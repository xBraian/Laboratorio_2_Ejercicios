using System;

namespace Entidades
{
    public abstract class Equipo
    {
        private string _nombre;
        private DateTime _fechaCreacion;

        public string Nombre
        {
            get
            {
                return _nombre;
            }
        }

        public Equipo(string nombre, DateTime fechaCreacion)
        {
            _nombre = nombre;
            _fechaCreacion = fechaCreacion;
        }

        public static bool operator ==(Equipo x, Equipo y)
        {
            return x._nombre == y._nombre && 
                x._fechaCreacion == y._fechaCreacion;
        }

        public static bool operator !=(Equipo x, Equipo y)
        {
            return !(x == y);
        }

        public string Ficha()
        {
            return $"{_nombre.ToUpper()} fundado el {_fechaCreacion:dd_MMM_yyyy}";
        }

        public override bool Equals(object obj)
        {
            return obj is Equipo equipo &&
                equipo == this;
        }
    }
}
