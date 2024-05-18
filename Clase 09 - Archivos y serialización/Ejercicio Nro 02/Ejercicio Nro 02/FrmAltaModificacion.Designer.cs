namespace Ejercicio_Nro_02
{
    partial class FrmAltaModificacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpContenedor = new System.Windows.Forms.TableLayoutPanel();
            this.txtObjeto = new System.Windows.Forms.TextBox();
            this.flpControles = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.tlpContenedor.SuspendLayout();
            this.flpControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpContenedor
            // 
            this.tlpContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(63)))), ((int)(((byte)(106)))));
            this.tlpContenedor.ColumnCount = 1;
            this.tlpContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenedor.Controls.Add(this.txtObjeto, 0, 0);
            this.tlpContenedor.Controls.Add(this.flpControles, 0, 1);
            this.tlpContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContenedor.Location = new System.Drawing.Point(0, 0);
            this.tlpContenedor.Name = "tlpContenedor";
            this.tlpContenedor.RowCount = 2;
            this.tlpContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpContenedor.Size = new System.Drawing.Size(616, 237);
            this.tlpContenedor.TabIndex = 0;
            // 
            // txtObjeto
            // 
            this.txtObjeto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObjeto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(63)))), ((int)(((byte)(106)))));
            this.txtObjeto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObjeto.ForeColor = System.Drawing.Color.White;
            this.txtObjeto.Location = new System.Drawing.Point(33, 68);
            this.txtObjeto.MaxLength = 50;
            this.txtObjeto.Name = "txtObjeto";
            this.txtObjeto.Size = new System.Drawing.Size(550, 28);
            this.txtObjeto.TabIndex = 0;
            this.txtObjeto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtObjeto_KeyPress);
            // 
            // flpControles
            // 
            this.flpControles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flpControles.Controls.Add(this.btnCancelar);
            this.flpControles.Controls.Add(this.btnConfirmar);
            this.flpControles.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpControles.Location = new System.Drawing.Point(3, 179);
            this.flpControles.Name = "flpControles";
            this.flpControles.Size = new System.Drawing.Size(610, 43);
            this.flpControles.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(63)))), ((int)(((byte)(106)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(407, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(200, 40);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(63)))), ((int)(((byte)(106)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirmar.Location = new System.Drawing.Point(201, 3);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(200, 40);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // FrmAltaModificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(63)))), ((int)(((byte)(106)))));
            this.ClientSize = new System.Drawing.Size(616, 237);
            this.ControlBox = false;
            this.Controls.Add(this.tlpContenedor);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAltaModificacion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Titulo";
            this.tlpContenedor.ResumeLayout(false);
            this.tlpContenedor.PerformLayout();
            this.flpControles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpContenedor;
        private System.Windows.Forms.TextBox txtObjeto;
        private System.Windows.Forms.FlowLayoutPanel flpControles;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
    }
}