namespace OceanLib.Interfaces
{
    public interface IDirection
    {
        Coordinate GetEmptyNeighborCoord(Coordinate coord);

        Coordinate GetPreyNeighborCoord(Coordinate coord);

        Coordinate GetPredatorNeighborCoord(Coordinate coord);
    }
}
