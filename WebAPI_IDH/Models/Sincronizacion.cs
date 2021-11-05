using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Sincronizacion
    {
        public long IdSincro { get; set; }
        public long TipoSincro { get; set; }
        public string Descripcion { get; set; }
        public long IdEstatus { get; set; }
        public string DescEstatus { get; set; }
        public long IdUsuario { get; set; }
        public string FchSincro { get; set; }
    }
}
