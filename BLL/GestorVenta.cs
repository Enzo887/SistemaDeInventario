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
                    Producto = producto,
                    CantidadProducto = cantidad
                };
                venta.DetallesVenta.Add(nuevoDetalle);
            }
        }

        //public decimal CalcularPrecioTotal(List<BE.DetalleVenta> detallesVenta)
        //{
        //    decimal resultado = 0;
        //    foreach (var detalle in detallesVenta)
        //    {
        //        resultado += detalle.PrecioSubTotal;
        //    }
        //    return resultado;
        //}

        //public decimal CalcularTotal(Venta venta)
        //{
        //    return venta.DetallesVenta.Sum(d => d.);
        //}
    }
}
