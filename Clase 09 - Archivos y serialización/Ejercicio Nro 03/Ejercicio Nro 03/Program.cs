using System;
using System.IO;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

namespace Ejercicio_Nro_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 03";

            Persona personaUno = new Persona("Braian", "Acosta");
            
            //Guardado JSON
            Persona.GuardarJson(personaUno);

            //Guardado XML
            Persona.GuardarXml(personaUno);

            //Lectura JSON
            Console.WriteLine("Lectura JSON");
            Console.WriteLine(Persona.LeerJson().ToString() + "\n");

            //Lectura XML
            Console.WriteLine("Lectura XML");
            Console.WriteLine(Persona.LeerXml().ToString());

            Console.ReadKey();
        }
    }

    public class Persona
{
        private string _nombre;
        private string _apellido;

        /*
            Son necesarias las propiedades publicas para guardar/leer los atributos del
            objeto, al momento de la serializacion y deserializacion. 
        */

        public string Nombre { get => _nombre; set => _nombre = value; }

        public string Apellido { get => _apellido; set => _apellido = value; }

        /*
            Los serializadores JSON y XML necesitan que haya un constructor sin parametros.
        */

        public Persona()
        {
        }

        public Persona(string nombre, string apellido)
        {
            _nombre = nombre;
            _apellido = apellido;
        }

        /*
            Agregue una ruta y nombre valido, de otra forma no era posible 
            guardar el archivo.
            Tambien separe los metodos de guardado.
        */

        public static void GuardarXml(Persona persona)
        {
            string pathXml = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "Archivo XML.xml");
            XmlWriterSettings configuracion = new XmlWriterSettings()
            {
                Indent = true,
            };
            using (XmlWriter xml = XmlWriter.Create(pathXml, configuracion))
            {
                XmlSerializer serializador = new XmlSerializer(typeof(Persona));
                serializador.Serialize(xml, persona);
            }
        }

        public static void GuardarJson(Persona persona)
        {
            string pathJson = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "Archivo JSON.json");
            JsonSerializerOptions configuracion = new JsonSerializerOptions()
            {
                WriteIndented = true,
            };
            using (StreamWriter archivoJson = new StreamWriter(pathJson))
            {
                string jsonString = JsonSerializer.Serialize(persona, configuracion);
                archivoJson.Write(jsonString);
            }
        }

        /*
            Agregue una ruta y nombre valido, de otra forma no era posible 
            leer el archivo.
            Tambien separe los metodos de lectura.
        */

        public static Persona LeerXml()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "Archivo XML.xml");
            using (XmlReader xml = XmlReader.Create(path))
            {
                XmlSerializer deserializador = new XmlSerializer(typeof(Persona));
                return (Persona)deserializador.Deserialize(xml);
            }
        }

        public static Persona LeerJson()
        {
            string pathJson = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "Archivo JSON.json");
            using (StreamReader archivoJson = new StreamReader(pathJson))
            {
                string jsonString = archivoJson.ReadToEnd();
                return JsonSerializer.Deserialize<Persona>(jsonString);
            }
        }

        public override string ToString()
        {
            return $"Nombre: {_nombre}\n" +
                $"Apellido: {_apellido}";
        }
    }
}
