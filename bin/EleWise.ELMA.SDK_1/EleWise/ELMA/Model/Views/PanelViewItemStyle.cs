// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.PanelViewItemStyle
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Стиль представления панели</summary>
  public enum PanelViewItemStyle
  {
    [DisplayName(typeof (__PanelViewItemStyleLocalization), "None")] None = 0,
    [DisplayName(typeof (__PanelViewItemStyleLocalization), "GrayHeaderNoBorder")] GrayHeaderNoBorder = 1,
    [DisplayName(typeof (__PanelViewItemStyleLocalization), "Separator")] Separator = 2,
    [DisplayName(typeof (__PanelViewItemStyleLocalization), "YellowSeparator")] YellowSeparator = 3,
    [DisplayName(typeof (__PanelViewItemStyleLocalization), "MetroBrickBlue")] MetroBrickBlue = 100, // 0x00000064
    /// <summary>Белый</summary>
    [DisplayName(typeof (__PanelViewItemStyleLocalization), "WhiteSeparator")] WhiteSeparator = 200, // 0x000000C8
    [DisplayName(typeof (__PanelViewItemStyleLocalization), "Custom")] Custom = 100000, // 0x000186A0
  }
}
