// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.IPerformanceCategoryRegistrar
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Collections.Generic;
using System.Diagnostics;

namespace EleWise.ELMA.Diagnostics
{
  /// <summary>Регистратор категорий и счетчиков производительности</summary>
  internal interface IPerformanceCategoryRegistrar
  {
    /// <summary>
    /// Проверить наличие и при необходимости пересоздать категории
    /// </summary>
    void CheckRegisterDefault();

    /// <summary>
    /// Получить имя файла с данными о необходимых категориях и счётчиках производительности
    /// </summary>
    string GetMissingCountersFileName();

    /// <summary>Создать категорию</summary>
    /// <param name="categoryName">Имя категории</param>
    /// <param name="categoryHelp">Описание категории</param>
    /// <param name="categoryType">Типа категории</param>
    /// <param name="allCreationData">Список счетчиков</param>
    void CreateCategory(
      string categoryName,
      string categoryHelp,
      PerformanceCounterCategoryType categoryType,
      IEnumerable<CounterCreationData> allCreationData);
  }
}
