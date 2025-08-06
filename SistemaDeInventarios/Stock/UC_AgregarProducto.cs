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
        private List<BE.Producto> productos = new List<BE.Producto>();
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

            

            if (btnAgregarProducto.Text == "Editar Producto")
            {
                try
                {
                    if (checkRestaurar.Checked) 
                    {
                        unProducto.Activo = true;
                    }
                    unProductoBLL.EditarProducto(unProducto);
                    TablaProductosActualizada?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show("Se editó el producto correctamente!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error al editar el producto:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                LimparInputsProductos();
                btnAgregarProducto.Text = "Agregar Producto";
                return;
                
            }

            if (unProductoBLL.ExisteProducto(unProducto))
            {
                MessageBox.Show("Este nombre de Producto ya existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
            numCantidad.Value = 1;
            dtVencimiento.Value = DateTime.Today;
            dgCategoria.ClearSelection();
            checkRestaurar.Checked = false;
            checkRestaurar.Visible = false;

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
            
            BLL.GestorProducto productoBLL = new BLL.GestorProducto();
            bool incluirEliminados = checkDeshabilitados.Checked;

            productos = productoBLL.ObtenerProductos(incluirEliminados);

            dgProductos.AutoGenerateColumns = false;
            dgProductos.Columns["idProducto"].DataPropertyName = "IDProducto";
            dgProductos.Columns["nombreProducto"].DataPropertyName = "NombreProducto";
            dgProductos.Columns["precioProducto"].DataPropertyName = "Precio";
            dgProductos.Columns["cantidadProducto"].DataPropertyName = "Cantidad";
            dgProductos.Columns["vencimientoProducto"].DataPropertyName = "FechaVencimiento";
            dgProductos.Columns["categoriaProducto"].DataPropertyName = "NombreCategoria";
            dgProductos.Columns["estadoProducto"].DataPropertyName = "Estado";
            dgProductos.DataSource = productos;
            AjustarDataGrid(dgProductos,527);
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

                unProducto.IDProducto = Convert.ToInt32(dgProductos.Rows[e.RowIndex].Cells["idProducto"].Value);

                string estadoTexto = dgProductos.Rows[e.RowIndex].Cells["estadoProducto"].Value?.ToString();

                if (estadoTexto == "Habilitado")
                {
                    unProducto.Activo = true;
                }
                else
                {
                    unProducto.Activo = false;
                }

                if (dgProductos.Columns[e.ColumnIndex].Name == "editarProducto")
                {
                    unProducto.NombreProducto = dgProductos.Rows[e.RowIndex].Cells["nombreProducto"].Value.ToString();
                    unProducto.Cantidad = Convert.ToInt32(dgProductos.Rows[e.RowIndex].Cells["cantidadProducto"].Value);
                    unProducto.FechaVencimiento = (DateTime)dgProductos.Rows[e.RowIndex].Cells["vencimientoProducto"].Value;
                    unProducto.Precio = Convert.ToInt32(dgProductos.Rows[e.RowIndex].Cells["precioProducto"].Value);

                    btnAgregarProducto.Text = "Editar Producto";

                    tboxNombreProducto.Text = unProducto.NombreProducto;
                    numCantidad.Value = unProducto.Cantidad;
                    numPrecio.Value = unProducto.Precio;
                    dtVencimiento.Value = unProducto.FechaVencimiento;

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

                    if (!unProducto.Activo)
                    {
                        checkRestaurar.Visible = true;
                    }
                    
                }

                if(dgProductos.Columns[e.ColumnIndex].Name == "eliminarProducto")
                {
                    if (!unProducto.Activo)
                    {
                        MessageBox.Show("Este producto ya esta eliminada!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DialogResult resultadoMsj = MessageBox.Show("¿Seguro que desea eliminar el producto?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (resultadoMsj == DialogResult.OK)
                    {
                        unProductoBLL.EliminarProducto(unProducto);
                        MostrarProductosDataGrid();
                        TablaProductosActualizada?.Invoke(this, EventArgs.Empty);
                        MessageBox.Show("Producto eliminado exitosamente!");
                    }

                }
                
            }
        }

        //Le doy formato a los Productos Deshabilitados
        private void dgProductos_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var fila = dgProductos.Rows[e.RowIndex];
            var producto = fila.DataBoundItem as Producto;

            if (producto != null && !producto.Activo)
            {
                fila.DefaultCellStyle.ForeColor = Color.Gray;
            }
        }

        private void checkDeshabilitados_CheckedChanged(object sender, EventArgs e)
        {
            MostrarProductosDataGrid();
        }

        private void tboxBucarProducto_TextChanged(object sender, EventArgs e)
        {
            string filtro = tboxBucarProducto.Text.Trim().ToLower();

            // Mostrar u ocultar botón según el texto real
            btnLimpiarProducto.Visible = !string.IsNullOrWhiteSpace(tboxBucarProducto.Text) &&
                                          tboxBucarProducto.Text != "Buscar por N° o Nombre";

            var filtrados = productos
                .Where(p => p.NombreProducto.ToLower().Contains(filtro)
                            || p.IDProducto.ToString().Contains(filtro))
                .ToList();

            dgProductos.DataSource = null;
            dgProductos.DataSource = filtrados;

        }

        private void tboxBucarProducto_Enter(object sender, EventArgs e)
        {
            if (tboxBucarProducto.Text == "Buscar por N° o Nombre")
            {
                tboxBucarProducto.Text = "";
                tboxBucarProducto.ForeColor = Color.Black;
                btnLimpiarProducto.Visible = true;
            }
        }

        private void tboxBucarProducto_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tboxBucarProducto.Text))
            {
                tboxBucarProducto.Text = "Buscar por N° o Nombre";
                tboxBucarProducto.ForeColor = Color.Gray;
                btnLimpiarProducto.Visible = false;
                MostrarProductosDataGrid();
            }
        }

        private void btnLimpiarProducto_Click(object sender, EventArgs e)
        {
            tboxBucarProducto.Text = "Buscar por N° o Nombre";
            tboxBucarProducto.ForeColor = Color.Gray;
            MostrarProductosDataGrid();
            btnLimpiarProducto.Visible = false;
            dgProductos.Focus();
        }

        public void AjustarDataGrid(DataGridView tabla, int anchoTabla)
        {
            int alturaFila = tabla.RowTemplate.Height;
            int totalFilas = tabla.Rows.Count;
            int alturaEncabezado = tabla.ColumnHeadersHeight;

            int alturaTabla = tabla.Height;

            int anchoScroll = 17;
            int alturaContenido = alturaEncabezado + (alturaFila * totalFilas);
            if (alturaContenido > alturaTabla)
            {
                tabla.Width = anchoTabla + anchoScroll;
            }
            else
            {
                tabla.Width = anchoTabla;
            }
        }
    }
}
