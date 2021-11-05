using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Direccione
    {
        public string Direccion { get; set; }
        public long? Periodoinformacion { get; set; }
        public long? Candidateinfoid { get; set; }
        public long Direccioneid { get; set; }
    }
}
