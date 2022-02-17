using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Riesgobitacora
    {
        public int Idriesgobitacora { get; set; }
        public string Idusuario { get; set; }
        public string Fecha { get; set; }
        public string Programa { get; set; }
        public string Accion { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
    }
}
