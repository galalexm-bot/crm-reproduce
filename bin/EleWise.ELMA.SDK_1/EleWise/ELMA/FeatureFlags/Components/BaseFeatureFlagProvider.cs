// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FeatureFlags.Components.BaseFeatureFlagProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.FeatureFlags.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.FeatureFlags.Components
{
  /// <summary>Базовый провайдер флагов функций</summary>
  internal abstract class BaseFeatureFlagProvider : IFeatureFlagProvider
  {
    private static BaseFeatureFlagProvider a8n2xDGWAuDTDe82alnA;

    private event EventHandler flagsChanged
    {
      add
      {
        int num = 1;
        while (true)
        {
          EventHandler eventHandler1;
          EventHandler comparand;
          EventHandler eventHandler2;
          switch (num)
          {
            case 1:
              eventHandler2 = this.flagsChanged;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            case 3:
              if (eventHandler2 == comparand)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 2 : 2;
                continue;
              }
              break;
            case 4:
              eventHandler2 = Interlocked.CompareExchange<EventHandler>(ref this.flagsChanged, eventHandler1, comparand);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 3 : 2;
              continue;
            case 5:
              eventHandler1 = comparand + value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 4 : 3;
              continue;
          }
          comparand = eventHandler2;
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 2 : 5;
        }
label_2:;
      }
      remove
      {
        int num = 3;
        EventHandler eventHandler1;
        EventHandler comparand;
        EventHandler eventHandler2;
        while (true)
        {
          switch (num)
          {
            case 1:
              eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.flagsChanged, eventHandler2, comparand);
              num = 4;
              continue;
            case 2:
              comparand = eventHandler1;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
              continue;
            case 3:
              eventHandler1 = this.flagsChanged;
              num = 2;
              continue;
            case 4:
              if (eventHandler1 == comparand)
              {
                num = 5;
                continue;
              }
              goto case 2;
            case 5:
              goto label_2;
            default:
              eventHandler2 = (EventHandler) BaseFeatureFlagProvider.o66pJxGW0JASTNqxfXUo((object) comparand, (object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 1 : 1;
              continue;
          }
        }
label_2:;
      }
    }

    event EventHandler IFeatureFlagProvider.FlagsChanged
    {
      add
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.flagsChanged += value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
      remove
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.flagsChanged -= value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
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

    /// <summary>Состояния флагов изменились</summary>
    protected void FlagsChanged()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_5;
          case 1:
            goto label_3;
          case 2:
            EventHandler flagsChanged = this.flagsChanged;
            if (flagsChanged == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 1 : 1;
              continue;
            }
            flagsChanged((object) this, EventArgs.Empty);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_5:
      return;
label_3:
      return;
label_2:;
    }

    /// <inheritdoc />
    public abstract IEnumerable<(string featureFlagName, bool enabled)> GetFlags(
      IEnumerable<string> featureFlagNames);

    protected BaseFeatureFlagProvider()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool DiGa56GW7kqkOuV9W9vL() => BaseFeatureFlagProvider.a8n2xDGWAuDTDe82alnA == null;

    internal static BaseFeatureFlagProvider u5VBAqGWxSE0jM4PV1pF() => BaseFeatureFlagProvider.a8n2xDGWAuDTDe82alnA;

    internal static object o66pJxGW0JASTNqxfXUo([In] object obj0, [In] object obj1) => (object) Delegate.Remove((Delegate) obj0, (Delegate) obj1);
  }
}
