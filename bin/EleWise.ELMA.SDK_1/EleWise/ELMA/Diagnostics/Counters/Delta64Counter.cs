// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Counters.Delta64Counter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Counters
{
  public abstract class Delta64Counter : BaseCounter
  {
    private string _counterName;
    private string _counterDescription;
    private PerformanceCounter _counter;
    internal static Delta64Counter HMT5reEn8FvtXEwF6P0J;

    public Delta64Counter()
    {
      Delta64Counter.JH5V3VEnIm07OHll28tM();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
        num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this._counterDescription = (string) Delta64Counter.AUajJEEnVuC0VTuQX5Gr((object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
            continue;
          case 2:
            this._counterName = this.Name;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 1 : 1;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    public void Increment()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            Delta64Counter.xMotDjEnSlyIiF309Vug((object) this._counter);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public void IncrementBy(long value)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this._counter.IncrementBy(value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    protected override IEnumerable<CounterCreationData> GetCreationData() => (IEnumerable<CounterCreationData>) new Delta64Counter.\u003CGetCreationData\u003Ed__3(-2)
    {
      \u003C\u003E4__this = this
    };

    protected override void Init(string category)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this._counter = this.CreateCounter(category, this._counterName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static void JH5V3VEnIm07OHll28tM() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object AUajJEEnVuC0VTuQX5Gr([In] object obj0) => (object) ((BaseCounter) obj0).Description;

    internal static bool k5OqfSEnZpfT5HIAepHU() => Delta64Counter.HMT5reEn8FvtXEwF6P0J == null;

    internal static Delta64Counter eMZmxcEnuOVyMRwsdLVN() => Delta64Counter.HMT5reEn8FvtXEwF6P0J;

    internal static long xMotDjEnSlyIiF309Vug([In] object obj0) => ((PerformanceCounter) obj0).Increment();
  }
}
