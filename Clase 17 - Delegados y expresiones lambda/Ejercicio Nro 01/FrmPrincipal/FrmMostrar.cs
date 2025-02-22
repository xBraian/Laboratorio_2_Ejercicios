using System.Windows.Forms;

namespace MisFormularios
{
    public partial class FrmMostrar : Form
    {
        public FrmMostrar()
        {
            InitializeComponent();
        }
        
        public void ActualizarNombre(string nombre)
        {
            lblNombre.Text = nombre;
        }

        private void FrmMostrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
