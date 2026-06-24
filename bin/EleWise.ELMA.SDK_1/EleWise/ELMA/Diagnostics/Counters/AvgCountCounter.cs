// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Counters.AvgCountCounter
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
  public abstract class AvgCountCounter : BaseCounter
  {
    private string _counterName;
    private string _counterDescription;
    private string _counterBaseName;
    private PerformanceCounter _counter;
    private PerformanceCounter _counterBase;
    internal static AvgCountCounter HQZRk3Ek41rw5bdKQYOu;

    public AvgCountCounter()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this._counterDescription = (string) AvgCountCounter.qISOMyEk7MlKttVshVQY((object) this);
            num = 3;
            continue;
          case 3:
            this._counterBaseName = SR.T((string) AvgCountCounter.FSjQOPEkxyJs7WuSr3kJ(1253244298 - 1829393894 ^ -575865950), (object) this._counterName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 1 : 0;
            continue;
          default:
            this._counterName = (string) AvgCountCounter.NL4PkVEkACTWTthC3aOO((object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 2;
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
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
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
          case 1:
            AvgCountCounter.MkXk8yEk0ile0iQmWGnC((object) this._counter, value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            AvgCountCounter.TflRJjEkmeCeypnSyjOl((object) this._counterBase);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    protected override IEnumerable<CounterCreationData> GetCreationData() => (IEnumerable<CounterCreationData>) new AvgCountCounter.\u003CGetCreationData\u003Ed__3(-2)
    {
      \u003C\u003E4__this = this
    };

    protected override void Init(string category)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this._counterBase = this.CreateCounter(category, this._counterBaseName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
            continue;
          case 2:
            this._counter = this.CreateCounter(category, this._counterName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object NL4PkVEkACTWTthC3aOO([In] object obj0) => (object) ((BaseCounter) obj0).Name;

    internal static object qISOMyEk7MlKttVshVQY([In] object obj0) => (object) ((BaseCounter) obj0).Description;

    internal static object FSjQOPEkxyJs7WuSr3kJ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool auBtNTEk6yp6vSxw8wSg() => AvgCountCounter.HQZRk3Ek41rw5bdKQYOu == null;

    internal static AvgCountCounter ODgfS0EkHH14882CHrYA() => AvgCountCounter.HQZRk3Ek41rw5bdKQYOu;

    internal static long MkXk8yEk0ile0iQmWGnC([In] object obj0, [In] long obj1) => ((PerformanceCounter) obj0).IncrementBy(obj1);

    internal static long TflRJjEkmeCeypnSyjOl([In] object obj0) => ((PerformanceCounter) obj0).Increment();
  }
}
