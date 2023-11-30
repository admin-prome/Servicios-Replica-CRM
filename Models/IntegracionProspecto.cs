using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class IntegracionProspecto
{
    public long IdIntProspecto { get; set; }

    public long FormId { get; set; }

    public string? Utmmedio { get; set; }

    public string? Utmorigen { get; set; }

    public string? Utmcampaña { get; set; }

    public string? Utmcontenido { get; set; }

    public int? FilialProme { get; set; }

    public DateTime FechaOrigen { get; set; }

    public DateTime FechaProceso { get; set; }

    public string IdProceso { get; set; } = null!;

    public long EntryId { get; set; }

    public string? Tipo { get; set; }

    public string? Dni { get; set; }

    public string? Sexo { get; set; }

    public string? Sucursal { get; set; }

    public string? Apellido { get; set; }

    public string? Nombre { get; set; }

    public string? Rating { get; set; }

    public string? ComoSeEntero { get; set; }

    public string? RecomendadorTipoDocumento { get; set; }

    public string? RecomendadorNumeroDocumento { get; set; }

    public string? RecomendadorGenero { get; set; }

    public string? CodigoDeAreaTelefono { get; set; }

    public string? TipoDeTelefono { get; set; }

    public string? NumeroDeTelefono { get; set; }

    public string? CodigoAreaTelefonoAlternativo { get; set; }

    public string? TipoDeTelefonoAlternativo { get; set; }

    public string? TelefonoAlternativoNro { get; set; }

    public string? Telefono3roCodArea { get; set; }

    public string? Telefono3roTipo { get; set; }

    public string? Telefono3roNro { get; set; }

    public string? Email { get; set; }

    public string? MicroempresaPropia { get; set; }

    public string? Microempresa { get; set; }

    public string? InicioActividades { get; set; }

    public string? Permanencia { get; set; }

    public string? Cnae { get; set; }

    public string? Cno { get; set; }

    public string? Segmento { get; set; }

    public string? Actividad { get; set; }

    public string? Categoria { get; set; }

    public string? AccionComercial { get; set; }

    public string? Accion { get; set; }

    public string? DocumentoTributarioTipo { get; set; }

    public string? DocumentoTributarioPrefijo { get; set; }

    public string? DocumentoTributarioCuerpo { get; set; }

    public string? DocumentoTributarioDigVerificador { get; set; }

    public string? DireccionTipo { get; set; }

    public string? Calle { get; set; }

    public string? CalleNro { get; set; }

    public string? Piso { get; set; }

    public string? Departamento { get; set; }

    public string? LocalidadMicroempresa { get; set; }

    public string? BarrioMicroempresa { get; set; }

    public string? CodPostal { get; set; }

    public string? Provincia { get; set; }

    public string? Pais { get; set; }
}
