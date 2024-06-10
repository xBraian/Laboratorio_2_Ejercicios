namespace Entidades
{
    public class Fabricante
    {
        private string _marca;
        private EPais _pais;

        public string Marca
        {
            get
            {
                return _marca;
            }
            set
            {
                _marca = value;
            }
        }

        public EPais Pais
        {
            get
            {
                return _pais;
            }
            set
            {
                _pais = value;
            }
        }

        public Fabricante()
        {
        }

        public Fabricante(string marca, EPais pais)
        {
            _marca = marca;
            _pais = pais;
        }

        public static implicit operator string(Fabricante fabricante)
        {
            return $"{fabricante.Marca.ToUpper()} - {fabricante.Pais}";
        }

        public static bool operator ==(Fabricante x, Fabricante y)
        {
            return x.Marca == y.Marca
                && x.Pais == y.Pais;
        }

        public static bool operator !=(Fabricante x, Fabricante y)
        {
            return !(x == y);
        }
    }
}
