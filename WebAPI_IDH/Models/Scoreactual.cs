using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Scoreactual
    {
        public string TypeScore { get; set; }
        public long? PeriInfo { get; set; }
        public string Message3 { get; set; }
        public string Message2 { get; set; }
        public string Message1 { get; set; }
        public string Score { get; set; }
        public string NumeNide { get; set; }
        public long? Candidateinfoid { get; set; }
        public long Scoreactualid { get; set; }
    }
}
