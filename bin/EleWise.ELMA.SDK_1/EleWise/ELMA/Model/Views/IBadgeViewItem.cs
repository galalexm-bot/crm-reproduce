// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.IBadgeViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Счетчик</summary>
  internal interface IBadgeViewItem
  {
    /// <summary>Текст</summary>
    string BadgeText { get; set; }

    /// <summary>Отображать счетчик в виде точки</summary>
    bool Dot { get; set; }

    /// <summary>Цвет</summary>
    ButtonStyle BadgeStyle { get; set; }
  }
}
