using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel
{
    public class HabitacionesPorReserva
    {
        private string hotel;
        public string Hotel
        {
            get { return this.hotel; }
            set { this.hotel = value; }
        }

        private string tipoHabitacion;
        public string TipoHabitacion
        {
            get { return this.tipoHabitacion; }
            set { this.tipoHabitacion = value; }
        }

        private string regimen;
        public string Regimen
        {
            get { return this.regimen; }
            set { this.regimen = value; }
        }

        private int idHabitacion;
        public int IdHabitacion
        {
            get { return this.idHabitacion; }
            set { this.idHabitacion = value; }
        }

        private decimal costoHabitacion;
        public decimal CostoHabitacion
        {
            get { return this.costoHabitacion; }
            set { this.costoHabitacion = value; }
        }

        private int idHotel;
        public int IdHotel
        {
            get { return this.idHotel; }
            set { this.idHotel = value; }
        }

        private int idRegimen;
        public int IdRegimen
        {
            get { return this.idRegimen; }
            set { this.idRegimen = value; }
        }

        private int idTipoHabitacion;
        public int IdTipoHabitacion
        {
            get { return this.idTipoHabitacion; }
            set { this.idTipoHabitacion = value; }
        }

        public HabitacionesPorReserva(string hotel, string tipoHabitacion, string regimen, int idHabitacion, decimal costoHabitacion)
        {
            this.regimen = regimen;
            this.hotel = hotel;
            this.tipoHabitacion = tipoHabitacion;
            this.idHabitacion = idHabitacion;
            this.costoHabitacion = costoHabitacion;
        }

        public HabitacionesPorReserva(int idHotel, int idTipoHabitacion, int idRegimen, int idHabitacion, decimal costoHabitacion)
        {
            this.idRegimen = idRegimen;
            this.idHotel = idHotel;
            this.idTipoHabitacion = idTipoHabitacion;
            this.idHabitacion = idHabitacion;
            this.costoHabitacion = costoHabitacion;
        }

        public HabitacionesPorReserva()
        { }
    }
}
