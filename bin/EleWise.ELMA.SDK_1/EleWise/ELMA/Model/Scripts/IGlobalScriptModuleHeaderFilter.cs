// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.IGlobalScriptModuleHeaderFilter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>
  /// Фильтр для объекта "Заголовок глобального модуля сценариев"
  /// </summary>
  [FilterFor(typeof (IGlobalScriptModuleHeader))]
  public interface IGlobalScriptModuleHeaderFilter : IEntityFilter
  {
    /// <summary>Фильтр для свойства "Название"</summary>
    string Name { get; set; }

    /// <summary>Фильтр для свойства "Пространство имен"</summary>
    string Namespace { get; set; }

    /// <summary>Фильтр для свойства "Удален"</summary>
    bool? Deleted { get; set; }

    /// <summary>Только загруженные</summary>
    [Uid("cbb5598b-8dc6-4c45-8d1f-7894e06721a2")]
    [CustomFilterProperty]
    [NotNull]
    [BoolSettings(FieldName = "LoadedOnly")]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [DisplayName("SR.M('Только загруженные')")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    bool LoadedOnly { get; set; }

    /// <summary>Только опубликованные</summary>
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [BoolSettings(FieldName = "PublishedOnly")]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [NotNull]
    [CustomFilterProperty]
    [Uid("9384316c-57ed-47e6-b718-cef39d8d75f3")]
    [Order(1)]
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [DisplayName("SR.M('Только опубликованные')")]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    bool PublishedOnly { get; set; }
  }
}
