using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;
using BE;

namespace SistemaDeInventarios.Stock
{
    public partial class UC_AgregarProducto : UserControl
    {
        public event EventHandler TablaProductosActualizada;
        public UC_AgregarProducto()
        {
            InitializeComponent();
            MostrarCategoriasDataGrid();
        }
        
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            BE.Producto unProducto = new BE.Producto();
            
            string nombreProducto = tboxNombreProducto.Text;
            decimal precio = numPrecio.Value;
            DateTime fechaVencimiento = dtVencimiento.Value;
            int cantidadProducto = (int)numCantidad.Value;

            //validaciones
            if (string.IsNullOrWhiteSpace(nombreProducto))
            {
                MessageBox.Show("El nombre no puede quedar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (nombreProducto.Length > 40) {
                MessageBox.Show("El nombre no puede ser tan largo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (precio <= 0) {
                MessageBox.Show("Ingrese un precio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(fechaVencimiento.Date <= DateTime.Today)
            {
                MessageBox.Show("Ingrese una fecha mayor a la de hoy", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(cantidadProducto <= 0)
            {
                MessageBox.Show("Ingrese una cantidad del producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgCategoria.Rows.Count == 0) 
            {
                MessageBox.Show("No hay ninguna categoria creada. Porfavor, cree una.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgCategoria.CurrentRow == null || dgCategoria.CurrentRow.Index < 0) 
            {
                MessageBox.Show("Debe seleccionar una categoria", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            unProducto.NombreProducto = nombreProducto;
            unProducto.Precio = precio;
            unProducto.FechaVencimiento = fechaVencimiento;
            unProducto.Cantidad = cantidadProducto;
            unProducto.Categoria = dgCategoria.CurrentRow?.DataBoundItem as Categoria;

            BLL.GestorProducto unProductoBLL = new BLL.GestorProducto();

            try
            {
                unProductoBLL.AgregarProductos(unProducto);
                TablaProductosActualizada?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Se agregó el producto correctamente!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al agregar el producto:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            {
                LimparInputsProductos();
            }
        }

        //No permite escribir una . o , en la cantidad
        private void numCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.Handled = true;
            }
        
        }

        private void LimparInputsProductos()
        {
            tboxNombreProducto.Clear();
            numPrecio.Value = numPrecio.Minimum;
            numCantidad.Value = numCantidad.Minimum;
            dtVencimiento.Value = DateTime.Today;
        }

        private void btnGestionarCategoria_Click(object sender, EventArgs e)
        {
            var home = FindForm() as Home;
            if (home != null) {
                home.MostrarGestionarCategoria(Gestionar_CategoriaActualizada);
            }
            else
            {
                MessageBox.Show("No se encontro el form");
            }
            
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

        private void UC_AgregarProducto_Load(object sender, EventArgs e)
        {
            MostrarCategoriasDataGrid();
        }
        
        //metodo que se suscribe
        private void Gestionar_CategoriaActualizada(object sender, EventArgs e)
        {
            MostrarCategoriasDataGrid();
        }
    }
}
