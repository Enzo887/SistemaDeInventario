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

namespace SistemaDeInventarios
{
    public partial class Home : Form
    {
        private UC_AgregarProducto AgregarProducto;
        private UC_GestionarCategoria GestionarCategoria;
        public Home()
        {
            InitializeComponent();
            AgregarProducto = new UC_AgregarProducto();
            GestionarCategoria = new UC_GestionarCategoria();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            CargarUserControl(AgregarProducto);
        }

        private void CargarUserControl(UserControl control)
        {
            panelPrincipal.Controls.Clear();           // Limpia el contenido actual
            control.Dock = DockStyle.Fill;             // Ocupa todo el panel
            panelPrincipal.Controls.Add(control);      // Agrega el nuevo
        }

        public void MostrarGestionarCategoria()
        {
            CargarUserControl(GestionarCategoria);
        }
    }
}
