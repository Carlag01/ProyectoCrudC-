using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoCrud.Models
{
    public class Usuarios
    {
        public string Nombres { get; set; }
        public string Apellido { get; set; }
        public string Rut { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public Rol IdRol { get; set; }

       
    }
}