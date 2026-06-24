using System;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Security.Models.API;

[ShowInDesigner(false)]
[ShowInTypeTree(false)]
[InterfaceImplementation("EleWise.ELMA.API.Models.IPublicClientCacheToken")]
[Entity("PublicClientCacheToken")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>d05096de-85bf-4175-a00d-82710abd4afe</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[TitleProperty("f9c8f420-167c-4a53-81a4-e0643b841c0e")]
[Uid("0197546b-b371-4dd7-9c92-ac64c02bf0aa")]
[MetadataType(typeof(EntityMetadata))]
[DisplayName(typeof(__Resources_IPublicClientCacheToken), "DisplayName")]
[DisplayFormat(null)]
[Description(typeof(__Resources_IPublicClientCacheToken), "Description")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[NonUnique]
[CacheEntity]
[FilterType(typeof(IPublicClientCacheTokenFilter))]
[ImplementationUid("ce0353fa-19fa-4c2a-bfe4-a40624492d50")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
public interface IPublicClientCacheToken : IEntity<long>, IEntity, IIdentified, EleWise.ELMA.API.Models.IPublicClientCacheToken
{
	[RequiredField]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Session")]
	[DisplayName(typeof(__Resources_IPublicClientCacheToken), "P_Session_DisplayName")]
	[EntityProperty]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[Uid("4e682316-4c15-4a81-b7de-abc0cfd84c93")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "2cdaf156-7742-4294-89cb-2ad63250efd8")]
	[Required(true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	new IPublicClientSession Session { get; set; }

	[RequiredField]
	[GuidSettings(FieldName = "TokenKey")]
	[Description(typeof(__Resources_IPublicClientCacheToken), "P_TokenKey_Description")]
	[DisplayName(typeof(__Resources_IPublicClientCacheToken), "P_TokenKey_DisplayName")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[Order(1)]
	[Uid("2c25b3c3-e50c-4f77-85eb-4d8d672d5e8d")]
	[Required(true)]
	[NotNull]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	new Guid TokenKey { get; set; }

	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[RequiredField]
	[StringSettings(FieldName = "TokenValue")]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[DisplayName(typeof(__Resources_IPublicClientCacheToken), "P_TokenValue_DisplayName")]
	[Uid("f9c8f420-167c-4a53-81a4-e0643b841c0e")]
	[Order(2)]
	[Required(true)]
	new string TokenValue { get; set; }

	[Order(3)]
	[Uid("83ce0601-ca4e-47af-9c63-712969a5aa85")]
	[RequiredField]
	[NotNull]
	[DateTimeSettings(FieldName = "LastAccess")]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[Required(true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[DisplayName(typeof(__Resources_IPublicClientCacheToken), "P_LastAccess_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	new DateTime LastAccess { get; set; }
}
