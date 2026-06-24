using System;
using System.Collections.Generic;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Security.Models.API;

[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[CacheEntity]
[FilterType(typeof(IClientSessionDataSetsFilter))]
[ImplementationUid("392794f7-bf11-42ac-bdc4-e74f2d133af0")]
[NonUnique]
[Entity("ClientSessionDataSets")]
[DisplayName(typeof(__Resources_IClientSessionDataSets), "DisplayName")]
[Description(typeof(__Resources_IClientSessionDataSets), "Description")]
[MetadataType(typeof(EntityMetadata))]
[Uid("6dd8c438-8b06-4af9-9300-f7e1eae65b45")]
[DisplayFormat(null)]
[InterfaceImplementation("EleWise.ELMA.API.Models.IClientSessionDataSets")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>2d2fd8cc-4ed5-4f4c-a45c-e800c3727344</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[ShowInTypeTree(false)]
[ShowInDesigner(false)]
public interface IClientSessionDataSets : IEntity<long>, IEntity, IIdentified, EleWise.ELMA.API.Models.IClientSessionDataSets
{
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[Required(true)]
	[Uid("6de6d64f-9656-4a1e-b00c-51cc72491df5")]
	[StringSettings(MaxValueString = "128", FieldName = "SessionToken")]
	[DisplayName(typeof(__Resources_IClientSessionDataSets), "P_SessionToken_DisplayName")]
	[StringRangeLength(0, "128")]
	[RequiredField]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[Filterable]
	new string SessionToken { get; set; }

	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Property("5c281e64-ddc8-4bc9-991a-84d9dc4e7649")]
	[ListOfSimpleTypeSettings(SimpleTypeUidStr = "eb6e8ddc-fafe-4e0e-9018-1a7667012579", FieldName = "DataSets")]
	[Uid("1ea0acf0-195b-49c4-875a-f971d47421c7")]
	[Order(1)]
	[DisplayName(typeof(__Resources_IClientSessionDataSets), "P_DataSets_DisplayName")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	new List<Guid> DataSets { get; set; }
}
