using System;
using System.Windows.Forms;

namespace MileageCalculator
{
    public partial class Form1 : Form
    {
        private int startingMileage;
        private int endingMileage;
        private double milesTraveled;
        private double reimburseRate = .39;
        private double amountOwed;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startingMileage = (int)numericUpDown1.Value;
            endingMileage = (int)numericUpDown2.Value;
            if (startingMileage < endingMileage)
            {
                milesTraveled = endingMileage - startingMileage;
                amountOwed = milesTraveled * reimburseRate;
                label4.Text = "$" + amountOwed;
            }
            else
            {
                MessageBox.Show(
                    "The starting mileage must be less than the ending mileage",
                    "Cannot Calculate Mileage");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milesTraveled + " miles", "Miles Traveled");
        }
    }
}