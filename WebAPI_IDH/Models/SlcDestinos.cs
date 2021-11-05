using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class SlcDestinos
    {
        public string CodSolicitud { get; set; }
        public string Destino { get; set; }
        public decimal Porcentaje { get; set; }
        public decimal Cantidad { get; set; }
        public string EmpreSaf { get; set; }
    }
}
