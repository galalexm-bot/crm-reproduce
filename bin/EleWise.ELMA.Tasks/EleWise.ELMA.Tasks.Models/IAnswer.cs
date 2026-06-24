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
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Tasks.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("ddff09fe-8839-448d-be48-2349985aa5c2")]
[DisplayName(typeof(__Resources_IAnswer), "DisplayName")]
[Description(typeof(__Resources_IAnswer), "Description")]
[DisplayFormat("Ответ на вопрос")]
[Image(typeof(IAnswer), "task_answer", 16, ImageFormatType.IconPack, false)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>baea2e37-cfc5-4188-bf3e-a66eb4a9c8b8</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("Answer")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[SaveHistory]
[ImplementationUid("5c59f1e3-6e6b-46c1-98ee-d867b9de6694")]
[CacheEntity]
public interface IAnswer : IEntity<long>, IEntity, IIdentified
{
	[Uid("5820e513-2f32-451a-91df-b137e2548aa9")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IAnswer), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("121f9759-b802-4f8f-823d-30921eceae59")]
	[Order(1)]
	[Required(true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MultiLine = true, FieldName = "Text")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IAnswer), "P_Text_DisplayName")]
	[Description(typeof(__Resources_IAnswer), "P_Text_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	string Text { get; set; }

	[Uid("3ed90170-47f5-4eac-8df5-c46cb9000fde")]
	[Order(2)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "3536c931-154c-4618-93b8-4e35bd8db226")]
	[EntitySettings(RelationType = RelationType.ManyToMany, RelationTableName = "AnswerAttachments", ParentColumnName = "Answer", ChildColumnName = "Attachment", CascadeMode = CascadeMode.All)]
	[DisplayName(typeof(__Resources_IAnswer), "P_Attachments_DisplayName")]
	[Description(typeof(__Resources_IAnswer), "P_Attachments_Description")]
	[Sortable(false)]
	[Groupable(false)]
	[PropertyHandler("81c57a64-25c0-4a7d-84a1-d018e2727460")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	ISet<IAttachment> Attachments { get; set; }

	[Uid("8a53fb3e-7b29-4938-aef5-e0f5d6f5d781")]
	[Order(3)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(DefaultValueStr = "True", FieldName = "ShowAll")]
	[DisplayName(typeof(__Resources_IAnswer), "P_ShowAll_DisplayName")]
	[Description(typeof(__Resources_IAnswer), "P_ShowAll_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	bool ShowAll { get; set; }

	[Uid("a34a1d32-deee-47d0-af13-5c8a9c40e3ee")]
	[Order(4)]
	[Required(true)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "31c95394-0958-4027-b15c-2db4632564c6")]
	[EntitySettings(CascadeMode = CascadeMode.All, FieldName = "Question")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IAnswer), "P_Question_DisplayName")]
	[Description(typeof(__Resources_IAnswer), "P_Question_Description")]
	[Sortable(false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IQuestion Question { get; set; }

	[Uid("a5ed602c-396c-4a56-964f-086e33600dcd")]
	[Order(5)]
	[CanBeNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(SetCurrentDate = true, FieldName = "CreationDate")]
	[DisplayName(typeof(__Resources_IAnswer), "P_CreationDate_DisplayName")]
	[PropertyHandler("d0c00d8a-e003-427d-9942-f52cfb77b0f0")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	DateTime? CreationDate { get; set; }

	[Uid("012aceb1-db15-48df-945f-c166a151300b")]
	[Order(6)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(FieldName = "CreationAuthor")]
	[DisplayName(typeof(__Resources_IAnswer), "P_CreationAuthor_DisplayName")]
	[PropertyHandler("b05ac6bd-eb8b-474a-a796-b53831a9967e")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IUser CreationAuthor { get; set; }
}
