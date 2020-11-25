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

        public void TellMe(string message, Elephant whoSaidIt)
        {
            MessageBox.Show(whoSaidIt.Name + " says: " + message);
        }

        public void SpeakTo(Elephant talkTo, string message)
        {
            talkTo.TellMe(message, this);
        }
    }
}