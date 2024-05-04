using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aprendete las tablas";

            Console.Write("Ingrese la tabla que quiere aprender: ");
            Console.WriteLine(Aprender.Tablas(int.Parse(Console.ReadLine())));

            Console.ReadKey();
        }
    }

    public static class Aprender
    {
        public static string Tablas(int numero)
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine($"Tabla de multiplicar del numero: {numero}");
            for (int i = 1; i <= 10; i++)
            {
                retorno.AppendLine($"{numero} x {i} = {numero * i}");
            }
            return retorno.ToString();
        }
    }
}
