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
[Uid("e9526843-ff66-4874-9b7b-1f84c042ea14")]
[DisplayName(typeof(__Resources_ILeadType), "DisplayName")]
[DisplayFormat(null)]
[TitleProperty("1a098705-8f28-4b16-a4a3-0360e3c86353")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>d26c24b8-cbf7-40c5-9f5f-444dd41f5250</Uid>\r\n  <ViewType>List</ViewType>\r\n  <SortDescriptors>\r\n    <TableViewSortDescriptor>\r\n      <PropertyUid>1a098705-8f28-4b16-a4a3-0360e3c86353</PropertyUid>\r\n      <Direction>Ascending</Direction>\r\n    </TableViewSortDescriptor>\r\n  </SortDescriptors>\r\n</TableView>")]
[Entity("LeadType")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(true)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("a86d8eff-1540-4f81-91a0-d54472dcdd1f")]
[FilterType(typeof(ILeadTypeFilter))]
public interface ILeadType : IEntity<long>, IEntity, IIdentified
{
	[Uid("df01fa35-cfe0-4723-9cd4-b41cd8a6c143")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_ILeadType), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("1a098705-8f28-4b16-a4a3-0360e3c86353")]
	[Order(1)]
	[Required(true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "Type")]
	[RequiredField]
	[DisplayName(typeof(__Resources_ILeadType), "P_Type_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[FastSearch(true)]
	[Filterable]
	[EntityProperty]
	string Type { get; set; }
}
