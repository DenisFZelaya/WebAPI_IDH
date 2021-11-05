using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Ciudades
    {
        public decimal CodCiud { get; set; }
        public string Ciudad { get; set; }
        public decimal NumDepto { get; set; }
        public string EmpreSaf { get; set; }
        public DateTime FchCreado { get; set; }
        public decimal CodRegion { get; set; }
        public decimal Esrural { get; set; }
        public string CodEquiv { get; set; }
        public string CreadoPor { get; set; }
    }
}
