namespace SistemaDeInventarios.Estadisticas
{
    partial class UC_VerDetalleVenta
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
            this.dgDetalleVenta = new System.Windows.Forms.DataGridView();
            this.idDetalleVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxVenta = new System.Windows.Forms.TextBox();
            this.dtVenta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxMetodoPago = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDetalleVenta
            // 
            this.dgDetalleVenta.AllowUserToAddRows = false;
            this.dgDetalleVenta.AllowUserToDeleteRows = false;
            this.dgDetalleVenta.AllowUserToResizeColumns = false;
            this.dgDetalleVenta.AllowUserToResizeRows = false;
            this.dgDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDetalleVenta,
            this.nombreProducto,
            this.cantidadProducto,
            this.precioProducto,
            this.subtotalProducto});
            this.dgDetalleVenta.Location = new System.Drawing.Point(168, 71);
            this.dgDetalleVenta.MultiSelect = false;
            this.dgDetalleVenta.Name = "dgDetalleVenta";
            this.dgDetalleVenta.ReadOnly = true;
            this.dgDetalleVenta.RowHeadersVisible = false;
            this.dgDetalleVenta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgDetalleVenta.Size = new System.Drawing.Size(278, 258);
            this.dgDetalleVenta.TabIndex = 2;
            // 
            // idDetalleVenta
            // 
            this.idDetalleVenta.HeaderText = "ID";
            this.idDetalleVenta.Name = "idDetalleVenta";
            this.idDetalleVenta.ReadOnly = true;
            this.idDetalleVenta.Width = 25;
            // 
            // nombreProducto
            // 
            this.nombreProducto.HeaderText = "Producto";
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.ReadOnly = true;
            this.nombreProducto.Width = 65;
            // 
            // cantidadProducto
            // 
            this.cantidadProducto.HeaderText = "Cant";
            this.cantidadProducto.Name = "cantidadProducto";
            this.cantidadProducto.ReadOnly = true;
            this.cantidadProducto.Width = 40;
            // 
            // precioProducto
            // 
            this.precioProducto.HeaderText = "Precio";
            this.precioProducto.Name = "precioProducto";
            this.precioProducto.ReadOnly = true;
            this.precioProducto.Width = 65;
            // 
            // subtotalProducto
            // 
            this.subtotalProducto.HeaderText = "Subtotal";
            this.subtotalProducto.Name = "subtotalProducto";
            this.subtotalProducto.ReadOnly = true;
            this.subtotalProducto.Width = 80;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(25, 19);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 21;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "TOTAL:";
            // 
            // tboxTotal
            // 
            this.tboxTotal.Location = new System.Drawing.Point(168, 335);
            this.tboxTotal.Name = "tboxTotal";
            this.tboxTotal.ReadOnly = true;
            this.tboxTotal.Size = new System.Drawing.Size(278, 20);
            this.tboxTotal.TabIndex = 22;
            this.tboxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "N° venta";
            // 
            // tboxVenta
            // 
            this.tboxVenta.Location = new System.Drawing.Point(168, 33);
            this.tboxVenta.Name = "tboxVenta";
            this.tboxVenta.ReadOnly = true;
            this.tboxVenta.Size = new System.Drawing.Size(46, 20);
            this.tboxVenta.TabIndex = 24;
            // 
            // dtVenta
            // 
            this.dtVenta.Enabled = false;
            this.dtVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVenta.Location = new System.Drawing.Point(362, 33);
            this.dtVenta.Name = "dtVenta";
            this.dtVenta.Size = new System.Drawing.Size(84, 20);
            this.dtVenta.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Metodo de Pago";
            // 
            // tboxMetodoPago
            // 
            this.tboxMetodoPago.Location = new System.Drawing.Point(248, 33);
            this.tboxMetodoPago.Name = "tboxMetodoPago";
            this.tboxMetodoPago.ReadOnly = true;
            this.tboxMetodoPago.Size = new System.Drawing.Size(86, 20);
            this.tboxMetodoPago.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Fecha Venta";
            // 
            // UC_VerDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboxMetodoPago);
            this.Controls.Add(this.dtVenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxVenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxTotal);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgDetalleVenta);
            this.Name = "UC_VerDetalleVenta";
            this.Size = new System.Drawing.Size(645, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDetalleVenta;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxVenta;
        private System.Windows.Forms.DateTimePicker dtVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetalleVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxMetodoPago;
        private System.Windows.Forms.Label label4;
    }
}
