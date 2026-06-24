// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.Models.ISchedulerTask
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using Iesi.Collections.Generic;
using System;

namespace EleWise.ELMA.Scheduling.Models
{
  /// <summary>Задача планировщика</summary>
  [EntityMetadataType(EntityMetadataType.Interface)]
  [ImplementationUid("c669fe60-8f5d-420d-9d17-1502cde677cb")]
  [ShowInCatalogList(false)]
  [TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>25658a0f-70f6-4cca-9a29-52a0b48cb182</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
  [Entity("SchedulerTask")]
  [DisplayFormat(null)]
  [TitleProperty("2baa3630-66e5-48fc-82aa-bc036835b887")]
  [IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
  [MetadataType(typeof (EntityMetadata))]
  [EleWise.ELMA.Model.Attributes.Uid("c423fe8a-b399-4fd9-a9a1-0bcc0e3e53bf")]
  [DisplayName(typeof (__Resources_ISchedulerTask), "DisplayName")]
  public interface ISchedulerTask : IEntity<long>, IEntity, IIdentified
  {
    /// <summary>Уникальный идентификатор</summary>
    [View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
    [DisplayName(typeof (__Resources_ISchedulerTask), "P_Uid_DisplayName")]
    [NotNull]
    [EleWise.ELMA.Model.Attributes.Uid("50ebbd5b-1e68-4dfa-a694-1dae4d886a5d")]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [GuidSettings(FieldName = "Uid")]
    [SystemProperty]
    [EntityProperty]
    Guid Uid { get; set; }

    /// <summary>Наименование</summary>
    [RequiredField]
    [StringSettings(FieldName = "Name")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [EleWise.ELMA.Model.Attributes.Uid("2baa3630-66e5-48fc-82aa-bc036835b887")]
    [Order(1)]
    [Required(true)]
    [DisplayName(typeof (__Resources_ISchedulerTask), "P_Name_DisplayName")]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [FastSearch(true)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Filterable]
    string Name { get; set; }

    /// <summary>Работы</summary>
    [EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "1ff528a6-c142-48b7-bc9f-d78e3918bc44", CascadeMode = CascadeMode.All)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [DisplayName(typeof (__Resources_ISchedulerTask), "P_Jobs_DisplayName")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.Uid("3d132143-f09d-49f7-950c-93bf22aafa2e")]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [Order(5)]
    [EntityProperty]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "215dd155-ef88-4b92-ab32-6c370e50340c")]
    ISet<ISchedulerTaskJob> Jobs { get; set; }

    /// <summary>Настройки</summary>
    [Property("66c7898b-e56b-49e0-bfb8-9f9c4a7a0c52")]
    [EleWise.ELMA.Model.Attributes.Uid("71448c77-840b-41a3-a419-8dc728531a5f")]
    [Order(6)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [EntityProperty]
    [XmlSerializableObjectSettings(FieldName = "Settings")]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [DisplayName(typeof (__Resources_ISchedulerTask), "P_Settings_DisplayName")]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    object Settings { get; set; }

    /// <summary>Время одиночного выполнения</summary>
    /// <remarks>Указывается, если задачу нужно выполнить ровно 1 раз</remarks>
    [CanBeNull]
    [EleWise.ELMA.Model.Attributes.Uid("f19031d5-bd7d-4212-8ae7-936e74161d8b")]
    [Order(7)]
    [DateTimeSettings(FieldName = "OnceExecuteTime")]
    [Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Description(typeof (__Resources_ISchedulerTask), "P_OnceExecuteTime_Description")]
    [DisplayName(typeof (__Resources_ISchedulerTask), "P_OnceExecuteTime_DisplayName")]
    [EntityProperty]
    DateTime? OnceExecuteTime { get; set; }

    /// <summary>Тип задачи</summary>
    [Order(3)]
    [EnumSettings(DefaultValueStr = "21f9b877-1ec4-4d7b-b88a-e2cb05433faf", FieldName = "Type")]
    [DisplayName(typeof (__Resources_ISchedulerTask), "P_Type_DisplayName")]
    [Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "d416d85e-62d4-458d-8865-65c13e0bd288")]
    [EleWise.ELMA.Model.Attributes.Uid("18d2b6c0-9b0e-4c96-bad4-d39aa7efcbb8")]
    [NotNull]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    SchedulerTaskType Type { get; set; }

    /// <summary>Статус</summary>
    [DisplayName(typeof (__Resources_ISchedulerTask), "P_Status_DisplayName")]
    [EnumSettings(DefaultValueStr = "fdd26016-cca3-442a-b2f7-b0b091e34e94", FieldName = "Status")]
    [Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "742e4058-85b4-4412-98d2-b80cc8f0aa3e")]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [NotNull]
    [Order(4)]
    [EleWise.ELMA.Model.Attributes.Uid("d097654c-9283-46c6-96f5-8815d7e58877")]
    SchedulerTaskStatus Status { get; set; }

    /// <summary>Дата создания</summary>
    [Filterable]
    [EleWise.ELMA.Model.Attributes.Uid("f4517829-528c-498a-8514-85dd2b1ebafa")]
    [DisplayName(typeof (__Resources_ISchedulerTask), "P_CreationDate_DisplayName")]
    [EntityProperty]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [PropertyHandler("d0c00d8a-e003-427d-9942-f52cfb77b0f0")]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [NotNull]
    [Order(2)]
    [DateTimeSettings(SetCurrentDate = true, FieldName = "CreationDate")]
    [Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
    DateTime CreationDate { get; set; }

    /// <summary>Уникальный идентификатор владельца</summary>
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [DisplayName(typeof (__Resources_ISchedulerTask), "P_OwnerUid_DisplayName")]
    [CanBeNull]
    [GuidSettings(FieldName = "OwnerUid")]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [EleWise.ELMA.Model.Attributes.Uid("8a11bbef-9964-42ba-92a2-b4dfa769e0be")]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [Order(8)]
    [EntityProperty]
    Guid? OwnerUid { get; set; }
  }
}
