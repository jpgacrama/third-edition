﻿using System;

namespace BeehiveManagementSystem
{
    public class Worker : Bee
    {
        public Worker(string[] jobsICanDo, double weightMg)
            : base(weightMg)
        {
            this.jobsICanDo = jobsICanDo;
        }

        private const double honeyUnitsPerShiftWorked = .65;

        public int ShiftsLeft
        {
            get
            {
                return shiftsToWork - shiftsWorked;
            }
        }

        private string currentJob = "";

        public string CurrentJob
        {
            get
            {
                return currentJob;
            }
        }

        private string[] jobsICanDo;
        private int shiftsToWork;
        private int shiftsWorked;

        public bool DoThisJob(string job, int numberOfShifts)
        {
            if (!String.IsNullOrEmpty(currentJob))
                return false;
            foreach (var item in jobsICanDo)
            {
                if (item == job)
                {
                    currentJob = job;
                    this.shiftsToWork = numberOfShifts;
                    shiftsWorked = 0;
                    return true;
                }
            }
            return false;
        }

        public bool DidYouFinish()
        {
            if (String.IsNullOrEmpty(currentJob))
                return false;
            shiftsWorked++;
            if (shiftsWorked > shiftsToWork)
            {
                shiftsWorked = 0;
                shiftsToWork = 0;
                currentJob = "";
                return true;
            }
            else
                return false;
        }

        public override double HoneyConsumptionRate()
        {
            double consumption = base.HoneyConsumptionRate();
            consumption += shiftsWorked * honeyUnitsPerShiftWorked;
            return consumption;
        }
    }
}