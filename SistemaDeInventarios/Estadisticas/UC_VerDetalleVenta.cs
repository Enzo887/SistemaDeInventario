using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeInventarios.Estadisticas
{
    public partial class UC_VerDetalleVenta : UserControl
    {
        private BE.Venta unaVenta;
        private BLL.GestorVenta ventaBLL = new BLL.GestorVenta();
        public UC_VerDetalleVenta(BE.Venta ventaSeleccionada)
        {
            InitializeComponent();
            unaVenta = ventaSeleccionada;
            tboxVenta.Text = unaVenta.IDVenta.ToString();
            tboxTotal.Text = unaVenta.PrecioTotal.ToString();
            tboxMetodoPago.Text = unaVenta.MetodoPago.ToString();
            dtVenta.Value = unaVenta.FechaVenta;
            MostrarDetalleVenta();
        }

        public void MostrarDetalleVenta()
        {
            List<BE.DetalleVenta> detalles = new List<DetalleVenta>();
            detalles = ventaBLL.ObtenerVentaDelDetalle(unaVenta.IDVenta);

            dgDetalleVenta.AutoGenerateColumns = false;
            dgDetalleVenta.Columns["idDetalleVenta"].DataPropertyName = "IdDetalleVenta";
            dgDetalleVenta.Columns["nombreProducto"].DataPropertyName = "NombreProducto";
            dgDetalleVenta.Columns["cantidadProducto"].DataPropertyName = "CantidadProducto"; 
            dgDetalleVenta.Columns["precioProducto"].DataPropertyName = "PrecioProducto";
            dgDetalleVenta.Columns["subtotalProducto"].DataPropertyName = "Subtotal";
            dgDetalleVenta.DataSource = detalles;
            AjustarDataGrid(dgDetalleVenta, 278);

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            var home = FindForm() as Home;
            if (home != null)
            {
                home.MostratEstadisticasVenta();
            }
            else
            {
                MessageBox.Show("No se encontro el form");
            }
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
