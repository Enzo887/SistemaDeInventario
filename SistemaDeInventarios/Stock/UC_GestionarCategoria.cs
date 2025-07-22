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
            BE.Categoria nuevaCategoria = new BE.Categoria();
            BLL.GestorCategoria categoriaBLL = new BLL.GestorCategoria();

            if (string.IsNullOrEmpty(nombreCategoria))
            {
                MessageBox.Show("No puede quedar vacio el nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            nuevaCategoria.NombreCategoria = nombreCategoria;
            
            try
            {
                categoriaBLL.AgregarCategoria(nuevaCategoria);
                MostrarCategoriasDataGrid();

                CategoriaActualizada?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Se agregó la categoria exitosamente!");
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
    }
}
