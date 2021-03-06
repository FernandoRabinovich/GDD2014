﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel
{
    public class Rol
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

        private bool estado;
        public bool Estado
        {
            get { return this.estado; }
            set { this.estado = value; }
        }

        public Rol(int id, string descripcion, bool estado)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.estado = estado;
        }

        public Rol(int id, string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }

        public override string ToString()
        {
            return this.descripcion;
        }
    }
}
