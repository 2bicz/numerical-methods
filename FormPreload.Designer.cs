namespace numerical_methods_Newton
{
    partial class FormPreload
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPreload));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTopLoadBar = new System.Windows.Forms.Panel();
            this.panelBottomLoadBar = new System.Windows.Forms.Panel();
            this.panelProgressTop = new System.Windows.Forms.Panel();
            this.panelProgressBottom = new System.Windows.Forms.Panel();
            this.timerLoadingScreen = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTopLoadBar.SuspendLayout();
            this.panelBottomLoadBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::numerical_methods_Newton.Properties.Resources.PreloadLogo;
            this.pictureBox1.Location = new System.Drawing.Point(67, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 413);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelTopLoadBar
            // 
            this.panelTopLoadBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.panelTopLoadBar.Controls.Add(this.panelProgressTop);
            this.panelTopLoadBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopLoadBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopLoadBar.Name = "panelTopLoadBar";
            this.panelTopLoadBar.Size = new System.Drawing.Size(700, 22);
            this.panelTopLoadBar.TabIndex = 1;
            // 
            // panelBottomLoadBar
            // 
            this.panelBottomLoadBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.panelBottomLoadBar.Controls.Add(this.panelProgressBottom);
            this.panelBottomLoadBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomLoadBar.Location = new System.Drawing.Point(0, 338);
            this.panelBottomLoadBar.Name = "panelBottomLoadBar";
            this.panelBottomLoadBar.Size = new System.Drawing.Size(700, 22);
            this.panelBottomLoadBar.TabIndex = 2;
            // 
            // panelProgressTop
            // 
            this.panelProgressTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(226)))), ((int)(((byte)(209)))));
            this.panelProgressTop.Location = new System.Drawing.Point(0, 0);
            this.panelProgressTop.Name = "panelProgressTop";
            this.panelProgressTop.Size = new System.Drawing.Size(26, 22);
            this.panelProgressTop.TabIndex = 3;
            // 
            // panelProgressBottom
            // 
            this.panelProgressBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(226)))), ((int)(((byte)(209)))));
            this.panelProgressBottom.Location = new System.Drawing.Point(676, 0);
            this.panelProgressBottom.Name = "panelProgressBottom";
            this.panelProgressBottom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelProgressBottom.Size = new System.Drawing.Size(26, 22);
            this.panelProgressBottom.TabIndex = 4;
            // 
            // timerLoadingScreen
            // 
            this.timerLoadingScreen.Enabled = true;
            this.timerLoadingScreen.Interval = 15;
            this.timerLoadingScreen.Tick += new System.EventHandler(this.timerLoadingScreen_Tick);
            // 
            // FormPreload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.panelTopLoadBar);
            this.Controls.Add(this.panelBottomLoadBar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPreload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTopLoadBar.ResumeLayout(false);
            this.panelBottomLoadBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTopLoadBar;
        private System.Windows.Forms.Panel panelBottomLoadBar;
        private System.Windows.Forms.Panel panelProgressTop;
        private System.Windows.Forms.Panel panelProgressBottom;
        private System.Windows.Forms.Timer timerLoadingScreen;
    }
}