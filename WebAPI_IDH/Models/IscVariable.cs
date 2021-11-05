using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class IscVariable
    {
        public string CodVar { get; set; }
        public string DescVariable { get; set; }
        public decimal EsFuncion { get; set; }
        public string Consulta { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FchCreado { get; set; }
        public string Observacion { get; set; }
    }
}
