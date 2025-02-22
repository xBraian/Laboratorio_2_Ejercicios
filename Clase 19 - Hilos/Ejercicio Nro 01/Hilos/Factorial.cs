using System;
using System.Threading;
using System.Windows.Forms;

namespace Hilos
{
    public partial class Factorial : Form
    {
        private string _mensaje;

        public Factorial()
        {
            InitializeComponent();
        }

        private int CalcularFactorial(int numero)
        {
            if (numero < 0)
            {
                throw new ArgumentException($"{numero} es menor que 0.");
            }
            int resultado = 1;
            for (int i = 1; i <= numero; i++)
            {
                resultado *= i;
                Thread.Sleep(100);
            }
            return resultado;
        }

        private void ActualizarResultado()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(ActualizarResultado));
            }
            else
            {
                lblResultado.Text = $"Resultado: {_mensaje}";
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtNumero.Text, out int numero))
                {
                    throw new FormatException($"'{txtNumero.Text}' no es un numero");
                }
                Thread hiloFactorial = new Thread(() =>
                {
                    try
                    {
                        _mensaje = CalcularFactorial(numero).ToString();
                    }
                    catch (ArgumentException ex)
                    {
                        _mensaje = ex.Message;
                    }
                    finally
                    {
                        ActualizarResultado();
                    }
                });
                hiloFactorial.Start();
            }
            catch (FormatException ex)
            {
                _mensaje = ex.Message;
                ActualizarResultado();
            }
            finally
            {
                txtNumero.Text = string.Empty;
            }
        }
    }
}
