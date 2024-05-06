using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estante
    {
        private Producto[] _productos;
        private int _ubicacionEstante;

        private Estante(int capacidad)
        {
            _productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) 
            : this(capacidad)
        {
            _ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return _productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder informacion = new StringBuilder();
            informacion.Append("LISTADO DE PRODUCTOS\n");
            for (int i = 0; i < e._productos.Length; i++)
            {
                if (!(e._productos[i] is null))
                {
                    informacion.AppendLine("------------------------------");
                    informacion.Append(Producto.MostrarProducto(e._productos[i]));
                }
            }
            return informacion.ToString();
        }

        public static bool operator +(Estante e, Producto p)
        {
            if (e != p)
            {
                for (int i = 0; i < e._productos.Length; i++)
                {
                    if (e._productos[i] is null)
                    {
                        e._productos[i] = p;
                        return true;
                    }
                }
            }
            return false;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            if (e == p)
            {
                for (int i = 0; i < e._productos.Length; i++)
                {
                    if (e._productos[i] == p)
                    {
                        e._productos[i] = null;
                        break;
                    }
                }
            }
            return e;
        }

        public static bool operator ==(Estante e, Producto p)
        {
            for (int i = 0; i < e._productos.Length; i++)
            {
                if (e._productos[i] == p)
                {
                    e._productos[i] = p;
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }
    }
}
