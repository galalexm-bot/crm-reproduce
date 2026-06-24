// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.API.Models.IPackageChanges
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using System;

namespace EleWise.ELMA.API.Models
{
  /// <summary>Кэш пакетов изменений</summary>
  [ShowInCatalogList(false)]
  [FilterType(typeof (IPackageChangesFilter))]
  [EleWise.ELMA.Model.Attributes.Uid("b78adddc-58d5-413e-b603-e0e6aa880b19")]
  [MetadataType(typeof (EntityMetadata))]
  [IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
  [DisplayName(typeof (__Resources_IPackageChanges), "DisplayName")]
  [Entity("PackageChanges")]
  [TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>07c42262-f13c-4f26-b730-3c0ca03ea30b</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
  [DisplayFormat(null)]
  [Filterable]
  [EntityMetadataType(EntityMetadataType.Interface)]
  [ImplementationUid("f2071709-9ead-482b-9bb0-17778416a59e")]
  public interface IPackageChanges : IEntity<long>, IEntity, IIdentified
  {
    /// <summary>Уникальный идентификатор</summary>
    [DisplayName(typeof (__Resources_IPackageChanges), "P_Uid_DisplayName")]
    [GuidSettings(FieldName = "Uid")]
    [EntityProperty]
    [View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [NotNull]
    [EleWise.ELMA.Model.Attributes.Uid("3552bb65-ca35-4f6c-baac-7925085a1cf2")]
    [SystemProperty]
    Guid Uid { get; set; }

    /// <summary>Идентификатор пользователя</summary>
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [EntityProperty]
    [Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
    [NotNull]
    [Int64Settings(RangeInFilter = false, FieldName = "UserId")]
    [Order(1)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [DisplayName(typeof (__Resources_IPackageChanges), "P_UserId_DisplayName")]
    [Filterable]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.Uid("c707532b-511e-4b40-9457-aff20fa453bb")]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    long UserId { get; set; }

    /// <summary>Статус</summary>
    [DisplayName(typeof (__Resources_IPackageChanges), "P_Status_DisplayName")]
    [Order(2)]
    [Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "b312e8c7-5241-4c59-8219-ab701956c065")]
    [EnumSettings(FieldName = "Status")]
    [NotNull]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.Uid("e7c40d35-095b-4290-a519-69c6b1af8df6")]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    PackageChangesStatus Status { get; set; }

    /// <summary>Информация о пакетах</summary>
    [StringSettings(FieldName = "PackagesInfo")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [EleWise.ELMA.Model.Attributes.Uid("dbad4e3a-31dc-466d-bf34-bbd8805dc3b3")]
    [Order(3)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [DisplayName(typeof (__Resources_IPackageChanges), "P_PackagesInfo_DisplayName")]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    string PackagesInfo { get; set; }

    /// <summary>Дата изменения в тиках</summary>
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [DisplayName(typeof (__Resources_IPackageChanges), "P_ChangeDateTicks_DisplayName")]
    [Order(4)]
    [EleWise.ELMA.Model.Attributes.Uid("3225a53d-9ff5-4341-9fb7-17c945bf2a68")]
    [CanBeNull]
    [Int64Settings(FieldName = "ChangeDateTicks")]
    [Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
    long? ChangeDateTicks { get; set; }
  }
}
