using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Workflow.Models;

[Description(typeof(__Resources_IWorkflowProcessListRunning), "Description")]
[FilterType(typeof(IWorkflowProcessListRunningFilter))]
[DisplayName(typeof(__Resources_IWorkflowProcessListRunning), "DisplayName")]
[Entity("WorkflowProcessListRunning")]
[MetadataType(typeof(EntityMetadata))]
[Uid("7fde8ac8-a040-49d0-b6f4-d204683dec8e")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>6dd32492-6192-4d5e-b8ff-5681f5b93e63</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("a3b1e9d3-de70-4c27-898b-06b6463f2db8")]
public interface IWorkflowProcessListRunning : IEntity<long>, IEntity, IIdentified
{
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[DisplayName(typeof(__Resources_IWorkflowProcessListRunning), "P_Uid_DisplayName")]
	[Uid("723bf834-34bd-4e6d-b15e-83308156853a")]
	[EntityProperty]
	[SystemProperty]
	[NotNull]
	[GuidSettings(FieldName = "Uid")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	Guid Uid { get; set; }

	[GuidSettings(FieldName = "TypeObject")]
	[RequiredField]
	[EntityProperty]
	[DisplayName(typeof(__Resources_IWorkflowProcessListRunning), "P_TypeObject_DisplayName")]
	[Required(true)]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[Filterable]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Description(typeof(__Resources_IWorkflowProcessListRunning), "P_TypeObject_Description")]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[NotNull]
	[Uid("9b23ec64-b06a-4bbb-83e0-7a2ac53ef2c7")]
	[Order(1)]
	Guid TypeObject { get; set; }

	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[Filterable]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "da55965d-02a3-4dfd-8b71-d0c45d82c6a5")]
	[Order(2)]
	[Uid("0dc0533a-54cd-4345-b565-fe4bc32000ed")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IWorkflowProcessListRunning), "P_ProcessHeader_DisplayName")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "ProcessHeader")]
	IProcessHeader ProcessHeader { get; set; }

	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[BoolSettings(FieldName = "IsParent")]
	[EntityProperty]
	[Filterable]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[CanBeNull]
	[Order(3)]
	[Uid("6e20b827-9513-4e9c-afab-9eba1602c194")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IWorkflowProcessListRunning), "P_IsParent_DisplayName")]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	bool? IsParent { get; set; }

	[Filterable]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IWorkflowProcessListRunning), "P_RootMetadata_DisplayName")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[GuidSettings(FieldName = "RootMetadata")]
	[Order(4)]
	[EntityProperty]
	[Uid("00a07bfc-b1f3-4d44-8e5b-83bdceebc483")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[CanBeNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	Guid? RootMetadata { get; set; }
}
