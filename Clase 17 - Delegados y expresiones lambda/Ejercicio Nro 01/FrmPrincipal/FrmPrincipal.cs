using System;
using System.Windows.Forms;

namespace MisFormularios
{
    public partial class FrmPrincipal : Form
    {
        private FrmMostrar _mostrar;
        private FrmTestDelegados _testDelegados;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void InstanciarMostrar()
        {
            _mostrar = new FrmMostrar()
            {
                MdiParent = this
            };
        }

        private void InstanciarTestDelegados()
        {
            _testDelegados = new FrmTestDelegados(_mostrar.ActualizarNombre)
            {
                MdiParent = this
            };
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            InstanciarMostrar();
            InstanciarTestDelegados();
        }

        private void tsmiMostrar_Click(object sender, EventArgs e)
        {
            _mostrar.Show();
        }

        private void tsmiTest_Click(object sender, EventArgs e)
        {
            _testDelegados.Show();
        }
    }
}
