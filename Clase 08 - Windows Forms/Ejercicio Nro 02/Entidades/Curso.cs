using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private string _nombre;

        public Curso(string nombre) 
        {
            _nombre = nombre;
        }

        public string Nombre {  get => _nombre; set => _nombre = value; }

        public override bool Equals(object obj)
        {
            return GetType() == obj.GetType();
        }

        public override int GetHashCode()
        {
            return Nombre.GetHashCode();
        }
    }
}
