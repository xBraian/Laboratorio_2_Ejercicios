using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Creo que necesito un préstamo";

            Cuenta cuenta = new Cuenta("Braian", 500000);

            Console.WriteLine("Estado inicial.");
            Console.WriteLine(cuenta.Mostrar()); ;
            Console.WriteLine("Ingreso dinero.");
            cuenta.Ingresar(250000);

            Console.WriteLine(cuenta.Mostrar());
            Console.WriteLine("Retiro dinero.");
            cuenta.Retirar(550000);
            Console.WriteLine(cuenta.Mostrar());
            
            Console.ReadKey();
        }
    }
}
