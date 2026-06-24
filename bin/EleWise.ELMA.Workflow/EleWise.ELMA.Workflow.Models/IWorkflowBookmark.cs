using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Workflow.Models;

[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[Entity("WorkflowBookmark")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>7fa62c60-2693-44f2-887b-b0c0d10e3e6a</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("828eecd5-0500-46f5-8197-a14711643b0f")]
[Uid("1c56d793-9753-4a56-bc01-790cb0417251")]
[MetadataType(typeof(EntityMetadata))]
[DisplayName(typeof(__Resources_IWorkflowBookmark), "DisplayName")]
[DisplayFormat("{$Instance}")]
[Description(typeof(__Resources_IWorkflowBookmark), "Description")]
public interface IWorkflowBookmark : IEntity<long>, IEntity, IIdentified
{
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[DisplayName(typeof(__Resources_IWorkflowBookmark), "P_Uid_DisplayName")]
	[Uid("1692112b-e567-4282-ae40-1c466f9e24c2")]
	[NotNull]
	[Required(true)]
	[EntityProperty]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[Description(typeof(__Resources_IWorkflowBookmark), "P_Uid_Description")]
	[GuidSettings(FieldName = "Uid")]
	[RequiredField]
	Guid Uid { get; set; }

	[Uid("55a21f8e-8829-48bc-a1ba-597d5af29c10")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[CanBeNull]
	[Order(1)]
	[GuidSettings(FieldName = "ElementUid")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Description(typeof(__Resources_IWorkflowBookmark), "P_ElementUid_Description")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IWorkflowBookmark), "P_ElementUid_DisplayName")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	Guid? ElementUid { get; set; }

	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntitySettings(FieldName = "Instance")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "ae8e2269-5077-4bb3-a8dd-62e5d130f009")]
	[DisplayName(typeof(__Resources_IWorkflowBookmark), "P_Instance_DisplayName")]
	[Order(2)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Uid("5384e6cc-928a-45e3-864c-7b67126d0771")]
	IWorkflowInstance Instance { get; set; }
}
