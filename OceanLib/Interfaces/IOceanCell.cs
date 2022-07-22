namespace OceanLib.Interfaces
{
    public interface IOceanCell
    {
        int NumRows { get; set; }
        int NumCols { get; set; }
        Cell[,] Cells { get; }
    }
}
