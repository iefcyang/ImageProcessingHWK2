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

        public static ColorImage GetHistogramEqualizedFixedRangeImage(ColorImage img, bool FullRange = false )
        {
            int rows = img.pixels.GetLength(0);
            int cols = img.pixels.GetLength(1);
            int[,,] pixels = new int[rows, cols, 3];
            double[,] his = new double[256, 3];
            int[] mins = new int[3];
            int[] ranges = new int[3];
            for( int i = 0; i < 3;i++)
            {
                mins[i] = int.MaxValue;
                ranges[i] = int.MinValue;
            }
            for( int r = 0; r < rows;r++)
                for( int c = 0; c < cols; c++ )
                {
                    for (int d = 0; d < 3; d++)
                    {
                        his[img.pixels[r, c, d], d]++;
                        if (img.pixels[r, c, d] < mins[d])
                            mins[d] = img.pixels[r, c, d];
                        else if(img.pixels[r, c, d] > ranges[d])
                            ranges[d] = img.pixels[r, c, d];
                    }
                }
            // Cumulated countes
            for (int d = 0; d < 3; d++)
                for (int i = 1; i < 256; i++)
                    his[i, d] += his[i - 1, d];
            // Normalized
            int total = rows * cols;
            for (int d = 0; d < 3; d++)
                for (int i = 1; i < 256; i++)
                    his[i, d] /= total;

            // linear map histogram
            for (int i = 0; i < 3; i++) ranges[i] = ranges[i] - mins[i];
            for (int d = 0; d < 3; d++)
                for (int i = 0; i < 256; i++)
                {
                    if( FullRange)
                        his[i, d] = (int)( his[i, d] * 255.0);
                  else
                        his[i, d] = (int)( mins[d] + his[i, d] * ranges[d] );

                    if (his[i, d] < 0) his[i, d] = 0;
                    else if (his[i, d] > 255) his[i, d] = 255;
                }

            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                {
                    for (int d = 0; d < 3; d++)
                    {
                        pixels[r, c, d] =  (int)his[img.pixels[r, c, d], d];
                    }
                }
            return new ColorImage(pixels);
        }


        public static int[,] SubtrasteTwoMonoImages( MonoToneImage img1, MonoToneImage img2 )
        {
            int rows = img1.intensities.GetLength(0);
            int cols = img1.intensities.GetLength(1);
            int[,] difference = new int[rows, cols ];
            int min = int.MaxValue;
            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                {
                    for (int d = 0; d < 3; d++)
                    {
                        difference[r, c] = img1.intensities[r, c] - img2.intensities[r, c];
                        if (difference[r, c] < min)
                            min = difference[r, c];
                    }
                }
            return difference;
        }

        public static ColorImage GetContrastChangedImage(ColorImage img, int contrastLevel)
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
        public static MonoToneImage GetGrayFromRGVDifferentWeighted(ColorImage img, double rFactor = 0.299, double gFactor = 0.587,double bFactor = 0.114 )
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
            double levelM1div255=  (level ) / 255.0;
            int rows = img.intensities.GetLength(0);
            int cols = img.intensities.GetLength(1);
            int[,] intensities = new int[rows, cols];
            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                {
                    int levelIndex = (int)(img.intensities[r, c] * levelM1div255);
                    if (levelIndex < 0) levelIndex = 0;
                    else if (levelIndex >= level) levelIndex = level - 1;
                    intensities[r, c] = (int)(levelIndex * 255.0 / (level-1));
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
