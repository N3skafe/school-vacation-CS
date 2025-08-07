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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);

            Pen bluePen = new Pen(Color.Blue, 1);

            Rectangle rect = new Rectangle(20, 20, 100, 100);

            float startAngle = 0.0f;
            float sweepAngle = 90.0f;

            e.Graphics.DrawPie(bluePen, rect, startAngle, sweepAngle);
        }
    }
}
