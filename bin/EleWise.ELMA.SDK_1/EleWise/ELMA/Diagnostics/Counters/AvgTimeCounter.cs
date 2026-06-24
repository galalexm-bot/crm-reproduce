// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Counters.AvgTimeCounter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Counters
{
  public abstract class AvgTimeCounter : BaseCounter
  {
    private string _counterName;
    private string _counterDescription;
    private string _counterBaseName;
    private PerformanceCounter _counter;
    private PerformanceCounter _counterBase;
    private static AvgTimeCounter Ta88nJEkylTC6r6dFOSY;

    public AvgTimeCounter()
    {
      AvgTimeCounter.QNwaxwEk9V0qjyyhRIXN();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
        num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this._counterBaseName = SR.T((string) AvgTimeCounter.LW5v5iEklMcsqTO78f1f(-1822890472 ^ -1822639586), (object) this._counterName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
            continue;
          case 2:
            this._counterName = this.Name;
            num = 3;
            continue;
          case 3:
            this._counterDescription = (string) AvgTimeCounter.NpfBg3Ekd0MS7r51rpGE((object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 1;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_7:;
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
            AvgTimeCounter.RKAYVpEkrh5bPyEfgs16((object) this._counter);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public void IncrementBy(long ticks)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            AvgTimeCounter.RKAYVpEkrh5bPyEfgs16((object) this._counterBase);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
            continue;
          case 2:
            AvgTimeCounter.Rwh4owEkgrli0BAPGyAt((object) this._counter, ticks);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    protected override IEnumerable<CounterCreationData> GetCreationData() => (IEnumerable<CounterCreationData>) new AvgTimeCounter.\u003CGetCreationData\u003Ed__3(-2)
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
          case 1:
            this._counter = this.CreateCounter(category, this._counterName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this._counterBase = this.CreateCounter(category, this._counterBaseName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static void QNwaxwEk9V0qjyyhRIXN() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object NpfBg3Ekd0MS7r51rpGE([In] object obj0) => (object) ((BaseCounter) obj0).Description;

    internal static object LW5v5iEklMcsqTO78f1f(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool z4ZrAXEkM8G4SF5EG58d() => AvgTimeCounter.Ta88nJEkylTC6r6dFOSY == null;

    internal static AvgTimeCounter ajSaTVEkJbRBpaMCONml() => AvgTimeCounter.Ta88nJEkylTC6r6dFOSY;

    internal static long RKAYVpEkrh5bPyEfgs16([In] object obj0) => ((PerformanceCounter) obj0).Increment();

    internal static long Rwh4owEkgrli0BAPGyAt([In] object obj0, [In] long obj1) => ((PerformanceCounter) obj0).IncrementBy(obj1);
  }
}
