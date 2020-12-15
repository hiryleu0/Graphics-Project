using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Projekt3.HSV;
using Projekt3.BezierCurve;

namespace Projekt3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CMYKButton_Click(object sender, EventArgs e)
        {
            new CMYKForm(this).Show();
        }

        private void HSVButton_Click(object sender, EventArgs e)
        {
            new HSVForm().Show();
        }

        private void bezierButton_Click(object sender, EventArgs e)
        {
            new BezierCurveForm().Show();
        }
    }
}
