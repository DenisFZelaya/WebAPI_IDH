using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Factordecambio
    {
        public double? ValoDola { get; set; }
        public long? PeriInfo { get; set; }
        public string TipoMone { get; set; }
        public long? Candidateinfoid { get; set; }
        public long Factordecambioid { get; set; }
    }
}
