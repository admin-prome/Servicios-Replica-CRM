using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class Attribute
{
    public Guid? AttributeId { get; set; }

    public Guid? AttributeTypeId { get; set; }

    public string? Name { get; set; }

    public string? PhysicalName { get; set; }

    public int? Length { get; set; }

    public bool? IsNullable { get; set; }

    public string? XmlAbbreviation { get; set; }

    public Guid? EntityId { get; set; }

    public string? DefaultValue { get; set; }

    public int? ColumnNumber { get; set; }

    public bool? ValidForUpdateApi { get; set; }

    public string? LogicalName { get; set; }

    public bool? ValidForReadApi { get; set; }

    public bool? ValidForCreateApi { get; set; }

    public bool? VisibleToPlatform { get; set; }

    public bool? IsPkattribute { get; set; }

    public bool? IsCustomField { get; set; }

    public bool? IsLogical { get; set; }

    public int? DisplayMask { get; set; }

    public Guid? AttributeOf { get; set; }

    public int? ReferencedEntityObjectTypeCode { get; set; }

    public Guid? AggregateOf { get; set; }

    public bool? IsSortAttribute { get; set; }

    public byte? PrecisionValue { get; set; }

    public byte? PrecisionSource { get; set; }

    public bool? IsIdentity { get; set; }

    public bool? IsReplicated { get; set; }

    public byte[]? VersionNumber { get; set; }

    public Guid? YomiOf { get; set; }

    public Guid? AttributeRowId { get; set; }

    public int? AppDefaultValue { get; set; }

    public string? AttributeLogicalTypeId { get; set; }

    public bool? Locked { get; set; }

    public string? AttributeImeModeId { get; set; }

    public string? AttributeRequiredLevelId { get; set; }

    public int? MaxLength { get; set; }

    public double? MinValue { get; set; }

    public double? MaxValue { get; set; }

    public int? Accuracy { get; set; }

    public int? AccuracySource { get; set; }

    public string? LookupStyle { get; set; }

    public bool? LookupBrowse { get; set; }

    public string? ImeMode { get; set; }

    public bool? HasMultipleLabels { get; set; }

    public bool? IsRowGuidAttribute { get; set; }

    public bool? IsBaseCurrency { get; set; }

    public Guid? CalculationOf { get; set; }

    public bool? IsAuditEnabled { get; set; }

    public string? UpgradeDefaultValue { get; set; }

    public Guid? OptionSetId { get; set; }

    public Guid? SolutionId { get; set; }

    public Guid? SupportingSolutionId { get; set; }

    public byte? ComponentState { get; set; }

    public DateTime? OverwriteTime { get; set; }

    public Guid? LinkedAttributeId { get; set; }

    public Guid? InheritsFrom { get; set; }

    public bool? IsStoredOnPrimaryTable { get; set; }

    public bool? IsInheritanceTypeAttribute { get; set; }

    public string? TableColumnName { get; set; }

    public bool? IsUnmanagedAttribute { get; set; }

    public bool? IsOneWayBooleanAttribute { get; set; }

    public bool? IsCustomizable { get; set; }

    public bool? IsRenameable { get; set; }

    public bool? CanModifySearchSettings { get; set; }

    public bool? CanModifyRequirementLevelSettings { get; set; }

    public bool? CanBeSecuredForCreate { get; set; }

    public bool? CanBeSecuredForRead { get; set; }

    public bool? CanBeSecuredForUpdate { get; set; }

    public bool? IsSecured { get; set; }

    public string? DeprecatedVersion { get; set; }

    public bool? IsManaged { get; set; }

    public string? ManagedPropertyLogicalName { get; set; }

    public int? ManagedPropertyParentComponentType { get; set; }

    public string? ManagedPropertyParentAttributeName { get; set; }

    public bool? CanModifyAdditionalSettings { get; set; }

    public Guid? ValuesFromRelationshipAttribute { get; set; }

    public bool? CanModifyAuditSettings { get; set; }

    public string? IntroducedVersion { get; set; }

    public bool? IsEncrypted { get; set; }

    public int? SourceType { get; set; }

    public string? FormulaDefinition { get; set; }

    public int? SourceTypeMask { get; set; }

    public int? Behavior { get; set; }

    public bool? CanModifyBehavior { get; set; }

    public bool? CanModifyGlobalFilterSettings { get; set; }

    public bool? CanModifyIsSortableSettings { get; set; }

    public bool? IsGlobalFilterEnabled { get; set; }

    public bool? IsSearchable { get; set; }

    public bool? IsFilterable { get; set; }

    public bool? IsRetrievable { get; set; }

    public bool? IsFilterableSetBySystem { get; set; }

    public bool? IsRetrievableSetBySystem { get; set; }

    public bool? IsSortableEnabled { get; set; }

    public bool? IsActive { get; set; }
}
