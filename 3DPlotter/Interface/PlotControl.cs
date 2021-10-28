using _3DPlotter.Projection;
using _3DPlotter.Rendering;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace _3DPlotter
{
    class PlotControl : GLControl
    {
        private bool _bControlLoaded = false;
        private bool _bUserMovedMouse = true;

        private int _iShaderProgramGrid = 0;
        private int _iShaderProgramPlot = 0;

        private PerspectiveCamera _fovCamera;

        private Grid _rGrid;
        private Plot _rPlot;

        public bool ShowGrid { private get; set; } = true;

        public int MouseSensitivity { get; set; } = 2;
        public float FOV
        { 
            set
            {
                _fovCamera.FOV = value * 10;
                _UpdateModelPointers();
            }
        }
        public bool ReverseH { get; set; }
        public bool ReverseV { get; set; }

        public PlotControl()
        {
            Load += PlotControl_Load;
            Resize += PlotControl_Resize;
            MouseDown += PlotControl_MouseDown;
            MouseUp += PlotControl_MouseUp;
            MouseMove += PlotControl_MouseMove;
            MouseWheel += PlotControl_MouseWheel;
            Paint += PlotControl_Paint;
        }

        private void PlotControl_Load(object sender, EventArgs e)
        {
            GL.ClearColor(Color4.Black);

            SetupShaderPrograms();

            // Grid model
            _rGrid = new Grid(PrimitiveType.Lines, _iShaderProgramGrid) { Size = new Size(5, 5) };

            // Plot model
            _rPlot = new Plot(PrimitiveType.Quads, _iShaderProgramPlot);

            // Camera
            _fovCamera = new PerspectiveCamera();
            _fovCamera.FOV = 70f;
            _fovCamera.vecTarget = new Vector3((float)_rGrid.Size.Width / 2, (float)_rGrid.Size.Height / 2, 0f);
            _fovCamera.AngleZ = 89.9f;
            _fovCamera.AngleX = -90f;
            _fovCamera.Zoom = 10f;
            _UpdateModelPointers();

            _bControlLoaded = true;
        }

        private void PlotControl_Resize(object sender, EventArgs e)
        {
            if (!_bControlLoaded)
                return;

            GL.Viewport(0, 0, Width, Height);

            _fovCamera.Aspect = (float)Width / Height;
            _UpdateModelPointers();
        }

        private void PlotControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Cursor.Hide();
                Cursor.Position = PointToScreen(new Point(Width / 2, Height / 2));
            }
        }

        private void PlotControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) Cursor.Show();
        }

        private void PlotControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (_bUserMovedMouse)
            {
                if (e.Button == MouseButtons.Left)
                {
                    float x = (Width / 2 - e.X) * ((float)MouseSensitivity / 10);
                    float z = (Height / 2 - e.Y) * ((float)MouseSensitivity / 10);

                    _fovCamera.AngleX += ReverseH ? -x : x;
                    _fovCamera.AngleZ += ReverseV ? z : -z;
                    _UpdateModelPointers();

                    _bUserMovedMouse = false;
                    Cursor.Position = PointToScreen(new Point(Width / 2, Height / 2));

                    Debug.WriteLine($"{_fovCamera.AngleZ} / {_fovCamera.AngleX}");
                }
            }
            else _bUserMovedMouse = true;
        }

        private void PlotControl_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 1) _fovCamera.Zoom--;
            else _fovCamera.Zoom++;

            _UpdateModelPointers();
        }

        private void PlotControl_Paint(object sender, PaintEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Enable(EnableCap.DepthTest);

            if (ShowGrid) _rGrid.Draw();
            _rPlot.Draw();

            Context.SwapBuffers();
        }

        private void _UpdateModelPointers()
        {
            _rGrid.UpdateProjectionModelView(_fovCamera.ProjectionMatrix, _fovCamera.ModelviewMatrix);
            _rPlot.UpdateProjectionModelView(_fovCamera.ProjectionMatrix, _fovCamera.ModelviewMatrix);

            Invalidate();
        }

        private void SetupShaderPrograms()
        {
            int iVertShaderGrid = GL.CreateShader(ShaderType.VertexShader);
            int iVertShaderPlot = GL.CreateShader(ShaderType.VertexShader);
            int iFragShaderGrid = GL.CreateShader(ShaderType.FragmentShader);
            int iFragShaderPlot = GL.CreateShader(ShaderType.FragmentShader);

            // RESX NAMES
            List<Tuple<int, string>> tplShaderCompilation = new List<Tuple<int, string>>()
            {
                new Tuple<int, string>(     iVertShaderGrid,    "_3DPlotter.Shaders.grid.vert"  ),
                new Tuple<int, string>(     iVertShaderPlot,    "_3DPlotter.Shaders.plot.vert"  ),
                new Tuple<int, string>(     iFragShaderGrid,    "_3DPlotter.Shaders.grid.frag"  ),
                new Tuple<int, string>(     iFragShaderPlot,    "_3DPlotter.Shaders.plot.frag"  )
            };

            Assembly assembly = Assembly.GetExecutingAssembly();

            foreach (Tuple<int, string> tpl in tplShaderCompilation)
            {
                using (Stream stream = assembly.GetManifestResourceStream(tpl.Item2))
                using (StreamReader reader = new StreamReader(stream))
                {
                    GL.ShaderSource(tpl.Item1, reader.ReadToEnd());
                }
            }

            GL.CompileShader(iVertShaderGrid);
            GL.CompileShader(iVertShaderPlot);
            GL.CompileShader(iFragShaderGrid);
            GL.CompileShader(iFragShaderPlot);

            // GRID
            _iShaderProgramGrid = GL.CreateProgram();
            GL.AttachShader(_iShaderProgramGrid, iVertShaderGrid);
            GL.AttachShader(_iShaderProgramGrid, iFragShaderGrid);
            GL.LinkProgram(_iShaderProgramGrid);

            // PLOT
            _iShaderProgramPlot = GL.CreateProgram();
            GL.AttachShader(_iShaderProgramPlot, iVertShaderPlot);
            GL.AttachShader(_iShaderProgramPlot, iFragShaderPlot);
            GL.LinkProgram(_iShaderProgramPlot);
        }

        public void UpdatePlotData(int width, int length, string math)
        {
            _rGrid.Size = new Size(width, length);
            _fovCamera.vecTarget = new Vector3((float)_rGrid.Size.Width / 2, (float)_rGrid.Size.Height / 2, 0f);

            _rPlot.UpdateData(width, length, _rGrid.HeightZ, math);

            _UpdateModelPointers();
        }

        public void SetGridHeight(int height)
        {
            _rGrid.HeightZ = height;
            Invalidate();
        }
    }
}
