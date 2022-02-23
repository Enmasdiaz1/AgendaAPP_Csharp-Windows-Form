using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string TelefonoPersonal { get; set; }
        public string TelefonoTrabajo { get; set; }
        public int IdUsuario { get; set; }

        public int IdUser { get; set; }
        public string NombreUser { get; set; }
        public string ApellidosUser { get; set; }
        public string Usuario { get; set; }
        public string Pass { get; set; }
        public string Pass2 { get; set; }


    }
}
