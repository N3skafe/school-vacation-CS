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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Paint(object sender, PaintEventArgs e)
        {
            string drawString = "Hello mother fucker";

            Font drawFont = new Font("Arial", 14);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            Rectangle rect = new Rectangle(20, 20, 200, 200);

            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;

            e.Graphics.DrawString(drawString, drawFont, blueBrush, rect, drawFormat);
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
