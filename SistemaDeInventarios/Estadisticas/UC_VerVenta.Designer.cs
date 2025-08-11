namespace SistemaDeInventarios.Venta
{
    partial class UC_VerVenta
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
            this.dgVentas = new System.Windows.Forms.DataGridView();
            this.idVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verDetalleVenta = new System.Windows.Forms.DataGridViewButtonColumn();
            this.montoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVerDia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxTotal = new System.Windows.Forms.TextBox();
            this.dtFechaBuscada = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVentas
            // 
            this.dgVentas.AllowUserToAddRows = false;
            this.dgVentas.AllowUserToDeleteRows = false;
            this.dgVentas.AllowUserToResizeColumns = false;
            this.dgVentas.AllowUserToResizeRows = false;
            this.dgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVenta,
            this.idDetalle,
            this.fechaVenta,
            this.metodoPago,
            this.verDetalleVenta,
            this.montoTotal});
            this.dgVentas.Location = new System.Drawing.Point(131, 80);
            this.dgVentas.MultiSelect = false;
            this.dgVentas.Name = "dgVentas";
            this.dgVentas.ReadOnly = true;
            this.dgVentas.RowHeadersVisible = false;
            this.dgVentas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgVentas.ShowCellToolTips = false;
            this.dgVentas.Size = new System.Drawing.Size(348, 255);
            this.dgVentas.TabIndex = 0;
            this.dgVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVentas_CellContentClick);
            // 
            // idVenta
            // 
            this.idVenta.HeaderText = "ID";
            this.idVenta.Name = "idVenta";
            this.idVenta.ReadOnly = true;
            this.idVenta.Width = 25;
            // 
            // idDetalle
            // 
            this.idDetalle.HeaderText = "idDetalle";
            this.idDetalle.Name = "idDetalle";
            this.idDetalle.ReadOnly = true;
            this.idDetalle.Visible = false;
            // 
            // fechaVenta
            // 
            this.fechaVenta.HeaderText = "Fecha";
            this.fechaVenta.Name = "fechaVenta";
            this.fechaVenta.ReadOnly = true;
            this.fechaVenta.Width = 65;
            // 
            // metodoPago
            // 
            this.metodoPago.HeaderText = "Metodo de Pago";
            this.metodoPago.Name = "metodoPago";
            this.metodoPago.ReadOnly = true;
            // 
            // verDetalleVenta
            // 
            this.verDetalleVenta.HeaderText = "";
            this.verDetalleVenta.Name = "verDetalleVenta";
            this.verDetalleVenta.ReadOnly = true;
            this.verDetalleVenta.Text = "Ver Detalle";
            this.verDetalleVenta.UseColumnTextForButtonValue = true;
            this.verDetalleVenta.Width = 75;
            // 
            // montoTotal
            // 
            this.montoTotal.HeaderText = "Monto";
            this.montoTotal.Name = "montoTotal";
            this.montoTotal.ReadOnly = true;
            this.montoTotal.Width = 80;
            // 
            // btnVerDia
            // 
            this.btnVerDia.Location = new System.Drawing.Point(217, 47);
            this.btnVerDia.Name = "btnVerDia";
            this.btnVerDia.Size = new System.Drawing.Size(37, 23);
            this.btnVerDia.TabIndex = 2;
            this.btnVerDia.Text = "Hoy";
            this.btnVerDia.UseVisualStyleBackColor = true;
            this.btnVerDia.Click += new System.EventHandler(this.btnVerDia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "TOTAL del día:";
            // 
            // tboxTotal
            // 
            this.tboxTotal.Location = new System.Drawing.Point(131, 355);
            this.tboxTotal.Name = "tboxTotal";
            this.tboxTotal.ReadOnly = true;
            this.tboxTotal.Size = new System.Drawing.Size(323, 20);
            this.tboxTotal.TabIndex = 24;
            this.tboxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtFechaBuscada
            // 
            this.dtFechaBuscada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaBuscada.Location = new System.Drawing.Point(129, 50);
            this.dtFechaBuscada.Name = "dtFechaBuscada";
            this.dtFechaBuscada.Size = new System.Drawing.Size(82, 20);
            this.dtFechaBuscada.TabIndex = 29;
            this.dtFechaBuscada.ValueChanged += new System.EventHandler(this.dtFechaBuscada_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Buscar Fecha";
            // 
            // UC_VerVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtFechaBuscada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxTotal);
            this.Controls.Add(this.btnVerDia);
            this.Controls.Add(this.dgVentas);
            this.Name = "UC_VerVenta";
            this.Size = new System.Drawing.Size(645, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dgVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVentas;
        private System.Windows.Forms.Button btnVerDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxTotal;
        private System.Windows.Forms.DateTimePicker dtFechaBuscada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn metodoPago;
        private System.Windows.Forms.DataGridViewButtonColumn verDetalleVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoTotal;
    }
}
