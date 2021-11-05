using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Riesgopeps
    {
        public string Identidad { get; set; }
        public string Partidopolitico { get; set; }
        public string Candidato { get; set; }
        public string Cargoelectoral { get; set; }
        public string Ubicacion { get; set; }
        public string Estado { get; set; }
    }
}
