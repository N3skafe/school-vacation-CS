using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tutorial07
{
    public partial class DieRollWindowApp : Form
    {
        private Random randomNumber = new Random();
        private int ones, twos, threes, fours, fives, sixs;
        public DieRollWindowApp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            dieLabel1.Text = "";
            dieLabel2.Text = "";
            dieLabel3.Text = "";
            dieLabel4.Text = "";
            dieLabel5.Text = "";
            dieLabel6.Text = "";
            dieLabel7.Text = "";
            dieLabel8.Text = "";
            dieLabel9.Text = "";
            dieLabel10.Text = "";
            dieLabel11.Text = "";
            dieLabel12.Text = "";

            DisplayDie(dieLabel1);
            DisplayDie(dieLabel2);
            DisplayDie(dieLabel3);
            DisplayDie(dieLabel4);
            DisplayDie(dieLabel5);
            DisplayDie(dieLabel6);
            DisplayDie(dieLabel7);
            DisplayDie(dieLabel8);
            DisplayDie(dieLabel9);
            DisplayDie(dieLabel10);
            DisplayDie(dieLabel11);
            DisplayDie(dieLabel12);

            double total = ones + twos + threes + fours + fives + sixs;

            displayTextBox.Text =
                "Face\t\tFrequency\tPrecent\n1\t\t" + ones + "\t\t" +
                String.Format("{0:f2}", ones / total * 100) + "%\n2\t\t" + twos + "\t\t" +
                String.Format("{0:f2}", twos / total * 100) + "%\n3\t\t" + threes + "\t\t" +
                String.Format("{0:f2}", threes / total * 100) + "%\n4\t\t" + fours + "\t\t" +
                String.Format("{0:f2}", fours / total * 100) + "%\n5\t\t" + fives + "\t\t" +
                String.Format("{0:f2}", fives / total * 100) + "%\n6\t\t" + sixs + "\t\t" +
                String.Format("{0:f2}", sixs / total * 100) + "%";
        }
        public void DisplayDie(Label dieLabel)
        {
            int face = randomNumber.Next(1, 7);
            dieLabel.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\die" + face + ".gif");

            switch (face)
            {
                case 1:
                    ones++;
                    break;
                case 2:
                    twos++;
                    break;
                case 3:
                    threes++;
                    break;
                case 4:
                    fours++;
                    break;
                case 5:
                    fives++;
                    break;
                case 6:
                    sixs++;
                    break;
            }
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
