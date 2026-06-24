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

namespace EleWise.ELMA.Tasks.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("e95af847-020a-4e93-bcb2-baafdb642dbe")]
[DisplayName(typeof(__Resources_ITaskTimePlan), "DisplayName")]
[DisplayFormat("{$Task}")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>39ad66ad-b71a-4482-becd-01f75f769773</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("TaskTimePlan")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[SaveHistory]
[Filterable]
[ImplementationUid("8eef62a2-3bc4-4f06-b18b-3c3cb41adc1f")]
[FilterType(typeof(ITaskTimePlanFilter))]
public interface ITaskTimePlan : IEntity<long>, IEntity, IIdentified
{
	[Uid("c6953b27-7770-44c1-9c72-3321b6f09a6c")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_ITaskTimePlan), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("b2a4004c-3c39-4c06-bd81-e21558a7df38")]
	[Order(1)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "0f338330-068c-4135-be4e-95797a209c4e")]
	[EntitySettings(FieldName = "TaskId")]
	[DisplayName(typeof(__Resources_ITaskTimePlan), "P_Task_DisplayName")]
	[Filterable]
	[EntityProperty]
	ITaskBase Task { get; set; }

	[Uid("acb2b970-d073-47e5-b393-7d1c2ca6ed70")]
	[Order(2)]
	[NotNull]
	[Required(true)]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(SetCurrentDate = true, FieldName = "StartTime")]
	[RequiredField]
	[DisplayName(typeof(__Resources_ITaskTimePlan), "P_StartTime_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	DateTime StartTime { get; set; }

	[Uid("0798af1e-f3ac-41c3-8366-8ebb941671da")]
	[Order(3)]
	[NotNull]
	[Required(true)]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(SetCurrentDate = true, FieldName = "EndTime")]
	[RequiredField]
	[DisplayName(typeof(__Resources_ITaskTimePlan), "P_EndTime_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	DateTime EndTime { get; set; }

	[Uid("4f0e4368-ec58-42ae-92b3-e3f343a4fe5d")]
	[Order(4)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(FieldName = "AuthorId")]
	[DisplayName(typeof(__Resources_ITaskTimePlan), "P_Author_DisplayName")]
	[PropertyHandler("b05ac6bd-eb8b-474a-a796-b53831a9967e")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IUser Author { get; set; }
}
