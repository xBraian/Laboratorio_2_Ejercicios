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
            Console.Title = "¿Vos cuántas primaveras tenés?";

            Persona personaUno = new Persona("Braian", new DateTime(2000, 10, 21), 12345678);
            Persona personaDos = new Persona("Ruby", new DateTime(2000, 10, 21), 23456789);
            Persona personaTres = new Persona("Pedro", new DateTime(2010, 05, 10), 34567890);

            Console.WriteLine("Persona uno.\n" +
                $"{personaUno.Mostrar()}" +
                $"{personaUno.EsMayor()}\n" +
                "\nPersona dos.\n" +
                $"{personaDos.Mostrar()}" +
                $"{personaDos.EsMayor()}\n" +
                "\nPersona tres.\n" +
                $"{personaTres.Mostrar()}" +
                $"{personaTres.EsMayor()}");

            Console.ReadKey();
        }
    }
}
