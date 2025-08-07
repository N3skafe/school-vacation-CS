using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial08
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Paint(object sender, PaintEventArgs e)
        {
            Pen bluePen = new Pen(Color.Blue, 1);
            Pen redPen = new Pen(Color.Red, 1);

            PointF pt1 = new PointF(40.0f, 50.0f);
            PointF pt2 = new PointF(80.0f, 80.0f);
            PointF pt3 = new PointF(110.0f, 120.0f);
            PointF pt4 = new PointF(120.0f, 180.0f);
            PointF pt5 = new PointF(200.0f, 150.0f);
            PointF pt6 = new PointF(350.0f, 250.0f);
            PointF pt7 = new PointF(200.0f, 200.0f);

            PointF[] ptsArray = { pt1, pt2, pt3, pt4, pt5, pt6, pt7, };

            e.Graphics.DrawBezier(bluePen, 30, 20, 80, 60, 120, 180, 140, 50);
            e.Graphics.DrawBeziers(redPen, ptsArray);
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
