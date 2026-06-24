// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Events.FindViewEndEvent
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Events
{
  /// <summary>
  /// Событие, сигнализирующее об окончании поиска представления
  /// </summary>
  public class FindViewEndEvent : AbstractCallEndEvent<FindViewInfo>
  {
    private static FindViewEndEvent cREgR4EXKJ0bLMU515YD;

    /// <summary>Ctor</summary>
    /// <param name="info">Информация о поиске представления</param>
    public FindViewEndEvent(FindViewInfo info)
    {
      FindViewEndEvent.BHgqU6EXkHKuPeJDqCmJ();
      // ISSUE: explicit constructor call
      base.\u002Ector(info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    /// <param name="info">Информация о поиске представления</param>
    public FindViewEndEvent(CallContextInfo callContextInfo, FindViewInfo info)
    {
      FindViewEndEvent.BHgqU6EXkHKuPeJDqCmJ();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo, info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void BHgqU6EXkHKuPeJDqCmJ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool mtQG58EXXLZDPoT8HX6b() => FindViewEndEvent.cREgR4EXKJ0bLMU515YD == null;

    internal static FindViewEndEvent gtTREqEXThcdHd23cJ46() => FindViewEndEvent.cREgR4EXKJ0bLMU515YD;
  }
}
