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
            MessageBox.Show("fecha: " + unaVenta.FechaVenta + "pago: " + unaVenta.MetodoPago);
            MostrarDetalleVenta();
        }

        public void MostrarDetalleVenta()
        {
            List<BE.DetalleVenta> detalles = new List<DetalleVenta>();
            //detalles = unaVenta.DetallesVenta;
            detalles = ventaBLL.ObtenerVentaDelDetalle(unaVenta.IDVenta);


            dgDetalleVenta.Columns["idDetalleVenta"].DataPropertyName = "IdDetalleVenta";
            //dgDetalleVenta.Columns["nombreProducto"].DataPropertyName = "NombreProducto";
            dgDetalleVenta.Columns["cantidadProducto"].DataPropertyName = "CantidadProducto";
            dgDetalleVenta.Columns["subtotalProducto"].DataPropertyName = "PrecioSubtotal";
            dgDetalleVenta.DataSource = detalles;

            //tboxTotal.Text = (ventaBLL.CalcularTotalVentas(ventas)).ToString();
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
    }
}
