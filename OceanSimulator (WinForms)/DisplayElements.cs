﻿using OceanLib;
using OceanLib.Interfaces;
using System.Windows.Forms;
using System.Drawing;

namespace OceanSimulator__WinForms_
{
    public class DisplayElements : IDisplayElements, IOceanView
    {
        private int numIterations;

        public int numOfOceans;

        private int _numPrey;
        private int _numPredators;
        private int _numObstacles;

        #region [Properties]

        public int UserNumPrey
        {
            get { return _numPrey; }
            set { _numPrey = value; }
        }

        public int UserNumPredators
        {
            get { return _numPredators; }
            set { _numPredators = value; }
        }

        public int UserNumObstacles
        {
            get { return _numObstacles; }
            set { _numObstacles = value; }
        }

        public int UserNumIteration
        {
            get { return numIterations; }
            set { numIterations = value; }
        }

        #endregion

        public void CountParticipants(Ocean owner)
        {
            int preys = 0;
            int predators = 0;

            for (int i = 0; i < owner.NumRows; i++)
            {
                for (int j = 0; j < owner.NumCols; j++)
                {
                    if (owner.Cells[i, j].Image == 'f')
                    {
                        preys++;
                    }
                    else if (owner.Cells[i, j].Image == 'S')
                    {
                        predators++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            owner.NumPrey = preys;
            owner.NumPredators = predators;
        }

        public void DisplayStats(Label iterationNum, Label obstaclesNum, Label preysNum, Label predatorsNum, Ocean owner, int iteration, ProgressBar bar)
        {
            iterationNum.Text = iteration.ToString();
            obstaclesNum.Text = owner.NumObstacles.ToString();
            preysNum.Text = owner.NumPrey.ToString();
            predatorsNum.Text = owner.NumPredators.ToString();

            bar.Value = iteration;
        }

        public void DisplayOcean(DataGridView gridView, Ocean owner)
        {
            for (int i = 0; i < Constants.MaxRows; i++)
            {
                for (int j = 0; j < Constants.MaxCols; j++)
                {
                    gridView.Rows[i].Cells[j].Value = owner.cells[i, j].Image;
                }
            }
        }
    }
}
