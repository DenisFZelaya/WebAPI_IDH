using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Lugarpoblado
    {
        public decimal CodLugpob { get; set; }
        public string DescLugpob { get; set; }
        public decimal CodTplugpob { get; set; }
        public decimal CodAldea { get; set; }
        public string CreadoPor { get; set; }
        public string FchCreado { get; set; }
        public string EmpreSaf { get; set; }
        public decimal VivOcupada { get; set; }
        public decimal VivDesocupada { get; set; }
        public decimal VivColectiva { get; set; }
        public decimal Hogar { get; set; }
        public decimal Poblacion { get; set; }
    }
}
