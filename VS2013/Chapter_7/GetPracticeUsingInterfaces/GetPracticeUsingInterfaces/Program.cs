namespace GetPracticeUsingInterfaces
{
    public class Program
    {
        private static void Main(string[] args)
        {
            TallGuy tallGuy = new TallGuy() { Height = 74, Name = "Jimmy" };
            tallGuy.TalkAboutYourself();
        }
    }
}