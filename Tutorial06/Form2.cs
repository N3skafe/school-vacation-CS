using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial06
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int startDan;
            int lastDan;
            int intResult;
            string strResult;

            startDan=Int32.Parse(textBox1.Text);
            lastDan=Int32.Parse(textBox2.Text);

            listBox1.Items.Clear();

            for (int i = startDan; i <= lastDan; i++)
            {
                for (int j = 1; j <= 100; j++)
                {
                    intResult = i * j;
                    strResult = intResult + "=" + i + "X" + j;
                    listBox1.Items.Add(strResult);

                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
        }
    }
}
