using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace FrbaHotel
{
    public class Usuario
    {
        private int id;
        public int Id
        {
            get{return this.id;}
            set{this.id = value;}
        }

        private string userName;
        public string UserName
        {
            get { return this.userName; }
            set { this.userName = value; }
        }

        private string nombre;
        public string Nombre
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

        public Usuario(string apellido, string direccion, string estado, DateTime fechaNac, string mail, int idUsuario, string nombre, int numero, 
                            int numeroDoc, int piso, TipoDoc tipoDoc, string userName)
        {
            this.Apellido = apellido;
            this.Direccion = direccion;
            this.Estado = estado;
            this.FechaNacimiento = fechaNac;
            this.Mail = mail;
            this.Id = idUsuario;
            this.nombre = nombre;
            this.Numero = numero;
            this.NumeroDoc = numeroDoc;
            this.Piso = piso;
            this.TipoDoc = tipoDoc;
            this.UserName = userName;
        }

        public Usuario() { }
    }
}
