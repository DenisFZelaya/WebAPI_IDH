using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Aldeas
    {
        public decimal CodAldea { get; set; }
        public string Aldea { get; set; }
        public decimal CodCiud { get; set; }
        public string EmpreSaf { get; set; }
        public DateTime FchCreado { get; set; }
        public string CreadoPor { get; set; }
        public decimal EsRural { get; set; }
        public decimal EsCabecera { get; set; }
    }
}
