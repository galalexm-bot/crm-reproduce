using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Workflow.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("c1f0c16f-482b-4f91-ae98-87fec56697f8")]
[EntityMetadataType(EntityMetadataType.Interface)]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[DisplayName(typeof(__Resources_IWorkflowInstanceState), "DisplayName")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>13fa197f-b33e-47f6-af8e-aa04e4761cf4</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("WorkflowInstanceState")]
[Description(typeof(__Resources_IWorkflowInstanceState), "Description")]
[DisplayFormat("{$Uid}")]
[ShowInCatalogList(false)]
[ImplementationUid("1cb89a86-a087-4ca4-8898-14de5abe27d9")]
public interface IWorkflowInstanceState : IEntity<long>, IEntity, IIdentified
{
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	[DisplayName(typeof(__Resources_IWorkflowInstanceState), "P_Uid_DisplayName")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[SystemProperty]
	[RequiredField]
	[GuidSettings(FieldName = "Uid")]
	[Required(true)]
	[Uid("24742f70-8247-47ce-bb3d-105e9ae6588e")]
	[NotNull]
	Guid Uid { get; set; }

	[BlobSettings(FieldName = "State")]
	[Property("1911b22d-0ce2-4743-832f-6a44cb0357fe")]
	[DisplayName(typeof(__Resources_IWorkflowInstanceState), "P_State_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Description(typeof(__Resources_IWorkflowInstanceState), "P_State_Description")]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Order(1)]
	[Uid("761799c9-9f54-4cf5-9b80-60c8123f0ec5")]
	byte[] State { get; set; }
}
