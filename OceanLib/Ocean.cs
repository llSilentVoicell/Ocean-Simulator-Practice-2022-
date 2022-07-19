using OceanLib.Interfaces;
using System.Collections.Generic;

namespace OceanLib
{
    public class Ocean : IOceanCell
    {
        #region [Variables]

        public Cell[,] cells;

        private static int _numRows = Constants.MaxRows;
        private static int _numCols = Constants.MaxCols;

        private int _numPrey = Constants.DefaultNumPrey;
        private int _numPredators = Constants.DefaultNumPredators;
        private int _numObstacles = Constants.DefaultNumObstacles;

        public static Randomize random;
        private AddCells _addCells;

        #endregion

        #region [Properties]

        public int NumPrey
        {
            get { return _numPrey; }
            set { _numPrey = value; }
        }

        public int NumPredators
        {
            get { return _numPredators; }
            set { _numPredators = value; }
        }

        public int NumObstacles
        {
            get { return _numObstacles; }
            set { _numObstacles = value; }
        }

        public int NumRows
        {
            get { return _numRows; }
            set { _numRows = value; }
        }

        public int NumCols
        {
            get { return _numCols; }
            set { _numCols = value; }
        }

        public Cell[,] Cells
        {
            get { return cells; }
        }

        #endregion

        #region [Methods]

        public void Initialize(IOceanView oceanView)
        {
            cells = new Cell[_numRows, _numCols];
            random = new Randomize();
            _addCells = new AddCells();

            InitializeCells(oceanView);
        }

        public void InitializeCells(IOceanView oceanView)
        {
            _numPrey = oceanView.UserNumPrey;
            _numPredators = oceanView.UserNumPredators;
            _numObstacles = oceanView.UserNumObstacles;

            _addCells.AddAllCells(this);
        }

        public void Run(int iteration)
        {
            for (int i = 0; i < _numRows; i++)
            {
                for (int j = 0; j < _numCols; j++)
                {
                    cells[i, j].wasNotProcessed = true;
                }
            }
            
            for (int i = 0; i < _numRows; i++)
            {
                for (int j = 0; j < _numCols; j++)
                {
                    cells[i, j].Process(iteration);
                }
            } 
        }

        #endregion

        #region [Neighbors]
        public Coordinate GetEmptyNeighborCoord(Coordinate coord)
        {
            List<Coordinate> coordinates = new List<Coordinate>();

            int choice;

            if (coord.X + 1 < NumRows)
            {
                if (Cells[coord.X + 1, coord.Y].GetType() == typeof(Cell))
                {
                    coordinates.Add(Cells[coord.X + 1, coord.Y].OffSet);
                }
            }

            if (coord.X - 1 >= 0)
            {
                if (Cells[coord.X - 1, coord.Y].GetType() == typeof(Cell))
                {
                    coordinates.Add(Cells[coord.X - 1, coord.Y].OffSet);
                }
            }

            if (coord.Y + 1 < NumCols)
            {
                if (Cells[coord.X, coord.Y + 1].GetType() == typeof(Cell))
                {
                    coordinates.Add(Cells[coord.X, coord.Y + 1].OffSet);
                }
            }

            if (coord.Y - 1 >= 0)
            {
                if (Cells[coord.X, coord.Y - 1].GetType() == typeof(Cell))
                {
                    coordinates.Add(Cells[coord.X, coord.Y - 1].OffSet);
                }
            }

            if (coord.X + 1 < NumRows && coord.Y + 1 < NumCols)
            {
                if (Cells[coord.X + 1, coord.Y + 1].GetType() == typeof(Cell))
                {
                    coordinates.Add(Cells[coord.X + 1, coord.Y + 1].OffSet);
                }
            }

            if (coord.X + 1 < NumRows && coord.Y - 1 >= 0)
            {
                if (Cells[coord.X + 1, coord.Y - 1].GetType() == typeof(Cell))
                {
                    coordinates.Add(Cells[coord.X + 1, coord.Y - 1].OffSet);
                }
            }

            if (coord.X - 1 >= 0 && coord.Y - 1 >= 0)
            {
                if (Cells[coord.X - 1, coord.Y - 1].GetType() == typeof(Cell))
                {
                    coordinates.Add(Cells[coord.X - 1, coord.Y - 1].OffSet);
                }
            }

            if (coord.X - 1 >= 0 && coord.Y + 1 < NumCols)
            {
                if (Cells[coord.X - 1, coord.Y + 1].GetType() == typeof(Cell))
                {
                    coordinates.Add(Cells[coord.X - 1, coord.Y + 1].OffSet);
                }
            }

            if (coordinates.Count == 0)
                return null;

            choice = random.RandomNumber(coordinates.Count - 1);

            return coordinates[choice];
        }

        public Coordinate GetPreyNeighborCoord(Coordinate coord)
        {
            List<Coordinate> coordinates = new List<Coordinate>();

            int choice;

            if (coord.X + 1 < NumRows)
            {
                if (Cells[coord.X + 1, coord.Y].GetType() == typeof(Prey))
                {
                    coordinates.Add(Cells[coord.X + 1, coord.Y].OffSet);
                }
            }

            if (coord.X - 1 >= 0)
            {
                if (Cells[coord.X - 1, coord.Y].GetType() == typeof(Prey))
                {
                    coordinates.Add(Cells[coord.X - 1, coord.Y].OffSet);
                }
            }

            if (coord.Y + 1 < NumCols)
            {
                if (Cells[coord.X, coord.Y + 1].GetType() == typeof(Prey))
                {
                    coordinates.Add(Cells[coord.X, coord.Y + 1].OffSet);
                }
            }

            if (coord.Y - 1 >= 0)
            {
                if (Cells[coord.X, coord.Y - 1].GetType() == typeof(Prey))
                {
                    coordinates.Add(Cells[coord.X, coord.Y - 1].OffSet);
                }
            }

            if (coord.X + 1 < NumRows && coord.Y + 1 < NumCols)
            {
                if (Cells[coord.X + 1, coord.Y + 1].GetType() == typeof(Prey))
                {
                    coordinates.Add(Cells[coord.X + 1, coord.Y + 1].OffSet);
                }
            }

            if (coord.X + 1 < NumRows && coord.Y - 1 >= 0)
            {
                if (Cells[coord.X + 1, coord.Y - 1].GetType() == typeof(Prey))
                {
                    coordinates.Add(Cells[coord.X + 1, coord.Y - 1].OffSet);
                }
            }

            if (coord.X - 1 >= 0 && coord.Y - 1 >= 0)
            {
                if (Cells[coord.X - 1, coord.Y - 1].GetType() == typeof(Prey))
                {
                    coordinates.Add(Cells[coord.X - 1, coord.Y - 1].OffSet);
                }
            }

            if (coord.X - 1 >= 0 && coord.Y + 1 < NumCols)
            {
                if (Cells[coord.X - 1, coord.Y + 1].GetType() == typeof(Prey))
                {
                    coordinates.Add(Cells[coord.X - 1, coord.Y + 1].OffSet);
                }
            }

            if (coordinates.Count == 0)
                return null;

            choice = random.RandomNumber(coordinates.Count - 1);

            return coordinates[choice];
        }

        #endregion
    }
}
