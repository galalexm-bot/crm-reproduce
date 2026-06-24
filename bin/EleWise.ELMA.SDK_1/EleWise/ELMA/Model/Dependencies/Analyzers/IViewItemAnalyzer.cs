// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Dependencies.Analyzers.IViewItemAnalyzer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Model.Dependencies.Analyzers
{
  /// <summary>Точка расширения для анализа ViewItem</summary>
  [ExtensionPoint(ComponentType.All)]
  internal interface IViewItemAnalyzer
  {
    /// <summary>Анализировать ViewItem</summary>
    /// <param name="contextMetadata">контекстные метаданные</param>
    /// <param name="metadata">метаданные</param>
    /// <param name="form">Форма</param>
    /// <param name="options">Настройки для анализа зависимостей</param>
    /// <returns>Результат анализа зависимостей</returns>
    DependencyAnalysisResult Analyse(
      ClassMetadata contextMetadata,
      IMetadata metadata,
      FormViewItem form,
      DependencyServiceOptions options);
  }
}
