// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.ITypeSettingsInstanceStore
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using System;

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>Хранилище настроек свойств для экземпляров объектов</summary>
  [EntityMetadataType(EntityMetadataType.Interface)]
  [ShowInCatalogList(false)]
  [EleWise.ELMA.Model.Attributes.Uid("717b74ef-1d4b-4af2-8c16-dcd5dde4620f")]
  [DisplayName(typeof (__Resources_ITypeSettingsInstanceStore), "DisplayName")]
  [ImplementationUid("c6e228cb-1142-4bff-acc3-ebbf9f70ec6d")]
  [MetadataType(typeof (EntityMetadata))]
  [ShowInDesigner(false)]
  [Entity("TypeSettingsInstanceStore")]
  [TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>c28f5237-7393-4ebd-827c-27b65b3989dc</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
  [ShowInTypeTree(false)]
  [IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
  [DisplayFormat(null)]
  public interface ITypeSettingsInstanceStore : IEntity<long>, IEntity, IIdentified
  {
    /// <summary>Уникальный идентификатор</summary>
    [SystemProperty]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [EntityProperty]
    [View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
    [DisplayName(typeof (__Resources_ITypeSettingsInstanceStore), "P_Uid_DisplayName")]
    [NotNull]
    [EleWise.ELMA.Model.Attributes.Uid("ea20d486-2faf-4672-9872-978f72324f33")]
    [GuidSettings(FieldName = "Uid")]
    Guid Uid { get; set; }

    /// <summary>Уникальный идентификатор типа объекта</summary>
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.Uid("87bb2220-38b9-450a-bf22-9ba96165a361")]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [DisplayName(typeof (__Resources_ITypeSettingsInstanceStore), "P_ObjectTypeUid_DisplayName")]
    [GuidSettings(FieldName = "ObjectTypeUid")]
    [NotNull]
    [Order(1)]
    Guid ObjectTypeUid { get; set; }

    /// <summary>Идентификатор объекта</summary>
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [StringRangeLength(0, "255")]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [DisplayName(typeof (__Resources_ITypeSettingsInstanceStore), "P_ObjectId_DisplayName")]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [StringSettings(MaxValueString = "255", FieldName = "ObjectId")]
    [Order(2)]
    [EleWise.ELMA.Model.Attributes.Uid("d4088112-8a67-452e-943a-e55ecb6ffc66")]
    string ObjectId { get; set; }

    /// <summary>Настройки</summary>
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Property("c0e3456c-53ba-4815-9d0a-262420f061a3")]
    [Order(3)]
    [TypeSettingsInstanceDataSettings(FieldName = "Settings")]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.Uid("ceeb3419-8132-4599-9828-ad4b43ab2043")]
    [DisplayName(typeof (__Resources_ITypeSettingsInstanceStore), "P_Settings_DisplayName")]
    [EntityProperty]
    TypeSettingsInstanceData Settings { get; set; }
  }
}
