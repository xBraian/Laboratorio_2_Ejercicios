using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Ejercicio_Nro_02
{
    public partial class FrmListaSuper : Form
    {
        private List<string> _listaSupermercado;
        private string _pathXml;

        public FrmListaSuper()
        {
            InitializeComponent();
            _listaSupermercado = new List<string>();
            _pathXml = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
                , "listaSupermercado.xml");
        }

        private void FrmListaSuper_Load(object sender, EventArgs e)
        {
            if (File.Exists(_pathXml))
            {
                LeerXml();
                ActualizarLista();
            }
        }

        private void btnAgregar_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnAgregar, "Agregar objeto");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaModificacion alta = new FrmAltaModificacion("Agregar objeto", string.Empty, "Agregar");
            if (alta.ShowDialog() == DialogResult.OK)
            {
                _listaSupermercado.Add(alta.Objeto);
                ActualizarLista();
            }
        }

        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnEliminar, "Eliminar objeto");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lbObjetos.SelectedItem is null)
            {
                MessageBox.Show("Se debe seleccionar un elemento de la lista.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("¿Seguro que desea eliminar el elemento seleccionado?", "Advertencia",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _listaSupermercado.RemoveAt(lbObjetos.SelectedIndex);
                ActualizarLista();
            }
        }

        private void btnModificar_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnModificar, "Modificar objeto");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!(lbObjetos.SelectedItem is null))
            {
                FrmAltaModificacion modificar = new FrmAltaModificacion("Modificar objeto",
                lbObjetos.SelectedItem.ToString(), "Modificar");
                if (modificar.ShowDialog() == DialogResult.OK)
                {
                    _listaSupermercado[lbObjetos.SelectedIndex] = modificar.Objeto;
                }
                ActualizarLista();
            }
        }

        private void FrmListaSuper_FormClosing(object sender, FormClosingEventArgs e)
        {
            GuardarXml();
        }

        private void ActualizarLista()
        {
            lbObjetos.DataSource = null;
            lbObjetos.DataSource = _listaSupermercado;
        }

        /*
            Anotacion:
            En las versiones actuales de .NET, tanto XmlTextWriter como XmlTextReader quedaron
            "obsoletos", por lo que uso XmlWriter y XmlReader. Estas clases son abstractas, asi 
            que para instanciar un objeto es necesario usar el metodo de clase .Create().
        */

        private void GuardarXml ()
        {
            XmlWriterSettings configuracion = new XmlWriterSettings();
            configuracion.Indent = true;
            using (XmlWriter writer = XmlWriter.Create(_pathXml, configuracion))
            {
                XmlSerializer serializador = new XmlSerializer(typeof(List<string>));
                serializador.Serialize(writer, _listaSupermercado);
            }
        }

        private void LeerXml()
        {
            using (XmlReader reader = XmlReader.Create(_pathXml))
            {
                XmlSerializer deserializador = new XmlSerializer(typeof(List<string>));
                _listaSupermercado = (List<string>)deserializador.Deserialize(reader);
            }
        }
    }
}
