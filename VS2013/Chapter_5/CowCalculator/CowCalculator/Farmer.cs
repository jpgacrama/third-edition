namespace CowCalculator
{
    internal class Farmer
    {
        private int feedMultiplier;

        public int FeedMultiplier
        {
            get { return feedMultiplier; }
            private set
            {
                feedMultiplier = value;
            }
        }

        public int BagsOfFeed { get; private set; }

        public Farmer(int numberOfCows, int feedMultiplier)
        {
            FeedMultiplier = feedMultiplier;
            NumberOfCows = numberOfCows;
        }

        private int numberOfCows;

        public int NumberOfCows
        {
            get
            {
                return numberOfCows;
            }
            set
            {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * FeedMultiplier;
            }
        }
    }
}