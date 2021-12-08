using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Usuarios
    {
        public int Idusuario { get; set; }
        public string Nombre { get; set; }
        public string Usu { get; set; }
        public string Contrasena { get; set; }
        public int Tipousuario { get; set; }
        public string Fchvenusu { get; set; }
        public string Fchvenpass { get; set; }
        public string Fchcreado { get; set; }
        public int Nivelusuario { get; set; }
        public int Codasesor { get; set; }
        public int Estado { get; set; }
        public string Email { get; set; }
        public string Codagencia { get; set; }
        public bool? SessionActiva { get; set; }
        public long? Tipousuarioriesgo { get; set; }
    }
}
