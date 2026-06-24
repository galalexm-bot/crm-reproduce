// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FeatureFlags.Components.EnvironmentFeatureFlagProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Scheduling;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.FeatureFlags.Components
{
  /// <summary>Провайдер флагов для переменных окружения</summary>
  [Component(Order = 2147483647)]
  internal sealed class EnvironmentFeatureFlagProvider : BaseFeatureFlagProvider
  {
    private readonly ILogger logger;
    private IDictionary<string, bool?> flags;
    private IDictionary<string, string> processVariables;
    internal static EnvironmentFeatureFlagProvider x8alaZGWmCTi3JBYjHkP;

    /// <inheritdoc />
    public override IEnumerable<(string featureFlagName, bool enabled)> GetFlags(
      IEnumerable<string> featureFlagNames)
    {
      if (featureFlagNames.Count<string>((Func<string, bool>) (n =>
      {
        int num = 1;
        bool? nullable1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.flags.ContainsKey(n))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
                continue;
              }
              goto case 3;
            case 2:
              goto label_3;
            case 3:
              IDictionary<string, bool?> flags = this.flags;
              string key = n;
              nullable1 = new bool?();
              bool? nullable2 = nullable1;
              flags[key] = nullable2;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 2 : 1;
              continue;
            default:
              goto label_4;
          }
        }
label_3:
        return nullable1.HasValue;
label_4:
        return false;
      })) > 0)
        this.Refresh();
      return this.flags.Where<KeyValuePair<string, bool?>>((Func<KeyValuePair<string, bool?>, bool>) (p => p.Value.HasValue)).Select<KeyValuePair<string, bool?>, (string, bool)>((Func<KeyValuePair<string, bool?>, (string, bool)>) (p => (p.Key, p.Value.Value)));
    }

    private void Refresh()
    {
      int num = 6;
      IDictionary<string, bool?> newFlags;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_17;
          case 2:
            ILogger logger = this.logger;
            object format = EnvironmentFeatureFlagProvider.uo36E4GWJhfCvRPCmOSY(44884861 ^ 45044747);
            object[] objArray = new object[1];
            IDictionary<string, bool?> flags = this.flags;
            // ISSUE: reference to a compiler-generated field
            Func<KeyValuePair<string, bool?>, bool> func1 = EnvironmentFeatureFlagProvider.\u003C\u003Ec.\u003C\u003E9__5_1;
            Func<KeyValuePair<string, bool?>, bool> predicate;
            if (func1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              EnvironmentFeatureFlagProvider.\u003C\u003Ec.\u003C\u003E9__5_1 = predicate = (Func<KeyValuePair<string, bool?>, bool>) (p => p.Value.HasValue);
            }
            else
              goto label_21;
label_16:
            IEnumerable<KeyValuePair<string, bool?>> source = flags.Where<KeyValuePair<string, bool?>>(predicate);
            // ISSUE: reference to a compiler-generated field
            Func<KeyValuePair<string, bool?>, string> func2 = EnvironmentFeatureFlagProvider.\u003C\u003Ec.\u003C\u003E9__5_2;
            Func<KeyValuePair<string, bool?>, string> selector;
            if (func2 == null)
            {
              // ISSUE: reference to a compiler-generated field
              EnvironmentFeatureFlagProvider.\u003C\u003Ec.\u003C\u003E9__5_2 = selector = (Func<KeyValuePair<string, bool?>, string>) (p => Environment.NewLine + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146423073) + p.Key + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867208767) + (object) p.Value);
            }
            else
              goto label_20;
label_19:
            objArray[0] = (object) string.Concat(source.Select<KeyValuePair<string, bool?>, string>(selector));
            logger.InfoFormat((string) format, objArray);
            num = 7;
            continue;
label_20:
            selector = func2;
            goto label_19;
label_21:
            predicate = func1;
            goto label_16;
          case 3:
            this.flags = newFlags;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 2 : 10;
            continue;
          case 4:
            if (EnvironmentFeatureFlagProvider.v2PS43GWd8kj84xcU0pa((object) this.flags) == newFlags.Count)
            {
              num = 9;
              continue;
            }
            goto case 3;
          case 5:
            EnvironmentFeatureFlagProvider.iUEGOYGW9uDjOf5FNrD4((object) this.logger, EnvironmentFeatureFlagProvider.uo36E4GWJhfCvRPCmOSY(-1255365154 ^ 596875508 ^ -1766028786));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 8 : 1;
            continue;
          case 6:
            num = 5;
            continue;
          case 8:
            newFlags = this.ReadFlags();
            num = 4;
            continue;
          case 9:
            if (this.flags.Any<KeyValuePair<string, bool?>>((Func<KeyValuePair<string, bool?>, bool>) (p =>
            {
              bool? nullable1;
              if (!newFlags.TryGetValue(p.Key, out nullable1))
                return true;
              bool? nullable2 = nullable1;
              bool? nullable3 = p.Value;
              return !(nullable2.GetValueOrDefault() == nullable3.GetValueOrDefault() & nullable2.HasValue == nullable3.HasValue);
            })))
            {
              num = 3;
              continue;
            }
            goto label_14;
          case 10:
            if (!this.logger.IsInfoEnabled())
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          default:
            this.FlagsChanged();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 0;
            continue;
        }
      }
label_17:
      return;
