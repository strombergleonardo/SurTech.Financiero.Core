namespace SurTech.Financiero.UI
{
    partial class FrmCompra
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
            groupProveedor = new GroupBox();
            cmbFormaPago = new ComboBox();
            numCotizacionDolar = new NumericUpDown();
            cmbMoneda = new ComboBox();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            cmbTipoComprobante = new ComboBox();
            lblTipoComp = new Label();
            cmbCondicionIvaProveedor = new ComboBox();
            lblCondIva = new Label();
            txtCuit = new TextBox();
            lblCuit = new Label();
            txtProveedor = new TextBox();
            lblProv = new Label();
            groupDetalle = new GroupBox();
            dgvDetalles = new DataGridView();
            btnQuitarDetalle = new Button();
            btnAgregarDetalle = new Button();
            numPrecio = new NumericUpDown();
            lblPrecio = new Label();
            numCantidad = new NumericUpDown();
            lblCant = new Label();
            cmbArticulos = new ComboBox();
            lblArt = new Label();
            groupTotales = new GroupBox();
            lblTotalVal = new Label();
            lblTotalTexto = new Label();
            lblIvaVal = new Label();
            lblIvaTexto = new Label();
            lblNetoVal = new Label();
            lblNetoTexto = new Label();
            btnGuardarCompra = new Button();
            groupProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCotizacionDolar).BeginInit();
            groupDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            groupTotales.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(51, 51, 51);
            lblTitulo.Location = new Point(30, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(360, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Módulo de Compras - SurTech";
            // 
            // groupProveedor
            // 
            groupProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupProveedor.Controls.Add(cmbFormaPago);
            groupProveedor.Controls.Add(numCotizacionDolar);
            groupProveedor.Controls.Add(cmbMoneda);
            groupProveedor.Controls.Add(lblFecha);
            groupProveedor.Controls.Add(dtpFecha);
            groupProveedor.Controls.Add(cmbTipoComprobante);
            groupProveedor.Controls.Add(lblTipoComp);
            groupProveedor.Controls.Add(cmbCondicionIvaProveedor);
            groupProveedor.Controls.Add(lblCondIva);
            groupProveedor.Controls.Add(txtCuit);
            groupProveedor.Controls.Add(lblCuit);
            groupProveedor.Controls.Add(txtProveedor);
            groupProveedor.Controls.Add(lblProv);
            groupProveedor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupProveedor.Location = new Point(30, 70);
            groupProveedor.Name = "groupProveedor";
            groupProveedor.Size = new Size(1220, 110);
            groupProveedor.TabIndex = 1;
            groupProveedor.TabStop = false;
            groupProveedor.Text = "Datos del Proveedor y Comprobante";
            // 
            // cmbFormaPago
            // 
            cmbFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFormaPago.Font = new Font("Segoe UI", 9F);
            cmbFormaPago.FormattingEnabled = true;
            cmbFormaPago.Items.AddRange(new object[] { "Contado", "Cuenta Corriente", "Cheque", "Tarjeta" });
            cmbFormaPago.Location = new Point(415, 67);
            cmbFormaPago.Name = "cmbFormaPago";
            cmbFormaPago.Size = new Size(130, 23);
            cmbFormaPago.TabIndex = 12;
            // 
            // numCotizacionDolar
            // 
            numCotizacionDolar.DecimalPlaces = 2;
            numCotizacionDolar.Font = new Font("Segoe UI", 9F);
            numCotizacionDolar.Location = new Point(305, 67);
            numCotizacionDolar.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numCotizacionDolar.Name = "numCotizacionDolar";
            numCotizacionDolar.Size = new Size(90, 23);
            numCotizacionDolar.TabIndex = 11;
            numCotizacionDolar.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // cmbMoneda
            // 
            cmbMoneda.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMoneda.Font = new Font("Segoe UI", 9F);
            cmbMoneda.FormattingEnabled = true;
            cmbMoneda.Items.AddRange(new object[] { "ARS", "USD" });
            cmbMoneda.Location = new Point(220, 67);
            cmbMoneda.Name = "cmbMoneda";
            cmbMoneda.Size = new Size(70, 23);
            cmbMoneda.TabIndex = 10;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9F);
            lblFecha.Location = new Point(20, 70);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(41, 15);
            lblFecha.TabIndex = 8;
            lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 9F);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(90, 67);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(110, 23);
            dtpFecha.TabIndex = 9;
            // 
            // cmbTipoComprobante
            // 
            cmbTipoComprobante.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoComprobante.Font = new Font("Segoe UI", 9F);
            cmbTipoComprobante.FormattingEnabled = true;
            cmbTipoComprobante.Items.AddRange(new object[] { "Factura A", "Factura B", "Factura C" });
            cmbTipoComprobante.Location = new Point(885, 27);
            cmbTipoComprobante.Name = "cmbTipoComprobante";
            cmbTipoComprobante.Size = new Size(120, 23);
            cmbTipoComprobante.TabIndex = 7;
            // 
            // lblTipoComp
            // 
            lblTipoComp.AutoSize = true;
            lblTipoComp.Font = new Font("Segoe UI", 9F);
            lblTipoComp.Location = new Point(795, 30);
            lblTipoComp.Name = "lblTipoComp";
            lblTipoComp.Size = new Size(84, 15);
            lblTipoComp.TabIndex = 6;
            lblTipoComp.Text = "Comprobante:";
            // 
            // cmbCondicionIvaProveedor
            // 
            cmbCondicionIvaProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCondicionIvaProveedor.Font = new Font("Segoe UI", 9F);
            cmbCondicionIvaProveedor.FormattingEnabled = true;
            cmbCondicionIvaProveedor.Items.AddRange(new object[] { "Responsable Inscripto", "Monotributista" });
            cmbCondicionIvaProveedor.Location = new Point(615, 27);
            cmbCondicionIvaProveedor.Name = "cmbCondicionIvaProveedor";
            cmbCondicionIvaProveedor.Size = new Size(160, 23);
            cmbCondicionIvaProveedor.TabIndex = 5;
            cmbCondicionIvaProveedor.SelectedIndexChanged += CmbCondicionIvaProveedor_SelectedIndexChanged;
            // 
            // lblCondIva
            // 
            lblCondIva.AutoSize = true;
            lblCondIva.Font = new Font("Segoe UI", 9F);
            lblCondIva.Location = new Point(525, 30);
            lblCondIva.Name = "lblCondIva";
            lblCondIva.Size = new Size(85, 15);
            lblCondIva.TabIndex = 4;
            lblCondIva.Text = "Condición IVA:";
            // 
            // txtCuit
            // 
            txtCuit.Font = new Font("Segoe UI", 9F);
            txtCuit.Location = new Point(375, 27);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(130, 23);
            txtCuit.TabIndex = 3;
            // 
            // lblCuit
            // 
            lblCuit.AutoSize = true;
            lblCuit.Font = new Font("Segoe UI", 9F);
            lblCuit.Location = new Point(330, 30);
            lblCuit.Name = "lblCuit";
            lblCuit.Size = new Size(35, 15);
            lblCuit.TabIndex = 2;
            lblCuit.Text = "CUIT:";
            // 
            // txtProveedor
            // 
            txtProveedor.Font = new Font("Segoe UI", 9F);
            txtProveedor.Location = new Point(90, 27);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(220, 23);
            txtProveedor.TabIndex = 1;
            // 
            // lblProv
            // 
            lblProv.AutoSize = true;
            lblProv.Font = new Font("Segoe UI", 9F);
            lblProv.Location = new Point(20, 30);
            lblProv.Name = "lblProv";
            lblProv.Size = new Size(64, 15);
            lblProv.TabIndex = 0;
            lblProv.Text = "Proveedor:";
            // 
            // groupDetalle
            // 
            groupDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupDetalle.Controls.Add(dgvDetalles);
            groupDetalle.Controls.Add(btnQuitarDetalle);
            groupDetalle.Controls.Add(btnAgregarDetalle);
            groupDetalle.Controls.Add(numPrecio);
            groupDetalle.Controls.Add(lblPrecio);
            groupDetalle.Controls.Add(numCantidad);
            groupDetalle.Controls.Add(lblCant);
            groupDetalle.Controls.Add(cmbArticulos);
            groupDetalle.Controls.Add(lblArt);
            groupDetalle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupDetalle.Location = new Point(30, 195);
            groupDetalle.Name = "groupDetalle";
            groupDetalle.Size = new Size(1220, 390);
            groupDetalle.TabIndex = 2;
            groupDetalle.TabStop = false;
            groupDetalle.Text = "Detalle de Artículos Comprados";
            // 
            // dgvDetalles
            // 
            dgvDetalles.AllowUserToAddRows = false;
            dgvDetalles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.Location = new Point(20, 65);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalles.Size = new Size(1180, 310);
            dgvDetalles.TabIndex = 8;
            // 
            // btnQuitarDetalle
            // 
            btnQuitarDetalle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnQuitarDetalle.Location = new Point(845, 25);
            btnQuitarDetalle.Name = "btnQuitarDetalle";
            btnQuitarDetalle.Size = new Size(100, 26);
            btnQuitarDetalle.TabIndex = 7;
            btnQuitarDetalle.Text = "Quitar Ítem";
            btnQuitarDetalle.UseVisualStyleBackColor = true;
            btnQuitarDetalle.Click += BtnQuitarDetalle_Click;
            // 
            // btnAgregarDetalle
            // 
            btnAgregarDetalle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregarDetalle.Location = new Point(735, 25);
            btnAgregarDetalle.Name = "btnAgregarDetalle";
            btnAgregarDetalle.Size = new Size(100, 26);
            btnAgregarDetalle.TabIndex = 6;
            btnAgregarDetalle.Text = "Agregar";
            btnAgregarDetalle.UseVisualStyleBackColor = true;
            btnAgregarDetalle.Click += BtnAgregarDetalle_Click;
            // 
            // numPrecio
            // 
            numPrecio.DecimalPlaces = 2;
            numPrecio.Font = new Font("Segoe UI", 9F);
            numPrecio.Location = new Point(615, 27);
            numPrecio.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numPrecio.Name = "numPrecio";
            numPrecio.Size = new Size(100, 23);
            numPrecio.TabIndex = 5;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 9F);
            lblPrecio.Location = new Point(565, 30);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(43, 15);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio:";
            // 
            // numCantidad
            // 
            numCantidad.Font = new Font("Segoe UI", 9F);
            numCantidad.Location = new Point(465, 27);
            numCantidad.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(80, 23);
            numCantidad.TabIndex = 3;
            numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblCant
            // 
            lblCant.AutoSize = true;
            lblCant.Font = new Font("Segoe UI", 9F);
            lblCant.Location = new Point(400, 30);
            lblCant.Name = "lblCant";
            lblCant.Size = new Size(58, 15);
            lblCant.TabIndex = 2;
            lblCant.Text = "Cantidad:";
            // 
            // cmbArticulos
            // 
            cmbArticulos.Font = new Font("Segoe UI", 9F);
            cmbArticulos.FormattingEnabled = true;
            cmbArticulos.Location = new Point(80, 27);
            cmbArticulos.Name = "cmbArticulos";
            cmbArticulos.Size = new Size(300, 23);
            cmbArticulos.TabIndex = 1;
            cmbArticulos.SelectedIndexChanged += CmbArticulos_SelectedIndexChanged;
            // 
            // lblArt
            // 
            lblArt.AutoSize = true;
            lblArt.Font = new Font("Segoe UI", 9F);
            lblArt.Location = new Point(20, 30);
            lblArt.Name = "lblArt";
            lblArt.Size = new Size(52, 15);
            lblArt.TabIndex = 0;
            lblArt.Text = "Artículo:";
            // 
            // groupTotales
            // 
            groupTotales.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupTotales.Controls.Add(lblTotalVal);
            groupTotales.Controls.Add(lblTotalTexto);
            groupTotales.Controls.Add(lblIvaVal);
            groupTotales.Controls.Add(lblIvaTexto);
            groupTotales.Controls.Add(lblNetoVal);
            groupTotales.Controls.Add(lblNetoTexto);
            groupTotales.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupTotales.Location = new Point(830, 595);
            groupTotales.Name = "groupTotales";
            groupTotales.Size = new Size(420, 120);
            groupTotales.TabIndex = 3;
            groupTotales.TabStop = false;
            groupTotales.Text = "Resumen de Totales";
            // 
            // lblTotalVal
            // 
            lblTotalVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalVal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalVal.ForeColor = Color.FromArgb(255, 102, 0);
            lblTotalVal.Location = new Point(220, 83);
            lblTotalVal.Name = "lblTotalVal";
            lblTotalVal.Size = new Size(180, 22);
            lblTotalVal.TabIndex = 5;
            lblTotalVal.Text = "$ 0.00";
            lblTotalVal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalTexto
            // 
            lblTotalTexto.AutoSize = true;
            lblTotalTexto.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotalTexto.Location = new Point(20, 85);
            lblTotalTexto.Name = "lblTotalTexto";
            lblTotalTexto.Size = new Size(48, 20);
            lblTotalTexto.TabIndex = 4;
            lblTotalTexto.Text = "Total:";
            // 
            // lblIvaVal
            // 
            lblIvaVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblIvaVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblIvaVal.Location = new Point(250, 55);
            lblIvaVal.Name = "lblIvaVal";
            lblIvaVal.Size = new Size(150, 15);
            lblIvaVal.TabIndex = 3;
            lblIvaVal.Text = "$ 0.00";
            lblIvaVal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblIvaTexto
            // 
            lblIvaTexto.AutoSize = true;
            lblIvaTexto.Font = new Font("Segoe UI", 9F);
            lblIvaTexto.Location = new Point(20, 55);
            lblIvaTexto.Name = "lblIvaTexto";
            lblIvaTexto.Size = new Size(77, 15);
            lblIvaTexto.TabIndex = 2;
            lblIvaTexto.Text = "IVA (Crédito):";
            // 
            // lblNetoVal
            // 
            lblNetoVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNetoVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNetoVal.Location = new Point(250, 30);
            lblNetoVal.Name = "lblNetoVal";
            lblNetoVal.Size = new Size(150, 15);
            lblNetoVal.TabIndex = 1;
            lblNetoVal.Text = "$ 0.00";
            lblNetoVal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNetoTexto
            // 
            lblNetoTexto.AutoSize = true;
            lblNetoTexto.Font = new Font("Segoe UI", 9F);
            lblNetoTexto.Location = new Point(20, 30);
            lblNetoTexto.Name = "lblNetoTexto";
            lblNetoTexto.Size = new Size(83, 15);
            lblNetoTexto.TabIndex = 0;
            lblNetoTexto.Text = "Subtotal Neto:";
            // 
            // btnGuardarCompra
            // 
            btnGuardarCompra.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGuardarCompra.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGuardarCompra.Location = new Point(30, 620);
            btnGuardarCompra.Name = "btnGuardarCompra";
            btnGuardarCompra.Size = new Size(200, 45);
            btnGuardarCompra.TabIndex = 4;
            btnGuardarCompra.Text = "Guardar Compra";
            btnGuardarCompra.UseVisualStyleBackColor = true;
            btnGuardarCompra.Click += BtnGuardarCompra_Click;
            // 
            // FrmCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 730);
            Controls.Add(btnGuardarCompra);
            Controls.Add(groupTotales);
            Controls.Add(groupDetalle);
            Controls.Add(groupProveedor);
            Controls.Add(lblTitulo);
            Name = "FrmCompra";
            Text = "SurTech - Registro de Compras a Proveedores";
            Load += FrmCompra_Load;
            groupProveedor.ResumeLayout(false);
            groupProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCotizacionDolar).EndInit();
            groupDetalle.ResumeLayout(false);
            groupDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            groupTotales.ResumeLayout(false);
            groupTotales.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupProveedor;
        private System.Windows.Forms.Label lblProv;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lblCondIva;
        private System.Windows.Forms.ComboBox cmbCondicionIvaProveedor;
        private System.Windows.Forms.Label lblTipoComp;
        private System.Windows.Forms.ComboBox cmbTipoComprobante;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cmbMoneda;
        private System.Windows.Forms.NumericUpDown numCotizacionDolar;
        private System.Windows.Forms.ComboBox cmbFormaPago;
        private System.Windows.Forms.GroupBox groupDetalle;
        private System.Windows.Forms.Label lblArt;
        private System.Windows.Forms.ComboBox cmbArticulos;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private System.Windows.Forms.Button btnQuitarDetalle;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.GroupBox groupTotales;
        private System.Windows.Forms.Label lblNetoTexto;
        private System.Windows.Forms.Label lblNetoVal;
        private System.Windows.Forms.Label lblIvaTexto;
        private System.Windows.Forms.Label lblIvaVal;
        private System.Windows.Forms.Label lblTotalTexto;
        private System.Windows.Forms.Label lblTotalVal;
        private System.Windows.Forms.Button btnGuardarCompra;
    }
}