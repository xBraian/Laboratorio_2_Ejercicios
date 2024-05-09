namespace Ejercicio_Nro_01
{
    partial class FrmBienvenido
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
            this.tlpDatosPersonales = new System.Windows.Forms.TableLayoutPanel();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnSaludar = new System.Windows.Forms.Button();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.tlpContenedor.SuspendLayout();
            this.tlpDatosPersonales.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpContenedor
            // 
            this.tlpContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.tlpContenedor.ColumnCount = 1;
            this.tlpContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenedor.Controls.Add(this.tlpDatosPersonales, 0, 0);
            this.tlpContenedor.Controls.Add(this.btnSaludar, 0, 1);
            this.tlpContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContenedor.Location = new System.Drawing.Point(0, 0);
            this.tlpContenedor.Margin = new System.Windows.Forms.Padding(4);
            this.tlpContenedor.Name = "tlpContenedor";
            this.tlpContenedor.RowCount = 2;
            this.tlpContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlpContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpContenedor.Size = new System.Drawing.Size(482, 453);
            this.tlpContenedor.TabIndex = 0;
            // 
            // tlpDatosPersonales
            // 
            this.tlpDatosPersonales.ColumnCount = 2;
            this.tlpDatosPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDatosPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlpDatosPersonales.Controls.Add(this.lblGenero, 0, 2);
            this.tlpDatosPersonales.Controls.Add(this.txtApellido, 1, 1);
            this.tlpDatosPersonales.Controls.Add(this.lblNombre, 0, 0);
            this.tlpDatosPersonales.Controls.Add(this.lblApellido, 0, 1);
            this.tlpDatosPersonales.Controls.Add(this.txtNombre, 1, 0);
            this.tlpDatosPersonales.Controls.Add(this.cmbGenero, 1, 2);
            this.tlpDatosPersonales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDatosPersonales.Location = new System.Drawing.Point(4, 4);
            this.tlpDatosPersonales.Margin = new System.Windows.Forms.Padding(4);
            this.tlpDatosPersonales.Name = "tlpDatosPersonales";
            this.tlpDatosPersonales.RowCount = 3;
            this.tlpDatosPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpDatosPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpDatosPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tlpDatosPersonales.Size = new System.Drawing.Size(474, 331);
            this.tlpDatosPersonales.TabIndex = 0;
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.txtApellido.Location = new System.Drawing.Point(171, 153);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(250, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(19, 43);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 22);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.lblApellido.Location = new System.Drawing.Point(9, 152);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(100, 22);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.txtNombre.Location = new System.Drawing.Point(171, 44);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // btnSaludar
            // 
            this.btnSaludar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaludar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaludar.Location = new System.Drawing.Point(166, 358);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(150, 75);
            this.btnSaludar.TabIndex = 1;
            this.btnSaludar.Text = "Saludar";
            this.btnSaludar.UseVisualStyleBackColor = true;
            this.btnSaludar.Click += new System.EventHandler(this.btnSaludar_Click);
            // 
            // lblGenero
            // 
            this.lblGenero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.lblGenero.Location = new System.Drawing.Point(9, 252);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(100, 44);
            this.lblGenero.TabIndex = 4;
            this.lblGenero.Text = "Género favorito:";
            this.lblGenero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbGenero
            // 
            this.cmbGenero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(171, 264);
            this.cmbGenero.MaxDropDownItems = 10;
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(250, 30);
            this.cmbGenero.TabIndex = 5;
            // 
            // FrmBienvenido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.tlpContenedor);
            this.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBienvenido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "¡Hola, Windows Forms!";
            this.Load += new System.EventHandler(this.FrmBienvenido_Load);
            this.tlpContenedor.ResumeLayout(false);
            this.tlpDatosPersonales.ResumeLayout(false);
            this.tlpDatosPersonales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpContenedor;
        private System.Windows.Forms.Button btnSaludar;
        private System.Windows.Forms.TableLayoutPanel tlpDatosPersonales;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.ComboBox cmbGenero;
    }
}

