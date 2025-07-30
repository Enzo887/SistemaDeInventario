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

        public UC_RegistratVenta()
        {
            InitializeComponent();
            MostrarProductosDataGrid();
        }

        public void MostrarProductosDataGrid()
        {
            List<BE.Producto> productos = new List<BE.Producto>();
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
    }
}
