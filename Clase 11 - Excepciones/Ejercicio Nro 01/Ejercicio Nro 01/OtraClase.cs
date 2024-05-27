namespace Ejercicio_Nro_01
{
    public class OtraClase
    {
        public void GenerarMiClase(int id, string nombre)
        {
            try
            {
                MiClase miClase = new MiClase(id, nombre);
            }
            catch (UnaExcepcion ex)
            {
                throw new MiExcepcion("Excepcion en OtraClase", ex);
            }
        }
    }
}
