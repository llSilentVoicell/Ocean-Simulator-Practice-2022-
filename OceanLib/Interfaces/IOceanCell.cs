namespace OceanLib.Interfaces
{
    public interface IOceanCell
    {
        Coordinate GetEmptyNeighborCoord(Coordinate coord);
        Coordinate GetPreyNeighborCoord(Coordinate coord);

        Cell[,] Cells { get; }
    }
}
