using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Riesgoofac
    {
        public string Uid { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Tipodocoumento { get; set; }
        public string Documento { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public string Departamento { get; set; }
        public string Fechanacimiento { get; set; }
        public string Title { get; set; }
    }
}
