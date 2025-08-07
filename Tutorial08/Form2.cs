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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void Form2_Paint_1(object sender, PaintEventArgs e)
        {
            PointF[] ptsArray =
{
                new PointF(20.0f, 20.0f),
                new PointF(20.0f, 200.0f),
                new PointF(200.0f, 200.0f),
                new PointF(20.0f, 20.0f)
            };
            Pen greenyellowPen = new Pen(Color.GreenYellow, 2);
            e.Graphics.DrawLines(greenyellowPen, ptsArray);
        }
    }
}
