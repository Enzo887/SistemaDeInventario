using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace SistemaDeInventarios.Venta
{
    public partial class UC_RegistrarVenta : UserControl
    {
        public event EventHandler VentaRealizada;

        private BE.Venta ventaActual = new BE.Venta();
        private BLL.GestorVenta gestorVenta = new BLL.GestorVenta();
        private List<BE.Producto> productos = new List<BE.Producto>();
        private BLL.GestorProducto productoBLL = new BLL.GestorProducto();

        public UC_RegistrarVenta()
        {
            InitializeComponent();
            MostrarProductosDataGrid();

            
            if (cBoxMetodoPago.Items.Count > 0)
            {
                cBoxMetodoPago.SelectedIndex = 0;
            }
        }

        public void MostrarProductosDataGrid()
        {
            //false -> No muestra productos DESHABILIDATOS
            productos = productoBLL.ObtenerProductos(false);
            
            dgProductos.AutoGenerateColumns = false;
            dgProductos.Columns["idProducto"].DataPropertyName = "IDProducto";
            dgProductos.Columns["nombreProducto"].DataPropertyName = "NombreProducto";
            dgProductos.Columns["precio"].DataPropertyName = "Precio";

            //Estas 2 columnas no estan visibles
            dgProductos.Columns["cantidadProducto"].DataPropertyName = "Cantidad";
            dgProductos.Columns["vencimientoProducto"].DataPropertyName = "FechaVencimiento";
            dgProductos.Columns["idCategoriaProducto"].DataPropertyName = "idCategoria";
            dgProductos.Columns["categoriaProducto"].DataPropertyName = "NombreCategoria";
            dgProductos.Columns["estadoProducto"].DataPropertyName = "Estado";
            dgProductos.DataSource = productos;
            AjustarDataGrid(dgProductos, 268);
        }

        public void MostrarProductosAgregadosDataGrid()
        {
            List<BE.Producto> productosBD = new List<BE.Producto>();
            //todos los productos
            productosBD = productoBLL.ObtenerProductos(true);

            gestorVenta.ActualizarDetalles(ventaActual, productosBD);
            ventaActual.PrecioTotal = gestorVenta.CalcularTotal(ventaActual);
            tboxTotal.Text = ventaActual.PrecioTotal.ToString();
            //gestorVenta.SacarDetalle2(ventaActual);
            dgVenta.AutoGenerateColumns = false;
            dgVenta.Columns["idProductoVenta"].DataPropertyName = "IDDetalleVenta";
            dgVenta.Columns["nombreProductoAgregado"].DataPropertyName = "NombreProducto";
            dgVenta.Columns["cantidadProductoAgregado"].DataPropertyName = "CantidadProducto";
            dgVenta.Columns["subtotal"].DataPropertyName = "Subtotal";
            dgVenta.DataSource = null;
            dgVenta.DataSource = new BindingList<BE.DetalleVenta>(ventaActual.DetallesVenta);
            AjustarDataGrid(dgVenta, 243);
        }


        private void dgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgProductos.Columns[e.ColumnIndex].Name == "agregarProducto")
            {
                BE.Producto unProducto = new BE.Producto();
                unProducto.IDProducto = Convert.ToInt32(dgProductos.Rows[e.RowIndex].Cells["idProducto"].Value);
                unProducto.NombreProducto = dgProductos.Rows[e.RowIndex].Cells["nombreProducto"].Value.ToString();
                unProducto.Precio = Convert.ToDecimal(dgProductos.Rows[e.RowIndex].Cells["precio"].Value);
                unProducto.Cantidad = Convert.ToInt32(dgProductos.Rows[e.RowIndex].Cells["cantidadProducto"].Value);
                unProducto.FechaVencimiento = (DateTime)dgProductos.Rows[e.RowIndex].Cells["vencimientoProducto"].Value;

                BE.Categoria categoria = new BE.Categoria();
                categoria.IDCategoria = Convert.ToInt32(dgProductos.Rows[e.RowIndex].Cells["idCategoriaProducto"].Value);
                categoria.NombreCategoria = dgProductos.Rows[e.RowIndex].Cells["categoriaProducto"].Value.ToString();

                unProducto.Categoria = categoria;

                string estadoProducto = dgProductos.Rows[e.RowIndex].Cells["estadoProducto"].Value.ToString();
                if(estadoProducto == "Habilitado")
                {
                    unProducto.Activo = true;
                }
                else
                {
                    unProducto.Activo = false;
                }
                //Agrega un nuevo detalleVenta o incrementa su cantidad
                bool excesoCantMax = gestorVenta.AgregarDetalle(ventaActual, unProducto);
                if (excesoCantMax)
                {
                    MessageBox.Show("No hay suficiente stock","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                MostrarProductosAgregadosDataGrid();
                
                ventaActual.PrecioTotal = gestorVenta.CalcularTotal(ventaActual);
                tboxTotal.Text = ventaActual.PrecioTotal.ToString();

                ventaActual.FechaVenta = DateTime.Now;
            }
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (cBoxMetodoPago.SelectedItem != null)
            {
                ventaActual.MetodoPago = cBoxMetodoPago.Text;
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un método de pago");
                return;
            }
            if (ventaActual.DetallesVenta.Count == 0) 
            {
                MessageBox.Show("No hay ningun producto añadido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            gestorVenta.RegistrarVenta(ventaActual);
            
            foreach (var detalle in ventaActual.DetallesVenta)
            {
               detalle.Producto.Cantidad -= detalle.CantidadProducto;
                productoBLL.EditarProducto(detalle.Producto);
            }
            VentaRealizada?.Invoke(this, EventArgs.Empty);

            MessageBox.Show("Se registró la venta correctamente!");
            ventaActual = new BE.Venta();
            dgVenta.DataSource = null;
            tboxTotal.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult mensajeResultado = MessageBox.Show("Seguro que desea cancelar la venta?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (mensajeResultado == DialogResult.OK) 
            {
                LimpiarVenta();
            }   
        }


        private void dgVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgVenta.Columns[e.ColumnIndex].Name == "reducirCantidad")
            {
                BE.Producto unProducto = new BE.Producto();
                unProducto.IDProducto = Convert.ToInt32(dgVenta.Rows[e.RowIndex].Cells["idProductoVenta"].Value);
                //Reduce o elimina la cantidad de un detalleVenta
                gestorVenta.SacarDetalle(ventaActual, unProducto);
                MostrarProductosAgregadosDataGrid();

                ventaActual.PrecioTotal = gestorVenta.CalcularTotal(ventaActual);
                tboxTotal.Text = ventaActual.PrecioTotal.ToString();
            }
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

        public void LimpiarVenta()
        {
            ventaActual = new BE.Venta();
            dgVenta.DataSource = null;
            tboxTotal.Clear();
        }

        public void AjustarDataGrid(DataGridView tabla, int anchoTabla)
        {
            int alturaFila = tabla.RowTemplate.Height;
            int totalFilas = tabla.Rows.Count;
            int alturaEncabezado = tabla.ColumnHeadersHeight;
            
            int alturaTabla = tabla.Height;

            int anchoScroll = 17;
            int alturaContenido = alturaEncabezado + (alturaFila * totalFilas);
            if(alturaContenido > alturaTabla)
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
