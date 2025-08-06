namespace SistemaDeInventarios.Stock
{
    partial class UC_AgregarProducto
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
            this.tboxNombreProducto = new System.Windows.Forms.TextBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnGestionarCategoria = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.dtVencimiento = new System.Windows.Forms.DateTimePicker();
            this.dgCategoria = new System.Windows.Forms.DataGridView();
            this.idCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vencimientoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editarProducto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.eliminarProducto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.estadoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtIngreso = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.checkDeshabilitados = new System.Windows.Forms.CheckBox();
            this.checkRestaurar = new System.Windows.Forms.CheckBox();
            this.btnLimpiarProducto = new System.Windows.Forms.Button();
            this.lblBuscador = new System.Windows.Forms.Label();
            this.tboxBucarProducto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // tboxNombreProducto
            // 
            this.tboxNombreProducto.Location = new System.Drawing.Point(110, 235);
            this.tboxNombreProducto.Name = "tboxNombreProducto";
            this.tboxNombreProducto.Size = new System.Drawing.Size(122, 20);
            this.tboxNombreProducto.TabIndex = 0;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(107, 219);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(90, 13);
            this.lblNombreProducto.TabIndex = 1;
            this.lblNombreProducto.Text = "Nombre Producto";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(262, 219);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad";
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(265, 235);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(96, 20);
            this.numCantidad.TabIndex = 3;
            this.numCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numCantidad_KeyPress);
            // 
            // numPrecio
            // 
            this.numPrecio.DecimalPlaces = 2;
            this.numPrecio.Location = new System.Drawing.Point(265, 282);
            this.numPrecio.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPrecio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(96, 20);
            this.numPrecio.TabIndex = 4;
            this.numPrecio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPrecio.ValueChanged += new System.EventHandler(this.numPrecio_ValueChanged);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(262, 266);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(384, 218);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 7;
            this.lblCategoria.Text = "Categoria";
            // 
            // btnGestionarCategoria
            // 
            this.btnGestionarCategoria.Location = new System.Drawing.Point(445, 236);
            this.btnGestionarCategoria.Name = "btnGestionarCategoria";
            this.btnGestionarCategoria.Size = new System.Drawing.Size(65, 20);
            this.btnGestionarCategoria.TabIndex = 8;
            this.btnGestionarCategoria.Text = "Gestionar";
            this.btnGestionarCategoria.UseVisualStyleBackColor = true;
            this.btnGestionarCategoria.Click += new System.EventHandler(this.btnGestionarCategoria_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(206, 379);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(155, 23);
            this.btnAgregarProducto.TabIndex = 9;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(387, 379);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(107, 315);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(98, 13);
            this.lblFechaVencimiento.TabIndex = 12;
            this.lblFechaVencimiento.Text = "Fecha Vencimiento";
            // 
            // dtVencimiento
            // 
            this.dtVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVencimiento.Location = new System.Drawing.Point(110, 331);
            this.dtVencimiento.Name = "dtVencimiento";
            this.dtVencimiento.Size = new System.Drawing.Size(122, 20);
            this.dtVencimiento.TabIndex = 13;
            // 
            // dgCategoria
            // 
            this.dgCategoria.AllowUserToAddRows = false;
            this.dgCategoria.AllowUserToDeleteRows = false;
            this.dgCategoria.AllowUserToResizeColumns = false;
            this.dgCategoria.AllowUserToResizeRows = false;
            this.dgCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCategoria,
            this.nombreCategoria});
            this.dgCategoria.Location = new System.Drawing.Point(387, 235);
            this.dgCategoria.MultiSelect = false;
            this.dgCategoria.Name = "dgCategoria";
            this.dgCategoria.ReadOnly = true;
            this.dgCategoria.RowHeadersVisible = false;
            this.dgCategoria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCategoria.Size = new System.Drawing.Size(124, 118);
            this.dgCategoria.TabIndex = 14;
            this.dgCategoria.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgCategoria_DataBindingComplete);
            // 
            // idCategoria
            // 
            this.idCategoria.HeaderText = "idCategoria";
            this.idCategoria.Name = "idCategoria";
            this.idCategoria.ReadOnly = true;
            this.idCategoria.Visible = false;
            // 
            // nombreCategoria
            // 
            this.nombreCategoria.HeaderText = "Nombre";
            this.nombreCategoria.Name = "nombreCategoria";
            this.nombreCategoria.ReadOnly = true;
            this.nombreCategoria.Width = 120;
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
            this.precioProducto,
            this.cantidadProducto,
            this.vencimientoProducto,
            this.categoriaProducto,
            this.editarProducto,
            this.eliminarProducto,
            this.estadoProducto});
            this.dgProductos.Location = new System.Drawing.Point(39, 49);
            this.dgProductos.MultiSelect = false;
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.ReadOnly = true;
            this.dgProductos.RowHeadersVisible = false;
            this.dgProductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgProductos.ShowCellToolTips = false;
            this.dgProductos.Size = new System.Drawing.Size(527, 155);
            this.dgProductos.TabIndex = 15;
            this.dgProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductos_CellClick);
            this.dgProductos.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgProductos_RowPrePaint);
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "ID";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Width = 25;
            // 
            // nombreProducto
            // 
            this.nombreProducto.HeaderText = "Nombre";
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.ReadOnly = true;
            this.nombreProducto.Width = 75;
            // 
            // precioProducto
            // 
            this.precioProducto.HeaderText = "Precio";
            this.precioProducto.Name = "precioProducto";
            this.precioProducto.ReadOnly = true;
            this.precioProducto.Width = 65;
            // 
            // cantidadProducto
            // 
            this.cantidadProducto.HeaderText = "Cant";
            this.cantidadProducto.Name = "cantidadProducto";
            this.cantidadProducto.ReadOnly = true;
            this.cantidadProducto.Width = 35;
            // 
            // vencimientoProducto
            // 
            this.vencimientoProducto.HeaderText = "Vence";
            this.vencimientoProducto.Name = "vencimientoProducto";
            this.vencimientoProducto.ReadOnly = true;
            this.vencimientoProducto.Width = 70;
            // 
            // categoriaProducto
            // 
            this.categoriaProducto.HeaderText = "Categoria";
            this.categoriaProducto.Name = "categoriaProducto";
            this.categoriaProducto.ReadOnly = true;
            this.categoriaProducto.Width = 75;
            // 
            // editarProducto
            // 
            this.editarProducto.HeaderText = "";
            this.editarProducto.Name = "editarProducto";
            this.editarProducto.ReadOnly = true;
            this.editarProducto.Text = "Editar";
            this.editarProducto.UseColumnTextForButtonValue = true;
            this.editarProducto.Width = 50;
            // 
            // eliminarProducto
            // 
            this.eliminarProducto.HeaderText = "";
            this.eliminarProducto.Name = "eliminarProducto";
            this.eliminarProducto.ReadOnly = true;
            this.eliminarProducto.Text = "Eliminar";
            this.eliminarProducto.UseColumnTextForButtonValue = true;
            this.eliminarProducto.Width = 50;
            // 
            // estadoProducto
            // 
            this.estadoProducto.HeaderText = "Estado";
            this.estadoProducto.Name = "estadoProducto";
            this.estadoProducto.ReadOnly = true;
            this.estadoProducto.Width = 85;
            // 
            // dtIngreso
            // 
            this.dtIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtIngreso.Location = new System.Drawing.Point(110, 281);
            this.dtIngreso.Name = "dtIngreso";
            this.dtIngreso.Size = new System.Drawing.Size(122, 20);
            this.dtIngreso.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Fecha Ingreso";
            // 
            // checkDeshabilitados
            // 
            this.checkDeshabilitados.AutoSize = true;
            this.checkDeshabilitados.Location = new System.Drawing.Point(452, 26);
            this.checkDeshabilitados.Name = "checkDeshabilitados";
            this.checkDeshabilitados.Size = new System.Drawing.Size(114, 17);
            this.checkDeshabilitados.TabIndex = 19;
            this.checkDeshabilitados.Text = "Ver Deshabilitados";
            this.checkDeshabilitados.UseVisualStyleBackColor = true;
            this.checkDeshabilitados.CheckedChanged += new System.EventHandler(this.checkDeshabilitados_CheckedChanged);
            // 
            // checkRestaurar
            // 
            this.checkRestaurar.AutoSize = true;
            this.checkRestaurar.Location = new System.Drawing.Point(265, 331);
            this.checkRestaurar.Name = "checkRestaurar";
            this.checkRestaurar.Size = new System.Drawing.Size(72, 17);
            this.checkRestaurar.TabIndex = 20;
            this.checkRestaurar.Text = "Restaurar";
            this.checkRestaurar.UseVisualStyleBackColor = true;
            this.checkRestaurar.Visible = false;
            // 
            // btnLimpiarProducto
            // 
            this.btnLimpiarProducto.Location = new System.Drawing.Point(416, 26);
            this.btnLimpiarProducto.Name = "btnLimpiarProducto";
            this.btnLimpiarProducto.Size = new System.Drawing.Size(20, 20);
            this.btnLimpiarProducto.TabIndex = 23;
            this.btnLimpiarProducto.Text = "X";
            this.btnLimpiarProducto.UseVisualStyleBackColor = true;
            this.btnLimpiarProducto.Visible = false;
            this.btnLimpiarProducto.Click += new System.EventHandler(this.btnLimpiarProducto_Click);
            // 
            // lblBuscador
            // 
            this.lblBuscador.AutoSize = true;
            this.lblBuscador.Location = new System.Drawing.Point(36, 10);
            this.lblBuscador.Name = "lblBuscador";
            this.lblBuscador.Size = new System.Drawing.Size(86, 13);
            this.lblBuscador.TabIndex = 22;
            this.lblBuscador.Text = "Buscar Producto";
            // 
            // tboxBucarProducto
            // 
            this.tboxBucarProducto.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tboxBucarProducto.Location = new System.Drawing.Point(39, 26);
            this.tboxBucarProducto.Name = "tboxBucarProducto";
            this.tboxBucarProducto.Size = new System.Drawing.Size(397, 20);
            this.tboxBucarProducto.TabIndex = 21;
            this.tboxBucarProducto.Text = "Buscar por N° o Nombre";
            this.tboxBucarProducto.TextChanged += new System.EventHandler(this.tboxBucarProducto_TextChanged);
            this.tboxBucarProducto.Enter += new System.EventHandler(this.tboxBucarProducto_Enter);
            this.tboxBucarProducto.Leave += new System.EventHandler(this.tboxBucarProducto_Leave);
            // 
            // UC_AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLimpiarProducto);
            this.Controls.Add(this.lblBuscador);
            this.Controls.Add(this.tboxBucarProducto);
            this.Controls.Add(this.checkRestaurar);
            this.Controls.Add(this.checkDeshabilitados);
            this.Controls.Add(this.dtIngreso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGestionarCategoria);
            this.Controls.Add(this.dgProductos);
            this.Controls.Add(this.dgCategoria);
            this.Controls.Add(this.dtVencimiento);
            this.Controls.Add(this.lblFechaVencimiento);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.numPrecio);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.tboxNombreProducto);
            this.Name = "UC_AgregarProducto";
            this.Size = new System.Drawing.Size(645, 450);
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxNombreProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnGestionarCategoria;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.DateTimePicker dtVencimiento;
        private System.Windows.Forms.DataGridView dgCategoria;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCategoria;
        private System.Windows.Forms.DateTimePicker dtIngreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkDeshabilitados;
        private System.Windows.Forms.CheckBox checkRestaurar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencimientoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaProducto;
        private System.Windows.Forms.DataGridViewButtonColumn editarProducto;
        private System.Windows.Forms.DataGridViewButtonColumn eliminarProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoProducto;
        private System.Windows.Forms.Button btnLimpiarProducto;
        private System.Windows.Forms.Label lblBuscador;
        private System.Windows.Forms.TextBox tboxBucarProducto;
    }
}
