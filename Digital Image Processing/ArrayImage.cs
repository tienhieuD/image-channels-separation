﻿using System;
using System.Drawing;

namespace Digital_Image_Processing
{
    internal class ArrayImage
    {
        private Bitmap image;
        private int[,,] array_image;
        private int width, height;

        public ArrayImage(Bitmap image)
        {
            this.image = image;
            width = image.Width;
            height = image.Height;

            array_image = new int[width, height, 3];
            for (int x = 0; x < width; x++) {
                for (int y = 0; y < height; y++) {
                    Color color = image.GetPixel(x, y);
                    array_image[x, y, 0] = color.R;
                    array_image[x, y, 1] = color.G;
                    array_image[x, y, 2] = color.B;
                }
            }
        }

        internal int[,] GetRedArray()
        {
            int[,] arr = new int[width, height];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    arr[x, y] = array_image[x, y, 0];
                }
            }
            return arr;
        }

        internal int[,] GetGreenArray()
        {
            int[,] arr = new int[width, height];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    arr[x, y] = array_image[x, y, 1];
                }
            }
            return arr;
        }

        internal int[,] GetBlueArray()
        {
            int[,] arr = new int[width, height];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    arr[x, y] = array_image[x, y, 2];
                }
            }
            return arr;
        }
    }
}