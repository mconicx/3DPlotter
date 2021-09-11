using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Data;

namespace _3DPlotter.Rendering
{
    class Plot : RenderObject
    {
        public Plot(PrimitiveType primitive_type, int shader_program_handle) : base(primitive_type, shader_program_handle)
        {
            AddUniformLocation(GL.GetUniformLocation(shader_program_handle, "uniMatP"));
            AddUniformLocation(GL.GetUniformLocation(shader_program_handle, "uniMatMV"));
            AddUniformLocation(GL.GetUniformLocation(shader_program_handle, "uniIHeight"));
        }

        public override void UpdateProjectionModelView(Matrix4 mat_projection, Matrix4 mat_modelview)
        {
            GL.UseProgram(_iShaderHandle);
            GL.UniformMatrix4(_lUniformLocations[0], false, ref mat_projection);
            GL.UniformMatrix4(_lUniformLocations[1], false, ref mat_modelview);
        }

        public void UpdateData(int width, int length, int height, string math)
        {
            _lVertexData.Clear();

            float lowest_z = 5f, highest_z = .5f;

            // Parse data
            for (int x = 0; x < width - 1; x++)
            {
                for (int y = 0; y < length - 1; y++)
                {
                    float this_z = getZ(math, x, y);

                    if (this_z > highest_z) highest_z = this_z;
                    if (this_z < lowest_z) lowest_z = this_z;

                    _lVertexData.Add(x); _lVertexData.Add(y);           _lVertexData.Add(this_z);
                    _lVertexData.Add(x); _lVertexData.Add(y + 1);       _lVertexData.Add(getZ(math, x, y + 1));
                    _lVertexData.Add(x + 1); _lVertexData.Add(y + 1);   _lVertexData.Add(getZ(math, x + 1, y + 1));
                    _lVertexData.Add(x + 1); _lVertexData.Add(y);       _lVertexData.Add(getZ(math, x + 1, y));
                }
            }

            // Adjust height
            if (lowest_z != highest_z)
            {
                for (int i = 2; i < _lVertexData.Count; i += 3)
                    _lVertexData[i] = _lVertexData[i].Map(lowest_z, highest_z, .5f, height);
            }

            GL.UseProgram(_iShaderHandle);
            GL.Uniform1(_lUniformLocations[2], height);

            GL.BindBuffer(BufferTarget.ArrayBuffer, _iVertexBuffer);
            GL.BufferData(BufferTarget.ArrayBuffer, _lVertexData.Count * sizeof(float), _lVertexData.ToArray(), BufferUsageHint.DynamicDraw);
            GL.EnableVertexAttribArray(1);
            GL.VertexAttribPointer(1, 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), 0);
        }

        private float getZ(string math, int x, int y)
        {
            try
            {
                DataTable table = new DataTable();
                table.Columns.Add("expression", typeof(string), math.Replace("x", $"{x}").Replace("y", $"{y}"));
                DataRow row = table.NewRow(); table.Rows.Add(row);
                return (float)double.Parse((string)row["expression"]);
            }
            catch (Exception) { return 0f; }
        }
    }

    public static class ExtensionMethods
    {
        public static float Map(this float value, float fromSource, float toSource, float fromTarget, float toTarget)
        {
            return (value - fromSource) / (toSource - fromSource) * (toTarget - fromTarget) + fromTarget;
        }
    }
}
