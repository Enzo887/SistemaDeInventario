using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GestorVenta
    {

        private DAL.VentaDAL ventaDAL = new DAL.VentaDAL();
        public void AgregarDetalle(BE.Venta venta, BE.Producto producto, int cantidad)
        {
            //Busca la primer coincidencia con el idSeleccionado
            var detalleExistente = venta.DetallesVenta.FirstOrDefault(detalle=> detalle.Producto.IDProducto == producto.IDProducto);

            if (detalleExistente != null)
            {
                detalleExistente.CantidadProducto += 1;
            }
            else
            {
                BE.DetalleVenta nuevoDetalle = new BE.DetalleVenta
                {
                    IDDetalleVenta = producto.IDProducto,
                    Producto = producto,
                    CantidadProducto = cantidad
                };
                venta.DetallesVenta.Add(nuevoDetalle);
            }
        }

        public void SacarDetalle(BE.Venta venta, BE.Producto producto)
        {
            var detalleExistente = venta.DetallesVenta.FirstOrDefault(detalle => detalle.Producto.IDProducto == producto.IDProducto);

            if(detalleExistente != null)
            {
                if(detalleExistente.CantidadProducto > 1)
                {
                    detalleExistente.CantidadProducto -= 1;
                }
                else
                {
                    venta.DetallesVenta.Remove(detalleExistente);
                }     
            }
        }

        public void SacarDetalle2(BE.Venta venta)
        {
            var detalleExistente = venta.DetallesVenta.FirstOrDefault(detalle => detalle.Producto.Estado == "Deshabilitado");

            if (detalleExistente != null)
            {
                    venta.DetallesVenta.Remove(detalleExistente);   
            }
        }

        public void ActualizarDetalles(BE.Venta unaVenta, List<BE.Producto> productosBD)
        {
            foreach (var producto in productosBD)
            {
                var detalleCoincidencia = unaVenta.DetallesVenta.FirstOrDefault(detalle => detalle.Producto.IDProducto == producto.IDProducto);
                
                if (detalleCoincidencia != null)
                {
                    detalleCoincidencia.Producto.NombreProducto = producto.NombreProducto;
                    detalleCoincidencia.Producto.Activo = producto.Activo;
                }
            }
            
        }



        public decimal CalcularTotal(Venta venta)
        {
            return venta.DetallesVenta.Sum(detalle => detalle.Subtotal);
        }

        public void RegistrarVenta(BE.Venta venta)
        {
            venta.IDVenta = ventaDAL.RegistrarVenta(venta);
            ventaDAL.GuardarDetalleVenta(venta);
        }

        public List<BE.Venta> ObtenerVentas()
        {
            DataTable tabla = ventaDAL.ObtenerVentas();

            List<BE.Venta> ventas = new List<BE.Venta>();

            foreach (DataRow fila in tabla.Rows)
            {
               BE.Venta unaVenta = new BE.Venta();
                unaVenta.IDVenta = Convert.ToInt32(fila["IdVenta"]);
                unaVenta.FechaVenta = (DateTime)fila["FechaVenta"];
                unaVenta.PrecioTotal = Convert.ToDecimal(fila["PrecioTotal"]);
                unaVenta.MetodoPago = fila["MetodoPago"].ToString();

                ventas.Add(unaVenta);
            }
            return ventas;
        }
    }
}
