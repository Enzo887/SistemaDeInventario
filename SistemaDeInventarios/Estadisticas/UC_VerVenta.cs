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
        private BLL.GestorVenta ventaBLL = new BLL.GestorVenta();
        private DateTime fechaBuscada = DateTime.Today;
        public UC_VerVenta()
        {
            InitializeComponent();
            MostrarVentasDataGrid();
            fechaBuscada = DateTime.Today;
        }
        public void MostrarVentasDataGrid()
        {
            ventas = ventaBLL.ObtenerVentasDia(fechaBuscada);            
            dgVentas.AutoGenerateColumns = false;
            dgVentas.Columns["idVenta"].DataPropertyName = "IDVenta";
            dgVentas.Columns["fechaVenta"].DataPropertyName = "FechaVenta";
            dgVentas.Columns["metodoPago"].DataPropertyName = "MetodoPago";
            dgVentas.Columns["montoTotal"].DataPropertyName = "PrecioTotal";
            dgVentas.DataSource = ventas;
            
            tboxTotal.Text = (ventaBLL.CalcularTotalVentas(ventas)).ToString();
        }

        private void btnVerDia_Click(object sender, EventArgs e)
        {
            fechaBuscada = DateTime.Today;
            MostrarVentasDataGrid();
        }

        private void btnBuscarFecha_Click(object sender, EventArgs e)
        {
            fechaBuscada = dtFechaBuscada.Value;
            MostrarVentasDataGrid();
            if (ventas.Count <= 0)
            {
                MessageBox.Show("No se encontraron coincidencias con la fecha", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgVentas.Columns[e.ColumnIndex].Name == "verDetalleVenta")
            {
                BE.Venta unaVenta = new BE.Venta();
                unaVenta.IDVenta = Convert.ToInt32(dgVentas.Rows[e.RowIndex].Cells["idVenta"].Value);
                unaVenta.FechaVenta = ((DateTime)dgVentas.Rows[e.RowIndex].Cells["fechaVenta"].Value).Date;
                unaVenta.MetodoPago = dgVentas.Rows[e.RowIndex].Cells["metodoPago"].Value.ToString();
                unaVenta.PrecioTotal = Convert.ToDecimal(dgVentas.Rows[e.RowIndex].Cells["montoTotal"].Value);


                var home = FindForm() as Home;
                if (home != null)
                {
                    home.MostrarVerDetalleVenta(unaVenta);
                }
                else
                {
                    MessageBox.Show("No se encontro el form");
                }
            }
        }
    }
}
