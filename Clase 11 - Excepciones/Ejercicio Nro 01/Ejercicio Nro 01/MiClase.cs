using System;

namespace Ejercicio_Nro_01
{
    public class MiClase
    {
        private int _id;
        private string _nombre;

        private MiClase() 
        {
            try
            {
                LanzarException();
            }
            catch (DivideByZeroException ex)
            { 
                throw ex;
            }
        }

        public MiClase(int id, string nombre) 
        {
            try
            {
                _id = id;
                _nombre = nombre;
                new MiClase();
            }
            catch (DivideByZeroException ex)
            {
                throw new UnaExcepcion("Excepcion en 2do constructor de MiClase", ex);
            }
        }

        public static void LanzarException()
        {
            throw new DivideByZeroException();
        }
    }
}
