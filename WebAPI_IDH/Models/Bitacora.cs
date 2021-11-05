using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Bitacora
    {
        public int IdBitacora { get; set; }
        public int IdUsuario { get; set; }
        public string Opcion { get; set; }
        public string Descripcion { get; set; }
        public string FchRegistro { get; set; }
    }
}
