using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Producto
    {
        private int _idProducto;

        public int IDProducto
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }

        private string _nombreProducto;

        public string NombreProducto
        {
            get { return _nombreProducto; }
            set { _nombreProducto = value; }
        }

        private int _cantidad;

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        private Categoria _categoria;

        public Categoria Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }


        private DateTime _fechaIngreso = DateTime.Now;

        public DateTime FechaIngreso
        {
            get { return _fechaIngreso; }
            set { _fechaIngreso = value; }
        }

        private DateTime _fechaVencimiento;

        public DateTime FechaVencimiento
        {
            get { return _fechaVencimiento; }
            set { _fechaVencimiento = value; }
        }
        private decimal _precio;

        public decimal Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        private bool _activo;

        public bool Activo
        {
            get { return _activo; }
            set { _activo = value; }
        }

        public string Estado => Activo ? "Habilitado" : "Deshabilitado";

        public string NombreCategoria
        {
            get { return _categoria != null ? _categoria.NombreCategoria : ""; }
        }
    }
}
