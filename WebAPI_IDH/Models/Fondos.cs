using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Fondos
    {
        public string Fondo { get; set; }
        public string DescFondo { get; set; }
        public string Prefijo { get; set; }
        public string EmpreSaf { get; set; }
        public string Ultimaactualizacion { get; set; }
        public decimal Monto { get; set; }
        public decimal Fondeador { get; set; }
    }
}
