using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lavadero
    {
        private List<Vehiculo> _vehiculos;
        private float _precioAuto;
        private float _precioCamion;
        private float _precioMoto;

        private Lavadero()
        {
            _vehiculos = new List<Vehiculo>();
        }

        public Lavadero(float precioAuto, float precioCamion, float precioMoto)
            : this()
        {
            _precioAuto = precioAuto;
            _precioCamion = precioCamion;
            _precioMoto = precioMoto;
        }

        public List<Vehiculo> Vehiculo { get => _vehiculos; }

        public string Detalle
        {
            get
            {
                StringBuilder informacion = new StringBuilder();
                informacion.AppendLine($"Precio auto: ${_precioAuto}");
                informacion.AppendLine($"Precio camion: ${_precioCamion}");
                informacion.AppendLine($"Precio Moto: ${_precioMoto}\n");
                foreach (Vehiculo vehiculo in _vehiculos)
                {
                    if (vehiculo is Auto auto)
                    {
                        informacion.AppendLine(auto.MostrarAuto());
                    }
                    else if (vehiculo is Camion camion)
                    {
                        informacion.AppendLine(camion.MostrarCamion());
                    }
                    else
                    {
                        Moto moto = (Moto)vehiculo;
                        informacion.AppendLine(moto.MostrarMoto());
                    }
                }
                return informacion.ToString();
            }
        }

        public double MostrarTotalFacturado()
        {
            double montoAuto = MostrarTotalFacturado(EVehiculos.Auto);
            double montoCamion = MostrarTotalFacturado(EVehiculos.Camion);
            double montoMoto = MostrarTotalFacturado(EVehiculos.Moto);
            return montoAuto + montoCamion + montoMoto;
        }

        public double MostrarTotalFacturado(EVehiculos tipo)
        {
            double acumulador = 0;
            foreach (Vehiculo vehiculo in _vehiculos)
            {
                if (tipo == EVehiculos.Auto && vehiculo is Auto)
                {
                    acumulador += _precioAuto;
                }
                else if (tipo == EVehiculos.Camion && vehiculo is Camion)
                {
                    acumulador += _precioCamion;
                }
                else if (tipo == EVehiculos.Moto && vehiculo is Moto)
                {
                    acumulador += _precioMoto;
                }
            }
            return acumulador;
        }

        public static int OrdenarVehiculosPorPatente(Vehiculo x, Vehiculo y)
        {
            int comparacion = x.Patente.CompareTo(y);
            if (comparacion == 0)
            {
                return 0;
            }
            else if (comparacion > 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public static int OrdenarVehiculosPorMarca(Vehiculo x, Vehiculo y)
        {
            if (x.Marca == y.Marca)
            {
                return 0;
            }
            else if (x.Marca > y.Marca)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public static Lavadero operator +(Lavadero l, Vehiculo v)
        {
            if (l != v)
            {
                l._vehiculos.Add(v);
            }
            return l;
        }

        public static Lavadero operator -(Lavadero l, Vehiculo v)
        {
            if (l == v)
            {
                l._vehiculos.Remove(v);
            }
            return l;
        }

        public static bool operator ==(Lavadero l, Vehiculo v)
        {
            foreach (Vehiculo vehiculo in l._vehiculos)
            {
                if (vehiculo == v)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Lavadero l, Vehiculo v)
        {
            return !(l == v);
        }
    }
}
