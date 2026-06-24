// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators.WebRequestMetricAggregator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators
{
  /// <summary>Агрегатор метрик Web-запросов</summary>
  [Component]
  public class WebRequestMetricAggregator : BaseMetricAggregator<CallContextInfo>
  {
    internal static WebRequestMetricAggregator zrN2DrEVELhmouoPpSBB;

    /// <summary>Ctor</summary>
    /// <param name="processors">Обработчики метрики</param>
    public WebRequestMetricAggregator(IEnumerable<IMetricProcessor> processors)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(processors);
    }

    /// <inheritdoc />
    public override void Add(CallContextInfo callInfo, MetricsContainer container)
    {
      int num1 = 7;
      WebRequestMetric orAdd1;
      IEnumerator<IMetricProcessor> enumerator;
      while (true)
      {
        CallContextType? type;
        string str;
        CallContextType callContextType;
        MetricsGroup<WebRequestMetric> orAdd2;
        switch (num1)
        {
          case 1:
          case 12:
            orAdd1 = orAdd2.GetOrAdd(str);
            num1 = 17;
            continue;
          case 2:
            str = (string) WebRequestMetricAggregator.cETGVJEVS842TVnSPCjo((object) str, WebRequestMetricAggregator.W09dO1EVZrdblJ7olbEa(-1710575414 ^ -1710301142), WebRequestMetricAggregator.uKduqwEVIGHdTPgZwQHp((object) callInfo), WebRequestMetricAggregator.W09dO1EVZrdblJ7olbEa(-1921202237 ^ -1921240789));
            num1 = 12;
            continue;
          case 3:
            goto label_26;
          case 4:
            goto label_37;
          case 5:
            callContextType = CallContextType.WebRequest;
            num1 = 8;
            continue;
          case 6:
            if (type.HasValue)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
              continue;
            }
            break;
          case 7:
            type = callInfo.Type;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 1 : 6;
            continue;
          case 8:
            if (!(type.GetValueOrDefault() == callContextType & type.HasValue))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 11 : 13;
              continue;
            }
            break;
          case 9:
            str = (string) WebRequestMetricAggregator.kYtqTREVvlaUIF1K3CmF(WebRequestMetricAggregator.W09dO1EVZrdblJ7olbEa(-1598106783 - -968262081 ^ -629853838), (object) str);
            num1 = 16;
            continue;
          case 10:
            goto label_8;
          case 11:
            if (!str.StartsWith((string) WebRequestMetricAggregator.W09dO1EVZrdblJ7olbEa(333888594 ^ 1075625116 ^ 1408918686)))
            {
              num1 = 9;
              continue;
            }
            goto case 16;
          case 13:
            goto label_13;
          case 14:
            if (WebRequestMetricAggregator.lxxd7HEVVWQMbFPejWcY(WebRequestMetricAggregator.uKduqwEVIGHdTPgZwQHp((object) callInfo), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272490361)))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 1;
              continue;
            }
            goto case 2;
          case 15:
            str = (string) WebRequestMetricAggregator.uQCs8bEV8oZvucBO2tUo((object) new Uri((string) WebRequestMetricAggregator.kYtqTREVvlaUIF1K3CmF((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306203746), WebRequestMetricAggregator.e4ZF9cEVCmpZO61OndTP((object) callInfo)), UriKind.RelativeOrAbsolute));
            num1 = 11;
            continue;
          case 16:
            str = (string) WebRequestMetricAggregator.B0iKrlEVuxbH20xK8bGY((object) str);
            num1 = 18;
            continue;
          case 17:
            enumerator = this.MetricProcessors.GetEnumerator();
            num1 = 3;
            continue;
          case 18:
            if (str.IsNullOrEmpty())
            {
              num1 = 10;
              continue;
            }
            if (!((string) WebRequestMetricAggregator.uKduqwEVIGHdTPgZwQHp((object) callInfo)).IsNullOrEmpty())
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 5 : 14;
              continue;
            }
            goto case 1;
          default:
            type = callInfo.Type;
            num1 = 5;
            continue;
        }
        orAdd2 = container.GetOrAdd<WebRequestMetric>();
        num1 = 15;
      }
