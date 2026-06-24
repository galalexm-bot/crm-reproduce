// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.Models.ISchedulerTaskJob
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
using System;

namespace EleWise.ELMA.Scheduling.Models
{
  /// <summary>Работа задачи планировщика</summary>
  [AllowCreateHeirs(true)]
  [DisplayName(typeof (__Resources_ISchedulerTaskJob), "DisplayName")]
  [EleWise.ELMA.Model.Attributes.Uid("215dd155-ef88-4b92-ab32-6c370e50340c")]
  [DisplayFormat(null)]
  [Entity("SchedulerTaskJob")]
  [TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>a4519f92-c042-4922-834a-55db183b3656</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
  [TitleProperty("722a0414-62e9-4d97-a85e-b903c1df5656")]
  [MetadataType(typeof (EntityMetadata))]
  [IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
  [ShowInCatalogList(false)]
  [EntityMetadataType(EntityMetadataType.Interface)]
  [ImplementationUid("ca666976-7810-4cf0-984f-63109f60e513")]
  public interface ISchedulerTaskJob : IEntity<long>, IEntity, IIdentified, IInheritable
  {
    /// <summary>Уникальный идентификатор</summary>
    [EntityProperty]
    [View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
    [SystemProperty]
    [EleWise.ELMA.Model.Attributes.Uid("1928a6c4-c9a4-4eb5-a0a1-126ea71d849a")]
    [NotNull]
    [DisplayName(typeof (__Resources_ISchedulerTaskJob), "P_Uid_DisplayName")]
    [GuidSettings(FieldName = "Uid")]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    Guid Uid { get; set; }

    /// <summary>Задача</summary>
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Order(2)]
    [EleWise.ELMA.Model.Attributes.Uid("1ff528a6-c142-48b7-bc9f-d78e3918bc44")]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "c423fe8a-b399-4fd9-a9a1-0bcc0e3e53bf")]
    [DisplayName(typeof (__Resources_ISchedulerTaskJob), "P_Task_DisplayName")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Task")]
    ISchedulerTask Task { get; set; }

    /// <summary>Наименование</summary>
    [EntityProperty]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Filterable]
    [FastSearch(true)]
    [Required(true)]
    [Order(1)]
    [EleWise.ELMA.Model.Attributes.Uid("722a0414-62e9-4d97-a85e-b903c1df5656")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [DisplayName(typeof (__Resources_ISchedulerTaskJob), "P_Name_DisplayName")]
    [RequiredField]
    [StringSettings(FieldName = "Name")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    string Name { get; set; }

    /// <summary>Статус одиночного выполнения</summary>
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [DisplayName(typeof (__Resources_ISchedulerTaskJob), "P_OnceExecuteStatus_DisplayName")]
    [EntityProperty]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [Order(3)]
    [EleWise.ELMA.Model.Attributes.Uid("ed1e23fe-1c1f-4778-9d89-d2bcc05356d5")]
    [CanBeNull]
    [EnumSettings(FieldName = "OnceExecuteStatus")]
    [Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "cfaea77f-1cdc-40fa-954b-d43da508b05a")]
    JobStatus? OnceExecuteStatus { get; set; }
  }
}
