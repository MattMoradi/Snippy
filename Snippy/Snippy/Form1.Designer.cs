namespace Snippy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CaptureScrn = new System.Windows.Forms.PictureBox();
            this.btnCapture = new MetroFramework.Controls.MetroButton();
            this.btnRecord = new MetroFramework.Controls.MetroButton();
            this.FileMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStopRecord = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.CaptureScrn)).BeginInit();
            this.FileMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // CaptureScrn
            // 
            this.CaptureScrn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CaptureScrn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CaptureScrn.Location = new System.Drawing.Point(17, 106);
            this.CaptureScrn.Margin = new System.Windows.Forms.Padding(4);
            this.CaptureScrn.Name = "CaptureScrn";
            this.CaptureScrn.Size = new System.Drawing.Size(1120, 660);
            this.CaptureScrn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CaptureScrn.TabIndex = 2;
            this.CaptureScrn.TabStop = false;
            // 
            // btnCapture
            // 
            this.btnCapture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapture.Highlight = true;
            this.btnCapture.Location = new System.Drawing.Point(1150, 106);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(90, 32);
            this.btnCapture.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnCapture.TabIndex = 5;
            this.btnCapture.Text = "Capture";
            this.btnCapture.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCapture.UseSelectable = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecord.Highlight = true;
            this.btnRecord.Location = new System.Drawing.Point(1150, 144);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(90, 29);
            this.btnRecord.Style = MetroFramework.MetroColorStyle.Red;
            this.btnRecord.TabIndex = 6;
            this.btnRecord.Text = "Record";
            this.btnRecord.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRecord.UseSelectable = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // FileMenu
            // 
            this.FileMenu.BackColor = System.Drawing.Color.Black;
            this.FileMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.FileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.FileMenu.Location = new System.Drawing.Point(20, 60);
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(1223, 27);
            this.FileMenu.TabIndex = 7;
            this.FileMenu.Text = "File Menu";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.toolStripButton1.ForeColor = System.Drawing.Color.Lime;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(46, 24);
            this.toolStripButton1.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // btnStopRecord
            // 
            this.btnStopRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopRecord.Highlight = true;
            this.btnStopRecord.Location = new System.Drawing.Point(1145, 179);
            this.btnStopRecord.Name = "btnStopRecord";
            this.btnStopRecord.Size = new System.Drawing.Size(101, 35);
            this.btnStopRecord.Style = MetroFramework.MetroColorStyle.Red;
            this.btnStopRecord.TabIndex = 8;
            this.btnStopRecord.Text = "Stop Record";
            this.btnStopRecord.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnStopRecord.UseSelectable = true;
            this.btnStopRecord.Click += new System.EventHandler(this.btnStopRecord_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 782);
            this.Controls.Add(this.btnStopRecord);
            this.Controls.Add(this.FileMenu);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.CaptureScrn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Snippy";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CaptureScrn)).EndInit();
            this.FileMenu.ResumeLayout(false);
            this.FileMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox CaptureScrn;
        private MetroFramework.Controls.MetroButton btnCapture;
        private MetroFramework.Controls.MetroButton btnRecord;
        private System.Windows.Forms.ToolStrip FileMenu;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private MetroFramework.Controls.MetroButton btnStopRecord;
    }
}

