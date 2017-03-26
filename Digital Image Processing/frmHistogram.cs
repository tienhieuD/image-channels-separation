using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Digital_Image_Processing
{
    public partial class frmHistogram : DevExpress.XtraEditors.XtraForm
    {
         Pen redPen = new Pen(Color.IndianRed, 1);
         Pen greenPen = new Pen(Color.SeaGreen, 1);
         Pen bluePen = new Pen(Color.RoyalBlue, 1);

        Bitmap image;
        ArrayImage array_image;

        public frmHistogram(Bitmap image)
        {
            InitializeComponent();
            this.image = image;
            array_image = new ArrayImage(image);
        }

        private void panelRed_Paint(object sender, PaintEventArgs e)
        {
            int[,] red_array_image = array_image.GetRedArray();
            Histogram red_histogram = new Histogram(red_array_image);
            red_histogram.Draw(panelRed, redPen, e);
        }

        private void panelGreen_Paint(object sender, PaintEventArgs e)
        {
            int[,] green_array_image = array_image.GetGreenArray();
            Histogram green_histogram = new Histogram(green_array_image);
            green_histogram.Draw(panelGreen, greenPen, e);
        }

        private void panelBlue_Paint(object sender, PaintEventArgs e)
        {
            int[,] blue_array_image = array_image.GetBlueArray();
            Histogram blue_histogram = new Histogram(blue_array_image);
            blue_histogram.Draw(panelBlue, bluePen, e);
        }
    }
}