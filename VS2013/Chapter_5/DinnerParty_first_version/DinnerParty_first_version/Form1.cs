using System;
using System.Windows.Forms;

namespace DinnerParty_first_version
{
    public partial class Form1 : Form
    {
        private DinnerParty dinnerParty;

        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty(5);
            dinnerParty.CalculateCostOfDecorations(FancyDecorationsCheckbox.Checked);
            dinnerParty.SetHealthyOption(HealthyOptionCheckbox.Checked);
            DisplayDinnerPartyCost();
        }

        private void FancyDecorationsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(FancyDecorationsCheckbox.Checked);
            DisplayDinnerPartyCost();
        }

        private void HealthyOptionCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(HealthyOptionCheckbox.Checked);
            DisplayDinnerPartyCost();
        }

        private void NumberOfPeopleListBox_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.SetNumberOfPeople((int)NumberOfPeopleListBox.Value);
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(HealthyOptionCheckbox.Checked);
            costLabel.Text = Cost.ToString("c");
        }
    }
}