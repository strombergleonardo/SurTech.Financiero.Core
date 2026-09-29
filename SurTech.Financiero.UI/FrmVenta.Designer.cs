namespace SurTech.Financiero.UI.Modulos
{
    partial class FrmVenta
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCuit = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.lblTipoComprobante = new System.Windows.Forms.Label();
            this.cmbTipoComprobante = new System.Windows.Forms.ComboBox();
            this.lblCondicionIva = new System.Windows.Forms.Label();
            this.cmbCondicionIvaCliente = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();

            this.grpDatosVenta = new System.Windows.Forms.GroupBox();

            this.lblArticulo = new System.Windows.Forms.Label();
            this.cmbArticulos = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();

            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.btnQuitarDetalle = new System.Windows.Forms.Button();

            this.lblNetoTexto = new System.Windows.Forms.Label();
            this.lblNetoVal = new System.Windows.Forms.Label();
            this.lblIvaTexto = new System.Windows.Forms.Label();
            this.lblIvaVal = new System.Windows.Forms.Label();
            this.lblTotalTexto = new System.Windows.Forms.Label();
            this.lblTotalVal = new System.Windows.Forms.Label();

            this.lblMoneda = new System.Windows.Forms.Label();
            this.cmbMoneda = new System.Windows.Forms.ComboBox();
            this.lblCotizacion = new System.Windows.Forms.Label();
            this.numCotizacionDolar = new System.Windows.Forms.NumericUpDown();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.cmbFormaPago = new System.Windows.Forms.ComboBox();

            this.btnGuardarVenta = new System.Windows.Forms.Button();

            // Controles del Visor de PDF incorporados
            this.btnVerPdfVenta = new System.Windows.Forms.Button();
            this.webBrowserPdfVenta = new System.Windows.Forms.WebBrowser();

            this.grpDatosVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCotizacionDolar)).BeginInit();
            this.SuspendLayout();

            // 
            // grpDatosVenta
            // 
            this.grpDatosVenta.Controls.Add(this.lblCliente);
            this.grpDatosVenta.Controls.Add(this.txtCliente);
            this.grpDatosVenta.Controls.Add(this.lblCuit);
            this.grpDatosVenta.Controls.Add(this.txtCuit);
            this.grpDatosVenta.Controls.Add(this.lblTipoComprobante);
            this.grpDatosVenta.Controls.Add(this.cmbTipoComprobante);
            this.grpDatosVenta.Controls.Add(this.lblCondicionIva);
            this.grpDatosVenta.Controls.Add(this.cmbCondicionIvaCliente);
            this.grpDatosVenta.Controls.Add(this.lblFecha);
            this.grpDatosVenta.Controls.Add(this.dtpFecha);
            this.grpDatosVenta.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpDatosVenta.Location = new System.Drawing.Point(25, 20);
            this.grpDatosVenta.Name = "grpDatosVenta";
            this.grpDatosVenta.Size = new System.Drawing.Size(850, 110);
            this.grpDatosVenta.TabIndex = 0;
            this.grpDatosVenta.TabStop = false;
            this.grpDatosVenta.Text = "Datos del Cliente y Comprobante";

            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCliente.Location = new System.Drawing.Point(15, 30);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(47, 15);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";

            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCliente.Location = new System.Drawing.Point(70, 27);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(220, 23);
            this.txtCliente.TabIndex = 1;

            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCuit.Location = new System.Drawing.Point(310, 30);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(65, 15);
            this.lblCuit.TabIndex = 2;
            this.lblCuit.Text = "CUIT / DNI:";

            // 
            // txtCuit
            // 
            this.txtCuit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCuit.Location = new System.Drawing.Point(385, 27);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(150, 23);
            this.txtCuit.TabIndex = 3;

            // 
            // lblTipoComprobante
            // 
            this.lblTipoComprobante.AutoSize = true;
            this.lblTipoComprobante.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTipoComprobante.Location = new System.Drawing.Point(555, 30);
            this.lblTipoComprobante.Name = "lblTipoComprobante";
            this.lblTipoComprobante.Size = new System.Drawing.Size(78, 15);
            this.lblTipoComprobante.TabIndex = 4;
            this.lblTipoComprobante.Text = "Comprobante:";

            // 
            // cmbTipoComprobante
            // 
            this.cmbTipoComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoComprobante.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbTipoComprobante.FormattingEnabled = true;
            this.cmbTipoComprobante.Items.AddRange(new object[] {
            "Factura A",
            "Factura B",
            "Factura C",
            "Ticket"});
            this.cmbTipoComprobante.Location = new System.Drawing.Point(645, 27);
            this.cmbTipoComprobante.Name = "cmbTipoComprobante";
            this.cmbTipoComprobante.Size = new System.Drawing.Size(180, 23);
            this.cmbTipoComprobante.TabIndex = 5;
            this.cmbTipoComprobante.SelectedIndex = 1;

            // 
            // lblCondicionIva
            // 
            this.lblCondicionIva.AutoSize = true;
            this.lblCondicionIva.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCondicionIva.Location = new System.Drawing.Point(15, 70);
            this.lblCondicionIva.Name = "lblCondicionIva";
            this.lblCondicionIva.Size = new System.Drawing.Size(86, 15);
            this.lblCondicionIva.TabIndex = 6;
            this.lblCondicionIva.Text = "Condición IVA:";

            // 
            // cmbCondicionIvaCliente
            // 
            this.cmbCondicionIvaCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondicionIvaCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbCondicionIvaCliente.FormattingEnabled = true;
            this.cmbCondicionIvaCliente.Items.AddRange(new object[] {
            "Responsable Inscripto",
            "Consumidor Final",
            "Monotributo",
            "Exento"});
            this.cmbCondicionIvaCliente.Location = new System.Drawing.Point(110, 67);
            this.cmbCondicionIvaCliente.Name = "cmbCondicionIvaCliente";
            this.cmbCondicionIvaCliente.Size = new System.Drawing.Size(180, 23);
            this.cmbCondicionIvaCliente.TabIndex = 7;
            this.cmbCondicionIvaCliente.SelectedIndexChanged += new System.EventHandler(this.CmbCondicionIvaCliente_SelectedIndexChanged);

            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFecha.Location = new System.Drawing.Point(310, 70);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(41, 15);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Fecha:";

            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(385, 67);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(150, 23);
            this.dtpFecha.TabIndex = 9;

            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblArticulo.Location = new System.Drawing.Point(25, 145);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(56, 15);
            this.lblArticulo.TabIndex = 1;
            this.lblArticulo.Text = "Artículo:";

            // 
            // cmbArticulos
            // 
            this.cmbArticulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArticulos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbArticulos.FormattingEnabled = true;
            this.cmbArticulos.Location = new System.Drawing.Point(90, 142);
            this.cmbArticulos.Name = "cmbArticulos";
            this.cmbArticulos.Size = new System.Drawing.Size(260, 23);
            this.cmbArticulos.TabIndex = 2;
            this.cmbArticulos.SelectedIndexChanged += new System.EventHandler(this.CmbArticulos_SelectedIndexChanged);

            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCantidad.Location = new System.Drawing.Point(365, 145);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(59, 15);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad:";

            // 
            // numCantidad
            // 
            this.numCantidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numCantidad.Location = new System.Drawing.Point(430, 142);
            this.numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(70, 23);
            this.numCantidad.TabIndex = 4;
            this.numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });

            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrecio.Location = new System.Drawing.Point(515, 145);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(45, 15);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio:";

            // 
            // numPrecio
            // 
            this.numPrecio.DecimalPlaces = 2;
            this.numPrecio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numPrecio.Location = new System.Drawing.Point(570, 142);
            this.numPrecio.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(110, 23);
            this.numPrecio.TabIndex = 6;

            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregarDetalle.Location = new System.Drawing.Point(695, 140);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(180, 28);
            this.btnAgregarDetalle.TabIndex = 7;
            this.btnAgregarDetalle.Text = "Agregar Ítem";
            this.btnAgregarDetalle.UseVisualStyleBackColor = true;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.BtnAgregarDetalle_Click);

            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Location = new System.Drawing.Point(25, 185);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalles.Size = new System.Drawing.Size(850, 180);
            this.dgvDetalles.TabIndex = 8;

            // 
            // btnQuitarDetalle
            // 
            this.btnQuitarDetalle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnQuitarDetalle.Location = new System.Drawing.Point(25, 375);
            this.btnQuitarDetalle.Name = "btnQuitarDetalle";
            this.btnQuitarDetalle.Size = new System.Drawing.Size(140, 28);
            this.btnQuitarDetalle.TabIndex = 9;
            this.btnQuitarDetalle.Text = "Quitar Seleccionado";
            this.btnQuitarDetalle.UseVisualStyleBackColor = true;
            this.btnQuitarDetalle.Click += new System.EventHandler(this.BtnQuitarDetalle_Click);

            // 
            // Totales e importes
            // 
            this.lblNetoTexto.AutoSize = true;
            this.lblNetoTexto.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNetoTexto.Location = new System.Drawing.Point(620, 380);
            this.lblNetoTexto.Name = "lblNetoTexto";
            this.lblNetoTexto.Size = new System.Drawing.Size(91, 17);
            this.lblNetoTexto.TabIndex = 10;
            this.lblNetoTexto.Text = "Neto Gravado:";

            this.lblNetoVal.AutoSize = true;
            this.lblNetoVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNetoVal.Location = new System.Drawing.Point(740, 380);
            this.lblNetoVal.Name = "lblNetoVal";
            this.lblNetoVal.Size = new System.Drawing.Size(43, 17);
            this.lblNetoVal.TabIndex = 11;
            this.lblNetoVal.Text = "$ 0.00";

            this.lblIvaTexto.AutoSize = true;
            this.lblIvaTexto.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblIvaTexto.Location = new System.Drawing.Point(540, 405);
            this.lblIvaTexto.Name = "lblIvaTexto";
            this.lblIvaTexto.Size = new System.Drawing.Size(171, 17);
            this.lblIvaTexto.TabIndex = 12;
            this.lblIvaTexto.Text = "IVA (21% Débito Fiscal):";

            this.lblIvaVal.AutoSize = true;
            this.lblIvaVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblIvaVal.Location = new System.Drawing.Point(740, 405);
            this.lblIvaVal.Name = "lblIvaVal";
            this.lblIvaVal.Size = new System.Drawing.Size(43, 17);
            this.lblIvaVal.TabIndex = 13;
            this.lblIvaVal.Text = "$ 0.00";

            this.lblTotalTexto.AutoSize = true;
            this.lblTotalTexto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalTexto.Location = new System.Drawing.Point(620, 435);
            this.lblTotalTexto.Name = "lblTotalTexto";
            this.lblTotalTexto.Size = new System.Drawing.Size(91, 20);
            this.lblTotalTexto.TabIndex = 14;
            this.lblTotalTexto.Text = "Total Final:";

            this.lblTotalVal.AutoSize = true;
            this.lblTotalVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.lblTotalVal.Location = new System.Drawing.Point(740, 435);
            this.lblTotalVal.Name = "lblTotalVal";
            this.lblTotalVal.Size = new System.Drawing.Size(51, 20);
            this.lblTotalVal.TabIndex = 15;
            this.lblTotalVal.Text = "$ 0.00";

            // 
            // Moneda, Cotización y Forma de Pago
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMoneda.Location = new System.Drawing.Point(25, 420);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(54, 15);
            this.lblMoneda.TabIndex = 16;
            this.lblMoneda.Text = "Moneda:";

            this.cmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoneda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbMoneda.FormattingEnabled = true;
            this.cmbMoneda.Items.AddRange(new object[] { "ARS", "USD" });
            this.cmbMoneda.Location = new System.Drawing.Point(90, 417);
            this.cmbMoneda.Name = "cmbMoneda";
            this.cmbMoneda.Size = new System.Drawing.Size(100, 23);
            this.cmbMoneda.TabIndex = 17;
            this.cmbMoneda.SelectedIndex = 0;

            this.lblCotizacion.AutoSize = true;
            this.lblCotizacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCotizacion.Location = new System.Drawing.Point(210, 420);
            this.lblCotizacion.Name = "lblCotizacion";
            this.lblCotizacion.Size = new System.Drawing.Size(83, 15);
            this.lblCotizacion.TabIndex = 18;
            this.lblCotizacion.Text = "Cotiz. Dólar:";

            this.numCotizacionDolar.DecimalPlaces = 2;
            this.numCotizacionDolar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numCotizacionDolar.Location = new System.Drawing.Point(305, 417);
            this.numCotizacionDolar.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numCotizacionDolar.Name = "numCotizacionDolar";
            this.numCotizacionDolar.Size = new System.Drawing.Size(90, 23);
            this.numCotizacionDolar.TabIndex = 19;
            this.numCotizacionDolar.Value = new decimal(new int[] { 1000, 0, 0, 0 });

            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFormaPago.Location = new System.Drawing.Point(25, 455);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(89, 15);
            this.lblFormaPago.TabIndex = 20;
            this.lblFormaPago.Text = "Forma de Pago:";

            this.cmbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaPago.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbFormaPago.FormattingEnabled = true;
            this.cmbFormaPago.Items.AddRange(new object[] { "Contado", "Cuenta Corriente", "Tarjeta", "Transferencia" });
            this.cmbFormaPago.Location = new System.Drawing.Point(125, 452);
            this.cmbFormaPago.Name = "cmbFormaPago";
            this.cmbFormaPago.Size = new System.Drawing.Size(150, 23);
            this.cmbFormaPago.TabIndex = 21;
            this.cmbFormaPago.SelectedIndex = 0;

            // 
            // btnGuardarVenta
            // 
            this.btnGuardarVenta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardarVenta.Location = new System.Drawing.Point(645, 480);
            this.btnGuardarVenta.Name = "btnGuardarVenta";
            this.btnGuardarVenta.Size = new System.Drawing.Size(230, 40);
            this.btnGuardarVenta.TabIndex = 22;
            this.btnGuardarVenta.Text = "Registrar Venta";
            this.btnGuardarVenta.UseVisualStyleBackColor = true;
            this.btnGuardarVenta.Click += new System.EventHandler(this.BtnGuardarVenta_Click);

            // 
            // btnVerPdfVenta
            // 
            this.btnVerPdfVenta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnVerPdfVenta.Location = new System.Drawing.Point(25, 535);
            this.btnVerPdfVenta.Name = "btnVerPdfVenta";
            this.btnVerPdfVenta.Size = new System.Drawing.Size(180, 35);
            this.btnVerPdfVenta.TabIndex = 23;
            this.btnVerPdfVenta.Text = "Cargar / Ver PDF Venta";
            this.btnVerPdfVenta.UseVisualStyleBackColor = true;
            this.btnVerPdfVenta.Click += new System.EventHandler(this.BtnVerPdfVenta_Click);

            // 
            // webBrowserPdfVenta
            // 
            this.webBrowserPdfVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowserPdfVenta.Location = new System.Drawing.Point(215, 535);
            this.webBrowserPdfVenta.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserPdfVenta.Name = "webBrowserPdfVenta";
            this.webBrowserPdfVenta.ScriptErrorsSuppressed = true;
            this.webBrowserPdfVenta.Size = new System.Drawing.Size(660, 180);
            this.webBrowserPdfVenta.TabIndex = 24;

            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 735);
            this.Controls.Add(this.webBrowserPdfVenta);
            this.Controls.Add(this.btnVerPdfVenta);
            this.Controls.Add(this.btnGuardarVenta);
            this.Controls.Add(this.cmbFormaPago);
            this.Controls.Add(this.lblFormaPago);
            this.Controls.Add(this.numCotizacionDolar);
            this.Controls.Add(this.lblCotizacion);
            this.Controls.Add(this.cmbMoneda);
            this.Controls.Add(this.lblMoneda);
            this.Controls.Add(this.lblTotalVal);
            this.Controls.Add(this.lblTotalTexto);
            this.Controls.Add(this.lblIvaVal);
            this.Controls.Add(this.lblIvaTexto);
            this.Controls.Add(this.lblNetoVal);
            this.Controls.Add(this.lblNetoTexto);
            this.Controls.Add(this.btnQuitarDetalle);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.btnAgregarDetalle);
            this.Controls.Add(this.numPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.cmbArticulos);
            this.Controls.Add(this.lblArticulo);
            this.Controls.Add(this.grpDatosVenta);
            this.Name = "FrmVenta";
            this.Text = "Módulo de Ventas";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            this.grpDatosVenta.ResumeLayout(false);
            this.grpDatosVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCotizacionDolar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosVenta;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lblTipoComprobante;
        private System.Windows.Forms.ComboBox cmbTipoComprobante;
        private System.Windows.Forms.Label lblCondicionIva;
        private System.Windows.Forms.ComboBox cmbCondicionIvaCliente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.ComboBox cmbArticulos;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Button btnQuitarDetalle;
        private System.Windows.Forms.Label lblNetoTexto;
        private System.Windows.Forms.Label lblNetoVal;
        private System.Windows.Forms.Label lblIvaTexto;
        private System.Windows.Forms.Label lblIvaVal;
        private System.Windows.Forms.Label lblTotalTexto;
        private System.Windows.Forms.Label lblTotalVal;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.ComboBox cmbMoneda;
        private System.Windows.Forms.Label lblCotizacion;
        private System.Windows.Forms.NumericUpDown numCotizacionDolar;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.ComboBox cmbFormaPago;
        private System.Windows.Forms.Button btnGuardarVenta;
        private System.Windows.Forms.Button btnVerPdfVenta;
        private System.Windows.Forms.WebBrowser webBrowserPdfVenta;
    }
}