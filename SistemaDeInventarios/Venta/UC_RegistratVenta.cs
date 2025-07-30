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
        private BindingList<BE.Producto> productosAgregados = new BindingList<Producto>();
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
            dgVenta.Columns["nombreProductoAgregado"].DataPropertyName = "NombreProducto";
            dgVenta.Columns["cantidadProductoAgregado"].DataPropertyName = "Cantidad";
            dgVenta.DataSource = null;
            dgVenta.DataSource = productosAgregados;
        }

        private void dgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgProductos.Columns[e.ColumnIndex].Name == "agregarProducto")
            {
                int idSeleccionado = Convert.ToInt32(dgProductos.Rows[e.RowIndex].Cells["idProducto"].Value);
                
                //Busca la primer coincidencia con el idSeleccionado
                var productoExistente = productosAgregados.FirstOrDefault(producto=>producto.IDProducto == idSeleccionado);

                if (productoExistente != null) 
                {
                    productoExistente.Cantidad += 1;
                }
                else
                {
                    BE.Producto unProducto = new BE.Producto();
                    unProducto.IDProducto = Convert.ToInt32(dgProductos.Rows[e.RowIndex].Cells["idProducto"].Value);
                    unProducto.NombreProducto = dgProductos.Rows[e.RowIndex].Cells["nombreProducto"].Value.ToString();
                    unProducto.Precio = Convert.ToDecimal(dgProductos.Rows[e.RowIndex].Cells["precio"].Value);
                    unProducto.Cantidad += 1;
                    productosAgregados.Add(unProducto);
                }
                MostrarProductosAgregadosDataGrid();
                MessageBox.Show($"Producto ID {idSeleccionado} - Cantidad: {productosAgregados.First(p => p.IDProducto == idSeleccionado).Cantidad} - Nombre:{productosAgregados.First(p => p.IDProducto == idSeleccionado).NombreProducto}");
            }
        }
    }
}
