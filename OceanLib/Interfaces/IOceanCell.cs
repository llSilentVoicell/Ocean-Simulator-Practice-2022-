namespace OceanLib.Interfaces
{
    public interface IOceanCell
    {
        Coordinate GetEmptyNeighborCoord(Coordinate coord);
        Coordinate GetPreyNeighborCoord(Coordinate coord);
        Coordinate GetPredatorNeighborCoord(Coordinate coord);

        Cell[,] Cells { get; }
    }
}
