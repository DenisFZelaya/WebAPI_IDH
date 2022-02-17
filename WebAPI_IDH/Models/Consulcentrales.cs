using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Consulcentrales
    {
        public int Idconsulta { get; set; }
        public string Fchconsulta { get; set; }
        public string Usuario { get; set; }
        public string Agencia { get; set; }
        public string CedulaClie { get; set; }
        public bool? Aval { get; set; }
        public bool? Equifax { get; set; }
        public bool? Transunion { get; set; }
        public long? Cuadre { get; set; }
    }
}
