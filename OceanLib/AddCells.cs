using System;
using OceanLib.Interfaces;

namespace OceanLib
{
    public class AddCells : IAdd
    {
        #region [Variables]

        Randomize random = new Randomize();

        #endregion

        #region [Methods]

        public void AddAllCells(Ocean owner)
        {
            AddEmptyCells(owner);
            AddObstacles(owner);
            AddPrey(owner);
            AddPredators(owner);
        }

        private Coordinate GetEmptyCellCoord(Ocean owner)
        {
            Coordinate coord = new Coordinate();

            for (int i = 0; i < (owner.NumCols * owner.NumRows); i++)
            {
                int RowCoord = random.RandomNumber(owner.NumRows);
                int ColCoord = random.RandomNumber(owner.NumCols);

                if (owner.cells[RowCoord, ColCoord].GetType() == typeof(Cell))
                {
                    coord.X = RowCoord;
                    coord.Y = ColCoord;

                    break;
                }
            }

            return coord;
        }

        private void AddEmptyCells(Ocean owner)
        {
            for (int i = 0; i < owner.NumRows; i++)
            {
                for (int j = 0; j < owner.NumCols; j++)
                {
                    owner.cells[i, j] = new Cell(new Coordinate
                    {
                        X = i,
                        Y = j,
                    }, owner);
                }
            }
        }

        private void AddObstacles(Ocean owner)
        {
            for (int i = 0; i < owner.NumObstacles; i++)
            {
                Coordinate coord = GetEmptyCellCoord(owner);
                owner.cells[coord.X, coord.Y] = new Obstacle(coord, owner);
            }
        }

        private void AddPredators(Ocean owner)
        {
            for (int i = 0; i < owner.NumPredators; i++)
            {
                Coordinate coord = GetEmptyCellCoord(owner);
                owner.cells[coord.X, coord.Y] = new Predator(coord, owner, Constants.TimeToReproduce, Constants.TimeToFeed);
            }
        }

        private void AddPrey(Ocean owner)
        {
            for (int i = 0; i < owner.NumPrey; i++)
            {
                int smartOrNot = random.RandomNumber(2);

                if (smartOrNot == 0)
                {
                    Coordinate coord = GetEmptyCellCoord(owner);
                    owner.cells[coord.X, coord.Y] = new Prey(coord, owner, Constants.TimeToReproduce);
                }
                if (smartOrNot == 1)
                {
                    Coordinate coord = GetEmptyCellCoord(owner);
                    owner.cells[coord.X, coord.Y] = new SmartPrey(coord, owner, Constants.TimeToReproduce);
                }
            }
        }

        #endregion
    }
}
