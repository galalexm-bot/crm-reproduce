// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Model.IFullTextSearchResultItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common.Models;
using System.Collections.Generic;

namespace EleWise.ELMA.FullTextSearch.Model
{
  /// <summary>
  /// Интерфейс элемента модели результата полнотекстового поиска
  /// </summary>
  public interface IFullTextSearchResultItem
  {
    /// <summary>Список вхождений</summary>
    Dictionary<string, List<string>> Highlights { get; set; }

    /// <summary>Общее количество вхождений</summary>
    long HighlightsCount { get; }

    WebData ResultData { get; set; }

    IFullTextSearchObject ResultObject { get; set; }
  }
}
