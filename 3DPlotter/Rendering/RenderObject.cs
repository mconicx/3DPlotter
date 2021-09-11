using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Collections.Generic;
using System.Linq;

namespace _3DPlotter.Rendering
{
    public abstract class RenderObject
    {
        private int _iVBO;

        protected PrimitiveType _tPrimitive = 0;

        protected int _iShaderHandle = 0;
        protected int _iVertexBuffer { get => _iVBO; }
        protected List<float> _lVertexData = new List<float>();
        protected List<int> _lUniformLocations { get; private set; } = new List<int>();

        public RenderObject(PrimitiveType primitive_type, int shader_program_handle)
        {
            GL.GenBuffers(1, out _iVBO);
            _tPrimitive = primitive_type;
            _iShaderHandle = shader_program_handle;
        }

        public void Draw()
        {
            GL.UseProgram(_iShaderHandle);
            GL.DrawArrays(_tPrimitive, 0, _lVertexData.Count() / 3);
        }

        protected void AddUniformLocation(int uni_location)
        {
            _lUniformLocations.Add(uni_location);
        }

        public virtual void UpdateProjectionModelView(Matrix4 mat_projection, Matrix4 mat_modelview) {}
    }
}
