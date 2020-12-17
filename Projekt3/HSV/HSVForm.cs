using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using Projekt3.HSV.ColorProfiles;
using Projekt3.HSV.Iluminants;

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
                groupBox2.Enabled = savePropertiesButton.Enabled = loadPropertiesButton.Enabled = value.PropertiesEnabled;
                comboBox2.Enabled = (comboBox1.SelectedItem as IColorProfile).IluminantEnabled;
                _filter = value;
            }
        }
        public HSVForm()
        {
            InitializeComponent();

            filterComboBox.Items.AddRange(new IFilter[] { new HSVFilter(), new YCbCrFilter(), new LabFilter(this) });


            Type[] iluminantClasses = Assembly.GetExecutingAssembly().GetTypes()
                          .Where(t => String.Equals(t.Namespace, "Projekt3.HSV.Iluminants", StringComparison.Ordinal))
                          .ToArray();
            foreach (Type type in iluminantClasses)
            {
                var types = new Type[] { };
                var cons = type.GetConstructor(types);
                if (cons != null)
                {
                    var obj = cons.Invoke(new object[] { });
                    comboBox2.Items.Add(obj);
                }
            }
            comboBox2.SelectedIndex = 0;

            Type[] colorProfilesClasses = Assembly.GetExecutingAssembly().GetTypes()
                          .Where(t => String.Equals(t.Namespace, "Projekt3.HSV.ColorProfiles", StringComparison.Ordinal))
                          .ToArray();
            foreach(Type type in colorProfilesClasses)
            {
                var types = new Type[] {  };
                var cons = type.GetConstructor(types);
                if (cons != null)
                {
                    var obj = cons.Invoke(new object[] { });
                    comboBox1.Items.Add(obj);
                }
            }
            comboBox1.SelectedIndex = 0;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColorProfile profile = comboBox1.SelectedItem as ColorProfile;
            if (comboBox2.Enabled = profile.IluminantEnabled)
            {
                redXNumericUpDown.Enabled = redYNumericUpDown.Enabled = greenXNumericUpDown.Enabled = greenYNumericUpDown.Enabled
                    = blueXNumericUpDown.Enabled = blueYNumericUpDown.Enabled = gammaNumericUpDown.Enabled = true;
                whiteXNumericUpDown.Enabled = whiteYNumericUpDown.Enabled = (comboBox2.SelectedItem as Iluminant).WhiteEnabled;

                return;
            }

            redXNumericUpDown.Enabled = redYNumericUpDown.Enabled = greenXNumericUpDown.Enabled = greenYNumericUpDown.Enabled
                    = blueXNumericUpDown.Enabled = blueYNumericUpDown.Enabled = gammaNumericUpDown.Enabled = false;
            whiteXNumericUpDown.Enabled = whiteYNumericUpDown.Enabled = false;

            redXNumericUpDown.Value = (decimal)profile.XRed;
            redYNumericUpDown.Value = (decimal)profile.YRed;
            greenXNumericUpDown.Value = (decimal)profile.XGreen;
            greenYNumericUpDown.Value = (decimal)profile.YGreen;
            blueXNumericUpDown.Value = (decimal)profile.XBlue;
            blueYNumericUpDown.Value = (decimal)profile.YBlue;
            whiteXNumericUpDown.Value = (decimal)profile.XWhite;
            whiteYNumericUpDown.Value = (decimal)profile.YWhite;
            gammaNumericUpDown.Value = (decimal)profile.Gamma;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Iluminant iluminant = comboBox2.SelectedItem as Iluminant;
            if (iluminant.WhiteEnabled)
            {
               whiteXNumericUpDown.Enabled = whiteYNumericUpDown.Enabled = true;
                return;
            }

            whiteXNumericUpDown.Enabled = whiteYNumericUpDown.Enabled = false;

            whiteXNumericUpDown.Value = (decimal)iluminant.XWhite;
            whiteYNumericUpDown.Value = (decimal)iluminant.YWhite;
        }

        private void savePropertiesButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal[] values = new decimal[9];
                values[0] = redXNumericUpDown.Value;
                values[1] = redYNumericUpDown.Value;
                values[2] = greenXNumericUpDown.Value;
                values[3] = greenYNumericUpDown.Value;
                values[4] = blueXNumericUpDown.Value;
                values[5] = blueYNumericUpDown.Value;
                values[6] = whiteXNumericUpDown.Value;
                values[7] = whiteYNumericUpDown.Value;
                values[8] = gammaNumericUpDown.Value;
                SaveFileDialog dialog = new SaveFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(decimal[]));
                    TextWriter writer = new StreamWriter(dialog.FileName);
                    serializer.Serialize(writer, values);
                    writer.Close();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void loadPropertiesButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Decimal[]));
                    TextReader reader = new StreamReader(dialog.FileName);
                    decimal[] values = (decimal[])serializer.Deserialize(reader);
                    reader.Close();

                    redXNumericUpDown.Value = values[0];
                    redYNumericUpDown.Value = values[1];
                    greenXNumericUpDown.Value = values[2];
                    greenYNumericUpDown.Value = values[3];
                    blueXNumericUpDown.Value = values[4];
                    blueYNumericUpDown.Value = values[5];
                    whiteXNumericUpDown.Value = values[6];
                    whiteYNumericUpDown.Value = values[7];
                    gammaNumericUpDown.Value = values[8];
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }

}
