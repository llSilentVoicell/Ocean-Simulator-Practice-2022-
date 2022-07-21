namespace OceanLib.CustomExceptions
{
    public delegate void ExceptionInformHandler(string message);

    public class ExceptionInform
    {
        ExceptionInformHandler exceptionInform;

        public ExceptionInform()
        {
        }

        public void RegisterHandler(ExceptionInformHandler del)
        {
            exceptionInform = del;
        }

        public void Inform(string outMessage)
        {
            exceptionInform?.Invoke(outMessage);
        }
    }
}
