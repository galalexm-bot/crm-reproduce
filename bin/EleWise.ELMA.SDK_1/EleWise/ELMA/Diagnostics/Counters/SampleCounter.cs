// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Counters.SampleCounter
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
  public abstract class SampleCounter : BaseCounter
  {
    private string _counterName;
    private string _counterDescription;
    private PerformanceCounter _counter;
    private static SampleCounter tuxSs8EnO9TQN8VJDaqE;

    public SampleCounter()
    {
      SampleCounter.aQa0MWEnPaWM8PlQtwrc();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this._counterDescription = (string) SampleCounter.syTECrEn1dwo9btbD5iv((object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 1;
            continue;
          default:
            this._counterName = this.Name;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 2 : 1;
            continue;
        }
      }
label_3:;
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
            this._counter.Increment();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
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
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    protected override IEnumerable<CounterCreationData> GetCreationData() => (IEnumerable<CounterCreationData>) new SampleCounter.\u003CGetCreationData\u003Ed__3(-2)
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
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static void aQa0MWEnPaWM8PlQtwrc() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object syTECrEn1dwo9btbD5iv([In] object obj0) => (object) ((BaseCounter) obj0).Description;

    internal static bool I1uvlyEn2mAf2PxRHRHf() => SampleCounter.tuxSs8EnO9TQN8VJDaqE == null;

    internal static SampleCounter SRrQ1vEneCCYmFmwDJ4Z() => SampleCounter.tuxSs8EnO9TQN8VJDaqE;
  }
}
