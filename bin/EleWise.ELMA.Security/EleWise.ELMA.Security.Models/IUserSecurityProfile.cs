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

[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>74dfa576-6d85-48d0-9228-9ce6b3fc1455</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[ImplementationUid("35e3f240-be41-4c38-abac-1c6e1f457967")]
[ShowInTypeTree(false)]
[ShowInDesigner(false)]
[Entity("UserSecurityProfile")]
[DisplayFormat(null)]
[MetadataType(typeof(EntityMetadata))]
[Uid("d63b1930-cbce-4d65-85a0-1a30b221bbbc")]
[ActionsType(typeof(UserSecurityProfileActions))]
[CacheEntity]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[DisplayName(typeof(__Resources_IUserSecurityProfile), "DisplayName")]
[CopyAction(CopyAction.ByRef)]
public interface IUserSecurityProfile : IEntity<long>, IEntity, IIdentified
{
	[SystemProperty]
	[DisplayName(typeof(__Resources_IUserSecurityProfile), "P_Uid_DisplayName")]
	[Uid("f5168a72-a4a0-4944-ac07-750631886dd5")]
	[NotNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[EntityProperty]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[GuidSettings(FieldName = "Uid")]
	Guid Uid { get; set; }

	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Order(1)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IUserSecurityProfile), "P_User_DisplayName")]
	[Uid("2390ebb1-537c-4651-b976-548e4fd654cd")]
	[EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "User")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	IUser User { get; set; }

	[DisplayName(typeof(__Resources_IUserSecurityProfile), "P_Password_DisplayName")]
	[StringSettings(MaxValueString = "2000", FieldName = "Password")]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringRangeLength(0, "2000")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Order(3)]
	[Uid("20da2488-5aef-4e2e-b60f-e6f2ef281d84")]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	string Password { get; set; }

	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[DisplayName(typeof(__Resources_IUserSecurityProfile), "P_ForcedChangePassword_DisplayName")]
	[BoolSettings(DisplayType = BoolDisplayType.Checkbox, FieldName = "ForcedChangePassword")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[NotNull]
	[Order(5)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("cb74bbad-a4ef-4231-bfe7-699172072bb4")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	bool ForcedChangePassword { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Uid("789e7cae-bd1b-4368-96e8-ca00ffdcf039")]
	[DateTimeSettings(FieldName = "LastDateChangePassword")]
	[EntityProperty]
	[Order(6)]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DisplayName(typeof(__Resources_IUserSecurityProfile), "P_LastDateChangePassword_DisplayName")]
	[CanBeNull]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	DateTime? LastDateChangePassword { get; set; }

	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Int64Settings(DefaultValueStr = "0", FieldName = "CountFailedLogon")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[NotNull]
	[DisplayName(typeof(__Resources_IUserSecurityProfile), "P_CountFailedLogon_DisplayName")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Uid("445dc224-d780-44e3-a3b0-7cc6c8eb947f")]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Order(7)]
	long CountFailedLogon { get; set; }

	[Uid("8df416c8-96ea-4ae1-9a59-504dfaba4938")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Order(8)]
	[EntityProperty]
	[DateTimeSettings(FieldName = "DateLastFailedLogon")]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DisplayName(typeof(__Resources_IUserSecurityProfile), "P_DateLastFailedLogon_DisplayName")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[CanBeNull]
	DateTime? DateLastFailedLogon { get; set; }

	[Description(typeof(__Resources_IUserSecurityProfile), "P_DisallowLogon_Description")]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[Order(2)]
	[BoolSettings(DisplayType = BoolDisplayType.Checkbox, FieldName = "DisallowLogon")]
	[DisplayName(typeof(__Resources_IUserSecurityProfile), "P_DisallowLogon_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[NotNull]
	[EntityProperty]
	[Uid("19af9fd2-736c-496e-9ea1-539bc8e0e572")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	bool DisallowLogon { get; set; }

	[Uid("779505ef-f18f-44e1-b243-3cc1f13eee5d")]
	[EntityProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IUserSecurityProfile), "P_Salt_DisplayName")]
	[StringSettings(FieldName = "Salt")]
	[Order(4)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	string Salt { get; set; }
}
