using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Direcciones
    {
        public int IdDir { get; set; }
        public string Cliente { get; set; }
        public decimal? NumDepto { get; set; }
        public decimal? CodCiud { get; set; }
        public decimal? CodAldea { get; set; }
        public string Dir1 { get; set; }
        public string Dir2 { get; set; }
        public string GpsLatitud { get; set; }
        public string GpsLongitud { get; set; }
        public string Tel { get; set; }
        public string TelMovil { get; set; }
        public string Tpresidencia { get; set; }
        public decimal TipoDir { get; set; }
        public string Cedula { get; set; }
        public DateTime FchCreado { get; set; }
        public string CreadoPor { get; set; }
        public decimal? TiempoResidir { get; set; }
        public decimal Zipcode { get; set; }
        public decimal CodLugpob { get; set; }
    }
}
