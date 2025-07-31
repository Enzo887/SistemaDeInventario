using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaDeInventarios.Stock;
using SistemaDeInventarios.Venta;

namespace SistemaDeInventarios
{
    public partial class Home : Form
    {
        private UC_AgregarProducto AgregarProducto;
        private UC_GestionarCategoria GestionarCategoria;
        private UC_RegistratVenta RegistrarVenta;
        public Home()
        {
            InitializeComponent();
            AgregarProducto = new UC_AgregarProducto();
            GestionarCategoria = new UC_GestionarCategoria();
            RegistrarVenta = new UC_RegistratVenta();
            CargarUserControl(RegistrarVenta);

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            MostrarAgregarProducto();
        }

        private void CargarUserControl(UserControl control)
        {
            panelPrincipal.Controls.Clear();           // Limpia el contenido actual
            control.Dock = DockStyle.Fill;             // Ocupa todo el panel
            panelPrincipal.Controls.Add(control);      // Agrega el nuevo
        }

        public void MostrarGestionarCategoria(EventHandler eventoCategoriaActualizada)
        {
            GestionarCategoria.CategoriaActualizada -= eventoCategoriaActualizada;
            GestionarCategoria.CategoriaActualizada += eventoCategoriaActualizada;

            CargarUserControl(GestionarCategoria);
        }

        public void MostrarAgregarProducto()
        {
            AgregarProducto.TablaProductosActualizada -= MostrarProductosEnVenta;
            AgregarProducto.TablaProductosActualizada += MostrarProductosEnVenta;

            AgregarProducto.TablaProductosActualizada -= MostrarProductosEnStock;
            AgregarProducto.TablaProductosActualizada += MostrarProductosEnStock;

            CargarUserControl(AgregarProducto);
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            CargarUserControl(RegistrarVenta);
        }

        private void MostrarProductosEnVenta(object sender, EventArgs e)
        {
            RegistrarVenta.MostrarProductosDataGrid();
        }

        private void MostrarProductosEnStock(object sender, EventArgs e)
        {
            AgregarProducto.MostrarProductosDataGrid();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
