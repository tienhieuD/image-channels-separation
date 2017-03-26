namespace Digital_Image_Processing
{
    partial class frmHistogram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistogram));
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelRed.SuspendLayout();
            this.panelBlue.SuspendLayout();
            this.panelGreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Snow;
            this.panelRed.Controls.Add(this.label1);
            this.panelRed.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRed.Location = new System.Drawing.Point(0, 0);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(256, 320);
            this.panelRed.TabIndex = 0;
            this.panelRed.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRed_Paint);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.AliceBlue;
            this.panelBlue.Controls.Add(this.label3);
            this.panelBlue.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBlue.Location = new System.Drawing.Point(512, 0);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(256, 320);
            this.panelBlue.TabIndex = 1;
            this.panelBlue.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBlue_Paint);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Honeydew;
            this.panelGreen.Controls.Add(this.label2);
            this.panelGreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGreen.Location = new System.Drawing.Point(256, 0);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(256, 320);
            this.panelGreen.TabIndex = 2;
            this.panelGreen.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGreen_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RED";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "GREEN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "BLUE";
            // 
            // frmHistogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 320);
            this.Controls.Add(this.panelGreen);
            this.Controls.Add(this.panelBlue);
            this.Controls.Add(this.panelRed);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHistogram";
            this.Text = "Histogram";
            this.panelRed.ResumeLayout(false);
            this.panelRed.PerformLayout();
            this.panelBlue.ResumeLayout(false);
            this.panelBlue.PerformLayout();
            this.panelGreen.ResumeLayout(false);
            this.panelGreen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}