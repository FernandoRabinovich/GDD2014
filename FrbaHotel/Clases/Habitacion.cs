using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel
{
    public class Habitacion
    {
        private int id;
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        private int numero;
        public int Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }

        private int piso;
        public int Piso
        {
            get { return this.piso; }
            set { this.piso = value; }
        }

        private string frente;
        public string Frente
        {
            get { return this.frente; }
            set { this.frente = value; }
        }

        private string descripcion;
        public string Descripcion
        {
            get { return this.descripcion; }
            set { this.descripcion = value; }
        }

        private bool estado;
        public string Estado
        {
            get { return this.estado ? "Activo" : "Inactivo"; }
            set{this.estado = value.Equals("Activo") ? true:false;}
        }

        private string tipoHabitacion;
        public string TipoHabitacion
        {
            get { return this.tipoHabitacion; }
            set { this.tipoHabitacion = value; }
        }

        public Habitacion()
        { }
    }
}
