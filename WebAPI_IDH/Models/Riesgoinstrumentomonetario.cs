using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Riesgoinstrumentomonetario
    {
        public int Idmonetario { get; set; }
        public string Nombre { get; set; }
        public decimal Valor { get; set; }
        public string Estado { get; set; }
    }
}
