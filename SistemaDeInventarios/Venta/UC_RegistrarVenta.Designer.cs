namespace SistemaDeInventarios.Venta
{
    partial class UC_RegistrarVenta
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tboxBucarProducto = new System.Windows.Forms.TextBox();
            this.lblBuscador = new System.Windows.Forms.Label();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agregarProducto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.vencimientoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategoriaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblVenta = new System.Windows.Forms.Label();
            this.dgVenta = new System.Windows.Forms.DataGridView();
            this.idProductoVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProductoAgregado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadProductoAgregado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiarProducto = new System.Windows.Forms.Button();
            this.cBoxMetodoPago = new System.Windows.Forms.ComboBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnSacarDetalle = new System.Windows.Forms.Button();
            this.checkSinStock = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxTotal = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tboxBucarProducto
            // 
            this.tboxBucarProducto.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tboxBucarProducto.Location = new System.Drawing.Point(3, 19);
            this.tboxBucarProducto.Name = "tboxBucarProducto";
            this.tboxBucarProducto.Size = new System.Drawing.Size(268, 20);
            this.tboxBucarProducto.TabIndex = 0;
            this.tboxBucarProducto.Text = "Buscar por N° o Nombre";
            this.tboxBucarProducto.TextChanged += new System.EventHandler(this.tboxBucarProducto_TextChanged);
            this.tboxBucarProducto.Enter += new System.EventHandler(this.tboxBucarProducto_Enter);
            this.tboxBucarProducto.Leave += new System.EventHandler(this.tboxBucarProducto_Leave);
            // 
            // lblBuscador
            // 
            this.lblBuscador.AutoSize = true;
            this.lblBuscador.Location = new System.Drawing.Point(0, 3);
            this.lblBuscador.Name = "lblBuscador";
            this.lblBuscador.Size = new System.Drawing.Size(86, 13);
            this.lblBuscador.TabIndex = 1;
            this.lblBuscador.Text = "Buscar Producto";
            // 
            // dgProductos
            // 
            this.dgProductos.AllowUserToAddRows = false;
            this.dgProductos.AllowUserToDeleteRows = false;
            this.dgProductos.AllowUserToResizeColumns = false;
            this.dgProductos.AllowUserToResizeRows = false;
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.nombreProducto,
            this.precio,
            this.cantidadProducto,
            this.agregarProducto,
            this.vencimientoProducto,
            this.idCategoriaProducto,
            this.categoriaProducto,
            this.estadoProducto});
            this.dgProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProductos.Location = new System.Drawing.Point(3, 53);
            this.dgProductos.MultiSelect = false;
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.ReadOnly = true;
            this.dgProductos.RowHeadersVisible = false;
            this.dgProductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProductos.ShowCellToolTips = false;
            this.dgProductos.Size = new System.Drawing.Size(281, 137);
            this.dgProductos.TabIndex = 2;
            this.dgProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductos_CellClick);
            this.dgProductos.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgProductos_RowPrePaint);
            // 
            // idProducto
            // 
            this.idProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idProducto.HeaderText = "Nº";
            this.idProducto.MinimumWidth = 25;
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            // 
            // nombreProducto
            // 
            this.nombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreProducto.HeaderText = "Producto";
            this.nombreProducto.MinimumWidth = 100;
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.ReadOnly = true;
            this.nombreProducto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // precio
            // 
            this.precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.precio.HeaderText = "Precio";
            this.precio.MinimumWidth = 80;
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // cantidadProducto
            // 
            this.cantidadProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cantidadProducto.HeaderText = "Cant";
            this.cantidadProducto.MinimumWidth = 40;
            this.cantidadProducto.Name = "cantidadProducto";
            this.cantidadProducto.ReadOnly = true;
            // 
            // agregarProducto
            // 
            this.agregarProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.agregarProducto.HeaderText = "+";
            this.agregarProducto.MinimumWidth = 20;
            this.agregarProducto.Name = "agregarProducto";
            this.agregarProducto.ReadOnly = true;
            this.agregarProducto.Text = "+";
            this.agregarProducto.UseColumnTextForButtonValue = true;
            // 
            // vencimientoProducto
            // 
            this.vencimientoProducto.HeaderText = "vencimientoProducto";
            this.vencimientoProducto.Name = "vencimientoProducto";
            this.vencimientoProducto.ReadOnly = true;
            this.vencimientoProducto.Visible = false;
            // 
            // idCategoriaProducto
            // 
            this.idCategoriaProducto.HeaderText = "idCategoriaProducto";
            this.idCategoriaProducto.Name = "idCategoriaProducto";
            this.idCategoriaProducto.ReadOnly = true;
            this.idCategoriaProducto.Visible = false;
            // 
            // categoriaProducto
            // 
            this.categoriaProducto.HeaderText = "categoriaProducto";
            this.categoriaProducto.Name = "categoriaProducto";
            this.categoriaProducto.ReadOnly = true;
            this.categoriaProducto.Visible = false;
            // 
            // estadoProducto
            // 
            this.estadoProducto.HeaderText = "estadoProducto";
            this.estadoProducto.Name = "estadoProducto";
            this.estadoProducto.ReadOnly = true;
            this.estadoProducto.Visible = false;
            // 
            // lblVenta
            // 
            this.lblVenta.AutoSize = true;
            this.lblVenta.Location = new System.Drawing.Point(3, 2);
            this.lblVenta.Name = "lblVenta";
            this.lblVenta.Size = new System.Drawing.Size(86, 13);
            this.lblVenta.TabIndex = 3;
            this.lblVenta.Text = "Metodo de Pago";
            // 
            // dgVenta
            // 
            this.dgVenta.AllowUserToAddRows = false;
            this.dgVenta.AllowUserToDeleteRows = false;
            this.dgVenta.AllowUserToResizeColumns = false;
            this.dgVenta.AllowUserToResizeRows = false;
            this.dgVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductoVenta,
            this.nombreProductoAgregado,
            this.cantidadProductoAgregado,
            this.subtotal});
            this.dgVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgVenta.Location = new System.Drawing.Point(3, 53);
            this.dgVenta.MultiSelect = false;
            this.dgVenta.Name = "dgVenta";
            this.dgVenta.ReadOnly = true;
            this.dgVenta.RowHeadersVisible = false;
            this.dgVenta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVenta.ShowCellToolTips = false;
            this.dgVenta.Size = new System.Drawing.Size(281, 137);
            this.dgVenta.TabIndex = 4;
            this.dgVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVenta_CellClick);
            // 
            // idProductoVenta
            // 
            this.idProductoVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idProductoVenta.HeaderText = "id";
            this.idProductoVenta.MinimumWidth = 25;
            this.idProductoVenta.Name = "idProductoVenta";
            this.idProductoVenta.ReadOnly = true;
            // 
            // nombreProductoAgregado
            // 
            this.nombreProductoAgregado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreProductoAgregado.HeaderText = "Producto";
            this.nombreProductoAgregado.MinimumWidth = 100;
            this.nombreProductoAgregado.Name = "nombreProductoAgregado";
            this.nombreProductoAgregado.ReadOnly = true;
            this.nombreProductoAgregado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cantidadProductoAgregado
            // 
            this.cantidadProductoAgregado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cantidadProductoAgregado.HeaderText = "Cant";
            this.cantidadProductoAgregado.MinimumWidth = 40;
            this.cantidadProductoAgregado.Name = "cantidadProductoAgregado";
            this.cantidadProductoAgregado.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subtotal.HeaderText = "SubTotal";
            this.subtotal.MinimumWidth = 80;
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Location = new System.Drawing.Point(3, 3);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(94, 23);
            this.btnRegistrarVenta.TabIndex = 8;
            this.btnRegistrarVenta.Text = "Registrar Venta";
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(103, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(69, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiarProducto
            // 
            this.btnLimpiarProducto.Location = new System.Drawing.Point(251, 19);
            this.btnLimpiarProducto.Name = "btnLimpiarProducto";
            this.btnLimpiarProducto.Size = new System.Drawing.Size(20, 20);
            this.btnLimpiarProducto.TabIndex = 11;
            this.btnLimpiarProducto.Text = "X";
            this.btnLimpiarProducto.UseVisualStyleBackColor = true;
            this.btnLimpiarProducto.Visible = false;
            this.btnLimpiarProducto.Click += new System.EventHandler(this.btnLimpiarProducto_Click);
            // 
            // cBoxMetodoPago
            // 
            this.cBoxMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxMetodoPago.FormattingEnabled = true;
            this.cBoxMetodoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Transferencia"});
            this.cBoxMetodoPago.Location = new System.Drawing.Point(6, 19);
            this.cBoxMetodoPago.Name = "cBoxMetodoPago";
            this.cBoxMetodoPago.Size = new System.Drawing.Size(100, 21);
            this.cBoxMetodoPago.TabIndex = 12;
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(112, 18);
            this.numCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(62, 20);
            this.numCantidad.TabIndex = 14;
            this.numCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidad.Visible = false;
            this.numCantidad.ValueChanged += new System.EventHandler(this.numCantidad_ValueChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(109, 2);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 13;
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.Visible = false;
            // 
            // btnSacarDetalle
            // 
            this.btnSacarDetalle.Location = new System.Drawing.Point(193, 16);
            this.btnSacarDetalle.Name = "btnSacarDetalle";
            this.btnSacarDetalle.Size = new System.Drawing.Size(56, 20);
            this.btnSacarDetalle.TabIndex = 15;
            this.btnSacarDetalle.Text = "Eliminar";
            this.btnSacarDetalle.UseVisualStyleBackColor = true;
            this.btnSacarDetalle.Visible = false;
            this.btnSacarDetalle.Click += new System.EventHandler(this.btnSacarDetalle_Click);
            // 
            // checkSinStock
            // 
            this.checkSinStock.AutoSize = true;
            this.checkSinStock.Location = new System.Drawing.Point(3, 196);
            this.checkSinStock.Name = "checkSinStock";
            this.checkSinStock.Size = new System.Drawing.Size(137, 17);
            this.checkSinStock.TabIndex = 16;
            this.checkSinStock.Text = "Ver productos sin stock";
            this.checkSinStock.UseVisualStyleBackColor = true;
            this.checkSinStock.CheckedChanged += new System.EventHandler(this.checkSinStock_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.55F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.13F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(645, 450);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.checkSinStock, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgProductos, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(32, 98);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(287, 228);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tboxBucarProducto);
            this.panel1.Controls.Add(this.lblBuscador);
            this.panel1.Controls.Add(this.btnLimpiarProducto);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 39);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.dgVenta, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(325, 98);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(287, 228);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSacarDetalle);
            this.panel2.Controls.Add(this.cBoxMetodoPago);
            this.panel2.Controls.Add(this.numCantidad);
            this.panel2.Controls.Add(this.lblVenta);
            this.panel2.Controls.Add(this.lblCantidad);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 43);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tboxTotal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 196);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(281, 29);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "TOTAL:";
            // 
            // tboxTotal
            // 
            this.tboxTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxTotal.Location = new System.Drawing.Point(0, 0);
            this.tboxTotal.Name = "tboxTotal";
            this.tboxTotal.ReadOnly = true;
            this.tboxTotal.Size = new System.Drawing.Size(281, 20);
            this.tboxTotal.TabIndex = 7;
            this.tboxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.btnRegistrarVenta);
            this.flowLayoutPanel1.Controls.Add(this.btnCancelar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(435, 332);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(177, 64);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // UC_RegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_RegistrarVenta";
            this.Size = new System.Drawing.Size(645, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tboxBucarProducto;
        private System.Windows.Forms.Label lblBuscador;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.Label lblVenta;
        private System.Windows.Forms.DataGridView dgVenta;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiarProducto;
        private System.Windows.Forms.ComboBox cBoxMetodoPago;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnSacarDetalle;
        private System.Windows.Forms.CheckBox checkSinStock;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProducto;
        private System.Windows.Forms.DataGridViewButtonColumn agregarProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencimientoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoriaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoProducto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoAgregado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProductoAgregado;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxTotal;
    }
}
