// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.ExtensionPoints.IFullTextSearchMappingProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System;

namespace EleWise.ELMA.FullTextSearch.ExtensionPoints
{
  /// <summary>Провадйер с поддержкой маппинга</summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IFullTextSearchMappingProvider : IFullTextSearchProvider
  {
    /// <summary>Обновить маппинг по всем карточкам</summary>
    void UpdateMapping();

    /// <summary>Обновить маппинг</summary>
    /// <param name="cardType">Тип карточки объекта полнотекстового поиска</param>
    void UpdateMapping(Type cardType);
  }
}
