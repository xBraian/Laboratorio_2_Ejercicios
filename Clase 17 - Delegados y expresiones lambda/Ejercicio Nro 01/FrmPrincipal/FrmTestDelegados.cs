using System;
using System.Windows.Forms;

namespace MisFormularios
{
    public partial class FrmTestDelegados : Form
    {
        private Action<string> _delegado;

        public FrmTestDelegados(Action<string> delegado)
        {
            InitializeComponent();
            _delegado = delegado;
        }

        private string ObtenerNombre()
        {
            return txtNombre.Text;
        }

        private void btnActualizar_Click(object sender, System.EventArgs e)
        {
            _delegado.Invoke(txtNombre.Text);
            MessageBox.Show("Nombre ingresado correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNombre.Text = string.Empty;
        }

        private void FrmTestDelegados_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
