using OceanLib.Interfaces;

namespace OceanLib
{
    public class Predator : Prey
    {
        #region [Variables]

        protected int _timeToFeed;

        #endregion

        #region [Constructor]

        public Predator(Coordinate offset, IOceanCell owner, int timeToProcreate, int timeToEat) : base(offset, owner, timeToProcreate)
        {
            _timeToReproduce = timeToProcreate;
            _timeToFeed = timeToEat;
            image = Constants.DefaultPredImage;

            wasNotProcessed = false;

            _dir = new ParticipantsDirection(owner);
        }

        #endregion

        #region [Methods]

        protected override Prey Reproduce(Coordinate coord)
        {
            if (coord != null)
            {
                Predator newborn = new Predator(coord, _owner, Constants.TimeToReproduce, Constants.TimeToFeed);
                _timeToReproduce = Constants.TimeToReproduce;

                return newborn;
            }
            else
            {
                return this;
            }
        }

        protected override void Move(Coordinate oldCoord, Coordinate newCoord, int iteration)
        {
            Coordinate preyCoord = _dir.GetPreyNeighborCoord(OffSet);

            if (iteration != _lastIterationNumber)
            {
                _timeToReproduce--;
                _timeToFeed--;
                _lastIterationNumber = iteration;
            }

            if (_timeToFeed <= 0)
            {
                AssignCellAt(oldCoord, new Cell(oldCoord, _owner));
            }
            else if (preyCoord != null)
            {
                AssignCellAt(oldCoord, new Cell(oldCoord, _owner));
                AssignCellAt(preyCoord, new Predator(preyCoord, _owner, _timeToReproduce, Constants.TimeToFeed));
            }
            else if (_timeToReproduce <= 0)
            {
                if (preyCoord != null)
                {
                    AssignCellAt(oldCoord, Reproduce(oldCoord));
                    AssignCellAt(preyCoord, new Predator(preyCoord, _owner, _timeToReproduce, Constants.TimeToFeed));
                }
                else
                {
                    AssignCellAt(oldCoord, Reproduce(oldCoord));
                    AssignCellAt(newCoord, new Predator(newCoord, _owner, _timeToReproduce, _timeToFeed));
                }
            }
            else
            {
                AssignCellAt(oldCoord, new Cell(oldCoord, _owner));
                AssignCellAt(newCoord, new Predator(newCoord, _owner, _timeToReproduce, _timeToFeed));
            }
        }

        public override void Process(int iteration)
        {
            if (wasNotProcessed == true)
            {
                if (_dir.GetEmptyNeighborCoord(OffSet) != OffSet)
                {
                    Move(OffSet, _dir.GetEmptyNeighborCoord(OffSet), iteration);
                }
            }
        }

        #endregion
    }
}
