using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Identificacion
    {
        public string Codigo { get; set; }
        public string Identificacion1 { get; set; }
        public decimal EsEmpresa { get; set; }
        public decimal Tpcliente { get; set; }
        public decimal Id { get; set; }
        public string EmpreSaf { get; set; }
        public string FchCreado { get; set; }
        public string Mascara { get; set; }
        public decimal Editable { get; set; }
        public decimal CodUnired { get; set; }
    }
}
