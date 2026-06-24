// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Glimpse.MessagesMakers.SqlCommandMessagesMaker
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Events;
using Glimpse.Ado.Message;
using Glimpse.Core.Extensibility;
using Glimpse.Core.Message;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Glimpse.MessagesMakers
{
  /// <summary>
  /// Точка расширения для генерации сообщений в Glimpse для SqlCommand
  /// </summary>
  [Component]
  internal class SqlCommandMessagesMaker : AbstractMessagesMaker
  {
    internal static SqlCommandMessagesMaker lknvasERkNRR79io3bUm;

    /// <inheritdoc />
    public override Type[] SupportedEventTypes => new Type[2]
    {
      TypeOf<SqlCommandExecuteEndEvent>.Raw,
      TypeOf<SqlCommandExecuteErrorEvent>.Raw
    };

    /// <inheritdoc />
    public override object[] MakeMessages(DiagnosticsEvent @event)
    {
      int num = 2;
      IDiagnosticsCallInfoEvent diagnosticsCallInfoEvent;
      TimerResult timerResult1;
      DbCommandExecuteMessage commandExecuteMessage;
      CommandDurationAndRowCountMessage andRowCountMessage;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (diagnosticsCallInfoEvent != null)
            {
              num = 4;
              continue;
            }
            goto label_7;
          case 2:
            diagnosticsCallInfoEvent = @event as IDiagnosticsCallInfoEvent;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 0;
            continue;
          case 3:
            goto label_7;
          case 4:
            if (diagnosticsCallInfoEvent.Info is SqlQueryInfo info)
            {
              TimerResult timerResult2 = new TimerResult();
              SqlCommandMessagesMaker.vpbr7jERe6JhbNMjm8hI((object) timerResult2, SqlCommandMessagesMaker.XRcCbrER2Av1tdsaxxdw((object) info));
              SqlCommandMessagesMaker.tMnkFaER3eg3UOoJM7aP((object) timerResult2, SqlCommandMessagesMaker.pKBswSERNBreDdDBPPnl(SqlCommandMessagesMaker.XRcCbrER2Av1tdsaxxdw((object) info), SqlCommandMessagesMaker.choqwIER1Hpykk4LFvqh(SqlCommandMessagesMaker.GcMomFERPGcETaZEmAbP((object) info))));
              SqlCommandMessagesMaker.EpE93DERa6XA5KmtoqRB((object) timerResult2, SqlCommandMessagesMaker.EYq6x1ERpvlRhW34Dnly((object) info));
              timerResult1 = timerResult2;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
              continue;
            }
            num = 3;
            continue;
          case 5:
            if (SqlCommandMessagesMaker.t7y1cdERwPIwcmo3AaQc((object) info) != null)
            {
              num = 7;
              continue;
            }
            andRowCountMessage = new CommandDurationAndRowCountMessage(SqlCommandMessagesMaker.wjeLWTER4IgZkTP5Axj0((object) info), SqlCommandMessagesMaker.QoWBKqERDbXxWkFLsAb8((object) info), info.RowsAffected).AsTimelineMessage<CommandDurationAndRowCountMessage>((string) SqlCommandMessagesMaker.tTxx5MER6jK4EVPUXBI6((object) info), (TimelineCategoryItem) SqlCommandMessagesMaker.xQeIU7ERHJAmR1ko1Tpg()).AsTimedMessage<CommandDurationAndRowCountMessage>(timerResult1);
            num = 6;
            continue;
          case 6:
            goto label_11;
          case 7:
            goto label_9;
          default:
            Guid connectionId = info.ConnectionId;
            Guid commandId = SqlCommandMessagesMaker.QoWBKqERDbXxWkFLsAb8((object) info);
            string sql = info.Sql;
            IList<SqlQueryInfo.CommandParamater> paramaters = info.Paramaters;
            // ISSUE: reference to a compiler-generated field
            Func<SqlQueryInfo.CommandParamater, CommandExecutedParamater> func = SqlCommandMessagesMaker.\u003C\u003Ec.\u003C\u003E9__2_0;
            Func<SqlQueryInfo.CommandParamater, CommandExecutedParamater> selector;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              SqlCommandMessagesMaker.\u003C\u003Ec.\u003C\u003E9__2_0 = selector = (Func<SqlQueryInfo.CommandParamater, CommandExecutedParamater>) (p =>
              {
                CommandExecutedParamater executedParamater = new CommandExecutedParamater();
                // ISSUE: reference to a compiler-generated method
                SqlCommandMessagesMaker.\u003C\u003Ec.EurDsY8XIjp11obo68JC((object) executedParamater, (object) p.Name);
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                SqlCommandMessagesMaker.\u003C\u003Ec.y9AxYa8XSEMjWJ8GUVku((object) executedParamater, SqlCommandMessagesMaker.\u003C\u003Ec.rYo4CR8XVDxiY67PIWhQ((object) p));
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                SqlCommandMessagesMaker.\u003C\u003Ec.Yxfmsi8XRlCuLh4O81Y5((object) executedParamater, SqlCommandMessagesMaker.\u003C\u003Ec.hCnuh58Xi5cRfSBdKpVw((object) p));
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                SqlCommandMessagesMaker.\u003C\u003Ec.oe3JIj8XKKndXs1icICS((object) executedParamater, SqlCommandMessagesMaker.\u003C\u003Ec.ssNueP8XqEGVkRb8aY36((object) p));
                return executedParamater;
              });
            }
            else
              goto label_17;
label_16:
            List<CommandExecutedParamater> list = paramaters.Select<SqlQueryInfo.CommandParamater, CommandExecutedParamater>(selector).ToList<CommandExecutedParamater>();
            commandExecuteMessage = new DbCommandExecuteMessage(connectionId, commandId, sql, (IList<CommandExecutedParamater>) list, true).AsTimedMessage<DbCommandExecuteMessage>(timerResult1).AsTimelineMessage<DbCommandExecuteMessage>((string) SqlCommandMessagesMaker.krAWKUERt4F3rI4EYCL4((object) info), AdoTimelineCategory.Command, SqlCommandMessagesMaker.t7y1cdERwPIwcmo3AaQc((object) info) != null ? ((Exception) SqlCommandMessagesMaker.t7y1cdERwPIwcmo3AaQc((object) info)).Message : "");
            num = 5;
            continue;
label_17:
            selector = func;
            goto label_16;
        }
      }
