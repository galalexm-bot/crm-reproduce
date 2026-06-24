// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.IMetricAggregator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Diagnostics.Metrics
{
  /// <summary>Точка расширения агрегатора метрик</summary>
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  [ExtensionPoint(ServiceScope.Application, ComponentType.Server)]
  public interface IMetricAggregator
  {
    /// <summary>Добавить информацию о вызове/контексте в метрику</summary>
    /// <param name="callInfo">Информация о вызове</param>
    /// <param name="container">Контейнер метрик</param>
    void Add(object callInfo, MetricsContainer container);
  }
}
