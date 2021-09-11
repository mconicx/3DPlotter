using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Drawing;

namespace _3DPlotter.Rendering
{
    class Grid : RenderObject
    {
        private Size _sizeCells;
        private int _heightZ;

        public Size Size
        {
            get => _sizeCells; 
            set
            {
                _sizeCells = value;
                _UpdateVertexData();
            }
        }

        public int HeightZ
        {
            get => _heightZ;
            set
            {
                _heightZ = value;
                _UpdateVertexData();
            }
        }

        private void _UpdateVertexData()
        {
            _lVertexData.Clear();

            // 3D Axis
            _lVertexData.Add(-.25f); _lVertexData.Add(-.25f);               _lVertexData.Add(0f);
            _lVertexData.Add(_sizeCells.Width); _lVertexData.Add(-.25f);    _lVertexData.Add(0f);
            _lVertexData.Add(-.25f); _lVertexData.Add(-.25f);               _lVertexData.Add(0f);
            _lVertexData.Add(-.25f); _lVertexData.Add(_sizeCells.Height);   _lVertexData.Add(0f);
            _lVertexData.Add(-.25f); _lVertexData.Add(-.25f);               _lVertexData.Add(0f);
            _lVertexData.Add(-.25f); _lVertexData.Add(-.25f);               _lVertexData.Add(HeightZ);

            for (float x = 0; x < _sizeCells.Width + 1; x++)
            {
                for (float y = 0; y < _sizeCells.Height + 1; y++)
                {
                    _lVertexData.Add(0);                _lVertexData.Add(y);    _lVertexData.Add(0);
                    _lVertexData.Add(_sizeCells.Width); _lVertexData.Add(y);    _lVertexData.Add(0);
                }

                _lVertexData.Add(x); _lVertexData.Add(0);                       _lVertexData.Add(0);
                _lVertexData.Add(x); _lVertexData.Add(_sizeCells.Height);       _lVertexData.Add(0);
            }

            GL.BindBuffer(BufferTarget.ArrayBuffer, _iVertexBuffer);
            GL.BufferData(BufferTarget.ArrayBuffer, _lVertexData.Count * sizeof(float), _lVertexData.ToArray(), BufferUsageHint.DynamicDraw);
            GL.EnableVertexAttribArray(0);
            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), 0);
        }

        public Grid(PrimitiveType primitive_type, int shader_program_handle) : base(primitive_type, shader_program_handle)
        {
            AddUniformLocation(GL.GetUniformLocation(shader_program_handle, "uniMatP"));
            AddUniformLocation(GL.GetUniformLocation(shader_program_handle, "uniMatMV"));
        }

        public override void UpdateProjectionModelView(Matrix4 mat_projection, Matrix4 mat_modelview)
        {
            GL.UseProgram(_iShaderHandle);
            GL.UniformMatrix4(_lUniformLocations[0], false, ref mat_projection);
            GL.UniformMatrix4(_lUniformLocations[1], false, ref mat_modelview);
        }
    }
}
