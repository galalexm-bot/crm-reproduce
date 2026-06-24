// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Events.MethodCallEndEvent
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Events
{
  /// <summary>
  /// Событие, сигнализирующее об окончании выполнения метода
  /// </summary>
  public class MethodCallEndEvent : AbstractCallEndEvent<MethodCallInfo>
  {
    private static MethodCallEndEvent qFUN0UETpOdaOt1JB6TV;

    /// <summary>Ctor</summary>
    /// <param name="info">Информация о вызове метода</param>
    public MethodCallEndEvent(MethodCallInfo info)
    {
      MethodCallEndEvent.SxiwLQETtWJuP07TQkh9();
      // ISSUE: explicit constructor call
      this.\u002Ector((CallContextInfo) MethodCallEndEvent.LKpu43ETwH3vK99QEM87((object) info), info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполния</param>
    /// <param name="info">Информация о вызове функции</param>
    public MethodCallEndEvent(CallContextInfo callContextInfo, MethodCallInfo info)
    {
      MethodCallEndEvent.SxiwLQETtWJuP07TQkh9();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo, info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void SxiwLQETtWJuP07TQkh9() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object LKpu43ETwH3vK99QEM87([In] object obj0) => (object) ((AbstractCallInfo) obj0).ContextInfo;

    internal static bool UdO6NIETam3a23laFfe4() => MethodCallEndEvent.qFUN0UETpOdaOt1JB6TV == null;

    internal static MethodCallEndEvent e6sBTNETDN2FuESbJhpA() => MethodCallEndEvent.qFUN0UETpOdaOt1JB6TV;
  }
}
