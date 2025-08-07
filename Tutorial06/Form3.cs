using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial06
{
    public partial class Form3 : Form
    {
        public enum CAL { SUM = 0, SUB = 1, MUL = 2, DIV = 3};
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int op = comboBox1.SelectedIndex;
            //object op2 = comboBox1.SelectedItem; //연산자 +, -, *, / ect..

            int num1 = Int32.Parse(textBox1.Text);
            int num2 =Int32.Parse(textBox2.Text); 
            int result;

            switch ((CAL)op)
            {
                case CAL.SUM:
                    result = num1 + num2;
                    textBox3.Text=result.ToString();
                    break;
                case CAL.SUB:
                    result = num1 - num2;
                    textBox3.Text=result.ToString();
                    break;
                case CAL.MUL:
                    result = num1 * num2;
                    textBox3.Text=result.ToString();
                    break;
                case CAL.DIV:
                    result = num1 / num2;
                    textBox3.Text=result.ToString();
                    break;
            }
        }
    }
}
