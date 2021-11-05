using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class ActividadFin
    {
        public decimal CodAct { get; set; }
        public string DescAct { get; set; }
        public string Sigla { get; set; }
        public string EmpreSaf { get; set; }
        public string FchCreado { get; set; }
    }
}
