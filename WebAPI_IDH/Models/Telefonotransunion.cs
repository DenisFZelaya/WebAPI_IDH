using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Telefonotransunion
    {
        public string Codigo { get; set; }
        public string Texto { get; set; }
        public string Telefono { get; set; }
        public long Telefonoid { get; set; }
        public long? Identificadorsujetoid { get; set; }
    }
}
