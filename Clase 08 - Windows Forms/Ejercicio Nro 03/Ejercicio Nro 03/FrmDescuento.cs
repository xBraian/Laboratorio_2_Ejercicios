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

namespace Ejercicio_Nro_03
{
    public partial class FrmDescuento : Form
    {
        private Restaurante _restaurante;

        public FrmDescuento()
        {
            InitializeComponent();
        }

        private void FrmDescuento_Load(object sender, EventArgs e)
        {
            _restaurante = new Restaurante();
            txtDescuento.Enabled = false;
            txtTotal.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtImporte.Text, out decimal importe))
            {
                _restaurante.Productos = new Producto(importe);
                txtDescuento.Text = _restaurante.Descuento.ToString();
                txtTotal.Text = _restaurante.PrecioFinal.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control c in tlpInformacion.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = string.Empty;
                }
            }
        }
    }
}
