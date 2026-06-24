using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Files.Previews;

[ImplementationUid("a4617b15-701f-4182-ba25-3fce51ecd02e")]
[Entity("CreateFilePreviewQueueItem")]
[DisplayFormat(null)]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[MetadataType(typeof(EntityMetadata))]
[DisplayName(typeof(__Resources_ICreateFilePreviewQueueItem), "DisplayName")]
[Uid("e67f61c5-2650-4abc-9884-b49b878c0c46")]
[EntityMetadataType(EntityMetadataType.Interface)]
[ShowInCatalogList(false)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>5c08948d-68a0-401c-bc4d-e5c7b5f8bb2c</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
public interface ICreateFilePreviewQueueItem : IEntity<long>, IEntity, IIdentified
{
	[EntityProperty]
	[DisplayName(typeof(__Resources_ICreateFilePreviewQueueItem), "P_Uid_DisplayName")]
	[NotNull]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[SystemProperty]
	[Uid("5609e23f-b65e-411a-812e-12ff6639e771")]
	[GuidSettings(FieldName = "Uid")]
	Guid Uid { get; set; }

	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MaxValueString = "2000", FieldName = "FileId")]
	[Uid("3fb917e4-b551-430a-aee2-b4e91679879b")]
	[Order(1)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[StringRangeLength(0, "2000")]
	[DisplayName(typeof(__Resources_ICreateFilePreviewQueueItem), "P_FileId_DisplayName")]
	string FileId { get; set; }

	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Uid("0d11bc23-44bc-430b-b67c-98e0b4e88977")]
	[NotNull]
	[Order(2)]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "09b07ae0-7c5a-4124-bbd7-df6e15766a15")]
	[EnumSettings(FieldName = "Status")]
	[DisplayName(typeof(__Resources_ICreateFilePreviewQueueItem), "P_Status_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	PreviewWorkStatus Status { get; set; }

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[NotNull]
	[Order(3)]
	[Uid("71b6f676-9b9b-4ca7-a02c-98eda3679daa")]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_ICreateFilePreviewQueueItem), "P_Priority_DisplayName")]
	[Int64Settings(FieldName = "Priority")]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	long Priority { get; set; }

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[CanBeNull]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Int64Settings(FieldName = "ProcessId")]
	[Order(4)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_ICreateFilePreviewQueueItem), "P_ProcessId_DisplayName")]
	[Uid("9c9e3393-3cd7-4191-b3f5-15238f81c66f")]
	long? ProcessId { get; set; }

	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[CanBeNull]
	[Order(5)]
	[Uid("2bdbd18f-be87-4f6a-b41c-07349a3f306b")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[GuidSettings(FieldName = "TemporaryFileUid")]
	[DisplayName(typeof(__Resources_ICreateFilePreviewQueueItem), "P_TemporaryFileUid_DisplayName")]
	Guid? TemporaryFileUid { get; set; }

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[Uid("af9dc41c-aa4f-47b5-a69b-bc7fccf8718b")]
	[Order(6)]
	[CanBeNull]
	[DisplayName(typeof(__Resources_ICreateFilePreviewQueueItem), "P_ELMAInstanceUid_DisplayName")]
	[GuidSettings(FieldName = "ELMAInstanceUid")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	Guid? ELMAInstanceUid { get; set; }

	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[Order(7)]
	[Uid("8589ab97-07b3-4ab2-a9e8-5c8493928a88")]
	[StringSettings(FieldName = "CreatorFileName")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_ICreateFilePreviewQueueItem), "P_CreatorFileName_DisplayName")]
	string CreatorFileName { get; set; }

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DisplayName(typeof(__Resources_ICreateFilePreviewQueueItem), "P_Attempt_DisplayName")]
	[Order(8)]
	[Uid("fe8a2c14-8b20-4ac8-8920-5928f2b7e817")]
	[NotNull]
	[Int64Settings(FieldName = "Attempt")]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	long Attempt { get; set; }

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[CanBeNull]
	[Order(9)]
	[Uid("56147710-24b6-4054-88d5-90993988525b")]
	[DateTimeSettings(FieldName = "NextAttemptDate")]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DisplayName(typeof(__Resources_ICreateFilePreviewQueueItem), "P_NextAttemptDate_DisplayName")]
	DateTime? NextAttemptDate { get; set; }
}
