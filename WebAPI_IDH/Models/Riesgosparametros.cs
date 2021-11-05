using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Riesgosparametros
    {
        public decimal Idparam { get; set; }
        public decimal Idriesgo { get; set; }
        public decimal Rangominimo { get; set; }
        public decimal Rangomaximo { get; set; }
        public decimal Valor { get; set; }
        public string Estado { get; set; }
    }
}
