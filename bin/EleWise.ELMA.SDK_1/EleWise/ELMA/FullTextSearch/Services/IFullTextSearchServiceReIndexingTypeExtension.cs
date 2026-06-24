// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Services.IFullTextSearchServiceReIndexingTypeExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.FullTextSearch.Model;

namespace EleWise.ELMA.FullTextSearch.Services
{
  /// <summary>
  /// Сервис полнотекстового поиска с поддержкой переиндексации по типу
  /// </summary>
  public interface IFullTextSearchServiceReIndexingTypeExtension : IFullTextSearchService
  {
    /// <summary>Обработать элемент очереди реиндексирования по типу</summary>
    /// <param name="item">Элемент очереди индексирования</param>
    IndexResult ReIndexingByType(IIndexQueue item);
  }
}
