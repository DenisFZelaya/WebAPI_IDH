using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Tpclientes
    {
        public decimal Tpcliente { get; set; }
        public string DescTpcliente { get; set; }
        public string EmpreSaf { get; set; }
        public string FchCreado { get; set; }
        public int EsEmpresa { get; set; }
    }
}
