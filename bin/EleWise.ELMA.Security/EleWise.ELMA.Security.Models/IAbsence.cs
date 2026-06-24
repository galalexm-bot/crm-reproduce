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
[Filterable]
[FilterType(typeof(IAbsenceFilter))]
[CacheEntity]
[ImplementationUid("7e545d8a-0a45-456b-9819-4d0db715f20d")]
[DisplayName(typeof(__Resources_IAbsence), "DisplayName")]
[Uid("f50c6471-7f79-4cf3-b45a-668dd964f20f")]
[MetadataType(typeof(EntityMetadata))]
[DisplayFormat(null)]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[Entity("Absence")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>bb45dd47-ebce-4ba9-8797-e2caacc7b3bd</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
public interface IAbsence : IEntity<long>, IEntity, IIdentified
{
	[EntityProperty]
	[SystemProperty]
	[Uid("aa8f1339-0d99-47ee-97c8-e5b7683733aa")]
	[NotNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[DisplayName(typeof(__Resources_IAbsence), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[GuidSettings(FieldName = "Uid")]
	Guid Uid { get; set; }

	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Order(1)]
	[DisplayName(typeof(__Resources_IAbsence), "P_User_DisplayName")]
	[EntityUserSettings(FieldName = "User")]
	[Required(true)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("6683a0b8-3462-4b41-bef8-9a92e1e81495")]
	[RequiredField]
	IUser User { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IAbsence), "P_StartDate_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[RequiredField]
	[Uid("0e71c829-3414-48bb-90bf-2370760c9193")]
	[Required(true)]
	[NotNull]
	[Order(2)]
	[DateTimeSettings(SetCurrentDate = true, FieldName = "StartDate")]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	DateTime StartDate { get; set; }

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IAbsence), "P_EndDate_DisplayName")]
	[Filterable]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[RequiredField]
	[NotNull]
	[Order(3)]
	[Uid("69787341-f2c3-4b35-ac93-9cd361c49434")]
	[DateTimeSettings(SetCurrentDate = true, FieldName = "EndDate")]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[Required(true)]
	DateTime EndDate { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[DisplayName(typeof(__Resources_IAbsence), "P_Description_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Order(4)]
	[Uid("52ea8244-9ba7-4104-af76-cbbecac6f2e9")]
	[StringSettings(MultiLine = true, FieldName = "Description")]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	string Description { get; set; }

	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Description(typeof(__Resources_IAbsence), "P_Status_Description")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "5af31f82-2104-4d1b-b028-a5996cad46e7")]
	[EntityProperty]
	[Filterable]
	[Required(true)]
	[EnumSettings(FieldName = "Status")]
	[RequiredField]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IAbsence), "P_Status_DisplayName")]
	[Order(5)]
	[Uid("c19e6e1b-f31c-4e1b-be5d-8cc185f2f6fc")]
	[NotNull]
	AbsenceStatus Status { get; set; }

	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[RequiredField]
	[Uid("bfc51cbb-424c-4085-9841-aa1dcab965e0")]
	[DisplayName(typeof(__Resources_IAbsence), "P_Grounds_DisplayName")]
	[Order(6)]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, GenerateListInFilter = true, FieldName = "Grounds")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "a79c6d13-4dba-4d51-a1e8-3f5a407985e4")]
	IGroundsForAbsence Grounds { get; set; }
}
