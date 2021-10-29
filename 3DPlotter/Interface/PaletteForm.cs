using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DPlotter.Interface
{
    public partial class PaletteForm : BorderlessForm
    {
        [Browsable(true)]
        [Category("Action")]
        [Description("Apply new palette settings")]
        public event EventHandler<PaletteApplyArgs> NewPaletteApplied;

        private Color _min_color, _max_color;

        public PaletteForm()
        {
            InitializeComponent();
        }

        public void Show(Color min_color, Color max_color)
        {
            _min_color = min_color;
            _max_color = max_color;
            Show();
        }

        private void PaletteForm_Load(object sender, EventArgs e)
        {
            // EXIT BUTTON
            btnMenuExit.Paint += new PaintEventHandler(delegate (object s, PaintEventArgs a) // Draw cross
            {
                Button this_button = (Button)s;
                Pen p = new Pen(new SolidBrush(Color.FromArgb(255, 50, 50, 50)), 2.5f);
                a.Graphics.DrawLine(p, 5, 5, this_button.Width - 5, this_button.Height - 5);
                a.Graphics.DrawLine(p, this_button.Width - 5, 5, 5, this_button.Height - 5);
            });
            btnMenuExit.Click += new EventHandler(delegate (object s, EventArgs a)
            {
                Hide();
            });

            pnlColorRange.Paint += new PaintEventHandler(delegate (object s, PaintEventArgs a)
            {
                a.Graphics.FillRectangle(new LinearGradientBrush(

                    new Rectangle(0, 0, Width, Height),
                    _min_color,
                    _max_color, LinearGradientMode.Horizontal
                ), new Rectangle(0, 0, Width, Height));
            });
            pnlColorRange.Invalidate();
        }

        private void btnSetMin_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _min_color = dialog.Color;
                pnlColorRange.Invalidate();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void ApplySettings()
        {
            NewPaletteApplied?.Invoke(null, new PaletteApplyArgs() { MinColor = _min_color, MaxColor = _max_color });
        }

        private void btnApplySettings_Click(object sender, EventArgs e)
        {
            ApplySettings();
        }

        private void btnApplySettingsAndClose_Click(object sender, EventArgs e)
        {
            ApplySettings();
            Hide();
        }

        private void btnSetMax_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _max_color = dialog.Color;
                pnlColorRange.Invalidate();
            }
        }
    }
}
