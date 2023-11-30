using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class ExtBonificacionTasaMinisterio
{
    public int BonificacionTasaMinisterioId { get; set; }

    public int ActiBa { get; set; }

    public int Pptmujer { get; set; }

    public string CondTributaria { get; set; } = null!;

    public decimal? IngresosAnualizados { get; set; }

    public int VerifMicroEmpresa { get; set; }

    public string? SituacionImpositiva { get; set; }

    public string? ConstanciaAfip { get; set; }

    public int SectoresConvenio { get; set; }

    public string? Provincia { get; set; }

    public int PresentacionIibb { get; set; }

    public string? ComentarioEvaluador { get; set; }

    public string? EstadoElegibilidad { get; set; }

    public string? JustificacionEvaluador { get; set; }

    public string? TipoSolicitud { get; set; }

    public int LideradoMujer { get; set; }

    public string? InversionElegible { get; set; }

    public string? CapTrabajoElegible { get; set; }

    public string? NumCertificado { get; set; }

    public int? Maquinaria { get; set; }

    public int? AmpliacionRemodelacion { get; set; }

    public int? Equipamiento { get; set; }

    public int? ReparacionMantenimiento { get; set; }

    public int? Software { get; set; }

    public decimal? TotalPuntosBonificacion { get; set; }

    public decimal? MontoMaximoElegible { get; set; }

    public Guid? ContactId { get; set; }

    public string EstadoRegistro { get; set; } = null!;

    public DateTime FechaModificación { get; set; }

    public string ModificadoPor { get; set; } = null!;

    public byte[] Stamp { get; set; } = null!;
}
