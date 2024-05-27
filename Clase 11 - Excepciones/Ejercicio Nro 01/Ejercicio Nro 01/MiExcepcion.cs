using System;

namespace Ejercicio_Nro_01
{
    public class MiExcepcion : Exception
    {
        public MiExcepcion(string message) 
            : base(message)
        {
        }

        public MiExcepcion(string message, Exception innerException) 
            : base(message, innerException)
        {
        }
    }
}
