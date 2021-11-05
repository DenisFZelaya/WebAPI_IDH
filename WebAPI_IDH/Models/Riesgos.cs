using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Riesgos
    {
        public decimal Idriesgo { get; set; }
        public decimal Idtipo { get; set; }
        public string Tipoparam { get; set; }
        public string Descripcion { get; set; }
        public decimal Valorminimo { get; set; }
        public decimal Valormaximo { get; set; }
        public decimal Importancia { get; set; }
        public string Estado { get; set; }
    }
}
