using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Riesgoclientes
    {
        public int Idriesgocliente { get; set; }
        public string Clienteid { get; set; }
        public string Apell { get; set; }
        public string Nombre { get; set; }
        public decimal? Idriesgo { get; set; }
        public decimal? Idtipo { get; set; }
        public string Descripcion { get; set; }
        public string CodSolicitud { get; set; }
        public string Codigo { get; set; }
        public string Criterios { get; set; }
        public decimal? Valor { get; set; }
        public decimal? Importancia { get; set; }
        public string Idusuario { get; set; }
        public string Fechahora { get; set; }
        public string Estado { get; set; }
    }
}
