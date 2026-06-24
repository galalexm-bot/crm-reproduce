// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Excel.MetricExcelTable`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Diagnostics.Metrics;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace EleWise.ELMA.Diagnostics.Reports.Excel
{
  /// <summary>Типизированная странница отчета</summary>
  /// <typeparam name="TMetric">Тип метрики</typeparam>
  public class MetricExcelTable<TMetric> : ExcelTable<KeyValuePair<string, TMetric>> where TMetric : IMetric
  {
    private static object vm3oAwEEP1XUqTurlE4P;

    /// <summary>Добавить колонку</summary>
    /// <typeparam name="TValue">Тип значения</typeparam>
    /// <param name="title">Заголовок</param>
    /// <param name="width">Ширина</param>
    /// <param name="valueAccessor">Функция доступа</param>
    /// <param name="format">Формат</param>
    /// <returns></returns>
    public MetricExcelTable<TMetric> AddColumn<TValue>(
      string title,
      double width,
      Func<KeyValuePair<string, TMetric>, TValue> valueAccessor,
      IExcelCellFormat format = null)
    {
      this.Columns.Add((ExcelTable<KeyValuePair<string, TMetric>>.IColumn) new ExcelTable<KeyValuePair<string, TMetric>>.Column<TValue>()
      {
        Title = title,
        Width = width,
        ValueAccessor = valueAccessor,
        Format = format
      });
      return this;
    }

    /// <summary>Добавить колонку</summary>
    /// <typeparam name="TValue">Тип значения</typeparam>
    /// <param name="order">Порядок</param>
    /// <param name="title">Заголовок</param>
    /// <param name="width">Ширина</param>
    /// <param name="valueAccessor">Функция доступа</param>
    /// <param name="format">Формат</param>
    /// <returns></returns>
    public MetricExcelTable<TMetric> AddColumn<TValue>(
      long order,
      string title,
      double width,
      Func<TMetric, TValue> valueAccessor,
      IExcelCellFormat format = null)
    {
      this.Columns.Add((ExcelTable<KeyValuePair<string, TMetric>>.IColumn) new ExcelTable<KeyValuePair<string, TMetric>>.Column<TValue>()
      {
        Order = order,
        Title = title,
        Width = width,
        ValueAccessor = (Func<KeyValuePair<string, TMetric>, TValue>) (s => valueAccessor(s.Value)),
        Format = format
      });
      return this;
    }

    /// <summary>Добавить колонку</summary>
    /// <typeparam name="TValue">Тип значения</typeparam>
    /// <param name="valueAccessor">Выражение доступа</param>
    /// <param name="width">Ширина</param>
    /// <param name="format">Формат</param>
    /// <returns></returns>
    public MetricExcelTable<TMetric> AddColumn<TValue>(
      Expression<Func<TMetric, TValue>> valueAccessor,
      double width = 10.0,
      IExcelCellFormat format = null)
    {
      string displayName = MetricsHelper<TMetric>.GetDisplayName<TValue>(valueAccessor);
      long order = MetricsHelper<TMetric>.GetOrder<TValue>(valueAccessor);
      Func<TMetric, TValue> accessor = valueAccessor.Compile();
      this.Columns.Add((ExcelTable<KeyValuePair<string, TMetric>>.IColumn) new ExcelTable<KeyValuePair<string, TMetric>>.Column<TValue>()
      {
        Order = order,
        Title = displayName,
        ValueAccessor = (Func<KeyValuePair<string, TMetric>, TValue>) (s => accessor(s.Value)),
        Format = format,
        Width = width
      });
      return this;
    }

    public MetricExcelTable()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool clDhqUEE1mQsUwB1jBm3() => MetricExcelTable<TMetric>.vm3oAwEEP1XUqTurlE4P == null;

    internal static object o67PASEENa1kNK5vjtm5() => MetricExcelTable<TMetric>.vm3oAwEEP1XUqTurlE4P;
  }
}
