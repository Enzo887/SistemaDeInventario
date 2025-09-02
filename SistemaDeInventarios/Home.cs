using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaDeInventarios.Estadisticas;
using SistemaDeInventarios.Stock;
using SistemaDeInventarios.Venta;

namespace SistemaDeInventarios
{
    public partial class Home : Form
    {
        private UC_AgregarProducto AgregarProducto;
        private UC_GestionarCategoria GestionarCategoria;
        private UC_RegistrarVenta RegistrarVenta;
        private UC_VerVenta VerVenta;
        private UC_VerDetalleVenta VerDetalleVenta;
        public Home()
        {
            InitializeComponent();
            AgregarProducto = new UC_AgregarProducto();
            GestionarCategoria = new UC_GestionarCategoria();
            RegistrarVenta = new UC_RegistrarVenta();
            VerVenta = new UC_VerVenta();

            btnVenta.Select();
            
            CargarUserControl(RegistrarVenta);

            AgregarProducto.TablaProductosActualizada += MostrarProductosEnVenta;

            AgregarProducto.TablaProductosActualizada += MostrarProductosEnStock;

            AgregarProducto.TablaProductosActualizada += LimpiarVenta;

            GestionarCategoria.CategoriaActualizada += MostrarProductosEnStock;

            GestionarCategoria.CategoriaActualizada += MostrarCategoriasDataGrid;

            RegistrarVenta.VentaRealizada += MostrarVentasDataGrid;

            RegistrarVenta.VentaRealizada += MostrarProductosEnStock;
            RegistrarVenta.VentaRealizada += MostrarProductosEnVenta;


        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            MostrarAgregarProducto();
        }

        private void CargarUserControl(UserControl control)
        {
            var existe = tablePrincipal.GetControlFromPosition(1, 0);
            if (existe != null)
            {
                tablePrincipal.Controls.Remove(existe);
            }
            control.Dock = DockStyle.Fill;             // Ocupa todo el panel
            tablePrincipal.Controls.Add(control, 1, 0);      // Agrega el nuevo
        }

        public void MostrarGestionarCategoria()
        {
            CargarUserControl(GestionarCategoria);
        }

        public void MostrarAgregarProducto()
        {
            CargarUserControl(AgregarProducto);
        }

        public void MostratEstadisticasVenta()
        {
            CargarUserControl(VerVenta);
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            CargarUserControl(RegistrarVenta);
        }

        public void MostrarVerDetalleVenta(BE.Venta ventaSeleccionada)
        {   
            VerDetalleVenta = new UC_VerDetalleVenta(ventaSeleccionada);
            CargarUserControl(VerDetalleVenta);
        }

        private void MostrarProductosEnVenta(object sender, EventArgs e)
        {
            RegistrarVenta.MostrarProductosDataGrid();
        }

        private void LimpiarVenta(object sender, EventArgs e)
        {
            RegistrarVenta.LimpiarVenta();
        }

        private void MostrarProductosEnStock(object sender, EventArgs e)
        {
            AgregarProducto.MostrarProductosDataGrid();
        }

        private void MostrarCategoriasDataGrid(object sender, EventArgs e)
        {
            AgregarProducto.MostrarCategoriasDataGrid();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            MostratEstadisticasVenta();
        }

        private void MostrarVentasDataGrid(object sender, EventArgs e)
        {
            VerVenta.MostrarVentasDataGrid();
        }
    }
}
