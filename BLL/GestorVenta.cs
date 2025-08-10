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
        public bool AgregarDetalle(BE.Venta venta, BE.Producto producto)
        {
            //Busca la primer coincidencia con el idSeleccionado
            var detalleExistente = venta.DetallesVenta.FirstOrDefault(detalle=> detalle.Producto.IDProducto == producto.IDProducto);

            if (detalleExistente != null)
            {                                 
                if(detalleExistente.CantidadProducto < producto.Cantidad)
                {
                    detalleExistente.CantidadProducto += 1;
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if(producto.Cantidad > 0)
            {
                BE.DetalleVenta nuevoDetalle = new BE.DetalleVenta
                {
                    IDDetalleVenta = producto.IDProducto,
                    Producto = producto,
                    CantidadProducto = 1,
                };
                venta.DetallesVenta.Add(nuevoDetalle);
                return false;
            }
            else
            {
                return true;
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
            var detalleExiste = unaVenta.DetallesVenta.FirstOrDefault(detalle => detalle.Producto.Estado == "Deshabilitado");

            if (detalleExiste != null)
            {
                unaVenta.DetallesVenta.Remove(detalleExiste);
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

        public List<BE.Venta> ObtenerVentasDia(DateTime fechaBuscada)
        {
            DataTable tabla = ventaDAL.ObtenerVentasDia(fechaBuscada);

            List<BE.Venta> ventas = new List<BE.Venta>();

            foreach (DataRow fila in tabla.Rows)
            {
               BE.Venta unaVenta = new BE.Venta();
                unaVenta.IDVenta = Convert.ToInt32(fila["IdVenta"]);
                unaVenta.FechaVenta = ((DateTime)fila["FechaVenta"]).Date;
                unaVenta.PrecioTotal = Convert.ToDecimal(fila["PrecioTotal"]);
                unaVenta.MetodoPago = fila["MetodoPago"].ToString();

                ventas.Add(unaVenta);
            }
            return ventas;
        }

        public decimal CalcularTotalVentas(List<BE.Venta> ventas)
        {
            return ventas.Sum(venta => venta.PrecioTotal);
        }

        //public void BuscarVentasDia(DateTime fechaBuscada)
        //{
        //    ventaDAL.BuscarFechaDia(fechaBuscada);
        //}

        public List<BE.DetalleVenta> ObtenerVentaDelDetalle(int idVenta)
        {
            DataTable tabla = ventaDAL.ObtenerVentaDelDetalle(idVenta);

            List<BE.DetalleVenta> detalles = new List<BE.DetalleVenta>();

            foreach (DataRow fila in tabla.Rows)
            {
                BE.DetalleVenta detalle = new BE.DetalleVenta();

                detalle.IDDetalleVenta = Convert.ToInt32(fila["IdDetalleVenta"]);
                //detalle.Producto.NombreProducto = fila["NombreProducto"].ToString();
                detalle.CantidadProducto = Convert.ToInt32(fila["CantidadProducto"]);
                //detalle.Subtotal = Convert.ToDecimal(fila["PrecioSubtotal"]);

                detalles.Add(detalle);
            }
            return detalles;
        }
    }
}
