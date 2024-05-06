using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Enciendan sus motores";

            Competencia competencia = new Competencia(2, 4);
            AutoF1 a1 = new AutoF1(10, "Alpine F1 Team");
            AutoF1 a2 = new AutoF1(10, "Alpine F1 Team");
            AutoF1 a3 = new AutoF1(20, "Red Bull");
            AutoF1 a4 = new AutoF1(30, "Stake F1 Team");

            if (competencia + a1)
            {
                Console.WriteLine("Competidor inscripto.");
            }
            else
            {
                Console.WriteLine("No se pudo inscribir.");
            }
            if (competencia + a2)
            {
                Console.WriteLine("Competidor inscripto.");
            }
            else
            {
                Console.WriteLine("No se pudo inscribir.");
            }
            if (competencia + a3)
            {
                Console.WriteLine("Competidor inscripto.");
            }
            else
            {
                Console.WriteLine("No se pudo inscribir.");
            }
            if (competencia + a4)
            {
                Console.WriteLine("Competidor inscripto.");
            }
            else
            {
                Console.WriteLine("No se pudo inscribir.");
            }

            Console.WriteLine("\nCampeonato Mundial F1");
            Console.WriteLine("\nCompetidores\n");
            Console.WriteLine(competencia.MostrarDatos());

            Console.ReadKey();
        }
    }
}
