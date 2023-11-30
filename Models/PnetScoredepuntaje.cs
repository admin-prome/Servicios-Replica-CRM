using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class PnetScoredepuntaje
{
    public string? CreatedOnBehalfByName { get; set; }

    public string? CreatedOnBehalfByYomiName { get; set; }

    public string? ModifiedByName { get; set; }

    public string? ModifiedByYomiName { get; set; }

    public string? CreatedByName { get; set; }

    public string? CreatedByYomiName { get; set; }

    public string? PnetActividadesCnaename { get; set; }

    public string? ModifiedOnBehalfByName { get; set; }

    public string? ModifiedOnBehalfByYomiName { get; set; }

    public string? PnetActividadessegmentName { get; set; }

    public string? PnetContactoPrincipalScoreName { get; set; }

    public string? PnetContactoPrincipalScoreYomiName { get; set; }

    public Guid? OwnerId { get; set; }

    public string? OwnerIdName { get; set; }

    public string? OwnerIdYomiName { get; set; }

    public int? OwnerIdDsc { get; set; }

    public int? OwnerIdType { get; set; }

    public Guid? OwningUser { get; set; }

    public Guid? OwningTeam { get; set; }

    public Guid? PnetScoredepuntajeId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedBy { get; set; }

    public Guid? CreatedOnBehalfBy { get; set; }

    public Guid? ModifiedOnBehalfBy { get; set; }

    public Guid? OwningBusinessUnit { get; set; }

    public int? Statecode { get; set; }

    public int? Statuscode { get; set; }

    public byte[]? VersionNumber { get; set; }

    public int? ImportSequenceNumber { get; set; }

    public DateTime? OverriddenCreatedOn { get; set; }

    public int? TimeZoneRuleVersionNumber { get; set; }

    public int? UtcconversionTimeZoneCode { get; set; }

    public string? PnetName { get; set; }

    public Guid? PnetActividadesCnae { get; set; }

    public Guid? PnetActividadessegment { get; set; }

    public int? PnetChequesRechazadosScore { get; set; }

    public int? PnetClasificacionPatrimonialscore { get; set; }

    public int? PnetCodigoSituacionScore { get; set; }

    public Guid? PnetContactoPrincipalScore { get; set; }

    public int? PnetEdadScore { get; set; }

    public int? PnetEstadoCivilScore { get; set; }

    public decimal? PnetMontodesaldoadeudado { get; set; }

    public decimal? PnetOtrosingresosdatooriginal { get; set; }

    public decimal? PnetOtrosIngresosValidadosScore { get; set; }

    public int? PnetPermanenciaenlaActividadScore { get; set; }

    public int? PnetPoseeHijosScore { get; set; }

    public decimal? PnetPuntosTotalScoredePuntaje { get; set; }

    public int? PnetSituacionenBcrascore { get; set; }

    public int? PnetTipodeImpuestoScore { get; set; }

    public int? PnetTipodeViviendaScore { get; set; }

    public bool? PnetValidarOtrosIngresos { get; set; }

    public bool? PnetValidarResultadoScore { get; set; }

    public decimal? PnetPuntosActividadesdelaMe { get; set; }

    public decimal? PnetPuntosBcra { get; set; }

    public decimal? PnetPuntosCategoriaIvascore { get; set; }

    public decimal? PnetPuntosChequesRechazados { get; set; }

    public decimal? PnetPuntosClasificacionPatrimonial { get; set; }

    public decimal? PnetPuntosEdad { get; set; }

    public decimal? PnetPuntosEstadoCivilScore { get; set; }

    public decimal? PnetPuntosIngresosValidados { get; set; }

    public decimal? PnetPuntosPermanenciaMe { get; set; }

    public decimal? PnetPuntosPoseeHijos { get; set; }

    public decimal? PnetPuntosSaldoAdeudado { get; set; }

    public decimal? PnetPuntosTipodeVivienda { get; set; }

    public int? PnetResultadoScoredePuntaje { get; set; }

    public string? PnetActividadsegmento { get; set; }
}
