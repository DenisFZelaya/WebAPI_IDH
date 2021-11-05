using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class BandSolicitud
    {
        public string IdSolicitud { get; set; }
        public string IdCliente { get; set; }
        public string IdUsuario { get; set; }
        public string IdClase { get; set; }
        public string Monto { get; set; }
        public string CodAgencia { get; set; }
        public string FchCreado { get; set; }
    }
}
