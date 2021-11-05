using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Clases
    {
        public decimal Clase { get; set; }
        public string Sigla { get; set; }
        public string DescClase { get; set; }
        public string Tpoperacion { get; set; }
        public string Fondo { get; set; }
        public string Programa { get; set; }
        public string MaximoAprobado { get; set; }
        public string ClTasa { get; set; }
    }
}
