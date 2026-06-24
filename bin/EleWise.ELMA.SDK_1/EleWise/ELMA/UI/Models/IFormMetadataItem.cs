// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Models.IFormMetadataItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using System;

namespace EleWise.ELMA.UI.Models
{
  /// <summary>Метаданные формы</summary>
  [DisplayFormat(null)]
  [EleWise.ELMA.Model.Attributes.Uid("4ea88112-1e4d-413e-9715-0a5514809607")]
  [ImplementationUid("c1ceac39-f487-48d5-8bb2-2591ba8f02f8")]
  [EntityMetadataType(EntityMetadataType.Interface)]
  [TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>934e808c-d14f-49bc-9d70-97b0171ac9a7</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
  [MetadataType(typeof (EntityMetadata))]
  [IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
  [DisplayName(typeof (__Resources_IFormMetadataItem), "DisplayName")]
  [Entity("FormMetadataItem")]
  [ShowInCatalogList(false)]
  public interface IFormMetadataItem : IEntity<long>, IEntity, IIdentified
  {
    /// <summary>Уникальный идентификатор</summary>
    [GuidSettings(FieldName = "Uid")]
    [DisplayName(typeof (__Resources_IFormMetadataItem), "P_Uid_DisplayName")]
    [View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
    [SystemProperty]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [EleWise.ELMA.Model.Attributes.Uid("74b99335-e8f8-4be6-9cb7-809c2b6e2359")]
    [NotNull]
    [EntityProperty]
    Guid Uid { get; set; }

    /// <summary>Дата создания</summary>
    [Order(1)]
    [EntityProperty]
    [EleWise.ELMA.Model.Attributes.Uid("8fd084d9-6e36-4b91-9b84-e659370f55d3")]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [PropertyHandler("d0c00d8a-e003-427d-9942-f52cfb77b0f0")]
    [Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
    [Filterable]
    [DisplayName(typeof (__Resources_IFormMetadataItem), "P_CreationDate_DisplayName")]
    [DateTimeSettings(SetCurrentDate = true, FieldName = "CreationDate")]
    [NotNull]
    DateTime CreationDate { get; set; }

    /// <summary>Идентификатор автора создания</summary>
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [EntityProperty]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [CanBeNull]
    [Order(2)]
    [EleWise.ELMA.Model.Attributes.Uid("962e5bed-bca7-4464-80fd-ef3d8ddbaa4d")]
    [DisplayName(typeof (__Resources_IFormMetadataItem), "P_CreationAuthorId_DisplayName")]
    [Int64Settings(FieldName = "CreationAuthorId")]
    [Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
    long? CreationAuthorId { get; set; }

    /// <summary>Метаданные</summary>
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [EntityProperty]
    [EleWise.ELMA.Model.Attributes.Uid("9807c1aa-7720-4b15-8907-b5f6da823e02")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [XmlSerializableObjectSettings(FieldName = "Metadata")]
    [Property("66c7898b-e56b-49e0-bfb8-9f9c4a7a0c52")]
    [DisplayName(typeof (__Resources_IFormMetadataItem), "P_Metadata_DisplayName")]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Order(3)]
    object Metadata { get; set; }

    /// <summary>Заголовок</summary>
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Order(4)]
    [EntityProperty]
    [EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Header")]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "7193b3a8-1310-4ea7-90ba-4d4632f1159f")]
    [EleWise.ELMA.Model.Attributes.Uid("3b63a507-1de8-4c74-a1d5-3f96160bdd03")]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [DisplayName(typeof (__Resources_IFormMetadataItem), "P_Header_DisplayName")]
    IFormMetadataItemHeader Header { get; set; }

    /// <summary>Комментарий</summary>
    [Order(5)]
    [EleWise.ELMA.Model.Attributes.Uid("8d145669-fa12-4459-b550-c31c00342633")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [DisplayName(typeof (__Resources_IFormMetadataItem), "P_Comment_DisplayName")]
    [TextSettings(FieldName = "Comment")]
    [Property("317e3d72-9c47-4b68-926d-ba77a2579bc2")]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    string Comment { get; set; }

    /// <summary>Модуль сценариев</summary>
    [Order(6)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [DisplayName(typeof (__Resources_IFormMetadataItem), "P_ScriptModule_DisplayName")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "ScriptModule")]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "53eba73b-29a5-4609-9d37-a93e409dc09f")]
    [EleWise.ELMA.Model.Attributes.Uid("9d5f972e-7748-4a46-b752-c981cff1f477")]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [EntityProperty]
    ScriptModule ScriptModule { get; set; }

    /// <summary>Номер версии</summary>
    [DisplayName(typeof (__Resources_IFormMetadataItem), "P_VersionNumber_DisplayName")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Order(7)]
    [Int64Settings(FieldName = "VersionNumber")]
    [Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [CanBeNull]
    [EleWise.ELMA.Model.Attributes.Uid("c0b3cb43-6e5b-4689-b61d-88ee1876f53a")]
    long? VersionNumber { get; set; }

    /// <summary>Бинарный код сборки</summary>
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [DisplayName(typeof (__Resources_IFormMetadataItem), "P_AssemblyRaw_DisplayName")]
    [Order(9)]
    [EleWise.ELMA.Model.Attributes.Uid("aaaabea4-8dec-4944-9cca-cf4621a561fe")]
    [BlobSettings(FieldName = "AssemblyRaw")]
    [Property("1911b22d-0ce2-4743-832f-6a44cb0357fe")]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    byte[] AssemblyRaw { get; set; }

    /// <summary>Отладочная информация</summary>
    [EntityProperty]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [Order(10)]
    [EleWise.ELMA.Model.Attributes.Uid("acf93cda-ee92-4344-88d9-d2e5253e3f4f")]
    [Property("1911b22d-0ce2-4743-832f-6a44cb0357fe")]
    [DisplayName(typeof (__Resources_IFormMetadataItem), "P_DebugRaw_DisplayName")]
    [BlobSettings(FieldName = "DebugRaw")]
    byte[] DebugRaw { get; set; }

    /// <summary>Имя сборки</summary>
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [DisplayName(typeof (__Resources_IFormMetadataItem), "P_AssemblyName_DisplayName")]
    [Order(8)]
    [EleWise.ELMA.Model.Attributes.Uid("587dd684-6415-4126-af7b-0077267b0230")]
    [StringSettings(FieldName = "AssemblyName")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    string AssemblyName { get; set; }

    /// <summary>Является версией для эмуляции</summary>
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [DisplayName(typeof (__Resources_IFormMetadataItem), "P_IsEmulation_DisplayName")]
    [Order(11)]
    [EleWise.ELMA.Model.Attributes.Uid("7dcc9d5f-0c40-4fc5-805f-4003057a9d70")]
    [NotNull]
    [BoolSettings(FieldName = "IsEmulation")]
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    bool IsEmulation { get; set; }
  }
}
