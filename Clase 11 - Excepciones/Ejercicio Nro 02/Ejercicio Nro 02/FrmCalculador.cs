using Entidades;
using System;
using System.Windows.Forms;

namespace Ejercicio_Nro_02
{
    public partial class FrmCalculador : Form
    {
        public FrmCalculador()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtKilometros.Text) ||
                    string.IsNullOrWhiteSpace(txtLitros.Text))
                {
                    throw new ParametrosVaciosException("Se debe completar los campos 'Kilometros' y 'Litros'.");
                }
                int kilometros = int.Parse(txtKilometros.Text);
                int litros = int.Parse(txtLitros.Text);
                rtbCalculador.Text = $"{kilometros} Km. / {litros} l. = {Calculador.Dividir(kilometros, litros):0.00}";
            }
            catch (ParametrosVaciosException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message + "\nIngrese caracteres numericos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
