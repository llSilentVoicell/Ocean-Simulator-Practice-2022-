using OceanLib.Interfaces;

namespace OceanLib
{
    public class Obstacle : Cell
    {
        #region [Constructor]

        public Obstacle(Coordinate offset, IOceanCell owner) : base(offset, owner)
        {
            image = Constants.ObstacleImage;
        }

        #endregion
    }
}
