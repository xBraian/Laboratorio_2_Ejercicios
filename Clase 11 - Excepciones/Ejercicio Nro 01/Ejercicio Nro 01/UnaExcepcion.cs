using System;

namespace Ejercicio_Nro_01
{
    public class UnaExcepcion : Exception
    {
        public UnaExcepcion(string message)
            : base(message)
        {
        }

        public UnaExcepcion(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
