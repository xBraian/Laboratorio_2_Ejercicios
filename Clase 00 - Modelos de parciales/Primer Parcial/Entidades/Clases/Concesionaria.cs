using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Entidades.Clases
{
    [XmlInclude(typeof(Vehiculo))]
    [XmlInclude(typeof(Auto))]
    [XmlInclude(typeof(Moto))]
    public class Concesionaria
    {
        private int _capacidad;
        private List<Vehiculo> vehiculos;

        public int Capacidad
        {
            get
            {
                return _capacidad;
            }
            set
            {
                _capacidad = value;
            }
        }

        public List<Vehiculo> Vehiculos
        {
            get
            {
                return vehiculos;
            }
            set
            {
                vehiculos = value;
            }
        }

        public double PrecioDeAutos
        {
            get
            {
                return ObtenerPrecio(EVehiculo.Auto);
            }
            set
            {
            }
        }

        public double PrecioDeMotos
        {
            get
            {
                return ObtenerPrecio(EVehiculo.Moto);
            }
            set
            {
            }
        }

        public double PrecioTotal
        {
            get
            {
                return ObtenerPrecio(EVehiculo.Ambos);
            }
            set
            {
            }
        }

        private Concesionaria()
        {
            vehiculos = new List<Vehiculo>();
        }

        private Concesionaria(int capacidad)
            : this()
        {
            _capacidad = capacidad;
        }

        private double ObtenerPrecio(EVehiculo tipo)
        {
            double total = 0;
            foreach (Vehiculo vehiculo in Vehiculos)
            {
                if (tipo == EVehiculo.Auto
                    && vehiculo is Auto auto)
                {
                    total += auto.Precio;
                }
                else if (tipo == EVehiculo.Moto
                    && vehiculo is Moto moto)
                {
                    total += moto.Precio;
                }
                else if (tipo == EVehiculo.Ambos)
                {
                    total += vehiculo.Precio;
                }
            }
            return total;
        }

        public static string Mostrar(Concesionaria concesionaria)
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine($"Capacidad: {concesionaria.Capacidad}");
            informacion.AppendLine($"Total por autos: ${concesionaria.PrecioDeAutos}");
            informacion.AppendLine($"Total por motos: ${concesionaria.PrecioDeMotos}");
            informacion.AppendLine($"Total: ${concesionaria.PrecioTotal}\n");
            informacion.AppendLine("*************************");
            informacion.AppendLine("Listado de Vehiculos");
            informacion.AppendLine("*************************");
            foreach (Vehiculo vehiculo in concesionaria.Vehiculos)
            {
                if (vehiculo is Auto auto)
                {
                    informacion.AppendLine(auto.ToString());
                }
                else
                {
                    informacion.AppendLine(((Moto)vehiculo).ToString());
                }
            }
            return informacion.ToString();
        }

        public void GuardarConcesionaria(string path)
        {
            using (StreamWriter archivo = new StreamWriter(path))
            {
                archivo.WriteLine(Mostrar(this));
            }
        }

        public void SerializarConcesionaria(string path)
        {
            using (StreamWriter archivo = new StreamWriter(path))
            {
                XmlSerializer serializador = new XmlSerializer(typeof(Concesionaria));
                serializador.Serialize(archivo, this);
            }
        }

        public static Concesionaria DeserializarConcesionaria(string path)
        {
            using (StreamReader archivo = new StreamReader(path))
            {
                XmlSerializer deserializador = new XmlSerializer(typeof(Concesionaria));
                return (Concesionaria)deserializador.Deserialize(archivo);
            }
        }

        public static implicit operator Concesionaria(int capacidad)
        {
            return new Concesionaria(capacidad);
        }

        public static Concesionaria operator +(Concesionaria concesionaria, Vehiculo vehiculo)
        {
            if (concesionaria.Vehiculos.Count == concesionaria.Capacidad)
            {
                Console.WriteLine("¡No hay más lugar en la concesionaria!");
            }
            else if (concesionaria == vehiculo)
            {
                Console.WriteLine("¡El vehículo ya está en la concesionaria!");
            }
            else
            {
                concesionaria.Vehiculos.Add(vehiculo);
            }
            return concesionaria;
        }

        public static Concesionaria operator -(Concesionaria concesionaria, Vehiculo vehiculo)
        {
            if (concesionaria != vehiculo)
            {
                Console.WriteLine("¡El vehículo no está en la concesionaria!");
            }
            else
            {
                concesionaria.Vehiculos.Remove(vehiculo);
            }
            return concesionaria;
        }

        public static bool operator ==(Concesionaria concesionaria, Vehiculo vehiculo)
        {
            return concesionaria.Vehiculos.Contains(vehiculo);
        }

        public static bool operator !=(Concesionaria concesionaria, Vehiculo vehiculo)
        {
            return !(concesionaria == vehiculo); 
        }
    }
}
