using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VentaDAL
    {
        Conexion conexion = new Conexion();

        public int RegistrarVenta(BE.Venta venta)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[] {
                new SqlParameter("@PrecioTotal",venta.PrecioTotal),
                new SqlParameter("@FechaVenta",venta.FechaVenta),
                new SqlParameter("@MetodoPago",venta.MetodoPago),
                new SqlParameter("@Venta_ID",SqlDbType.Int)
                {Direction = ParameterDirection.Output}
                    };
                conexion.EscribirPorStoreProcedure("SP_RegistrarVenta", parametros);
                int idVenta = Convert.ToInt32(parametros[3].Value);
                return idVenta;
            }
            catch (Exception e)
            {
                throw new Exception("Hubo un error en el INSERT de registrar venta",e);
            }  
        }

        public void GuardarDetalleVenta(BE.Venta venta)
        {
            try
            {
                foreach (var detalle in venta.DetallesVenta)
                {
                    SqlParameter[] parametros = new SqlParameter[] {
                    new SqlParameter("@IdProducto",detalle.Producto.IDProducto),
                    new SqlParameter("@IdVenta",venta.IDVenta),//id venta
                    new SqlParameter("@Cantidad",detalle.CantidadProducto),
                    new SqlParameter("@PrecioSubtotal",detalle.Subtotal)
                        };
                    conexion.EscribirPorStoreProcedure("SP_GuardarDetalleVenta", parametros);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Hubo un error en el INSERT de detalleVenta", e);
            }
        }



        public DataTable ObtenerVentasDia(DateTime fechaBuscada)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@fechaBuscada",fechaBuscada)
                };
                return conexion.LeerPorStoreProcedure("SP_BuscarFechaDia", parametros);

            }
            catch (Exception e)
            {
                throw new Exception("Hubo un error en obtener la fecha de ventas en DIA en la BD", e);
            }
        }
       
        public DataTable ObtenerVentaDelDetalle(int idVenta)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@ventaID",idVenta)
                };
                return conexion.LeerPorStoreProcedure("SP_BuscarDetalleVenta", parametros);

            }
            catch (Exception e)
            {
                throw new Exception("Hubo un error en obtener venta del detalle en la BD", e);
            }
        }
    }
}
