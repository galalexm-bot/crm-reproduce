// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.MetricsGroup`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Diagnostics.Metrics.Internal;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Threading;

namespace EleWise.ELMA.Diagnostics.Metrics
{
  /// <summary>Группа метрик</summary>
  /// <typeparam name="T">Тип метрики</typeparam>
  public sealed class MetricsGroup<T> : Dictionary<string, T>, IMetricGroup<T>, IMetricGroup where T : IMetric, new()
  {
    private readonly ReaderWriterLockSlim rwLock;
    internal static object bKCO9MEZAFQtCqvSC52p;

    /// <summary>Ctor</summary>
    public MetricsGroup()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.rwLock = new ReaderWriterLockSlim();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="comparer">Компаратор</param>
    public MetricsGroup(IEqualityComparer<string> comparer = null)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.rwLock = new ReaderWriterLockSlim();
      // ISSUE: explicit constructor call
      base.\u002Ector(comparer);
    }

    /// <inheritdoc />
    public T GetOrAdd(string name)
    {
      T orAdd = default (T);
      if (this.rwLock.TryEnterUpgradeableReadLock(50))
      {
        try
        {
          if (!this.TryGetValue(name, out orAdd))
          {
            orAdd = new T();
            this.rwLock.EnterWriteLock();
            try
            {
              this.Add(name, orAdd);
            }
            finally
            {
              this.rwLock.ExitWriteLock();
            }
          }
        }
        finally
        {
          this.rwLock.ExitUpgradeableReadLock();
        }
      }
      return orAdd;
    }

    /// <inheritdoc />
    public void Merge(IMetricGroup metricGroup)
    {
      int num1 = 4;
      MetricsGroup<T> enumeration;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_14;
          case 1:
            goto label_3;
          case 2:
            goto label_6;
          case 3:
            if (enumeration != null)
            {
              if (this.rwLock.TryEnterUpgradeableReadLock(50))
              {
                num1 = 2;
                continue;
              }
              goto label_9;
            }
            else
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
              continue;
            }
          case 4:
            enumeration = metricGroup as MetricsGroup<T>;
            num1 = 3;
            continue;
          default:
            goto label_10;
        }
      }
label_14:
      return;
label_3:
      return;
label_10:
      return;
label_9:
      return;
label_6:
      try
      {
        enumeration.ForEach<KeyValuePair<string, T>>((Action<KeyValuePair<string, T>>) (g =>
        {
          T obj1 = default (T);
          if (this.TryGetValue(g.Key, out obj1))
          {
            obj1.Merge((IMetric) g.Value);
          }
          else
          {
            T obj2 = new T();
            obj2.Merge((IMetric) g.Value);
            this.rwLock.EnterWriteLock();
            try
            {
              this.Add(g.Key, obj2);
            }
            finally
            {
              this.rwLock.ExitWriteLock();
            }
          }
        }));
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        this.rwLock.ExitUpgradeableReadLock();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    internal static bool Uw2s0YEZ7i6h35POCU5t() => MetricsGroup<T>.bKCO9MEZAFQtCqvSC52p == null;

    internal static object FvnAHBEZxicGPmcweh17() => MetricsGroup<T>.bKCO9MEZAFQtCqvSC52p;
  }
}
