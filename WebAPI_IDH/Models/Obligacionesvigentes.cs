using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Obligacionesvigentes
    {
        public string Codigotipocuenta { get; set; }
        public string Textotipocuenta { get; set; }
        public string Estadocodigo { get; set; }
        public string Estadotexto { get; set; }
        public long Obligacionesvigentesid { get; set; }
        public long? Identificadorsujetoid { get; set; }
    }
}
