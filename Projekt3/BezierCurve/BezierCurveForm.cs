using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt3.BezierCurve
{
    public partial class BezierCurveForm : Form
    {
        DirectBitmap directBitmap;
        DirectBitmap loadedColoredBitmap;
        DirectBitmap loadedBlackAndWhiteBitmap;
        DirectBitmap movingBitmap;
        Action<Graphics, DirectBitmap> bitmapAction;

        BezierCurve curve;

        double fi = 0.0;
        bool isAnyBezierPointMoving;

        public BezierCurveForm()
        {
            InitializeComponent();
            directBitmap = new DirectBitmap(pictureBox.Width, pictureBox.Height);
            loadedColoredBitmap = new DirectBitmap(smallPictureBox.Width, smallPictureBox.Height);
            loadedBlackAndWhiteBitmap = new DirectBitmap(smallPictureBox.Width, smallPictureBox.Height);
            pictureBox.Image = directBitmap.Bitmap;
            DrawAll();
        }

        private void pictureBoxIpl1_Click(object sender, EventArgs e)
        {

        }

        private void generateCurveButton_Click(object sender, EventArgs e)
        {
            curve = new BezierCurve((int)numericUpDown1.Value, pictureBox.Width, pictureBox.Height);
            DrawAll();
        }

        private void DrawAll(bool isCurveNew=true)
        {
            using (Graphics g = Graphics.FromImage(pictureBox.Image))
            {
                g.FillRectangle(Brushes.White, 0, 0, pictureBox.Width, pictureBox.Height);
                curve?.DrawCurve(g, visiblePolylineCheckbox.Checked, directBitmap, isCurveNew);
                bitmapAction?.Invoke(g, directBitmap);
            }
            pictureBox.Refresh();
        }

        private void visiblePolylineCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            DrawAll();
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && visiblePolylineCheckbox.Checked)
                isAnyBezierPointMoving = curve.MouseDown(e.X, e.Y);
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isAnyBezierPointMoving)
            {
                curve.MouseMove(e.X, e.Y);
                DrawAll();
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isAnyBezierPointMoving = false;
        }

        private void savePolylineButton_Click(object sender, EventArgs e)
        {
            if (curve.SaveBezierCurve())
                MessageBox.Show("Saved!", "Done", MessageBoxButtons.OK);
        }

        private void loadCurveButton_Click(object sender, EventArgs e)
        {
            if (curve.LoadCurve())
                DrawAll();
        }

        private void loadImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = Path.Combine(Directory.GetCurrentDirectory(), "pictures"),
                RestoreDirectory = true
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(openFileDialog.FileName);
                for (int i = 0; i < loadedColoredBitmap.Width; i++)
                    for (int j = 0; j < loadedColoredBitmap.Height; j++)
                    {
                        int x = i * (bitmap.Width) / (loadedColoredBitmap.Width);
                        int y = j * (bitmap.Height) / (loadedColoredBitmap.Height);
                        Color c = bitmap.GetPixel(x, y);
                        loadedColoredBitmap.SetPixel(i, j, c);
                        int gray = 3 * c.R / 10 + 59 * c.G / 100 + 11 * c.B / 100;
                        loadedBlackAndWhiteBitmap.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                    }
                movingBitmap = grayColorsCheckbox.Checked ? loadedBlackAndWhiteBitmap : loadedColoredBitmap;
                smallPictureBox.Image = movingBitmap.Bitmap;
                smallPictureBox.Refresh();
                DrawAll(false);
            }
        }

        private void grayColorsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            movingBitmap = grayColorsCheckbox.Checked ? loadedBlackAndWhiteBitmap : loadedColoredBitmap;
            smallPictureBox.Image = movingBitmap.Bitmap;
            smallPictureBox.Refresh();
            DrawAll(false);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DrawAll(false);
            pictureBox.Refresh();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if(curve!=null && movingBitmap!=null)
                timer.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if(timer.Enabled)
                timer.Stop();
        }

        private void movingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
            bitmapAction = (g, b) =>
            {
                if (movingBitmap != null && curve != null)
                {
                    Point p = curve.GetNextPoint();
                    g.DrawImage(movingBitmap.Bitmap, p.X - movingBitmap.Bitmap.Width / 2, p.Y - movingBitmap.Bitmap.Height / 2);
                }
            };
        }

        private void rotationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!rotationRadioButton.Checked)
            {
                rotatingGroupBox.Enabled = false;
                return;
            }
            rotatingGroupBox.Enabled = true;
            bitmapAction = (g, b) =>
            {
                if (movingBitmap != null && curve != null)
                {
                    fi += Math.PI / 50;
                    Point p = curve.GetCurrentPoint();
                    for(int i=0;i<movingBitmap.Width;i++)
                        for(int j=0;j<movingBitmap.Height;j++)
                        {
                            int x = i - movingBitmap.Width/2;
                            int y = j - movingBitmap.Height/2;

                            int xx = (int)Math.Round( x * Math.Cos(fi) - y * Math.Sin(fi));
                            int yy = (int)Math.Round(x * Math.Sin(fi) + y * Math.Cos(fi));

                            xx += p.X;
                            yy += p.Y;
                            if(xx>=0 && yy >=0 && xx<b.Width && yy<b.Height)
                                b.SetPixel(xx, yy, movingBitmap.GetPixel(i,j));
                        }
                }
            };
        }

        private void bothRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!bothRadioButton.Checked)
            {
                rotatingGroupBox.Enabled = false;
                return;
            }
            rotatingGroupBox.Enabled = true;
            bitmapAction = (g, b) =>
            {
                if (movingBitmap != null && curve != null)
                {
                    fi += Math.PI / 50;
                    Point p = curve.GetNextPoint();
                    for (int i = 0; i < movingBitmap.Width; i++)
                        for (int j = 0; j < movingBitmap.Height; j++)
                        {
                            int x = i - movingBitmap.Width / 2;
                            int y = j - movingBitmap.Height / 2;

                            int xx = (int)Math.Round(x * Math.Cos(fi) - y * Math.Sin(fi));
                            int yy = (int)Math.Round(x * Math.Sin(fi) + y * Math.Cos(fi));

                            xx += p.X;
                            yy += p.Y;
                            if (xx >= 0 && yy >= 0 && xx < b.Width && yy < b.Height)
                                b.SetPixel(xx, yy, movingBitmap.GetPixel(i, j));
                        }
                }
            };
        }

        private void naiveRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
