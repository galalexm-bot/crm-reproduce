// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.ExtensionPoints.IFullTextSearchFieldsMappingsReIndexingExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.FullTextSearch.ExtensionPoints
{
  /// <summary>
  /// Расширение для объекта полнотекстового поиска с поддержкой переиндексации по типу
  /// </summary>
  [ExtensionPoint(ComponentType.All)]
  internal interface IFullTextSearchFieldsMappingsReIndexingExtension : 
    IFullTextSearchFieldsMappingsExtension,
    IModuleFullTextSearchExtension
  {
    /// <summary>Выключить индексацию объекта</summary>
    /// <param name="disableInfo">Причина выключения</param>
    void DisableIndexing(string disableInfo);
  }
}
