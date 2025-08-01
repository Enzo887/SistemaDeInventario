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
        private BE.Producto unProducto = new BE.Producto();
        private BLL.GestorProducto unProductoBLL = new BLL.GestorProducto();
        public UC_AgregarProducto()
        {
            InitializeComponent();
            MostrarCategoriasDataGrid();
            MostrarProductosDataGrid();
        }
        
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {   
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
            dgCategoria.ClearSelection();
        }

        private void btnGestionarCategoria_Click(object sender, EventArgs e)
        {
            var home = FindForm() as Home;
            if (home != null) {
                home.MostrarGestionarCategoria();
            }
            else
            {
                MessageBox.Show("No se encontro el form");
            }
            
        }

        public void MostrarCategoriasDataGrid()
        {
            List<BE.Categoria> categorias = new List<BE.Categoria>();
            BLL.GestorCategoria categoriaBLL = new BLL.GestorCategoria();

            categorias = categoriaBLL.ObtenerCategorias();
            
            dgCategoria.AutoGenerateColumns = false;
            dgCategoria.Columns["NombreCategoria"].DataPropertyName = "NombreCategoria";
            dgCategoria.Columns["idCategoria"].DataPropertyName = "IDCategoria";
            dgCategoria.DataSource = categorias;
        }

        public void MostrarProductosDataGrid()
        {
            List<BE.Producto> productos = new List<BE.Producto>();
            BLL.GestorProducto productoBLL = new BLL.GestorProducto();

            productos = productoBLL.ObtenerProductos();

            dgProductos.AutoGenerateColumns = false;
            dgProductos.Columns["idProducto"].DataPropertyName = "IDProducto";
            dgProductos.Columns["nombreProducto"].DataPropertyName = "NombreProducto";
            dgProductos.Columns["precioProducto"].DataPropertyName = "Precio";
            dgProductos.Columns["cantidadProducto"].DataPropertyName = "Cantidad";
            dgProductos.Columns["vencimientoProducto"].DataPropertyName = "FechaVencimiento";
            dgProductos.Columns["categoriaProducto"].DataPropertyName = "NombreCategoria";
            dgProductos.DataSource = productos;
        }

        private void dgCategoria_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgCategoria.ClearSelection();
            dgCategoria.CurrentCell = null;
        }
        
        private void numPrecio_ValueChanged(object sender, EventArgs e)
        {
            if (numPrecio.Value == numPrecio.Maximum) 
            {
                MessageBox.Show("Has alcanzado la cantidad máxima permitida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult mensajeResultado = MessageBox.Show("Seguro que desea cancelar la venta?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (mensajeResultado == DialogResult.OK)
            {
                unProducto = new BE.Producto();
                LimparInputsProductos();
            }
        }

        private void dgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0){
                BE.Producto productoSeleccionado = new Producto();

                productoSeleccionado.IDProducto = Convert.ToInt32(dgProductos.Rows[e.RowIndex].Cells["idProducto"].Value);

                if (dgProductos.Columns[e.ColumnIndex].Name == "editarProducto")
                {
                    productoSeleccionado.NombreProducto = dgProductos.Rows[e.RowIndex].Cells["nombreProducto"].Value.ToString();
                    productoSeleccionado.Cantidad = Convert.ToInt32(dgProductos.Rows[e.RowIndex].Cells["cantidadProducto"].Value);
                    productoSeleccionado.FechaVencimiento = (DateTime)dgProductos.Rows[e.RowIndex].Cells["vencimientoProducto"].Value;
                    productoSeleccionado.Precio = Convert.ToInt32(dgProductos.Rows[e.RowIndex].Cells["precioProducto"].Value);

                    tboxNombreProducto.Text = productoSeleccionado.NombreProducto;
                    numCantidad.Value = productoSeleccionado.Cantidad;
                    numPrecio.Value = productoSeleccionado.Precio;
                    dtVencimiento.Value = productoSeleccionado.FechaVencimiento;

                    string nombreCategoriaProducto = dgProductos.Rows[e.RowIndex].Cells["categoriaProducto"].Value.ToString();

                    foreach (DataGridViewRow fila in dgCategoria.Rows)
                    {
                        if (fila.Cells["NombreCategoria"].Value != null &&
                            fila.Cells["NombreCategoria"].Value.ToString() == nombreCategoriaProducto)
                        {
                            fila.Selected = true;
                            dgCategoria.CurrentCell = fila.Cells["NombreCategoria"];
                            break;
                        }
                    }
                }
                if(dgProductos.Columns[e.ColumnIndex].Name == "eliminarProducto")
                {
                    DialogResult resultadoMsj = MessageBox.Show("¿Seguro que desea eliminar el producto?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (resultadoMsj == DialogResult.OK)
                    {
                        unProductoBLL.EliminarProducto(productoSeleccionado);
                        MostrarProductosDataGrid();
                        TablaProductosActualizada?.Invoke(this, EventArgs.Empty);
                        MessageBox.Show("Producto eliminado exitosamente!");
                    }

                }
                
            }
        }
    }
}
