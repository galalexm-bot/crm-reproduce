// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Models.IPageItemViewModel
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.UI.Models
{
  /// <summary>Интерфейс модели элемента страницы</summary>
  public interface IPageItemViewModel
  {
    /// <summary>Контекст</summary>
    IEntity Context { get; }

    /// <summary>Представление</summary>
    RootViewItem View { get; }
  }
}
