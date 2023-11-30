using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FogabaMailService.Models;

public partial class ProvMicroOpContext : DbContext
{
    public ProvMicroOpContext()
    {
    }

    public ProvMicroOpContext(DbContextOptions<ProvMicroOpContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccountBase> AccountBases { get; set; }

    public virtual DbSet<AccountBase1> AccountBases1 { get; set; }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<Attribute> Attributes { get; set; }

    public virtual DbSet<AuxDefinicionCampo> AuxDefinicionCampos { get; set; }

    public virtual DbSet<AuxDefinicionColumna> AuxDefinicionColumnas { get; set; }

    public virtual DbSet<BusinessUnitBase> BusinessUnitBases { get; set; }

    public virtual DbSet<Calipso> Calipsos { get; set; }

    public virtual DbSet<CalipsoRentabilidadxUn> CalipsoRentabilidadxUns { get; set; }

    public virtual DbSet<CalipsoRentabilidadxUnaXi> CalipsoRentabilidadxUnaXis { get; set; }

    public virtual DbSet<CampTelefonosRechazo> CampTelefonosRechazos { get; set; }

    public virtual DbSet<CampaignBase> CampaignBases { get; set; }

    public virtual DbSet<CampaignBase1> CampaignBases1 { get; set; }

    public virtual DbSet<CampaignResponse> CampaignResponses { get; set; }

    public virtual DbSet<CampaignResponseBase> CampaignResponseBases { get; set; }

    public virtual DbSet<CategoriasMonotributo> CategoriasMonotributos { get; set; }

    public virtual DbSet<Cdni> Cdnis { get; set; }

    public virtual DbSet<CdniBip> CdniBips { get; set; }

    public virtual DbSet<ConnectionBase> ConnectionBases { get; set; }

    public virtual DbSet<ConnectionRole> ConnectionRoles { get; set; }

    public virtual DbSet<ContactBase> ContactBases { get; set; }

    public virtual DbSet<ContactBase1> ContactBases1 { get; set; }

    public virtual DbSet<ContactBaseExtranetForm1> ContactBaseExtranetForm1s { get; set; }

    public virtual DbSet<Contacto> Contactos { get; set; }

    public virtual DbSet<Contacto1> Contactos1 { get; set; }

    public virtual DbSet<ControlArchivosSur> ControlArchivosSurs { get; set; }

    public virtual DbSet<ControlBparchivo> ControlBparchivos { get; set; }

    public virtual DbSet<ControlCorreo> ControlCorreos { get; set; }

    public virtual DbSet<CorreoCopium> CorreoCopia { get; set; }

    public virtual DbSet<CorreoPlantilla> CorreoPlantillas { get; set; }

    public virtual DbSet<CorreosIntegracion> CorreosIntegracions { get; set; }

    public virtual DbSet<Credito> Creditos { get; set; }

    public virtual DbSet<CrmFiliale> CrmFiliales { get; set; }

    public virtual DbSet<CuadroDiarioEjecutivo> CuadroDiarioEjecutivos { get; set; }

    public virtual DbSet<CuadroDiarioEjecutivosMail> CuadroDiarioEjecutivosMails { get; set; }

    public virtual DbSet<CustomerAddressBase> CustomerAddressBases { get; set; }

    public virtual DbSet<CustomerAddressBase1> CustomerAddressBases1 { get; set; }

    public virtual DbSet<DbMailQueue> DbMailQueues { get; set; }

    public virtual DbSet<Diccionario> Diccionarios { get; set; }

    public virtual DbSet<Distribucion> Distribucions { get; set; }

    public virtual DbSet<DomiciliosCrm> DomiciliosCrms { get; set; }

    public virtual DbSet<Dwcatalogo> Dwcatalogos { get; set; }

    public virtual DbSet<Entity> Entities { get; set; }

    public virtual DbSet<EntityLogicalView> EntityLogicalViews { get; set; }

    public virtual DbSet<EntityMapBase> EntityMapBases { get; set; }

    public virtual DbSet<Estado> Estados { get; set; }

    public virtual DbSet<ExtBonificacionTasaMinisterio> ExtBonificacionTasaMinisterios { get; set; }

    public virtual DbSet<ExtBonificacionTasaProme> ExtBonificacionTasaPromes { get; set; }

    public virtual DbSet<ExtDescripcionGeneral> ExtDescripcionGenerals { get; set; }

    public virtual DbSet<Fallecido> Fallecidos { get; set; }

    public virtual DbSet<FallecidosCrm> FallecidosCrms { get; set; }

    public virtual DbSet<Fecha> Fechas { get; set; }

    public virtual DbSet<FechaFeriado> FechaFeriados { get; set; }

    public virtual DbSet<FlujoFondosSur> FlujoFondosSurs { get; set; }

    public virtual DbSet<FlujoFondosSur1> FlujoFondosSurs1 { get; set; }

    public virtual DbSet<FtpwatcherConfig> FtpwatcherConfigs { get; set; }

    public virtual DbSet<GeCalipso> GeCalipsos { get; set; }

    public virtual DbSet<GeCalipso1> GeCalipsos1 { get; set; }

    public virtual DbSet<GeDistribucion> GeDistribucions { get; set; }

    public virtual DbSet<GeRentabilidadxUn> GeRentabilidadxUns { get; set; }

    public virtual DbSet<GeRentabilidadxUnaXi> GeRentabilidadxUnaXis { get; set; }

    public virtual DbSet<GpTablero> GpTableros { get; set; }

    public virtual DbSet<GpTableroGantt> GpTableroGantts { get; set; }

    public virtual DbSet<GpTableroKpi> GpTableroKpis { get; set; }

    public virtual DbSet<GravityChoice> GravityChoices { get; set; }

    public virtual DbSet<GravityField> GravityFields { get; set; }

    public virtual DbSet<GravityForm> GravityForms { get; set; }

    public virtual DbSet<GravityFormsBase> GravityFormsBases { get; set; }

    public virtual DbSet<HistorialJob> HistorialJobs { get; set; }

    public virtual DbSet<HistorialJob1> HistorialJobs1 { get; set; }

    public virtual DbSet<IcCaCcSaldoPromedioProm> IcCaCcSaldoPromedioProms { get; set; }

    public virtual DbSet<IcCdniBip> IcCdniBips { get; set; }

    public virtual DbSet<IcCdniBip1> IcCdniBips1 { get; set; }

    public virtual DbSet<IcCdniComerciosProme> IcCdniComerciosPromes { get; set; }

    public virtual DbSet<IcMatrizRentum> IcMatrizRenta { get; set; }

    public virtual DbSet<IcPromeCdniComercio> IcPromeCdniComercios { get; set; }

    public virtual DbSet<IcTarjetasAtesorada> IcTarjetasAtesoradas { get; set; }

    public virtual DbSet<IcTarjetasAtesorada1> IcTarjetasAtesoradas1 { get; set; }

    public virtual DbSet<Index> Indices { get; set; }

    public virtual DbSet<IntCampaña> IntCampañas { get; set; }

    public virtual DbSet<IntCampaña1> IntCampañas1 { get; set; }

    public virtual DbSet<IntCampañaOval> IntCampañaOvals { get; set; }

    public virtual DbSet<IntCampañasNotificar> IntCampañasNotificars { get; set; }

    public virtual DbSet<IntegracionDir> IntegracionDirs { get; set; }

    public virtual DbSet<IntegracionProspecto> IntegracionProspectos { get; set; }

    public virtual DbSet<IntegracionProspecto1> IntegracionProspectos1 { get; set; }

    public virtual DbSet<IntegracionProspectosControl> IntegracionProspectosControls { get; set; }

    public virtual DbSet<IntegracionProspectosCtrl> IntegracionProspectosCtrls { get; set; }

    public virtual DbSet<Lead> Leads { get; set; }

    public virtual DbSet<LeadBase> LeadBases { get; set; }

    public virtual DbSet<LeadBase1> LeadBases1 { get; set; }

    public virtual DbSet<LegajoDigital> LegajoDigitals { get; set; }

    public virtual DbSet<ListBase> ListBases { get; set; }

    public virtual DbSet<ListBase1> ListBases1 { get; set; }

    public virtual DbSet<LocalidadesMunicipio> LocalidadesMunicipios { get; set; }

    public virtual DbSet<LocalizedLabel> LocalizedLabels { get; set; }

    public virtual DbSet<MetadataSchemaAttribute> MetadataSchemaAttributes { get; set; }

    public virtual DbSet<MetadataSchemaEntity> MetadataSchemaEntities { get; set; }

    public virtual DbSet<MetadataSchemaLocalizedLabel> MetadataSchemaLocalizedLabels { get; set; }

    public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }

    public virtual DbSet<MktBasesCampaña> MktBasesCampañas { get; set; }

    public virtual DbSet<MktBasesCampaña1> MktBasesCampañas1 { get; set; }

    public virtual DbSet<MktFormularioWp> MktFormularioWps { get; set; }

    public virtual DbSet<MktFormularioWp1> MktFormularioWps1 { get; set; }

    public virtual DbSet<MktRegistroFormWp> MktRegistroFormWps { get; set; }

    public virtual DbSet<MktSeguimientoCamp> MktSeguimientoCamps { get; set; }

    public virtual DbSet<MktSeguimientoCampPopUp> MktSeguimientoCampPopUps { get; set; }

    public virtual DbSet<MoraMasUnoNivelesRango> MoraMasUnoNivelesRangos { get; set; }

    public virtual DbSet<NivelesIrregularidad> NivelesIrregularidads { get; set; }

    public virtual DbSet<NivelesIrregularidad1> NivelesIrregularidads1 { get; set; }

    public virtual DbSet<NivelesRiesgo> NivelesRiesgos { get; set; }

    public virtual DbSet<NivelesRiesgo1> NivelesRiesgos1 { get; set; }

    public virtual DbSet<Nomina> Nominas { get; set; }

    public virtual DbSet<NominaArea> NominaAreas { get; set; }

    public virtual DbSet<NominaCategoriaColocacione> NominaCategoriaColocaciones { get; set; }

    public virtual DbSet<NormalizacionGestion> NormalizacionGestions { get; set; }

    public virtual DbSet<NormalizacionGestion1> NormalizacionGestions1 { get; set; }

    public virtual DbSet<NovedadesCompleto> NovedadesCompletos { get; set; }

    public virtual DbSet<OpportunityBase> OpportunityBases { get; set; }

    public virtual DbSet<OpportunityBase1> OpportunityBases1 { get; set; }

    public virtual DbSet<Organización> Organizacións { get; set; }

    public virtual DbSet<Ovale> Ovales { get; set; }

    public virtual DbSet<OwnerBase> OwnerBases { get; set; }

    public virtual DbSet<Padronsur> Padronsurs { get; set; }

    public virtual DbSet<PaginaRegistro> PaginaRegistros { get; set; }

    public virtual DbSet<PaginasConfig> PaginasConfigs { get; set; }

    public virtual DbSet<PaginasConfigMail> PaginasConfigMails { get; set; }

    public virtual DbSet<PaginasMenu> PaginasMenus { get; set; }

    public virtual DbSet<PaginasNotificacion> PaginasNotificacions { get; set; }

    public virtual DbSet<Parametro> Parametros { get; set; }

    public virtual DbSet<PerColaboradorCapacitacion> PerColaboradorCapacitacions { get; set; }

    public virtual DbSet<PerColaboradorCapacitacion1> PerColaboradorCapacitacions1 { get; set; }

    public virtual DbSet<PerHuellaFichadum> PerHuellaFichada { get; set; }

    public virtual DbSet<PerHuellaFichadum1> PerHuellaFichada1 { get; set; }

    public virtual DbSet<PerIncentivoConsultum> PerIncentivoConsulta { get; set; }

    public virtual DbSet<PerIncentivoParcial> PerIncentivoParcials { get; set; }

    public virtual DbSet<PerNominaTalento> PerNominaTalentos { get; set; }

    public virtual DbSet<PerNominaTalento1> PerNominaTalentos1 { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<PersonasExtra> PersonasExtras { get; set; }

    public virtual DbSet<PhoneCall> PhoneCalls { get; set; }

    public virtual DbSet<PnetAccountbpba> PnetAccountbpbas { get; set; }

    public virtual DbSet<PnetAddressBase> PnetAddressBases { get; set; }

    public virtual DbSet<PnetAddressBaseExtranet> PnetAddressBaseExtranets { get; set; }

    public virtual DbSet<PnetAttribution> PnetAttributions { get; set; }

    public virtual DbSet<PnetBinnaclerecordBase> PnetBinnaclerecordBases { get; set; }

    public virtual DbSet<PnetCnaeBase> PnetCnaeBases { get; set; }

    public virtual DbSet<PnetCnoBase> PnetCnoBases { get; set; }

    public virtual DbSet<PnetCollectionManagementBase> PnetCollectionManagementBases { get; set; }

    public virtual DbSet<PnetCollectionsource> PnetCollectionsources { get; set; }

    public virtual DbSet<PnetCommercialbackground> PnetCommercialbackgrounds { get; set; }

    public virtual DbSet<PnetConveniosdecredito> PnetConveniosdecreditos { get; set; }

    public virtual DbSet<PnetCreditBase> PnetCreditBases { get; set; }

    public virtual DbSet<PnetDistrictLocality> PnetDistrictLocalities { get; set; }

    public virtual DbSet<PnetDistrictLocalityBase> PnetDistrictLocalityBases { get; set; }

    public virtual DbSet<PnetInstance> PnetInstances { get; set; }

    public virtual DbSet<PnetInstancesBase> PnetInstancesBases { get; set; }

    public virtual DbSet<PnetListmembersBase> PnetListmembersBases { get; set; }

    public virtual DbSet<PnetNegativeFolderBasesBase> PnetNegativeFolderBasesBases { get; set; }

    public virtual DbSet<PnetParametersBase> PnetParametersBases { get; set; }

    public virtual DbSet<PnetPortfoliorecordBase> PnetPortfoliorecordBases { get; set; }

    public virtual DbSet<PnetRecordCommitteeBase> PnetRecordCommitteeBases { get; set; }

    public virtual DbSet<PnetSalesubstatusBase> PnetSalesubstatusBases { get; set; }

    public virtual DbSet<PnetScoredepuntaje> PnetScoredepuntajes { get; set; }

    public virtual DbSet<PnetSegmentBase> PnetSegmentBases { get; set; }

    public virtual DbSet<PnetSitevisitBase> PnetSitevisitBases { get; set; }

    public virtual DbSet<PositionBase> PositionBases { get; set; }

    public virtual DbSet<Presentismo> Presentismos { get; set; }

    public virtual DbSet<PresentismoRendicion> PresentismoRendicions { get; set; }

    public virtual DbSet<PrestamosLiquidadosNuevo> PrestamosLiquidadosNuevos { get; set; }

    public virtual DbSet<ProcesosCarga> ProcesosCargas { get; set; }

    public virtual DbSet<ProductBase> ProductBases { get; set; }

    public virtual DbSet<PromeLiqOrigen> PromeLiqOrigens { get; set; }

    public virtual DbSet<PromeLiqOrigen1> PromeLiqOrigens1 { get; set; }

    public virtual DbSet<ProspectoOval> ProspectoOvals { get; set; }

    public virtual DbSet<ProspectoVeraz> ProspectoVerazs { get; set; }

    public virtual DbSet<ProspectoVerazCodigo> ProspectoVerazCodigos { get; set; }

    public virtual DbSet<ProspectoVerazCrm> ProspectoVerazCrms { get; set; }

    public virtual DbSet<ProyeccionesCantidad> ProyeccionesCantidads { get; set; }

    public virtual DbSet<ProyeccionesSaldo> ProyeccionesSaldos { get; set; }

    public virtual DbSet<RechazadosBpba> RechazadosBpbas { get; set; }

    public virtual DbSet<RechazadosBpba1> RechazadosBpbas1 { get; set; }

    public virtual DbSet<RechazosBpba> RechazosBpbas { get; set; }

    public virtual DbSet<RechazosBpbaaDw> RechazosBpbaaDws { get; set; }

    public virtual DbSet<RepColocacionesBimestre> RepColocacionesBimestres { get; set; }

    public virtual DbSet<RepColocacionesColaboradore> RepColocacionesColaboradores { get; set; }

    public virtual DbSet<RepColocacionesEcBimestral> RepColocacionesEcBimestrals { get; set; }

    public virtual DbSet<ReportePresentismo> ReportePresentismos { get; set; }

    public virtual DbSet<ReportePresentismoCalendario> ReportePresentismoCalendarios { get; set; }

    public virtual DbSet<ResultadosFondep> ResultadosFondeps { get; set; }

    public virtual DbSet<ResultadosFondepCompleto> ResultadosFondepCompletos { get; set; }

    public virtual DbSet<SegmentoActual> SegmentoActuals { get; set; }

    public virtual DbSet<Solicitude> Solicitudes { get; set; }

    public virtual DbSet<Solicitude1> Solicitudes1 { get; set; }

    public virtual DbSet<SolicitudesEstado> SolicitudesEstados { get; set; }

    public virtual DbSet<SolicitudesExtra> SolicitudesExtras { get; set; }

    public virtual DbSet<SolicitudesImpecabilidad> SolicitudesImpecabilidads { get; set; }

    public virtual DbSet<SolicitudesInstancia> SolicitudesInstancias { get; set; }

    public virtual DbSet<SolicitudesLiquidadasHoy> SolicitudesLiquidadasHoys { get; set; }

    public virtual DbSet<StringMapBase> StringMapBases { get; set; }

    public virtual DbSet<SystemUserBase> SystemUserBases { get; set; }

    public virtual DbSet<TcgKpi> TcgKpis { get; set; }

    public virtual DbSet<TcgMetrica> TcgMetricas { get; set; }

    public virtual DbSet<TcgMetricasCalculo> TcgMetricasCalculos { get; set; }

    public virtual DbSet<TcgMetricasRecordatorio> TcgMetricasRecordatorios { get; set; }

    public virtual DbSet<TcgObjetivo> TcgObjetivos { get; set; }

    public virtual DbSet<TeamBase> TeamBases { get; set; }

    public virtual DbSet<TecKpi> TecKpis { get; set; }

    public virtual DbSet<TecMetrica> TecMetricas { get; set; }

    public virtual DbSet<TecMetricasCalculo> TecMetricasCalculos { get; set; }

    public virtual DbSet<TecMetricasRecordatorio> TecMetricasRecordatorios { get; set; }

    public virtual DbSet<TecObjetivo> TecObjetivos { get; set; }

    public virtual DbSet<Telefono> Telefonos { get; set; }

    public virtual DbSet<TerritoryBase> TerritoryBases { get; set; }

    public virtual DbSet<Ubicacione> Ubicaciones { get; set; }

    public virtual DbSet<UsuariosProme> UsuariosPromes { get; set; }

    public virtual DbSet<VerazExperto> VerazExpertos { get; set; }

    public virtual DbSet<VerazExpertoCrm> VerazExpertoCrms { get; set; }

    public virtual DbSet<VerazExpertoIc> VerazExpertoIcs { get; set; }

    public virtual DbSet<VerazOvale> VerazOvales { get; set; }

    public virtual DbSet<Zonificación> Zonificacións { get; set; }

    public virtual DbSet<ZzDomiciliosCrm> ZzDomiciliosCrms { get; set; }

    public virtual DbSet<ZzReporteEnlace> ZzReporteEnlaces { get; set; }

    public virtual DbSet<ZzReporteFiltro> ZzReporteFiltros { get; set; }

    public virtual DbSet<ZzSolicitudesEstado> ZzSolicitudesEstados { get; set; }

    public virtual DbSet<ZzSolicitudesHistorico> ZzSolicitudesHistoricos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=provmicrosql02.database.windows.net;database=ProvMicroOP;user id=Desarrollo;password='AyD!021#';");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccountBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AccountBase", "crm");

            entity.HasIndex(e => new { e.AccountId, e.TerritoryId }, "AccountBase-20210108-IDX");

            entity.HasIndex(e => e.PrimaryContactId, "idx_ext_AccountBase_01");

            entity.Property(e => e.AccountNumber).HasMaxLength(20);
            entity.Property(e => e.Aging30).HasColumnType("money");
            entity.Property(e => e.Aging30Base)
                .HasColumnType("money")
                .HasColumnName("Aging30_Base");
            entity.Property(e => e.Aging60).HasColumnType("money");
            entity.Property(e => e.Aging60Base)
                .HasColumnType("money")
                .HasColumnName("Aging60_Base");
            entity.Property(e => e.Aging90).HasColumnType("money");
            entity.Property(e => e.Aging90Base)
                .HasColumnType("money")
                .HasColumnName("Aging90_Base");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreditLimit).HasColumnType("money");
            entity.Property(e => e.CreditLimitBase)
                .HasColumnType("money")
                .HasColumnName("CreditLimit_Base");
            entity.Property(e => e.DoNotBulkEmail).HasColumnName("DoNotBulkEMail");
            entity.Property(e => e.DoNotEmail).HasColumnName("DoNotEMail");
            entity.Property(e => e.DoNotSendMm).HasColumnName("DoNotSendMM");
            entity.Property(e => e.EmailAddress1)
                .HasMaxLength(100)
                .HasColumnName("EMailAddress1");
            entity.Property(e => e.EmailAddress2)
                .HasMaxLength(100)
                .HasColumnName("EMailAddress2");
            entity.Property(e => e.EmailAddress3)
                .HasMaxLength(100)
                .HasColumnName("EMailAddress3");
            entity.Property(e => e.ExchangeRate).HasColumnType("numeric(23, 10)");
            entity.Property(e => e.Fax).HasMaxLength(50);
            entity.Property(e => e.FtpSiteUrl)
                .HasMaxLength(200)
                .HasColumnName("FtpSiteURL");
            entity.Property(e => e.LastOnHoldTime).HasColumnType("datetime");
            entity.Property(e => e.LastUsedInCampaign).HasColumnType("datetime");
            entity.Property(e => e.MarketCap).HasColumnType("money");
            entity.Property(e => e.MarketCapBase)
                .HasColumnType("money")
                .HasColumnName("MarketCap_Base");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(160);
            entity.Property(e => e.OpenDealsDate)
                .HasColumnType("datetime")
                .HasColumnName("OpenDeals_Date");
            entity.Property(e => e.OpenDealsState).HasColumnName("OpenDeals_State");
            entity.Property(e => e.OpenRevenue).HasColumnType("money");
            entity.Property(e => e.OpenRevenueBase)
                .HasColumnType("money")
                .HasColumnName("OpenRevenue_Base");
            entity.Property(e => e.OpenRevenueDate)
                .HasColumnType("datetime")
                .HasColumnName("OpenRevenue_Date");
            entity.Property(e => e.OpenRevenueState).HasColumnName("OpenRevenue_State");
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PnetAntiquity).HasColumnName("pnet_Antiquity");
            entity.Property(e => e.PnetCnaeflag).HasColumnName("pnet_cnaeflag");
            entity.Property(e => e.PnetCnaeid).HasColumnName("pnet_CNAEId");
            entity.Property(e => e.PnetCnaevalue).HasColumnName("pnet_CNAEvalue");
            entity.Property(e => e.PnetCnoflag).HasColumnName("pnet_cnoflag");
            entity.Property(e => e.PnetCnoid).HasColumnName("pnet_CNOId");
            entity.Property(e => e.PnetGetTypifiedSegment).HasColumnName("pnet_GetTypifiedSegment");
            entity.Property(e => e.PnetIncomeLevel).HasColumnName("pnet_IncomeLevel");
            entity.Property(e => e.PnetIncomes)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_incomes");
            entity.Property(e => e.PnetLocalityVisitId).HasColumnName("pnet_LocalityVisitId");
            entity.Property(e => e.PnetPermanence).HasColumnName("pnet_Permanence");
            entity.Property(e => e.PnetPermanency).HasColumnName("pnet_Permanency");
            entity.Property(e => e.PnetPrimaryContactId).HasColumnName("pnet_PrimaryContactId");
            entity.Property(e => e.PnetSalesRecords).HasColumnName("pnet_SalesRecords");
            entity.Property(e => e.PnetSegmentId).HasColumnName("pnet_SegmentId");
            entity.Property(e => e.PnetStartBusinessActivity)
                .HasColumnType("datetime")
                .HasColumnName("pnet_StartBusinessActivity");
            entity.Property(e => e.PnetSubsidiaryId).HasColumnName("pnet_SubsidiaryId");
            entity.Property(e => e.PnetTaxGciascategory).HasColumnName("pnet_TaxGCIASCategory");
            entity.Property(e => e.PnetTaxIibbcategory).HasColumnName("pnet_TaxIIBBCategory");
            entity.Property(e => e.PnetTaxIvacategory).HasColumnName("pnet_TaxIVACategory");
            entity.Property(e => e.PnetTypeSalesRecords)
                .HasMaxLength(150)
                .HasColumnName("pnet_TypeSalesRecords");
            entity.Property(e => e.PrimarySatoriId).HasMaxLength(200);
            entity.Property(e => e.PrimaryTwitterId).HasMaxLength(20);
            entity.Property(e => e.Revenue).HasColumnType("money");
            entity.Property(e => e.RevenueBase)
                .HasColumnType("money")
                .HasColumnName("Revenue_Base");
            entity.Property(e => e.Sic)
                .HasMaxLength(20)
                .HasColumnName("SIC");
            entity.Property(e => e.Slaid).HasColumnName("SLAId");
            entity.Property(e => e.SlainvokedId).HasColumnName("SLAInvokedId");
            entity.Property(e => e.StockExchange).HasMaxLength(20);
            entity.Property(e => e.Telephone1).HasMaxLength(50);
            entity.Property(e => e.Telephone2).HasMaxLength(50);
            entity.Property(e => e.Telephone3).HasMaxLength(50);
            entity.Property(e => e.TickerSymbol).HasMaxLength(10);
            entity.Property(e => e.TimeSpentByMeOnEmailAndMeetings).HasMaxLength(1250);
            entity.Property(e => e.TraversedPath).HasMaxLength(1250);
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.WebSiteUrl)
                .HasMaxLength(200)
                .HasColumnName("WebSiteURL");
            entity.Property(e => e.YomiName).HasMaxLength(160);
        });

        modelBuilder.Entity<AccountBase1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AccountBase", "int");

            entity.Property(e => e.AccountNumber).HasMaxLength(20);
            entity.Property(e => e.Aging30).HasColumnType("money");
            entity.Property(e => e.Aging30Base)
                .HasColumnType("money")
                .HasColumnName("Aging30_Base");
            entity.Property(e => e.Aging60).HasColumnType("money");
            entity.Property(e => e.Aging60Base)
                .HasColumnType("money")
                .HasColumnName("Aging60_Base");
            entity.Property(e => e.Aging90).HasColumnType("money");
            entity.Property(e => e.Aging90Base)
                .HasColumnType("money")
                .HasColumnName("Aging90_Base");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreditLimit).HasColumnType("money");
            entity.Property(e => e.CreditLimitBase)
                .HasColumnType("money")
                .HasColumnName("CreditLimit_Base");
            entity.Property(e => e.DoNotBulkEmail).HasColumnName("DoNotBulkEMail");
            entity.Property(e => e.DoNotEmail).HasColumnName("DoNotEMail");
            entity.Property(e => e.DoNotSendMm).HasColumnName("DoNotSendMM");
            entity.Property(e => e.EmailAddress1)
                .HasMaxLength(100)
                .HasColumnName("EMailAddress1");
            entity.Property(e => e.EmailAddress2)
                .HasMaxLength(100)
                .HasColumnName("EMailAddress2");
            entity.Property(e => e.EmailAddress3)
                .HasMaxLength(100)
                .HasColumnName("EMailAddress3");
            entity.Property(e => e.ExchangeRate).HasColumnType("numeric(23, 10)");
            entity.Property(e => e.Fax).HasMaxLength(50);
            entity.Property(e => e.FtpSiteUrl)
                .HasMaxLength(200)
                .HasColumnName("FtpSiteURL");
            entity.Property(e => e.LastOnHoldTime).HasColumnType("datetime");
            entity.Property(e => e.LastUsedInCampaign).HasColumnType("datetime");
            entity.Property(e => e.MarketCap).HasColumnType("money");
            entity.Property(e => e.MarketCapBase)
                .HasColumnType("money")
                .HasColumnName("MarketCap_Base");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(160);
            entity.Property(e => e.OpenDealsDate)
                .HasColumnType("datetime")
                .HasColumnName("OpenDeals_Date");
            entity.Property(e => e.OpenDealsState).HasColumnName("OpenDeals_State");
            entity.Property(e => e.OpenRevenue).HasColumnType("money");
            entity.Property(e => e.OpenRevenueBase)
                .HasColumnType("money")
                .HasColumnName("OpenRevenue_Base");
            entity.Property(e => e.OpenRevenueDate)
                .HasColumnType("datetime")
                .HasColumnName("OpenRevenue_Date");
            entity.Property(e => e.OpenRevenueState).HasColumnName("OpenRevenue_State");
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PnetAntiquity).HasColumnName("pnet_Antiquity");
            entity.Property(e => e.PnetCnaeflag).HasColumnName("pnet_cnaeflag");
            entity.Property(e => e.PnetCnaeid).HasColumnName("pnet_CNAEId");
            entity.Property(e => e.PnetCnaevalue).HasColumnName("pnet_CNAEvalue");
            entity.Property(e => e.PnetCnoflag).HasColumnName("pnet_cnoflag");
            entity.Property(e => e.PnetCnoid).HasColumnName("pnet_CNOId");
            entity.Property(e => e.PnetGetTypifiedSegment).HasColumnName("pnet_GetTypifiedSegment");
            entity.Property(e => e.PnetIncomeLevel).HasColumnName("pnet_IncomeLevel");
            entity.Property(e => e.PnetIncomes)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_incomes");
            entity.Property(e => e.PnetLocalityVisitId).HasColumnName("pnet_LocalityVisitId");
            entity.Property(e => e.PnetPermanence).HasColumnName("pnet_Permanence");
            entity.Property(e => e.PnetPermanency).HasColumnName("pnet_Permanency");
            entity.Property(e => e.PnetPrimaryContactId).HasColumnName("pnet_PrimaryContactId");
            entity.Property(e => e.PnetSalesRecords).HasColumnName("pnet_SalesRecords");
            entity.Property(e => e.PnetSegmentId).HasColumnName("pnet_SegmentId");
            entity.Property(e => e.PnetStartBusinessActivity)
                .HasColumnType("datetime")
                .HasColumnName("pnet_StartBusinessActivity");
            entity.Property(e => e.PnetSubsidiaryId).HasColumnName("pnet_SubsidiaryId");
            entity.Property(e => e.PnetTaxGciascategory).HasColumnName("pnet_TaxGCIASCategory");
            entity.Property(e => e.PnetTaxIibbcategory).HasColumnName("pnet_TaxIIBBCategory");
            entity.Property(e => e.PnetTaxIvacategory).HasColumnName("pnet_TaxIVACategory");
            entity.Property(e => e.PnetTypeSalesRecords)
                .HasMaxLength(150)
                .HasColumnName("pnet_TypeSalesRecords");
            entity.Property(e => e.PrimarySatoriId).HasMaxLength(200);
            entity.Property(e => e.PrimaryTwitterId).HasMaxLength(20);
            entity.Property(e => e.Revenue).HasColumnType("money");
            entity.Property(e => e.RevenueBase)
                .HasColumnType("money")
                .HasColumnName("Revenue_Base");
            entity.Property(e => e.Sic)
                .HasMaxLength(20)
                .HasColumnName("SIC");
            entity.Property(e => e.Slaid).HasColumnName("SLAId");
            entity.Property(e => e.SlainvokedId).HasColumnName("SLAInvokedId");
            entity.Property(e => e.StockExchange).HasMaxLength(20);
            entity.Property(e => e.Telephone1).HasMaxLength(50);
            entity.Property(e => e.Telephone2).HasMaxLength(50);
            entity.Property(e => e.Telephone3).HasMaxLength(50);
            entity.Property(e => e.TickerSymbol).HasMaxLength(10);
            entity.Property(e => e.TimeSpentByMeOnEmailAndMeetings).HasMaxLength(1250);
            entity.Property(e => e.TraversedPath).HasMaxLength(1250);
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.WebSiteUrl)
                .HasMaxLength(200)
                .HasColumnName("WebSiteURL");
            entity.Property(e => e.YomiName).HasMaxLength(160);
        });

        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetRoles");

            entity.HasIndex(e => e.Name, "RoleNameIndex").IsUnique();

            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.Name).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetUsers");

            entity.HasIndex(e => e.UserName, "UserNameIndex").IsUnique();

            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRole",
                    r => r.HasOne<AspNetRole>().WithMany()
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId"),
                    l => l.HasOne<AspNetUser>().WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId").HasName("PK_dbo.AspNetUserRoles");
                        j.ToTable("AspNetUserRoles");
                        j.HasIndex(new[] { "RoleId" }, "IX_RoleId");
                        j.HasIndex(new[] { "UserId" }, "IX_UserId");
                        j.IndexerProperty<string>("UserId").HasMaxLength(128);
                        j.IndexerProperty<string>("RoleId").HasMaxLength(128);
                    });
        });

        modelBuilder.Entity<AspNetUserClaim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetUserClaims");

            entity.HasIndex(e => e.UserId, "IX_UserId");

            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
        });

        modelBuilder.Entity<AspNetUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId }).HasName("PK_dbo.AspNetUserLogins");

            entity.HasIndex(e => e.UserId, "IX_UserId");

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.ProviderKey).HasMaxLength(128);
            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
        });

        modelBuilder.Entity<Attribute>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Attribute", "crm");

            entity.HasIndex(e => e.AttributeId, "Attribute-20210201-IDX");

            entity.Property(e => e.AttributeImeModeId).HasMaxLength(50);
            entity.Property(e => e.AttributeLogicalTypeId).HasMaxLength(50);
            entity.Property(e => e.AttributeRequiredLevelId).HasMaxLength(50);
            entity.Property(e => e.DefaultValue).HasMaxLength(100);
            entity.Property(e => e.DeprecatedVersion).HasMaxLength(24);
            entity.Property(e => e.ImeMode).HasMaxLength(50);
            entity.Property(e => e.IntroducedVersion).HasMaxLength(48);
            entity.Property(e => e.IsPkattribute).HasColumnName("IsPKAttribute");
            entity.Property(e => e.LogicalName).HasMaxLength(50);
            entity.Property(e => e.LookupStyle).HasMaxLength(50);
            entity.Property(e => e.ManagedPropertyLogicalName).HasMaxLength(100);
            entity.Property(e => e.ManagedPropertyParentAttributeName).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.OverwriteTime).HasColumnType("datetime");
            entity.Property(e => e.PhysicalName).HasMaxLength(50);
            entity.Property(e => e.TableColumnName).HasMaxLength(50);
            entity.Property(e => e.UpgradeDefaultValue).HasMaxLength(100);
            entity.Property(e => e.ValidForCreateApi).HasColumnName("ValidForCreateAPI");
            entity.Property(e => e.ValidForReadApi).HasColumnName("ValidForReadAPI");
            entity.Property(e => e.ValidForUpdateApi).HasColumnName("ValidForUpdateAPI");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.XmlAbbreviation).HasMaxLength(50);
        });

        modelBuilder.Entity<AuxDefinicionCampo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("auxDefinicionCampos", "crm");

            entity.Property(e => e.Columna).HasMaxLength(100);
            entity.Property(e => e.Entidad).HasMaxLength(64);
            entity.Property(e => e.ValorCrm).HasColumnName("Valor_CRM");
            entity.Property(e => e.ValorResultado)
                .HasMaxLength(4000)
                .HasColumnName("Valor_Resultado");
        });

        modelBuilder.Entity<AuxDefinicionColumna>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("auxDefinicionColumnas", "crm");

            entity.Property(e => e.Columna).HasMaxLength(50);
            entity.Property(e => e.Entidad).HasMaxLength(64);
        });

        modelBuilder.Entity<BusinessUnitBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BusinessUnitBase", "crm");

            entity.HasIndex(e => new { e.BusinessUnitId, e.ParentBusinessUnitId }, "BusinessUnitBase-20201201-ids");

            entity.Property(e => e.CostCenter).HasMaxLength(100);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DisabledReason).HasMaxLength(500);
            entity.Property(e => e.DivisionName).HasMaxLength(100);
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .HasColumnName("EMailAddress");
            entity.Property(e => e.ExchangeRate).HasColumnType("numeric(23, 10)");
            entity.Property(e => e.FileAsName).HasMaxLength(100);
            entity.Property(e => e.FtpSiteUrl).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(160);
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.StockExchange).HasMaxLength(20);
            entity.Property(e => e.TickerSymbol).HasMaxLength(10);
            entity.Property(e => e.Utcoffset).HasColumnName("UTCOffset");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.WebSiteUrl).HasMaxLength(200);
        });

        modelBuilder.Entity<Calipso>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Calipso", "fin");

            entity.Property(e => e.AjusteInflación).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Archivo).HasMaxLength(255);
            entity.Property(e => e.CentroCostos).HasMaxLength(50);
            entity.Property(e => e.Clasificación).HasMaxLength(50);
            entity.Property(e => e.CodProy).HasMaxLength(50);
            entity.Property(e => e.Descripción).HasMaxLength(255);
            entity.Property(e => e.DetalleAsiento).HasMaxLength(255);
            entity.Property(e => e.Fecha).HasColumnType("date");
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.Gerencia).HasMaxLength(50);
            entity.Property(e => e.IdProceso).HasMaxLength(50);
            entity.Property(e => e.Idasiento)
                .HasMaxLength(50)
                .HasColumnName("IDASIENTO");
            entity.Property(e => e.IdgeCalipso).HasColumnName("idgeCalipso");
            entity.Property(e => e.Línea).HasMaxLength(50);
            entity.Property(e => e.Periodo).HasColumnType("date");
            entity.Property(e => e.Presupuesto).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Proveedor).HasMaxLength(255);
            entity.Property(e => e.Proyecto).HasMaxLength(255);
            entity.Property(e => e.Real).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.RealAxI).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.Rubro).HasMaxLength(255);
            entity.Property(e => e.Subrubro).HasMaxLength(255);
            entity.Property(e => e.Zona).HasMaxLength(50);
        });

        modelBuilder.Entity<CalipsoRentabilidadxUn>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Calipso_RentabilidadxUN", "fin");

            entity.Property(e => e.AmortizacionesEIngresosFinancieros)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Amortizaciones e Ingresos Financieros");
            entity.Property(e => e.Archivo).HasMaxLength(255);
            entity.Property(e => e.CentroCostos)
                .HasMaxLength(50)
                .HasColumnName("Centro_Costos");
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.GaoPresupuesto)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("GAO Presupuesto");
            entity.Property(e => e.GaoPresupuestoCmz)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("GAO Presupuesto CMZ");
            entity.Property(e => e.GaoPresupuestoSucursal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("GAO Presupuesto Sucursal");
            entity.Property(e => e.GaoPresupuestoZonal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("GAO Presupuesto Zonal");
            entity.Property(e => e.GaoReal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("GAO Real");
            entity.Property(e => e.GaoRealCmz)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("GAO Real CMZ");
            entity.Property(e => e.GaoRealSucursal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("GAO Real Sucursal");
            entity.Property(e => e.GaoRealZonal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("GAO Real Zonal");
            entity.Property(e => e.GaoRealZonalCentralizado)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("GAO Real Zonal Centralizado");
            entity.Property(e => e.IdProceso).HasMaxLength(50);
            entity.Property(e => e.IdRentabilidadxUn).HasColumnName("idRentabilidadxUN");
            entity.Property(e => e.Iibb)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("IIBB");
            entity.Property(e => e.IibbMatriz)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("IIBB Matriz");
            entity.Property(e => e.IibbRedMatriz)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("IIBB RED Matriz");
            entity.Property(e => e.IibbSucursal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("IIBB Sucursal");
            entity.Property(e => e.IibbZonal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("IIBB Zonal");
            entity.Property(e => e.IngresosPorComisionRedMatriz)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("Ingresos por Comision RED Matriz");
            entity.Property(e => e.IngresosPorComisiones)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Ingresos por Comisiones");
            entity.Property(e => e.IngresosPorComisionesMatriz)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Ingresos por Comisiones Matriz");
            entity.Property(e => e.IngresosPorComisionesSucursal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Ingresos por Comisiones Sucursal");
            entity.Property(e => e.IngresosPorComisionesZonal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Ingresos por Comisiones Zonal");
            entity.Property(e => e.IngresosPorFacturacionReal)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("Ingresos Por Facturacion Real");
            entity.Property(e => e.IngresosPorFacturacionRedMatriz)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("Ingresos por Facturacion RED Matriz");
            entity.Property(e => e.OtrosCostosLaborales).HasColumnName("Otros Costos Laborales");
            entity.Property(e => e.OtrosCostosOperativos)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Otros Costos Operativos");
            entity.Property(e => e.Periodo).HasColumnType("date");
            entity.Property(e => e.RendimientoFinanciero)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Rendimiento Financiero");
            entity.Property(e => e.RendimientoFinancieroMatriz)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Rendimiento Financiero Matriz");
            entity.Property(e => e.RendimientoFinancieroRedMatriz)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("Rendimiento Financiero RED Matriz");
            entity.Property(e => e.RendimientoFinancieroSucursal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Rendimiento Financiero Sucursal");
            entity.Property(e => e.RendimientoFinancieroZonal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Rendimiento Financiero Zonal");
            entity.Property(e => e.SueldosPresupuesto)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Sueldos Presupuesto");
            entity.Property(e => e.SueldosPresupuestoCmz)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Sueldos Presupuesto CMZ");
            entity.Property(e => e.SueldosPresupuestoSucursal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Sueldos Presupuesto Sucursal");
            entity.Property(e => e.SueldosPresupuestoZonal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Sueldos Presupuesto Zonal");
            entity.Property(e => e.SueldosReal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Sueldos Real");
            entity.Property(e => e.SueldosRealCmz)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Sueldos Real CMZ");
            entity.Property(e => e.SueldosRealSucursal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Sueldos Real Sucursal");
            entity.Property(e => e.SueldosRealZonal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Sueldos Real Zonal");
            entity.Property(e => e.Zona).HasMaxLength(50);
        });

        modelBuilder.Entity<CalipsoRentabilidadxUnaXi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Calipso_RentabilidadxUNaXi", "fin");

            entity.Property(e => e.AmortizacionesEIngresosFinancieros)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Amortizaciones e Ingresos Financieros");
            entity.Property(e => e.Archivo).HasMaxLength(255);
            entity.Property(e => e.CentroCostos)
                .HasMaxLength(50)
                .HasColumnName("Centro_Costos");
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.GaoPresupuesto)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("GAO Presupuesto");
            entity.Property(e => e.GaoPresupuestoCmz)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("GAO Presupuesto CMZ");
            entity.Property(e => e.GaoPresupuestoSucursal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("GAO Presupuesto Sucursal");
            entity.Property(e => e.GaoPresupuestoZonal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("GAO Presupuesto Zonal");
            entity.Property(e => e.GaoReal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("GAO Real");
            entity.Property(e => e.GaoRealCmz)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("GAO Real CMZ");
            entity.Property(e => e.GaoRealSucursal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("GAO Real Sucursal");
            entity.Property(e => e.GaoRealZonal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("GAO Real Zonal");
            entity.Property(e => e.GaoRealZonalCentralizado)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("GAO Real Zonal Centralizado");
            entity.Property(e => e.IdProceso).HasMaxLength(50);
            entity.Property(e => e.IdRentabilidadxUn).HasColumnName("idRentabilidadxUN");
            entity.Property(e => e.Iibb)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("IIBB");
            entity.Property(e => e.IibbMatriz)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("IIBB Matriz");
            entity.Property(e => e.IibbRedMatriz)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("IIBB RED Matriz");
            entity.Property(e => e.IibbSucursal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("IIBB Sucursal");
            entity.Property(e => e.IibbZonal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("IIBB Zonal");
            entity.Property(e => e.IngresosPorComisionRedMatriz)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("Ingresos por Comision RED Matriz");
            entity.Property(e => e.IngresosPorComisiones)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Ingresos por Comisiones");
            entity.Property(e => e.IngresosPorComisionesMatriz)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Ingresos por Comisiones Matriz");
            entity.Property(e => e.IngresosPorComisionesSucursal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Ingresos por Comisiones Sucursal");
            entity.Property(e => e.IngresosPorComisionesZonal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Ingresos por Comisiones Zonal");
            entity.Property(e => e.IngresosPorFacturacionReal)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("Ingresos Por Facturacion Real");
            entity.Property(e => e.IngresosPorFacturacionRedMatriz)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("Ingresos por Facturacion RED Matriz");
            entity.Property(e => e.OtrosCostosLaborales).HasColumnName("Otros Costos Laborales");
            entity.Property(e => e.OtrosCostosOperativos)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Otros Costos Operativos");
            entity.Property(e => e.Periodo).HasColumnType("date");
            entity.Property(e => e.RendimientoFinanciero)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Rendimiento Financiero");
            entity.Property(e => e.RendimientoFinancieroMatriz)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Rendimiento Financiero Matriz");
            entity.Property(e => e.RendimientoFinancieroRedMatriz)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("Rendimiento Financiero RED Matriz");
            entity.Property(e => e.RendimientoFinancieroSucursal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Rendimiento Financiero Sucursal");
            entity.Property(e => e.RendimientoFinancieroZonal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Rendimiento Financiero Zonal");
            entity.Property(e => e.SueldosPresupuesto)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Sueldos Presupuesto");
            entity.Property(e => e.SueldosPresupuestoCmz)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Sueldos Presupuesto CMZ");
            entity.Property(e => e.SueldosPresupuestoSucursal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Sueldos Presupuesto Sucursal");
            entity.Property(e => e.SueldosPresupuestoZonal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Sueldos Presupuesto Zonal");
            entity.Property(e => e.SueldosReal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Sueldos Real");
            entity.Property(e => e.SueldosRealCmz)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Sueldos Real CMZ");
            entity.Property(e => e.SueldosRealSucursal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Sueldos Real Sucursal");
            entity.Property(e => e.SueldosRealZonal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Sueldos Real Zonal");
            entity.Property(e => e.Zona).HasMaxLength(50);
        });

        modelBuilder.Entity<CampTelefonosRechazo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CampTelefonosRechazos", "int");

            entity.HasIndex(e => e.DniCliente, "IDX_intCampTelefonosRechazos_DNI");

            entity.Property(e => e.DniCliente).HasColumnName("dni_cliente");
            entity.Property(e => e.SubestadoDeVenta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("subestado_de_venta");
        });

        modelBuilder.Entity<CampaignBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CampaignBase", "crm");

            entity.Property(e => e.ActualEnd).HasColumnType("datetime");
            entity.Property(e => e.ActualStart).HasColumnType("datetime");
            entity.Property(e => e.BudgetedCost).HasColumnType("money");
            entity.Property(e => e.BudgetedCostBase)
                .HasColumnType("money")
                .HasColumnName("BudgetedCost_Base");
            entity.Property(e => e.CodeName).HasMaxLength(32);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(23, 10)");
            entity.Property(e => e.ExpectedRevenue).HasColumnType("money");
            entity.Property(e => e.ExpectedRevenueBase)
                .HasColumnType("money")
                .HasColumnName("ExpectedRevenue_Base");
            entity.Property(e => e.Message).HasMaxLength(256);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(128);
            entity.Property(e => e.OtherCost).HasColumnType("money");
            entity.Property(e => e.OtherCostBase)
                .HasColumnType("money")
                .HasColumnName("OtherCost_Base");
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PnetCampaignCode).HasColumnName("pnet_CampaignCode");
            entity.Property(e => e.PnetCodigoCampania)
                .HasMaxLength(100)
                .HasColumnName("pnet_CodigoCampania");
            entity.Property(e => e.PnetConvenio).HasColumnName("pnet_convenio");
            entity.Property(e => e.PnetCounterId).HasColumnName("pnet_CounterId");
            entity.Property(e => e.PnetCreditType).HasColumnName("pnet_CreditType");
            entity.Property(e => e.PnetCustomerType).HasColumnName("pnet_CustomerType");
            entity.Property(e => e.PnetFormType).HasColumnName("pnet_FormType");
            entity.Property(e => e.PnetInterestRate).HasColumnName("pnet_InterestRate");
            entity.Property(e => e.PnetNumberMembers).HasColumnName("pnet_NumberMembers");
            entity.Property(e => e.PnetNumberMembersDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_NumberMembers_Date");
            entity.Property(e => e.PnetNumberMembersState).HasColumnName("pnet_NumberMembers_State");
            entity.Property(e => e.PnetRelatedProduct).HasColumnName("pnet_RelatedProduct");
            entity.Property(e => e.PnetRequireRate).HasColumnName("pnet_RequireRate");
            entity.Property(e => e.PnetRequireSiteVisit).HasColumnName("pnet_RequireSiteVisit");
            entity.Property(e => e.PnetRequireWfcolegiatura).HasColumnName("pnet_RequireWFColegiatura");
            entity.Property(e => e.PnetXVencimientoCampaginresponse).HasColumnName("pnet_x_vencimiento_campaginresponse");
            entity.Property(e => e.PnetXVencimientoOffervalue).HasColumnName("pnet_x_vencimiento_offervalue");
            entity.Property(e => e.PromotionCodeName).HasMaxLength(128);
            entity.Property(e => e.ProposedEnd).HasColumnType("datetime");
            entity.Property(e => e.ProposedStart).HasColumnType("datetime");
            entity.Property(e => e.TotalActualCost).HasColumnType("money");
            entity.Property(e => e.TotalActualCostBase)
                .HasColumnType("money")
                .HasColumnName("TotalActualCost_Base");
            entity.Property(e => e.TotalCampaignActivityActualCost).HasColumnType("money");
            entity.Property(e => e.TotalCampaignActivityActualCostBase)
                .HasColumnType("money")
                .HasColumnName("TotalCampaignActivityActualCost_Base");
            entity.Property(e => e.TraversedPath).HasMaxLength(1250);
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<CampaignBase1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CampaignBase", "int");

            entity.Property(e => e.ActualEnd).HasColumnType("datetime");
            entity.Property(e => e.ActualStart).HasColumnType("datetime");
            entity.Property(e => e.BudgetedCost).HasColumnType("money");
            entity.Property(e => e.BudgetedCostBase)
                .HasColumnType("money")
                .HasColumnName("BudgetedCost_Base");
            entity.Property(e => e.CodeName).HasMaxLength(32);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ExchangeRate).HasColumnType("numeric(23, 10)");
            entity.Property(e => e.ExpectedRevenue).HasColumnType("money");
            entity.Property(e => e.ExpectedRevenueBase)
                .HasColumnType("money")
                .HasColumnName("ExpectedRevenue_Base");
            entity.Property(e => e.Message).HasMaxLength(256);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(128);
            entity.Property(e => e.OtherCost).HasColumnType("money");
            entity.Property(e => e.OtherCostBase)
                .HasColumnType("money")
                .HasColumnName("OtherCost_Base");
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PnetCampaignCode).HasColumnName("pnet_CampaignCode");
            entity.Property(e => e.PnetCodigoCampania)
                .HasMaxLength(100)
                .HasColumnName("pnet_CodigoCampania");
            entity.Property(e => e.PnetConvenio).HasColumnName("pnet_convenio");
            entity.Property(e => e.PnetCounterId).HasColumnName("pnet_CounterId");
            entity.Property(e => e.PnetCreditType).HasColumnName("pnet_CreditType");
            entity.Property(e => e.PnetCustomerType).HasColumnName("pnet_CustomerType");
            entity.Property(e => e.PnetFormType).HasColumnName("pnet_FormType");
            entity.Property(e => e.PnetInterestRate).HasColumnName("pnet_InterestRate");
            entity.Property(e => e.PnetNumberMembers).HasColumnName("pnet_NumberMembers");
            entity.Property(e => e.PnetNumberMembersDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_NumberMembers_Date");
            entity.Property(e => e.PnetNumberMembersState).HasColumnName("pnet_NumberMembers_State");
            entity.Property(e => e.PnetRelatedProduct).HasColumnName("pnet_RelatedProduct");
            entity.Property(e => e.PnetRequireRate).HasColumnName("pnet_RequireRate");
            entity.Property(e => e.PnetRequireSiteVisit).HasColumnName("pnet_RequireSiteVisit");
            entity.Property(e => e.PnetRequireWfcolegiatura).HasColumnName("pnet_RequireWFColegiatura");
            entity.Property(e => e.PnetXVencimientoCampaginresponse).HasColumnName("pnet_x_vencimiento_campaginresponse");
            entity.Property(e => e.PnetXVencimientoOffervalue).HasColumnName("pnet_x_vencimiento_offervalue");
            entity.Property(e => e.PromotionCodeName).HasMaxLength(128);
            entity.Property(e => e.ProposedEnd).HasColumnType("datetime");
            entity.Property(e => e.ProposedStart).HasColumnType("datetime");
            entity.Property(e => e.TotalActualCost).HasColumnType("money");
            entity.Property(e => e.TotalActualCostBase)
                .HasColumnType("money")
                .HasColumnName("TotalActualCost_Base");
            entity.Property(e => e.TotalCampaignActivityActualCost).HasColumnType("money");
            entity.Property(e => e.TotalCampaignActivityActualCostBase)
                .HasColumnType("money")
                .HasColumnName("TotalCampaignActivityActualCost_Base");
            entity.Property(e => e.TraversedPath).HasMaxLength(1250);
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<CampaignResponse>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CampaignResponse", "crm");

            entity.HasIndex(e => e.ActivityId, "IDX_crmCampaignResponse_01");

            entity.HasIndex(e => new { e.RegardingObjectId, e.PnetContactId, e.PnetOfferValueId }, "IDX_crmCampaignResponse_02");

            entity.Property(e => e.ActualEnd).HasColumnType("datetime");
            entity.Property(e => e.ActualStart).HasColumnType("datetime");
            entity.Property(e => e.Category).HasMaxLength(250);
            entity.Property(e => e.CompanyName).HasMaxLength(100);
            entity.Property(e => e.CreatedByName).HasMaxLength(200);
            entity.Property(e => e.CreatedByYomiName).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreatedOnBehalfByName).HasMaxLength(200);
            entity.Property(e => e.CreatedOnBehalfByYomiName).HasMaxLength(200);
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .HasColumnName("EMailAddress");
            entity.Property(e => e.ExchangeRate).HasColumnType("numeric(23, 10)");
            entity.Property(e => e.Fax).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.ModifiedByName).HasMaxLength(200);
            entity.Property(e => e.ModifiedByYomiName).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOnBehalfByName).HasMaxLength(200);
            entity.Property(e => e.ModifiedOnBehalfByYomiName).HasMaxLength(200);
            entity.Property(e => e.OriginatingActivityName).HasMaxLength(200);
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.OwnerIdName).HasMaxLength(160);
            entity.Property(e => e.OwnerIdYomiName).HasMaxLength(160);
            entity.Property(e => e.PnetAgreement).HasColumnName("pnet_Agreement");
            entity.Property(e => e.PnetAmountRange).HasColumnName("pnet_AmountRange");
            entity.Property(e => e.PnetBusinessUnit).HasColumnName("pnet_BusinessUnit");
            entity.Property(e => e.PnetBusinessUnitName)
                .HasMaxLength(160)
                .HasColumnName("pnet_BusinessUnitName");
            entity.Property(e => e.PnetBuyingPropensity).HasColumnName("pnet_BuyingPropensity");
            entity.Property(e => e.PnetCampaniaRespuestaId).HasColumnName("pnet_CampaniaRespuestaId");
            entity.Property(e => e.PnetCampaniaRespuestaIdName)
                .HasMaxLength(128)
                .HasColumnName("pnet_CampaniaRespuestaIdName");
            entity.Property(e => e.PnetContactId).HasColumnName("pnet_ContactId");
            entity.Property(e => e.PnetContactIdName)
                .HasMaxLength(160)
                .HasColumnName("pnet_ContactIdName");
            entity.Property(e => e.PnetContactIdYomiName)
                .HasMaxLength(450)
                .HasColumnName("pnet_ContactIdYomiName");
            entity.Property(e => e.PnetContactOwner).HasColumnName("pnet_ContactOwner");
            entity.Property(e => e.PnetContactOwnerName)
                .HasMaxLength(160)
                .HasColumnName("pnet_ContactOwnerName");
            entity.Property(e => e.PnetContactOwnerYomiName)
                .HasMaxLength(160)
                .HasColumnName("pnet_ContactOwnerYomiName");
            entity.Property(e => e.PnetConvenio).HasColumnName("pnet_convenio");
            entity.Property(e => e.PnetCreditAmount).HasColumnName("pnet_CreditAmount");
            entity.Property(e => e.PnetCreditAmountNegotiation).HasColumnName("pnet_CreditAmountNegotiation");
            entity.Property(e => e.PnetCreditDestination).HasColumnName("pnet_CreditDestination");
            entity.Property(e => e.PnetCreditTypification)
                .HasMaxLength(3)
                .HasColumnName("pnet_CreditTypification");
            entity.Property(e => e.PnetExecutiveNameId).HasColumnName("pnet_ExecutiveNameId");
            entity.Property(e => e.PnetExecutiveNameIdName)
                .HasMaxLength(200)
                .HasColumnName("pnet_ExecutiveNameIdName");
            entity.Property(e => e.PnetExecutiveNameIdYomiName)
                .HasMaxLength(200)
                .HasColumnName("pnet_ExecutiveNameIdYomiName");
            entity.Property(e => e.PnetFechafin)
                .HasColumnType("datetime")
                .HasColumnName("pnet_fechafin");
            entity.Property(e => e.PnetFechainicio)
                .HasColumnType("datetime")
                .HasColumnName("pnet_fechainicio");
            entity.Property(e => e.PnetInteractionDescription).HasColumnName("pnet_InteractionDescription");
            entity.Property(e => e.PnetInteractionQuotasNumber).HasColumnName("pnet_InteractionQuotasNumber");
            entity.Property(e => e.PnetInteractionSaleStatus).HasColumnName("pnet_InteractionSaleStatus");
            entity.Property(e => e.PnetInteractionSaleStatusName)
                .HasMaxLength(100)
                .HasColumnName("pnet_InteractionSaleStatusName");
            entity.Property(e => e.PnetInteractionSaleSubStatus).HasColumnName("pnet_InteractionSaleSubStatus");
            entity.Property(e => e.PnetInteractionSaleSubStatusName)
                .HasMaxLength(100)
                .HasColumnName("pnet_InteractionSaleSubStatusName");
            entity.Property(e => e.PnetInteractionStatus).HasColumnName("pnet_InteractionStatus");
            entity.Property(e => e.PnetInteractionStatusName)
                .HasMaxLength(100)
                .HasColumnName("pnet_InteractionStatusName");
            entity.Property(e => e.PnetInteractionSubStatus).HasColumnName("pnet_InteractionSubStatus");
            entity.Property(e => e.PnetInteractionSubStatusName)
                .HasMaxLength(100)
                .HasColumnName("pnet_InteractionSubStatusName");
            entity.Property(e => e.PnetInterestRate).HasColumnName("pnet_InterestRate");
            entity.Property(e => e.PnetInterestRateAnual).HasColumnName("pnet_InterestRateAnual");
            entity.Property(e => e.PnetManualEntreyRequest).HasColumnName("pnet_ManualEntreyRequest");
            entity.Property(e => e.PnetNpa).HasColumnName("pnet_NPA");
            entity.Property(e => e.PnetNpb).HasColumnName("pnet_NPB");
            entity.Property(e => e.PnetNpc).HasColumnName("pnet_NPC");
            entity.Property(e => e.PnetNpd).HasColumnName("pnet_NPD");
            entity.Property(e => e.PnetOfferValueCreditAmount).HasColumnName("pnet_OfferValueCreditAmount");
            entity.Property(e => e.PnetOfferValueId).HasColumnName("pnet_OfferValueId");
            entity.Property(e => e.PnetOfferValueIdName)
                .HasMaxLength(300)
                .HasColumnName("pnet_OfferValueIdName");
            entity.Property(e => e.PnetOfferValueQuotaAmount).HasColumnName("pnet_OfferValueQuotaAmount");
            entity.Property(e => e.PnetPa).HasColumnName("pnet_PA");
            entity.Property(e => e.PnetPb).HasColumnName("pnet_PB");
            entity.Property(e => e.PnetPc).HasColumnName("pnet_PC");
            entity.Property(e => e.PnetPd).HasColumnName("pnet_PD");
            entity.Property(e => e.PnetPe).HasColumnName("pnet_pe");
            entity.Property(e => e.PnetPf).HasColumnName("pnet_pf");
            entity.Property(e => e.PnetPg).HasColumnName("pnet_pg");
            entity.Property(e => e.PnetQuotaValue).HasColumnName("pnet_QuotaValue");
            entity.Property(e => e.PnetQuotaValueNegotiation).HasColumnName("pnet_QuotaValueNegotiation");
            entity.Property(e => e.PnetQuotasNumber).HasColumnName("pnet_QuotasNumber");
            entity.Property(e => e.PnetRate).HasColumnName("pnet_Rate");
            entity.Property(e => e.PnetRb).HasColumnName("pnet_RB");
            entity.Property(e => e.PnetRc).HasColumnName("pnet_RC");
            entity.Property(e => e.PnetRd).HasColumnName("pnet_RD");
            entity.Property(e => e.PnetRenovationRequestId).HasColumnName("pnet_RenovationRequestId");
            entity.Property(e => e.PnetRenovationRequestIdName)
                .HasMaxLength(300)
                .HasColumnName("pnet_RenovationRequestIdName");
            entity.Property(e => e.PnetRenovationRequestManual).HasColumnName("pnet_RenovationRequestManual");
            entity.Property(e => e.PnetRequireSiteVisit).HasColumnName("pnet_RequireSiteVisit");
            entity.Property(e => e.PnetSaa).HasColumnName("pnet_SAA");
            entity.Property(e => e.PnetSaleStatus).HasColumnName("pnet_SaleStatus");
            entity.Property(e => e.PnetSaleStatusName)
                .HasMaxLength(100)
                .HasColumnName("pnet_SaleStatusName");
            entity.Property(e => e.PnetSaleSubStatus).HasColumnName("pnet_SaleSubStatus");
            entity.Property(e => e.PnetSaleSubStatusName)
                .HasMaxLength(100)
                .HasColumnName("pnet_SaleSubStatusName");
            entity.Property(e => e.PnetSchema).HasColumnName("pnet_Schema");
            entity.Property(e => e.PnetSetValuesInterestRate).HasColumnName("pnet_SetValuesInterestRate");
            entity.Property(e => e.PnetShowCloseCampaignFlag).HasColumnName("pnet_ShowCloseCampaignFlag");
            entity.Property(e => e.PnetSubStatusCode).HasColumnName("pnet_SubStatusCode");
            entity.Property(e => e.PnetTasa).HasColumnName("pnet_tasa");
            entity.Property(e => e.PnetTermRanges).HasColumnName("pnet_TermRanges");
            entity.Property(e => e.PnetTopicId).HasColumnName("pnet_TopicId");
            entity.Property(e => e.PnetTopicIdName)
                .HasMaxLength(300)
                .HasColumnName("pnet_TopicIdName");
            entity.Property(e => e.PromotionCodeName).HasMaxLength(250);
            entity.Property(e => e.ReceivedOn).HasColumnType("datetime");
            entity.Property(e => e.RegardingObjectIdName).HasMaxLength(4000);
            entity.Property(e => e.RegardingObjectIdYomiName).HasMaxLength(4000);
            entity.Property(e => e.ScheduledEnd).HasColumnType("datetime");
            entity.Property(e => e.ScheduledStart).HasColumnType("datetime");
            entity.Property(e => e.Subcategory).HasMaxLength(250);
            entity.Property(e => e.Subject).HasMaxLength(200);
            entity.Property(e => e.Telephone).HasMaxLength(50);
            entity.Property(e => e.TransactionCurrencyIdName).HasMaxLength(100);
            entity.Property(e => e.TraversedPath).HasMaxLength(1250);
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.YomiCompanyName).HasMaxLength(100);
            entity.Property(e => e.YomiFirstName).HasMaxLength(150);
            entity.Property(e => e.YomiLastName).HasMaxLength(150);
        });

        modelBuilder.Entity<CampaignResponseBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CampaignResponseBase", "crm");

            entity.Property(e => e.PnetAgreement).HasColumnName("pnet_Agreement");
            entity.Property(e => e.PnetAmountRange).HasColumnName("pnet_AmountRange");
            entity.Property(e => e.PnetBusinessUnit).HasColumnName("pnet_BusinessUnit");
            entity.Property(e => e.PnetBuyingPropensity).HasColumnName("pnet_BuyingPropensity");
            entity.Property(e => e.PnetCampaniaRespuestaId).HasColumnName("pnet_CampaniaRespuestaId");
            entity.Property(e => e.PnetContactId).HasColumnName("pnet_ContactId");
            entity.Property(e => e.PnetContactOwner).HasColumnName("pnet_ContactOwner");
            entity.Property(e => e.PnetConvenio).HasColumnName("pnet_convenio");
            entity.Property(e => e.PnetCreditAmount).HasColumnName("pnet_CreditAmount");
            entity.Property(e => e.PnetCreditAmountNegotiation).HasColumnName("pnet_CreditAmountNegotiation");
            entity.Property(e => e.PnetCreditDestination).HasColumnName("pnet_CreditDestination");
            entity.Property(e => e.PnetCreditTypification)
                .HasMaxLength(3)
                .HasColumnName("pnet_CreditTypification");
            entity.Property(e => e.PnetExecutiveNameId).HasColumnName("pnet_ExecutiveNameId");
            entity.Property(e => e.PnetFechafin)
                .HasColumnType("datetime")
                .HasColumnName("pnet_fechafin");
            entity.Property(e => e.PnetFechainicio)
                .HasColumnType("datetime")
                .HasColumnName("pnet_fechainicio");
            entity.Property(e => e.PnetInteractionDescription).HasColumnName("pnet_InteractionDescription");
            entity.Property(e => e.PnetInteractionQuotasNumber).HasColumnName("pnet_InteractionQuotasNumber");
            entity.Property(e => e.PnetInteractionSaleStatus).HasColumnName("pnet_InteractionSaleStatus");
            entity.Property(e => e.PnetInteractionSaleSubStatus).HasColumnName("pnet_InteractionSaleSubStatus");
            entity.Property(e => e.PnetInteractionStatus).HasColumnName("pnet_InteractionStatus");
            entity.Property(e => e.PnetInteractionSubStatus).HasColumnName("pnet_InteractionSubStatus");
            entity.Property(e => e.PnetInterestRate).HasColumnName("pnet_InterestRate");
            entity.Property(e => e.PnetInterestRateAnual).HasColumnName("pnet_InterestRateAnual");
            entity.Property(e => e.PnetManualEntreyRequest).HasColumnName("pnet_ManualEntreyRequest");
            entity.Property(e => e.PnetNpa).HasColumnName("pnet_NPA");
            entity.Property(e => e.PnetNpb).HasColumnName("pnet_NPB");
            entity.Property(e => e.PnetNpc).HasColumnName("pnet_NPC");
            entity.Property(e => e.PnetNpd).HasColumnName("pnet_NPD");
            entity.Property(e => e.PnetOfferValueCreditAmount).HasColumnName("pnet_OfferValueCreditAmount");
            entity.Property(e => e.PnetOfferValueId).HasColumnName("pnet_OfferValueId");
            entity.Property(e => e.PnetOfferValueQuotaAmount).HasColumnName("pnet_OfferValueQuotaAmount");
            entity.Property(e => e.PnetPa).HasColumnName("pnet_PA");
            entity.Property(e => e.PnetPb).HasColumnName("pnet_PB");
            entity.Property(e => e.PnetPc).HasColumnName("pnet_PC");
            entity.Property(e => e.PnetPd).HasColumnName("pnet_PD");
            entity.Property(e => e.PnetPe).HasColumnName("pnet_pe");
            entity.Property(e => e.PnetPf).HasColumnName("pnet_pf");
            entity.Property(e => e.PnetPg).HasColumnName("pnet_pg");
            entity.Property(e => e.PnetQuotaValue).HasColumnName("pnet_QuotaValue");
            entity.Property(e => e.PnetQuotaValueNegotiation).HasColumnName("pnet_QuotaValueNegotiation");
            entity.Property(e => e.PnetQuotasNumber).HasColumnName("pnet_QuotasNumber");
            entity.Property(e => e.PnetRate).HasColumnName("pnet_Rate");
            entity.Property(e => e.PnetRb).HasColumnName("pnet_RB");
            entity.Property(e => e.PnetRc).HasColumnName("pnet_RC");
            entity.Property(e => e.PnetRd).HasColumnName("pnet_RD");
            entity.Property(e => e.PnetRenovationRequestId).HasColumnName("pnet_RenovationRequestId");
            entity.Property(e => e.PnetRenovationRequestManual).HasColumnName("pnet_RenovationRequestManual");
            entity.Property(e => e.PnetRequireSiteVisit).HasColumnName("pnet_RequireSiteVisit");
            entity.Property(e => e.PnetSaa).HasColumnName("pnet_SAA");
            entity.Property(e => e.PnetSaleStatus).HasColumnName("pnet_SaleStatus");
            entity.Property(e => e.PnetSaleSubStatus).HasColumnName("pnet_SaleSubStatus");
            entity.Property(e => e.PnetSchema).HasColumnName("pnet_Schema");
            entity.Property(e => e.PnetSetValuesInterestRate).HasColumnName("pnet_SetValuesInterestRate");
            entity.Property(e => e.PnetShowCloseCampaignFlag).HasColumnName("pnet_ShowCloseCampaignFlag");
            entity.Property(e => e.PnetSubStatusCode).HasColumnName("pnet_SubStatusCode");
            entity.Property(e => e.PnetTasa).HasColumnName("pnet_tasa");
            entity.Property(e => e.PnetTermRanges).HasColumnName("pnet_TermRanges");
            entity.Property(e => e.PnetTopicId).HasColumnName("pnet_TopicId");
        });

        modelBuilder.Entity<CategoriasMonotributo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CategoriasMonotributo", "app");

            entity.Property(e => e.Actividad)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Categ)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IngresosBrutos)
                .HasColumnType("money")
                .HasColumnName("Ingresos Brutos");
            entity.Property(e => e.Periodo).HasColumnType("date");
        });

        modelBuilder.Entity<Cdni>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CDNI", "int");

            entity.Property(e => e.CodAreaFijo1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COD_AREA_FIJO_1");
            entity.Property(e => e.CodAreaMovil1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COD_AREA_MOVIL_1");
            entity.Property(e => e.EmailBip)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EMAIL_BIP");
            entity.Property(e => e.EmailCdni)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EMAIL_CDNI");
            entity.Property(e => e.FecAltaEmailBip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FEC_ALTA_EMAIL_BIP");
            entity.Property(e => e.FecCdniAlta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FEC_CDNI_ALTA");
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.FlaCdni)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FLA_CDNI");
            entity.Property(e => e.FlagCdniComercios).HasColumnName("flag_cdni_comercios");
            entity.Property(e => e.FlagClienteCdni).HasColumnName("flag_cliente_cdni");
            entity.Property(e => e.IdDCliente).HasColumnName("ID_D_CLIENTE");
            entity.Property(e => e.NumCuit).HasColumnName("num_cuit");
            entity.Property(e => e.NumTelefonoFijo1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NUM_TELEFONO_FIJO_1");
            entity.Property(e => e.NumTelefonoMovil1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NUM_TELEFONO_MOVIL_1");
        });

        modelBuilder.Entity<CdniBip>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CdniBip");

            entity.Property(e => e.CodAreaFijo1).HasColumnName("COD_AREA_FIJO_1");
            entity.Property(e => e.CodAreaMovil1).HasColumnName("COD_AREA_MOVIL_1");
            entity.Property(e => e.EmailBip)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EMAIL_BIP");
            entity.Property(e => e.EmailCdni)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EMAIL_CDNI");
            entity.Property(e => e.FecAltaEmailBip)
                .HasColumnType("date")
                .HasColumnName("FEC_ALTA_EMAIL_BIP");
            entity.Property(e => e.FecCdniAlta)
                .HasColumnType("date")
                .HasColumnName("FEC_CDNI_ALTA");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.FlaCdni)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FLA_CDNI");
            entity.Property(e => e.IdCdniBip)
                .ValueGeneratedOnAdd()
                .HasColumnName("idCdniBip");
            entity.Property(e => e.IdDCliente).HasColumnName("ID_D_CLIENTE");
            entity.Property(e => e.NumTelefonoFijo1).HasColumnName("NUM_TELEFONO_FIJO_1");
            entity.Property(e => e.NumTelefonoMovil1).HasColumnName("NUM_TELEFONO_MOVIL_1");
        });

        modelBuilder.Entity<ConnectionBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ConnectionBase", "crm");

            entity.HasIndex(e => new { e.Record2Id, e.Record1Id }, "ConnectionBase-20210118-IDX");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EffectiveEnd).HasColumnType("datetime");
            entity.Property(e => e.EffectiveStart).HasColumnType("datetime");
            entity.Property(e => e.ExchangeRate).HasColumnType("numeric(23, 10)");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Record1IdName).HasMaxLength(4000);
            entity.Property(e => e.Record2IdName).HasMaxLength(4000);
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<ConnectionRole>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ConnectionRole", "crm");

            entity.HasIndex(e => e.ConnectionRoleId, "ConnectionRole-20210123-IDX");

            entity.Property(e => e.CreatedByName).HasMaxLength(200);
            entity.Property(e => e.CreatedByYomiName).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreatedOnBehalfByName).HasMaxLength(200);
            entity.Property(e => e.CreatedOnBehalfByYomiName).HasMaxLength(200);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.IntroducedVersion).HasMaxLength(48);
            entity.Property(e => e.ModifiedByName).HasMaxLength(200);
            entity.Property(e => e.ModifiedByYomiName).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOnBehalfByName).HasMaxLength(200);
            entity.Property(e => e.ModifiedOnBehalfByYomiName).HasMaxLength(200);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.OrganizationIdName).HasMaxLength(160);
            entity.Property(e => e.OverwriteTime).HasColumnType("datetime");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<ContactBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ContactBase", "crm");

            entity.HasIndex(e => e.ContactId, "ClusteredIndex-20201002-ContactBase")
                .IsUnique()
                .IsClustered();

            entity.HasIndex(e => e.PnetDocumentNumber, "NonClusteredIndex-20201002-ContactBase1");

            entity.HasIndex(e => e.PnetTaxDocumentNumber, "idx_ext_ContactBase_01");

            entity.Property(e => e.Aging30).HasColumnType("money");
            entity.Property(e => e.Aging30Base)
                .HasColumnType("money")
                .HasColumnName("Aging30_Base");
            entity.Property(e => e.Aging60).HasColumnType("money");
            entity.Property(e => e.Aging60Base)
                .HasColumnType("money")
                .HasColumnName("Aging60_Base");
            entity.Property(e => e.Aging90).HasColumnType("money");
            entity.Property(e => e.Aging90Base)
                .HasColumnType("money")
                .HasColumnName("Aging90_Base");
            entity.Property(e => e.Anniversary).HasColumnType("datetime");
            entity.Property(e => e.AnnualIncome).HasColumnType("money");
            entity.Property(e => e.AnnualIncomeBase)
                .HasColumnType("money")
                .HasColumnName("AnnualIncome_Base");
            entity.Property(e => e.AssistantName).HasMaxLength(100);
            entity.Property(e => e.AssistantPhone).HasMaxLength(50);
            entity.Property(e => e.AxxonClienteinterno).HasColumnName("axxon_clienteinterno");
            entity.Property(e => e.BirthDate).HasColumnType("datetime");
            entity.Property(e => e.Business2).HasMaxLength(50);
            entity.Property(e => e.Callback).HasMaxLength(50);
            entity.Property(e => e.ChildrensNames).HasMaxLength(255);
            entity.Property(e => e.Company).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreditLimit).HasColumnType("money");
            entity.Property(e => e.CreditLimitBase)
                .HasColumnType("money")
                .HasColumnName("CreditLimit_Base");
            entity.Property(e => e.Department).HasMaxLength(100);
            entity.Property(e => e.DoNotBulkEmail).HasColumnName("DoNotBulkEMail");
            entity.Property(e => e.DoNotEmail).HasColumnName("DoNotEMail");
            entity.Property(e => e.DoNotSendMm).HasColumnName("DoNotSendMM");
            entity.Property(e => e.EmailAddress1)
                .HasMaxLength(100)
                .HasColumnName("EMailAddress1");
            entity.Property(e => e.EmailAddress2)
                .HasMaxLength(100)
                .HasColumnName("EMailAddress2");
            entity.Property(e => e.EmailAddress3)
                .HasMaxLength(100)
                .HasColumnName("EMailAddress3");
            entity.Property(e => e.EmployeeId).HasMaxLength(50);
            entity.Property(e => e.ExchangeRate).HasColumnType("numeric(23, 10)");
            entity.Property(e => e.ExternalUserIdentifier).HasMaxLength(50);
            entity.Property(e => e.Fax).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(69);
            entity.Property(e => e.FtpSiteUrl).HasMaxLength(200);
            entity.Property(e => e.FullName).HasMaxLength(160);
            entity.Property(e => e.GovernmentId).HasMaxLength(50);
            entity.Property(e => e.Home2).HasMaxLength(50);
            entity.Property(e => e.JobTitle).HasMaxLength(100);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.LastOnHoldTime).HasColumnType("datetime");
            entity.Property(e => e.LastUsedInCampaign).HasColumnType("datetime");
            entity.Property(e => e.ManagerName).HasMaxLength(100);
            entity.Property(e => e.ManagerPhone).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.MobilePhone).HasMaxLength(53);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.NickName).HasMaxLength(50);
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Pager).HasMaxLength(50);
            entity.Property(e => e.ParentCustomerIdName).HasMaxLength(4000);
            entity.Property(e => e.ParentCustomerIdYomiName).HasMaxLength(4000);
            entity.Property(e => e.PnetAddress)
                .HasMaxLength(250)
                .HasColumnName("pnet_Address");
            entity.Property(e => e.PnetAddressCreation).HasColumnName("pnet_AddressCreation");
            entity.Property(e => e.PnetAddressNumber).HasColumnName("pnet_AddressNumber");
            entity.Property(e => e.PnetAreaCode1)
                .HasMaxLength(7)
                .HasColumnName("pnet_AreaCode1");
            entity.Property(e => e.PnetAreaCode2)
                .HasMaxLength(7)
                .HasColumnName("pnet_AreaCode2");
            entity.Property(e => e.PnetAreaCode3)
                .HasMaxLength(7)
                .HasColumnName("pnet_AreaCode3");
            entity.Property(e => e.PnetAreaCode4)
                .HasMaxLength(7)
                .HasColumnName("pnet_AreaCode4");
            entity.Property(e => e.PnetBadFinancialBehavior).HasColumnName("pnet_BadFinancialBehavior");
            entity.Property(e => e.PnetBetweenStreets)
                .HasMaxLength(100)
                .HasColumnName("pnet_BetweenStreets");
            entity.Property(e => e.PnetBipcontact).HasColumnName("pnet_BIPContact");
            entity.Property(e => e.PnetBlock)
                .HasMaxLength(20)
                .HasColumnName("pnet_Block");
            entity.Property(e => e.PnetBody)
                .HasMaxLength(20)
                .HasColumnName("pnet_Body");
            entity.Property(e => e.PnetBp730creation)
                .HasColumnType("datetime")
                .HasColumnName("pnet_BP730Creation");
            entity.Property(e => e.PnetBp730printed).HasColumnName("pnet_BP730Printed");
            entity.Property(e => e.PnetBp88Barcode)
                .HasMaxLength(500)
                .HasColumnName("pnet_bp88_barcode");
            entity.Property(e => e.PnetBpbaAddressDepartment)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBA_AddressDepartment");
            entity.Property(e => e.PnetBpbaAddressFlat)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBA_AddressFlat");
            entity.Property(e => e.PnetBpbaAddressNumber)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBA_AddressNumber");
            entity.Property(e => e.PnetBpbaAddressPostalCode)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBA_AddressPostalCode");
            entity.Property(e => e.PnetBpbaAddressProvince)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBA_AddressProvince");
            entity.Property(e => e.PnetBpbaAddressStreet)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBA_AddressStreet");
            entity.Property(e => e.PnetBpbaDocumentNumber)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBA_DocumentNumber");
            entity.Property(e => e.PnetBpbaDocumentType)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBA_DocumentType");
            entity.Property(e => e.PnetBpbaEconomicActivityCode)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBA_EconomicActivityCode");
            entity.Property(e => e.PnetBpbaFiscalIdNumber)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBA_FiscalIdNumber");
            entity.Property(e => e.PnetBpbaFiscalIdNumberType)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBA_FiscalIdNumberType");
            entity.Property(e => e.PnetBpbaOfficeInCharge)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBA_OfficeInCharge");
            entity.Property(e => e.PnetBpbaPersonClasification)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBA_PersonClasification");
            entity.Property(e => e.PnetBpbaPersonInternalNumber)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBA_PersonInternalNumber");
            entity.Property(e => e.PnetBpbaPersonSocialName)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBA_PersonSocialName");
            entity.Property(e => e.PnetBpbaproducts).HasColumnName("pnet_BPBAProducts");
            entity.Property(e => e.PnetBpbateamId).HasColumnName("pnet_BPBATeamId");
            entity.Property(e => e.PnetCellPhone)
                .HasMaxLength(400)
                .HasColumnName("pnet_CellPhone");
            entity.Property(e => e.PnetChangeStatusDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_ChangeStatusDate");
            entity.Property(e => e.PnetCiudadano).HasColumnName("pnet_Ciudadano");
            entity.Property(e => e.PnetCnaeval).HasColumnName("pnet_CNAEVal");
            entity.Property(e => e.PnetCnaevalue).HasColumnName("pnet_CNAEValue");
            entity.Property(e => e.PnetCodeStatusOld).HasColumnName("pnet_CodeStatusOld");
            entity.Property(e => e.PnetCodeSubStatusOld).HasColumnName("pnet_CodeSubStatusOld");
            entity.Property(e => e.PnetCodigoSituacion).HasColumnName("pnet_CodigoSituacion");
            entity.Property(e => e.PnetCollectionSourcesValidated).HasColumnName("pnet_CollectionSourcesValidated");
            entity.Property(e => e.PnetComment).HasColumnName("pnet_Comment");
            entity.Property(e => e.PnetCommercialExecutiveAdministratorId).HasColumnName("pnet_CommercialExecutiveAdministratorId");
            entity.Property(e => e.PnetCommercialaction).HasColumnName("pnet_Commercialaction");
            entity.Property(e => e.PnetCommercialactiondescription)
                .HasMaxLength(400)
                .HasColumnName("pnet_Commercialactiondescription");
            entity.Property(e => e.PnetConsolidatePhone1)
                .HasMaxLength(100)
                .HasColumnName("pnet_ConsolidatePhone1");
            entity.Property(e => e.PnetConsolidatePhone2)
                .HasMaxLength(100)
                .HasColumnName("pnet_ConsolidatePhone2");
            entity.Property(e => e.PnetConsolidatePhone3)
                .HasMaxLength(100)
                .HasColumnName("pnet_ConsolidatePhone3");
            entity.Property(e => e.PnetConsolidatePhone4)
                .HasMaxLength(100)
                .HasColumnName("pnet_ConsolidatePhone4");
            entity.Property(e => e.PnetConsolidatedBankPhone)
                .HasMaxLength(100)
                .HasColumnName("pnet_ConsolidatedBankPhone");
            entity.Property(e => e.PnetContractInternalNumber)
                .HasMaxLength(100)
                .HasColumnName("pnet_ContractInternalNumber");
            entity.Property(e => e.PnetCorner)
                .HasMaxLength(100)
                .HasColumnName("pnet_Corner");
            entity.Property(e => e.PnetCountryofbirth).HasColumnName("pnet_Countryofbirth");
            entity.Property(e => e.PnetCprincipalApplication).HasColumnName("pnet_CPrincipalApplication");
            entity.Property(e => e.PnetCustomerExcepted).HasColumnName("pnet_CustomerExcepted");
            entity.Property(e => e.PnetCustomerScore).HasColumnName("pnet_CustomerScore");
            entity.Property(e => e.PnetDeceasedDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_DeceasedDate");
            entity.Property(e => e.PnetDeceasedRegistrationDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_DeceasedRegistrationDate");
            entity.Property(e => e.PnetDeceasedRegistrationName)
                .HasMaxLength(100)
                .HasColumnName("pnet_DeceasedRegistrationName");
            entity.Property(e => e.PnetDepartment)
                .HasMaxLength(3)
                .HasColumnName("pnet_Department");
            entity.Property(e => e.PnetDeseasedCustomer).HasColumnName("pnet_DeseasedCustomer");
            entity.Property(e => e.PnetDiplomaticoProfesorEstudianteDeportistaEu).HasColumnName("pnet_DiplomaticoProfesorEstudianteDeportistaEU");
            entity.Property(e => e.PnetDistrictLocalityId).HasColumnName("pnet_DistrictLocalityId");
            entity.Property(e => e.PnetDobleNacionalidad).HasColumnName("pnet_DobleNacionalidad");
            entity.Property(e => e.PnetDocumentNumber).HasColumnName("pnet_DocumentNumber");
            entity.Property(e => e.PnetDocumentType).HasColumnName("pnet_DocumentType");
            entity.Property(e => e.PnetDocumentTypeValue)
                .HasMaxLength(100)
                .HasColumnName("pnet_DocumentTypeValue");
            entity.Property(e => e.PnetDwelling).HasColumnName("pnet_Dwelling");
            entity.Property(e => e.PnetEstimatedAmount).HasColumnName("pnet_EstimatedAmount");
            entity.Property(e => e.PnetExtraDetails)
                .HasMaxLength(40)
                .HasColumnName("pnet_ExtraDetails");
            entity.Property(e => e.PnetFacebook).HasColumnName("pnet_Facebook");
            entity.Property(e => e.PnetFatcasituation).HasColumnName("pnet_FATCASituation");
            entity.Property(e => e.PnetFateCredit)
                .HasMaxLength(100)
                .HasColumnName("pnet_FateCredit");
            entity.Property(e => e.PnetFatherName)
                .HasMaxLength(100)
                .HasColumnName("pnet_FatherName");
            entity.Property(e => e.PnetFechaFinVigencia)
                .HasColumnType("datetime")
                .HasColumnName("pnet_FechaFinVigencia");
            entity.Property(e => e.PnetFee).HasColumnName("pnet_Fee");
            entity.Property(e => e.PnetFloor)
                .HasMaxLength(3)
                .HasColumnName("pnet_Floor");
            entity.Property(e => e.PnetFollowSocialNetworks).HasColumnName("pnet_FollowSocialNetworks");
            entity.Property(e => e.PnetFrecuenteEnEeuu).HasColumnName("pnet_FrecuenteEnEEUU");
            entity.Property(e => e.PnetGetSegOrConv).HasColumnName("pnet_GetSegOrConv");
            entity.Property(e => e.PnetHasCommunityWork).HasColumnName("pnet_HasCommunityWork");
            entity.Property(e => e.PnetHaveAccountOtherBank).HasColumnName("pnet_HaveAccountOtherBank");
            entity.Property(e => e.PnetHaveCreditCard).HasColumnName("pnet_HaveCreditCard");
            entity.Property(e => e.PnetHaveCredits).HasColumnName("pnet_HaveCredits");
            entity.Property(e => e.PnetHaveInsurance).HasColumnName("pnet_HaveInsurance");
            entity.Property(e => e.PnetHaveProductsBp).HasColumnName("pnet_HaveProductsBP");
            entity.Property(e => e.PnetHistoricalObservations).HasColumnName("pnet_HistoricalObservations");
            entity.Property(e => e.PnetInterestRate).HasColumnName("pnet_InterestRate");
            entity.Property(e => e.PnetInternationalData).HasColumnName("pnet_InternationalData");
            entity.Property(e => e.PnetJsonError).HasColumnName("pnet_JsonError");
            entity.Property(e => e.PnetJsonResult).HasColumnName("pnet_JsonResult");
            entity.Property(e => e.PnetLevelEducation).HasColumnName("pnet_LevelEducation");
            entity.Property(e => e.PnetLinkage).HasColumnName("pnet_Linkage");
            entity.Property(e => e.PnetLocal)
                .HasMaxLength(20)
                .HasColumnName("pnet_Local");
            entity.Property(e => e.PnetLocationBirth)
                .HasMaxLength(250)
                .HasColumnName("pnet_LocationBirth");
            entity.Property(e => e.PnetLot)
                .HasMaxLength(20)
                .HasColumnName("pnet_Lot");
            entity.Property(e => e.PnetMeansCommunication).HasColumnName("pnet_MeansCommunication");
            entity.Property(e => e.PnetMecreated).HasColumnName("pnet_MECreated");
            entity.Property(e => e.PnetMenameId).HasColumnName("pnet_MENameId");
            entity.Property(e => e.PnetMobilePhone)
                .HasMaxLength(400)
                .HasColumnName("pnet_MobilePhone");
            entity.Property(e => e.PnetModel).HasColumnName("pnet_Model");
            entity.Property(e => e.PnetMotherName)
                .HasMaxLength(100)
                .HasColumnName("pnet_MotherName");
            entity.Property(e => e.PnetNacionalidadFiscal)
                .HasMaxLength(100)
                .HasColumnName("pnet_NacionalidadFiscal");
            entity.Property(e => e.PnetNameGenerator)
                .HasMaxLength(335)
                .HasColumnName("pnet_Name_Generator");
            entity.Property(e => e.PnetNationality)
                .HasMaxLength(250)
                .HasColumnName("pnet_Nationality");
            entity.Property(e => e.PnetNationalityCountry).HasColumnName("pnet_NationalityCountry");
            entity.Property(e => e.PnetNationalityId).HasColumnName("pnet_NationalityId");
            entity.Property(e => e.PnetNationalityInformed).HasColumnName("pnet_NationalityInformed");
            entity.Property(e => e.PnetNationalityList).HasColumnName("pnet_NationalityList");
            entity.Property(e => e.PnetNeighborhood)
                .HasMaxLength(100)
                .HasColumnName("pnet_Neighborhood");
            entity.Property(e => e.PnetNic).HasColumnName("pnet_NIC");
            entity.Property(e => e.PnetNumberChildren).HasColumnName("pnet_NumberChildren");
            entity.Property(e => e.PnetNumeroDocumentoFiscalExtranjero)
                .HasMaxLength(100)
                .HasColumnName("pnet_NumeroDocumentoFiscalExtranjero");
            entity.Property(e => e.PnetObservationAddress).HasColumnName("pnet_ObservationAddress");
            entity.Property(e => e.PnetOccupation).HasColumnName("pnet_Occupation");
            entity.Property(e => e.PnetOperativeContractIdentification)
                .HasMaxLength(100)
                .HasColumnName("pnet_OperativeContractIdentification");
            entity.Property(e => e.PnetOrdenesTransferenciaPeriodicaCuentasEeuu).HasColumnName("pnet_OrdenesTransferenciaPeriodicaCuentasEEUU");
            entity.Property(e => e.PnetOthersIncomes).HasColumnName("pnet_OthersIncomes");
            entity.Property(e => e.PnetOwnerVehicle).HasColumnName("pnet_OwnerVehicle");
            entity.Property(e => e.PnetPadreMadreEstadounidense).HasColumnName("pnet_PadreMadreEstadounidense");
            entity.Property(e => e.PnetPasaporteNorteamericano).HasColumnName("pnet_PasaporteNorteamericano");
            entity.Property(e => e.PnetPep).HasColumnName("pnet_pep");
            entity.Property(e => e.PnetPepreason)
                .HasMaxLength(100)
                .HasColumnName("pnet_PEPReason");
            entity.Property(e => e.PnetPersonsHousehold).HasColumnName("pnet_PersonsHousehold");
            entity.Property(e => e.PnetPhone1)
                .HasMaxLength(100)
                .HasColumnName("pnet_Phone1");
            entity.Property(e => e.PnetPhone2)
                .HasMaxLength(100)
                .HasColumnName("pnet_Phone2");
            entity.Property(e => e.PnetPhone3)
                .HasMaxLength(100)
                .HasColumnName("pnet_Phone3");
            entity.Property(e => e.PnetPhone4)
                .HasMaxLength(100)
                .HasColumnName("pnet_Phone4");
            entity.Property(e => e.PnetPhoneCallId).HasColumnName("pnet_PhoneCallId");
            entity.Property(e => e.PnetPhoneCreation).HasColumnName("pnet_PhoneCreation");
            entity.Property(e => e.PnetPhoneType1).HasColumnName("pnet_PhoneType1");
            entity.Property(e => e.PnetPhoneType2).HasColumnName("pnet_PhoneType2");
            entity.Property(e => e.PnetPhoneType3).HasColumnName("pnet_PhoneType3");
            entity.Property(e => e.PnetPhoneType4).HasColumnName("pnet_PhoneType4");
            entity.Property(e => e.PnetPhones)
                .HasMaxLength(400)
                .HasColumnName("pnet_Phones");
            entity.Property(e => e.PnetPorcentajeExcencion)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_PorcentajeExcencion");
            entity.Property(e => e.PnetPoseeCuentaConjuntaFatca).HasColumnName("pnet_PoseeCuentaConjuntaFATCA");
            entity.Property(e => e.PnetPreApprovedAmount).HasColumnName("pnet_PreApprovedAmount");
            entity.Property(e => e.PnetPreApprovedClassification).HasColumnName("pnet_PreApprovedClassification");
            entity.Property(e => e.PnetPreApprovedQuota).HasColumnName("pnet_PreApprovedQuota");
            entity.Property(e => e.PnetPreferredMethodChannel).HasColumnName("pnet_PreferredMethodChannel");
            entity.Property(e => e.PnetPremiumCustomer).HasColumnName("pnet_PremiumCustomer");
            entity.Property(e => e.PnetPrimerNacionalidad)
                .HasMaxLength(100)
                .HasColumnName("pnet_PrimerNacionalidad");
            entity.Property(e => e.PnetPrincipalApplication)
                .HasMaxLength(100)
                .HasColumnName("pnet_PrincipalApplication");
            entity.Property(e => e.PnetPrincipalApplicationPreAp).HasColumnName("pnet_PrincipalApplicationPreAp");
            entity.Property(e => e.PnetProductsService).HasColumnName("pnet_ProductsService");
            entity.Property(e => e.PnetPuccreatedon)
                .HasColumnType("datetime")
                .HasColumnName("pnet_PUCCreatedon");
            entity.Property(e => e.PnetRecommendedBusinessId).HasColumnName("pnet_RecommendedBusinessId");
            entity.Property(e => e.PnetRecommendedById).HasColumnName("pnet_RecommendedById");
            entity.Property(e => e.PnetRegistrationDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_RegistrationDate");
            entity.Property(e => e.PnetRelacionadoConCorporaciones).HasColumnName("pnet_RelacionadoConCorporaciones");
            entity.Property(e => e.PnetRenovationNumber).HasColumnName("pnet_RenovationNumber");
            entity.Property(e => e.PnetRentalValue).HasColumnName("pnet_RentalValue");
            entity.Property(e => e.PnetRenunciaNacionalidadEeuu).HasColumnName("pnet_RenunciaNacionalidadEEUU");
            entity.Property(e => e.PnetResidente).HasColumnName("pnet_Residente");
            entity.Property(e => e.PnetSegundaNacionalidad)
                .HasMaxLength(100)
                .HasColumnName("pnet_SegundaNacionalidad");
            entity.Property(e => e.PnetSeleccionadoFatca).HasColumnName("pnet_SeleccionadoFATCA");
            entity.Property(e => e.PnetSeleccionadoOcde).HasColumnName("pnet_SeleccionadoOCDE");
            entity.Property(e => e.PnetSoi).HasColumnName("pnet_Soi");
            entity.Property(e => e.PnetSoiType).HasColumnName("pnet_SoiType");
            entity.Property(e => e.PnetSource)
                .HasMaxLength(80)
                .HasColumnName("pnet_Source");
            entity.Property(e => e.PnetStatus).HasColumnName("pnet_Status");
            entity.Property(e => e.PnetSubStatus).HasColumnName("pnet_SubStatus");
            entity.Property(e => e.PnetSubsidaryNumber)
                .HasMaxLength(100)
                .HasColumnName("pnet_SubsidaryNumber");
            entity.Property(e => e.PnetSubsidiaryCode).HasColumnName("pnet_SubsidiaryCode");
            entity.Property(e => e.PnetSubsidiaryId).HasColumnName("pnet_SubsidiaryId");
            entity.Property(e => e.PnetSuscribioPoderNotarial).HasColumnName("pnet_SuscribioPoderNotarial");
            entity.Property(e => e.PnetSwernDeclaration).HasColumnName("pnet_SwernDeclaration");
            entity.Property(e => e.PnetTaxDocumentNumber).HasColumnName("pnet_TaxDocumentNumber");
            entity.Property(e => e.PnetTaxDocumentNumber2).HasColumnName("pnet_TaxDocumentNumber2");
            entity.Property(e => e.PnetTaxDocumentNumber3).HasColumnName("pnet_TaxDocumentNumber3");
            entity.Property(e => e.PnetTaxDocumentType).HasColumnName("pnet_TaxDocumentType");
            entity.Property(e => e.PnetTaxGciascategory).HasColumnName("pnet_TaxGCIASCategory");
            entity.Property(e => e.PnetTaxIibbcategory).HasColumnName("pnet_TaxIIBBCategory");
            entity.Property(e => e.PnetTaxIvacategory).HasColumnName("pnet_TaxIVACategory");
            entity.Property(e => e.PnetTelephones).HasColumnName("pnet_Telephones");
            entity.Property(e => e.PnetTipoDocumentoFiscalExtranjero).HasColumnName("pnet_TipoDocumentoFiscalExtranjero");
            entity.Property(e => e.PnetTipoImpuesto).HasColumnName("pnet_TipoImpuesto");
            entity.Property(e => e.PnetTower)
                .HasMaxLength(20)
                .HasColumnName("pnet_Tower");
            entity.Property(e => e.PnetTypeBank).HasColumnName("pnet_TypeBank");
            entity.Property(e => e.PnetTypeCredit)
                .HasMaxLength(100)
                .HasColumnName("pnet_TypeCredit");
            entity.Property(e => e.PnetTypeCreditCard).HasColumnName("pnet_TypeCreditCard");
            entity.Property(e => e.PnetTypeIncomes)
                .HasMaxLength(150)
                .HasColumnName("pnet_TypeIncomes");
            entity.Property(e => e.PnetTypeInsurance)
                .HasMaxLength(100)
                .HasColumnName("pnet_TypeInsurance");
            entity.Property(e => e.PnetTypeProductsBp)
                .HasMaxLength(150)
                .HasColumnName("pnet_TypeProductsBP");
            entity.Property(e => e.PnetUifconstancy).HasColumnName("pnet_UIFConstancy");
            entity.Property(e => e.PnetUltimaofertavalorid).HasColumnName("pnet_ultimaofertavalorid");
            entity.Property(e => e.PnetUrlGetClientsByDni)
                .HasMaxLength(200)
                .HasColumnName("pnet_URL_GetClientsByDni");
            entity.Property(e => e.PnetUrlGetDateTime)
                .HasMaxLength(200)
                .HasColumnName("pnet_URL_GetDateTime");
            entity.Property(e => e.PnetUrlGetProductsByNip)
                .HasMaxLength(200)
                .HasColumnName("pnet_URL_GetProductsByNIP");
            entity.Property(e => e.PnetUrlGetProductsFormattedByNip)
                .HasMaxLength(200)
                .HasColumnName("pnet_URL_GetProductsFormattedByNip");
            entity.Property(e => e.PnetUrlGetRealAddressByNip)
                .HasMaxLength(200)
                .HasColumnName("pnet_URL_GetRealAddressByNip");
            entity.Property(e => e.Salutation).HasMaxLength(100);
            entity.Property(e => e.Slaid).HasColumnName("SLAId");
            entity.Property(e => e.SlainvokedId).HasColumnName("SLAInvokedId");
            entity.Property(e => e.SpousesName).HasMaxLength(100);
            entity.Property(e => e.Suffix).HasMaxLength(10);
            entity.Property(e => e.Telephone1).HasMaxLength(50);
            entity.Property(e => e.Telephone2).HasMaxLength(50);
            entity.Property(e => e.Telephone3).HasMaxLength(50);
            entity.Property(e => e.TimeSpentByMeOnEmailAndMeetings).HasMaxLength(1250);
            entity.Property(e => e.TraversedPath).HasMaxLength(1250);
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.WebSiteUrl).HasMaxLength(200);
            entity.Property(e => e.YomiFirstName).HasMaxLength(150);
            entity.Property(e => e.YomiFullName).HasMaxLength(450);
            entity.Property(e => e.YomiLastName).HasMaxLength(150);
            entity.Property(e => e.YomiMiddleName).HasMaxLength(150);
            entity.Property(e => e.ZennonbiActualscore)
                .HasMaxLength(50)
                .HasColumnName("zennonbi_actualscore");
        });

        modelBuilder.Entity<ContactBase1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ContactBase", "int");

            entity.Property(e => e.Aging30).HasColumnType("money");
            entity.Property(e => e.Aging30Base)
                .HasColumnType("money")
                .HasColumnName("Aging30_Base");
            entity.Property(e => e.Aging60).HasColumnType("money");
            entity.Property(e => e.Aging60Base)
                .HasColumnType("money")
                .HasColumnName("Aging60_Base");
            entity.Property(e => e.Aging90).HasColumnType("money");
            entity.Property(e => e.Aging90Base)
                .HasColumnType("money")
                .HasColumnName("Aging90_Base");
            entity.Property(e => e.Anniversary).HasColumnType("datetime");
            entity.Property(e => e.AnnualIncome).HasColumnType("money");
            entity.Property(e => e.AnnualIncomeBase)
                .HasColumnType("money")
                .HasColumnName("AnnualIncome_Base");
            entity.Property(e => e.AssistantName).HasMaxLength(100);
            entity.Property(e => e.AssistantPhone).HasMaxLength(50);
            entity.Property(e => e.AxxonClienteinterno).HasColumnName("axxon_clienteinterno");
            entity.Property(e => e.BirthDate).HasColumnType("datetime");
            entity.Property(e => e.Business2).HasMaxLength(50);
            entity.Property(e => e.Callback).HasMaxLength(50);
            entity.Property(e => e.ChildrensNames).HasMaxLength(255);
            entity.Property(e => e.Company).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreditLimit).HasColumnType("money");
            entity.Property(e => e.CreditLimitBase)
                .HasColumnType("money")
                .HasColumnName("CreditLimit_Base");
            entity.Property(e => e.Department).HasMaxLength(100);
            entity.Property(e => e.DoNotBulkEmail).HasColumnName("DoNotBulkEMail");
            entity.Property(e => e.DoNotEmail).HasColumnName("DoNotEMail");
            entity.Property(e => e.DoNotSendMm).HasColumnName("DoNotSendMM");
            entity.Property(e => e.EmailAddress1)
                .HasMaxLength(100)
                .HasColumnName("EMailAddress1");
            entity.Property(e => e.EmailAddress2)
                .HasMaxLength(100)
                .HasColumnName("EMailAddress2");
            entity.Property(e => e.EmailAddress3)
                .HasMaxLength(100)
                .HasColumnName("EMailAddress3");
            entity.Property(e => e.EmployeeId).HasMaxLength(50);
            entity.Property(e => e.ExchangeRate).HasColumnType("numeric(23, 10)");
            entity.Property(e => e.ExternalUserIdentifier).HasMaxLength(50);
            entity.Property(e => e.Fax).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(69);
            entity.Property(e => e.FtpSiteUrl).HasMaxLength(200);
            entity.Property(e => e.FullName).HasMaxLength(160);
            entity.Property(e => e.GovernmentId).HasMaxLength(50);
            entity.Property(e => e.Home2).HasMaxLength(50);
            entity.Property(e => e.JobTitle).HasMaxLength(100);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.LastOnHoldTime).HasColumnType("datetime");
            entity.Property(e => e.LastUsedInCampaign).HasColumnType("datetime");
            entity.Property(e => e.ManagerName).HasMaxLength(100);
            entity.Property(e => e.ManagerPhone).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.MobilePhone).HasMaxLength(53);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.NickName).HasMaxLength(50);
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Pager).HasMaxLength(50);
            entity.Property(e => e.ParentCustomerIdName).HasMaxLength(4000);
            entity.Property(e => e.ParentCustomerIdYomiName).HasMaxLength(4000);
            entity.Property(e => e.PnetAddress)
                .HasMaxLength(250)
                .HasColumnName("pnet_Address");
            entity.Property(e => e.PnetAddressCreation).HasColumnName("pnet_AddressCreation");
            entity.Property(e => e.PnetAddressNumber).HasColumnName("pnet_AddressNumber");
            entity.Property(e => e.PnetAreaCode1)
                .HasMaxLength(7)
                .HasColumnName("pnet_AreaCode1");
            entity.Property(e => e.PnetAreaCode2)
                .HasMaxLength(7)
                .HasColumnName("pnet_AreaCode2");
            entity.Property(e => e.PnetAreaCode3)
                .HasMaxLength(7)
                .HasColumnName("pnet_AreaCode3");
            entity.Property(e => e.PnetAreaCode4)
                .HasMaxLength(7)
                .HasColumnName("pnet_AreaCode4");
            entity.Property(e => e.PnetBadFinancialBehavior).HasColumnName("pnet_BadFinancialBehavior");
            entity.Property(e => e.PnetBetweenStreets)
                .HasMaxLength(100)
                .HasColumnName("pnet_BetweenStreets");
            entity.Property(e => e.PnetBipcontact).HasColumnName("pnet_BIPContact");
            entity.Property(e => e.PnetBlock)
                .HasMaxLength(20)
                .HasColumnName("pnet_Block");
            entity.Property(e => e.PnetBody)
                .HasMaxLength(20)
                .HasColumnName("pnet_Body");
            entity.Property(e => e.PnetBp730creation)
                .HasColumnType("datetime")
                .HasColumnName("pnet_BP730Creation");
            entity.Property(e => e.PnetBp730printed).HasColumnName("pnet_BP730Printed");
            entity.Property(e => e.PnetBp88Barcode)
                .HasMaxLength(500)
                .HasColumnName("pnet_bp88_barcode");
            entity.Property(e => e.PnetBpbaAddressDepartment)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBA_AddressDepartment");
            entity.Property(e => e.PnetBpbaAddressFlat)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBA_AddressFlat");
            entity.Property(e => e.PnetBpbaAddressNumber)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBA_AddressNumber");
            entity.Property(e => e.PnetBpbaAddressPostalCode)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBA_AddressPostalCode");
            entity.Property(e => e.PnetBpbaAddressProvince)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBA_AddressProvince");
            entity.Property(e => e.PnetBpbaAddressStreet)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBA_AddressStreet");
            entity.Property(e => e.PnetBpbaDocumentNumber)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBA_DocumentNumber");
            entity.Property(e => e.PnetBpbaDocumentType)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBA_DocumentType");
            entity.Property(e => e.PnetBpbaEconomicActivityCode)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBA_EconomicActivityCode");
            entity.Property(e => e.PnetBpbaFiscalIdNumber)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBA_FiscalIdNumber");
            entity.Property(e => e.PnetBpbaFiscalIdNumberType)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBA_FiscalIdNumberType");
            entity.Property(e => e.PnetBpbaOfficeInCharge)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBA_OfficeInCharge");
            entity.Property(e => e.PnetBpbaPersonClasification)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBA_PersonClasification");
            entity.Property(e => e.PnetBpbaPersonInternalNumber)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBA_PersonInternalNumber");
            entity.Property(e => e.PnetBpbaPersonSocialName)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBA_PersonSocialName");
            entity.Property(e => e.PnetBpbaproducts).HasColumnName("pnet_BPBAProducts");
            entity.Property(e => e.PnetBpbateamId).HasColumnName("pnet_BPBATeamId");
            entity.Property(e => e.PnetCellPhone)
                .HasMaxLength(400)
                .HasColumnName("pnet_CellPhone");
            entity.Property(e => e.PnetChangeStatusDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_ChangeStatusDate");
            entity.Property(e => e.PnetCiudadano).HasColumnName("pnet_Ciudadano");
            entity.Property(e => e.PnetCnaeval).HasColumnName("pnet_CNAEVal");
            entity.Property(e => e.PnetCnaevalue).HasColumnName("pnet_CNAEValue");
            entity.Property(e => e.PnetCodeStatusOld).HasColumnName("pnet_CodeStatusOld");
            entity.Property(e => e.PnetCodeSubStatusOld).HasColumnName("pnet_CodeSubStatusOld");
            entity.Property(e => e.PnetCodigoSituacion).HasColumnName("pnet_CodigoSituacion");
            entity.Property(e => e.PnetCollectionSourcesValidated).HasColumnName("pnet_CollectionSourcesValidated");
            entity.Property(e => e.PnetComment).HasColumnName("pnet_Comment");
            entity.Property(e => e.PnetCommercialExecutiveAdministratorId).HasColumnName("pnet_CommercialExecutiveAdministratorId");
            entity.Property(e => e.PnetCommercialaction).HasColumnName("pnet_Commercialaction");
            entity.Property(e => e.PnetCommercialactiondescription)
                .HasMaxLength(400)
                .HasColumnName("pnet_Commercialactiondescription");
            entity.Property(e => e.PnetConsolidatePhone1)
                .HasMaxLength(100)
                .HasColumnName("pnet_ConsolidatePhone1");
            entity.Property(e => e.PnetConsolidatePhone2)
                .HasMaxLength(100)
                .HasColumnName("pnet_ConsolidatePhone2");
            entity.Property(e => e.PnetConsolidatePhone3)
                .HasMaxLength(100)
                .HasColumnName("pnet_ConsolidatePhone3");
            entity.Property(e => e.PnetConsolidatePhone4)
                .HasMaxLength(100)
                .HasColumnName("pnet_ConsolidatePhone4");
            entity.Property(e => e.PnetConsolidatedBankPhone)
                .HasMaxLength(100)
                .HasColumnName("pnet_ConsolidatedBankPhone");
            entity.Property(e => e.PnetContractInternalNumber)
                .HasMaxLength(100)
                .HasColumnName("pnet_ContractInternalNumber");
            entity.Property(e => e.PnetCorner)
                .HasMaxLength(100)
                .HasColumnName("pnet_Corner");
            entity.Property(e => e.PnetCountryofbirth).HasColumnName("pnet_Countryofbirth");
            entity.Property(e => e.PnetCprincipalApplication).HasColumnName("pnet_CPrincipalApplication");
            entity.Property(e => e.PnetCustomerExcepted).HasColumnName("pnet_CustomerExcepted");
            entity.Property(e => e.PnetCustomerScore).HasColumnName("pnet_CustomerScore");
            entity.Property(e => e.PnetDeceasedDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_DeceasedDate");
            entity.Property(e => e.PnetDeceasedRegistrationDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_DeceasedRegistrationDate");
            entity.Property(e => e.PnetDeceasedRegistrationName)
                .HasMaxLength(100)
                .HasColumnName("pnet_DeceasedRegistrationName");
            entity.Property(e => e.PnetDepartment)
                .HasMaxLength(3)
                .HasColumnName("pnet_Department");
            entity.Property(e => e.PnetDeseasedCustomer).HasColumnName("pnet_DeseasedCustomer");
            entity.Property(e => e.PnetDiplomaticoProfesorEstudianteDeportistaEu).HasColumnName("pnet_DiplomaticoProfesorEstudianteDeportistaEU");
            entity.Property(e => e.PnetDistrictLocalityId).HasColumnName("pnet_DistrictLocalityId");
            entity.Property(e => e.PnetDobleNacionalidad).HasColumnName("pnet_DobleNacionalidad");
            entity.Property(e => e.PnetDocumentNumber).HasColumnName("pnet_DocumentNumber");
            entity.Property(e => e.PnetDocumentType).HasColumnName("pnet_DocumentType");
            entity.Property(e => e.PnetDocumentTypeValue)
                .HasMaxLength(100)
                .HasColumnName("pnet_DocumentTypeValue");
            entity.Property(e => e.PnetDwelling).HasColumnName("pnet_Dwelling");
            entity.Property(e => e.PnetEstimatedAmount).HasColumnName("pnet_EstimatedAmount");
            entity.Property(e => e.PnetExtraDetails)
                .HasMaxLength(40)
                .HasColumnName("pnet_ExtraDetails");
            entity.Property(e => e.PnetFacebook).HasColumnName("pnet_Facebook");
            entity.Property(e => e.PnetFatcasituation).HasColumnName("pnet_FATCASituation");
            entity.Property(e => e.PnetFateCredit)
                .HasMaxLength(100)
                .HasColumnName("pnet_FateCredit");
            entity.Property(e => e.PnetFatherName)
                .HasMaxLength(100)
                .HasColumnName("pnet_FatherName");
            entity.Property(e => e.PnetFechaFinVigencia)
                .HasColumnType("datetime")
                .HasColumnName("pnet_FechaFinVigencia");
            entity.Property(e => e.PnetFee).HasColumnName("pnet_Fee");
            entity.Property(e => e.PnetFloor)
                .HasMaxLength(3)
                .HasColumnName("pnet_Floor");
            entity.Property(e => e.PnetFollowSocialNetworks).HasColumnName("pnet_FollowSocialNetworks");
            entity.Property(e => e.PnetFrecuenteEnEeuu).HasColumnName("pnet_FrecuenteEnEEUU");
            entity.Property(e => e.PnetGetSegOrConv).HasColumnName("pnet_GetSegOrConv");
            entity.Property(e => e.PnetHasCommunityWork).HasColumnName("pnet_HasCommunityWork");
            entity.Property(e => e.PnetHaveAccountOtherBank).HasColumnName("pnet_HaveAccountOtherBank");
            entity.Property(e => e.PnetHaveCreditCard).HasColumnName("pnet_HaveCreditCard");
            entity.Property(e => e.PnetHaveCredits).HasColumnName("pnet_HaveCredits");
            entity.Property(e => e.PnetHaveInsurance).HasColumnName("pnet_HaveInsurance");
            entity.Property(e => e.PnetHaveProductsBp).HasColumnName("pnet_HaveProductsBP");
            entity.Property(e => e.PnetHistoricalObservations).HasColumnName("pnet_HistoricalObservations");
            entity.Property(e => e.PnetInterestRate).HasColumnName("pnet_InterestRate");
            entity.Property(e => e.PnetInternationalData).HasColumnName("pnet_InternationalData");
            entity.Property(e => e.PnetJsonError).HasColumnName("pnet_JsonError");
            entity.Property(e => e.PnetJsonResult).HasColumnName("pnet_JsonResult");
            entity.Property(e => e.PnetLevelEducation).HasColumnName("pnet_LevelEducation");
            entity.Property(e => e.PnetLinkage).HasColumnName("pnet_Linkage");
            entity.Property(e => e.PnetLocal)
                .HasMaxLength(20)
                .HasColumnName("pnet_Local");
            entity.Property(e => e.PnetLocationBirth)
                .HasMaxLength(250)
                .HasColumnName("pnet_LocationBirth");
            entity.Property(e => e.PnetLot)
                .HasMaxLength(20)
                .HasColumnName("pnet_Lot");
            entity.Property(e => e.PnetMeansCommunication).HasColumnName("pnet_MeansCommunication");
            entity.Property(e => e.PnetMecreated).HasColumnName("pnet_MECreated");
            entity.Property(e => e.PnetMenameId).HasColumnName("pnet_MENameId");
            entity.Property(e => e.PnetMobilePhone)
                .HasMaxLength(400)
                .HasColumnName("pnet_MobilePhone");
            entity.Property(e => e.PnetModel).HasColumnName("pnet_Model");
            entity.Property(e => e.PnetMotherName)
                .HasMaxLength(100)
                .HasColumnName("pnet_MotherName");
            entity.Property(e => e.PnetNacionalidadFiscal)
                .HasMaxLength(100)
                .HasColumnName("pnet_NacionalidadFiscal");
            entity.Property(e => e.PnetNameGenerator)
                .HasMaxLength(335)
                .HasColumnName("pnet_Name_Generator");
            entity.Property(e => e.PnetNationality)
                .HasMaxLength(250)
                .HasColumnName("pnet_Nationality");
            entity.Property(e => e.PnetNationalityCountry).HasColumnName("pnet_NationalityCountry");
            entity.Property(e => e.PnetNationalityId).HasColumnName("pnet_NationalityId");
            entity.Property(e => e.PnetNationalityInformed).HasColumnName("pnet_NationalityInformed");
            entity.Property(e => e.PnetNationalityList).HasColumnName("pnet_NationalityList");
            entity.Property(e => e.PnetNeighborhood)
                .HasMaxLength(100)
                .HasColumnName("pnet_Neighborhood");
            entity.Property(e => e.PnetNic).HasColumnName("pnet_NIC");
            entity.Property(e => e.PnetNumberChildren).HasColumnName("pnet_NumberChildren");
            entity.Property(e => e.PnetNumeroDocumentoFiscalExtranjero)
                .HasMaxLength(100)
                .HasColumnName("pnet_NumeroDocumentoFiscalExtranjero");
            entity.Property(e => e.PnetObservationAddress).HasColumnName("pnet_ObservationAddress");
            entity.Property(e => e.PnetOccupation).HasColumnName("pnet_Occupation");
            entity.Property(e => e.PnetOperativeContractIdentification)
                .HasMaxLength(100)
                .HasColumnName("pnet_OperativeContractIdentification");
            entity.Property(e => e.PnetOrdenesTransferenciaPeriodicaCuentasEeuu).HasColumnName("pnet_OrdenesTransferenciaPeriodicaCuentasEEUU");
            entity.Property(e => e.PnetOthersIncomes).HasColumnName("pnet_OthersIncomes");
            entity.Property(e => e.PnetOwnerVehicle).HasColumnName("pnet_OwnerVehicle");
            entity.Property(e => e.PnetPadreMadreEstadounidense).HasColumnName("pnet_PadreMadreEstadounidense");
            entity.Property(e => e.PnetPasaporteNorteamericano).HasColumnName("pnet_PasaporteNorteamericano");
            entity.Property(e => e.PnetPep).HasColumnName("pnet_pep");
            entity.Property(e => e.PnetPepreason)
                .HasMaxLength(100)
                .HasColumnName("pnet_PEPReason");
            entity.Property(e => e.PnetPersonsHousehold).HasColumnName("pnet_PersonsHousehold");
            entity.Property(e => e.PnetPhone1)
                .HasMaxLength(100)
                .HasColumnName("pnet_Phone1");
            entity.Property(e => e.PnetPhone2)
                .HasMaxLength(100)
                .HasColumnName("pnet_Phone2");
            entity.Property(e => e.PnetPhone3)
                .HasMaxLength(100)
                .HasColumnName("pnet_Phone3");
            entity.Property(e => e.PnetPhone4)
                .HasMaxLength(100)
                .HasColumnName("pnet_Phone4");
            entity.Property(e => e.PnetPhoneCallId).HasColumnName("pnet_PhoneCallId");
            entity.Property(e => e.PnetPhoneCreation).HasColumnName("pnet_PhoneCreation");
            entity.Property(e => e.PnetPhoneType1).HasColumnName("pnet_PhoneType1");
            entity.Property(e => e.PnetPhoneType2).HasColumnName("pnet_PhoneType2");
            entity.Property(e => e.PnetPhoneType3).HasColumnName("pnet_PhoneType3");
            entity.Property(e => e.PnetPhoneType4).HasColumnName("pnet_PhoneType4");
            entity.Property(e => e.PnetPhones)
                .HasMaxLength(400)
                .HasColumnName("pnet_Phones");
            entity.Property(e => e.PnetPorcentajeExcencion)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_PorcentajeExcencion");
            entity.Property(e => e.PnetPoseeCuentaConjuntaFatca).HasColumnName("pnet_PoseeCuentaConjuntaFATCA");
            entity.Property(e => e.PnetPreApprovedAmount).HasColumnName("pnet_PreApprovedAmount");
            entity.Property(e => e.PnetPreApprovedClassification).HasColumnName("pnet_PreApprovedClassification");
            entity.Property(e => e.PnetPreApprovedQuota).HasColumnName("pnet_PreApprovedQuota");
            entity.Property(e => e.PnetPreferredMethodChannel).HasColumnName("pnet_PreferredMethodChannel");
            entity.Property(e => e.PnetPremiumCustomer).HasColumnName("pnet_PremiumCustomer");
            entity.Property(e => e.PnetPrimerNacionalidad)
                .HasMaxLength(100)
                .HasColumnName("pnet_PrimerNacionalidad");
            entity.Property(e => e.PnetPrincipalApplication)
                .HasMaxLength(100)
                .HasColumnName("pnet_PrincipalApplication");
            entity.Property(e => e.PnetPrincipalApplicationPreAp).HasColumnName("pnet_PrincipalApplicationPreAp");
            entity.Property(e => e.PnetProductsService).HasColumnName("pnet_ProductsService");
            entity.Property(e => e.PnetPuccreatedon)
                .HasColumnType("datetime")
                .HasColumnName("pnet_PUCCreatedon");
            entity.Property(e => e.PnetRecommendedBusinessId).HasColumnName("pnet_RecommendedBusinessId");
            entity.Property(e => e.PnetRecommendedById).HasColumnName("pnet_RecommendedById");
            entity.Property(e => e.PnetRegistrationDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_RegistrationDate");
            entity.Property(e => e.PnetRelacionadoConCorporaciones).HasColumnName("pnet_RelacionadoConCorporaciones");
            entity.Property(e => e.PnetRenovationNumber).HasColumnName("pnet_RenovationNumber");
            entity.Property(e => e.PnetRentalValue).HasColumnName("pnet_RentalValue");
            entity.Property(e => e.PnetRenunciaNacionalidadEeuu).HasColumnName("pnet_RenunciaNacionalidadEEUU");
            entity.Property(e => e.PnetResidente).HasColumnName("pnet_Residente");
            entity.Property(e => e.PnetSegundaNacionalidad)
                .HasMaxLength(100)
                .HasColumnName("pnet_SegundaNacionalidad");
            entity.Property(e => e.PnetSeleccionadoFatca).HasColumnName("pnet_SeleccionadoFATCA");
            entity.Property(e => e.PnetSeleccionadoOcde).HasColumnName("pnet_SeleccionadoOCDE");
            entity.Property(e => e.PnetSoi).HasColumnName("pnet_Soi");
            entity.Property(e => e.PnetSoiType).HasColumnName("pnet_SoiType");
            entity.Property(e => e.PnetSource)
                .HasMaxLength(80)
                .HasColumnName("pnet_Source");
            entity.Property(e => e.PnetStatus).HasColumnName("pnet_Status");
            entity.Property(e => e.PnetSubStatus).HasColumnName("pnet_SubStatus");
            entity.Property(e => e.PnetSubsidaryNumber)
                .HasMaxLength(100)
                .HasColumnName("pnet_SubsidaryNumber");
            entity.Property(e => e.PnetSubsidiaryCode).HasColumnName("pnet_SubsidiaryCode");
            entity.Property(e => e.PnetSubsidiaryId).HasColumnName("pnet_SubsidiaryId");
            entity.Property(e => e.PnetSuscribioPoderNotarial).HasColumnName("pnet_SuscribioPoderNotarial");
            entity.Property(e => e.PnetSwernDeclaration).HasColumnName("pnet_SwernDeclaration");
            entity.Property(e => e.PnetTaxDocumentNumber).HasColumnName("pnet_TaxDocumentNumber");
            entity.Property(e => e.PnetTaxDocumentNumber2).HasColumnName("pnet_TaxDocumentNumber2");
            entity.Property(e => e.PnetTaxDocumentNumber3).HasColumnName("pnet_TaxDocumentNumber3");
            entity.Property(e => e.PnetTaxDocumentType).HasColumnName("pnet_TaxDocumentType");
            entity.Property(e => e.PnetTaxGciascategory).HasColumnName("pnet_TaxGCIASCategory");
            entity.Property(e => e.PnetTaxIibbcategory).HasColumnName("pnet_TaxIIBBCategory");
            entity.Property(e => e.PnetTaxIvacategory).HasColumnName("pnet_TaxIVACategory");
            entity.Property(e => e.PnetTelephones).HasColumnName("pnet_Telephones");
            entity.Property(e => e.PnetTipoDocumentoFiscalExtranjero).HasColumnName("pnet_TipoDocumentoFiscalExtranjero");
            entity.Property(e => e.PnetTipoImpuesto).HasColumnName("pnet_TipoImpuesto");
            entity.Property(e => e.PnetTower)
                .HasMaxLength(20)
                .HasColumnName("pnet_Tower");
            entity.Property(e => e.PnetTypeBank).HasColumnName("pnet_TypeBank");
            entity.Property(e => e.PnetTypeCredit)
                .HasMaxLength(100)
                .HasColumnName("pnet_TypeCredit");
            entity.Property(e => e.PnetTypeCreditCard).HasColumnName("pnet_TypeCreditCard");
            entity.Property(e => e.PnetTypeIncomes)
                .HasMaxLength(150)
                .HasColumnName("pnet_TypeIncomes");
            entity.Property(e => e.PnetTypeInsurance)
                .HasMaxLength(100)
                .HasColumnName("pnet_TypeInsurance");
            entity.Property(e => e.PnetTypeProductsBp)
                .HasMaxLength(150)
                .HasColumnName("pnet_TypeProductsBP");
            entity.Property(e => e.PnetUifconstancy).HasColumnName("pnet_UIFConstancy");
            entity.Property(e => e.PnetUltimaofertavalorid).HasColumnName("pnet_ultimaofertavalorid");
            entity.Property(e => e.PnetUrlGetClientsByDni)
                .HasMaxLength(200)
                .HasColumnName("pnet_URL_GetClientsByDni");
            entity.Property(e => e.PnetUrlGetDateTime)
                .HasMaxLength(200)
                .HasColumnName("pnet_URL_GetDateTime");
            entity.Property(e => e.PnetUrlGetProductsByNip)
                .HasMaxLength(200)
                .HasColumnName("pnet_URL_GetProductsByNIP");
            entity.Property(e => e.PnetUrlGetProductsFormattedByNip)
                .HasMaxLength(200)
                .HasColumnName("pnet_URL_GetProductsFormattedByNip");
            entity.Property(e => e.PnetUrlGetRealAddressByNip)
                .HasMaxLength(200)
                .HasColumnName("pnet_URL_GetRealAddressByNip");
            entity.Property(e => e.Salutation).HasMaxLength(100);
            entity.Property(e => e.Slaid).HasColumnName("SLAId");
            entity.Property(e => e.SlainvokedId).HasColumnName("SLAInvokedId");
            entity.Property(e => e.SpousesName).HasMaxLength(100);
            entity.Property(e => e.Suffix).HasMaxLength(10);
            entity.Property(e => e.Telephone1).HasMaxLength(50);
            entity.Property(e => e.Telephone2).HasMaxLength(50);
            entity.Property(e => e.Telephone3).HasMaxLength(50);
            entity.Property(e => e.TimeSpentByMeOnEmailAndMeetings).HasMaxLength(1250);
            entity.Property(e => e.TraversedPath).HasMaxLength(1250);
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.WebSiteUrl).HasMaxLength(200);
            entity.Property(e => e.YomiFirstName).HasMaxLength(150);
            entity.Property(e => e.YomiFullName).HasMaxLength(450);
            entity.Property(e => e.YomiLastName).HasMaxLength(150);
            entity.Property(e => e.YomiMiddleName).HasMaxLength(150);
            entity.Property(e => e.ZennonbiActualscore)
                .HasMaxLength(50)
                .HasColumnName("zennonbi_actualscore");
        });

        modelBuilder.Entity<ContactBaseExtranetForm1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ContactBaseExtranetForm1", "app");

            entity.Property(e => e.Actividad).HasMaxLength(100);
            entity.Property(e => e.Area1).HasMaxLength(7);
            entity.Property(e => e.CnaeDescripcion).HasMaxLength(102);
            entity.Property(e => e.Cuitdv).HasColumnName("CUITdv");
            entity.Property(e => e.Cuitpre).HasColumnName("CUITpre");
            entity.Property(e => e.Dni).HasColumnName("DNI");
            entity.Property(e => e.Domicilio).HasMaxLength(259);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FechaCargaSolicitud).HasColumnType("datetime");
            entity.Property(e => e.FechaEfectivaLiquidacion).HasColumnType("datetime");
            entity.Property(e => e.FullNameContacto).HasMaxLength(160);
            entity.Property(e => e.MontoCredito).HasColumnType("money");
            entity.Property(e => e.PnetTaxdocumentnumber).HasColumnName("pnet_taxdocumentnumber");
            entity.Property(e => e.Rubro).HasMaxLength(100);
            entity.Property(e => e.Segmento).HasMaxLength(100);
            entity.Property(e => e.StatusCodeDesc)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.SucursalBapro).HasMaxLength(160);
            entity.Property(e => e.Teléfono).HasMaxLength(100);
            entity.Property(e => e.UsuarioCargaSolicitud).HasMaxLength(200);
        });

        modelBuilder.Entity<Contacto>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Contacto", "app");

            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("CODIGO POSTAL");
            entity.Property(e => e.Direccion)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.Domicilio)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("DOMICILIO");
            entity.Property(e => e.FechaCreación)
                .HasColumnType("datetime")
                .HasColumnName("Fecha Creación");
            entity.Property(e => e.FechaModificación)
                .HasColumnType("datetime")
                .HasColumnName("Fecha Modificación");
            entity.Property(e => e.Google)
                .HasMaxLength(250)
                .HasColumnName("google");
            entity.Property(e => e.Latitud).HasColumnType("numeric(18, 6)");
            entity.Property(e => e.Localidad)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("LOCALIDAD");
            entity.Property(e => e.Longitud).HasColumnType("numeric(18, 6)");
            entity.Property(e => e.NroDoc).HasColumnName("NRO DOC");
            entity.Property(e => e.Origen)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Sucur)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SUCUR");
            entity.Property(e => e.Telefonos)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("TELEFONOS");
            entity.Property(e => e.TipDoc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TIP DOC");
        });

        modelBuilder.Entity<Contacto1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Contactos", "crm");

            entity.Property(e => e.BirthDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Ec)
                .HasMaxLength(200)
                .HasColumnName("EC");
            entity.Property(e => e.Ecadmin)
                .HasMaxLength(200)
                .HasColumnName("ECadmin");
            entity.Property(e => e.EmailAddress1)
                .HasMaxLength(100)
                .HasColumnName("EMailAddress1");
            entity.Property(e => e.EmailAddress2)
                .HasMaxLength(100)
                .HasColumnName("EMailAddress2");
            entity.Property(e => e.EmailAddress3)
                .HasMaxLength(100)
                .HasColumnName("EMailAddress3");
            entity.Property(e => e.FamilyStatus).HasMaxLength(4000);
            entity.Property(e => e.FirstName).HasMaxLength(69);
            entity.Property(e => e.FullName).HasMaxLength(160);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.LegajoEc)
                .HasMaxLength(50)
                .HasColumnName("LegajoEC");
            entity.Property(e => e.LegajoEcadmin)
                .HasMaxLength(50)
                .HasColumnName("LegajoECadmin");
            entity.Property(e => e.LevelEducation).HasMaxLength(4000);
            entity.Property(e => e.MobilePhone).HasMaxLength(53);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Nif)
                .HasMaxLength(100)
                .HasColumnName("NIF");
            entity.Property(e => e.Occupation).HasMaxLength(4000);
            entity.Property(e => e.PhoneType1).HasMaxLength(4000);
            entity.Property(e => e.PhoneType2).HasMaxLength(4000);
            entity.Property(e => e.PhoneType3).HasMaxLength(4000);
            entity.Property(e => e.PhoneType4).HasMaxLength(4000);
            entity.Property(e => e.PnetAreaCode1)
                .HasMaxLength(7)
                .HasColumnName("pnet_AreaCode1");
            entity.Property(e => e.PnetAreaCode2)
                .HasMaxLength(7)
                .HasColumnName("pnet_AreaCode2");
            entity.Property(e => e.PnetAreaCode3)
                .HasMaxLength(7)
                .HasColumnName("pnet_AreaCode3");
            entity.Property(e => e.PnetAreaCode4)
                .HasMaxLength(7)
                .HasColumnName("pnet_AreaCode4");
            entity.Property(e => e.PnetBipcontact).HasColumnName("pnet_BIPContact");
            entity.Property(e => e.PnetBpbaPersonInternalNumber)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBA_PersonInternalNumber");
            entity.Property(e => e.PnetBpbaproducts).HasColumnName("pnet_BPBAProducts");
            entity.Property(e => e.PnetChangeStatusDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_ChangeStatusDate");
            entity.Property(e => e.PnetCommercialactiondescription)
                .HasMaxLength(400)
                .HasColumnName("pnet_Commercialactiondescription");
            entity.Property(e => e.PnetConsolidatePhone1)
                .HasMaxLength(100)
                .HasColumnName("pnet_ConsolidatePhone1");
            entity.Property(e => e.PnetConsolidatePhone2)
                .HasMaxLength(100)
                .HasColumnName("pnet_ConsolidatePhone2");
            entity.Property(e => e.PnetConsolidatePhone3)
                .HasMaxLength(100)
                .HasColumnName("pnet_ConsolidatePhone3");
            entity.Property(e => e.PnetConsolidatePhone4)
                .HasMaxLength(100)
                .HasColumnName("pnet_ConsolidatePhone4");
            entity.Property(e => e.PnetConsolidatedBankPhone)
                .HasMaxLength(100)
                .HasColumnName("pnet_ConsolidatedBankPhone");
            entity.Property(e => e.PnetContractInternalNumber)
                .HasMaxLength(100)
                .HasColumnName("pnet_ContractInternalNumber");
            entity.Property(e => e.PnetDeceasedDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_DeceasedDate");
            entity.Property(e => e.PnetDeceasedRegistrationDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_DeceasedRegistrationDate");
            entity.Property(e => e.PnetDeceasedRegistrationName)
                .HasMaxLength(100)
                .HasColumnName("pnet_DeceasedRegistrationName");
            entity.Property(e => e.PnetDeseasedCustomer).HasColumnName("pnet_DeseasedCustomer");
            entity.Property(e => e.PnetDiplomaticoProfesorEstudianteDeportistaEu).HasColumnName("pnet_DiplomaticoProfesorEstudianteDeportistaEU");
            entity.Property(e => e.PnetDobleNacionalidad).HasColumnName("pnet_DobleNacionalidad");
            entity.Property(e => e.PnetDocumentNumber).HasColumnName("pnet_DocumentNumber");
            entity.Property(e => e.PnetDocumentTypeValue)
                .HasMaxLength(100)
                .HasColumnName("pnet_DocumentTypeValue");
            entity.Property(e => e.PnetFatcasituation).HasColumnName("pnet_FATCASituation");
            entity.Property(e => e.PnetFatherName)
                .HasMaxLength(100)
                .HasColumnName("pnet_FatherName");
            entity.Property(e => e.PnetFechaFinVigencia)
                .HasColumnType("datetime")
                .HasColumnName("pnet_FechaFinVigencia");
            entity.Property(e => e.PnetFrecuenteEnEeuu).HasColumnName("pnet_FrecuenteEnEEUU");
            entity.Property(e => e.PnetInternationalData).HasColumnName("pnet_InternationalData");
            entity.Property(e => e.PnetLocationBirth)
                .HasMaxLength(250)
                .HasColumnName("pnet_LocationBirth");
            entity.Property(e => e.PnetMotherName)
                .HasMaxLength(100)
                .HasColumnName("pnet_MotherName");
            entity.Property(e => e.PnetNationality)
                .HasMaxLength(250)
                .HasColumnName("pnet_Nationality");
            entity.Property(e => e.PnetOperativeContractIdentification)
                .HasMaxLength(100)
                .HasColumnName("pnet_OperativeContractIdentification");
            entity.Property(e => e.PnetPhone1)
                .HasMaxLength(100)
                .HasColumnName("pnet_Phone1");
            entity.Property(e => e.PnetPhone2)
                .HasMaxLength(100)
                .HasColumnName("pnet_Phone2");
            entity.Property(e => e.PnetPhone3)
                .HasMaxLength(100)
                .HasColumnName("pnet_Phone3");
            entity.Property(e => e.PnetPhone4)
                .HasMaxLength(100)
                .HasColumnName("pnet_Phone4");
            entity.Property(e => e.PnetRegistrationDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_RegistrationDate");
            entity.Property(e => e.PnetResidente).HasColumnName("pnet_Residente");
            entity.Property(e => e.PnetSubsidaryNumber)
                .HasMaxLength(100)
                .HasColumnName("pnet_SubsidaryNumber");
            entity.Property(e => e.PnetTaxDocumentNumber).HasColumnName("pnet_TaxDocumentNumber");
            entity.Property(e => e.SpousesName).HasMaxLength(100);
            entity.Property(e => e.Status).HasMaxLength(4000);
            entity.Property(e => e.SubStatus).HasMaxLength(4000);
            entity.Property(e => e.Sucursal).HasMaxLength(160);
            entity.Property(e => e.SucursalCód).HasMaxLength(400);
            entity.Property(e => e.Telephone1).HasMaxLength(50);
            entity.Property(e => e.Telephone2).HasMaxLength(50);
            entity.Property(e => e.Telephone3).HasMaxLength(50);
            entity.Property(e => e.ZennonbiActualscore)
                .HasMaxLength(50)
                .HasColumnName("zennonbi_actualscore");
        });

        modelBuilder.Entity<ControlArchivosSur>(entity =>
        {
            entity.HasKey(e => e.IdControl);

            entity.ToTable("ControlArchivosSur", "app");

            entity.Property(e => e.IdControl)
                .ValueGeneratedNever()
                .HasColumnName("idControl");
            entity.Property(e => e.FechaModificación).HasColumnType("datetime");
        });

        modelBuilder.Entity<ControlBparchivo>(entity =>
        {
            entity.HasKey(e => e.IdBparchivos).HasName("PK_BParchivos");

            entity.ToTable("ControlBParchivos", "app");

            entity.Property(e => e.IdBparchivos).HasColumnName("idBParchivos");
            entity.Property(e => e.Archivo).HasMaxLength(50);
            entity.Property(e => e.Carpeta).HasMaxLength(500);
            entity.Property(e => e.FechaCreación).HasColumnType("datetime");
            entity.Property(e => e.FechaEliminación).HasColumnType("datetime");
        });

        modelBuilder.Entity<ControlCorreo>(entity =>
        {
            entity.HasKey(e => e.IdControlCorreos);

            entity.ToTable("ControlCorreos", "app");

            entity.Property(e => e.IdControlCorreos).HasColumnName("idControlCorreos");
            entity.Property(e => e.Correo).HasMaxLength(50);
            entity.Property(e => e.FechaCreación).HasColumnType("datetime");
        });

        modelBuilder.Entity<CorreoCopium>(entity =>
        {
            entity.HasKey(e => e.IdCorreoCopia);

            entity.ToTable("CorreoCopia", "app");

            entity.HasIndex(e => new { e.Destinatario, e.CopiarA }, "IDX_CorreoCopia_01").IsUnique();

            entity.Property(e => e.IdCorreoCopia).HasColumnName("idCorreoCopia");
            entity.Property(e => e.CopiarA).HasMaxLength(50);
            entity.Property(e => e.Destinatario).HasMaxLength(50);
            entity.Property(e => e.FechaCreación).HasColumnType("datetime");
            entity.Property(e => e.ModificadoPor).HasMaxLength(50);
            entity.Property(e => e.Tipo).HasMaxLength(50);
        });

        modelBuilder.Entity<CorreoPlantilla>(entity =>
        {
            entity.HasKey(e => e.IdPlantilla).HasName("PK_appCorreoPlantilla_1");

            entity.ToTable("CorreoPlantilla", "app");

            entity.HasIndex(e => new { e.Nombre, e.Categoría }, "IDX_appCorreoPlantilla_1").IsUnique();

            entity.Property(e => e.Asunto).HasMaxLength(255);
            entity.Property(e => e.Categoría).HasMaxLength(50);
            entity.Property(e => e.Html).HasColumnName("HTML");
            entity.Property(e => e.Modificado).HasColumnType("datetime");
            entity.Property(e => e.ModificadoPor).HasMaxLength(50);
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.Notas).HasMaxLength(500);
            entity.Property(e => e.Sector).HasMaxLength(50);
        });

        modelBuilder.Entity<CorreosIntegracion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CorreosIntegracion", "int");

            entity.Property(e => e.Desde).HasMaxLength(50);
            entity.Property(e => e.Encabezado).HasMaxLength(255);
            entity.Property(e => e.FechaCreación).HasColumnType("datetime");
            entity.Property(e => e.IdMensaje).HasMaxLength(50);
            entity.Property(e => e.IdProceso).HasMaxLength(50);
            entity.Property(e => e.Proceso).HasMaxLength(30);
            entity.Property(e => e.Recibido).HasMaxLength(30);
        });

        modelBuilder.Entity<Credito>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Creditos", "int");

            entity.Property(e => e.BkCreditBase).HasColumnName("bkCreditBase");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EcAdminDni).HasColumnName("EC Admin DNI");
            entity.Property(e => e.EcAdminLegajo)
                .HasMaxLength(50)
                .HasColumnName("EC Admin Legajo");
            entity.Property(e => e.EcAdminZona)
                .HasMaxLength(160)
                .HasColumnName("EC Admin Zona");
            entity.Property(e => e.EcEvaluador)
                .HasMaxLength(200)
                .HasColumnName("EC Evaluador");
            entity.Property(e => e.EcEvaluadorDni).HasColumnName("EC Evaluador DNI");
            entity.Property(e => e.EcEvaluadorLegajo)
                .HasMaxLength(50)
                .HasColumnName("EC Evaluador Legajo");
            entity.Property(e => e.FechaCompromiso)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Fecha Compromiso");
            entity.Property(e => e.FechaProceso).HasColumnType("date");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.NroCta)
                .HasMaxLength(100)
                .HasColumnName("Nro Cta");
            entity.Property(e => e.PnetAccepted).HasColumnName("pnet_Accepted");
            entity.Property(e => e.Solicitud).HasMaxLength(100);
        });

        modelBuilder.Entity<CrmFiliale>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CRM_FILIALES");

            entity.Property(e => e.FilialProme).HasColumnName("Filial Prome");
            entity.Property(e => e.NombreJefeZonal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE JEFE ZONAL");
            entity.Property(e => e.SubZonaId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUB ZONA ID");
            entity.Property(e => e.SubZonaNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUB ZONA NOMBRE");
            entity.Property(e => e.Sucursal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Zona)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CuadroDiarioEjecutivo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CuadroDiarioEjecutivos", "int");

            entity.HasIndex(e => e.GrupoAtraso, "nci_wi_CuadroDiarioEjecutivos_6CC69D4ED561F4362E3E998AB7971FC4");

            entity.Property(e => e.Apellidos)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ContactId).HasMaxLength(50);
            entity.Property(e => e.DeudaExigible)
                .HasColumnType("money")
                .HasColumnName("Deuda Exigible");
            entity.Property(e => e.DiaHabil).HasColumnType("date");
            entity.Property(e => e.DíasAtraso).HasColumnName("Días atraso");
            entity.Property(e => e.FactorCobertura).HasColumnType("money");
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.GrupoAtraso).HasMaxLength(32);
            entity.Property(e => e.GrupoCompromiso).HasMaxLength(32);
            entity.Property(e => e.GrupoVencimiento).HasMaxLength(32);
            entity.Property(e => e.GrupoÚltimaGestion)
                .HasMaxLength(5)
                .HasColumnName("Grupo Última Gestion");
            entity.Property(e => e.LegajoEc).HasColumnName("LegajoEC");
            entity.Property(e => e.Mes)
                .HasColumnType("datetime")
                .HasColumnName("mes");
            entity.Property(e => e.MontoCuota)
                .HasColumnType("money")
                .HasColumnName("Monto Cuota");
            entity.Property(e => e.MontoMayor).HasColumnName("Monto Mayor");
            entity.Property(e => e.NombreEc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NombreEC");
            entity.Property(e => e.NombreEcAdm)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NombreEcEvaluador)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombres)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NroDoc).HasColumnName("Nro Doc");
            entity.Property(e => e.PromesaPago)
                .HasMaxLength(512)
                .HasColumnName("Promesa Pago");
            entity.Property(e => e.PróximaLiquidación)
                .HasColumnType("date")
                .HasColumnName("Próxima Liquidación");
            entity.Property(e => e.Quartile)
                .HasMaxLength(35)
                .IsUnicode(false);
            entity.Property(e => e.SaldoCuenta)
                .HasColumnType("money")
                .HasColumnName("Saldo Cuenta");
            entity.Property(e => e.SaldoMora).HasColumnType("money");
            entity.Property(e => e.SaldoPréstamo)
                .HasColumnType("money")
                .HasColumnName("Saldo Préstamo");
            entity.Property(e => e.SaldoTotalPréstamos)
                .HasColumnType("money")
                .HasColumnName("Saldo Total Préstamos");
            entity.Property(e => e.SinPiloto).HasColumnName("Sin Piloto");
            entity.Property(e => e.Situación).HasMaxLength(15);
            entity.Property(e => e.SituaciónNombre)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.SkArea).HasColumnName("skArea");
            entity.Property(e => e.SkFecha)
                .HasColumnType("date")
                .HasColumnName("skFecha");
            entity.Property(e => e.SkPersona).HasColumnName("skPersona");
            entity.Property(e => e.SkPrestamo).HasColumnName("skPrestamo");
            entity.Property(e => e.Solicitud).HasMaxLength(16);
            entity.Property(e => e.SubTipoCrédito)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Subzona)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubzonaCorregida)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sucursal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SucursalCódigo).HasColumnName("Sucursal Código");
            entity.Property(e => e.Te)
                .HasMaxLength(50)
                .HasColumnName("TE");
            entity.Property(e => e.TipoCobertura).HasMaxLength(32);
            entity.Property(e => e.TipoCrédito)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Zona)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CuadroDiarioEjecutivosMail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CuadroDiarioEjecutivosMail", "app");

            entity.Property(e => e.Body).HasColumnName("body");
            entity.Property(e => e.CategoriaCodigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FromAddress)
                .HasMaxLength(39)
                .IsUnicode(false)
                .HasColumnName("from_address");
            entity.Property(e => e.Importance)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("importance");
            entity.Property(e => e.NombreEcAdm)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Recipients)
                .HasMaxLength(50)
                .HasColumnName("recipients");
            entity.Property(e => e.Subject)
                .HasMaxLength(4000)
                .HasColumnName("subject");
        });

        modelBuilder.Entity<CustomerAddressBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CustomerAddressBase", "crm");

            entity.HasIndex(e => new { e.CustomerAddressId, e.ParentId }, "CustomerAddressBase-20210108-IDX");

            entity.Property(e => e.City).HasMaxLength(4000);
            entity.Property(e => e.Country).HasMaxLength(4000);
            entity.Property(e => e.County).HasMaxLength(4000);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ExchangeRate).HasColumnType("numeric(23, 10)");
            entity.Property(e => e.Fax).HasMaxLength(50);
            entity.Property(e => e.Line1).HasMaxLength(4000);
            entity.Property(e => e.Line2).HasMaxLength(4000);
            entity.Property(e => e.Line3).HasMaxLength(4000);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PostOfficeBox).HasMaxLength(4000);
            entity.Property(e => e.PostalCode).HasMaxLength(4000);
            entity.Property(e => e.PrimaryContactName).HasMaxLength(150);
            entity.Property(e => e.StateOrProvince).HasMaxLength(4000);
            entity.Property(e => e.Telephone1).HasMaxLength(50);
            entity.Property(e => e.Telephone2).HasMaxLength(50);
            entity.Property(e => e.Telephone3).HasMaxLength(50);
            entity.Property(e => e.Upszone)
                .HasMaxLength(4)
                .HasColumnName("UPSZone");
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.Utcoffset).HasColumnName("UTCOffset");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<CustomerAddressBase1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CustomerAddressBase", "int");

            entity.Property(e => e.City).HasMaxLength(4000);
            entity.Property(e => e.Country).HasMaxLength(4000);
            entity.Property(e => e.County).HasMaxLength(4000);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ExchangeRate).HasColumnType("numeric(23, 10)");
            entity.Property(e => e.Fax).HasMaxLength(50);
            entity.Property(e => e.Line1).HasMaxLength(4000);
            entity.Property(e => e.Line2).HasMaxLength(4000);
            entity.Property(e => e.Line3).HasMaxLength(4000);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PostOfficeBox).HasMaxLength(4000);
            entity.Property(e => e.PostalCode).HasMaxLength(4000);
            entity.Property(e => e.PrimaryContactName).HasMaxLength(150);
            entity.Property(e => e.StateOrProvince).HasMaxLength(4000);
            entity.Property(e => e.Telephone1).HasMaxLength(50);
            entity.Property(e => e.Telephone2).HasMaxLength(50);
            entity.Property(e => e.Telephone3).HasMaxLength(50);
            entity.Property(e => e.Upszone)
                .HasMaxLength(4)
                .HasColumnName("UPSZone");
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.Utcoffset).HasColumnName("UTCOffset");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<DbMailQueue>(entity =>
        {
            entity.HasKey(e => e.IdMailQueue);

            entity.ToTable("DbMailQueue", "app");

            entity.Property(e => e.IdMailQueue).HasColumnName("idMailQueue");
            entity.Property(e => e.AppendQueryError).HasColumnName("append_query_error");
            entity.Property(e => e.AttachQueryResultAsFile).HasColumnName("attach_query_result_as_file");
            entity.Property(e => e.BlindCopyRecipients)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("blind_copy_recipients");
            entity.Property(e => e.Body).HasColumnName("body");
            entity.Property(e => e.BodyFormat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("body_format");
            entity.Property(e => e.CopyRecipients)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("copy_recipients");
            entity.Property(e => e.ExcludeQueryOutput).HasColumnName("exclude_query_output");
            entity.Property(e => e.ExecuteQueryDatabase)
                .HasMaxLength(128)
                .HasColumnName("execute_query_database");
            entity.Property(e => e.FileAttachments)
                .HasMaxLength(4000)
                .HasColumnName("file_attachments");
            entity.Property(e => e.FromAddress)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("from_address");
            entity.Property(e => e.Importance)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("importance");
            entity.Property(e => e.ProfileName)
                .HasMaxLength(128)
                .HasColumnName("profile_name");
            entity.Property(e => e.Query)
                .HasMaxLength(4000)
                .HasColumnName("query");
            entity.Property(e => e.QueryAttachmentFilename)
                .HasMaxLength(260)
                .HasColumnName("query_attachment_filename");
            entity.Property(e => e.QueryNoTruncate).HasColumnName("query_no_truncate");
            entity.Property(e => e.QueryResultHeader).HasColumnName("query_result_header");
            entity.Property(e => e.QueryResultNoPadding).HasColumnName("query_result_no_padding");
            entity.Property(e => e.QueryResultSeparator)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("query_result_separator");
            entity.Property(e => e.QueryResultWidth).HasColumnName("query_result_width");
            entity.Property(e => e.Recipients)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("recipients");
            entity.Property(e => e.ReplyTo)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("reply_to");
            entity.Property(e => e.Sensitivity)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("sensitivity");
            entity.Property(e => e.Subject)
                .HasMaxLength(255)
                .HasColumnName("subject");
        });

        modelBuilder.Entity<Diccionario>(entity =>
        {
            entity.HasKey(e => e.IdDiccionario).HasName("PK_appDiccionario_1");

            entity.ToTable("Diccionario", "app");

            entity.Property(e => e.Campo).HasMaxLength(50);
            entity.Property(e => e.CodigoCrm)
                .HasMaxLength(256)
                .HasColumnName("CodigoCRM");
            entity.Property(e => e.Dato).HasMaxLength(256);
            entity.Property(e => e.Descriptor).HasMaxLength(50);
        });

        modelBuilder.Entity<Distribucion>(entity =>
        {
            entity.HasKey(e => e.IdDistribucion).HasName("PK_Distribución");

            entity.ToTable("Distribucion", "fin");

            entity.Property(e => e.IdDistribucion).HasColumnName("idDistribucion");
            entity.Property(e => e.Archivo).HasMaxLength(255);
            entity.Property(e => e.Concepto).HasMaxLength(30);
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.IdProceso).HasMaxLength(50);
            entity.Property(e => e.Periodo).HasColumnType("date");
            entity.Property(e => e.Sucursal).HasMaxLength(50);
            entity.Property(e => e.Valor).HasColumnType("numeric(18, 6)");
        });

        modelBuilder.Entity<DomiciliosCrm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DomiciliosCRM", "int");

            entity.Property(e => e.Calle).HasMaxLength(250);
            entity.Property(e => e.City).HasMaxLength(4000);
            entity.Property(e => e.DocTipo).HasMaxLength(100);
            entity.Property(e => e.Line1).HasMaxLength(4000);
            entity.Property(e => e.Localidad).HasMaxLength(100);
            entity.Property(e => e.Municipio).HasMaxLength(100);
            entity.Property(e => e.PnetConsolidatePhone1)
                .HasMaxLength(100)
                .HasColumnName("pnet_ConsolidatePhone1");
            entity.Property(e => e.PnetConsolidatePhone2)
                .HasMaxLength(100)
                .HasColumnName("pnet_ConsolidatePhone2");
            entity.Property(e => e.PnetConsolidatePhone3)
                .HasMaxLength(100)
                .HasColumnName("pnet_ConsolidatePhone3");
            entity.Property(e => e.PnetConsolidatePhone4)
                .HasMaxLength(100)
                .HasColumnName("pnet_ConsolidatePhone4");
            entity.Property(e => e.PnetDocumentNumber).HasColumnName("pnet_DocumentNumber");
            entity.Property(e => e.PostalCode).HasMaxLength(4000);
            entity.Property(e => e.StateOrProvince).HasMaxLength(4000);
            entity.Property(e => e.Zona).HasMaxLength(100);
        });

        modelBuilder.Entity<Dwcatalogo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DWCatalogo", "app");

            entity.Property(e => e.Columna).HasMaxLength(128);
            entity.Property(e => e.EsquemaTabla)
                .HasMaxLength(128)
                .HasColumnName("esquemaTabla");
            entity.Property(e => e.Notas).HasColumnType("sql_variant");
            entity.Property(e => e.Tabla).HasMaxLength(4000);
            entity.Property(e => e.Tipo).HasMaxLength(128);
        });

        modelBuilder.Entity<Entity>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Entity", "crm");

            entity.HasIndex(e => e.EntityId, "Entity-20210118-IDX");

            entity.Property(e => e.AddressTableName).HasMaxLength(64);
            entity.Property(e => e.BaseTableName).HasMaxLength(64);
            entity.Property(e => e.CollectionName).HasMaxLength(64);
            entity.Property(e => e.EntityAssembly).HasMaxLength(255);
            entity.Property(e => e.EntityClassName).HasMaxLength(255);
            entity.Property(e => e.EntityColor).HasMaxLength(7);
            entity.Property(e => e.EntityHelpUrl).HasMaxLength(1024);
            entity.Property(e => e.EntitySetName).HasMaxLength(64);
            entity.Property(e => e.ExtensionTableName).HasMaxLength(64);
            entity.Property(e => e.IconLargeName).HasMaxLength(512);
            entity.Property(e => e.IconMediumName).HasMaxLength(512);
            entity.Property(e => e.IconSmallName).HasMaxLength(512);
            entity.Property(e => e.IntroducedVersion).HasMaxLength(48);
            entity.Property(e => e.IsAirupdated).HasColumnName("IsAIRUpdated");
            entity.Property(e => e.IsBpfentity).HasColumnName("IsBPFEntity");
            entity.Property(e => e.IsHsmenabled).HasColumnName("IsHSMEnabled");
            entity.Property(e => e.IsSlaenabled).HasColumnName("IsSLAEnabled");
            entity.Property(e => e.LogicalCollectionName).HasMaxLength(64);
            entity.Property(e => e.LogicalName).HasMaxLength(64);
            entity.Property(e => e.MobileOfflineFilters).HasMaxLength(4000);
            entity.Property(e => e.Name).HasMaxLength(64);
            entity.Property(e => e.OriginalLocalizedCollectionName).HasMaxLength(100);
            entity.Property(e => e.OriginalLocalizedName).HasMaxLength(100);
            entity.Property(e => e.OverwriteTime).HasColumnType("datetime");
            entity.Property(e => e.ParentControllingAttributeName).HasMaxLength(100);
            entity.Property(e => e.PhysicalName).HasMaxLength(64);
            entity.Property(e => e.ReportViewName).HasMaxLength(64);
            entity.Property(e => e.ServiceAssembly).HasMaxLength(255);
            entity.Property(e => e.ServiceClassName).HasMaxLength(255);
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<EntityLogicalView>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EntityLogicalView", "crm");

            entity.Property(e => e.AddressTableName).HasMaxLength(64);
            entity.Property(e => e.BaseTableName).HasMaxLength(64);
            entity.Property(e => e.CollectionName).HasMaxLength(64);
            entity.Property(e => e.EntityAssembly).HasMaxLength(255);
            entity.Property(e => e.EntityClassName).HasMaxLength(255);
            entity.Property(e => e.EntityColor).HasMaxLength(7);
            entity.Property(e => e.EntityHelpUrl).HasMaxLength(1024);
            entity.Property(e => e.EntitySetName).HasMaxLength(64);
            entity.Property(e => e.ExtensionTableName).HasMaxLength(64);
            entity.Property(e => e.IconLargeName).HasMaxLength(512);
            entity.Property(e => e.IconMediumName).HasMaxLength(512);
            entity.Property(e => e.IconSmallName).HasMaxLength(512);
            entity.Property(e => e.IntroducedVersion).HasMaxLength(48);
            entity.Property(e => e.IsAirupdated).HasColumnName("IsAIRUpdated");
            entity.Property(e => e.IsBpfentity).HasColumnName("IsBPFEntity");
            entity.Property(e => e.IsHsmenabled).HasColumnName("IsHSMEnabled");
            entity.Property(e => e.IsSlaenabled).HasColumnName("IsSLAEnabled");
            entity.Property(e => e.LogicalCollectionName).HasMaxLength(64);
            entity.Property(e => e.LogicalName).HasMaxLength(64);
            entity.Property(e => e.MobileOfflineFilters).HasMaxLength(4000);
            entity.Property(e => e.Name).HasMaxLength(64);
            entity.Property(e => e.OriginalLocalizedCollectionName).HasMaxLength(100);
            entity.Property(e => e.OriginalLocalizedName).HasMaxLength(100);
            entity.Property(e => e.OverwriteTime).HasColumnType("datetime");
            entity.Property(e => e.ParentControllingAttributeName).HasMaxLength(100);
            entity.Property(e => e.PhysicalName).HasMaxLength(64);
            entity.Property(e => e.ReportViewName).HasMaxLength(64);
            entity.Property(e => e.ServiceAssembly).HasMaxLength(255);
            entity.Property(e => e.ServiceClassName).HasMaxLength(255);
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<EntityMapBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EntityMapBase", "crm");

            entity.HasIndex(e => new { e.TargetEntityName, e.EntityMapId }, "EntityMapBase-20210108-IDX");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OverwriteTime).HasColumnType("datetime");
            entity.Property(e => e.SourceEntityName).HasMaxLength(50);
            entity.Property(e => e.TargetEntityName).HasMaxLength(50);
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<Estado>(entity =>
        {
            entity.HasKey(e => e.IdEstado).HasName("PK_Estado_1");

            entity.ToTable("Estado", "app");

            entity.Property(e => e.Descripción).HasMaxLength(50);
            entity.Property(e => e.Nombre).HasMaxLength(16);
        });

        modelBuilder.Entity<ExtBonificacionTasaMinisterio>(entity =>
        {
            entity.HasKey(e => e.BonificacionTasaMinisterioId).HasName("PK__extBonif__21298B91B915C219");

            entity.ToTable("extBonificacionTasaMinisterio", "app");

            entity.Property(e => e.ActiBa).HasColumnName("ActiBA");
            entity.Property(e => e.CapTrabajoElegible).HasMaxLength(200);
            entity.Property(e => e.ComentarioEvaluador).HasMaxLength(1000);
            entity.Property(e => e.CondTributaria).HasMaxLength(4);
            entity.Property(e => e.ConstanciaAfip)
                .HasMaxLength(50)
                .HasColumnName("ConstanciaAFIP");
            entity.Property(e => e.EstadoElegibilidad).HasMaxLength(4);
            entity.Property(e => e.EstadoRegistro).HasMaxLength(50);
            entity.Property(e => e.FechaModificación).HasColumnType("datetime");
            entity.Property(e => e.IngresosAnualizados).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.InversionElegible).HasMaxLength(200);
            entity.Property(e => e.JustificacionEvaluador).HasMaxLength(200);
            entity.Property(e => e.ModificadoPor).HasMaxLength(50);
            entity.Property(e => e.MontoMaximoElegible).HasColumnType("money");
            entity.Property(e => e.NumCertificado).HasMaxLength(50);
            entity.Property(e => e.Pptmujer).HasColumnName("PPTMujer");
            entity.Property(e => e.PresentacionIibb).HasColumnName("PresentacionIIBB");
            entity.Property(e => e.Provincia).HasMaxLength(50);
            entity.Property(e => e.SituacionImpositiva).HasMaxLength(4);
            entity.Property(e => e.Stamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("stamp");
            entity.Property(e => e.TipoSolicitud).HasMaxLength(4);
            entity.Property(e => e.TotalPuntosBonificacion).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<ExtBonificacionTasaProme>(entity =>
        {
            entity.HasKey(e => e.BonificacionTasaPromeId).HasName("PK__extBonif__ADBBB3A5D384CCB1");

            entity.ToTable("extBonificacionTasaProme", "app");

            entity.Property(e => e.AdjuntosJson).HasMaxLength(4000);
            entity.Property(e => e.CondicionTributaria).HasMaxLength(5);
            entity.Property(e => e.CuitCooperativa).HasMaxLength(11);
            entity.Property(e => e.CuitRelacionado).HasMaxLength(11);
            entity.Property(e => e.DescripcionProyecto).HasMaxLength(1000);
            entity.Property(e => e.EstadoCredCapTrabajo).HasMaxLength(4);
            entity.Property(e => e.EstadoCredito).HasMaxLength(4);
            entity.Property(e => e.EstadoPrev).HasMaxLength(4);
            entity.Property(e => e.EstadoRegistro).HasMaxLength(50);
            entity.Property(e => e.FechaEfectCapTrabajo).HasColumnType("date");
            entity.Property(e => e.FechaEfectivizacion).HasColumnType("date");
            entity.Property(e => e.FechaModificación).HasColumnType("datetime");
            entity.Property(e => e.ModificadoPor).HasMaxLength(50);
            entity.Property(e => e.MontoEfectMonetizado).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.MontoIngresoMensual).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.MontoMonetizado).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.NombreProyectoAsociativo).HasMaxLength(50);
            entity.Property(e => e.Stamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("stamp");
            entity.Property(e => e.TipoMonotributo).HasMaxLength(5);
            entity.Property(e => e.UsuariosAsociadosJson).HasMaxLength(1000);
        });

        modelBuilder.Entity<ExtDescripcionGeneral>(entity =>
        {
            entity.HasKey(e => e.DescripcionGeneralId).HasName("PK__extDescr__10EED01C1A91288E");

            entity.ToTable("extDescripcionGeneral", "app");

            entity.Property(e => e.CodDesc).HasMaxLength(4);
            entity.Property(e => e.Codigo).HasMaxLength(4);
            entity.Property(e => e.Descripcion).HasMaxLength(200);
            entity.Property(e => e.Valor).HasMaxLength(200);
        });

        modelBuilder.Entity<Fallecido>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Fallecidos", "crm");

            entity.Property(e => e.DocTipo)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.FechaFallecimiento).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.PnetDeseasedCustomer).HasColumnName("pnet_DeseasedCustomer");
            entity.Property(e => e.PnetDocumentNumber).HasColumnName("pnet_DocumentNumber");
            entity.Property(e => e.RegistradoPor).HasMaxLength(100);
        });

        modelBuilder.Entity<FallecidosCrm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FallecidosCRM", "int");

            entity.Property(e => e.DocTipo)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.FechaFallecimiento).HasColumnType("datetime");
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.PnetDeseasedCustomer).HasColumnName("pnet_DeseasedCustomer");
            entity.Property(e => e.RegistradoPor).HasMaxLength(100);
        });

        modelBuilder.Entity<Fecha>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Fecha", "app");

            entity.Property(e => e.Año).HasColumnType("datetime");
            entity.Property(e => e.AñoNombre)
                .HasMaxLength(50)
                .HasColumnName("Año_Nombre");
            entity.Property(e => e.Bimestre).HasColumnType("datetime");
            entity.Property(e => e.BimestreDelAño).HasColumnName("Bimestre_del_Año");
            entity.Property(e => e.BimestreDelAñoNombre)
                .HasMaxLength(50)
                .HasColumnName("Bimestre_del_Año_Nombre");
            entity.Property(e => e.BimestreNombre)
                .HasMaxLength(50)
                .HasColumnName("Bimestre_Nombre");
            entity.Property(e => e.DíaDeLaSemana).HasColumnName("Día_de_la_Semana");
            entity.Property(e => e.DíaDeLaSemanaNombre)
                .HasMaxLength(50)
                .HasColumnName("Día_de_la_Semana_Nombre");
            entity.Property(e => e.DíaDelAño).HasColumnName("Día_del_Año");
            entity.Property(e => e.DíaDelAñoNombre)
                .HasMaxLength(50)
                .HasColumnName("Día_del_Año_Nombre");
            entity.Property(e => e.DíaDelMes).HasColumnName("Día_del_Mes");
            entity.Property(e => e.DíaDelMesNombre)
                .HasMaxLength(50)
                .HasColumnName("Día_del_Mes_Nombre");
            entity.Property(e => e.DíaDelSemestre).HasColumnName("Día_del_Semestre");
            entity.Property(e => e.DíaDelSemestreNombre)
                .HasMaxLength(50)
                .HasColumnName("Día_del_Semestre_Nombre");
            entity.Property(e => e.DíaDelTrimestre).HasColumnName("Día_del_Trimestre");
            entity.Property(e => e.DíaDelTrimestreNombre)
                .HasMaxLength(50)
                .HasColumnName("Día_del_Trimestre_Nombre");
            entity.Property(e => e.FechaNombre)
                .HasMaxLength(50)
                .HasColumnName("Fecha_Nombre");
            entity.Property(e => e.Mes).HasColumnType("datetime");
            entity.Property(e => e.MesDelAño).HasColumnName("Mes_del_Año");
            entity.Property(e => e.MesDelAñoNombre)
                .HasMaxLength(50)
                .HasColumnName("Mes_del_Año_Nombre");
            entity.Property(e => e.MesDelSemestre).HasColumnName("Mes_del_Semestre");
            entity.Property(e => e.MesDelSemestreNombre)
                .HasMaxLength(50)
                .HasColumnName("Mes_del_Semestre_Nombre");
            entity.Property(e => e.MesDelTrimestre).HasColumnName("Mes_del_Trimestre");
            entity.Property(e => e.MesDelTrimestreNombre)
                .HasMaxLength(50)
                .HasColumnName("Mes_del_Trimestre_Nombre");
            entity.Property(e => e.MesNombre)
                .HasMaxLength(50)
                .HasColumnName("Mes_Nombre");
            entity.Property(e => e.Semana).HasColumnType("datetime");
            entity.Property(e => e.SemanaDelAño).HasColumnName("Semana_del_Año");
            entity.Property(e => e.SemanaDelAñoNombre)
                .HasMaxLength(50)
                .HasColumnName("Semana_del_Año_Nombre");
            entity.Property(e => e.SemanaNombre)
                .HasMaxLength(50)
                .HasColumnName("Semana_Nombre");
            entity.Property(e => e.Semestre).HasColumnType("datetime");
            entity.Property(e => e.SemestreDelAño).HasColumnName("Semestre_del_Año");
            entity.Property(e => e.SemestreDelAñoNombre)
                .HasMaxLength(50)
                .HasColumnName("Semestre_del_Año_Nombre");
            entity.Property(e => e.SemestreNombre)
                .HasMaxLength(50)
                .HasColumnName("Semestre_Nombre");
            entity.Property(e => e.SkFecha)
                .HasColumnType("datetime")
                .HasColumnName("skFecha");
            entity.Property(e => e.Trimestre).HasColumnType("datetime");
            entity.Property(e => e.TrimestreDelAño).HasColumnName("Trimestre_del_Año");
            entity.Property(e => e.TrimestreDelAñoNombre)
                .HasMaxLength(50)
                .HasColumnName("Trimestre_del_Año_Nombre");
            entity.Property(e => e.TrimestreDelSemestre).HasColumnName("Trimestre_del_Semestre");
            entity.Property(e => e.TrimestreDelSemestreNombre)
                .HasMaxLength(50)
                .HasColumnName("Trimestre_del_Semestre_Nombre");
            entity.Property(e => e.TrimestreNombre)
                .HasMaxLength(50)
                .HasColumnName("Trimestre_Nombre");
        });

        modelBuilder.Entity<FechaFeriado>(entity =>
        {
            entity.HasKey(e => e.Fecha);

            entity.ToTable("FechaFeriado", "app");

            entity.Property(e => e.Fecha).HasColumnType("date");
            entity.Property(e => e.FechaCreación).HasColumnType("datetime");
            entity.Property(e => e.FechaModificación).HasColumnType("datetime");
            entity.Property(e => e.Feriado).HasMaxLength(50);
            entity.Property(e => e.ModificadoPor).HasMaxLength(50);
        });

        modelBuilder.Entity<FlujoFondosSur>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FlujoFondosSur", "app");

            entity.Property(e => e.Amort60Mes)
                .HasColumnType("money")
                .HasColumnName("AMORT 60 MES");
            entity.Property(e => e.AmortPrevias)
                .HasColumnType("money")
                .HasColumnName("AMORT PREVIAS");
            entity.Property(e => e.AmortResto)
                .HasColumnType("money")
                .HasColumnName("AMORT RESTO");
            entity.Property(e => e.Archivo).HasMaxLength(255);
            entity.Property(e => e.CapOtorgado)
                .HasColumnType("money")
                .HasColumnName("CAP OTORGADO");
            entity.Property(e => e.CodSis).HasColumnName("COD SIS");
            entity.Property(e => e.CtroZonal).HasColumnName("CTRO ZONAL");
            entity.Property(e => e.Dest)
                .HasMaxLength(15)
                .HasColumnName("DEST");
            entity.Property(e => e.FecAlta)
                .HasColumnType("date")
                .HasColumnName("FEC ALTA");
            entity.Property(e => e.FecProces)
                .HasColumnType("date")
                .HasColumnName("FEC PROCES");
            entity.Property(e => e.FecVto)
                .HasColumnType("date")
                .HasColumnName("FEC VTO");
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.Filial).HasMaxLength(8);
            entity.Property(e => e.FilialProme).HasColumnName("Filial Prome");
            entity.Property(e => e.IdProceso).HasMaxLength(34);
            entity.Property(e => e.ImpCuota01)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(01)");
            entity.Property(e => e.ImpCuota02)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(02)");
            entity.Property(e => e.ImpCuota03)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(03)");
            entity.Property(e => e.ImpCuota04)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(04)");
            entity.Property(e => e.ImpCuota05)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(05)");
            entity.Property(e => e.ImpCuota06)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(06)");
            entity.Property(e => e.ImpCuota07)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(07)");
            entity.Property(e => e.ImpCuota08)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(08)");
            entity.Property(e => e.ImpCuota09)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(09)");
            entity.Property(e => e.ImpCuota10)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(10)");
            entity.Property(e => e.ImpCuota11)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(11)");
            entity.Property(e => e.ImpCuota12)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(12)");
            entity.Property(e => e.ImpCuota13)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(13)");
            entity.Property(e => e.ImpCuota14)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(14)");
            entity.Property(e => e.ImpCuota15)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(15)");
            entity.Property(e => e.ImpCuota16)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(16)");
            entity.Property(e => e.ImpCuota17)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(17)");
            entity.Property(e => e.ImpCuota18)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(18)");
            entity.Property(e => e.ImpCuota19)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(19)");
            entity.Property(e => e.ImpCuota20)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(20)");
            entity.Property(e => e.ImpCuota21)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(21)");
            entity.Property(e => e.ImpCuota22)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(22)");
            entity.Property(e => e.ImpCuota23)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(23)");
            entity.Property(e => e.ImpCuota24)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(24)");
            entity.Property(e => e.ImpCuota25)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(25)");
            entity.Property(e => e.ImpCuota26)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(26)");
            entity.Property(e => e.ImpCuota27)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(27)");
            entity.Property(e => e.ImpCuota28)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(28)");
            entity.Property(e => e.ImpCuota29)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(29)");
            entity.Property(e => e.ImpCuota30)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(30)");
            entity.Property(e => e.ImpCuota31)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(31)");
            entity.Property(e => e.ImpCuota32)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(32)");
            entity.Property(e => e.ImpCuota33)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(33)");
            entity.Property(e => e.ImpCuota34)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(34)");
            entity.Property(e => e.ImpCuota35)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(35)");
            entity.Property(e => e.ImpCuota36)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(36)");
            entity.Property(e => e.ImpCuota37)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(37)");
            entity.Property(e => e.ImpCuota38)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(38)");
            entity.Property(e => e.ImpCuota39)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(39)");
            entity.Property(e => e.ImpCuota40)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(40)");
            entity.Property(e => e.ImpCuota41)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(41)");
            entity.Property(e => e.ImpCuota42)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(42)");
            entity.Property(e => e.ImpCuota43)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(43)");
            entity.Property(e => e.ImpCuota44)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(44)");
            entity.Property(e => e.ImpCuota45)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(45)");
            entity.Property(e => e.ImpCuota46)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(46)");
            entity.Property(e => e.ImpCuota47)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(47)");
            entity.Property(e => e.ImpCuota48)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(48)");
            entity.Property(e => e.ImpCuota49)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(49)");
            entity.Property(e => e.ImpCuota50)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(50)");
            entity.Property(e => e.ImpCuota51)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(51)");
            entity.Property(e => e.ImpCuota52)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(52)");
            entity.Property(e => e.ImpCuota53)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(53)");
            entity.Property(e => e.ImpCuota54)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(54)");
            entity.Property(e => e.ImpCuota55)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(55)");
            entity.Property(e => e.ImpCuota56)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(56)");
            entity.Property(e => e.ImpCuota57)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(57)");
            entity.Property(e => e.ImpCuota58)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(58)");
            entity.Property(e => e.ImpCuota59)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(59)");
            entity.Property(e => e.ImpCuota60)
                .HasColumnType("money")
                .HasColumnName("IMP-CUOTA(60)");
            entity.Property(e => e.ImpDispuesto)
                .HasColumnType("money")
                .HasColumnName("IMP DISPUESTO");
            entity.Property(e => e.Linea).HasColumnName("LINEA");
            entity.Property(e => e.Mod).HasColumnName("MOD");
            entity.Property(e => e.Ofic)
                .HasMaxLength(15)
                .HasColumnName("OFIC");
            entity.Property(e => e.Orig)
                .HasMaxLength(15)
                .HasColumnName("ORIG");
            entity.Property(e => e.Prestamo)
                .HasMaxLength(15)
                .HasColumnName("PRESTAMO");
            entity.Property(e => e.Prod).HasColumnName("PROD");
            entity.Property(e => e.Rubro)
                .HasMaxLength(15)
                .HasColumnName("RUBRO");
            entity.Property(e => e.Sucursal).HasMaxLength(50);
            entity.Property(e => e.Tasa)
                .HasColumnType("numeric(15, 4)")
                .HasColumnName("TASA");
            entity.Property(e => e.TipReg).HasColumnName("TIP REG");
            entity.Property(e => e.Tna)
                .HasColumnType("numeric(15, 4)")
                .HasColumnName("TNA");
            entity.Property(e => e.VtoCuota01)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(01)");
            entity.Property(e => e.VtoCuota02)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(02)");
            entity.Property(e => e.VtoCuota03)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(03)");
            entity.Property(e => e.VtoCuota04)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(04)");
            entity.Property(e => e.VtoCuota05)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(05)");
            entity.Property(e => e.VtoCuota06)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(06)");
            entity.Property(e => e.VtoCuota07)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(07)");
            entity.Property(e => e.VtoCuota08)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(08)");
            entity.Property(e => e.VtoCuota09)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(09)");
            entity.Property(e => e.VtoCuota10)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(10)");
            entity.Property(e => e.VtoCuota11)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(11)");
            entity.Property(e => e.VtoCuota12)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(12)");
            entity.Property(e => e.VtoCuota13)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(13)");
            entity.Property(e => e.VtoCuota14)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(14)");
            entity.Property(e => e.VtoCuota15)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(15)");
            entity.Property(e => e.VtoCuota16)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(16)");
            entity.Property(e => e.VtoCuota17)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(17)");
            entity.Property(e => e.VtoCuota18)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(18)");
            entity.Property(e => e.VtoCuota19)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(19)");
            entity.Property(e => e.VtoCuota20)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(20)");
            entity.Property(e => e.VtoCuota21)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(21)");
            entity.Property(e => e.VtoCuota22)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(22)");
            entity.Property(e => e.VtoCuota23)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(23)");
            entity.Property(e => e.VtoCuota24)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(24)");
            entity.Property(e => e.VtoCuota25)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(25)");
            entity.Property(e => e.VtoCuota26)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(26)");
            entity.Property(e => e.VtoCuota27)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(27)");
            entity.Property(e => e.VtoCuota28)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(28)");
            entity.Property(e => e.VtoCuota29)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(29)");
            entity.Property(e => e.VtoCuota30)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(30)");
            entity.Property(e => e.VtoCuota31)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(31)");
            entity.Property(e => e.VtoCuota32)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(32)");
            entity.Property(e => e.VtoCuota33)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(33)");
            entity.Property(e => e.VtoCuota34)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(34)");
            entity.Property(e => e.VtoCuota35)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(35)");
            entity.Property(e => e.VtoCuota36)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(36)");
            entity.Property(e => e.VtoCuota37)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(37)");
            entity.Property(e => e.VtoCuota38)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(38)");
            entity.Property(e => e.VtoCuota39)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(39)");
            entity.Property(e => e.VtoCuota40)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(40)");
            entity.Property(e => e.VtoCuota41)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(41)");
            entity.Property(e => e.VtoCuota42)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(42)");
            entity.Property(e => e.VtoCuota43)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(43)");
            entity.Property(e => e.VtoCuota44)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(44)");
            entity.Property(e => e.VtoCuota45)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(45)");
            entity.Property(e => e.VtoCuota46)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(46)");
            entity.Property(e => e.VtoCuota47)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(47)");
            entity.Property(e => e.VtoCuota48)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(48)");
            entity.Property(e => e.VtoCuota49)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(49)");
            entity.Property(e => e.VtoCuota50)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(50)");
            entity.Property(e => e.VtoCuota51)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(51)");
            entity.Property(e => e.VtoCuota52)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(52)");
            entity.Property(e => e.VtoCuota53)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(53)");
            entity.Property(e => e.VtoCuota54)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(54)");
            entity.Property(e => e.VtoCuota55)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(55)");
            entity.Property(e => e.VtoCuota56)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(56)");
            entity.Property(e => e.VtoCuota57)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(57)");
            entity.Property(e => e.VtoCuota58)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(58)");
            entity.Property(e => e.VtoCuota59)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(59)");
            entity.Property(e => e.VtoCuota60)
                .HasColumnType("date")
                .HasColumnName("VTO-CUOTA(60)");
            entity.Property(e => e.Zona).HasMaxLength(50);
        });

        modelBuilder.Entity<FlujoFondosSur1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FlujoFondosSur", "int");

            entity.Property(e => e.Amort60Mes)
                .HasMaxLength(512)
                .HasColumnName("AMORT 60 MES");
            entity.Property(e => e.AmortPrevias)
                .HasMaxLength(512)
                .HasColumnName("AMORT PREVIAS");
            entity.Property(e => e.AmortResto)
                .HasMaxLength(512)
                .HasColumnName("AMORT RESTO");
            entity.Property(e => e.Archivo).HasMaxLength(512);
            entity.Property(e => e.CapOtorgado)
                .HasMaxLength(512)
                .HasColumnName("CAP OTORGADO");
            entity.Property(e => e.CodSis)
                .HasMaxLength(512)
                .HasColumnName("COD SIS");
            entity.Property(e => e.CtroZonal)
                .HasMaxLength(512)
                .HasColumnName("CTRO ZONAL");
            entity.Property(e => e.Dest)
                .HasMaxLength(512)
                .HasColumnName("DEST");
            entity.Property(e => e.FecAlta)
                .HasMaxLength(512)
                .HasColumnName("FEC ALTA");
            entity.Property(e => e.FecProces)
                .HasMaxLength(512)
                .HasColumnName("FEC PROCES");
            entity.Property(e => e.FecVto)
                .HasMaxLength(512)
                .HasColumnName("FEC VTO");
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.IdProceso).HasMaxLength(34);
            entity.Property(e => e.ImpCuota01)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(01)");
            entity.Property(e => e.ImpCuota02)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(02)");
            entity.Property(e => e.ImpCuota03)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(03)");
            entity.Property(e => e.ImpCuota04)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(04)");
            entity.Property(e => e.ImpCuota05)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(05)");
            entity.Property(e => e.ImpCuota06)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(06)");
            entity.Property(e => e.ImpCuota07)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(07)");
            entity.Property(e => e.ImpCuota08)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(08)");
            entity.Property(e => e.ImpCuota09)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(09)");
            entity.Property(e => e.ImpCuota10)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(10)");
            entity.Property(e => e.ImpCuota11)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(11)");
            entity.Property(e => e.ImpCuota12)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(12)");
            entity.Property(e => e.ImpCuota13)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(13)");
            entity.Property(e => e.ImpCuota14)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(14)");
            entity.Property(e => e.ImpCuota15)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(15)");
            entity.Property(e => e.ImpCuota16)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(16)");
            entity.Property(e => e.ImpCuota17)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(17)");
            entity.Property(e => e.ImpCuota18)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(18)");
            entity.Property(e => e.ImpCuota19)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(19)");
            entity.Property(e => e.ImpCuota20)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(20)");
            entity.Property(e => e.ImpCuota21)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(21)");
            entity.Property(e => e.ImpCuota22)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(22)");
            entity.Property(e => e.ImpCuota23)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(23)");
            entity.Property(e => e.ImpCuota24)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(24)");
            entity.Property(e => e.ImpCuota25)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(25)");
            entity.Property(e => e.ImpCuota26)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(26)");
            entity.Property(e => e.ImpCuota27)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(27)");
            entity.Property(e => e.ImpCuota28)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(28)");
            entity.Property(e => e.ImpCuota29)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(29)");
            entity.Property(e => e.ImpCuota30)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(30)");
            entity.Property(e => e.ImpCuota31)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(31)");
            entity.Property(e => e.ImpCuota32)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(32)");
            entity.Property(e => e.ImpCuota33)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(33)");
            entity.Property(e => e.ImpCuota34)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(34)");
            entity.Property(e => e.ImpCuota35)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(35)");
            entity.Property(e => e.ImpCuota36)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(36)");
            entity.Property(e => e.ImpCuota37)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(37)");
            entity.Property(e => e.ImpCuota38)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(38)");
            entity.Property(e => e.ImpCuota39)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(39)");
            entity.Property(e => e.ImpCuota40)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(40)");
            entity.Property(e => e.ImpCuota41)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(41)");
            entity.Property(e => e.ImpCuota42)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(42)");
            entity.Property(e => e.ImpCuota43)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(43)");
            entity.Property(e => e.ImpCuota44)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(44)");
            entity.Property(e => e.ImpCuota45)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(45)");
            entity.Property(e => e.ImpCuota46)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(46)");
            entity.Property(e => e.ImpCuota47)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(47)");
            entity.Property(e => e.ImpCuota48)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(48)");
            entity.Property(e => e.ImpCuota49)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(49)");
            entity.Property(e => e.ImpCuota50)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(50)");
            entity.Property(e => e.ImpCuota51)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(51)");
            entity.Property(e => e.ImpCuota52)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(52)");
            entity.Property(e => e.ImpCuota53)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(53)");
            entity.Property(e => e.ImpCuota54)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(54)");
            entity.Property(e => e.ImpCuota55)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(55)");
            entity.Property(e => e.ImpCuota56)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(56)");
            entity.Property(e => e.ImpCuota57)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(57)");
            entity.Property(e => e.ImpCuota58)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(58)");
            entity.Property(e => e.ImpCuota59)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(59)");
            entity.Property(e => e.ImpCuota60)
                .HasMaxLength(512)
                .HasColumnName("IMP-CUOTA(60)");
            entity.Property(e => e.ImpDispuesto)
                .HasMaxLength(512)
                .HasColumnName("IMP DISPUESTO");
            entity.Property(e => e.Linea)
                .HasMaxLength(512)
                .HasColumnName("LINEA");
            entity.Property(e => e.Mod)
                .HasMaxLength(512)
                .HasColumnName("MOD");
            entity.Property(e => e.Ofic)
                .HasMaxLength(512)
                .HasColumnName("OFIC");
            entity.Property(e => e.Orig)
                .HasMaxLength(512)
                .HasColumnName("ORIG");
            entity.Property(e => e.Prestamo)
                .HasMaxLength(512)
                .HasColumnName("PRESTAMO");
            entity.Property(e => e.Prod)
                .HasMaxLength(512)
                .HasColumnName("PROD");
            entity.Property(e => e.Rubro)
                .HasMaxLength(512)
                .HasColumnName("RUBRO");
            entity.Property(e => e.Sucursal)
                .HasMaxLength(512)
                .HasColumnName("SUCURSAL");
            entity.Property(e => e.Tasa)
                .HasMaxLength(512)
                .HasColumnName("TASA");
            entity.Property(e => e.TipReg)
                .HasMaxLength(512)
                .HasColumnName("TIP REG");
            entity.Property(e => e.Tna)
                .HasMaxLength(512)
                .HasColumnName("TNA");
            entity.Property(e => e.VtoCuota01)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(01)");
            entity.Property(e => e.VtoCuota02)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(02)");
            entity.Property(e => e.VtoCuota03)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(03)");
            entity.Property(e => e.VtoCuota04)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(04)");
            entity.Property(e => e.VtoCuota05)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(05)");
            entity.Property(e => e.VtoCuota06)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(06)");
            entity.Property(e => e.VtoCuota07)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(07)");
            entity.Property(e => e.VtoCuota08)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(08)");
            entity.Property(e => e.VtoCuota09)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(09)");
            entity.Property(e => e.VtoCuota10)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(10)");
            entity.Property(e => e.VtoCuota11)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(11)");
            entity.Property(e => e.VtoCuota12)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(12)");
            entity.Property(e => e.VtoCuota13)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(13)");
            entity.Property(e => e.VtoCuota14)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(14)");
            entity.Property(e => e.VtoCuota15)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(15)");
            entity.Property(e => e.VtoCuota16)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(16)");
            entity.Property(e => e.VtoCuota17)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(17)");
            entity.Property(e => e.VtoCuota18)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(18)");
            entity.Property(e => e.VtoCuota19)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(19)");
            entity.Property(e => e.VtoCuota20)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(20)");
            entity.Property(e => e.VtoCuota21)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(21)");
            entity.Property(e => e.VtoCuota22)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(22)");
            entity.Property(e => e.VtoCuota23)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(23)");
            entity.Property(e => e.VtoCuota24)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(24)");
            entity.Property(e => e.VtoCuota25)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(25)");
            entity.Property(e => e.VtoCuota26)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(26)");
            entity.Property(e => e.VtoCuota27)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(27)");
            entity.Property(e => e.VtoCuota28)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(28)");
            entity.Property(e => e.VtoCuota29)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(29)");
            entity.Property(e => e.VtoCuota30)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(30)");
            entity.Property(e => e.VtoCuota31)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(31)");
            entity.Property(e => e.VtoCuota32)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(32)");
            entity.Property(e => e.VtoCuota33)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(33)");
            entity.Property(e => e.VtoCuota34)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(34)");
            entity.Property(e => e.VtoCuota35)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(35)");
            entity.Property(e => e.VtoCuota36)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(36)");
            entity.Property(e => e.VtoCuota37)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(37)");
            entity.Property(e => e.VtoCuota38)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(38)");
            entity.Property(e => e.VtoCuota39)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(39)");
            entity.Property(e => e.VtoCuota40)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(40)");
            entity.Property(e => e.VtoCuota41)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(41)");
            entity.Property(e => e.VtoCuota42)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(42)");
            entity.Property(e => e.VtoCuota43)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(43)");
            entity.Property(e => e.VtoCuota44)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(44)");
            entity.Property(e => e.VtoCuota45)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(45)");
            entity.Property(e => e.VtoCuota46)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(46)");
            entity.Property(e => e.VtoCuota47)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(47)");
            entity.Property(e => e.VtoCuota48)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(48)");
            entity.Property(e => e.VtoCuota49)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(49)");
            entity.Property(e => e.VtoCuota50)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(50)");
            entity.Property(e => e.VtoCuota51)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(51)");
            entity.Property(e => e.VtoCuota52)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(52)");
            entity.Property(e => e.VtoCuota53)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(53)");
            entity.Property(e => e.VtoCuota54)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(54)");
            entity.Property(e => e.VtoCuota55)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(55)");
            entity.Property(e => e.VtoCuota56)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(56)");
            entity.Property(e => e.VtoCuota57)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(57)");
            entity.Property(e => e.VtoCuota58)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(58)");
            entity.Property(e => e.VtoCuota59)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(59)");
            entity.Property(e => e.VtoCuota60)
                .HasMaxLength(512)
                .HasColumnName("VTO-CUOTA(60)");
        });

        modelBuilder.Entity<FtpwatcherConfig>(entity =>
        {
            entity.HasKey(e => e.IdFtpwatcherConfig).HasName("PK_appFTPwatcherConfig");

            entity.ToTable("FTPwatcherConfig", "app");

            entity.Property(e => e.IdFtpwatcherConfig).HasColumnName("IdFTPwatcherConfig");
            entity.Property(e => e.Acciones).HasMaxLength(1000);
            entity.Property(e => e.Host)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Ruta)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GeCalipso>(entity =>
        {
            entity.HasKey(e => e.IdgeCalipso);

            entity.ToTable("geCalipso", "fin");

            entity.Property(e => e.IdgeCalipso).HasColumnName("idgeCalipso");
            entity.Property(e => e.AjusteInflación).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Archivo).HasMaxLength(255);
            entity.Property(e => e.CentroCostos).HasMaxLength(50);
            entity.Property(e => e.Clasificación).HasMaxLength(50);
            entity.Property(e => e.CodProy).HasMaxLength(50);
            entity.Property(e => e.Descripción).HasMaxLength(255);
            entity.Property(e => e.DetalleAsiento).HasMaxLength(255);
            entity.Property(e => e.Fecha).HasColumnType("date");
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.Gerencia).HasMaxLength(50);
            entity.Property(e => e.IdProceso).HasMaxLength(50);
            entity.Property(e => e.Idasiento)
                .HasMaxLength(50)
                .HasColumnName("IDASIENTO");
            entity.Property(e => e.Línea).HasMaxLength(50);
            entity.Property(e => e.Periodo).HasColumnType("date");
            entity.Property(e => e.Presupuesto).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Proveedor).HasMaxLength(255);
            entity.Property(e => e.Proyecto).HasMaxLength(255);
            entity.Property(e => e.Real).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Rubro).HasMaxLength(255);
            entity.Property(e => e.Subrubro).HasMaxLength(255);
            entity.Property(e => e.Zona).HasMaxLength(50);
        });

        modelBuilder.Entity<GeCalipso1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("geCalipso", "int");

            entity.Property(e => e.AjusteInflación).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Archivo).HasMaxLength(255);
            entity.Property(e => e.CentroCostos).HasMaxLength(255);
            entity.Property(e => e.Clasificación).HasMaxLength(255);
            entity.Property(e => e.CodProy).HasMaxLength(255);
            entity.Property(e => e.Descripción).HasMaxLength(255);
            entity.Property(e => e.DetalleAsiento).HasMaxLength(255);
            entity.Property(e => e.Fecha).HasColumnType("date");
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.Gerencia).HasMaxLength(255);
            entity.Property(e => e.IdProceso).HasMaxLength(50);
            entity.Property(e => e.Idasiento)
                .HasMaxLength(255)
                .HasColumnName("IDASIENTO");
            entity.Property(e => e.Línea).HasMaxLength(255);
            entity.Property(e => e.Presupuesto).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Proveedor).HasMaxLength(255);
            entity.Property(e => e.Proyecto).HasMaxLength(255);
            entity.Property(e => e.Real).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Rubro).HasMaxLength(255);
            entity.Property(e => e.Subrubro).HasMaxLength(255);
            entity.Property(e => e.Zona).HasMaxLength(255);
        });

        modelBuilder.Entity<GeDistribucion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("geDistribucion", "int");

            entity.Property(e => e.Archivo).HasMaxLength(255);
            entity.Property(e => e.Categoría).HasMaxLength(50);
            entity.Property(e => e.Concepto).HasMaxLength(30);
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.IdProceso).HasMaxLength(50);
            entity.Property(e => e.Periodo).HasColumnType("date");
            entity.Property(e => e.Ponderación).HasColumnType("numeric(18, 6)");
            entity.Property(e => e.QSuc)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("qSuc");
            entity.Property(e => e.QSucPond)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("qSucPond");
            entity.Property(e => e.QTotPond)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("qTotPond");
            entity.Property(e => e.QTotal)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("qTotal");
            entity.Property(e => e.Sucursal).HasMaxLength(50);
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<GeRentabilidadxUn>(entity =>
        {
            entity.HasKey(e => e.IdRentabilidadxUn);

            entity.ToTable("geRentabilidadxUN", "fin");

            entity.Property(e => e.IdRentabilidadxUn).HasColumnName("idRentabilidadxUN");
            entity.Property(e => e.AmortizacionesEIngresosFinancieros)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Amortizaciones e Ingresos Financieros");
            entity.Property(e => e.Archivo).HasMaxLength(255);
            entity.Property(e => e.CentroCostos).HasMaxLength(50);
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.GaoPresupuesto)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("GAO Presupuesto");
            entity.Property(e => e.GaoPresupuestoCmz)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("GAO Presupuesto CMZ");
            entity.Property(e => e.GaoPresupuestoSucursal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("GAO Presupuesto Sucursal");
            entity.Property(e => e.GaoPresupuestoZonal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("GAO Presupuesto Zonal");
            entity.Property(e => e.GaoReal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("GAO Real");
            entity.Property(e => e.GaoRealCmz)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("GAO Real CMZ");
            entity.Property(e => e.GaoRealSucursal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("GAO Real Sucursal");
            entity.Property(e => e.GaoRealZonal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("GAO Real Zonal");
            entity.Property(e => e.GaoRealZonalCentralizado)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("GAO Real Zonal Centralizado");
            entity.Property(e => e.Gerencia).HasMaxLength(50);
            entity.Property(e => e.IdProceso).HasMaxLength(50);
            entity.Property(e => e.Iibb)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("IIBB");
            entity.Property(e => e.IibbMatriz)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("IIBB Matriz");
            entity.Property(e => e.IibbRedMatriz)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("IIBB RED Matriz");
            entity.Property(e => e.IibbSucursal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("IIBB Sucursal");
            entity.Property(e => e.IibbZonal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("IIBB Zonal");
            entity.Property(e => e.IngresosPorComisionRedMatriz)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("Ingresos por Comision RED Matriz");
            entity.Property(e => e.IngresosPorComisiones)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Ingresos por Comisiones");
            entity.Property(e => e.IngresosPorComisionesMatriz)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Ingresos por Comisiones Matriz");
            entity.Property(e => e.IngresosPorComisionesSucursal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Ingresos por Comisiones Sucursal");
            entity.Property(e => e.IngresosPorComisionesZonal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Ingresos por Comisiones Zonal");
            entity.Property(e => e.IngresosPorFacturacionReal)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("Ingresos Por Facturacion Real");
            entity.Property(e => e.IngresosPorFacturacionRedMatriz)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("Ingresos por Facturacion RED Matriz");
            entity.Property(e => e.OtrosCostosOperativos)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Otros Costos Operativos");
            entity.Property(e => e.Periodo).HasColumnType("date");
            entity.Property(e => e.RendimientoFinanciero)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Rendimiento Financiero");
            entity.Property(e => e.RendimientoFinancieroMatriz)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Rendimiento Financiero Matriz");
            entity.Property(e => e.RendimientoFinancieroRedMatriz)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("Rendimiento Financiero RED Matriz");
            entity.Property(e => e.RendimientoFinancieroSucursal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Rendimiento Financiero Sucursal");
            entity.Property(e => e.RendimientoFinancieroZonal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Rendimiento Financiero Zonal");
            entity.Property(e => e.SueldosPresupuesto)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Sueldos Presupuesto");
            entity.Property(e => e.SueldosPresupuestoCmz)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Sueldos Presupuesto CMZ");
            entity.Property(e => e.SueldosPresupuestoSucursal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Sueldos Presupuesto Sucursal");
            entity.Property(e => e.SueldosPresupuestoZonal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Sueldos Presupuesto Zonal");
            entity.Property(e => e.SueldosReal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Sueldos Real");
            entity.Property(e => e.SueldosRealCmz)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Sueldos Real CMZ");
            entity.Property(e => e.SueldosRealSucursal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Sueldos Real Sucursal");
            entity.Property(e => e.SueldosRealZonal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Sueldos Real Zonal");
            entity.Property(e => e.Ver).HasColumnName("ver");
            entity.Property(e => e.Zona).HasMaxLength(50);
        });

        modelBuilder.Entity<GeRentabilidadxUnaXi>(entity =>
        {
            entity.HasKey(e => e.IdRentabilidadxUn);

            entity.ToTable("geRentabilidadxUNaXi", "fin");

            entity.Property(e => e.IdRentabilidadxUn)
                .ValueGeneratedNever()
                .HasColumnName("idRentabilidadxUN");
            entity.Property(e => e.AmortizacionesEIngresosFinancieros)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Amortizaciones e Ingresos Financieros");
            entity.Property(e => e.Archivo).HasMaxLength(255);
            entity.Property(e => e.CentroCostos).HasMaxLength(50);
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.GaoPresupuesto)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("GAO Presupuesto");
            entity.Property(e => e.GaoPresupuestoCmz)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("GAO Presupuesto CMZ");
            entity.Property(e => e.GaoPresupuestoSucursal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("GAO Presupuesto Sucursal");
            entity.Property(e => e.GaoPresupuestoZonal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("GAO Presupuesto Zonal");
            entity.Property(e => e.GaoReal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("GAO Real");
            entity.Property(e => e.GaoRealCmz)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("GAO Real CMZ");
            entity.Property(e => e.GaoRealSucursal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("GAO Real Sucursal");
            entity.Property(e => e.GaoRealZonal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("GAO Real Zonal");
            entity.Property(e => e.GaoRealZonalCentralizado)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("GAO Real Zonal Centralizado");
            entity.Property(e => e.IdProceso).HasMaxLength(50);
            entity.Property(e => e.Iibb)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("IIBB");
            entity.Property(e => e.IibbMatriz)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("IIBB Matriz");
            entity.Property(e => e.IibbRedMatriz)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("IIBB RED Matriz");
            entity.Property(e => e.IibbSucursal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("IIBB Sucursal");
            entity.Property(e => e.IibbZonal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("IIBB Zonal");
            entity.Property(e => e.IngresosPorComisionRedMatriz)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("Ingresos por Comision RED Matriz");
            entity.Property(e => e.IngresosPorComisiones)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Ingresos por Comisiones");
            entity.Property(e => e.IngresosPorComisionesMatriz)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Ingresos por Comisiones Matriz");
            entity.Property(e => e.IngresosPorComisionesSucursal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Ingresos por Comisiones Sucursal");
            entity.Property(e => e.IngresosPorComisionesZonal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Ingresos por Comisiones Zonal");
            entity.Property(e => e.IngresosPorFacturacionReal)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("Ingresos Por Facturacion Real");
            entity.Property(e => e.IngresosPorFacturacionRedMatriz)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("Ingresos por Facturacion RED Matriz");
            entity.Property(e => e.OtrosCostosOperativos)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Otros Costos Operativos");
            entity.Property(e => e.Periodo).HasColumnType("date");
            entity.Property(e => e.PeriodoIndice).HasColumnType("date");
            entity.Property(e => e.RendimientoFinanciero)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Rendimiento Financiero");
            entity.Property(e => e.RendimientoFinancieroMatriz)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Rendimiento Financiero Matriz");
            entity.Property(e => e.RendimientoFinancieroRedMatriz)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("Rendimiento Financiero RED Matriz");
            entity.Property(e => e.RendimientoFinancieroSucursal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Rendimiento Financiero Sucursal");
            entity.Property(e => e.RendimientoFinancieroZonal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Rendimiento Financiero Zonal");
            entity.Property(e => e.SueldosPresupuesto)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Sueldos Presupuesto");
            entity.Property(e => e.SueldosPresupuestoCmz)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Sueldos Presupuesto CMZ");
            entity.Property(e => e.SueldosPresupuestoSucursal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Sueldos Presupuesto Sucursal");
            entity.Property(e => e.SueldosPresupuestoZonal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Sueldos Presupuesto Zonal");
            entity.Property(e => e.SueldosReal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Sueldos Real");
            entity.Property(e => e.SueldosRealCmz)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Sueldos Real CMZ");
            entity.Property(e => e.SueldosRealSucursal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Sueldos Real Sucursal");
            entity.Property(e => e.SueldosRealZonal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Sueldos Real Zonal");
            entity.Property(e => e.Ver).HasColumnName("ver");
            entity.Property(e => e.Zona).HasMaxLength(50);
        });

        modelBuilder.Entity<GpTablero>(entity =>
        {
            entity.HasKey(e => e.IdTableros);

            entity.ToTable("gpTableros", "app");

            entity.Property(e => e.IdTableros).HasColumnName("idTableros");
            entity.Property(e => e.Area).HasMaxLength(30);
            entity.Property(e => e.Descripción).HasMaxLength(512);
            entity.Property(e => e.Fecha).HasColumnType("date");
            entity.Property(e => e.FechaCreación).HasColumnType("datetime");
            entity.Property(e => e.FechaFin).HasColumnType("date");
            entity.Property(e => e.FechaFinReal).HasColumnType("date");
            entity.Property(e => e.FechaInicio).HasColumnType("date");
            entity.Property(e => e.FechaModificación).HasColumnType("datetime");
            entity.Property(e => e.ModificadoPor).HasMaxLength(50);
            entity.Property(e => e.Proyecto).HasMaxLength(50);
            entity.Property(e => e.Responsable).HasMaxLength(50);
            entity.Property(e => e.Stamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("stamp");
        });

        modelBuilder.Entity<GpTableroGantt>(entity =>
        {
            entity.HasKey(e => e.IdTableroGantt).HasName("PK_gpTablero");

            entity.ToTable("gpTableroGantt", "app");

            entity.Property(e => e.IdTableroGantt).HasColumnName("idTableroGantt");
            entity.Property(e => e.Accion).HasMaxLength(20);
            entity.Property(e => e.AvanceAcción).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Descripción).HasMaxLength(512);
            entity.Property(e => e.Fecha).HasColumnType("date");
            entity.Property(e => e.FechaCreación).HasColumnType("datetime");
            entity.Property(e => e.FechaFin).HasColumnType("date");
            entity.Property(e => e.FechaInicio).HasColumnType("date");
            entity.Property(e => e.FechaModificación).HasColumnType("datetime");
            entity.Property(e => e.IdTableros).HasColumnName("idTableros");
            entity.Property(e => e.ModificadoPor).HasMaxLength(50);
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.Responsable).HasMaxLength(50);
            entity.Property(e => e.ResponsableAcción).HasMaxLength(50);
            entity.Property(e => e.Stamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("stamp");
            entity.Property(e => e.Tipo).HasMaxLength(20);

            entity.HasOne(d => d.IdTablerosNavigation).WithMany(p => p.GpTableroGantts)
                .HasForeignKey(d => d.IdTableros)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_gpTableroGantt_gpTableros");
        });

        modelBuilder.Entity<GpTableroKpi>(entity =>
        {
            entity.HasKey(e => e.IdKpi);

            entity.ToTable("gpTableroKPI", "app");

            entity.Property(e => e.IdKpi).HasColumnName("idKpi");
            entity.Property(e => e.Fecha).HasColumnType("date");
            entity.Property(e => e.FechaCreación).HasColumnType("datetime");
            entity.Property(e => e.FechaModificación).HasColumnType("datetime");
            entity.Property(e => e.IdTablero).HasColumnName("idTablero");
            entity.Property(e => e.MetaMax).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.MetaMin).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.ModificadoPor).HasMaxLength(50);
            entity.Property(e => e.NombreKpi)
                .HasMaxLength(32)
                .HasColumnName("NombreKPI");
            entity.Property(e => e.Observaciones).HasMaxLength(255);
            entity.Property(e => e.Stamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("stamp");
            entity.Property(e => e.Valor).HasColumnType("numeric(18, 2)");

            entity.HasOne(d => d.IdTableroNavigation).WithMany(p => p.GpTableroKpis)
                .HasForeignKey(d => d.IdTablero)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_gpTableroKPI_gpTableros");
        });

        modelBuilder.Entity<GravityChoice>(entity =>
        {
            entity.HasKey(e => new { e.SkForm, e.SkField, e.SkChoice });

            entity.ToTable("GravityChoices", "app");

            entity.Property(e => e.SkForm).HasColumnName("skForm");
            entity.Property(e => e.SkField).HasColumnName("skField");
            entity.Property(e => e.SkChoice)
                .ValueGeneratedOnAdd()
                .HasColumnName("skChoice");
            entity.Property(e => e.Modificado).HasColumnType("datetime");
            entity.Property(e => e.ModificadoPor).HasMaxLength(50);
            entity.Property(e => e.Text).HasMaxLength(500);
            entity.Property(e => e.ValorCrm)
                .HasMaxLength(500)
                .HasColumnName("ValorCRM");
            entity.Property(e => e.Value).HasMaxLength(500);
        });

        modelBuilder.Entity<GravityField>(entity =>
        {
            entity.HasKey(e => new { e.SkForm, e.SkField }).HasName("PK_GravityFields_1");

            entity.ToTable("GravityFields", "app");

            entity.Property(e => e.SkForm).HasColumnName("skForm");
            entity.Property(e => e.SkField)
                .ValueGeneratedOnAdd()
                .HasColumnName("skField");
            entity.Property(e => e.CampoCrm).HasColumnName("CampoCRM");
            entity.Property(e => e.Label).HasMaxLength(256);
            entity.Property(e => e.Modificado).HasColumnType("datetime");
            entity.Property(e => e.ModificadoPor).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<GravityForm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("GravityForms", "app");

            entity.Property(e => e.Creado).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.Modificado).HasColumnType("datetime");
            entity.Property(e => e.ModificadoPor).HasMaxLength(50);
            entity.Property(e => e.SkForm)
                .ValueGeneratedOnAdd()
                .HasColumnName("skForm");
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.Version).HasMaxLength(50);
        });

        modelBuilder.Entity<GravityFormsBase>(entity =>
        {
            entity.HasKey(e => e.SkForm).HasName("PK_GravityForms_1");

            entity.ToTable("GravityFormsBase", "app");

            entity.Property(e => e.SkForm).HasColumnName("skForm");
            entity.Property(e => e.Creado).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.Modificado).HasColumnType("datetime");
            entity.Property(e => e.ModificadoPor).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.Version).HasMaxLength(50);
        });

        modelBuilder.Entity<HistorialJob>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HistorialJobs", "app");

            entity.HasIndex(e => new { e.Server, e.InstanceId, e.RunStatus, e.RunDuration }, "IDX_appHistorialJobs_01");

            entity.HasIndex(e => e.RunDate, "nci_wi_HistorialJobs_3770D6BD0D89C503FCDB396998C656D2");

            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.IdProceso).HasMaxLength(50);
            entity.Property(e => e.InstanceId).HasColumnName("InstanceID");
            entity.Property(e => e.JobId).HasColumnName("JobID");
            entity.Property(e => e.JobName).HasMaxLength(128);
            entity.Property(e => e.Message).HasMaxLength(4000);
            entity.Property(e => e.OperatorEmailed).HasMaxLength(128);
            entity.Property(e => e.OperatorNetsent).HasMaxLength(128);
            entity.Property(e => e.OperatorPaged).HasMaxLength(128);
            entity.Property(e => e.RunDate).HasColumnType("datetime");
            entity.Property(e => e.RunStatusDesc)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.Server).HasMaxLength(128);
            entity.Property(e => e.SqlMessageId).HasColumnName("SqlMessageID");
            entity.Property(e => e.StepId).HasColumnName("StepID");
            entity.Property(e => e.StepName).HasMaxLength(128);
        });

        modelBuilder.Entity<HistorialJob1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HistorialJobs", "int");

            entity.HasIndex(e => e.IdProceso, "nci_wi_HistorialJobs_514B9DD114418301EFC20D0F0815F26D");

            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.IdProceso).HasMaxLength(50);
            entity.Property(e => e.InstanceId).HasColumnName("InstanceID");
            entity.Property(e => e.JobId).HasColumnName("JobID");
            entity.Property(e => e.JobName).HasMaxLength(128);
            entity.Property(e => e.Message).HasMaxLength(4000);
            entity.Property(e => e.OperatorEmailed).HasMaxLength(128);
            entity.Property(e => e.OperatorNetsent).HasMaxLength(128);
            entity.Property(e => e.OperatorPaged).HasMaxLength(128);
            entity.Property(e => e.RunDate).HasColumnType("datetime");
            entity.Property(e => e.RunStatusDesc)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.Server).HasMaxLength(128);
            entity.Property(e => e.SqlMessageId).HasColumnName("SqlMessageID");
            entity.Property(e => e.StepId).HasColumnName("StepID");
            entity.Property(e => e.StepName).HasMaxLength(128);
        });

        modelBuilder.Entity<IcCaCcSaldoPromedioProm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("icCaCcSaldoPromedioProm", "int");

            entity.Property(e => e.IdDClienteCuitDniNombreIdDContratoSaldoPromMesSaldoPromAntSdoAntSdoMes).HasColumnName("Id_d_Cliente|CUIT|DNI|nombre|Id_d_Contrato|saldo_prom_mes|saldo_prom_ant|Sdo_Ant|Sdo_mes");
        });

        modelBuilder.Entity<IcCdniBip>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("icCdniBip", "app");

            entity.Property(e => e.CodAreaFijo1).HasColumnName("COD_AREA_FIJO_1");
            entity.Property(e => e.CodAreaMovil1).HasColumnName("COD_AREA_MOVIL_1");
            entity.Property(e => e.EmailBip)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EMAIL_BIP");
            entity.Property(e => e.EmailCdni)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EMAIL_CDNI");
            entity.Property(e => e.FecAltaEmailBip)
                .HasColumnType("date")
                .HasColumnName("FEC_ALTA_EMAIL_BIP");
            entity.Property(e => e.FecCdniAlta)
                .HasColumnType("date")
                .HasColumnName("FEC_CDNI_ALTA");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.FlaCdni)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FLA_CDNI");
            entity.Property(e => e.IdCdniBip)
                .ValueGeneratedOnAdd()
                .HasColumnName("idCdniBip");
            entity.Property(e => e.IdDCliente).HasColumnName("ID_D_CLIENTE");
            entity.Property(e => e.NumTelefonoFijo1).HasColumnName("NUM_TELEFONO_FIJO_1");
            entity.Property(e => e.NumTelefonoMovil1).HasColumnName("NUM_TELEFONO_MOVIL_1");
        });

        modelBuilder.Entity<IcCdniBip1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("icCdniBip", "int");

            entity.Property(e => e.CodAreaFijo1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COD_AREA_FIJO_1");
            entity.Property(e => e.CodAreaMovil1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COD_AREA_MOVIL_1");
            entity.Property(e => e.EmailBip)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EMAIL_BIP");
            entity.Property(e => e.EmailCdni)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EMAIL_CDNI");
            entity.Property(e => e.FecAltaEmailBip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FEC_ALTA_EMAIL_BIP");
            entity.Property(e => e.FecCdniAlta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FEC_CDNI_ALTA");
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.FlaCdni)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FLA_CDNI");
            entity.Property(e => e.IdCdniBip)
                .ValueGeneratedOnAdd()
                .HasColumnName("idCdniBip");
            entity.Property(e => e.IdDCliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ID_D_CLIENTE");
            entity.Property(e => e.NumTelefonoFijo1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NUM_TELEFONO_FIJO_1");
            entity.Property(e => e.NumTelefonoMovil1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NUM_TELEFONO_MOVIL_1");
        });

        modelBuilder.Entity<IcCdniComerciosProme>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("icCdniComerciosProme", "int");

            entity.Property(e => e.ComFecAlta).HasColumnName("COM_FEC_ALTA");
            entity.Property(e => e.IdDCliente).HasColumnName("id_d_cliente");
            entity.Property(e => e.NumCuit).HasColumnName("num_cuit");
        });

        modelBuilder.Entity<IcMatrizRentum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("icMatrizRenta", "int");

            entity.Property(e => e.IdDClienteDescAgrupadorPrestamoN1DescAgrupadorPrestamoN2RentAcumuladaRentabPromedio).HasColumnName("Id_d_Cliente|Desc_Agrupador_Prestamo_N1|Desc_Agrupador_Prestamo_N2|RentAcumulada|Rentab_Promedio");
        });

        modelBuilder.Entity<IcPromeCdniComercio>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("icPromeCdniComercios", "int");

            entity.Property(e => e.FlagCdniComercios).HasColumnName("flag_cdni_comercios");
            entity.Property(e => e.FlagClienteCdni).HasColumnName("flag_cliente_cdni");
            entity.Property(e => e.IdDCliente).HasColumnName("ID_D_CLIENTE");
        });

        modelBuilder.Entity<IcTarjetasAtesorada>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("icTarjetasAtesoradas", "app");

            entity.Property(e => e.CodCliente).HasColumnName("COD_CLIENTE");
            entity.Property(e => e.CodIdentificacion).HasColumnName("COD_IDENTIFICACION");
            entity.Property(e => e.CodUdn).HasColumnName("COD_UDN");
            entity.Property(e => e.DescCliente)
                .HasMaxLength(256)
                .HasColumnName("DESC_CLIENTE");
            entity.Property(e => e.DescClienteEmail)
                .HasMaxLength(256)
                .HasColumnName("DESC_CLIENTE_EMAIL");
            entity.Property(e => e.DescIdentifEmail)
                .HasMaxLength(256)
                .HasColumnName("DESC_IDENTIF_EMAIL");
            entity.Property(e => e.DescIdentificacion)
                .HasMaxLength(256)
                .HasColumnName("DESC_IDENTIFICACION");
            entity.Property(e => e.DescTipoDocumento)
                .HasMaxLength(256)
                .HasColumnName("DESC_TIPO_DOCUMENTO");
            entity.Property(e => e.DescUdn)
                .HasMaxLength(256)
                .HasColumnName("DESC_UDN");
            entity.Property(e => e.Eliminada).HasColumnName("eliminada");
            entity.Property(e => e.FecStockDesde)
                .HasColumnType("date")
                .HasColumnName("FEC_STOCK_DESDE");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.FlaMicroempresa)
                .HasMaxLength(3)
                .HasColumnName("FLA_MICROEMPRESA");
            entity.Property(e => e.IdTarjetasAtesorada).ValueGeneratedOnAdd();
            entity.Property(e => e.NumClienteTelefono).HasColumnName("NUM_CLIENTE_TELEFONO");
            entity.Property(e => e.NumDocumento).HasColumnName("NUM_DOCUMENTO");
            entity.Property(e => e.NumIdentifTelefono).HasColumnName("NUM_IDENTIF_TELEFONO");
            entity.Property(e => e.NumTarjeta).HasColumnName("NUM_TARJETA");
        });

        modelBuilder.Entity<IcTarjetasAtesorada1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("icTarjetasAtesoradas", "int");

            entity.Property(e => e.CodCliente)
                .HasMaxLength(256)
                .HasColumnName("COD_CLIENTE");
            entity.Property(e => e.CodIdentificacion)
                .HasMaxLength(256)
                .HasColumnName("COD_IDENTIFICACION");
            entity.Property(e => e.CodUdn)
                .HasMaxLength(256)
                .HasColumnName("COD_UDN");
            entity.Property(e => e.DescCliente)
                .HasMaxLength(256)
                .HasColumnName("DESC_CLIENTE");
            entity.Property(e => e.DescClienteEmail)
                .HasMaxLength(256)
                .HasColumnName("DESC_CLIENTE_EMAIL");
            entity.Property(e => e.DescIdentifEmail)
                .HasMaxLength(256)
                .HasColumnName("DESC_IDENTIF_EMAIL");
            entity.Property(e => e.DescIdentificacion)
                .HasMaxLength(256)
                .HasColumnName("DESC_IDENTIFICACION");
            entity.Property(e => e.DescTipoDocumento)
                .HasMaxLength(256)
                .HasColumnName("DESC_TIPO_DOCUMENTO");
            entity.Property(e => e.DescUdn)
                .HasMaxLength(256)
                .HasColumnName("DESC_UDN");
            entity.Property(e => e.FecStockDesde)
                .HasMaxLength(256)
                .HasColumnName("FEC_STOCK_DESDE");
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.FlaMicroempresa)
                .HasMaxLength(256)
                .HasColumnName("FLA_MICROEMPRESA");
            entity.Property(e => e.IdTarjetasAtesorada).ValueGeneratedOnAdd();
            entity.Property(e => e.NumClienteTelefono)
                .HasMaxLength(256)
                .HasColumnName("NUM_CLIENTE_TELEFONO");
            entity.Property(e => e.NumDocumento)
                .HasMaxLength(256)
                .HasColumnName("NUM_DOCUMENTO");
            entity.Property(e => e.NumIdentifTelefono)
                .HasMaxLength(256)
                .HasColumnName("NUM_IDENTIF_TELEFONO");
            entity.Property(e => e.NumTarjeta)
                .HasMaxLength(256)
                .HasColumnName("NUM_TARJETA");
        });

        modelBuilder.Entity<Index>(entity =>
        {
            entity.HasKey(e => e.IdIndice).HasName("PK_appIndices");

            entity.ToTable("Indices", "app");

            entity.Property(e => e.IdIndice).HasColumnName("idIndice");
            entity.Property(e => e.Archivo).HasMaxLength(255);
            entity.Property(e => e.Cod)
                .HasMaxLength(10)
                .HasColumnName("cod");
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.IdProceso).HasMaxLength(50);
            entity.Property(e => e.Indice).HasMaxLength(50);
            entity.Property(e => e.Periodo).HasColumnType("date");
            entity.Property(e => e.Tipo).HasMaxLength(50);
            entity.Property(e => e.Valor).HasColumnType("numeric(18, 6)");
        });

        modelBuilder.Entity<IntCampaña>(entity =>
        {
            entity.HasKey(e => e.IdIntCampañas).HasName("PK_appIntCampañas");

            entity.ToTable("IntCampañas", "app");

            entity.HasIndex(e => new { e.Archivo, e.Estado }, "IDX_appIntCampañas_1");

            entity.HasIndex(e => new { e.IdIntCampañas, e.Estado }, "IDX_appIntCampañas_2");

            entity.HasIndex(e => e.Estado, "nci_wi_IntCampañas_4EED4EE81D6952929CAD385716F81272");

            entity.Property(e => e.Archivo).HasMaxLength(255);
            entity.Property(e => e.Area).HasMaxLength(16);
            entity.Property(e => e.AssignedTeam).HasMaxLength(50);
            entity.Property(e => e.AssignedTeamVal).HasMaxLength(550);
            entity.Property(e => e.Branch).HasMaxLength(80);
            entity.Property(e => e.BranchVal).HasMaxLength(550);
            entity.Property(e => e.CampaignName).HasMaxLength(150);
            entity.Property(e => e.CampaignNameVal).HasMaxLength(550);
            entity.Property(e => e.ContactId).HasMaxLength(50);
            entity.Property(e => e.ContactIdVal).HasMaxLength(550);
            entity.Property(e => e.CreditAmount).HasMaxLength(50);
            entity.Property(e => e.CreditAmountVal).HasMaxLength(550);
            entity.Property(e => e.CreditSubtype).HasMaxLength(50);
            entity.Property(e => e.CreditSubtypeVal).HasMaxLength(550);
            entity.Property(e => e.Estado).HasMaxLength(50);
            entity.Property(e => e.FechaOval).HasColumnType("datetime");
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.IdProceso).HasMaxLength(50);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");
            entity.Property(e => e.OfferCode).HasMaxLength(50);
            entity.Property(e => e.OfferCodeVal).HasMaxLength(550);
            entity.Property(e => e.Oval).HasMaxLength(255);
            entity.Property(e => e.QuotaAmount).HasMaxLength(50);
            entity.Property(e => e.QuotaAmountVal).HasMaxLength(550);
            entity.Property(e => e.ToTeam).HasMaxLength(50);
            entity.Property(e => e.ToTeamVal).HasMaxLength(550);
            entity.Property(e => e.Zone).HasMaxLength(50);
            entity.Property(e => e.ZoneVal).HasMaxLength(550);
        });

        modelBuilder.Entity<IntCampaña1>(entity =>
        {
            entity.HasKey(e => e.IdIntCampañas);

            entity.ToTable("IntCampañas", "int");

            entity.Property(e => e.Archivo).HasMaxLength(255);
            entity.Property(e => e.AssignedTeam).HasMaxLength(50);
            entity.Property(e => e.Branch).HasMaxLength(80);
            entity.Property(e => e.CampaignName).HasMaxLength(150);
            entity.Property(e => e.ContactId).HasMaxLength(50);
            entity.Property(e => e.CreditAmount).HasMaxLength(50);
            entity.Property(e => e.CreditSubtype).HasMaxLength(50);
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.IdProceso).HasMaxLength(50);
            entity.Property(e => e.OfferCode).HasMaxLength(50);
            entity.Property(e => e.QuotaAmount).HasMaxLength(50);
            entity.Property(e => e.ToTeam).HasMaxLength(50);
            entity.Property(e => e.Zone).HasMaxLength(50);
        });

        modelBuilder.Entity<IntCampañaOval>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IntCampañaOval", "int");

            entity.HasIndex(e => new { e.IdIntCampañas, e.Estado }, "IDX_IntCampañaOval_Id");

            entity.HasIndex(e => e.IdIntCampañas, "IDX_IntCampañaOval_Id2");

            entity.Property(e => e.Estado).HasMaxLength(50);
            entity.Property(e => e.FechaEnviado).HasColumnType("datetime");
            entity.Property(e => e.FechaOval).HasColumnType("datetime");
            entity.Property(e => e.Oval).HasMaxLength(255);
        });

        modelBuilder.Entity<IntCampañasNotificar>(entity =>
        {
            entity.HasKey(e => e.IdNotificar);

            entity.ToTable("IntCampañasNotificar", "app");

            entity.Property(e => e.Archivo).HasMaxLength(256);
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.IdProceso).HasMaxLength(50);
            entity.Property(e => e.NotificarA).HasMaxLength(50);
        });

        modelBuilder.Entity<IntegracionDir>(entity =>
        {
            entity.HasKey(e => e.IdIntegracionDir).HasName("PK_IntegracionDir_1");

            entity.ToTable("IntegracionDir", "app");

            entity.Property(e => e.Campo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripción)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.Integración)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ValorPorDefecto)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<IntegracionProspecto>(entity =>
        {
            entity.HasKey(e => e.IdIntProspecto).HasName("PK_appIntegracionProspectos");

            entity.ToTable("IntegracionProspectos", "app");

            entity.Property(e => e.IdIntProspecto).HasColumnName("idIntProspecto");
            entity.Property(e => e.Accion).HasMaxLength(255);
            entity.Property(e => e.AccionComercial)
                .HasMaxLength(50)
                .HasColumnName("Accion Comercial");
            entity.Property(e => e.Actividad).HasMaxLength(50);
            entity.Property(e => e.Apellido).HasMaxLength(50);
            entity.Property(e => e.BarrioMicroempresa)
                .HasMaxLength(150)
                .HasColumnName("Barrio Microempresa");
            entity.Property(e => e.Calle).HasMaxLength(50);
            entity.Property(e => e.CalleNro)
                .HasMaxLength(50)
                .HasColumnName("Calle nro");
            entity.Property(e => e.Categoria).HasMaxLength(50);
            entity.Property(e => e.Cnae)
                .HasMaxLength(50)
                .HasColumnName("CNAE");
            entity.Property(e => e.Cno)
                .HasMaxLength(50)
                .HasColumnName("CNO");
            entity.Property(e => e.CodPostal)
                .HasMaxLength(50)
                .HasColumnName("Cod. postal");
            entity.Property(e => e.CodigoAreaTelefonoAlternativo)
                .HasMaxLength(50)
                .HasColumnName("Codigo area telefono alternativo");
            entity.Property(e => e.CodigoDeAreaTelefono)
                .HasMaxLength(50)
                .HasColumnName("Codigo de area telefono");
            entity.Property(e => e.ComoSeEntero).HasMaxLength(50);
            entity.Property(e => e.Departamento).HasMaxLength(50);
            entity.Property(e => e.DireccionTipo)
                .HasMaxLength(50)
                .HasColumnName("Direccion tipo");
            entity.Property(e => e.Dni)
                .HasMaxLength(50)
                .HasColumnName("DNI");
            entity.Property(e => e.DocumentoTributarioCuerpo)
                .HasMaxLength(50)
                .HasColumnName("Documento Tributario Cuerpo");
            entity.Property(e => e.DocumentoTributarioDigVerificador)
                .HasMaxLength(50)
                .HasColumnName("Documento Tributario Dig Verificador");
            entity.Property(e => e.DocumentoTributarioPrefijo)
                .HasMaxLength(50)
                .HasColumnName("Documento Tributario Prefijo");
            entity.Property(e => e.DocumentoTributarioTipo)
                .HasMaxLength(50)
                .HasColumnName("Documento Tributario Tipo");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FechaOrigen).HasColumnType("datetime");
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.IdProceso).HasMaxLength(50);
            entity.Property(e => e.InicioActividades)
                .HasMaxLength(50)
                .HasColumnName("Inicio actividades");
            entity.Property(e => e.LocalidadMicroempresa)
                .HasMaxLength(150)
                .HasColumnName("Localidad Microempresa");
            entity.Property(e => e.Microempresa).HasMaxLength(50);
            entity.Property(e => e.MicroempresaPropia)
                .HasMaxLength(50)
                .HasColumnName("Microempresa propia");
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.NumeroDeTelefono)
                .HasMaxLength(50)
                .HasColumnName("Numero de telefono");
            entity.Property(e => e.Pais).HasMaxLength(50);
            entity.Property(e => e.Permanencia).HasMaxLength(50);
            entity.Property(e => e.Piso).HasMaxLength(50);
            entity.Property(e => e.Provincia).HasMaxLength(50);
            entity.Property(e => e.Rating).HasMaxLength(50);
            entity.Property(e => e.RecomendadorGenero)
                .HasMaxLength(50)
                .HasColumnName("Recomendador genero");
            entity.Property(e => e.RecomendadorNumeroDocumento)
                .HasMaxLength(50)
                .HasColumnName("Recomendador numero documento");
            entity.Property(e => e.RecomendadorTipoDocumento)
                .HasMaxLength(50)
                .HasColumnName("Recomendador  tipo documento");
            entity.Property(e => e.Segmento).HasMaxLength(50);
            entity.Property(e => e.Sexo).HasMaxLength(50);
            entity.Property(e => e.Sucursal).HasMaxLength(50);
            entity.Property(e => e.Telefono3roCodArea)
                .HasMaxLength(50)
                .HasColumnName("Telefono 3ro cod area");
            entity.Property(e => e.Telefono3roNro)
                .HasMaxLength(50)
                .HasColumnName("Telefono 3ro nro");
            entity.Property(e => e.Telefono3roTipo)
                .HasMaxLength(50)
                .HasColumnName("Telefono 3ro tipo");
            entity.Property(e => e.TelefonoAlternativoNro)
                .HasMaxLength(50)
                .HasColumnName("Telefono alternativo nro");
            entity.Property(e => e.Tipo).HasMaxLength(50);
            entity.Property(e => e.TipoDeTelefono)
                .HasMaxLength(50)
                .HasColumnName("Tipo de Telefono");
            entity.Property(e => e.TipoDeTelefonoAlternativo)
                .HasMaxLength(50)
                .HasColumnName("Tipo de telefono alternativo");
            entity.Property(e => e.Utmcampaña)
                .HasMaxLength(50)
                .HasColumnName("UTMCampaña");
            entity.Property(e => e.Utmcontenido)
                .HasMaxLength(50)
                .HasColumnName("UTMContenido");
            entity.Property(e => e.Utmmedio)
                .HasMaxLength(50)
                .HasColumnName("UTMmedio");
            entity.Property(e => e.Utmorigen)
                .HasMaxLength(50)
                .HasColumnName("UTMorigen");
        });

        modelBuilder.Entity<IntegracionProspecto1>(entity =>
        {
            entity.HasKey(e => e.IdIntProspecto);

            entity.ToTable("IntegracionProspectos", "int");

            entity.Property(e => e.IdIntProspecto).HasColumnName("idIntProspecto");
            entity.Property(e => e.Accion).HasMaxLength(255);
            entity.Property(e => e.AccionComercial)
                .HasMaxLength(50)
                .HasColumnName("Accion Comercial");
            entity.Property(e => e.Actividad).HasMaxLength(50);
            entity.Property(e => e.Apellido).HasMaxLength(50);
            entity.Property(e => e.BarrioMicroempresa)
                .HasMaxLength(150)
                .HasColumnName("Barrio Microempresa");
            entity.Property(e => e.Calle).HasMaxLength(50);
            entity.Property(e => e.CalleNro)
                .HasMaxLength(50)
                .HasColumnName("Calle nro");
            entity.Property(e => e.Categoria).HasMaxLength(50);
            entity.Property(e => e.Cnae)
                .HasMaxLength(50)
                .HasColumnName("CNAE");
            entity.Property(e => e.Cno)
                .HasMaxLength(50)
                .HasColumnName("CNO");
            entity.Property(e => e.CodPostal)
                .HasMaxLength(50)
                .HasColumnName("Cod. postal");
            entity.Property(e => e.CodigoAreaTelefonoAlternativo)
                .HasMaxLength(50)
                .HasColumnName("Codigo area telefono alternativo");
            entity.Property(e => e.CodigoDeAreaTelefono)
                .HasMaxLength(50)
                .HasColumnName("Codigo de area telefono");
            entity.Property(e => e.ComoSeEntero).HasMaxLength(50);
            entity.Property(e => e.Departamento).HasMaxLength(50);
            entity.Property(e => e.DireccionTipo)
                .HasMaxLength(50)
                .HasColumnName("Direccion tipo");
            entity.Property(e => e.Dni)
                .HasMaxLength(50)
                .HasColumnName("DNI");
            entity.Property(e => e.DocumentoTributarioCuerpo)
                .HasMaxLength(50)
                .HasColumnName("Documento Tributario Cuerpo");
            entity.Property(e => e.DocumentoTributarioDigVerificador)
                .HasMaxLength(50)
                .HasColumnName("Documento Tributario Dig Verificador");
            entity.Property(e => e.DocumentoTributarioPrefijo)
                .HasMaxLength(50)
                .HasColumnName("Documento Tributario Prefijo");
            entity.Property(e => e.DocumentoTributarioTipo)
                .HasMaxLength(50)
                .HasColumnName("Documento Tributario Tipo");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FechaOrigen).HasColumnType("datetime");
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.IdProceso).HasMaxLength(50);
            entity.Property(e => e.InicioActividades)
                .HasMaxLength(50)
                .HasColumnName("Inicio actividades");
            entity.Property(e => e.LocalidadMicroempresa)
                .HasMaxLength(150)
                .HasColumnName("Localidad Microempresa");
            entity.Property(e => e.Microempresa).HasMaxLength(50);
            entity.Property(e => e.MicroempresaPropia)
                .HasMaxLength(50)
                .HasColumnName("Microempresa propia");
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.NumeroDeTelefono)
                .HasMaxLength(50)
                .HasColumnName("Numero de telefono");
            entity.Property(e => e.Pais).HasMaxLength(50);
            entity.Property(e => e.Permanencia).HasMaxLength(50);
            entity.Property(e => e.Piso).HasMaxLength(50);
            entity.Property(e => e.Provincia).HasMaxLength(50);
            entity.Property(e => e.Rating).HasMaxLength(50);
            entity.Property(e => e.RecomendadorGenero)
                .HasMaxLength(50)
                .HasColumnName("Recomendador genero");
            entity.Property(e => e.RecomendadorNumeroDocumento)
                .HasMaxLength(50)
                .HasColumnName("Recomendador numero documento");
            entity.Property(e => e.RecomendadorTipoDocumento)
                .HasMaxLength(50)
                .HasColumnName("Recomendador  tipo documento");
            entity.Property(e => e.Segmento).HasMaxLength(50);
            entity.Property(e => e.Sexo).HasMaxLength(50);
            entity.Property(e => e.Sucursal).HasMaxLength(50);
            entity.Property(e => e.Telefono3roCodArea)
                .HasMaxLength(50)
                .HasColumnName("Telefono 3ro cod area");
            entity.Property(e => e.Telefono3roNro)
                .HasMaxLength(50)
                .HasColumnName("Telefono 3ro nro");
            entity.Property(e => e.Telefono3roTipo)
                .HasMaxLength(50)
                .HasColumnName("Telefono 3ro tipo");
            entity.Property(e => e.TelefonoAlternativoNro)
                .HasMaxLength(50)
                .HasColumnName("Telefono alternativo nro");
            entity.Property(e => e.Tipo).HasMaxLength(50);
            entity.Property(e => e.TipoDeTelefono)
                .HasMaxLength(50)
                .HasColumnName("Tipo de Telefono");
            entity.Property(e => e.TipoDeTelefonoAlternativo)
                .HasMaxLength(50)
                .HasColumnName("Tipo de telefono alternativo");
            entity.Property(e => e.Utmcampaña)
                .HasMaxLength(50)
                .HasColumnName("UTMCampaña");
            entity.Property(e => e.Utmcontenido)
                .HasMaxLength(50)
                .HasColumnName("UTMContenido");
            entity.Property(e => e.Utmmedio)
                .HasMaxLength(50)
                .HasColumnName("UTMmedio");
            entity.Property(e => e.Utmorigen)
                .HasMaxLength(50)
                .HasColumnName("UTMorigen");
        });

        modelBuilder.Entity<IntegracionProspectosControl>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("IntegracionProspectosControl", "app");

            entity.Property(e => e.Accion).HasMaxLength(50);
            entity.Property(e => e.AccionComercial)
                .HasMaxLength(50)
                .HasColumnName("Accion Comercial");
            entity.Property(e => e.Actividad).HasMaxLength(50);
            entity.Property(e => e.Apellido).HasMaxLength(50);
            entity.Property(e => e.BarrioMicroempresa)
                .HasMaxLength(150)
                .HasColumnName("Barrio Microempresa");
            entity.Property(e => e.Calle).HasMaxLength(50);
            entity.Property(e => e.CalleNro)
                .HasMaxLength(50)
                .HasColumnName("Calle nro");
            entity.Property(e => e.Categoria).HasMaxLength(50);
            entity.Property(e => e.Cnae)
                .HasMaxLength(50)
                .HasColumnName("CNAE");
            entity.Property(e => e.Cno)
                .HasMaxLength(50)
                .HasColumnName("CNO");
            entity.Property(e => e.CodPostal)
                .HasMaxLength(50)
                .HasColumnName("Cod. postal");
            entity.Property(e => e.CodigoAreaTelefonoAlternativo)
                .HasMaxLength(50)
                .HasColumnName("Codigo area telefono alternativo");
            entity.Property(e => e.CodigoDeAreaTelefono)
                .HasMaxLength(50)
                .HasColumnName("Codigo de area telefono");
            entity.Property(e => e.ComoSeEntero).HasMaxLength(50);
            entity.Property(e => e.Departamento).HasMaxLength(50);
            entity.Property(e => e.DireccionTipo)
                .HasMaxLength(50)
                .HasColumnName("Direccion tipo");
            entity.Property(e => e.Dni)
                .HasMaxLength(50)
                .HasColumnName("DNI");
            entity.Property(e => e.DocumentoTributarioCuerpo)
                .HasMaxLength(50)
                .HasColumnName("Documento Tributario Cuerpo");
            entity.Property(e => e.DocumentoTributarioDigVerificador)
                .HasMaxLength(50)
                .HasColumnName("Documento Tributario Dig Verificador");
            entity.Property(e => e.DocumentoTributarioPrefijo)
                .HasMaxLength(50)
                .HasColumnName("Documento Tributario Prefijo");
            entity.Property(e => e.DocumentoTributarioTipo)
                .HasMaxLength(50)
                .HasColumnName("Documento Tributario Tipo");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FechaAplicacionCrm)
                .HasColumnType("date")
                .HasColumnName("FechaAplicacionCRM");
            entity.Property(e => e.FechaEntrada).HasColumnType("date");
            entity.Property(e => e.FechaOrigen).HasColumnType("datetime");
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.IdIntProspecto).HasColumnName("idIntProspecto");
            entity.Property(e => e.IdProceso).HasMaxLength(50);
            entity.Property(e => e.InicioActividades)
                .HasMaxLength(50)
                .HasColumnName("Inicio actividades");
            entity.Property(e => e.LocalidadMicroempresa)
                .HasMaxLength(150)
                .HasColumnName("Localidad Microempresa");
            entity.Property(e => e.Microempresa).HasMaxLength(50);
            entity.Property(e => e.MicroempresaPropia)
                .HasMaxLength(50)
                .HasColumnName("Microempresa propia");
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.NumeroDeTelefono)
                .HasMaxLength(50)
                .HasColumnName("Numero de telefono");
            entity.Property(e => e.Observaciones).HasMaxLength(128);
            entity.Property(e => e.Pais).HasMaxLength(50);
            entity.Property(e => e.Permanencia).HasMaxLength(50);
            entity.Property(e => e.Piso).HasMaxLength(50);
            entity.Property(e => e.Provincia).HasMaxLength(50);
            entity.Property(e => e.Rating).HasMaxLength(50);
            entity.Property(e => e.RecomendadorGenero)
                .HasMaxLength(50)
                .HasColumnName("Recomendador genero");
            entity.Property(e => e.RecomendadorNumeroDocumento)
                .HasMaxLength(50)
                .HasColumnName("Recomendador numero documento");
            entity.Property(e => e.RecomendadorTipoDocumento)
                .HasMaxLength(50)
                .HasColumnName("Recomendador  tipo documento");
            entity.Property(e => e.Segmento).HasMaxLength(50);
            entity.Property(e => e.Sexo).HasMaxLength(50);
            entity.Property(e => e.Sucursal).HasMaxLength(50);
            entity.Property(e => e.Telefono3roCodArea)
                .HasMaxLength(50)
                .HasColumnName("Telefono 3ro cod area");
            entity.Property(e => e.Telefono3roNro)
                .HasMaxLength(50)
                .HasColumnName("Telefono 3ro nro");
            entity.Property(e => e.Telefono3roTipo)
                .HasMaxLength(50)
                .HasColumnName("Telefono 3ro tipo");
            entity.Property(e => e.TelefonoAlternativoNro)
                .HasMaxLength(50)
                .HasColumnName("Telefono alternativo nro");
            entity.Property(e => e.Tipo).HasMaxLength(50);
            entity.Property(e => e.TipoDeTelefono)
                .HasMaxLength(50)
                .HasColumnName("Tipo de Telefono");
            entity.Property(e => e.TipoDeTelefonoAlternativo)
                .HasMaxLength(50)
                .HasColumnName("Tipo de telefono alternativo");
            entity.Property(e => e.Utmcampaña)
                .HasMaxLength(50)
                .HasColumnName("UTMCampaña");
            entity.Property(e => e.Utmcontenido)
                .HasMaxLength(50)
                .HasColumnName("UTMContenido");
            entity.Property(e => e.Utmmedio)
                .HasMaxLength(50)
                .HasColumnName("UTMmedio");
            entity.Property(e => e.Utmorigen)
                .HasMaxLength(50)
                .HasColumnName("UTMorigen");
        });

        modelBuilder.Entity<IntegracionProspectosCtrl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IntegracionProspectosCtrl", "app");

            entity.HasIndex(e => e.EntryId, "IDX_IntegracionProspectosCtrl_ids");

            entity.Property(e => e.FechaEntrada).HasColumnType("date");
            entity.Property(e => e.Observaciones).HasMaxLength(128);
        });

        modelBuilder.Entity<Lead>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Lead", "crm");

            entity.HasIndex(e => e.PnetDocumentNumber, "NonClusteredIndex-20210122-IDX");

            entity.HasIndex(e => e.LeadId, "NonClusteredIndex-20210122-Lead");

            entity.Property(e => e.AccountIdName).HasMaxLength(4000);
            entity.Property(e => e.AccountIdYomiName).HasMaxLength(4000);
            entity.Property(e => e.Address1AddressId).HasColumnName("Address1_AddressId");
            entity.Property(e => e.Address1AddressTypeCode).HasColumnName("Address1_AddressTypeCode");
            entity.Property(e => e.Address1City)
                .HasMaxLength(4000)
                .HasColumnName("Address1_City");
            entity.Property(e => e.Address1Composite).HasColumnName("Address1_Composite");
            entity.Property(e => e.Address1Country)
                .HasMaxLength(4000)
                .HasColumnName("Address1_Country");
            entity.Property(e => e.Address1County)
                .HasMaxLength(4000)
                .HasColumnName("Address1_County");
            entity.Property(e => e.Address1Fax)
                .HasMaxLength(50)
                .HasColumnName("Address1_Fax");
            entity.Property(e => e.Address1Latitude).HasColumnName("Address1_Latitude");
            entity.Property(e => e.Address1Line1)
                .HasMaxLength(4000)
                .HasColumnName("Address1_Line1");
            entity.Property(e => e.Address1Line2)
                .HasMaxLength(4000)
                .HasColumnName("Address1_Line2");
            entity.Property(e => e.Address1Line3)
                .HasMaxLength(4000)
                .HasColumnName("Address1_Line3");
            entity.Property(e => e.Address1Longitude).HasColumnName("Address1_Longitude");
            entity.Property(e => e.Address1Name)
                .HasMaxLength(200)
                .HasColumnName("Address1_Name");
            entity.Property(e => e.Address1PostOfficeBox)
                .HasMaxLength(4000)
                .HasColumnName("Address1_PostOfficeBox");
            entity.Property(e => e.Address1PostalCode)
                .HasMaxLength(4000)
                .HasColumnName("Address1_PostalCode");
            entity.Property(e => e.Address1ShippingMethodCode).HasColumnName("Address1_ShippingMethodCode");
            entity.Property(e => e.Address1StateOrProvince)
                .HasMaxLength(4000)
                .HasColumnName("Address1_StateOrProvince");
            entity.Property(e => e.Address1Telephone1)
                .HasMaxLength(50)
                .HasColumnName("Address1_Telephone1");
            entity.Property(e => e.Address1Telephone2)
                .HasMaxLength(50)
                .HasColumnName("Address1_Telephone2");
            entity.Property(e => e.Address1Telephone3)
                .HasMaxLength(50)
                .HasColumnName("Address1_Telephone3");
            entity.Property(e => e.Address1Upszone)
                .HasMaxLength(4)
                .HasColumnName("Address1_UPSZone");
            entity.Property(e => e.Address1Utcoffset).HasColumnName("Address1_UTCOffset");
            entity.Property(e => e.Address2AddressId).HasColumnName("Address2_AddressId");
            entity.Property(e => e.Address2AddressTypeCode).HasColumnName("Address2_AddressTypeCode");
            entity.Property(e => e.Address2City)
                .HasMaxLength(4000)
                .HasColumnName("Address2_City");
            entity.Property(e => e.Address2Composite).HasColumnName("Address2_Composite");
            entity.Property(e => e.Address2Country)
                .HasMaxLength(4000)
                .HasColumnName("Address2_Country");
            entity.Property(e => e.Address2County)
                .HasMaxLength(4000)
                .HasColumnName("Address2_County");
            entity.Property(e => e.Address2Fax)
                .HasMaxLength(50)
                .HasColumnName("Address2_Fax");
            entity.Property(e => e.Address2Latitude).HasColumnName("Address2_Latitude");
            entity.Property(e => e.Address2Line1)
                .HasMaxLength(4000)
                .HasColumnName("Address2_Line1");
            entity.Property(e => e.Address2Line2)
                .HasMaxLength(4000)
                .HasColumnName("Address2_Line2");
            entity.Property(e => e.Address2Line3)
                .HasMaxLength(4000)
                .HasColumnName("Address2_Line3");
            entity.Property(e => e.Address2Longitude).HasColumnName("Address2_Longitude");
            entity.Property(e => e.Address2Name)
                .HasMaxLength(200)
                .HasColumnName("Address2_Name");
            entity.Property(e => e.Address2PostOfficeBox)
                .HasMaxLength(4000)
                .HasColumnName("Address2_PostOfficeBox");
            entity.Property(e => e.Address2PostalCode)
                .HasMaxLength(4000)
                .HasColumnName("Address2_PostalCode");
            entity.Property(e => e.Address2ShippingMethodCode).HasColumnName("Address2_ShippingMethodCode");
            entity.Property(e => e.Address2StateOrProvince)
                .HasMaxLength(4000)
                .HasColumnName("Address2_StateOrProvince");
            entity.Property(e => e.Address2Telephone1)
                .HasMaxLength(50)
                .HasColumnName("Address2_Telephone1");
            entity.Property(e => e.Address2Telephone2)
                .HasMaxLength(50)
                .HasColumnName("Address2_Telephone2");
            entity.Property(e => e.Address2Telephone3)
                .HasMaxLength(50)
                .HasColumnName("Address2_Telephone3");
            entity.Property(e => e.Address2Upszone)
                .HasMaxLength(4)
                .HasColumnName("Address2_UPSZone");
            entity.Property(e => e.Address2Utcoffset).HasColumnName("Address2_UTCOffset");
            entity.Property(e => e.BudgetAmount).HasColumnType("money");
            entity.Property(e => e.BudgetAmountBase)
                .HasColumnType("money")
                .HasColumnName("BudgetAmount_Base");
            entity.Property(e => e.CampaignIdName).HasMaxLength(128);
            entity.Property(e => e.CompanyName).HasMaxLength(100);
            entity.Property(e => e.ContactIdName).HasMaxLength(4000);
            entity.Property(e => e.ContactIdYomiName).HasMaxLength(4000);
            entity.Property(e => e.CreatedByName).HasMaxLength(200);
            entity.Property(e => e.CreatedByYomiName).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreatedOnBehalfByName).HasMaxLength(200);
            entity.Property(e => e.CreatedOnBehalfByYomiName).HasMaxLength(200);
            entity.Property(e => e.CustomerIdName).HasMaxLength(4000);
            entity.Property(e => e.CustomerIdYomiName).HasMaxLength(4000);
            entity.Property(e => e.DoNotBulkEmail).HasColumnName("DoNotBulkEMail");
            entity.Property(e => e.DoNotEmail).HasColumnName("DoNotEMail");
            entity.Property(e => e.DoNotSendMm).HasColumnName("DoNotSendMM");
            entity.Property(e => e.EmailAddress1)
                .HasMaxLength(100)
                .HasColumnName("EMailAddress1");
            entity.Property(e => e.EmailAddress2)
                .HasMaxLength(100)
                .HasColumnName("EMailAddress2");
            entity.Property(e => e.EmailAddress3)
                .HasMaxLength(100)
                .HasColumnName("EMailAddress3");
            entity.Property(e => e.EntityImageTimestamp).HasColumnName("EntityImage_Timestamp");
            entity.Property(e => e.EntityImageUrl)
                .HasMaxLength(200)
                .HasColumnName("EntityImage_URL");
            entity.Property(e => e.EstimatedAmount).HasColumnType("money");
            entity.Property(e => e.EstimatedAmountBase)
                .HasColumnType("money")
                .HasColumnName("EstimatedAmount_Base");
            entity.Property(e => e.EstimatedCloseDate).HasColumnType("datetime");
            entity.Property(e => e.ExchangeRate).HasColumnType("numeric(23, 10)");
            entity.Property(e => e.Fax).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(160);
            entity.Property(e => e.JobTitle).HasMaxLength(100);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.LastOnHoldTime).HasColumnType("datetime");
            entity.Property(e => e.LastUsedInCampaign).HasColumnType("datetime");
            entity.Property(e => e.MasterLeadIdName).HasMaxLength(160);
            entity.Property(e => e.MasterLeadIdYomiName).HasMaxLength(450);
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.MobilePhone).HasMaxLength(26);
            entity.Property(e => e.ModifiedByName).HasMaxLength(200);
            entity.Property(e => e.ModifiedByYomiName).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOnBehalfByName).HasMaxLength(200);
            entity.Property(e => e.ModifiedOnBehalfByYomiName).HasMaxLength(200);
            entity.Property(e => e.OriginatingCaseIdName).HasMaxLength(200);
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.OwnerIdName).HasMaxLength(160);
            entity.Property(e => e.OwnerIdYomiName).HasMaxLength(160);
            entity.Property(e => e.Pager).HasMaxLength(20);
            entity.Property(e => e.ParentAccountIdName).HasMaxLength(160);
            entity.Property(e => e.ParentAccountIdYomiName).HasMaxLength(160);
            entity.Property(e => e.ParentContactIdName).HasMaxLength(160);
            entity.Property(e => e.ParentContactIdYomiName).HasMaxLength(450);
            entity.Property(e => e.PnetAccountName)
                .HasMaxLength(160)
                .HasColumnName("pnet_AccountName");
            entity.Property(e => e.PnetAddress)
                .HasMaxLength(250)
                .HasColumnName("pnet_Address");
            entity.Property(e => e.PnetAddressNumber).HasColumnName("pnet_AddressNumber");
            entity.Property(e => e.PnetAreaCode1)
                .HasMaxLength(7)
                .HasColumnName("pnet_AreaCode1");
            entity.Property(e => e.PnetAreaCode2)
                .HasMaxLength(7)
                .HasColumnName("pnet_AreaCode2");
            entity.Property(e => e.PnetAreaCode3)
                .HasMaxLength(7)
                .HasColumnName("pnet_AreaCode3");
            entity.Property(e => e.PnetBlock)
                .HasMaxLength(20)
                .HasColumnName("pnet_Block");
            entity.Property(e => e.PnetCnaeid).HasColumnName("pnet_CNAEId");
            entity.Property(e => e.PnetCnaeidName)
                .HasMaxLength(102)
                .HasColumnName("pnet_CNAEIdName");
            entity.Property(e => e.PnetCnoid).HasColumnName("pnet_CNOId");
            entity.Property(e => e.PnetCnoidName)
                .HasMaxLength(100)
                .HasColumnName("pnet_CNOIdName");
            entity.Property(e => e.PnetCommercialAction).HasColumnName("pnet_CommercialAction");
            entity.Property(e => e.PnetCommercialActionDescription)
                .HasMaxLength(400)
                .HasColumnName("pnet_CommercialActionDescription");
            entity.Property(e => e.PnetConsolidatePhone1)
                .HasMaxLength(100)
                .HasColumnName("pnet_ConsolidatePhone1");
            entity.Property(e => e.PnetConsolidatePhone2)
                .HasMaxLength(100)
                .HasColumnName("pnet_ConsolidatePhone2");
            entity.Property(e => e.PnetConsolidatePhone3)
                .HasMaxLength(100)
                .HasColumnName("pnet_ConsolidatePhone3");
            entity.Property(e => e.PnetDepartment)
                .HasMaxLength(3)
                .HasColumnName("pnet_Department");
            entity.Property(e => e.PnetDistrictLocalityId).HasColumnName("pnet_DistrictLocalityId");
            entity.Property(e => e.PnetDistrictLocalityIdName)
                .HasMaxLength(100)
                .HasColumnName("pnet_DistrictLocalityIdName");
            entity.Property(e => e.PnetDocumentNumber).HasColumnName("pnet_DocumentNumber");
            entity.Property(e => e.PnetDocumentType).HasColumnName("pnet_DocumentType");
            entity.Property(e => e.PnetDoor)
                .HasMaxLength(3)
                .HasColumnName("pnet_Door");
            entity.Property(e => e.PnetDuplicatedContact).HasColumnName("pnet_DuplicatedContact");
            entity.Property(e => e.PnetFloor)
                .HasMaxLength(3)
                .HasColumnName("pnet_Floor");
            entity.Property(e => e.PnetGender).HasColumnName("pnet_Gender");
            entity.Property(e => e.PnetGetServerDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_GetServerDate");
            entity.Property(e => e.PnetNeighborhood)
                .HasMaxLength(100)
                .HasColumnName("pnet_Neighborhood");
            entity.Property(e => e.PnetPermanency).HasColumnName("pnet_Permanency");
            entity.Property(e => e.PnetPhone1)
                .HasMaxLength(100)
                .HasColumnName("pnet_Phone1");
            entity.Property(e => e.PnetPhone2)
                .HasMaxLength(100)
                .HasColumnName("pnet_Phone2");
            entity.Property(e => e.PnetPhone3)
                .HasMaxLength(100)
                .HasColumnName("pnet_Phone3");
            entity.Property(e => e.PnetPhoneType1).HasColumnName("pnet_PhoneType1");
            entity.Property(e => e.PnetPhoneType2).HasColumnName("pnet_PhoneType2");
            entity.Property(e => e.PnetPhoneType3).HasColumnName("pnet_PhoneType3");
            entity.Property(e => e.PnetRecommendedById).HasColumnName("pnet_RecommendedById");
            entity.Property(e => e.PnetRecommendedByIdName)
                .HasMaxLength(160)
                .HasColumnName("pnet_RecommendedByIdName");
            entity.Property(e => e.PnetRecommendedByIdYomiName)
                .HasMaxLength(450)
                .HasColumnName("pnet_RecommendedByIdYomiName");
            entity.Property(e => e.PnetSegmentId).HasColumnName("pnet_SegmentId");
            entity.Property(e => e.PnetSegmentIdName)
                .HasMaxLength(100)
                .HasColumnName("pnet_SegmentIdName");
            entity.Property(e => e.PnetStartBusinessActivity)
                .HasColumnType("datetime")
                .HasColumnName("pnet_StartBusinessActivity");
            entity.Property(e => e.PnetSubsidiaryId).HasColumnName("pnet_SubsidiaryId");
            entity.Property(e => e.PnetSubsidiaryIdName)
                .HasMaxLength(160)
                .HasColumnName("pnet_SubsidiaryIdName");
            entity.Property(e => e.PnetSubsidiaryIdYomiName)
                .HasMaxLength(160)
                .HasColumnName("pnet_SubsidiaryIdYomiName");
            entity.Property(e => e.PnetTaxdocumentnumber).HasColumnName("pnet_taxdocumentnumber");
            entity.Property(e => e.PnetTaxdocumentnumber2).HasColumnName("pnet_taxdocumentnumber2");
            entity.Property(e => e.PnetTaxdocumentnumber3).HasColumnName("pnet_taxdocumentnumber3");
            entity.Property(e => e.PnetTaxdocumenttype).HasColumnName("pnet_taxdocumenttype");
            entity.Property(e => e.QualifyingOpportunityIdName).HasMaxLength(300);
            entity.Property(e => e.RelatedObjectIdName).HasMaxLength(200);
            entity.Property(e => e.Revenue).HasColumnType("money");
            entity.Property(e => e.RevenueBase)
                .HasColumnType("money")
                .HasColumnName("Revenue_Base");
            entity.Property(e => e.Salutation).HasMaxLength(100);
            entity.Property(e => e.ScheduleFollowUpProspect)
                .HasColumnType("datetime")
                .HasColumnName("ScheduleFollowUp_Prospect");
            entity.Property(e => e.ScheduleFollowUpQualify)
                .HasColumnType("datetime")
                .HasColumnName("ScheduleFollowUp_Qualify");
            entity.Property(e => e.Sic)
                .HasMaxLength(20)
                .HasColumnName("SIC");
            entity.Property(e => e.Slaid).HasColumnName("SLAId");
            entity.Property(e => e.SlainvokedId).HasColumnName("SLAInvokedId");
            entity.Property(e => e.SlainvokedIdName)
                .HasMaxLength(160)
                .HasColumnName("SLAInvokedIdName");
            entity.Property(e => e.Slaname)
                .HasMaxLength(160)
                .HasColumnName("SLAName");
            entity.Property(e => e.Subject).HasMaxLength(300);
            entity.Property(e => e.Telephone1).HasMaxLength(50);
            entity.Property(e => e.Telephone2).HasMaxLength(50);
            entity.Property(e => e.Telephone3).HasMaxLength(50);
            entity.Property(e => e.TimeSpentByMeOnEmailAndMeetings).HasMaxLength(1250);
            entity.Property(e => e.TransactionCurrencyIdName).HasMaxLength(100);
            entity.Property(e => e.TraversedPath).HasMaxLength(1250);
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.WebSiteUrl).HasMaxLength(200);
            entity.Property(e => e.YomiCompanyName).HasMaxLength(100);
            entity.Property(e => e.YomiFirstName).HasMaxLength(150);
            entity.Property(e => e.YomiFullName).HasMaxLength(450);
            entity.Property(e => e.YomiLastName).HasMaxLength(150);
            entity.Property(e => e.YomiMiddleName).HasMaxLength(150);
        });

        modelBuilder.Entity<LeadBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LeadBase", "crm");

            entity.HasIndex(e => e.LeadId, "ClusteredIndex-20201002-LeadBase")
                .IsUnique()
                .IsClustered();

            entity.HasIndex(e => e.PnetDocumentNumber, "NonClusteredIndex-20201002-LeadBase");

            entity.Property(e => e.BudgetAmount).HasColumnType("money");
            entity.Property(e => e.BudgetAmountBase)
                .HasColumnType("money")
                .HasColumnName("BudgetAmount_Base");
            entity.Property(e => e.CompanyName).HasMaxLength(100);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerIdName).HasMaxLength(4000);
            entity.Property(e => e.CustomerIdYomiName).HasMaxLength(4000);
            entity.Property(e => e.DoNotBulkEmail).HasColumnName("DoNotBulkEMail");
            entity.Property(e => e.DoNotEmail).HasColumnName("DoNotEMail");
            entity.Property(e => e.DoNotSendMm).HasColumnName("DoNotSendMM");
            entity.Property(e => e.EmailAddress1)
                .HasMaxLength(100)
                .HasColumnName("EMailAddress1");
            entity.Property(e => e.EmailAddress2)
                .HasMaxLength(100)
                .HasColumnName("EMailAddress2");
            entity.Property(e => e.EmailAddress3)
                .HasMaxLength(100)
                .HasColumnName("EMailAddress3");
            entity.Property(e => e.EstimatedAmount).HasColumnType("money");
            entity.Property(e => e.EstimatedAmountBase)
                .HasColumnType("money")
                .HasColumnName("EstimatedAmount_Base");
            entity.Property(e => e.EstimatedCloseDate).HasColumnType("datetime");
            entity.Property(e => e.ExchangeRate).HasColumnType("numeric(23, 10)");
            entity.Property(e => e.Fax).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(160);
            entity.Property(e => e.JobTitle).HasMaxLength(100);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.LastOnHoldTime).HasColumnType("datetime");
            entity.Property(e => e.LastUsedInCampaign).HasColumnType("datetime");
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.MobilePhone).HasMaxLength(26);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Pager).HasMaxLength(20);
            entity.Property(e => e.PnetAccountName)
                .HasMaxLength(160)
                .HasColumnName("pnet_AccountName");
            entity.Property(e => e.PnetAddress)
                .HasMaxLength(250)
                .HasColumnName("pnet_Address");
            entity.Property(e => e.PnetAddressNumber).HasColumnName("pnet_AddressNumber");
            entity.Property(e => e.PnetAreaCode1)
                .HasMaxLength(7)
                .HasColumnName("pnet_AreaCode1");
            entity.Property(e => e.PnetAreaCode2)
                .HasMaxLength(7)
                .HasColumnName("pnet_AreaCode2");
            entity.Property(e => e.PnetAreaCode3)
                .HasMaxLength(7)
                .HasColumnName("pnet_AreaCode3");
            entity.Property(e => e.PnetBlock)
                .HasMaxLength(20)
                .HasColumnName("pnet_Block");
            entity.Property(e => e.PnetCnaeid).HasColumnName("pnet_CNAEId");
            entity.Property(e => e.PnetCnoid).HasColumnName("pnet_CNOId");
            entity.Property(e => e.PnetCommercialAction).HasColumnName("pnet_CommercialAction");
            entity.Property(e => e.PnetCommercialActionDescription)
                .HasMaxLength(400)
                .HasColumnName("pnet_CommercialActionDescription");
            entity.Property(e => e.PnetConsolidatePhone1)
                .HasMaxLength(100)
                .HasColumnName("pnet_ConsolidatePhone1");
            entity.Property(e => e.PnetConsolidatePhone2)
                .HasMaxLength(100)
                .HasColumnName("pnet_ConsolidatePhone2");
            entity.Property(e => e.PnetConsolidatePhone3)
                .HasMaxLength(100)
                .HasColumnName("pnet_ConsolidatePhone3");
            entity.Property(e => e.PnetDepartment)
                .HasMaxLength(3)
                .HasColumnName("pnet_Department");
            entity.Property(e => e.PnetDistrictLocalityId).HasColumnName("pnet_DistrictLocalityId");
            entity.Property(e => e.PnetDocumentNumber).HasColumnName("pnet_DocumentNumber");
            entity.Property(e => e.PnetDocumentType).HasColumnName("pnet_DocumentType");
            entity.Property(e => e.PnetDoor)
                .HasMaxLength(3)
                .HasColumnName("pnet_Door");
            entity.Property(e => e.PnetDuplicatedContact).HasColumnName("pnet_DuplicatedContact");
            entity.Property(e => e.PnetFloor)
                .HasMaxLength(3)
                .HasColumnName("pnet_Floor");
            entity.Property(e => e.PnetGender).HasColumnName("pnet_Gender");
            entity.Property(e => e.PnetGetServerDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_GetServerDate");
            entity.Property(e => e.PnetNeighborhood)
                .HasMaxLength(100)
                .HasColumnName("pnet_Neighborhood");
            entity.Property(e => e.PnetPermanency).HasColumnName("pnet_Permanency");
            entity.Property(e => e.PnetPhone1)
                .HasMaxLength(100)
                .HasColumnName("pnet_Phone1");
            entity.Property(e => e.PnetPhone2)
                .HasMaxLength(100)
                .HasColumnName("pnet_Phone2");
            entity.Property(e => e.PnetPhone3)
                .HasMaxLength(100)
                .HasColumnName("pnet_Phone3");
            entity.Property(e => e.PnetPhoneType1).HasColumnName("pnet_PhoneType1");
            entity.Property(e => e.PnetPhoneType2).HasColumnName("pnet_PhoneType2");
            entity.Property(e => e.PnetPhoneType3).HasColumnName("pnet_PhoneType3");
            entity.Property(e => e.PnetRecommendedById).HasColumnName("pnet_RecommendedById");
            entity.Property(e => e.PnetSegmentId).HasColumnName("pnet_SegmentId");
            entity.Property(e => e.PnetStartBusinessActivity)
                .HasColumnType("datetime")
                .HasColumnName("pnet_StartBusinessActivity");
            entity.Property(e => e.PnetSubsidiaryId).HasColumnName("pnet_SubsidiaryId");
            entity.Property(e => e.PnetTaxdocumentnumber).HasColumnName("pnet_taxdocumentnumber");
            entity.Property(e => e.PnetTaxdocumentnumber2).HasColumnName("pnet_taxdocumentnumber2");
            entity.Property(e => e.PnetTaxdocumentnumber3).HasColumnName("pnet_taxdocumentnumber3");
            entity.Property(e => e.PnetTaxdocumenttype).HasColumnName("pnet_taxdocumenttype");
            entity.Property(e => e.Revenue).HasColumnType("money");
            entity.Property(e => e.RevenueBase)
                .HasColumnType("money")
                .HasColumnName("Revenue_Base");
            entity.Property(e => e.Salutation).HasMaxLength(100);
            entity.Property(e => e.ScheduleFollowUpProspect)
                .HasColumnType("datetime")
                .HasColumnName("ScheduleFollowUp_Prospect");
            entity.Property(e => e.ScheduleFollowUpQualify)
                .HasColumnType("datetime")
                .HasColumnName("ScheduleFollowUp_Qualify");
            entity.Property(e => e.Sic)
                .HasMaxLength(20)
                .HasColumnName("SIC");
            entity.Property(e => e.Slaid).HasColumnName("SLAId");
            entity.Property(e => e.SlainvokedId).HasColumnName("SLAInvokedId");
            entity.Property(e => e.Subject).HasMaxLength(300);
            entity.Property(e => e.Telephone1).HasMaxLength(50);
            entity.Property(e => e.Telephone2).HasMaxLength(50);
            entity.Property(e => e.Telephone3).HasMaxLength(50);
            entity.Property(e => e.TimeSpentByMeOnEmailAndMeetings).HasMaxLength(1250);
            entity.Property(e => e.TraversedPath).HasMaxLength(1250);
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.WebSiteUrl).HasMaxLength(200);
            entity.Property(e => e.YomiCompanyName).HasMaxLength(100);
            entity.Property(e => e.YomiFirstName).HasMaxLength(150);
            entity.Property(e => e.YomiFullName).HasMaxLength(450);
            entity.Property(e => e.YomiLastName).HasMaxLength(150);
            entity.Property(e => e.YomiMiddleName).HasMaxLength(150);
        });

        modelBuilder.Entity<LeadBase1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LeadBase", "int");

            entity.Property(e => e.BudgetAmount).HasColumnType("money");
            entity.Property(e => e.BudgetAmountBase)
                .HasColumnType("money")
                .HasColumnName("BudgetAmount_Base");
            entity.Property(e => e.CompanyName).HasMaxLength(100);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerIdName).HasMaxLength(4000);
            entity.Property(e => e.CustomerIdYomiName).HasMaxLength(4000);
            entity.Property(e => e.DoNotBulkEmail).HasColumnName("DoNotBulkEMail");
            entity.Property(e => e.DoNotEmail).HasColumnName("DoNotEMail");
            entity.Property(e => e.DoNotSendMm).HasColumnName("DoNotSendMM");
            entity.Property(e => e.EmailAddress1)
                .HasMaxLength(100)
                .HasColumnName("EMailAddress1");
            entity.Property(e => e.EmailAddress2)
                .HasMaxLength(100)
                .HasColumnName("EMailAddress2");
            entity.Property(e => e.EmailAddress3)
                .HasMaxLength(100)
                .HasColumnName("EMailAddress3");
            entity.Property(e => e.EstimatedAmount).HasColumnType("money");
            entity.Property(e => e.EstimatedAmountBase)
                .HasColumnType("money")
                .HasColumnName("EstimatedAmount_Base");
            entity.Property(e => e.EstimatedCloseDate).HasColumnType("datetime");
            entity.Property(e => e.ExchangeRate).HasColumnType("numeric(23, 10)");
            entity.Property(e => e.Fax).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(160);
            entity.Property(e => e.JobTitle).HasMaxLength(100);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.LastOnHoldTime).HasColumnType("datetime");
            entity.Property(e => e.LastUsedInCampaign).HasColumnType("datetime");
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.MobilePhone).HasMaxLength(26);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Pager).HasMaxLength(20);
            entity.Property(e => e.PnetAccountName)
                .HasMaxLength(160)
                .HasColumnName("pnet_AccountName");
            entity.Property(e => e.PnetAddress)
                .HasMaxLength(250)
                .HasColumnName("pnet_Address");
            entity.Property(e => e.PnetAddressNumber).HasColumnName("pnet_AddressNumber");
            entity.Property(e => e.PnetAreaCode1)
                .HasMaxLength(7)
                .HasColumnName("pnet_AreaCode1");
            entity.Property(e => e.PnetAreaCode2)
                .HasMaxLength(7)
                .HasColumnName("pnet_AreaCode2");
            entity.Property(e => e.PnetAreaCode3)
                .HasMaxLength(7)
                .HasColumnName("pnet_AreaCode3");
            entity.Property(e => e.PnetBlock)
                .HasMaxLength(20)
                .HasColumnName("pnet_Block");
            entity.Property(e => e.PnetCnaeid).HasColumnName("pnet_CNAEId");
            entity.Property(e => e.PnetCnoid).HasColumnName("pnet_CNOId");
            entity.Property(e => e.PnetCommercialAction).HasColumnName("pnet_CommercialAction");
            entity.Property(e => e.PnetCommercialActionDescription)
                .HasMaxLength(400)
                .HasColumnName("pnet_CommercialActionDescription");
            entity.Property(e => e.PnetConsolidatePhone1)
                .HasMaxLength(100)
                .HasColumnName("pnet_ConsolidatePhone1");
            entity.Property(e => e.PnetConsolidatePhone2)
                .HasMaxLength(100)
                .HasColumnName("pnet_ConsolidatePhone2");
            entity.Property(e => e.PnetConsolidatePhone3)
                .HasMaxLength(100)
                .HasColumnName("pnet_ConsolidatePhone3");
            entity.Property(e => e.PnetDepartment)
                .HasMaxLength(3)
                .HasColumnName("pnet_Department");
            entity.Property(e => e.PnetDistrictLocalityId).HasColumnName("pnet_DistrictLocalityId");
            entity.Property(e => e.PnetDocumentNumber).HasColumnName("pnet_DocumentNumber");
            entity.Property(e => e.PnetDocumentType).HasColumnName("pnet_DocumentType");
            entity.Property(e => e.PnetDoor)
                .HasMaxLength(3)
                .HasColumnName("pnet_Door");
            entity.Property(e => e.PnetDuplicatedContact).HasColumnName("pnet_DuplicatedContact");
            entity.Property(e => e.PnetFloor)
                .HasMaxLength(3)
                .HasColumnName("pnet_Floor");
            entity.Property(e => e.PnetGender).HasColumnName("pnet_Gender");
            entity.Property(e => e.PnetGetServerDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_GetServerDate");
            entity.Property(e => e.PnetNeighborhood)
                .HasMaxLength(100)
                .HasColumnName("pnet_Neighborhood");
            entity.Property(e => e.PnetPermanency).HasColumnName("pnet_Permanency");
            entity.Property(e => e.PnetPhone1)
                .HasMaxLength(100)
                .HasColumnName("pnet_Phone1");
            entity.Property(e => e.PnetPhone2)
                .HasMaxLength(100)
                .HasColumnName("pnet_Phone2");
            entity.Property(e => e.PnetPhone3)
                .HasMaxLength(100)
                .HasColumnName("pnet_Phone3");
            entity.Property(e => e.PnetPhoneType1).HasColumnName("pnet_PhoneType1");
            entity.Property(e => e.PnetPhoneType2).HasColumnName("pnet_PhoneType2");
            entity.Property(e => e.PnetPhoneType3).HasColumnName("pnet_PhoneType3");
            entity.Property(e => e.PnetRecommendedById).HasColumnName("pnet_RecommendedById");
            entity.Property(e => e.PnetSegmentId).HasColumnName("pnet_SegmentId");
            entity.Property(e => e.PnetStartBusinessActivity)
                .HasColumnType("datetime")
                .HasColumnName("pnet_StartBusinessActivity");
            entity.Property(e => e.PnetSubsidiaryId).HasColumnName("pnet_SubsidiaryId");
            entity.Property(e => e.PnetTaxdocumentnumber).HasColumnName("pnet_taxdocumentnumber");
            entity.Property(e => e.PnetTaxdocumentnumber2).HasColumnName("pnet_taxdocumentnumber2");
            entity.Property(e => e.PnetTaxdocumentnumber3).HasColumnName("pnet_taxdocumentnumber3");
            entity.Property(e => e.PnetTaxdocumenttype).HasColumnName("pnet_taxdocumenttype");
            entity.Property(e => e.Revenue).HasColumnType("money");
            entity.Property(e => e.RevenueBase)
                .HasColumnType("money")
                .HasColumnName("Revenue_Base");
            entity.Property(e => e.Salutation).HasMaxLength(100);
            entity.Property(e => e.ScheduleFollowUpProspect)
                .HasColumnType("datetime")
                .HasColumnName("ScheduleFollowUp_Prospect");
            entity.Property(e => e.ScheduleFollowUpQualify)
                .HasColumnType("datetime")
                .HasColumnName("ScheduleFollowUp_Qualify");
            entity.Property(e => e.Sic)
                .HasMaxLength(20)
                .HasColumnName("SIC");
            entity.Property(e => e.Slaid).HasColumnName("SLAId");
            entity.Property(e => e.SlainvokedId).HasColumnName("SLAInvokedId");
            entity.Property(e => e.Subject).HasMaxLength(300);
            entity.Property(e => e.Telephone1).HasMaxLength(50);
            entity.Property(e => e.Telephone2).HasMaxLength(50);
            entity.Property(e => e.Telephone3).HasMaxLength(50);
            entity.Property(e => e.TimeSpentByMeOnEmailAndMeetings).HasMaxLength(1250);
            entity.Property(e => e.TraversedPath).HasMaxLength(1250);
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.WebSiteUrl).HasMaxLength(200);
            entity.Property(e => e.YomiCompanyName).HasMaxLength(100);
            entity.Property(e => e.YomiFirstName).HasMaxLength(150);
            entity.Property(e => e.YomiFullName).HasMaxLength(450);
            entity.Property(e => e.YomiLastName).HasMaxLength(150);
            entity.Property(e => e.YomiMiddleName).HasMaxLength(150);
        });

        modelBuilder.Entity<LegajoDigital>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LegajoDigital", "int");

            entity.Property(e => e.Bp510)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("bp510");
            entity.Property(e => e.Bp730)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("bp730");
            entity.Property(e => e.Bp733)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("bp733");
            entity.Property(e => e.Bp935)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("bp935");
            entity.Property(e => e.Cuil)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cuil");
            entity.Property(e => e.DniServicios)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("dni_servicios");
            entity.Property(e => e.EstadoLeg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Estado_Leg");
            entity.Property(e => e.FechaConsulta)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fecha_consulta");
            entity.Property(e => e.Nif).HasColumnName("NIF");
        });

        modelBuilder.Entity<ListBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ListBase", "crm");

            entity.HasIndex(e => new { e.ListId, e.PnetContactoId }, "ListBase-20210108-IDX");

            entity.Property(e => e.Cost).HasColumnType("money");
            entity.Property(e => e.CostBase)
                .HasColumnType("money")
                .HasColumnName("Cost_Base");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ExchangeRate).HasColumnType("numeric(23, 10)");
            entity.Property(e => e.LastUsedOn).HasColumnType("datetime");
            entity.Property(e => e.ListName).HasMaxLength(300);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PnetBusinessUnit).HasColumnName("pnet_BusinessUnit");
            entity.Property(e => e.PnetBuyingPropensity).HasColumnName("pnet_BuyingPropensity");
            entity.Property(e => e.PnetCampaniaId).HasColumnName("pnet_CampaniaId");
            entity.Property(e => e.PnetCode)
                .HasMaxLength(100)
                .HasColumnName("pnet_Code");
            entity.Property(e => e.PnetContactoId).HasColumnName("pnet_ContactoId");
            entity.Property(e => e.PnetCounterId).HasColumnName("pnet_CounterID");
            entity.Property(e => e.PnetCounterValue).HasColumnName("pnet_CounterValue");
            entity.Property(e => e.PnetCreditAmount).HasColumnName("pnet_CreditAmount");
            entity.Property(e => e.PnetCreditSubType).HasColumnName("pnet_CreditSubType");
            entity.Property(e => e.PnetFechafin)
                .HasColumnType("datetime")
                .HasColumnName("pnet_fechafin");
            entity.Property(e => e.PnetFechainicio)
                .HasColumnType("datetime")
                .HasColumnName("pnet_fechainicio");
            entity.Property(e => e.PnetQuotaAmount).HasColumnName("pnet_QuotaAmount");
            entity.Property(e => e.PnetSegmentId).HasColumnName("pnet_SegmentId");
            entity.Property(e => e.PnetTeam).HasColumnName("pnet_Team");
            entity.Property(e => e.PnetTopic).HasColumnName("pnet_Topic");
            entity.Property(e => e.Purpose).HasMaxLength(512);
            entity.Property(e => e.Source).HasMaxLength(128);
            entity.Property(e => e.TraversedPath).HasMaxLength(1250);
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<ListBase1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ListBase", "int");

            entity.Property(e => e.Cost).HasColumnType("money");
            entity.Property(e => e.CostBase)
                .HasColumnType("money")
                .HasColumnName("Cost_Base");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ExchangeRate).HasColumnType("numeric(23, 10)");
            entity.Property(e => e.LastUsedOn).HasColumnType("datetime");
            entity.Property(e => e.ListName).HasMaxLength(300);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PnetBusinessUnit).HasColumnName("pnet_BusinessUnit");
            entity.Property(e => e.PnetBuyingPropensity).HasColumnName("pnet_BuyingPropensity");
            entity.Property(e => e.PnetCampaniaId).HasColumnName("pnet_CampaniaId");
            entity.Property(e => e.PnetCode)
                .HasMaxLength(100)
                .HasColumnName("pnet_Code");
            entity.Property(e => e.PnetContactoId).HasColumnName("pnet_ContactoId");
            entity.Property(e => e.PnetCounterId).HasColumnName("pnet_CounterID");
            entity.Property(e => e.PnetCounterValue).HasColumnName("pnet_CounterValue");
            entity.Property(e => e.PnetCreditAmount).HasColumnName("pnet_CreditAmount");
            entity.Property(e => e.PnetCreditSubType).HasColumnName("pnet_CreditSubType");
            entity.Property(e => e.PnetFechafin)
                .HasColumnType("datetime")
                .HasColumnName("pnet_fechafin");
            entity.Property(e => e.PnetFechainicio)
                .HasColumnType("datetime")
                .HasColumnName("pnet_fechainicio");
            entity.Property(e => e.PnetQuotaAmount).HasColumnName("pnet_QuotaAmount");
            entity.Property(e => e.PnetSegmentId).HasColumnName("pnet_SegmentId");
            entity.Property(e => e.PnetTeam).HasColumnName("pnet_Team");
            entity.Property(e => e.PnetTopic).HasColumnName("pnet_Topic");
            entity.Property(e => e.Purpose).HasMaxLength(512);
            entity.Property(e => e.Source).HasMaxLength(128);
            entity.Property(e => e.TraversedPath).HasMaxLength(1250);
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<LocalidadesMunicipio>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LocalidadesMunicipio", "crm");

            entity.Property(e => e.Filial).HasMaxLength(160);
            entity.Property(e => e.FilialBpba)
                .HasMaxLength(100)
                .HasColumnName("FilialBPBA");
            entity.Property(e => e.FilialProme).HasMaxLength(400);
            entity.Property(e => e.Localidad).HasMaxLength(100);
            entity.Property(e => e.Municipio).HasMaxLength(100);
            entity.Property(e => e.Provincia).HasMaxLength(4000);
            entity.Property(e => e.Zona).HasMaxLength(100);
        });

        modelBuilder.Entity<LocalizedLabel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LocalizedLabel", "crm");

            entity.HasIndex(e => e.LocalizedLabelId, "LocalizedLabel-20210201-IDX");

            entity.Property(e => e.ObjectColumnName).HasMaxLength(128);
            entity.Property(e => e.OverwriteTime).HasColumnType("datetime");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<MetadataSchemaAttribute>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MetadataSchema_Attribute", "crm");

            entity.HasIndex(e => new { e.AttributeId, e.EntityId }, "Attribute-20210108-IDX");

            entity.Property(e => e.AttributeImeModeId).HasMaxLength(50);
            entity.Property(e => e.AttributeLogicalTypeId).HasMaxLength(50);
            entity.Property(e => e.AttributeRequiredLevelId).HasMaxLength(50);
            entity.Property(e => e.DefaultValue).HasMaxLength(100);
            entity.Property(e => e.DeprecatedVersion).HasMaxLength(24);
            entity.Property(e => e.ImeMode).HasMaxLength(50);
            entity.Property(e => e.IntroducedVersion).HasMaxLength(48);
            entity.Property(e => e.IsPkattribute).HasColumnName("IsPKAttribute");
            entity.Property(e => e.LogicalName).HasMaxLength(50);
            entity.Property(e => e.LookupStyle).HasMaxLength(50);
            entity.Property(e => e.ManagedPropertyLogicalName).HasMaxLength(100);
            entity.Property(e => e.ManagedPropertyParentAttributeName).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.OverwriteTime).HasColumnType("datetime");
            entity.Property(e => e.PhysicalName).HasMaxLength(50);
            entity.Property(e => e.TableColumnName).HasMaxLength(50);
            entity.Property(e => e.UpgradeDefaultValue).HasMaxLength(100);
            entity.Property(e => e.ValidForCreateApi).HasColumnName("ValidForCreateAPI");
            entity.Property(e => e.ValidForReadApi).HasColumnName("ValidForReadAPI");
            entity.Property(e => e.ValidForUpdateApi).HasColumnName("ValidForUpdateAPI");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.XmlAbbreviation).HasMaxLength(50);
        });

        modelBuilder.Entity<MetadataSchemaEntity>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MetadataSchema_Entity", "crm");

            entity.HasIndex(e => e.EntityId, "Entity-20210108-IDX");

            entity.Property(e => e.AddressTableName).HasMaxLength(64);
            entity.Property(e => e.BaseTableName).HasMaxLength(64);
            entity.Property(e => e.CollectionName).HasMaxLength(64);
            entity.Property(e => e.EntityAssembly).HasMaxLength(255);
            entity.Property(e => e.EntityClassName).HasMaxLength(255);
            entity.Property(e => e.EntityColor).HasMaxLength(7);
            entity.Property(e => e.EntityHelpUrl).HasMaxLength(1024);
            entity.Property(e => e.EntitySetName).HasMaxLength(64);
            entity.Property(e => e.ExtensionTableName).HasMaxLength(64);
            entity.Property(e => e.IconLargeName).HasMaxLength(512);
            entity.Property(e => e.IconMediumName).HasMaxLength(512);
            entity.Property(e => e.IconSmallName).HasMaxLength(512);
            entity.Property(e => e.IntroducedVersion).HasMaxLength(48);
            entity.Property(e => e.IsAirupdated).HasColumnName("IsAIRUpdated");
            entity.Property(e => e.IsBpfentity).HasColumnName("IsBPFEntity");
            entity.Property(e => e.IsHsmenabled).HasColumnName("IsHSMEnabled");
            entity.Property(e => e.IsSlaenabled).HasColumnName("IsSLAEnabled");
            entity.Property(e => e.LogicalCollectionName).HasMaxLength(64);
            entity.Property(e => e.LogicalName).HasMaxLength(64);
            entity.Property(e => e.MobileOfflineFilters).HasMaxLength(4000);
            entity.Property(e => e.Name).HasMaxLength(64);
            entity.Property(e => e.OriginalLocalizedCollectionName).HasMaxLength(100);
            entity.Property(e => e.OriginalLocalizedName).HasMaxLength(100);
            entity.Property(e => e.OverwriteTime).HasColumnType("datetime");
            entity.Property(e => e.ParentControllingAttributeName).HasMaxLength(100);
            entity.Property(e => e.PhysicalName).HasMaxLength(64);
            entity.Property(e => e.ReportViewName).HasMaxLength(64);
            entity.Property(e => e.ServiceAssembly).HasMaxLength(255);
            entity.Property(e => e.ServiceClassName).HasMaxLength(255);
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<MetadataSchemaLocalizedLabel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MetadataSchema_LocalizedLabel", "crm");

            entity.HasIndex(e => new { e.ObjectId, e.ObjectColumnName }, "LocalizedLabel-20210108-IDX");

            entity.Property(e => e.ObjectColumnName).HasMaxLength(128);
            entity.Property(e => e.OverwriteTime).HasColumnType("datetime");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<MigrationHistory>(entity =>
        {
            entity.HasKey(e => new { e.MigrationId, e.ContextKey }).HasName("PK_dbo.__MigrationHistory");

            entity.ToTable("__MigrationHistory");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ContextKey).HasMaxLength(300);
            entity.Property(e => e.ProductVersion).HasMaxLength(32);
        });

        modelBuilder.Entity<MktBasesCampaña>(entity =>
        {
            entity.HasKey(e => e.IdBases);

            entity.ToTable("mktBasesCampaña", "app");

            entity.Property(e => e.Archivo).HasMaxLength(255);
            entity.Property(e => e.Año).HasColumnName("año");
            entity.Property(e => e.Campaña).HasMaxLength(255);
            entity.Property(e => e.Dni)
                .HasMaxLength(255)
                .HasColumnName("DNI");
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.IdProceso).HasMaxLength(50);
            entity.Property(e => e.Mail)
                .HasMaxLength(255)
                .HasColumnName("mail");
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.NombreCliente)
                .HasMaxLength(255)
                .HasColumnName("Nombre_Cliente");
            entity.Property(e => e.Oferta).HasColumnType("money");
            entity.Property(e => e.Oval)
                .HasMaxLength(255)
                .HasColumnName("OVAL");
            entity.Property(e => e.Sucursal).HasMaxLength(255);
            entity.Property(e => e.Tel1)
                .HasMaxLength(255)
                .HasColumnName("tel_1");
            entity.Property(e => e.Tel2)
                .HasMaxLength(255)
                .HasColumnName("tel_2");
            entity.Property(e => e.Tel3)
                .HasMaxLength(255)
                .HasColumnName("tel_3");
            entity.Property(e => e.TelefonoBanco)
                .HasMaxLength(255)
                .HasColumnName("telefono_banco");
            entity.Property(e => e.Tipo1)
                .HasMaxLength(255)
                .HasColumnName("tipo_1");
            entity.Property(e => e.Tipo2)
                .HasMaxLength(255)
                .HasColumnName("tipo_2");
            entity.Property(e => e.Tipo3)
                .HasMaxLength(255)
                .HasColumnName("tipo_3");
            entity.Property(e => e.Zona).HasMaxLength(255);
        });

        modelBuilder.Entity<MktBasesCampaña1>(entity =>
        {
            entity.HasKey(e => e.IdBases);

            entity.ToTable("mktBasesCampaña", "int");

            entity.Property(e => e.Archivo).HasMaxLength(255);
            entity.Property(e => e.Año).HasColumnName("año");
            entity.Property(e => e.Campaña).HasMaxLength(255);
            entity.Property(e => e.Dni)
                .HasMaxLength(255)
                .HasColumnName("DNI");
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.IdProceso).HasMaxLength(50);
            entity.Property(e => e.Mail)
                .HasMaxLength(255)
                .HasColumnName("mail");
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.NombreCliente)
                .HasMaxLength(255)
                .HasColumnName("Nombre_Cliente");
            entity.Property(e => e.Oferta).HasColumnType("money");
            entity.Property(e => e.Oval).HasMaxLength(255);
            entity.Property(e => e.Sucursal).HasMaxLength(255);
            entity.Property(e => e.Tel1)
                .HasMaxLength(255)
                .HasColumnName("tel_1");
            entity.Property(e => e.Tel2)
                .HasMaxLength(255)
                .HasColumnName("tel_2");
            entity.Property(e => e.Tel3)
                .HasMaxLength(255)
                .HasColumnName("tel_3");
            entity.Property(e => e.TelefonoBanco)
                .HasMaxLength(255)
                .HasColumnName("telefono_banco");
            entity.Property(e => e.Tipo1)
                .HasMaxLength(255)
                .HasColumnName("tipo_1");
            entity.Property(e => e.Tipo2)
                .HasMaxLength(255)
                .HasColumnName("tipo_2");
            entity.Property(e => e.Tipo3)
                .HasMaxLength(255)
                .HasColumnName("tipo_3");
            entity.Property(e => e.Zona).HasMaxLength(255);
        });

        modelBuilder.Entity<MktFormularioWp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mktFormularioWP", "app");

            entity.Property(e => e.Archivo).HasMaxLength(255);
            entity.Property(e => e.Campaña)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Dni)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DNI");
            entity.Property(e => e.EntryDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Entry Date");
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.IdProceso).HasMaxLength(50);
            entity.Property(e => e.Medio)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Origen)
                .HasMaxLength(32)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MktFormularioWp1>(entity =>
        {
            entity.HasKey(e => e.IdFormularioWp);

            entity.ToTable("mktFormularioWP", "int");

            entity.Property(e => e.IdFormularioWp).HasColumnName("IdFormularioWP");
            entity.Property(e => e.Archivo).HasMaxLength(255);
            entity.Property(e => e.Campaña)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Dni)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DNI");
            entity.Property(e => e.EntryDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Entry Date");
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.IdProceso).HasMaxLength(50);
            entity.Property(e => e.Medio)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Origen)
                .HasMaxLength(32)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MktRegistroFormWp>(entity =>
        {
            entity.HasKey(e => e.IdRegistroFormWp).HasName("PK_mktRegistroFormWP_1");

            entity.ToTable("mktRegistroFormWP", "app");

            entity.Property(e => e.IdRegistroFormWp).HasColumnName("IdRegistroFormWP");
            entity.Property(e => e.FechaCreación).HasColumnType("datetime");
            entity.Property(e => e.FechaModificación).HasColumnType("datetime");
            entity.Property(e => e.IdFormWp).HasColumnName("IdFormWP");
            entity.Property(e => e.JsonData).HasMaxLength(2000);
        });

        modelBuilder.Entity<MktSeguimientoCamp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("mktSeguimientoCamp", "app");

            entity.Property(e => e.Archivo).HasMaxLength(255);
            entity.Property(e => e.Año).HasColumnName("año");
            entity.Property(e => e.Campaña).HasMaxLength(255);
            entity.Property(e => e.CampañaFormulario)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("Campaña Formulario");
            entity.Property(e => e.Dni)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DNI");
            entity.Property(e => e.EntryDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Entry Date");
            entity.Property(e => e.Mail)
                .HasMaxLength(255)
                .HasColumnName("mail");
            entity.Property(e => e.Medio)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.NombreCliente)
                .HasMaxLength(255)
                .HasColumnName("Nombre_Cliente");
            entity.Property(e => e.Oferta).HasColumnType("money");
            entity.Property(e => e.Origen)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Oval)
                .HasMaxLength(255)
                .HasColumnName("OVAL");
            entity.Property(e => e.Sucursal).HasMaxLength(255);
            entity.Property(e => e.Tel1)
                .HasMaxLength(255)
                .HasColumnName("tel_1");
            entity.Property(e => e.Tel2)
                .HasMaxLength(255)
                .HasColumnName("tel_2");
            entity.Property(e => e.Tel3)
                .HasMaxLength(255)
                .HasColumnName("tel_3");
            entity.Property(e => e.TelefonoBanco)
                .HasMaxLength(255)
                .HasColumnName("telefono_banco");
            entity.Property(e => e.Tipo1)
                .HasMaxLength(255)
                .HasColumnName("tipo_1");
            entity.Property(e => e.Tipo2)
                .HasMaxLength(255)
                .HasColumnName("tipo_2");
            entity.Property(e => e.Tipo3)
                .HasMaxLength(255)
                .HasColumnName("tipo_3");
            entity.Property(e => e.Zona).HasMaxLength(255);
        });

        modelBuilder.Entity<MktSeguimientoCampPopUp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("mktSeguimientoCampPopUps", "app");

            entity.Property(e => e.Archivo).HasMaxLength(255);
            entity.Property(e => e.Año).HasColumnName("año");
            entity.Property(e => e.Campaña).HasMaxLength(255);
            entity.Property(e => e.CampañaFormulario)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("Campaña Formulario");
            entity.Property(e => e.Dni)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DNI");
            entity.Property(e => e.EntryDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Entry Date");
            entity.Property(e => e.FilialProme)
                .HasMaxLength(400)
                .HasColumnName("Filial Prome");
            entity.Property(e => e.IdProceso).HasMaxLength(50);
            entity.Property(e => e.Mail)
                .HasMaxLength(255)
                .HasColumnName("mail");
            entity.Property(e => e.MailEc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MailEC");
            entity.Property(e => e.Medio)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NombreCliente)
                .HasMaxLength(255)
                .HasColumnName("Nombre_Cliente");
            entity.Property(e => e.Oferta).HasColumnType("money");
            entity.Property(e => e.Origen)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Oval)
                .HasMaxLength(255)
                .HasColumnName("OVAL");
            entity.Property(e => e.SubZonaId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SUB ZONA ID");
            entity.Property(e => e.SubZonaNombre)
                .HasMaxLength(200)
                .HasColumnName("SUB ZONA NOMBRE");
            entity.Property(e => e.Sucursal).HasMaxLength(255);
            entity.Property(e => e.SucursalCrm)
                .HasMaxLength(160)
                .HasColumnName("SucursalCRM");
            entity.Property(e => e.Tel1)
                .HasMaxLength(255)
                .HasColumnName("tel_1");
            entity.Property(e => e.Tel2)
                .HasMaxLength(255)
                .HasColumnName("tel_2");
            entity.Property(e => e.Tel3)
                .HasMaxLength(255)
                .HasColumnName("tel_3");
            entity.Property(e => e.TelefonoBanco)
                .HasMaxLength(255)
                .HasColumnName("telefono_banco");
            entity.Property(e => e.Tipo1)
                .HasMaxLength(255)
                .HasColumnName("tipo_1");
            entity.Property(e => e.Tipo2)
                .HasMaxLength(255)
                .HasColumnName("tipo_2");
            entity.Property(e => e.Tipo3)
                .HasMaxLength(255)
                .HasColumnName("tipo_3");
            entity.Property(e => e.Zona).HasMaxLength(255);
            entity.Property(e => e.ZonaCrm)
                .HasMaxLength(160)
                .HasColumnName("ZonaCRM");
        });

        modelBuilder.Entity<MoraMasUnoNivelesRango>(entity =>
        {
            entity.HasKey(e => e.IdNivel);

            entity.Property(e => e.Color)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("COLOR");
            entity.Property(e => e.EsBpba).HasColumnName("esBPBA");
            entity.Property(e => e.Grupo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Maximo)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("MAXIMO");
            entity.Property(e => e.Minimo)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("MINIMO");
            entity.Property(e => e.NivelNro).HasColumnName("NIVEL_NRO");
            entity.Property(e => e.NivelTexto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NIVEL_TEXTO");
            entity.Property(e => e.SkFecha)
                .HasColumnType("date")
                .HasColumnName("skFecha");
        });

        modelBuilder.Entity<NivelesIrregularidad>(entity =>
        {
            entity.HasKey(e => e.IdNivelesIrregularidad);

            entity.ToTable("NivelesIrregularidad", "app");

            entity.Property(e => e.Color)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.Grupo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Maximo).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.Minimo).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.NivelNro).HasColumnName("Nivel_Nro");
            entity.Property(e => e.NivelTexto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nivel_Texto");
            entity.Property(e => e.SkFecha)
                .HasColumnType("date")
                .HasColumnName("skFecha");
        });

        modelBuilder.Entity<NivelesIrregularidad1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NivelesIrregularidad", "int");

            entity.Property(e => e.Color)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.Grupo).HasMaxLength(50);
            entity.Property(e => e.IdNivelesIrregularidad).ValueGeneratedOnAdd();
            entity.Property(e => e.MaximoVal).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.MinimoVal).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.Máximo).HasMaxLength(50);
            entity.Property(e => e.Mínimo).HasMaxLength(50);
            entity.Property(e => e.NivelTexto)
                .HasMaxLength(50)
                .HasColumnName("Nivel texto");
        });

        modelBuilder.Entity<NivelesRiesgo>(entity =>
        {
            entity.HasKey(e => e.IdNivelesRiesgo);

            entity.ToTable("NivelesRiesgo", "app");

            entity.Property(e => e.Color)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.Grupo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Maximo).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.Minimo).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.NivelNro).HasColumnName("Nivel_Nro");
            entity.Property(e => e.NivelTexto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nivel_Texto");
            entity.Property(e => e.SkFecha)
                .HasColumnType("date")
                .HasColumnName("skFecha");
        });

        modelBuilder.Entity<NivelesRiesgo1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NivelesRiesgo", "int");

            entity.Property(e => e.Color)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.Grupo).HasMaxLength(50);
            entity.Property(e => e.IdNivelesRiesgo).ValueGeneratedOnAdd();
            entity.Property(e => e.MaximoVal).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.MinimoVal).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.Máximo).HasMaxLength(50);
            entity.Property(e => e.Mínimo).HasMaxLength(50);
            entity.Property(e => e.NivelTexto)
                .HasMaxLength(50)
                .HasColumnName("Nivel texto");
        });

        modelBuilder.Entity<Nomina>(entity =>
        {
            entity.HasKey(e => new { e.SkNomina, e.SkArea }).HasName("PK_Nomina_1");

            entity.ToTable("Nomina", "app");

            entity.Property(e => e.SkNomina).HasColumnName("skNomina");
            entity.Property(e => e.SkArea).HasColumnName("skArea");
            entity.Property(e => e.CategoriaCodigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CategoriaNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Categoría)
                .HasMaxLength(73)
                .IsUnicode(false);
            entity.Property(e => e.FechaBaja).HasColumnType("date");
            entity.Property(e => e.FechaCreación).HasColumnType("datetime");
            entity.Property(e => e.FechaModificación).HasColumnType("datetime");
            entity.Property(e => e.Generación)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NominaArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("NominaArea", "app");

            entity.Property(e => e.AreaMail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CategoriaCodigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CategoriaNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Categoría)
                .HasMaxLength(73)
                .IsUnicode(false);
            entity.Property(e => e.CentroDeCostos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Generación)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gerencia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Latitud).HasColumnType("numeric(18, 6)");
            entity.Property(e => e.Longitud).HasColumnType("numeric(18, 6)");
            entity.Property(e => e.Mail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SectorCodigo)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.SectorNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Zona)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NominaCategoriaColocacione>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("NominaCategoriaColocaciones", "app");

            entity.Property(e => e.Bimestre).HasColumnType("datetime");
            entity.Property(e => e.BimestreDelAñoNombre).HasMaxLength(50);
            entity.Property(e => e.CategoriaNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ejecutivo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SubTipoCrédito)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Sucursal).HasMaxLength(160);
            entity.Property(e => e.Tasa).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Tipo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TipoCrédito)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Zona).HasMaxLength(4000);
        });

        modelBuilder.Entity<NormalizacionGestion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NormalizacionGestion", "int");

            entity.Property(e => e.AfectaTda)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("AFECTA_TDA");
            entity.Property(e => e.AfectaTmv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("AFECTA_TMV");
            entity.Property(e => e.CallDiasAccion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CALL DIAS ACCION");
            entity.Property(e => e.CallTipiAccion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CALL TIPI ACCION");
            entity.Property(e => e.CantidadCuotas).HasColumnName("CANTIDAD_CUOTAS");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("CODIGO_POSTAL");
            entity.Property(e => e.DeudaConsolidada)
                .HasColumnType("money")
                .HasColumnName("DEUDA_CONSOLIDADA");
            entity.Property(e => e.DeudaExigible)
                .HasColumnType("money")
                .HasColumnName("DEUDA_EXIGIBLE");
            entity.Property(e => e.DiasAtraso).HasColumnName("DIAS_ATRASO");
            entity.Property(e => e.Domicilio)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DOMICILIO");
            entity.Property(e => e.EcDiasAccion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EC DIAS ACCION");
            entity.Property(e => e.EcDiasVisita)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EC DIAS VISITA");
            entity.Property(e => e.EcTipiAccion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("EC TIPI ACCION");
            entity.Property(e => e.EcTipiVisita)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("EC TIPI VISITA");
            entity.Property(e => e.FechaCompromiso).HasColumnName("FECHA_COMPROMISO");
            entity.Property(e => e.FechaOtorgamiento)
                .HasColumnType("date")
                .HasColumnName("FECHA_OTORGAMIENTO");
            entity.Property(e => e.FechaProceso).HasPrecision(3);
            entity.Property(e => e.FechaProximaLiquidacion)
                .HasColumnType("date")
                .HasColumnName("FECHA_PROXIMA_LIQUIDACION");
            entity.Property(e => e.FechaUltimoMovimiento)
                .HasColumnType("date")
                .HasColumnName("FECHA_ULTIMO_MOVIMIENTO");
            entity.Property(e => e.FechaVencimiento)
                .HasColumnType("date")
                .HasColumnName("FECHA_VENCIMIENTO");
            entity.Property(e => e.FilialBpba)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("FILIAL_BPBA");
            entity.Property(e => e.GrupoVencimiento).HasMaxLength(32);
            entity.Property(e => e.Hogar)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("HOGAR");
            entity.Property(e => e.LegajoAdmin).HasColumnName("LEGAJO_ADMIN");
            entity.Property(e => e.LegajoAsigna).HasColumnName("LEGAJO_ASIGNA");
            entity.Property(e => e.Localidad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LOCALIDAD");
            entity.Property(e => e.Microempresa)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MICROEMPRESA");
            entity.Property(e => e.NombreAdmin)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_ADMIN");
            entity.Property(e => e.NombreAsigna)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_ASIGNA");
            entity.Property(e => e.NroDoc).HasColumnName("NRO_DOC");
            entity.Property(e => e.Plazo).HasColumnName("PLAZO");
            entity.Property(e => e.PrestamosMora).HasColumnName("PRESTAMOS_MORA");
            entity.Property(e => e.PrestamosVigentes).HasColumnName("PRESTAMOS_VIGENTES");
            entity.Property(e => e.RiesgoDiasAccion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("RIESGO DIAS ACCION");
            entity.Property(e => e.RiesgoDiasVisita)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("RIESGO DIAS VISITA");
            entity.Property(e => e.RiesgoTipiAccion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RIESGO TIPI ACCION");
            entity.Property(e => e.RiesgoTipiVisit)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RIESGO TIPI VISIT");
            entity.Property(e => e.SaldoConsolidado)
                .HasColumnType("money")
                .HasColumnName("SALDO_CONSOLIDADO");
            entity.Property(e => e.SaldoCuenta)
                .HasColumnType("money")
                .HasColumnName("SALDO_CUENTA");
            entity.Property(e => e.SaldoPrestamo)
                .HasColumnType("money")
                .HasColumnName("SALDO_PRESTAMO");
            entity.Property(e => e.Solicitud)
                .HasMaxLength(16)
                .HasColumnName("SOLICITUD");
            entity.Property(e => e.SubTipoCredito)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUB_TIPO_CREDITO");
            entity.Property(e => e.Sucursal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUCURSAL");
            entity.Property(e => e.TelefonoBpba)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEFONO_BPBA");
            entity.Property(e => e.TelefonoCrm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEFONO_CRM");
            entity.Property(e => e.TipoCredito)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO_CREDITO");
            entity.Property(e => e.Titular)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("TITULAR");
            entity.Property(e => e.TotalCuota)
                .HasColumnType("money")
                .HasColumnName("TOTAL_CUOTA");
            entity.Property(e => e.Url)
                .HasMaxLength(103)
                .IsUnicode(false)
                .HasColumnName("URL");
            entity.Property(e => e.Zona)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ZONA");
        });

        modelBuilder.Entity<NormalizacionGestion1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NormalizacionGestion", "rep");

            entity.Property(e => e.AfectaTda)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("AFECTA_TDA");
            entity.Property(e => e.AfectaTmv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("AFECTA_TMV");
            entity.Property(e => e.CallDiasAccion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CALL DIAS ACCION");
            entity.Property(e => e.CallTipiAccion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CALL TIPI ACCION");
            entity.Property(e => e.CantidadCuotas).HasColumnName("CANTIDAD_CUOTAS");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("CODIGO_POSTAL");
            entity.Property(e => e.DeudaConsolidada)
                .HasColumnType("money")
                .HasColumnName("DEUDA_CONSOLIDADA");
            entity.Property(e => e.DeudaExigible)
                .HasColumnType("money")
                .HasColumnName("DEUDA_EXIGIBLE");
            entity.Property(e => e.DiasAtraso).HasColumnName("DIAS_ATRASO");
            entity.Property(e => e.Domicilio)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DOMICILIO");
            entity.Property(e => e.EcDiasAccion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EC DIAS ACCION");
            entity.Property(e => e.EcDiasVisita)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EC DIAS VISITA");
            entity.Property(e => e.EcTipiAccion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("EC TIPI ACCION");
            entity.Property(e => e.EcTipiVisita)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("EC TIPI VISITA");
            entity.Property(e => e.FechaCompromiso).HasColumnName("FECHA_COMPROMISO");
            entity.Property(e => e.FechaOtorgamiento)
                .HasColumnType("date")
                .HasColumnName("FECHA_OTORGAMIENTO");
            entity.Property(e => e.FechaProximaLiquidacion)
                .HasColumnType("date")
                .HasColumnName("FECHA_PROXIMA_LIQUIDACION");
            entity.Property(e => e.FechaUltimoMovimiento)
                .HasColumnType("date")
                .HasColumnName("FECHA_ULTIMO_MOVIMIENTO");
            entity.Property(e => e.FechaVencimiento)
                .HasColumnType("date")
                .HasColumnName("FECHA_VENCIMIENTO");
            entity.Property(e => e.FilialBpba)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("FILIAL_BPBA");
            entity.Property(e => e.GrupoVencimiento).HasMaxLength(32);
            entity.Property(e => e.Hogar)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("HOGAR");
            entity.Property(e => e.LegajoAdmin).HasColumnName("LEGAJO_ADMIN");
            entity.Property(e => e.LegajoAsigna).HasColumnName("LEGAJO_ASIGNA");
            entity.Property(e => e.Localidad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LOCALIDAD");
            entity.Property(e => e.Microempresa)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MICROEMPRESA");
            entity.Property(e => e.NombreAdmin)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_ADMIN");
            entity.Property(e => e.NombreAsigna)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_ASIGNA");
            entity.Property(e => e.NroDoc).HasColumnName("NRO_DOC");
            entity.Property(e => e.Plazo).HasColumnName("PLAZO");
            entity.Property(e => e.PrestamosMora).HasColumnName("PRESTAMOS_MORA");
            entity.Property(e => e.PrestamosVigentes).HasColumnName("PRESTAMOS_VIGENTES");
            entity.Property(e => e.RiesgoDiasAccion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("RIESGO DIAS ACCION");
            entity.Property(e => e.RiesgoDiasVisita)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("RIESGO DIAS VISITA");
            entity.Property(e => e.RiesgoTipiAccion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RIESGO TIPI ACCION");
            entity.Property(e => e.RiesgoTipiVisit)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RIESGO TIPI VISIT");
            entity.Property(e => e.SaldoConsolidado)
                .HasColumnType("money")
                .HasColumnName("SALDO_CONSOLIDADO");
            entity.Property(e => e.SaldoCuenta)
                .HasColumnType("money")
                .HasColumnName("SALDO_CUENTA");
            entity.Property(e => e.SaldoPrestamo)
                .HasColumnType("money")
                .HasColumnName("SALDO_PRESTAMO");
            entity.Property(e => e.Solicitud)
                .HasMaxLength(16)
                .HasColumnName("SOLICITUD");
            entity.Property(e => e.SubTipoCredito)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUB_TIPO_CREDITO");
            entity.Property(e => e.Sucursal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUCURSAL");
            entity.Property(e => e.TelefonoBpba)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEFONO_BPBA");
            entity.Property(e => e.TelefonoCrm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEFONO_CRM");
            entity.Property(e => e.TipoCredito)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO_CREDITO");
            entity.Property(e => e.Titular)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("TITULAR");
            entity.Property(e => e.TotalCuota)
                .HasColumnType("money")
                .HasColumnName("TOTAL_CUOTA");
            entity.Property(e => e.Url)
                .HasMaxLength(103)
                .IsUnicode(false)
                .HasColumnName("URL");
            entity.Property(e => e.Zona)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ZONA");
        });

        modelBuilder.Entity<NovedadesCompleto>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NovedadesCompleto", "crm");

            entity.HasIndex(e => new { e.Documento, e.Agrupado }, "nci_wi_NovedadesCompleto_DC3F6F8791EFB6679DB8A2920AE186AF");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdRegistro).ValueGeneratedOnAdd();
            entity.Property(e => e.Observaciones)
                .HasMaxLength(2000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OpportunityBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OpportunityBase", "crm");

            entity.HasIndex(e => e.OpportunityId, "ClusteredIndex-20201002-OpportunityBase")
                .IsUnique()
                .IsClustered();

            entity.HasIndex(e => e.PnetCreditDestination, "IDX_OpportunityBase_2");

            entity.HasIndex(e => e.Name, "IDX_OpportunityBase_Solic");

            entity.HasIndex(e => e.PnetCampaignResponseId, "IDX_crmOpportunityBase_01");

            entity.HasIndex(e => new { e.ParentContactId, e.PnetEffectiveDateLiquidation, e.Name }, "NonClusteredIndex-20201002-OpportunityBase");

            entity.HasIndex(e => new { e.PnetCreditSubType, e.Name, e.ModifiedOn }, "idx-OpportunityBase-FechaModificacionSolicitud-5").IsDescending(false, false, true);

            entity.HasIndex(e => new { e.PnetEffectiveDateLiquidation, e.PnetSuraccount, e.PnetCursabip, e.Name, e.StatusCode }, "idx_OpportunityBase_3");

            entity.HasIndex(e => new { e.PnetCreditSubType, e.PnetEffectiveDateLiquidation, e.PnetSuraccount, e.PnetCursabip, e.Name, e.StatusCode }, "idx_OpportunityBase_4");

            entity.HasIndex(e => new { e.StatusCode, e.CustomerId }, "idx_ext_OpportunityBase_01");

            entity.HasIndex(e => e.CustomerId, "idx_ext_OpportunityBase_02");

            entity.Property(e => e.ActualCloseDate).HasColumnType("datetime");
            entity.Property(e => e.ActualValue).HasColumnType("money");
            entity.Property(e => e.ActualValueBase)
                .HasColumnType("money")
                .HasColumnName("ActualValue_Base");
            entity.Property(e => e.BudgetAmount).HasColumnType("money");
            entity.Property(e => e.BudgetAmountBase)
                .HasColumnType("money")
                .HasColumnName("BudgetAmount_Base");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerIdName).HasMaxLength(4000);
            entity.Property(e => e.CustomerIdYomiName).HasMaxLength(4000);
            entity.Property(e => e.DiscountAmount).HasColumnType("money");
            entity.Property(e => e.DiscountAmountBase)
                .HasColumnType("money")
                .HasColumnName("DiscountAmount_Base");
            entity.Property(e => e.DiscountPercentage).HasColumnType("numeric(23, 10)");
            entity.Property(e => e.EstimatedCloseDate).HasColumnType("datetime");
            entity.Property(e => e.EstimatedValue).HasColumnType("money");
            entity.Property(e => e.EstimatedValueBase)
                .HasColumnType("money")
                .HasColumnName("EstimatedValue_Base");
            entity.Property(e => e.ExchangeRate).HasColumnType("numeric(23, 10)");
            entity.Property(e => e.FinalDecisionDate).HasColumnType("datetime");
            entity.Property(e => e.FreightAmount).HasColumnType("money");
            entity.Property(e => e.FreightAmountBase)
                .HasColumnType("money")
                .HasColumnName("FreightAmount_Base");
            entity.Property(e => e.LastOnHoldTime).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(300);
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Pnet30dayPaymentMethod).HasColumnName("pnet_30DayPaymentMethod");
            entity.Property(e => e.PnetAccountsReceivable).HasColumnName("pnet_AccountsReceivable");
            entity.Property(e => e.PnetAccumulateExecute).HasColumnName("pnet_AccumulateExecute");
            entity.Property(e => e.PnetAccumulateExecuteOk).HasColumnName("pnet_AccumulateExecuteOK");
            entity.Property(e => e.PnetAccumulatorWillPay).HasColumnName("pnet_AccumulatorWillPay");
            entity.Property(e => e.PnetAdultNumber).HasColumnName("pnet_AdultNumber");
            entity.Property(e => e.PnetAffectedAreaId).HasColumnName("pnet_AffectedAreaId");
            entity.Property(e => e.PnetAgreement).HasColumnName("pnet_Agreement");
            entity.Property(e => e.PnetAgro).HasColumnName("pnet_AGRO");
            entity.Property(e => e.PnetAmortizationperiod).HasColumnName("pnet_amortizationperiod");
            entity.Property(e => e.PnetAmortizationsystem).HasColumnName("pnet_amortizationsystem");
            entity.Property(e => e.PnetAmountRange).HasColumnName("pnet_AmountRange");
            entity.Property(e => e.PnetApprobationDate1)
                .HasColumnType("datetime")
                .HasColumnName("pnet_ApprobationDate1");
            entity.Property(e => e.PnetApprobationDate2)
                .HasColumnType("datetime")
                .HasColumnName("pnet_ApprobationDate2");
            entity.Property(e => e.PnetApprobationDate3)
                .HasColumnType("datetime")
                .HasColumnName("pnet_ApprobationDate3");
            entity.Property(e => e.PnetApprovalStatusStage1).HasColumnName("pnet_ApprovalStatusStage1");
            entity.Property(e => e.PnetApprovalStatusStage2).HasColumnName("pnet_ApprovalStatusStage2");
            entity.Property(e => e.PnetApprovalStatusStage3).HasColumnName("pnet_ApprovalStatusStage3");
            entity.Property(e => e.PnetApprovalStatusStage4).HasColumnName("pnet_ApprovalStatusStage4");
            entity.Property(e => e.PnetApprovalStatusStage5).HasColumnName("pnet_ApprovalStatusStage5");
            entity.Property(e => e.PnetApril).HasColumnName("pnet_April");
            entity.Property(e => e.PnetAtoPayEigthMonth).HasColumnName("pnet_AToPayEigthMonth");
            entity.Property(e => e.PnetAtoPayElvenMonth).HasColumnName("pnet_AToPayElvenMonth");
            entity.Property(e => e.PnetAtoPayFiveMonth).HasColumnName("pnet_AToPayFiveMonth");
            entity.Property(e => e.PnetAtoPayFourMonth).HasColumnName("pnet_AToPayFourMonth");
            entity.Property(e => e.PnetAtoPayNineMonth).HasColumnName("pnet_AToPayNineMonth");
            entity.Property(e => e.PnetAtoPayOneMonth).HasColumnName("pnet_AToPayOneMonth");
            entity.Property(e => e.PnetAtoPaySevenMonth).HasColumnName("pnet_AToPaySevenMonth");
            entity.Property(e => e.PnetAtoPaySixMonth).HasColumnName("pnet_AToPaySixMonth");
            entity.Property(e => e.PnetAtoPayTenMonth).HasColumnName("pnet_AToPayTenMonth");
            entity.Property(e => e.PnetAtoPayThreeMonth).HasColumnName("pnet_AToPayThreeMonth");
            entity.Property(e => e.PnetAtoPayTwelveMonth).HasColumnName("pnet_AToPayTwelveMonth");
            entity.Property(e => e.PnetAtoPayTwoMonth).HasColumnName("pnet_AToPayTwoMonth");
            entity.Property(e => e.PnetAugust).HasColumnName("pnet_August");
            entity.Property(e => e.PnetAverageAgeEmployees).HasColumnName("pnet_AverageAgeEmployees");
            entity.Property(e => e.PnetAverageFee).HasColumnName("pnet_AverageFee");
            entity.Property(e => e.PnetBackCar).HasColumnName("pnet_BackCar");
            entity.Property(e => e.PnetBackCarValue).HasColumnName("pnet_BackCarValue");
            entity.Property(e => e.PnetBackHouse).HasColumnName("pnet_BackHouse");
            entity.Property(e => e.PnetBackHouseCheck).HasColumnName("pnet_BackHouseCheck");
            entity.Property(e => e.PnetBackHouseValue).HasColumnName("pnet_BackHouseValue");
            entity.Property(e => e.PnetBackMachines).HasColumnName("pnet_BackMachines");
            entity.Property(e => e.PnetBackMachinesValue).HasColumnName("pnet_BackMachinesValue");
            entity.Property(e => e.PnetBackOthersProperties).HasColumnName("pnet_BackOthersProperties");
            entity.Property(e => e.PnetBackOthersPropertiesValue).HasColumnName("pnet_BackOthersPropertiesValue");
            entity.Property(e => e.PnetBanco).HasColumnName("pnet_Banco");
            entity.Property(e => e.PnetBankLoanAgreement).HasColumnName("pnet_BankLoanAgreement");
            entity.Property(e => e.PnetBankResponse).HasColumnName("pnet_BankResponse");
            entity.Property(e => e.PnetBeigthMonth).HasColumnName("pnet_BEigthMonth");
            entity.Property(e => e.PnetBelevenMonth).HasColumnName("pnet_BElevenMonth");
            entity.Property(e => e.PnetBfiveMonth).HasColumnName("pnet_BFiveMonth");
            entity.Property(e => e.PnetBfourMonth).HasColumnName("pnet_BFourMonth");
            entity.Property(e => e.PnetBnineMonth).HasColumnName("pnet_BNineMonth");
            entity.Property(e => e.PnetBoneMonth).HasColumnName("pnet_BOneMonth");
            entity.Property(e => e.PnetBsevenMonth).HasColumnName("pnet_BSevenMonth");
            entity.Property(e => e.PnetBsixMonth).HasColumnName("pnet_BSixMonth");
            entity.Property(e => e.PnetBtenMonth).HasColumnName("pnet_BTenMonth");
            entity.Property(e => e.PnetBthreeMonth).HasColumnName("pnet_BThreeMonth");
            entity.Property(e => e.PnetBtwelveMonth).HasColumnName("pnet_BTwelveMonth");
            entity.Property(e => e.PnetBtwoMonth).HasColumnName("pnet_BTwoMonth");
            entity.Property(e => e.PnetBusinessDescription).HasColumnName("pnet_BusinessDescription");
            entity.Property(e => e.PnetCampaignApprovalStatusStage).HasColumnName("pnet_CampaignApprovalStatusStage");
            entity.Property(e => e.PnetCampaignResponseId).HasColumnName("pnet_CampaignResponseId");
            entity.Property(e => e.PnetCar).HasColumnName("pnet_Car");
            entity.Property(e => e.PnetCashPaymentMethod).HasColumnName("pnet_CashPaymentMethod");
            entity.Property(e => e.PnetCashbox).HasColumnName("pnet_Cashbox");
            entity.Property(e => e.PnetCganancias)
                .HasMaxLength(1)
                .HasColumnName("pnet_cganancias");
            entity.Property(e => e.PnetChangeOwnership).HasColumnName("pnet_ChangeOwnership");
            entity.Property(e => e.PnetCheckFixedCostsAdd).HasColumnName("pnet_CheckFixedCostsAdd");
            entity.Property(e => e.PnetChildrenNumber).HasColumnName("pnet_ChildrenNumber");
            entity.Property(e => e.PnetCingbr)
                .HasMaxLength(1)
                .HasColumnName("pnet_cingbr");
            entity.Property(e => e.PnetCiva)
                .HasMaxLength(1)
                .HasColumnName("pnet_civa");
            entity.Property(e => e.PnetClass1).HasColumnName("pnet_Class1");
            entity.Property(e => e.PnetClassificationWillingnessToPay).HasColumnName("pnet_ClassificationWillingnessToPay");
            entity.Property(e => e.PnetCmodalidad).HasColumnName("pnet_cmodalidad");
            entity.Property(e => e.PnetCommercialBackgrounds).HasColumnName("pnet_CommercialBackgrounds");
            entity.Property(e => e.PnetCommercializationObservation).HasColumnName("pnet_CommercializationObservation");
            entity.Property(e => e.PnetCommitmentdate).HasColumnName("pnet_Commitmentdate");
            entity.Property(e => e.PnetCommunicationDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_CommunicationDate");
            entity.Property(e => e.PnetConsultations).HasColumnName("pnet_Consultations");
            entity.Property(e => e.PnetContract).HasColumnName("pnet_Contract");
            entity.Property(e => e.PnetContratationType).HasColumnName("pnet_ContratationType");
            entity.Property(e => e.PnetCorrectionFactorDebtMonthHigh).HasColumnName("pnet_CorrectionFactorDebtMonthHigh");
            entity.Property(e => e.PnetCorrectionFactorDebtMonthLow).HasColumnName("pnet_CorrectionFactorDebtMonthLow");
            entity.Property(e => e.PnetCorrectionFactorDebtMonthMiddle).HasColumnName("pnet_CorrectionFactorDebtMonthMiddle");
            entity.Property(e => e.PnetCorrectionFactorMonthHigh).HasColumnName("pnet_CorrectionFactorMonthHigh");
            entity.Property(e => e.PnetCorrectionFactorMonthLow).HasColumnName("pnet_CorrectionFactorMonthLow");
            entity.Property(e => e.PnetCorrectionFactorMonthMiddle).HasColumnName("pnet_CorrectionFactorMonthMiddle");
            entity.Property(e => e.PnetCounterId).HasColumnName("pnet_CounterId");
            entity.Property(e => e.PnetCoursesWorkshops).HasColumnName("pnet_CoursesWorkshops");
            entity.Property(e => e.PnetCpacauseChanges).HasColumnName("pnet_CPACauseChanges");
            entity.Property(e => e.PnetCpadecreased).HasColumnName("pnet_CPADecreased");
            entity.Property(e => e.PnetCpaincreased).HasColumnName("pnet_CPAIncreased");
            entity.Property(e => e.PnetCparesult)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_CPAResult");
            entity.Property(e => e.PnetCpcpaflow).HasColumnName("pnet_cpcpaflow");
            entity.Property(e => e.PnetCpincreased).HasColumnName("pnet_CPIncreased");
            entity.Property(e => e.PnetCpresult)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_CPResult");
            entity.Property(e => e.PnetCredit1DebtAmount)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_Credit1DebtAmount");
            entity.Property(e => e.PnetCredit2DebtAmount)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_Credit2DebtAmount");
            entity.Property(e => e.PnetCreditAmount).HasColumnName("pnet_CreditAmount");
            entity.Property(e => e.PnetCreditAmountSupplementary).HasColumnName("pnet_CreditAmountSupplementary");
            entity.Property(e => e.PnetCreditAmountTitular).HasColumnName("pnet_CreditAmountTitular");
            entity.Property(e => e.PnetCreditAmountletters)
                .HasMaxLength(300)
                .HasColumnName("pnet_CreditAmountletters");
            entity.Property(e => e.PnetCreditDestination).HasColumnName("pnet_CreditDestination");
            entity.Property(e => e.PnetCreditDestinationBusinessHistory).HasColumnName("pnet_CreditDestinationBusinessHistory");
            entity.Property(e => e.PnetCreditFate).HasColumnName("pnet_CreditFate");
            entity.Property(e => e.PnetCreditHistoryObservation).HasColumnName("pnet_CreditHistoryObservation");
            entity.Property(e => e.PnetCreditSubType).HasColumnName("pnet_CreditSubType");
            entity.Property(e => e.PnetCreditToBeCancelled1).HasColumnName("pnet_CreditToBeCancelled1");
            entity.Property(e => e.PnetCreditToBeCancelled2).HasColumnName("pnet_CreditToBeCancelled2");
            entity.Property(e => e.PnetCreditType).HasColumnName("pnet_CreditType");
            entity.Property(e => e.PnetCreditTypification)
                .HasMaxLength(3)
                .HasColumnName("pnet_CreditTypification");
            entity.Property(e => e.PnetCreditocongarantiafogaba).HasColumnName("pnet_creditocongarantiafogaba");
            entity.Property(e => e.PnetCronopago).HasColumnName("pnet_Cronopago");
            entity.Property(e => e.PnetCronopagoResult).HasColumnName("pnet_CronopagoResult");
            entity.Property(e => e.PnetCurrentCollegiate).HasColumnName("pnet_CurrentCollegiate");
            entity.Property(e => e.PnetCursabip).HasColumnName("pnet_cursabip");
            entity.Property(e => e.PnetCustomer1)
                .HasMaxLength(220)
                .HasColumnName("pnet_Customer1");
            entity.Property(e => e.PnetCustomer2)
                .HasMaxLength(153)
                .HasColumnName("pnet_Customer2");
            entity.Property(e => e.PnetCustomer3)
                .HasMaxLength(100)
                .HasColumnName("pnet_Customer3");
            entity.Property(e => e.PnetCustomerMonthHigh).HasColumnName("pnet_CustomerMonthHigh");
            entity.Property(e => e.PnetCustomerMonthLow).HasColumnName("pnet_CustomerMonthLow");
            entity.Property(e => e.PnetCustomerMonthMiddle).HasColumnName("pnet_CustomerMonthMiddle");
            entity.Property(e => e.PnetCustomerType).HasColumnName("pnet_CustomerType");
            entity.Property(e => e.PnetCustomerTypeCompany).HasColumnName("pnet_CustomerTypeCompany");
            entity.Property(e => e.PnetCustomerTypeFactorPercent).HasColumnName("pnet_CustomerTypeFactorPercent");
            entity.Property(e => e.PnetCustomerTypeOther).HasColumnName("pnet_CustomerTypeOther");
            entity.Property(e => e.PnetCustomerTypeParticular).HasColumnName("pnet_CustomerTypeParticular");
            entity.Property(e => e.PnetCustomerregistration).HasColumnName("pnet_customerregistration");
            entity.Property(e => e.PnetCv1).HasColumnName("pnet_CV1");
            entity.Property(e => e.PnetCv2).HasColumnName("pnet_CV2");
            entity.Property(e => e.PnetCv3).HasColumnName("pnet_CV3");
            entity.Property(e => e.PnetCvx1).HasColumnName("pnet_CVX1");
            entity.Property(e => e.PnetCvx2).HasColumnName("pnet_CVX2");
            entity.Property(e => e.PnetCvx3).HasColumnName("pnet_CVX3");
            entity.Property(e => e.PnetDateTest)
                .HasColumnType("datetime")
                .HasColumnName("pnet_DateTEST");
            entity.Property(e => e.PnetDeal).HasColumnName("pnet_Deal");
            entity.Property(e => e.PnetDebt).HasColumnName("pnet_debt");
            entity.Property(e => e.PnetDebtAdjustedMonthHigh).HasColumnName("pnet_DebtAdjustedMonthHigh");
            entity.Property(e => e.PnetDebtAdjustedMonthLow).HasColumnName("pnet_DebtAdjustedMonthLow");
            entity.Property(e => e.PnetDebtAdjustedMonthMiddle).HasColumnName("pnet_DebtAdjustedMonthMiddle");
            entity.Property(e => e.PnetDebtAmount)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_DebtAmount");
            entity.Property(e => e.PnetDebtlevel).HasColumnName("pnet_debtlevel");
            entity.Property(e => e.PnetDebtsMonthHigh).HasColumnName("pnet_DebtsMonthHigh");
            entity.Property(e => e.PnetDebtsMonthLow).HasColumnName("pnet_DebtsMonthLow");
            entity.Property(e => e.PnetDebtsMonthMiddle).HasColumnName("pnet_DebtsMonthMiddle");
            entity.Property(e => e.PnetDebtsToPay).HasColumnName("pnet_DebtsToPay");
            entity.Property(e => e.PnetDecember).HasColumnName("pnet_December");
            entity.Property(e => e.PnetDividends).HasColumnName("pnet_Dividends");
            entity.Property(e => e.PnetDocumentUrl)
                .HasMaxLength(500)
                .HasColumnName("pnet_DocumentURL");
            entity.Property(e => e.PnetDueMoreThanOneYear).HasColumnName("pnet_DueMoreThanOneYear");
            entity.Property(e => e.PnetEffectiveDateLiquidation)
                .HasColumnType("datetime")
                .HasColumnName("pnet_EffectiveDateLiquidation");
            entity.Property(e => e.PnetEigthMonth)
                .HasMaxLength(100)
                .HasColumnName("pnet_EigthMonth");
            entity.Property(e => e.PnetElevenMonth)
                .HasMaxLength(100)
                .HasColumnName("pnet_ElevenMonth");
            entity.Property(e => e.PnetEmployeesNumber).HasColumnName("pnet_EmployeesNumber");
            entity.Property(e => e.PnetEnddategraceperiod)
                .HasColumnType("datetime")
                .HasColumnName("pnet_enddategraceperiod");
            entity.Property(e => e.PnetEverSheDelayed).HasColumnName("pnet_EverSheDelayed");
            entity.Property(e => e.PnetExceptionLevel).HasColumnName("pnet_ExceptionLevel");
            entity.Property(e => e.PnetExceptionsAmount).HasColumnName("pnet_ExceptionsAmount");
            entity.Property(e => e.PnetExceptionsDebt).HasColumnName("pnet_ExceptionsDebt");
            entity.Property(e => e.PnetExceptionsDebtLevel2).HasColumnName("pnet_ExceptionsDebtLevel2");
            entity.Property(e => e.PnetExecutiveMonthHigh).HasColumnName("pnet_ExecutiveMonthHigh");
            entity.Property(e => e.PnetExecutiveMonthLow).HasColumnName("pnet_ExecutiveMonthLow");
            entity.Property(e => e.PnetExecutiveMonthMiddle).HasColumnName("pnet_ExecutiveMonthMiddle");
            entity.Property(e => e.PnetExecutiveNameId).HasColumnName("pnet_ExecutiveNameId");
            entity.Property(e => e.PnetExecutiveSeniority).HasColumnName("pnet_ExecutiveSeniority");
            entity.Property(e => e.PnetExecutiveadministrator).HasColumnName("pnet_executiveadministrator");
            entity.Property(e => e.PnetExtraSchoolActivities).HasColumnName("pnet_ExtraSchoolActivities");
            entity.Property(e => e.PnetFamilyExpensesMonthHigh).HasColumnName("pnet_FamilyExpensesMonthHigh");
            entity.Property(e => e.PnetFamilyExpensesMonthLow).HasColumnName("pnet_FamilyExpensesMonthLow");
            entity.Property(e => e.PnetFamilyExpensesMonthMiddle).HasColumnName("pnet_FamilyExpensesMonthMiddle");
            entity.Property(e => e.PnetFamilyExpensesccordingMe).HasColumnName("pnet_FamilyExpensesccordingME");
            entity.Property(e => e.PnetFamilyGroupObservations).HasColumnName("pnet_FamilyGroupObservations");
            entity.Property(e => e.PnetFamilyStrength).HasColumnName("pnet_FamilyStrength");
            entity.Property(e => e.PnetFebruary).HasColumnName("pnet_February");
            entity.Property(e => e.PnetFiveMonth)
                .HasMaxLength(100)
                .HasColumnName("pnet_FiveMonth");
            entity.Property(e => e.PnetFixedCostMonthHigh).HasColumnName("pnet_FixedCostMonthHigh");
            entity.Property(e => e.PnetFixedCostMonthLow).HasColumnName("pnet_FixedCostMonthLow");
            entity.Property(e => e.PnetFixedCostMonthMiddle).HasColumnName("pnet_FixedCostMonthMiddle");
            entity.Property(e => e.PnetFixedNumberCustomers).HasColumnName("pnet_FixedNumberCustomers");
            entity.Property(e => e.PnetFixedSalary).HasColumnName("pnet_FixedSalary");
            entity.Property(e => e.PnetFlagAttributions).HasColumnName("pnet_FlagAttributions");
            entity.Property(e => e.PnetFlagStateApprovalSent).HasColumnName("pnet_FlagStateApprovalSent");
            entity.Property(e => e.PnetFlagStateStartWorkflow).HasColumnName("pnet_FlagStateStartWorkflow");
            entity.Property(e => e.PnetFlagStateTransition).HasColumnName("pnet_FlagStateTransition");
            entity.Property(e => e.PnetFlagUcctoUccr).HasColumnName("pnet_FlagUCCtoUCCR");
            entity.Property(e => e.PnetFociAsMinimizingRisksAnd).HasColumnName("pnet_FociAsMinimizingRisksAnd");
            entity.Property(e => e.PnetFormType).HasColumnName("pnet_FormType");
            entity.Property(e => e.PnetFormal).HasColumnName("pnet_Formal");
            entity.Property(e => e.PnetFourMonth)
                .HasMaxLength(100)
                .HasColumnName("pnet_FourMonth");
            entity.Property(e => e.PnetFreeInterestrate).HasColumnName("pnet_FreeInterestrate");
            entity.Property(e => e.PnetFutureDreamBusiness).HasColumnName("pnet_FutureDreamBusiness");
            entity.Property(e => e.PnetFutureDreamFamily).HasColumnName("pnet_FutureDreamFamily");
            entity.Property(e => e.PnetGeoPositioining)
                .HasColumnType("datetime")
                .HasColumnName("pnet_GeoPositioining");
            entity.Property(e => e.PnetGetId)
                .HasMaxLength(100)
                .HasColumnName("pnet_getID");
            entity.Property(e => e.PnetGoodPayment).HasColumnName("pnet_GoodPayment");
            entity.Property(e => e.PnetGraceperiod).HasColumnName("pnet_graceperiod");
            entity.Property(e => e.PnetHighMonthFactor2).HasColumnName("pnet_HighMonthFactor2");
            entity.Property(e => e.PnetHigher30DayPaymentMethod).HasColumnName("pnet_Higher30DayPaymentMethod");
            entity.Property(e => e.PnetHouseType).HasColumnName("pnet_HouseType");
            entity.Property(e => e.PnetImpactonRm).HasColumnName("pnet_ImpactonRm");
            entity.Property(e => e.PnetInCampaign).HasColumnName("pnet_InCampaign");
            entity.Property(e => e.PnetIndependent).HasColumnName("pnet_Independent");
            entity.Property(e => e.PnetInformal).HasColumnName("pnet_Informal");
            entity.Property(e => e.PnetInterestRate).HasColumnName("pnet_InterestRate");
            entity.Property(e => e.PnetInterestRateAnual).HasColumnName("pnet_InterestRateAnual");
            entity.Property(e => e.PnetInterestRateMonthly).HasColumnName("pnet_InterestRateMonthly");
            entity.Property(e => e.PnetItpca)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_ITPCA");
            entity.Property(e => e.PnetJanuary).HasColumnName("pnet_January");
            entity.Property(e => e.PnetJuly).HasColumnName("pnet_July");
            entity.Property(e => e.PnetJune).HasColumnName("pnet_June");
            entity.Property(e => e.PnetLabor1).HasColumnName("pnet_Labor1");
            entity.Property(e => e.PnetLabor2).HasColumnName("pnet_Labor2");
            entity.Property(e => e.PnetLabor3).HasColumnName("pnet_Labor3");
            entity.Property(e => e.PnetLastSentDateColegiar)
                .HasColumnType("datetime")
                .HasColumnName("pnet_LastSentDateColegiar");
            entity.Property(e => e.PnetLastcomment).HasColumnName("pnet_Lastcomment");
            entity.Property(e => e.PnetLlapre).HasColumnName("pnet_Llapre");
            entity.Property(e => e.PnetLlare).HasColumnName("pnet_Llare");
            entity.Property(e => e.PnetLocal).HasColumnName("pnet_Local");
            entity.Property(e => e.PnetLog).HasColumnName("pnet_Log");
            entity.Property(e => e.PnetMachineryEquipment).HasColumnName("pnet_MachineryEquipment");
            entity.Property(e => e.PnetMachines).HasColumnName("pnet_Machines");
            entity.Property(e => e.PnetManagement).HasColumnName("pnet_Management");
            entity.Property(e => e.PnetMarch).HasColumnName("pnet_March");
            entity.Property(e => e.PnetMay).HasColumnName("pnet_May");
            entity.Property(e => e.PnetMechangeEvaluated).HasColumnName("pnet_MEChangeEvaluated");
            entity.Property(e => e.PnetMerchandises).HasColumnName("pnet_Merchandises");
            entity.Property(e => e.PnetMicroEmpresa).HasColumnName("pnet_MicroEmpresa");
            entity.Property(e => e.PnetMicroempresaExcellence).HasColumnName("pnet_MicroempresaExcellence");
            entity.Property(e => e.PnetMiddleMonthFactor).HasColumnName("pnet_MiddleMonthFactor");
            entity.Property(e => e.PnetMinimumEstimatedExpenditure).HasColumnName("pnet_MinimumEstimatedExpenditure");
            entity.Property(e => e.PnetMircorempresaInherited).HasColumnName("pnet_MircorempresaInherited");
            entity.Property(e => e.PnetMonthFirstQuota).HasColumnName("pnet_MonthFirstQuota");
            entity.Property(e => e.PnetMonthlyAmountPurchase).HasColumnName("pnet_MonthlyAmountPurchase");
            entity.Property(e => e.PnetMonthlyincome)
                .HasMaxLength(100)
                .HasColumnName("pnet_monthlyincome");
            entity.Property(e => e.PnetMonthlysales).HasColumnName("pnet_monthlysales");
            entity.Property(e => e.PnetMotivators).HasColumnName("pnet_Motivators");
            entity.Property(e => e.PnetMtabilityToPay)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_MTAbilityToPay");
            entity.Property(e => e.PnetMtabilityToPay2)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_MTAbilityToPay2");
            entity.Property(e => e.PnetMtacpca)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_MTACPCA");
            entity.Property(e => e.PnetMtamountFees).HasColumnName("pnet_MTAmountFees");
            entity.Property(e => e.PnetMtamountRecorded).HasColumnName("pnet_MTAmountRecorded");
            entity.Property(e => e.PnetMtaverageSalesMonth).HasColumnName("pnet_MTAverageSalesMonth");
            entity.Property(e => e.PnetMtcapactyPaymentAdjusted)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_MTCapactyPaymentAdjusted");
            entity.Property(e => e.PnetMtcapactyPaymentAdjusted2)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_MTCapactyPaymentAdjusted2");
            entity.Property(e => e.PnetMtchangesCorrectionFactor).HasColumnName("pnet_MTChangesCorrectionFactor");
            entity.Property(e => e.PnetMtcorrectionFactor).HasColumnName("pnet_MTCorrectionFactor");
            entity.Property(e => e.PnetMtcorrectionFactor2).HasColumnName("pnet_MTCorrectionFactor2");
            entity.Property(e => e.PnetMtcorrectionFactorPromeCurrentDebt)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_MTCorrectionFactorPromeCurrentDebt");
            entity.Property(e => e.PnetMtcorrectionFactorPromeCurrentDebt2).HasColumnName("pnet_MTCorrectionFactorPromeCurrentDebt2");
            entity.Property(e => e.PnetMtcorrectionFactorRenovation).HasColumnName("pnet_MTCorrectionFactorRenovation");
            entity.Property(e => e.PnetMtcpaaverageMonth).HasColumnName("pnet_MTCPAAverageMonth");
            entity.Property(e => e.PnetMtcpaverageMonth).HasColumnName("pnet_MTCPAverageMonth");
            entity.Property(e => e.PnetMtcreditHistoryObservation).HasColumnName("pnet_MTCreditHistoryObservation");
            entity.Property(e => e.PnetMtcreditLiquidationDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_MTCreditLiquidationDate");
            entity.Property(e => e.PnetMtcreditRatingHistory).HasColumnName("pnet_MTCreditRatingHistory");
            entity.Property(e => e.PnetMtdebt).HasColumnName("pnet_MTDebt");
            entity.Property(e => e.PnetMtdebt2).HasColumnName("pnet_MTDebt2");
            entity.Property(e => e.PnetMtdelayed).HasColumnName("pnet_MTDelayed");
            entity.Property(e => e.PnetMtevaluatorExecutive).HasColumnName("pnet_MTEvaluatorExecutive");
            entity.Property(e => e.PnetMteverDelayed).HasColumnName("pnet_MTEverDelayed");
            entity.Property(e => e.PnetMtfamilyExpenditures).HasColumnName("pnet_MTFamilyExpenditures");
            entity.Property(e => e.PnetMtfamilyExpenditures2).HasColumnName("pnet_MTFamilyExpenditures2");
            entity.Property(e => e.PnetMtfeesPaid).HasColumnName("pnet_MTFeesPaid");
            entity.Property(e => e.PnetMtfixedCost).HasColumnName("pnet_MTFixedCost");
            entity.Property(e => e.PnetMtfixedCost2).HasColumnName("pnet_MTFixedCost2");
            entity.Property(e => e.PnetMtmaximumProduce).HasColumnName("pnet_MTMaximumProduce");
            entity.Property(e => e.PnetMtmonthType)
                .HasMaxLength(100)
                .HasColumnName("pnet_MTMonthType");
            entity.Property(e => e.PnetMtmonthlyPurchase).HasColumnName("pnet_MTMonthlyPurchase");
            entity.Property(e => e.PnetMtmppca)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_MTMPPCA");
            entity.Property(e => e.PnetMtobservations).HasColumnName("pnet_MTObservations");
            entity.Property(e => e.PnetMtoperatingIncome)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_MTOperatingIncome");
            entity.Property(e => e.PnetMtoperatingIncome2)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_MTOperatingIncome2");
            entity.Property(e => e.PnetMtotherIncome).HasColumnName("pnet_MTOtherIncome");
            entity.Property(e => e.PnetMtotherIncome2).HasColumnName("pnet_MTOtherIncome2");
            entity.Property(e => e.PnetMtpaymentBehavior).HasColumnName("pnet_MTPaymentBehavior");
            entity.Property(e => e.PnetMtprice).HasColumnName("pnet_MTPrice");
            entity.Property(e => e.PnetMtpromeAdjustedDebt).HasColumnName("pnet_MTPromeAdjustedDebt");
            entity.Property(e => e.PnetMtpromeAdjustedDebt2).HasColumnName("pnet_MTPromeAdjustedDebt2");
            entity.Property(e => e.PnetMtpromeDebt).HasColumnName("pnet_MTPromeDebt");
            entity.Property(e => e.PnetMtpromeDebt2).HasColumnName("pnet_MTPromeDebt2");
            entity.Property(e => e.PnetMtquantityPurchase).HasColumnName("pnet_MTQuantityPurchase");
            entity.Property(e => e.PnetMtriskFocus).HasColumnName("pnet_MTRiskFocus");
            entity.Property(e => e.PnetMtsabilityToPay)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_MTSAbilityToPay");
            entity.Property(e => e.PnetMtsamountFees).HasColumnName("pnet_MTSAmountFees");
            entity.Property(e => e.PnetMtsamountRecorded).HasColumnName("pnet_MTSAmountRecorded");
            entity.Property(e => e.PnetMtscapactyPaymentAdjusted)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_MTSCapactyPaymentAdjusted");
            entity.Property(e => e.PnetMtschangesCorrectionFactor).HasColumnName("pnet_MTSChangesCorrectionFactor");
            entity.Property(e => e.PnetMtscorrectionFactorPromeCurrentDebt).HasColumnName("pnet_MTSCorrectionFactorPromeCurrentDebt");
            entity.Property(e => e.PnetMtscorrectionFactorRenovation).HasColumnName("pnet_MTSCorrectionFactorRenovation");
            entity.Property(e => e.PnetMtscorrectionfactor).HasColumnName("pnet_MTSCorrectionfactor");
            entity.Property(e => e.PnetMtscostsObservation).HasColumnName("pnet_MTSCostsObservation");
            entity.Property(e => e.PnetMtscpaaverageMonth).HasColumnName("pnet_MTSCPAAverageMonth");
            entity.Property(e => e.PnetMtscpaverageMonth).HasColumnName("pnet_MTSCPAverageMonth");
            entity.Property(e => e.PnetMtscreditHistory).HasColumnName("pnet_MTSCreditHistory");
            entity.Property(e => e.PnetMtscreditHistoryObservation).HasColumnName("pnet_MTSCreditHistoryObservation");
            entity.Property(e => e.PnetMtscreditLiquidationDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_MTSCreditLiquidationDate");
            entity.Property(e => e.PnetMtsdebt).HasColumnName("pnet_MTSDebt");
            entity.Property(e => e.PnetMtsdelayed).HasColumnName("pnet_MTSDelayed");
            entity.Property(e => e.PnetMtsevaluatorExecutive).HasColumnName("pnet_MTSEvaluatorExecutive");
            entity.Property(e => e.PnetMtseverDelayed).HasColumnName("pnet_MTSEverDelayed");
            entity.Property(e => e.PnetMtsexecutiveMonthMiddle).HasColumnName("pnet_MTSExecutiveMonthMiddle");
            entity.Property(e => e.PnetMtsfamilyExpenditures).HasColumnName("pnet_MTSFamilyExpenditures");
            entity.Property(e => e.PnetMtsfeesPaid).HasColumnName("pnet_MTSFeesPaid");
            entity.Property(e => e.PnetMtsfixedCost).HasColumnName("pnet_MTSFixedCost");
            entity.Property(e => e.PnetMtsobservations).HasColumnName("pnet_MTSObservations");
            entity.Property(e => e.PnetMtsoperatingIncome)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_MTSOperatingIncome");
            entity.Property(e => e.PnetMtsotherIncome).HasColumnName("pnet_MTSOtherIncome");
            entity.Property(e => e.PnetMtspatrimonialClassification).HasColumnName("pnet_MTSPatrimonialClassification");
            entity.Property(e => e.PnetMtspaymentBehavior).HasColumnName("pnet_MTSPaymentBehavior");
            entity.Property(e => e.PnetMtspca)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_MTSPCA");
            entity.Property(e => e.PnetMtspermanenceRating).HasColumnName("pnet_MTSPermanenceRating");
            entity.Property(e => e.PnetMtspromeAdjustedDebt).HasColumnName("pnet_MTSPromeAdjustedDebt");
            entity.Property(e => e.PnetMtspromeDebt).HasColumnName("pnet_MTSPromeDebt");
            entity.Property(e => e.PnetMtsqualityRecords).HasColumnName("pnet_MTSQualityRecords");
            entity.Property(e => e.PnetMtsqualityRecordsObservation).HasColumnName("pnet_MTSQualityRecordsObservation");
            entity.Property(e => e.PnetMtssubTotalVariableCost).HasColumnName("pnet_MTSSubTotalVariableCost");
            entity.Property(e => e.PnetMtsterm).HasColumnName("pnet_MTSTerm");
            entity.Property(e => e.PnetMtstotalCost).HasColumnName("pnet_MTSTotalCost");
            entity.Property(e => e.PnetMtstotalSales).HasColumnName("pnet_MTSTotalSales");
            entity.Property(e => e.PnetMtstotalVariableCost).HasColumnName("pnet_MTSTotalVariableCost");
            entity.Property(e => e.PnetMtsvariableCost).HasColumnName("pnet_MTSVariableCost");
            entity.Property(e => e.PnetMtswillingnessPay).HasColumnName("pnet_MTSWillingnessPay");
            entity.Property(e => e.PnetMtswillingnessPayObservations).HasColumnName("pnet_MTSWillingnessPayObservations");
            entity.Property(e => e.PnetMtterm).HasColumnName("pnet_MTTerm");
            entity.Property(e => e.PnetMttotalCost).HasColumnName("pnet_MTTotalCost");
            entity.Property(e => e.PnetMttotalCost2).HasColumnName("pnet_MTTotalCost2");
            entity.Property(e => e.PnetMttotalSales).HasColumnName("pnet_MTTotalSales");
            entity.Property(e => e.PnetMttotalSales2).HasColumnName("pnet_MTTotalSales2");
            entity.Property(e => e.PnetMtvariableCost).HasColumnName("pnet_MTVariableCost");
            entity.Property(e => e.PnetMtvariableCost2).HasColumnName("pnet_MTVariableCost2");
            entity.Property(e => e.PnetMtvariableCostsSubTotal).HasColumnName("pnet_MTVariableCostsSubTotal");
            entity.Property(e => e.PnetMtvariableCostsTotal).HasColumnName("pnet_MTVariableCostsTotal");
            entity.Property(e => e.PnetNegativebasisobs).HasColumnName("pnet_negativebasisobs");
            entity.Property(e => e.PnetNetAmount).HasColumnName("pnet_NetAmount");
            entity.Property(e => e.PnetNewProductQuantity1).HasColumnName("pnet_newProductQuantity1");
            entity.Property(e => e.PnetNewProductQuantity2).HasColumnName("pnet_newProductQuantity2");
            entity.Property(e => e.PnetNewProductQuantity3).HasColumnName("pnet_newProductQuantity3");
            entity.Property(e => e.PnetNineMonth)
                .HasMaxLength(100)
                .HasColumnName("pnet_NineMonth");
            entity.Property(e => e.PnetNoRecords).HasColumnName("pnet_NoRecords");
            entity.Property(e => e.PnetNovember).HasColumnName("pnet_November");
            entity.Property(e => e.PnetNpa).HasColumnName("pnet_NPA");
            entity.Property(e => e.PnetNpb).HasColumnName("pnet_NPB");
            entity.Property(e => e.PnetNpc).HasColumnName("pnet_NPC");
            entity.Property(e => e.PnetNpd).HasColumnName("pnet_NPD");
            entity.Property(e => e.PnetNumberMonthlyPurchases).HasColumnName("pnet_NumberMonthlyPurchases");
            entity.Property(e => e.PnetObservation).HasColumnName("pnet_Observation");
            entity.Property(e => e.PnetObservationsRenewal).HasColumnName("pnet_ObservationsRenewal");
            entity.Property(e => e.PnetOctober).HasColumnName("pnet_October");
            entity.Property(e => e.PnetOfferByMemberId).HasColumnName("pnet_OfferByMemberId");
            entity.Property(e => e.PnetOneMonth)
                .HasMaxLength(100)
                .HasColumnName("pnet_OneMonth");
            entity.Property(e => e.PnetOpcreditSubType).HasColumnName("pnet_OPCreditSubType");
            entity.Property(e => e.PnetOpcreditType).HasColumnName("pnet_OPCreditType");
            entity.Property(e => e.PnetOperationalResultsHigh)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_OperationalResultsHigh");
            entity.Property(e => e.PnetOperationalResultsLow)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_OperationalResultsLow");
            entity.Property(e => e.PnetOperationalResultsMiddle)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_OperationalResultsMiddle");
            entity.Property(e => e.PnetOpportunities).HasColumnName("pnet_Opportunities");
            entity.Property(e => e.PnetOpportunityId)
                .HasMaxLength(100)
                .HasColumnName("pnet_OpportunityID");
            entity.Property(e => e.PnetOpprincipalApplication)
                .HasMaxLength(100)
                .HasColumnName("pnet_OPPrincipalApplication");
            entity.Property(e => e.PnetOpreportType).HasColumnName("pnet_OPReportType");
            entity.Property(e => e.PnetOtherActive).HasColumnName("pnet_OtherActive");
            entity.Property(e => e.PnetOtherCirculatingActives).HasColumnName("pnet_OtherCirculatingActives");
            entity.Property(e => e.PnetOtherFamilyExpenses).HasColumnName("pnet_OtherFamilyExpenses");
            entity.Property(e => e.PnetOtherFixedActives).HasColumnName("pnet_OtherFixedActives");
            entity.Property(e => e.PnetOtherIncomeMonthHigh).HasColumnName("pnet_OtherIncomeMonthHigh");
            entity.Property(e => e.PnetOtherIncomeMonthLow).HasColumnName("pnet_OtherIncomeMonthLow");
            entity.Property(e => e.PnetOtherIncomeMonthMiddle).HasColumnName("pnet_OtherIncomeMonthMiddle");
            entity.Property(e => e.PnetOtherPaymentMethod).HasColumnName("pnet_OtherPaymentMethod");
            entity.Property(e => e.PnetOtherincomes).HasColumnName("pnet_otherincomes");
            entity.Property(e => e.PnetOthers).HasColumnName("pnet_Others");
            entity.Property(e => e.PnetOthersCirculatingPassives).HasColumnName("pnet_OthersCirculatingPassives");
            entity.Property(e => e.PnetOthersPassives).HasColumnName("pnet_OthersPassives");
            entity.Property(e => e.PnetOthersProperties).HasColumnName("pnet_OthersProperties");
            entity.Property(e => e.PnetOwnHouse).HasColumnName("pnet_OwnHouse");
            entity.Property(e => e.PnetOwnerEi).HasColumnName("pnet_OwnerEI");
            entity.Property(e => e.PnetPa).HasColumnName("pnet_PA");
            entity.Property(e => e.PnetPanelSin).HasColumnName("pnet_PanelSin");
            entity.Property(e => e.PnetPapers).HasColumnName("pnet_Papers");
            entity.Property(e => e.PnetParameterId).HasColumnName("pnet_ParameterId");
            entity.Property(e => e.PnetPatrimonialClassification).HasColumnName("pnet_PatrimonialClassification");
            entity.Property(e => e.PnetPatrimonialObservations).HasColumnName("pnet_PatrimonialObservations");
            entity.Property(e => e.PnetPatrimonialSolidityTotal).HasColumnName("pnet_PatrimonialSolidityTotal");
            entity.Property(e => e.PnetPatrimonialsolidity).HasColumnName("pnet_patrimonialsolidity");
            entity.Property(e => e.PnetPayCapacityAdjustedMonthHigh)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_PayCapacityAdjustedMonthHigh");
            entity.Property(e => e.PnetPayCapacityAdjustedMonthLow)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_PayCapacityAdjustedMonthLow");
            entity.Property(e => e.PnetPayCapacityAdjustedMonthMiddle)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_PayCapacityAdjustedMonthMiddle");
            entity.Property(e => e.PnetPayCapacityMonthHigh)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_PayCapacityMonthHigh");
            entity.Property(e => e.PnetPayCapacityMonthLow)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_PayCapacityMonthLow");
            entity.Property(e => e.PnetPayCapacityMonthMiddle)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_PayCapacityMonthMiddle");
            entity.Property(e => e.PnetPayCapacityPeriod)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_PayCapacityPeriod");
            entity.Property(e => e.PnetPayFees).HasColumnName("pnet_PayFees");
            entity.Property(e => e.PnetPaycapacityadjusted).HasColumnName("pnet_paycapacityadjusted");
            entity.Property(e => e.PnetPaymentBehavior).HasColumnName("pnet_PaymentBehavior");
            entity.Property(e => e.PnetPb).HasColumnName("pnet_PB");
            entity.Property(e => e.PnetPc).HasColumnName("pnet_PC");
            entity.Property(e => e.PnetPd).HasColumnName("pnet_PD");
            entity.Property(e => e.PnetPe).HasColumnName("pnet_pe");
            entity.Property(e => e.PnetPermanence).HasColumnName("pnet_Permanence");
            entity.Property(e => e.PnetPermanenceObservation).HasColumnName("pnet_PermanenceObservation");
            entity.Property(e => e.PnetPermanenceRating).HasColumnName("pnet_PermanenceRating");
            entity.Property(e => e.PnetPositiveReferences).HasColumnName("pnet_PositiveReferences");
            entity.Property(e => e.PnetPreApprovedAmountPa).HasColumnName("pnet_PreApprovedAmountPA");
            entity.Property(e => e.PnetPreApprovedClassificationOp).HasColumnName("pnet_PreApprovedClassificationOP");
            entity.Property(e => e.PnetPreApprovedFeePa).HasColumnName("pnet_PreApprovedFeePA");
            entity.Property(e => e.PnetPreApprovedOpportunity).HasColumnName("pnet_PreApprovedOpportunity");
            entity.Property(e => e.PnetPreapprovedAmount).HasColumnName("pnet_PreapprovedAmount");
            entity.Property(e => e.PnetPreapprovedFee).HasColumnName("pnet_PreapprovedFee");
            entity.Property(e => e.PnetPreferenceRate).HasColumnName("pnet_PreferenceRate");
            entity.Property(e => e.PnetPreviousCategory).HasColumnName("pnet_PreviousCategory");
            entity.Property(e => e.PnetPreviousInstance).HasColumnName("pnet_PreviousInstance");
            entity.Property(e => e.PnetPrincipalApplication).HasColumnName("pnet_PrincipalApplication");
            entity.Property(e => e.PnetPrivateEducation).HasColumnName("pnet_PrivateEducation");
            entity.Property(e => e.PnetProductName1)
                .HasMaxLength(114)
                .HasColumnName("pnet_ProductName1");
            entity.Property(e => e.PnetProductName2)
                .HasMaxLength(119)
                .HasColumnName("pnet_ProductName2");
            entity.Property(e => e.PnetProductName3)
                .HasMaxLength(109)
                .HasColumnName("pnet_ProductName3");
            entity.Property(e => e.PnetProductQuantity1).HasColumnName("pnet_ProductQuantity1");
            entity.Property(e => e.PnetProductQuantity2).HasColumnName("pnet_ProductQuantity2");
            entity.Property(e => e.PnetProductQuantity3).HasColumnName("pnet_ProductQuantity3");
            entity.Property(e => e.PnetPromeDebts).HasColumnName("pnet_PromeDebts");
            entity.Property(e => e.PnetPromebehavior).HasColumnName("pnet_PROMEBehavior");
            entity.Property(e => e.PnetProviders).HasColumnName("pnet_Providers");
            entity.Property(e => e.PnetPurchaseMethod).HasColumnName("pnet_PurchaseMethod");
            entity.Property(e => e.PnetQualityRecordSales).HasColumnName("pnet_QualityRecordSales");
            entity.Property(e => e.PnetQualityRecordsObservation).HasColumnName("pnet_QualityRecordsObservation");
            entity.Property(e => e.PnetQuotaExpirationDay).HasColumnName("pnet_QuotaExpirationDay");
            entity.Property(e => e.PnetQuotaOverdue).HasColumnName("pnet_QuotaOverdue");
            entity.Property(e => e.PnetQuotasNumber).HasColumnName("pnet_QuotasNumber");
            entity.Property(e => e.PnetQuotasPaid).HasColumnName("pnet_QuotasPaid");
            entity.Property(e => e.PnetRa).HasColumnName("pnet_RA");
            entity.Property(e => e.PnetRate).HasColumnName("pnet_Rate");
            entity.Property(e => e.PnetRate1).HasColumnName("pnet_rate1");
            entity.Property(e => e.PnetRateApplied).HasColumnName("pnet_RateApplied");
            entity.Property(e => e.PnetRawMaterial1).HasColumnName("pnet_RawMaterial1");
            entity.Property(e => e.PnetRawMaterial2).HasColumnName("pnet_RawMaterial2");
            entity.Property(e => e.PnetRawMaterial3).HasColumnName("pnet_RawMaterial3");
            entity.Property(e => e.PnetRawMaterials).HasColumnName("pnet_RawMaterials");
            entity.Property(e => e.PnetRb).HasColumnName("pnet_RB");
            entity.Property(e => e.PnetRc).HasColumnName("pnet_RC");
            entity.Property(e => e.PnetRd).HasColumnName("pnet_RD");
            entity.Property(e => e.PnetRecordCommitteeId).HasColumnName("pnet_RecordCommitteeId");
            entity.Property(e => e.PnetRegistrationDateAfip)
                .HasColumnType("datetime")
                .HasColumnName("pnet_RegistrationDateAFIP");
            entity.Property(e => e.PnetRemunerationType).HasColumnName("pnet_RemunerationType");
            entity.Property(e => e.PnetRenewalAccumulate).HasColumnName("pnet_RenewalAccumulate");
            entity.Property(e => e.PnetRenovation).HasColumnName("pnet_Renovation");
            entity.Property(e => e.PnetRenovationCorrectionFactor).HasColumnName("pnet_RenovationCorrectionFactor");
            entity.Property(e => e.PnetRenovationPayCapacity)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_RenovationPayCapacity");
            entity.Property(e => e.PnetRenovationPayCapacityAdjusted)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_REnovationPayCapacityAdjusted");
            entity.Property(e => e.PnetRenovationRequest).HasColumnName("pnet_RenovationRequest");
            entity.Property(e => e.PnetRenovationRequestManual).HasColumnName("pnet_RenovationRequestManual");
            entity.Property(e => e.PnetRent).HasColumnName("pnet_Rent");
            entity.Property(e => e.PnetReportGenerate).HasColumnName("pnet_ReportGenerate");
            entity.Property(e => e.PnetReportType).HasColumnName("pnet_ReportType");
            entity.Property(e => e.PnetReportTypeid).HasColumnName("pnet_ReportTypeid");
            entity.Property(e => e.PnetReportsGeneratePdf).HasColumnName("pnet_ReportsGeneratePDF");
            entity.Property(e => e.PnetReputationCommercialBasis).HasColumnName("pnet_ReputationCommercialBasis");
            entity.Property(e => e.PnetRequestId).HasColumnName("pnet_RequestId");
            entity.Property(e => e.PnetRequestIdOpp).HasColumnName("pnet_RequestId_Opp");
            entity.Property(e => e.PnetRequireRisk).HasColumnName("pnet_RequireRisk");
            entity.Property(e => e.PnetRequiresAccountOpening)
                .HasMaxLength(100)
                .HasColumnName("pnet_RequiresAccountOpening");
            entity.Property(e => e.PnetResponse)
                .HasMaxLength(100)
                .HasColumnName("pnet_Response");
            entity.Property(e => e.PnetResultadosScoreDePuntaje).HasColumnName("pnet_resultadosScoreDePuntaje");
            entity.Property(e => e.PnetRiskAnalysisId).HasColumnName("pnet_RiskAnalysisId");
            entity.Property(e => e.PnetRiskFactors).HasColumnName("pnet_RiskFactors");
            entity.Property(e => e.PnetRollupTotalAdjustedRevenue)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_RollupTotalAdjustedRevenue");
            entity.Property(e => e.PnetRollupTotalAdjustedRevenueDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_RollupTotalAdjustedRevenue_Date");
            entity.Property(e => e.PnetRollupTotalAdjustedRevenueState).HasColumnName("pnet_RollupTotalAdjustedRevenue_State");
            entity.Property(e => e.PnetRollupTotalFamilyBusinessDebts)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_RollupTotalFamilyBusinessDebts");
            entity.Property(e => e.PnetRollupTotalFamilyBusinessDebtsDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_RollupTotalFamilyBusinessDebts_Date");
            entity.Property(e => e.PnetRollupTotalFamilyBusinessDebtsState).HasColumnName("pnet_RollupTotalFamilyBusinessDebts_State");
            entity.Property(e => e.PnetRollupTotalFixedCost)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_RollupTotalFixedCost");
            entity.Property(e => e.PnetRollupTotalFixedCostDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_RollupTotalFixedCost_Date");
            entity.Property(e => e.PnetRollupTotalFixedCostState).HasColumnName("pnet_RollupTotalFixedCost_State");
            entity.Property(e => e.PnetSaa).HasColumnName("pnet_SAA");
            entity.Property(e => e.PnetSaleMonthHigh).HasColumnName("pnet_SaleMonthHigh");
            entity.Property(e => e.PnetSaleMonthLow).HasColumnName("pnet_SaleMonthLow");
            entity.Property(e => e.PnetSaleMonthMiddle).HasColumnName("pnet_SaleMonthMiddle");
            entity.Property(e => e.PnetSalePrice1).HasColumnName("pnet_SalePrice1");
            entity.Property(e => e.PnetSalePrice2).HasColumnName("pnet_SalePrice2");
            entity.Property(e => e.PnetSalePrice3).HasColumnName("pnet_SalePrice3");
            entity.Property(e => e.PnetSalesCustomer1).HasColumnName("pnet_SalesCustomer1");
            entity.Property(e => e.PnetSalesCustomer2).HasColumnName("pnet_SalesCustomer2");
            entity.Property(e => e.PnetSalesCustomer3).HasColumnName("pnet_SalesCustomer3");
            entity.Property(e => e.PnetSalesImpact1).HasColumnName("pnet_SalesImpact1");
            entity.Property(e => e.PnetSalesImpact2).HasColumnName("pnet_SalesImpact2");
            entity.Property(e => e.PnetSalesImpact3).HasColumnName("pnet_SalesImpact3");
            entity.Property(e => e.PnetSalesMonthHigh).HasColumnName("pnet_SalesMonthHigh");
            entity.Property(e => e.PnetSalesMonthLow).HasColumnName("pnet_SalesMonthLow");
            entity.Property(e => e.PnetSalesMonthMedium).HasColumnName("pnet_SalesMonthMedium");
            entity.Property(e => e.PnetSchema).HasColumnName("pnet_Schema");
            entity.Property(e => e.PnetSeptember).HasColumnName("pnet_September");
            entity.Property(e => e.PnetSetAcumRen).HasColumnName("pnet_SetAcumRen");
            entity.Property(e => e.PnetSetValuesInterestrate).HasColumnName("pnet_SetValuesInterestrate");
            entity.Property(e => e.PnetSettlementperiod).HasColumnName("pnet_settlementperiod");
            entity.Property(e => e.PnetSevenMonth)
                .HasMaxLength(100)
                .HasColumnName("pnet_SevenMonth");
            entity.Property(e => e.PnetSignature1)
                .HasMaxLength(100)
                .HasColumnName("pnet_Signature1");
            entity.Property(e => e.PnetSignature2)
                .HasMaxLength(100)
                .HasColumnName("pnet_Signature2");
            entity.Property(e => e.PnetSignature3)
                .HasMaxLength(100)
                .HasColumnName("pnet_Signature3");
            entity.Property(e => e.PnetSiteVisitNumber).HasColumnName("pnet_SiteVisitNumber");
            entity.Property(e => e.PnetSixMonth)
                .HasMaxLength(100)
                .HasColumnName("pnet_SixMonth");
            entity.Property(e => e.PnetSocialWork).HasColumnName("pnet_SocialWork");
            entity.Property(e => e.PnetSports).HasColumnName("pnet_Sports");
            entity.Property(e => e.PnetSteIme).HasColumnName("pnet_SteIME");
            entity.Property(e => e.PnetSteMe).HasColumnName("pnet_SteME");
            entity.Property(e => e.PnetStrengths).HasColumnName("pnet_Strengths");
            entity.Property(e => e.PnetSubtotalExpenditures).HasColumnName("pnet_SubtotalExpenditures");
            entity.Property(e => e.PnetSupplementaryRequest).HasColumnName("pnet_SupplementaryRequest");
            entity.Property(e => e.PnetSuraccount).HasColumnName("pnet_SURaccount");
            entity.Property(e => e.PnetSvcreditSubType).HasColumnName("pnet_SVCreditSubType");
            entity.Property(e => e.PnetSvcreditType).HasColumnName("pnet_SVCreditType");
            entity.Property(e => e.PnetSvreportType).HasColumnName("pnet_SVReportType");
            entity.Property(e => e.PnetTenMonth)
                .HasMaxLength(100)
                .HasColumnName("pnet_TenMonth");
            entity.Property(e => e.PnetTermRange)
                .HasMaxLength(2)
                .HasColumnName("pnet_TermRange");
            entity.Property(e => e.PnetTermRanges).HasColumnName("pnet_TermRanges");
            entity.Property(e => e.PnetTest)
                .HasMaxLength(100)
                .HasColumnName("pnet_test");
            entity.Property(e => e.PnetTest2).HasColumnName("pnet_test2");
            entity.Property(e => e.PnetThreeMonth)
                .HasMaxLength(100)
                .HasColumnName("pnet_ThreeMonth");
            entity.Property(e => e.PnetTmov).HasColumnName("pnet_TMov");
            entity.Property(e => e.PnetToDateCb)
                .HasColumnType("datetime")
                .HasColumnName("pnet_ToDateCB");
            entity.Property(e => e.PnetTotalActives).HasColumnName("pnet_TotalActives");
            entity.Property(e => e.PnetTotalAdjustedRevenue).HasColumnName("pnet_TotalAdjustedRevenue");
            entity.Property(e => e.PnetTotalCirculatingActives).HasColumnName("pnet_TotalCirculatingActives");
            entity.Property(e => e.PnetTotalCirculatingPassives).HasColumnName("pnet_TotalCirculatingPassives");
            entity.Property(e => e.PnetTotalCostMonthHigh).HasColumnName("pnet_TotalCostMonthHigh");
            entity.Property(e => e.PnetTotalCostMonthLow).HasColumnName("pnet_TotalCostMonthLow");
            entity.Property(e => e.PnetTotalCostMonthMiddle).HasColumnName("pnet_TotalCostMonthMiddle");
            entity.Property(e => e.PnetTotalFamilyBusinessDebts).HasColumnName("pnet_TotalFamilyBusinessDebts");
            entity.Property(e => e.PnetTotalFamilyExpenditure).HasColumnName("pnet_TotalFamilyExpenditure");
            entity.Property(e => e.PnetTotalFamilyGroup).HasColumnName("pnet_TotalFamilyGroup");
            entity.Property(e => e.PnetTotalFamilyandBusinessDebts).HasColumnName("pnet_TotalFamilyandBusinessDebts");
            entity.Property(e => e.PnetTotalFixedActives).HasColumnName("pnet_TotalFixedActives");
            entity.Property(e => e.PnetTotalFixedCosts).HasColumnName("pnet_TotalFixedCosts");
            entity.Property(e => e.PnetTotalFixedCosts10).HasColumnName("pnet_TotalFixedCosts10");
            entity.Property(e => e.PnetTotalMonthHigh).HasColumnName("pnet_TotalMonthHigh");
            entity.Property(e => e.PnetTotalMonthLow).HasColumnName("pnet_TotalMonthLow");
            entity.Property(e => e.PnetTotalMonthMedium).HasColumnName("pnet_TotalMonthMedium");
            entity.Property(e => e.PnetTotalPassiveLongTerm).HasColumnName("pnet_TotalPassiveLongTerm");
            entity.Property(e => e.PnetTotalPassives).HasColumnName("pnet_TotalPassives");
            entity.Property(e => e.PnetTotalSalesMonthHigh).HasColumnName("pnet_TotalSalesMonthHigh");
            entity.Property(e => e.PnetTotalSalesMonthLow).HasColumnName("pnet_TotalSalesMonthLow");
            entity.Property(e => e.PnetTotalSalesMonthMiddle).HasColumnName("pnet_TotalSalesMonthMiddle");
            entity.Property(e => e.PnetTwelveMonth)
                .HasMaxLength(100)
                .HasColumnName("pnet_TwelveMonth");
            entity.Property(e => e.PnetTwoMonth)
                .HasMaxLength(100)
                .HasColumnName("pnet_TwoMonth");
            entity.Property(e => e.PnetUlcstatus).HasColumnName("pnet_ULCStatus");
            entity.Property(e => e.PnetUnderMonthFactor).HasColumnName("pnet_UnderMonthFactor");
            entity.Property(e => e.PnetUnderMonthFactor2).HasColumnName("pnet_UnderMonthFactor2");
            entity.Property(e => e.PnetUnremunerative).HasColumnName("pnet_Unremunerative");
            entity.Property(e => e.PnetUrl).HasColumnName("pnet_url");
            entity.Property(e => e.PnetUrl01)
                .HasMaxLength(200)
                .HasColumnName("pnet_url01");
            entity.Property(e => e.PnetUrl02)
                .HasMaxLength(200)
                .HasColumnName("pnet_url02");
            entity.Property(e => e.PnetUrlExchangeNews)
                .HasMaxLength(200)
                .HasColumnName("pnet_URL_ExchangeNews");
            entity.Property(e => e.PnetUrlGetProductsByNip)
                .HasMaxLength(200)
                .HasColumnName("pnet_URL_GetProductsByNip");
            entity.Property(e => e.PnetUrlgetProductsByNip1)
                .HasMaxLength(250)
                .HasColumnName("pnet_URLGetProductsByNip");
            entity.Property(e => e.PnetUrlra)
                .HasMaxLength(100)
                .HasColumnName("pnet_URLRA");
            entity.Property(e => e.PnetUrlrc)
                .HasMaxLength(100)
                .HasColumnName("pnet_URLRC");
            entity.Property(e => e.PnetValidateProcessUserId).HasColumnName("pnet_ValidateProcessUserId");
            entity.Property(e => e.PnetVariableCostMonthHigh).HasColumnName("pnet_VariableCostMonthHigh");
            entity.Property(e => e.PnetVariableCostMonthLow).HasColumnName("pnet_VariableCostMonthLow");
            entity.Property(e => e.PnetVariableCostMonthMiddle).HasColumnName("pnet_VariableCostMonthMiddle");
            entity.Property(e => e.PnetVariableCostsObservations).HasColumnName("pnet_VariableCostsObservations");
            entity.Property(e => e.PnetVariableCostsSubTotal).HasColumnName("pnet_VariableCostsSubTotal");
            entity.Property(e => e.PnetVariableCostsTotal).HasColumnName("pnet_VariableCostsTotal");
            entity.Property(e => e.PnetVariableNumberCustomers).HasColumnName("pnet_VariableNumberCustomers");
            entity.Property(e => e.PnetVehicles).HasColumnName("pnet_Vehicles");
            entity.Property(e => e.PnetVisitDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_VisitDate");
            entity.Property(e => e.PnetWhyChangesCorrectionFactor).HasColumnName("pnet_WhyChangesCorrectionFactor");
            entity.Property(e => e.PnetWhyDelayed).HasColumnName("pnet_WhyDelayed");
            entity.Property(e => e.PnetWhyPaymentDateChanged).HasColumnName("pnet_WhyPaymentDateChanged");
            entity.Property(e => e.PnetZonalChiefAuthorization).HasColumnName("pnet_ZonalChiefAuthorization");
            entity.Property(e => e.ScheduleFollowupProspect)
                .HasColumnType("datetime")
                .HasColumnName("ScheduleFollowup_Prospect");
            entity.Property(e => e.ScheduleFollowupQualify)
                .HasColumnType("datetime")
                .HasColumnName("ScheduleFollowup_Qualify");
            entity.Property(e => e.ScheduleProposalMeeting).HasColumnType("datetime");
            entity.Property(e => e.Slaid).HasColumnName("SLAId");
            entity.Property(e => e.SlainvokedId).HasColumnName("SLAInvokedId");
            entity.Property(e => e.StepName).HasMaxLength(200);
            entity.Property(e => e.TimeSpentByMeOnEmailAndMeetings).HasMaxLength(1250);
            entity.Property(e => e.TotalAmount).HasColumnType("money");
            entity.Property(e => e.TotalAmountBase)
                .HasColumnType("money")
                .HasColumnName("TotalAmount_Base");
            entity.Property(e => e.TotalAmountLessFreight).HasColumnType("money");
            entity.Property(e => e.TotalAmountLessFreightBase)
                .HasColumnType("money")
                .HasColumnName("TotalAmountLessFreight_Base");
            entity.Property(e => e.TotalDiscountAmount).HasColumnType("money");
            entity.Property(e => e.TotalDiscountAmountBase)
                .HasColumnType("money")
                .HasColumnName("TotalDiscountAmount_Base");
            entity.Property(e => e.TotalLineItemAmount).HasColumnType("money");
            entity.Property(e => e.TotalLineItemAmountBase)
                .HasColumnType("money")
                .HasColumnName("TotalLineItemAmount_Base");
            entity.Property(e => e.TotalLineItemDiscountAmount).HasColumnType("money");
            entity.Property(e => e.TotalLineItemDiscountAmountBase)
                .HasColumnType("money")
                .HasColumnName("TotalLineItemDiscountAmount_Base");
            entity.Property(e => e.TotalTax).HasColumnType("money");
            entity.Property(e => e.TotalTaxBase)
                .HasColumnType("money")
                .HasColumnName("TotalTax_Base");
            entity.Property(e => e.TraversedPath).HasMaxLength(1250);
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.ZennonbiScore)
                .HasMaxLength(50)
                .HasColumnName("zennonbi_score");
        });

        modelBuilder.Entity<OpportunityBase1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OpportunityBase", "int");

            entity.Property(e => e.ActualCloseDate).HasColumnType("datetime");
            entity.Property(e => e.ActualValue).HasColumnType("money");
            entity.Property(e => e.ActualValueBase)
                .HasColumnType("money")
                .HasColumnName("ActualValue_Base");
            entity.Property(e => e.BudgetAmount).HasColumnType("money");
            entity.Property(e => e.BudgetAmountBase)
                .HasColumnType("money")
                .HasColumnName("BudgetAmount_Base");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerIdName).HasMaxLength(4000);
            entity.Property(e => e.CustomerIdYomiName).HasMaxLength(4000);
            entity.Property(e => e.DiscountAmount).HasColumnType("money");
            entity.Property(e => e.DiscountAmountBase)
                .HasColumnType("money")
                .HasColumnName("DiscountAmount_Base");
            entity.Property(e => e.DiscountPercentage).HasColumnType("numeric(23, 10)");
            entity.Property(e => e.EstimatedCloseDate).HasColumnType("datetime");
            entity.Property(e => e.EstimatedValue).HasColumnType("money");
            entity.Property(e => e.EstimatedValueBase)
                .HasColumnType("money")
                .HasColumnName("EstimatedValue_Base");
            entity.Property(e => e.ExchangeRate).HasColumnType("numeric(23, 10)");
            entity.Property(e => e.FinalDecisionDate).HasColumnType("datetime");
            entity.Property(e => e.FreightAmount).HasColumnType("money");
            entity.Property(e => e.FreightAmountBase)
                .HasColumnType("money")
                .HasColumnName("FreightAmount_Base");
            entity.Property(e => e.LastOnHoldTime).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(300);
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Pnet30dayPaymentMethod).HasColumnName("pnet_30DayPaymentMethod");
            entity.Property(e => e.PnetAccountsReceivable).HasColumnName("pnet_AccountsReceivable");
            entity.Property(e => e.PnetAccumulateExecute).HasColumnName("pnet_AccumulateExecute");
            entity.Property(e => e.PnetAccumulateExecuteOk).HasColumnName("pnet_AccumulateExecuteOK");
            entity.Property(e => e.PnetAccumulatorWillPay).HasColumnName("pnet_AccumulatorWillPay");
            entity.Property(e => e.PnetAdultNumber).HasColumnName("pnet_AdultNumber");
            entity.Property(e => e.PnetAffectedAreaId).HasColumnName("pnet_AffectedAreaId");
            entity.Property(e => e.PnetAgreement).HasColumnName("pnet_Agreement");
            entity.Property(e => e.PnetAgro).HasColumnName("pnet_AGRO");
            entity.Property(e => e.PnetAmortizationperiod).HasColumnName("pnet_amortizationperiod");
            entity.Property(e => e.PnetAmortizationsystem).HasColumnName("pnet_amortizationsystem");
            entity.Property(e => e.PnetAmountRange).HasColumnName("pnet_AmountRange");
            entity.Property(e => e.PnetApprobationDate1)
                .HasColumnType("datetime")
                .HasColumnName("pnet_ApprobationDate1");
            entity.Property(e => e.PnetApprobationDate2)
                .HasColumnType("datetime")
                .HasColumnName("pnet_ApprobationDate2");
            entity.Property(e => e.PnetApprobationDate3)
                .HasColumnType("datetime")
                .HasColumnName("pnet_ApprobationDate3");
            entity.Property(e => e.PnetApprovalStatusStage1).HasColumnName("pnet_ApprovalStatusStage1");
            entity.Property(e => e.PnetApprovalStatusStage2).HasColumnName("pnet_ApprovalStatusStage2");
            entity.Property(e => e.PnetApprovalStatusStage3).HasColumnName("pnet_ApprovalStatusStage3");
            entity.Property(e => e.PnetApprovalStatusStage4).HasColumnName("pnet_ApprovalStatusStage4");
            entity.Property(e => e.PnetApprovalStatusStage5).HasColumnName("pnet_ApprovalStatusStage5");
            entity.Property(e => e.PnetApril).HasColumnName("pnet_April");
            entity.Property(e => e.PnetAtoPayEigthMonth).HasColumnName("pnet_AToPayEigthMonth");
            entity.Property(e => e.PnetAtoPayElvenMonth).HasColumnName("pnet_AToPayElvenMonth");
            entity.Property(e => e.PnetAtoPayFiveMonth).HasColumnName("pnet_AToPayFiveMonth");
            entity.Property(e => e.PnetAtoPayFourMonth).HasColumnName("pnet_AToPayFourMonth");
            entity.Property(e => e.PnetAtoPayNineMonth).HasColumnName("pnet_AToPayNineMonth");
            entity.Property(e => e.PnetAtoPayOneMonth).HasColumnName("pnet_AToPayOneMonth");
            entity.Property(e => e.PnetAtoPaySevenMonth).HasColumnName("pnet_AToPaySevenMonth");
            entity.Property(e => e.PnetAtoPaySixMonth).HasColumnName("pnet_AToPaySixMonth");
            entity.Property(e => e.PnetAtoPayTenMonth).HasColumnName("pnet_AToPayTenMonth");
            entity.Property(e => e.PnetAtoPayThreeMonth).HasColumnName("pnet_AToPayThreeMonth");
            entity.Property(e => e.PnetAtoPayTwelveMonth).HasColumnName("pnet_AToPayTwelveMonth");
            entity.Property(e => e.PnetAtoPayTwoMonth).HasColumnName("pnet_AToPayTwoMonth");
            entity.Property(e => e.PnetAugust).HasColumnName("pnet_August");
            entity.Property(e => e.PnetAverageAgeEmployees).HasColumnName("pnet_AverageAgeEmployees");
            entity.Property(e => e.PnetAverageFee).HasColumnName("pnet_AverageFee");
            entity.Property(e => e.PnetBackCar).HasColumnName("pnet_BackCar");
            entity.Property(e => e.PnetBackCarValue).HasColumnName("pnet_BackCarValue");
            entity.Property(e => e.PnetBackHouse).HasColumnName("pnet_BackHouse");
            entity.Property(e => e.PnetBackHouseCheck).HasColumnName("pnet_BackHouseCheck");
            entity.Property(e => e.PnetBackHouseValue).HasColumnName("pnet_BackHouseValue");
            entity.Property(e => e.PnetBackMachines).HasColumnName("pnet_BackMachines");
            entity.Property(e => e.PnetBackMachinesValue).HasColumnName("pnet_BackMachinesValue");
            entity.Property(e => e.PnetBackOthersProperties).HasColumnName("pnet_BackOthersProperties");
            entity.Property(e => e.PnetBackOthersPropertiesValue).HasColumnName("pnet_BackOthersPropertiesValue");
            entity.Property(e => e.PnetBanco).HasColumnName("pnet_Banco");
            entity.Property(e => e.PnetBankLoanAgreement).HasColumnName("pnet_BankLoanAgreement");
            entity.Property(e => e.PnetBankResponse).HasColumnName("pnet_BankResponse");
            entity.Property(e => e.PnetBeigthMonth).HasColumnName("pnet_BEigthMonth");
            entity.Property(e => e.PnetBelevenMonth).HasColumnName("pnet_BElevenMonth");
            entity.Property(e => e.PnetBfiveMonth).HasColumnName("pnet_BFiveMonth");
            entity.Property(e => e.PnetBfourMonth).HasColumnName("pnet_BFourMonth");
            entity.Property(e => e.PnetBnineMonth).HasColumnName("pnet_BNineMonth");
            entity.Property(e => e.PnetBoneMonth).HasColumnName("pnet_BOneMonth");
            entity.Property(e => e.PnetBsevenMonth).HasColumnName("pnet_BSevenMonth");
            entity.Property(e => e.PnetBsixMonth).HasColumnName("pnet_BSixMonth");
            entity.Property(e => e.PnetBtenMonth).HasColumnName("pnet_BTenMonth");
            entity.Property(e => e.PnetBthreeMonth).HasColumnName("pnet_BThreeMonth");
            entity.Property(e => e.PnetBtwelveMonth).HasColumnName("pnet_BTwelveMonth");
            entity.Property(e => e.PnetBtwoMonth).HasColumnName("pnet_BTwoMonth");
            entity.Property(e => e.PnetBusinessDescription).HasColumnName("pnet_BusinessDescription");
            entity.Property(e => e.PnetCampaignApprovalStatusStage).HasColumnName("pnet_CampaignApprovalStatusStage");
            entity.Property(e => e.PnetCampaignResponseId).HasColumnName("pnet_CampaignResponseId");
            entity.Property(e => e.PnetCar).HasColumnName("pnet_Car");
            entity.Property(e => e.PnetCashPaymentMethod).HasColumnName("pnet_CashPaymentMethod");
            entity.Property(e => e.PnetCashbox).HasColumnName("pnet_Cashbox");
            entity.Property(e => e.PnetCganancias)
                .HasMaxLength(1)
                .HasColumnName("pnet_cganancias");
            entity.Property(e => e.PnetChangeOwnership).HasColumnName("pnet_ChangeOwnership");
            entity.Property(e => e.PnetCheckFixedCostsAdd).HasColumnName("pnet_CheckFixedCostsAdd");
            entity.Property(e => e.PnetChildrenNumber).HasColumnName("pnet_ChildrenNumber");
            entity.Property(e => e.PnetCingbr)
                .HasMaxLength(1)
                .HasColumnName("pnet_cingbr");
            entity.Property(e => e.PnetCiva)
                .HasMaxLength(1)
                .HasColumnName("pnet_civa");
            entity.Property(e => e.PnetClass1).HasColumnName("pnet_Class1");
            entity.Property(e => e.PnetClassificationWillingnessToPay).HasColumnName("pnet_ClassificationWillingnessToPay");
            entity.Property(e => e.PnetCmodalidad).HasColumnName("pnet_cmodalidad");
            entity.Property(e => e.PnetCommercialBackgrounds).HasColumnName("pnet_CommercialBackgrounds");
            entity.Property(e => e.PnetCommercializationObservation).HasColumnName("pnet_CommercializationObservation");
            entity.Property(e => e.PnetCommitmentdate).HasColumnName("pnet_Commitmentdate");
            entity.Property(e => e.PnetCommunicationDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_CommunicationDate");
            entity.Property(e => e.PnetConsultations).HasColumnName("pnet_Consultations");
            entity.Property(e => e.PnetContract).HasColumnName("pnet_Contract");
            entity.Property(e => e.PnetContratationType).HasColumnName("pnet_ContratationType");
            entity.Property(e => e.PnetCorrectionFactorDebtMonthHigh).HasColumnName("pnet_CorrectionFactorDebtMonthHigh");
            entity.Property(e => e.PnetCorrectionFactorDebtMonthLow).HasColumnName("pnet_CorrectionFactorDebtMonthLow");
            entity.Property(e => e.PnetCorrectionFactorDebtMonthMiddle).HasColumnName("pnet_CorrectionFactorDebtMonthMiddle");
            entity.Property(e => e.PnetCorrectionFactorMonthHigh).HasColumnName("pnet_CorrectionFactorMonthHigh");
            entity.Property(e => e.PnetCorrectionFactorMonthLow).HasColumnName("pnet_CorrectionFactorMonthLow");
            entity.Property(e => e.PnetCorrectionFactorMonthMiddle).HasColumnName("pnet_CorrectionFactorMonthMiddle");
            entity.Property(e => e.PnetCounterId).HasColumnName("pnet_CounterId");
            entity.Property(e => e.PnetCoursesWorkshops).HasColumnName("pnet_CoursesWorkshops");
            entity.Property(e => e.PnetCpacauseChanges).HasColumnName("pnet_CPACauseChanges");
            entity.Property(e => e.PnetCpadecreased).HasColumnName("pnet_CPADecreased");
            entity.Property(e => e.PnetCpaincreased).HasColumnName("pnet_CPAIncreased");
            entity.Property(e => e.PnetCparesult)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_CPAResult");
            entity.Property(e => e.PnetCpcpaflow).HasColumnName("pnet_cpcpaflow");
            entity.Property(e => e.PnetCpincreased).HasColumnName("pnet_CPIncreased");
            entity.Property(e => e.PnetCpresult)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_CPResult");
            entity.Property(e => e.PnetCredit1DebtAmount)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_Credit1DebtAmount");
            entity.Property(e => e.PnetCredit2DebtAmount)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_Credit2DebtAmount");
            entity.Property(e => e.PnetCreditAmount).HasColumnName("pnet_CreditAmount");
            entity.Property(e => e.PnetCreditAmountSupplementary).HasColumnName("pnet_CreditAmountSupplementary");
            entity.Property(e => e.PnetCreditAmountTitular).HasColumnName("pnet_CreditAmountTitular");
            entity.Property(e => e.PnetCreditAmountletters)
                .HasMaxLength(300)
                .HasColumnName("pnet_CreditAmountletters");
            entity.Property(e => e.PnetCreditDestination).HasColumnName("pnet_CreditDestination");
            entity.Property(e => e.PnetCreditDestinationBusinessHistory).HasColumnName("pnet_CreditDestinationBusinessHistory");
            entity.Property(e => e.PnetCreditFate).HasColumnName("pnet_CreditFate");
            entity.Property(e => e.PnetCreditHistoryObservation).HasColumnName("pnet_CreditHistoryObservation");
            entity.Property(e => e.PnetCreditSubType).HasColumnName("pnet_CreditSubType");
            entity.Property(e => e.PnetCreditToBeCancelled1).HasColumnName("pnet_CreditToBeCancelled1");
            entity.Property(e => e.PnetCreditToBeCancelled2).HasColumnName("pnet_CreditToBeCancelled2");
            entity.Property(e => e.PnetCreditType).HasColumnName("pnet_CreditType");
            entity.Property(e => e.PnetCreditTypification)
                .HasMaxLength(3)
                .HasColumnName("pnet_CreditTypification");
            entity.Property(e => e.PnetCreditocongarantiafogaba).HasColumnName("pnet_creditocongarantiafogaba");
            entity.Property(e => e.PnetCronopago).HasColumnName("pnet_Cronopago");
            entity.Property(e => e.PnetCronopagoResult).HasColumnName("pnet_CronopagoResult");
            entity.Property(e => e.PnetCurrentCollegiate).HasColumnName("pnet_CurrentCollegiate");
            entity.Property(e => e.PnetCursabip).HasColumnName("pnet_cursabip");
            entity.Property(e => e.PnetCustomer1)
                .HasMaxLength(220)
                .HasColumnName("pnet_Customer1");
            entity.Property(e => e.PnetCustomer2)
                .HasMaxLength(153)
                .HasColumnName("pnet_Customer2");
            entity.Property(e => e.PnetCustomer3)
                .HasMaxLength(100)
                .HasColumnName("pnet_Customer3");
            entity.Property(e => e.PnetCustomerMonthHigh).HasColumnName("pnet_CustomerMonthHigh");
            entity.Property(e => e.PnetCustomerMonthLow).HasColumnName("pnet_CustomerMonthLow");
            entity.Property(e => e.PnetCustomerMonthMiddle).HasColumnName("pnet_CustomerMonthMiddle");
            entity.Property(e => e.PnetCustomerType).HasColumnName("pnet_CustomerType");
            entity.Property(e => e.PnetCustomerTypeCompany).HasColumnName("pnet_CustomerTypeCompany");
            entity.Property(e => e.PnetCustomerTypeFactorPercent).HasColumnName("pnet_CustomerTypeFactorPercent");
            entity.Property(e => e.PnetCustomerTypeOther).HasColumnName("pnet_CustomerTypeOther");
            entity.Property(e => e.PnetCustomerTypeParticular).HasColumnName("pnet_CustomerTypeParticular");
            entity.Property(e => e.PnetCustomerregistration).HasColumnName("pnet_customerregistration");
            entity.Property(e => e.PnetCv1).HasColumnName("pnet_CV1");
            entity.Property(e => e.PnetCv2).HasColumnName("pnet_CV2");
            entity.Property(e => e.PnetCv3).HasColumnName("pnet_CV3");
            entity.Property(e => e.PnetCvx1).HasColumnName("pnet_CVX1");
            entity.Property(e => e.PnetCvx2).HasColumnName("pnet_CVX2");
            entity.Property(e => e.PnetCvx3).HasColumnName("pnet_CVX3");
            entity.Property(e => e.PnetDateTest)
                .HasColumnType("datetime")
                .HasColumnName("pnet_DateTEST");
            entity.Property(e => e.PnetDeal).HasColumnName("pnet_Deal");
            entity.Property(e => e.PnetDebt).HasColumnName("pnet_debt");
            entity.Property(e => e.PnetDebtAdjustedMonthHigh).HasColumnName("pnet_DebtAdjustedMonthHigh");
            entity.Property(e => e.PnetDebtAdjustedMonthLow).HasColumnName("pnet_DebtAdjustedMonthLow");
            entity.Property(e => e.PnetDebtAdjustedMonthMiddle).HasColumnName("pnet_DebtAdjustedMonthMiddle");
            entity.Property(e => e.PnetDebtAmount)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_DebtAmount");
            entity.Property(e => e.PnetDebtlevel).HasColumnName("pnet_debtlevel");
            entity.Property(e => e.PnetDebtsMonthHigh).HasColumnName("pnet_DebtsMonthHigh");
            entity.Property(e => e.PnetDebtsMonthLow).HasColumnName("pnet_DebtsMonthLow");
            entity.Property(e => e.PnetDebtsMonthMiddle).HasColumnName("pnet_DebtsMonthMiddle");
            entity.Property(e => e.PnetDebtsToPay).HasColumnName("pnet_DebtsToPay");
            entity.Property(e => e.PnetDecember).HasColumnName("pnet_December");
            entity.Property(e => e.PnetDividends).HasColumnName("pnet_Dividends");
            entity.Property(e => e.PnetDocumentUrl)
                .HasMaxLength(500)
                .HasColumnName("pnet_DocumentURL");
            entity.Property(e => e.PnetDueMoreThanOneYear).HasColumnName("pnet_DueMoreThanOneYear");
            entity.Property(e => e.PnetEffectiveDateLiquidation)
                .HasColumnType("datetime")
                .HasColumnName("pnet_EffectiveDateLiquidation");
            entity.Property(e => e.PnetEigthMonth)
                .HasMaxLength(100)
                .HasColumnName("pnet_EigthMonth");
            entity.Property(e => e.PnetElevenMonth)
                .HasMaxLength(100)
                .HasColumnName("pnet_ElevenMonth");
            entity.Property(e => e.PnetEmployeesNumber).HasColumnName("pnet_EmployeesNumber");
            entity.Property(e => e.PnetEnddategraceperiod)
                .HasColumnType("datetime")
                .HasColumnName("pnet_enddategraceperiod");
            entity.Property(e => e.PnetEverSheDelayed).HasColumnName("pnet_EverSheDelayed");
            entity.Property(e => e.PnetExceptionLevel).HasColumnName("pnet_ExceptionLevel");
            entity.Property(e => e.PnetExceptionsAmount).HasColumnName("pnet_ExceptionsAmount");
            entity.Property(e => e.PnetExceptionsDebt).HasColumnName("pnet_ExceptionsDebt");
            entity.Property(e => e.PnetExceptionsDebtLevel2).HasColumnName("pnet_ExceptionsDebtLevel2");
            entity.Property(e => e.PnetExecutiveMonthHigh).HasColumnName("pnet_ExecutiveMonthHigh");
            entity.Property(e => e.PnetExecutiveMonthLow).HasColumnName("pnet_ExecutiveMonthLow");
            entity.Property(e => e.PnetExecutiveMonthMiddle).HasColumnName("pnet_ExecutiveMonthMiddle");
            entity.Property(e => e.PnetExecutiveNameId).HasColumnName("pnet_ExecutiveNameId");
            entity.Property(e => e.PnetExecutiveSeniority).HasColumnName("pnet_ExecutiveSeniority");
            entity.Property(e => e.PnetExecutiveadministrator).HasColumnName("pnet_executiveadministrator");
            entity.Property(e => e.PnetExtraSchoolActivities).HasColumnName("pnet_ExtraSchoolActivities");
            entity.Property(e => e.PnetFamilyExpensesMonthHigh).HasColumnName("pnet_FamilyExpensesMonthHigh");
            entity.Property(e => e.PnetFamilyExpensesMonthLow).HasColumnName("pnet_FamilyExpensesMonthLow");
            entity.Property(e => e.PnetFamilyExpensesMonthMiddle).HasColumnName("pnet_FamilyExpensesMonthMiddle");
            entity.Property(e => e.PnetFamilyExpensesccordingMe).HasColumnName("pnet_FamilyExpensesccordingME");
            entity.Property(e => e.PnetFamilyGroupObservations).HasColumnName("pnet_FamilyGroupObservations");
            entity.Property(e => e.PnetFamilyStrength).HasColumnName("pnet_FamilyStrength");
            entity.Property(e => e.PnetFebruary).HasColumnName("pnet_February");
            entity.Property(e => e.PnetFiveMonth)
                .HasMaxLength(100)
                .HasColumnName("pnet_FiveMonth");
            entity.Property(e => e.PnetFixedCostMonthHigh).HasColumnName("pnet_FixedCostMonthHigh");
            entity.Property(e => e.PnetFixedCostMonthLow).HasColumnName("pnet_FixedCostMonthLow");
            entity.Property(e => e.PnetFixedCostMonthMiddle).HasColumnName("pnet_FixedCostMonthMiddle");
            entity.Property(e => e.PnetFixedNumberCustomers).HasColumnName("pnet_FixedNumberCustomers");
            entity.Property(e => e.PnetFixedSalary).HasColumnName("pnet_FixedSalary");
            entity.Property(e => e.PnetFlagAttributions).HasColumnName("pnet_FlagAttributions");
            entity.Property(e => e.PnetFlagStateApprovalSent).HasColumnName("pnet_FlagStateApprovalSent");
            entity.Property(e => e.PnetFlagStateStartWorkflow).HasColumnName("pnet_FlagStateStartWorkflow");
            entity.Property(e => e.PnetFlagStateTransition).HasColumnName("pnet_FlagStateTransition");
            entity.Property(e => e.PnetFlagUcctoUccr).HasColumnName("pnet_FlagUCCtoUCCR");
            entity.Property(e => e.PnetFociAsMinimizingRisksAnd).HasColumnName("pnet_FociAsMinimizingRisksAnd");
            entity.Property(e => e.PnetFormType).HasColumnName("pnet_FormType");
            entity.Property(e => e.PnetFormal).HasColumnName("pnet_Formal");
            entity.Property(e => e.PnetFourMonth)
                .HasMaxLength(100)
                .HasColumnName("pnet_FourMonth");
            entity.Property(e => e.PnetFreeInterestrate).HasColumnName("pnet_FreeInterestrate");
            entity.Property(e => e.PnetFutureDreamBusiness).HasColumnName("pnet_FutureDreamBusiness");
            entity.Property(e => e.PnetFutureDreamFamily).HasColumnName("pnet_FutureDreamFamily");
            entity.Property(e => e.PnetGeoPositioining)
                .HasColumnType("datetime")
                .HasColumnName("pnet_GeoPositioining");
            entity.Property(e => e.PnetGetId)
                .HasMaxLength(100)
                .HasColumnName("pnet_getID");
            entity.Property(e => e.PnetGoodPayment).HasColumnName("pnet_GoodPayment");
            entity.Property(e => e.PnetGraceperiod).HasColumnName("pnet_graceperiod");
            entity.Property(e => e.PnetHighMonthFactor2).HasColumnName("pnet_HighMonthFactor2");
            entity.Property(e => e.PnetHigher30DayPaymentMethod).HasColumnName("pnet_Higher30DayPaymentMethod");
            entity.Property(e => e.PnetHouseType).HasColumnName("pnet_HouseType");
            entity.Property(e => e.PnetImpactonRm).HasColumnName("pnet_ImpactonRm");
            entity.Property(e => e.PnetInCampaign).HasColumnName("pnet_InCampaign");
            entity.Property(e => e.PnetIndependent).HasColumnName("pnet_Independent");
            entity.Property(e => e.PnetInformal).HasColumnName("pnet_Informal");
            entity.Property(e => e.PnetInterestRate).HasColumnName("pnet_InterestRate");
            entity.Property(e => e.PnetInterestRateAnual).HasColumnName("pnet_InterestRateAnual");
            entity.Property(e => e.PnetInterestRateMonthly).HasColumnName("pnet_InterestRateMonthly");
            entity.Property(e => e.PnetItpca)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_ITPCA");
            entity.Property(e => e.PnetJanuary).HasColumnName("pnet_January");
            entity.Property(e => e.PnetJuly).HasColumnName("pnet_July");
            entity.Property(e => e.PnetJune).HasColumnName("pnet_June");
            entity.Property(e => e.PnetLabor1).HasColumnName("pnet_Labor1");
            entity.Property(e => e.PnetLabor2).HasColumnName("pnet_Labor2");
            entity.Property(e => e.PnetLabor3).HasColumnName("pnet_Labor3");
            entity.Property(e => e.PnetLastSentDateColegiar)
                .HasColumnType("datetime")
                .HasColumnName("pnet_LastSentDateColegiar");
            entity.Property(e => e.PnetLastcomment).HasColumnName("pnet_Lastcomment");
            entity.Property(e => e.PnetLlapre).HasColumnName("pnet_Llapre");
            entity.Property(e => e.PnetLlare).HasColumnName("pnet_Llare");
            entity.Property(e => e.PnetLocal).HasColumnName("pnet_Local");
            entity.Property(e => e.PnetLog).HasColumnName("pnet_Log");
            entity.Property(e => e.PnetMachineryEquipment).HasColumnName("pnet_MachineryEquipment");
            entity.Property(e => e.PnetMachines).HasColumnName("pnet_Machines");
            entity.Property(e => e.PnetManagement).HasColumnName("pnet_Management");
            entity.Property(e => e.PnetMarch).HasColumnName("pnet_March");
            entity.Property(e => e.PnetMay).HasColumnName("pnet_May");
            entity.Property(e => e.PnetMechangeEvaluated).HasColumnName("pnet_MEChangeEvaluated");
            entity.Property(e => e.PnetMerchandises).HasColumnName("pnet_Merchandises");
            entity.Property(e => e.PnetMicroEmpresa).HasColumnName("pnet_MicroEmpresa");
            entity.Property(e => e.PnetMicroempresaExcellence).HasColumnName("pnet_MicroempresaExcellence");
            entity.Property(e => e.PnetMiddleMonthFactor).HasColumnName("pnet_MiddleMonthFactor");
            entity.Property(e => e.PnetMinimumEstimatedExpenditure).HasColumnName("pnet_MinimumEstimatedExpenditure");
            entity.Property(e => e.PnetMircorempresaInherited).HasColumnName("pnet_MircorempresaInherited");
            entity.Property(e => e.PnetMonthFirstQuota).HasColumnName("pnet_MonthFirstQuota");
            entity.Property(e => e.PnetMonthlyAmountPurchase).HasColumnName("pnet_MonthlyAmountPurchase");
            entity.Property(e => e.PnetMonthlyincome)
                .HasMaxLength(100)
                .HasColumnName("pnet_monthlyincome");
            entity.Property(e => e.PnetMonthlysales).HasColumnName("pnet_monthlysales");
            entity.Property(e => e.PnetMotivators).HasColumnName("pnet_Motivators");
            entity.Property(e => e.PnetMtabilityToPay)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_MTAbilityToPay");
            entity.Property(e => e.PnetMtabilityToPay2)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_MTAbilityToPay2");
            entity.Property(e => e.PnetMtacpca)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_MTACPCA");
            entity.Property(e => e.PnetMtamountFees).HasColumnName("pnet_MTAmountFees");
            entity.Property(e => e.PnetMtamountRecorded).HasColumnName("pnet_MTAmountRecorded");
            entity.Property(e => e.PnetMtaverageSalesMonth).HasColumnName("pnet_MTAverageSalesMonth");
            entity.Property(e => e.PnetMtcapactyPaymentAdjusted)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_MTCapactyPaymentAdjusted");
            entity.Property(e => e.PnetMtcapactyPaymentAdjusted2)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_MTCapactyPaymentAdjusted2");
            entity.Property(e => e.PnetMtchangesCorrectionFactor).HasColumnName("pnet_MTChangesCorrectionFactor");
            entity.Property(e => e.PnetMtcorrectionFactor).HasColumnName("pnet_MTCorrectionFactor");
            entity.Property(e => e.PnetMtcorrectionFactor2).HasColumnName("pnet_MTCorrectionFactor2");
            entity.Property(e => e.PnetMtcorrectionFactorPromeCurrentDebt)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_MTCorrectionFactorPromeCurrentDebt");
            entity.Property(e => e.PnetMtcorrectionFactorPromeCurrentDebt2).HasColumnName("pnet_MTCorrectionFactorPromeCurrentDebt2");
            entity.Property(e => e.PnetMtcorrectionFactorRenovation).HasColumnName("pnet_MTCorrectionFactorRenovation");
            entity.Property(e => e.PnetMtcpaaverageMonth).HasColumnName("pnet_MTCPAAverageMonth");
            entity.Property(e => e.PnetMtcpaverageMonth).HasColumnName("pnet_MTCPAverageMonth");
            entity.Property(e => e.PnetMtcreditHistoryObservation).HasColumnName("pnet_MTCreditHistoryObservation");
            entity.Property(e => e.PnetMtcreditLiquidationDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_MTCreditLiquidationDate");
            entity.Property(e => e.PnetMtcreditRatingHistory).HasColumnName("pnet_MTCreditRatingHistory");
            entity.Property(e => e.PnetMtdebt).HasColumnName("pnet_MTDebt");
            entity.Property(e => e.PnetMtdebt2).HasColumnName("pnet_MTDebt2");
            entity.Property(e => e.PnetMtdelayed).HasColumnName("pnet_MTDelayed");
            entity.Property(e => e.PnetMtevaluatorExecutive).HasColumnName("pnet_MTEvaluatorExecutive");
            entity.Property(e => e.PnetMteverDelayed).HasColumnName("pnet_MTEverDelayed");
            entity.Property(e => e.PnetMtfamilyExpenditures).HasColumnName("pnet_MTFamilyExpenditures");
            entity.Property(e => e.PnetMtfamilyExpenditures2).HasColumnName("pnet_MTFamilyExpenditures2");
            entity.Property(e => e.PnetMtfeesPaid).HasColumnName("pnet_MTFeesPaid");
            entity.Property(e => e.PnetMtfixedCost).HasColumnName("pnet_MTFixedCost");
            entity.Property(e => e.PnetMtfixedCost2).HasColumnName("pnet_MTFixedCost2");
            entity.Property(e => e.PnetMtmaximumProduce).HasColumnName("pnet_MTMaximumProduce");
            entity.Property(e => e.PnetMtmonthType)
                .HasMaxLength(100)
                .HasColumnName("pnet_MTMonthType");
            entity.Property(e => e.PnetMtmonthlyPurchase).HasColumnName("pnet_MTMonthlyPurchase");
            entity.Property(e => e.PnetMtmppca)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_MTMPPCA");
            entity.Property(e => e.PnetMtobservations).HasColumnName("pnet_MTObservations");
            entity.Property(e => e.PnetMtoperatingIncome)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_MTOperatingIncome");
            entity.Property(e => e.PnetMtoperatingIncome2)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_MTOperatingIncome2");
            entity.Property(e => e.PnetMtotherIncome).HasColumnName("pnet_MTOtherIncome");
            entity.Property(e => e.PnetMtotherIncome2).HasColumnName("pnet_MTOtherIncome2");
            entity.Property(e => e.PnetMtpaymentBehavior).HasColumnName("pnet_MTPaymentBehavior");
            entity.Property(e => e.PnetMtprice).HasColumnName("pnet_MTPrice");
            entity.Property(e => e.PnetMtpromeAdjustedDebt).HasColumnName("pnet_MTPromeAdjustedDebt");
            entity.Property(e => e.PnetMtpromeAdjustedDebt2).HasColumnName("pnet_MTPromeAdjustedDebt2");
            entity.Property(e => e.PnetMtpromeDebt).HasColumnName("pnet_MTPromeDebt");
            entity.Property(e => e.PnetMtpromeDebt2).HasColumnName("pnet_MTPromeDebt2");
            entity.Property(e => e.PnetMtquantityPurchase).HasColumnName("pnet_MTQuantityPurchase");
            entity.Property(e => e.PnetMtriskFocus).HasColumnName("pnet_MTRiskFocus");
            entity.Property(e => e.PnetMtsabilityToPay)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_MTSAbilityToPay");
            entity.Property(e => e.PnetMtsamountFees).HasColumnName("pnet_MTSAmountFees");
            entity.Property(e => e.PnetMtsamountRecorded).HasColumnName("pnet_MTSAmountRecorded");
            entity.Property(e => e.PnetMtscapactyPaymentAdjusted)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_MTSCapactyPaymentAdjusted");
            entity.Property(e => e.PnetMtschangesCorrectionFactor).HasColumnName("pnet_MTSChangesCorrectionFactor");
            entity.Property(e => e.PnetMtscorrectionFactorPromeCurrentDebt).HasColumnName("pnet_MTSCorrectionFactorPromeCurrentDebt");
            entity.Property(e => e.PnetMtscorrectionFactorRenovation).HasColumnName("pnet_MTSCorrectionFactorRenovation");
            entity.Property(e => e.PnetMtscorrectionfactor).HasColumnName("pnet_MTSCorrectionfactor");
            entity.Property(e => e.PnetMtscostsObservation).HasColumnName("pnet_MTSCostsObservation");
            entity.Property(e => e.PnetMtscpaaverageMonth).HasColumnName("pnet_MTSCPAAverageMonth");
            entity.Property(e => e.PnetMtscpaverageMonth).HasColumnName("pnet_MTSCPAverageMonth");
            entity.Property(e => e.PnetMtscreditHistory).HasColumnName("pnet_MTSCreditHistory");
            entity.Property(e => e.PnetMtscreditHistoryObservation).HasColumnName("pnet_MTSCreditHistoryObservation");
            entity.Property(e => e.PnetMtscreditLiquidationDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_MTSCreditLiquidationDate");
            entity.Property(e => e.PnetMtsdebt).HasColumnName("pnet_MTSDebt");
            entity.Property(e => e.PnetMtsdelayed).HasColumnName("pnet_MTSDelayed");
            entity.Property(e => e.PnetMtsevaluatorExecutive).HasColumnName("pnet_MTSEvaluatorExecutive");
            entity.Property(e => e.PnetMtseverDelayed).HasColumnName("pnet_MTSEverDelayed");
            entity.Property(e => e.PnetMtsexecutiveMonthMiddle).HasColumnName("pnet_MTSExecutiveMonthMiddle");
            entity.Property(e => e.PnetMtsfamilyExpenditures).HasColumnName("pnet_MTSFamilyExpenditures");
            entity.Property(e => e.PnetMtsfeesPaid).HasColumnName("pnet_MTSFeesPaid");
            entity.Property(e => e.PnetMtsfixedCost).HasColumnName("pnet_MTSFixedCost");
            entity.Property(e => e.PnetMtsobservations).HasColumnName("pnet_MTSObservations");
            entity.Property(e => e.PnetMtsoperatingIncome)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_MTSOperatingIncome");
            entity.Property(e => e.PnetMtsotherIncome).HasColumnName("pnet_MTSOtherIncome");
            entity.Property(e => e.PnetMtspatrimonialClassification).HasColumnName("pnet_MTSPatrimonialClassification");
            entity.Property(e => e.PnetMtspaymentBehavior).HasColumnName("pnet_MTSPaymentBehavior");
            entity.Property(e => e.PnetMtspca)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_MTSPCA");
            entity.Property(e => e.PnetMtspermanenceRating).HasColumnName("pnet_MTSPermanenceRating");
            entity.Property(e => e.PnetMtspromeAdjustedDebt).HasColumnName("pnet_MTSPromeAdjustedDebt");
            entity.Property(e => e.PnetMtspromeDebt).HasColumnName("pnet_MTSPromeDebt");
            entity.Property(e => e.PnetMtsqualityRecords).HasColumnName("pnet_MTSQualityRecords");
            entity.Property(e => e.PnetMtsqualityRecordsObservation).HasColumnName("pnet_MTSQualityRecordsObservation");
            entity.Property(e => e.PnetMtssubTotalVariableCost).HasColumnName("pnet_MTSSubTotalVariableCost");
            entity.Property(e => e.PnetMtsterm).HasColumnName("pnet_MTSTerm");
            entity.Property(e => e.PnetMtstotalCost).HasColumnName("pnet_MTSTotalCost");
            entity.Property(e => e.PnetMtstotalSales).HasColumnName("pnet_MTSTotalSales");
            entity.Property(e => e.PnetMtstotalVariableCost).HasColumnName("pnet_MTSTotalVariableCost");
            entity.Property(e => e.PnetMtsvariableCost).HasColumnName("pnet_MTSVariableCost");
            entity.Property(e => e.PnetMtswillingnessPay).HasColumnName("pnet_MTSWillingnessPay");
            entity.Property(e => e.PnetMtswillingnessPayObservations).HasColumnName("pnet_MTSWillingnessPayObservations");
            entity.Property(e => e.PnetMtterm).HasColumnName("pnet_MTTerm");
            entity.Property(e => e.PnetMttotalCost).HasColumnName("pnet_MTTotalCost");
            entity.Property(e => e.PnetMttotalCost2).HasColumnName("pnet_MTTotalCost2");
            entity.Property(e => e.PnetMttotalSales).HasColumnName("pnet_MTTotalSales");
            entity.Property(e => e.PnetMttotalSales2).HasColumnName("pnet_MTTotalSales2");
            entity.Property(e => e.PnetMtvariableCost).HasColumnName("pnet_MTVariableCost");
            entity.Property(e => e.PnetMtvariableCost2).HasColumnName("pnet_MTVariableCost2");
            entity.Property(e => e.PnetMtvariableCostsSubTotal).HasColumnName("pnet_MTVariableCostsSubTotal");
            entity.Property(e => e.PnetMtvariableCostsTotal).HasColumnName("pnet_MTVariableCostsTotal");
            entity.Property(e => e.PnetNegativebasisobs).HasColumnName("pnet_negativebasisobs");
            entity.Property(e => e.PnetNetAmount).HasColumnName("pnet_NetAmount");
            entity.Property(e => e.PnetNewProductQuantity1).HasColumnName("pnet_newProductQuantity1");
            entity.Property(e => e.PnetNewProductQuantity2).HasColumnName("pnet_newProductQuantity2");
            entity.Property(e => e.PnetNewProductQuantity3).HasColumnName("pnet_newProductQuantity3");
            entity.Property(e => e.PnetNineMonth)
                .HasMaxLength(100)
                .HasColumnName("pnet_NineMonth");
            entity.Property(e => e.PnetNoRecords).HasColumnName("pnet_NoRecords");
            entity.Property(e => e.PnetNovember).HasColumnName("pnet_November");
            entity.Property(e => e.PnetNpa).HasColumnName("pnet_NPA");
            entity.Property(e => e.PnetNpb).HasColumnName("pnet_NPB");
            entity.Property(e => e.PnetNpc).HasColumnName("pnet_NPC");
            entity.Property(e => e.PnetNpd).HasColumnName("pnet_NPD");
            entity.Property(e => e.PnetNumberMonthlyPurchases).HasColumnName("pnet_NumberMonthlyPurchases");
            entity.Property(e => e.PnetObservation).HasColumnName("pnet_Observation");
            entity.Property(e => e.PnetObservationsRenewal).HasColumnName("pnet_ObservationsRenewal");
            entity.Property(e => e.PnetOctober).HasColumnName("pnet_October");
            entity.Property(e => e.PnetOfferByMemberId).HasColumnName("pnet_OfferByMemberId");
            entity.Property(e => e.PnetOneMonth)
                .HasMaxLength(100)
                .HasColumnName("pnet_OneMonth");
            entity.Property(e => e.PnetOpcreditSubType).HasColumnName("pnet_OPCreditSubType");
            entity.Property(e => e.PnetOpcreditType).HasColumnName("pnet_OPCreditType");
            entity.Property(e => e.PnetOperationalResultsHigh)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_OperationalResultsHigh");
            entity.Property(e => e.PnetOperationalResultsLow)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_OperationalResultsLow");
            entity.Property(e => e.PnetOperationalResultsMiddle)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_OperationalResultsMiddle");
            entity.Property(e => e.PnetOpportunities).HasColumnName("pnet_Opportunities");
            entity.Property(e => e.PnetOpportunityId)
                .HasMaxLength(100)
                .HasColumnName("pnet_OpportunityID");
            entity.Property(e => e.PnetOpprincipalApplication)
                .HasMaxLength(100)
                .HasColumnName("pnet_OPPrincipalApplication");
            entity.Property(e => e.PnetOpreportType).HasColumnName("pnet_OPReportType");
            entity.Property(e => e.PnetOtherActive).HasColumnName("pnet_OtherActive");
            entity.Property(e => e.PnetOtherCirculatingActives).HasColumnName("pnet_OtherCirculatingActives");
            entity.Property(e => e.PnetOtherFamilyExpenses).HasColumnName("pnet_OtherFamilyExpenses");
            entity.Property(e => e.PnetOtherFixedActives).HasColumnName("pnet_OtherFixedActives");
            entity.Property(e => e.PnetOtherIncomeMonthHigh).HasColumnName("pnet_OtherIncomeMonthHigh");
            entity.Property(e => e.PnetOtherIncomeMonthLow).HasColumnName("pnet_OtherIncomeMonthLow");
            entity.Property(e => e.PnetOtherIncomeMonthMiddle).HasColumnName("pnet_OtherIncomeMonthMiddle");
            entity.Property(e => e.PnetOtherPaymentMethod).HasColumnName("pnet_OtherPaymentMethod");
            entity.Property(e => e.PnetOtherincomes).HasColumnName("pnet_otherincomes");
            entity.Property(e => e.PnetOthers).HasColumnName("pnet_Others");
            entity.Property(e => e.PnetOthersCirculatingPassives).HasColumnName("pnet_OthersCirculatingPassives");
            entity.Property(e => e.PnetOthersPassives).HasColumnName("pnet_OthersPassives");
            entity.Property(e => e.PnetOthersProperties).HasColumnName("pnet_OthersProperties");
            entity.Property(e => e.PnetOwnHouse).HasColumnName("pnet_OwnHouse");
            entity.Property(e => e.PnetOwnerEi).HasColumnName("pnet_OwnerEI");
            entity.Property(e => e.PnetPa).HasColumnName("pnet_PA");
            entity.Property(e => e.PnetPanelSin).HasColumnName("pnet_PanelSin");
            entity.Property(e => e.PnetPapers).HasColumnName("pnet_Papers");
            entity.Property(e => e.PnetParameterId).HasColumnName("pnet_ParameterId");
            entity.Property(e => e.PnetPatrimonialClassification).HasColumnName("pnet_PatrimonialClassification");
            entity.Property(e => e.PnetPatrimonialObservations).HasColumnName("pnet_PatrimonialObservations");
            entity.Property(e => e.PnetPatrimonialSolidityTotal).HasColumnName("pnet_PatrimonialSolidityTotal");
            entity.Property(e => e.PnetPayCapacityAdjustedMonthHigh)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_PayCapacityAdjustedMonthHigh");
            entity.Property(e => e.PnetPayCapacityAdjustedMonthLow)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_PayCapacityAdjustedMonthLow");
            entity.Property(e => e.PnetPayCapacityAdjustedMonthMiddle)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_PayCapacityAdjustedMonthMiddle");
            entity.Property(e => e.PnetPayCapacityMonthHigh)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_PayCapacityMonthHigh");
            entity.Property(e => e.PnetPayCapacityMonthLow)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_PayCapacityMonthLow");
            entity.Property(e => e.PnetPayCapacityMonthMiddle)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_PayCapacityMonthMiddle");
            entity.Property(e => e.PnetPayCapacityPeriod)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_PayCapacityPeriod");
            entity.Property(e => e.PnetPayFees).HasColumnName("pnet_PayFees");
            entity.Property(e => e.PnetPaycapacityadjusted).HasColumnName("pnet_paycapacityadjusted");
            entity.Property(e => e.PnetPaymentBehavior).HasColumnName("pnet_PaymentBehavior");
            entity.Property(e => e.PnetPb).HasColumnName("pnet_PB");
            entity.Property(e => e.PnetPc).HasColumnName("pnet_PC");
            entity.Property(e => e.PnetPd).HasColumnName("pnet_PD");
            entity.Property(e => e.PnetPe).HasColumnName("pnet_pe");
            entity.Property(e => e.PnetPermanence).HasColumnName("pnet_Permanence");
            entity.Property(e => e.PnetPermanenceObservation).HasColumnName("pnet_PermanenceObservation");
            entity.Property(e => e.PnetPermanenceRating).HasColumnName("pnet_PermanenceRating");
            entity.Property(e => e.PnetPositiveReferences).HasColumnName("pnet_PositiveReferences");
            entity.Property(e => e.PnetPreApprovedAmountPa).HasColumnName("pnet_PreApprovedAmountPA");
            entity.Property(e => e.PnetPreApprovedClassificationOp).HasColumnName("pnet_PreApprovedClassificationOP");
            entity.Property(e => e.PnetPreApprovedFeePa).HasColumnName("pnet_PreApprovedFeePA");
            entity.Property(e => e.PnetPreApprovedOpportunity).HasColumnName("pnet_PreApprovedOpportunity");
            entity.Property(e => e.PnetPreapprovedAmount).HasColumnName("pnet_PreapprovedAmount");
            entity.Property(e => e.PnetPreapprovedFee).HasColumnName("pnet_PreapprovedFee");
            entity.Property(e => e.PnetPreferenceRate).HasColumnName("pnet_PreferenceRate");
            entity.Property(e => e.PnetPreviousCategory).HasColumnName("pnet_PreviousCategory");
            entity.Property(e => e.PnetPreviousInstance).HasColumnName("pnet_PreviousInstance");
            entity.Property(e => e.PnetPrincipalApplication).HasColumnName("pnet_PrincipalApplication");
            entity.Property(e => e.PnetPrivateEducation).HasColumnName("pnet_PrivateEducation");
            entity.Property(e => e.PnetProductName1)
                .HasMaxLength(114)
                .HasColumnName("pnet_ProductName1");
            entity.Property(e => e.PnetProductName2)
                .HasMaxLength(119)
                .HasColumnName("pnet_ProductName2");
            entity.Property(e => e.PnetProductName3)
                .HasMaxLength(109)
                .HasColumnName("pnet_ProductName3");
            entity.Property(e => e.PnetProductQuantity1).HasColumnName("pnet_ProductQuantity1");
            entity.Property(e => e.PnetProductQuantity2).HasColumnName("pnet_ProductQuantity2");
            entity.Property(e => e.PnetProductQuantity3).HasColumnName("pnet_ProductQuantity3");
            entity.Property(e => e.PnetPromeDebts).HasColumnName("pnet_PromeDebts");
            entity.Property(e => e.PnetPromebehavior).HasColumnName("pnet_PROMEBehavior");
            entity.Property(e => e.PnetProviders).HasColumnName("pnet_Providers");
            entity.Property(e => e.PnetPurchaseMethod).HasColumnName("pnet_PurchaseMethod");
            entity.Property(e => e.PnetQualityRecordSales).HasColumnName("pnet_QualityRecordSales");
            entity.Property(e => e.PnetQualityRecordsObservation).HasColumnName("pnet_QualityRecordsObservation");
            entity.Property(e => e.PnetQuotaExpirationDay).HasColumnName("pnet_QuotaExpirationDay");
            entity.Property(e => e.PnetQuotaOverdue).HasColumnName("pnet_QuotaOverdue");
            entity.Property(e => e.PnetQuotasNumber).HasColumnName("pnet_QuotasNumber");
            entity.Property(e => e.PnetQuotasPaid).HasColumnName("pnet_QuotasPaid");
            entity.Property(e => e.PnetRa).HasColumnName("pnet_RA");
            entity.Property(e => e.PnetRate).HasColumnName("pnet_Rate");
            entity.Property(e => e.PnetRate1).HasColumnName("pnet_rate1");
            entity.Property(e => e.PnetRateApplied).HasColumnName("pnet_RateApplied");
            entity.Property(e => e.PnetRawMaterial1).HasColumnName("pnet_RawMaterial1");
            entity.Property(e => e.PnetRawMaterial2).HasColumnName("pnet_RawMaterial2");
            entity.Property(e => e.PnetRawMaterial3).HasColumnName("pnet_RawMaterial3");
            entity.Property(e => e.PnetRawMaterials).HasColumnName("pnet_RawMaterials");
            entity.Property(e => e.PnetRb).HasColumnName("pnet_RB");
            entity.Property(e => e.PnetRc).HasColumnName("pnet_RC");
            entity.Property(e => e.PnetRd).HasColumnName("pnet_RD");
            entity.Property(e => e.PnetRecordCommitteeId).HasColumnName("pnet_RecordCommitteeId");
            entity.Property(e => e.PnetRegistrationDateAfip)
                .HasColumnType("datetime")
                .HasColumnName("pnet_RegistrationDateAFIP");
            entity.Property(e => e.PnetRemunerationType).HasColumnName("pnet_RemunerationType");
            entity.Property(e => e.PnetRenewalAccumulate).HasColumnName("pnet_RenewalAccumulate");
            entity.Property(e => e.PnetRenovation).HasColumnName("pnet_Renovation");
            entity.Property(e => e.PnetRenovationCorrectionFactor).HasColumnName("pnet_RenovationCorrectionFactor");
            entity.Property(e => e.PnetRenovationPayCapacity)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_RenovationPayCapacity");
            entity.Property(e => e.PnetRenovationPayCapacityAdjusted)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_REnovationPayCapacityAdjusted");
            entity.Property(e => e.PnetRenovationRequest).HasColumnName("pnet_RenovationRequest");
            entity.Property(e => e.PnetRenovationRequestManual).HasColumnName("pnet_RenovationRequestManual");
            entity.Property(e => e.PnetRent).HasColumnName("pnet_Rent");
            entity.Property(e => e.PnetReportGenerate).HasColumnName("pnet_ReportGenerate");
            entity.Property(e => e.PnetReportType).HasColumnName("pnet_ReportType");
            entity.Property(e => e.PnetReportTypeid).HasColumnName("pnet_ReportTypeid");
            entity.Property(e => e.PnetReportsGeneratePdf).HasColumnName("pnet_ReportsGeneratePDF");
            entity.Property(e => e.PnetReputationCommercialBasis).HasColumnName("pnet_ReputationCommercialBasis");
            entity.Property(e => e.PnetRequestId).HasColumnName("pnet_RequestId");
            entity.Property(e => e.PnetRequestIdOpp).HasColumnName("pnet_RequestId_Opp");
            entity.Property(e => e.PnetRequireRisk).HasColumnName("pnet_RequireRisk");
            entity.Property(e => e.PnetRequiresAccountOpening)
                .HasMaxLength(100)
                .HasColumnName("pnet_RequiresAccountOpening");
            entity.Property(e => e.PnetResponse)
                .HasMaxLength(100)
                .HasColumnName("pnet_Response");
            entity.Property(e => e.PnetResultadosScoreDePuntaje).HasColumnName("pnet_resultadosScoreDePuntaje");
            entity.Property(e => e.PnetRiskAnalysisId).HasColumnName("pnet_RiskAnalysisId");
            entity.Property(e => e.PnetRiskFactors).HasColumnName("pnet_RiskFactors");
            entity.Property(e => e.PnetRollupTotalAdjustedRevenue)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_RollupTotalAdjustedRevenue");
            entity.Property(e => e.PnetRollupTotalAdjustedRevenueDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_RollupTotalAdjustedRevenue_Date");
            entity.Property(e => e.PnetRollupTotalAdjustedRevenueState).HasColumnName("pnet_RollupTotalAdjustedRevenue_State");
            entity.Property(e => e.PnetRollupTotalFamilyBusinessDebts)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_RollupTotalFamilyBusinessDebts");
            entity.Property(e => e.PnetRollupTotalFamilyBusinessDebtsDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_RollupTotalFamilyBusinessDebts_Date");
            entity.Property(e => e.PnetRollupTotalFamilyBusinessDebtsState).HasColumnName("pnet_RollupTotalFamilyBusinessDebts_State");
            entity.Property(e => e.PnetRollupTotalFixedCost)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_RollupTotalFixedCost");
            entity.Property(e => e.PnetRollupTotalFixedCostDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_RollupTotalFixedCost_Date");
            entity.Property(e => e.PnetRollupTotalFixedCostState).HasColumnName("pnet_RollupTotalFixedCost_State");
            entity.Property(e => e.PnetSaa).HasColumnName("pnet_SAA");
            entity.Property(e => e.PnetSaleMonthHigh).HasColumnName("pnet_SaleMonthHigh");
            entity.Property(e => e.PnetSaleMonthLow).HasColumnName("pnet_SaleMonthLow");
            entity.Property(e => e.PnetSaleMonthMiddle).HasColumnName("pnet_SaleMonthMiddle");
            entity.Property(e => e.PnetSalePrice1).HasColumnName("pnet_SalePrice1");
            entity.Property(e => e.PnetSalePrice2).HasColumnName("pnet_SalePrice2");
            entity.Property(e => e.PnetSalePrice3).HasColumnName("pnet_SalePrice3");
            entity.Property(e => e.PnetSalesCustomer1).HasColumnName("pnet_SalesCustomer1");
            entity.Property(e => e.PnetSalesCustomer2).HasColumnName("pnet_SalesCustomer2");
            entity.Property(e => e.PnetSalesCustomer3).HasColumnName("pnet_SalesCustomer3");
            entity.Property(e => e.PnetSalesImpact1).HasColumnName("pnet_SalesImpact1");
            entity.Property(e => e.PnetSalesImpact2).HasColumnName("pnet_SalesImpact2");
            entity.Property(e => e.PnetSalesImpact3).HasColumnName("pnet_SalesImpact3");
            entity.Property(e => e.PnetSalesMonthHigh).HasColumnName("pnet_SalesMonthHigh");
            entity.Property(e => e.PnetSalesMonthLow).HasColumnName("pnet_SalesMonthLow");
            entity.Property(e => e.PnetSalesMonthMedium).HasColumnName("pnet_SalesMonthMedium");
            entity.Property(e => e.PnetSchema).HasColumnName("pnet_Schema");
            entity.Property(e => e.PnetSeptember).HasColumnName("pnet_September");
            entity.Property(e => e.PnetSetAcumRen).HasColumnName("pnet_SetAcumRen");
            entity.Property(e => e.PnetSetValuesInterestrate).HasColumnName("pnet_SetValuesInterestrate");
            entity.Property(e => e.PnetSettlementperiod).HasColumnName("pnet_settlementperiod");
            entity.Property(e => e.PnetSevenMonth)
                .HasMaxLength(100)
                .HasColumnName("pnet_SevenMonth");
            entity.Property(e => e.PnetSignature1)
                .HasMaxLength(100)
                .HasColumnName("pnet_Signature1");
            entity.Property(e => e.PnetSignature2)
                .HasMaxLength(100)
                .HasColumnName("pnet_Signature2");
            entity.Property(e => e.PnetSignature3)
                .HasMaxLength(100)
                .HasColumnName("pnet_Signature3");
            entity.Property(e => e.PnetSiteVisitNumber).HasColumnName("pnet_SiteVisitNumber");
            entity.Property(e => e.PnetSixMonth)
                .HasMaxLength(100)
                .HasColumnName("pnet_SixMonth");
            entity.Property(e => e.PnetSocialWork).HasColumnName("pnet_SocialWork");
            entity.Property(e => e.PnetSports).HasColumnName("pnet_Sports");
            entity.Property(e => e.PnetSteIme).HasColumnName("pnet_SteIME");
            entity.Property(e => e.PnetSteMe).HasColumnName("pnet_SteME");
            entity.Property(e => e.PnetStrengths).HasColumnName("pnet_Strengths");
            entity.Property(e => e.PnetSubtotalExpenditures).HasColumnName("pnet_SubtotalExpenditures");
            entity.Property(e => e.PnetSupplementaryRequest).HasColumnName("pnet_SupplementaryRequest");
            entity.Property(e => e.PnetSuraccount).HasColumnName("pnet_SURaccount");
            entity.Property(e => e.PnetSvcreditSubType).HasColumnName("pnet_SVCreditSubType");
            entity.Property(e => e.PnetSvcreditType).HasColumnName("pnet_SVCreditType");
            entity.Property(e => e.PnetSvreportType).HasColumnName("pnet_SVReportType");
            entity.Property(e => e.PnetTenMonth)
                .HasMaxLength(100)
                .HasColumnName("pnet_TenMonth");
            entity.Property(e => e.PnetTermRange)
                .HasMaxLength(2)
                .HasColumnName("pnet_TermRange");
            entity.Property(e => e.PnetTermRanges).HasColumnName("pnet_TermRanges");
            entity.Property(e => e.PnetTest)
                .HasMaxLength(100)
                .HasColumnName("pnet_test");
            entity.Property(e => e.PnetTest2).HasColumnName("pnet_test2");
            entity.Property(e => e.PnetThreeMonth)
                .HasMaxLength(100)
                .HasColumnName("pnet_ThreeMonth");
            entity.Property(e => e.PnetTmov).HasColumnName("pnet_TMov");
            entity.Property(e => e.PnetToDateCb)
                .HasColumnType("datetime")
                .HasColumnName("pnet_ToDateCB");
            entity.Property(e => e.PnetTotalActives).HasColumnName("pnet_TotalActives");
            entity.Property(e => e.PnetTotalAdjustedRevenue).HasColumnName("pnet_TotalAdjustedRevenue");
            entity.Property(e => e.PnetTotalCirculatingActives).HasColumnName("pnet_TotalCirculatingActives");
            entity.Property(e => e.PnetTotalCirculatingPassives).HasColumnName("pnet_TotalCirculatingPassives");
            entity.Property(e => e.PnetTotalCostMonthHigh).HasColumnName("pnet_TotalCostMonthHigh");
            entity.Property(e => e.PnetTotalCostMonthLow).HasColumnName("pnet_TotalCostMonthLow");
            entity.Property(e => e.PnetTotalCostMonthMiddle).HasColumnName("pnet_TotalCostMonthMiddle");
            entity.Property(e => e.PnetTotalFamilyBusinessDebts).HasColumnName("pnet_TotalFamilyBusinessDebts");
            entity.Property(e => e.PnetTotalFamilyExpenditure).HasColumnName("pnet_TotalFamilyExpenditure");
            entity.Property(e => e.PnetTotalFamilyGroup).HasColumnName("pnet_TotalFamilyGroup");
            entity.Property(e => e.PnetTotalFamilyandBusinessDebts).HasColumnName("pnet_TotalFamilyandBusinessDebts");
            entity.Property(e => e.PnetTotalFixedActives).HasColumnName("pnet_TotalFixedActives");
            entity.Property(e => e.PnetTotalFixedCosts).HasColumnName("pnet_TotalFixedCosts");
            entity.Property(e => e.PnetTotalFixedCosts10).HasColumnName("pnet_TotalFixedCosts10");
            entity.Property(e => e.PnetTotalMonthHigh).HasColumnName("pnet_TotalMonthHigh");
            entity.Property(e => e.PnetTotalMonthLow).HasColumnName("pnet_TotalMonthLow");
            entity.Property(e => e.PnetTotalMonthMedium).HasColumnName("pnet_TotalMonthMedium");
            entity.Property(e => e.PnetTotalPassiveLongTerm).HasColumnName("pnet_TotalPassiveLongTerm");
            entity.Property(e => e.PnetTotalPassives).HasColumnName("pnet_TotalPassives");
            entity.Property(e => e.PnetTotalSalesMonthHigh).HasColumnName("pnet_TotalSalesMonthHigh");
            entity.Property(e => e.PnetTotalSalesMonthLow).HasColumnName("pnet_TotalSalesMonthLow");
            entity.Property(e => e.PnetTotalSalesMonthMiddle).HasColumnName("pnet_TotalSalesMonthMiddle");
            entity.Property(e => e.PnetTwelveMonth)
                .HasMaxLength(100)
                .HasColumnName("pnet_TwelveMonth");
            entity.Property(e => e.PnetTwoMonth)
                .HasMaxLength(100)
                .HasColumnName("pnet_TwoMonth");
            entity.Property(e => e.PnetUlcstatus).HasColumnName("pnet_ULCStatus");
            entity.Property(e => e.PnetUnderMonthFactor).HasColumnName("pnet_UnderMonthFactor");
            entity.Property(e => e.PnetUnderMonthFactor2).HasColumnName("pnet_UnderMonthFactor2");
            entity.Property(e => e.PnetUnremunerative).HasColumnName("pnet_Unremunerative");
            entity.Property(e => e.PnetUrl).HasColumnName("pnet_url");
            entity.Property(e => e.PnetUrl01)
                .HasMaxLength(200)
                .HasColumnName("pnet_url01");
            entity.Property(e => e.PnetUrl02)
                .HasMaxLength(200)
                .HasColumnName("pnet_url02");
            entity.Property(e => e.PnetUrlExchangeNews)
                .HasMaxLength(200)
                .HasColumnName("pnet_URL_ExchangeNews");
            entity.Property(e => e.PnetUrlGetProductsByNip)
                .HasMaxLength(200)
                .HasColumnName("pnet_URL_GetProductsByNip");
            entity.Property(e => e.PnetUrlgetProductsByNip1)
                .HasMaxLength(250)
                .HasColumnName("pnet_URLGetProductsByNip");
            entity.Property(e => e.PnetUrlra)
                .HasMaxLength(100)
                .HasColumnName("pnet_URLRA");
            entity.Property(e => e.PnetUrlrc)
                .HasMaxLength(100)
                .HasColumnName("pnet_URLRC");
            entity.Property(e => e.PnetValidateProcessUserId).HasColumnName("pnet_ValidateProcessUserId");
            entity.Property(e => e.PnetVariableCostMonthHigh).HasColumnName("pnet_VariableCostMonthHigh");
            entity.Property(e => e.PnetVariableCostMonthLow).HasColumnName("pnet_VariableCostMonthLow");
            entity.Property(e => e.PnetVariableCostMonthMiddle).HasColumnName("pnet_VariableCostMonthMiddle");
            entity.Property(e => e.PnetVariableCostsObservations).HasColumnName("pnet_VariableCostsObservations");
            entity.Property(e => e.PnetVariableCostsSubTotal).HasColumnName("pnet_VariableCostsSubTotal");
            entity.Property(e => e.PnetVariableCostsTotal).HasColumnName("pnet_VariableCostsTotal");
            entity.Property(e => e.PnetVariableNumberCustomers).HasColumnName("pnet_VariableNumberCustomers");
            entity.Property(e => e.PnetVehicles).HasColumnName("pnet_Vehicles");
            entity.Property(e => e.PnetVisitDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_VisitDate");
            entity.Property(e => e.PnetWhyChangesCorrectionFactor).HasColumnName("pnet_WhyChangesCorrectionFactor");
            entity.Property(e => e.PnetWhyDelayed).HasColumnName("pnet_WhyDelayed");
            entity.Property(e => e.PnetWhyPaymentDateChanged).HasColumnName("pnet_WhyPaymentDateChanged");
            entity.Property(e => e.PnetZonalChiefAuthorization).HasColumnName("pnet_ZonalChiefAuthorization");
            entity.Property(e => e.ScheduleFollowupProspect)
                .HasColumnType("datetime")
                .HasColumnName("ScheduleFollowup_Prospect");
            entity.Property(e => e.ScheduleFollowupQualify)
                .HasColumnType("datetime")
                .HasColumnName("ScheduleFollowup_Qualify");
            entity.Property(e => e.ScheduleProposalMeeting).HasColumnType("datetime");
            entity.Property(e => e.Slaid).HasColumnName("SLAId");
            entity.Property(e => e.SlainvokedId).HasColumnName("SLAInvokedId");
            entity.Property(e => e.StepName).HasMaxLength(200);
            entity.Property(e => e.TimeSpentByMeOnEmailAndMeetings).HasMaxLength(1250);
            entity.Property(e => e.TotalAmount).HasColumnType("money");
            entity.Property(e => e.TotalAmountBase)
                .HasColumnType("money")
                .HasColumnName("TotalAmount_Base");
            entity.Property(e => e.TotalAmountLessFreight).HasColumnType("money");
            entity.Property(e => e.TotalAmountLessFreightBase)
                .HasColumnType("money")
                .HasColumnName("TotalAmountLessFreight_Base");
            entity.Property(e => e.TotalDiscountAmount).HasColumnType("money");
            entity.Property(e => e.TotalDiscountAmountBase)
                .HasColumnType("money")
                .HasColumnName("TotalDiscountAmount_Base");
            entity.Property(e => e.TotalLineItemAmount).HasColumnType("money");
            entity.Property(e => e.TotalLineItemAmountBase)
                .HasColumnType("money")
                .HasColumnName("TotalLineItemAmount_Base");
            entity.Property(e => e.TotalLineItemDiscountAmount).HasColumnType("money");
            entity.Property(e => e.TotalLineItemDiscountAmountBase)
                .HasColumnType("money")
                .HasColumnName("TotalLineItemDiscountAmount_Base");
            entity.Property(e => e.TotalTax).HasColumnType("money");
            entity.Property(e => e.TotalTaxBase)
                .HasColumnType("money")
                .HasColumnName("TotalTax_Base");
            entity.Property(e => e.TraversedPath).HasMaxLength(1250);
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.ZennonbiScore)
                .HasMaxLength(50)
                .HasColumnName("zennonbi_score");
        });

        modelBuilder.Entity<Organización>(entity =>
        {
            entity.HasKey(e => e.SkArea);

            entity.ToTable("Organización", "app");

            entity.Property(e => e.SkArea)
                .ValueGeneratedNever()
                .HasColumnName("skArea");
            entity.Property(e => e.CentroDeCostos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaCreación).HasColumnType("datetime");
            entity.Property(e => e.FechaModificación).HasColumnType("datetime");
            entity.Property(e => e.Gerencia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Latitud).HasColumnType("numeric(18, 6)");
            entity.Property(e => e.Longitud).HasColumnType("numeric(18, 6)");
            entity.Property(e => e.Mail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SectorCodigo)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.SectorNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Zona)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Ovale>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Ovales", "int");

            entity.Property(e => e.Apellido).HasMaxLength(50);
            entity.Property(e => e.AreaCód1).HasMaxLength(4000);
            entity.Property(e => e.AreaCód2).HasMaxLength(4000);
            entity.Property(e => e.AreaCód3).HasMaxLength(4000);
            entity.Property(e => e.Bpbacalle)
                .HasMaxLength(100)
                .HasColumnName("BPBACalle");
            entity.Property(e => e.BpbacalleCp)
                .HasMaxLength(100)
                .HasColumnName("BPBACalleCP");
            entity.Property(e => e.BpbacalleNro)
                .HasMaxLength(100)
                .HasColumnName("BPBACalleNro");
            entity.Property(e => e.Bpbapersona)
                .HasMaxLength(100)
                .HasColumnName("BPBAPersona");
            entity.Property(e => e.CalificaBip).HasColumnName("calificaBIP");
            entity.Property(e => e.Calle).HasMaxLength(250);
            entity.Property(e => e.Celular).HasMaxLength(53);
            entity.Property(e => e.ComienzoRealGestión)
                .HasColumnType("datetime")
                .HasColumnName("Comienzo real Gestión");
            entity.Property(e => e.CreatedOnCampaign).HasColumnType("datetime");
            entity.Property(e => e.CreatedOnCampaignResponse).HasColumnType("datetime");
            entity.Property(e => e.CódigoDeCampaña)
                .HasMaxLength(32)
                .HasColumnName("Código de campaña");
            entity.Property(e => e.CódigoDeCampaña2)
                .HasMaxLength(100)
                .HasColumnName("Código de campaña 2");
            entity.Property(e => e.CómoSeEnteró)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("¿Cómo se enteró?");
            entity.Property(e => e.DestinoDelCrédito)
                .HasMaxLength(4000)
                .HasColumnName("Destino del Crédito");
            entity.Property(e => e.DocTipo).HasMaxLength(100);
            entity.Property(e => e.EjecutivoComercial)
                .HasMaxLength(200)
                .HasColumnName("Ejecutivo Comercial");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .HasColumnName("EMailAddress");
            entity.Property(e => e.EquipoPropietario)
                .HasMaxLength(160)
                .HasColumnName("Equipo Propietario");
            entity.Property(e => e.EstadoDeVenta)
                .HasMaxLength(100)
                .HasColumnName("Estado de Venta");
            entity.Property(e => e.EstadoDeVentaDeLaGestión)
                .HasMaxLength(100)
                .HasColumnName("Estado de Venta de la Gestión");
            entity.Property(e => e.FechaDeFinalizaciónReal)
                .HasColumnType("datetime")
                .HasColumnName("Fecha de finalización real");
            entity.Property(e => e.FechaDeInicioReal)
                .HasColumnType("datetime")
                .HasColumnName("Fecha de inicio real");
            entity.Property(e => e.FechaLiquidación).HasColumnType("datetime");
            entity.Property(e => e.FechaModificaciónContacto).HasColumnType("datetime");
            entity.Property(e => e.FechaModificaciónSolicitud).HasColumnType("datetime");
            entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");
            entity.Property(e => e.FilialBpbaPropietaria)
                .HasMaxLength(8)
                .HasColumnName("Filial BPBA Propietaria");
            entity.Property(e => e.FinRealGestión)
                .HasColumnType("datetime")
                .HasColumnName("Fin real Gestión");
            entity.Property(e => e.Legajo).HasMaxLength(8);
            entity.Property(e => e.ModifiedOnCampaign).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOnCampaignResponse).HasColumnType("datetime");
            entity.Property(e => e.MontoDeCréditoDeLaGestión).HasColumnName("Monto de Crédito de la Gestión");
            entity.Property(e => e.MontoDeCréditoDeLaOfertaDeValor).HasColumnName("Monto de Crédito de la Oferta de Valor");
            entity.Property(e => e.MontoDeCuota).HasColumnName("Monto de Cuota");
            entity.Property(e => e.MontoDeCuotaDeLaOfertaDeValor).HasColumnName("Monto de Cuota de la Oferta de Valor");
            entity.Property(e => e.Nacionalidad).HasMaxLength(250);
            entity.Property(e => e.Nif)
                .HasMaxLength(100)
                .HasColumnName("NIF");
            entity.Property(e => e.NombreDeCampaña)
                .HasMaxLength(128)
                .HasColumnName("Nombre de campaña");
            entity.Property(e => e.Nombres).HasMaxLength(69);
            entity.Property(e => e.Npa).HasColumnName("NPA");
            entity.Property(e => e.Npb).HasColumnName("NPB");
            entity.Property(e => e.Npc).HasColumnName("NPC");
            entity.Property(e => e.Npd).HasColumnName("NPD");
            entity.Property(e => e.NúmeroDeCuotas).HasColumnName("Número de Cuotas");
            entity.Property(e => e.NúmeroDeCuotasDeLaGestión).HasColumnName("Número de Cuotas de la Gestión");
            entity.Property(e => e.OfertaDeValor)
                .HasMaxLength(300)
                .HasColumnName("Oferta de Valor");
            entity.Property(e => e.Pa).HasColumnName("PA");
            entity.Property(e => e.Pb).HasColumnName("PB");
            entity.Property(e => e.Pc).HasColumnName("PC");
            entity.Property(e => e.Pd).HasColumnName("PD");
            entity.Property(e => e.Pe).HasColumnName("PE");
            entity.Property(e => e.Pf).HasColumnName("PF");
            entity.Property(e => e.Pg).HasColumnName("PG");
            entity.Property(e => e.PnetContactId).HasColumnName("pnet_ContactId");
            entity.Property(e => e.PnetConvenio).HasColumnName("pnet_convenio");
            entity.Property(e => e.PnetInCampaign).HasColumnName("pnet_InCampaign");
            entity.Property(e => e.PnetSuraccount).HasColumnName("pnet_SURaccount");
            entity.Property(e => e.Propietario).HasMaxLength(160);
            entity.Property(e => e.RangoDeMonto).HasColumnName("Rango de Monto");
            entity.Property(e => e.RangosDeTérmino).HasColumnName("Rangos de Término");
            entity.Property(e => e.Rb).HasColumnName("RB");
            entity.Property(e => e.Rc).HasColumnName("RC");
            entity.Property(e => e.Rd).HasColumnName("RD");
            entity.Property(e => e.RequiereVisitaEnTerreno).HasColumnName("Requiere Visita en Terreno");
            entity.Property(e => e.Solicitud).HasMaxLength(300);
            entity.Property(e => e.StateCodeCampaign).HasMaxLength(4000);
            entity.Property(e => e.StateCodeCampaignResponse).HasMaxLength(4000);
            entity.Property(e => e.StateCodeListmembers).HasMaxLength(4000);
            entity.Property(e => e.StatusCodeCampaign).HasMaxLength(4000);
            entity.Property(e => e.StatusCodeCampaignResponse).HasMaxLength(4000);
            entity.Property(e => e.StatusCodeListmembers).HasMaxLength(4000);
            entity.Property(e => e.SubEstadoDeLaVenta)
                .HasMaxLength(100)
                .HasColumnName("Sub-Estado de la Venta");
            entity.Property(e => e.SucursalCódigoPropietaria)
                .HasMaxLength(8)
                .HasColumnName("Sucursal Código Propietaria");
            entity.Property(e => e.SucursalPropietaria)
                .HasMaxLength(100)
                .HasColumnName("Sucursal Propietaria");
            entity.Property(e => e.TasaDeInterésAnual).HasColumnName("Tasa de Interés Anual");
            entity.Property(e => e.TasaDeInterésMensual).HasColumnName("Tasa de Interés Mensual");
            entity.Property(e => e.TasaGestión).HasColumnName("Tasa gestión");
            entity.Property(e => e.Tel1).HasMaxLength(100);
            entity.Property(e => e.Tel2).HasMaxLength(100);
            entity.Property(e => e.Tel3).HasMaxLength(100);
            entity.Property(e => e.Teléfono).HasMaxLength(50);
            entity.Property(e => e.TeléfonoConsolidado).HasMaxLength(100);
            entity.Property(e => e.TipificaciónDeCrédito)
                .HasMaxLength(3)
                .HasColumnName("Tipificación de Crédito");
            entity.Property(e => e.TipoDeCampaña)
                .HasMaxLength(4000)
                .HasColumnName("Tipo de campaña");
            entity.Property(e => e.TipoDeCliente)
                .HasMaxLength(4000)
                .HasColumnName("Tipo de Cliente");
            entity.Property(e => e.TipoDeFormulario)
                .HasMaxLength(4000)
                .HasColumnName("Tipo de Formulario");
            entity.Property(e => e.ValorDeCuotaDeLaGestión).HasColumnName("Valor de Cuota de la Gestión");
            entity.Property(e => e.XVencimientoCampaginResponse).HasColumnName("X Vencimiento Campagin Response");
            entity.Property(e => e.XVencimientoOfferValue).HasColumnName("X Vencimiento Offer Value");
            entity.Property(e => e.Zona).HasMaxLength(160);
        });

        modelBuilder.Entity<OwnerBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OwnerBase", "crm");

            entity.HasIndex(e => e.OwnerId, "IDX-OwnerBase-ids");

            entity.Property(e => e.Name).HasMaxLength(160);
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.YomiName).HasMaxLength(160);
        });

        modelBuilder.Entity<Padronsur>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PADRONSUR", "int");

            entity.Property(e => e.Adic)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ADIC");
            entity.Property(e => e.Archivo).HasMaxLength(256);
            entity.Property(e => e.CanCuotAtr)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CAN CUOT ATR");
            entity.Property(e => e.CanCuotEmi)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CAN CUOT EMI");
            entity.Property(e => e.CanCuotPag)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CAN CUOT PAG");
            entity.Property(e => e.CanCuotPre)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CAN CUOT PRE");
            entity.Property(e => e.Cnae)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("CNAE");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("CODIGO POSTAL");
            entity.Property(e => e.Contrato)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("CONTRATO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.DiasAtraso)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("DIAS ATRASO");
            entity.Property(e => e.DirElectron)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("DIR ELECTRON");
            entity.Property(e => e.Domicilio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DOMICILIO");
            entity.Property(e => e.EstadoCivil)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ESTADO CIVIL");
            entity.Property(e => e.FecNac)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("FEC NAC");
            entity.Property(e => e.FecProces)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("FEC PROCES");
            entity.Property(e => e.FecUltVen)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("FEC ULT VEN");
            entity.Property(e => e.FechaAper)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("FECHA APER");
            entity.Property(e => e.FechaVto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("FECHA VTO");
            entity.Property(e => e.IdProceso).HasMaxLength(50);
            entity.Property(e => e.LimiteCompra)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("LIMITE COMPRA");
            entity.Property(e => e.Localidad)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("LOCALIDAD");
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NACIONALIDAD");
            entity.Property(e => e.Nif)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("NIF");
            entity.Property(e => e.NivFormac)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("NIV FORMAC");
            entity.Property(e => e.NroCartera)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("NroCARTERA");
            entity.Property(e => e.NroCta)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("NRO CTA");
            entity.Property(e => e.NroDoc)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("NRO DOC");
            entity.Property(e => e.NroTarjeta)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("NRO TARJETA");
            entity.Property(e => e.Persona)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("PERSONA");
            entity.Property(e => e.Plazo)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("PLAZO");
            entity.Property(e => e.SaldoDeu)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasColumnName("SALDO DEU");
            entity.Property(e => e.Segment)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SEGMENT");
            entity.Property(e => e.Sexo)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("SEXO");
            entity.Property(e => e.SitCont)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SIT CONT");
            entity.Property(e => e.Sucur)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SUCUR");
            entity.Property(e => e.Sucur2)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SUCUR2");
            entity.Property(e => e.Tasa)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TASA");
            entity.Property(e => e.Telefono)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.TipCta)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TIP CTA");
            entity.Property(e => e.TipDoc)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("TIP DOC");
            entity.Property(e => e.Titular)
                .HasMaxLength(74)
                .IsUnicode(false)
                .HasColumnName("TITULAR");
            entity.Property(e => e.TotalPrest)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasColumnName("TOTAL PREST");
            entity.Property(e => e.ValorMin)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("VALOR MIN");
        });

        modelBuilder.Entity<PaginaRegistro>(entity =>
        {
            entity.HasKey(e => e.IdPaginaRegistro);

            entity.ToTable("PaginaRegistro", "app");

            entity.Property(e => e.IdPaginaRegistro).HasColumnName("idPaginaRegistro");
            entity.Property(e => e.CTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("C_timestamp");
            entity.Property(e => e.Colaborador).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FechaActualización).HasColumnType("datetime");
            entity.Property(e => e.FechaCreación).HasColumnType("datetime");
            entity.Property(e => e.Pagina).HasMaxLength(250);
        });

        modelBuilder.Entity<PaginasConfig>(entity =>
        {
            entity.HasKey(e => e.IdConfiguracion);

            entity.ToTable("PaginasConfig", "app");

            entity.Property(e => e.Area).HasMaxLength(50);
            entity.Property(e => e.CTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("C_timestamp");
            entity.Property(e => e.Cc)
                .HasMaxLength(1000)
                .HasColumnName("CC");
            entity.Property(e => e.Cco)
                .HasMaxLength(1000)
                .HasColumnName("CCO");
            entity.Property(e => e.Cdestinarios)
                .HasMaxLength(1000)
                .HasColumnName("CDestinarios");
            entity.Property(e => e.CorreoEnviado).HasComment("Indica si el correo se envió en la fecha de consulta");
            entity.Property(e => e.CorreosPersonalizados).HasMaxLength(2000);
            entity.Property(e => e.Enlace).HasMaxLength(200);
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.ModificadoPor).HasMaxLength(50);
            entity.Property(e => e.Pagina).HasMaxLength(100);
            entity.Property(e => e.PaginaNombre).HasMaxLength(100);
            entity.Property(e => e.Permisos).HasMaxLength(2000);
        });

        modelBuilder.Entity<PaginasConfigMail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PaginasConfigMail", "app");

            entity.Property(e => e.Area).HasMaxLength(50);
            entity.Property(e => e.Asunto).HasMaxLength(4000);
            entity.Property(e => e.Cc)
                .HasMaxLength(1000)
                .HasColumnName("CC");
            entity.Property(e => e.Cco)
                .HasMaxLength(1000)
                .HasColumnName("CCO");
            entity.Property(e => e.Cdestinarios)
                .HasMaxLength(1000)
                .HasColumnName("CDestinarios");
            entity.Property(e => e.DiaHabil).HasColumnType("date");
            entity.Property(e => e.Html).HasColumnName("HTML");
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Notas).HasMaxLength(500);
            entity.Property(e => e.Pagina).HasMaxLength(100);
            entity.Property(e => e.Sector).HasMaxLength(50);
        });

        modelBuilder.Entity<PaginasMenu>(entity =>
        {
            entity.HasKey(e => e.IdPaginaMenu).HasName("PK_PaginaMenu");

            entity.ToTable("PaginasMenu", "app");

            entity.Property(e => e.CTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("C_timestamp");
            entity.Property(e => e.Colaborador).HasMaxLength(50);
            entity.Property(e => e.Completo).IsUnicode(false);
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.ModificadoPor).HasMaxLength(50);
            entity.Property(e => e.Personalizado).IsUnicode(false);
        });

        modelBuilder.Entity<PaginasNotificacion>(entity =>
        {
            entity.HasKey(e => e.IdNotificacion);

            entity.ToTable("PaginasNotificacion", "app");

            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaDesde).HasColumnType("datetime");
            entity.Property(e => e.FechaHasta).HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.ModificadoPor).HasMaxLength(50);
            entity.Property(e => e.Nota).HasMaxLength(500);
            entity.Property(e => e.Pagina).HasMaxLength(100);
            entity.Property(e => e.Titulo).HasMaxLength(100);
        });

        modelBuilder.Entity<Parametro>(entity =>
        {
            entity.HasKey(e => e.IdParametro);

            entity.ToTable("Parametros", "fin");

            entity.Property(e => e.IdParametro).HasColumnName("idParametro");
            entity.Property(e => e.Parametro1)
                .HasMaxLength(30)
                .HasColumnName("Parametro");
            entity.Property(e => e.Periodo).HasColumnType("date");
            entity.Property(e => e.Ponderación).HasColumnType("numeric(18, 6)");
            entity.Property(e => e.Valor).HasMaxLength(50);
        });

        modelBuilder.Entity<PerColaboradorCapacitacion>(entity =>
        {
            entity.HasKey(e => e.IdColaborador);

            entity.ToTable("perColaboradorCapacitacion", "app");

            entity.Property(e => e.IdColaborador).HasColumnName("idColaborador");
            entity.Property(e => e.Carácter)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CostoCurso).HasColumnName("Costo Curso");
            entity.Property(e => e.EstadoCurso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Estado Curso");
            entity.Property(e => e.EstadoEvaluación)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Estado Evaluación");
            entity.Property(e => e.FechaFin)
                .HasColumnType("date")
                .HasColumnName("Fecha Fin");
            entity.Property(e => e.FechaInicio)
                .HasColumnType("date")
                .HasColumnName("Fecha Inicio");
            entity.Property(e => e.FechaProceso)
                .HasColumnType("datetime")
                .HasColumnName("Fecha Proceso");
            entity.Property(e => e.HorasCapacitación).HasColumnName("Horas Capacitación");
            entity.Property(e => e.Modalidad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreCurso)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Nombre Curso");
            entity.Property(e => e.NroIntento).HasColumnName("Nro Intento");
            entity.Property(e => e.Proveedor).HasMaxLength(255);
            entity.Property(e => e.PuntajeEvaluación)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("Puntaje Evaluación");
            entity.Property(e => e.TipoFormación)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Tipo Formación");
        });

        modelBuilder.Entity<PerColaboradorCapacitacion1>(entity =>
        {
            entity.HasKey(e => e.IdColaborador);

            entity.ToTable("perColaboradorCapacitacion", "int");

            entity.Property(e => e.IdColaborador).HasColumnName("idColaborador");
            entity.Property(e => e.Carácter).HasMaxLength(255);
            entity.Property(e => e.CostoCurso)
                .HasMaxLength(255)
                .HasColumnName("Costo Curso");
            entity.Property(e => e.EstadoCurso)
                .HasMaxLength(255)
                .HasColumnName("Estado Curso");
            entity.Property(e => e.EstadoEvaluación)
                .HasMaxLength(255)
                .HasColumnName("Estado Evaluación");
            entity.Property(e => e.FechaFin)
                .HasMaxLength(255)
                .HasColumnName("Fecha Fin");
            entity.Property(e => e.FechaInicio)
                .HasMaxLength(255)
                .HasColumnName("Fecha Inicio");
            entity.Property(e => e.FechaProceso)
                .HasColumnType("datetime")
                .HasColumnName("Fecha Proceso");
            entity.Property(e => e.HorasCapacitación)
                .HasMaxLength(255)
                .HasColumnName("Horas Capacitación");
            entity.Property(e => e.Legajo).HasMaxLength(255);
            entity.Property(e => e.Modalidad).HasMaxLength(255);
            entity.Property(e => e.Nombre).HasMaxLength(255);
            entity.Property(e => e.NombreCurso)
                .HasMaxLength(255)
                .HasColumnName("Nombre Curso");
            entity.Property(e => e.NroIntento)
                .HasMaxLength(255)
                .HasColumnName("Nro Intento");
            entity.Property(e => e.Proveedor).HasMaxLength(255);
            entity.Property(e => e.PuntajeEvaluación)
                .HasMaxLength(255)
                .HasColumnName("Puntaje Evaluación");
            entity.Property(e => e.TipoFormación)
                .HasMaxLength(255)
                .HasColumnName("Tipo Formación");
        });

        modelBuilder.Entity<PerHuellaFichadum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("perHuellaFichada", "app");

            entity.Property(e => e.AcNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AC-No#");
            entity.Property(e => e.Exception)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NewState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("New State");
            entity.Property(e => e.No)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("No#");
            entity.Property(e => e.Operation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Time).HasColumnType("datetime");
        });

        modelBuilder.Entity<PerHuellaFichadum1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("perHuellaFichada", "int");

            entity.Property(e => e.AcNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AC-No#");
            entity.Property(e => e.Exception)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NewState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("New State");
            entity.Property(e => e.No)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("No#");
            entity.Property(e => e.Operation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Time)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PerIncentivoConsultum>(entity =>
        {
            entity.HasKey(e => e.IdIncentivo).HasName("PK_persIncentivoConsulta");

            entity.ToTable("perIncentivoConsulta", "int");

            entity.Property(e => e.AdicionalRiesgo).HasMaxLength(256);
            entity.Property(e => e.Legajo).HasMaxLength(256);
            entity.Property(e => e.Nivel)
                .HasMaxLength(256)
                .HasColumnName("nivel");
            entity.Property(e => e.Nota).HasMaxLength(256);
            entity.Property(e => e.Porcentaje1).HasMaxLength(256);
            entity.Property(e => e.Porcentaje2).HasMaxLength(256);
            entity.Property(e => e.ResultadoComercial).HasMaxLength(256);
            entity.Property(e => e.Target).HasMaxLength(256);
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(256)
                .HasColumnName("tratamiento");
        });

        modelBuilder.Entity<PerIncentivoParcial>(entity =>
        {
            entity.HasKey(e => e.IdIncentivoParcial).HasName("PK_persIncentivoParcial");

            entity.ToTable("perIncentivoParcial", "int");

            entity.Property(e => e.Columna1).HasMaxLength(256);
            entity.Property(e => e.Columna10).HasMaxLength(256);
            entity.Property(e => e.Columna11).HasMaxLength(256);
            entity.Property(e => e.Columna12).HasMaxLength(256);
            entity.Property(e => e.Columna13).HasMaxLength(256);
            entity.Property(e => e.Columna14).HasMaxLength(256);
            entity.Property(e => e.Columna15).HasMaxLength(256);
            entity.Property(e => e.Columna2).HasMaxLength(256);
            entity.Property(e => e.Columna3).HasMaxLength(256);
            entity.Property(e => e.Columna4).HasMaxLength(256);
            entity.Property(e => e.Columna5).HasMaxLength(256);
            entity.Property(e => e.Columna6).HasMaxLength(256);
            entity.Property(e => e.Columna7).HasMaxLength(256);
            entity.Property(e => e.Columna8).HasMaxLength(256);
            entity.Property(e => e.Columna9).HasMaxLength(256);
        });

        modelBuilder.Entity<PerNominaTalento>(entity =>
        {
            entity.HasKey(e => e.IdNominaTalentos).HasName("PK_perNominaTalentos_1");

            entity.ToTable("perNominaTalentos", "app");

            entity.Property(e => e.IdNominaTalentos).HasColumnName("idNominaTalentos");
            entity.Property(e => e.Categoria)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CentroDeCostos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Centro de Costos");
            entity.Property(e => e.FechaAntiguedad)
                .HasColumnType("date")
                .HasColumnName("Fecha Antiguedad");
            entity.Property(e => e.FechaBaja)
                .HasColumnType("date")
                .HasColumnName("Fecha Baja");
            entity.Property(e => e.Fechaproceso)
                .HasColumnType("datetime")
                .HasColumnName("fechaproceso");
            entity.Property(e => e.Generacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gerencia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MotivoBaja)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Motivo Baja");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Perfil)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sector)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Zona)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PerNominaTalento1>(entity =>
        {
            entity.HasKey(e => e.IdNominaTalentos);

            entity.ToTable("perNominaTalentos", "int");

            entity.Property(e => e.IdNominaTalentos).HasColumnName("idNominaTalentos");
            entity.Property(e => e.Categoria)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CentroDeCostos)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Centro de Costos");
            entity.Property(e => e.FechaAntiguedad)
                .HasMaxLength(255)
                .HasColumnName("Fecha Antiguedad");
            entity.Property(e => e.FechaBaja)
                .HasMaxLength(255)
                .HasColumnName("Fecha Baja");
            entity.Property(e => e.Fechaproceso)
                .HasColumnType("datetime")
                .HasColumnName("fechaproceso");
            entity.Property(e => e.Generacion).HasMaxLength(255);
            entity.Property(e => e.Gerencia)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Legajo).HasMaxLength(255);
            entity.Property(e => e.MotivoBaja)
                .HasMaxLength(255)
                .HasColumnName("Motivo Baja");
            entity.Property(e => e.Nombre).HasMaxLength(255);
            entity.Property(e => e.Perfil)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Sector)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Zona).HasMaxLength(255);
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.IdPersona);

            entity.ToTable("Persona", "app");

            entity.HasIndex(e => new { e.TipoDocumento, e.NroDoc, e.Nif }, "IDX_Persona_DNI");

            entity.Property(e => e.Apellidos)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaCreación)
                .HasColumnType("datetime")
                .HasColumnName("Fecha Creación");
            entity.Property(e => e.FechaModificación)
                .HasColumnType("datetime")
                .HasColumnName("Fecha Modificación");
            entity.Property(e => e.FechaNacimiento)
                .HasColumnType("date")
                .HasColumnName("Fecha Nacimiento");
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Nif).HasColumnName("NIF");
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("Nombre Completo");
            entity.Property(e => e.Nombres)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NroDoc).HasColumnName("Nro Doc");
            entity.Property(e => e.Origen)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Sexo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Tipo Documento");
        });

        modelBuilder.Entity<PersonasExtra>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PersonasExtras", "crm");

            entity.Property(e => e.CantidadDeHijos).HasColumnName("Cantidad de Hijos");
            entity.Property(e => e.CantidadDePersonasQueIntegranElHogar).HasColumnName("Cantidad de personas que integran el hogar");
            entity.Property(e => e.Cumpleaños).HasColumnType("datetime");
            entity.Property(e => e.DestinoDelCrédito)
                .HasMaxLength(100)
                .HasColumnName("Destino del crédito");
            entity.Property(e => e.DocTipo).HasMaxLength(100);
            entity.Property(e => e.EstadoCivil)
                .HasMaxLength(4000)
                .HasColumnName("Estado civil");
            entity.Property(e => e.MontoEstimado).HasColumnName("Monto Estimado");
            entity.Property(e => e.NivelDeEducación)
                .HasMaxLength(4000)
                .HasColumnName("Nivel de educación");
            entity.Property(e => e.OtrosIngresos).HasColumnName("Otros ingresos");
            entity.Property(e => e.PropietarioDeVehículo)
                .HasMaxLength(4000)
                .HasColumnName("Propietario de vehículo");
            entity.Property(e => e.TeléfonoMóvil)
                .HasMaxLength(53)
                .HasColumnName("Teléfono móvil");
            entity.Property(e => e.TipoDeIngreso)
                .HasMaxLength(150)
                .HasColumnName("Tipo de Ingreso");
        });

        modelBuilder.Entity<PhoneCall>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PhoneCall", "crm");

            entity.HasIndex(e => new { e.PnetContactId, e.PnetOfferValueId }, "PhoneCall-20210108-IDX");

            entity.HasIndex(e => e.ActivityId, "PhoneCall-20210112-IDs");

            entity.Property(e => e.ActualEnd).HasColumnType("datetime");
            entity.Property(e => e.ActualStart).HasColumnType("datetime");
            entity.Property(e => e.Category).HasMaxLength(250);
            entity.Property(e => e.CreatedByName).HasMaxLength(200);
            entity.Property(e => e.CreatedByYomiName).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreatedOnBehalfByName).HasMaxLength(200);
            entity.Property(e => e.CreatedOnBehalfByYomiName).HasMaxLength(200);
            entity.Property(e => e.ExchangeRate).HasColumnType("numeric(23, 10)");
            entity.Property(e => e.LastOnHoldTime).HasColumnType("datetime");
            entity.Property(e => e.ModifiedByName).HasMaxLength(200);
            entity.Property(e => e.ModifiedByYomiName).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOnBehalfByName).HasMaxLength(200);
            entity.Property(e => e.ModifiedOnBehalfByYomiName).HasMaxLength(200);
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.OwnerIdName).HasMaxLength(160);
            entity.Property(e => e.OwnerIdYomiName).HasMaxLength(160);
            entity.Property(e => e.PhoneNumber).HasMaxLength(200);
            entity.Property(e => e.PnetAgreement).HasColumnName("pnet_Agreement");
            entity.Property(e => e.PnetAmountRange).HasColumnName("pnet_AmountRange");
            entity.Property(e => e.PnetBusinessUnit).HasColumnName("pnet_BusinessUnit");
            entity.Property(e => e.PnetBusinessUnitName)
                .HasMaxLength(160)
                .HasColumnName("pnet_BusinessUnitName");
            entity.Property(e => e.PnetBuyingPropension).HasColumnName("pnet_BuyingPropension");
            entity.Property(e => e.PnetCommercialBackgroundId).HasColumnName("pnet_CommercialBackgroundId");
            entity.Property(e => e.PnetCommercialBackgroundIdName)
                .HasMaxLength(100)
                .HasColumnName("pnet_CommercialBackgroundIdName");
            entity.Property(e => e.PnetContactId).HasColumnName("pnet_ContactId");
            entity.Property(e => e.PnetContactIdName)
                .HasMaxLength(160)
                .HasColumnName("pnet_ContactIdName");
            entity.Property(e => e.PnetContactIdYomiName)
                .HasMaxLength(450)
                .HasColumnName("pnet_ContactIdYomiName");
            entity.Property(e => e.PnetCreditAmount).HasColumnName("pnet_CreditAmount");
            entity.Property(e => e.PnetCreditAmountCampaign).HasColumnName("pnet_CreditAmountCampaign");
            entity.Property(e => e.PnetCreditDestination).HasColumnName("pnet_CreditDestination");
            entity.Property(e => e.PnetCreditTypification)
                .HasMaxLength(3)
                .HasColumnName("pnet_CreditTypification");
            entity.Property(e => e.PnetDocumentNumber).HasColumnName("pnet_DocumentNumber");
            entity.Property(e => e.PnetDocumentType).HasColumnName("pnet_DocumentType");
            entity.Property(e => e.PnetFechafin)
                .HasColumnType("datetime")
                .HasColumnName("pnet_fechafin");
            entity.Property(e => e.PnetFechainicio)
                .HasColumnType("datetime")
                .HasColumnName("pnet_fechainicio");
            entity.Property(e => e.PnetFlagTopic).HasColumnName("pnet_FlagTopic");
            entity.Property(e => e.PnetIncomingTypes1).HasColumnName("pnet_IncomingTypes1");
            entity.Property(e => e.PnetIncomingTypes2).HasColumnName("pnet_IncomingTypes2");
            entity.Property(e => e.PnetInteractionStatus).HasColumnName("pnet_InteractionStatus");
            entity.Property(e => e.PnetInteractionStatusName)
                .HasMaxLength(100)
                .HasColumnName("pnet_InteractionStatusName");
            entity.Property(e => e.PnetInteractionSubStatus).HasColumnName("pnet_InteractionSubStatus");
            entity.Property(e => e.PnetInteractionSubStatusName)
                .HasMaxLength(100)
                .HasColumnName("pnet_InteractionSubStatusName");
            entity.Property(e => e.PnetInterestRate).HasColumnName("pnet_InterestRate");
            entity.Property(e => e.PnetInterestRateAnual).HasColumnName("pnet_InterestRateAnual");
            entity.Property(e => e.PnetLeadId).HasColumnName("pnet_LeadId");
            entity.Property(e => e.PnetLeadIdName)
                .HasMaxLength(160)
                .HasColumnName("pnet_LeadIdName");
            entity.Property(e => e.PnetLeadIdYomiName)
                .HasMaxLength(450)
                .HasColumnName("pnet_LeadIdYomiName");
            entity.Property(e => e.PnetNegativeFolderBaseId).HasColumnName("pnet_NegativeFolderBaseId");
            entity.Property(e => e.PnetNegativeFolderBaseIdName)
                .HasMaxLength(100)
                .HasColumnName("pnet_NegativeFolderBaseIdName");
            entity.Property(e => e.PnetNpa).HasColumnName("pnet_NPA");
            entity.Property(e => e.PnetNpb).HasColumnName("pnet_NPB");
            entity.Property(e => e.PnetNpc).HasColumnName("pnet_NPC");
            entity.Property(e => e.PnetNpd).HasColumnName("pnet_NPD");
            entity.Property(e => e.PnetOfertaValorIndividualId).HasColumnName("pnet_OfertaValorIndividualId");
            entity.Property(e => e.PnetOfertaValorIndividualIdName)
                .HasMaxLength(300)
                .HasColumnName("pnet_OfertaValorIndividualIdName");
            entity.Property(e => e.PnetOfferValueCreditAmount).HasColumnName("pnet_OfferValueCreditAmount");
            entity.Property(e => e.PnetOfferValueId).HasColumnName("pnet_OfferValueId");
            entity.Property(e => e.PnetOfferValueIdName)
                .HasMaxLength(300)
                .HasColumnName("pnet_OfferValueIdName");
            entity.Property(e => e.PnetOfferValueQuotaAmount).HasColumnName("pnet_OfferValueQuotaAmount");
            entity.Property(e => e.PnetOutgoingTypes1).HasColumnName("pnet_OutgoingTypes1");
            entity.Property(e => e.PnetOutgoingTypes2).HasColumnName("pnet_OutgoingTypes2");
            entity.Property(e => e.PnetPa).HasColumnName("pnet_PA");
            entity.Property(e => e.PnetPb).HasColumnName("pnet_PB");
            entity.Property(e => e.PnetPc).HasColumnName("pnet_PC");
            entity.Property(e => e.PnetPd).HasColumnName("pnet_PD");
            entity.Property(e => e.PnetPe).HasColumnName("pnet_pe");
            entity.Property(e => e.PnetPf).HasColumnName("pnet_pf");
            entity.Property(e => e.PnetPg).HasColumnName("pnet_pg");
            entity.Property(e => e.PnetQuotaValue).HasColumnName("pnet_QuotaValue");
            entity.Property(e => e.PnetQuotasNumber).HasColumnName("pnet_QuotasNumber");
            entity.Property(e => e.PnetRate).HasColumnName("pnet_Rate");
            entity.Property(e => e.PnetRb).HasColumnName("pnet_RB");
            entity.Property(e => e.PnetRc).HasColumnName("pnet_RC");
            entity.Property(e => e.PnetRd).HasColumnName("pnet_RD");
            entity.Property(e => e.PnetReschedulePending)
                .HasColumnType("datetime")
                .HasColumnName("pnet_ReschedulePending");
            entity.Property(e => e.PnetSaa).HasColumnName("pnet_SAA");
            entity.Property(e => e.PnetSaleStatus).HasColumnName("pnet_SaleStatus");
            entity.Property(e => e.PnetSaleStatusName)
                .HasMaxLength(100)
                .HasColumnName("pnet_SaleStatusName");
            entity.Property(e => e.PnetSaleSubStatus).HasColumnName("pnet_SaleSubStatus");
            entity.Property(e => e.PnetSaleSubStatusName)
                .HasMaxLength(100)
                .HasColumnName("pnet_SaleSubStatusName");
            entity.Property(e => e.PnetSchema).HasColumnName("pnet_Schema");
            entity.Property(e => e.PnetSetValuesInterestRate).HasColumnName("pnet_SetValuesInterestRate");
            entity.Property(e => e.PnetStartBusinessActivity)
                .HasColumnType("datetime")
                .HasColumnName("pnet_StartBusinessActivity");
            entity.Property(e => e.PnetTeamDirectionFor).HasColumnName("pnet_TeamDirectionFor");
            entity.Property(e => e.PnetTeamDirectionForName)
                .HasMaxLength(160)
                .HasColumnName("pnet_TeamDirectionForName");
            entity.Property(e => e.PnetTeamDirectionForYomiName)
                .HasMaxLength(160)
                .HasColumnName("pnet_TeamDirectionForYomiName");
            entity.Property(e => e.PnetTermRanges).HasColumnName("pnet_TermRanges");
            entity.Property(e => e.PnetUserDirectionFor).HasColumnName("pnet_UserDirectionFor");
            entity.Property(e => e.PnetUserDirectionForName)
                .HasMaxLength(200)
                .HasColumnName("pnet_UserDirectionForName");
            entity.Property(e => e.PnetUserDirectionForYomiName)
                .HasMaxLength(200)
                .HasColumnName("pnet_UserDirectionForYomiName");
            entity.Property(e => e.RegardingObjectIdName).HasMaxLength(4000);
            entity.Property(e => e.RegardingObjectIdYomiName).HasMaxLength(4000);
            entity.Property(e => e.ScheduledEnd).HasColumnType("datetime");
            entity.Property(e => e.ScheduledStart).HasColumnType("datetime");
            entity.Property(e => e.Slaid).HasColumnName("SLAId");
            entity.Property(e => e.SlainvokedId).HasColumnName("SLAInvokedId");
            entity.Property(e => e.SlainvokedIdName)
                .HasMaxLength(160)
                .HasColumnName("SLAInvokedIdName");
            entity.Property(e => e.Slaname)
                .HasMaxLength(160)
                .HasColumnName("SLAName");
            entity.Property(e => e.SortDate).HasColumnType("datetime");
            entity.Property(e => e.Subcategory).HasMaxLength(250);
            entity.Property(e => e.Subject).HasMaxLength(200);
            entity.Property(e => e.TransactionCurrencyIdName).HasMaxLength(100);
            entity.Property(e => e.TraversedPath).HasMaxLength(1250);
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<PnetAccountbpba>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pnet_accountbpba", "crm");

            entity.Property(e => e.CreatedByName).HasMaxLength(200);
            entity.Property(e => e.CreatedByYomiName).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreatedOnBehalfByName).HasMaxLength(200);
            entity.Property(e => e.CreatedOnBehalfByYomiName).HasMaxLength(200);
            entity.Property(e => e.ModifiedByName).HasMaxLength(200);
            entity.Property(e => e.ModifiedByYomiName).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOnBehalfByName).HasMaxLength(200);
            entity.Property(e => e.ModifiedOnBehalfByYomiName).HasMaxLength(200);
            entity.Property(e => e.OrganizationIdName).HasMaxLength(160);
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PnetAccountNumber)
                .HasMaxLength(100)
                .HasColumnName("pnet_AccountNumber");
            entity.Property(e => e.PnetAccountbpbaId).HasColumnName("pnet_accountbpbaId");
            entity.Property(e => e.PnetBalanceCa)
                .HasMaxLength(100)
                .HasColumnName("pnet_BalanceCA");
            entity.Property(e => e.PnetCbu)
                .HasMaxLength(100)
                .HasColumnName("pnet_CBU");
            entity.Property(e => e.PnetContactId).HasColumnName("pnet_ContactId");
            entity.Property(e => e.PnetContactIdName)
                .HasMaxLength(160)
                .HasColumnName("pnet_ContactIdName");
            entity.Property(e => e.PnetContactIdYomiName)
                .HasMaxLength(450)
                .HasColumnName("pnet_ContactIdYomiName");
            entity.Property(e => e.PnetName)
                .HasMaxLength(100)
                .HasColumnName("pnet_name");
            entity.Property(e => e.PnetNic)
                .HasMaxLength(10)
                .HasColumnName("pnet_NIC");
            entity.Property(e => e.PnetNip)
                .HasMaxLength(10)
                .HasColumnName("pnet_NIP");
            entity.Property(e => e.PnetProductState)
                .HasMaxLength(100)
                .HasColumnName("pnet_ProductState");
            entity.Property(e => e.PnetProductStateCode)
                .HasMaxLength(100)
                .HasColumnName("pnet_ProductStateCode");
            entity.Property(e => e.PnetProductTypeCode)
                .HasMaxLength(100)
                .HasColumnName("pnet_ProductTypeCode");
            entity.Property(e => e.PnetProductTypeId).HasColumnName("pnet_ProductTypeId");
            entity.Property(e => e.PnetProductTypeIdName)
                .HasMaxLength(137)
                .HasColumnName("pnet_ProductTypeIdName");
            entity.Property(e => e.PnetSuc)
                .HasMaxLength(10)
                .HasColumnName("pnet_SUC");
            entity.Property(e => e.Statecode).HasColumnName("statecode");
            entity.Property(e => e.Statuscode).HasColumnName("statuscode");
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<PnetAddressBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pnet_addressBase", "crm");

            entity.HasIndex(e => e.PnetContactId, "idx-pnet_addressBase-01");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PnetAddress)
                .HasMaxLength(100)
                .HasColumnName("pnet_Address");
            entity.Property(e => e.PnetAddressId).HasColumnName("pnet_addressId");
            entity.Property(e => e.PnetAddressNumber)
                .HasMaxLength(100)
                .HasColumnName("pnet_AddressNumber");
            entity.Property(e => e.PnetAddressNumberTo)
                .HasMaxLength(100)
                .HasColumnName("pnet_AddressNumberTo");
            entity.Property(e => e.PnetAddressType)
                .HasMaxLength(100)
                .HasColumnName("pnet_AddressType");
            entity.Property(e => e.PnetAddressTypeCode).HasColumnName("pnet_AddressTypeCode");
            entity.Property(e => e.PnetBpbaAddressId)
                .HasMaxLength(100)
                .HasColumnName("pnet__bpba_AddressId");
            entity.Property(e => e.PnetBpbaPersoninternalnumber)
                .HasMaxLength(100)
                .HasColumnName("pnet_bpba_personinternalnumber");
            entity.Property(e => e.PnetContactId).HasColumnName("pnet_ContactId");
            entity.Property(e => e.PnetCountry)
                .HasMaxLength(100)
                .HasColumnName("pnet_Country");
            entity.Property(e => e.PnetCountryCode)
                .HasMaxLength(100)
                .HasColumnName("pnet_CountryCode");
            entity.Property(e => e.PnetCountryId).HasColumnName("pnet_CountryId");
            entity.Property(e => e.PnetDepartment)
                .HasMaxLength(100)
                .HasColumnName("pnet_Department");
            entity.Property(e => e.PnetDistrictLocality)
                .HasMaxLength(100)
                .HasColumnName("pnet_DistrictLocality");
            entity.Property(e => e.PnetDistrictLocalityCode)
                .HasMaxLength(100)
                .HasColumnName("pnet_DistrictLocalityCode");
            entity.Property(e => e.PnetDistrictLocalityId).HasColumnName("pnet_DistrictLocalityId");
            entity.Property(e => e.PnetFloor)
                .HasMaxLength(100)
                .HasColumnName("pnet_Floor");
            entity.Property(e => e.PnetLeadid).HasColumnName("pnet_Leadid");
            entity.Property(e => e.PnetLinked).HasColumnName("pnet_Linked");
            entity.Property(e => e.PnetName)
                .HasMaxLength(100)
                .HasColumnName("pnet_name");
            entity.Property(e => e.PnetNormalizationscounter)
                .HasMaxLength(100)
                .HasColumnName("pnet_normalizationscounter");
            entity.Property(e => e.PnetNormalized).HasColumnName("pnet_Normalized");
            entity.Property(e => e.PnetPostalCode)
                .HasMaxLength(100)
                .HasColumnName("pnet_PostalCode");
            entity.Property(e => e.PnetProvince)
                .HasMaxLength(100)
                .HasColumnName("pnet_Province");
            entity.Property(e => e.PnetProvincecode).HasColumnName("pnet_provincecode");
            entity.Property(e => e.PnetStartDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_StartDate");
            entity.Property(e => e.PnetTriednormalize).HasColumnName("pnet_triednormalize");
            entity.Property(e => e.Statecode).HasColumnName("statecode");
            entity.Property(e => e.Statuscode).HasColumnName("statuscode");
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<PnetAddressBaseExtranet>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("pnetAddressBaseExtranet", "app");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.PnetAddress)
                .HasMaxLength(100)
                .HasColumnName("pnet_Address");
            entity.Property(e => e.PnetAddressId).HasColumnName("pnet_addressId");
            entity.Property(e => e.PnetAddressNumber)
                .HasMaxLength(100)
                .HasColumnName("pnet_AddressNumber");
            entity.Property(e => e.PnetAddressNumberTo)
                .HasMaxLength(100)
                .HasColumnName("pnet_AddressNumberTo");
            entity.Property(e => e.PnetAddressType)
                .HasMaxLength(100)
                .HasColumnName("pnet_AddressType");
            entity.Property(e => e.PnetAddressTypeCode).HasColumnName("pnet_AddressTypeCode");
            entity.Property(e => e.PnetBpbaAddressId)
                .HasMaxLength(100)
                .HasColumnName("pnet__bpba_AddressId");
            entity.Property(e => e.PnetBpbaPersoninternalnumber)
                .HasMaxLength(100)
                .HasColumnName("pnet_bpba_personinternalnumber");
            entity.Property(e => e.PnetContactId).HasColumnName("pnet_ContactId");
            entity.Property(e => e.PnetDepartment)
                .HasMaxLength(100)
                .HasColumnName("pnet_Department");
            entity.Property(e => e.PnetDistrictLocality)
                .HasMaxLength(100)
                .HasColumnName("pnet_DistrictLocality");
            entity.Property(e => e.PnetDistrictLocalityCode)
                .HasMaxLength(100)
                .HasColumnName("pnet_DistrictLocalityCode");
            entity.Property(e => e.PnetDistrictLocalityId).HasColumnName("pnet_DistrictLocalityId");
            entity.Property(e => e.PnetFloor)
                .HasMaxLength(100)
                .HasColumnName("pnet_Floor");
            entity.Property(e => e.PnetLeadid).HasColumnName("pnet_Leadid");
            entity.Property(e => e.PnetLinked).HasColumnName("pnet_Linked");
            entity.Property(e => e.PnetName)
                .HasMaxLength(100)
                .HasColumnName("pnet_name");
            entity.Property(e => e.PnetNormalizationscounter)
                .HasMaxLength(100)
                .HasColumnName("pnet_normalizationscounter");
            entity.Property(e => e.PnetNormalized).HasColumnName("pnet_Normalized");
            entity.Property(e => e.PnetPostalCode)
                .HasMaxLength(100)
                .HasColumnName("pnet_PostalCode");
            entity.Property(e => e.PnetProvince)
                .HasMaxLength(100)
                .HasColumnName("pnet_Province");
            entity.Property(e => e.PnetProvincecode).HasColumnName("pnet_provincecode");
            entity.Property(e => e.Statecode).HasColumnName("statecode");
            entity.Property(e => e.Statuscode).HasColumnName("statuscode");
        });

        modelBuilder.Entity<PnetAttribution>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pnet_Attributions", "crm");

            entity.Property(e => e.CreatedByName).HasMaxLength(200);
            entity.Property(e => e.CreatedByYomiName).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreatedOnBehalfByName).HasMaxLength(200);
            entity.Property(e => e.CreatedOnBehalfByYomiName).HasMaxLength(200);
            entity.Property(e => e.ModifiedByName).HasMaxLength(200);
            entity.Property(e => e.ModifiedByYomiName).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOnBehalfByName).HasMaxLength(200);
            entity.Property(e => e.ModifiedOnBehalfByYomiName).HasMaxLength(200);
            entity.Property(e => e.OrganizationIdName).HasMaxLength(160);
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PnetAmountRenewal).HasColumnName("pnet_AmountRenewal");
            entity.Property(e => e.PnetAmountUnder).HasColumnName("pnet_AmountUnder");
            entity.Property(e => e.PnetAtribMm25smvm).HasColumnName("pnet_atribMM25smvm");
            entity.Property(e => e.PnetAttributionsId).HasColumnName("pnet_AttributionsId");
            entity.Property(e => e.PnetClass1).HasColumnName("pnet_Class1");
            entity.Property(e => e.PnetCurrentCategory).HasColumnName("pnet_CurrentCategory");
            entity.Property(e => e.PnetExcellentFactorCorrection).HasColumnName("pnet_ExcellentFactorCorrection");
            entity.Property(e => e.PnetExceptionLevel).HasColumnName("pnet_ExceptionLevel");
            entity.Property(e => e.PnetGoodFactorCorrection).HasColumnName("pnet_GoodFactorCorrection");
            entity.Property(e => e.PnetMiniTer).HasColumnName("pnet_MiniTer");
            entity.Property(e => e.PnetMonthPeriod).HasColumnName("pnet_MonthPeriod");
            entity.Property(e => e.PnetName)
                .HasMaxLength(100)
                .HasColumnName("pnet_name");
            entity.Property(e => e.PnetNoExceptionPayFees).HasColumnName("pnet_NoExceptionPayFees");
            entity.Property(e => e.PnetNote).HasColumnName("pnet_Note");
            entity.Property(e => e.PnetPanel).HasColumnName("pnet_Panel");
            entity.Property(e => e.PnetPanelSin).HasColumnName("pnet_PanelSIN");
            entity.Property(e => e.PnetPreviousCategory).HasColumnName("pnet_PreviousCategory");
            entity.Property(e => e.PnetPreviousCategory2).HasColumnName("pnet_PreviousCategory2");
            entity.Property(e => e.PnetProfileCollection).HasColumnName("pnet_ProfileCollection");
            entity.Property(e => e.PnetRegularFactorCorrection).HasColumnName("pnet_RegularFactorCorrection");
            entity.Property(e => e.PnetSimpleMiniter).HasColumnName("pnet_SimpleMiniter");
            entity.Property(e => e.PnetSpecialamountunder).HasColumnName("pnet_specialamountunder");
            entity.Property(e => e.PnetTerD).HasColumnName("pnet_TerD");
            entity.Property(e => e.PnetTotalSuspensionAttributions).HasColumnName("pnet_TotalSuspensionAttributions");
            entity.Property(e => e.PnetUserId).HasColumnName("pnet_UserId");
            entity.Property(e => e.PnetUserIdName)
                .HasMaxLength(200)
                .HasColumnName("pnet_UserIdName");
            entity.Property(e => e.PnetUserIdYomiName)
                .HasMaxLength(200)
                .HasColumnName("pnet_UserIdYomiName");
            entity.Property(e => e.PnetWorkPlanRisk).HasColumnName("pnet_WorkPlanRisk");
            entity.Property(e => e.PnetWorkPlanRiskYes).HasColumnName("pnet_WorkPlanRiskYES");
            entity.Property(e => e.PnetYearPeriod).HasColumnName("pnet_YearPeriod");
            entity.Property(e => e.Statecode).HasColumnName("statecode");
            entity.Property(e => e.Statuscode).HasColumnName("statuscode");
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<PnetBinnaclerecordBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pnet_binnaclerecordBase", "crm");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PnetAccount)
                .HasMaxLength(30)
                .HasColumnName("pnet_account");
            entity.Property(e => e.PnetAccountMaster)
                .HasMaxLength(100)
                .HasColumnName("pnet_AccountMaster");
            entity.Property(e => e.PnetAccountnumber).HasColumnName("pnet_accountnumber");
            entity.Property(e => e.PnetAccountstatus)
                .HasMaxLength(3)
                .HasColumnName("pnet_accountstatus");
            entity.Property(e => e.PnetAccounttype).HasColumnName("pnet_accounttype");
            entity.Property(e => e.PnetAddress).HasColumnName("pnet_address");
            entity.Property(e => e.PnetAvAccountNumber)
                .HasMaxLength(100)
                .HasColumnName("pnet_AV_AccountNumber");
            entity.Property(e => e.PnetAvBranchLoan)
                .HasMaxLength(100)
                .HasColumnName("pnet_AV_BranchLoan");
            entity.Property(e => e.PnetAvProductNumber)
                .HasMaxLength(100)
                .HasColumnName("pnet_AV_ProductNumber");
            entity.Property(e => e.PnetBalance)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_balance");
            entity.Property(e => e.PnetBinnaclerecordId).HasColumnName("pnet_binnaclerecordId");
            entity.Property(e => e.PnetBpbasubsidiary).HasColumnName("pnet_BPBASubsidiary");
            entity.Property(e => e.PnetBranch).HasColumnName("pnet_branch");
            entity.Property(e => e.PnetCal2180).HasColumnName("pnet_cal2180");
            entity.Property(e => e.PnetCardAccumulatedPayments)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_CardAccumulatedPayments");
            entity.Property(e => e.PnetCardDebtBalance)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_CardDebtBalance");
            entity.Property(e => e.PnetCardExpirationDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_CardExpirationDate");
            entity.Property(e => e.PnetCardMinimumAmount)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_CardMinimumAmount");
            entity.Property(e => e.PnetClaimabledebt)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_claimabledebt");
            entity.Property(e => e.PnetComercialExecutiveAssignedId).HasColumnName("pnet_ComercialExecutiveAssignedId");
            entity.Property(e => e.PnetComercialexecutiveassignedtext)
                .HasMaxLength(250)
                .HasColumnName("pnet_comercialexecutiveassignedtext");
            entity.Property(e => e.PnetCommercialExecutiveAdminId).HasColumnName("pnet_CommercialExecutiveAdminId");
            entity.Property(e => e.PnetCommercialExecutiveId).HasColumnName("pnet_CommercialExecutiveId");
            entity.Property(e => e.PnetCommitmentDate).HasColumnName("pnet_CommitmentDate");
            entity.Property(e => e.PnetContactId).HasColumnName("pnet_ContactId");
            entity.Property(e => e.PnetContract).HasColumnName("pnet_contract");
            entity.Property(e => e.PnetCoupondate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_coupondate");
            entity.Property(e => e.PnetCreditId).HasColumnName("pnet_CreditId");
            entity.Property(e => e.PnetCreditSubtype)
                .HasMaxLength(100)
                .HasColumnName("pnet_CreditSubtype");
            entity.Property(e => e.PnetCreditType)
                .HasMaxLength(100)
                .HasColumnName("pnet_CreditType");
            entity.Property(e => e.PnetCumulativepayments)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_cumulativepayments");
            entity.Property(e => e.PnetDebtCover)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_DebtCover");
            entity.Property(e => e.PnetDebtexpirationbalance)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_debtexpirationbalance");
            entity.Property(e => e.PnetDelayDays).HasColumnName("pnet_DelayDays");
            entity.Property(e => e.PnetDeu2180)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_deu2180");
            entity.Property(e => e.PnetDocumentnumber)
                .HasMaxLength(20)
                .HasColumnName("pnet_documentnumber");
            entity.Property(e => e.PnetDocumenttype)
                .HasMaxLength(20)
                .HasColumnName("pnet_documenttype");
            entity.Property(e => e.PnetFec2180)
                .HasMaxLength(10)
                .HasColumnName("pnet_fec2180");
            entity.Property(e => e.PnetFulladdress)
                .HasMaxLength(100)
                .HasColumnName("pnet_fulladdress");
            entity.Property(e => e.PnetGrantdate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_grantdate");
            entity.Property(e => e.PnetGrantedAmount)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_GrantedAmount");
            entity.Property(e => e.PnetHeadquarterCode)
                .HasMaxLength(100)
                .HasColumnName("pnet_HeadquarterCode");
            entity.Property(e => e.PnetHoldername)
                .HasMaxLength(100)
                .HasColumnName("pnet_holdername");
            entity.Property(e => e.PnetLastmovementdate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_lastmovementdate");
            entity.Property(e => e.PnetLastpaymentdate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_lastpaymentdate");
            entity.Property(e => e.PnetLatepaymentdays).HasColumnName("pnet_latepaymentdays");
            entity.Property(e => e.PnetLoanbalance)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_loanbalance");
            entity.Property(e => e.PnetLocality)
                .HasMaxLength(100)
                .HasColumnName("pnet_locality");
            entity.Property(e => e.PnetMinimalduedate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_minimalduedate");
            entity.Property(e => e.PnetMinimalexpirationamount)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_minimalexpirationamount");
            entity.Property(e => e.PnetName)
                .HasMaxLength(100)
                .HasColumnName("pnet_name");
            entity.Property(e => e.PnetNextLiquidationDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_NextLiquidationDate");
            entity.Property(e => e.PnetNextexpirationdate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_nextexpirationdate");
            entity.Property(e => e.PnetNextsettlementdate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_nextsettlementdate");
            entity.Property(e => e.PnetNif)
                .HasMaxLength(100)
                .HasColumnName("pnet_nif");
            entity.Property(e => e.PnetOpeningDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_OpeningDate");
            entity.Property(e => e.PnetOpportunityId).HasColumnName("pnet_OpportunityId");
            entity.Property(e => e.PnetOpportunityNumber)
                .HasMaxLength(100)
                .HasColumnName("pnet_OpportunityNumber");
            entity.Property(e => e.PnetPaymentAmount)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_PaymentAmount");
            entity.Property(e => e.PnetPaymentDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_PaymentDate");
            entity.Property(e => e.PnetPayments).HasColumnName("pnet_payments");
            entity.Property(e => e.PnetPerson).HasColumnName("pnet_person");
            entity.Property(e => e.PnetPhonenumber)
                .HasMaxLength(100)
                .HasColumnName("pnet_phonenumber");
            entity.Property(e => e.PnetPostalcode)
                .HasMaxLength(8)
                .HasColumnName("pnet_postalcode");
            entity.Property(e => e.PnetProcessdate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_processdate");
            entity.Property(e => e.PnetPromesubsidiary).HasColumnName("pnet_PROMESubsidiary");
            entity.Property(e => e.PnetRate)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_Rate");
            entity.Property(e => e.PnetSit2180)
                .HasMaxLength(8)
                .HasColumnName("pnet_sit2180");
            entity.Property(e => e.PnetSitoperation)
                .HasMaxLength(3)
                .HasColumnName("pnet_sitoperation");
            entity.Property(e => e.PnetSittar).HasColumnName("pnet_sittar");
            entity.Property(e => e.PnetSubsidiaryName)
                .HasMaxLength(100)
                .HasColumnName("pnet_SubsidiaryName");
            entity.Property(e => e.PnetTerm).HasColumnName("pnet_Term");
            entity.Property(e => e.PnetZone)
                .HasMaxLength(100)
                .HasColumnName("pnet_Zone");
            entity.Property(e => e.PnetZoneId).HasColumnName("pnet_ZoneId");
            entity.Property(e => e.Statecode).HasColumnName("statecode");
            entity.Property(e => e.Statuscode).HasColumnName("statuscode");
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<PnetCnaeBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pnet_CnaeBase", "crm");

            entity.HasIndex(e => e.PnetCode, "IDX-pnet_CnaeBase-Code");

            entity.HasIndex(e => e.PnetCnaeId, "IDX-pnet_CnaeBase-ID");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PnetCnaeId).HasColumnName("pnet_CnaeId");
            entity.Property(e => e.PnetCode).HasColumnName("pnet_Code");
            entity.Property(e => e.PnetName)
                .HasMaxLength(102)
                .HasColumnName("pnet_name");
            entity.Property(e => e.PnetValue).HasColumnName("pnet_Value");
            entity.Property(e => e.Statecode).HasColumnName("statecode");
            entity.Property(e => e.Statuscode).HasColumnName("statuscode");
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<PnetCnoBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pnet_CnoBase", "crm");

            entity.HasIndex(e => new { e.PnetCnoId, e.PnetCnocode }, "pnet_CnoBase-IDX-ind");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PnetCnoId).HasColumnName("pnet_CnoId");
            entity.Property(e => e.PnetCnocode).HasColumnName("pnet_CNOCode");
            entity.Property(e => e.PnetName)
                .HasMaxLength(100)
                .HasColumnName("pnet_name");
            entity.Property(e => e.Statecode).HasColumnName("statecode");
            entity.Property(e => e.Statuscode).HasColumnName("statuscode");
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<PnetCollectionManagementBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pnet_CollectionManagementBase", "crm");

            entity.HasIndex(e => e.PnetCollectionManagementId, "CollectionManagementBase-20210108-IDX");

            entity.HasIndex(e => e.PnetCollectionsManagementId, "pnet_CollectionManagementBase_IDX2");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PnetCollectionManagementId).HasColumnName("pnet_CollectionManagementId");
            entity.Property(e => e.PnetCollectionsManagementId).HasColumnName("pnet_CollectionsManagementId");
            entity.Property(e => e.PnetManagementStatus).HasColumnName("pnet_ManagementStatus");
            entity.Property(e => e.PnetName)
                .HasMaxLength(100)
                .HasColumnName("pnet_name");
            entity.Property(e => e.PnetObservations).HasColumnName("pnet_Observations");
            entity.Property(e => e.PnetTypification).HasColumnName("pnet_Typification");
            entity.Property(e => e.Statecode).HasColumnName("statecode");
            entity.Property(e => e.Statuscode).HasColumnName("statuscode");
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<PnetCollectionsource>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pnet_collectionsources", "crm");

            entity.Property(e => e.CreatedByName).HasMaxLength(200);
            entity.Property(e => e.CreatedByYomiName).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreatedOnBehalfByName).HasMaxLength(200);
            entity.Property(e => e.CreatedOnBehalfByYomiName).HasMaxLength(200);
            entity.Property(e => e.ModifiedByName).HasMaxLength(200);
            entity.Property(e => e.ModifiedByYomiName).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOnBehalfByName).HasMaxLength(200);
            entity.Property(e => e.ModifiedOnBehalfByYomiName).HasMaxLength(200);
            entity.Property(e => e.OrganizationIdName).HasMaxLength(160);
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PnetAddress)
                .HasMaxLength(100)
                .HasColumnName("pnet_Address");
            entity.Property(e => e.PnetAreaCode1)
                .HasMaxLength(7)
                .HasColumnName("pnet_AreaCode1");
            entity.Property(e => e.PnetAreaCode2)
                .HasMaxLength(7)
                .HasColumnName("pnet_AreaCode2");
            entity.Property(e => e.PnetCollectionsourcesId).HasColumnName("pnet_collectionsourcesId");
            entity.Property(e => e.PnetComments).HasColumnName("pnet_Comments");
            entity.Property(e => e.PnetConnection).HasColumnName("pnet_Connection");
            entity.Property(e => e.PnetConsolidateMobilePhone)
                .HasMaxLength(100)
                .HasColumnName("pnet_ConsolidateMobilePhone");
            entity.Property(e => e.PnetConsolidatePhone)
                .HasMaxLength(100)
                .HasColumnName("pnet_ConsolidatePhone");
            entity.Property(e => e.PnetContactName).HasColumnName("pnet_ContactName");
            entity.Property(e => e.PnetContactNameName)
                .HasMaxLength(160)
                .HasColumnName("pnet_ContactNameName");
            entity.Property(e => e.PnetContactNameYomiName)
                .HasMaxLength(450)
                .HasColumnName("pnet_ContactNameYomiName");
            entity.Property(e => e.PnetFamily).HasColumnName("pnet_Family");
            entity.Property(e => e.PnetFullName)
                .HasMaxLength(100)
                .HasColumnName("pnet_FullName");
            entity.Property(e => e.PnetMobilePhone)
                .HasMaxLength(100)
                .HasColumnName("pnet_MobilePhone");
            entity.Property(e => e.PnetName)
                .HasMaxLength(100)
                .HasColumnName("pnet_name");
            entity.Property(e => e.PnetPhone)
                .HasMaxLength(100)
                .HasColumnName("pnet_Phone");
            entity.Property(e => e.PnetPrincipalContactId).HasColumnName("pnet_PrincipalContactId");
            entity.Property(e => e.PnetPrincipalContactIdName)
                .HasMaxLength(160)
                .HasColumnName("pnet_PrincipalContactIdName");
            entity.Property(e => e.PnetPrincipalContactIdYomiName)
                .HasMaxLength(450)
                .HasColumnName("pnet_PrincipalContactIdYomiName");
            entity.Property(e => e.PnetRelationship).HasColumnName("pnet_Relationship");
            entity.Property(e => e.PnetRelationshipRole).HasColumnName("pnet_RelationshipRole");
            entity.Property(e => e.PnetRelationshipRoleName)
                .HasMaxLength(100)
                .HasColumnName("pnet_RelationshipRoleName");
            entity.Property(e => e.Statecode).HasColumnName("statecode");
            entity.Property(e => e.Statuscode).HasColumnName("statuscode");
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<PnetCommercialbackground>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pnet_commercialbackground", "crm");

            entity.HasIndex(e => e.PnetCommercialbackgroundId, "pnet_commercialbackground-20210108-IDX");

            entity.Property(e => e.CreatedByName).HasMaxLength(200);
            entity.Property(e => e.CreatedByYomiName).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreatedOnBehalfByName).HasMaxLength(200);
            entity.Property(e => e.CreatedOnBehalfByYomiName).HasMaxLength(200);
            entity.Property(e => e.ModifiedByName).HasMaxLength(200);
            entity.Property(e => e.ModifiedByYomiName).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOnBehalfByName).HasMaxLength(200);
            entity.Property(e => e.ModifiedOnBehalfByYomiName).HasMaxLength(200);
            entity.Property(e => e.OrganizationIdName).HasMaxLength(160);
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PnetArbaconsultationDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_ARBAConsultationDate");
            entity.Property(e => e.PnetArbaconsultationDateR1)
                .HasColumnType("datetime")
                .HasColumnName("pnet_ARBAConsultationDateR1");
            entity.Property(e => e.PnetArbaconsultationDateR2)
                .HasColumnType("datetime")
                .HasColumnName("pnet_ARBAConsultationDateR2");
            entity.Property(e => e.PnetArbaconsultationDateR3)
                .HasColumnType("datetime")
                .HasColumnName("pnet_ARBAConsultationDateR3");
            entity.Property(e => e.PnetArbaconsultationDateR4)
                .HasColumnType("datetime")
                .HasColumnName("pnet_ARBAConsultationDateR4");
            entity.Property(e => e.PnetArbaprincipalContact).HasColumnName("pnet_ARBAPrincipalContact");
            entity.Property(e => e.PnetArbarelatedContact1).HasColumnName("pnet_ARBARelatedContact1");
            entity.Property(e => e.PnetArbarelatedContact2).HasColumnName("pnet_ARBARelatedContact2");
            entity.Property(e => e.PnetArbarelatedContact3).HasColumnName("pnet_ARBARelatedContact3");
            entity.Property(e => e.PnetArbarelatedContact4).HasColumnName("pnet_ARBARelatedContact4");
            entity.Property(e => e.PnetBcraconsultationDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_BCRAConsultationDate");
            entity.Property(e => e.PnetBcraconsultationDateR1)
                .HasColumnType("datetime")
                .HasColumnName("pnet_BCRAConsultationDateR1");
            entity.Property(e => e.PnetBcraconsultationDateR2)
                .HasColumnType("datetime")
                .HasColumnName("pnet_BCRAConsultationDateR2");
            entity.Property(e => e.PnetBcraconsultationDateR3)
                .HasColumnType("datetime")
                .HasColumnName("pnet_BCRAConsultationDateR3");
            entity.Property(e => e.PnetBcraconsultationDateR4)
                .HasColumnType("datetime")
                .HasColumnName("pnet_BCRAConsultationDateR4");
            entity.Property(e => e.PnetBcraprincipalContact).HasColumnName("pnet_BCRAPrincipalContact");
            entity.Property(e => e.PnetBcrarelatedContact1).HasColumnName("pnet_BCRARelatedContact1");
            entity.Property(e => e.PnetBcrarelatedContact2).HasColumnName("pnet_BCRARelatedContact2");
            entity.Property(e => e.PnetBcrarelatedContact3).HasColumnName("pnet_BCRARelatedContact3");
            entity.Property(e => e.PnetBcrarelatedContact4).HasColumnName("pnet_BCRARelatedContact4");
            entity.Property(e => e.PnetBpbaclean1).HasColumnName("pnet_BPBAClean1");
            entity.Property(e => e.PnetBpbaclean10).HasColumnName("pnet_BPBAClean10");
            entity.Property(e => e.PnetBpbaclean10R1).HasColumnName("pnet_BPBAClean10R1");
            entity.Property(e => e.PnetBpbaclean10R2).HasColumnName("pnet_BPBAClean10R2");
            entity.Property(e => e.PnetBpbaclean10R3).HasColumnName("pnet_BPBAClean10R3");
            entity.Property(e => e.PnetBpbaclean10R4).HasColumnName("pnet_BPBAClean10R4");
            entity.Property(e => e.PnetBpbaclean11).HasColumnName("pnet_BPBAClean11");
            entity.Property(e => e.PnetBpbaclean11R1).HasColumnName("pnet_BPBAClean11R1");
            entity.Property(e => e.PnetBpbaclean11R2).HasColumnName("pnet_BPBAClean11R2");
            entity.Property(e => e.PnetBpbaclean11R3).HasColumnName("pnet_BPBAClean11R3");
            entity.Property(e => e.PnetBpbaclean11R4).HasColumnName("pnet_BPBAClean11R4");
            entity.Property(e => e.PnetBpbaclean1R1).HasColumnName("pnet_BPBAClean1R1");
            entity.Property(e => e.PnetBpbaclean1R2).HasColumnName("pnet_BPBAClean1R2");
            entity.Property(e => e.PnetBpbaclean1R3).HasColumnName("pnet_BPBAClean1R3");
            entity.Property(e => e.PnetBpbaclean1R4).HasColumnName("pnet_BPBAClean1R4");
            entity.Property(e => e.PnetBpbaclean2).HasColumnName("pnet_BPBAClean2");
            entity.Property(e => e.PnetBpbaclean2R1).HasColumnName("pnet_BPBAClean2R1");
            entity.Property(e => e.PnetBpbaclean2R2).HasColumnName("pnet_BPBAClean2R2");
            entity.Property(e => e.PnetBpbaclean2R3).HasColumnName("pnet_BPBAClean2R3");
            entity.Property(e => e.PnetBpbaclean2R4).HasColumnName("pnet_BPBAClean2R4");
            entity.Property(e => e.PnetBpbaclean3).HasColumnName("pnet_BPBAClean3");
            entity.Property(e => e.PnetBpbaclean3R1).HasColumnName("pnet_BPBAClean3R1");
            entity.Property(e => e.PnetBpbaclean3R2).HasColumnName("pnet_BPBAClean3R2");
            entity.Property(e => e.PnetBpbaclean3R3).HasColumnName("pnet_BPBAClean3R3");
            entity.Property(e => e.PnetBpbaclean3R4).HasColumnName("pnet_BPBAClean3R4");
            entity.Property(e => e.PnetBpbaclean4).HasColumnName("pnet_BPBAClean4");
            entity.Property(e => e.PnetBpbaclean4R1).HasColumnName("pnet_BPBAClean4R1");
            entity.Property(e => e.PnetBpbaclean4R2).HasColumnName("pnet_BPBAClean4R2");
            entity.Property(e => e.PnetBpbaclean4R3).HasColumnName("pnet_BPBAClean4R3");
            entity.Property(e => e.PnetBpbaclean4R4).HasColumnName("pnet_BPBAClean4R4");
            entity.Property(e => e.PnetBpbaclean5).HasColumnName("pnet_BPBAClean5");
            entity.Property(e => e.PnetBpbaclean5R1).HasColumnName("pnet_BPBAClean5R1");
            entity.Property(e => e.PnetBpbaclean5R2).HasColumnName("pnet_BPBAClean5R2");
            entity.Property(e => e.PnetBpbaclean5R3).HasColumnName("pnet_BPBAClean5R3");
            entity.Property(e => e.PnetBpbaclean5R4).HasColumnName("pnet_BPBAClean5R4");
            entity.Property(e => e.PnetBpbaclean6).HasColumnName("pnet_BPBAClean6");
            entity.Property(e => e.PnetBpbaclean6R1).HasColumnName("pnet_BPBAClean6R1");
            entity.Property(e => e.PnetBpbaclean6R2).HasColumnName("pnet_BPBAClean6R2");
            entity.Property(e => e.PnetBpbaclean6R3).HasColumnName("pnet_BPBAClean6R3");
            entity.Property(e => e.PnetBpbaclean6R4).HasColumnName("pnet_BPBAClean6R4");
            entity.Property(e => e.PnetBpbaclean7).HasColumnName("pnet_BPBAClean7");
            entity.Property(e => e.PnetBpbaclean7R1).HasColumnName("pnet_BPBAClean7R1");
            entity.Property(e => e.PnetBpbaclean7R2).HasColumnName("pnet_BPBAClean7R2");
            entity.Property(e => e.PnetBpbaclean7R3).HasColumnName("pnet_BPBAClean7R3");
            entity.Property(e => e.PnetBpbaclean7R4).HasColumnName("pnet_BPBAClean7R4");
            entity.Property(e => e.PnetBpbaclean8).HasColumnName("pnet_BPBAClean8");
            entity.Property(e => e.PnetBpbaclean8R1).HasColumnName("pnet_BPBAClean8R1");
            entity.Property(e => e.PnetBpbaclean8R2).HasColumnName("pnet_BPBAClean8R2");
            entity.Property(e => e.PnetBpbaclean8R3).HasColumnName("pnet_BPBAClean8R3");
            entity.Property(e => e.PnetBpbaclean8R4).HasColumnName("pnet_BPBAClean8R4");
            entity.Property(e => e.PnetBpbaclean9).HasColumnName("pnet_BPBAClean9");
            entity.Property(e => e.PnetBpbaclean9R1).HasColumnName("pnet_BPBAClean9R1");
            entity.Property(e => e.PnetBpbaclean9R2).HasColumnName("pnet_BPBAClean9R2");
            entity.Property(e => e.PnetBpbaclean9R3).HasColumnName("pnet_BPBAClean9R3");
            entity.Property(e => e.PnetBpbaclean9R4).HasColumnName("pnet_BPBAClean9R4");
            entity.Property(e => e.PnetBpbaconsultationDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_BPBAConsultationDate");
            entity.Property(e => e.PnetBpbaconsultationDateR1)
                .HasColumnType("datetime")
                .HasColumnName("pnet_BPBAConsultationDateR1");
            entity.Property(e => e.PnetBpbaconsultationDateR2)
                .HasColumnType("datetime")
                .HasColumnName("pnet_BPBAConsultationDateR2");
            entity.Property(e => e.PnetBpbaconsultationDateR3)
                .HasColumnType("datetime")
                .HasColumnName("pnet_BPBAConsultationDateR3");
            entity.Property(e => e.PnetBpbaconsultationDateR4)
                .HasColumnType("datetime")
                .HasColumnName("pnet_BPBAConsultationDateR4");
            entity.Property(e => e.PnetBpbaprovider1)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider1");
            entity.Property(e => e.PnetBpbaprovider10)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider10");
            entity.Property(e => e.PnetBpbaprovider10R1)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider10R1");
            entity.Property(e => e.PnetBpbaprovider10R2)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider10R2");
            entity.Property(e => e.PnetBpbaprovider10R3)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider10R3");
            entity.Property(e => e.PnetBpbaprovider10R4)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider10R4");
            entity.Property(e => e.PnetBpbaprovider11)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider11");
            entity.Property(e => e.PnetBpbaprovider11R1)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider11R1");
            entity.Property(e => e.PnetBpbaprovider11R2)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider11R2");
            entity.Property(e => e.PnetBpbaprovider11R3)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider11R3");
            entity.Property(e => e.PnetBpbaprovider11R4)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider11R4");
            entity.Property(e => e.PnetBpbaprovider1R1)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider1R1");
            entity.Property(e => e.PnetBpbaprovider1R2)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider1R2");
            entity.Property(e => e.PnetBpbaprovider1R3)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider1R3");
            entity.Property(e => e.PnetBpbaprovider1R4)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider1R4");
            entity.Property(e => e.PnetBpbaprovider2)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider2");
            entity.Property(e => e.PnetBpbaprovider2R1)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider2R1");
            entity.Property(e => e.PnetBpbaprovider2R2)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider2R2");
            entity.Property(e => e.PnetBpbaprovider2R3)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider2R3");
            entity.Property(e => e.PnetBpbaprovider2R4)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider2R4");
            entity.Property(e => e.PnetBpbaprovider3)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider3");
            entity.Property(e => e.PnetBpbaprovider3R1)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider3R1");
            entity.Property(e => e.PnetBpbaprovider3R2)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider3R2");
            entity.Property(e => e.PnetBpbaprovider3R3)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider3R3");
            entity.Property(e => e.PnetBpbaprovider3R4)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider3R4");
            entity.Property(e => e.PnetBpbaprovider4)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider4");
            entity.Property(e => e.PnetBpbaprovider4R1)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider4R1");
            entity.Property(e => e.PnetBpbaprovider4R2)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider4R2");
            entity.Property(e => e.PnetBpbaprovider4R3)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider4R3");
            entity.Property(e => e.PnetBpbaprovider4R4)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider4R4");
            entity.Property(e => e.PnetBpbaprovider5)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider5");
            entity.Property(e => e.PnetBpbaprovider5R1)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider5R1");
            entity.Property(e => e.PnetBpbaprovider5R2)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider5R2");
            entity.Property(e => e.PnetBpbaprovider5R3)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider5R3");
            entity.Property(e => e.PnetBpbaprovider5R4)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider5R4");
            entity.Property(e => e.PnetBpbaprovider6)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider6");
            entity.Property(e => e.PnetBpbaprovider6R1)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider6R1");
            entity.Property(e => e.PnetBpbaprovider6R2)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider6R2");
            entity.Property(e => e.PnetBpbaprovider6R3)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider6R3");
            entity.Property(e => e.PnetBpbaprovider6R4)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider6R4");
            entity.Property(e => e.PnetBpbaprovider7)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider7");
            entity.Property(e => e.PnetBpbaprovider7R1)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider7R1");
            entity.Property(e => e.PnetBpbaprovider7R2)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider7R2");
            entity.Property(e => e.PnetBpbaprovider7R3)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider7R3");
            entity.Property(e => e.PnetBpbaprovider7R4)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider7R4");
            entity.Property(e => e.PnetBpbaprovider8)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider8");
            entity.Property(e => e.PnetBpbaprovider8R1)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider8R1");
            entity.Property(e => e.PnetBpbaprovider8R2)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider8R2");
            entity.Property(e => e.PnetBpbaprovider8R3)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider8R3");
            entity.Property(e => e.PnetBpbaprovider8R4)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider8R4");
            entity.Property(e => e.PnetBpbaprovider9)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider9");
            entity.Property(e => e.PnetBpbaprovider9R1)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider9R1");
            entity.Property(e => e.PnetBpbaprovider9R2)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider9R2");
            entity.Property(e => e.PnetBpbaprovider9R3)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider9R3");
            entity.Property(e => e.PnetBpbaprovider9R4)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAProvider9R4");
            entity.Property(e => e.PnetBpbarelatedContact1).HasColumnName("pnet_BPBARelatedContact1");
            entity.Property(e => e.PnetBpbarelatedContact2).HasColumnName("pnet_BPBARelatedContact2");
            entity.Property(e => e.PnetBpbarelatedContact3).HasColumnName("pnet_BPBARelatedContact3");
            entity.Property(e => e.PnetBpbarelatedContact4).HasColumnName("pnet_BPBARelatedContact4");
            entity.Property(e => e.PnetBpbaresult1).HasColumnName("pnet_BPBAResult1");
            entity.Property(e => e.PnetBpbaresult10).HasColumnName("pnet_BPBAResult10");
            entity.Property(e => e.PnetBpbaresult11).HasColumnName("pnet_BPBAResult11");
            entity.Property(e => e.PnetBpbaresult2).HasColumnName("pnet_BPBAResult2");
            entity.Property(e => e.PnetBpbaresult3).HasColumnName("pnet_BPBAResult3");
            entity.Property(e => e.PnetBpbaresult4).HasColumnName("pnet_BPBAResult4");
            entity.Property(e => e.PnetBpbaresult5).HasColumnName("pnet_BPBAResult5");
            entity.Property(e => e.PnetBpbaresult6).HasColumnName("pnet_BPBAResult6");
            entity.Property(e => e.PnetBpbaresult7).HasColumnName("pnet_BPBAResult7");
            entity.Property(e => e.PnetBpbaresult8).HasColumnName("pnet_BPBAResult8");
            entity.Property(e => e.PnetBpbaresult9).HasColumnName("pnet_BPBAResult9");
            entity.Property(e => e.PnetBpbaresults10R1).HasColumnName("pnet_BPBAResults10R1");
            entity.Property(e => e.PnetBpbaresults10R2).HasColumnName("pnet_BPBAResults10R2");
            entity.Property(e => e.PnetBpbaresults10R3).HasColumnName("pnet_BPBAResults10R3");
            entity.Property(e => e.PnetBpbaresults10R4).HasColumnName("pnet_BPBAResults10R4");
            entity.Property(e => e.PnetBpbaresults11R1).HasColumnName("pnet_BPBAResults11R1");
            entity.Property(e => e.PnetBpbaresults11R2).HasColumnName("pnet_BPBAResults11R2");
            entity.Property(e => e.PnetBpbaresults11R3).HasColumnName("pnet_BPBAResults11R3");
            entity.Property(e => e.PnetBpbaresults11R4).HasColumnName("pnet_BPBAResults11R4");
            entity.Property(e => e.PnetBpbaresults1R1).HasColumnName("pnet_BPBAResults1R1");
            entity.Property(e => e.PnetBpbaresults1R2).HasColumnName("pnet_BPBAResults1R2");
            entity.Property(e => e.PnetBpbaresults1R3).HasColumnName("pnet_BPBAResults1R3");
            entity.Property(e => e.PnetBpbaresults1R4).HasColumnName("pnet_BPBAResults1R4");
            entity.Property(e => e.PnetBpbaresults2R1).HasColumnName("pnet_BPBAResults2R1");
            entity.Property(e => e.PnetBpbaresults2R2).HasColumnName("pnet_BPBAResults2R2");
            entity.Property(e => e.PnetBpbaresults2R3).HasColumnName("pnet_BPBAResults2R3");
            entity.Property(e => e.PnetBpbaresults2R4).HasColumnName("pnet_BPBAResults2R4");
            entity.Property(e => e.PnetBpbaresults3R1).HasColumnName("pnet_BPBAResults3R1");
            entity.Property(e => e.PnetBpbaresults3R2).HasColumnName("pnet_BPBAResults3R2");
            entity.Property(e => e.PnetBpbaresults3R3).HasColumnName("pnet_BPBAResults3R3");
            entity.Property(e => e.PnetBpbaresults3R4).HasColumnName("pnet_BPBAResults3R4");
            entity.Property(e => e.PnetBpbaresults4R1).HasColumnName("pnet_BPBAResults4R1");
            entity.Property(e => e.PnetBpbaresults4R2).HasColumnName("pnet_BPBAResults4R2");
            entity.Property(e => e.PnetBpbaresults4R3).HasColumnName("pnet_BPBAResults4R3");
            entity.Property(e => e.PnetBpbaresults4R4).HasColumnName("pnet_BPBAResults4R4");
            entity.Property(e => e.PnetBpbaresults5R1).HasColumnName("pnet_BPBAResults5R1");
            entity.Property(e => e.PnetBpbaresults5R2).HasColumnName("pnet_BPBAResults5R2");
            entity.Property(e => e.PnetBpbaresults5R3).HasColumnName("pnet_BPBAResults5R3");
            entity.Property(e => e.PnetBpbaresults5R4).HasColumnName("pnet_BPBAResults5R4");
            entity.Property(e => e.PnetBpbaresults6R1).HasColumnName("pnet_BPBAResults6R1");
            entity.Property(e => e.PnetBpbaresults6R2).HasColumnName("pnet_BPBAResults6R2");
            entity.Property(e => e.PnetBpbaresults6R3).HasColumnName("pnet_BPBAResults6R3");
            entity.Property(e => e.PnetBpbaresults6R4).HasColumnName("pnet_BPBAResults6R4");
            entity.Property(e => e.PnetBpbaresults7R1).HasColumnName("pnet_BPBAResults7R1");
            entity.Property(e => e.PnetBpbaresults7R2).HasColumnName("pnet_BPBAResults7R2");
            entity.Property(e => e.PnetBpbaresults7R3).HasColumnName("pnet_BPBAResults7R3");
            entity.Property(e => e.PnetBpbaresults7R4).HasColumnName("pnet_BPBAResults7R4");
            entity.Property(e => e.PnetBpbaresults8R1).HasColumnName("pnet_BPBAResults8R1");
            entity.Property(e => e.PnetBpbaresults8R2).HasColumnName("pnet_BPBAResults8R2");
            entity.Property(e => e.PnetBpbaresults8R3).HasColumnName("pnet_BPBAResults8R3");
            entity.Property(e => e.PnetBpbaresults8R4).HasColumnName("pnet_BPBAResults8R4");
            entity.Property(e => e.PnetBpbaresults9R1).HasColumnName("pnet_BPBAResults9R1");
            entity.Property(e => e.PnetBpbaresults9R2).HasColumnName("pnet_BPBAResults9R2");
            entity.Property(e => e.PnetBpbaresults9R3).HasColumnName("pnet_BPBAResults9R3");
            entity.Property(e => e.PnetBpbaresults9R4).HasColumnName("pnet_BPBAResults9R4");
            entity.Property(e => e.PnetBusinessHistoryBpbarefresh).HasColumnName("pnet_BusinessHistoryBPBARefresh");
            entity.Property(e => e.PnetClassification).HasColumnName("pnet_Classification");
            entity.Property(e => e.PnetCode)
                .HasMaxLength(100)
                .HasColumnName("pnet_code");
            entity.Property(e => e.PnetCodeWf)
                .HasMaxLength(100)
                .HasColumnName("pnet_CodeWF");
            entity.Property(e => e.PnetCommercialbackgroundId).HasColumnName("pnet_commercialbackgroundId");
            entity.Property(e => e.PnetCounterId).HasColumnName("pnet_CounterId");
            entity.Property(e => e.PnetCounterIdName)
                .HasMaxLength(100)
                .HasColumnName("pnet_CounterIdName");
            entity.Property(e => e.PnetCuitpart1).HasColumnName("pnet_cuitpart1");
            entity.Property(e => e.PnetCuitpart1R1).HasColumnName("pnet_CUITPart1R1");
            entity.Property(e => e.PnetCuitpart1R2).HasColumnName("pnet_CUITPart1R2");
            entity.Property(e => e.PnetCuitpart1R3).HasColumnName("pnet_CUITPart1R3");
            entity.Property(e => e.PnetCuitpart2).HasColumnName("pnet_cuitpart2");
            entity.Property(e => e.PnetCuitpart2R1).HasColumnName("pnet_CUITPart2R1");
            entity.Property(e => e.PnetCuitpart2R2).HasColumnName("pnet_CUITPart2R2");
            entity.Property(e => e.PnetCuitpart2R3).HasColumnName("pnet_CUITPart2R3");
            entity.Property(e => e.PnetCuitpart3).HasColumnName("pnet_cuitpart3");
            entity.Property(e => e.PnetCuitpart3R1).HasColumnName("pnet_CUITPart3R1");
            entity.Property(e => e.PnetCuitpart3R2).HasColumnName("pnet_CUITPart3R2");
            entity.Property(e => e.PnetCuitpart3R3).HasColumnName("pnet_CUITPart3R3");
            entity.Property(e => e.PnetCuitpart4R1).HasColumnName("pnet_CUITPart4R1");
            entity.Property(e => e.PnetCuitpart4R2).HasColumnName("pnet_CUITPart4R2");
            entity.Property(e => e.PnetCuitpart4R3).HasColumnName("pnet_CUITPart4R3");
            entity.Property(e => e.PnetDocumenturl)
                .HasMaxLength(500)
                .HasColumnName("pnet_documenturl");
            entity.Property(e => e.PnetFullCuit)
                .HasMaxLength(11)
                .HasColumnName("pnet_full_cuit");
            entity.Property(e => e.PnetFullCuitr1)
                .HasMaxLength(11)
                .HasColumnName("pnet_FullCUITR1");
            entity.Property(e => e.PnetFullCuitr2)
                .HasMaxLength(100)
                .HasColumnName("pnet_FullCUITR2");
            entity.Property(e => e.PnetFullCuitr3)
                .HasMaxLength(11)
                .HasColumnName("pnet_FullCUITR3");
            entity.Property(e => e.PnetFullCuitr4)
                .HasMaxLength(11)
                .HasColumnName("pnet_FullCUITR4");
            entity.Property(e => e.PnetGetCreditWellnessInformation)
                .HasMaxLength(200)
                .HasColumnName("pnet_GetCreditWellnessInformation");
            entity.Property(e => e.PnetLeadId).HasColumnName("pnet_LeadId");
            entity.Property(e => e.PnetLeadIdName)
                .HasMaxLength(160)
                .HasColumnName("pnet_LeadIdName");
            entity.Property(e => e.PnetLeadIdYomiName)
                .HasMaxLength(450)
                .HasColumnName("pnet_LeadIdYomiName");
            entity.Property(e => e.PnetPrincipalContact).HasColumnName("pnet_PrincipalContact");
            entity.Property(e => e.PnetPrincipalContactName)
                .HasMaxLength(160)
                .HasColumnName("pnet_PrincipalContactName");
            entity.Property(e => e.PnetPrincipalContactYomiName)
                .HasMaxLength(450)
                .HasColumnName("pnet_PrincipalContactYomiName");
            entity.Property(e => e.PnetRelatedContact1).HasColumnName("pnet_RelatedContact1");
            entity.Property(e => e.PnetRelatedContact1Name)
                .HasMaxLength(160)
                .HasColumnName("pnet_RelatedContact1Name");
            entity.Property(e => e.PnetRelatedContact1YomiName)
                .HasMaxLength(450)
                .HasColumnName("pnet_RelatedContact1YomiName");
            entity.Property(e => e.PnetRelatedContact2).HasColumnName("pnet_RelatedContact2");
            entity.Property(e => e.PnetRelatedContact2Name)
                .HasMaxLength(160)
                .HasColumnName("pnet_RelatedContact2Name");
            entity.Property(e => e.PnetRelatedContact2YomiName)
                .HasMaxLength(450)
                .HasColumnName("pnet_RelatedContact2YomiName");
            entity.Property(e => e.PnetRelatedContact3).HasColumnName("pnet_RelatedContact3");
            entity.Property(e => e.PnetRelatedContact3Name)
                .HasMaxLength(160)
                .HasColumnName("pnet_RelatedContact3Name");
            entity.Property(e => e.PnetRelatedContact3YomiName)
                .HasMaxLength(450)
                .HasColumnName("pnet_RelatedContact3YomiName");
            entity.Property(e => e.PnetRelatedContact4).HasColumnName("pnet_RelatedContact4");
            entity.Property(e => e.PnetRelatedContact4Name)
                .HasMaxLength(160)
                .HasColumnName("pnet_RelatedContact4Name");
            entity.Property(e => e.PnetRelatedContact4YomiName)
                .HasMaxLength(450)
                .HasColumnName("pnet_RelatedContact4YomiName");
            entity.Property(e => e.PnetToDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_ToDate");
            entity.Property(e => e.PnetUrlGetDateTime)
                .HasMaxLength(200)
                .HasColumnName("pnet_URL_GetDateTime");
            entity.Property(e => e.PnetVerazConsultationDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_VerazConsultationDate");
            entity.Property(e => e.PnetVerazConsultationDateR1)
                .HasColumnType("datetime")
                .HasColumnName("pnet_VerazConsultationDateR1");
            entity.Property(e => e.PnetVerazConsultationDateR2)
                .HasColumnType("datetime")
                .HasColumnName("pnet_VerazConsultationDateR2");
            entity.Property(e => e.PnetVerazConsultationDateR3)
                .HasColumnType("datetime")
                .HasColumnName("pnet_VerazConsultationDateR3");
            entity.Property(e => e.PnetVerazConsultationDateR4)
                .HasColumnType("datetime")
                .HasColumnName("pnet_VerazConsultationDateR4");
            entity.Property(e => e.PnetVerazPrincipalContact).HasColumnName("pnet_VerazPrincipalContact");
            entity.Property(e => e.PnetVerazRelatedContact1).HasColumnName("pnet_VerazRelatedContact1");
            entity.Property(e => e.PnetVerazRelatedContact2).HasColumnName("pnet_VerazRelatedContact2");
            entity.Property(e => e.PnetVerazRelatedContact3).HasColumnName("pnet_VerazRelatedContact3");
            entity.Property(e => e.PnetVerazRelatedContact4).HasColumnName("pnet_VerazRelatedContact4");
            entity.Property(e => e.PnetWfcreated).HasColumnName("pnet_WFCreated");
            entity.Property(e => e.Statecode).HasColumnName("statecode");
            entity.Property(e => e.Statuscode).HasColumnName("statuscode");
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<PnetConveniosdecredito>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pnet_conveniosdecreditos", "crm");

            entity.Property(e => e.CreatedByName).HasMaxLength(200);
            entity.Property(e => e.CreatedByYomiName).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreatedOnBehalfByName).HasMaxLength(200);
            entity.Property(e => e.CreatedOnBehalfByYomiName).HasMaxLength(200);
            entity.Property(e => e.ModifiedByName).HasMaxLength(200);
            entity.Property(e => e.ModifiedByYomiName).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOnBehalfByName).HasMaxLength(200);
            entity.Property(e => e.ModifiedOnBehalfByYomiName).HasMaxLength(200);
            entity.Property(e => e.OrganizationIdName).HasMaxLength(160);
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PnetAcuerdo).HasColumnName("pnet_acuerdo");
            entity.Property(e => e.PnetCodigodedestino).HasColumnName("pnet_codigodedestino");
            entity.Property(e => e.PnetConveniosdecreditosId).HasColumnName("pnet_conveniosdecreditosId");
            entity.Property(e => e.PnetDescripciondelproducto).HasColumnName("pnet_descripciondelproducto");
            entity.Property(e => e.PnetDestinodelcredito).HasColumnName("pnet_destinodelcredito");
            entity.Property(e => e.PnetEvaluationprocess).HasColumnName("pnet_evaluationprocess");
            entity.Property(e => e.PnetEvaluationprocessName)
                .HasMaxLength(100)
                .HasColumnName("pnet_evaluationprocessName");
            entity.Property(e => e.PnetLineadecredito).HasColumnName("pnet_lineadecredito");
            entity.Property(e => e.PnetLineadecreditoName)
                .HasMaxLength(4000)
                .HasColumnName("pnet_lineadecreditoName");
            entity.Property(e => e.PnetMindeproduccion).HasColumnName("pnet_mindeproduccion");
            entity.Property(e => e.PnetModalidad).HasColumnName("pnet_modalidad");
            entity.Property(e => e.PnetMontomaximo).HasColumnName("pnet_montomaximo");
            entity.Property(e => e.PnetMontominimo).HasColumnName("pnet_montominimo");
            entity.Property(e => e.PnetName)
                .HasMaxLength(100)
                .HasColumnName("pnet_name");
            entity.Property(e => e.PnetPeriodicidadamortizacion).HasColumnName("pnet_periodicidadamortizacion");
            entity.Property(e => e.PnetPeriodicidaddeinteres).HasColumnName("pnet_periodicidaddeinteres");
            entity.Property(e => e.PnetPeriododegracia).HasColumnName("pnet_periododegracia");
            entity.Property(e => e.PnetPlazomaximoenmeses).HasColumnName("pnet_plazomaximoenmeses");
            entity.Property(e => e.PnetPlazominimoenmeses).HasColumnName("pnet_plazominimoenmeses");
            entity.Property(e => e.PnetProducto).HasColumnName("pnet_producto");
            entity.Property(e => e.PnetRequiereaprobacion).HasColumnName("pnet_requiereaprobacion");
            entity.Property(e => e.PnetSistemadeamortizacion).HasColumnName("pnet_sistemadeamortizacion");
            entity.Property(e => e.PnetTasa).HasColumnName("pnet_tasa");
            entity.Property(e => e.Statecode).HasColumnName("statecode");
            entity.Property(e => e.Statuscode).HasColumnName("statuscode");
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<PnetCreditBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pnet_CreditBase", "crm");

            entity.HasIndex(e => e.PnetOpportunityNumber, "IDX_crmPnet_CreditBase_on");

            entity.HasIndex(e => e.PnetOpportunityId, "IDX_pnetCreditBase_01");

            entity.HasIndex(e => new { e.PnetCreditId, e.PnetCommitmentDate, e.PnetCommercialExecutiveAdminId, e.PnetCommercialExecutiveId, e.PnetAssignedExecutiveId }, "pnet_CreditBase-20201201-ids");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PnetAccepted).HasColumnName("pnet_Accepted");
            entity.Property(e => e.PnetAssignedExecutiveId).HasColumnName("pnet_AssignedExecutiveId");
            entity.Property(e => e.PnetAssignedExecutiveText).HasColumnName("pnet_AssignedExecutiveText");
            entity.Property(e => e.PnetCommercialExecutiveAdminId).HasColumnName("pnet_CommercialExecutiveAdminId");
            entity.Property(e => e.PnetCommercialExecutiveId).HasColumnName("pnet_CommercialExecutiveId");
            entity.Property(e => e.PnetCommitmentDate).HasColumnName("pnet_CommitmentDate");
            entity.Property(e => e.PnetContactId).HasColumnName("pnet_ContactId");
            entity.Property(e => e.PnetCreditId).HasColumnName("pnet_CreditId");
            entity.Property(e => e.PnetHeadquarterCode)
                .HasMaxLength(100)
                .HasColumnName("pnet_HeadquarterCode");
            entity.Property(e => e.PnetName)
                .HasMaxLength(100)
                .HasColumnName("pnet_name");
            entity.Property(e => e.PnetNif)
                .HasMaxLength(100)
                .HasColumnName("pnet_NIF");
            entity.Property(e => e.PnetOpportunityId).HasColumnName("pnet_OpportunityId");
            entity.Property(e => e.PnetOpportunityNumber)
                .HasMaxLength(100)
                .HasColumnName("pnet_OpportunityNumber");
            entity.Property(e => e.PnetOverdue).HasColumnName("pnet_Overdue");
            entity.Property(e => e.PnetState).HasColumnName("pnet_State");
            entity.Property(e => e.PnetZoneId).HasColumnName("pnet_ZoneId");
            entity.Property(e => e.Statecode).HasColumnName("statecode");
            entity.Property(e => e.Statuscode).HasColumnName("statuscode");
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<PnetDistrictLocality>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pnet_DistrictLocality", "crm");

            entity.HasIndex(e => e.PnetDistrictLocalityId, "pnet_DistrictLocality-20210121-IDX");

            entity.Property(e => e.CreatedByName).HasMaxLength(200);
            entity.Property(e => e.CreatedByYomiName).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreatedOnBehalfByName).HasMaxLength(200);
            entity.Property(e => e.CreatedOnBehalfByYomiName).HasMaxLength(200);
            entity.Property(e => e.ModifiedByName).HasMaxLength(200);
            entity.Property(e => e.ModifiedByYomiName).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOnBehalfByName).HasMaxLength(200);
            entity.Property(e => e.ModifiedOnBehalfByYomiName).HasMaxLength(200);
            entity.Property(e => e.OrganizationIdName).HasMaxLength(160);
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PnetCode)
                .HasMaxLength(100)
                .HasColumnName("pnet_Code");
            entity.Property(e => e.PnetDistrict)
                .HasMaxLength(100)
                .HasColumnName("pnet_District");
            entity.Property(e => e.PnetDistrictLocalityId).HasColumnName("pnet_DistrictLocalityId");
            entity.Property(e => e.PnetName)
                .HasMaxLength(100)
                .HasColumnName("pnet_name");
            entity.Property(e => e.PnetNumberZone).HasColumnName("pnet_NumberZone");
            entity.Property(e => e.PnetProvince).HasColumnName("pnet_Province");
            entity.Property(e => e.PnetSubsidiaryId).HasColumnName("pnet_SubsidiaryId");
            entity.Property(e => e.PnetSubsidiaryIdName)
                .HasMaxLength(160)
                .HasColumnName("pnet_SubsidiaryIdName");
            entity.Property(e => e.PnetSubsidiaryIdYomiName)
                .HasMaxLength(160)
                .HasColumnName("pnet_SubsidiaryIdYomiName");
            entity.Property(e => e.PnetZone)
                .HasMaxLength(100)
                .HasColumnName("pnet_Zone");
            entity.Property(e => e.Statecode).HasColumnName("statecode");
            entity.Property(e => e.Statuscode).HasColumnName("statuscode");
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<PnetDistrictLocalityBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pnet_DistrictLocalityBase", "crm");

            entity.HasIndex(e => e.PnetDistrictLocalityId, "pnet_DistrictLocalityBase-20210108-IDX");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PnetCode)
                .HasMaxLength(100)
                .HasColumnName("pnet_Code");
            entity.Property(e => e.PnetDistrict)
                .HasMaxLength(100)
                .HasColumnName("pnet_District");
            entity.Property(e => e.PnetDistrictLocalityId).HasColumnName("pnet_DistrictLocalityId");
            entity.Property(e => e.PnetName)
                .HasMaxLength(100)
                .HasColumnName("pnet_name");
            entity.Property(e => e.PnetNumberZone).HasColumnName("pnet_NumberZone");
            entity.Property(e => e.PnetProvince).HasColumnName("pnet_Province");
            entity.Property(e => e.PnetSubsidiaryId).HasColumnName("pnet_SubsidiaryId");
            entity.Property(e => e.PnetZone)
                .HasMaxLength(100)
                .HasColumnName("pnet_Zone");
            entity.Property(e => e.Statecode).HasColumnName("statecode");
            entity.Property(e => e.Statuscode).HasColumnName("statuscode");
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<PnetInstance>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pnet_Instances", "crm");

            entity.HasIndex(e => e.PnetInstancesId, "pnet_Instances-20210108-IDX");

            entity.Property(e => e.CreatedByName).HasMaxLength(200);
            entity.Property(e => e.CreatedByYomiName).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreatedOnBehalfByName).HasMaxLength(200);
            entity.Property(e => e.CreatedOnBehalfByYomiName).HasMaxLength(200);
            entity.Property(e => e.ModifiedByName).HasMaxLength(200);
            entity.Property(e => e.ModifiedByYomiName).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOnBehalfByName).HasMaxLength(200);
            entity.Property(e => e.ModifiedOnBehalfByYomiName).HasMaxLength(200);
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.OwnerIdName).HasMaxLength(160);
            entity.Property(e => e.OwnerIdYomiName).HasMaxLength(160);
            entity.Property(e => e.PnetAnswers).HasColumnName("pnet_Answers");
            entity.Property(e => e.PnetAssessImpeccability).HasColumnName("pnet_AssessImpeccability");
            entity.Property(e => e.PnetComment).HasColumnName("pnet_Comment");
            entity.Property(e => e.PnetConsultations)
                .HasMaxLength(100)
                .HasColumnName("pnet_Consultations");
            entity.Property(e => e.PnetCreditAmount).HasColumnName("pnet_CreditAmount");
            entity.Property(e => e.PnetDateProcessed)
                .HasColumnType("datetime")
                .HasColumnName("pnet_DateProcessed");
            entity.Property(e => e.PnetInstancesId).HasColumnName("pnet_InstancesId");
            entity.Property(e => e.PnetInterestRate).HasColumnName("pnet_InterestRate");
            entity.Property(e => e.PnetName)
                .HasMaxLength(100)
                .HasColumnName("pnet_name");
            entity.Property(e => e.PnetObservations)
                .HasMaxLength(100)
                .HasColumnName("pnet_Observations");
            entity.Property(e => e.PnetPreviousState)
                .HasMaxLength(100)
                .HasColumnName("pnet_PreviousState");
            entity.Property(e => e.PnetQuotasNumber).HasColumnName("pnet_QuotasNumber");
            entity.Property(e => e.PnetRejectedOrigin).HasColumnName("pnet_RejectedOrigin");
            entity.Property(e => e.PnetRequestId).HasColumnName("pnet_RequestId");
            entity.Property(e => e.PnetRequestIdName)
                .HasMaxLength(300)
                .HasColumnName("pnet_RequestIdName");
            entity.Property(e => e.PnetResponse)
                .HasMaxLength(100)
                .HasColumnName("pnet_Response");
            entity.Property(e => e.PnetResultState)
                .HasMaxLength(100)
                .HasColumnName("pnet_ResultState");
            entity.Property(e => e.PnetSendBy).HasColumnName("pnet_SendBy");
            entity.Property(e => e.PnetSendByName)
                .HasMaxLength(200)
                .HasColumnName("pnet_SendByName");
            entity.Property(e => e.PnetSendByYomiName)
                .HasMaxLength(200)
                .HasColumnName("pnet_SendByYomiName");
            entity.Property(e => e.Statecode).HasColumnName("statecode");
            entity.Property(e => e.Statuscode).HasColumnName("statuscode");
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<PnetInstancesBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pnet_InstancesBase", "crm");

            entity.HasIndex(e => new { e.CreatedBy, e.PnetName, e.PnetPreviousState }, "pnet_InstancesBase-20201125-idx");

            entity.HasIndex(e => e.PnetInstancesId, "pnet_InstancesBase-20210112-IDs").IsDescending();

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PnetAnswers).HasColumnName("pnet_Answers");
            entity.Property(e => e.PnetAssessImpeccability).HasColumnName("pnet_AssessImpeccability");
            entity.Property(e => e.PnetComment).HasColumnName("pnet_Comment");
            entity.Property(e => e.PnetConsultations)
                .HasMaxLength(100)
                .HasColumnName("pnet_Consultations");
            entity.Property(e => e.PnetCreditAmount).HasColumnName("pnet_CreditAmount");
            entity.Property(e => e.PnetDateProcessed)
                .HasColumnType("datetime")
                .HasColumnName("pnet_DateProcessed");
            entity.Property(e => e.PnetInstancesId).HasColumnName("pnet_InstancesId");
            entity.Property(e => e.PnetInterestRate).HasColumnName("pnet_InterestRate");
            entity.Property(e => e.PnetName)
                .HasMaxLength(100)
                .HasColumnName("pnet_name");
            entity.Property(e => e.PnetObservations)
                .HasMaxLength(100)
                .HasColumnName("pnet_Observations");
            entity.Property(e => e.PnetPreviousState)
                .HasMaxLength(100)
                .HasColumnName("pnet_PreviousState");
            entity.Property(e => e.PnetQuotasNumber).HasColumnName("pnet_QuotasNumber");
            entity.Property(e => e.PnetRejectedOrigin).HasColumnName("pnet_RejectedOrigin");
            entity.Property(e => e.PnetRequestId).HasColumnName("pnet_RequestId");
            entity.Property(e => e.PnetResponse)
                .HasMaxLength(100)
                .HasColumnName("pnet_Response");
            entity.Property(e => e.PnetResultState)
                .HasMaxLength(100)
                .HasColumnName("pnet_ResultState");
            entity.Property(e => e.PnetSendBy).HasColumnName("pnet_SendBy");
            entity.Property(e => e.Statecode).HasColumnName("statecode");
            entity.Property(e => e.Statuscode).HasColumnName("statuscode");
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<PnetListmembersBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pnet_listmembersBase", "crm");

            entity.HasIndex(e => e.PnetListmembersId, "ClusteredIndex-20201003-pnet_listmembersBase")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PnetBusinessUnit).HasColumnName("pnet_BusinessUnit");
            entity.Property(e => e.PnetBuyingPropensity).HasColumnName("pnet_BuyingPropensity");
            entity.Property(e => e.PnetCampaignId).HasColumnName("pnet_CampaignId");
            entity.Property(e => e.PnetCreditAmount).HasColumnName("pnet_CreditAmount");
            entity.Property(e => e.PnetCreditSubType).HasColumnName("pnet_CreditSubType");
            entity.Property(e => e.PnetCustomerId).HasColumnName("pnet_CustomerId");
            entity.Property(e => e.PnetDocumentNumber).HasColumnName("pnet_DocumentNumber");
            entity.Property(e => e.PnetDocumentType).HasColumnName("pnet_DocumentType");
            entity.Property(e => e.PnetFechafin)
                .HasColumnType("datetime")
                .HasColumnName("pnet_fechafin");
            entity.Property(e => e.PnetFechainicio)
                .HasColumnType("datetime")
                .HasColumnName("pnet_fechainicio");
            entity.Property(e => e.PnetLeadId).HasColumnName("pnet_LeadId");
            entity.Property(e => e.PnetListmembersId).HasColumnName("pnet_listmembersId");
            entity.Property(e => e.PnetName)
                .HasMaxLength(300)
                .HasColumnName("pnet_name");
            entity.Property(e => e.PnetOfferValueId).HasColumnName("pnet_OfferValueId");
            entity.Property(e => e.PnetQuotaValue).HasColumnName("pnet_QuotaValue");
            entity.Property(e => e.PnetSegmentId).HasColumnName("pnet_SegmentId");
            entity.Property(e => e.PnetTeam).HasColumnName("pnet_Team");
            entity.Property(e => e.Statecode).HasColumnName("statecode");
            entity.Property(e => e.Statuscode).HasColumnName("statuscode");
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<PnetNegativeFolderBasesBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pnet_NegativeFolderBasesBase", "crm");

            entity.HasIndex(e => new { e.PnetNegativeFolderBasesId, e.PnetSubsidiaryId }, "pnet_NegativeFolderBasesBase-20210108-IDX");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PnetAcmanagement).HasColumnName("pnet_ACManagement");
            entity.Property(e => e.PnetAmountTaxes).HasColumnName("pnet_AmountTaxes");
            entity.Property(e => e.PnetCallCenterManagement).HasColumnName("pnet_CallCenterManagement");
            entity.Property(e => e.PnetClass1).HasColumnName("pnet_Class1");
            entity.Property(e => e.PnetClassification).HasColumnName("pnet_Classification");
            entity.Property(e => e.PnetComments)
                .HasMaxLength(300)
                .HasColumnName("pnet_Comments");
            entity.Property(e => e.PnetComments2).HasColumnName("pnet_Comments2");
            entity.Property(e => e.PnetCommercialBackground).HasColumnName("pnet_CommercialBackground");
            entity.Property(e => e.PnetCompletePd).HasColumnName("pnet_CompletePD");
            entity.Property(e => e.PnetCompletePersonalData).HasColumnName("pnet_CompletePersonalData");
            entity.Property(e => e.PnetCounterId).HasColumnName("pnet_CounterId");
            entity.Property(e => e.PnetEmployeeMonthlySalary).HasColumnName("pnet_EmployeeMonthlySalary");
            entity.Property(e => e.PnetEstimatedamount).HasColumnName("pnet_Estimatedamount");
            entity.Property(e => e.PnetExecutiveResponsibleId).HasColumnName("pnet_ExecutiveResponsibleId");
            entity.Property(e => e.PnetFamilyHelp).HasColumnName("pnet_FamilyHelp");
            entity.Property(e => e.PnetFateCredit)
                .HasMaxLength(100)
                .HasColumnName("pnet_FateCredit");
            entity.Property(e => e.PnetFee).HasColumnName("pnet_Fee");
            entity.Property(e => e.PnetHasEmployees).HasColumnName("pnet_HasEmployees");
            entity.Property(e => e.PnetHaveCreditCard).HasColumnName("pnet_HaveCreditCard");
            entity.Property(e => e.PnetHaveCredits).HasColumnName("pnet_HaveCredits");
            entity.Property(e => e.PnetHaveProductsBp).HasColumnName("pnet_HaveProductsBP");
            entity.Property(e => e.PnetHaveaccountwithotherBank).HasColumnName("pnet_HaveaccountwithotherBank");
            entity.Property(e => e.PnetHaveinsurance).HasColumnName("pnet_Haveinsurance");
            entity.Property(e => e.PnetHowManyEmployees).HasColumnName("pnet_HowManyEmployees");
            entity.Property(e => e.PnetIsMonotributista).HasColumnName("pnet_IsMonotributista");
            entity.Property(e => e.PnetIsRi).HasColumnName("pnet_IsRI");
            entity.Property(e => e.PnetIsStoreOwner).HasColumnName("pnet_IsStoreOwner");
            entity.Property(e => e.PnetItjpg1).HasColumnName("pnet_ITJPG1");
            entity.Property(e => e.PnetItjpg2).HasColumnName("pnet_ITJPG2");
            entity.Property(e => e.PnetItjpg3).HasColumnName("pnet_ITJPG3");
            entity.Property(e => e.PnetMename).HasColumnName("pnet_MEName");
            entity.Property(e => e.PnetMenameContact)
                .HasMaxLength(100)
                .HasColumnName("pnet_MENameContact");
            entity.Property(e => e.PnetMonthlyRent).HasColumnName("pnet_MonthlyRent");
            entity.Property(e => e.PnetMonthlySales).HasColumnName("pnet_MonthlySales");
            entity.Property(e => e.PnetMtjpg1).HasColumnName("pnet_MTJPG1");
            entity.Property(e => e.PnetMtjpg2).HasColumnName("pnet_MTJPG2");
            entity.Property(e => e.PnetMtsjpg1).HasColumnName("pnet_MTSJPG1");
            entity.Property(e => e.PnetName)
                .HasMaxLength(100)
                .HasColumnName("pnet_name");
            entity.Property(e => e.PnetNegativeFolderBasesId).HasColumnName("pnet_NegativeFolderBasesId");
            entity.Property(e => e.PnetNfprincipalApplication)
                .HasMaxLength(100)
                .HasColumnName("pnet_NFPrincipalApplication");
            entity.Property(e => e.PnetOtherIncome).HasColumnName("pnet_OtherIncome");
            entity.Property(e => e.PnetPanelSin).HasColumnName("pnet_PanelSIN");
            entity.Property(e => e.PnetPhoneCallId).HasColumnName("pnet_PhoneCallId");
            entity.Property(e => e.PnetPreInitialInterviewComplete).HasColumnName("pnet_PreInitialInterviewComplete");
            entity.Property(e => e.PnetPreviousCategory).HasColumnName("pnet_PreviousCategory");
            entity.Property(e => e.PnetPrincipalContactId).HasColumnName("pnet_PrincipalContactId");
            entity.Property(e => e.PnetProductType).HasColumnName("pnet_ProductType");
            entity.Property(e => e.PnetReport).HasColumnName("pnet_Report");
            entity.Property(e => e.PnetStatus).HasColumnName("pnet_Status");
            entity.Property(e => e.PnetSubsidiaryId).HasColumnName("pnet_SubsidiaryId");
            entity.Property(e => e.PnetTypeofBank).HasColumnName("pnet_TypeofBank");
            entity.Property(e => e.PnetTypeofCredit)
                .HasMaxLength(100)
                .HasColumnName("pnet_TypeofCredit");
            entity.Property(e => e.PnetTypeofCreditCard).HasColumnName("pnet_TypeofCreditCard");
            entity.Property(e => e.PnetTypeofInsurance)
                .HasMaxLength(100)
                .HasColumnName("pnet_TypeofInsurance");
            entity.Property(e => e.PnetTypeofProductsBp)
                .HasMaxLength(100)
                .HasColumnName("pnet_TypeofProductsBP");
            entity.Property(e => e.PnetUrlreportEi)
                .HasMaxLength(200)
                .HasColumnName("pnet_URLReportEI");
            entity.Property(e => e.PnetUrltemplate)
                .HasMaxLength(200)
                .HasColumnName("pnet_URLTemplate");
            entity.Property(e => e.Statecode).HasColumnName("statecode");
            entity.Property(e => e.Statuscode).HasColumnName("statuscode");
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<PnetParametersBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pnet_ParametersBase", "crm");

            entity.HasIndex(e => e.PnetParametersId, "pnet_ParametersBase-20210201-IDX");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PnetAccmaintcost)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_accmaintcost");
            entity.Property(e => e.PnetAlertMontoCnmb).HasColumnName("pnet_AlertMontoCNMB");
            entity.Property(e => e.PnetAlertMontoRenoMb).HasColumnName("pnet_AlertMontoRenoMB");
            entity.Property(e => e.PnetAlertmontocnmbesp).HasColumnName("pnet_alertmontocnmbesp");
            entity.Property(e => e.PnetAltaPromeVersion).HasColumnName("pnet_AltaPromeVersion");
            entity.Property(e => e.PnetAutomaticcampaignexpiration).HasColumnName("pnet_automaticcampaignexpiration");
            entity.Property(e => e.PnetCallcenterposition).HasColumnName("pnet_callcenterposition");
            entity.Property(e => e.PnetCommercialassistantposition).HasColumnName("pnet_commercialassistantposition");
            entity.Property(e => e.PnetCommercialexecutiveposition).HasColumnName("pnet_commercialexecutiveposition");
            entity.Property(e => e.PnetCostretirement)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_costretirement");
            entity.Property(e => e.PnetDaysToSendOpps).HasColumnName("pnet_DaysToSendOpps");
            entity.Property(e => e.PnetDelaydays).HasColumnName("pnet_delaydays");
            entity.Property(e => e.PnetDummyTonIndex).HasColumnName("pnet_DummyTonIndex");
            entity.Property(e => e.PnetGetAccountMovements)
                .HasMaxLength(300)
                .HasColumnName("pnet_GetAccountMovements");
            entity.Property(e => e.PnetGetLoanHistory)
                .HasMaxLength(300)
                .HasColumnName("pnet_GetLoanHistory");
            entity.Property(e => e.PnetGetProductsByNipProduct)
                .HasMaxLength(300)
                .HasColumnName("pnet_GetProductsByNipProduct");
            entity.Property(e => e.PnetGetispromeaccount)
                .HasMaxLength(250)
                .HasColumnName("pnet_getispromeaccount");
            entity.Property(e => e.PnetGroupFactor).HasColumnName("pnet_GroupFactor");
            entity.Property(e => e.PnetHoursToSendOpps).HasColumnName("pnet_HoursToSendOpps");
            entity.Property(e => e.PnetIndexDomain)
                .HasMaxLength(100)
                .HasColumnName("pnet_IndexDomain");
            entity.Property(e => e.PnetIndexOrganization)
                .HasMaxLength(100)
                .HasColumnName("pnet_IndexOrganization");
            entity.Property(e => e.PnetIndexPassword)
                .HasMaxLength(100)
                .HasColumnName("pnet_IndexPassword");
            entity.Property(e => e.PnetIndexPort)
                .HasMaxLength(100)
                .HasColumnName("pnet_IndexPort");
            entity.Property(e => e.PnetIndexServer)
                .HasMaxLength(100)
                .HasColumnName("pnet_IndexServer");
            entity.Property(e => e.PnetIndexSiteVisit).HasColumnName("pnet_IndexSiteVisit");
            entity.Property(e => e.PnetIndexUser)
                .HasMaxLength(100)
                .HasColumnName("pnet_IndexUser");
            entity.Property(e => e.PnetIndexhttps).HasColumnName("pnet_indexhttps");
            entity.Property(e => e.PnetIndexlog)
                .HasMaxLength(100)
                .HasColumnName("pnet_indexlog");
            entity.Property(e => e.PnetInstanceRole).HasColumnName("pnet_InstanceRole");
            entity.Property(e => e.PnetMaxMontoCnmb).HasColumnName("pnet_MaxMontoCNMB");
            entity.Property(e => e.PnetMaxMontoRenoMb).HasColumnName("pnet_MaxMontoRenoMB");
            entity.Property(e => e.PnetMaximumAmount1).HasColumnName("pnet_MaximumAmount1");
            entity.Property(e => e.PnetMaximumAmount2).HasColumnName("pnet_MaximumAmount2");
            entity.Property(e => e.PnetMaximumAmount3).HasColumnName("pnet_MaximumAmount3");
            entity.Property(e => e.PnetMaximumAmount4).HasColumnName("pnet_MaximumAmount4");
            entity.Property(e => e.PnetMaximumCreditAmount).HasColumnName("pnet_MaximumCreditAmount");
            entity.Property(e => e.PnetMinimunAmountSmvm)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_MinimunAmountSMVM");
            entity.Property(e => e.PnetName)
                .HasMaxLength(100)
                .HasColumnName("pnet_name");
            entity.Property(e => e.PnetNoPreferencialA).HasColumnName("pnet_NoPreferencialA");
            entity.Property(e => e.PnetNoPreferencialB).HasColumnName("pnet_NoPreferencialB");
            entity.Property(e => e.PnetNoPreferencialC).HasColumnName("pnet_NoPreferencialC");
            entity.Property(e => e.PnetNoPreferencialD).HasColumnName("pnet_NoPreferencialD");
            entity.Property(e => e.PnetNopreferenciale).HasColumnName("pnet_nopreferenciale");
            entity.Property(e => e.PnetNormalizationMax).HasColumnName("pnet_normalizationMAX");
            entity.Property(e => e.PnetOpperccomm)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_opperccomm");
            entity.Property(e => e.PnetOpportunityIndex).HasColumnName("pnet_OpportunityIndex");
            entity.Property(e => e.PnetOpportunityUrldoc)
                .HasMaxLength(200)
                .HasColumnName("pnet_OpportunityURLDoc");
            entity.Property(e => e.PnetParametersId).HasColumnName("pnet_ParametersId");
            entity.Property(e => e.PnetPercli)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_percli");
            entity.Property(e => e.PnetPerctaxa)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_perctaxa");
            entity.Property(e => e.PnetPerctaxb)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_perctaxb");
            entity.Property(e => e.PnetPermanency).HasColumnName("pnet_Permanency");
            entity.Property(e => e.PnetPreApprovedAmount1).HasColumnName("pnet_PreApprovedAmount1");
            entity.Property(e => e.PnetPreApprovedAmount2).HasColumnName("pnet_PreApprovedAmount2");
            entity.Property(e => e.PnetPreferencialA).HasColumnName("pnet_PreferencialA");
            entity.Property(e => e.PnetPreferencialB).HasColumnName("pnet_PreferencialB");
            entity.Property(e => e.PnetPreferencialC).HasColumnName("pnet_PreferencialC");
            entity.Property(e => e.PnetPreferencialD).HasColumnName("pnet_PreferencialD");
            entity.Property(e => e.PnetPreferencialf).HasColumnName("pnet_preferencialf");
            entity.Property(e => e.PnetPreferencialg).HasColumnName("pnet_preferencialg");
            entity.Property(e => e.PnetQueryVeraz)
                .HasMaxLength(250)
                .HasColumnName("pnet_QueryVeraz");
            entity.Property(e => e.PnetQuote1).HasColumnName("pnet_Quote1");
            entity.Property(e => e.PnetQuote2).HasColumnName("pnet_Quote2");
            entity.Property(e => e.PnetRecordCommittee)
                .HasMaxLength(100)
                .HasColumnName("pnet_RecordCommittee");
            entity.Property(e => e.PnetRefinancingA).HasColumnName("pnet_RefinancingA");
            entity.Property(e => e.PnetRefinancingB).HasColumnName("pnet_RefinancingB");
            entity.Property(e => e.PnetRefinancingC).HasColumnName("pnet_RefinancingC");
            entity.Property(e => e.PnetRefinancingD).HasColumnName("pnet_RefinancingD");
            entity.Property(e => e.PnetRiskAnalisis)
                .HasMaxLength(100)
                .HasColumnName("pnet_RiskAnalisis");
            entity.Property(e => e.PnetRiskRole).HasColumnName("pnet_RiskRole");
            entity.Property(e => e.PnetSavingsAccountAmount).HasColumnName("pnet_SavingsAccountAmount");
            entity.Property(e => e.PnetSingleAmount).HasColumnName("pnet_SingleAmount");
            entity.Property(e => e.PnetSingleFactor).HasColumnName("pnet_SingleFactor");
            entity.Property(e => e.PnetSmvm).HasColumnName("pnet_SMVM");
            entity.Property(e => e.PnetSpecialamountunder).HasColumnName("pnet_specialamountunder");
            entity.Property(e => e.PnetUccrole).HasColumnName("pnet_UCCRole");
            entity.Property(e => e.PnetUccrrole).HasColumnName("pnet_UCCRRole");
            entity.Property(e => e.PnetUrl01)
                .HasMaxLength(200)
                .HasColumnName("pnet_url01");
            entity.Property(e => e.PnetUrl02)
                .HasMaxLength(200)
                .HasColumnName("pnet_url02");
            entity.Property(e => e.PnetUrl03)
                .HasMaxLength(200)
                .HasColumnName("pnet_url03");
            entity.Property(e => e.PnetUrl04)
                .HasMaxLength(200)
                .HasColumnName("pnet_url04");
            entity.Property(e => e.PnetUrl05)
                .HasMaxLength(200)
                .HasColumnName("pnet_url05");
            entity.Property(e => e.PnetUrl06)
                .HasMaxLength(200)
                .HasColumnName("pnet_url06");
            entity.Property(e => e.PnetUrl07)
                .HasMaxLength(200)
                .HasColumnName("pnet_url07");
            entity.Property(e => e.PnetUrl08)
                .HasMaxLength(200)
                .HasColumnName("pnet_url08");
            entity.Property(e => e.PnetUrl09)
                .HasMaxLength(200)
                .HasColumnName("pnet_url09");
            entity.Property(e => e.PnetUrl1).HasColumnName("pnet_url1");
            entity.Property(e => e.PnetUrl10)
                .HasMaxLength(200)
                .HasColumnName("pnet_url10");
            entity.Property(e => e.PnetUrl11)
                .HasMaxLength(100)
                .HasColumnName("pnet_url11");
            entity.Property(e => e.PnetUrlReportBp0934)
                .HasMaxLength(200)
                .HasColumnName("pnet_urlReportBP0934");
            entity.Property(e => e.PnetUrlaltaDirecciones)
                .HasMaxLength(500)
                .HasColumnName("pnet_URLAltaDirecciones");
            entity.Property(e => e.PnetUrlaltaNip)
                .HasMaxLength(500)
                .HasColumnName("pnet_URLAltaNIP");
            entity.Property(e => e.PnetUrlaltaServiciosInternacionales)
                .HasMaxLength(500)
                .HasColumnName("pnet_URLAltaServiciosInternacionales");
            entity.Property(e => e.PnetUrlaltaTelefonos)
                .HasMaxLength(500)
                .HasColumnName("pnet_URLAltaTelefonos");
            entity.Property(e => e.PnetUrlconsultaNovedades)
                .HasMaxLength(500)
                .HasColumnName("pnet_URLConsultaNovedades");
            entity.Property(e => e.PnetUrlconsultaTelefonos)
                .HasMaxLength(500)
                .HasColumnName("pnet_URLConsultaTelefonos");
            entity.Property(e => e.PnetUrlconsultadeLegajo)
                .HasMaxLength(500)
                .HasColumnName("pnet_URLConsultadeLegajo");
            entity.Property(e => e.PnetUrlcreacionCajadeAhorro)
                .HasMaxLength(500)
                .HasColumnName("pnet_URLCreacionCajadeAhorro");
            entity.Property(e => e.PnetUrlentityMetadata)
                .HasMaxLength(500)
                .HasColumnName("pnet_URLEntityMetadata");
            entity.Property(e => e.PnetUrlenvioaBancoBip)
                .HasMaxLength(500)
                .HasColumnName("pnet_URLEnvioaBancoBIP");
            entity.Property(e => e.PnetUrlesCliente)
                .HasMaxLength(500)
                .HasColumnName("pnet_URLEsCliente");
            entity.Property(e => e.PnetUrlesClienteBip)
                .HasMaxLength(500)
                .HasColumnName("pnet_URLEsClienteBIP");
            entity.Property(e => e.PnetUrlnormalizacion)
                .HasMaxLength(500)
                .HasColumnName("pnet_URLNormalizacion");
            entity.Property(e => e.PnetUrlreporteB510)
                .HasMaxLength(500)
                .HasColumnName("pnet_URLReporteB510");
            entity.Property(e => e.PnetUrlreporteBp730)
                .HasMaxLength(500)
                .HasColumnName("pnet_URLReporteBP730");
            entity.Property(e => e.PnetUrlsincronizarDirecciones)
                .HasMaxLength(500)
                .HasColumnName("pnet_URLSincronizarDirecciones");
            entity.Property(e => e.PnetUrlvincularContacto)
                .HasMaxLength(500)
                .HasColumnName("pnet_URLVincularContacto");
            entity.Property(e => e.PnetXVencimientoCampaginresponse).HasColumnName("pnet_x_vencimiento_campaginresponse");
            entity.Property(e => e.PnetXVencimientoOffervalue).HasColumnName("pnet_x_vencimiento_offervalue");
            entity.Property(e => e.Statecode).HasColumnName("statecode");
            entity.Property(e => e.Statuscode).HasColumnName("statuscode");
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<PnetPortfoliorecordBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pnet_portfoliorecordBase", "crm");

            entity.HasIndex(e => new { e.PnetPortfoliorecordId, e.PnetOpportunityId, e.PnetCreditId }, "pnet_portfoliorecordBase-20210121-IDX");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PnetAccount)
                .HasMaxLength(100)
                .HasColumnName("pnet_Account");
            entity.Property(e => e.PnetAccountnumber).HasColumnName("pnet_accountnumber");
            entity.Property(e => e.PnetAccounttype)
                .HasMaxLength(100)
                .HasColumnName("pnet_accounttype");
            entity.Property(e => e.PnetAddress).HasColumnName("pnet_address");
            entity.Property(e => e.PnetBalance)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_balance");
            entity.Property(e => e.PnetBpbasubsidiary).HasColumnName("pnet_BPBASubsidiary");
            entity.Property(e => e.PnetBranch).HasColumnName("pnet_branch");
            entity.Property(e => e.PnetCardAccumulatedPayments)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_CardAccumulatedPayments");
            entity.Property(e => e.PnetCardDebtBalance)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_CardDebtBalance");
            entity.Property(e => e.PnetCardExpirationDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_CardExpirationDate");
            entity.Property(e => e.PnetCardMinimumAmount)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_CardMinimumAmount");
            entity.Property(e => e.PnetClaimabledebt)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_claimabledebt");
            entity.Property(e => e.PnetClexaccount)
                .HasMaxLength(20)
                .HasColumnName("pnet_clexaccount");
            entity.Property(e => e.PnetCnae).HasColumnName("pnet_cnae");
            entity.Property(e => e.PnetComercialExecutiveAssignedId).HasColumnName("pnet_ComercialExecutiveAssignedId");
            entity.Property(e => e.PnetComercialexecutiveassignedtext)
                .HasMaxLength(200)
                .HasColumnName("pnet_comercialexecutiveassignedtext");
            entity.Property(e => e.PnetCommercialExecutiveAdminId).HasColumnName("pnet_CommercialExecutiveAdminId");
            entity.Property(e => e.PnetCommercialExecutiveId).HasColumnName("pnet_CommercialExecutiveId");
            entity.Property(e => e.PnetCommitmentDate).HasColumnName("pnet_CommitmentDate");
            entity.Property(e => e.PnetCommitmentDay).HasColumnName("pnet_CommitmentDay");
            entity.Property(e => e.PnetContactId).HasColumnName("pnet_ContactId");
            entity.Property(e => e.PnetContract).HasColumnName("pnet_contract");
            entity.Property(e => e.PnetCreditId).HasColumnName("pnet_CreditId");
            entity.Property(e => e.PnetCreditSubtype)
                .HasMaxLength(100)
                .HasColumnName("pnet_CreditSubtype");
            entity.Property(e => e.PnetCreditType)
                .HasMaxLength(100)
                .HasColumnName("pnet_CreditType");
            entity.Property(e => e.PnetDebtCover)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_DebtCover");
            entity.Property(e => e.PnetDebtexpirationbalance)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_debtexpirationbalance");
            entity.Property(e => e.PnetDelayDays).HasColumnName("pnet_DelayDays");
            entity.Property(e => e.PnetDocumentnumber)
                .HasMaxLength(20)
                .HasColumnName("pnet_documentnumber");
            entity.Property(e => e.PnetDocumenttype)
                .HasMaxLength(100)
                .HasColumnName("pnet_documenttype");
            entity.Property(e => e.PnetEmailAddress)
                .HasMaxLength(100)
                .HasColumnName("pnet_EmailAddress");
            entity.Property(e => e.PnetExpirationdate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_expirationdate");
            entity.Property(e => e.PnetGrantdate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_grantdate");
            entity.Property(e => e.PnetGrantedAmount)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_GrantedAmount");
            entity.Property(e => e.PnetHeadquarterCode)
                .HasMaxLength(100)
                .HasColumnName("pnet_HeadquarterCode");
            entity.Property(e => e.PnetHedgeddebt)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_hedgeddebt");
            entity.Property(e => e.PnetHoldername)
                .HasMaxLength(100)
                .HasColumnName("pnet_holdername");
            entity.Property(e => e.PnetLastmovementdate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_lastmovementdate");
            entity.Property(e => e.PnetLoanBalance)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_LoanBalance");
            entity.Property(e => e.PnetMinimalduedate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_minimalduedate");
            entity.Property(e => e.PnetMinimalexpirationamount)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_minimalexpirationamount");
            entity.Property(e => e.PnetNacionality)
                .HasMaxLength(100)
                .HasColumnName("pnet_nacionality");
            entity.Property(e => e.PnetName)
                .HasMaxLength(100)
                .HasColumnName("pnet_name");
            entity.Property(e => e.PnetNextLiquidationDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_NextLiquidationDate");
            entity.Property(e => e.PnetNextexpirationdate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_nextexpirationdate");
            entity.Property(e => e.PnetNextsettlementdate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_nextsettlementdate");
            entity.Property(e => e.PnetNif)
                .HasMaxLength(20)
                .HasColumnName("pnet_nif");
            entity.Property(e => e.PnetOpeningdate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_openingdate");
            entity.Property(e => e.PnetOpportunityId).HasColumnName("pnet_OpportunityId");
            entity.Property(e => e.PnetOpportunityNumber)
                .HasMaxLength(100)
                .HasColumnName("pnet_OpportunityNumber");
            entity.Property(e => e.PnetPaymentDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_PaymentDate");
            entity.Property(e => e.PnetPaymentamount)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_paymentamount");
            entity.Property(e => e.PnetPayments).HasColumnName("pnet_payments");
            entity.Property(e => e.PnetPaymentsaccumulationamount)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_paymentsaccumulationamount");
            entity.Property(e => e.PnetPerson).HasColumnName("pnet_person");
            entity.Property(e => e.PnetPhonenumber)
                .HasMaxLength(30)
                .HasColumnName("pnet_phonenumber");
            entity.Property(e => e.PnetPortfoliorecordId).HasColumnName("pnet_portfoliorecordId");
            entity.Property(e => e.PnetProcessdate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_processdate");
            entity.Property(e => e.PnetPromesubsidiary).HasColumnName("pnet_PROMESubsidiary");
            entity.Property(e => e.PnetRate)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_Rate");
            entity.Property(e => e.PnetReconciledbalance)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_reconciledbalance");
            entity.Property(e => e.PnetSit).HasColumnName("pnet_sit");
            entity.Property(e => e.PnetSubsidiaryName)
                .HasMaxLength(100)
                .HasColumnName("pnet_SubsidiaryName");
            entity.Property(e => e.PnetTerm).HasColumnName("pnet_Term");
            entity.Property(e => e.PnetZone)
                .HasMaxLength(100)
                .HasColumnName("pnet_Zone");
            entity.Property(e => e.PnetZoneId).HasColumnName("pnet_ZoneId");
            entity.Property(e => e.Statecode).HasColumnName("statecode");
            entity.Property(e => e.Statuscode).HasColumnName("statuscode");
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<PnetRecordCommitteeBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pnet_RecordCommitteeBase", "crm");

            entity.HasIndex(e => new { e.PnetRecordCommitteeId, e.PnetOpportunityId }, "pnet_RecordCommitteeBase-20210121-IDX");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PnetAccountRequested).HasColumnName("pnet_AccountRequested");
            entity.Property(e => e.PnetAddress)
                .HasMaxLength(250)
                .HasColumnName("pnet_Address");
            entity.Property(e => e.PnetAddressNumber).HasColumnName("pnet_AddressNumber");
            entity.Property(e => e.PnetAv).HasColumnName("pnet_AV");
            entity.Property(e => e.PnetBail).HasColumnName("pnet_Bail");
            entity.Property(e => e.PnetBetweenStreets)
                .HasMaxLength(100)
                .HasColumnName("pnet_BetweenStreets");
            entity.Property(e => e.PnetBlock)
                .HasMaxLength(100)
                .HasColumnName("pnet_Block");
            entity.Property(e => e.PnetBody)
                .HasMaxLength(20)
                .HasColumnName("pnet_Body");
            entity.Property(e => e.PnetBusinessBackground).HasColumnName("pnet_BusinessBackground");
            entity.Property(e => e.PnetCancelationDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_CancelationDate");
            entity.Property(e => e.PnetComment).HasColumnName("pnet_Comment");
            entity.Property(e => e.PnetComplianceScore).HasColumnName("pnet_ComplianceScore");
            entity.Property(e => e.PnetContactId).HasColumnName("pnet_ContactId");
            entity.Property(e => e.PnetCorner)
                .HasMaxLength(100)
                .HasColumnName("pnet_Corner");
            entity.Property(e => e.PnetCounterId).HasColumnName("pnet_CounterId");
            entity.Property(e => e.PnetCreditAmount).HasColumnName("pnet_CreditAmount");
            entity.Property(e => e.PnetCreditCardLimit).HasColumnName("pnet_CreditCardLimit");
            entity.Property(e => e.PnetCreditDescription).HasColumnName("pnet_CreditDescription");
            entity.Property(e => e.PnetCreditFile).HasColumnName("pnet_CreditFile");
            entity.Property(e => e.PnetCreditNumber)
                .HasMaxLength(80)
                .HasColumnName("pnet_CreditNumber");
            entity.Property(e => e.PnetCreditProductDescription).HasColumnName("pnet_CreditProductDescription");
            entity.Property(e => e.PnetCreditType).HasColumnName("pnet_CreditType");
            entity.Property(e => e.PnetCsr).HasColumnName("pnet_CSR");
            entity.Property(e => e.PnetCvub).HasColumnName("pnet_CVUB");
            entity.Property(e => e.PnetDepartment)
                .HasMaxLength(100)
                .HasColumnName("pnet_Department");
            entity.Property(e => e.PnetDistrictLocalityId).HasColumnName("pnet_DistrictLocalityId");
            entity.Property(e => e.PnetExecutiveId).HasColumnName("pnet_ExecutiveId");
            entity.Property(e => e.PnetExtraDetails)
                .HasMaxLength(100)
                .HasColumnName("pnet_ExtraDetails");
            entity.Property(e => e.PnetFirstPaymentDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_FirstPaymentDate");
            entity.Property(e => e.PnetFloor)
                .HasMaxLength(100)
                .HasColumnName("pnet_Floor");
            entity.Property(e => e.PnetLocal)
                .HasMaxLength(100)
                .HasColumnName("pnet_Local");
            entity.Property(e => e.PnetLot)
                .HasMaxLength(20)
                .HasColumnName("pnet_Lot");
            entity.Property(e => e.PnetName)
                .HasMaxLength(100)
                .HasColumnName("pnet_name");
            entity.Property(e => e.PnetNeighborhood)
                .HasMaxLength(100)
                .HasColumnName("pnet_Neighborhood");
            entity.Property(e => e.PnetNotificationUnfavorableBackground).HasColumnName("pnet_NotificationUnfavorableBackground");
            entity.Property(e => e.PnetNub).HasColumnName("pnet_NUB");
            entity.Property(e => e.PnetOpportunityId).HasColumnName("pnet_OpportunityId");
            entity.Property(e => e.PnetOtherCredit).HasColumnName("pnet_OtherCredit");
            entity.Property(e => e.PnetPostalCode)
                .HasMaxLength(100)
                .HasColumnName("pnet_PostalCode");
            entity.Property(e => e.PnetPreferentialRate).HasColumnName("pnet_PreferentialRate");
            entity.Property(e => e.PnetQuotasNumber).HasColumnName("pnet_QuotasNumber");
            entity.Property(e => e.PnetRecordCommitteeId).HasColumnName("pnet_RecordCommitteeId");
            entity.Property(e => e.PnetSavingAccountNumber)
                .HasMaxLength(20)
                .HasColumnName("pnet_SavingAccountNumber");
            entity.Property(e => e.PnetSavingAccountsInformation).HasColumnName("pnet_SavingAccountsInformation");
            entity.Property(e => e.PnetTower)
                .HasMaxLength(100)
                .HasColumnName("pnet_Tower");
            entity.Property(e => e.PnetVcf).HasColumnName("pnet_VCF");
            entity.Property(e => e.PnetVof).HasColumnName("pnet_VOF");
            entity.Property(e => e.Statecode).HasColumnName("statecode");
            entity.Property(e => e.Statuscode).HasColumnName("statuscode");
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<PnetSalesubstatusBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pnet_salesubstatusBase", "crm");

            entity.HasIndex(e => new { e.PnetSalesubstatusId, e.PnetName }, "pnet_salesubstatusBase-20210108-IDX");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PnetCampaignResponse).HasColumnName("pnet_CampaignResponse");
            entity.Property(e => e.PnetInteractionSubStatusId).HasColumnName("pnet_InteractionSubStatusId");
            entity.Property(e => e.PnetName)
                .HasMaxLength(100)
                .HasColumnName("pnet_name");
            entity.Property(e => e.PnetPhoneCall).HasColumnName("pnet_PhoneCall");
            entity.Property(e => e.PnetSaleStatus).HasColumnName("pnet_SaleStatus");
            entity.Property(e => e.PnetSalesubstatusId).HasColumnName("pnet_salesubstatusId");
            entity.Property(e => e.Statecode).HasColumnName("statecode");
            entity.Property(e => e.Statuscode).HasColumnName("statuscode");
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<PnetScoredepuntaje>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pnet_scoredepuntaje", "crm");

            entity.Property(e => e.CreatedByName).HasMaxLength(200);
            entity.Property(e => e.CreatedByYomiName).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreatedOnBehalfByName).HasMaxLength(200);
            entity.Property(e => e.CreatedOnBehalfByYomiName).HasMaxLength(200);
            entity.Property(e => e.ModifiedByName).HasMaxLength(200);
            entity.Property(e => e.ModifiedByYomiName).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOnBehalfByName).HasMaxLength(200);
            entity.Property(e => e.ModifiedOnBehalfByYomiName).HasMaxLength(200);
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.OwnerIdName).HasMaxLength(160);
            entity.Property(e => e.OwnerIdYomiName).HasMaxLength(160);
            entity.Property(e => e.PnetActividadesCnae).HasColumnName("pnet_actividadesCNAE");
            entity.Property(e => e.PnetActividadesCnaename)
                .HasMaxLength(102)
                .HasColumnName("pnet_actividadesCNAEName");
            entity.Property(e => e.PnetActividadessegment).HasColumnName("pnet_actividadessegment");
            entity.Property(e => e.PnetActividadessegmentName)
                .HasMaxLength(100)
                .HasColumnName("pnet_actividadessegmentName");
            entity.Property(e => e.PnetActividadsegmento)
                .HasMaxLength(100)
                .HasColumnName("pnet_actividadsegmento");
            entity.Property(e => e.PnetChequesRechazadosScore).HasColumnName("pnet_chequesRechazadosScore");
            entity.Property(e => e.PnetClasificacionPatrimonialscore).HasColumnName("pnet_clasificacionPatrimonialscore");
            entity.Property(e => e.PnetCodigoSituacionScore).HasColumnName("pnet_codigoSituacionScore");
            entity.Property(e => e.PnetContactoPrincipalScore).HasColumnName("pnet_ContactoPrincipalScore");
            entity.Property(e => e.PnetContactoPrincipalScoreName)
                .HasMaxLength(160)
                .HasColumnName("pnet_ContactoPrincipalScoreName");
            entity.Property(e => e.PnetContactoPrincipalScoreYomiName)
                .HasMaxLength(450)
                .HasColumnName("pnet_ContactoPrincipalScoreYomiName");
            entity.Property(e => e.PnetEdadScore).HasColumnName("pnet_edadScore");
            entity.Property(e => e.PnetEstadoCivilScore).HasColumnName("pnet_estadoCivilScore");
            entity.Property(e => e.PnetMontodesaldoadeudado)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_montodesaldoadeudado");
            entity.Property(e => e.PnetName)
                .HasMaxLength(100)
                .HasColumnName("pnet_name");
            entity.Property(e => e.PnetOtrosIngresosValidadosScore)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_otrosIngresosValidadosScore");
            entity.Property(e => e.PnetOtrosingresosdatooriginal)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_otrosingresosdatooriginal");
            entity.Property(e => e.PnetPermanenciaenlaActividadScore).HasColumnName("pnet_permanenciaenlaActividadScore");
            entity.Property(e => e.PnetPoseeHijosScore).HasColumnName("pnet_poseeHijosScore");
            entity.Property(e => e.PnetPuntosActividadesdelaMe)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_puntosActividadesdelaME");
            entity.Property(e => e.PnetPuntosBcra)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_puntosBCRA");
            entity.Property(e => e.PnetPuntosCategoriaIvascore)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_puntosCategoriaIVAScore");
            entity.Property(e => e.PnetPuntosChequesRechazados)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_puntosChequesRechazados");
            entity.Property(e => e.PnetPuntosClasificacionPatrimonial)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_puntosClasificacionPatrimonial");
            entity.Property(e => e.PnetPuntosEdad)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_puntosEdad");
            entity.Property(e => e.PnetPuntosEstadoCivilScore)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_puntosEstadoCivilScore");
            entity.Property(e => e.PnetPuntosIngresosValidados)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_puntosIngresosValidados");
            entity.Property(e => e.PnetPuntosPermanenciaMe)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_puntosPermanenciaME");
            entity.Property(e => e.PnetPuntosPoseeHijos)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_puntosPoseeHijos");
            entity.Property(e => e.PnetPuntosSaldoAdeudado)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_puntosSaldoAdeudado");
            entity.Property(e => e.PnetPuntosTipodeVivienda)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_puntosTipodeVivienda");
            entity.Property(e => e.PnetPuntosTotalScoredePuntaje)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("pnet_puntosTotalScoredePuntaje");
            entity.Property(e => e.PnetResultadoScoredePuntaje).HasColumnName("pnet_resultadoScoredePuntaje");
            entity.Property(e => e.PnetScoredepuntajeId).HasColumnName("pnet_scoredepuntajeId");
            entity.Property(e => e.PnetSituacionenBcrascore).HasColumnName("pnet_situacionenBCRAscore");
            entity.Property(e => e.PnetTipodeImpuestoScore).HasColumnName("pnet_tipodeImpuestoScore");
            entity.Property(e => e.PnetTipodeViviendaScore).HasColumnName("pnet_tipodeViviendaScore");
            entity.Property(e => e.PnetValidarOtrosIngresos).HasColumnName("pnet_validarOtrosIngresos");
            entity.Property(e => e.PnetValidarResultadoScore).HasColumnName("pnet_validarResultadoScore");
            entity.Property(e => e.Statecode).HasColumnName("statecode");
            entity.Property(e => e.Statuscode).HasColumnName("statuscode");
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<PnetSegmentBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pnet_SegmentBase", "crm");

            entity.HasIndex(e => e.PnetSegmentId, "pnet_SegmentBase-20210108-IDX");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PnetActivity)
                .HasMaxLength(100)
                .HasColumnName("pnet_Activity");
            entity.Property(e => e.PnetActivityIcode).HasColumnName("pnet_ActivityICode");
            entity.Property(e => e.PnetCategory)
                .HasMaxLength(100)
                .HasColumnName("pnet_Category");
            entity.Property(e => e.PnetGrupodeactividadme).HasColumnName("pnet_grupodeactividadme");
            entity.Property(e => e.PnetName)
                .HasMaxLength(100)
                .HasColumnName("pnet_name");
            entity.Property(e => e.PnetSegmentId).HasColumnName("pnet_SegmentId");
            entity.Property(e => e.PnetTypifiedSegment).HasColumnName("pnet_TypifiedSegment");
            entity.Property(e => e.Statecode).HasColumnName("statecode");
            entity.Property(e => e.Statuscode).HasColumnName("statuscode");
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<PnetSitevisitBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pnet_sitevisitBase", "crm");

            entity.HasIndex(e => new { e.PnetSitevisitId, e.PnetCampaignResponseId }, "pnet_sitevisitBase-20210108-IDX");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PnetAssignmentDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_AssignmentDate");
            entity.Property(e => e.PnetBankLoanAgreement).HasColumnName("pnet_BankLoanAgreement");
            entity.Property(e => e.PnetCampaignId).HasColumnName("pnet_CampaignId");
            entity.Property(e => e.PnetCampaignResponseId).HasColumnName("pnet_CampaignResponseId");
            entity.Property(e => e.PnetCancelOpportunityPrevious).HasColumnName("pnet_CancelOpportunityPrevious");
            entity.Property(e => e.PnetCancelOpportunityPrevious2).HasColumnName("pnet_CancelOpportunityPrevious2");
            entity.Property(e => e.PnetChangeCreditTypeorSubtype).HasColumnName("pnet_ChangeCreditTypeorSubtype");
            entity.Property(e => e.PnetCloneType).HasColumnName("pnet_CloneType");
            entity.Property(e => e.PnetCommercialBackgroundId).HasColumnName("pnet_CommercialBackgroundID");
            entity.Property(e => e.PnetConvenio).HasColumnName("pnet_convenio");
            entity.Property(e => e.PnetCounterId).HasColumnName("pnet_CounterId");
            entity.Property(e => e.PnetCreditDestination).HasColumnName("pnet_CreditDestination");
            entity.Property(e => e.PnetCreditSubType).HasColumnName("pnet_CreditSubType");
            entity.Property(e => e.PnetCreditType).HasColumnName("pnet_CreditType");
            entity.Property(e => e.PnetCustomerregistration).HasColumnName("pnet_customerregistration");
            entity.Property(e => e.PnetDateofvisitineffectivefield)
                .HasColumnType("datetime")
                .HasColumnName("pnet_Dateofvisitineffectivefield");
            entity.Property(e => e.PnetDirectFamily).HasColumnName("pnet_DirectFamily");
            entity.Property(e => e.PnetEjecutiveResponsible).HasColumnName("pnet_EjecutiveResponsible");
            entity.Property(e => e.PnetEstimatedAmount).HasColumnName("pnet_EstimatedAmount");
            entity.Property(e => e.PnetEstimatedAmountletters)
                .HasMaxLength(300)
                .HasColumnName("pnet_EstimatedAmountletters");
            entity.Property(e => e.PnetFateCredit)
                .HasMaxLength(100)
                .HasColumnName("pnet_FateCredit");
            entity.Property(e => e.PnetFee).HasColumnName("pnet_Fee");
            entity.Property(e => e.PnetFomrTypeRenovation)
                .HasMaxLength(100)
                .HasColumnName("pnet_FomrTypeRenovation");
            entity.Property(e => e.PnetFormTypeRenovation).HasColumnName("pnet_FormTypeRenovation");
            entity.Property(e => e.PnetGetId)
                .HasMaxLength(100)
                .HasColumnName("pnet_getID");
            entity.Property(e => e.PnetInCampaign).HasColumnName("pnet_InCampaign");
            entity.Property(e => e.PnetInterestRate).HasColumnName("pnet_InterestRate");
            entity.Property(e => e.PnetManualentryrequest).HasColumnName("pnet_Manualentryrequest");
            entity.Property(e => e.PnetMicroEmpresa).HasColumnName("pnet_MicroEmpresa");
            entity.Property(e => e.PnetMiniTer).HasColumnName("pnet_MiniTER");
            entity.Property(e => e.PnetName)
                .HasMaxLength(100)
                .HasColumnName("pnet_name");
            entity.Property(e => e.PnetNffateCredit)
                .HasMaxLength(100)
                .HasColumnName("pnet_NFFateCredit");
            entity.Property(e => e.PnetNffee).HasColumnName("pnet_NFFee");
            entity.Property(e => e.PnetOfferByMemberId).HasColumnName("pnet_OfferByMemberId");
            entity.Property(e => e.PnetOpportunityCreated).HasColumnName("pnet_OpportunityCreated");
            entity.Property(e => e.PnetOpportunityGenerated).HasColumnName("pnet_OpportunityGenerated");
            entity.Property(e => e.PnetOwnerId).HasColumnName("pnet_OwnerId");
            entity.Property(e => e.PnetPapopp).HasColumnName("pnet_PAPOPP");
            entity.Property(e => e.PnetPreapprovedAmount).HasColumnName("pnet_PreapprovedAmount");
            entity.Property(e => e.PnetPreapprovedFee).HasColumnName("pnet_PreapprovedFee");
            entity.Property(e => e.PnetPrincipalApplication)
                .HasMaxLength(100)
                .HasColumnName("pnet_PrincipalApplication");
            entity.Property(e => e.PnetPrincipalApplicationId).HasColumnName("pnet_PrincipalApplicationId");
            entity.Property(e => e.PnetPrincipalContact).HasColumnName("pnet_PrincipalContact");
            entity.Property(e => e.PnetProcessEvaluate).HasColumnName("pnet_process_evaluate");
            entity.Property(e => e.PnetQuotaAmount).HasColumnName("pnet_QuotaAmount");
            entity.Property(e => e.PnetQuotasNumber).HasColumnName("pnet_QuotasNumber");
            entity.Property(e => e.PnetRenovationRequest).HasColumnName("pnet_RenovationRequest");
            entity.Property(e => e.PnetRenovationResquestmanual).HasColumnName("pnet_RenovationResquestmanual");
            entity.Property(e => e.PnetReportType).HasColumnName("pnet_ReportType");
            entity.Property(e => e.PnetRequestId).HasColumnName("pnet_RequestId");
            entity.Property(e => e.PnetSetValuesInterestRate).HasColumnName("pnet_SetValuesInterestRate");
            entity.Property(e => e.PnetSiteVisitGps)
                .HasMaxLength(300)
                .HasColumnName("pnet_SiteVisitGPS");
            entity.Property(e => e.PnetSitevisitId).HasColumnName("pnet_sitevisitId");
            entity.Property(e => e.PnetSitevisitPrincipalApplicationId).HasColumnName("pnet_sitevisit_PrincipalApplicationId");
            entity.Property(e => e.PnetSolNumber)
                .HasMaxLength(5)
                .HasColumnName("pnet_solNumber");
            entity.Property(e => e.PnetSubsidiaryId).HasColumnName("pnet_SubsidiaryId");
            entity.Property(e => e.PnetSupplementaryRequest).HasColumnName("pnet_SupplementaryRequest");
            entity.Property(e => e.PnetSvcreditSubType).HasColumnName("pnet_SVCreditSubType");
            entity.Property(e => e.PnetSvcreditType).HasColumnName("pnet_SVCreditType");
            entity.Property(e => e.PnetSvname)
                .HasMaxLength(100)
                .HasColumnName("pnet_SVName");
            entity.Property(e => e.PnetSvreportType).HasColumnName("pnet_SVReportType");
            entity.Property(e => e.PnetVisitDate)
                .HasColumnType("datetime")
                .HasColumnName("pnet_VisitDate");
            entity.Property(e => e.Statecode).HasColumnName("statecode");
            entity.Property(e => e.Statuscode).HasColumnName("statuscode");
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<PositionBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PositionBase", "crm");

            entity.HasIndex(e => new { e.ParentPositionId, e.PositionId }, "PositionBase-20201107-Ids");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.ExchangeRate).HasColumnType("numeric(23, 10)");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Statecode).HasColumnName("statecode");
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<Presentismo>(entity =>
        {
            entity.HasKey(e => e.IdPresentismo);

            entity.ToTable("Presentismo", "app");

            entity.Property(e => e.BkId).HasColumnName("bkId");
            entity.Property(e => e.CargadoEnCelular)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CategoriaCodigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CentroDeCostos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Concepto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Destino)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Gerencia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Km)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("km");
            entity.Property(e => e.LatitudSucursal).HasColumnType("numeric(18, 6)");
            entity.Property(e => e.LongitudSucursal).HasColumnType("numeric(18, 6)");
            entity.Property(e => e.Motivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SectorCodigo)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.SectorNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Zona)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PresentismoRendicion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PresentismoRendicion", "int");

            entity.Property(e => e.CargadoEnCelular)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cargado_en_celular");
            entity.Property(e => e.CategoriaCodigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Destino)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("destino");
            entity.Property(e => e.Email)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdConcepto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_concepto");
            entity.Property(e => e.IdEstado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_estado");
            entity.Property(e => e.IdMotivo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_motivo");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Km)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("km");
            entity.Property(e => e.NumeroLegajo).HasColumnName("numero_legajo");
        });

        modelBuilder.Entity<PrestamosLiquidadosNuevo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PrestamosLiquidadosNuevos", "app");

            entity.Property(e => e.CuentaSur)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Cuenta Sur");
            entity.Property(e => e.FechaDelDia)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Fecha del Dia");
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.Nif)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("NIF");
            entity.Property(e => e.NombreDelCliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre del Cliente");
            entity.Property(e => e.NroDeDocumento).HasColumnName("Nro de Documento");
            entity.Property(e => e.Prod)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("PROD");
            entity.Property(e => e.Solicitud).HasMaxLength(16);
            entity.Property(e => e.Sucursal)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProcesosCarga>(entity =>
        {
            entity.HasKey(e => e.NombreProceso);

            entity.ToTable("ProcesosCarga", "app");

            entity.Property(e => e.NombreProceso)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado).HasComment("Estado del proceso : 0 ejecutando | 1 finalizado");
            entity.Property(e => e.FechaEjecución).HasColumnType("datetime");
            entity.Property(e => e.Guid).HasColumnName("guid");
        });

        modelBuilder.Entity<ProductBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ProductBase", "crm");

            entity.HasIndex(e => new { e.ProductId, e.ParentProductId }, "ProductBase-20210121-IDX");

            entity.Property(e => e.AxxonFormConfigId).HasColumnName("axxon_FormConfigId");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CurrentCost).HasColumnType("money");
            entity.Property(e => e.CurrentCostBase)
                .HasColumnType("money")
                .HasColumnName("CurrentCost_Base");
            entity.Property(e => e.DefaultUoMid).HasColumnName("DefaultUoMId");
            entity.Property(e => e.DefaultUoMscheduleId).HasColumnName("DefaultUoMScheduleId");
            entity.Property(e => e.ExchangeRate).HasColumnType("numeric(23, 10)");
            entity.Property(e => e.HierarchyPath).HasMaxLength(900);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(137);
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("money");
            entity.Property(e => e.PriceBase)
                .HasColumnType("money")
                .HasColumnName("Price_Base");
            entity.Property(e => e.ProductNumber).HasMaxLength(100);
            entity.Property(e => e.ProductUrl).HasMaxLength(255);
            entity.Property(e => e.QuantityOnHand).HasColumnType("numeric(23, 10)");
            entity.Property(e => e.Size).HasMaxLength(200);
            entity.Property(e => e.StandardCost).HasColumnType("money");
            entity.Property(e => e.StandardCostBase)
                .HasColumnType("money")
                .HasColumnName("StandardCost_Base");
            entity.Property(e => e.StockVolume).HasColumnType("numeric(23, 10)");
            entity.Property(e => e.StockWeight).HasColumnType("numeric(23, 10)");
            entity.Property(e => e.SupplierName).HasMaxLength(100);
            entity.Property(e => e.TraversedPath).HasMaxLength(1250);
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.ValidFromDate).HasColumnType("datetime");
            entity.Property(e => e.ValidToDate).HasColumnType("datetime");
            entity.Property(e => e.VendorId)
                .HasMaxLength(100)
                .HasColumnName("VendorID");
            entity.Property(e => e.VendorName).HasMaxLength(100);
            entity.Property(e => e.VendorPartNumber).HasMaxLength(100);
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<PromeLiqOrigen>(entity =>
        {
            entity.HasKey(e => e.Solicitud).HasName("PK_appPromeLiqOrigen");

            entity.ToTable("PromeLiqOrigen", "app");

            entity.Property(e => e.Solicitud).ValueGeneratedNever();
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.Origen)
                .HasMaxLength(3)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PromeLiqOrigen1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PromeLiqOrigen", "int");

            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.Origen)
                .HasMaxLength(3)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProspectoOval>(entity =>
        {
            entity.HasKey(e => e.IdProspectoOval);

            entity.ToTable("ProspectoOval", "app");

            entity.Property(e => e.IdProspectoOval).HasColumnName("idProspectoOval");
            entity.Property(e => e.ArchConsulta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("archConsulta");
            entity.Property(e => e.AssignedTeam)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AssignedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Branch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Contacto).HasColumnName("contacto");
            entity.Property(e => e.CreditAmount).HasColumnType("money");
            entity.Property(e => e.CreditSubtype)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaCreación).HasColumnType("datetime");
            entity.Property(e => e.IdProspectoVeraz).HasColumnName("idProspectoVeraz");
            entity.Property(e => e.OfferCode).HasColumnType("money");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.OrdenId).HasColumnName("ordenID");
            entity.Property(e => e.QuotaAmount).HasColumnType("money");
            entity.Property(e => e.QuotasNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Segment)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ToTeam)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ToUser)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Zone)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProspectoVeraz>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ProspectoVeraz", "app");

            entity.HasIndex(e => new { e.FechaConsulta, e.Pendiente }, "IDX_appProspectoVeraz_fecha");

            entity.HasIndex(e => new { e.ArchConsulta, e.Orden }, "nci_wi_ProspectoVeraz_IDX");

            entity.Property(e => e.ArchConsulta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("archConsulta");
            entity.Property(e => e.Campaign)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CAMPAIGN");
            entity.Property(e => e.CodSucProme).HasColumnName("CodSucPROME");
            entity.Property(e => e.Dni).HasColumnName("DNI");
            entity.Property(e => e.FechaConsulta)
                .HasColumnType("date")
                .HasColumnName("fechaConsulta");
            entity.Property(e => e.IdProspectoVeraz)
                .ValueGeneratedOnAdd()
                .HasColumnName("idProspectoVeraz");
            entity.Property(e => e.Nombre)
                .HasMaxLength(101)
                .IsUnicode(false);
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.Otros)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Pendiente).HasColumnName("pendiente");
            entity.Property(e => e.RespuestaVeraz)
                .HasMaxLength(2000)
                .HasColumnName("respuestaVeraz");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("sexo");
            entity.Property(e => e.Sucursal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUCURSAL");
            entity.Property(e => e.SucursalOrigen)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Zona)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("zona");
        });

        modelBuilder.Entity<ProspectoVerazCodigo>(entity =>
        {
            entity.HasKey(e => e.IdCodigos);

            entity.ToTable("ProspectoVerazCodigos", "app");

            entity.Property(e => e.IdCodigos).HasColumnName("idCodigos");
            entity.Property(e => e.AssignedTeamMatriz).HasColumnName("AssignedTeam Matriz");
            entity.Property(e => e.Bancarizado)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("bancarizado");
            entity.Property(e => e.BranchMatriz).HasColumnName("Branch Matriz");
            entity.Property(e => e.CampañaCv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Campaña CV");
            entity.Property(e => e.CampañaSv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Campaña SV");
            entity.Property(e => e.Columna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripción)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Entidad)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.Modificado).HasColumnType("datetime");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Modificado por");
            entity.Property(e => e.NoBancarizado)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("no bancarizado");
            entity.Property(e => e.ToTeamMatriz).HasColumnName("ToTeam Matriz");
        });

        modelBuilder.Entity<ProspectoVerazCrm>(entity =>
        {
            entity.HasKey(e => e.IdProspectoVerazCrm);

            entity.ToTable("ProspectoVerazCRM", "app");

            entity.Property(e => e.IdProspectoVerazCrm).HasColumnName("idProspectoVerazCRM");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Dni).HasColumnName("DNI");
            entity.Property(e => e.FechaConsulta)
                .HasColumnType("date")
                .HasColumnName("fechaConsulta");
            entity.Property(e => e.LineaCrm)
                .HasMaxLength(512)
                .HasColumnName("LineaCRM");
            entity.Property(e => e.Oferta).HasColumnName("oferta");
            entity.Property(e => e.PnetName)
                .HasMaxLength(128)
                .HasColumnName("pnet_name");
        });

        modelBuilder.Entity<ProyeccionesCantidad>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PROYECCIONES_CANTIDAD");

            entity.Property(e => e.Doc).HasColumnName("DOC");
            entity.Property(e => e.Ec).HasColumnName("EC");
            entity.Property(e => e.Ei).HasColumnName("EI");
            entity.Property(e => e.FechaProceso).HasColumnType("date");
            entity.Property(e => e.MetaQ).HasColumnType("numeric(38, 1)");
            entity.Property(e => e.SinMetas).HasColumnName("sinMetas");
            entity.Property(e => e.Ucc).HasColumnName("UCC");
            entity.Property(e => e.Uccr).HasColumnName("UCCR");
            entity.Property(e => e.Vt).HasColumnName("VT");
            entity.Property(e => e.Zona)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProyeccionesSaldo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PROYECCIONES_SALDO");

            entity.Property(e => e.Admision).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.Banco).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.Doc)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("DOC");
            entity.Property(e => e.Ec)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("EC");
            entity.Property(e => e.Ei).HasColumnName("EI");
            entity.Property(e => e.FechaProceso).HasColumnType("date");
            entity.Property(e => e.Meta).HasColumnType("numeric(38, 3)");
            entity.Property(e => e.MontoMes).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.ProyectadoCerrado).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.ProyectadoCerradoLiquidado).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.ProyectadoLiquidado).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.RechazadoBanco).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.Riesgo).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.TotalProyectado).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.Ucc)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("UCC");
            entity.Property(e => e.Uccr)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("UCCR");
            entity.Property(e => e.Vt).HasColumnName("VT");
            entity.Property(e => e.Zona)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RechazadosBpba>(entity =>
        {
            entity.HasKey(e => e.IdRechazado);

            entity.ToTable("RechazadosBPBA", "app");

            entity.HasIndex(e => e.IdMensaje, "IDX_RechazadosBPBA_IdMensaje")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.IdRechazado).HasColumnName("idRechazado");
            entity.Property(e => e.Archivo).HasMaxLength(255);
            entity.Property(e => e.Desde).HasMaxLength(30);
            entity.Property(e => e.Encabezado).HasMaxLength(255);
            entity.Property(e => e.Estado).HasMaxLength(20);
            entity.Property(e => e.FechaCreación).HasColumnType("datetime");
            entity.Property(e => e.FechaModificación).HasColumnType("datetime");
            entity.Property(e => e.IdMensaje).HasMaxLength(50);
            entity.Property(e => e.Mensaje).HasMaxLength(2048);
            entity.Property(e => e.Recibido).HasColumnType("datetime");
        });

        modelBuilder.Entity<RechazadosBpba1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RechazadosBPBA", "int");

            entity.Property(e => e.Desde).HasMaxLength(30);
            entity.Property(e => e.Encabezado).HasMaxLength(255);
            entity.Property(e => e.FechaCreación).HasColumnType("datetime");
            entity.Property(e => e.IdMensaje).HasMaxLength(50);
            entity.Property(e => e.Recibido).HasMaxLength(30);
        });

        modelBuilder.Entity<RechazosBpba>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RechazosBPBA", "app");

            entity.Property(e => e.Archivo).HasMaxLength(255);
            entity.Property(e => e.Desde).HasMaxLength(30);
            entity.Property(e => e.Encabezado).HasMaxLength(255);
            entity.Property(e => e.Estado).HasMaxLength(20);
            entity.Property(e => e.FechaModificación).HasColumnType("datetime");
            entity.Property(e => e.Mensaje).HasMaxLength(2048);
            entity.Property(e => e.Recibido).HasColumnType("datetime");
            entity.Property(e => e.Solicitud).HasMaxLength(4000);
        });

        modelBuilder.Entity<RechazosBpbaaDw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RechazosBPBAaDW", "app");

            entity.Property(e => e.Archivo).HasMaxLength(255);
            entity.Property(e => e.DetalleDelError)
                .HasMaxLength(2048)
                .HasColumnName("Detalle del Error");
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.FilialBpba).HasColumnName("FilialBPBA");
            entity.Property(e => e.IdProceso).HasMaxLength(50);
            entity.Property(e => e.Nif).HasColumnName("NIF");
            entity.Property(e => e.NroDeDocumento).HasColumnName("Nro de Documento");
            entity.Property(e => e.Origen)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.SkFecha)
                .HasColumnType("datetime")
                .HasColumnName("skFecha");
            entity.Property(e => e.Solicitud).HasMaxLength(4000);
        });

        modelBuilder.Entity<RepColocacionesBimestre>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("repColocacionesBimestre");

            entity.Property(e => e.Ec)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EC");
            entity.Property(e => e.FechaDelDia)
                .HasColumnType("date")
                .HasColumnName("Fecha del Dia");
            entity.Property(e => e.FechaOtorgamiento).HasColumnType("date");
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.NroDocEc).HasColumnName("NroDocEC");
            entity.Property(e => e.Posicion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SaldoPrestamo).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.SubTipoCredito)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sucursal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tasa).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TipoCredito)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Zona)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RepColocacionesColaboradore>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("repCOLOCACIONES_COLABORADORES");

            entity.Property(e => e.Asistente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Categoria)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CumplimientoQ)
                .HasColumnType("numeric(29, 13)")
                .HasColumnName("Cumplimiento Q");
            entity.Property(e => e.CumplimientoQRepo)
                .HasColumnType("numeric(29, 13)")
                .HasColumnName("Cumplimiento Q repo");
            entity.Property(e => e.CumplimientoSRepo)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("Cumplimiento S repo");
            entity.Property(e => e.Ejecutivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fecha");
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.ImporteColocado).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.ImporteMeta).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.M1)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("M_1");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.Ppm)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("PPM");
            entity.Property(e => e.Registro)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("registro");
            entity.Property(e => e.SucursalOrden)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalFilial)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("totalFilial");
            entity.Property(e => e.Tpm)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("TPM");
            entity.Property(e => e.Zona)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RepColocacionesEcBimestral>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("repColocacionesEcBimestral");

            entity.Property(e => e.Categoria)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ejecutivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EjecutivoSucursal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.M1)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("M_1");
            entity.Property(e => e.M1Suc)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("M_1_Suc");
            entity.Property(e => e.MetaEjecutivo).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.MetaQ).HasColumnName("Meta Q");
            entity.Property(e => e.MetaQsucursal).HasColumnName("MetaQSucursal");
            entity.Property(e => e.MetaSucursal).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Origen)
                .HasMaxLength(19)
                .IsUnicode(false)
                .HasColumnName("origen");
            entity.Property(e => e.PeriodoFin).HasColumnType("date");
            entity.Property(e => e.Posicion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Rh30S0)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RH30_S0");
            entity.Property(e => e.SaldoPrestamo).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.SubTipoCredito)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sucursal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tasa).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TipoCredito)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Zona)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ReportePresentismo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ReportePresentismo", "app");

            entity.Property(e => e.CargadoEnCelular)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CentroDeCostos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Concepto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Destino)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Gerencia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Km)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("km");
            entity.Property(e => e.LatitudSucursal).HasColumnType("numeric(18, 6)");
            entity.Property(e => e.Legajo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LongitudSucursal).HasColumnType("numeric(18, 6)");
            entity.Property(e => e.Motivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SectorCodigo)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.SectorNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SkFecha)
                .HasColumnType("date")
                .HasColumnName("skFecha");
            entity.Property(e => e.Tamaño).HasColumnName("tamaño");
            entity.Property(e => e.Tipo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("tipo");
            entity.Property(e => e.Zona)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ReportePresentismoCalendario>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ReportePresentismoCalendario", "app");

            entity.Property(e => e.Año).HasColumnType("datetime");
            entity.Property(e => e.AñoNombre)
                .HasMaxLength(50)
                .HasColumnName("Año_Nombre");
            entity.Property(e => e.DíaDeLaSemana).HasColumnName("Día_de_la_Semana");
            entity.Property(e => e.DíaDeLaSemanaNombre)
                .HasMaxLength(50)
                .HasColumnName("Día_de_la_Semana_Nombre");
            entity.Property(e => e.DíaDelAño).HasColumnName("Día_del_Año");
            entity.Property(e => e.DíaDelAñoNombre)
                .HasMaxLength(50)
                .HasColumnName("Día_del_Año_Nombre");
            entity.Property(e => e.DíaDelMes).HasColumnName("Día_del_Mes");
            entity.Property(e => e.DíaDelMesNombre)
                .HasMaxLength(50)
                .HasColumnName("Día_del_Mes_Nombre");
            entity.Property(e => e.DíaDelSemestre).HasColumnName("Día_del_Semestre");
            entity.Property(e => e.DíaDelSemestreNombre)
                .HasMaxLength(50)
                .HasColumnName("Día_del_Semestre_Nombre");
            entity.Property(e => e.DíaDelTrimestre).HasColumnName("Día_del_Trimestre");
            entity.Property(e => e.DíaDelTrimestreNombre)
                .HasMaxLength(50)
                .HasColumnName("Día_del_Trimestre_Nombre");
            entity.Property(e => e.FechaNombre)
                .HasMaxLength(50)
                .HasColumnName("Fecha_Nombre");
            entity.Property(e => e.Mes).HasColumnType("datetime");
            entity.Property(e => e.MesDelAño).HasColumnName("Mes_del_Año");
            entity.Property(e => e.MesDelAñoNombre)
                .HasMaxLength(50)
                .HasColumnName("Mes_del_Año_Nombre");
            entity.Property(e => e.MesDelSemestre).HasColumnName("Mes_del_Semestre");
            entity.Property(e => e.MesDelSemestreNombre)
                .HasMaxLength(50)
                .HasColumnName("Mes_del_Semestre_Nombre");
            entity.Property(e => e.MesDelTrimestre).HasColumnName("Mes_del_Trimestre");
            entity.Property(e => e.MesDelTrimestreNombre)
                .HasMaxLength(50)
                .HasColumnName("Mes_del_Trimestre_Nombre");
            entity.Property(e => e.MesNombre)
                .HasMaxLength(50)
                .HasColumnName("Mes_Nombre");
            entity.Property(e => e.Semana).HasColumnType("datetime");
            entity.Property(e => e.SemanaDelAño).HasColumnName("Semana_del_Año");
            entity.Property(e => e.SemanaDelAñoNombre)
                .HasMaxLength(50)
                .HasColumnName("Semana_del_Año_Nombre");
            entity.Property(e => e.SemanaNombre)
                .HasMaxLength(50)
                .HasColumnName("Semana_Nombre");
            entity.Property(e => e.Semestre).HasColumnType("datetime");
            entity.Property(e => e.SemestreDelAño).HasColumnName("Semestre_del_Año");
            entity.Property(e => e.SemestreDelAñoNombre)
                .HasMaxLength(50)
                .HasColumnName("Semestre_del_Año_Nombre");
            entity.Property(e => e.SemestreNombre)
                .HasMaxLength(50)
                .HasColumnName("Semestre_Nombre");
            entity.Property(e => e.SkFecha)
                .HasColumnType("datetime")
                .HasColumnName("skFecha");
            entity.Property(e => e.Trimestre).HasColumnType("datetime");
            entity.Property(e => e.TrimestreDelAño).HasColumnName("Trimestre_del_Año");
            entity.Property(e => e.TrimestreDelAñoNombre)
                .HasMaxLength(50)
                .HasColumnName("Trimestre_del_Año_Nombre");
            entity.Property(e => e.TrimestreDelSemestre).HasColumnName("Trimestre_del_Semestre");
            entity.Property(e => e.TrimestreDelSemestreNombre)
                .HasMaxLength(50)
                .HasColumnName("Trimestre_del_Semestre_Nombre");
            entity.Property(e => e.TrimestreNombre)
                .HasMaxLength(50)
                .HasColumnName("Trimestre_Nombre");
        });

        modelBuilder.Entity<ResultadosFondep>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RESULTADOS_FONDEP", "int");

            entity.Property(e => e.Cuota).HasColumnName("cuota");
            entity.Property(e => e.Dni).HasColumnName("DNI");
            entity.Property(e => e.ErrorCode).HasColumnName("error_code");
            entity.Property(e => e.ErrorMesg)
                .HasMaxLength(50)
                .HasColumnName("error_mesg");
            entity.Property(e => e.FechaLote)
                .HasColumnType("date")
                .HasColumnName("fecha_lote");
            entity.Property(e => e.FechaOval)
                .HasColumnType("date")
                .HasColumnName("fecha_oval");
            entity.Property(e => e.FondepFinal)
                .HasMaxLength(50)
                .HasColumnName("fondep_final");
            entity.Property(e => e.Monto).HasColumnName("monto");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreOval)
                .HasMaxLength(50)
                .HasColumnName("nombre_oval");
            entity.Property(e => e.Oval).HasColumnName("oval");
            entity.Property(e => e.PuntoCorte)
                .HasMaxLength(50)
                .HasColumnName("Punto_Corte");
            entity.Property(e => e.Registro).HasColumnName("registro");
            entity.Property(e => e.Resultado).HasMaxLength(50);
            entity.Property(e => e.SucursalCartera)
                .HasMaxLength(50)
                .HasColumnName("Sucursal_Cartera");
            entity.Property(e => e.ZonaCartera)
                .HasMaxLength(50)
                .HasColumnName("Zona_Cartera");
        });

        modelBuilder.Entity<ResultadosFondepCompleto>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RESULTADOS_FONDEP_completo", "int");

            entity.Property(e => e.Cuota).HasColumnName("cuota");
            entity.Property(e => e.Dni).HasColumnName("DNI");
            entity.Property(e => e.DocTipo).HasMaxLength(100);
            entity.Property(e => e.Ec)
                .HasMaxLength(200)
                .HasColumnName("EC");
            entity.Property(e => e.ErrorCode).HasColumnName("error_code");
            entity.Property(e => e.ErrorMesg)
                .HasMaxLength(50)
                .HasColumnName("error_mesg");
            entity.Property(e => e.Estado)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.FechaLiquidación).HasColumnType("datetime");
            entity.Property(e => e.FechaLote)
                .HasColumnType("date")
                .HasColumnName("fecha_lote");
            entity.Property(e => e.FechaOval)
                .HasColumnType("date")
                .HasColumnName("fecha_oval");
            entity.Property(e => e.FondepFinal)
                .HasMaxLength(50)
                .HasColumnName("fondep_final");
            entity.Property(e => e.Instancia)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.LegajoEc)
                .HasMaxLength(50)
                .HasColumnName("LegajoEC");
            entity.Property(e => e.Monto).HasColumnName("monto");
            entity.Property(e => e.MontoSolicitud).HasColumnName("Monto Solicitud");
            entity.Property(e => e.Nif)
                .HasMaxLength(100)
                .HasColumnName("NIF");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreOval)
                .HasMaxLength(50)
                .HasColumnName("nombre_oval");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.Origen)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Oval).HasColumnName("oval");
            entity.Property(e => e.PnetSuraccount).HasColumnName("pnet_SURaccount");
            entity.Property(e => e.PuntoCorte)
                .HasMaxLength(50)
                .HasColumnName("Punto_Corte");
            entity.Property(e => e.Registro).HasColumnName("registro");
            entity.Property(e => e.Resultado).HasMaxLength(50);
            entity.Property(e => e.Solicitud).HasMaxLength(300);
            entity.Property(e => e.SubInstancia)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.SubTipoCrédito)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Subzona).HasMaxLength(200);
            entity.Property(e => e.SubzonaCartera)
                .HasMaxLength(50)
                .HasColumnName("Subzona_Cartera");
            entity.Property(e => e.Sucursal).HasMaxLength(160);
            entity.Property(e => e.SucursalCartera)
                .HasMaxLength(50)
                .HasColumnName("Sucursal_Cartera");
            entity.Property(e => e.SucursalCód).HasMaxLength(400);
            entity.Property(e => e.TasaAnual).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.TipoCrédito)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.TipoFormulario)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Zona).HasMaxLength(4000);
            entity.Property(e => e.ZonaCartera)
                .HasMaxLength(50)
                .HasColumnName("Zona_Cartera");
        });

        modelBuilder.Entity<SegmentoActual>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SegmentoActual", "crm");

            entity.Property(e => e.Actividad).HasMaxLength(100);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Orden2).HasColumnName("orden2");
            entity.Property(e => e.PnetDocumentNumber).HasColumnName("pnet_DocumentNumber");
            entity.Property(e => e.PnetDocumentTypeValue)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("pnet_DocumentTypeValue");
            entity.Property(e => e.Rubro).HasMaxLength(100);
            entity.Property(e => e.Segmento).HasMaxLength(100);
        });

        modelBuilder.Entity<Solicitude>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Solicitudes", "crm");

            entity.Property(e => e.Apellido).HasMaxLength(50);
            entity.Property(e => e.AreaCód1).HasMaxLength(4000);
            entity.Property(e => e.AreaCód2).HasMaxLength(4000);
            entity.Property(e => e.AreaCód3).HasMaxLength(4000);
            entity.Property(e => e.Bpbacalle)
                .HasMaxLength(100)
                .HasColumnName("BPBACalle");
            entity.Property(e => e.BpbacalleCp)
                .HasMaxLength(100)
                .HasColumnName("BPBACalleCP");
            entity.Property(e => e.BpbacalleNro)
                .HasMaxLength(100)
                .HasColumnName("BPBACalleNro");
            entity.Property(e => e.Bpbapersona)
                .HasMaxLength(100)
                .HasColumnName("BPBAPersona");
            entity.Property(e => e.CalificaBip).HasColumnName("calificaBIP");
            entity.Property(e => e.Calle).HasMaxLength(250);
            entity.Property(e => e.CambioDeMeEvaluada).HasColumnName("Cambio de ME evaluada");
            entity.Property(e => e.Celular).HasMaxLength(53);
            entity.Property(e => e.ComportamientoProme).HasColumnName("Comportamiento PROME");
            entity.Property(e => e.CuotasPagasSN).HasColumnName("Cuotas pagas S/N");
            entity.Property(e => e.CómoSeEnteró)
                .HasMaxLength(4000)
                .HasColumnName("¿Cómo se enteró?");
            entity.Property(e => e.Destino).HasMaxLength(4000);
            entity.Property(e => e.DocTipo).HasMaxLength(100);
            entity.Property(e => e.Ec)
                .HasMaxLength(200)
                .HasColumnName("EC");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .HasColumnName("EMailAddress");
            entity.Property(e => e.Estado)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.FechaCreaciónSolicitud).HasColumnType("datetime");
            entity.Property(e => e.FechaLiquidación).HasColumnType("datetime");
            entity.Property(e => e.FechaModificaciónContacto).HasColumnType("datetime");
            entity.Property(e => e.FechaModificaciónSolicitud).HasColumnType("datetime");
            entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");
            entity.Property(e => e.Instancia).HasMaxLength(4000);
            entity.Property(e => e.JefeZonalAprobación)
                .HasMaxLength(100)
                .HasColumnName("Jefe Zonal Aprobación");
            entity.Property(e => e.JefeZonalLegajo)
                .HasMaxLength(50)
                .HasColumnName("Jefe Zonal Legajo");
            entity.Property(e => e.LegajoEc)
                .HasMaxLength(50)
                .HasColumnName("LegajoEC");
            entity.Property(e => e.Localidad).HasMaxLength(100);
            entity.Property(e => e.Municipio).HasMaxLength(100);
            entity.Property(e => e.Nacionalidad).HasMaxLength(250);
            entity.Property(e => e.Nif)
                .HasMaxLength(100)
                .HasColumnName("NIF");
            entity.Property(e => e.NivelDeExcepción).HasColumnName("Nivel de Excepción");
            entity.Property(e => e.Nombres).HasMaxLength(69);
            entity.Property(e => e.NúmeroDeCuotas).HasColumnName("Número de Cuotas");
            entity.Property(e => e.Origen)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PnetAgreement).HasColumnName("pnet_agreement");
            entity.Property(e => e.PnetCampaignResponseId).HasColumnName("pnet_CampaignResponseId");
            entity.Property(e => e.PnetCreditocongarantiafogaba).HasColumnName("pnet_creditocongarantiafogaba");
            entity.Property(e => e.PnetSiteVisitNumber).HasColumnName("pnet_SiteVisitNumber");
            entity.Property(e => e.PnetSuraccount).HasColumnName("pnet_SURaccount");
            entity.Property(e => e.Score).HasMaxLength(50);
            entity.Property(e => e.Solicitud).HasMaxLength(300);
            entity.Property(e => e.SolidezPatrimonial).HasColumnName("Solidez Patrimonial");
            entity.Property(e => e.SubInstancia).HasMaxLength(4000);
            entity.Property(e => e.SubTipoCrédito).HasMaxLength(4000);
            entity.Property(e => e.Subzona).HasMaxLength(200);
            entity.Property(e => e.Sucursal).HasMaxLength(160);
            entity.Property(e => e.SucursalCód).HasMaxLength(400);
            entity.Property(e => e.TasaAnual).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Tel1).HasMaxLength(100);
            entity.Property(e => e.Tel2).HasMaxLength(100);
            entity.Property(e => e.Tel3).HasMaxLength(100);
            entity.Property(e => e.Teléfono).HasMaxLength(50);
            entity.Property(e => e.TeléfonoConsolidado).HasMaxLength(100);
            entity.Property(e => e.TipoCrédito).HasMaxLength(4000);
            entity.Property(e => e.TipoFormulario).HasMaxLength(4000);
            entity.Property(e => e.Zona).HasMaxLength(4000);
        });

        modelBuilder.Entity<Solicitude1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Solicitudes", "int");

            entity.Property(e => e.Apellido).HasMaxLength(50);
            entity.Property(e => e.AreaCód1).HasMaxLength(4000);
            entity.Property(e => e.AreaCód2).HasMaxLength(4000);
            entity.Property(e => e.AreaCód3).HasMaxLength(4000);
            entity.Property(e => e.Bpbacalle)
                .HasMaxLength(100)
                .HasColumnName("BPBACalle");
            entity.Property(e => e.BpbacalleCp)
                .HasMaxLength(100)
                .HasColumnName("BPBACalleCP");
            entity.Property(e => e.BpbacalleNro)
                .HasMaxLength(100)
                .HasColumnName("BPBACalleNro");
            entity.Property(e => e.Bpbapersona)
                .HasMaxLength(100)
                .HasColumnName("BPBAPersona");
            entity.Property(e => e.CalificaBip).HasColumnName("CalificaBIP");
            entity.Property(e => e.Calle).HasMaxLength(250);
            entity.Property(e => e.CambioDeMeEvaluada).HasColumnName("Cambio de ME evaluada");
            entity.Property(e => e.Celular).HasMaxLength(53);
            entity.Property(e => e.ComportamientoProme).HasColumnName("Comportamiento PROME");
            entity.Property(e => e.CuotasPagasSN).HasColumnName("Cuotas pagas S/N");
            entity.Property(e => e.CómoSeEnteró)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("¿Cómo se enteró?");
            entity.Property(e => e.Destino)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DocTipo).HasMaxLength(100);
            entity.Property(e => e.Ec)
                .HasMaxLength(200)
                .HasColumnName("EC");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .HasColumnName("EMailAddress");
            entity.Property(e => e.Estado)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.FechaLiquidación).HasColumnType("datetime");
            entity.Property(e => e.FechaModificaciónContacto).HasColumnType("datetime");
            entity.Property(e => e.FechaModificaciónSolicitud).HasColumnType("datetime");
            entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");
            entity.Property(e => e.Instancia)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.JefeZonalAprobación)
                .HasMaxLength(100)
                .HasColumnName("Jefe Zonal Aprobación");
            entity.Property(e => e.JefeZonalLegajo).HasColumnName("Jefe Zonal Legajo");
            entity.Property(e => e.LegajoEc)
                .HasMaxLength(50)
                .HasColumnName("LegajoEC");
            entity.Property(e => e.Localidad).HasMaxLength(100);
            entity.Property(e => e.Municipio).HasMaxLength(100);
            entity.Property(e => e.Nacionalidad).HasMaxLength(250);
            entity.Property(e => e.Nif)
                .HasMaxLength(100)
                .HasColumnName("NIF");
            entity.Property(e => e.NivelDeExcepción).HasColumnName("Nivel de Excepción");
            entity.Property(e => e.Nombres).HasMaxLength(69);
            entity.Property(e => e.NúmeroDeCuotas).HasColumnName("Número de Cuotas");
            entity.Property(e => e.Origen)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PnetAgreement).HasColumnName("pnet_agreement");
            entity.Property(e => e.PnetCampaignResponseId).HasColumnName("pnet_CampaignResponseId");
            entity.Property(e => e.PnetCreditocongarantiafogaba).HasColumnName("pnet_creditocongarantiafogaba");
            entity.Property(e => e.PnetSiteVisitNumber).HasColumnName("pnet_SiteVisitNumber");
            entity.Property(e => e.PnetSuraccount).HasColumnName("pnet_SURaccount");
            entity.Property(e => e.Score).HasMaxLength(50);
            entity.Property(e => e.Solicitud).HasMaxLength(300);
            entity.Property(e => e.SolidezPatrimonial).HasColumnName("Solidez Patrimonial");
            entity.Property(e => e.SubInstancia)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.SubTipoCrédito)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Subzona).HasMaxLength(200);
            entity.Property(e => e.Sucursal).HasMaxLength(160);
            entity.Property(e => e.SucursalCód).HasMaxLength(400);
            entity.Property(e => e.TasaAnual).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Tel1).HasMaxLength(100);
            entity.Property(e => e.Tel2).HasMaxLength(100);
            entity.Property(e => e.Tel3).HasMaxLength(100);
            entity.Property(e => e.Teléfono).HasMaxLength(50);
            entity.Property(e => e.TeléfonoConsolidado).HasMaxLength(100);
            entity.Property(e => e.TipoCrédito)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.TipoFormulario)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Zona).HasMaxLength(4000);
        });

        modelBuilder.Entity<SolicitudesEstado>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SolicitudesEstados", "int");

            entity.Property(e => e.Estado)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.Estatus)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.FechaModificaciónSolicitud).HasColumnType("datetime");
            entity.Property(e => e.PnetSuraccount).HasColumnName("pnet_SURaccount");
            entity.Property(e => e.Solicitud).HasMaxLength(300);
        });

        modelBuilder.Entity<SolicitudesExtra>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SolicitudesExtras", "crm");

            entity.Property(e => e.Agro).HasColumnName("AGRO");
            entity.Property(e => e.AumentoDisminuciónCpCpa).HasColumnName("Aumento/Disminución CP/CPA");
            entity.Property(e => e.AutorizaciónJefeZonal).HasColumnName("Autorización Jefe Zonal");
            entity.Property(e => e.BasesNegativasObs).HasColumnName("Bases Negativas obs.");
            entity.Property(e => e.BkMicroEmpresa).HasColumnName("bkMicroEmpresa");
            entity.Property(e => e.CambioDeMeEvaluada).HasColumnName("Cambio de ME evaluada");
            entity.Property(e => e.CapacidadDePagoAjustadaMesAlto)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("Capacidad de Pago Ajustada Mes Alto ($)");
            entity.Property(e => e.CapacidadDePagoAjustadaMesBajo)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("Capacidad de Pago Ajustada Mes Bajo ($)");
            entity.Property(e => e.CapacidadDePagoAjustadaMesMedio)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("Capacidad de Pago Ajustada Mes Medio ($)");
            entity.Property(e => e.CapacidadDePagoEnElPeríodo)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("Capacidad de pago en el período ($)");
            entity.Property(e => e.CapacidadDePagoMesAlto)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("Capacidad de Pago Mes Alto ($)");
            entity.Property(e => e.CapacidadDePagoMesBajo)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("Capacidad de Pago Mes Bajo ($)");
            entity.Property(e => e.CapacidadDePagoMesMedio)
                .HasColumnType("numeric(23, 10)")
                .HasColumnName("Capacidad de Pago Mes Medio ($)");
            entity.Property(e => e.ClasificaciónDePermanencia)
                .HasMaxLength(20)
                .HasColumnName("Clasificación de Permanencia");
            entity.Property(e => e.ClasificaciónDePermanenciaMt)
                .HasMaxLength(20)
                .HasColumnName("Clasificación de Permanencia MT");
            entity.Property(e => e.ClasificaciónHistorialCrediticio)
                .HasMaxLength(20)
                .HasColumnName("Clasificación Historial Crediticio");
            entity.Property(e => e.ClasificaciónPatrimonial).HasColumnName("Clasificación Patrimonial");
            entity.Property(e => e.ComportamientoProme).HasColumnName("Comportamiento PROME");
            entity.Property(e => e.CostoVariableMesAlto).HasColumnName("Costo Variable Mes Alto ($)");
            entity.Property(e => e.CostoVariableMesBajo).HasColumnName("Costo Variable Mes Bajo ($)");
            entity.Property(e => e.CostoVariableMesMedio).HasColumnName("Costo Variable Mes Medio ($)");
            entity.Property(e => e.CuotasPagas).HasColumnName("Cuotas pagas");
            entity.Property(e => e.DentroDeCampaña).HasColumnName("Dentro de Campaña");
            entity.Property(e => e.DescripciónDelNegocio).HasColumnName("Descripción del Negocio");
            entity.Property(e => e.DestinoDelCrédito).HasColumnName("Destino del Crédito");
            entity.Property(e => e.DeudasHistorialCrediticioNivelEndeudamiento).HasColumnName("Deudas Historial Crediticio/Nivel endeudamiento");
            entity.Property(e => e.EducaciónPrivada).HasColumnName("Educación Privada ($)");
            entity.Property(e => e.EjecutivoColegiador)
                .HasMaxLength(100)
                .HasColumnName("Ejecutivo Colegiador");
            entity.Property(e => e.EjecutivoEvaluador)
                .HasMaxLength(100)
                .HasColumnName("Ejecutivo evaluador");
            entity.Property(e => e.EjecutivoSupervisor)
                .HasMaxLength(100)
                .HasColumnName("Ejecutivo Supervisor");
            entity.Property(e => e.FechaInscripciónAfip)
                .HasColumnType("datetime")
                .HasColumnName("Fecha Inscripción AFIP");
            entity.Property(e => e.FocoDeRiesgo).HasColumnName("Foco de Riesgo");
            entity.Property(e => e.FocoDeRiesgosYCómoSeMinimizan).HasColumnName("Foco de riesgos y cómo se minimizan");
            entity.Property(e => e.ImpactaSóloARm)
                .HasMaxLength(20)
                .HasColumnName("Impacta sólo a RM");
            entity.Property(e => e.MicroEmpresa).HasMaxLength(160);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.NúmeroDeClientesVariable).HasColumnName("Número de Clientes Variable (%)");
            entity.Property(e => e.NúmeroDeEmpleados).HasColumnName("Número de Empleados");
            entity.Property(e => e.ObservacionesDeCostosVariables).HasColumnName("Observaciones de Costos Variables");
            entity.Property(e => e.ObservacionesSobreComercialización).HasColumnName("Observaciones sobre Comercialización");
            entity.Property(e => e.ObservacionesSobreGrupoFamiliarVivienda).HasColumnName("Observaciones sobre Grupo Familiar/Vivienda");
            entity.Property(e => e.ObservacionesSobreHistorialCrediticio).HasColumnName("Observaciones sobre Historial Crediticio");
            entity.Property(e => e.ObservacionesSobrePermanenciaDelNegocio).HasColumnName("Observaciones sobre Permanencia del Negocio");
            entity.Property(e => e.ObservaciónSobreSolidezPatrimonial).HasColumnName("Observación sobre Solidez Patrimonial");
            entity.Property(e => e.OpCreditSubType)
                .HasMaxLength(50)
                .HasColumnName("OP Credit Sub Type");
            entity.Property(e => e.OtrosIngresos).HasColumnName("Otros Ingresos ($)");
            entity.Property(e => e.PermanenciaMeses).HasColumnName("Permanencia (meses)");
            entity.Property(e => e.PeríodoDeAmortización)
                .HasMaxLength(20)
                .HasColumnName("Período de Amortización");
            entity.Property(e => e.RequiereRiesgo).HasColumnName("Requiere Riesgo");
            entity.Property(e => e.ResultadosScoreDePuntaje)
                .HasMaxLength(20)
                .HasColumnName("Resultados Score De Puntaje");
            entity.Property(e => e.SistemaDeAmortización)
                .HasMaxLength(20)
                .HasColumnName("Sistema de Amortización");
            entity.Property(e => e.Solicitud).HasMaxLength(20);
            entity.Property(e => e.SubTotal).HasColumnName("Sub Total %");
            entity.Property(e => e.TasaDeInterésAnual).HasColumnName("Tasa de Interés Anual (%)");
            entity.Property(e => e.TipoDeCréditoOp)
                .HasMaxLength(50)
                .HasColumnName("Tipo de Crédito OP");
            entity.Property(e => e.TipoDeVivienda)
                .HasMaxLength(20)
                .HasColumnName("Tipo de Vivienda");
            entity.Property(e => e.Total).HasColumnName("Total ($)");
            entity.Property(e => e.Total1).HasColumnName("Total");
            entity.Property(e => e.Total11).HasColumnName("Total 1.1");
            entity.Property(e => e.TotalActivosFijos).HasColumnName("Total activos fijos ($)");
            entity.Property(e => e.TotalGastoFamiliar).HasColumnName("Total Gasto Familiar ($)");
            entity.Property(e => e.TotalGrupoFamiliar).HasColumnName("Total Grupo Familiar");
            entity.Property(e => e.TotalUS).HasColumnName("Total (u$s)");
            entity.Property(e => e.Vehículos).HasColumnName("Vehículos ($)");
        });

        modelBuilder.Entity<SolicitudesImpecabilidad>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SolicitudesImpecabilidad", "app");

            entity.Property(e => e.EjecutivoComercialIda).HasColumnName("Ejecutivo Comercial Ida");
            entity.Property(e => e.EjecutivoComercialVuelta).HasColumnName("Ejecutivo Comercial Vuelta");
            entity.Property(e => e.FilialProme).HasColumnName("FILIAL PROME");
            entity.Property(e => e.GeneracionEcAdmin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Generacion EC ADMIN");
            entity.Property(e => e.LegajoEcAdmin).HasColumnName("LEGAJO EC ADMIN");
            entity.Property(e => e.NombreEcAdmin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE EC ADMIN");
            entity.Property(e => e.Periodo)
                .HasColumnType("date")
                .HasColumnName("periodo");
            entity.Property(e => e.RechazadoBancoLiq).HasColumnName("Rechazado Banco Liq");
            entity.Property(e => e.RechazadoBancoQ).HasColumnName("Rechazado Banco Q");
            entity.Property(e => e.RechazadoQ).HasColumnName("Rechazado_Q");
            entity.Property(e => e.Semana).HasColumnName("semana");
            entity.Property(e => e.SubZonaNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUB ZONA NOMBRE");
            entity.Property(e => e.Sucursal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUCURSAL");
            entity.Property(e => e.Zona)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ZONA");
        });

        modelBuilder.Entity<SolicitudesInstancia>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SolicitudesInstancias", "int");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.InstanciaDestino).HasMaxLength(100);
            entity.Property(e => e.InstanciaOrigen).HasMaxLength(100);
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.PnetAssessImpeccability).HasColumnName("pnet_AssessImpeccability");
            entity.Property(e => e.Solicitud).HasMaxLength(100);
        });

        modelBuilder.Entity<SolicitudesLiquidadasHoy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SolicitudesLiquidadasHoy", "crm");

            entity.Property(e => e.FechaLiquidación).HasColumnType("datetime");
            entity.Property(e => e.FechaModificaciónSolicitud).HasColumnType("datetime");
            entity.Property(e => e.PnetSuraccount).HasColumnName("pnet_SURaccount");
            entity.Property(e => e.Solicitud).HasMaxLength(300);
        });

        modelBuilder.Entity<StringMapBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StringMapBase", "crm");

            entity.HasIndex(e => e.ObjectTypeCode, "StringMapBase-20210108-IDX");

            entity.Property(e => e.AttributeName).HasMaxLength(100);
            entity.Property(e => e.Value).HasMaxLength(4000);
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<SystemUserBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SystemUserBase", "crm");

            entity.HasIndex(e => new { e.SystemUserId, e.PositionId }, "SystemUserBase-20201107-ids");

            entity.Property(e => e.ApplicationIdUri).HasMaxLength(1024);
            entity.Property(e => e.AxxonAreaId).HasColumnName("axxon_AreaId");
            entity.Property(e => e.AxxonContacto).HasColumnName("axxon_contacto");
            entity.Property(e => e.AxxonEmpleadovip).HasColumnName("axxon_empleadovip");
            entity.Property(e => e.Caltype).HasColumnName("CALType");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DefaultOdbFolderName).HasMaxLength(200);
            entity.Property(e => e.DisabledReason).HasMaxLength(500);
            entity.Property(e => e.DomainName).HasMaxLength(1024);
            entity.Property(e => e.EmployeeId).HasMaxLength(100);
            entity.Property(e => e.ExchangeRate).HasColumnType("numeric(23, 10)");
            entity.Property(e => e.FirstName).HasMaxLength(64);
            entity.Property(e => e.FullName).HasMaxLength(200);
            entity.Property(e => e.GovernmentId).HasMaxLength(100);
            entity.Property(e => e.HomePhone).HasMaxLength(50);
            entity.Property(e => e.InternalEmailAddress)
                .HasMaxLength(100)
                .HasColumnName("InternalEMailAddress");
            entity.Property(e => e.IsEmailAddressApprovedByO365admin).HasColumnName("IsEmailAddressApprovedByO365Admin");
            entity.Property(e => e.JobTitle).HasMaxLength(100);
            entity.Property(e => e.LastName).HasMaxLength(64);
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.MobileAlertEmail)
                .HasMaxLength(100)
                .HasColumnName("MobileAlertEMail");
            entity.Property(e => e.MobilePhone).HasMaxLength(64);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.NickName).HasMaxLength(50);
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PersonalEmailAddress)
                .HasMaxLength(100)
                .HasColumnName("PersonalEMailAddress");
            entity.Property(e => e.PhotoUrl).HasMaxLength(200);
            entity.Property(e => e.PnetAmountUnder).HasColumnName("pnet_AmountUnder");
            entity.Property(e => e.PnetBpbaexecutiveId)
                .HasMaxLength(10)
                .HasColumnName("pnet_BPBAExecutiveID");
            entity.Property(e => e.PnetClass1).HasColumnName("pnet_Class1");
            entity.Property(e => e.PnetExcecutiveId).HasColumnName("pnet_ExcecutiveID");
            entity.Property(e => e.PnetFolder)
                .HasMaxLength(50)
                .HasColumnName("pnet_Folder");
            entity.Property(e => e.PnetGeneration).HasColumnName("pnet_Generation");
            entity.Property(e => e.PnetLaboralprofile).HasColumnName("pnet_Laboralprofile");
            entity.Property(e => e.PnetMiniTer).HasColumnName("pnet_MiniTer");
            entity.Property(e => e.PnetPanelSin).HasColumnName("pnet_PanelSIN");
            entity.Property(e => e.PnetPreviousCategory).HasColumnName("pnet_PreviousCategory");
            entity.Property(e => e.PnetRelSignatureId).HasColumnName("pnet_rel_SignatureId");
            entity.Property(e => e.PnetSpecialamountunder).HasColumnName("pnet_specialamountunder");
            entity.Property(e => e.PnetSubsidiary).HasColumnName("pnet_Subsidiary");
            entity.Property(e => e.PnetTerD).HasColumnName("pnet_TerD");
            entity.Property(e => e.PnetWorkPlanRisk).HasColumnName("pnet_WorkPlanRisk");
            entity.Property(e => e.PnetWorkPlanRiskYes).HasColumnName("pnet_WorkPlanRiskYES");
            entity.Property(e => e.Salutation).HasMaxLength(20);
            entity.Property(e => e.SharePointEmailAddress).HasMaxLength(1024);
            entity.Property(e => e.Skills).HasMaxLength(100);
            entity.Property(e => e.Title).HasMaxLength(128);
            entity.Property(e => e.TraversedPath).HasMaxLength(1250);
            entity.Property(e => e.UtcconversionTimeZoneCode).HasColumnName("UTCConversionTimeZoneCode");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.WindowsLiveId)
                .HasMaxLength(1024)
                .HasColumnName("WindowsLiveID");
            entity.Property(e => e.YammerEmailAddress).HasMaxLength(100);
            entity.Property(e => e.YammerUserId).HasMaxLength(64);
            entity.Property(e => e.YomiFirstName).HasMaxLength(64);
            entity.Property(e => e.YomiFullName).HasMaxLength(200);
            entity.Property(e => e.YomiLastName).HasMaxLength(64);
            entity.Property(e => e.YomiMiddleName).HasMaxLength(50);
        });

        modelBuilder.Entity<TcgKpi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tcgKpi", "app");

            entity.Property(e => e.Area).HasMaxLength(50);
            entity.Property(e => e.CalidadInfo).HasColumnType("numeric(14, 13)");
            entity.Property(e => e.Cumplimiento).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CumplimientoEsperado).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Desvío).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DesvíoEsfuerzo).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Esfuerzo).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.EsfuerzoAcumulado).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.EsfuerzoEstimado).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.EsfuerzoUnidad).HasMaxLength(16);
            entity.Property(e => e.IdObjetivo).HasColumnName("idObjetivo");
            entity.Property(e => e.IdObjetivoSuperior).HasColumnName("idObjetivoSuperior");
            entity.Property(e => e.Meta).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Periodo).HasColumnType("date");
        });

        modelBuilder.Entity<TcgMetrica>(entity =>
        {
            entity.HasKey(e => e.IdMetricas);

            entity.ToTable("tcgMetricas", "app");

            entity.Property(e => e.IdMetricas).HasColumnName("idMetricas");
            entity.Property(e => e.AvanceEstimado).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.EsfuerzoAcumulado).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.EsfuerzoEstimado).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.EsfuerzoUnidad).HasMaxLength(16);
            entity.Property(e => e.FechaCancelado).HasColumnType("date");
            entity.Property(e => e.FechaEntrega).HasColumnType("date");
            entity.Property(e => e.FechaInformada).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("date");
            entity.Property(e => e.FechaModificación).HasColumnType("datetime");
            entity.Property(e => e.IdObjetivo).HasColumnName("idObjetivo");
            entity.Property(e => e.Meta).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.ModificadoPor).HasMaxLength(50);
            entity.Property(e => e.Observaciones).HasMaxLength(2048);
            entity.Property(e => e.Periodo).HasColumnType("date");
            entity.Property(e => e.Stamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("stamp");
        });

        modelBuilder.Entity<TcgMetricasCalculo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("tcgMetricasCalculos", "app");

            entity.Property(e => e.Area)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AvanceEstimado).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CalidadInfo).HasColumnType("numeric(14, 13)");
            entity.Property(e => e.Cumplimiento).HasColumnType("numeric(38, 20)");
            entity.Property(e => e.CumplimientoEsperado).HasColumnType("numeric(38, 11)");
            entity.Property(e => e.DesvíoEsfuerzo).HasColumnType("numeric(38, 20)");
            entity.Property(e => e.EntregaEstimada).HasColumnType("date");
            entity.Property(e => e.EntregaProyectada).HasColumnType("date");
            entity.Property(e => e.Esfuerzo).HasColumnType("numeric(38, 20)");
            entity.Property(e => e.EsfuerzoAcumulado).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.EsfuerzoEstimado).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.EsfuerzoUnidad).HasMaxLength(16);
            entity.Property(e => e.FechaEntrega).HasColumnType("date");
            entity.Property(e => e.FechaInformada).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("date");
            entity.Property(e => e.IdObjetivo).HasColumnName("idObjetivo");
            entity.Property(e => e.IdObjetivoPredecesor).HasColumnName("idObjetivoPredecesor");
            entity.Property(e => e.Idmetricas).HasColumnName("idmetricas");
            entity.Property(e => e.Meta).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.NombreMétrica).HasMaxLength(255);
            entity.Property(e => e.Periodo).HasColumnType("date");
        });

        modelBuilder.Entity<TcgMetricasRecordatorio>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("tcgMetricasRecordatorio", "app");

            entity.Property(e => e.Mail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Periodo).HasColumnType("date");
            entity.Property(e => e.Q).HasColumnName("q");
        });

        modelBuilder.Entity<TcgObjetivo>(entity =>
        {
            entity.HasKey(e => e.IdObjetivo);

            entity.ToTable("tcgObjetivos", "app");

            entity.HasIndex(e => new { e.Area, e.NombreMétrica }, "tcgObjetivos-IDX1").IsUnique();

            entity.Property(e => e.IdObjetivo).HasColumnName("idObjetivo");
            entity.Property(e => e.Area)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripción).HasMaxLength(2048);
            entity.Property(e => e.FechaModificación).HasColumnType("datetime");
            entity.Property(e => e.IdObjetivoPredecesor).HasColumnName("idObjetivoPredecesor");
            entity.Property(e => e.ModificadoPor).HasMaxLength(50);
            entity.Property(e => e.NombreMétrica).HasMaxLength(255);
            entity.Property(e => e.Stamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("stamp");
        });

        modelBuilder.Entity<TeamBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TeamBase", "crm");

            entity.HasIndex(e => new { e.TeamId, e.BusinessUnitId }, "TeamBase-20201201-ids");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .HasColumnName("EMailAddress");
            entity.Property(e => e.ExchangeRate).HasColumnType("numeric(23, 10)");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(160);
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PnetBipcourse).HasColumnName("pnet_BIPCourse");
            entity.Property(e => e.PnetBpbabusinessunit)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAbusinessunit");
            entity.Property(e => e.PnetBpbasubsidiaryaddress)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAsubsidiaryaddress");
            entity.Property(e => e.PnetBpbasubsidiarydistrictlocality)
                .HasMaxLength(100)
                .HasColumnName("pnet_BPBAsubsidiarydistrictlocality");
            entity.Property(e => e.PnetBpbateamId).HasColumnName("pnet_BPBATeamId");
            entity.Property(e => e.PnetLinkage).HasColumnName("pnet_Linkage");
            entity.Property(e => e.PnetPrometeamCode)
                .HasMaxLength(400)
                .HasColumnName("pnet_PROMETeamCode");
            entity.Property(e => e.PnetSatellitesubsidiary).HasColumnName("pnet_satellitesubsidiary");
            entity.Property(e => e.PnetSubsidiaryCode)
                .HasMaxLength(100)
                .HasColumnName("pnet_SubsidiaryCode");
            entity.Property(e => e.PnetSubsidiaryIcode).HasColumnName("pnet_SubsidiaryICode");
            entity.Property(e => e.PnetTeamCounter).HasColumnName("pnet_TeamCounter");
            entity.Property(e => e.PnetTerritory).HasColumnName("pnet_territory");
            entity.Property(e => e.TraversedPath).HasMaxLength(1250);
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.YomiName).HasMaxLength(160);
        });

        modelBuilder.Entity<TecKpi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tecKpi", "app");

            entity.Property(e => e.Area).HasMaxLength(50);
            entity.Property(e => e.CalidadInfo).HasColumnType("numeric(14, 13)");
            entity.Property(e => e.Cumplimiento).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CumplimientoEsperado).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Desvío).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DesvíoEsfuerzo).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Esfuerzo).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.EsfuerzoAcumulado).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.EsfuerzoEstimado).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.EsfuerzoUnidad).HasMaxLength(16);
            entity.Property(e => e.IdObjetivo).HasColumnName("idObjetivo");
            entity.Property(e => e.IdObjetivoSuperior).HasColumnName("idObjetivoSuperior");
            entity.Property(e => e.Meta).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Periodo).HasColumnType("date");
        });

        modelBuilder.Entity<TecMetrica>(entity =>
        {
            entity.HasKey(e => e.IdMetricas);

            entity.ToTable("tecMetricas", "app");

            entity.Property(e => e.IdMetricas).HasColumnName("idMetricas");
            entity.Property(e => e.AvanceEstimado).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.EsfuerzoAcumulado).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.EsfuerzoEstimado).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.EsfuerzoUnidad).HasMaxLength(16);
            entity.Property(e => e.FechaCancelado).HasColumnType("date");
            entity.Property(e => e.FechaEntrega).HasColumnType("date");
            entity.Property(e => e.FechaInformada).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("date");
            entity.Property(e => e.FechaModificación).HasColumnType("datetime");
            entity.Property(e => e.IdObjetivo).HasColumnName("idObjetivo");
            entity.Property(e => e.Meta).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.ModificadoPor).HasMaxLength(50);
            entity.Property(e => e.Observaciones).HasMaxLength(2048);
            entity.Property(e => e.Periodo).HasColumnType("date");
            entity.Property(e => e.Stamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("stamp");
        });

        modelBuilder.Entity<TecMetricasCalculo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("tecMetricasCalculos", "app");

            entity.Property(e => e.Area)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AvanceEstimado).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CalidadInfo).HasColumnType("numeric(14, 13)");
            entity.Property(e => e.Cumplimiento).HasColumnType("numeric(38, 20)");
            entity.Property(e => e.CumplimientoEsperado).HasColumnType("numeric(38, 11)");
            entity.Property(e => e.DesvíoEsfuerzo).HasColumnType("numeric(38, 20)");
            entity.Property(e => e.EntregaEstimada).HasColumnType("date");
            entity.Property(e => e.EntregaProyectada).HasColumnType("date");
            entity.Property(e => e.Esfuerzo).HasColumnType("numeric(38, 20)");
            entity.Property(e => e.EsfuerzoAcumulado).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.EsfuerzoEstimado).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.EsfuerzoUnidad).HasMaxLength(16);
            entity.Property(e => e.FechaEntrega).HasColumnType("date");
            entity.Property(e => e.FechaInformada).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("date");
            entity.Property(e => e.IdObjetivo).HasColumnName("idObjetivo");
            entity.Property(e => e.IdObjetivoPredecesor).HasColumnName("idObjetivoPredecesor");
            entity.Property(e => e.Idmetricas).HasColumnName("idmetricas");
            entity.Property(e => e.Meta).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.NombreMétrica).HasMaxLength(255);
            entity.Property(e => e.Periodo).HasColumnType("date");
        });

        modelBuilder.Entity<TecMetricasRecordatorio>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("tecMetricasRecordatorio", "app");

            entity.Property(e => e.Mail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Periodo).HasColumnType("date");
            entity.Property(e => e.Q).HasColumnName("q");
        });

        modelBuilder.Entity<TecObjetivo>(entity =>
        {
            entity.HasKey(e => e.IdObjetivo);

            entity.ToTable("tecObjetivos", "app");

            entity.Property(e => e.IdObjetivo).HasColumnName("idObjetivo");
            entity.Property(e => e.Area)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripción).HasMaxLength(2048);
            entity.Property(e => e.FechaModificación).HasColumnType("datetime");
            entity.Property(e => e.IdObjetivoPredecesor).HasColumnName("idObjetivoPredecesor");
            entity.Property(e => e.ModificadoPor).HasMaxLength(50);
            entity.Property(e => e.NombreMétrica).HasMaxLength(255);
            entity.Property(e => e.Stamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("stamp");
        });

        modelBuilder.Entity<Telefono>(entity =>
        {
            entity.HasKey(e => new { e.IdTelefono, e.IdPersona }).HasName("PK_appTelefono");

            entity.ToTable("Telefono", "app");

            entity.Property(e => e.IdTelefono).ValueGeneratedOnAdd();
            entity.Property(e => e.Corregido).HasColumnName("corregido");
            entity.Property(e => e.FechaCreación)
                .HasColumnType("date")
                .HasColumnName("Fecha Creación");
            entity.Property(e => e.FechaModificación)
                .HasColumnType("date")
                .HasColumnName("Fecha Modificación");
            entity.Property(e => e.NroLocal)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nro local");
            entity.Property(e => e.Numero)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("numero");
            entity.Property(e => e.Origen)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("origen");
            entity.Property(e => e.Recibido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("recibido");
            entity.Property(e => e.SkNomina).HasColumnName("skNomina");
            entity.Property(e => e.TipoContacto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tipo contacto");
            entity.Property(e => e.Área)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("área");
        });

        modelBuilder.Entity<TerritoryBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TerritoryBase", "crm");

            entity.HasIndex(e => e.TerritoryId, "TerritoryBase-20201203-ids");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ExchangeRate).HasColumnType("numeric(23, 10)");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.OverriddenCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(8)
                .IsFixedLength();
        });

        modelBuilder.Entity<Ubicacione>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Ubicaciones", "app");

            entity.Property(e => e.PnetDistrict)
                .HasMaxLength(100)
                .HasColumnName("pnet_District");
            entity.Property(e => e.PnetName)
                .HasMaxLength(100)
                .HasColumnName("pnet_name");
            entity.Property(e => e.PnetZone)
                .HasMaxLength(100)
                .HasColumnName("pnet_Zone");
        });

        modelBuilder.Entity<UsuariosProme>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("UsuariosProme", "crm");

            entity.Property(e => e.Caltype).HasColumnName("CALType");
            entity.Property(e => e.DomainName).HasMaxLength(1024);
            entity.Property(e => e.FullName).HasMaxLength(200);
            entity.Property(e => e.InternalEmailAddress)
                .HasMaxLength(100)
                .HasColumnName("InternalEMailAddress");
            entity.Property(e => e.Legajo).HasMaxLength(50);
        });

        modelBuilder.Entity<VerazExperto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VerazExperto", "app");

            entity.Property(e => e.Cad)
                .HasMaxLength(4000)
                .HasColumnName("CAD");
            entity.Property(e => e.Campaña)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CantChSf24m)
                .HasMaxLength(4000)
                .HasColumnName("CANT_CH_SF_24M");
            entity.Property(e => e.Categoria)
                .HasMaxLength(4000)
                .HasColumnName("categoria");
            entity.Property(e => e.CompromisoMensual)
                .HasMaxLength(4000)
                .HasColumnName("compromiso_mensual");
            entity.Property(e => e.Cp)
                .HasMaxLength(4000)
                .HasColumnName("CP");
            entity.Property(e => e.Ctc)
                .HasMaxLength(4000)
                .HasColumnName("CTC");
            entity.Property(e => e.Cuota)
                .HasMaxLength(4000)
                .HasColumnName("cuota");
            entity.Property(e => e.Dmp)
                .HasMaxLength(4000)
                .HasColumnName("DMP");
            entity.Property(e => e.Dni)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("DNI");
            entity.Property(e => e.Explicacion)
                .HasMaxLength(4000)
                .HasColumnName("explicacion");
            entity.Property(e => e.Fecha)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FechaConsulta)
                .HasColumnType("date")
                .HasColumnName("fechaConsulta");
            entity.Property(e => e.Ip)
                .HasMaxLength(4000)
                .HasColumnName("IP");
            entity.Property(e => e.Nombre)
                .HasMaxLength(101)
                .IsUnicode(false);
            entity.Property(e => e.Oferta)
                .HasMaxLength(4000)
                .HasColumnName("oferta");
            entity.Property(e => e.PeorSitBcra24m)
                .HasMaxLength(4000)
                .HasColumnName("PEOR_SIT_BCRA_24M");
            entity.Property(e => e.PeorSitBcra6m)
                .HasMaxLength(4000)
                .HasColumnName("PEOR_SIT_BCRA_6M");
            entity.Property(e => e.PeorSitBureau24m)
                .HasMaxLength(4000)
                .HasColumnName("PEOR_SIT_BUREAU_24M");
            entity.Property(e => e.PeorSitBureau6m)
                .HasMaxLength(4000)
                .HasColumnName("PEOR_SIT_BUREAU_6M");
            entity.Property(e => e.Poblacion)
                .HasMaxLength(4000)
                .HasColumnName("poblacion");
            entity.Property(e => e.PrestamoMaximo)
                .HasMaxLength(4000)
                .HasColumnName("prestamo_maximo");
            entity.Property(e => e.Score)
                .HasMaxLength(4000)
                .HasColumnName("score");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("sexo");
            entity.Property(e => e.Sucursal)
                .HasMaxLength(103)
                .IsUnicode(false)
                .HasColumnName("SUCURSAL");
            entity.Property(e => e.SumAutCc)
                .HasMaxLength(4000)
                .HasColumnName("SUM_AUT_CC");
            entity.Property(e => e.SumCuotasAPagarPg)
                .HasMaxLength(4000)
                .HasColumnName("SUM_CUOTAS_A_PAGAR_PG");
            entity.Property(e => e.SumCuotasAPagarPre)
                .HasMaxLength(4000)
                .HasColumnName("SUM_CUOTAS_A_PAGAR_PRE");
            entity.Property(e => e.SumCuotasAPagarPsg)
                .HasMaxLength(4000)
                .HasColumnName("SUM_CUOTAS_A_PAGAR_PSG");
            entity.Property(e => e.SumLimTc)
                .HasMaxLength(4000)
                .HasColumnName("SUM_LIM_TC");
            entity.Property(e => e.SumPagMinTc)
                .HasMaxLength(4000)
                .HasColumnName("SUM_PAG_MIN_TC");
            entity.Property(e => e.SumSalTotTc)
                .HasMaxLength(4000)
                .HasColumnName("SUM_SAL_TOT_TC");
            entity.Property(e => e.SumSaldoPromCc)
                .HasMaxLength(4000)
                .HasColumnName("SUM_SALDO_PROM_CC");
            entity.Property(e => e.SumSaldosPpsg)
                .HasMaxLength(4000)
                .HasColumnName("SUM_SALDOS_PPSG");
            entity.Property(e => e.Va)
                .HasMaxLength(4000)
                .HasColumnName("VA");
            entity.Property(e => e.Visita)
                .HasMaxLength(4000)
                .HasColumnName("visita");
            entity.Property(e => e.Zona)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("zona");
        });

        modelBuilder.Entity<VerazExpertoCrm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VerazExpertoCRM", "app");

            entity.Property(e => e.ArchivoOriginal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Archivo Original");
            entity.Property(e => e.Campaña)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Categoria)
                .HasMaxLength(4000)
                .HasColumnName("categoria");
            entity.Property(e => e.Cuota)
                .HasMaxLength(4000)
                .HasColumnName("cuota");
            entity.Property(e => e.Dni).HasColumnName("DNI");
            entity.Property(e => e.Explicacion)
                .HasMaxLength(4000)
                .HasColumnName("explicacion");
            entity.Property(e => e.FechaConsulta)
                .HasColumnType("date")
                .HasColumnName("fechaConsulta");
            entity.Property(e => e.FechaOval)
                .HasColumnType("datetime")
                .HasColumnName("Fecha Oval");
            entity.Property(e => e.LineaIntegracion)
                .HasMaxLength(518)
                .HasColumnName("lineaIntegracion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(101)
                .IsUnicode(false);
            entity.Property(e => e.Oval)
                .HasMaxLength(128)
                .HasColumnName("oval");
            entity.Property(e => e.PrestamoMaximo)
                .HasMaxLength(4000)
                .HasColumnName("prestamo_maximo");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("sexo");
            entity.Property(e => e.Sucursal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUCURSAL");
            entity.Property(e => e.SucursalOrigen)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Zona)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("zona");
        });

        modelBuilder.Entity<VerazExpertoIc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VerazExpertoIC", "app");

            entity.Property(e => e.Cad)
                .HasMaxLength(4000)
                .HasColumnName("CAD");
            entity.Property(e => e.Campaña)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CantChSf24m)
                .HasMaxLength(4000)
                .HasColumnName("CANT_CH_SF_24M");
            entity.Property(e => e.Categoria)
                .HasMaxLength(4000)
                .HasColumnName("categoria");
            entity.Property(e => e.CompromisoMensual)
                .HasMaxLength(4000)
                .HasColumnName("compromiso_mensual");
            entity.Property(e => e.Cp)
                .HasMaxLength(4000)
                .HasColumnName("CP");
            entity.Property(e => e.Ctc)
                .HasMaxLength(4000)
                .HasColumnName("CTC");
            entity.Property(e => e.Cuota)
                .HasMaxLength(4000)
                .HasColumnName("cuota");
            entity.Property(e => e.Dmp)
                .HasMaxLength(4000)
                .HasColumnName("DMP");
            entity.Property(e => e.Dni).HasColumnName("DNI");
            entity.Property(e => e.Explicacion)
                .HasMaxLength(4000)
                .HasColumnName("explicacion");
            entity.Property(e => e.FechaConsulta)
                .HasColumnType("date")
                .HasColumnName("fechaConsulta");
            entity.Property(e => e.Ip)
                .HasMaxLength(4000)
                .HasColumnName("IP");
            entity.Property(e => e.Nombre)
                .HasMaxLength(101)
                .IsUnicode(false);
            entity.Property(e => e.Oferta)
                .HasMaxLength(4000)
                .HasColumnName("oferta");
            entity.Property(e => e.PeorSitBcra24m)
                .HasMaxLength(4000)
                .HasColumnName("PEOR_SIT_BCRA_24M");
            entity.Property(e => e.PeorSitBcra6m)
                .HasMaxLength(4000)
                .HasColumnName("PEOR_SIT_BCRA_6M");
            entity.Property(e => e.PeorSitBureau24m)
                .HasMaxLength(4000)
                .HasColumnName("PEOR_SIT_BUREAU_24M");
            entity.Property(e => e.PeorSitBureau6m)
                .HasMaxLength(4000)
                .HasColumnName("PEOR_SIT_BUREAU_6M");
            entity.Property(e => e.Poblacion)
                .HasMaxLength(4000)
                .HasColumnName("poblacion");
            entity.Property(e => e.PrestamoMaximo)
                .HasMaxLength(4000)
                .HasColumnName("prestamo_maximo");
            entity.Property(e => e.Score)
                .HasMaxLength(4000)
                .HasColumnName("score");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("sexo");
            entity.Property(e => e.Sucursal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUCURSAL");
            entity.Property(e => e.SucursalOrigen)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SumAutCc)
                .HasMaxLength(4000)
                .HasColumnName("SUM_AUT_CC");
            entity.Property(e => e.SumCuotasAPagarPg)
                .HasMaxLength(4000)
                .HasColumnName("SUM_CUOTAS_A_PAGAR_PG");
            entity.Property(e => e.SumCuotasAPagarPre)
                .HasMaxLength(4000)
                .HasColumnName("SUM_CUOTAS_A_PAGAR_PRE");
            entity.Property(e => e.SumCuotasAPagarPsg)
                .HasMaxLength(4000)
                .HasColumnName("SUM_CUOTAS_A_PAGAR_PSG");
            entity.Property(e => e.SumLimTc)
                .HasMaxLength(4000)
                .HasColumnName("SUM_LIM_TC");
            entity.Property(e => e.SumPagMinTc)
                .HasMaxLength(4000)
                .HasColumnName("SUM_PAG_MIN_TC");
            entity.Property(e => e.SumSalTotTc)
                .HasMaxLength(4000)
                .HasColumnName("SUM_SAL_TOT_TC");
            entity.Property(e => e.SumSaldoPromCc)
                .HasMaxLength(4000)
                .HasColumnName("SUM_SALDO_PROM_CC");
            entity.Property(e => e.SumSaldosPpsg)
                .HasMaxLength(4000)
                .HasColumnName("SUM_SALDOS_PPSG");
            entity.Property(e => e.Va)
                .HasMaxLength(4000)
                .HasColumnName("VA");
            entity.Property(e => e.Visita)
                .HasMaxLength(4000)
                .HasColumnName("visita");
            entity.Property(e => e.Zona)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("zona");
        });

        modelBuilder.Entity<VerazOvale>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VerazOvales", "app");

            entity.Property(e => e.AssignedTeam)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Categoria)
                .HasMaxLength(4000)
                .HasColumnName("categoria");
            entity.Property(e => e.ConVisita)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.CreditAmount).HasColumnType("money");
            entity.Property(e => e.CreditSubtype)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CuotaVeraz)
                .HasColumnType("money")
                .HasColumnName("cuotaVeraz");
            entity.Property(e => e.FechaConsulta)
                .HasColumnType("date")
                .HasColumnName("fechaConsulta");
            entity.Property(e => e.OfertaVeraz)
                .HasColumnType("money")
                .HasColumnName("ofertaVeraz");
            entity.Property(e => e.OfferCode).HasColumnType("money");
            entity.Property(e => e.QuotaAmount).HasColumnType("money");
            entity.Property(e => e.ToTeam)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Zone)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Zonificación>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Zonificación", "crm");

            entity.Property(e => e.FilialBpba)
                .HasMaxLength(100)
                .HasColumnName("Filial BPBA");
            entity.Property(e => e.Subzona).HasMaxLength(200);
            entity.Property(e => e.Sucursal).HasMaxLength(160);
            entity.Property(e => e.SucursalCódigo)
                .HasMaxLength(400)
                .HasColumnName("Sucursal Código");
            entity.Property(e => e.Zona).HasMaxLength(160);
        });

        modelBuilder.Entity<ZzDomiciliosCrm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zzDomiciliosCRM", "int");

            entity.Property(e => e.Calle).HasColumnType("date");
            entity.Property(e => e.City).HasColumnType("date");
            entity.Property(e => e.Composite).HasColumnType("ntext");
            entity.Property(e => e.DocTipo).HasMaxLength(10);
            entity.Property(e => e.Line1).HasColumnType("date");
            entity.Property(e => e.Localidad).HasColumnType("date");
            entity.Property(e => e.Municipio).HasColumnType("date");
            entity.Property(e => e.PnetConsolidatePhone1)
                .HasColumnType("date")
                .HasColumnName("pnet_ConsolidatePhone1");
            entity.Property(e => e.PnetConsolidatePhone2)
                .HasColumnType("date")
                .HasColumnName("pnet_ConsolidatePhone2");
            entity.Property(e => e.PnetConsolidatePhone3)
                .HasColumnType("date")
                .HasColumnName("pnet_ConsolidatePhone3");
            entity.Property(e => e.PnetConsolidatePhone4)
                .HasColumnType("date")
                .HasColumnName("pnet_ConsolidatePhone4");
            entity.Property(e => e.PnetDocumentNumber).HasColumnName("pnet_DocumentNumber");
            entity.Property(e => e.PostalCode).HasColumnType("date");
            entity.Property(e => e.StateOrProvince).HasColumnType("date");
            entity.Property(e => e.Zona).HasColumnType("date");
        });

        modelBuilder.Entity<ZzReporteEnlace>(entity =>
        {
            entity.HasKey(e => e.IdEnlace).HasName("PK_ReporteEnlace");

            entity.ToTable("zzReporteEnlace", "app");

            entity.Property(e => e.Area).HasMaxLength(50);
            entity.Property(e => e.Enlace).HasMaxLength(1024);
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.ModificadoPor).HasMaxLength(50);
            entity.Property(e => e.Pagina).HasMaxLength(100);
        });

        modelBuilder.Entity<ZzReporteFiltro>(entity =>
        {
            entity.HasKey(e => e.IdFiltro).HasName("PK_ReporteFiltro");

            entity.ToTable("zzReporteFiltro", "app");

            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreNivel)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.RefFiltroNavigation).WithMany(p => p.InverseRefFiltroNavigation)
                .HasForeignKey(d => d.RefFiltro)
                .HasConstraintName("FK_ReporteFiltro_ReporteFiltro");
        });

        modelBuilder.Entity<ZzSolicitudesEstado>(entity =>
        {
            entity.HasKey(e => e.IdSolicitudEstado).HasName("PK_SolicitudesEstados");

            entity.ToTable("zzSolicitudesEstados", "app");

            entity.Property(e => e.FechaEstado)
                .HasColumnType("datetime")
                .HasColumnName("fechaEstado");
            entity.Property(e => e.OpportunityBaseCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Periodo).HasColumnType("date");
            entity.Property(e => e.PnetAssessImpeccability).HasColumnName("pnet_AssessImpeccability");
            entity.Property(e => e.PnetComment).HasColumnName("pnet_Comment");
            entity.Property(e => e.PnetEffectiveDateLiquidation)
                .HasColumnType("datetime")
                .HasColumnName("pnet_EffectiveDateLiquidation");
            entity.Property(e => e.PnetInstancesId).HasColumnName("pnet_InstancesId");
            entity.Property(e => e.PnetName)
                .HasMaxLength(100)
                .HasColumnName("pnet_name");
            entity.Property(e => e.PnetPreviousState)
                .HasMaxLength(100)
                .HasColumnName("pnet_PreviousState");
            entity.Property(e => e.PnetResultState)
                .HasMaxLength(100)
                .HasColumnName("pnet_ResultState");
        });

        modelBuilder.Entity<ZzSolicitudesHistorico>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zzSolicitudesHistorico", "app");

            entity.HasIndex(e => new { e.Periodo, e.Solicitud }, "IDX_SolicitudesHistorico_Ids");

            entity.HasIndex(e => e.Periodo, "IDX_SolicitudesHistorico_Periodo");

            entity.Property(e => e.FechaApertura)
                .HasColumnType("date")
                .HasColumnName("FECHA APERTURA");
            entity.Property(e => e.FechaOtorgamiento)
                .HasColumnType("date")
                .HasColumnName("FECHA OTORGAMIENTO");
            entity.Property(e => e.FilialBpba).HasColumnName("FILIAL BPBA");
            entity.Property(e => e.FilialProme).HasColumnName("FILIAL PROME");
            entity.Property(e => e.GeneracionEcAdmin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Generacion EC ADMIN");
            entity.Property(e => e.LegajoEcAdmin).HasColumnName("LEGAJO EC ADMIN");
            entity.Property(e => e.LegajoEcAsigna).HasColumnName("LEGAJO EC ASIGNA");
            entity.Property(e => e.LegajoEcEval).HasColumnName("LEGAJO EC EVAL");
            entity.Property(e => e.MontoOtorgado)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("MONTO OTORGADO");
            entity.Property(e => e.NombreCliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE CLIENTE");
            entity.Property(e => e.NombreEcAdmin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE EC ADMIN");
            entity.Property(e => e.NombreEcAsigna)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE EC ASIGNA");
            entity.Property(e => e.NombreEcEval)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE EC EVAL");
            entity.Property(e => e.NroCtaSur).HasColumnName("NRO CTA SUR");
            entity.Property(e => e.Periodo).HasColumnType("date");
            entity.Property(e => e.Plazo).HasColumnName("PLAZO");
            entity.Property(e => e.Solicitud).HasColumnName("SOLICITUD");
            entity.Property(e => e.SubTipoCredito)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUB TIPO CREDITO");
            entity.Property(e => e.SubZonaId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUB ZONA ID");
            entity.Property(e => e.SubZonaNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUB ZONA NOMBRE");
            entity.Property(e => e.Sucursal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUCURSAL");
            entity.Property(e => e.Tasa)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("TASA");
            entity.Property(e => e.TipCtaSur).HasColumnName("TIP CTA SUR");
            entity.Property(e => e.Zona)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ZONA");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
