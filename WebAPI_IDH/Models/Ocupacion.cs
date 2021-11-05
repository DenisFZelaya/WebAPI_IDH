using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Ocupacion
    {
        public decimal CodOcupacion { get; set; }
        public string Ocupacion1 { get; set; }
        public DateTime FechaCreado { get; set; }
        public string CreadoPor { get; set; }
        public decimal Idsesion { get; set; }
    }
}
