using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt3.BezierCurve
{
    public partial class BezierCurveForm : Form
    {
        DirectBitmap directBitmap;
        BezierCurve curve;
        public BezierCurveForm()
        {
            InitializeComponent();
            directBitmap = new DirectBitmap(pictureBox.Width, pictureBox.Height);
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

        private void DrawAll()
        {
            using (Graphics g = Graphics.FromImage(pictureBox.Image))
            {
                g.FillRectangle(Brushes.White, 0, 0, pictureBox.Width, pictureBox.Height);
                curve?.DrawCurve(g, visiblePolylineCheckbox.Checked, directBitmap);
            }
            pictureBox.Refresh();
        }

        private void visiblePolylineCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            DrawAll();
        }

        bool moving;
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && visiblePolylineCheckbox.Checked)
                moving = curve.MouseDown(e.X, e.Y);
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving)
            {
                curve.MouseMove(e.X, e.Y);
                DrawAll();
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
        }
    }
}
