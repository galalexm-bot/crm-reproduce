// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.IGlobalScriptModule
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

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>Глобальный модуль сценариев</summary>
  [IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
  [ShowInCatalogList(false)]
  [EntityMetadataType(EntityMetadataType.Interface)]
  [MetadataType(typeof (EntityMetadata))]
  [TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>84e3ec6c-7503-478d-9323-28c91d317294</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
  [Entity("GlobalScriptModule")]
  [DisplayFormat(null)]
  [EleWise.ELMA.Model.Attributes.Uid("e5f6d1e3-6b00-4fae-ae1a-4d75a4126429")]
  [DisplayName(typeof (__Resources_IGlobalScriptModule), "DisplayName")]
  [ImplementationUid("f9b98e71-cb9e-4aa5-a35f-6d83e3c684c2")]
  public interface IGlobalScriptModule : IEntity<long>, IEntity, IIdentified
  {
    /// <summary>Уникальный идентификатор</summary>
    [DisplayName(typeof (__Resources_IGlobalScriptModule), "P_Uid_DisplayName")]
    [EntityProperty]
    [View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [EleWise.ELMA.Model.Attributes.Uid("ce4d1b92-0a1c-4d17-807c-d37e83ff2717")]
    [GuidSettings(FieldName = "Uid")]
    [SystemProperty]
    [NotNull]
    Guid Uid { get; set; }

    /// <summary>Модуль сценариев</summary>
    [DisplayName(typeof (__Resources_IGlobalScriptModule), "P_ScriptModule_DisplayName")]
    [EleWise.ELMA.Model.Attributes.Uid("05cf171f-626b-42d6-844f-170155092f84")]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "53eba73b-29a5-4609-9d37-a93e409dc09f")]
    [Order(1)]
    [EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "ScriptModule")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    ScriptModule ScriptModule { get; set; }

    /// <summary>Заголовок</summary>
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [EleWise.ELMA.Model.Attributes.Uid("d583b287-9d63-42b9-8156-41fb1f8a42d6")]
    [EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Header")]
    [DisplayName(typeof (__Resources_IGlobalScriptModule), "P_Header_DisplayName")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "9fb8f30f-4c1a-4db6-97db-cefc39b5448d")]
    [EntityProperty]
    [Order(2)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    IGlobalScriptModuleHeader Header { get; set; }

    /// <summary>Элементы модуля</summary>
    /// <remarks>Папки и файлы в виде сериализованного объекта</remarks>
    [Order(3)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [EntityProperty]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [XmlSerializableObjectSettings(FieldName = "Items")]
    [Property("66c7898b-e56b-49e0-bfb8-9f9c4a7a0c52")]
    [Description(typeof (__Resources_IGlobalScriptModule), "P_Items_Description")]
    [DisplayName(typeof (__Resources_IGlobalScriptModule), "P_Items_DisplayName")]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [EleWise.ELMA.Model.Attributes.Uid("1f3cc48f-0a62-4dcf-a758-710211522232")]
    object Items { get; set; }

    /// <summary>Файл проекта</summary>
    /// <remarks>.csproj</remarks>
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Description(typeof (__Resources_IGlobalScriptModule), "P_ProjectFile_Description")]
    [StringSettings(MultiLine = true, FieldName = "ProjectFile")]
    [DisplayName(typeof (__Resources_IGlobalScriptModule), "P_ProjectFile_DisplayName")]
    [EntityProperty]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [EleWise.ELMA.Model.Attributes.Uid("a9896c66-5623-4a62-8c7b-a6b73b0fc13d")]
    [Order(4)]
    string ProjectFile { get; set; }
  }
}
