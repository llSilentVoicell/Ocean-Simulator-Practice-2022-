namespace OceanLib.Interfaces
{
    public interface IEnterDisplayData
    {
        void EnterNumOfObjects(int oceanNumber, IOceanView view);
        void EnterNumOfIterations(IOceanView view);
        void Display(int iteration, Ocean owner, int oceanNumber, int numIterations);
        void EndSimulation(int oceanNumber);
    }
}
