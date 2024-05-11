using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ingresante : Persona
    {
        private List<Curso> _cursos;

        public Ingresante(string nombre, int edad, string genero, string direccion, string pais, List<Curso> cursos) 
            : base(nombre, edad, genero, direccion, pais)
        {
            _cursos = cursos;
        }

        public List<Curso> Cursos { get => _cursos; set => _cursos = value; }

        public string Mostrar()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine($"Nombre: {Nombre}");
            informacion.AppendLine($"Edad: {Edad}");
            informacion.AppendLine($"Genero: {Genero}");
            informacion.AppendLine($"Direccion: {Direccion}");
            informacion.AppendLine($"Pais: {Pais}");
            if ( _cursos.Count > 0)
            {
                informacion.AppendLine($"Cursos:");
                foreach (Curso c in _cursos)
                {
                    informacion.AppendLine($"   > {c.Nombre}");
                }
            }
            return informacion.ToString();
        }
    }
}
