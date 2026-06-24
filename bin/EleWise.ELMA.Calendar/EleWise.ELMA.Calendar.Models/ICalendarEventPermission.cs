using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Security.Types.Settings;

namespace EleWise.ELMA.Calendar.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("8843a228-586e-435f-908b-0903b2ed4b46")]
[DisplayName(typeof(__Resources_ICalendarEventPermission), "DisplayName")]
[DisplayFormat(null)]
[InterfaceImplementation("EleWise.ELMA.Security.Services.IInstanceExpressionPermissionHolder")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>296810d9-bb5d-4871-bce3-9c6349ec0277</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("CalendarEventPermission")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("3b25a38f-26a0-49ec-8c99-b41b9cfc12f2")]
public interface ICalendarEventPermission : IEntity<long>, IEntity, IIdentified, IInstanceExpressionPermissionHolder
{
	[Uid("52702889-c7a1-4de8-9aa4-4a1b09af9ae4")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_ICalendarEventPermission), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("caa4d1a6-fa92-4248-9459-1ca88e097c51")]
	[Order(1)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "6fb5a4a7-8b40-4b17-a2ae-3fdd0b04945c")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Target")]
	[DisplayName(typeof(__Resources_ICalendarEventPermission), "P_Target_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	new ICalendarEvent Target { get; set; }

	[Uid("eef13606-afa5-4878-bf1e-8bcca10b335b")]
	[Order(2)]
	[Required(true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MaxValueString = "255", FieldName = "RoleType")]
	[RequiredField]
	[StringRangeLength(0, "255")]
	[DisplayName(typeof(__Resources_ICalendarEventPermission), "P_TypeRole_DisplayName")]
	[EntityProperty]
	new string TypeRole { get; set; }

	[Uid("0215edce-db82-4744-8f46-8d0ea93a6bdd")]
	[Order(3)]
	[Required(true)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(FieldName = "UserId")]
	[RequiredField]
	[DisplayName(typeof(__Resources_ICalendarEventPermission), "P_User_DisplayName")]
	[EntityProperty]
	new IUser User { get; set; }

	[Uid("9e3a5a9b-6f25-4346-9861-492577386909")]
	[Order(4)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "AllowChief")]
	[DisplayName(typeof(__Resources_ICalendarEventPermission), "P_AllowChief_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	new bool AllowChief { get; set; }
}
