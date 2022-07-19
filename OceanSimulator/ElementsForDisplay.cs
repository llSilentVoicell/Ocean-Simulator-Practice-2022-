using OceanLib;
using OceanLib.Interfaces;

namespace OceanSimulator
{
    class ElementsForDisplay : IDisplayElements
    {
        #region [Methods]

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

        public char[,] GetIterationImage(char[,] iterationImage, string stats, Ocean owner, int iterationRows, int iterationCols)
        {
            for (int i = 0; i < iterationRows; i++)
            {
                for (int j = 0; j < iterationCols; j++)
                {
                    if (i == 0)
                    {
                        if (j < stats.Length)
                        {
                            iterationImage[i, j] = stats[j];
                        }
                        else
                        {
                            iterationImage[i, j] = ' ';
                        }
                    }
                    else if (i == 1 || i == iterationRows - 1)
                    {
                        if (j < Constants.MaxCols)
                        {
                            iterationImage[i, j] = '@';
                        }
                        else
                        {
                            iterationImage[i, j] = ' ';
                        }
                    }
                    else
                    {
                        if (j < Constants.MaxCols)
                        {
                            iterationImage[i, j] = owner.Cells[i - 2, j].Image;
                        }
                        else
                        {
                            iterationImage[i, j] = ' ';
                        }
                    }
                }
            }

            return iterationImage;
        }

        #endregion
    }
}
