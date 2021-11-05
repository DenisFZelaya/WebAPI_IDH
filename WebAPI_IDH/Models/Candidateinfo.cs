using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Candidateinfo
    {
        public string Nombre { get; set; }
        public string Tipopersona { get; set; }
        public string Fechanacimiento { get; set; }
        public long Candidateinfoid { get; set; }
        public DateTime? Fechaconsulta { get; set; }
        public string Identidad { get; set; }
    }
}
