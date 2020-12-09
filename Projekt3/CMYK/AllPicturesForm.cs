using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt3
{
    public partial class AllPicturesForm : Form
    {
        private readonly CMYKForm mainForm;
        private readonly DirectBitmap cyjanDirectBitmap, magentaDirectBitmap, yellowDirectBitmap, blackDirectBitmap;
        private readonly DirectBitmap cyjanBitmap, magentaBitmap, yellowBitmap, blackBitmap;
        public AllPicturesForm(CMYKForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            cyjanDirectBitmap = new DirectBitmap(mainForm.mainPictureBox.Width, mainForm.mainPictureBox.Height);
            magentaDirectBitmap = new DirectBitmap(cyjanDirectBitmap.Width, cyjanDirectBitmap.Height);
            yellowDirectBitmap = new DirectBitmap(cyjanDirectBitmap.Width, cyjanDirectBitmap.Height);
            blackDirectBitmap = new DirectBitmap(cyjanDirectBitmap.Width, cyjanDirectBitmap.Height);

            cyjanBitmap = new DirectBitmap(cyjanPictureBox.Width, cyjanPictureBox.Height);
            magentaBitmap = new DirectBitmap(cyjanPictureBox.Width, cyjanPictureBox.Height);
            yellowBitmap = new DirectBitmap(cyjanPictureBox.Width, cyjanPictureBox.Height);
            blackBitmap = new DirectBitmap(cyjanPictureBox.Width, cyjanPictureBox.Height);

            cyjanPictureBox.Image = cyjanBitmap.Bitmap;
            magentaPictureBox.Image = magentaBitmap.Bitmap;
            yellowPictureBox.Image = yellowBitmap.Bitmap;
            blackPictureBox.Image = blackBitmap.Bitmap;


            CMYK();
            DrawPictures();
        }

        private void DrawPictures()
        {
            DrawPicture(magentaBitmap, magentaDirectBitmap);
            DrawPicture(cyjanBitmap, cyjanDirectBitmap);
            DrawPicture(yellowBitmap, yellowDirectBitmap);
            DrawPicture(blackBitmap, blackDirectBitmap);
            cyjanPictureBox.Refresh();
            magentaPictureBox.Refresh();
            yellowPictureBox.Refresh();
            blackPictureBox.Refresh();
        }

        private void DrawPicture(DirectBitmap destBitmap, DirectBitmap srcBitmap)
        {

            for (int i = 0; i < destBitmap.Width; i++)
                for (int j = 0; j < destBitmap.Height; j++)
                {
                    int x = i * srcBitmap.Width / destBitmap.Width;
                    int y = j * srcBitmap.Height / destBitmap.Height;
                    destBitmap.SetPixel(i, j, srcBitmap.GetPixel(x, y));
                }
        }

        public void CMYK()
        {
            for (int i = 0; i < cyjanDirectBitmap.Width; i++)
                for (int j = 0; j < cyjanDirectBitmap.Height; j++)
                {
                    Color RGB = mainForm.mainBitmap.GetPixel(i, j);
                    int C = 255 - RGB.R;
                    int M = 255 - RGB.G;
                    int Y = 255 - RGB.B;
                    int k = Math.Min(Math.Min(C, M), Y);
                    C -= k;
                    M -= k;
                    Y -= k;
                    C += mainForm.ValueFromPlot(k, mainForm.cyjanCurve);
                    M += mainForm.ValueFromPlot(k, mainForm.magentaCurve);
                    Y += mainForm.ValueFromPlot(k, mainForm.yellowCurve);
                    int K = mainForm.ValueFromPlot(k, mainForm.blackCurve);
                    if (C > 255) C = 255;
                    else if (C < 0) C = 0;
                    if (M > 255) M = 255;
                    else if (M < 0) M= 0;
                    if (Y > 255) Y = 255;
                    else if (Y  < 0) Y = 0;
                    if (K > 255) K = 255;
                    else if (K < 0) K = 0;

                    cyjanDirectBitmap.SetPixel(i, j, Color.FromArgb(255, 255 - C, 255, 255));
                    magentaDirectBitmap.SetPixel(i, j, Color.FromArgb(255, 255, 255 - M, 255));
                    yellowDirectBitmap.SetPixel(i, j, Color.FromArgb(255, 255, 255, 255 - Y));
                    blackDirectBitmap.SetPixel(i, j, Color.FromArgb(255, 255 - K, 255 - K, 255 - K));
                }

        }

        public void SavePictures()
        {
            try
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    cyjanDirectBitmap.Bitmap.Save(dialog.SelectedPath + "\\cyan.jpg");
                    magentaDirectBitmap.Bitmap.Save(dialog.SelectedPath + "\\magenta.jpg");
                    yellowDirectBitmap.Bitmap.Save(dialog.SelectedPath + "\\yellow.jpg");
                    blackDirectBitmap.Bitmap.Save(dialog.SelectedPath + "\\black.jpg");
                    MessageBox.Show($"Pliki zapisane w folderze {dialog.SelectedPath}");

                }
            }
            catch
            {
                MessageBox.Show("Niepowodzenie");
            }
        }
    }
}
