using System.IO;
namespace DesafioDio.Excecoes
{
    [Serializable]
    public class LimiteExcedidoSuiteException : Exception
    {
        public LimiteExcedidoSuiteException() {}

        public LimiteExcedidoSuiteException(string message) : base (message) 
        {
            
        }

        public LimiteExcedidoSuiteException(string message, Exception inner) : base (message, inner)
        {}
        
    }
}