using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;

namespace EleWise.ELMA.Tasks.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("c97dfff8-731e-4984-8733-f5b56402889a")]
[DisplayName(typeof(__Resources_IWorkLog), "DisplayName")]
[Description(typeof(__Resources_IWorkLog), "Description")]
[DisplayFormat(null)]
[FormView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<FormView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>00000000-0000-0000-0000-000000000000</Uid>\r\n  <ViewType>Create</ViewType>\r\n  <CanUseCommonView>true</CanUseCommonView>\r\n  <ViewInCommon>true</ViewInCommon>\r\n</FormView>")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>8af6798a-3744-4ca1-aeba-eb85a9761db1</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("WorkLog")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("e51a53b7-087a-4d31-8033-4d130676d0da")]
[FilterType(typeof(IWorkLogFilter))]
public interface IWorkLog : IEntity<long>, IEntity, IIdentified
{
	[Uid("271a4d27-7eb1-4086-9804-fbe5d47bebe9")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IWorkLog), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("1f63e401-13dd-416d-b93f-db4c13a1e36a")]
	[Order(3)]
	[CanBeNull]
	[Required(true)]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(SetCurrentDate = true, FieldName = "StartDate")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IWorkLog), "P_StartDate_DisplayName")]
	[Description(typeof(__Resources_IWorkLog), "P_StartDate_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	DateTime? StartDate { get; set; }

	[Uid("08604943-c5ac-4ae4-b4ab-fe9ac52af9c4")]
	[Order(5)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "CreationAuthor")]
	[DisplayName(typeof(__Resources_IWorkLog), "P_CreationAuthor_DisplayName")]
	[Description(typeof(__Resources_IWorkLog), "P_CreationAuthor_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IUser CreationAuthor { get; set; }

	[Uid("55b04563-ea87-4281-8faa-2d78df0bdd3e")]
	[Order(4)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MultiLine = true, FieldName = "Comment")]
	[DisplayName(typeof(__Resources_IWorkLog), "P_Comment_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	string Comment { get; set; }

	[Uid("a84e973c-749d-4f11-b9c3-b1586003c750")]
	[Order(6)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Worker")]
	[DisplayName(typeof(__Resources_IWorkLog), "P_Worker_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IUser Worker { get; set; }

	[Uid("63e6fc1a-fc1c-43f9-897a-159a4efc91eb")]
	[Order(7)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "0f338330-068c-4135-be4e-95797a209c4e")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "TaskBase")]
	[DisplayName(typeof(__Resources_IWorkLog), "P_TaskBase_DisplayName")]
	[Description(typeof(__Resources_IWorkLog), "P_TaskBase_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	ITaskBase TaskBase { get; set; }

	[Uid("f9e0d776-c89d-40fa-9322-c4dc7f3b01d9")]
	[Order(8)]
	[CanBeNull]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "cc641cef-d2ef-428c-8fd1-2bded558b6bb")]
	[EnumSettings(DefaultValueStr = "1765402a-7be7-4da9-af27-f4803e169dc2", FieldName = "Status")]
	[DisplayName(typeof(__Resources_IWorkLog), "P_Status_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	WorkLogStatus? Status { get; set; }

	[Uid("c890df6d-25f5-45c9-bf77-21562565a0e2")]
	[Order(2)]
	[CanBeNull]
	[Property("cdd9f627-2a60-4e36-9c10-ecb492b1adad")]
	[WorkTimeSettings(FieldName = "WorkMinutes")]
	[DisplayName(typeof(__Resources_IWorkLog), "P_WorkMinutes_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	WorkTime? WorkMinutes { get; set; }

	[Uid("6400ecd5-f27f-4e8e-bfec-c7f1b05f81fc")]
	[Order(1)]
	[NotNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(SetCurrentDate = true, FieldName = "CreationDate")]
	[DisplayName(typeof(__Resources_IWorkLog), "P_CreationDate_DisplayName")]
	[PropertyHandler("d0c00d8a-e003-427d-9942-f52cfb77b0f0")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	DateTime CreationDate { get; set; }

	[Uid("00f03a70-7b04-46d6-bdb6-af70bab7b636")]
	[Order(9)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "20ccd3da-8fc7-41aa-af79-b18757be446a")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "WorkLogItem")]
	[DisplayName(typeof(__Resources_IWorkLog), "P_WorkLogItem_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	IWorkLogItem WorkLogItem { get; set; }
}
