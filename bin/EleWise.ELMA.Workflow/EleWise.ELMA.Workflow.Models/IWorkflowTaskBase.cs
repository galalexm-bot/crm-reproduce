using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Workflow.Models;

[Uid("91670c2e-fc1e-462e-8e89-7284aaf12561")]
[Filterable]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[Entity("WorkflowTaskBase")]
[EntityMetadataType(EntityMetadataType.InterfaceExtension)]
[FilterType(typeof(IWorkflowTaskBaseFilter))]
[ActionsType(typeof(WorkflowTaskBaseActions))]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>d0a0f306-add3-4cab-bc0e-4e63c36e9c5b</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[ShowInCatalogList(false)]
[MetadataType(typeof(EntityMetadata))]
[DisplayName(typeof(__Resources_IWorkflowTaskBase), "DisplayName")]
[DisplayFormat(null)]
[BaseClass("0f338330-068c-4135-be4e-95797a209c4e")]
[Description(typeof(__Resources_IWorkflowTaskBase), "Description")]
public interface IWorkflowTaskBase : ITaskBase, IEntity<long>, IEntity, IIdentified, IInheritable
{
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "1c56d793-9753-4a56-bc01-790cb0417251")]
	[Uid("60788d60-c8fd-4b64-a4ce-20bd91e2f5db")]
	[EntitySettings(FieldName = "WorkflowBookmark")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IWorkflowTaskBase), "P_WorkflowBookmark_DisplayName")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	IWorkflowBookmark WorkflowBookmark { get; set; }

	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Uid("269fa6f0-c981-4fd6-8135-2c941f9ec109")]
	[Order(1)]
	[BoolSettings(FieldName = "AssignedToResponsible")]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Description(typeof(__Resources_IWorkflowTaskBase), "P_AssignedToResponsible_Description")]
	[DisplayName(typeof(__Resources_IWorkflowTaskBase), "P_AssignedToResponsible_DisplayName")]
	bool AssignedToResponsible { get; set; }
}
