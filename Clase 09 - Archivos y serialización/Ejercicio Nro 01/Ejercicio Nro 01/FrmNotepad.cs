using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Nro_01
{
    public partial class FrmNotepad : Form
    {
        private string _filtro;
        private string _ultimoArchivo;

        public FrmNotepad()
        {
            InitializeComponent();
        }

        private void FrmNotepad_Load(object sender, EventArgs e)
        {
            _filtro = "Archivos de texto | *.txt";
            _ultimoArchivo = null;
            tsslCantidadCaracteres.Text = "Cantidad de caracteres: 0";
        }

        private void tsmiAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirArchivo = new OpenFileDialog();
            abrirArchivo.Filter = _filtro;
            if (abrirArchivo.ShowDialog() == DialogResult.OK)
            {
                rtbNotepad.Text = null;
                _ultimoArchivo = abrirArchivo.FileName;
                using (StreamReader archivo = new StreamReader(_ultimoArchivo, true))
                {
                    rtbNotepad.Text = archivo.ReadToEnd();
                }
            }
        }

        private void tsmiGuardarComo_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardarArchivo = new SaveFileDialog();
            guardarArchivo.Filter = _filtro;
            if (guardarArchivo.ShowDialog() == DialogResult.OK)
            {
                _ultimoArchivo = guardarArchivo.FileName;
                EscribirArchivo();
            }
        }

        private void tsmiGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_ultimoArchivo))
            {
                tsmiGuardarComo_Click(sender, e);
            }
            else
            {
                EscribirArchivo();
            }
        }

        private void EscribirArchivo()
        {
            using (StreamWriter archivo = new StreamWriter(_ultimoArchivo))
            {
                archivo.Write(rtbNotepad.Text);
                MessageBox.Show("Archivo guardado correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rtbNotepad_TextChanged(object sender, EventArgs e)
        {
            tsslCantidadCaracteres.Text = $"Cantidad de caracteres: {rtbNotepad.Text.Length}";
        }
    }
}
