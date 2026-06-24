// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Performance.PerformanceReportPage
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics;
using EleWise.ELMA.Diagnostics.Reports.Excel;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Diagnostics.Reports.Performance
{
  /// <summary>
  /// Базовый класс для страницы отчета по производительности
  /// </summary>
  [Component]
  public abstract class PerformanceReportPage : IPerformanceReportPage
  {
    private readonly List<IPerformanceReportPageColumnBuilder> performanceReportPageColumnBuilders;

    protected PerformanceReportPage(
      IEnumerable<IPerformanceReportPageColumnBuilder> builders)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.performanceReportPageColumnBuilders = builders.ToList<IPerformanceReportPageColumnBuilder>();
    }

    /// <summary>Построители столбцов отчета</summary>
    public IEnumerable<IPerformanceReportPageColumnBuilder> PerformanceReportPageColumnBuilders => (IEnumerable<IPerformanceReportPageColumnBuilder>) this.performanceReportPageColumnBuilders;

    /// <inheritdoc />
    public abstract string Name { get; }

    /// <inheritdoc />
    public abstract void ExportExcel(MetricsContainer metrics, ExcelReportBuilder builder);
  }
}
