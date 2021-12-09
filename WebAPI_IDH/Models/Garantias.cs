using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class Garantias
    {
        public string Aval { get; set; }
        public string EmpreSaf { get; set; }
        public decimal? Tpgarantiam { get; set; }
        public decimal? ClsGarantia { get; set; }
        public decimal? Tpbien { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Tipo { get; set; }
        public string Color { get; set; }
        public string Motor { get; set; }
        public string Chasis { get; set; }
        public string Vin { get; set; }
        public decimal? Anio { get; set; }
        public string Cilindraje { get; set; }
        public string NumPlaca { get; set; }
        public string NomValuador { get; set; }
        public string Tpidentificacion { get; set; }
        public string NumIdentificacion { get; set; }
        public string DescAvaluo { get; set; }
        public string DescNotaria { get; set; }
        public string Serie { get; set; }
        public decimal? CantSemovientes { get; set; }
        public string Raza { get; set; }
        public string CodCustodia { get; set; }
        public DateTime? FchEntrega { get; set; }
        public string Responsable { get; set; }
        public string Lugar { get; set; }
        public string TelCustodia { get; set; }
        public string InfoCustodia { get; set; }
        public string AvalReferencia { get; set; }
        public decimal? NumDepto { get; set; }
        public decimal? CodCiud { get; set; }
        public decimal? CodAldea { get; set; }
        public decimal Tpaval { get; set; }
        public decimal? TipoHipoteca { get; set; }
        public decimal? IdTpgarantiaHipo { get; set; }
        public DateTime? FchSuscripcion { get; set; }
        public DateTime? FchVencimiento { get; set; }
        public decimal? TieneSeguro { get; set; }
        public string TipoCobertura { get; set; }
        public string Aseguradora { get; set; }
        public string TelAsegu { get; set; }
        public decimal? ValorProyectado { get; set; }
        public string NumContrato { get; set; }
        public decimal? Zipcode { get; set; }
    }
}
