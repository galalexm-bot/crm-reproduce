// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.IMetricProcessor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System;

namespace EleWise.ELMA.Diagnostics.Metrics
{
  /// <summary>Точка расширения обработчика метрики</summary>
  [ExtensionPoint(ComponentType.Server)]
  public interface IMetricProcessor
  {
    /// <summary>Типы совместимых агрегаторов</summary>
    Type[] AggregatorTypes { get; }

    /// <summary>
    /// Обработать данные вызова и вернуть расчетные параметры метрики
    /// </summary>
    /// <param name="callInfo">Информация о вызове/контексте</param>
    /// <param name="currentMetric">Текущая метрика</param>
    void Process(object callInfo, IMetric currentMetric);
  }
}
