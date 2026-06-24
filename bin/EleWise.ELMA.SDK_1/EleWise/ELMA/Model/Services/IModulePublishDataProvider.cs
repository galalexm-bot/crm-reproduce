// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Services.IModulePublishDataProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Services
{
  /// <summary>
  /// Сервис подготовки/проверки метаданных и зависимости модуля для публикации
  /// </summary>
  internal interface IModulePublishDataProvider
  {
    /// <summary>Подготовить метаданные модуля</summary>
    /// <param name="module">Метаданные модуля</param>
    /// <param name="extendedModuleContext">Расширенный контекст модулей, является приоритетным при подборе зависимостей</param>
    /// <returns>Метаданные зависимостей</returns>
    IReadOnlyCollection<ModuleVersion> PrepareData(
      ModuleInfoMetadata module,
      IEnumerable<ModuleVersion> extendedModuleContext = null);
  }
}
