using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel
{
    public class Cliente
    {
        //id, nombre, apellido, idTipoDocumento, nroDocumento, estado
        private int id;
        public int Id
        {
            get{return this.id;}
            set{this.id = value;}
        }

        private string nombre;
        public string Nonbre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        private string apellido;
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        private bool estado;
        public string Estado
        {
            get 
            {
                if (this.estado)
                    return "Actico";
                else return "Inactivo";
            }
            set 
            { 
                this.estado = value.Equals("Activo") ? true:false; 
            }
        }
        
        private string direccion;
        public string Direccion
        {
            get { return this.direccion; }
            set { this.direccion = value; }
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

        private string telefono;
        public string Telefono
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }

        private DateTime fechaNac;
        public DateTime FechaNacimiento
        {
            get { return this.fechaNac; }
            set { this.fechaNac = value; }
        }
        
        private string mail;
        public string Mail
        {
            get { return this.mail; }
            set { this.mail = value; }
        }

        private TipoDoc tipoDoc;
        public TipoDoc TipoDoc
        {
            get { return this.tipoDoc; }
            set { this.tipoDoc = value; }
        }

        private int numeroDoc;
        public int NumeroDoc
        {
            get { return this.numeroDoc; }
            set { this.numeroDoc = value; }
        }

        private string nacionalidad;
        public string Nacionalidad
        {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }

        private string localidad;
        public string Localidad
        {
            get { return this.localidad; }
            set { this.localidad = value; }
        }

        private string departamento;
        public string Departamento
        {
            get { return this.departamento; }
            set { this.departamento = value; }
        }

        public Cliente(int idCliente, string apellido, string direccion, string estado, DateTime fechaNac, string mail, string nombre, int numero, 
                            int numeroDoc, int piso, TipoDoc tipoDoc, string nacionalidad, string localidad, string departamento, string telefono)
        {
            this.Apellido = apellido;
            this.Direccion = direccion;
            this.Estado = estado;
            this.FechaNacimiento = fechaNac;
            this.Mail = mail;
            this.Id = idCliente;
            this.Nonbre = nombre;
            this.Numero = numero;
            this.NumeroDoc = numeroDoc;
            this.Piso = piso;
            this.TipoDoc = tipoDoc;
            this.nacionalidad = nacionalidad;
            this.departamento = departamento;
            this.localidad = localidad;
            this.telefono = telefono;
        }

        public Cliente(string apellido, string direccion, DateTime fechaNac, string mail, string nombre, int numero,
                    int numeroDoc, int piso, TipoDoc tipoDoc, string nacionalidad, string localidad, string departamento, string telefono)
        {
            this.Apellido = apellido;
            this.Direccion = direccion;
            this.FechaNacimiento = fechaNac;
            this.Mail = mail;
            this.Nonbre = nombre;
            this.Numero = numero;
            this.NumeroDoc = numeroDoc;
            this.Piso = piso;
            this.TipoDoc = tipoDoc;
            this.nacionalidad = nacionalidad;
            this.departamento = departamento;
            this.localidad = localidad;
            this.telefono = telefono;
        }

        public Cliente() { }
    }
}
