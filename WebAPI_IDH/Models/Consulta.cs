using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Consulta
    {
        public string FechOper { get; set; }
        public string Codigoentidad { get; set; }
        public long? Periodoinformacion { get; set; }
        public string Nombrerazon { get; set; }
        public string CodiOfic { get; set; }
        public long? Candidateinfo { get; set; }
        public long Consultaid { get; set; }
        public long? Identificadorsujetoid { get; set; }
    }
}
