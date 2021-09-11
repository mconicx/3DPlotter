using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace _3DPlotter
{
    public partial class BorderlessForm : Form
    {
        [Flags]
        private enum MouseOptions : byte
        {
            NULL = 0,
            Top = 1,
            Left = 2,
            Right = 4,
            Bottom = 8,
            Drag = 16
        };
        private MouseOptions _bMouseOptions = MouseOptions.NULL;

        private Rectangle _rectWindowBeforeResizingBegun;

        private Point _pMouseDragOrigin;

        public BorderlessForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void _UpdateResizeCursor(Point p)
        {
            if (_bMouseOptions.HasFlag(MouseOptions.Drag))
                Cursor.Current = Cursors.SizeAll;
            else
            {
                bool top = p.Y <= Padding.Top;
                bool left = p.X <= Padding.Left;
                bool right = p.X >= Width - Padding.Right;
                bool bottom = p.Y >= Height - Padding.Bottom;

                if (top)
                {
                    if (left) Cursor.Current = Cursors.SizeNWSE;
                    else if (right) Cursor.Current = Cursors.SizeNESW;
                    else Cursor.Current = Cursors.SizeNS;
                }
                else if (bottom)
                {
                    if (left) Cursor.Current = Cursors.SizeNESW;
                    else if (right) Cursor.Current = Cursors.SizeNWSE;
                    else Cursor.Current = Cursors.SizeNS;
                }
                else if (left || right)
                    Cursor.Current = Cursors.SizeWE;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea; // Prevent maximizing window from covering the taskbar.
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (WindowState != FormWindowState.Normal || e.Button != MouseButtons.Left)
                return;

            _bMouseOptions = MouseOptions.NULL; // Reset

            if (new Rectangle(Padding.Left, Padding.Top, Width - (Padding.Right * 2), 30).Contains(e.Location))
            {
                _bMouseOptions = MouseOptions.Drag;
                _pMouseDragOrigin = e.Location;
            }
            else
            {
                if (e.Y <= Padding.Top)
                    _bMouseOptions |= MouseOptions.Top;
                if (e.X <= Padding.Left)
                    _bMouseOptions |= MouseOptions.Left;
                if (e.X >= Width - Padding.Right)
                    _bMouseOptions |= MouseOptions.Right;
                if (e.Y >= Height - Padding.Bottom)
                    _bMouseOptions |= MouseOptions.Bottom;

                _rectWindowBeforeResizingBegun = new Rectangle(Location, Size);
            }

            _UpdateResizeCursor(e.Location);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _bMouseOptions = MouseOptions.NULL;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (WindowState != FormWindowState.Normal)
                return;

            if (e.Button == MouseButtons.None)
            {
                _UpdateResizeCursor(e.Location);
                return;
            }

            if (_bMouseOptions.HasFlag(MouseOptions.Drag))
                Location = PointToScreen(new Point(e.X - _pMouseDragOrigin.X, e.Y - _pMouseDragOrigin.Y));
            else
            {
                if (_bMouseOptions.HasFlag(MouseOptions.Top))
                {
                    int iMovedTop = PointToScreen(e.Location).Y;
                    int iNewHeight = _rectWindowBeforeResizingBegun.Height - (iMovedTop - _rectWindowBeforeResizingBegun.Top);

                    if (iNewHeight > MinimumSize.Height)
                        Top = iMovedTop;

                    Height = iNewHeight;
                }
                if (_bMouseOptions.HasFlag(MouseOptions.Left))
                {
                    int iMovedLeft = PointToScreen(e.Location).X;
                    int iNewWidth = _rectWindowBeforeResizingBegun.Width - (iMovedLeft - _rectWindowBeforeResizingBegun.Left);

                    if (iNewWidth > MinimumSize.Width)
                        Left = iMovedLeft;

                    Width = iNewWidth;
                }
                if (_bMouseOptions.HasFlag(MouseOptions.Right)) Width = PointToScreen(e.Location).X - Location.X;
                if (_bMouseOptions.HasFlag(MouseOptions.Bottom)) Height = PointToScreen(e.Location).Y - Location.Y;
            }
        }

        private void Form1_OnResize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Form1_OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Menu
            g.FillRectangle(new LinearGradientBrush(

                new Rectangle(0, 0, Width, 30),
                Color.FromArgb(255, 25, 150, 255),
                Color.FromArgb(255, 235, 235, 235), LinearGradientMode.Horizontal
            ), new Rectangle(0, 0, Width, 30));

            g.DrawString(Text, Font, new SolidBrush(Color.White), 10, 6);

            g.DrawLines(new Pen(Color.Black, 1.0f), new Point[]
            {
                new Point(0, 0), new Point(0, Height - 1), 
                new Point(0, Height - 1), new Point(Width - 1, Height - 1), 
                new Point(Width - 1, Height - 1), new Point(Width - 1, 0), 
                new Point(Width - 1, 0), new Point(0, 0)
            });
        }
    }
}
