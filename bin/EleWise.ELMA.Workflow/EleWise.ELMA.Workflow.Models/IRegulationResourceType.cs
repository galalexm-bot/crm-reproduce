using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Workflow.Models;

[DisplayFormat(null)]
[Description(typeof(__Resources_IRegulationResourceType), "Description")]
[DisplayName(typeof(__Resources_IRegulationResourceType), "DisplayName")]
[ImplementationUid("889267f7-58b0-4df4-93ea-7b982d2a9bfa")]
[Uid("40868f81-7175-4afa-9ead-591d0f04960e")]
[TitleProperty("d29c2652-f2b6-444a-939d-d0c4cdba514a")]
[ShowInCatalogList(true)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Entity("RegulationResourceType")]
[InterfaceImplementation("EleWise.ELMA.Model.Entities.ISoftDeletable")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>eb426eeb-f720-4ccf-9766-f3a1f1a79b77</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[MetadataType(typeof(EntityMetadata))]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
public interface IRegulationResourceType : IEntity<long>, IEntity, IIdentified, ISoftDeletable
{
	[EntityProperty]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IRegulationResourceType), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[NotNull]
	[Uid("8663af11-c232-461e-9c82-8d60bc26b5e4")]
	[SystemProperty]
	Guid Uid { get; set; }

	[FastSearch(true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Required(true)]
	[Uid("d29c2652-f2b6-444a-939d-d0c4cdba514a")]
	[EntityProperty]
	[StringSettings(MaxValueString = "2000", FieldName = "Name")]
	[RequiredField]
	[Order(1)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringRangeLength(0, "2000")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[DisplayName(typeof(__Resources_IRegulationResourceType), "P_Name_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	string Name { get; set; }

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[NotNull]
	[Order(2)]
	[Uid("5ac534c4-a521-4f50-a38b-12d94c420433")]
	[DisplayName(typeof(__Resources_IRegulationResourceType), "P_IsDeleted_DisplayName")]
	[BoolSettings(FieldName = "IsDeleted")]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	new bool IsDeleted { get; set; }

	[NotNull]
	[DisplayName(typeof(__Resources_IRegulationResourceType), "P_HardDelete_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[BoolSettings(FieldName = "HardDelete")]
	[Uid("58a4bbe9-b459-4d8f-9df1-1ff43a62a680")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[EntityProperty]
	[Order(3)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	new bool HardDelete { get; set; }
}
