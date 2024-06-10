namespace Entidades.Clases
{
    public class Auto : Vehiculo
    {
        private ETipo _tipo;

        public ETipo Tipo
        {
            get
            {
                return _tipo;
            }
            set
            {
                _tipo = value;
            }
        }

        public Auto()
        {
        }

        public Auto(string modelo, float precio, Fabricante fabricante, ETipo tipo)
            : base(modelo, precio, fabricante)
        {
            _tipo = tipo;
        }

        public override bool Equals(object obj)
        {
            return obj is Auto auto
                && this == auto; 
        }

        public override string ToString()
        {
            return $"{(string)this}\n" +
                $"TIPO: {Tipo}\n";
        }

        public static explicit operator float(Auto auto)
        {
            return auto.Precio;
        }

        public static bool operator ==(Auto x, Auto y)
        {
            return (Vehiculo)x == y 
                && x.Tipo == y.Tipo;
        }

        public static bool operator !=(Auto x, Auto y)
        {
            return !(x == y);
        }
    }
}
