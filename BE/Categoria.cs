using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Categoria
    {
		private int _idCategoria;

		public int IDCategoria
		{
			get { return _idCategoria; }
			set { _idCategoria = value; }
		}

		private string _nombreCategoria;

		public string NombreCategoria
		{
			get { return _nombreCategoria; }
			set { _nombreCategoria = value; }
		}


	}
}
