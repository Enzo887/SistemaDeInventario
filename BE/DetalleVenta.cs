using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class DetalleVenta
    {
		private int _idDetalleVenta;

		public int IDDetalleVenta
		{
			get { return _idDetalleVenta; }
			set { _idDetalleVenta = value; }
		}

		private int _cantidadProducto;

		public int CantidadProducto
		{
			get { return _cantidadProducto; }
			set { _cantidadProducto = value; }
		}

		private Producto _producto;

		public Producto Producto
		{
			get { return _producto; }
			set { _producto = value; }
		}

        public decimal Subtotal
        {
            get
            {
				if(_producto != null)
				{
					return _producto.Precio * _cantidadProducto;

				}
				else
				{
					return 0;
				}
					
            }
            //set { Subtotal = value; }
        }

        public string NombreProducto
        {
            get { return _producto != null ? _producto.NombreProducto : ""; }
        }

        public string EstadoProducto
        {
            get { return _producto != null ? _producto.Estado : ""; }
        }

        public decimal PrecioProducto
        {
            get { return _producto != null ? _producto.Precio : 0; }
        }
    }
}
