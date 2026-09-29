namespace SurTech.Financiero.UI
{
    partial class FrmCierreEjercicio
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
            lblTitulo = new Label();
            groupFiltro = new GroupBox();
            btnCalcularBalance = new Button();
            dtpHasta = new DateTimePicker();
            lblHasta = new Label();
            dtpDesde = new DateTimePicker();
            lblDesde = new Label();
            groupResultados = new GroupBox();
            lblSaldoIvaVal = new Label();
            lblSaldoIvaTexto = new Label();
            lblIvaCreditoVal = new Label();
            lblIvaCreditoTexto = new Label();
            lblIvaDebitoVal = new Label();
            lblIvaDebitoTexto = new Label();
            lblComprasVal = new Label();
            lblComprasTexto = new Label();
            lblVentasVal = new Label();
            lblVentasTexto = new Label();
            btnEjecutarCierre = new Button();
            groupFiltro.SuspendLayout();
            groupResultados.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(51, 51, 51);
            lblTitulo.Location = new Point(30, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(448, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cierre de Ejercicio y Balance - SurTech";
            // 
            // groupFiltro
            // 
            groupFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupFiltro.Controls.Add(btnCalcularBalance);
            groupFiltro.Controls.Add(dtpHasta);
            groupFiltro.Controls.Add(lblHasta);
            groupFiltro.Controls.Add(dtpDesde);
            groupFiltro.Controls.Add(lblDesde);
            groupFiltro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupFiltro.Location = new Point(30, 75);
            groupFiltro.Name = "groupFiltro";
            groupFiltro.Size = new Size(1220, 90);
            groupFiltro.TabIndex = 1;
            groupFiltro.TabStop = false;
            groupFiltro.Text = "Período Fiscal a Auditar";
            // 
            // btnCalcularBalance
            // 
            btnCalcularBalance.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCalcularBalance.Location = new Point(440, 33);
            btnCalcularBalance.Name = "btnCalcularBalance";
            btnCalcularBalance.Size = new Size(160, 30);
            btnCalcularBalance.TabIndex = 4;
            btnCalcularBalance.Text = "Calcular Balance";
            btnCalcularBalance.UseVisualStyleBackColor = true;
            btnCalcularBalance.Click += BtnCalcularBalance_Click;
            // 
            // dtpHasta
            // 
            dtpHasta.Font = new Font("Segoe UI", 9F);
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(290, 37);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(120, 23);
            dtpHasta.TabIndex = 3;
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Segoe UI", 9F);
            lblHasta.Location = new Point(235, 40);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(40, 15);
            lblHasta.TabIndex = 2;
            lblHasta.Text = "Hasta:";
            // 
            // dtpDesde
            // 
            dtpDesde.Font = new Font("Segoe UI", 9F);
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(85, 37);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(120, 23);
            dtpDesde.TabIndex = 1;
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Segoe UI", 9F);
            lblDesde.Location = new Point(30, 40);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(42, 15);
            lblDesde.TabIndex = 0;
            lblDesde.Text = "Desde:";
            // 
            // groupResultados
            // 
            groupResultados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupResultados.Controls.Add(lblSaldoIvaVal);
            groupResultados.Controls.Add(lblSaldoIvaTexto);
            groupResultados.Controls.Add(lblIvaCreditoVal);
            groupResultados.Controls.Add(lblIvaCreditoTexto);
            groupResultados.Controls.Add(lblIvaDebitoVal);
            groupResultados.Controls.Add(lblIvaDebitoTexto);
            groupResultados.Controls.Add(lblComprasVal);
            groupResultados.Controls.Add(lblComprasTexto);
            groupResultados.Controls.Add(lblVentasVal);
            groupResultados.Controls.Add(lblVentasTexto);
            groupResultados.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupResultados.Location = new Point(30, 190);
            groupResultados.Name = "groupResultados";
            groupResultados.Size = new Size(1220, 380);
            groupResultados.TabIndex = 2;
            groupResultados.TabStop = false;
            groupResultados.Text = "Balance Consolidado del Período";
            // 
            // lblSaldoIvaVal
            // 
            lblSaldoIvaVal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblSaldoIvaVal.ForeColor = Color.FromArgb(255, 102, 0);
            lblSaldoIvaVal.Location = new Point(440, 260);
            lblSaldoIvaVal.Name = "lblSaldoIvaVal";
            lblSaldoIvaVal.Size = new Size(250, 25);
            lblSaldoIvaVal.TabIndex = 9;
            lblSaldoIvaVal.Text = "$ 0.00";
            // 
            // lblSaldoIvaTexto
            // 
            lblSaldoIvaTexto.AutoSize = true;
            lblSaldoIvaTexto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSaldoIvaTexto.Location = new Point(50, 260);
            lblSaldoIvaTexto.Name = "lblSaldoIvaTexto";
            lblSaldoIvaTexto.Size = new Size(296, 21);
            lblSaldoIvaTexto.TabIndex = 8;
            lblSaldoIvaTexto.Text = "Saldo Técnico IVA (A Pagar / A Favor):";
            // 
            // lblIvaCreditoVal
            // 
            lblIvaCreditoVal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblIvaCreditoVal.Location = new Point(440, 195);
            lblIvaCreditoVal.Name = "lblIvaCreditoVal";
            lblIvaCreditoVal.Size = new Size(200, 20);
            lblIvaCreditoVal.TabIndex = 7;
            lblIvaCreditoVal.Text = "$ 0.00";
            // 
            // lblIvaCreditoTexto
            // 
            lblIvaCreditoTexto.AutoSize = true;
            lblIvaCreditoTexto.Font = new Font("Segoe UI", 11F);
            lblIvaCreditoTexto.Location = new Point(50, 195);
            lblIvaCreditoTexto.Name = "lblIvaCreditoTexto";
            lblIvaCreditoTexto.Size = new Size(200, 20);
            lblIvaCreditoTexto.TabIndex = 6;
            lblIvaCreditoTexto.Text = "IVA Crédito Fiscal (Compras):";
            // 
            // lblIvaDebitoVal
            // 
            lblIvaDebitoVal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblIvaDebitoVal.Location = new Point(440, 150);
            lblIvaDebitoVal.Name = "lblIvaDebitoVal";
            lblIvaDebitoVal.Size = new Size(200, 20);
            lblIvaDebitoVal.TabIndex = 5;
            lblIvaDebitoVal.Text = "$ 0.00";
            // 
            // lblIvaDebitoTexto
            // 
            lblIvaDebitoTexto.AutoSize = true;
            lblIvaDebitoTexto.Font = new Font("Segoe UI", 11F);
            lblIvaDebitoTexto.Location = new Point(50, 150);
            lblIvaDebitoTexto.Name = "lblIvaDebitoTexto";
            lblIvaDebitoTexto.Size = new Size(181, 20);
            lblIvaDebitoTexto.TabIndex = 4;
            lblIvaDebitoTexto.Text = "IVA Débito Fiscal (Ventas):";
            // 
            // lblComprasVal
            // 
            lblComprasVal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblComprasVal.Location = new Point(440, 95);
            lblComprasVal.Name = "lblComprasVal";
            lblComprasVal.Size = new Size(200, 20);
            lblComprasVal.TabIndex = 3;
            lblComprasVal.Text = "$ 0.00";
            // 
            // lblComprasTexto
            // 
            lblComprasTexto.AutoSize = true;
            lblComprasTexto.Font = new Font("Segoe UI", 11F);
            lblComprasTexto.Location = new Point(50, 95);
            lblComprasTexto.Name = "lblComprasTexto";
            lblComprasTexto.Size = new Size(198, 20);
            lblComprasTexto.TabIndex = 2;
            lblComprasTexto.Text = "Total Compras (Bruto + IVA):";
            // 
            // lblVentasVal
            // 
            lblVentasVal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblVentasVal.Location = new Point(440, 50);
            lblVentasVal.Name = "lblVentasVal";
            lblVentasVal.Size = new Size(200, 20);
            lblVentasVal.TabIndex = 1;
            lblVentasVal.Text = "$ 0.00";
            // 
            // lblVentasTexto
            // 
            lblVentasTexto.AutoSize = true;
            lblVentasTexto.Font = new Font("Segoe UI", 11F);
            lblVentasTexto.Location = new Point(50, 50);
            lblVentasTexto.Name = "lblVentasTexto";
            lblVentasTexto.Size = new Size(182, 20);
            lblVentasTexto.TabIndex = 0;
            lblVentasTexto.Text = "Total Ventas (Bruto + IVA):";
            // 
            // btnEjecutarCierre
            // 
            btnEjecutarCierre.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEjecutarCierre.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEjecutarCierre.Location = new Point(30, 610);
            btnEjecutarCierre.Name = "btnEjecutarCierre";
            btnEjecutarCierre.Size = new Size(220, 45);
            btnEjecutarCierre.TabIndex = 3;
            btnEjecutarCierre.Text = "Ejecutar Cierre de Ejercicio";
            btnEjecutarCierre.UseVisualStyleBackColor = true;
            btnEjecutarCierre.Click += BtnEjecutarCierre_Click;
            // 
            // FrmCierreEjercicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 730);
            Controls.Add(btnEjecutarCierre);
            Controls.Add(groupResultados);
            Controls.Add(groupFiltro);
            Controls.Add(lblTitulo);
            Name = "FrmCierreEjercicio";
            Text = "SurTech - Cierre de Ejercicio";
            Load += FrmCierreEjercicio_Load;
            groupFiltro.ResumeLayout(false);
            groupFiltro.PerformLayout();
            groupResultados.ResumeLayout(false);
            groupResultados.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupFiltro;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnCalcularBalance;
        private System.Windows.Forms.GroupBox groupResultados;
        private System.Windows.Forms.Label lblVentasTexto;
        private System.Windows.Forms.Label lblVentasVal;
        private System.Windows.Forms.Label lblComprasTexto;
        private System.Windows.Forms.Label lblComprasVal;
        private System.Windows.Forms.Label lblIvaDebitoTexto;
        private System.Windows.Forms.Label lblIvaDebitoVal;
        private System.Windows.Forms.Label lblIvaCreditoTexto;
        private System.Windows.Forms.Label lblIvaCreditoVal;
        private System.Windows.Forms.Label lblSaldoIvaTexto;
        private System.Windows.Forms.Label lblSaldoIvaVal;
        private System.Windows.Forms.Button btnEjecutarCierre;
    }
}