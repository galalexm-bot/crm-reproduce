// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Activity.ActivityReportPage
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Reports.Excel;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Diagnostics.Reports.Activity
{
  /// <summary>
  /// Базовый класс для страницы отчета по производительности
  /// </summary>
  [Component]
  public abstract class ActivityReportPage : IActivityReportPage
  {
    private static ActivityReportPage xT8EqnEf5ZOYtErM0pNJ;

    /// <summary>Имя страницы</summary>
    public abstract string Name { get; }

    /// <summary>Экспортировать в Excel</summary>
    /// <param name="currentCalls">Информация о текущих вызовах</param>
    /// <param name="builder">Построитель отчета</param>
    public abstract void ExportExcel(
      IEnumerable<CallContextInfo> currentCalls,
      ExcelReportBuilder builder);

    protected ActivityReportPage()
    {
      ActivityReportPage.x98fJvEfLuUU5qGy12lR();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void x98fJvEfLuUU5qGy12lR() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool eGxQQDEfjIFiLmuY78vP() => ActivityReportPage.xT8EqnEf5ZOYtErM0pNJ == null;

    internal static ActivityReportPage s1N2kSEfYhblMZwHjD5O() => ActivityReportPage.xT8EqnEf5ZOYtErM0pNJ;
  }
}
