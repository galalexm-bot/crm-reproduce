// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Events.ExecuteResultCallErrorEvent
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Events
{
  /// <summary>
  /// Событие, сигнализирующее об ошибке в процессе выполнения ExecuteResult
  /// </summary>
  public class ExecuteResultCallErrorEvent : AbstractCallErrorEvent<ExecuteResultCallInfo>
  {
    internal static ExecuteResultCallErrorEvent mrgn4eEXuw82jsDjCCY8;

    /// <summary>Ctor</summary>
    /// <param name="info">Информация о вызове</param>
    public ExecuteResultCallErrorEvent(ExecuteResultCallInfo info)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    /// <param name="info">Информация о вызове</param>
    public ExecuteResultCallErrorEvent(CallContextInfo callContextInfo, ExecuteResultCallInfo info)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo, info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool RniU0EEXIgmf1ZpCqrK0() => ExecuteResultCallErrorEvent.mrgn4eEXuw82jsDjCCY8 == null;

    internal static ExecuteResultCallErrorEvent Cc9Q0OEXV1BHGqtEHIb0() => ExecuteResultCallErrorEvent.mrgn4eEXuw82jsDjCCY8;
  }
}
