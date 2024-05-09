using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Nro_01
{
    public partial class FrmBienvenido : Form
    {
        public FrmBienvenido()
        {
            InitializeComponent();
        }

        public enum EGeneros
        {
            Accion,
            Comedia,
            Drama,
            Aventura,
            Ficcion,
            Fantasia,
            Suspenso,
            Animacion,
            Romance,
            Terror
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                string camposVacios = string.Empty;
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    camposVacios += "Nombre\n";
                }
                if (string.IsNullOrWhiteSpace(txtApellido.Text))
                {
                    camposVacios += "Apellido";
                }
                MessageBox.Show("Se deben completar los siguientes campos:\n" +
                    camposVacios, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Hide();
                string titulo = "¡Hola, Windows Forms!";
                string mensaje = $"Soy {txtNombre.Text} {txtApellido.Text} " +
                    $"y mi género de película favorito es {cmbGenero.SelectedItem}.";
                FrmSaludo frmSaludo = new FrmSaludo(titulo, mensaje);
                frmSaludo.ShowDialog();
                txtNombre.Text = string.Empty;
                txtApellido.Text = string.Empty;
                Show();
            }
        }

        private void FrmBienvenido_Load(object sender, EventArgs e)
        {
            cmbGenero.DataSource = Enum.GetValues(typeof(EGeneros));
        }
    }
}
