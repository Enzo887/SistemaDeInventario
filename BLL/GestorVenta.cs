using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GestorVenta
    {
        public void AgregarDetalle(BE.Venta venta, BE.Producto producto, int cantidad)
        {
            //Busca la primer coincidencia con el idSeleccionado
            var productoExistente = venta.DetallesVenta.FirstOrDefault(detalle=> detalle.Producto.IDProducto == producto.IDProducto);

            if (productoExistente != null)
            {
                productoExistente.CantidadProducto += 1;
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


        public decimal CalcularTotal(Venta venta)
        {
            return venta.DetallesVenta.Sum(detalle => detalle.Subtotal);
        }

        public void RegistrarVenta(BE.Venta venta)
        {
            DAL.VentaDAL ventaDAL = new DAL.VentaDAL();
            venta.IDVenta = ventaDAL.RegistrarVenta(venta);
            ventaDAL.GuardarDetalleVenta(venta);
        }
    }
}
