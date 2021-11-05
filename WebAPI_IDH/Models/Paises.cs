using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Paises
    {
        public decimal CodPais { get; set; }
        public string NombPais { get; set; }
        public string EmpreSaf { get; set; }
        public string FchCreado { get; set; }
        public string Prefijo { get; set; }
        public string Nacionalidad { get; set; }
        public string CreadoPor { get; set; }
        public string SiglasPais { get; set; }
    }
}
