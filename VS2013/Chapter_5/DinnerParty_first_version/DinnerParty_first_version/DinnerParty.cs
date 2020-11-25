namespace DinnerParty_first_version
{
    internal class DinnerParty
    {
        private const int CostOfFoodPerPerson = 25;
        private int NumberOfPeople;
        private decimal CostOfBeveragesPerPerson;
        private decimal CostOfDecorations = 0;

        // Constructor
        public DinnerParty(int numPeople) { NumberOfPeople = numPeople; }

        // Access Modifier
        public void SetNumberOfPeople(int numPeople)
        {
            NumberOfPeople = numPeople;
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
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }
        }

        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = CostOfDecorations +
                   ((CostOfBeveragesPerPerson + CostOfFoodPerPerson)
                       * NumberOfPeople);

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