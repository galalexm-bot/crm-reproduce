// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Events.SqlCommandExecuteErrorEvent
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Events
{
  /// <summary>
  /// Событие, сигнализирующее об ошибке в процессе выполнения SQL-запроса
  /// </summary>
  public class SqlCommandExecuteErrorEvent : AbstractCallErrorEvent<SqlQueryInfo>
  {
    private static SqlCommandExecuteErrorEvent BYOgyOEXsox6Dv1KSCSl;

    /// <summary>Ctor</summary>
    /// <param name="info">Информация об SQL-запросе</param>
    public SqlCommandExecuteErrorEvent(SqlQueryInfo info)
    {
      SqlCommandExecuteErrorEvent.CUGKoyETFxqes9M4elaO();
      // ISSUE: explicit constructor call
      this.\u002Ector((CallContextInfo) SqlCommandExecuteErrorEvent.uRhwblETBQaC9LY7k5Um((object) info), info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    /// <param name="info">Информация об SQL-запросе</param>
    public SqlCommandExecuteErrorEvent(CallContextInfo callContextInfo, SqlQueryInfo info)
    {
      SqlCommandExecuteErrorEvent.CUGKoyETFxqes9M4elaO();
      // ISSUE: explicit constructor call
      this.\u002Ector(callContextInfo, info, (string) SqlCommandExecuteErrorEvent.yJNbS3ETWsw2qXZ0TtvJ((object) info));
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    /// <param name="info">Информация об SQL-запросе</param>
    /// <param name="message">Сообщение</param>
    public SqlCommandExecuteErrorEvent(
      CallContextInfo callContextInfo,
      SqlQueryInfo info,
      string message)
    {
      SqlCommandExecuteErrorEvent.CUGKoyETFxqes9M4elaO();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo, info, message);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void CUGKoyETFxqes9M4elaO() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object uRhwblETBQaC9LY7k5Um([In] object obj0) => (object) ((AbstractCallInfo) obj0).ContextInfo;

    internal static bool cgdI6bEXcQdX5TI94ewY() => SqlCommandExecuteErrorEvent.BYOgyOEXsox6Dv1KSCSl == null;

    internal static SqlCommandExecuteErrorEvent OTXs1qEXzIrMKMBjYDAh() => SqlCommandExecuteErrorEvent.BYOgyOEXsox6Dv1KSCSl;

    internal static object yJNbS3ETWsw2qXZ0TtvJ([In] object obj0) => (object) ((AbstractCallInfo) obj0).Description;
  }
}
