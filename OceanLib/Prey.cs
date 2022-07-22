using OceanLib.Interfaces;

namespace OceanLib
{
    public class Prey : Cell
    {
        #region [Variables]

        protected int _timeToReproduce = Constants.TimeToReproduce;
        protected int _lastIterationNumber = 0;

        protected IDirection _dir;

        #endregion

        #region [Constructor]

        public Prey(Coordinate offset, IOceanCell owner, int timeToProcreate) : base(offset, owner)
        {
            _timeToReproduce = timeToProcreate;
            image = Constants.DefaultPreyImage;

            wasNotProcessed = false;

            _dir = new ParticipantsDirection(owner);
        }

        #endregion

        #region [Methods]

        public virtual Prey Reproduce(Coordinate coord)
        {
            if (coord != null)
            {
                Prey newborn = new Prey(coord, _owner, Constants.TimeToReproduce);
                _timeToReproduce = Constants.TimeToReproduce;

                return newborn;
            }
            else
            {
                return this;
            }
        }

        protected virtual void Move(Coordinate oldCoord, Coordinate newCoord, int iteration)
        {
            if (iteration != _lastIterationNumber)
            {
                _timeToReproduce--;
                _lastIterationNumber = iteration;
            }

            if (_timeToReproduce <= 0)
            {
                AssignCellAt(oldCoord, Reproduce(oldCoord));
            }
            else
            {
                AssignCellAt(oldCoord, new Cell(oldCoord, _owner));
            }
            AssignCellAt(newCoord, new Prey(newCoord, _owner, _timeToReproduce));
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
