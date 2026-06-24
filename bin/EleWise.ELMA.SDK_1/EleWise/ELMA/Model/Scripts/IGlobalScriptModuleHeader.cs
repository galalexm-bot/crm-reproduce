// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.IGlobalScriptModuleHeader
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

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>Заголовок глобального модуля сценариев</summary>
  [DisplayName("SR.M('Заголовок глобального модуля сценариев')")]
  [DisplayFormat(null)]
  [ShowInCatalogList(false)]
  [Entity("GlobalScriptModuleHeader")]
  [IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
  [TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>83eadf14-529f-46cf-b094-bc3a2f1813f4</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
  [EntityMetadataType(EntityMetadataType.Interface)]
  [MetadataType(typeof (EntityMetadata))]
  [EleWise.ELMA.Model.Attributes.Uid("9fb8f30f-4c1a-4db6-97db-cefc39b5448d")]
  [TitleProperty("8ef23861-9f2c-41eb-a98e-a2761f9eb5ee")]
  [Filterable]
  [ImplementationUid("6f255324-d5c4-4c03-ab5b-fe5c0bb37781")]
  [FilterType(typeof (IGlobalScriptModuleHeaderFilter))]
  public interface IGlobalScriptModuleHeader : IEntity<long>, IEntity, IIdentified
  {
    /// <summary>Уникальный идентификатор</summary>
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [SystemProperty]
    [DisplayName("SR.M('Уникальный идентификатор')")]
    [View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
    [NotNull]
    [GuidSettings(FieldName = "Uid")]
    [EntityProperty]
    [EleWise.ELMA.Model.Attributes.Uid("efa2f923-b6a6-4bbc-afd4-8fc13960976b")]
    Guid Uid { get; set; }

    /// <summary>Название</summary>
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [Filterable]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Order(1)]
    [EleWise.ELMA.Model.Attributes.Uid("8ef23861-9f2c-41eb-a98e-a2761f9eb5ee")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [DisplayName("SR.M('Название')")]
    [StringSettings(FieldName = "Name")]
    string Name { get; set; }

    /// <summary>Опубликованная версия</summary>
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "e5f6d1e3-6b00-4fae-ae1a-4d75a4126429")]
    [Order(4)]
    [EleWise.ELMA.Model.Attributes.Uid("fb8fe2ff-095c-4bc7-924b-ad3fe82a8ea3")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [DisplayName("SR.M('Опубликованная версия')")]
    [EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Published")]
    IGlobalScriptModule Published { get; set; }

    /// <summary>Черновик</summary>
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.Uid("da96c379-dc53-4a22-8e82-9051639a34c3")]
    [Order(5)]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "e5f6d1e3-6b00-4fae-ae1a-4d75a4126429")]
    [DisplayName("SR.M('Черновик')")]
    [EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Draft")]
    IGlobalScriptModule Draft { get; set; }

    /// <summary>Пространство имен</summary>
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [EntityProperty]
    [EleWise.ELMA.Model.Attributes.Uid("41eefb19-0f76-4ccb-91c5-3cedb47dcdc2")]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Filterable]
    [StringRangeLength(0, "2000")]
    [StringSettings(MaxValueString = "2000", FieldName = "Namespace")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [DisplayName("SR.M('Пространство имен')")]
    [Order(2)]
    string Namespace { get; set; }

    /// <summary>Удален</summary>
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [DisplayName("SR.M('Удален')")]
    [EntityProperty]
    [Filterable]
    [NotNull]
    [Order(6)]
    [EleWise.ELMA.Model.Attributes.Uid("0bff88de-37d2-4b81-9529-59e1cd1e00e9")]
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [BoolSettings(FieldName = "Deleted")]
    bool Deleted { get; set; }

    /// <summary>Описание</summary>
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [Order(3)]
    [StringSettings(MultiLine = true, FieldName = "Description")]
    [EleWise.ELMA.Model.Attributes.Uid("4f789bd0-5464-4092-bdeb-d61d27b46da7")]
    [DisplayName("SR.M('Описание')")]
    string Description { get; set; }

    /// <summary>Имеются неопубликованные изменения</summary>
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [DisplayName("SR.M('Имеются неопубликованные изменения')")]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [EntityProperty]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [Order(7)]
    [EleWise.ELMA.Model.Attributes.Uid("c2aa847b-ca66-4625-b060-be7d20a4e955")]
    [NotNull]
    [BoolSettings(FieldName = "HasChanges")]
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    bool HasChanges { get; set; }
  }
}
