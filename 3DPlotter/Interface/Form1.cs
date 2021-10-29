using _3DPlotter.Interface;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace _3DPlotter
{
    public partial class Form1 : BorderlessForm
    {
        private PlotControl _plotControl;

        private SettingsForm _formSettings;
        private PaletteForm _formPalette;

        private string _szLastSavedZ;
        private int _iLastSavedX, _iLastSavedY, _iLastSavedHeight;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitMenuButtons();
            SetupSettingsPanel();

            // 3D Plot Control (GLControl)
            _plotControl = new PlotControl() { Dock = DockStyle.Fill };
            splitContainer1.Panel2.Controls.Add(_plotControl);

            _plotControl.SetGridHeight(trackBarHeight.Value);
            _ApplySettings();

            _formSettings = new SettingsForm();
            _formPalette = new PaletteForm();
        }

        private void InitMenuButtons()
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
                Application.Exit();
            });

            // MAXIMIZE BUTTON
            btnMenuMaximize.Paint += new PaintEventHandler(delegate (object s, PaintEventArgs a) // Draw rectangles
            {
                Button this_button = (Button)s;
                Pen p = new Pen(new SolidBrush(Color.FromArgb(255, 50, 50, 50)), 2.0f);
                a.Graphics.DrawRectangle(p, 6, 3, this_button.Width - 9, this_button.Height - 9);
                a.Graphics.FillRectangle(new SolidBrush(this_button.BackColor), 3, 6, this_button.Width - 9, this_button.Height - 9);
                a.Graphics.DrawRectangle(p, 3, 6, this_button.Width - 9, this_button.Height - 9);
            });
            btnMenuMaximize.Click += new EventHandler(delegate (object s, EventArgs a)
            {
                WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
            });

            // MINIMIZE BUTTON
            btnMenuMinimize.Paint += new PaintEventHandler(delegate (object s, PaintEventArgs a) // Draw line
            {
                Button this_button = (Button)s;
                a.Graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(255, 50, 50, 50)), 2.0f), 5, this_button.Height - 5, this_button.Width - 5, this_button.Height - 5);
            });
            btnMenuMinimize.Click += new EventHandler(delegate (object s, EventArgs a)
            {
                WindowState = FormWindowState.Minimized;
            });
        }

        private void SetupSettingsPanel()
        {
            // Settings panel
            gbSettings.VisibleChanged += new EventHandler(delegate (object s, EventArgs a) // Expand/Collapse splitContainer's left panel
            {
                GroupBox this_panel = (GroupBox)s;
                if (this_panel.Visible)
                {
                    btnShowLeftPanel.BackgroundImage = Properties.Resources.btn_arrow_r;
                    splitContainer1.SplitterDistance = 200;
                    gbSettings.Visible = true;
                }
                else
                {
                    btnShowLeftPanel.BackgroundImage = Properties.Resources.btn_arrow;
                    splitContainer1.SplitterDistance = 45;
                    gbSettings.Visible = false;
                }
            });

            // Expand/Collapse Settings button
            btnShowLeftPanel.Click += new EventHandler(delegate (object s, EventArgs a)
            {
                gbSettings.Visible = !gbSettings.Visible;
            });
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            _ApplySettings();
        }

        private void tbPlotZ_TextChanged(object sender, EventArgs e)
        {
            TextBox this_tb = (TextBox)sender;

            if (this_tb.Text != _szLastSavedZ) this_tb.BackColor = Color.FromArgb(255, 150, 150, 255);
            else this_tb.BackColor = BackColor;
        }

        private void nudX_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown this_nud = (NumericUpDown)sender;
            if (this_nud.Value != _iLastSavedX) this_nud.BackColor = Color.FromArgb(255, 150, 150, 255);
            else this_nud.BackColor = BackColor;
        }

        private void nudY_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown this_nud = (NumericUpDown)sender;
            if (this_nud.Value != _iLastSavedY) this_nud.BackColor = Color.FromArgb(255, 150, 150, 255);
            else this_nud.BackColor = BackColor;
        }

        private void cbGrid_CheckedChanged(object sender, EventArgs e)
        {
            _plotControl.ShowGrid = ((CheckBox)sender).Checked;
            _plotControl.Invalidate();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Enabled = false;
            _formSettings.Show();
            _formSettings.VisibleChanged += new EventHandler(delegate (object s, EventArgs a)
            {
                Enabled = !((SettingsForm)s).Visible;
            });
            _formSettings.SettingsChanged += new EventHandler<SettingsChangedArgs>(delegate (object s, SettingsChangedArgs a)
            {
                _plotControl.MouseSensitivity = a.MouseSensitivity;
                _plotControl.FOV = a.FOV;
                _plotControl.ReverseH = a.ReverseH;
                _plotControl.ReverseV = a.ReverseV;
            });
        }

        private void btnPalette_Click(object sender, EventArgs e)
        {
            Enabled = false;
            _formPalette.Show((Color)_plotControl.MinPaletteColor, (Color)_plotControl.MaxPaletteColor);
            _formPalette.VisibleChanged += new EventHandler(delegate (object s, EventArgs a)
            {
                Enabled = !((PaletteForm)s).Visible;
            });
            _formPalette.NewPaletteApplied += new EventHandler<PaletteApplyArgs>(delegate (object s, PaletteApplyArgs a)
            {
                _plotControl.MinPaletteColor = a.MinColor;
                _plotControl.MaxPaletteColor = a.MaxColor;
                _plotControl.Invalidate();
            });
        }

        private void trackBarHeight_Scroll(object sender, EventArgs e)
        {
            TrackBar this_trackbar = (TrackBar)sender;
            if (this_trackbar.Value != _iLastSavedHeight) this_trackbar.BackColor = Color.FromArgb(255, 150, 150, 255);
            else this_trackbar.BackColor = BackColor;

            _plotControl.SetGridHeight(trackBarHeight.Value);
        }

        private void _ApplySettings()
        {
            if (
                    tbPlotZ.Text == _szLastSavedZ &&
                    nudX.Value == _iLastSavedX &&
                    nudY.Value == _iLastSavedY &&
                    trackBarHeight.Value == _iLastSavedHeight
               )
                return;

            if (Regex.IsMatch(tbPlotZ.Text, @"[^xy\s.+\-*\/()%0-9]"))
            {
                MessageBox.Show("Invalid conditional Z data. Must only contain the characters 'x', 'y', whole numbers, arithmetic operators and white space.",
                    "Parsing error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            tbPlotZ.BackColor = 
            nudX.BackColor = 
            nudY.BackColor = 
            trackBarHeight.BackColor = BackColor;

            _szLastSavedZ = tbPlotZ.Text;
            _iLastSavedX = (int)nudX.Value;
            _iLastSavedY = (int)nudY.Value;
            _iLastSavedHeight = trackBarHeight.Value;

            _plotControl.UpdatePlotData((int)nudX.Value, (int)nudY.Value, tbPlotZ.Text);
        }
    }
}
