// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.MetricsContainer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Attributes;
using EleWise.ELMA.Diagnostics.Metrics.Internal;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Diagnostics.Metrics
{
  /// <summary>Контейнер метрик</summary>
  public sealed class MetricsContainer : Dictionary<Type, IMetricGroup>
  {
    private readonly ReaderWriterLockSlim rwLock;
    private static readonly Type genericMetricGroupType;
    internal static MetricsContainer wCYV4EEZa5yLYJDpbeQ8;

    /// <summary>Ctor</summary>
    public MetricsContainer()
    {
      MetricsContainer.U2SdFaEZwoacQGDrAV92();
      this.rwLock = new ReaderWriterLockSlim();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Periods = new List<DateTimeRange>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Дата/время начала сбора метрик</summary>
    public DateTime StartTime
    {
      get => this.\u003CStartTime\u003Ek__BackingField;
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
              this.\u003CStartTime\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
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

    /// <summary>Периоды сбора метрик</summary>
    public List<DateTimeRange> Periods { get; set; }

    /// <summary>Получить или добавить группу метрик</summary>
    /// <typeparam name="T">Тип метрики</typeparam>
    /// <param name="comparer">Компаратор для ключа метрики</param>
    /// <returns></returns>
    public MetricsGroup<T> GetOrAdd<T>(IEqualityComparer<string> comparer = null) where T : IMetric, new()
    {
      orAdd = (MetricsGroup<T>) null;
      AggregatorAttribute attribute = AttributeHelper<AggregatorAttribute>.GetAttribute(TypeOf<T>.Raw, false);
      if (attribute == null)
        throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123878916), (object) TypeOf<T>.Name));
      IMetricGroup metricGroup = (IMetricGroup) null;
      if (this.rwLock.TryEnterUpgradeableReadLock(50))
      {
        try
        {
          if (this.TryGetValue(attribute.Type, out metricGroup))
          {
            if (metricGroup is MetricsGroup<T> orAdd)
              goto label_9;
          }
          orAdd = new MetricsGroup<T>(comparer);
          this.rwLock.EnterWriteLock();
          try
          {
            this.Add(attribute.Type, (IMetricGroup) orAdd);
          }
          finally
          {
            this.rwLock.ExitWriteLock();
          }
        }
        finally
        {
          this.rwLock.ExitUpgradeableReadLock();
        }
      }
label_9:
      return orAdd;
    }

    /// <summary>Получить группу метрик</summary>
    /// <typeparam name="T">Тип метрики</typeparam>
    /// <returns></returns>
    public MetricsGroup<T> Get<T>() where T : IMetric, new()
    {
      AggregatorAttribute attribute = AttributeHelper<AggregatorAttribute>.GetAttribute(TypeOf<T>.Raw, true);
      if (attribute == null)
        throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 132668093), (object) TypeOf<T>.Name));
      IMetricGroup metricGroup = (IMetricGroup) null;
      if (this.rwLock.TryEnterReadLock(50))
      {
        try
        {
          this.TryGetValue(attribute.Type, out metricGroup);
        }
        finally
        {
          this.rwLock.ExitReadLock();
        }
      }
      return metricGroup as MetricsGroup<T>;
    }

    /// <summary>Объединить контейнеры метрик</summary>
    /// <param name="container">Контейнер метрик</param>
    public void Merge(MetricsContainer container)
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (MetricsContainer.iD1ERXEZ4d60JsJ01ZTI((object) this.rwLock, 50))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
              continue;
            }
            goto label_10;
          case 2:
            goto label_14;
          default:
            goto label_5;
        }
      }
label_14:
      return;
label_10:
      return;
label_5:
      try
      {
        container.ForEach<KeyValuePair<Type, IMetricGroup>>((Action<KeyValuePair<Type, IMetricGroup>>) (a =>
        {
          IMetricGroup metricGroup1;
          if (this.TryGetValue(a.Key, out metricGroup1))
          {
            IMetricGroup metricGroup2 = a.Value;
            if (metricGroup1 == null || metricGroup2 == null)
              return;
            metricGroup1.Merge(metricGroup2);
          }
          else
          {
            if (!(Activator.CreateInstance(MetricsContainer.genericMetricGroupType.MakeGenericType(a.Value.GetType().GetGenericArguments()[0])) is IMetricGroup instance2))
              return;
            instance2.Merge(a.Value);
            this.rwLock.EnterWriteLock();
            try
            {
              this.Add(a.Key, instance2);
            }
            finally
            {
              this.rwLock.ExitWriteLock();
            }
          }
        }));
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        MetricsContainer.WgZZJVEZ6YJJrHNcdkDR((object) this.rwLock);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    static MetricsContainer()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            MetricsContainer.U2SdFaEZwoacQGDrAV92();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            // ISSUE: type reference
            MetricsContainer.genericMetricGroupType = MetricsContainer.Wa5bfVEZHMiy7D2Zcl2o(__typeref (MetricsGroup<>));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static void U2SdFaEZwoacQGDrAV92() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool QRi2qBEZDK5dkvAc9qss() => MetricsContainer.wCYV4EEZa5yLYJDpbeQ8 == null;

    internal static MetricsContainer m1ASiFEZtswwFxXbcbWB() => MetricsContainer.wCYV4EEZa5yLYJDpbeQ8;

    internal static bool iD1ERXEZ4d60JsJ01ZTI([In] object obj0, [In] int obj1) => ((ReaderWriterLockSlim) obj0).TryEnterUpgradeableReadLock(obj1);

    internal static void WgZZJVEZ6YJJrHNcdkDR([In] object obj0) => ((ReaderWriterLockSlim) obj0).ExitUpgradeableReadLock();

    internal static Type Wa5bfVEZHMiy7D2Zcl2o([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);
  }
}
