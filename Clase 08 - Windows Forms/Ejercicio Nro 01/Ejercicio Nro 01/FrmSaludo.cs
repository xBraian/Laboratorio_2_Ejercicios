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
    public partial class FrmSaludo : Form
    {
        private string _titulo;
        private string _mensaje;

        public FrmSaludo(string titulo, string mensaje)
        {
            InitializeComponent();
            _titulo = titulo;
            _mensaje = mensaje;
        }

        private void FrmSaludo_Load(object sender, EventArgs e)
        {
            lblTitulo.Font = new Font("Cascadia Code", 14F, FontStyle.Italic | FontStyle.Bold);
            lblTitulo.Text = _titulo;
            lblMensaje.Font = new Font("Cascadia Code", 12F, FontStyle.Italic);
            lblMensaje.Text = _mensaje;
        }
    }
}
