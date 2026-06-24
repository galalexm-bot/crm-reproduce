// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Events.FindViewStartEvent
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Events
{
  /// <summary>
  /// Событие, сигнализирующее о начале поиска представления
  /// </summary>
  public class FindViewStartEvent : AbstractCallStartEvent<FindViewInfo>
  {
    private static FindViewStartEvent DCnNbEEK6ktttsMh3M4A;

    /// <summary>Ctor</summary>
    /// <param name="info">Информация о поиске представления</param>
    public FindViewStartEvent(FindViewInfo info)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    /// <param name="info">Информация о поиске представления</param>
    public FindViewStartEvent(CallContextInfo callContextInfo, FindViewInfo info)
    {
      FindViewStartEvent.rGaGfXEK7LgQAwbikAnr();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo, info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool uD5KuMEKHJYHvvcT1vBj() => FindViewStartEvent.DCnNbEEK6ktttsMh3M4A == null;

    internal static FindViewStartEvent KP3B9nEKAENyHMDlkswe() => FindViewStartEvent.DCnNbEEK6ktttsMh3M4A;

    internal static void rGaGfXEK7LgQAwbikAnr() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
