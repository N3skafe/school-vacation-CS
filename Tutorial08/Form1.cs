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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen redPen = new Pen(Color.Red, 1);
            Pen bluePen = new Pen(Color.Blue, 1);
            Pen greenPen = new Pen(Color.Green, 2);
            Pen blackPen = new Pen(Color.Black, 2);

            float x1 = 20.0f;
            float y1 = 20.0f;
            float x2 = 200.0f;
            float y2 = 20.0f;
            e.Graphics.DrawLine(redPen, x1, y1, x2, y2);

            Point pt1 = new Point(20, 20);
            Point pt2 = new Point(20, 200);
            e.Graphics.DrawLine(bluePen, pt1, pt2);

            PointF ptf1 = new PointF(20.0f, 20.0f);
            PointF ptf2 = new PointF(200.0f, 200.0f);
            e.Graphics.DrawLine (greenPen, ptf1, ptf2);

            int X1 = 60, Y1 = 40;
            int X2 = 250, Y2 = 100;
            e.Graphics.DrawLine(blackPen, X1, Y1, X2, Y2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
