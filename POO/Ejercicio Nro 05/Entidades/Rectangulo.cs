using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rectangulo
    {
        private float _area;
        private float _perimetro;
        private Punto _vertice1;
        private Punto _vertice2;
        private Punto _vertice3;
        private Punto _vertice4;

        /*
            Dibujo de rectangulo:
            V1 --- V4
            |       |   
            V2 --- V3
        */

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            _vertice1 = vertice1;
            _vertice2 = new Punto(vertice1.GetX(), vertice3.GetY());
            _vertice3 = vertice3;
            _vertice4 = new Punto(vertice3.GetX(), vertice1.GetY());
        }

        public float Area()
        {
            if (_area == 0)
            {
                float baseRectangulo = Math.Abs(_vertice1.GetX() - _vertice4.GetX());
                float altura = Math.Abs(_vertice1.GetY() - _vertice2.GetY());
                _area = baseRectangulo * altura;
            }
            return _area;
        }

        public float Perimetro()
        {
            if (_perimetro == 0)
            {
                float baseRectangulo = Math.Abs(_vertice1.GetX() - _vertice4.GetX());
                float altura = Math.Abs(_vertice1.GetY() - _vertice2.GetY());
                _perimetro = (baseRectangulo + altura) * 2;
            }
            return _perimetro;
        }

        public string Mostrar()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine($"Area del rectangulo: {Area()}");
            informacion.AppendLine($"Perimetro del rectangulo: {Perimetro()}");
            return informacion.ToString();
        }
    }
}
