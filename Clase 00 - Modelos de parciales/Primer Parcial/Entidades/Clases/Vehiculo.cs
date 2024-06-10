using System;

namespace Entidades.Clases
{
    public abstract class Vehiculo
    {
        protected Fabricante _fabricante;
        protected static Random _generadorDeVelocidades;
        protected string _modelo;
        protected float _precio;
        protected int _velocidadMaxima;

        public Fabricante Fabricante
        {
            get 
            { 
                return _fabricante; 
            }
            set
            {
                _fabricante = value;
            }
        }

        public string Modelo
        {
            get
            {
                return _modelo;
            }
            set
            {
                _modelo = value;
            }
        }

        public float Precio
        {
            get 
            { 
                return _precio;
            }
            set
            {
                _precio = value;
            }
        }

        public int VelocidadMaxima
        {
            get
            {
                return _velocidadMaxima;
            }
            set
            {
                if (_velocidadMaxima == 0)
                {
                    _velocidadMaxima = _generadorDeVelocidades.Next(100, 281);
                }
            }
        }

        static Vehiculo()
        {
            _generadorDeVelocidades = new Random();
        }

        public Vehiculo()
        {
        }

        public Vehiculo(string marca, EPais pais, string modelo, float precio)
        {
            _modelo = modelo;
            _precio = precio;
            _fabricante = new Fabricante(marca, pais);
            VelocidadMaxima = 0;
        }

        public Vehiculo(string modelo, float precio, Fabricante fabricante)
            : this(fabricante.Marca, fabricante.Pais, modelo, precio)
        {
        }

        private static string Mostrar(Vehiculo vehiculo)
        {
            string fabricante = vehiculo.Fabricante;
            return $"FABRICANTE: {fabricante}\n" +
                $"MODELO: {vehiculo.Modelo}\n" +
                $"VELOCIDAD MAXIMA: {vehiculo.VelocidadMaxima}\n" +
                $"PRECIO: ${vehiculo.Precio}";
        }

        public static explicit operator string(Vehiculo vehiculo)
        {
            return Mostrar(vehiculo);
        }

        public static bool operator ==(Vehiculo x, Vehiculo y)
        {
            return x.Modelo == y.Modelo
                && x.Fabricante == y.Fabricante;
        }

        public static bool operator !=(Vehiculo x, Vehiculo y)
        {
            return !(x == y);
        }
    }
}
