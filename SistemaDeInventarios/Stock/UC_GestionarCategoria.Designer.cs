namespace SistemaDeInventarios.Stock
{
    partial class UC_GestionarCategoria
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
            this.lblCategoria = new System.Windows.Forms.Label();
            this.dgCategoria = new System.Windows.Forms.DataGridView();
            this.idCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.tboxNombreCategoria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(177, 56);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 15;
            this.lblCategoria.Text = "Categoria";
            // 
            // dgCategoria
            // 
            this.dgCategoria.AllowUserToAddRows = false;
            this.dgCategoria.AllowUserToDeleteRows = false;
            this.dgCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCategoria,
            this.Categoria});
            this.dgCategoria.Location = new System.Drawing.Point(180, 72);
            this.dgCategoria.Name = "dgCategoria";
            this.dgCategoria.ReadOnly = true;
            this.dgCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCategoria.Size = new System.Drawing.Size(145, 129);
            this.dgCategoria.TabIndex = 16;
            // 
            // idCategoria
            // 
            this.idCategoria.HeaderText = "idCategoria";
            this.idCategoria.Name = "idCategoria";
            this.idCategoria.ReadOnly = true;
            this.idCategoria.Visible = false;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Nombre";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(340, 220);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCategoria.TabIndex = 17;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            // 
            // tboxNombreCategoria
            // 
            this.tboxNombreCategoria.Location = new System.Drawing.Point(180, 220);
            this.tboxNombreCategoria.Name = "tboxNombreCategoria";
            this.tboxNombreCategoria.Size = new System.Drawing.Size(145, 20);
            this.tboxNombreCategoria.TabIndex = 18;
            this.tboxNombreCategoria.Text = "Nombre de la Categoria";
            // 
            // UC_GestionarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tboxNombreCategoria);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.dgCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Name = "UC_GestionarCategoria";
            this.Size = new System.Drawing.Size(645, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dgCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.DataGridView dgCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.TextBox tboxNombreCategoria;
    }
}
