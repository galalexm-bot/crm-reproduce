// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Events.SqlCommandExecuteEndEvent
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Events
{
  /// <summary>
  /// Событие, сигнализирующее об окончании выполнения SQL-запроса
  /// </summary>
  public class SqlCommandExecuteEndEvent : AbstractCallEndEvent<SqlQueryInfo>
  {
    private static SqlCommandExecuteEndEvent xKoijVEX9fxS6ww5gB83;

    /// <summary>Ctor</summary>
    /// <param name="info">Информация об SQL-запросе</param>
    public SqlCommandExecuteEndEvent(SqlQueryInfo info)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector((CallContextInfo) SqlCommandExecuteEndEvent.JaJUwKEXr7pHR5LVsG2p((object) info), info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Сtor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    /// <param name="info">Информация об SQL-запросе</param>
    public SqlCommandExecuteEndEvent(CallContextInfo callContextInfo, SqlQueryInfo info)
    {
      SqlCommandExecuteEndEvent.JfbUYMEXgsUVnbt0eJ3b();
      // ISSUE: explicit constructor call
      this.\u002Ector(callContextInfo, info, (string) SqlCommandExecuteEndEvent.uth0XVEX5QAxhRKFKDqN((object) info));
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    /// <param name="info">Информация об SQL-запросе</param>
    /// <param name="message">Сообщение</param>
    public SqlCommandExecuteEndEvent(
      CallContextInfo callContextInfo,
      SqlQueryInfo info,
      string message)
    {
      SqlCommandExecuteEndEvent.JfbUYMEXgsUVnbt0eJ3b();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo, info, message);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object JaJUwKEXr7pHR5LVsG2p([In] object obj0) => (object) ((AbstractCallInfo) obj0).ContextInfo;

    internal static bool mYAE9JEXdXHN7rabAfTu() => SqlCommandExecuteEndEvent.xKoijVEX9fxS6ww5gB83 == null;

    internal static SqlCommandExecuteEndEvent KUJd6vEXlsueryTwmutm() => SqlCommandExecuteEndEvent.xKoijVEX9fxS6ww5gB83;

    internal static void JfbUYMEXgsUVnbt0eJ3b() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object uth0XVEX5QAxhRKFKDqN([In] object obj0) => (object) ((AbstractCallInfo) obj0).Description;
  }
}
