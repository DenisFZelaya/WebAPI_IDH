using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Frecuenc
    {
        public decimal Frec { get; set; }
        public decimal Factor { get; set; }
        public string DescFrec { get; set; }
        public string Unidad { get; set; }
        public string EmpreSaf { get; set; }
        public DateTime FchCreado { get; set; }
        public decimal? CntAnual { get; set; }
    }
}
