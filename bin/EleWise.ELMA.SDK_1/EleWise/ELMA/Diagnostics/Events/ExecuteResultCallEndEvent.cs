// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Events.ExecuteResultCallEndEvent
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Events
{
  /// <summary>
  /// Событие, сигнализирующее об окончании выполнения ExecuteResult
  /// </summary>
  public class ExecuteResultCallEndEvent : AbstractCallEndEvent<ExecuteResultCallInfo>
  {
    internal static ExecuteResultCallEndEvent RnFr8fEXClaXZEkWNKCD;

    /// <summary>Ctor</summary>
    /// <param name="info">Информация о вызове</param>
    public ExecuteResultCallEndEvent(ExecuteResultCallInfo info)
    {
      ExecuteResultCallEndEvent.rKANOJEXZRt7aDpLdyIL();
      // ISSUE: explicit constructor call
      base.\u002Ector(info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    /// <param name="info">Информация о вызове</param>
    public ExecuteResultCallEndEvent(CallContextInfo callContextInfo, ExecuteResultCallInfo info)
    {
      ExecuteResultCallEndEvent.rKANOJEXZRt7aDpLdyIL();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo, info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void rKANOJEXZRt7aDpLdyIL() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool vBWoMCEXvtfKi9k5Huig() => ExecuteResultCallEndEvent.RnFr8fEXClaXZEkWNKCD == null;

    internal static ExecuteResultCallEndEvent bkhs2jEX8pxcCg98ERy2() => ExecuteResultCallEndEvent.RnFr8fEXClaXZEkWNKCD;
  }
}
