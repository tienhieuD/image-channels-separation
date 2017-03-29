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
    public partial class frmHistogramGray : DevExpress.XtraEditors.XtraForm
    {
        Pen black_pen = new Pen(Color.Silver, 1);
        Bitmap image;
        ArrayImage array_image;

        public frmHistogramGray(Bitmap image)
        {
            InitializeComponent();
            this.image = image;
            array_image = new ArrayImage(image);
        }

        private void panelGray_Paint(object sender, PaintEventArgs e)
        {
            int[,] gray_array_image = array_image.GetGreenArray();
            Histogram gray_histogram = new Histogram(gray_array_image);
            gray_histogram.Draw(panelGray, black_pen, e);
        }
    }
}