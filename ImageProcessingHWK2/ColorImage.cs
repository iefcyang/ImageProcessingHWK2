using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingHWK2
{
    class ColorImage
    {

        #region static

        public static ColorImage GetContrasthangedImage(ColorImage img, int contrastLevel)
        {
            double factor = 259.0 * (255 + contrastLevel) / 255.0 / (259.0 - contrastLevel);
            int rows = img.pixels.GetLength(0);
            int cols = img.pixels.GetLength(1);
            int[,,] intensities = new int[rows, cols, 3];
            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                {
                    for (int d = 0; d < 3; d++)
                    {
                        intensities[r, c, d] = (int)( ( img.pixels[r, c, d] -128.0) * factor + 128.0 );
                        if (intensities[r, c, d] < 0) intensities[r, c, d] = 0;
                        else if (intensities[r, c, d] > 255) intensities[r, c, d] = 255;
                    }
                }
            return new ColorImage(intensities);
        }

        public static ColorImage GetBrignthessChangedImage(ColorImage img, int brightnesssDelta )
        {
            int rows = img.pixels.GetLength(0);
            int cols = img.pixels.GetLength(1);
            int[,,] intensities = new int[rows, cols,3];
            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                {
                    for (int d = 0; d < 3; d++)
                    {
                        intensities[r, c, d] = img.pixels[r, c, d] + brightnesssDelta;
                        if (intensities[r, c, d] < 0) intensities[r, c, d] = 0;
                        else if (intensities[r, c, d] > 255) intensities[r, c, d] = 255;
                    }
                }
                    
            return new ColorImage(intensities);
        }

        public static MonoToneImage GetGrayFromRGVAverage(ColorImage img)
        {
            int rows = img.pixels.GetLength(0);
            int cols = img.pixels.GetLength(1);
            int[,] intensities = new int[rows, cols];
            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                    intensities[r, c] = (img.pixels[r, c, 0] + img.pixels[r, c, 1] + img.pixels[r, c, 2]) / 3;
            return new MonoToneImage(intensities);
        }
        public static MonoToneImage GetGrayFromRGVAranged(ColorImage img, double rFactor = 0.299, double gFactor = 0.587,double bFactor = 0.114 )
        {
            int rows = img.pixels.GetLength(0);
            int cols = img.pixels.GetLength(1);
            int[,] intensities = new int[rows, cols];
            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                    intensities[r, c] = (int)(  img.pixels[r, c, 0] * rFactor + img.pixels[r, c, 1]* gFactor + img.pixels[r, c, 2] * bFactor );
            return new MonoToneImage(intensities);
        }

        public static MonoToneImage GetBlackWhiteImage(MonoToneImage img, int thresh = 128)
        {
            int rows = img.intensities.GetLength(0);
            int cols = img.intensities.GetLength(1);
            int[,] intensities = new int[rows, cols];
            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                    intensities[r, c] = img.intensities[r, c] < thresh ? 0 : 255;
            return new MonoToneImage(intensities);
        }

        public static MonoToneImage GetLeveledGray(MonoToneImage img, int level = 16 )
        {
            double levelM1div255=  (level - 1.0) / 255.0;
            int rows = img.intensities.GetLength(0);
            int cols = img.intensities.GetLength(1);
            int[,] intensities = new int[rows, cols];
            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                {
                    int levelIndex = (int)(img.intensities[r, c] * levelM1div255);
                    intensities[r, c] = (int)(levelIndex / levelM1div255);
                }
            return new MonoToneImage(intensities);
        }



        #endregion

        Bitmap theBitmap;
        int cols, rows;
        int[,,] pixels;
        public ColorImage( string filePath )
        {
            theBitmap = new Bitmap(filePath);
            cols = theBitmap.Width;
            rows = theBitmap.Height;
            pixels = new int[rows, cols, 3];
            GetPixelsFromBitmap();
        }

        public ColorImage(int[,,] pixels)
        {
            this.pixels = pixels;
            rows = this.pixels.GetLength(0);
            cols = this.pixels.GetLength(1);
            SetBitmapFromPixels();
        }


        void GetPixelsFromBitmap()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    Color p = theBitmap.GetPixel(c, r);
                    pixels[r, c, 0] = p.R; pixels[r, c, 1] = p.G; pixels[r, c, 2] = p.B;
                }
            }
        }


        void SetBitmapFromPixels(  )
        {
            theBitmap = new Bitmap(cols, rows);
            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                {
                    Color p = Color.FromArgb( pixels[r, c, 0], pixels[r, c, 1] , pixels[r, c, 2] );
                    theBitmap.SetPixel(c,r, p);
                }
        }


        public Bitmap TheBitmap { get => theBitmap; set => theBitmap = value; }
    }
}
