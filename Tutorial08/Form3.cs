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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            Pen greenPen = new Pen(Color.Green, 4);

            RectangleF[] rectArray =
            {
                new RectangleF(5.0f, 5.0f, 100.0f, 200.0f),
                new RectangleF(20.0f, 20.0f, 80.0f, 40.0f),
                new RectangleF(60.0f, 80.0f, 140.0f, 50.0f)
            };
            e.Graphics.DrawRectangles(greenPen, rectArray);
        }
    }
}
