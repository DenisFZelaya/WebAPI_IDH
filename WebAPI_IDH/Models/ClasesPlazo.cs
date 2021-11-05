using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class ClasesPlazo
    {
        public decimal Clase { get; set; }
        public decimal Nivel { get; set; }
        public decimal MDesde { get; set; }
        public decimal MHasta { get; set; }
        public decimal Plazo { get; set; }
        public string EmpreSaf { get; set; }
    }
}