label_7:
      return new object[0];
label_9:
      return new object[1]{ (object) commandExecuteMessage };
label_11:
      return new object[2]
      {
        (object) commandExecuteMessage,
        (object) andRowCountMessage
      };
    }

    public SqlCommandMessagesMaker()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool bBEO7iERnn0FNvuIGnWf() => SqlCommandMessagesMaker.lknvasERkNRR79io3bUm == null;

    internal static SqlCommandMessagesMaker DmufbmERO20uACQlnFQm() => SqlCommandMessagesMaker.lknvasERkNRR79io3bUm;

    internal static DateTime XRcCbrER2Av1tdsaxxdw([In] object obj0) => ((AbstractCallInfo) obj0).StartTime;

    internal static void vpbr7jERe6JhbNMjm8hI([In] object obj0, [In] DateTime obj1) => ((TimerResult) obj0).StartTime = obj1;

    internal static object GcMomFERPGcETaZEmAbP([In] object obj0) => (object) ((AbstractCallInfo) obj0).ContextInfo;

    internal static DateTime choqwIER1Hpykk4LFvqh([In] object obj0) => ((CallContextInfo) obj0).StartTime;

    internal static TimeSpan pKBswSERNBreDdDBPPnl([In] DateTime obj0, [In] DateTime obj1) => obj0 - obj1;

    internal static void tMnkFaER3eg3UOoJM7aP([In] object obj0, [In] TimeSpan obj1) => ((TimerResult) obj0).Offset = obj1;

    internal static TimeSpan EYq6x1ERpvlRhW34Dnly([In] object obj0) => ((AbstractCallInfo) obj0).TotalTime;

    internal static void EpE93DERa6XA5KmtoqRB([In] object obj0, [In] TimeSpan obj1) => ((TimerResult) obj0).Duration = obj1;

    internal static Guid QoWBKqERDbXxWkFLsAb8([In] object obj0) => ((SqlQueryInfo) obj0).CommandId;

    internal static object krAWKUERt4F3rI4EYCL4([In] object obj0) => (object) ((SqlQueryInfo) obj0).Sql;

    internal static object t7y1cdERwPIwcmo3AaQc([In] object obj0) => (object) ((AbstractCallInfo) obj0).Exception;

    internal static Guid wjeLWTER4IgZkTP5Axj0([In] object obj0) => ((SqlQueryInfo) obj0).ConnectionId;

    internal static object tTxx5MER6jK4EVPUXBI6([In] object obj0) => (object) ((AbstractCallInfo) obj0).CallType;

    internal static object xQeIU7ERHJAmR1ko1Tpg() => (object) AdoTimelineCategory.Command;
  }
}
