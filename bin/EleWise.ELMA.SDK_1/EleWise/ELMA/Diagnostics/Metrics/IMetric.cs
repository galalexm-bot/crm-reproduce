// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.IMetric
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Diagnostics.Metrics
{
  /// <summary>Базовый интерфейс метрики</summary>
  public interface IMetric
  {
    /// <summary>Уникальный идентификатор метрики</summary>
    Guid Uid { get; }

    /// <summary>Объединить показатели двух метрик</summary>
    /// <param name="metric">Метрика</param>
    void Merge(IMetric metric);
  }
}
