using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Agencia
    {
        public string Codagencia { get; set; }
        public string Nombreagencia { get; set; }
        public string Codciudad { get; set; }
        public string Nombreciudad { get; set; }
        public string Region { get; set; }
    }
}
