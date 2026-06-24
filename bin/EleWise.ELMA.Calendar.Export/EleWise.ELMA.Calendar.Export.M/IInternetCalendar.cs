using System;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;

namespace EleWise.ELMA.Calendar.Export.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("4111189e-4cd9-49d6-9121-45aae1a8710c")]
[DisplayName(typeof(__Resources_IInternetCalendar), "DisplayName")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>fdae3e82-b24e-4bbe-bfe2-9abca601c518</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("InternetCalendar")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("9275eb0f-a722-4869-ba86-3bd91b8bb7be")]
[FilterType(typeof(IInternetCalendarFilter))]
public interface IInternetCalendar : IEntity<long>, IEntity, IIdentified
{
	[Uid("0b7a090c-7997-4ae0-a550-5c9ec6d09138")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IInternetCalendar), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("00dbd7ca-f646-432e-885c-22e98721d560")]
	[Order(3)]
	[NotNull]
	[Required(true)]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "4887c814-b045-47d3-b542-d73d988ddf40")]
	[EnumSettings(DefaultValueStr = "6a74fc73-8f82-4cb8-a49f-4dcac2b29879", FieldName = "Period")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IInternetCalendar), "P_Period_DisplayName")]
	[Description(typeof(__Resources_IInternetCalendar), "P_Period_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	InternetCalendarPeriod Period { get; set; }

	[Uid("57ff31da-4772-4e0f-be6e-6e6483646cac")]
	[Order(4)]
	[NotNull]
	[Required(true)]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "DynamicUrlPart")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IInternetCalendar), "P_DynamicUrlPart_DisplayName")]
	[Description(typeof(__Resources_IInternetCalendar), "P_DynamicUrlPart_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[EntityProperty]
	Guid DynamicUrlPart { get; set; }

	[Uid("5b851f1c-5a09-4493-82c3-55e825f36461")]
	[Order(5)]
	[Required(true)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "2919287f-1f84-42d0-b937-7da6025b95e4")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Calendar")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IInternetCalendar), "P_Calendar_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	ISchedule Calendar { get; set; }

	[Uid("76c8949a-e7f0-4510-b172-00dcf7ef40d9")]
	[Order(2)]
	[Required(true)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(FieldName = "CreationAuthor")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IInternetCalendar), "P_CreationAuthor_DisplayName")]
	[PropertyHandler("b05ac6bd-eb8b-474a-a796-b53831a9967e")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	IUser CreationAuthor { get; set; }

	[Uid("cdeaff98-6417-4c4a-8b1c-c4e07937377c")]
	[Order(1)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "Name")]
	[DisplayName(typeof(__Resources_IInternetCalendar), "P_Name_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	string Name { get; set; }

	[Uid("8b286773-a065-4212-88e5-4b8fd3258bac")]
	[Order(6)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(DefaultValueStr = "True", FieldName = "QuickConnection")]
	[DisplayName(typeof(__Resources_IInternetCalendar), "P_QuickConnection_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	bool QuickConnection { get; set; }
}
