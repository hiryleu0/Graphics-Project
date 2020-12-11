using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace Projekt3.HSV
{
    public partial class HSVForm : Form
    {
        private bool separatedOnce = false;

        public DirectBitmap bigDirectBitmap1;
        public DirectBitmap bigDirectBitmap2;
        public DirectBitmap bigDirectBitmap3;
        private DirectBitmap smallDirectBitmap1;
        private DirectBitmap smallDirectBitmap2;
        private DirectBitmap smallDirectBitmap3;

        public DirectBitmap mainBitmap;
        private IFilter _filter = null;
        private IFilter Filter
        {
            get => _filter;
            set
            {
                label1.Text = value.Label1;
                label2.Text = value.Label2;
                label3.Text = value.Label3;
                groupBox2.Enabled = savePropertiesButton.Enabled = value.PropertiesEnabled;
                _filter = value;
            }
        }
        public HSVForm()
        {
            InitializeComponent();

            filterComboBox.Items.AddRange(new IFilter[] { new HSVFilter(), new YCbCrFilter(), new LabFilter(this) });
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter = filterComboBox.SelectedItem as IFilter;
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

                bigDirectBitmap1 = new DirectBitmap(bitmap.Width, bitmap.Height);
                bigDirectBitmap2 = new DirectBitmap(bitmap.Width, bitmap.Height);
                bigDirectBitmap3 = new DirectBitmap(bitmap.Width, bitmap.Height);

                mainBitmap = new DirectBitmap(bitmap.Width, bitmap.Height);
                for (int i = 0; i < mainBitmap.Width; i++)
                    for (int j = 0; j < mainBitmap.Height; j++)
                        mainBitmap.SetPixel(i, j, bitmap.GetPixel(i, j));
                mainPictureBox.Image = mainBitmap.Bitmap;
                mainPictureBox.Refresh();
            }
        }

        private void grayScaleButton_Click(object sender, EventArgs e)
        {
            if (mainBitmap == null) return;
            for (int y = 0; y < mainBitmap.Height; y++)
                for (int x = 0; x < mainBitmap.Width; x++)
                {
                    Color c = mainBitmap.GetPixel(x, y);
                    int rgb = (int)Math.Round(.299 * c.R + .587 * c.G + .114 * c.B);
                    mainBitmap.SetPixel(x, y, Color.FromArgb(rgb, rgb, rgb));
                }
            mainPictureBox.Refresh();
        }

        private void seprateChannelsButton_Click(object sender, EventArgs e)
        {
            if (mainBitmap == null || Filter == null) return;

            separatedOnce = true;

            for (int i = 0; i < mainBitmap.Width; i++)
                for (int j = 0; j < mainBitmap.Height; j++)
                {
                    (Color c1, Color c2, Color c3) = Filter.FilterColor(mainBitmap.GetPixel(i, j));
                    bigDirectBitmap1.SetPixel(i, j, c1);
                    bigDirectBitmap2.SetPixel(i, j, c2);
                    bigDirectBitmap3.SetPixel(i, j, c3);
                }

            void scale(DirectBitmap srcBitmap, DirectBitmap destBitmap, PictureBox pictureBox)
            {
                for (int i = 0; i < destBitmap.Width; i++)
                    for (int j = 0; j < destBitmap.Height; j++)
                    {
                        int x = i * srcBitmap.Width / destBitmap.Width;
                        int y = j * srcBitmap.Height / destBitmap.Height;
                        destBitmap.SetPixel(i, j, srcBitmap.GetPixel(x, y));
                    }
                pictureBox.Refresh();
            }

            scale(bigDirectBitmap1, smallDirectBitmap1, pictureBox1);
            scale(bigDirectBitmap2, smallDirectBitmap2, pictureBox2);
            scale(bigDirectBitmap3, smallDirectBitmap3, pictureBox3);
        }

        private void saveOutputButton_Click(object sender, EventArgs e)
        {
            if (mainBitmap == null || Filter == null || !separatedOnce)
            {
                MessageBox.Show("Nothing to save!");
                return;
            }
            try
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    bigDirectBitmap1.Bitmap.Save(dialog.SelectedPath + "\\" + Filter.Label1 + ".jpg");
                    bigDirectBitmap2.Bitmap.Save(dialog.SelectedPath + "\\" + Filter.Label2 + ".jpg");
                    bigDirectBitmap3.Bitmap.Save(dialog.SelectedPath + "\\" + Filter.Label3 + ".jpg");
                    MessageBox.Show($"Pliki zapisane w folderze {dialog.SelectedPath}");
                }
            }
            catch
            {
                MessageBox.Show("Niepowodzenie");
            }
        }

        private void HSVForm_SizeChanged(object sender, EventArgs e)
        {
            TableLayoutPanelCellPosition pos = tableLayoutPanel.GetCellPosition(pictureBox1);
            int width = tableLayoutPanel.GetColumnWidths()[pos.Column];
            int height = tableLayoutPanel.GetRowHeights()[pos.Row];
            pictureBox1.Size = new System.Drawing.Size(width, height);
            pos = tableLayoutPanel.GetCellPosition(pictureBox2);
            width = tableLayoutPanel.GetColumnWidths()[pos.Column];
            height = tableLayoutPanel.GetColumnWidths()[pos.Row];
            pictureBox2.Size = pictureBox3.Size = new System.Drawing.Size(width, height);

            smallDirectBitmap1 = new DirectBitmap(pictureBox1.Width, pictureBox1.Height);
            smallDirectBitmap2 = new DirectBitmap(pictureBox2.Width, pictureBox2.Height);
            smallDirectBitmap3 = new DirectBitmap(pictureBox3.Width, pictureBox3.Height);
            pictureBox1.Image = smallDirectBitmap1.Bitmap;
            pictureBox2.Image = smallDirectBitmap2.Bitmap;
            pictureBox3.Image = smallDirectBitmap3.Bitmap;


            void scale(DirectBitmap srcBitmap, DirectBitmap destBitmap, PictureBox pictureBox)
            {
                if (srcBitmap == null || destBitmap == null) return;
                for (int i = 0; i < destBitmap.Width; i++)
                    for (int j = 0; j < destBitmap.Height; j++)
                    {
                        int x = i * srcBitmap.Width / destBitmap.Width;
                        int y = j * srcBitmap.Height / destBitmap.Height;
                        destBitmap.SetPixel(i, j, srcBitmap.GetPixel(x, y));
                    }
                pictureBox.Refresh();
            }

            scale(bigDirectBitmap1, smallDirectBitmap1, pictureBox1);
            scale(bigDirectBitmap2, smallDirectBitmap2, pictureBox2);
            scale(bigDirectBitmap3, smallDirectBitmap3, pictureBox3);
        }

        private CameraForm cameraForm;

        private void cameraButton_Click(object sender, EventArgs e)
        {
            cameraForm = new CameraForm(this); ;
            cameraForm.ShowDialog();
        }
    }

}
