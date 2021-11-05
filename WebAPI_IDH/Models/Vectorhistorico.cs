using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Vectorhistorico
    {
        public string Anio { get; set; }
        public string Mes { get; set; }
        public string Mora { get; set; }
        public long Vectorhistoricoid { get; set; }
        public long? Identificadorsujetoid { get; set; }
    }
}
