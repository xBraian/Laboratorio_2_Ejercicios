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
    public partial class FrmAltaModificacion : Form
    {

        public string Objeto { get => txtObjeto.Text; }

        public FrmAltaModificacion(string titulo, string contenido, string texto)
        {
            InitializeComponent();
            Text = titulo;
            txtObjeto.Text = contenido;
            btnConfirmar.Text = texto;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ValidarTexto();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txtObjeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                ValidarTexto();
            }
            else if (e.KeyChar == (char)27)
            {
                DialogResult= DialogResult.Cancel;
            }
        }

        private void ValidarTexto()
        {
            if (string.IsNullOrWhiteSpace(txtObjeto.Text))
            {
                MessageBox.Show($"El texto ' {txtObjeto.Text} ' no es valido.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
