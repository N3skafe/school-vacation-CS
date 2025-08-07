using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Tutorial08
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Paint(object sender, PaintEventArgs e)
        {
            Pen bluePen = new Pen(Color.Blue, 1);
            SolidBrush solBrush = new SolidBrush(Color.Red);

            PointF pt1 = new PointF(40.0f, 50.0f);
            PointF pt2 = new PointF(50.0f, 75.0f);
            PointF pt3 = new PointF(80.0f, 115.0f);
            PointF pt4 = new PointF(200.0f, 180.0f);
            PointF pt5 = new PointF(200.0f, 90.0f);

            PointF[] ptsArray = { pt1, pt2, pt3, pt4, pt5 };

            float tension = 0.5f;

            e.Graphics.DrawClosedCurve(bluePen, ptsArray, tension, System.Drawing.Drawing2D.FillMode.Alternate);
        }
    }
}
