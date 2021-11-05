using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Riesgoonu
    {
        public string Dataid { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Pasaporte { get; set; }
        public string Comentario { get; set; }
        public string Nacionalidad { get; set; }
        public string Fechanacimiento { get; set; }
        public string Designacion { get; set; }
    }
}
