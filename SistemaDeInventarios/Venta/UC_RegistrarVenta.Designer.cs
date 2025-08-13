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
            this.tboxTotal = new System.Windows.Forms.TextBox();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiarProducto = new System.Windows.Forms.Button();
            this.cBoxMetodoPago = new System.Windows.Forms.ComboBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.idProductoVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProductoAgregado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadProductoAgregado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // tboxBucarProducto
            // 
            this.tboxBucarProducto.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tboxBucarProducto.Location = new System.Drawing.Point(48, 68);
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
            this.lblBuscador.Location = new System.Drawing.Point(45, 52);
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
            this.dgProductos.Location = new System.Drawing.Point(48, 94);
            this.dgProductos.MultiSelect = false;
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.ReadOnly = true;
            this.dgProductos.RowHeadersVisible = false;
            this.dgProductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgProductos.ShowCellToolTips = false;
            this.dgProductos.Size = new System.Drawing.Size(268, 265);
            this.dgProductos.TabIndex = 2;
            this.dgProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductos_CellClick);
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "Nº";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Width = 25;
            // 
            // nombreProducto
            // 
            this.nombreProducto.HeaderText = "Producto";
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.ReadOnly = true;
            this.nombreProducto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 80;
            // 
            // cantidadProducto
            // 
            this.cantidadProducto.HeaderText = "Cant";
            this.cantidadProducto.Name = "cantidadProducto";
            this.cantidadProducto.ReadOnly = true;
            this.cantidadProducto.Width = 40;
            // 
            // agregarProducto
            // 
            this.agregarProducto.HeaderText = "+";
            this.agregarProducto.Name = "agregarProducto";
            this.agregarProducto.ReadOnly = true;
            this.agregarProducto.Text = "+";
            this.agregarProducto.UseColumnTextForButtonValue = true;
            this.agregarProducto.Width = 20;
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
            this.lblVenta.Location = new System.Drawing.Point(341, 52);
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
            this.dgVenta.Location = new System.Drawing.Point(344, 94);
            this.dgVenta.MultiSelect = false;
            this.dgVenta.Name = "dgVenta";
            this.dgVenta.ReadOnly = true;
            this.dgVenta.RowHeadersVisible = false;
            this.dgVenta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVenta.ShowCellToolTips = false;
            this.dgVenta.Size = new System.Drawing.Size(243, 155);
            this.dgVenta.TabIndex = 4;
            this.dgVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVenta_CellClick);
            // 
            // tboxTotal
            // 
            this.tboxTotal.Location = new System.Drawing.Point(344, 253);
            this.tboxTotal.Name = "tboxTotal";
            this.tboxTotal.ReadOnly = true;
            this.tboxTotal.Size = new System.Drawing.Size(243, 20);
            this.tboxTotal.TabIndex = 7;
            this.tboxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Location = new System.Drawing.Point(418, 338);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(94, 23);
            this.btnRegistrarVenta.TabIndex = 8;
            this.btnRegistrarVenta.Text = "Registrar Venta";
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(518, 338);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(69, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "TOTAL:";
            // 
            // btnLimpiarProducto
            // 
            this.btnLimpiarProducto.Location = new System.Drawing.Point(296, 68);
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
            this.cBoxMetodoPago.Location = new System.Drawing.Point(344, 69);
            this.cBoxMetodoPago.Name = "cBoxMetodoPago";
            this.cBoxMetodoPago.Size = new System.Drawing.Size(100, 21);
            this.cBoxMetodoPago.TabIndex = 12;
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(450, 68);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(96, 20);
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
            this.lblCantidad.Location = new System.Drawing.Point(447, 52);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 13;
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.Visible = false;
            // 
            // idProductoVenta
            // 
            this.idProductoVenta.HeaderText = "id";
            this.idProductoVenta.Name = "idProductoVenta";
            this.idProductoVenta.ReadOnly = true;
            this.idProductoVenta.Width = 25;
            // 
            // nombreProductoAgregado
            // 
            this.nombreProductoAgregado.HeaderText = "Producto";
            this.nombreProductoAgregado.Name = "nombreProductoAgregado";
            this.nombreProductoAgregado.ReadOnly = true;
            this.nombreProductoAgregado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cantidadProductoAgregado
            // 
            this.cantidadProductoAgregado.HeaderText = "Cant";
            this.cantidadProductoAgregado.Name = "cantidadProductoAgregado";
            this.cantidadProductoAgregado.ReadOnly = true;
            this.cantidadProductoAgregado.Width = 40;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "SubTotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            this.subtotal.Width = 80;
            // 
            // UC_RegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.cBoxMetodoPago);
            this.Controls.Add(this.btnLimpiarProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.tboxTotal);
            this.Controls.Add(this.dgVenta);
            this.Controls.Add(this.lblVenta);
            this.Controls.Add(this.dgProductos);
            this.Controls.Add(this.lblBuscador);
            this.Controls.Add(this.tboxBucarProducto);
            this.Name = "UC_RegistrarVenta";
            this.Size = new System.Drawing.Size(645, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxBucarProducto;
        private System.Windows.Forms.Label lblBuscador;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.Label lblVenta;
        private System.Windows.Forms.DataGridView dgVenta;
        private System.Windows.Forms.TextBox tboxTotal;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiarProducto;
        private System.Windows.Forms.ComboBox cBoxMetodoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProducto;
        private System.Windows.Forms.DataGridViewButtonColumn agregarProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencimientoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoriaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoProducto;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoAgregado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProductoAgregado;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}
