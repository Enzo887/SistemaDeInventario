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
    public partial class UC_VerVenta : UserControl
    {
        private List<BE.Venta> ventas = new List<BE.Venta>();
        public UC_VerVenta()
        {
            InitializeComponent();
            MostrarVentasDataGrid();
        }
        public void MostrarVentasDataGrid()
        {

            BLL.GestorVenta ventaBLL = new BLL.GestorVenta();

            //ventas = ventaBLL.ObtenerVentas();
            ventas = ventaBLL.ObtenerVentas();
            dgVentas.AutoGenerateColumns = false;
            dgVentas.Columns["idVenta"].DataPropertyName = "IDVenta";
            dgVentas.Columns["fechaVenta"].DataPropertyName = "FechaVenta";
            dgVentas.Columns["metodoPago"].DataPropertyName = "MetodoPago";
            dgVentas.Columns["montoTotal"].DataPropertyName = "PrecioTotal";
            dgVentas.DataSource = ventas;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarVentasDataGrid();
        }
    }
}
