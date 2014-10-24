﻿using System;
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

        public HabitacionesPorReserva(string hotel, string tipoHabitacion, string regimen, int idHabitacion)
        {
            this.regimen = regimen;
            this.hotel = hotel;
            this.tipoHabitacion = tipoHabitacion;
            this.idHabitacion = idHabitacion;
        }

        public HabitacionesPorReserva()
        { }
    }
}
