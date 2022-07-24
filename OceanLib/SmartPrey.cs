using OceanLib.Interfaces;

namespace OceanLib
{
    public class SmartPrey : Prey
    {
        #region [Constructor]

        public SmartPrey(Coordinate offset, IOceanCell owner, int timeToProcreate) : base(offset, owner, timeToProcreate)
        {
            _timeToReproduce = timeToProcreate;
            image = Constants.DefaultSmartPreyImage;

            wasNotProcessed = false;

            _dir = new ParticipantsDirection(owner);
        }

        #endregion

        #region [Methods]

        protected override Prey Reproduce(Coordinate coord)
        {
            if (coord != null)
            {
                SmartPrey newborn = new SmartPrey(coord, _owner, Constants.TimeToReproduce);
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
            Coordinate predatorCoord = _dir.GetPredatorNeighborCoord(OffSet);

            if (iteration != _lastIterationNumber)
            {
                _timeToReproduce--;
                _lastIterationNumber = iteration;
            }

            if (predatorCoord != null)
            {
                AssignCellAt(oldCoord, new Cell(oldCoord, _owner));
                AssignCellAt(predatorCoord, new SmartPrey(predatorCoord, _owner, _timeToReproduce));
            }
            else if (_timeToReproduce <= 0)
            {
                AssignCellAt(oldCoord, Reproduce(oldCoord));
                AssignCellAt(newCoord, new SmartPrey(newCoord, _owner, _timeToReproduce));
            }
            else
            {
                AssignCellAt(oldCoord, new Cell(oldCoord, _owner));
                AssignCellAt(newCoord, new SmartPrey(newCoord, _owner, _timeToReproduce));
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
