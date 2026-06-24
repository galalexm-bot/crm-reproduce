// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Counters.BaseCounter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Counters
{
  /// <summary>Базовый класс для счетчиков производительности ELMA</summary>
  [Component]
  public abstract class BaseCounter : IPerformanceCounter
  {
    private static BaseCounter r5BHE0EksvG87S82kLLf;

    /// <summary>Имя счетчика</summary>
    public abstract string Name { get; }

    /// <summary>Описание счетчика</summary>
    public abstract string Description { get; }

    /// <summary>Получить данные для создания счетчика</summary>
    /// <returns></returns>
    IEnumerable<CounterCreationData> IPerformanceCounter.GetCreationData() => this.GetCreationData();

    /// <summary>Инициализировать</summary>
    /// <param name="category">Имя категории счетчиков</param>
    void IPerformanceCounter.Init(string category)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Init(category);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Получить данные для создания счетчика</summary>
    /// <returns></returns>
    protected abstract IEnumerable<CounterCreationData> GetCreationData();

    /// <summary>Инициализировать</summary>
    /// <param name="category">Имя категории счетчиков</param>
    protected abstract void Init(string category);

    protected CounterCreationData CreateCounterData(
      string name,
      string description,
      PerformanceCounterType type)
    {
      CounterCreationData counterData = new CounterCreationData();
      BaseCounter.oZeftiEnFncGw9fxrelE((object) counterData, (object) name);
      BaseCounter.GAMqY0EnBaiWIb7l6XfI((object) counterData, (object) description);
      BaseCounter.pRPeO9EnWRNsB6eQexhw((object) counterData, type);
      return counterData;
    }

    protected PerformanceCounter CreateCounter(string category, string name)
    {
      PerformanceCounter counter = new PerformanceCounter();
      counter.CategoryName = category;
      BaseCounter.zndA8VEno1GHnGlUgTUB((object) counter, (object) name);
      counter.MachineName = (string) BaseCounter.K2XrkJEnblrPiwvD57EO(-1998538950 ^ -1998541314);
      BaseCounter.o2nnE3Enhia8fcEYjNEJ((object) counter, false);
      BaseCounter.AvAjW1EnGZ8dritFRfbH((object) counter, 0L);
      return counter;
    }

    protected BaseCounter()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool IGCBVKEkcxha6tIvsWS0() => BaseCounter.r5BHE0EksvG87S82kLLf == null;

    internal static BaseCounter mfdwaEEkzVUctYDeKxCI() => BaseCounter.r5BHE0EksvG87S82kLLf;

    internal static void oZeftiEnFncGw9fxrelE([In] object obj0, [In] object obj1) => ((CounterCreationData) obj0).CounterName = (string) obj1;

    internal static void GAMqY0EnBaiWIb7l6XfI([In] object obj0, [In] object obj1) => ((CounterCreationData) obj0).CounterHelp = (string) obj1;

    internal static void pRPeO9EnWRNsB6eQexhw([In] object obj0, [In] PerformanceCounterType obj1) => ((CounterCreationData) obj0).CounterType = obj1;

    internal static void zndA8VEno1GHnGlUgTUB([In] object obj0, [In] object obj1) => ((PerformanceCounter) obj0).CounterName = (string) obj1;

    internal static object K2XrkJEnblrPiwvD57EO(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void o2nnE3Enhia8fcEYjNEJ([In] object obj0, [In] bool obj1) => ((PerformanceCounter) obj0).ReadOnly = obj1;

    internal static void AvAjW1EnGZ8dritFRfbH([In] object obj0, [In] long obj1) => ((PerformanceCounter) obj0).RawValue = obj1;
  }
}
