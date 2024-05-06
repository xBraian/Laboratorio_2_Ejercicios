using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Estadística deportiva";

            Equipo equipo = new Equipo(4, "Boca Juniors");
            Jugador j1 = new Jugador(1111, "Medina", 10, 2);
            Jugador j2 = new Jugador(1111, "Bullaude");
            Jugador j3 = new Jugador(2222, "Equi", 10, 0);
            Jugador j4 = new Jugador(3333, "Zenon", 15, 2);
            Jugador j5 = new Jugador(4444, "Taborda");
            Jugador j6 = new Jugador(5555, "Rojo");

            if (equipo + j1)
            {
                Console.WriteLine("Se agrego al jugador");
            }
            else
            {
                Console.WriteLine("No se pudo agregar al jugador");
            }
            if (equipo + j2)
            {
                Console.WriteLine("Se agrego al jugador");
            }
            else
            {
                Console.WriteLine("No se pudo agregar al jugador");
            }
            if (equipo + j3)
            {
                Console.WriteLine("Se agrego al jugador");
            }
            else
            {
                Console.WriteLine("No se pudo agregar al jugador");
            }
            if (equipo + j4)
            {
                Console.WriteLine("Se agrego al jugador");
            }
            else
            {
                Console.WriteLine("No se pudo agregar al jugador");
            }
            if (equipo + j5)
            {
                Console.WriteLine("Se agrego al jugador");
            }
            else
            {
                Console.WriteLine("No se pudo agregar al jugador");
            }
            if (equipo + j6)
            {
                Console.WriteLine("Se agrego al jugador");
            }
            else
            {
                Console.WriteLine("No se pudo agregar al jugador");
            }

            Console.WriteLine("\nEQUIPO\n\n" +
                $"{equipo.Nombre}\n\n" +
                "JUGADORES\n\n" +
                $"{equipo.MostrarDatos()}");

            Console.ReadKey();
        }
    }
}
