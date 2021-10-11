using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessingHWK2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            tkbThresh_ValueChanged(null, null);
            tkbLevel_ValueChanged(null, null);
            tkbBrightness_ValueChanged(null, null);
            tkbContrast_ValueChanged(null, null);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //tableLayoutPanel1.
               //folderBrowserDialog1.ShowDialog();

            //directorySearcher1.SearchRoot = DirectoryEntry. .Filter = "*.*";
            //SearchResult sr =  directorySearcher1.FindOne();
            
        }

        ColorImage mainImage, modifiedImage;
        MonoToneImage gray1, gray2, blackWhite, grayLevel;
        

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() != DialogResult.OK) return;

            mainImage = new ColorImage(dlg.FileName);
            pbxMain.Image = mainImage.TheBitmap;
            splitContainer2.Panel2.Enabled = true;
        }

        private void btnColorAveragedGray_Click(object sender, EventArgs e)
        {
            gray1 = ColorImage.GetGrayFromRGVAverage(mainImage);
            pbx001.Image =  gray1.theImage;
            lab001.Text = "RGV Averaged Gray";
            cht001.Series[0].Points.Clear();
            for (int i = 0; i < gray1.histogram.Length; i++)
                cht001.Series[0].Points.AddXY(i, gray1.histogram[i]);

            btnBlackWhite.Enabled = btnLeveledGray.Enabled  = true;
            
        }

        private void btnBetterGray_Click(object sender, EventArgs e)
        {
            gray2 = ColorImage.GetGrayFromRGVAranged(mainImage);
            lab002.Text = "RGV Balanced Gray";
            pbx002.Image = gray2.theImage;
            cht002.Series[0].Points.Clear();
            for (int i = 0; i < gray2.histogram.Length; i++)
                cht002.Series[0].Points.AddXY(i, gray2.histogram[i]);

            //btnBlackWhite.Enabled = btnLeveledGray.Enabled = true;
        }

        private void tkbLevel_ValueChanged(object sender, EventArgs e)
        {
            labLevel.Text = $"Gray Level: {tkbLevel.Value}";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tkbBrightness_ValueChanged(object sender, EventArgs e)
        {
            if(  tkbBrightness.Value > 0) 
                labBrightness.Text = $"Brightness Edit: +{tkbBrightness.Value}";
            else
                labBrightness.Text = $"Brightness Edit: {tkbBrightness.Value}";
        }

        private void tkbContrast_ValueChanged(object sender, EventArgs e)
        {
            labContrast.Text = $"Contrast Level: {tkbContrast.Value}";

        }

        private void btnContrast_Click(object sender, EventArgs e)
        {
            modifiedImage = ColorImage.GetContrasthangedImage(mainImage, tkbContrast.Value);
            lab002.Text = "Contrast Changed Image";
            pbx002.Image = modifiedImage.TheBitmap;
        }


        private void btnBrightness_Click(object sender, EventArgs e)
        {
            modifiedImage = ColorImage.GetBrignthessChangedImage(mainImage, tkbBrightness.Value);
            lab001.Text = "Brightness Changed Image";
            pbx001.Image = modifiedImage.TheBitmap;
        }



        private void tkbThresh_ValueChanged(object sender, EventArgs e)
        {
            labThresh.Text = $"B/W Thresh: {tkbThresh.Value}";
        }

        private void btnBlackWhite_Click(object sender, EventArgs e)
        {
            blackWhite = ColorImage.GetBlackWhiteImage(gray1, tkbThresh.Value );

            lab003.Text = "Black / White";
            pbx003.Image = blackWhite.theImage;
            cht003.Series[0].Points.Clear();
            for (int i = 0; i < blackWhite.histogram.Length; i++)
                cht003.Series[0].Points.AddXY(i, blackWhite.histogram[i]);

        }


        private void btnLeveledGray_Click(object sender, EventArgs e)
        {
            grayLevel = ColorImage.GetLeveledGray(gray1, tkbLevel.Value);

            lab003.Text = $"{tkbLevel.Value} Level Gray";
            pbx003.Image = grayLevel.theImage;
            cht003.Series[0].Points.Clear();
            for (int i = 0; i < grayLevel.histogram.Length; i++)
                cht003.Series[0].Points.AddXY(i, grayLevel.histogram[i]);


        }
    }
}
