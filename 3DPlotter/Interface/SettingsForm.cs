using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DPlotter.Interface
{
    public partial class SettingsForm : BorderlessForm
    {
        [Browsable(true)]
        [Category("Action")]
        [Description("Change settings")]
        public event EventHandler<SettingsChangedArgs> SettingsChanged;

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
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
        }

        private void btnApplySettings_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void trackBarMouse_Scroll(object sender, EventArgs e)
        {
            _ApplySettings();
        }

        private void trackBarFOV_Scroll(object sender, EventArgs e)
        {
            _ApplySettings();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            _ApplySettings();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            _ApplySettings();
        }

        private void _ApplySettings()
        {
            SettingsChanged?.Invoke(this, new SettingsChangedArgs()
            {
                MouseSensitivity = trackBarMouse.Value, 
                FOV = trackBarFOV.Value, 
                ReverseH = checkBox1.Checked,
                ReverseV = checkBox2.Checked
            });
        }
    }
}
