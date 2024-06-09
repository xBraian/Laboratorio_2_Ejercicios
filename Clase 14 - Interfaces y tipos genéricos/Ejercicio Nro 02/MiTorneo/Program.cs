using Entidades;
using Entidades.Clases;
using System;

namespace MiTorneo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creacion de torneos.
            Torneo<EquipoFutbol> futbol = new Torneo<EquipoFutbol>("LPF");
            Torneo<EquipoBasquet> basquet = new Torneo<EquipoBasquet>("NBA");
            
            //Creacion de equipos de futbol.
            EquipoFutbol cabj = new EquipoFutbol("Boca Juniors", new DateTime(1905, 4, 3));
            EquipoFutbol cai = new EquipoFutbol("Independiente", new DateTime(1905, 1, 1));
            EquipoFutbol cdgcat = new EquipoFutbol("Godoy Cruz", new DateTime(1921, 6, 1));
            EquipoFutbol cabjCopia = new EquipoFutbol("Boca Juniors", new DateTime(1905, 4, 3));
            
            //Creacion de equipos de basquet.
            EquipoBasquet celtics = new EquipoBasquet("Celtics", new DateTime(1946, 1, 1));
            EquipoBasquet angeles = new EquipoBasquet("Los Angeles Lakers", new DateTime(1947, 1, 1));
            EquipoBasquet mavericks = new EquipoBasquet("Mavericks", new DateTime(1980, 1, 1));
            EquipoBasquet angelesCopia = new EquipoBasquet("Los Angeles Lakers", new DateTime(1947, 1, 1));

            //Agregar equipos de futbol.
            futbol += cabj;
            futbol += cai;
            futbol += cdgcat;
            futbol += cabjCopia;

            //Agregar equipos de basquet.
            basquet += celtics;
            basquet += angeles;
            basquet += mavericks;
            basquet += angelesCopia;

            //Informacion torneo de futbol.
            Console.WriteLine(futbol.Mostrar());

            //Informacion torneo de basquet.
            Console.WriteLine(basquet.Mostrar());

            //Simulacro partidos de futbol.
            Console.WriteLine("\nPartido 1");
            Console.WriteLine(futbol.JugarPartido);
            Console.WriteLine("\nPartido 2");
            Console.WriteLine(futbol.JugarPartido);
            Console.WriteLine("\nPartido 3");
            Console.WriteLine(futbol.JugarPartido);

            //Simulacro partidos de basquet.
            Console.WriteLine("\nJuego 1");
            Console.WriteLine(basquet.JugarPartido);
            Console.WriteLine("\nJuego 2");
            Console.WriteLine(basquet.JugarPartido);
            Console.WriteLine("\nJuego 3");
            Console.WriteLine(basquet.JugarPartido);

            Console.ReadKey();
        }
    }
}
