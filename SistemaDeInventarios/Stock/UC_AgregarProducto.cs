using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;

namespace SistemaDeInventarios.Stock
{
    public partial class UC_AgregarProducto : UserControl
    {
        public UC_AgregarProducto()
        {
            InitializeComponent();
        }
        
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            string nombreProducto = tboxNombreProducto.Text;
            decimal precio = numPrecio.Value;
            DateTime fechaVencimiento = dtVencimiento.Value;
            int cantidadProducto = (int)numCantidad.Value;

            BE.Producto unProducto = new BE.Producto();

            //validaciones
            if (string.IsNullOrWhiteSpace(nombreProducto))
            {
                MessageBox.Show("El nombre no puede quedar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (nombreProducto.Length > 40) {
                MessageBox.Show("El nombre no puede ser tan largo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (precio <= 0) {
                MessageBox.Show("Ingrese un precio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(fechaVencimiento.Date <= DateTime.Today)
            {
                MessageBox.Show("Ingrese una fecha mayor a la de hoy", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(cantidadProducto <= 0)
            {
                MessageBox.Show("Ingrese una cantidad del producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            unProducto.NombreProducto = nombreProducto;
            unProducto.Precio = precio;
            unProducto.FechaVencimiento = fechaVencimiento;
            unProducto.Cantidad = cantidadProducto;

            BLL.GestorDeProductos unProductoBLL = new BLL.GestorDeProductos();

            try
            {
                unProductoBLL.AgregarProductos(unProducto);
                MessageBox.Show("Se agregó el producto correctamente!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al agregar el producto:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            {
                LimparInputsProductos();
            }
        }

        //No permite escribir una . o , en la cantidad
        private void numCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.Handled = true;
            }
        
        }

        private void LimparInputsProductos()
        {
            tboxNombreProducto.Clear();
            numPrecio.Value = numPrecio.Minimum;
            numCantidad.Value = numCantidad.Minimum;
            dtVencimiento.Value = DateTime.Today;
        }

        private void btnGestionarCategoria_Click(object sender, EventArgs e)
        {
            var home = FindForm() as Home;
            if (home != null) {
                home.MostrarGestionarCategoria();
            }
            else
            {
                MessageBox.Show("No se encontro el form");
            }
        }
    }
}
