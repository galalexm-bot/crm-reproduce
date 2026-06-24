// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IMetadataSourcesProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model;
using System.Collections.Generic;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>
  /// Провайдер исходных текстов по метаданным для последующей сборки
  /// </summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IMetadataSourcesProvider
  {
    /// <summary>Получить исходные тексты серверной части</summary>
    /// <param name="args">Аргументы</param>
    /// <returns>Коллекция исходных текстов</returns>
    IEnumerable<string> GetServerSources(MetadataSourcesProviderArgs args);

    /// <summary>Получить исходные тексты клиентской части</summary>
    /// <param name="args">Аргументы</param>
    /// <returns>Коллекция исходных текстов</returns>
    IEnumerable<(string fileName, string sourceCode)> GetClientSources(
      MetadataSourcesProviderArgs args);

    /// <summary>Получить исходные тексты клиентских представлений</summary>
    /// <param name="args">Аргументы</param>
    /// <returns>Коллекция исходных текстов</returns>
    IEnumerable<(string fileName, string sourceCode)> GetViewSources(
      MetadataSourcesProviderArgs args);
  }
}
