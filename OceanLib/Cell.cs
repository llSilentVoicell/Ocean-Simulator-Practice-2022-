using OceanLib.Interfaces;

namespace OceanLib
{
    public class Cell
    {
        #region [Variables]

        protected IOceanCell _owner;
        private Coordinate _offset;
        public char image;

        public bool wasNotProcessed = false;

        #endregion

        #region [Properties]

        public Coordinate OffSet
        {
            get { return _offset; }
            set { _offset = value; }
        }

        public char Image
        {
            get { return image; }
        }

        #endregion

        #region [Constructor]

        public Cell(Coordinate offset, IOceanCell owner)
        {
            image = Constants.DefaultImage;
            _offset = offset;
            _owner = owner;
        }

        #endregion

        #region [Methods]

        public void AssignCellAt(Coordinate coord, Cell cell)
        {
            if (coord != null)
            {
                _owner.Cells[coord.X, coord.Y] = cell;
            }
        }

        public virtual void Process(int iteration)
        {
        }

        #endregion
    }
}
