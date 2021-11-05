using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Comportamientopago
    {
        public long Comportamientodepagoid { get; set; }
        public string Calificacion { get; set; }
        public long? Diasmora { get; set; }
        public string Moneda { get; set; }
        public string Estado { get; set; }
        public double? Limite { get; set; }
        public double? Saldoactual { get; set; }
        public double? Saldomora { get; set; }
        public long? Identificacionsujetoid { get; set; }
    }
}
