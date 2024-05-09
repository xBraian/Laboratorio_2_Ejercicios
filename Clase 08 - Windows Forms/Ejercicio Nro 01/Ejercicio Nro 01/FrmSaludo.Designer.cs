namespace Ejercicio_Nro_01
{
    partial class FrmSaludo
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
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tlpContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpContenedor
            // 
            this.tlpContenedor.ColumnCount = 1;
            this.tlpContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContenedor.Controls.Add(this.lblMensaje, 0, 1);
            this.tlpContenedor.Controls.Add(this.lblTitulo, 0, 0);
            this.tlpContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContenedor.Location = new System.Drawing.Point(0, 0);
            this.tlpContenedor.Name = "tlpContenedor";
            this.tlpContenedor.RowCount = 2;
            this.tlpContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContenedor.Size = new System.Drawing.Size(482, 453);
            this.tlpContenedor.TabIndex = 0;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.lblMensaje.Location = new System.Drawing.Point(241, 226);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 22);
            this.lblMensaje.TabIndex = 1;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.lblTitulo.Location = new System.Drawing.Point(241, 204);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(0, 22);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmSaludo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.tlpContenedor);
            this.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSaludo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saludo";
            this.Load += new System.EventHandler(this.FrmSaludo_Load);
            this.tlpContenedor.ResumeLayout(false);
            this.tlpContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpContenedor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMensaje;
    }
}