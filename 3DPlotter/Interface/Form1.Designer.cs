
namespace _3DPlotter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMenuMinimize = new System.Windows.Forms.Button();
            this.btnMenuMaximize = new System.Windows.Forms.Button();
            this.btnMenuExit = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbGrid = new System.Windows.Forms.CheckBox();
            this.gbGenerate = new System.Windows.Forms.GroupBox();
            this.btnPalette = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.trackBarHeight = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPlotZ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.btnShowLeftPanel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbGenerate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenuMinimize
            // 
            this.btnMenuMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenuMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuMinimize.FlatAppearance.BorderSize = 0;
            this.btnMenuMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMenuMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnMenuMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuMinimize.Location = new System.Drawing.Point(715, 5);
            this.btnMenuMinimize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMenuMinimize.Name = "btnMenuMinimize";
            this.btnMenuMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMenuMinimize.TabIndex = 10;
            this.btnMenuMinimize.UseVisualStyleBackColor = false;
            // 
            // btnMenuMaximize
            // 
            this.btnMenuMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenuMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuMaximize.FlatAppearance.BorderSize = 0;
            this.btnMenuMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMenuMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnMenuMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuMaximize.Location = new System.Drawing.Point(743, 5);
            this.btnMenuMaximize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMenuMaximize.Name = "btnMenuMaximize";
            this.btnMenuMaximize.Size = new System.Drawing.Size(20, 20);
            this.btnMenuMaximize.TabIndex = 9;
            this.btnMenuMaximize.UseVisualStyleBackColor = false;
            // 
            // btnMenuExit
            // 
            this.btnMenuExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenuExit.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuExit.FlatAppearance.BorderSize = 0;
            this.btnMenuExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMenuExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMenuExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuExit.Location = new System.Drawing.Point(771, 5);
            this.btnMenuExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMenuExit.Name = "btnMenuExit";
            this.btnMenuExit.Size = new System.Drawing.Size(20, 20);
            this.btnMenuExit.TabIndex = 8;
            this.btnMenuExit.UseVisualStyleBackColor = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(8, 36);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbSettings);
            this.splitContainer1.Panel1.Controls.Add(this.btnShowLeftPanel);
            this.splitContainer1.Size = new System.Drawing.Size(783, 556);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 11;
            // 
            // gbSettings
            // 
            this.gbSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSettings.Controls.Add(this.btnSettings);
            this.gbSettings.Controls.Add(this.groupBox1);
            this.gbSettings.Controls.Add(this.gbGenerate);
            this.gbSettings.Location = new System.Drawing.Point(3, 40);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(189, 529);
            this.gbSettings.TabIndex = 13;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Quick settings";
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BackgroundImage = global::_3DPlotter.Properties.Resources.btn_settings;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Location = new System.Drawing.Point(7, 282);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(30, 30);
            this.btnSettings.TabIndex = 15;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbGrid);
            this.groupBox1.Location = new System.Drawing.Point(6, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 55);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grid";
            // 
            // cbGrid
            // 
            this.cbGrid.AutoSize = true;
            this.cbGrid.Checked = true;
            this.cbGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGrid.Location = new System.Drawing.Point(9, 22);
            this.cbGrid.Name = "cbGrid";
            this.cbGrid.Size = new System.Drawing.Size(83, 21);
            this.cbGrid.TabIndex = 0;
            this.cbGrid.Text = "Enabled";
            this.cbGrid.UseVisualStyleBackColor = true;
            this.cbGrid.CheckedChanged += new System.EventHandler(this.cbGrid_CheckedChanged);
            // 
            // gbGenerate
            // 
            this.gbGenerate.Controls.Add(this.btnPalette);
            this.gbGenerate.Controls.Add(this.btnApply);
            this.gbGenerate.Controls.Add(this.trackBarHeight);
            this.gbGenerate.Controls.Add(this.label2);
            this.gbGenerate.Controls.Add(this.label5);
            this.gbGenerate.Controls.Add(this.tbPlotZ);
            this.gbGenerate.Controls.Add(this.label1);
            this.gbGenerate.Controls.Add(this.nudY);
            this.gbGenerate.Controls.Add(this.label4);
            this.gbGenerate.Controls.Add(this.nudX);
            this.gbGenerate.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGenerate.Location = new System.Drawing.Point(6, 22);
            this.gbGenerate.Name = "gbGenerate";
            this.gbGenerate.Size = new System.Drawing.Size(177, 193);
            this.gbGenerate.TabIndex = 13;
            this.gbGenerate.TabStop = false;
            this.gbGenerate.Text = "Plot Generation";
            // 
            // btnPalette
            // 
            this.btnPalette.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPalette.BackColor = System.Drawing.Color.Transparent;
            this.btnPalette.BackgroundImage = global::_3DPlotter.Properties.Resources.btn_palette;
            this.btnPalette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPalette.FlatAppearance.BorderSize = 0;
            this.btnPalette.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPalette.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnPalette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPalette.Location = new System.Drawing.Point(7, 157);
            this.btnPalette.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPalette.Name = "btnPalette";
            this.btnPalette.Size = new System.Drawing.Size(30, 30);
            this.btnPalette.TabIndex = 15;
            this.btnPalette.UseVisualStyleBackColor = false;
            this.btnPalette.Click += new System.EventHandler(this.btnPalette_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.BackColor = System.Drawing.Color.Transparent;
            this.btnApply.BackgroundImage = global::_3DPlotter.Properties.Resources.btn_apply;
            this.btnApply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Location = new System.Drawing.Point(140, 157);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(30, 30);
            this.btnApply.TabIndex = 14;
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // trackBarHeight
            // 
            this.trackBarHeight.BackColor = System.Drawing.Color.White;
            this.trackBarHeight.LargeChange = 1;
            this.trackBarHeight.Location = new System.Drawing.Point(61, 107);
            this.trackBarHeight.Maximum = 50;
            this.trackBarHeight.Minimum = 1;
            this.trackBarHeight.Name = "trackBarHeight";
            this.trackBarHeight.Size = new System.Drawing.Size(110, 45);
            this.trackBarHeight.TabIndex = 13;
            this.trackBarHeight.TickFrequency = 5;
            this.trackBarHeight.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarHeight.Value = 5;
            this.trackBarHeight.Scroll += new System.EventHandler(this.trackBarHeight_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "Height";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "Max Y";
            // 
            // tbPlotZ
            // 
            this.tbPlotZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPlotZ.BackColor = System.Drawing.Color.White;
            this.tbPlotZ.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlotZ.ForeColor = System.Drawing.Color.Black;
            this.tbPlotZ.Location = new System.Drawing.Point(48, 21);
            this.tbPlotZ.Name = "tbPlotZ";
            this.tbPlotZ.Size = new System.Drawing.Size(123, 23);
            this.tbPlotZ.TabIndex = 1;
            this.tbPlotZ.Text = "x*x - y*y";
            this.tbPlotZ.TextChanged += new System.EventHandler(this.tbPlotZ_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Z =";
            // 
            // nudY
            // 
            this.nudY.BackColor = System.Drawing.Color.White;
            this.nudY.ForeColor = System.Drawing.Color.Black;
            this.nudY.Location = new System.Drawing.Point(62, 80);
            this.nudY.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudY.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(80, 22);
            this.nudY.TabIndex = 9;
            this.nudY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudY.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudY.ValueChanged += new System.EventHandler(this.nudY_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Max X";
            // 
            // nudX
            // 
            this.nudX.BackColor = System.Drawing.Color.White;
            this.nudX.ForeColor = System.Drawing.Color.Black;
            this.nudX.Location = new System.Drawing.Point(62, 50);
            this.nudX.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudX.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(80, 22);
            this.nudX.TabIndex = 7;
            this.nudX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudX.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudX.ValueChanged += new System.EventHandler(this.nudX_ValueChanged);
            // 
            // btnShowLeftPanel
            // 
            this.btnShowLeftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowLeftPanel.BackColor = System.Drawing.Color.Transparent;
            this.btnShowLeftPanel.BackgroundImage = global::_3DPlotter.Properties.Resources.btn_arrow_r;
            this.btnShowLeftPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowLeftPanel.FlatAppearance.BorderSize = 0;
            this.btnShowLeftPanel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnShowLeftPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnShowLeftPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowLeftPanel.Location = new System.Drawing.Point(162, 3);
            this.btnShowLeftPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnShowLeftPanel.Name = "btnShowLeftPanel";
            this.btnShowLeftPanel.Size = new System.Drawing.Size(30, 30);
            this.btnShowLeftPanel.TabIndex = 12;
            this.btnShowLeftPanel.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnMenuMinimize);
            this.Controls.Add(this.btnMenuMaximize);
            this.Controls.Add(this.btnMenuExit);
            this.Name = "Form1";
            this.Text = "3DPlotter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbSettings.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbGenerate.ResumeLayout(false);
            this.gbGenerate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenuMinimize;
        private System.Windows.Forms.Button btnMenuMaximize;
        private System.Windows.Forms.Button btnMenuExit;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnShowLeftPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPlotZ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.GroupBox gbGenerate;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.TrackBar trackBarHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbGrid;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnPalette;
    }
}

