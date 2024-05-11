using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Restaurante
    {
        private Producto _producto;

        public Restaurante() 
        {
        }

        public Producto Productos { get => _producto; set => _producto = value; }

        public decimal Descuento { get => CalcularDescuento(); }

        public decimal PrecioFinal { get => _producto.Precio - CalcularDescuento(); }

        private decimal CalcularDescuento()
        {
            int descuento;
            if (_producto.Precio >= 3000 && _producto.Precio <= 5000)
            {
                descuento = 10;
            }
            else if (_producto.Precio > 5000)
            {
                descuento = 20;
            }
            else
            {
                return 0;
            }
            return _producto.Precio * descuento / 100;
        }
    }
}
