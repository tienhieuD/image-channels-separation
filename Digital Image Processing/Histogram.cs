using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Image_Processing
{
    class Histogram
    {
        //private const int WIDTH = 261;
        //private const int HEIGHT = 261;

        int[,] a;
        int[] value_count = new int[256];
        int width, height;

        public Histogram(int[,] array)
        {
            this.a = array;

            for (int k = 0; k < value_count.Length; k++)
            {
                value_count[k] = 0;
            }
            width = a.GetLength(0);
            height = a.GetLength(1);
        }

        private void CountLevel() {
            

            //Đếm số mức xám
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    int k = a[x, y];
                    value_count[k]++;
                }
            }

        }

        private int GetMaxCountLevel()
        {
            int max = -1;
            for (int i = 0; i < value_count.Length; i++)
                max = value_count[i] > max ? value_count[i] : max;
            return max;
        }

        public void Draw(Panel panel, Pen pen, PaintEventArgs e)
        {
            CountLevel();

            for (int i = 0; i < 256; i++)
            {
                double y = value_count[i] * panel.Height / GetMaxCountLevel();
                double x = (panel.Height - y);

                Point p1 = new Point(i, panel.Height);
                Point p2 = new Point(i, (int)x);
                e.Graphics.DrawLine(pen, p1, p2);
            }
            
        }
    }
}
