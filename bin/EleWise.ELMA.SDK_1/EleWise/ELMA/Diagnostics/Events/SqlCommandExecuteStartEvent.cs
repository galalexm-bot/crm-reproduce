// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Events.SqlCommandExecuteStartEvent
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Events
{
  /// <summary>
  /// Событие, сигнализирующее о начале выполнения SQL-запроса
  /// </summary>
  public class SqlCommandExecuteStartEvent : AbstractCallStartEvent<SqlQueryInfo>
  {
    internal static SqlCommandExecuteStartEvent ropgOjEKlhpgY2wOhfLj;

    /// <summary>Ctor</summary>
    /// <param name="info">Информация об SQL-запросе</param>
    public SqlCommandExecuteStartEvent(SqlQueryInfo info)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector((CallContextInfo) SqlCommandExecuteStartEvent.qrVVnXEK54GuKIYM3s2I((object) info), info);
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_8;
          case 1:
            goto label_7;
          case 2:
            if (info.Paramaters == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 1 : 1;
              continue;
            }
            goto case 5;
          case 3:
            this.Message = this.Message + SR.T((string) SqlCommandExecuteStartEvent.xfbrinEKjlW1H9UnW7Ix(1178210108 ^ 1178491146), true) + (string) SqlCommandExecuteStartEvent.CEYP9mEKY9CPAJ4FDrO5((object) info.Paramaters);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
            continue;
          case 4:
            goto label_2;
          case 5:
            if (info.Paramaters.Count <= 0)
            {
              num = 4;
              continue;
            }
            goto case 3;
          default:
            goto label_10;
        }
      }
label_8:
      return;
label_7:
      return;
label_2:
      return;
label_10:;
    }

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    /// <param name="info">Информация об SQL-запросе</param>
    public SqlCommandExecuteStartEvent(CallContextInfo callContextInfo, SqlQueryInfo info)
    {
      SqlCommandExecuteStartEvent.HsK7bFEKL44rOkUHU9wL();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo, info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Message = this.Message + SR.T((string) SqlCommandExecuteStartEvent.xfbrinEKjlW1H9UnW7Ix(964881585 - -1459193222 ^ -1871174655), true) + (string) SqlCommandExecuteStartEvent.CEYP9mEKY9CPAJ4FDrO5((object) info.Paramaters);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 2 : 1;
            continue;
          case 2:
            goto label_3;
          case 3:
            if (info.Paramaters.Count > 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 1;
              continue;
            }
            goto label_9;
          default:
            if (info.Paramaters != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 3 : 0;
              continue;
            }
            goto label_10;
        }
      }
label_3:
      return;
label_9:
      return;
label_10:;
    }

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    /// <param name="info">Информация об SQL-запросе</param>
    /// <param name="message">Сообщение</param>
    public SqlCommandExecuteStartEvent(
      CallContextInfo callContextInfo,
      SqlQueryInfo info,
      string message)
    {
      SqlCommandExecuteStartEvent.HsK7bFEKL44rOkUHU9wL();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo, info, message);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object qrVVnXEK54GuKIYM3s2I([In] object obj0) => (object) ((AbstractCallInfo) obj0).ContextInfo;

    internal static object xfbrinEKjlW1H9UnW7Ix(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object CEYP9mEKY9CPAJ4FDrO5([In] object obj0) => (object) ClassSerializationHelper.SerializeObjectByJsonNet(obj0);

    internal static bool aCsBCTEKruWQiPEun2Rj() => SqlCommandExecuteStartEvent.ropgOjEKlhpgY2wOhfLj == null;

    internal static SqlCommandExecuteStartEvent KkfCQvEKgr9IVbLCOBvx() => SqlCommandExecuteStartEvent.ropgOjEKlhpgY2wOhfLj;

    internal static void HsK7bFEKL44rOkUHU9wL() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
