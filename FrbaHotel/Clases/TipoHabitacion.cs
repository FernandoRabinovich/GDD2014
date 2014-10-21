﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel
{
    public class TipoHabitacion
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

        public TipoHabitacion(int id, string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }
    }
}
