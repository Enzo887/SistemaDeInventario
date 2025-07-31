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

namespace SistemaDeInventarios.Venta
{
    public partial class UC_RegistratVenta : UserControl
    {
        private BE.Venta ventaActual = new BE.Venta();
        private BLL.GestorVenta gestorVenta = new BLL.GestorVenta();
        private List<BE.Producto> productos = new List<BE.Producto>();

        public UC_RegistratVenta()
        {
            InitializeComponent();
            MostrarProductosDataGrid();
        }

        public void MostrarProductosDataGrid()
        {
            
            BLL.GestorProducto productoBLL = new BLL.GestorProducto();

            productos = productoBLL.ObtenerProductos();

            dgProductos.AutoGenerateColumns = false;
            dgProductos.Columns["idProducto"].DataPropertyName = "IDProducto";
            dgProductos.Columns["nombreProducto"].DataPropertyName = "NombreProducto";
            dgProductos.Columns["precio"].DataPropertyName = "Precio";
            dgProductos.DataSource = productos;
        }

        public void MostrarProductosAgregadosDataGrid()
        {
            dgVenta.AutoGenerateColumns = false;
            dgVenta.Columns["idProductoVenta"].DataPropertyName = "IDDetalleVenta";
            dgVenta.Columns["nombreProductoAgregado"].DataPropertyName = "NombreProducto";
            dgVenta.Columns["cantidadProductoAgregado"].DataPropertyName = "CantidadProducto";
            dgVenta.Columns["subtotal"].DataPropertyName = "Subtotal";
            dgVenta.DataSource = null;
            dgVenta.DataSource = new BindingList<BE.DetalleVenta>(ventaActual.DetallesVenta);
        }

        //Agrega un detalleVenta con su respectiva cantidad
        private void dgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgProductos.Columns[e.ColumnIndex].Name == "agregarProducto")
            {
                BE.Producto unProducto = new BE.Producto();
                unProducto.IDProducto = Convert.ToInt32(dgProductos.Rows[e.RowIndex].Cells["idProducto"].Value);
                unProducto.NombreProducto = dgProductos.Rows[e.RowIndex].Cells["nombreProducto"].Value.ToString();
                unProducto.Precio = Convert.ToDecimal(dgProductos.Rows[e.RowIndex].Cells["precio"].Value);

                gestorVenta.AgregarDetalle(ventaActual, unProducto, 1);               
                MostrarProductosAgregadosDataGrid();
                
                ventaActual.PrecioTotal = gestorVenta.CalcularTotal(ventaActual);
                tboxTotal.Text = ventaActual.PrecioTotal.ToString();

                ventaActual.FechaVenta = DateTime.Now;
            }
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            gestorVenta.RegistrarVenta(ventaActual);
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
                ventaActual = new BE.Venta();
                dgVenta.DataSource = null;
                tboxTotal.Clear();
            }   
        }

        //Reduce o elimina la cantidad de un detalleVenta
        private void dgVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgVenta.Columns[e.ColumnIndex].Name == "reducirCantidad")
            {
                BE.Producto unProducto = new BE.Producto();
                unProducto.IDProducto = Convert.ToInt32(dgVenta.Rows[e.RowIndex].Cells["idProductoVenta"].Value);
                
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
    }
}
