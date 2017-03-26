using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Digital_Image_Processing
{
    public partial class fromMain : DevExpress.XtraEditors.XtraForm
    {
        private bool flag = false;

        public fromMain()
        {
            InitializeComponent();
        }

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All File (*.*)|*.*|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|BMP Files (*.bmp)|*.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Bitmap openImg = new Bitmap(open.FileName);

                //Căn ảnh vửa màn hình;
                if (openImg.Width > pictureBox1.Width || openImg.Height > pictureBox1.Height)
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                else
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

                pictureBox1.Image = openImg;
                flag = true;
                this.Text = string.Format("Digital Image Processing ({0})", open.FileName);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.FileName = DateTime.Now.ToString("HmmssddMMyyyy");
                save.Filter = "JPG Files (*.jpg)|*.jpeg|PNG Files (*.png)|*.png|JPEG Files (*.jpeg)|*.jpeg|GIF Files (*.gif)|*.gif|BMP Files (*.bmp)|*.bmp|All File (*.*)|*.*";
                if (save.ShowDialog() == DialogResult.OK)
                    pictureBox1.Image.Save(save.FileName);
            }
            else
            {
                MessageBox.Show("No image available.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void viewHistogramsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                frmHistogram f = new frmHistogram(new Bitmap(pictureBox1.Image));
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("No image available.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
