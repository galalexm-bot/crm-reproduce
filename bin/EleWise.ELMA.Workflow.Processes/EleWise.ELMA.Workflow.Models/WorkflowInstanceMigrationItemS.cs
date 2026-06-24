using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Workflow.Models;

[DisplayName(typeof(__Resources_WorkflowInstanceMigrationItemStatus), "DisplayName")]
[Uid("a26bbf50-feb9-4416-84bb-0813dfb4acb3")]
[MetadataType(typeof(EnumMetadata))]
public enum WorkflowInstanceMigrationItemStatus
{
	[DisplayName(typeof(__Resources_WorkflowInstanceMigrationItemStatus), "P_New_DisplayName")]
	[Uid("3175271a-5589-4001-8d57-40d467e716b6")]
	New = 0,
	[DisplayName(typeof(__Resources_WorkflowInstanceMigrationItemStatus), "P_Processed_DisplayName")]
	[Uid("949c68ed-2f6e-45a9-8e1c-59062bde2dcd")]
	Processed = 8,
	[Uid("f65222b6-cbdb-4ee5-8563-456eba5a6646")]
	[DisplayName(typeof(__Resources_WorkflowInstanceMigrationItemStatus), "P_NewVersion_DisplayName")]
	NewVersion = 1,
	[Uid("49298699-7def-49af-ae4e-95efcf0a1c7d")]
	[DisplayName(typeof(__Resources_WorkflowInstanceMigrationItemStatus), "P_ValidationCriticalError_DisplayName")]
	ValidationCriticalError = 2,
	[DisplayName(typeof(__Resources_WorkflowInstanceMigrationItemStatus), "P_Work_DisplayName")]
	[Uid("5e7d61e4-adf0-4147-a98e-72d013f80712")]
	Work = 3,
	[DisplayName(typeof(__Resources_WorkflowInstanceMigrationItemStatus), "P_ManualProcessingRequired_DisplayName")]
	[Uid("5abd5370-e708-4413-bfa6-604d5d6964d5")]
	ManualProcessingRequired = 4,
	[Uid("ece87c7c-95e6-4bb7-99f8-0ae75dba8fde")]
	[DisplayName(typeof(__Resources_WorkflowInstanceMigrationItemStatus), "P_OtherError_DisplayName")]
	OtherError = 5,
	[DisplayName(typeof(__Resources_WorkflowInstanceMigrationItemStatus), "P_UnSatisfied_DisplayName")]
	[Uid("98a2fac8-80a2-4a75-b5bb-ec859d5b1b45")]
	UnSatisfied = 6,
	[Uid("f1c009c9-d9f1-4af0-b5a5-a87532fdb574")]
	[DisplayName(typeof(__Resources_WorkflowInstanceMigrationItemStatus), "P_UpdateIsNotRequired_DisplayName")]
	UpdateIsNotRequired = 7
}
