// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Performance.ColumnBuilders.BackgroundTasksThreadJoinColumnBuilder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics;
using EleWise.ELMA.Diagnostics.Reports.Excel;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Diagnostics.Reports.Performance.ColumnBuilders
{
  /// <summary>
  /// Построитель столбцов статистики по ожиданию завершения потоков в отчете по фоновым задачам
  /// </summary>
  [Component]
  internal class BackgroundTasksThreadJoinColumnBuilder : IPerformanceReportPageColumnBuilder
  {
    private static BackgroundTasksThreadJoinColumnBuilder FYKj9WEvxNj9YUoRRoOX;

    /// <inheritdoc />
    public void AddColumn<TMetric>(MetricExcelTable<TMetric> table) where TMetric : IMetric
    {
      if (!(table is MetricExcelTable<BackgroundTaskMetric> metricExcelTable))
        return;
      string title = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87092761));
      metricExcelTable.AddColumn<double>(330L, title, 10.0, (Func<BackgroundTaskMetric, double>) (s =>
      {
        int num1 = 3;
        TimeSpan timeSpan;
        while (true)
        {
          int num2 = num1;
          MetricsGroup<ThreadJoinMetric> source;
          while (true)
          {
            switch (num2)
            {
              case 1:
                timeSpan = source.Sum<KeyValuePair<string, ThreadJoinMetric>>((Func<KeyValuePair<string, ThreadJoinMetric>, TimeSpan>) (c => c.Value.TotalTime));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
                continue;
              case 2:
                if (source != null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 1;
                  continue;
                }
                goto label_7;
              case 3:
                goto label_5;
              default:
                goto label_6;
            }
          }
label_5:
          source = s.Metrics.Get<ThreadJoinMetric>();
          num1 = 2;
        }
label_6:
        return timeSpan.TotalMilliseconds;
label_7:
        return 0.0;
      }));
    }

    public BackgroundTasksThreadJoinColumnBuilder()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool N1i6vHEv0bbWb0vXcsXK() => BackgroundTasksThreadJoinColumnBuilder.FYKj9WEvxNj9YUoRRoOX == null;

    internal static BackgroundTasksThreadJoinColumnBuilder DFgIVvEvmWp31khZBJxu() => BackgroundTasksThreadJoinColumnBuilder.FYKj9WEvxNj9YUoRRoOX;
  }
}
