using System;

namespace OceanLib
{
    public class AddCells
    {
        #region [Variables]

        readonly Random random = new Random((int)DateTime.Now.Ticks);

        #endregion

        #region [Methods]

        public void AddAllCells(Ocean owner)
        {
            AddEmptyCells(owner);
            AddObstacles(owner);
            AddPrey(owner);
            AddPredators(owner);
        }

        public Coordinate GetEmptyCellCoord(Ocean owner)
        {
            Coordinate coord = new Coordinate();

            for (int i = 0; i < (owner.NumCols * owner.NumRows); i++)
            {
                int RowCoord = random.Next(0, owner.NumRows);
                int ColCoord = random.Next(0, owner.NumCols);

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
                Coordinate coord = GetEmptyCellCoord(owner);
                owner.cells[coord.X, coord.Y] = new Prey(coord, owner, Constants.TimeToReproduce);
            }
        }

        #endregion
    }
}
