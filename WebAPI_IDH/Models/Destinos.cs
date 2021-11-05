using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Destinos
    {
        public string Destino { get; set; }
        public string DescDest { get; set; }
        public decimal DescNiv { get; set; }
        public string EmpreSaf { get; set; }
        public DateTime FchCreado { get; set; }
        public string DestinoPadre { get; set; }
    }
}
