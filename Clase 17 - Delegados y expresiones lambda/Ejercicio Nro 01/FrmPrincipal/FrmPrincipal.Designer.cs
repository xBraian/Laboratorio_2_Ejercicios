namespace MisFormularios
{
    partial class FrmPrincipal
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
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmiAlta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMostrar = new System.Windows.Forms.ToolStripMenuItem();
            this.msPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.msPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAlta,
            this.tsmiMostrar});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(1062, 28);
            this.msPrincipal.TabIndex = 1;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // tsmiAlta
            // 
            this.tsmiAlta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTest,
            this.tsmiAlumno});
            this.tsmiAlta.Name = "tsmiAlta";
            this.tsmiAlta.Size = new System.Drawing.Size(50, 24);
            this.tsmiAlta.Text = "Alta";
            // 
            // tsmiTest
            // 
            this.tsmiTest.Name = "tsmiTest";
            this.tsmiTest.Size = new System.Drawing.Size(194, 26);
            this.tsmiTest.Text = "Test Delegados";
            this.tsmiTest.Click += new System.EventHandler(this.tsmiTest_Click);
            // 
            // tsmiAlumno
            // 
            this.tsmiAlumno.Name = "tsmiAlumno";
            this.tsmiAlumno.Size = new System.Drawing.Size(194, 26);
            this.tsmiAlumno.Text = "Alumno";
            // 
            // tsmiMostrar
            // 
            this.tsmiMostrar.Name = "tsmiMostrar";
            this.tsmiMostrar.Size = new System.Drawing.Size(73, 24);
            this.tsmiMostrar.Text = "Mostrar";
            this.tsmiMostrar.Click += new System.EventHandler(this.tsmiMostrar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.msPrincipal);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmiAlta;
        private System.Windows.Forms.ToolStripMenuItem tsmiTest;
        private System.Windows.Forms.ToolStripMenuItem tsmiAlumno;
        private System.Windows.Forms.ToolStripMenuItem tsmiMostrar;
    }
}

