using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Comportamientoobligaciones
    {
        public string Creditoconsecutivo { get; set; }
        public string Entidadinformante { get; set; }
        public string Tipo { get; set; }
        public long? Numero { get; set; }
        public string Fechaapertura { get; set; }
        public string Fechacierre { get; set; }
        public string Fechaactualizacion { get; set; }
        public string Periodopago { get; set; }
        public long Comportamientoobligacionesid { get; set; }
        public long? Identificadorsujetoid { get; set; }
        public string Garantia { get; set; }
    }
}
