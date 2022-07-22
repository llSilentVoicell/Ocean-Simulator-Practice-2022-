using OceanLib.Interfaces;
using System.Collections.Generic;

namespace OceanLib
{
    public class ParticipantsDirection : IDirection
    {
        #region [Variables]

        private IOceanCell _owner;

        Randomize random = new Randomize();

        private int _x;
        private int _y;

        #endregion

        #region [Constructor]

        public ParticipantsDirection(IOceanCell owner)
        {
            _owner = owner;
        }

        #endregion

        #region [Methods]

        public Coordinate GetEmptyNeighborCoord(Coordinate coord)
        {
            List<Coordinate> coordinates = new List<Coordinate>();

            int choice;

            if (coord.X + 1 < _owner.NumRows)
            {
                (_x, _y) = GetSouth(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Cell))
                {
                    coordinates.Add(_owner.Cells[_x, _y].OffSet);
                }
            }

            if (coord.X - 1 >= 0)
            {
                (_x, _y) = GetNorth(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Cell))
                {
                    coordinates.Add(_owner.Cells[_x, _y].OffSet);
                }
            }

            if (coord.Y + 1 < _owner.NumCols)
            {
                (_x, _y) = GetEast(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Cell))
                {
                    coordinates.Add(_owner.Cells[_x, _y].OffSet);
                }
            }

            if (coord.Y - 1 >= 0)
            {
                (_x, _y) = GetWest(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Cell))
                {
                    coordinates.Add(_owner.Cells[_x, _y].OffSet);
                }
            }

            if (coord.X + 1 < _owner.NumRows && coord.Y + 1 < _owner.NumCols)
            {
                (_x, _y) = GetSouthEast(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Cell))
                {
                    coordinates.Add(_owner.Cells[_x, _y].OffSet);
                }
            }

            if (coord.X + 1 < _owner.NumRows && coord.Y - 1 >= 0)
            {
                (_x, _y) = GetSouthWest(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Cell))
                {
                    coordinates.Add(_owner.Cells[_x, _y].OffSet);
                }
            }

            if (coord.X - 1 >= 0 && coord.Y - 1 >= 0)
            {
                (_x, _y) = GetNorthWest(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Cell))
                {
                    coordinates.Add(_owner.Cells[_x, _y].OffSet);
                }
            }

            if (coord.X - 1 >= 0 && coord.Y + 1 < _owner.NumCols)
            {
                (_x, _y) = GetNorthEast(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Cell))
                {
                    coordinates.Add(_owner.Cells[_x, _y].OffSet);
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

            if (coord.X + 1 < _owner.NumRows)
            {
                (_x, _y) = GetSouth(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Prey) || _owner.Cells[_x, _y].GetType() == typeof(SmartPrey))
                {
                    coordinates.Add(_owner.Cells[_x, _y].OffSet);
                }
            }

            if (coord.X - 1 >= 0)
            {
                (_x, _y) = GetNorth(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Prey) || _owner.Cells[_x, _y].GetType() == typeof(SmartPrey))
                {
                    coordinates.Add(_owner.Cells[_x, _y].OffSet);
                }
            }

            if (coord.Y + 1 < _owner.NumCols)
            {
                (_x, _y) = GetEast(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Prey) || _owner.Cells[_x, _y].GetType() == typeof(SmartPrey))
                {
                    coordinates.Add(_owner.Cells[_x, _y].OffSet);
                }
            }

            if (coord.Y - 1 >= 0)
            {
                (_x, _y) = GetWest(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Prey) || _owner.Cells[_x, _y].GetType() == typeof(SmartPrey))
                {
                    coordinates.Add(_owner.Cells[_x, _y].OffSet);
                }
            }

            if (coord.X + 1 < _owner.NumRows && coord.Y + 1 < _owner.NumCols)
            {
                (_x, _y) = GetSouthEast(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Prey) || _owner.Cells[_x, _y].GetType() == typeof(SmartPrey))
                {
                    coordinates.Add(_owner.Cells[_x, _y].OffSet);
                }
            }

            if (coord.X + 1 < _owner.NumRows && coord.Y - 1 >= 0)
            {
                (_x, _y) = GetSouthWest(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Prey) || _owner.Cells[_x, _y].GetType() == typeof(SmartPrey))
                {
                    coordinates.Add(_owner.Cells[_x, _y].OffSet);
                }
            }

            if (coord.X - 1 >= 0 && coord.Y - 1 >= 0)
            {
                (_x, _y) = GetNorthWest(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Prey) || _owner.Cells[_x, _y].GetType() == typeof(SmartPrey))
                {
                    coordinates.Add(_owner.Cells[_x, _y].OffSet);
                }
            }

            if (coord.X - 1 >= 0 && coord.Y + 1 < _owner.NumCols)
            {
                (_x, _y) = GetNorthEast(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Prey) || _owner.Cells[_x, _y].GetType() == typeof(SmartPrey))
                {
                    coordinates.Add(_owner.Cells[_x, _y].OffSet);
                }
            }

            if (coordinates.Count == 0)
                return null;

            choice = random.RandomNumber(coordinates.Count - 1);

            return coordinates[choice];
        }

        public Coordinate GetPredatorNeighborCoord(Coordinate coord)
        {
            List<Coordinate> coordinates = new List<Coordinate>();

            if (coord.X + 1 < _owner.NumRows && coord.X - 1 >= 0)
            {
                (_x, _y) = GetSouth(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Predator))
                {
                    (_x, _y) = GetNorth(coord);

                    SetSmartPreyCoord(_x, _y, coordinates);

                }
            }

            if (coord.X - 1 >= 0 && coord.X + 1 < _owner.NumRows)
            {
                (_x, _y) = GetNorth(coord);

                if (_owner.Cells[coord.X - 1, coord.Y].GetType() == typeof(Predator))
                {
                    (_x, _y) = GetNorth(coord);

                    SetSmartPreyCoord(_x, _y, coordinates);
                }
            }

            if (coord.Y + 1 < _owner.NumCols && coord.Y - 1 >= 0)
            {
                (_x, _y) = GetEast(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Predator))
                {
                    (_x, _y) = GetWest(coord);

                    SetSmartPreyCoord(_x, _y, coordinates);

                }
            }

            if (coord.Y - 1 >= 0 && coord.Y + 1 < _owner.NumCols)
            {
                (_x, _y) = GetWest(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Predator))
                {
                    (_x, _y) = GetEast(coord);

                    SetSmartPreyCoord(_x, _y, coordinates);
                }
            }

            if (coord.X + 1 < _owner.NumRows && coord.Y + 1 < _owner.NumCols && coord.X - 1 >= 0 && coord.Y - 1 >= 0)
            {
                (_x, _y) = GetSouthEast(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Predator))
                {
                    (_x, _y) = GetNorthWest(coord);

                    SetSmartPreyCoord(_x, _y, coordinates);
                }
            }

            if (coord.X - 1 >= 0 && coord.Y - 1 >= 0 && coord.X + 1 < _owner.NumRows && coord.Y + 1 < _owner.NumCols)
            {
                (_x, _y) = GetNorthWest(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Predator))
                {
                    (_x, _y) = GetSouthEast(coord);

                    SetSmartPreyCoord(_x, _y, coordinates);

                }
            }

            if (coord.X + 1 < _owner.NumRows && coord.Y - 1 >= 0 && coord.X - 1 >= 0 && coord.Y + 1 < _owner.NumCols)
            {
                (_x, _y) = GetSouthWest(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Predator))
                {
                    (_x, _y) = GetNorthEast(coord);

                    SetSmartPreyCoord(_x, _y, coordinates);

                }
            }

            if (coord.X - 1 >= 0 && coord.Y + 1 < _owner.NumCols && coord.X + 1 < _owner.NumRows && coord.Y - 1 >= 0)
            {
                (_x, _y) = GetNorthEast(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Predator))
                {
                    (_x, _y) = GetSouthWest(coord);

                    SetSmartPreyCoord(_x, _y, coordinates);

                }
            }

            if (coord.X - 2 >= 0 && coord.X + 1 < _owner.NumRows)
            {
                (_x, _y) = GetDoubleNorth(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Predator))
                {
                    (_x, _y) = GetSouth(coord);

                    SetSmartPreyCoord(_x, _y, coordinates);
                }
            }

            if (coord.X - 2 >= 0 && coord.X + 1 < _owner.NumRows && coord.Y - 1 >= 0 && coord.Y + 1 < _owner.NumCols)
            {
                (_x, _y) = GetDoubleNorthEast(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Predator))
                {
                    (_x, _y) = GetSouthWest(coord);

                    SetSmartPreyCoord(_x, _y, coordinates);
                }
            }

            if (coord.X - 2 >= 0 && coord.X + 1 < _owner.NumRows && coord.Y - 1 >= 0 && coord.Y + 2 < _owner.NumCols)
            {
                (_x, _y) = GetDoubleNorthDoubleEast(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Predator))
                {
                    (_x, _y) = GetSouthWest(coord);

                    SetSmartPreyCoord(_x, _y, coordinates);
                }
            }

            if (coord.X + 1 < _owner.NumRows && coord.X - 1 >= 0 && coord.Y - 1 >= 0 && coord.Y + 2 < _owner.NumCols)
            {
                (_x, _y) = GetNorthDoubleEast(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Predator))
                {
                    (_x, _y) = GetSouthWest(coord);

                    SetSmartPreyCoord(_x, _y, coordinates);
                }
            }

            if (coord.Y - 1 >= 0 && coord.Y + 2 < _owner.NumCols)
            {
                (_x, _y) = GetDoubleEast(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Predator))
                {
                    (_x, _y) = GetWest(coord);

                    SetSmartPreyCoord(_x, _y, coordinates);
                }
            }

            if (coord.X + 1 < _owner.NumRows && coord.X - 1 >= 0 && coord.Y + 2 < _owner.NumCols && coord.Y - 1 >= 0)
            {
                (_x, _y) = GetSouthDoubleEast(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Predator))
                {
                    (_x, _y) = GetNorthWest(coord);

                    SetSmartPreyCoord(_x, _y, coordinates);
                }
            }

            if (coord.X + 2 < _owner.NumRows && coord.X - 1 >= 0 && coord.Y + 2 < _owner.NumCols && coord.Y - 1 >= 0)
            {
                (_x, _y) = GetDoubleSouthDoubleEast(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Predator))
                {
                    (_x, _y) = GetNorthWest(coord);

                    SetSmartPreyCoord(_x, _y, coordinates);
                }
            }

            if (coord.X + 2 < _owner.NumRows && coord.X - 1 >= 0 && coord.Y + 1 < _owner.NumCols && coord.Y - 1 >= 0)
            {
                (_x, _y) = GetDoubleSouthEast(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Predator))
                {
                    (_x, _y) = GetNorthWest(coord);

                    SetSmartPreyCoord(_x, _y, coordinates);
                }
            }

            if (coord.X - 1 >= 0 && coord.X + 2 < _owner.NumRows)
            {
                (_x, _y) = GetDoubleSouth(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Predator))
                {
                    (_x, _y) = GetNorth(coord);

                    SetSmartPreyCoord(_x, _y, coordinates);
                }
            }

            if (coord.X + 2 < _owner.NumRows && coord.X - 1 >= 0 && coord.Y - 1 >= 0 && coord.Y + 1 < _owner.NumCols)
            {
                (_x, _y) = GetDoubleSouthWest(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Predator))
                {
                    (_x, _y) = GetNorthEast(coord);

                    SetSmartPreyCoord(_x, _y, coordinates);
                }
            }

            if (coord.X + 2 < _owner.NumRows && coord.X - 1 >= 0 && coord.Y - 2 >= 0 && coord.Y + 1 < _owner.NumCols)
            {
                (_x, _y) = GetDoubleSouthDoubleWest(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Predator))
                {
                    (_x, _y) = GetNorthEast(coord);

                    SetSmartPreyCoord(_x, _y, coordinates);
                }
            }

            if (coord.X + 1 < _owner.NumRows && coord.X - 1 >= 0 && coord.Y - 2 >= 0 && coord.Y + 1 < _owner.NumCols)
            {
                (_x, _y) = GetSouthDoubleWest(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Predator))
                {
                    (_x, _y) = GetNorthEast(coord);

                    SetSmartPreyCoord(_x, _y, coordinates);
                }
            }

            if (coord.Y - 2 >= 0 && coord.Y + 1 < _owner.NumCols)
            {
                (_x, _y) = GetDoubleWest(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Predator))
                {
                    (_x, _y) = GetEast(coord);

                    SetSmartPreyCoord(_x, _y, coordinates);
                }
            }

            if (coord.X + 1 < _owner.NumRows && coord.X - 1 >= 0 && coord.Y - 2 >= 0 && coord.Y + 1 < _owner.NumCols)
            {
                (_x, _y) = GetNorthDoubleWest(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Predator))
                {
                    (_x, _y) = GetSouthEast(coord);

                    SetSmartPreyCoord(_x, _y, coordinates);
                }
            }

            if (coord.X + 1 < _owner.NumRows && coord.X - 2 >= 0 && coord.Y - 2 >= 0 && coord.Y + 1 < _owner.NumCols)
            {
                (_x, _y) = GetDoubleNorthDoubleWest(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Predator))
                {
                    (_x, _y) = GetSouthEast(coord);

                    SetSmartPreyCoord(_x, _y, coordinates);
                }
            }

            if (coord.X + 1 < _owner.NumRows && coord.X - 2 >= 0 && coord.Y - 1 >= 0 && coord.Y + 1 < _owner.NumCols)
            {
                (_x, _y) = GetDoubleNorthWest(coord);

                if (_owner.Cells[_x, _y].GetType() == typeof(Predator))
                {
                    (_x, _y) = GetSouthEast(coord);

                    SetSmartPreyCoord(_x, _y, coordinates);
                }
            }

            if (coordinates.Count == 0)
            {
                return null;
            }

            return coordinates[0];
        }

        private void SetSmartPreyCoord(int x, int y, List<Coordinate> allCoordinates)
        {
            if (_owner.Cells[x, y].GetType() != typeof(Predator) &&
                            _owner.Cells[x, y].GetType() != typeof(Prey) &&
                            _owner.Cells[x, y].GetType() != typeof(Obstacle) &&
                            _owner.Cells[x, y].GetType() != typeof(SmartPrey))
            {
                if (allCoordinates.Count != 1)
                {
                    allCoordinates.Add(_owner.Cells[x, y].OffSet);
                }
                else
                {
                    allCoordinates.RemoveAt(allCoordinates.Count - 1);
                    allCoordinates.Add(_owner.Cells[x, y].OffSet);
                }
            }
        }

        #endregion

        #region [Neighbors]

        private (int, int) GetNorth(Coordinate coord)
        {
            return (coord.X - 1, coord.Y);
        }

        private (int, int) GetNorthEast(Coordinate coord)
        {
            return (coord.X - 1, coord.Y+1);
        }

        private (int, int) GetEast(Coordinate coord)
        {
            return (coord.X, coord.Y + 1);
        }

        private (int, int) GetSouthEast(Coordinate coord)
        {
            return (coord.X + 1, coord.Y + 1);
        }

        private (int, int) GetSouth(Coordinate coord)
        {
            return (coord.X + 1, coord.Y);
        }

        private (int, int) GetSouthWest(Coordinate coord)
        {
            return (coord.X + 1, coord.Y - 1);
        }

        private (int, int) GetWest(Coordinate coord)
        {
            return (coord.X, coord.Y - 1);
        }

        private (int, int) GetNorthWest(Coordinate coord)
        {
            return (coord.X - 1, coord.Y - 1);
        }

        private (int, int) GetDoubleNorth(Coordinate coord)
        {
            return (coord.X - 2, coord.Y);
        }

        private (int, int) GetDoubleNorthEast(Coordinate coord)
        {
            return (coord.X - 2, coord.Y + 1);
        }

        private (int, int) GetDoubleNorthDoubleEast(Coordinate coord)
        {
            return (coord.X - 1, coord.Y + 2);
        }

        private (int, int) GetNorthDoubleEast(Coordinate coord)
        {
            return (coord.X - 1, coord.Y + 2);
        }

        private (int, int) GetDoubleEast(Coordinate coord)
        {
            return (coord.X, coord.Y + 2);
        }

        private (int, int) GetSouthDoubleEast(Coordinate coord)
        {
            return (coord.X + 1, coord.Y + 2);
        }

        private (int, int) GetDoubleSouthDoubleEast(Coordinate coord)
        {
            return (coord.X + 2, coord.Y + 2);
        }

        private (int, int) GetDoubleSouthEast(Coordinate coord)
        {
            return (coord.X + 2, coord.Y + 1);
        }

        private (int, int) GetDoubleSouth(Coordinate coord)
        {
            return (coord.X + 2, coord.Y);
        }

        private (int, int) GetDoubleSouthWest(Coordinate coord)
        {
            return (coord.X + 2, coord.Y - 1);
        }

        private (int, int) GetDoubleSouthDoubleWest(Coordinate coord)
        {
            return (coord.X + 2, coord.Y - 2);
        }

        private (int, int) GetSouthDoubleWest(Coordinate coord)
        {
            return (coord.X + 1, coord.Y - 2);
        }

        private (int, int) GetDoubleWest(Coordinate coord)
        {
            return (coord.X, coord.Y - 2);
        }

        private (int, int) GetNorthDoubleWest(Coordinate coord)
        {
            return (coord.X - 1, coord.Y - 2);
        }

        private (int, int) GetDoubleNorthDoubleWest(Coordinate coord)
        {
            return (coord.X - 2, coord.Y - 2);
        }

        private (int, int) GetDoubleNorthWest(Coordinate coord)
        {
            return (coord.X - 2, coord.Y - 1);
        }

        #endregion
    }
}