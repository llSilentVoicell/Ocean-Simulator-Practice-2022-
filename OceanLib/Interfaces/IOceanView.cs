namespace OceanLib.Interfaces
{
    public interface IOceanView
    {
        int UserNumPrey{ get; set; }
        int UserNumPredators { get; set; }
        int UserNumObstacles { get; set; }
        int UserNumIteration { get; set; }
    }
}
