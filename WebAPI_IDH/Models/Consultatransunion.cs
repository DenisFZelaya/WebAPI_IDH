using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Consultatransunion
    {
        public string Entidadconsultante { get; set; }
        public string Fecha { get; set; }
        public string Motivo { get; set; }
        public long Consultaid { get; set; }
    }
}
