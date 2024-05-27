using System;

namespace Ejercicio_Nro_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lanzar y atrapar";

            try
            {
                OtraClase clase = new OtraClase();
                clase.GenerarMiClase(1, "braian");
            }
            catch (MiExcepcion ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
                Exception excepcion = ex.InnerException;
                for (int i = 0; ; i++)
                {
                    if (excepcion == null)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine(excepcion.Message);
                        excepcion = excepcion.InnerException;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
