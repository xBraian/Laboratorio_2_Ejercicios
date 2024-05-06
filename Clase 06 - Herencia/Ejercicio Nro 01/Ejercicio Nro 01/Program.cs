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
            Console.Title = "El viajar es un placer";

            Automovil auto = new Automovil(4, 3, EColores.Negro, 6, 4);
            Camion camion = new Camion(10, 2, EColores.Blanco, 18, 10);
            Moto moto = new Moto(2, 0, EColores.Azul, 195);

            Console.WriteLine($"Tipo vehiculo: {auto.Tipo}\n" +
                $"Cantidad de ruedas: {auto.Ruedas}\n" +
                $"Cantidad de puertas: {auto.Puertas}\n" +
                $"Color: {auto.Color}\n" +
                $"Cantidad de marchas: {auto.Marchas}\n" +
                $"Cantidad de pasajeros: {auto.Pasajeros}\n");

            Console.WriteLine($"Tipo vehiculo: {camion.Tipo}\n" +
                $"Cantidad de ruedas: {camion.Ruedas}\n" +
                $"Cantidad de puertas: {camion.Puertas}\n" +
                $"Color: {camion.Color}\n" +
                $"Cantidad de marchas: {camion.Marchas}\n" +
                $"Peso carga: {camion.PesoCarga}Kg\n");

            Console.WriteLine($"Tipo vehiculo: {moto.Tipo}\n" +
                $"Cantidad de ruedas: {moto.Ruedas}\n" +
                $"Cantidad de puertas: {moto.Puertas}\n" +
                $"Color: {moto.Color}\n" +
                $"Cilindrada: {moto.Cilindrada}cc");

            Console.ReadKey();
        }
    }
}
