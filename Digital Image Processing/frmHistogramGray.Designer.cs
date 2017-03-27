namespace Digital_Image_Processing
{
    partial class frmHistogramGray
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
            this.panelGray = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelGray.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Black;
            this.panelGray.Controls.Add(this.label1);
            this.panelGray.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGray.Location = new System.Drawing.Point(0, 0);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(256, 295);
            this.panelGray.TabIndex = 0;
            this.panelGray.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGray_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "GRAY";
            // 
            // frmHistogramGray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 295);
            this.Controls.Add(this.panelGray);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHistogramGray";
            this.Text = "Histogram Gray";
            this.panelGray.ResumeLayout(false);
            this.panelGray.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Label label1;
    }
}