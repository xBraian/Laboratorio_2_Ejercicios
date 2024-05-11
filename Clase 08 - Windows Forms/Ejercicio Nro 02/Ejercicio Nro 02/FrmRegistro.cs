using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Nro_02
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        public enum EPaises
        {
            Argentina,
            Bolivia,
            Brasil,
            Chile,
            Colombia,
            Ecuador,
            Paraguay,
            Peru,
            Uruguay,
            Venezuela
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            lbPais.DataSource = Enum.GetValues(typeof(EPaises));
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bool exito = true;
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                exito = false;
            }
            if (exito)
            {
                Ingresante ingresante = new Ingresante(txtNombre.Text, int.Parse(nudEdad.Value.ToString()), ObtenerGenero(), 
                    txtDireccion.Text, lbPais.SelectedItem.ToString(), ObtenerCursos());
                MessageBox.Show(ingresante.Mostrar());
            }
            else
            {
                MessageBox.Show("No fue posible el ingreso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ObtenerGenero()
        {
            if (rbMasculino.Checked)
            {
                return rbMasculino.Text;
            }
            if (rbFemenino.Checked)
            {
                return rbFemenino.Text;
            }
            return rbNoBinario.Text;
        }

        private List<Curso> ObtenerCursos()
        {
            List<Curso> cursos = new List<Curso>();
            if (cbCSharp.Checked)
            {
                cursos.Add(new Curso (cbCSharp.Text));
            }
            if (cbJavaScript.Checked)
            {
                cursos.Add(new Curso(cbJavaScript.Text));
            }
            if (cbPython.Checked)
            {
                cursos.Add(new Curso(cbPython.Text));
            }
            return cursos;
        }
    }
}
