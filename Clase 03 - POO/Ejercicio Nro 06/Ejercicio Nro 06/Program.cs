using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "La veterinaria";

            Cliente clienteUno = new Cliente("yuji", "itadori", "Tokyo", 11111111);
            Cliente clienteDos = new Cliente("satoru", "gojo", "Tokyo", 22222222);
            Cliente clienteTres = new Cliente("nobara", "kugisaki", "Tokyo", 33333333);
            Cliente clienteCuatro = new Cliente("braian", "acosta", "Avellaneda", 44444444);

            clienteUno.EstablecerMascota(new Mascota("Panda", "Perro", new DateTime(2016, 06, 30)));
            clienteDos.EstablecerMascota(new Mascota("manchi", "Gato", new DateTime(2012, 10, 21)));
            clienteDos.AplicarVacuna("Triple Felina");
            clienteTres.EstablecerMascota(new Mascota("maki", "Gato", new DateTime(2018, 10, 31)));
            clienteCuatro.EstablecerMascota(new Mascota("rocky", "Perro", new DateTime(2015, 05, 19)));
            clienteCuatro.AplicarVacuna("Contra la rabia");
            
            Console.WriteLine($"{clienteUno.VerInformacion()}" +
                $"{clienteDos.VerInformacion()}" +
                $"{clienteTres.VerInformacion()}" +
                $"{clienteCuatro.VerInformacion()}");

            Console.ReadKey();
        }
    }
}
