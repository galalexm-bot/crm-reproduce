using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("4b165160-07b7-4e0c-a2d9-75bb05a37824")]
[DisplayName(typeof(__Resources_ILegalForm), "DisplayName")]
[DisplayFormat(null)]
[TitleProperty("2b533794-7fb7-41db-81dc-3cb31c59ad63")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>f055f2ec-125e-4df5-ab42-b3ec142151e6</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("LegalForm")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(true)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("4b482e94-ca31-4a96-8935-1b3967448386")]
[FilterType(typeof(ILegalFormFilter))]
public interface ILegalForm : IEntity<long>, IEntity, IIdentified
{
	[Uid("8c65b1ee-1013-438e-b998-5369011801b1")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_ILegalForm), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("2b533794-7fb7-41db-81dc-3cb31c59ad63")]
	[Order(1)]
	[Required(true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "LongName")]
	[RequiredField]
	[DisplayName(typeof(__Resources_ILegalForm), "P_LongName_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[FastSearch(true)]
	[ShowInTable(true)]
	[Filterable]
	[EntityProperty]
	string LongName { get; set; }

	[Uid("48574390-e7f2-411d-b728-d9b8093e45d1")]
	[Order(2)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "ShortName")]
	[DisplayName(typeof(__Resources_ILegalForm), "P_ShortName_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[FastSearch(true)]
	[ShowInTable(true)]
	[Filterable]
	[EntityProperty]
	string ShortName { get; set; }
}