label_14:;
    }

    private IDictionary<string, bool?> ReadFlags()
    {
      IDictionary environmentVariables1 = Environment.GetEnvironmentVariables(EnvironmentVariableTarget.User);
      IDictionary environmentVariables2 = Environment.GetEnvironmentVariables(EnvironmentVariableTarget.Machine);
      if (this.processVariables == null)
      {
        lock (this)
        {
          if (this.processVariables == null)
          {
            IDictionary environmentVariables3 = Environment.GetEnvironmentVariables(EnvironmentVariableTarget.Process);
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            IDictionaryEnumerator enumerator = environmentVariables3.GetEnumerator();
            while (enumerator.MoveNext())
            {
              string key = (string) enumerator.Key;
              string str = (string) enumerator.Value;
              if ((environmentVariables1.Contains((object) key) ? ((string) environmentVariables1[(object) key] != str ? 1 : 0) : (!environmentVariables2.Contains((object) key) ? 1 : ((string) environmentVariables2[(object) key] != str ? 1 : 0))) != 0)
                dictionary.Add(key, str);
            }
            this.processVariables = (IDictionary<string, string>) dictionary;
          }
        }
      }
      Dictionary<string, bool?> dictionary1 = new Dictionary<string, bool?>();
      foreach (string key1 in (IEnumerable<string>) this.flags.Keys)
      {
        string key2 = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 45044941), (object) key1);
        string str;
        if (!this.processVariables.TryGetValue(key2, out str))
          str = environmentVariables1.Contains((object) key2) ? (string) environmentVariables1[(object) key2] : (environmentVariables2.Contains((object) key2) ? (string) environmentVariables2[(object) key2] : (string) null);
        if (str == null)
        {
          dictionary1.Add(key1, new bool?());
        }
        else
        {
          bool result;
          if (bool.TryParse(str, out result))
            dictionary1.Add(key1, new bool?(result));
          else if (this.logger.IsDebugEnabled())
            this.logger.Debug((object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87497805), (object) key1));
        }
      }
      return (IDictionary<string, bool?>) dictionary1;
    }

    public EnvironmentFeatureFlagProvider()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: type reference
      this.logger = (ILogger) EnvironmentFeatureFlagProvider.FZPZC3GWrLnmmm8rloaR(EnvironmentFeatureFlagProvider.GjV4W3GWl1GF6fip4dEy(__typeref (EnvironmentFeatureFlagProvider)));
      this.flags = (IDictionary<string, bool?>) new Dictionary<string, bool?>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object uo36E4GWJhfCvRPCmOSY(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void iUEGOYGW9uDjOf5FNrD4([In] object obj0, [In] object obj1) => ((ILogger) obj0).Debug(obj1);

    internal static int v2PS43GWd8kj84xcU0pa([In] object obj0) => ((ICollection<KeyValuePair<string, bool?>>) obj0).Count;

    internal static bool yWOoEdGWypU9ouQ5HgCv() => EnvironmentFeatureFlagProvider.x8alaZGWmCTi3JBYjHkP == null;

    internal static EnvironmentFeatureFlagProvider KnOSL5GWMm7dY6vesNOY() => EnvironmentFeatureFlagProvider.x8alaZGWmCTi3JBYjHkP;

    internal static Type GjV4W3GWl1GF6fip4dEy([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object FZPZC3GWrLnmmm8rloaR(Type componentType) => (object) Logger.GetLogger(componentType);

    [Component]
    private sealed class SweepHandler : ISweepHandler
    {
      private readonly object environmentFeatureFlagProvider;
      private DateTime needUpdate;
      private static object dRo2MsvdfQVGHQrMQ3dp;

      public SweepHandler(
        EnvironmentFeatureFlagProvider environmentFeatureFlagProvider)
      {
        EnvironmentFeatureFlagProvider.SweepHandler.uYxESfvdvOwvre33ttxd();
        this.needUpdate = DateTime.MinValue;
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              this.environmentFeatureFlagProvider = (object) environmentFeatureFlagProvider;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 0;
              continue;
          }
        }
label_3:;
      }

      public void Execute()
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              EnvironmentFeatureFlagProvider.SweepHandler.Qxy0vvvdIIfIiRTUedYJ(this.environmentFeatureFlagProvider);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
              continue;
            case 2:
              this.needUpdate = EnvironmentFeatureFlagProvider.SweepHandler.qmtH9evdZpLlatIQyPkh().AddSeconds((double) EleWise.ELMA.SR.GetSetting<int>((string) EnvironmentFeatureFlagProvider.SweepHandler.Gb3niGvdudDlJyqHE7v9(1051802738 - -1831968059 ^ -1410920721), 60));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 1 : 0;
              continue;
            case 3:
              if (EnvironmentFeatureFlagProvider.SweepHandler.L3W4i8vd8WtroWOdlOWT(DateTime.Now, this.needUpdate))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 2 : 0;
                continue;
              }
              goto label_7;
            default:
              goto label_8;
          }
        }
label_2:
        return;
label_8:
        return;
label_7:;
      }

      internal static void uYxESfvdvOwvre33ttxd() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool POr7kevdQKyjxmXarpkV() => EnvironmentFeatureFlagProvider.SweepHandler.dRo2MsvdfQVGHQrMQ3dp == null;

      internal static EnvironmentFeatureFlagProvider.SweepHandler gmS2CkvdC489xEE4KXYX() => (EnvironmentFeatureFlagProvider.SweepHandler) EnvironmentFeatureFlagProvider.SweepHandler.dRo2MsvdfQVGHQrMQ3dp;

      internal static bool L3W4i8vd8WtroWOdlOWT([In] DateTime obj0, [In] DateTime obj1) => obj0 >= obj1;

      internal static DateTime qmtH9evdZpLlatIQyPkh() => DateTime.Now;

      internal static object Gb3niGvdudDlJyqHE7v9(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static void Qxy0vvvdIIfIiRTUedYJ([In] object obj0) => ((EnvironmentFeatureFlagProvider) obj0).Refresh();
    }
  }
}
