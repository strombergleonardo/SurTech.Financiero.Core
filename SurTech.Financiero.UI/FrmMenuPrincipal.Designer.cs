namespace SurTech.Financiero.UI
{
    partial class FrmMenuPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            pnlMenuDerecha = new Panel();
            btnCierre = new Button();
            btnRecordatorios = new Button();
            btnStock = new Button();
            btnCompras = new Button();
            btnVentas = new Button();
            pnlContenedor = new Panel();
            pnlMenuDerecha.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenuDerecha
            // 
            pnlMenuDerecha.BackColor = Color.FromArgb(51, 51, 51);
            pnlMenuDerecha.Controls.Add(btnCierre);
            pnlMenuDerecha.Controls.Add(btnRecordatorios);
            pnlMenuDerecha.Controls.Add(btnStock);
            pnlMenuDerecha.Controls.Add(btnCompras);
            pnlMenuDerecha.Controls.Add(btnVentas);
            pnlMenuDerecha.Dock = DockStyle.Right;
            pnlMenuDerecha.Location = new Point(1050, 0);
            pnlMenuDerecha.Name = "pnlMenuDerecha";
            pnlMenuDerecha.Size = new Size(230, 700);
            pnlMenuDerecha.TabIndex = 0;
            // 
            // btnCierre
            // 
            btnCierre.Dock = DockStyle.Top;
            btnCierre.FlatAppearance.BorderSize = 0;
            btnCierre.FlatStyle = FlatStyle.Flat;
            btnCierre.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCierre.ForeColor = Color.White;
            btnCierre.Location = new Point(0, 240);
            btnCierre.Name = "btnCierre";
            btnCierre.Size = new Size(230, 60);
            btnCierre.TabIndex = 4;
            btnCierre.Text = "Cierre de Ejercicio";
            btnCierre.UseVisualStyleBackColor = true;
            btnCierre.Click += BtnCierre_Click;
            // 
            // btnRecordatorios
            // 
            btnRecordatorios.Dock = DockStyle.Top;
            btnRecordatorios.FlatAppearance.BorderSize = 0;
            btnRecordatorios.FlatStyle = FlatStyle.Flat;
            btnRecordatorios.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRecordatorios.ForeColor = Color.White;
            btnRecordatorios.Location = new Point(0, 180);
            btnRecordatorios.Name = "btnRecordatorios";
            btnRecordatorios.Size = new Size(230, 60);
            btnRecordatorios.TabIndex = 3;
            btnRecordatorios.Text = "Recordatorios";
            btnRecordatorios.UseVisualStyleBackColor = true;
            btnRecordatorios.Click += BtnRecordatorios_Click;
            // 
            // btnStock
            // 
            btnStock.Dock = DockStyle.Top;
            btnStock.FlatAppearance.BorderSize = 0;
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnStock.ForeColor = Color.White;
            btnStock.Location = new Point(0, 120);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(230, 60);
            btnStock.TabIndex = 2;
            btnStock.Text = "Control de Stock";
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += BtnStock_Click;
            // 
            // btnCompras
            // 
            btnCompras.Dock = DockStyle.Top;
            btnCompras.FlatAppearance.BorderSize = 0;
            btnCompras.FlatStyle = FlatStyle.Flat;
            btnCompras.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCompras.ForeColor = Color.White;
            btnCompras.Location = new Point(0, 60);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(230, 60);
            btnCompras.TabIndex = 1;
            btnCompras.Text = "Módulo Compras";
            btnCompras.UseVisualStyleBackColor = true;
            btnCompras.Click += BtnCompras_Click;
            // 
            // btnVentas
            // 
            btnVentas.Dock = DockStyle.Top;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnVentas.ForeColor = Color.White;
            btnVentas.Location = new Point(0, 0);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(230, 60);
            btnVentas.TabIndex = 0;
            btnVentas.Text = "Módulo Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += BtnVentas_Click;
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackgroundImage = (Image)resources.GetObject("pnlContenedor.BackgroundImage");
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(0, 0);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1050, 700);
            pnlContenedor.TabIndex = 1;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 700);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlMenuDerecha);
            Name = "FrmMenuPrincipal";
            Text = "SurTech Financiero - Menú Principal";
            pnlMenuDerecha.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuDerecha;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnRecordatorios;
        private System.Windows.Forms.Button btnCierre;
        private System.Windows.Forms.Panel pnlContenedor;
    }
}