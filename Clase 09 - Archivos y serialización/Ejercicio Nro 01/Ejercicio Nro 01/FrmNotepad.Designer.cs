namespace Ejercicio_Nro_01
{
    partial class FrmNotepad
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.msNotepad = new System.Windows.Forms.MenuStrip();
            this.tsmiArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGuardarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.ssNotepad = new System.Windows.Forms.StatusStrip();
            this.tsslCantidadCaracteres = new System.Windows.Forms.ToolStripStatusLabel();
            this.rtbNotepad = new System.Windows.Forms.RichTextBox();
            this.msNotepad.SuspendLayout();
            this.ssNotepad.SuspendLayout();
            this.SuspendLayout();
            // 
            // msNotepad
            // 
            this.msNotepad.BackColor = System.Drawing.Color.Ivory;
            this.msNotepad.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.msNotepad.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msNotepad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiArchivo});
            this.msNotepad.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.msNotepad.Location = new System.Drawing.Point(0, 0);
            this.msNotepad.Name = "msNotepad";
            this.msNotepad.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.msNotepad.Size = new System.Drawing.Size(1062, 30);
            this.msNotepad.TabIndex = 0;
            this.msNotepad.Text = "Archivo";
            // 
            // tsmiArchivo
            // 
            this.tsmiArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbrir,
            this.tsmiGuardar,
            this.tsmiGuardarComo});
            this.tsmiArchivo.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.tsmiArchivo.ForeColor = System.Drawing.Color.Black;
            this.tsmiArchivo.Name = "tsmiArchivo";
            this.tsmiArchivo.Size = new System.Drawing.Size(74, 26);
            this.tsmiArchivo.Text = "Archivo";
            this.tsmiArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsmiAbrir
            // 
            this.tsmiAbrir.BackColor = System.Drawing.Color.Ivory;
            this.tsmiAbrir.ForeColor = System.Drawing.Color.Black;
            this.tsmiAbrir.Name = "tsmiAbrir";
            this.tsmiAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.tsmiAbrir.Size = new System.Drawing.Size(313, 26);
            this.tsmiAbrir.Text = "Abrir";
            this.tsmiAbrir.Click += new System.EventHandler(this.tsmiAbrir_Click);
            // 
            // tsmiGuardar
            // 
            this.tsmiGuardar.BackColor = System.Drawing.Color.Ivory;
            this.tsmiGuardar.ForeColor = System.Drawing.Color.Black;
            this.tsmiGuardar.Name = "tsmiGuardar";
            this.tsmiGuardar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiGuardar.Size = new System.Drawing.Size(313, 26);
            this.tsmiGuardar.Text = "Guardar";
            this.tsmiGuardar.Click += new System.EventHandler(this.tsmiGuardar_Click);
            // 
            // tsmiGuardarComo
            // 
            this.tsmiGuardarComo.BackColor = System.Drawing.Color.Ivory;
            this.tsmiGuardarComo.ForeColor = System.Drawing.Color.Black;
            this.tsmiGuardarComo.Name = "tsmiGuardarComo";
            this.tsmiGuardarComo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.tsmiGuardarComo.Size = new System.Drawing.Size(313, 26);
            this.tsmiGuardarComo.Text = "Guardar como...";
            this.tsmiGuardarComo.Click += new System.EventHandler(this.tsmiGuardarComo_Click);
            // 
            // ssNotepad
            // 
            this.ssNotepad.BackColor = System.Drawing.Color.Ivory;
            this.ssNotepad.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.ssNotepad.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssNotepad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslCantidadCaracteres});
            this.ssNotepad.Location = new System.Drawing.Point(0, 651);
            this.ssNotepad.Name = "ssNotepad";
            this.ssNotepad.Size = new System.Drawing.Size(1062, 22);
            this.ssNotepad.TabIndex = 1;
            this.ssNotepad.Text = "statusStrip1";
            // 
            // tsslCantidadCaracteres
            // 
            this.tsslCantidadCaracteres.ForeColor = System.Drawing.Color.Black;
            this.tsslCantidadCaracteres.Name = "tsslCantidadCaracteres";
            this.tsslCantidadCaracteres.Size = new System.Drawing.Size(0, 19);
            // 
            // rtbNotepad
            // 
            this.rtbNotepad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.rtbNotepad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbNotepad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbNotepad.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rtbNotepad.ForeColor = System.Drawing.Color.White;
            this.rtbNotepad.Location = new System.Drawing.Point(0, 30);
            this.rtbNotepad.Name = "rtbNotepad";
            this.rtbNotepad.Size = new System.Drawing.Size(1062, 621);
            this.rtbNotepad.TabIndex = 2;
            this.rtbNotepad.Text = "";
            this.rtbNotepad.TextChanged += new System.EventHandler(this.rtbNotepad_TextChanged);
            // 
            // FrmNotepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.rtbNotepad);
            this.Controls.Add(this.ssNotepad);
            this.Controls.Add(this.msNotepad);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msNotepad;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNotepad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notepad";
            this.Load += new System.EventHandler(this.FrmNotepad_Load);
            this.msNotepad.ResumeLayout(false);
            this.msNotepad.PerformLayout();
            this.ssNotepad.ResumeLayout(false);
            this.ssNotepad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msNotepad;
        private System.Windows.Forms.ToolStripMenuItem tsmiArchivo;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbrir;
        private System.Windows.Forms.ToolStripMenuItem tsmiGuardar;
        private System.Windows.Forms.ToolStripMenuItem tsmiGuardarComo;
        private System.Windows.Forms.StatusStrip ssNotepad;
        private System.Windows.Forms.ToolStripStatusLabel tsslCantidadCaracteres;
        private System.Windows.Forms.RichTextBox rtbNotepad;
    }
}

