using System;
using System.Windows.Forms;

namespace SwappingElephants
{
    public partial class Form1 : Form
    {
        private Elephant lucinda;
        private Elephant lloyd;

        public Form1()
        {
            InitializeComponent();
            lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
            lloyd.TellMe("Hi", lucinda);
            lucinda.SpeakTo(lloyd, "Hello");
        }

        private void LloydButton_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void LucindaButton_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void SwapButton_Click(object sender, EventArgs e)
        {
            Elephant holder;
            holder = lloyd;
            lloyd = lucinda;
            lucinda = holder;
            MessageBox.Show("Objects swapped");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lloyd = lucinda;
            lloyd.EarSize = 4321;
            lloyd.WhoAmI();
        }
    }
}