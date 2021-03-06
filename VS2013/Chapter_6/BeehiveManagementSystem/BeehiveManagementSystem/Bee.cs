﻿namespace BeehiveManagementSystem
{
    public class Bee
    {
        public const double HoneyUnitsConsumedPerMg = .25;

        public double WeightMg { get; private set; }

        public Bee(double weightMg)
        {
            WeightMg = weightMg;
        }

        virtual public double HoneyConsumptionRate()
        {
            return WeightMg * HoneyUnitsConsumedPerMg;
        }
    }
}