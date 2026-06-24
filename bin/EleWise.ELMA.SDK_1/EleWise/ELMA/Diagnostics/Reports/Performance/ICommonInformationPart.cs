// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Performance.ICommonInformationPart
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics;
using System.Collections.Generic;

namespace EleWise.ELMA.Diagnostics.Reports.Performance
{
  /// <summary>Блок общей информации</summary>
  [ExtensionPoint(ComponentType.Server)]
  public interface ICommonInformationPart
  {
    /// <summary>Заголовок блока</summary>
    string Title { get; }

    /// <summary>Получить элементы блока</summary>
    /// <param name="metrics">Метрики</param>
    /// <returns></returns>
    IEnumerable<CommonInformationPartItem> GetItems(MetricsContainer metrics);
  }
}
