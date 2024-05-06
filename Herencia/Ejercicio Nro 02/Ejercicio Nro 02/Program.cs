using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lavadero";

            Lavadero lavadero = new Lavadero(500, 1000, 250);
            Auto auto1 = new Auto("aa00", new byte(), Vehiculo.EMarcas.Ford, 5);
            Auto auto2 = new Auto("aa01", new byte(), Vehiculo.EMarcas.Fiat, 2);
            Camion camion = new Camion("aa02", new byte(), Vehiculo.EMarcas.Scania, 1000);
            Moto moto1 = new Moto("aa03", new byte(), Vehiculo.EMarcas.Zanella, 150);
            Moto moto2 = new Moto("aa03", new byte(), Vehiculo.EMarcas.Zanella, 150);

            lavadero += auto1;
            lavadero += auto2;
            lavadero += camion;
            lavadero += moto1;
            lavadero += moto2;

            Console.WriteLine(lavadero.Detalle);
            Console.WriteLine($"Total facturado: ${lavadero.MostrarTotalFacturado()}");

            Console.ReadKey();
        }
    }
}
