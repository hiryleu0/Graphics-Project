using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace Projekt3.HSV
{
    public partial class CameraForm : Form
    {
        private HSVForm form;
        public CameraForm(HSVForm form)
        {
            InitializeComponent();
            this.form = form;
            CaptureCamera();
        }

        VideoCapture capture;
        Mat frame;
        Bitmap image;
        private Thread camera;
        int isCameraRunning = 1;

        private void CaptureCamera()
        {
            camera = new Thread(new ThreadStart(CaptureCameraCallback));
            camera.Start();
        }

        private void CaptureCameraCallback()
        {
            frame = new Mat();
            capture = new VideoCapture(0);
            capture.Open(0);

            if (capture.IsOpened())
            {
                while (isCameraRunning == 1)
                {
                    capture.Read(frame);
                    image = BitmapConverter.ToBitmap(frame);
                    if (pictureBox.Image != null)
                    {
                        pictureBox.Image.Dispose();
                    }
                    pictureBox.Image = image;
                }
            }
            capture.Release();
            if (isCameraRunning == 0)
            {
                if (!(pictureBox.Image is Bitmap bitmap))
                {
                    Close();
                    return;
                }

                form.bigDirectBitmap1 = new DirectBitmap(bitmap.Width, bitmap.Height);
                form.bigDirectBitmap2 = new DirectBitmap(bitmap.Width, bitmap.Height);
                form.bigDirectBitmap3 = new DirectBitmap(bitmap.Width, bitmap.Height);

                form.mainBitmap = new DirectBitmap(bitmap.Width, bitmap.Height);
                for (int i = 0; i < form.mainBitmap.Width; i++)
                    for (int j = 0; j < form.mainBitmap.Height; j++)
                        form.mainBitmap.SetPixel(i, j, bitmap.GetPixel(i, j));
               
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            isCameraRunning = 0;
            camera.Join();
            if(form.mainBitmap.Bitmap != null)
                form.mainPictureBox.Image = form.mainBitmap.Bitmap;
            form.mainPictureBox.Refresh();
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            isCameraRunning = -1;
            camera.Join();
            Close();
        }
    }

}
