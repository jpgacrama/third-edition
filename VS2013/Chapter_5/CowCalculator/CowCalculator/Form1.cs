using System;
using System.Windows.Forms;

namespace CowCalculator
{
    public partial class Form1 : Form
    {
        private Farmer farmer;

        public Form1()
        {
            InitializeComponent();
            farmer = new Farmer(15, 30);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            farmer.NumberOfCows = (int)numericUpDown1.Value;
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            Console.WriteLine("I need " + farmer.BagsOfFeed + " bags of feed for "
                + farmer.NumberOfCows + " cows");
        }
    }
}