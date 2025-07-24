using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeInventarios.Stock
{
    public partial class UC_GestionarCategoria : UserControl
    {
        public event EventHandler CategoriaActualizada;
        private BE.Categoria unaCategoria = new BE.Categoria();
        public UC_GestionarCategoria()
        {
            InitializeComponent();
            MostrarCategoriasDataGrid();
        }
        private void MostrarCategoriasDataGrid()
        {
            List<BE.Categoria> categorias = new List<BE.Categoria>();
            BLL.GestorCategoria categoriaBLL = new BLL.GestorCategoria();

            categorias = categoriaBLL.ObtenerCategorias();

            dgCategoria.AutoGenerateColumns = false;
            dgCategoria.Columns["NombreCategoria"].DataPropertyName = "NombreCategoria";
            dgCategoria.Columns["idCategoria"].DataPropertyName = "IDCategoria";
            dgCategoria.DataSource = categorias;
        }
    
        private void dgCategoria_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgCategoria.ClearSelection();
            dgCategoria.CurrentCell = null;
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            string nombreCategoria = tboxNombreCategoria.Text;
            BLL.GestorCategoria categoriaBLL = new BLL.GestorCategoria();

            if (string.IsNullOrEmpty(nombreCategoria))
            {
                MessageBox.Show("No puede quedar vacio el nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            unaCategoria.NombreCategoria = nombreCategoria;

            if (categoriaBLL.ExisteCategoria(unaCategoria))
            {
                MessageBox.Show("Esta categoria ya existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Seccion de cuando se Edita
            if (btnAgregarCategoria.Text == "Aceptar")
            {
                try
                {                    
                    categoriaBLL.EditarCategoria(unaCategoria);
                    MostrarCategoriasDataGrid();
                    CategoriaActualizada?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show("Se editó la categoria correctamente!");                    
                }
                catch (Exception ex)
                {
                    throw new Exception("Hubo un error en editar la categoria", ex);
                }
                btnAgregarCategoria.Text = "Agregar";
                tboxNombreCategoria.Clear();
                return;
            }
            
            try
            {
                categoriaBLL.AgregarCategoria(unaCategoria);
                MostrarCategoriasDataGrid();
                CategoriaActualizada?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Se agregó la categoria exitosamente!");
                tboxNombreCategoria.Clear();
            }
            catch (Exception ex)
            {
                throw new Exception("Hubo un error al intentar agregar la nueva categoria", ex);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            var home = FindForm() as Home;
            if (home != null) 
            {
                home.MostrarAgregarProducto();
            }
            else
            {
                MessageBox.Show("No se encontro el form");
            }
        }

        private void dgCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //primero, que no sea ninguna celda del tipo encabezado. Luego que la columna a la que le pertenece es la correcta
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                unaCategoria.IDCategoria = Convert.ToInt32(dgCategoria.Rows[e.RowIndex].Cells["idCategoria"].Value);
                unaCategoria.NombreCategoria = dgCategoria.Rows[e.RowIndex].Cells["NombreCategoria"].Value.ToString();

                if (dgCategoria.Columns[e.ColumnIndex].Name == "btnEditarCategoria")
                {
                    tboxNombreCategoria.Text = unaCategoria.NombreCategoria;
                    btnAgregarCategoria.Text = "Aceptar";
                }
                else if (dgCategoria.Columns[e.ColumnIndex].Name == "btnEliminarCategoria")
                {
                    DialogResult resultadoMsj = MessageBox.Show("¿Seguro que desea eliminar la categoria?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (resultadoMsj == DialogResult.OK)
                    {
                        //unaCategoria.IDCategoria = Convert.ToInt32(dgCategoria.Rows[e.RowIndex].Cells["idCategoria"].Value);
                        BLL.GestorCategoria categoriaBLL = new BLL.GestorCategoria();
                        categoriaBLL.EliminarCategoria(unaCategoria);
                    }

                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tboxNombreCategoria.Clear();
            if (btnAgregarCategoria.Text == "Aceptar")
            {
                btnAgregarCategoria.Text = "Agregar";
            }
        }
    }
}
