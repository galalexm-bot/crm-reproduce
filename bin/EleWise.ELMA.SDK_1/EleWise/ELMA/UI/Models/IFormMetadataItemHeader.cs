// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Models.IFormMetadataItemHeader
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

namespace EleWise.ELMA.UI.Models
{
  /// <summary>Заголовок метаданных формы</summary>
  [DisplayFormat(null)]
  [TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>26470873-6201-4fd2-ba7f-3905490a4af7</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
  [InterfaceImplementation("EleWise.ELMA.Model.Entities.ISoftDeletable")]
  [EleWise.ELMA.Model.Attributes.MetadataType(typeof (EntityMetadata))]
  [EleWise.ELMA.Model.Attributes.Uid("7193b3a8-1310-4ea7-90ba-4d4632f1159f")]
  [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_IFormMetadataItemHeader), "DisplayName")]
  [Entity("FormMetadataItemHeader")]
  [Filterable]
  [ImplementationUid("5fac6b2d-f630-4cf4-a692-9c001737d7c1")]
  [FilterType(typeof (IFormMetadataItemHeaderFilter))]
  [IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
  [ShowInCatalogList(false)]
  [EntityMetadataType(EntityMetadataType.Interface)]
  public interface IFormMetadataItemHeader : IEntity<long>, IEntity, IIdentified, ISoftDeletable
  {
    /// <summary>Уникальный идентификатор</summary>
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_IFormMetadataItemHeader), "P_Uid_DisplayName")]
    [GuidSettings(FieldName = "Uid")]
    [View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
    [SystemProperty]
    [EntityProperty]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [NotNull]
    [EleWise.ELMA.Model.Attributes.Uid("aa22584d-197b-4b6d-8e3d-12ba9d5cc0ef")]
    Guid Uid { get; set; }

    /// <summary>Наименование</summary>
    [EntityProperty]
    [Filterable]
    [FastSearch(true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [StringRangeLength(0, "2000")]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_IFormMetadataItemHeader), "P_Name_DisplayName")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Order(1)]
    [EleWise.ELMA.Model.Attributes.Uid("4c5d5553-d816-4b8c-abd4-de2003c4ed3d")]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [StringSettings(MaxValueString = "2000", FieldName = "Name")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    string Name { get; set; }

    /// <summary>Отображаемое имя</summary>
    [EleWise.ELMA.Model.Attributes.Uid("fcb0afe8-999c-45d3-b2e6-a7acf2110434")]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [EntityProperty]
    [Filterable]
    [FastSearch(true)]
    [StringSettings(FieldName = "DisplayName")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [Order(2)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_IFormMetadataItemHeader), "P_DisplayName_DisplayName")]
    string DisplayName { get; set; }

    /// <summary>Дата создания</summary>
    [RequiredField]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_IFormMetadataItemHeader), "P_CreationDate_DisplayName")]
    [EntityProperty]
    [Filterable]
    [PropertyHandler("d0c00d8a-e003-427d-9942-f52cfb77b0f0")]
    [NotNull]
    [Order(5)]
    [Required(true)]
    [DateTimeSettings(SetCurrentDate = true, FieldName = "CreationDate")]
    [Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
    [EleWise.ELMA.Model.Attributes.Uid("0848e973-b0f2-46a8-ae1e-a7e93fd5ab5e")]
    DateTime CreationDate { get; set; }

    /// <summary>Идентификатор автора создания</summary>
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [EntityProperty]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [CanBeNull]
    [Order(6)]
    [EleWise.ELMA.Model.Attributes.Uid("36d2b15b-4f28-4f3a-b1ab-17dcaa85f17d")]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_IFormMetadataItemHeader), "P_CreationAuthorId_DisplayName")]
    [Int64Settings(FieldName = "CreationAuthorId")]
    [Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
    long? CreationAuthorId { get; set; }

    /// <summary>Черновик</summary>
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.Uid("a2331e29-0bb6-4f06-845c-9440fd6cc3f8")]
    [EntityProperty]
    [EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Draft")]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "4ea88112-1e4d-413e-9715-0a5514809607")]
    [Order(8)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_IFormMetadataItemHeader), "P_Draft_DisplayName")]
    IFormMetadataItem Draft { get; set; }

    /// <summary>Опубликованная версия</summary>
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "4ea88112-1e4d-413e-9715-0a5514809607")]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Order(9)]
    [EleWise.ELMA.Model.Attributes.Uid("cc2895f8-2c1b-4a0c-b738-cb70a7870afa")]
    [EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Published")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_IFormMetadataItemHeader), "P_Published_DisplayName")]
    [EntityProperty]
    IFormMetadataItem Published { get; set; }

    /// <summary>Есть неопубликованные изменения</summary>
    [BoolSettings(DefaultValueStr = "True", FieldName = "IsDirtyItem")]
    [RequiredField]
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    [Required(true)]
    [NotNull]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [EntityProperty]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_IFormMetadataItemHeader), "P_IsDirtyItem_DisplayName")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.Uid("95d1ff8d-12a3-445e-a0ac-f4ccb12c84f8")]
    [Order(11)]
    bool IsDirtyItem { get; set; }

    /// <summary>Тип метаданных</summary>
    [NotNull]
    [EleWise.ELMA.Model.Attributes.Uid("c4a3e404-cf03-444b-bfec-1fb8a3103b01")]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_IFormMetadataItemHeader), "P_MetadataType_DisplayName")]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [Order(7)]
    [EntityProperty]
    [Filterable]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [GuidSettings(FieldName = "MetadataType")]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    Guid MetadataType { get; set; }

    /// <summary>Версия для эмуляции</summary>
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Emulation")]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_IFormMetadataItemHeader), "P_Emulation_DisplayName")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.Uid("07620a56-8e5b-4202-b266-da55d18e6c7d")]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "4ea88112-1e4d-413e-9715-0a5514809607")]
    [Order(10)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    IFormMetadataItem Emulation { get; set; }

    /// <summary>Группа</summary>
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Order(4)]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "0fb824f0-01de-439e-9d42-320cc59e10b6")]
    [EleWise.ELMA.Model.Attributes.Uid("c9f61c8e-2e6e-497d-afe2-a7759b6c135d")]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_IFormMetadataItemHeader), "P_Group_DisplayName")]
    [EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Group")]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [Filterable]
    IFormMetadataItemGroup Group { get; set; }

    /// <summary>Удален</summary>
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [EntityProperty]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [NotNull]
    [Order(12)]
    [EleWise.ELMA.Model.Attributes.Uid("84788dd4-2d1b-4324-a0ac-8329413efa3a")]
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_IFormMetadataItemHeader), "P_IsDeleted_DisplayName")]
    [BoolSettings(FieldName = "IsDeleted")]
    new bool IsDeleted { get; set; }

    /// <summary>Удалить из базы</summary>
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_IFormMetadataItemHeader), "P_HardDelete_DisplayName")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [Order(13)]
    [NotNull]
    [EleWise.ELMA.Model.Attributes.Uid("cc276a89-5494-4ea1-abe6-ca6b8a196178")]
    [BoolSettings(FieldName = "HardDelete")]
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
    [EntityProperty]
    new bool HardDelete { get; set; }

    /// <summary>Описание</summary>
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [StringSettings(FieldName = "Description")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_IFormMetadataItemHeader), "P_Description_DisplayName")]
    [EleWise.ELMA.Model.Attributes.Uid("480ddd79-d903-417f-a6d8-85eeb2262619")]
    [Order(3)]
    string Description { get; set; }
  }
}
