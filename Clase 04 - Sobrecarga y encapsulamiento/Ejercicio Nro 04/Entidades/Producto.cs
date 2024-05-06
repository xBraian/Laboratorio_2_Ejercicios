using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        private string _codigoDeBarra;
        private string _marca;
        private float _precio;

        public Producto(string codigoDeBarra, string marca, float precio)
        {
            _codigoDeBarra = codigoDeBarra;
            _marca = marca;
            _precio = precio;
        }

        public string GetMarca()
        {
            return _marca;
        }

        public float GetPrecio()
        {
            return _precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine($"Codigo de barra: {p._codigoDeBarra}");
            informacion.AppendLine($"Marca: {p._marca}");
            informacion.AppendLine($"Precio: {p._precio}");
            return informacion.ToString();
        }

        public static explicit operator string(Producto p)
        {
            return p._codigoDeBarra;
        }

        public static bool operator ==(Producto p, string marca)
        {
            return p._marca == marca;
        }

        public static bool operator ==(Producto x, Producto y)
        {
            if (!(x is null) &&
                !(y is null) &&
                x._codigoDeBarra == y._codigoDeBarra &&
                x._marca == y._marca)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }

        public static bool operator !=(Producto x, Producto y)
        {
            return !(x == y);
        }
    }
}
