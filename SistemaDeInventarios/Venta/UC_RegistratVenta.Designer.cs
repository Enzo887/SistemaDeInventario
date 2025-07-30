namespace SistemaDeInventarios.Venta
{
    partial class UC_RegistratVenta
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
            this.agregarProducto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblVenta = new System.Windows.Forms.Label();
            this.dgVenta = new System.Windows.Forms.DataGridView();
            this.tboxCantidad = new System.Windows.Forms.TextBox();
            this.tboxTotal = new System.Windows.Forms.TextBox();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reducirCantidad = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idProductoVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProductoAgregado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadProductoAgregado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // tboxBucarProducto
            // 
            this.tboxBucarProducto.Location = new System.Drawing.Point(61, 68);
            this.tboxBucarProducto.Name = "tboxBucarProducto";
            this.tboxBucarProducto.Size = new System.Drawing.Size(228, 20);
            this.tboxBucarProducto.TabIndex = 0;
            // 
            // lblBuscador
            // 
            this.lblBuscador.AutoSize = true;
            this.lblBuscador.Location = new System.Drawing.Point(58, 52);
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
            this.agregarProducto});
            this.dgProductos.Location = new System.Drawing.Point(61, 94);
            this.dgProductos.MultiSelect = false;
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.ReadOnly = true;
            this.dgProductos.RowHeadersVisible = false;
            this.dgProductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgProductos.Size = new System.Drawing.Size(228, 267);
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
            // agregarProducto
            // 
            this.agregarProducto.HeaderText = "+";
            this.agregarProducto.Name = "agregarProducto";
            this.agregarProducto.ReadOnly = true;
            this.agregarProducto.Text = "+";
            this.agregarProducto.UseColumnTextForButtonValue = true;
            this.agregarProducto.Width = 20;
            // 
            // lblVenta
            // 
            this.lblVenta.AutoSize = true;
            this.lblVenta.Location = new System.Drawing.Point(341, 52);
            this.lblVenta.Name = "lblVenta";
            this.lblVenta.Size = new System.Drawing.Size(91, 13);
            this.lblVenta.TabIndex = 3;
            this.lblVenta.Text = "Registro de venta";
            // 
            // dgVenta
            // 
            this.dgVenta.AllowUserToAddRows = false;
            this.dgVenta.AllowUserToDeleteRows = false;
            this.dgVenta.AllowUserToResizeColumns = false;
            this.dgVenta.AllowUserToResizeRows = false;
            this.dgVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reducirCantidad,
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
            this.dgVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgVenta.Size = new System.Drawing.Size(243, 143);
            this.dgVenta.TabIndex = 4;
            this.dgVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVenta_CellClick);
            // 
            // tboxCantidad
            // 
            this.tboxCantidad.Location = new System.Drawing.Point(344, 68);
            this.tboxCantidad.Name = "tboxCantidad";
            this.tboxCantidad.Size = new System.Drawing.Size(43, 20);
            this.tboxCantidad.TabIndex = 5;
            // 
            // tboxTotal
            // 
            this.tboxTotal.Location = new System.Drawing.Point(344, 243);
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
            this.label1.Location = new System.Drawing.Point(351, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "TOTAL:";
            // 
            // reducirCantidad
            // 
            this.reducirCantidad.HeaderText = "-";
            this.reducirCantidad.Name = "reducirCantidad";
            this.reducirCantidad.ReadOnly = true;
            this.reducirCantidad.Text = "-";
            this.reducirCantidad.UseColumnTextForButtonValue = true;
            this.reducirCantidad.Width = 20;
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
            // UC_RegistratVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.tboxTotal);
            this.Controls.Add(this.tboxCantidad);
            this.Controls.Add(this.dgVenta);
            this.Controls.Add(this.lblVenta);
            this.Controls.Add(this.dgProductos);
            this.Controls.Add(this.lblBuscador);
            this.Controls.Add(this.tboxBucarProducto);
            this.Name = "UC_RegistratVenta";
            this.Size = new System.Drawing.Size(645, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxBucarProducto;
        private System.Windows.Forms.Label lblBuscador;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.Label lblVenta;
        private System.Windows.Forms.DataGridView dgVenta;
        private System.Windows.Forms.TextBox tboxCantidad;
        private System.Windows.Forms.TextBox tboxTotal;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewButtonColumn agregarProducto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn reducirCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoAgregado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProductoAgregado;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}
