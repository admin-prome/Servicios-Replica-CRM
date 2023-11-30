using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class TeamBase
{
    public Guid? TeamId { get; set; }

    public Guid? OrganizationId { get; set; }

    public Guid? BusinessUnitId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? EmailAddress { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ModifiedBy { get; set; }

    public byte[]? VersionNumber { get; set; }

    public int? ImportSequenceNumber { get; set; }

    public DateTime? OverriddenCreatedOn { get; set; }

    public bool? IsDefault { get; set; }

    public Guid? AdministratorId { get; set; }

    public Guid? QueueId { get; set; }

    public decimal? ExchangeRate { get; set; }

    public Guid? ModifiedOnBehalfBy { get; set; }

    public Guid? CreatedOnBehalfBy { get; set; }

    public Guid? TransactionCurrencyId { get; set; }

    public string? YomiName { get; set; }

    public Guid? RegardingObjectId { get; set; }

    public int? TeamType { get; set; }

    public Guid? ProcessId { get; set; }

    public bool? SystemManaged { get; set; }

    public Guid? StageId { get; set; }

    public Guid? TeamTemplateId { get; set; }

    public int? RegardingObjectTypeCode { get; set; }

    public string? TraversedPath { get; set; }

    public string? PnetSubsidiaryCode { get; set; }

    public string? PnetBpbabusinessunit { get; set; }

    public string? PnetBpbasubsidiaryaddress { get; set; }

    public string? PnetBpbasubsidiarydistrictlocality { get; set; }

    public int? PnetSubsidiaryIcode { get; set; }

    public Guid? PnetBpbateamId { get; set; }

    public string? PnetPrometeamCode { get; set; }

    public int? PnetTeamCounter { get; set; }

    public bool? PnetSatellitesubsidiary { get; set; }

    public bool? PnetBipcourse { get; set; }

    public bool? PnetLinkage { get; set; }

    public Guid? PnetTerritory { get; set; }
}
