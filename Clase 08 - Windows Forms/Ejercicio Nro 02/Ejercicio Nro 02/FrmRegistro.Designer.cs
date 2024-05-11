namespace Ejercicio_Nro_02
{
    partial class FrmRegistro
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
            this.tlpContenedor = new System.Windows.Forms.TableLayoutPanel();
            this.tlpLadoIzquierdo = new System.Windows.Forms.TableLayoutPanel();
            this.gbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.tlpDatosPersonales = new System.Windows.Forms.TableLayoutPanel();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.tlpPais = new System.Windows.Forms.TableLayoutPanel();
            this.lblPais = new System.Windows.Forms.Label();
            this.lbPais = new System.Windows.Forms.ListBox();
            this.tlpLadoDerecho = new System.Windows.Forms.TableLayoutPanel();
            this.gbCursos = new System.Windows.Forms.GroupBox();
            this.flpCursos = new System.Windows.Forms.FlowLayoutPanel();
            this.cbCSharp = new System.Windows.Forms.CheckBox();
            this.cbJavaScript = new System.Windows.Forms.CheckBox();
            this.cbPython = new System.Windows.Forms.CheckBox();
            this.gbGenero = new System.Windows.Forms.GroupBox();
            this.flpGenero = new System.Windows.Forms.FlowLayoutPanel();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbNoBinario = new System.Windows.Forms.RadioButton();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.tlpContenedor.SuspendLayout();
            this.tlpLadoIzquierdo.SuspendLayout();
            this.gbDatosPersonales.SuspendLayout();
            this.tlpDatosPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.tlpPais.SuspendLayout();
            this.tlpLadoDerecho.SuspendLayout();
            this.gbCursos.SuspendLayout();
            this.flpCursos.SuspendLayout();
            this.gbGenero.SuspendLayout();
            this.flpGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpContenedor
            // 
            this.tlpContenedor.ColumnCount = 2;
            this.tlpContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpContenedor.Controls.Add(this.tlpLadoIzquierdo, 0, 0);
            this.tlpContenedor.Controls.Add(this.tlpLadoDerecho, 1, 0);
            this.tlpContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContenedor.Location = new System.Drawing.Point(0, 0);
            this.tlpContenedor.Name = "tlpContenedor";
            this.tlpContenedor.RowCount = 1;
            this.tlpContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenedor.Size = new System.Drawing.Size(632, 553);
            this.tlpContenedor.TabIndex = 0;
            // 
            // tlpLadoIzquierdo
            // 
            this.tlpLadoIzquierdo.ColumnCount = 1;
            this.tlpLadoIzquierdo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLadoIzquierdo.Controls.Add(this.gbDatosPersonales, 0, 0);
            this.tlpLadoIzquierdo.Controls.Add(this.tlpPais, 0, 1);
            this.tlpLadoIzquierdo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLadoIzquierdo.Location = new System.Drawing.Point(3, 3);
            this.tlpLadoIzquierdo.Name = "tlpLadoIzquierdo";
            this.tlpLadoIzquierdo.RowCount = 2;
            this.tlpLadoIzquierdo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLadoIzquierdo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLadoIzquierdo.Size = new System.Drawing.Size(373, 547);
            this.tlpLadoIzquierdo.TabIndex = 0;
            // 
            // gbDatosPersonales
            // 
            this.gbDatosPersonales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbDatosPersonales.Controls.Add(this.tlpDatosPersonales);
            this.gbDatosPersonales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDatosPersonales.ForeColor = System.Drawing.Color.White;
            this.gbDatosPersonales.Location = new System.Drawing.Point(29, 36);
            this.gbDatosPersonales.Name = "gbDatosPersonales";
            this.gbDatosPersonales.Size = new System.Drawing.Size(315, 200);
            this.gbDatosPersonales.TabIndex = 0;
            this.gbDatosPersonales.TabStop = false;
            this.gbDatosPersonales.Text = "Detalles del usuario";
            // 
            // tlpDatosPersonales
            // 
            this.tlpDatosPersonales.ColumnCount = 2;
            this.tlpDatosPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpDatosPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpDatosPersonales.Controls.Add(this.txtDireccion, 1, 1);
            this.tlpDatosPersonales.Controls.Add(this.lblNombre, 0, 0);
            this.tlpDatosPersonales.Controls.Add(this.lblDireccion, 0, 1);
            this.tlpDatosPersonales.Controls.Add(this.lblEdad, 0, 2);
            this.tlpDatosPersonales.Controls.Add(this.txtNombre, 1, 0);
            this.tlpDatosPersonales.Controls.Add(this.nudEdad, 1, 2);
            this.tlpDatosPersonales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDatosPersonales.Location = new System.Drawing.Point(3, 24);
            this.tlpDatosPersonales.Name = "tlpDatosPersonales";
            this.tlpDatosPersonales.RowCount = 3;
            this.tlpDatosPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpDatosPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpDatosPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tlpDatosPersonales.Size = new System.Drawing.Size(309, 173);
            this.tlpDatosPersonales.TabIndex = 0;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Location = new System.Drawing.Point(95, 71);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(175, 28);
            this.txtDireccion.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNombre.AutoSize = true;
            this.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombre.Location = new System.Drawing.Point(3, 18);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 21);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDireccion.Location = new System.Drawing.Point(3, 64);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(78, 42);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblEdad
            // 
            this.lblEdad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEdad.AutoSize = true;
            this.lblEdad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEdad.Location = new System.Drawing.Point(3, 133);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(55, 21);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(95, 14);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(175, 28);
            this.txtNombre.TabIndex = 3;
            // 
            // nudEdad
            // 
            this.nudEdad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudEdad.Location = new System.Drawing.Point(95, 129);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(175, 28);
            this.nudEdad.TabIndex = 5;
            // 
            // tlpPais
            // 
            this.tlpPais.ColumnCount = 1;
            this.tlpPais.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPais.Controls.Add(this.lblPais, 0, 0);
            this.tlpPais.Controls.Add(this.lbPais, 0, 1);
            this.tlpPais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPais.Location = new System.Drawing.Point(3, 276);
            this.tlpPais.Name = "tlpPais";
            this.tlpPais.RowCount = 2;
            this.tlpPais.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpPais.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tlpPais.Size = new System.Drawing.Size(367, 268);
            this.tlpPais.TabIndex = 1;
            // 
            // lblPais
            // 
            this.lblPais.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPais.AutoSize = true;
            this.lblPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPais.Location = new System.Drawing.Point(3, 9);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(42, 21);
            this.lblPais.TabIndex = 3;
            this.lblPais.Text = "País";
            // 
            // lbPais
            // 
            this.lbPais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lbPais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPais.ForeColor = System.Drawing.Color.White;
            this.lbPais.FormattingEnabled = true;
            this.lbPais.ItemHeight = 21;
            this.lbPais.Location = new System.Drawing.Point(26, 58);
            this.lbPais.Name = "lbPais";
            this.lbPais.Size = new System.Drawing.Size(315, 191);
            this.lbPais.TabIndex = 4;
            // 
            // tlpLadoDerecho
            // 
            this.tlpLadoDerecho.ColumnCount = 1;
            this.tlpLadoDerecho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLadoDerecho.Controls.Add(this.gbCursos, 0, 1);
            this.tlpLadoDerecho.Controls.Add(this.gbGenero, 0, 0);
            this.tlpLadoDerecho.Controls.Add(this.btnIngresar, 0, 2);
            this.tlpLadoDerecho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLadoDerecho.Location = new System.Drawing.Point(382, 3);
            this.tlpLadoDerecho.Name = "tlpLadoDerecho";
            this.tlpLadoDerecho.RowCount = 3;
            this.tlpLadoDerecho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpLadoDerecho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpLadoDerecho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpLadoDerecho.Size = new System.Drawing.Size(247, 547);
            this.tlpLadoDerecho.TabIndex = 1;
            // 
            // gbCursos
            // 
            this.gbCursos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbCursos.Controls.Add(this.flpCursos);
            this.gbCursos.ForeColor = System.Drawing.Color.White;
            this.gbCursos.Location = new System.Drawing.Point(23, 306);
            this.gbCursos.Name = "gbCursos";
            this.gbCursos.Size = new System.Drawing.Size(200, 125);
            this.gbCursos.TabIndex = 1;
            this.gbCursos.TabStop = false;
            this.gbCursos.Text = "Cursos";
            // 
            // flpCursos
            // 
            this.flpCursos.Controls.Add(this.cbCSharp);
            this.flpCursos.Controls.Add(this.cbJavaScript);
            this.flpCursos.Controls.Add(this.cbPython);
            this.flpCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCursos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpCursos.Location = new System.Drawing.Point(3, 24);
            this.flpCursos.Name = "flpCursos";
            this.flpCursos.Size = new System.Drawing.Size(194, 98);
            this.flpCursos.TabIndex = 1;
            // 
            // cbCSharp
            // 
            this.cbCSharp.AutoSize = true;
            this.cbCSharp.Location = new System.Drawing.Point(3, 3);
            this.cbCSharp.Name = "cbCSharp";
            this.cbCSharp.Size = new System.Drawing.Size(58, 25);
            this.cbCSharp.TabIndex = 0;
            this.cbCSharp.Text = "C#";
            this.cbCSharp.UseVisualStyleBackColor = true;
            // 
            // cbJavaScript
            // 
            this.cbJavaScript.AutoSize = true;
            this.cbJavaScript.Location = new System.Drawing.Point(3, 34);
            this.cbJavaScript.Name = "cbJavaScript";
            this.cbJavaScript.Size = new System.Drawing.Size(121, 25);
            this.cbJavaScript.TabIndex = 1;
            this.cbJavaScript.Text = "JavaScript";
            this.cbJavaScript.UseVisualStyleBackColor = true;
            // 
            // cbPython
            // 
            this.cbPython.AutoSize = true;
            this.cbPython.Location = new System.Drawing.Point(3, 65);
            this.cbPython.Name = "cbPython";
            this.cbPython.Size = new System.Drawing.Size(88, 25);
            this.cbPython.TabIndex = 2;
            this.cbPython.Text = "Python";
            this.cbPython.UseVisualStyleBackColor = true;
            // 
            // gbGenero
            // 
            this.gbGenero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbGenero.Controls.Add(this.flpGenero);
            this.gbGenero.ForeColor = System.Drawing.Color.White;
            this.gbGenero.Location = new System.Drawing.Point(23, 60);
            this.gbGenero.Name = "gbGenero";
            this.gbGenero.Size = new System.Drawing.Size(200, 125);
            this.gbGenero.TabIndex = 0;
            this.gbGenero.TabStop = false;
            this.gbGenero.Text = "Género";
            // 
            // flpGenero
            // 
            this.flpGenero.Controls.Add(this.rbMasculino);
            this.flpGenero.Controls.Add(this.rbFemenino);
            this.flpGenero.Controls.Add(this.rbNoBinario);
            this.flpGenero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpGenero.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpGenero.Location = new System.Drawing.Point(3, 24);
            this.flpGenero.Name = "flpGenero";
            this.flpGenero.Size = new System.Drawing.Size(194, 98);
            this.flpGenero.TabIndex = 0;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Checked = true;
            this.rbMasculino.Location = new System.Drawing.Point(3, 3);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(115, 25);
            this.rbMasculino.TabIndex = 0;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(3, 34);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(110, 25);
            this.rbFemenino.TabIndex = 1;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbNoBinario
            // 
            this.rbNoBinario.AutoSize = true;
            this.rbNoBinario.Location = new System.Drawing.Point(3, 65);
            this.rbNoBinario.Name = "rbNoBinario";
            this.rbNoBinario.Size = new System.Drawing.Size(116, 25);
            this.rbNoBinario.TabIndex = 2;
            this.rbNoBinario.Text = "No binario";
            this.rbNoBinario.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Location = new System.Drawing.Point(144, 504);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(100, 30);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(632, 553);
            this.Controls.Add(this.tlpContenedor);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.FrmRegistro_Load);
            this.tlpContenedor.ResumeLayout(false);
            this.tlpLadoIzquierdo.ResumeLayout(false);
            this.gbDatosPersonales.ResumeLayout(false);
            this.tlpDatosPersonales.ResumeLayout(false);
            this.tlpDatosPersonales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.tlpPais.ResumeLayout(false);
            this.tlpPais.PerformLayout();
            this.tlpLadoDerecho.ResumeLayout(false);
            this.gbCursos.ResumeLayout(false);
            this.flpCursos.ResumeLayout(false);
            this.flpCursos.PerformLayout();
            this.gbGenero.ResumeLayout(false);
            this.flpGenero.ResumeLayout(false);
            this.flpGenero.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpContenedor;
        private System.Windows.Forms.TableLayoutPanel tlpLadoIzquierdo;
        private System.Windows.Forms.TableLayoutPanel tlpLadoDerecho;
        private System.Windows.Forms.GroupBox gbDatosPersonales;
        private System.Windows.Forms.TableLayoutPanel tlpDatosPersonales;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.TableLayoutPanel tlpPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.ListBox lbPais;
        private System.Windows.Forms.GroupBox gbGenero;
        private System.Windows.Forms.GroupBox gbCursos;
        private System.Windows.Forms.FlowLayoutPanel flpGenero;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbNoBinario;
        private System.Windows.Forms.FlowLayoutPanel flpCursos;
        private System.Windows.Forms.CheckBox cbCSharp;
        private System.Windows.Forms.CheckBox cbJavaScript;
        private System.Windows.Forms.CheckBox cbPython;
        private System.Windows.Forms.Button btnIngresar;
    }
}

