// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.Impl.Processors.CacheQueryCallMetricProcessor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Metrics.Impl.Processors
{
  /// <summary>Обработчик для метрики CacheMetric</summary>
  [Component]
  public class CacheQueryCallMetricProcessor : IMetricProcessor
  {
    internal static CacheQueryCallMetricProcessor iWfy1nEu1k3oSD1klOWQ;

    /// <inheritdoc />
    public Type[] AggregatorTypes => new Type[1]
    {
      TypeOf<CacheQueryCallMetricAggregator>.Raw
    };

    /// <inheritdoc />
    public void Process(object callInfo, IMetric currentMetric)
    {
      int num1 = 23;
      while (true)
      {
        int num2 = num1;
        CacheMetric cacheMetric1;
        CacheReadInfo cacheReadInfo;
        CacheLockInfo cacheLockInfo;
        CacheWriteInfo cacheWriteInfo;
        while (true)
        {
          switch (num2)
          {
            case 1:
              CacheMetric cacheMetric2 = cacheMetric1;
              CacheQueryCallMetricProcessor.c09wHOEugV4O6rGkxaEU((object) cacheMetric2, CacheQueryCallMetricProcessor.yh9L1JEurn9dM9XiDO0T((object) cacheMetric2) + 1L);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 2 : 2;
              continue;
            case 2:
              goto label_33;
            case 3:
              if (CacheQueryCallMetricProcessor.EqIRMIEuwN9XH97iUI0d((object) cacheWriteInfo) != null)
              {
                num2 = 24;
                continue;
              }
              goto case 8;
            case 4:
              goto label_3;
            case 5:
            case 16:
              cacheWriteInfo = callInfo as CacheWriteInfo;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 11 : 0;
              continue;
            case 6:
              if (cacheLockInfo == null)
              {
                num2 = 4;
                continue;
              }
              goto case 18;
            case 7:
              CacheMetric cacheMetric3 = cacheMetric1;
              cacheMetric3.WriteTotalTime = CacheQueryCallMetricProcessor.FxcPeSEutMqDhPSe4i0u(CacheQueryCallMetricProcessor.kQDooPEu0ahi22CFYoFX((object) cacheMetric3), CacheQueryCallMetricProcessor.WV7QrUEumKtlXkhObNC4((object) cacheWriteInfo));
              num2 = 3;
              continue;
            case 8:
              cacheLockInfo = callInfo as CacheLockInfo;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 4 : 6;
              continue;
            case 9:
              CacheMetric cacheMetric4 = cacheMetric1;
              CacheQueryCallMetricProcessor.QojhyvEu7Ak7gYAQ3YQ8((object) cacheMetric4, CacheQueryCallMetricProcessor.SxBeAjEuA5vbx9m0h0ni((object) cacheMetric4) + 1L);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 8 : 16;
              continue;
            case 10:
              CacheMetric cacheMetric5 = cacheMetric1;
              CacheQueryCallMetricProcessor.RNLx4xEu6lMTvXgWHe9G((object) cacheMetric5, CacheQueryCallMetricProcessor.WOG287Eu4vXGTmr2nLtI((object) cacheMetric5) + 1L);
              num2 = 17;
              continue;
            case 11:
              if (cacheWriteInfo != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
                continue;
              }
              goto case 8;
            case 12:
              if (CacheQueryCallMetricProcessor.EqIRMIEuwN9XH97iUI0d((object) cacheReadInfo) != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 10;
                continue;
              }
              goto case 17;
            case 13:
              if (cacheReadInfo != null)
                goto case 14;
              else
                goto label_32;
            case 14:
              CacheMetric cacheMetric6 = cacheMetric1;
              CacheQueryCallMetricProcessor.RJHAs1Eua80jup2EfRUf((object) cacheMetric6, CacheQueryCallMetricProcessor.Xf9tKPEupslC5OhPieN2((object) cacheMetric6) + 1L);
              num2 = 21;
              continue;
            case 15:
              goto label_8;
            case 17:
              if (CacheQueryCallMetricProcessor.RSelohEuHKG3ZquwSZHM((object) cacheReadInfo))
              {
                num2 = 9;
                continue;
              }
              goto case 5;
            case 18:
              CacheMetric cacheMetric7 = cacheMetric1;
              CacheQueryCallMetricProcessor.l7Vk7vEu9cuni3Iq2c7L((object) cacheMetric7, CacheQueryCallMetricProcessor.xEGdYREuJU2mKu0q0Y1D((object) cacheMetric7) + 1L);
              num2 = 15;
              continue;
            case 19:
              goto label_5;
            case 20:
              if (CacheQueryCallMetricProcessor.EqIRMIEuwN9XH97iUI0d((object) cacheLockInfo) != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 1 : 1;
                continue;
              }
              goto label_27;
            case 21:
              CacheMetric cacheMetric8 = cacheMetric1;
              cacheMetric8.ReadTotalTime = CacheQueryCallMetricProcessor.FxcPeSEutMqDhPSe4i0u(CacheQueryCallMetricProcessor.JrOmddEuDwGAD2ZBYcer((object) cacheMetric8), cacheReadInfo.TotalTime);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 11 : 12;
              continue;
            case 22:
              if (cacheMetric1 == null)
              {
                num2 = 19;
                continue;
              }
              cacheReadInfo = callInfo as CacheReadInfo;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 13;
              continue;
            case 23:
              CacheQueryInfo cacheQueryInfo = callInfo as CacheQueryInfo;
              cacheMetric1 = currentMetric as CacheMetric;
              if (cacheQueryInfo != null)
              {
                num2 = 22;
                continue;
              }
              goto label_38;
            case 24:
              CacheMetric cacheMetric9 = cacheMetric1;
              CacheQueryCallMetricProcessor.iuXEBxEuMKQfKDMWELfW((object) cacheMetric9, CacheQueryCallMetricProcessor.aAve5WEuy2VrYBCR4OGl((object) cacheMetric9) + 1L);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 8 : 8;
              continue;
            default:
              CacheMetric cacheMetric10 = cacheMetric1;
              CacheQueryCallMetricProcessor.lvlvAKEuxdkLobwZyc3c((object) cacheMetric10, cacheMetric10.WriteTotalCount + 1L);
              num2 = 7;
              continue;
          }
        }
label_8:
        CacheMetric cacheMetric11 = cacheMetric1;
        CacheQueryCallMetricProcessor.h8KNJQEulpOEvU0n7vMB((object) cacheMetric11, CacheQueryCallMetricProcessor.wfZneSEudJiBP8xFkFOw((object) cacheMetric11) + cacheLockInfo.TotalTime);
        num1 = 20;
        continue;
label_32:
        num1 = 5;
      }
label_33:
      return;
label_3:
      return;
label_5:
      return;
label_27:
      return;
label_38:;
    }

    public CacheQueryCallMetricProcessor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool k6lh52EuNUNBulQVYVZy() => CacheQueryCallMetricProcessor.iWfy1nEu1k3oSD1klOWQ == null;

    internal static CacheQueryCallMetricProcessor QYFDkIEu3wphiA6paKQZ() => CacheQueryCallMetricProcessor.iWfy1nEu1k3oSD1klOWQ;

    internal static long Xf9tKPEupslC5OhPieN2([In] object obj0) => ((CacheMetric) obj0).ReadTotalCount;

    internal static void RJHAs1Eua80jup2EfRUf([In] object obj0, long value) => ((CacheMetric) obj0).ReadTotalCount = value;

    internal static TimeSpan JrOmddEuDwGAD2ZBYcer([In] object obj0) => ((CacheMetric) obj0).ReadTotalTime;

    internal static TimeSpan FxcPeSEutMqDhPSe4i0u([In] TimeSpan obj0, [In] TimeSpan obj1) => obj0 + obj1;

    internal static object EqIRMIEuwN9XH97iUI0d([In] object obj0) => (object) ((AbstractCallInfo) obj0).Exception;

    internal static long WOG287Eu4vXGTmr2nLtI([In] object obj0) => ((CacheMetric) obj0).ReadErrorTotalCount;

    internal static void RNLx4xEu6lMTvXgWHe9G([In] object obj0, long value) => ((CacheMetric) obj0).ReadErrorTotalCount = value;

    internal static bool RSelohEuHKG3ZquwSZHM([In] object obj0) => ((CacheReadInfo) obj0).Success;

    internal static long SxBeAjEuA5vbx9m0h0ni([In] object obj0) => ((CacheMetric) obj0).SuccesReadTotalCount;

    internal static void QojhyvEu7Ak7gYAQ3YQ8([In] object obj0, long value) => ((CacheMetric) obj0).SuccesReadTotalCount = value;

    internal static void lvlvAKEuxdkLobwZyc3c([In] object obj0, long value) => ((CacheMetric) obj0).WriteTotalCount = value;

    internal static TimeSpan kQDooPEu0ahi22CFYoFX([In] object obj0) => ((CacheMetric) obj0).WriteTotalTime;

    internal static TimeSpan WV7QrUEumKtlXkhObNC4([In] object obj0) => ((AbstractCallInfo) obj0).TotalTime;

    internal static long aAve5WEuy2VrYBCR4OGl([In] object obj0) => ((CacheMetric) obj0).WriteErrorTotalCount;

    internal static void iuXEBxEuMKQfKDMWELfW([In] object obj0, long value) => ((CacheMetric) obj0).WriteErrorTotalCount = value;

    internal static long xEGdYREuJU2mKu0q0Y1D([In] object obj0) => ((CacheMetric) obj0).LockTotalCount;

    internal static void l7Vk7vEu9cuni3Iq2c7L([In] object obj0, long value) => ((CacheMetric) obj0).LockTotalCount = value;

    internal static TimeSpan wfZneSEudJiBP8xFkFOw([In] object obj0) => ((CacheMetric) obj0).LockTotalTime;

    internal static void h8KNJQEulpOEvU0n7vMB([In] object obj0, TimeSpan value) => ((CacheMetric) obj0).LockTotalTime = value;

    internal static long yh9L1JEurn9dM9XiDO0T([In] object obj0) => ((CacheMetric) obj0).LockErrorTotalCount;

    internal static void c09wHOEugV4O6rGkxaEU([In] object obj0, long value) => ((CacheMetric) obj0).LockErrorTotalCount = value;
  }
}
