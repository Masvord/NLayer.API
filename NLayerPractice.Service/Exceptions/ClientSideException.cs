namespace NLayerPractice.Service.Exceptions
{
    public class ClientSideException : Exception
    {
        //Handling client errors
        public ClientSideException(string message) : base(message) //Base is constructor.
        {

        }
    }
}
