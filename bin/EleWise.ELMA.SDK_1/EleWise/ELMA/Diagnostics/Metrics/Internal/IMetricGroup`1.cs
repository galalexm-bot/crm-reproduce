// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.Internal.IMetricGroup`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Diagnostics.Metrics.Internal
{
  /// <summary>Типизированный интерфейс группы метрк</summary>
  /// <typeparam name="T">Тип метрики</typeparam>
  public interface IMetricGroup<T> : IMetricGroup where T : IMetric
  {
    /// <summary>Получить или добавить метрику для элемента</summary>
    /// <param name="name"></param>
    /// <returns></returns>
    T GetOrAdd(string name);
  }
}
