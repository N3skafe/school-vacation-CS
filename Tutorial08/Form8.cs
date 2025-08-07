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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Image newImage = Image.FromFile("TEST.JPG");

                e.Graphics.DrawImage(newImage, this.ClientRectangle);
                newImage.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
    }
}
