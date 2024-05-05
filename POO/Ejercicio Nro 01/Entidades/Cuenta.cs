using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cuenta
    {
        private string _titular;
        private decimal _cantidad;

        public Cuenta(string titular, decimal cantidad)
        {
            _titular = titular;
            _cantidad = cantidad;
        }

        public string ObtenerTitular()
        {
            return _titular;
        }

        public decimal Cantidad()
        {
            return _cantidad;
        }

        public string Mostrar()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine($"Nombre del titular: {_titular}");
            informacion.AppendLine($"Monto actual de dinero en la cuenta: {_cantidad}");
            return informacion.ToString();
        }

        public bool Ingresar(decimal valor)
        {
            if (valor > 0)
            {
                _cantidad += valor;
                return true;
            }
            return false;
        }

        public void Retirar(decimal valor)
        {
            _cantidad -= valor;
        }
    }
}
