// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ViewItemHideMode
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Режим скрытия элементов на форме</summary>
  [Flags]
  public enum ViewItemHideMode
  {
    /// <summary>Не скрывать</summary>
    None = 0,
    /// <summary>Скрывать на основной форме</summary>
    Main = 1,
    /// <summary>Скрывать на форме в модальных окнах (popup)</summary>
    Modal = 2,
  }
}
