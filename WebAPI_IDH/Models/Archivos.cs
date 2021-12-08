using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Archivos
    {
        public int Idarchivo { get; set; }
        public int? Idconcepto { get; set; }
        public string Nombrearchivo { get; set; }
        public string Ubicacion { get; set; }
        public string Codsolicitud { get; set; }
        public string Fchcreado { get; set; }
        public string CodsolicitudIdconcepto { get; set; }
    }
}
