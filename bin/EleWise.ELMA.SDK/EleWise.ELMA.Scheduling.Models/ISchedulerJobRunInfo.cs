using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Scheduling.Models;

[DisplayFormat(null)]
[Filterable]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>9c1ee2ee-921d-4525-887e-ec0d58b82f3e</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[ImplementationUid("79743226-3bd8-428e-89ea-ad55f42950f9")]
[FilterType(typeof(ISchedulerJobRunInfoFilter))]
[CacheEntity]
[NonUnique]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[Entity("SchedulerJobRunInfo")]
[MetadataType(typeof(EntityMetadata))]
[Uid("a7a7a36e-3bcd-49df-bb36-e8bb0a279fdc")]
[DisplayName(typeof(__Resources_ISchedulerJobRunInfo), "DisplayName")]
public interface ISchedulerJobRunInfo : IEntity<long>, IEntity, IIdentified
{
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[Uid("47d10f91-3058-4383-b865-d84ccf71c991")]
	[NotNull]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[DateTimeSettings(FieldName = "DateToRun")]
	[DisplayName(typeof(__Resources_ISchedulerJobRunInfo), "P_DateToRun_DisplayName")]
	DateTime DateToRun { get; set; }

	[EntityProperty]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Order(1)]
	[DateTimeSettings(FieldName = "ActualStartDate")]
	[DisplayName(typeof(__Resources_ISchedulerJobRunInfo), "P_ActualStartDate_DisplayName")]
	[NotNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("b772d961-ea2e-4183-af3a-e9e13e007e07")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	DateTime ActualStartDate { get; set; }

	[Order(2)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(FieldName = "FinishDate")]
	[Uid("bfbf29cd-1569-4c07-a264-c6b81a3976df")]
	[CanBeNull]
	[DisplayName(typeof(__Resources_ISchedulerJobRunInfo), "P_FinishDate_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	DateTime? FinishDate { get; set; }

	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Order(3)]
	[Uid("b93ba791-b7ce-457e-810b-9e86bff4d4a0")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[DisplayName(typeof(__Resources_ISchedulerJobRunInfo), "P_TriggerId_DisplayName")]
	[NotNull]
	[GuidSettings(FieldName = "TriggerId")]
	[Filterable]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	Guid TriggerId { get; set; }

	[Order(4)]
	[EntityProperty]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "TriggerName")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_ISchedulerJobRunInfo), "P_TriggerName_DisplayName")]
	[Uid("42457692-f2d9-4099-bd38-dcea9f6e23e7")]
	string TriggerName { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Uid("2c6ca0dc-b5d2-4ecb-8e38-b58bd5cd15a7")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DisplayName(typeof(__Resources_ISchedulerJobRunInfo), "P_Status_DisplayName")]
	[Order(8)]
	[EntityProperty]
	[NotNull]
	[EnumSettings(FieldName = "Status")]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "cfaea77f-1cdc-40fa-954b-d43da508b05a")]
	JobStatus Status { get; set; }

	[DisplayName(typeof(__Resources_ISchedulerJobRunInfo), "P_Description_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Uid("fdf0c2e9-c44f-4560-9c3a-88c8f7cc05e8")]
	[EntityProperty]
	[Order(9)]
	[StringSettings(MultiLine = true, FieldName = "Description")]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	string Description { get; set; }

	[DisplayName(typeof(__Resources_ISchedulerJobRunInfo), "P_Error_DisplayName")]
	[Uid("23de71df-b2c8-4aaf-894b-672a49fd8b66")]
	[EntityProperty]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MultiLine = true, FieldName = "Error")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Order(10)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	string Error { get; set; }

	[Uid("9ec3c1c6-d195-40be-a7ea-be365ee11f99")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Order(6)]
	[NotNull]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_ISchedulerJobRunInfo), "P_JobId_DisplayName")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[Filterable]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "JobId")]
	Guid JobId { get; set; }

	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Uid("f8e55208-acb5-4bdb-b71c-6db7128ac824")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "JobName")]
	[DisplayName(typeof(__Resources_ISchedulerJobRunInfo), "P_JobName_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[Order(7)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	string JobName { get; set; }

	[Filterable]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "215dd155-ef88-4b92-ab32-6c370e50340c")]
	[EntityProperty]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Order(5)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[DisplayName(typeof(__Resources_ISchedulerJobRunInfo), "P_Job_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntitySettings(FieldName = "Job")]
	[Uid("23f1c982-63f3-4565-9ccb-c92ae4616bc4")]
	ISchedulerTaskJob Job { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "ConnectionUid")]
	[Order(11)]
	[NotNull]
	[DisplayName(typeof(__Resources_ISchedulerJobRunInfo), "P_ConnectionUid_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("fdb9d397-c8bf-4f38-a7ad-0f14be886563")]
	Guid ConnectionUid { get; set; }

	[EntityProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DisplayName(typeof(__Resources_ISchedulerJobRunInfo), "P_StatusUpdateDate_DisplayName")]
	[NotNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(SetCurrentDate = true, FieldName = "StatusUpdateDate")]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Order(12)]
	[Uid("580940eb-4d10-46bd-b9eb-50c42053864d")]
	DateTime StatusUpdateDate { get; set; }
}
