namespace Ejercicio_Nro_02
{
    partial class FrmCalculador
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
            this.tlpIngresoDatos = new System.Windows.Forms.TableLayoutPanel();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.tlpLitros = new System.Windows.Forms.TableLayoutPanel();
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.lblLitros = new System.Windows.Forms.Label();
            this.tlpKilometros = new System.Windows.Forms.TableLayoutPanel();
            this.lblKilometros = new System.Windows.Forms.Label();
            this.txtKilometros = new System.Windows.Forms.TextBox();
            this.rtbCalculador = new System.Windows.Forms.RichTextBox();
            this.tlpContenedor.SuspendLayout();
            this.tlpIngresoDatos.SuspendLayout();
            this.tlpLitros.SuspendLayout();
            this.tlpKilometros.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpContenedor
            // 
            this.tlpContenedor.ColumnCount = 2;
            this.tlpContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpContenedor.Controls.Add(this.tlpIngresoDatos, 0, 0);
            this.tlpContenedor.Controls.Add(this.rtbCalculador, 1, 0);
            this.tlpContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContenedor.Location = new System.Drawing.Point(0, 0);
            this.tlpContenedor.Name = "tlpContenedor";
            this.tlpContenedor.RowCount = 1;
            this.tlpContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenedor.Size = new System.Drawing.Size(732, 353);
            this.tlpContenedor.TabIndex = 0;
            // 
            // tlpIngresoDatos
            // 
            this.tlpIngresoDatos.ColumnCount = 1;
            this.tlpIngresoDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpIngresoDatos.Controls.Add(this.btnCalcular, 0, 2);
            this.tlpIngresoDatos.Controls.Add(this.tlpLitros, 0, 1);
            this.tlpIngresoDatos.Controls.Add(this.tlpKilometros, 0, 0);
            this.tlpIngresoDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpIngresoDatos.Location = new System.Drawing.Point(3, 3);
            this.tlpIngresoDatos.Name = "tlpIngresoDatos";
            this.tlpIngresoDatos.RowCount = 3;
            this.tlpIngresoDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.66667F));
            this.tlpIngresoDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.66667F));
            this.tlpIngresoDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.66667F));
            this.tlpIngresoDatos.Size = new System.Drawing.Size(213, 347);
            this.tlpIngresoDatos.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(61)))), ((int)(((byte)(64)))));
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(61)))), ((int)(((byte)(64)))));
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Location = new System.Drawing.Point(31, 285);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(150, 30);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // tlpLitros
            // 
            this.tlpLitros.ColumnCount = 1;
            this.tlpLitros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLitros.Controls.Add(this.txtLitros, 0, 1);
            this.tlpLitros.Controls.Add(this.lblLitros, 0, 0);
            this.tlpLitros.Location = new System.Drawing.Point(3, 130);
            this.tlpLitros.Name = "tlpLitros";
            this.tlpLitros.RowCount = 2;
            this.tlpLitros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLitros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLitros.Size = new System.Drawing.Size(207, 100);
            this.tlpLitros.TabIndex = 1;
            // 
            // txtLitros
            // 
            this.txtLitros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLitros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(61)))), ((int)(((byte)(64)))));
            this.txtLitros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLitros.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtLitros.ForeColor = System.Drawing.Color.White;
            this.txtLitros.Location = new System.Drawing.Point(28, 64);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(150, 21);
            this.txtLitros.TabIndex = 2;
            // 
            // lblLitros
            // 
            this.lblLitros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLitros.AutoSize = true;
            this.lblLitros.Location = new System.Drawing.Point(3, 29);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(51, 21);
            this.lblLitros.TabIndex = 1;
            this.lblLitros.Text = "Litros";
            // 
            // tlpKilometros
            // 
            this.tlpKilometros.ColumnCount = 1;
            this.tlpKilometros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpKilometros.Controls.Add(this.lblKilometros, 0, 0);
            this.tlpKilometros.Controls.Add(this.txtKilometros, 0, 1);
            this.tlpKilometros.Location = new System.Drawing.Point(3, 3);
            this.tlpKilometros.Name = "tlpKilometros";
            this.tlpKilometros.RowCount = 2;
            this.tlpKilometros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpKilometros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpKilometros.Size = new System.Drawing.Size(207, 100);
            this.tlpKilometros.TabIndex = 0;
            // 
            // lblKilometros
            // 
            this.lblKilometros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblKilometros.AutoSize = true;
            this.lblKilometros.Location = new System.Drawing.Point(3, 29);
            this.lblKilometros.Name = "lblKilometros";
            this.lblKilometros.Size = new System.Drawing.Size(93, 21);
            this.lblKilometros.TabIndex = 0;
            this.lblKilometros.Text = "Kilometros";
            // 
            // txtKilometros
            // 
            this.txtKilometros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKilometros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(61)))), ((int)(((byte)(64)))));
            this.txtKilometros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKilometros.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtKilometros.ForeColor = System.Drawing.Color.White;
            this.txtKilometros.Location = new System.Drawing.Point(28, 64);
            this.txtKilometros.Name = "txtKilometros";
            this.txtKilometros.Size = new System.Drawing.Size(150, 21);
            this.txtKilometros.TabIndex = 1;
            // 
            // rtbCalculador
            // 
            this.rtbCalculador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.rtbCalculador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbCalculador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbCalculador.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.rtbCalculador.ForeColor = System.Drawing.Color.White;
            this.rtbCalculador.Location = new System.Drawing.Point(222, 3);
            this.rtbCalculador.Name = "rtbCalculador";
            this.rtbCalculador.ReadOnly = true;
            this.rtbCalculador.Size = new System.Drawing.Size(507, 347);
            this.rtbCalculador.TabIndex = 2;
            this.rtbCalculador.Text = "";
            // 
            // FrmCalculador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(732, 353);
            this.Controls.Add(this.tlpContenedor);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalculador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculador";
            this.tlpContenedor.ResumeLayout(false);
            this.tlpIngresoDatos.ResumeLayout(false);
            this.tlpLitros.ResumeLayout(false);
            this.tlpLitros.PerformLayout();
            this.tlpKilometros.ResumeLayout(false);
            this.tlpKilometros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpContenedor;
        private System.Windows.Forms.TableLayoutPanel tlpKilometros;
        private System.Windows.Forms.Label lblKilometros;
        private System.Windows.Forms.TextBox txtKilometros;
        private System.Windows.Forms.TableLayoutPanel tlpLitros;
        private System.Windows.Forms.Label lblLitros;
        private System.Windows.Forms.TextBox txtLitros;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TableLayoutPanel tlpIngresoDatos;
        private System.Windows.Forms.RichTextBox rtbCalculador;
    }
}

