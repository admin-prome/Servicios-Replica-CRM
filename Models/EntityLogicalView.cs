using System;
using System.Collections.Generic;

namespace FogabaMailService.Models;

public partial class EntityLogicalView
{
    public Guid? EntityId { get; set; }

    public string? Name { get; set; }

    public int? ObjectTypeCode { get; set; }

    public string? PhysicalName { get; set; }

    public string? LogicalName { get; set; }

    public string? CollectionName { get; set; }

    public string? BaseTableName { get; set; }

    public string? LogicalCollectionName { get; set; }

    public bool? IsIntersect { get; set; }

    public bool? IsSecurityIntersect { get; set; }

    public bool? IsLookupTable { get; set; }

    public int? EventMask { get; set; }

    public bool? IsLogicalEntity { get; set; }

    public bool? IsCustomizable { get; set; }

    public bool? IsCollaboration { get; set; }

    public bool? IsActivity { get; set; }

    public string? AddressTableName { get; set; }

    public bool? IsMappable { get; set; }

    public int? OwnershipTypeMask { get; set; }

    public bool? IsAudited { get; set; }

    public bool? UsesFullnameConventionRules { get; set; }

    public bool? IsParented { get; set; }

    public int? EntityMask { get; set; }

    public bool? IsReplicated { get; set; }

    public bool? IsReplicationUserFiltered { get; set; }

    public bool? IsChildEntity { get; set; }

    public bool? IsCustomEntity { get; set; }

    public bool? IsActivityParty { get; set; }

    public bool? IsValidForAdvancedFind { get; set; }

    public string? ExtensionTableName { get; set; }

    public byte[]? VersionNumber { get; set; }

    public string? ReportViewName { get; set; }

    public bool? IsRequiredOffline { get; set; }

    public bool? IsRenameable { get; set; }

    public string? EntityClassName { get; set; }

    public string? ServiceClassName { get; set; }

    public string? EntityAssembly { get; set; }

    public string? ServiceAssembly { get; set; }

    public Guid? EntityRowId { get; set; }

    public bool? IsDuplicateCheckSupported { get; set; }

    public bool? IsImportable { get; set; }

    public bool? IsShareableAcrossOrgs { get; set; }

    public bool? IsPublishable { get; set; }

    public string? OriginalLocalizedName { get; set; }

    public string? OriginalLocalizedCollectionName { get; set; }

    public bool? CanTriggerWorkflow { get; set; }

    public int? WorkflowSupport { get; set; }

    public bool? CanBeChildInCustomRelationship { get; set; }

    public bool? CanBeInCustomEntityAssociation { get; set; }

    public bool? CanBeInCustomReflexiveRelationship { get; set; }

    public bool? IsMailMergeEnabled { get; set; }

    public int? RecurrenceTypeMask { get; set; }

    public Guid? RecurrenceBaseEntityId { get; set; }

    public bool? IsDocumentManagementEnabled { get; set; }

    public int? MobileAccessLevelMask { get; set; }

    public bool? IsVisibleInMobile { get; set; }

    public bool? IsMultipleQueueEnabled { get; set; }

    public bool? AutoRouteToOwnerQueue { get; set; }

    public bool? IsAuditEnabled { get; set; }

    public bool? IsConnectionsEnabled { get; set; }

    public bool? IsReadingPaneEnabled { get; set; }

    public bool? IsMapiGridEnabled { get; set; }

    public bool? IsEnabledForCharts { get; set; }

    public string? IconLargeName { get; set; }

    public string? IconMediumName { get; set; }

    public string? IconSmallName { get; set; }

    public int? NextCustomAttributeColumnNumber { get; set; }

    public int? ActivityTypeMask { get; set; }

    public bool? IsSolutionAware { get; set; }

    public Guid? SolutionId { get; set; }

    public Guid? SupportingSolutionId { get; set; }

    public byte? ComponentState { get; set; }

    public DateTime? OverwriteTime { get; set; }

    public Guid? InheritsFrom { get; set; }

    public bool? IsInheritedFrom { get; set; }

    public bool? CanBeSecured { get; set; }

    public bool? CanModifyConnectionSettings { get; set; }

    public bool? CanModifyDuplicateDetectionSettings { get; set; }

    public bool? CanModifyMailMergeSettings { get; set; }

    public bool? CanModifyQueueSettings { get; set; }

    public bool? CanCreateAttributes { get; set; }

    public bool? CanBeRelatedEntityInRelationship { get; set; }

    public bool? CanBePrimaryEntityInRelationship { get; set; }

    public bool? CanBeInManyToMany { get; set; }

    public bool? CanCreateForms { get; set; }

    public bool? CanCreateCharts { get; set; }

    public bool? CanCreateViews { get; set; }

    public bool? CanModifyAuditSettings { get; set; }

    public bool? CanModifyMobileVisibility { get; set; }

    public int? ParentComponentType { get; set; }

    public string? ParentControllingAttributeName { get; set; }

    public bool? IsManaged { get; set; }

    public bool? CanModifyAdditionalSettings { get; set; }

    public bool? IsAirupdated { get; set; }

    public bool? IsQuickCreateEnabled { get; set; }

    public string? IntroducedVersion { get; set; }

    public bool? AutoCreateAccessTeams { get; set; }

    public bool? IsBusinessProcessEnabled { get; set; }

    public bool? HasIdsTable { get; set; }

    public bool? IsReadOnlyInMobileClient { get; set; }

    public bool? IsVisibleInMobileClient { get; set; }

    public bool? CanModifyMobileClientVisibility { get; set; }

    public bool? CanModifyMobileClientReadOnly { get; set; }

    public bool? IsEnabledForTrace { get; set; }

    public bool? CanChangeHierarchicalRelationship { get; set; }

    public string? EntityHelpUrl { get; set; }

    public bool? EntityHelpUrlEnabled { get; set; }

    public bool? IsHsmenabled { get; set; }

    public bool? UsesBusinessDataLabelTable { get; set; }

    public bool? IsStateModelAware { get; set; }

    public bool? EnforceStateTransitions { get; set; }

    public bool? ChangeTrackingEnabled { get; set; }

    public bool? CanChangeTrackingBeEnabled { get; set; }

    public bool? CanEnableSyncToExternalSearchIndex { get; set; }

    public bool? SyncToExternalSearchIndex { get; set; }

    public int? EntityClass { get; set; }

    public string? EntityColor { get; set; }

    public string? EntitySetName { get; set; }

    public bool? IsInteractionCentricEnabled { get; set; }

    public bool? IsOneNoteIntegrationEnabled { get; set; }

    public bool? IsPrivate { get; set; }

    public bool? IsOfflineInMobileClient { get; set; }

    public bool? CanModifyMobileClientOffline { get; set; }

    public int? DaysSinceRecordLastModified { get; set; }

    public bool? IsEnabledForExternalChannels { get; set; }

    public bool? CanExternalChannelsBeEnabled { get; set; }

    public bool? IsOptimisticConcurrencyRequired { get; set; }

    public bool? IsOptimisticConcurrencyEnabled { get; set; }

    public bool? CanOptimisticConcurrencyBeEnabled { get; set; }

    public bool? CanOptimisticConcurrencyBeRequired { get; set; }

    public bool? IsKnowledgeManagementEnabled { get; set; }

    public bool? IsBpfentity { get; set; }

    public bool? IsDocumentRecommendationsEnabled { get; set; }

    public bool? IsSlaenabled { get; set; }

    public string? MobileOfflineFilters { get; set; }
}
