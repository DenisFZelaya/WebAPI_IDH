using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Identificacionsujeto
    {
        public string Tipo { get; set; }
        public string Numero { get; set; }
        public long Identificacionsujetoid { get; set; }
        public string Fechareporte { get; set; }
    }
}
