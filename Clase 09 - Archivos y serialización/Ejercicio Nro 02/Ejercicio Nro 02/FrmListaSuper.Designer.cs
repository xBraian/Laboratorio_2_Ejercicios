namespace Ejercicio_Nro_02
{
    partial class FrmListaSuper
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
            this.lbObjetos = new System.Windows.Forms.ListBox();
            this.flpControles = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.tlpContenedor.SuspendLayout();
            this.flpControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpContenedor
            // 
            this.tlpContenedor.ColumnCount = 2;
            this.tlpContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpContenedor.Controls.Add(this.lbObjetos, 0, 0);
            this.tlpContenedor.Controls.Add(this.flpControles, 1, 0);
            this.tlpContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContenedor.Location = new System.Drawing.Point(0, 0);
            this.tlpContenedor.Name = "tlpContenedor";
            this.tlpContenedor.RowCount = 1;
            this.tlpContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenedor.Size = new System.Drawing.Size(632, 703);
            this.tlpContenedor.TabIndex = 0;
            // 
            // lbObjetos
            // 
            this.lbObjetos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(63)))), ((int)(((byte)(106)))));
            this.lbObjetos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbObjetos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbObjetos.ForeColor = System.Drawing.Color.White;
            this.lbObjetos.FormattingEnabled = true;
            this.lbObjetos.ItemHeight = 21;
            this.lbObjetos.Location = new System.Drawing.Point(3, 3);
            this.lbObjetos.Name = "lbObjetos";
            this.lbObjetos.Size = new System.Drawing.Size(562, 697);
            this.lbObjetos.TabIndex = 0;
            // 
            // flpControles
            // 
            this.flpControles.Controls.Add(this.btnAgregar);
            this.flpControles.Controls.Add(this.btnEliminar);
            this.flpControles.Controls.Add(this.btnModificar);
            this.flpControles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpControles.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpControles.Location = new System.Drawing.Point(571, 3);
            this.flpControles.Name = "flpControles";
            this.flpControles.Size = new System.Drawing.Size(58, 697);
            this.flpControles.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(63)))), ((int)(((byte)(106)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.Location = new System.Drawing.Point(3, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(50, 50);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            this.btnAgregar.MouseHover += new System.EventHandler(this.btnAgregar_MouseHover);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(63)))), ((int)(((byte)(106)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Location = new System.Drawing.Point(3, 59);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(50, 50);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "-";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnEliminar.MouseHover += new System.EventHandler(this.btnEliminar_MouseHover);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(63)))), ((int)(((byte)(106)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnModificar.Location = new System.Drawing.Point(3, 115);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(50, 50);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "M";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            this.btnModificar.MouseHover += new System.EventHandler(this.btnModificar_MouseHover);
            // 
            // FrmListaSuper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(63)))), ((int)(((byte)(106)))));
            this.ClientSize = new System.Drawing.Size(632, 703);
            this.Controls.Add(this.tlpContenedor);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListaSuper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista del supermercado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmListaSuper_FormClosing);
            this.Load += new System.EventHandler(this.FrmListaSuper_Load);
            this.tlpContenedor.ResumeLayout(false);
            this.flpControles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpContenedor;
        private System.Windows.Forms.ListBox lbObjetos;
        private System.Windows.Forms.FlowLayoutPanel flpControles;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
    }
}

