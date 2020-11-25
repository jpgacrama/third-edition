namespace DinnerParty_first_version
{
    internal class DinnerParty
    {
        private const int CostOfFoodPerPerson = 25;
        private int numberOfPeople;
        private decimal CostOfBeveragesPerPerson;
        private decimal CostOfDecorations = 0;

        // Constructor
        public DinnerParty(int numPeople) { numberOfPeople = numPeople; }

        public void SetNumberOfPeople(int numPeople)
        {
            numberOfPeople = numPeople;
        }

        public int GetNumberOfPeople()
        {
            return numberOfPeople;
        }

        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
            {
                CostOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.00M;
            }
        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
            {
                CostOfDecorations = (numberOfPeople * 15.00M) + 50M;
            }
            else
            {
                CostOfDecorations = (numberOfPeople * 7.50M) + 30M;
            }
        }

        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = CostOfDecorations +
                   ((CostOfBeveragesPerPerson + CostOfFoodPerPerson)
                       * numberOfPeople);

            if (healthyOption)
            {
                return totalCost * .95M;
            }
            else
            {
                return totalCost;
            }
        }
    }
}