using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class ExcepcionesAppMovil
    {
        public long Id { get; set; }
        public decimal? Idasesor { get; set; }
        public DateTime? Fecha { get; set; }
        public string Nameexc { get; set; }
        public string Pageexc { get; set; }
        public string Lineexc { get; set; }
        public string Processexc { get; set; }
        public string Messageexc { get; set; }
        public string Modeldevice { get; set; }
        public string Manufacturer { get; set; }
        public string Devincename { get; set; }
        public string Osrun { get; set; }
        public string Platform { get; set; }
        public string Idiom { get; set; }
        public string Devicetype { get; set; }
    }
}
