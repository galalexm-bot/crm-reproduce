// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.PanelViewItemCollapseType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>
  /// Для сворачиваемой панели варианты отображения по умолчанию
  /// </summary>
  public enum PanelViewItemCollapseType
  {
    /// <summary>Развернута по умолчанию</summary>
    [XmlEnum("false")] DefaultExpanded,
    /// <summary>Свернута по умолчанию</summary>
    [XmlEnum("true")] DefaultCollapsed,
    /// <summary>Свернута, если все внутренние поля пустые</summary>
    [XmlEnum("collapsedIfEmpty")] CollapsedIfEmpty,
  }
}
