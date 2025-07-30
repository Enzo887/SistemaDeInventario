using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Venta
    {
		private int _idVenta;

		public int IDVenta
		{
			get { return _idVenta; }
			set { _idVenta = value; }
		}

		private List<DetalleVenta> _detallesVenta = new List<DetalleVenta>();

		public List<DetalleVenta> DetallesVenta
		{	
			get { return _detallesVenta; }
			set { _detallesVenta = value; }
		}

		private DateTime _fechaVenta;

		public DateTime FechaVenta
		{
			get { return _fechaVenta; }
			set { _fechaVenta = value; }
		}

		private decimal _precioTotal;

		public decimal PrecioTotal
		{
			get { return _precioTotal; }
			set { _precioTotal = value; }
		}
	}
}
