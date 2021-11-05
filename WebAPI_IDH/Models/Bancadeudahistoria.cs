using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Bancadeudahistoria
    {
        public string NumeLine { get; set; }
        public string CodiFnte { get; set; }
        public string PeriActu { get; set; }
        public string PeriLine { get; set; }
        public string FechOtor { get; set; }
        public string NumeRefe { get; set; }
        public string TipoCred { get; set; }
        public long? Periodoinformacion { get; set; }
        public long? Candidateinfoid { get; set; }
        public long Bandeudahistoricaid { get; set; }
    }
}
