using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel
{
    public class Hotel
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

        private string mail;
        public string Mail
        {
            get { return this.mail; }
            set { this.mail = value; }
        }

        private int estrellas;
        public int Estrellas
        {
            get { return this.estrellas; }
            set { this.estrellas = value; }
        }

        private string telefono;
        public string Telefono
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }

        private string direccion;
        public string Direccion
        {
            get { return this.direccion; }
            set { this.direccion = value; }
        }

        private int numeroCalle;
        public int NumeroCalle
        {
            get { return this.numeroCalle; }
            set { this.numeroCalle = value; }
        }

        private Ciudad ciudad;
        public Ciudad Ciudad
        {
            get { return this.ciudad; }
            set { this.ciudad = value; }
        }

        private string pais;
        public string Pais
        {
            get { return this.pais; }
            set { this.pais = value; }
        }

        private List<Regimen> regimenes;
        public List<Regimen> Regimenes
        {
            get { return this.regimenes; }
            set { this.regimenes = value; }
        }

        public Hotel(int id, string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }

        public Hotel(int id, string descripcion, string mail, int estrellas, string telefono, string direccion, int numeroCalle, Ciudad ciudad, string pais, List<Regimen> regimenes)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.mail = mail;
            this.estrellas = estrellas;
            this.telefono = telefono;
            this.direccion = direccion;
            this.numeroCalle = numeroCalle;
            this.ciudad = ciudad;
            this.pais = pais;
            this.regimenes = regimenes;
        }

        public override string ToString()
        {
            return this.descripcion;
        }
    }
}
