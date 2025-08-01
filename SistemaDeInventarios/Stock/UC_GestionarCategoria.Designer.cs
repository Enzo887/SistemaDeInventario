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
            this.NombreCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditarCategoria = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEliminarCategoria = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.tboxNombreCategoria = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(166, 52);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 15;
            this.lblCategoria.Text = "Categoria";
            // 
            // dgCategoria
            // 
            this.dgCategoria.AllowUserToAddRows = false;
            this.dgCategoria.AllowUserToDeleteRows = false;
            this.dgCategoria.AllowUserToResizeRows = false;
            this.dgCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCategoria,
            this.NombreCategoria,
            this.btnEditarCategoria,
            this.btnEliminarCategoria});
            this.dgCategoria.Location = new System.Drawing.Point(169, 123);
            this.dgCategoria.MultiSelect = false;
            this.dgCategoria.Name = "dgCategoria";
            this.dgCategoria.ReadOnly = true;
            this.dgCategoria.RowHeadersVisible = false;
            this.dgCategoria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgCategoria.Size = new System.Drawing.Size(229, 248);
            this.dgCategoria.TabIndex = 16;
            this.dgCategoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCategoria_CellClick);
            this.dgCategoria.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgCategoria_DataBindingComplete);
            // 
            // idCategoria
            // 
            this.idCategoria.HeaderText = "Nº";
            this.idCategoria.Name = "idCategoria";
            this.idCategoria.ReadOnly = true;
            this.idCategoria.Width = 25;
            // 
            // NombreCategoria
            // 
            this.NombreCategoria.HeaderText = "Nombre";
            this.NombreCategoria.Name = "NombreCategoria";
            this.NombreCategoria.ReadOnly = true;
            // 
            // btnEditarCategoria
            // 
            this.btnEditarCategoria.HeaderText = "";
            this.btnEditarCategoria.Name = "btnEditarCategoria";
            this.btnEditarCategoria.ReadOnly = true;
            this.btnEditarCategoria.Text = "Editar";
            this.btnEditarCategoria.UseColumnTextForButtonValue = true;
            this.btnEditarCategoria.Width = 50;
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.HeaderText = "";
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.ReadOnly = true;
            this.btnEliminarCategoria.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseColumnTextForButtonValue = true;
            this.btnEliminarCategoria.Width = 50;
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(169, 94);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(113, 23);
            this.btnAgregarCategoria.TabIndex = 17;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // tboxNombreCategoria
            // 
            this.tboxNombreCategoria.Location = new System.Drawing.Point(169, 68);
            this.tboxNombreCategoria.Name = "tboxNombreCategoria";
            this.tboxNombreCategoria.Size = new System.Drawing.Size(229, 20);
            this.tboxNombreCategoria.TabIndex = 18;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(15, 22);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(288, 94);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 23);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // UC_GestionarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnVolver);
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
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.TextBox tboxNombreCategoria;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCategoria;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditarCategoria;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminarCategoria;
    }
}
