// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.IExpandableMetric
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Collections.Generic;

namespace EleWise.ELMA.Diagnostics.Metrics
{
  /// <summary>Интерфейс метрики поддерживающей расширение</summary>
  public interface IExpandableMetric : IMetric
  {
    /// <summary>Дополнительные метрики</summary>
    IEnumerable<IMetric> AdditionalParameters { get; }

    /// <summary>Добавить дополнительную метрику</summary>
    /// <param name="metric">Метрика</param>
    void AddAdditionalParameters(IMetric metric);
  }
}
