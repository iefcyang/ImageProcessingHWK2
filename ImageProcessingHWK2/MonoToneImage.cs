using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingHWK2
{
    class MonoToneImage
    {
        public Bitmap theImage;
        public int[,] intensities;
        public int[] histogram = new int[256];
        int rows, cols;

        public MonoToneImage( int[,] intensities )
        {
            rows = intensities.GetLength(0);
            cols = intensities.GetLength(1);
            this.intensities = intensities;
            theImage = new Bitmap(cols, rows);
            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                {
                    int intensity = intensities[r, c];
                    if (intensity < 0) intensity = 0;
                    else if (intensity > 255) intensity = 255;
                    histogram[intensity]++;
                    Color p = Color.FromArgb( intensity,intensity,intensity);
                    theImage.SetPixel(c,r,p);
                 }

        }
    }
}
