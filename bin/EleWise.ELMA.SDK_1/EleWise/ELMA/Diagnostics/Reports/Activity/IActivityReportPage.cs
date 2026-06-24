// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Activity.IActivityReportPage
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Reports.Excel;
using System.Collections.Generic;

namespace EleWise.ELMA.Diagnostics.Reports.Activity
{
  /// <summary>Страница отчета о текущей активности в системе</summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IActivityReportPage
  {
    /// <summary>Имя страницы</summary>
    string Name { get; }

    /// <summary>Экспортировать в Excel</summary>
    /// <param name="currentCalls">Информация о текущих вызовах</param>
    /// <param name="builder">Построитель отчета</param>
    void ExportExcel(IEnumerable<CallContextInfo> currentCalls, ExcelReportBuilder builder);
  }
}