label_37:
      return;
label_8:
      return;
label_13:
      return;
label_26:
      try
      {
label_29:
        if (WebRequestMetricAggregator.C0oChMEViSgfnsRYMXiJ((object) enumerator))
          goto label_31;
        else
          goto label_30;
label_27:
        int num2;
        switch (num2)
        {
          case 0:
            return;
          case 1:
            goto label_31;
          case 2:
            goto label_29;
          default:
            return;
        }
label_30:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
        goto label_27;
label_31:
        enumerator.Current.Process((object) callInfo, (IMetric) orAdd1);
        num2 = 2;
        goto label_27;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                enumerator.Dispose();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
                continue;
              default:
                goto label_39;
            }
          }
        }
label_39:;
      }
    }

    private static string CutUrl(object url)
    {
      int num1 = 8;
      int num2;
      while (true)
      {
        int num3;
        int num4;
        int num5;
        switch (num1)
        {
          case 1:
            goto label_15;
          case 2:
            num5 = -1;
            break;
          case 3:
          case 13:
            num4 = WebRequestMetricAggregator.NgePOcEVRp6hPscQ5D73(url, '/', num2 + 1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 1 : 4;
            continue;
          case 4:
            if (num4 >= 0)
            {
              num1 = 5;
              continue;
            }
            goto case 2;
          case 5:
            num5 = num4;
            break;
          case 6:
            goto label_14;
          case 7:
            num3 = 0;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 10 : 10;
            continue;
          case 8:
            num2 = -1;
            num1 = 7;
            continue;
          case 9:
          case 10:
            if (num3 < 4)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 5 : 13;
              continue;
            }
            goto case 11;
          case 11:
            if (num2 >= 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 5 : 6;
              continue;
            }
            goto label_13;
          case 12:
            if (num2 == -1)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 1;
              continue;
            }
            ++num3;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 9 : 3;
            continue;
          default:
            goto label_13;
        }
        num2 = num5;
        num1 = 12;
      }
label_13:
      return (string) url;
label_14:
      return (string) WebRequestMetricAggregator.NRWGAUEVqBW9D7wGVpjW(url, 0, num2);
label_15:
      return (string) url;
    }

    internal static object e4ZF9cEVCmpZO61OndTP([In] object obj0) => (object) ((CallContextInfo) obj0).Name;

    internal static object kYtqTREVvlaUIF1K3CmF([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object uQCs8bEV8oZvucBO2tUo([In] object obj0) => (object) ((Uri) obj0).AbsolutePath;

    internal static object W09dO1EVZrdblJ7olbEa(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object B0iKrlEVuxbH20xK8bGY([In] object obj0) => (object) WebRequestMetricAggregator.CutUrl(obj0);

    internal static object uKduqwEVIGHdTPgZwQHp([In] object obj0) => (object) ((CallContextInfo) obj0).HttpMethod;

    internal static bool lxxd7HEVVWQMbFPejWcY([In] object obj0, [In] object obj1) => ((string) obj0).Equals((string) obj1);

    internal static object cETGVJEVS842TVnSPCjo(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((string) obj0 + (string) obj1 + (string) obj2 + (string) obj3);
    }

    internal static bool C0oChMEViSgfnsRYMXiJ([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static bool UgxrcDEVfpBqPTEkfjqo() => WebRequestMetricAggregator.zrN2DrEVELhmouoPpSBB == null;

    internal static WebRequestMetricAggregator HW0a5SEVQKsnHpuKtk5N() => WebRequestMetricAggregator.zrN2DrEVELhmouoPpSBB;

    internal static int NgePOcEVRp6hPscQ5D73([In] object obj0, [In] char obj1, [In] int obj2) => ((string) obj0).IndexOf(obj1, obj2);

    internal static object NRWGAUEVqBW9D7wGVpjW([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);
  }
}
