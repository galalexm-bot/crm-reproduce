using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Model.Scripts;

[Uid("832bc52b-6f0d-44a9-bccb-825a89a28503")]
[DisplayFormat(null)]
[DisplayName(typeof(__Resources_IExternalAssembly), "DisplayName")]
[MetadataType(typeof(EntityMetadata))]
[TitleProperty("ce2a09b0-c48b-4641-9b31-dfef2116339d")]
[EntityMetadataType(EntityMetadataType.Interface)]
[ShowInCatalogList(false)]
[Filterable]
[FilterType(typeof(IExternalAssemblyFilter))]
[ImplementationUid("50e1ea4a-2a29-41cc-8f65-b2956b9288d7")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>7dee7623-7232-429e-9f9d-fb0be9ed73be</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[ShowInTypeTree(false)]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[Entity("ExternalAssembly")]
public interface IExternalAssembly : IEntity<long>, IEntity, IIdentified
{
	[SystemProperty]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[DisplayName(typeof(__Resources_IExternalAssembly), "P_Uid_DisplayName")]
	[GuidSettings(FieldName = "Uid")]
	[EntityProperty]
	[NotNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[Uid("4ed0d347-39e8-47a4-a729-6d3a0dae71d7")]
	Guid Uid { get; set; }

	[Uid("ce2a09b0-c48b-4641-9b31-dfef2116339d")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[Filterable]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[Order(1)]
	[StringSettings(FieldName = "Name")]
	[DisplayName(typeof(__Resources_IExternalAssembly), "P_Name_DisplayName")]
	string Name { get; set; }

	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[DisplayName(typeof(__Resources_IExternalAssembly), "P_HashCode_DisplayName")]
	[StringSettings(FieldName = "HashCode")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Order(2)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[Uid("e8d5e5a1-159c-4dea-a6a5-a96ac14ec98c")]
	[Filterable]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	string HashCode { get; set; }

	[BlobSettings(FieldName = "Raw")]
	[Order(3)]
	[Uid("8dabac66-60e6-4b64-9e17-c3bfc0e1c738")]
	[EntityProperty]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Property("1911b22d-0ce2-4743-832f-6a44cb0357fe")]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IExternalAssembly), "P_Raw_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	byte[] Raw { get; set; }
}
