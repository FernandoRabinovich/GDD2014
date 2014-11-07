using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel
{
    public class Reserva
    {
        private int codigo;
        public int Codigo
        {
            get{return this.codigo;}
            set{this.codigo = value;}
        }

        private DateTime fechaDesde;
        public DateTime FechaDesde
        {
            get{return this.fechaDesde;}
            set{this.fechaDesde = value;}
        }

        private DateTime fechaHasta;
        public DateTime FechaHasta
        {
            get{return this.fechaHasta;}
            set{this.fechaHasta = value;}
        }

        private int idHotel;
        public int IdHotel
        {
            get{return this.idHotel;}
            set{this.idHotel = value;}
        }

        private int idRegimen;
        public int IdRegimen
        {
            get{return this.idRegimen;}
            set{this.idRegimen = value;}
        }

        private int idCliente;
        public int IdCliente
        {
            get { return this.idCliente; }
            set { this.idCliente = value; }
        }

        public Reserva(int codigo, int idHotel, int idRegimen, DateTime fechaDesde, DateTime fechaHasta, int idCliente)
        {
            this.codigo = codigo;
            this.idHotel = idHotel;
            this.idRegimen = idRegimen;
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            this.idCliente = idCliente;
        }

        public Reserva()
        { }
    }
}
