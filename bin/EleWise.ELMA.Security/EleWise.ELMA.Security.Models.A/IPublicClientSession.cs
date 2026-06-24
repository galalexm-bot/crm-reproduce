using System;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Types.Settings;

namespace EleWise.ELMA.Security.Models.API;

[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>b3de4a23-7d29-4286-bc8d-ccf7e7c994c8</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("PublicClientSession")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInTypeTree(false)]
[ShowInDesigner(false)]
[InterfaceImplementation("EleWise.ELMA.API.Models.IPublicClientSession")]
[ShowInCatalogList(false)]
[NonUnique]
[CacheEntity]
[FilterType(typeof(IPublicClientSessionFilter))]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("f3ee68d7-fc22-4d1d-a9f1-48dc3b4123e1")]
[TitleProperty("6401a97e-d06b-46f0-8f3d-c722491efe6b")]
[Uid("2cdaf156-7742-4294-89cb-2ad63250efd8")]
[MetadataType(typeof(EntityMetadata))]
[DisplayName(typeof(__Resources_IPublicClientSession), "DisplayName")]
[DisplayFormat(null)]
[Description(typeof(__Resources_IPublicClientSession), "Description")]
public interface IPublicClientSession : IEntity<long>, IEntity, IIdentified, EleWise.ELMA.API.Models.IPublicClientSession
{
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[Filterable]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IPublicClientSession), "P_AuthToken_DisplayName")]
	[Required(true)]
	[NotNull]
	[Uid("5f732fc8-5328-42d8-bf54-46f7e9d58339")]
	[RequiredField]
	[GuidSettings(FieldName = "AuthToken")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	new Guid AuthToken { get; set; }

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[Filterable]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "69334e6e-2d55-4665-94e1-1de241bfa9ce")]
	[Required(true)]
	[Order(1)]
	[DisplayName(typeof(__Resources_IPublicClientSession), "P_ClientToken_DisplayName")]
	[RequiredField]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "ClientToken")]
	[Uid("0fddf46f-81b4-4ab6-9cdb-c3617e41e627")]
	new IPublicApplicationToken ClientToken { get; set; }

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IPublicClientSession), "P_Application_DisplayName")]
	[Filterable]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "1817c965-17ce-4463-86b5-08deb0f4b04e")]
	[Required(true)]
	[Order(2)]
	[Uid("ab0693ca-302a-467e-8350-1ca6e78ee8e0")]
	[RequiredField]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Application")]
	[EntityProperty]
	new IPublicApplication Application { get; set; }

	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IPublicClientSession), "P_AuthUser_DisplayName")]
	[RequiredField]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Order(3)]
	[Uid("423fe569-d9c0-44b6-953e-65c53c8456c4")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "AuthUser")]
	[Required(true)]
	new IUser AuthUser { get; set; }

	[DisplayName(typeof(__Resources_IPublicClientSession), "P_LastAccess_DisplayName")]
	[EntityProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[Description(typeof(__Resources_IPublicClientSession), "P_LastAccess_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[RequiredField]
	[NotNull]
	[Order(4)]
	[Uid("dbd5d4ab-fc5b-4efe-a00d-cf9cbc31a623")]
	[DateTimeSettings(FieldName = "LastAccess")]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[Required(true)]
	new DateTime LastAccess { get; set; }

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[RequiredField]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[Required(true)]
	[Order(5)]
	[Uid("6401a97e-d06b-46f0-8f3d-c722491efe6b")]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[DisplayName(typeof(__Resources_IPublicClientSession), "P_SessionToken_DisplayName")]
	[StringRangeLength(0, "128")]
	[StringSettings(MaxValueString = "128", FieldName = "SessionToken")]
	new string SessionToken { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Property("1911b22d-0ce2-4743-832f-6a44cb0357fe")]
	[Order(6)]
	[Uid("b86ae295-32b5-4662-a742-88e20e1ca9f3")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IPublicClientSession), "P_LastChangesPackage_DisplayName")]
	[BlobSettings(FieldName = "LastChangesPackage")]
	new byte[] LastChangesPackage { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[BlobSettings(FieldName = "Secret")]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Property("1911b22d-0ce2-4743-832f-6a44cb0357fe")]
	[Order(7)]
	[Uid("37c12433-9bd8-4fea-8cc9-ca3ea11d09e8")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Sortable(false)]
	[DisplayName(typeof(__Resources_IPublicClientSession), "P_Secret_DisplayName")]
	byte[] Secret { get; set; }
}
