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
    }
}
