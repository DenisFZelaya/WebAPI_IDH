using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class IndClienteNegocio
    {
        public string Cliente { get; set; }
        public string ActEco { get; set; }
        public string TipoNegocio { get; set; }
        public string Tenencia { get; set; }
        public string TiempoAlq { get; set; }
        public decimal Pais { get; set; }
        public decimal NumDepto { get; set; }
        public decimal CodCiudad { get; set; }
        public decimal CodAldea { get; set; }
        public string Dir1 { get; set; }
        public string TelNeg { get; set; }
        public string TelFijo { get; set; }
        public string TelCelular { get; set; }
        public DateTime FchInicio { get; set; }
        public DateTime FchPto { get; set; }
        public string TieneSocios { get; set; }
        public decimal NumeroEmpl { get; set; }
        public decimal EmplFijos { get; set; }
        public decimal EmplFam { get; set; }
        public decimal EmplRemunerados { get; set; }
        public string DiasSemana { get; set; }
        public string DiasDescanso { get; set; }
        public string HorarioIni { get; set; }
        public string HorarioFin { get; set; }
        public string CicloRotacion { get; set; }
        public decimal InvRotacion { get; set; }
        public decimal Capital { get; set; }
        public string LlevaConta { get; set; }
        public string EmpreSaf { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FchCreado { get; set; }
        public string Propiedad { get; set; }
        public string GestionJuridica { get; set; }
        public string LlevaActas { get; set; }
        public string LlevaPrestamos { get; set; }
        public string LlevaReglamentos { get; set; }
        public string LlevaEstatutos { get; set; }
        public string Zipcode { get; set; }
        public string NomNegocio { get; set; }
        public decimal IngMensual { get; set; }
        public decimal ClasifMypme { get; set; }
        public decimal SclasifMypme { get; set; }
        public decimal CodLugpob { get; set; }
    }
}
