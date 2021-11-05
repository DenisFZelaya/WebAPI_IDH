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
        public decimal? Idparam { get; set; }
        public string Descripcion { get; set; }
        public string CodSolicitud { get; set; }
        public decimal? Idriesgomuni { get; set; }
        public decimal? Idriesgooficio { get; set; }
        public string Idriesgoorigen { get; set; }
        public decimal? Idtipopersona { get; set; }
        public string Idestadocivil { get; set; }
        public string Idgenero { get; set; }
        public decimal? Rangomin { get; set; }
        public decimal? Rangomax { get; set; }
        public decimal? Valor { get; set; }
        public decimal? Importancia { get; set; }
        public string Idriesgoagencia { get; set; }
        public string Idactividad { get; set; }
        public decimal? Rangoactual { get; set; }
        public string Idusuario { get; set; }
        public string Fechahora { get; set; }
        public bool? Ofac { get; set; }
        public bool? Onu { get; set; }
        public bool? Infornet { get; set; }
        public bool? Peps { get; set; }
        public string Estado { get; set; }
    }
}
