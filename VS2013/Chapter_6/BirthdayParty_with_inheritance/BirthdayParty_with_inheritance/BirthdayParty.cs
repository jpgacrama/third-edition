namespace BirthdayParty_with_inheritance
{
    internal class BirthdayParty : Party
    {
        private const int DEFAULT_CAKE_SIZE = 8;
        private const int LARGE_CAKE_SIZE = 16;
        private const decimal MAX_WRITING_LENGTH = 40;

        public BirthdayParty(int numberOfPeople,
                             bool fancyDecorations,
                             string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }

        public string CakeWriting { get; set; }

        private int ActualLength
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                    return MaxWritingLength();
                else
                    return CakeWriting.Length;
            }
        }

        private int CakeSize()
        {
            if (NumberOfPeople <= 4)
                return DEFAULT_CAKE_SIZE;
            else
                return LARGE_CAKE_SIZE;
        }

        private int MaxWritingLength()
        {
            if (CakeSize() == DEFAULT_CAKE_SIZE)
                return LARGE_CAKE_SIZE;
            else
                // possible modulo effect since MAX_WRITING_LENGTH is decimal
                return (int)MAX_WRITING_LENGTH;
        }

        public bool CakeWritingTooLong
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                    return true;
                else
                    return false;
            }
        }

        override public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                decimal cakeCost;
                if (CakeSize() == DEFAULT_CAKE_SIZE)
                    cakeCost = MAX_WRITING_LENGTH + ActualLength * .25M;
                else
                    cakeCost = 75M + ActualLength * .25M;
                return totalCost + cakeCost;
            }
        }
    }
}