using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Validsession
    {
        public long Id { get; set; }
        public long IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Pass { get; set; }
        public long Agencia { get; set; }
        public string Modulo { get; set; }
        public string Estado { get; set; }
        public string Fecha { get; set; }
    }
}
