// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.BaseMetricAggregator`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EleWise.ELMA.Diagnostics.Metrics
{
  /// <summary>Базовая реализация агрегатора метрик</summary>
  /// <typeparam name="TCallInfo">Тип вызова, для которого работает агрегатор</typeparam>
  public abstract class BaseMetricAggregator<TCallInfo> : IMetricAggregator where TCallInfo : class
  {
    private readonly Type baseMetricAggregatorType;
    private static object VZtlNFEZqvVPP1667BbC;

    /// <summary>Ctor</summary>
    /// <param name="processors">Обработчики</param>
    protected BaseMetricAggregator(IEnumerable<IMetricProcessor> processors)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.baseMetricAggregatorType = typeof (BaseMetricAggregator<>);
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.MetricProcessors = processors.Where<IMetricProcessor>((Func<IMetricProcessor, bool>) (mp =>
      {
        int num1 = 2;
        while (true)
        {
          switch (num1)
          {
            case 1:
              goto label_3;
            case 2:
              if (!((IEnumerable<Type>) mp.AggregatorTypes).Any<Type>((Func<Type, bool>) (at =>
              {
                int num2 = 2;
                while (true)
                {
                  switch (num2)
                  {
                    case 1:
                      goto label_3;
                    case 2:
                      if (at.IsInstanceOfType((object) this))
                      {
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 1 : 1;
                        continue;
                      }
                      goto label_2;
                    default:
                      goto label_2;
                  }
                }
label_2:
                return at == this.baseMetricAggregatorType;
label_3:
                return true;
              })))
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 1 : 1;
                continue;
              }
              goto label_2;
            default:
              goto label_2;
          }
        }
label_2:
        return !((IEnumerable<Type>) this.IgnoredProcessors).Contains<Type>(mp.GetType());
label_3:
        return false;
      }));
    }

    /// <summary>Игнорируемые типы обработчиков</summary>
    public virtual Type[] IgnoredProcessors => new Type[0];

    /// <summary>Обработчики метрик</summary>
    public IEnumerable<IMetricProcessor> MetricProcessors { get; private set; }

    void IMetricAggregator.Add(object callInfo, MetricsContainer container)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(callInfo.GetType() != TypeOf<TCallInfo>.Raw))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_3;
          case 3:
            goto label_7;
          default:
            this.Add((TCallInfo) callInfo, container);
            num = 3;
            continue;
        }
      }
label_3:
      return;
label_7:
      return;
label_2:;
    }

    /// <summary>Добавить информацию о вызове/контексте в метрику</summary>
    /// <param name="callInfo">Информация о вызове</param>
    /// <param name="container">Контейнер метрик</param>
    public abstract void Add(TCallInfo callInfo, MetricsContainer container);

    internal static bool cGBrPrEZKMNgnO0ONYkt() => BaseMetricAggregator<TCallInfo>.VZtlNFEZqvVPP1667BbC == null;

    internal static object aXfejTEZX7Pp5OEoRbrQ() => BaseMetricAggregator<TCallInfo>.VZtlNFEZqvVPP1667BbC;
  }
}
