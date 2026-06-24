// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.IMetadataItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using System;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Элемент метаданных</summary>
  /// <remarks>Элемент метаданных, созданный через дизайнер ELMA</remarks>
  [EleWise.ELMA.Model.Attributes.Uid("f351b2f8-586c-4ad2-a9d4-8996caab21fd")]
  [TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>0921366c-c236-49c9-a9f3-ac9e391e6ea0</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
  [ShowInDesigner(false)]
  [IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
  [ShowInCatalogList(false)]
  [EntityMetadataType(EntityMetadataType.Interface)]
  [ImplementationUid("107d6e78-4004-4271-b97a-968d1a8a0d63")]
  [ShowInTypeTree(false)]
  [DisplayFormat(null)]
  [Entity("MetadataItem")]
  [DisplayName("SR.M('Элемент метаданных')")]
  [Description("SR.M('Элемент метаданных, созданный через дизайнер ELMA')")]
  [MetadataType(typeof (EntityMetadata))]
  public interface IMetadataItem : IEntity<long>, IEntity, IIdentified
  {
    /// <summary>Уникальный идентификатор</summary>
    [DisplayName("SR.M('Уникальный идентификатор')")]
    [View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
    [GuidSettings(FieldName = "Uid")]
    [EntityProperty]
    [NotNull]
    [EleWise.ELMA.Model.Attributes.Uid("9898e3c9-e861-4938-aad6-5b5d446d5602")]
    [SystemProperty]
    [RequiredField]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [Required(true)]
    Guid Uid { get; set; }

    /// <summary>Дата создания</summary>
    [EleWise.ELMA.Model.Attributes.Uid("da22cce5-813f-4fc8-8739-69963896e31c")]
    [PropertyHandler("d0c00d8a-e003-427d-9942-f52cfb77b0f0")]
    [Filterable]
    [DateTimeSettings(SetCurrentDate = true, FieldName = "CreationDate")]
    [EntityProperty]
    [DisplayName("SR.M('Дата создания')")]
    [Required(true)]
    [Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
    [NotNull]
    [RequiredField]
    [Order(1)]
    DateTime CreationDate { get; set; }

    /// <summary>Метаданные</summary>
    /// <remarks>Сериализованные метаданные</remarks>
    [DisplayName("SR.M('Метаданные')")]
    [XmlSerializableObjectSettings(FieldName = "Metadata")]
    [EntityProperty]
    [Description("SR.M('Сериализованные метаданные')")]
    [Order(3)]
    [EleWise.ELMA.Model.Attributes.Uid("7a37342d-8f5b-4f40-aaaf-520b2568eae7")]
    [Property("66c7898b-e56b-49e0-bfb8-9f9c4a7a0c52")]
    object Metadata { get; set; }

    /// <summary>Заголовок</summary>
    [EntitySettings(CascadeMode = CascadeMode.All, FieldName = "Header")]
    [DisplayName("SR.M('Заголовок')")]
    [EntityProperty]
    [Order(4)]
    [EleWise.ELMA.Model.Attributes.Uid("3295a52d-7bc1-44be-a6a4-a7378ef55687")]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "8ead9b92-c173-45cf-97bc-91cce45df1ea")]
    IMetadataItemHeader Header { get; set; }

    /// <summary>Комментарий</summary>
    /// <remarks>Комментарий к опубликованной версии</remarks>
    [Order(5)]
    [EleWise.ELMA.Model.Attributes.Uid("f35bd263-6435-4e6b-bb12-b15fa20270b8")]
    [Description("SR.M('Комментарий к опубликованной версии')")]
    [EntityProperty]
    [DisplayName("SR.M('Комментарий')")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [StringSettings(MultiLine = true, FieldName = "Comment")]
    string Comment { get; set; }

    /// <summary>Идентификатор автора создания</summary>
    [DisplayName("SR.M('Идентификатор автора создания')")]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [CanBeNull]
    [Order(2)]
    [EleWise.ELMA.Model.Attributes.Uid("e3db1077-069a-4f1e-a88a-baa06999391a")]
    [Int64Settings(FieldName = "CreationAuthorId")]
    [Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
    long? CreationAuthorId { get; set; }

    /// <summary>Модуль сценариев</summary>
    [DisplayName("SR.M('Модуль сценариев')")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [EleWise.ELMA.Model.Attributes.Uid("34cf5723-3e17-47a4-96f2-a62cd126379c")]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [Order(6)]
    [EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "ScriptModule")]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "53eba73b-29a5-4609-9d37-a93e409dc09f")]
    ScriptModule ScriptModule { get; set; }

    /// <summary>Клиентский модуль сценариев</summary>
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "ClientScriptModule")]
    [DisplayName("SR.M('Клиентский модуль сценариев')")]
    [EntityProperty]
    [Order(7)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "53eba73b-29a5-4609-9d37-a93e409dc09f")]
    [EleWise.ELMA.Model.Attributes.Uid("3c611351-35a8-4e6a-b8b9-c94d7d41c5e9")]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    ScriptModule ClientScriptModule { get; set; }

    /// <summary>Зависимости</summary>
    /// <remarks>Сериализованные зависимости метаданных</remarks>
    [XmlSerializableObjectSettings(FieldName = "Dependencies")]
    [EleWise.ELMA.Model.Attributes.Uid("c812afc8-5260-47e6-a861-ad6275a9ef14")]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [EntityProperty]
    [Property("66c7898b-e56b-49e0-bfb8-9f9c4a7a0c52")]
    [Description("SR.M('Сериализованные зависимости метаданных')")]
    [DisplayName("SR.M('Зависимости')")]
    [Order(8)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    object Dependencies { get; set; }
  }
}
