using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Riesgousuarios
    {
        public string Idusuario { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public int Tipousuario { get; set; }
        public string Fchcreado { get; set; }
        public string Estado { get; set; }
    }
}
