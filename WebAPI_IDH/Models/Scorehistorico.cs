using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Scorehistorico
    {
        public string FactMsg2 { get; set; }
        public string FactMsg1 { get; set; }
        public string Tiposcore { get; set; }
        public long? Valorscore { get; set; }
        public long? Periodoinformacion { get; set; }
        public string FactMsg3 { get; set; }
        public long? Candidateinfoid { get; set; }
        public long Scorehistoricoid { get; set; }
    }
}
