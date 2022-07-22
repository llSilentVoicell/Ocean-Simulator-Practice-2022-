using OceanLib;
using OceanLib.Interfaces;
using System.Windows.Forms;
using System.Drawing;

namespace OceanSimulator__WinForms_
{
    public class DisplayElements : IDisplayElements, IOceanView
    {
        #region [Variables]

        private int numIterations;

        public int numOfOceans;

        private int _numPrey;
        private int _numPredators;
        private int _numObstacles;

        private Bitmap _obstacleImage = new Bitmap(Properties.Resources.stone);
        private Bitmap _preyImage = new Bitmap(Properties.Resources.fish);
        private Bitmap _smartPreyImage = new Bitmap(Properties.Resources.smart_fish);
        private Bitmap _predatorImage = new Bitmap(Properties.Resources.Shark);

        #endregion

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

        #region [Methods]

        public void CountParticipants(Ocean owner)
        {
            int preys = 0;
            int predators = 0;

            for (int i = 0; i < owner.NumRows; i++)
            {
                for (int j = 0; j < owner.NumCols; j++)
                {
                    if (owner.Cells[i, j].Image == 'D' || owner.Cells[i, j].Image == 'F')
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
                    if(owner.cells[i, j].Image == 'D')
                    {
                        gridView.Rows[i].Cells[j].Value = _preyImage;
                    }
                    else if (owner.cells[i, j].Image == 'F')
                    {
                        gridView.Rows[i].Cells[j].Value = _smartPreyImage;
                    }
                    else if(owner.cells[i, j].Image == 'S')
                    {
                        gridView.Rows[i].Cells[j].Value = _predatorImage;
                    }
                    else if (owner.cells[i, j].Image == '#')
                    {
                        gridView.Rows[i].Cells[j].Value = _obstacleImage;
                    }
                    else
                    {
                        gridView.Rows[i].Cells[j].Value = null;
                    }
                }
            }
        }

        #endregion
    }
}
