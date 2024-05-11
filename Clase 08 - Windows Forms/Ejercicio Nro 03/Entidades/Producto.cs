using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        private decimal _precio;

        public Producto(decimal precio) 
        { 
            _precio = precio;
        }

        public decimal Precio { get => _precio; set => _precio = value; }
    }
}
