namespace Ejercicio_Nro_03
{
    partial class FrmDescuento
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
            this.tlpControles = new System.Windows.Forms.TableLayoutPanel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbInformacion = new System.Windows.Forms.GroupBox();
            this.tlpInformacion = new System.Windows.Forms.TableLayoutPanel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.tlpContenedor.SuspendLayout();
            this.tlpControles.SuspendLayout();
            this.gbInformacion.SuspendLayout();
            this.tlpInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpContenedor
            // 
            this.tlpContenedor.ColumnCount = 1;
            this.tlpContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenedor.Controls.Add(this.tlpControles, 0, 1);
            this.tlpContenedor.Controls.Add(this.gbInformacion, 0, 0);
            this.tlpContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContenedor.Location = new System.Drawing.Point(0, 0);
            this.tlpContenedor.Name = "tlpContenedor";
            this.tlpContenedor.RowCount = 2;
            this.tlpContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpContenedor.Size = new System.Drawing.Size(482, 353);
            this.tlpContenedor.TabIndex = 0;
            // 
            // tlpControles
            // 
            this.tlpControles.ColumnCount = 2;
            this.tlpControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpControles.Controls.Add(this.btnLimpiar, 1, 0);
            this.tlpControles.Controls.Add(this.btnAceptar, 0, 0);
            this.tlpControles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControles.Location = new System.Drawing.Point(3, 285);
            this.tlpControles.Name = "tlpControles";
            this.tlpControles.RowCount = 1;
            this.tlpControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpControles.Size = new System.Drawing.Size(476, 65);
            this.tlpControles.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(241, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(232, 59);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(3, 3);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(232, 59);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gbInformacion
            // 
            this.gbInformacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbInformacion.Controls.Add(this.tlpInformacion);
            this.gbInformacion.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.gbInformacion.ForeColor = System.Drawing.Color.White;
            this.gbInformacion.Location = new System.Drawing.Point(28, 28);
            this.gbInformacion.Name = "gbInformacion";
            this.gbInformacion.Size = new System.Drawing.Size(425, 225);
            this.gbInformacion.TabIndex = 1;
            this.gbInformacion.TabStop = false;
            this.gbInformacion.Text = "Información";
            // 
            // tlpInformacion
            // 
            this.tlpInformacion.ColumnCount = 2;
            this.tlpInformacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpInformacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpInformacion.Controls.Add(this.txtTotal, 1, 2);
            this.tlpInformacion.Controls.Add(this.txtDescuento, 1, 1);
            this.tlpInformacion.Controls.Add(this.lblImporte, 0, 0);
            this.tlpInformacion.Controls.Add(this.lblDescuento, 0, 1);
            this.tlpInformacion.Controls.Add(this.lblTotal, 0, 2);
            this.tlpInformacion.Controls.Add(this.txtImporte, 1, 0);
            this.tlpInformacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInformacion.Location = new System.Drawing.Point(3, 24);
            this.tlpInformacion.Name = "tlpInformacion";
            this.tlpInformacion.RowCount = 3;
            this.tlpInformacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpInformacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpInformacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tlpInformacion.Size = new System.Drawing.Size(419, 198);
            this.tlpInformacion.TabIndex = 0;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Location = new System.Drawing.Point(285, 153);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 21);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescuento.Location = new System.Drawing.Point(285, 87);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 21);
            this.txtDescuento.TabIndex = 4;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblImporte
            // 
            this.lblImporte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblImporte.Location = new System.Drawing.Point(17, 23);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(217, 19);
            this.lblImporte.TabIndex = 0;
            this.lblImporte.Text = "Ingrese importe a cobrar:";
            // 
            // lblDescuento
            // 
            this.lblDescuento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(36, 87);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(179, 21);
            this.lblDescuento.TabIndex = 1;
            this.lblDescuento.Text = "Descuento recibido:";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(65, 154);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(121, 19);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total a pagar:";
            // 
            // txtImporte
            // 
            this.txtImporte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtImporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImporte.Location = new System.Drawing.Point(285, 22);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(100, 21);
            this.txtImporte.TabIndex = 3;
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmDescuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.tlpContenedor);
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDescuento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Descuento";
            this.Load += new System.EventHandler(this.FrmDescuento_Load);
            this.tlpContenedor.ResumeLayout(false);
            this.tlpControles.ResumeLayout(false);
            this.gbInformacion.ResumeLayout(false);
            this.tlpInformacion.ResumeLayout(false);
            this.tlpInformacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpContenedor;
        private System.Windows.Forms.TableLayoutPanel tlpControles;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox gbInformacion;
        private System.Windows.Forms.TableLayoutPanel tlpInformacion;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtImporte;
    }
}

