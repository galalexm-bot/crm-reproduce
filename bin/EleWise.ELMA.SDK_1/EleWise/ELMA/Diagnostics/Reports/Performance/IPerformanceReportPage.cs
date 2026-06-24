// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Performance.IPerformanceReportPage
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics;
using EleWise.ELMA.Diagnostics.Reports.Excel;

namespace EleWise.ELMA.Diagnostics.Reports.Performance
{
  /// <summary>Страница отчета по производительности системы</summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IPerformanceReportPage
  {
    /// <summary>Имя страницы</summary>
    string Name { get; }

    /// <summary>Экспортировать в Excel</summary>
    /// <param name="metrics">Контейнер с метриками</param>
    /// <param name="builder">Построитель отчета</param>
    void ExportExcel(MetricsContainer metrics, ExcelReportBuilder builder);
  }
}
