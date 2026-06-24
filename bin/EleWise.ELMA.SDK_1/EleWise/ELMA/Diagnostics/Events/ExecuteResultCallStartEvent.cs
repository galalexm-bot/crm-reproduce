// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Events.ExecuteResultCallStartEvent
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Events
{
  /// <summary>
  /// Событие, сигнализирующее о начале выполнения ExecuteResult
  /// </summary>
  public class ExecuteResultCallStartEvent : AbstractCallStartEvent<ExecuteResultCallInfo>
  {
    internal static ExecuteResultCallStartEvent sVrDgrEXSlcU6jWBmwqK;

    /// <summary>Ctor</summary>
    /// <param name="info">Информация о вызове</param>
    public ExecuteResultCallStartEvent(ExecuteResultCallInfo info)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    /// <param name="info">Информация о вызове</param>
    public ExecuteResultCallStartEvent(CallContextInfo callContextInfo, ExecuteResultCallInfo info)
    {
      ExecuteResultCallStartEvent.FwxRYgEXq1jDa4XNmKev();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo, info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool EKyXlGEXiOK71FXbPVhy() => ExecuteResultCallStartEvent.sVrDgrEXSlcU6jWBmwqK == null;

    internal static ExecuteResultCallStartEvent s0JUH9EXRdtHdKuGuIa7() => ExecuteResultCallStartEvent.sVrDgrEXSlcU6jWBmwqK;

    internal static void FwxRYgEXq1jDa4XNmKev() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
