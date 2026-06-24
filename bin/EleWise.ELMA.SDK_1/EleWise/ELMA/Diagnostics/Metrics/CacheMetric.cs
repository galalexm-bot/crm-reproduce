// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.CacheMetric
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
  /// <summary>Метрики работы с кешем</summary>
  [Aggregator(typeof (CacheQueryCallMetricAggregator))]
  public class CacheMetric : CountTimeMetric
  {
    private static CacheMetric UoblQSE8NX7b6DZk5oal;

    /// <inheritdoc />
    public override Guid Uid => new Guid((string) CacheMetric.n8KfxNE8aEyny2V54PbY(1654249598 >> 2 ^ 413285197));

    /// <summary>Количество чтений из кеша</summary>
    [Order(60)]
    [DisplayName(typeof (CacheMetric.__CacheMetricLocalization), "ReadTotalCount")]
    public long ReadTotalCount
    {
      get => this.\u003CReadTotalCount\u003Ek__BackingField;
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
              this.\u003CReadTotalCount\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
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

    /// <summary>Суммарное время чтения из кеша</summary>
    [Order(70)]
    [DisplayName(typeof (CacheMetric.__CacheMetricLocalization), "ReadTotalTime")]
    public TimeSpan ReadTotalTime
    {
      get => this.\u003CReadTotalTime\u003Ek__BackingField;
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
              this.\u003CReadTotalTime\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
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

    /// <summary>Среднее время чтения из кеша</summary>
    [DisplayName(typeof (CacheMetric.__CacheMetricLocalization), "AvgReadTime")]
    [Order(80)]
    public double AvgReadTime
    {
      get
      {
        int num = 1;
        TimeSpan readTotalTime;
        while (true)
        {
          switch (num)
          {
            case 1:
              readTotalTime = this.ReadTotalTime;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        return readTotalTime.TotalMilliseconds / (double) this.ReadTotalCount;
      }
    }

    /// <summary>Количество ошибок при чтении из кеша</summary>
    [Order(90)]
    [DisplayName(typeof (CacheMetric.__CacheMetricLocalization), "ReadErrorTotalCount")]
    public long ReadErrorTotalCount
    {
      get => this.\u003CReadErrorTotalCount\u003Ek__BackingField;
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
              this.\u003CReadErrorTotalCount\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
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

    /// <summary>Количество результативных чтений из кеша</summary>
    [DisplayName(typeof (CacheMetric.__CacheMetricLocalization), "SuccesReadTotalCount")]
    [Order(100)]
    public long SuccesReadTotalCount
    {
      get => this.\u003CSuccesReadTotalCount\u003Ek__BackingField;
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
              this.\u003CSuccesReadTotalCount\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
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

    /// <summary>Количество записей в кеш</summary>
    [DisplayName(typeof (CacheMetric.__CacheMetricLocalization), "WriteTotalCount")]
    [Order(110)]
    public long WriteTotalCount
    {
      get => this.\u003CWriteTotalCount\u003Ek__BackingField;
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
              this.\u003CWriteTotalCount\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
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

    /// <summary>Суммарное время записи в кеш</summary>
    [Order(120)]
    [DisplayName(typeof (CacheMetric.__CacheMetricLocalization), "WriteTotalTime")]
    public TimeSpan WriteTotalTime
    {
      get => this.\u003CWriteTotalTime\u003Ek__BackingField;
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
              this.\u003CWriteTotalTime\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
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

    /// <summary>Среднее время записи в кеш</summary>
    [DisplayName(typeof (CacheMetric.__CacheMetricLocalization), "AvgWriteTime")]
    [Order(130)]
    public double AvgWriteTime
    {
      get
      {
        int num = 1;
        TimeSpan writeTotalTime;
        while (true)
        {
          switch (num)
          {
            case 1:
              writeTotalTime = this.WriteTotalTime;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return writeTotalTime.TotalMilliseconds / (double) this.WriteTotalCount;
      }
    }

    /// <summary>Количество ошибок при записи в кеш</summary>
    [Order(140)]
    [DisplayName(typeof (CacheMetric.__CacheMetricLocalization), "WriteErrorTotalCount")]
    public long WriteErrorTotalCount
    {
      get => this.\u003CWriteErrorTotalCount\u003Ek__BackingField;
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
              this.\u003CWriteErrorTotalCount\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
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

    /// <summary>Количество блокировок кеша</summary>
    [Order(150)]
    [DisplayName(typeof (CacheMetric.__CacheMetricLocalization), "LockTotalCount")]
    public long LockTotalCount
    {
      get => this.\u003CLockTotalCount\u003Ek__BackingField;
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
              this.\u003CLockTotalCount\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
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

    /// <summary>Суммарное время блокировки кеша</summary>
    [DisplayName(typeof (CacheMetric.__CacheMetricLocalization), "LockTotalTime")]
    [Order(160)]
    public TimeSpan LockTotalTime
    {
      get => this.\u003CLockTotalTime\u003Ek__BackingField;
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
              this.\u003CLockTotalTime\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
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

    /// <summary>Среднее время блокировки кеша</summary>
    [Order(170)]
    [DisplayName(typeof (CacheMetric.__CacheMetricLocalization), "AvgLockTime")]
    public double AvgLockTime
    {
      get
      {
        int num = 1;
        TimeSpan lockTotalTime;
        while (true)
        {
          switch (num)
          {
            case 1:
              lockTotalTime = this.LockTotalTime;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        return lockTotalTime.TotalMilliseconds / (double) this.LockTotalCount;
      }
    }

    /// <summary>Количество ошибок при блокировке кеша</summary>
    [Order(180)]
    [DisplayName(typeof (CacheMetric.__CacheMetricLocalization), "LockErrorTotalCount")]
    public long LockErrorTotalCount
    {
      get => this.\u003CLockErrorTotalCount\u003Ek__BackingField;
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
              this.\u003CLockErrorTotalCount\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
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

    /// <summary>Количество успешных блокировок кеша</summary>
    [DisplayName(typeof (CacheMetric.__CacheMetricLocalization), "LockSuccesTotalCount")]
    [Order(190)]
    public long LockSuccesTotalCount => this.LockTotalCount - this.LockErrorTotalCount;

    /// <inheritdoc />
    public override void Merge(IMetric metric)
    {
      int num = 7;
      CacheMetric cacheMetric;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_8;
          case 2:
            this.ReadTotalCount += CacheMetric.Ripl2fE8Dfv8TB2kPdon((object) cacheMetric);
            num = 4;
            continue;
          case 3:
            base.Merge(metric);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 2 : 0;
            continue;
          case 4:
            this.ReadTotalTime = CacheMetric.qk5pWKE8thYeuMbaDNkv(this.ReadTotalTime, cacheMetric.ReadTotalTime);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 11 : 0;
            continue;
          case 5:
            this.WriteTotalCount += CacheMetric.F5IHGuE86igJxS4ECu9Y((object) cacheMetric);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 9 : 6;
            continue;
          case 6:
            if (cacheMetric == null)
            {
              num = 14;
              continue;
            }
            goto case 3;
          case 7:
            cacheMetric = metric as CacheMetric;
            num = 6;
            continue;
          case 8:
            this.LockErrorTotalCount += CacheMetric.Iwfm0CE800fOJarO3Z7w((object) cacheMetric);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 1 : 1;
            continue;
          case 9:
            this.WriteTotalTime += CacheMetric.ojTF08E8HdrfURjF4RTZ((object) cacheMetric);
            num = 10;
            continue;
          case 10:
            this.WriteErrorTotalCount += CacheMetric.raAK6jE8AMh8krDRXd2U((object) cacheMetric);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
            continue;
          case 11:
            this.ReadErrorTotalCount += CacheMetric.crIjT5E8wyObyqNqqA29((object) cacheMetric);
            num = 13;
            continue;
          case 12:
            this.LockTotalTime = CacheMetric.qk5pWKE8thYeuMbaDNkv(this.LockTotalTime, CacheMetric.xx3o7ME8xQfVvUpvJ5e6((object) cacheMetric));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 2 : 8;
            continue;
          case 13:
            this.SuccesReadTotalCount += CacheMetric.bZ5PUhE8477n6hDxMq52((object) cacheMetric);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 1 : 5;
            continue;
          case 14:
            goto label_2;
          default:
            this.LockTotalCount += CacheMetric.tvJSRfE87o7PTYBBc79h((object) cacheMetric);
            num = 12;
            continue;
        }
      }
label_8:
      return;
label_2:;
    }

    public CacheMetric()
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

    internal static object n8KfxNE8aEyny2V54PbY(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool oLhIj1E83DfBHVTIglQ8() => CacheMetric.UoblQSE8NX7b6DZk5oal == null;

    internal static CacheMetric dhlTkAE8piDn50Ib9YAY() => CacheMetric.UoblQSE8NX7b6DZk5oal;

    internal static long Ripl2fE8Dfv8TB2kPdon([In] object obj0) => ((CacheMetric) obj0).ReadTotalCount;

    internal static TimeSpan qk5pWKE8thYeuMbaDNkv([In] TimeSpan obj0, [In] TimeSpan obj1) => obj0 + obj1;

    internal static long crIjT5E8wyObyqNqqA29([In] object obj0) => ((CacheMetric) obj0).ReadErrorTotalCount;

    internal static long bZ5PUhE8477n6hDxMq52([In] object obj0) => ((CacheMetric) obj0).SuccesReadTotalCount;

    internal static long F5IHGuE86igJxS4ECu9Y([In] object obj0) => ((CacheMetric) obj0).WriteTotalCount;

    internal static TimeSpan ojTF08E8HdrfURjF4RTZ([In] object obj0) => ((CacheMetric) obj0).WriteTotalTime;

    internal static long raAK6jE8AMh8krDRXd2U([In] object obj0) => ((CacheMetric) obj0).WriteErrorTotalCount;

    internal static long tvJSRfE87o7PTYBBc79h([In] object obj0) => ((CacheMetric) obj0).LockTotalCount;

    internal static TimeSpan xx3o7ME8xQfVvUpvJ5e6([In] object obj0) => ((CacheMetric) obj0).LockTotalTime;

    internal static long Iwfm0CE800fOJarO3Z7w([In] object obj0) => ((CacheMetric) obj0).LockErrorTotalCount;

    internal static class __CacheMetricLocalization
    {
      internal static CacheMetric.__CacheMetricLocalization YZyQ198KG6WwKvciQHVV;

      public static string ReadTotalCount => EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1445902765 ^ -1980277732 ^ 539228765));

      public static string ReadTotalTime => (string) CacheMetric.__CacheMetricLocalization.fD2XPc8KQ4UpELd37hLx((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210406517));

      public static string AvgReadTime => (string) CacheMetric.__CacheMetricLocalization.fD2XPc8KQ4UpELd37hLx(CacheMetric.__CacheMetricLocalization.O2ZyrB8KCMqNNWKjg0DG(516838154 ^ 516666242));

      public static string ReadErrorTotalCount => (string) CacheMetric.__CacheMetricLocalization.fD2XPc8KQ4UpELd37hLx(CacheMetric.__CacheMetricLocalization.O2ZyrB8KCMqNNWKjg0DG(1461625753 ^ 1461404503));

      public static string SuccesReadTotalCount => EleWise.ELMA.SR.T((string) CacheMetric.__CacheMetricLocalization.O2ZyrB8KCMqNNWKjg0DG(1021410165 ^ 1021614703));

      public static string WriteTotalCount => (string) CacheMetric.__CacheMetricLocalization.fD2XPc8KQ4UpELd37hLx(CacheMetric.__CacheMetricLocalization.O2ZyrB8KCMqNNWKjg0DG(~-397266137 ^ 396897718));

      public static string WriteTotalTime => (string) CacheMetric.__CacheMetricLocalization.fD2XPc8KQ4UpELd37hLx(CacheMetric.__CacheMetricLocalization.O2ZyrB8KCMqNNWKjg0DG(1242972401 >> 4 ^ 77890989));

      public static string AvgWriteTime => EleWise.ELMA.SR.T((string) CacheMetric.__CacheMetricLocalization.O2ZyrB8KCMqNNWKjg0DG(-1839087379 - 334718690 ^ 2120989653));

      public static string WriteErrorTotalCount => (string) CacheMetric.__CacheMetricLocalization.fD2XPc8KQ4UpELd37hLx(CacheMetric.__CacheMetricLocalization.O2ZyrB8KCMqNNWKjg0DG(-345420348 ^ -345198620));

      public static string LockTotalCount => (string) CacheMetric.__CacheMetricLocalization.fD2XPc8KQ4UpELd37hLx(CacheMetric.__CacheMetricLocalization.O2ZyrB8KCMqNNWKjg0DG(92412609 - 1050237057 ^ -957538264));

      public static string LockTotalTime => (string) CacheMetric.__CacheMetricLocalization.fD2XPc8KQ4UpELd37hLx(CacheMetric.__CacheMetricLocalization.O2ZyrB8KCMqNNWKjg0DG(-1822890472 ^ -1822620488));

      public static string AvgLockTime => EleWise.ELMA.SR.T((string) CacheMetric.__CacheMetricLocalization.O2ZyrB8KCMqNNWKjg0DG(-1876063057 ^ -1876398515));

      public static string LockErrorTotalCount => (string) CacheMetric.__CacheMetricLocalization.fD2XPc8KQ4UpELd37hLx((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138332846));

      public static string LockSuccesTotalCount => (string) CacheMetric.__CacheMetricLocalization.fD2XPc8KQ4UpELd37hLx((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1853222532));

      internal static bool bqvg7o8KENwKWel3nN8u() => CacheMetric.__CacheMetricLocalization.YZyQ198KG6WwKvciQHVV == null;

      internal static CacheMetric.__CacheMetricLocalization J4esdQ8KfjxtmWKMm9JJ() => CacheMetric.__CacheMetricLocalization.YZyQ198KG6WwKvciQHVV;

      internal static object fD2XPc8KQ4UpELd37hLx([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static object O2ZyrB8KCMqNNWKjg0DG(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
    }
  }
}
