// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Counters.NumberOfItemsCounter
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
  public abstract class NumberOfItemsCounter : BaseCounter
  {
    private string _counterName;
    private string _counterDescription;
    private PerformanceCounter _counter;
    internal static NumberOfItemsCounter NN9lpXEnil3FmsRMOVdo;

    public NumberOfItemsCounter()
    {
      NumberOfItemsCounter.gu6vRnEnKbN9oGuOgJkW();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
        num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this._counterDescription = (string) NumberOfItemsCounter.qY7jZVEnTwusFC6QarDO((object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
            continue;
          case 2:
            this._counterName = (string) NumberOfItemsCounter.arGRbfEnXTHppivNH4ia((object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 1 : 1;
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
            NumberOfItemsCounter.HhQ9M1Enk8QrP8W67s1l((object) this._counter);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public void Decrement()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this._counter.Decrement();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
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
            NumberOfItemsCounter.wVynclEnnIrtaEHKbDpK((object) this._counter, value);
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

    protected override IEnumerable<CounterCreationData> GetCreationData() => (IEnumerable<CounterCreationData>) new NumberOfItemsCounter.\u003CGetCreationData\u003Ed__4(-2)
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

    internal static void gu6vRnEnKbN9oGuOgJkW() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object arGRbfEnXTHppivNH4ia([In] object obj0) => (object) ((BaseCounter) obj0).Name;

    internal static object qY7jZVEnTwusFC6QarDO([In] object obj0) => (object) ((BaseCounter) obj0).Description;

    internal static bool DvW4uVEnRZnen6PDuP79() => NumberOfItemsCounter.NN9lpXEnil3FmsRMOVdo == null;

    internal static NumberOfItemsCounter ntCgjUEnqAdRoj5wbMmT() => NumberOfItemsCounter.NN9lpXEnil3FmsRMOVdo;

    internal static long HhQ9M1Enk8QrP8W67s1l([In] object obj0) => ((PerformanceCounter) obj0).Increment();

    internal static long wVynclEnnIrtaEHKbDpK([In] object obj0, [In] long obj1) => ((PerformanceCounter) obj0).IncrementBy(obj1);
  }
}
