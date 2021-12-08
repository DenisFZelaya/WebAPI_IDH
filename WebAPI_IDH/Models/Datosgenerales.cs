using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Datosgenerales
    {
        public string Tipoprimerapellido { get; set; }
        public string Segundoapellido { get; set; }
        public string Apellidocasada { get; set; }
        public string Primernombre { get; set; }
        public string Segundonombre { get; set; }
        public string Nombrecompleto { get; set; }
        public string Fechanacimiento { get; set; }
        public long? Edad { get; set; }
        public long Datosgeneralesid { get; set; }
        public string Genero { get; set; }
        public long? Identificadorsujetoid { get; set; }
        public string Estadovida { get; set; }
    }
}
