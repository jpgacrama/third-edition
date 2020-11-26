﻿using System;
using System.Windows.Forms;

namespace BeehiveManagementSystem
{
    public partial class Form1 : Form
    {
        private const int QUEEN_BEE_WEIGHT = 275;

        public Form1()
        {
            InitializeComponent();
            workerBeeJob.SelectedIndex = 0;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" }, 175);
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" }, 114);
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" }, 149);
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing",
                                                   "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol" }, 155);
            queen = new Queen(workers, QUEEN_BEE_WEIGHT);
        }

        private Queen queen;

        private void assignJob_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(workerBeeJob.Text, (int)shifts.Value) == false)
                MessageBox.Show("No workers are available to do the job ‘"
                    + workerBeeJob.Text + "’", "The queen bee says...");
            else
                MessageBox.Show("The job ‘" + workerBeeJob.Text + "’ will be done in "
                    + shifts.Value + " shifts", "The queen bee says...");
        }

        private void nextShift_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextShift();
        }
    }
}