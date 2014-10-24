using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel
{
    public class Regimen
    {
        private int id;
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        private string descripcion;
        public string Descripcion
        {
            get { return this.descripcion; }
            set { this.descripcion = value; }
        }

        private decimal precio;
        public decimal Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }

        public Regimen(int id, string descripcion, decimal precio)
        {
            this.id = id;
            this.precio = precio;
        }

        public Regimen()
        { }
    }
}
