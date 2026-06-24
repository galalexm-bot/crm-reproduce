using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Types.Settings;

namespace EleWise.ELMA.Security.Models;

[EntityMetadataType(EntityMetadataType.Interface)]
[ShowInCatalogList(false)]
[FilterType(typeof(IUserPublicKeyTokenFilter))]
[DisplayName(typeof(__Resources_IUserPublicKeyToken), "DisplayName")]
[Filterable]
[ImplementationUid("43d71923-4f4d-487e-b5fd-194ec9f74509")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[MetadataType(typeof(EntityMetadata))]
[Uid("3b70fbaf-eb4c-46d5-a841-5f8e7a9748fb")]
[DisplayFormat(null)]
[Entity("UserPublicKeyToken")]
[TitleProperty("5e9ca1f5-8706-4ba3-b1ac-27b1d85bf898")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>7d04e5ac-edf3-4759-93f3-d68d82376a65</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
public interface IUserPublicKeyToken : IEntity<long>, IEntity, IIdentified
{
	[Uid("45c973d4-b388-4ee5-9433-2737ed563e7b")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IUserPublicKeyToken), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	Guid Uid { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[Filterable]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[Order(3)]
	[Uid("b0313769-297e-4c16-8732-723dcc5e72b5")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IUserPublicKeyToken), "P_User_DisplayName")]
	[EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "User")]
	IUser User { get; set; }

	[DisplayName(typeof(__Resources_IUserPublicKeyToken), "P_CreationDate_DisplayName")]
	[DateTimeSettings(SetCurrentDate = true, FieldName = "CreationDate")]
	[Order(2)]
	[Uid("c0bb8f0a-9179-4e20-902b-44a8272bdffd")]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[NotNull]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[PropertyHandler("d0c00d8a-e003-427d-9942-f52cfb77b0f0")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	DateTime CreationDate { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IUserPublicKeyToken), "P_PublicKey_DisplayName")]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[StringSettings(MaxValueString = "2000", FieldName = "PublicKey")]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[Order(4)]
	[StringRangeLength(0, "2000")]
	[Uid("ace993d7-fdd0-4448-a988-e0bf3c9dc3d1")]
	string PublicKey { get; set; }

	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[StringRangeLength(0, "2000")]
	[StringSettings(MaxValueString = "2000", FieldName = "DeviceId")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IUserPublicKeyToken), "P_DeviceId_DisplayName")]
	[Uid("9103d2d7-385f-4135-9f01-a15c3a5cb39f")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[Order(5)]
	string DeviceId { get; set; }

	[CanBeNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[Uid("a9b2de09-3d8a-4a89-bd61-7f9dc1d8ab77")]
	[Order(6)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DateTimeSettings(FieldName = "LastLogonDate")]
	[DisplayName(typeof(__Resources_IUserPublicKeyToken), "P_LastLogonDate_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	DateTime? LastLogonDate { get; set; }

	[EntityProperty]
	[Filterable]
	[FastSearch(true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[StringRangeLength(0, "2000")]
	[DisplayName(typeof(__Resources_IUserPublicKeyToken), "P_Name_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[Uid("5e9ca1f5-8706-4ba3-b1ac-27b1d85bf898")]
	[Order(1)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[StringSettings(MaxValueString = "2000", FieldName = "Name")]
	string Name { get; set; }
}
