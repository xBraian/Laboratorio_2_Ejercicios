namespace Entidades.Clases
{
    public class Moto : Vehiculo
    {
        private ECilindrada _cilindrada;

        public ECilindrada Cilindrada
        {
            get
            {
                return _cilindrada;
            }
            set
            {
                _cilindrada = value;
            }
        }

        public Moto()
        {
        }

        public Moto(string marca, EPais pais, string modelo, float precio, ECilindrada cilindrada)
            : base(marca, pais, modelo, precio)
        {
            _cilindrada = cilindrada;
        }

        public override bool Equals(object obj)
        {
            return obj is Moto moto 
                && this == moto;
        }

        public override string ToString()
        {
            return $"{(string)this}\n" +
                $"CILINDRADA: {Cilindrada}\n";
        }

        public static bool operator ==(Moto x, Moto y)
        {
            return (Vehiculo)x == y
                && x.Cilindrada == y.Cilindrada; 
        }

        public static bool operator !=(Moto x, Moto y)
        {
            return !(x == y);
        }
    }
}
