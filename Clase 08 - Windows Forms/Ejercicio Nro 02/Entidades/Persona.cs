using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private string _nombre;
        private int _edad;
        private string _genero;
        private string _direccion;
        private string _pais;

        public Persona(string nombre, int edad, string genero, string direccion, string pais)
        {
            _nombre = nombre;
            _edad = edad;
            _genero = genero;
            _direccion = direccion;
            _pais = pais;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }

        public int Edad { get => _edad; set => _edad = value; }

        public string Genero { get => _genero; set => _genero = value; }

        public string Direccion { get => _direccion; set => _direccion = value; }

        public string Pais { get => _pais ; set => _pais = value; }
    }
}
