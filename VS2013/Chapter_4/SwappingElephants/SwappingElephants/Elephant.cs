namespace SwappingElephants
{
    using System.Windows.Forms;

    internal class Elephant
    {
        public int EarSize;
        public string Name;

        public void WhoAmI()
        {
            MessageBox.Show("My ears are " + EarSize + " inches tall.",
               Name + " says…");
        }
    }
}