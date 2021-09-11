
namespace _3DPlotter.Interface
{
    partial class SettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarMouse = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarFOV = new System.Windows.Forms.TrackBar();
            this.btnApplySettings = new System.Windows.Forms.Button();
            this.btnMenuExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFOV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sensitivity";
            // 
            // trackBarMouse
            // 
            this.trackBarMouse.LargeChange = 1;
            this.trackBarMouse.Location = new System.Drawing.Point(9, 36);
            this.trackBarMouse.Maximum = 5;
            this.trackBarMouse.Minimum = 1;
            this.trackBarMouse.Name = "trackBarMouse";
            this.trackBarMouse.Size = new System.Drawing.Size(334, 45);
            this.trackBarMouse.TabIndex = 1;
            this.trackBarMouse.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarMouse.Value = 2;
            this.trackBarMouse.Scroll += new System.EventHandler(this.trackBarMouse_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Field of view";
            // 
            // trackBarFOV
            // 
            this.trackBarFOV.LargeChange = 1;
            this.trackBarFOV.Location = new System.Drawing.Point(8, 143);
            this.trackBarFOV.Maximum = 12;
            this.trackBarFOV.Minimum = 5;
            this.trackBarFOV.Name = "trackBarFOV";
            this.trackBarFOV.Size = new System.Drawing.Size(483, 45);
            this.trackBarFOV.TabIndex = 3;
            this.trackBarFOV.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarFOV.Value = 9;
            this.trackBarFOV.Scroll += new System.EventHandler(this.trackBarFOV_Scroll);
            // 
            // btnApplySettings
            // 
            this.btnApplySettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplySettings.BackColor = System.Drawing.Color.White;
            this.btnApplySettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnApplySettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnApplySettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnApplySettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplySettings.Location = new System.Drawing.Point(357, 262);
            this.btnApplySettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnApplySettings.Name = "btnApplySettings";
            this.btnApplySettings.Size = new System.Drawing.Size(134, 25);
            this.btnApplySettings.TabIndex = 15;
            this.btnApplySettings.Text = "OK";
            this.btnApplySettings.UseVisualStyleBackColor = false;
            this.btnApplySettings.Click += new System.EventHandler(this.btnApplySettings_Click);
            // 
            // btnMenuExit
            // 
            this.btnMenuExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenuExit.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuExit.FlatAppearance.BorderSize = 0;
            this.btnMenuExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMenuExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMenuExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuExit.Location = new System.Drawing.Point(471, 5);
            this.btnMenuExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMenuExit.Name = "btnMenuExit";
            this.btnMenuExit.Size = new System.Drawing.Size(20, 20);
            this.btnMenuExit.TabIndex = 16;
            this.btnMenuExit.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trackBarMouse);
            this.groupBox1.Location = new System.Drawing.Point(8, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 92);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mouse";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(349, 18);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 18);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Reverse H";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(349, 42);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(89, 18);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Reverse V";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMenuExit);
            this.Controls.Add(this.trackBarFOV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnApplySettings);
            this.MaximumSize = new System.Drawing.Size(500, 300);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFOV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarMouse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarFOV;
        private System.Windows.Forms.Button btnApplySettings;
        private System.Windows.Forms.Button btnMenuExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}