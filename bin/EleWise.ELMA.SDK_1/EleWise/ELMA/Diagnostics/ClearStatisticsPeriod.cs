// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.ClearStatisticsPeriod
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Diagnostics
{
  /// <summary>Период обнуления статистики</summary>
  public enum ClearStatisticsPeriod
  {
    /// <summary>Никогда</summary>
    [DisplayName(typeof (__ClearStatisticsPeriodLocalization), "Never")] Never,
    /// <summary>Раз в день после 1-го экспорта отчетов</summary>
    [DisplayName(typeof (__ClearStatisticsPeriodLocalization), "AfterFirstReportAtDay")] AfterFirstReportAtDay,
    /// <summary>После каждого экспорта отчетов</summary>
    [DisplayName(typeof (__ClearStatisticsPeriodLocalization), "AfterEveryReport")] AfterEveryReport,
  }
}
