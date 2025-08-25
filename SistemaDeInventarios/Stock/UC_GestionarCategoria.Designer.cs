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
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.tboxNombreCategoria = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.idCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditarCategoria = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEliminarCategoria = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategoria)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(3, 7);
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
            this.dgCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCategoria.Location = new System.Drawing.Point(3, 86);
            this.dgCategoria.MultiSelect = false;
            this.dgCategoria.Name = "dgCategoria";
            this.dgCategoria.ReadOnly = true;
            this.dgCategoria.RowHeadersVisible = false;
            this.dgCategoria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgCategoria.Size = new System.Drawing.Size(356, 162);
            this.dgCategoria.TabIndex = 16;
            this.dgCategoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCategoria_CellClick);
            this.dgCategoria.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgCategoria_DataBindingComplete);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(3, 3);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(172, 23);
            this.btnAgregarCategoria.TabIndex = 17;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // tboxNombreCategoria
            // 
            this.tboxNombreCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxNombreCategoria.Location = new System.Drawing.Point(3, 23);
            this.tboxNombreCategoria.Name = "tboxNombreCategoria";
            this.tboxNombreCategoria.Size = new System.Drawing.Size(356, 20);
            this.tboxNombreCategoria.TabIndex = 18;
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolver.Location = new System.Drawing.Point(60, 70);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.Location = new System.Drawing.Point(181, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(172, 23);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.42857F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.14286F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.42857F));
            this.tableLayoutPanel1.Controls.Add(this.btnVolver, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.42857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.14286F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.42857F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(645, 450);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dgCategoria, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblCategoria, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tboxNombreCategoria, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(141, 99);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(362, 251);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnCancelar, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnAgregarCategoria, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 51);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(356, 29);
            this.tableLayoutPanel3.TabIndex = 19;
            // 
            // idCategoria
            // 
            this.idCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idCategoria.FillWeight = 25F;
            this.idCategoria.HeaderText = "Nº";
            this.idCategoria.MinimumWidth = 25;
            this.idCategoria.Name = "idCategoria";
            this.idCategoria.ReadOnly = true;
            // 
            // NombreCategoria
            // 
            this.NombreCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreCategoria.HeaderText = "Nombre";
            this.NombreCategoria.MinimumWidth = 100;
            this.NombreCategoria.Name = "NombreCategoria";
            this.NombreCategoria.ReadOnly = true;
            // 
            // btnEditarCategoria
            // 
            this.btnEditarCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btnEditarCategoria.HeaderText = "";
            this.btnEditarCategoria.MinimumWidth = 50;
            this.btnEditarCategoria.Name = "btnEditarCategoria";
            this.btnEditarCategoria.ReadOnly = true;
            this.btnEditarCategoria.Text = "Editar";
            this.btnEditarCategoria.UseColumnTextForButtonValue = true;
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btnEliminarCategoria.HeaderText = "";
            this.btnEliminarCategoria.MinimumWidth = 50;
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.ReadOnly = true;
            this.btnEliminarCategoria.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseColumnTextForButtonValue = true;
            // 
            // UC_GestionarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_GestionarCategoria";
            this.Size = new System.Drawing.Size(645, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dgCategoria)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.DataGridView dgCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.TextBox tboxNombreCategoria;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCategoria;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditarCategoria;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminarCategoria;
    }
}
