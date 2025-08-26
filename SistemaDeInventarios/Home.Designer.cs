namespace SistemaDeInventarios
{
    partial class Home
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLateral = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tablePrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tableLateral.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tablePrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLateral
            // 
            this.tableLateral.ColumnCount = 1;
            this.tableLateral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLateral.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLateral.Controls.Add(this.btnCerrar, 0, 2);
            this.tableLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLateral.Location = new System.Drawing.Point(3, 3);
            this.tableLateral.Name = "tableLateral";
            this.tableLateral.RowCount = 3;
            this.tableLateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.tableLateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLateral.Size = new System.Drawing.Size(164, 444);
            this.tableLateral.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnVenta);
            this.flowLayoutPanel1.Controls.Add(this.btnAgregarProducto);
            this.flowLayoutPanel1.Controls.Add(this.btnEstadisticas);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 101);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(158, 240);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // btnVenta
            // 
            this.btnVenta.Location = new System.Drawing.Point(3, 3);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(155, 55);
            this.btnVenta.TabIndex = 3;
            this.btnVenta.Text = "Registrar Venta";
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(3, 64);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(155, 55);
            this.btnAgregarProducto.TabIndex = 1;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Location = new System.Drawing.Point(3, 125);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(155, 55);
            this.btnEstadisticas.TabIndex = 2;
            this.btnEstadisticas.Text = "Ver Ventas";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(3, 347);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(155, 58);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Salir del programa";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // tablePrincipal
            // 
            this.tablePrincipal.ColumnCount = 2;
            this.tablePrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tablePrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePrincipal.Controls.Add(this.tableLateral, 0, 0);
            this.tablePrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePrincipal.Location = new System.Drawing.Point(0, 0);
            this.tablePrincipal.Name = "tablePrincipal";
            this.tablePrincipal.RowCount = 1;
            this.tablePrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePrincipal.Size = new System.Drawing.Size(800, 450);
            this.tablePrincipal.TabIndex = 6;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tablePrincipal);
            this.Name = "Home";
            this.Text = "Sistema de inventario";
            this.tableLateral.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tablePrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLateral;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TableLayoutPanel tablePrincipal;
    }
}

