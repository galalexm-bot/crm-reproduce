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
[Uid("3f592fad-88b9-441c-ba36-0400f4dfe431")]
[DisplayName(typeof(__Resources_ILeadSource), "DisplayName")]
[DisplayFormat(null)]
[TitleProperty("7979a2b5-9191-4d36-a174-467ff7bd159e")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>675de72b-d4e2-46ce-acc2-05d3d57a4b15</Uid>\r\n  <ViewType>List</ViewType>\r\n  <SortDescriptors>\r\n    <TableViewSortDescriptor>\r\n      <PropertyUid>7979a2b5-9191-4d36-a174-467ff7bd159e</PropertyUid>\r\n      <Direction>Ascending</Direction>\r\n    </TableViewSortDescriptor>\r\n  </SortDescriptors>\r\n</TableView>")]
[Entity("LeadSource")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(true)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("1c5d9662-5cc5-4bc8-a033-d35e059337aa")]
[FilterType(typeof(ILeadSourceFilter))]
public interface ILeadSource : IEntity<long>, IEntity, IIdentified
{
	[Uid("1bbffa2c-d27b-4c63-bfb5-92aa3581fd07")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_ILeadSource), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("7979a2b5-9191-4d36-a174-467ff7bd159e")]
	[Order(1)]
	[Required(true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "Name")]
	[RequiredField]
	[DisplayName(typeof(__Resources_ILeadSource), "P_Name_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[FastSearch(true)]
	[Filterable]
	[EntityProperty]
	string Name { get; set; }
}
