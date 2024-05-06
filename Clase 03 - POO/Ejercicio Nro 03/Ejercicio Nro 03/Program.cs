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
            Console.Title = "El ejemplo universal";

            Estudiante estudianteUno = new Estudiante("Acosta", "00", "Braian", new Random());
            Estudiante estudianteDos = new Estudiante("Hoshino", "01", "Ruby", new Random());
            Estudiante estudianteTres = new Estudiante("Hernandez", "02", "Pedro", new Random());
            
            estudianteUno.SetNotaPrimerParcial(9);
            estudianteUno.SetNotaSegundoParcial(10);
            estudianteDos.SetNotaPrimerParcial(10);
            estudianteDos.SetNotaSegundoParcial(10);
            estudianteTres.SetNotaPrimerParcial(4);
            estudianteTres.SetNotaSegundoParcial(3);
            
            Console.WriteLine("Primer estudiante.\n" +
                $"{estudianteUno.Mostrar()}\n" +
                "Segundo estudiante.\n" +
                $"{estudianteDos.Mostrar()}\n" +
                "Tercer estudiante.\n" +
                $"{estudianteTres.Mostrar()}");

            Console.ReadKey();
        }
    }
}
