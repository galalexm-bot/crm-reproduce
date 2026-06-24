using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Workflow.Models;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Workflow.BPMN.Models;

[Uid("3d3fb3b8-ba0d-4f4b-82bb-97b098c2eb6a")]
[DisplayName(typeof(__Resources_IBPMNProcess), "DisplayName")]
[MetadataType(typeof(EntityMetadata))]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[BaseClass("05ee2952-d4f3-4ac7-b9f9-6d4d8abc0079")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>3d0c43dc-1e04-4912-a17e-649e6ceef729</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[AllowCreateHeirs(true)]
[Entity("BPMNProcess")]
[DisplayFormat("{$Name}")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ImplementationUid("c6c4f47b-de4d-46b6-a66a-123a0f698a4e")]
public interface IBPMNProcess : IWorkflowProcess, IEntity<long>, IEntity, IIdentified, IInheritable
{
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "255f5025-e430-4d28-85e2-93d173070032")]
	[Uid("0748b253-35e0-4048-9657-d4b526e6105c")]
	[EntitySettings(RelationType = RelationType.OneToMany, RelationTableName = "M_BPMNProcess_", ParentColumnName = "Parent", ChildColumnName = "Child", KeyColumnUidStr = "23b8b4ef-15d1-43d6-9a26-6a4c67a7dbdb", CascadeMode = CascadeMode.SaveUpdate)]
	[EntityProperty]
	[DisplayName(typeof(__Resources_IBPMNProcess), "P_ResponsibilityMatrix_DisplayName")]
	ISet<IResponsibilityMatrixItem> ResponsibilityMatrix { get; set; }
}
