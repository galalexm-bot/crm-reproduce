using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;

namespace EleWise.ELMA.Calendar.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("56632811-169a-4815-8277-7b9b22c23a10")]
[DisplayName(typeof(__Resources_ICalendarEventUser), "DisplayName")]
[DisplayFormat("{$CalendarEventUser}")]
[Image(typeof(ICalendarEventUser), "calendar", 16, ImageFormatType.IconPack, false)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>7e3a78a2-7607-4194-adf0-e8e8cae74e31</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("CalendarEventUser")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[CopyAction(CopyAction.Clone)]
[ImplementationUid("187f5054-c061-4103-8ffc-a38dca4bf08e")]
[ActionsType(typeof(CalendarEventUserActions))]
public interface ICalendarEventUser : IEntity<long>, IEntity, IIdentified
{
	[Uid("3ec032ef-79f4-4b9e-9b68-969b3ed5a8a1")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_ICalendarEventUser), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("5a41358c-0308-4cac-bcdd-b8912ffe6406")]
	[Order(1)]
	[Required(true)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "6fb5a4a7-8b40-4b17-a2ae-3fdd0b04945c")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "EventID")]
	[RequiredField]
	[DisplayName(typeof(__Resources_ICalendarEventUser), "P_Event_DisplayName")]
	[Description(typeof(__Resources_ICalendarEventUser), "P_Event_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	ICalendarEvent Event { get; set; }

	[Uid("0979629f-1c85-42db-9cb4-5b12a503c63e")]
	[Order(2)]
	[Required(true)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(FieldName = "UserID")]
	[RequiredField]
	[DisplayName(typeof(__Resources_ICalendarEventUser), "P_User_DisplayName")]
	[Description(typeof(__Resources_ICalendarEventUser), "P_User_Description")]
	[EntityProperty]
	IUser User { get; set; }

	[Uid("5eb5f8da-11ee-4521-8860-22fd752f86c7")]
	[Order(3)]
	[NotNull]
	[Required(true)]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "7957c8d6-40a7-4db7-87c7-655bfb23b62e")]
	[EnumSettings(FieldName = "StatusId")]
	[RequiredField]
	[DisplayName(typeof(__Resources_ICalendarEventUser), "P_Status_DisplayName")]
	[EntityProperty]
	CalendarEventUserStatus Status { get; set; }

	[Uid("db185052-2dec-4905-93c2-66969fe186bc")]
	[Order(4)]
	[NotNull]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "6c05e2bc-b2b5-4e5b-b50b-18d72d81b0d8")]
	[EnumSettings(FieldName = "ConfirmedId")]
	[DisplayName(typeof(__Resources_ICalendarEventUser), "P_Confirmed_DisplayName")]
	[EntityProperty]
	ConfirmParticipation Confirmed { get; set; }

	[Uid("4253ba3b-21e3-4314-8a0b-c973a179643b")]
	[Order(5)]
	[CanBeNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(SetCurrentDate = true, FieldName = "ConfirmDate")]
	[DisplayName(typeof(__Resources_ICalendarEventUser), "P_ConfirmDate_DisplayName")]
	[EntityProperty]
	DateTime? ConfirmDate { get; set; }

	[Uid("4ddd2677-1bb4-4c61-a6c8-bf20d2233d7b")]
	[Order(6)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MultiLine = true, FieldName = "ConfirmComment")]
	[DisplayName(typeof(__Resources_ICalendarEventUser), "P_ConfirmComment_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	string ConfirmComment { get; set; }
}
