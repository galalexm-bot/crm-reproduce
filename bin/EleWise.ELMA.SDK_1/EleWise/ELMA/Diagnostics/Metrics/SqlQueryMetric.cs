// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.SqlQueryMetric
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Diagnostics.Attributes;
using EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Metrics
{
  /// <summary>Метрики SQL-запроса</summary>
  [Aggregator(typeof (SqlQueryCallMetricAggregator))]
  public class SqlQueryMetric : CountTimeMetric
  {
    internal static SqlQueryMetric hr6g3cEZlhOSZP6u8VbJ;

    /// <inheritdoc />
    public override Guid Uid => new Guid((string) SqlQueryMetric.o6M3tCEZ50IkCSx53JFa(95909607 + 343705423 ^ 439856656));

    /// <summary>Максимальное время выполнения одного запроса</summary>
    [Order(600)]
    [DisplayName(typeof (SqlQueryMetric.__SqlQueryMetricLocalization), "MaxExecuteTime")]
    public long MaxExecuteTime
    {
      get => this.\u003CMaxExecuteTime\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CMaxExecuteTime\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Среднее время выполнения одного запроса</summary>
    [DisplayName(typeof (SqlQueryMetric.__SqlQueryMetricLocalization), "AvgExecuteTime")]
    [Order(700)]
    public double AvgExecuteTime
    {
      get => this.\u003CAvgExecuteTime\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CAvgExecuteTime\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Максимальное время подготовки одного запроса</summary>
    [Order(800)]
    [DisplayName(typeof (SqlQueryMetric.__SqlQueryMetricLocalization), "MaxPrepareTime")]
    public long MaxPrepareTime
    {
      get => this.\u003CMaxPrepareTime\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CMaxPrepareTime\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Среднее время подготовки одного запроса</summary>
    [DisplayName(typeof (SqlQueryMetric.__SqlQueryMetricLocalization), "AvgPrepareTime")]
    [Order(900)]
    public double AvgPrepareTime
    {
      get => this.\u003CAvgPrepareTime\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CAvgPrepareTime\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Общее количество задействованных записей</summary>
    [DisplayName(typeof (SqlQueryMetric.__SqlQueryMetricLocalization), "TotalAffectedRows")]
    [Order(1000)]
    public long TotalAffectedRows
    {
      get => this.\u003CTotalAffectedRows\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CTotalAffectedRows\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <inheritdoc />
    public override void Merge(IMetric metric)
    {
      int num = 4;
      SqlQueryMetric sqlQueryMetric;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.AvgExecuteTime = (this.AvgExecuteTime * (double) this.CountCall + sqlQueryMetric.AvgExecuteTime * (double) sqlQueryMetric.CountCall) / (double) (this.CountCall + SqlQueryMetric.KWRFgTEZYZkdK1LTmpCv((object) sqlQueryMetric));
            num = 2;
            continue;
          case 2:
            if (this.MaxPrepareTime < sqlQueryMetric.MaxPrepareTime)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 9 : 10;
              continue;
            }
            goto case 5;
          case 3:
            if (sqlQueryMetric != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
              continue;
            }
            goto label_16;
          case 4:
            sqlQueryMetric = metric as SqlQueryMetric;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 1 : 3;
            continue;
          case 5:
            this.AvgPrepareTime = (this.AvgPrepareTime * (double) this.CountCall + SqlQueryMetric.eQ8EJUEZUdBsey782Dwj((object) sqlQueryMetric) * (double) sqlQueryMetric.CountCall) / (double) (this.CountCall + SqlQueryMetric.KWRFgTEZYZkdK1LTmpCv((object) sqlQueryMetric));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 9 : 5;
            continue;
          case 6:
            this.MaxExecuteTime = SqlQueryMetric.JZSogIEZjWysl9Pu9ppZ((object) sqlQueryMetric);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 1 : 1;
            continue;
          case 7:
            base.Merge(metric);
            num = 8;
            continue;
          case 8:
            goto label_2;
          case 9:
            this.TotalAffectedRows += SqlQueryMetric.buQEpnEZsrNMVkFK7AlY((object) sqlQueryMetric);
            num = 7;
            continue;
          case 10:
            this.MaxPrepareTime = SqlQueryMetric.A1mS38EZLYAaFg1NkTky((object) sqlQueryMetric);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 2 : 5;
            continue;
          default:
            if (this.MaxExecuteTime < SqlQueryMetric.JZSogIEZjWysl9Pu9ppZ((object) sqlQueryMetric))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 5 : 6;
              continue;
            }
            goto case 1;
        }
      }
label_2:
      return;
label_16:;
    }

    public SqlQueryMetric()
    {
      SqlQueryMetric.dycaosEZc2fcLdaoem30();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object o6M3tCEZ50IkCSx53JFa(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool cZf1qnEZr78hj7Aj6Pup() => SqlQueryMetric.hr6g3cEZlhOSZP6u8VbJ == null;

    internal static SqlQueryMetric g1HPY6EZgd26JRtiGnmN() => SqlQueryMetric.hr6g3cEZlhOSZP6u8VbJ;

    internal static long JZSogIEZjWysl9Pu9ppZ([In] object obj0) => ((SqlQueryMetric) obj0).MaxExecuteTime;

    internal static long KWRFgTEZYZkdK1LTmpCv([In] object obj0) => ((CountMetric) obj0).CountCall;

    internal static long A1mS38EZLYAaFg1NkTky([In] object obj0) => ((SqlQueryMetric) obj0).MaxPrepareTime;

    internal static double eQ8EJUEZUdBsey782Dwj([In] object obj0) => ((SqlQueryMetric) obj0).AvgPrepareTime;

    internal static long buQEpnEZsrNMVkFK7AlY([In] object obj0) => ((SqlQueryMetric) obj0).TotalAffectedRows;

    internal static void dycaosEZc2fcLdaoem30() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static class __SqlQueryMetricLocalization
    {
      private static SqlQueryMetric.__SqlQueryMetricLocalization KHa3mt8Kt5PZ2alYvS8T;

      public static string MaxExecuteTime => (string) SqlQueryMetric.__SqlQueryMetricLocalization.YtaIef8K6qY6OuPgYW76((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1380439818 << 3 ^ 1841602844));

      public static string AvgExecuteTime => EleWise.ELMA.SR.T((string) SqlQueryMetric.__SqlQueryMetricLocalization.UaFOxH8KHvHGSmwiriwH(-16752921 ^ -16401931));

      public static string MaxPrepareTime => (string) SqlQueryMetric.__SqlQueryMetricLocalization.YtaIef8K6qY6OuPgYW76(SqlQueryMetric.__SqlQueryMetricLocalization.UaFOxH8KHvHGSmwiriwH(~-122002947 ^ 121665900));

      public static string AvgPrepareTime => EleWise.ELMA.SR.T((string) SqlQueryMetric.__SqlQueryMetricLocalization.UaFOxH8KHvHGSmwiriwH(1319452732 ^ 1319151592));

      public static string TotalAffectedRows => (string) SqlQueryMetric.__SqlQueryMetricLocalization.YtaIef8K6qY6OuPgYW76(SqlQueryMetric.__SqlQueryMetricLocalization.UaFOxH8KHvHGSmwiriwH(-1146510045 ^ -1146335981));

      internal static object YtaIef8K6qY6OuPgYW76([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static bool S5RILg8KwYr7L0NcAFrQ() => SqlQueryMetric.__SqlQueryMetricLocalization.KHa3mt8Kt5PZ2alYvS8T == null;

      internal static SqlQueryMetric.__SqlQueryMetricLocalization n1xYax8K4MuFbE74l6ur() => SqlQueryMetric.__SqlQueryMetricLocalization.KHa3mt8Kt5PZ2alYvS8T;

      internal static object UaFOxH8KHvHGSmwiriwH(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
    }
  }
}
