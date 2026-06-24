// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.CustomBatcher
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Diagnostics;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Proxies;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.AdoNet;
using NHibernate.Engine;
using NHibernate.SqlCommand;
using NHibernate.SqlTypes;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime.NH
{
  public class CustomBatcher : IBatcher, IDisposable, ISavePointHelper
  {
    private static readonly ILogger OrgItemLog;
    private DbCommand batchCommand;
    private readonly IBatcher batcher;
    private readonly IInterceptor interceptor;
    private static IRuntimeApplication runtimeApplication;
    private static IUnitOfWorkManager unitOfWorkManager;
    private long rowsAffected;
    private static CustomBatcher gF0AaUW1wCdtw4HLRhkP;

    /// <inheritdoc />
    public Task AddToBatchAsync(IExpectation expectation, CancellationToken cancellationToken)
    {
      int num = 1;
      AsyncTaskMethodBuilder tBuilder;
      // ISSUE: variable of a compiler-generated type
      CustomBatcher.\u003CAddToBatchAsync\u003Ed__0 stateMachine;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            stateMachine.cancellationToken = cancellationToken;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 6 : 5;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = 7;
            continue;
          case 4:
            goto label_5;
          case 5:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = 3;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = AsyncTaskMethodBuilder.Create();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 5 : 5;
            continue;
          case 7:
            tBuilder.Start<CustomBatcher.\u003CAddToBatchAsync\u003Ed__0>(ref stateMachine);
            num = 4;
            continue;
          default:
            // ISSUE: reference to a compiler-generated field
            stateMachine.expectation = expectation;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 2 : 2;
            continue;
        }
      }
label_5:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <inheritdoc />
    public Task ExecuteBatchAsync(CancellationToken cancellationToken)
    {
      int num = 3;
      // ISSUE: variable of a compiler-generated type
      CustomBatcher.\u003CExecuteBatchAsync\u003Ed__1 stateMachine;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            // ISSUE: reference to a compiler-generated field
            stateMachine.cancellationToken = cancellationToken;
            num = 4;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 1 : 2;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = CustomBatcher.yuRPJTW1HNO7IJMFenE3();
            num = 6;
            continue;
          case 5:
            tBuilder.Start<CustomBatcher.\u003CExecuteBatchAsync\u003Ed__1>(ref stateMachine);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 1;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
            continue;
          default:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = 5;
            continue;
        }
      }
label_5:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <inheritdoc />
    public async Task<DbDataReader> ExecuteReaderAsync(
      DbCommand cmd,
      CancellationToken cancellationToken)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        int num3;
        DbDataReader result;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_61;
            case 1:
              goto label_62;
            case 2:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003Et__builder.SetResult(result);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
              continue;
            case 3:
              num2 = 5;
              continue;
            case 4:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              num3 = (^this).\u003C\u003E1__state;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 3 : 1;
              continue;
            case 5:
              goto label_6;
            default:
              goto label_58;
          }
        }
label_6:
        try
        {
          int num4;
          if (num3 != 0)
            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
          else
            goto label_16;
label_8:
          SqlQueryInfo sqlQueryInfo;
          DbCommand cmd1;
          while (true)
          {
            switch (num4)
            {
              case 1:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (CustomBatcher.\u003CExecuteReaderAsync\u003Ed__2.C0A6b5QmgLp6sSZjPABU(CustomBatcher.\u003CExecuteReaderAsync\u003Ed__2.DxrqQLQmlhCEM4xhIden((object) cmd1), CustomBatcher.\u003CExecuteReaderAsync\u003Ed__2.QokqxjQmrLoH8i1Vpdcv(1470440286 ^ 1470451350), StringComparison.InvariantCultureIgnoreCase))
                {
                  num4 = 5;
                  continue;
                }
                goto case 6;
              case 2:
                cmd1 = cmd;
                num4 = 3;
                continue;
              case 3:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (!CustomBatcher.\u003CExecuteReaderAsync\u003Ed__2.bkry4KQmd2BKfUrBcsYH(CustomBatcher.\u003CExecuteReaderAsync\u003Ed__2.USTdYNQm9bBydun4uOqb()))
                {
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 1 : 0;
                  continue;
                }
                goto case 6;
              case 4:
                goto label_20;
              case 5:
                DbCommand dbCommand1 = cmd1;
                // ISSUE: reference to a compiler-generated method
                object obj1 = CustomBatcher.\u003CExecuteReaderAsync\u003Ed__2.DxrqQLQmlhCEM4xhIden((object) cmd1);
                string pattern = CustomBatcher.Pattern;
                // ISSUE: reference to a compiler-generated field
                MatchEvaluator matchEvaluator1 = CustomBatcher.\u003C\u003Ec.\u003C\u003E9__2_0;
                MatchEvaluator matchEvaluator2;
                if (matchEvaluator1 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  CustomBatcher.\u003C\u003Ec.\u003C\u003E9__2_0 = matchEvaluator2 = (MatchEvaluator) (match => ((Capture) CustomBatcher.\u003C\u003Ec.bfuZQYQmPlq4jet48jRI(CustomBatcher.\u003C\u003Ec.Hboyk0Qm2lgRpkTSl9bX((object) match), CustomBatcher.\u003C\u003Ec.zb7ZT3Qmel3VOSmChtyY(-606654180 ^ -606946610))).Value + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461397575));
                }
                else
                  goto label_63;
label_19:
                // ISSUE: reference to a compiler-generated method
                object obj2 = CustomBatcher.\u003CExecuteReaderAsync\u003Ed__2.dR25CdQm5gbuEfvIiW93(obj1, (object) pattern, (object) matchEvaluator2, RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture);
                // ISSUE: reference to a compiler-generated method
                CustomBatcher.\u003CExecuteReaderAsync\u003Ed__2.oHIWFtQmjY1ftLue9nHU((object) dbCommand1, obj2);
                num4 = 6;
                continue;
label_63:
                matchEvaluator2 = matchEvaluator1;
                goto label_19;
              case 6:
                sqlQueryInfo = DiagnosticsManager.StartCall<SqlQueryInfo>((Func<SqlQueryInfo>) (() =>
                {
                  int num5 = 1;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
                        if (cmd1 != null)
                        {
                          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
                          continue;
                        }
                        goto label_6;
                      case 2:
                        goto label_6;
                      default:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        if (CustomBatcher.\u003C\u003Ec__DisplayClass2_0.FPGjF9Qmm5y2FGtXpm8B(CustomBatcher.\u003C\u003Ec__DisplayClass2_0.fAaMTwQm0dQpLkJMymF0((object) cmd1)))
                        {
                          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 2 : 0;
                          continue;
                        }
                        goto label_7;
                    }
                  }
label_6:
                  return (SqlQueryInfo) null;
label_7:
                  return new SqlQueryInfo((IDbCommand) cmd1);
                }));
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 7 : 5;
                continue;
              case 7:
                goto label_16;
              default:
                num4 = 2;
                continue;
            }
          }
label_20:
          try
          {
            int num6 = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
              num6 = 0;
            while (true)
            {
              switch (num6)
              {
                case 1:
                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
                  continue;
                default:
                  goto label_24;
              }
            }
label_24:
            try
            {
              int num7;
              if (num3 == 0)
                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 1 : 1;
              else
                goto label_35;
label_28:
              TaskAwaiter<DbDataReader> awaiter;
              while (true)
              {
                TaskAwaiter<DbDataReader> taskAwaiter;
                int num8;
                switch (num7)
                {
                  case 1:
                  case 6:
                    awaiter = taskAwaiter;
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 2 : 0;
                    continue;
                  case 2:
                    taskAwaiter = new TaskAwaiter<DbDataReader>();
                    num7 = 11;
                    continue;
                  case 3:
                    goto label_35;
                  case 4:
                    goto label_62;
                  case 5:
                  case 7:
                    result = (DbDataReader) new DataReaderProxy(awaiter.GetResult(), cmd1, sqlQueryInfo);
                    num8 = 4;
                    break;
                  case 8:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<DbDataReader>, CustomBatcher.\u003CExecuteReaderAsync\u003Ed__2>(ref awaiter, this);
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 6 : 10;
                    continue;
                  case 9:
                    if (awaiter.IsCompleted)
                    {
                      num7 = 7;
                      continue;
                    }
                    goto default;
                  case 10:
                    goto label_53;
                  case 11:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num3 = -1;
                    num8 = 5;
                    break;
                  case 12:
                    taskAwaiter = awaiter;
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 8 : 8;
                    continue;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num3 = 0;
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 8 : 12;
                    continue;
                }
                num7 = num8;
              }
label_53:
              return;
label_35:
              awaiter = this.batcher.ExecuteReaderAsync(cmd1, cancellationToken).GetAwaiter();
              num7 = 9;
              goto label_28;
            }
            catch (Exception ex)
            {
              int num9 = 3;
              while (true)
              {
                switch (num9)
                {
                  case 2:
                    goto label_45;
                  case 3:
                    if (sqlQueryInfo == null)
                    {
                      num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 1 : 1;
                      continue;
                    }
                    goto case 4;
                  case 4:
                    // ISSUE: reference to a compiler-generated method
                    CustomBatcher.\u003CExecuteReaderAsync\u003Ed__2.ILes1SQmYTW7NggEFlH1((object) sqlQueryInfo, (object) ex);
                    num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
                    continue;
                  default:
                    Exception exception = ex;
                    DbCommand dbCommand2 = cmd1;
                    // ISSUE: reference to a compiler-generated method
                    object obj3 = dbCommand2 == null ? (object) null : CustomBatcher.\u003CExecuteReaderAsync\u003Ed__2.qW6SriQmLfCLwVRdUsK6((object) dbCommand2);
                    // ISSUE: reference to a compiler-generated method
                    CustomBatcher.\u003CExecuteReaderAsync\u003Ed__2.bfrKQOQmUpdr7fF8Ub2l((object) exception, obj3);
                    num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 2 : 2;
                    continue;
                }
              }
label_45:
              throw;
            }
          }
          finally
          {
            int num10;
            if (num3 >= 0)
              num10 = 4;
            else
              goto label_50;
label_48:
            switch (num10)
            {
              case 1:
                break;
              case 2:
              case 3:
              case 4:
              default:
                goto label_50;
            }
label_49:
            // ISSUE: reference to a compiler-generated method
            CustomBatcher.\u003CExecuteReaderAsync\u003Ed__2.oUc5kjQmsGAiS0rewI1o((object) sqlQueryInfo);
            num10 = 3;
            goto label_48;
label_50:
            if (sqlQueryInfo == null)
            {
              num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 2 : 2;
              goto label_48;
            }
            else
              goto label_49;
          }
label_16:
          num4 = 4;
          goto label_8;
        }
        catch (Exception ex)
        {
          int num11 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
            num11 = 0;
          while (true)
          {
            switch (num11)
            {
              case 1:
                // ISSUE: explicit reference operation
                // ISSUE: reference to a compiler-generated field
                (^this).\u003C\u003Et__builder.SetException(ex);
                num11 = 2;
                continue;
              case 2:
                goto label_52;
              default:
                // ISSUE: explicit reference operation
                // ISSUE: reference to a compiler-generated field
                (^this).\u003C\u003E1__state = -2;
                num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 1;
                continue;
            }
          }
label_52:
          return;
        }
label_62:
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        (^this).\u003C\u003E1__state = -2;
        num1 = 2;
      }
label_61:
      return;
label_58:;
    }

    /// <inheritdoc />
    public async Task<int> ExecuteNonQueryAsync(DbCommand cmd, CancellationToken cancellationToken)
    {
      int num1 = 1;
      int result1;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
            continue;
          case 2:
label_5:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = 3;
            continue;
          case 3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 4;
            continue;
          case 4:
            goto label_57;
          case 5:
            try
            {
              int num3;
              if (num2 != 0)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 1;
              else
                goto label_9;
label_8:
              SqlQueryInfo sqlQueryInfo;
              DbCommand cmd1;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 4 : 4;
                    continue;
                  case 2:
                    goto label_13;
                  case 3:
                    sqlQueryInfo = DiagnosticsManager.StartCall<SqlQueryInfo>((Func<SqlQueryInfo>) (() =>
                    {
                      int num4 = 3;
                      while (true)
                      {
                        switch (num4)
                        {
                          case 1:
                            // ISSUE: reference to a compiler-generated method
                            // ISSUE: reference to a compiler-generated method
                            if (CustomBatcher.\u003C\u003Ec__DisplayClass3_0.Q2ac2IQyolfAk5PDZw5t(CustomBatcher.\u003C\u003Ec__DisplayClass3_0.ebUqbRQyWXMJ924ooC6s((object) cmd1)))
                            {
                              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
                              continue;
                            }
                            goto label_7;
                          case 3:
                            if (cmd1 == null)
                            {
                              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 2 : 2;
                              continue;
                            }
                            goto case 1;
                          default:
                            goto label_6;
                        }
                      }
label_6:
                      return (SqlQueryInfo) null;
label_7:
                      return new SqlQueryInfo((IDbCommand) cmd1);
                    }));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
                    continue;
                  case 4:
                    cmd1 = cmd;
                    num3 = 3;
                    continue;
                  default:
                    goto label_9;
                }
              }
label_13:
              try
              {
                int num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
                  num5 = 1;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_17;
                  }
                }
label_17:
                try
                {
                  int num6;
                  if (num2 == 0)
                    num6 = 13;
                  else
                    goto label_25;
label_20:
                  TaskAwaiter<int> taskAwaiter;
                  TaskAwaiter<int> awaiter;
                  int result2;
                  while (true)
                  {
                    switch (num6)
                    {
                      case 1:
                        sqlQueryInfo.RowsAffected = new long?(result2 <= 0 ? 0L : (long) result2);
                        num6 = 14;
                        continue;
                      case 2:
                        goto label_54;
                      case 3:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, CustomBatcher.\u003CExecuteNonQueryAsync\u003Ed__3>(ref awaiter, this);
                        num6 = 2;
                        continue;
                      case 4:
                        goto label_25;
                      case 5:
                        taskAwaiter = new TaskAwaiter<int>();
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 16 : 14;
                        continue;
                      case 6:
                        result1 = result2;
                        num6 = 10;
                        continue;
                      case 7:
                        taskAwaiter = awaiter;
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 3;
                        continue;
                      case 8:
                        result2 = awaiter.GetResult();
                        num6 = 9;
                        continue;
                      case 9:
                        if (sqlQueryInfo == null)
                        {
                          num6 = 12;
                          continue;
                        }
                        goto case 1;
                      case 10:
                        goto label_5;
                      case 11:
                        if (!awaiter.IsCompleted)
                        {
                          num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
                          continue;
                        }
                        goto case 8;
                      case 12:
                      case 14:
                        this.rowsAffected = 0L;
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 1 : 6;
                        continue;
                      case 13:
                      case 15:
                        awaiter = taskAwaiter;
                        num6 = 5;
                        continue;
                      case 16:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003E1__state = num2 = -1;
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 8 : 6;
                        continue;
                      default:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003E1__state = num2 = 0;
                        num6 = 7;
                        continue;
                    }
                  }
label_54:
                  return;
label_25:
                  awaiter = this.batcher.ExecuteNonQueryAsync(cmd1, cancellationToken).GetAwaiter();
                  num6 = 11;
                  goto label_20;
                }
                catch (Exception ex)
                {
                  int num7 = 4;
                  while (true)
                  {
                    switch (num7)
                    {
                      case 1:
                        goto label_42;
                      case 2:
                      case 3:
                        // ISSUE: reference to a compiler-generated method
                        CustomBatcher.\u003CExecuteNonQueryAsync\u003Ed__3.oYi2SSQyfVuYsCb2F7a3((object) ex, (object) cmd1?.Connection);
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 1 : 1;
                        continue;
                      case 4:
                        if (sqlQueryInfo == null)
                        {
                          num7 = 3;
                          continue;
                        }
                        break;
                    }
                    // ISSUE: reference to a compiler-generated method
                    CustomBatcher.\u003CExecuteNonQueryAsync\u003Ed__3.XJZ8kkQyEsQ3NBYj5V4O((object) sqlQueryInfo, (object) ex);
                    num7 = 2;
                  }
label_42:
                  throw;
                }
              }
              finally
              {
                int num8;
                if (num2 >= 0)
                  num8 = 2;
                else
                  goto label_46;
label_45:
                while (true)
                {
                  switch (num8)
                  {
                    case 1:
                      goto label_46;
                    case 3:
                      // ISSUE: reference to a compiler-generated method
                      CustomBatcher.\u003CExecuteNonQueryAsync\u003Ed__3.jC9KfOQyQvviVd75L2BA((object) sqlQueryInfo);
                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_50;
                  }
                }
label_46:
                if (sqlQueryInfo != null)
                {
                  num8 = 3;
                  goto label_45;
                }
label_50:;
              }
label_9:
              num3 = 2;
              goto label_8;
            }
            catch (Exception ex)
            {
              int num9 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0)
                num9 = 1;
              while (true)
              {
                switch (num9)
                {
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
                    continue;
                  case 2:
                    goto label_48;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 2 : 2;
                    continue;
                }
              }
label_48:
              return;
            }
          default:
            num1 = 5;
            continue;
        }
      }
label_57:;
    }

    /// <inheritdoc />
    public async Task<DbCommand> PrepareCommandAsync(
      CommandType commandType,
      SqlString sql,
      SqlType[] parameterTypes,
      CancellationToken cancellationToken)
    {
      int num1 = 5;
      int num2;
      DbCommand result;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result);
            num1 = 2;
            continue;
          case 2:
            goto label_55;
          case 3:
label_58:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 1 : 0;
            continue;
          case 4:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
            continue;
          case 5:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 4 : 4;
            continue;
          default:
            try
            {
              int num3;
              if (num2 == 0)
                num3 = 2;
              else
                goto label_7;
label_6:
              SqlQueryInfo sqlQueryInfo;
              string sqlString;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                  case 2:
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 3 : 1;
                    continue;
                  case 3:
                    goto label_11;
                  case 4:
                    sqlQueryInfo = DiagnosticsManager.StartCall<SqlQueryInfo>((Func<SqlQueryInfo>) (() =>
                    {
                      int num4 = 1;
                      while (true)
                      {
                        switch (num4)
                        {
                          case 1:
                            // ISSUE: reference to a compiler-generated method
                            if (CustomBatcher.\u003C\u003Ec__DisplayClass4_0.N0YAXKQyZnwNwJK8KsL8((object) sqlString))
                            {
                              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
                              continue;
                            }
                            goto label_5;
                          default:
                            goto label_4;
                        }
                      }
label_4:
                      return (SqlQueryInfo) null;
label_5:
                      SqlQueryInfo sqlQueryInfo1 = new SqlQueryInfo();
                      // ISSUE: reference to a compiler-generated method
                      CustomBatcher.\u003C\u003Ec__DisplayClass4_0.I9RSEXQyuv3juio6v98O((object) sqlQueryInfo1, (object) sqlString);
                      // ISSUE: reference to a compiler-generated method
                      CustomBatcher.\u003C\u003Ec__DisplayClass4_0.ebTtOYQyIhi8OXqdTXBO((object) sqlQueryInfo1, true);
                      return sqlQueryInfo1;
                    }));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 1 : 1;
                    continue;
                  case 5:
                    sqlString = sql.ToString();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 4;
                    continue;
                  default:
                    goto label_7;
                }
              }
label_11:
              try
              {
                int num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
                  num5 = 1;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_15;
                  }
                }
label_15:
                try
                {
                  int num6;
                  if (num2 == 0)
                    num6 = 9;
                  else
                    goto label_29;
label_18:
                  TaskAwaiter<DbCommand> taskAwaiter;
                  TaskAwaiter<DbCommand> awaiter;
                  DbCommand command;
                  while (true)
                  {
                    switch (num6)
                    {
                      case 1:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003E1__state = num2 = 0;
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 13 : 0;
                        continue;
                      case 2:
                      case 9:
                        awaiter = taskAwaiter;
                        num6 = 10;
                        continue;
                      case 3:
                        goto label_29;
                      case 4:
                        goto label_58;
                      case 5:
                      case 7:
                        command = CustomBatcher.SetCommandTimeout((object) awaiter.GetResult());
                        num6 = 11;
                        continue;
                      case 6:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<DbCommand>, CustomBatcher.\u003CPrepareCommandAsync\u003Ed__4>(ref awaiter, this);
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 14 : 15;
                        continue;
                      case 8:
                        if (awaiter.IsCompleted)
                        {
                          num6 = 5;
                          continue;
                        }
                        goto case 1;
                      case 10:
                        taskAwaiter = new TaskAwaiter<DbCommand>();
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
                        continue;
                      case 11:
                        SqlQueryInfo sqlQueryInfo2 = sqlQueryInfo;
                        if (sqlQueryInfo2 == null)
                        {
                          num6 = 14;
                          continue;
                        }
                        sqlQueryInfo2.SetDbCommand((IDbCommand) command);
                        num6 = 12;
                        continue;
                      case 12:
                      case 14:
                        result = command;
                        num6 = 4;
                        continue;
                      case 13:
                        taskAwaiter = awaiter;
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 6 : 1;
                        continue;
                      case 15:
                        goto label_52;
                      default:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003E1__state = num2 = -1;
                        num6 = 7;
                        continue;
                    }
                  }
label_52:
                  return;
label_29:
                  awaiter = this.batcher.PrepareCommandAsync(commandType, sql, parameterTypes, cancellationToken).GetAwaiter();
                  num6 = 8;
                  goto label_18;
                }
                catch (Exception ex)
                {
                  int num7 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
                    num7 = 0;
                  while (true)
                  {
                    switch (num7)
                    {
                      case 1:
                        goto label_39;
                      case 2:
                        // ISSUE: reference to a compiler-generated method
                        CustomBatcher.\u003CPrepareCommandAsync\u003Ed__4.cnEyAdQyRochE2d8qXOk((object) sqlQueryInfo, (object) ex);
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 1 : 1;
                        continue;
                      default:
                        if (sqlQueryInfo != null)
                        {
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 2;
                          continue;
                        }
                        goto label_39;
                    }
                  }
label_39:
                  throw;
                }
              }
              finally
              {
                if (num2 < 0)
                {
                  int num8 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
                    num8 = 1;
                  while (true)
                  {
                    switch (num8)
                    {
                      case 1:
                        if (sqlQueryInfo != null)
                        {
                          num8 = 2;
                          continue;
                        }
                        goto label_48;
                      case 2:
                        // ISSUE: reference to a compiler-generated method
                        CustomBatcher.\u003CPrepareCommandAsync\u003Ed__4.nyLfMSQyqlNsTbv8O52R((object) sqlQueryInfo);
                        num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_48;
                    }
                  }
                }
label_48:;
              }
label_7:
              num3 = 5;
              goto label_6;
            }
            catch (Exception ex)
            {
              int num9 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
                num9 = 0;
              while (true)
              {
                switch (num9)
                {
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
                    continue;
                  case 2:
                    goto label_44;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 1 : 2;
                    continue;
                }
              }
label_44:
              return;
            }
        }
      }
label_55:;
    }

    /// <inheritdoc />
    public async Task<DbCommand> PrepareBatchCommandAsync(
      CommandType commandType,
      SqlString sql,
      SqlType[] parameterTypes,
      CancellationToken cancellationToken)
    {
      int num1 = 5;
      int num2;
      DbCommand batchCommand;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_61;
          case 1:
            try
            {
              int num3;
              if (num2 == 0)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
              else
                goto label_12;
label_8:
              SqlQueryInfo sqlQueryInfo;
              string sqlString;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    goto label_14;
                  case 2:
                    goto label_12;
                  case 3:
                    sqlQueryInfo = DiagnosticsManager.StartCall<SqlQueryInfo>((Func<SqlQueryInfo>) (() =>
                    {
                      int num4 = 1;
                      while (true)
                      {
                        switch (num4)
                        {
                          case 1:
                            // ISSUE: reference to a compiler-generated method
                            if (!CustomBatcher.\u003C\u003Ec__DisplayClass5_0.EWuyLqQynVJ69I2S6nL0((object) sqlString))
                            {
                              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
                              continue;
                            }
                            goto label_2;
                          case 2:
                            goto label_2;
                          default:
                            goto label_3;
                        }
                      }
label_2:
                      return (SqlQueryInfo) null;
label_3:
                      SqlQueryInfo sqlQueryInfo1 = new SqlQueryInfo();
                      // ISSUE: reference to a compiler-generated method
                      CustomBatcher.\u003C\u003Ec__DisplayClass5_0.hmHrR8QyOlfZO269Vxx2((object) sqlQueryInfo1, (object) sqlString);
                      // ISSUE: reference to a compiler-generated method
                      CustomBatcher.\u003C\u003Ec__DisplayClass5_0.bNIOPxQy2mMnoqY0IaXS((object) sqlQueryInfo1, true);
                      return sqlQueryInfo1;
                    }));
                    num3 = 5;
                    continue;
                  case 4:
                    sqlString = sql.ToString();
                    num3 = 3;
                    continue;
                  default:
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 1;
                    continue;
                }
              }
label_14:
              try
              {
                int num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
                  num5 = 0;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      goto label_18;
                    default:
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 1;
                      continue;
                  }
                }
label_18:
                try
                {
                  int num6;
                  if (num2 != 0)
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 10 : 10;
                  else
                    goto label_32;
label_21:
                  TaskAwaiter<DbCommand> taskAwaiter;
                  TaskAwaiter<DbCommand> awaiter;
                  while (true)
                  {
                    int num7;
                    DbCommand result;
                    switch (num6)
                    {
                      case 1:
                        if (awaiter.IsCompleted)
                        {
                          num6 = 13;
                          continue;
                        }
                        goto case 2;
                      case 2:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003E1__state = num2 = 0;
                        num7 = 8;
                        break;
                      case 3:
                        taskAwaiter = new TaskAwaiter<DbCommand>();
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 7 : 3;
                        continue;
                      case 4:
                      case 9:
                        batchCommand = this.batchCommand;
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
                        continue;
                      case 5:
                        // ISSUE: reference to a compiler-generated method
                        this.batchCommand = (DbCommand) CustomBatcher.\u003CPrepareBatchCommandAsync\u003Ed__5.FR14OWQyNtQ5MaNpDSeQ((object) result);
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 6 : 6;
                        continue;
                      case 6:
                        SqlQueryInfo sqlQueryInfo2 = sqlQueryInfo;
                        if (sqlQueryInfo2 == null)
                        {
                          num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 4 : 4;
                          continue;
                        }
                        sqlQueryInfo2.SetDbCommand((IDbCommand) this.batchCommand);
                        num7 = 9;
                        break;
                      case 7:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003E1__state = num2 = -1;
                        num6 = 14;
                        continue;
                      case 8:
                        taskAwaiter = awaiter;
                        num6 = 11;
                        continue;
                      case 10:
                        awaiter = this.batcher.PrepareBatchCommandAsync(commandType, sql, parameterTypes, cancellationToken).GetAwaiter();
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 1 : 1;
                        continue;
                      case 11:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<DbCommand>, CustomBatcher.\u003CPrepareBatchCommandAsync\u003Ed__5>(ref awaiter, this);
                        num6 = 15;
                        continue;
                      case 12:
                        goto label_32;
                      case 13:
                      case 14:
                        result = awaiter.GetResult();
                        num7 = 5;
                        break;
                      case 15:
                        goto label_51;
                      default:
                        goto label_2;
                    }
                    num6 = num7;
                  }
label_51:
                  return;
label_32:
                  awaiter = taskAwaiter;
                  num6 = 2;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
                  {
                    num6 = 3;
                    goto label_21;
                  }
                  else
                    goto label_21;
                }
                catch (Exception ex)
                {
                  int num8 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0)
                    num8 = 0;
                  while (true)
                  {
                    switch (num8)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        CustomBatcher.\u003CPrepareBatchCommandAsync\u003Ed__5.zpJwEHQy3Jw8woW2nveu((object) sqlQueryInfo, (object) ex);
                        num8 = 3;
                        continue;
                      case 2:
                      case 3:
                        goto label_45;
                      default:
                        if (sqlQueryInfo == null)
                        {
                          num8 = 2;
                          continue;
                        }
                        goto case 1;
                    }
                  }
label_45:
                  throw;
                }
              }
              finally
              {
                if (num2 < 0)
                {
                  int num9 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
                    num9 = 0;
                  while (true)
                  {
                    switch (num9)
                    {
                      case 1:
                        if (sqlQueryInfo == null)
                        {
                          num9 = 3;
                          continue;
                        }
                        break;
                      case 2:
                      case 3:
                        goto label_55;
                    }
                    sqlQueryInfo.Dispose();
                    num9 = 2;
                  }
                }
label_55:;
              }
label_12:
              num3 = 2;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
              {
                num3 = 4;
                goto label_8;
              }
              else
                goto label_8;
            }
            catch (Exception ex)
            {
              int num10 = 2;
              while (true)
              {
                switch (num10)
                {
                  case 0:
                    goto label_50;
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
                    continue;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 1;
                    continue;
                  default:
                    goto label_43;
                }
              }
label_50:
              return;
label_43:
              return;
            }
          case 2:
label_2:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 3;
            continue;
          case 3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(batchCommand);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
            continue;
          case 4:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 1 : 1;
            continue;
          case 5:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = 4;
            continue;
          default:
            goto label_58;
        }
      }
label_61:
      return;
label_58:;
    }

    public bool SavePoint(string key, IDbCommand dBCommand) => CustomBatcher.ne4CSkW1AGC36NPpOMFo((object) key, (object) dBCommand);

    public void ReleaseSavePoint(string key, IDbCommand dBCommand)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            CustomBatcher.wX9onmW17SOVlyJyKJM2((object) key, (object) dBCommand);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public void RollBackSavePoint(string key, IDbCommand dBCommand)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            CustomBatcher.ef5agyW1xqGEbMT7DIsF((object) key, (object) dBCommand);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public CustomBatcher(IBatcher batcher, IInterceptor interceptor)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.interceptor = interceptor;
            num = 2;
            continue;
          case 2:
            goto label_3;
          default:
            this.batcher = batcher;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public void AbortBatch(Exception e)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            CustomBatcher.OgO6sSW10vZglgu08kpH((object) this.batcher, (object) e);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public void AddToBatch(IExpectation expectation)
    {
      switch (1)
      {
        case 1:
          try
          {
            int num;
            if (expectation.CanBeBatched)
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 1 : 1;
            else
              goto label_6;
label_3:
            while (true)
            {
              switch (num)
              {
                case 1:
                  this.rowsAffected += (long) CustomBatcher.r3Rm7gW1mXyo37JPrcso((object) expectation);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
                  continue;
                case 2:
                  goto label_4;
                default:
                  goto label_6;
              }
            }
label_4:
            break;
label_6:
            CustomBatcher.k0FyL0W1yNSbpn3FjfkQ((object) this.batcher, (object) expectation);
            num = 2;
            goto label_3;
          }
          catch (Exception ex)
          {
            CustomBatcher.ProcessException((object) ex);
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
              num = 0;
            switch (num)
            {
              default:
                throw;
            }
          }
      }
    }

    public int BatchSize
    {
      get => CustomBatcher.QHTnZHW1MnaS9dlLAJGG((object) this.batcher);
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              CustomBatcher.Cro4GgW1JqTQiYOBAh2t((object) this.batcher, value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public void CancelLastQuery()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            CustomBatcher.DuXHPgW19pQxv22rGMnl((object) this.batcher);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public void CloseCommand(DbCommand cmd, DbDataReader reader)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            CustomBatcher.btKj1FW1d8NyW0RiBXDj((object) this.batcher, (object) cmd, (object) reader);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public void CloseCommands()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            CustomBatcher.mY0Sn2W1lHZFUvQCb3Zt((object) this.batcher);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public void CloseReader(DbDataReader reader)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            CustomBatcher.xCnfUNW1rU53fBExuPfC((object) this.batcher, (object) reader);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public void ExecuteBatch()
    {
      int num1 = 2;
      SqlQueryInfo sqlQueryInfo;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_35;
          case 1:
            goto label_3;
          case 2:
            sqlQueryInfo = DiagnosticsManager.StartCall<SqlQueryInfo>((Func<SqlQueryInfo>) (() =>
            {
              int num2 = 2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                  case 3:
                    goto label_2;
                  case 2:
                    if (this.batchCommand == null)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 1 : 1;
                      continue;
                    }
                    break;
                }
                if (CustomBatcher.VPCk0fW1jRw6rUG7QDoY(CustomBatcher.uAX3wOW15YsylCp716uU((object) this.batchCommand)))
                  num2 = 3;
                else
                  goto label_3;
              }
label_2:
              return (SqlQueryInfo) null;
label_3:
              return new SqlQueryInfo((IDbCommand) this.batchCommand);
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 1;
            continue;
          default:
            goto label_25;
        }
      }
label_35:
      return;
label_25:
      return;
label_3:
      try
      {
        int num3;
        if (!CustomBatcher.mL01r7W1gSXb36nBslmN((object) CustomBatcher.OrgItemLog, EleWise.ELMA.Logging.LogLevel.Debug))
          num3 = 5;
        else
          goto label_9;
label_5:
        int num4 = num3;
label_6:
        while (true)
        {
          switch (num4)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              CustomBatcher.jLpyPnW1cTnn1bQkyhar((object) CustomBatcher.OrgItemLog, CustomBatcher.GZlvLFW1sguHo2bkygEF((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638537387), (object) this.batchCommand.CommandText, (object) string.Concat(((IEnumerable) CustomBatcher.yR6AqkW1U71LhmrXZpGm((object) this.batchCommand)).Cast<IDataParameter>().Select<IDataParameter, string>((System.Func<IDataParameter, string>) (p => (string) CustomBatcher.\u003C\u003Ec.DEna1hQmOQJwOjl82KR8((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979680774), CustomBatcher.\u003C\u003Ec.TTZpVSQmkT49smaTYRtp((object) p), CustomBatcher.\u003C\u003Ec.WY7HjQQmnrAV1qDeVyGj((object) p))))), (object) Environment.StackTrace));
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 7 : 7;
              continue;
            case 2:
            case 5:
            case 7:
            case 8:
              goto label_13;
            case 3:
              if (!CustomBatcher.QCRO9WW1LpKDrc8dA52J((object) this.batchCommand.CommandText, CustomBatcher.EFZE9UW1YprMiZQoJKub(516838154 ^ 516702744), StringComparison.InvariantCultureIgnoreCase))
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 8 : 0;
                continue;
              }
              goto case 1;
            case 4:
              goto label_9;
            case 6:
              goto label_15;
            default:
              goto label_11;
          }
        }
label_15:
        try
        {
          CustomBatcher.I1OAVbW1zNaGBGksfgFP((object) this.batcher);
          int num5 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0)
            num5 = 1;
          while (true)
          {
            switch (num5)
            {
              case 1:
                if (sqlQueryInfo == null)
                {
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 3 : 2;
                  continue;
                }
                goto case 4;
              case 2:
                goto label_24;
              case 4:
                sqlQueryInfo.RowsAffected = new long?(this.rowsAffected <= 0L ? 0L : this.rowsAffected);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
                continue;
              default:
                this.rowsAffected = 0L;
                num5 = 2;
                continue;
            }
          }
label_24:
          return;
        }
        catch (Exception ex)
        {
          int num6 = 3;
          while (true)
          {
            switch (num6)
            {
              case 1:
                CustomBatcher.lXmSvkWNFvPuHY8knMGQ((object) sqlQueryInfo, (object) ex);
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 2 : 2;
                continue;
              case 3:
                if (sqlQueryInfo == null)
                {
                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
                  continue;
                }
                goto case 1;
              case 4:
                goto label_30;
              default:
                CustomBatcher.ProcessException((object) ex);
                num6 = 4;
                continue;
            }
          }
label_30:
          throw;
        }
label_9:
        if (this.batchCommand == null)
        {
          num4 = 2;
          goto label_6;
        }
label_11:
        if (!CustomBatcher.VPCk0fW1jRw6rUG7QDoY(CustomBatcher.uAX3wOW15YsylCp716uU((object) this.batchCommand)))
        {
          num3 = 3;
          goto label_5;
        }
label_13:
        num4 = 6;
        goto label_6;
      }
      finally
      {
        if (sqlQueryInfo != null)
        {
          int num7 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
            num7 = 0;
          while (true)
          {
            switch (num7)
            {
              case 1:
                goto label_37;
              default:
                sqlQueryInfo.Dispose();
                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 1;
                continue;
            }
          }
        }
label_37:;
      }
    }

    public int ExecuteNonQuery(DbCommand cmd)
    {
      int num1 = 4;
      SqlQueryInfo sqlQueryInfo;
      DbCommand cmd1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            sqlQueryInfo = DiagnosticsManager.StartCall<SqlQueryInfo>((Func<SqlQueryInfo>) (() =>
            {
              int num2 = 2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    if (string.IsNullOrEmpty((string) CustomBatcher.\u003C\u003Ec__DisplayClass21_0.GGIA9tQywvbpp0Efu6lK((object) cmd1)))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_7;
                  case 2:
                    if (cmd1 != null)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 1 : 1;
                      continue;
                    }
                    goto label_6;
                  default:
                    goto label_6;
                }
              }
label_6:
              return (SqlQueryInfo) null;
label_7:
              return new SqlQueryInfo((IDbCommand) cmd1);
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          case 3:
            cmd1 = cmd;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 1 : 0;
            continue;
          case 4:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 3 : 3;
            continue;
          default:
            goto label_5;
        }
      }
label_4:
      int num3;
      return num3;
label_5:
      try
      {
        int num4 = CustomBatcher.HHWCSsWNBq4Z41XejoYc((object) this.batcher, (object) cmd1);
        int num5 = 5;
        while (true)
        {
          int num6;
          switch (num5)
          {
            case 1:
              sqlQueryInfo.RowsAffected = new long?(num4 > 0 ? (long) num4 : 0L);
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 3 : 3;
              continue;
            case 2:
              goto label_4;
            case 3:
            case 4:
              this.rowsAffected = 0L;
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
              continue;
            case 5:
              if (sqlQueryInfo == null)
              {
                num6 = 4;
                break;
              }
              goto case 1;
            default:
              num3 = num4;
              num6 = 2;
              break;
          }
          num5 = num6;
        }
      }
      catch (Exception ex)
      {
        int num7 = 3;
        while (true)
        {
          switch (num7)
          {
            case 1:
              CustomBatcher.lXmSvkWNFvPuHY8knMGQ((object) sqlQueryInfo, (object) ex);
              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 2 : 1;
              continue;
            case 2:
              CustomBatcher.RQJKdtWNWEk6GnKUFlFj((object) ex, cmd1 != null ? (object) cmd1.Connection : (object) (DbConnection) null);
              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
              continue;
            case 3:
              if (sqlQueryInfo != null)
              {
                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 1;
                continue;
              }
              goto case 2;
            default:
              goto label_20;
          }
        }
label_20:
        throw;
      }
      finally
      {
        if (sqlQueryInfo != null)
        {
          int num8 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
            num8 = 0;
          while (true)
          {
            switch (num8)
            {
              case 1:
                CustomBatcher.y182loWNoTJHc01K5jT8((object) sqlQueryInfo);
                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
                continue;
              default:
                goto label_26;
            }
          }
        }
label_26:;
      }
    }

    private static string Pattern
    {
      get
      {
        int num = 4;
        string str1;
        while (true)
        {
          string str2;
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              if (!CustomBatcher.zhjcKUWNbSfH3Ue9QoZx((object) str1))
              {
                if (!CustomBatcher.v3lDhIWNhfXPg6tjWOnX((object) str1, CustomBatcher.EFZE9UW1YprMiZQoJKub(-1120607109 - 305487170 ^ -1426221405)))
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
                  continue;
                }
                goto label_8;
              }
              else
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 1 : 1;
                continue;
              }
            case 3:
              str2 = "";
              break;
            case 4:
              string setting = EleWise.ELMA.SR.GetSetting((string) CustomBatcher.EFZE9UW1YprMiZQoJKub(1917256330 ^ 1917129684));
              if (setting == null)
              {
                num = 3;
                continue;
              }
              str2 = setting;
              break;
            default:
              goto label_7;
          }
          str1 = str2;
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 2;
        }
label_2:
        return "";
label_7:
        return "";
label_8:
        return (string) CustomBatcher.WUoMJAWNGRud8UrvvGGM(CustomBatcher.EFZE9UW1YprMiZQoJKub(-1487388570 ^ -1487253074), (object) str1);
      }
    }

    public DbDataReader ExecuteReader(DbCommand cmd)
    {
      int num1 = 2;
      SqlQueryInfo queryInfo;
      DbCommand cmd1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            cmd1 = cmd;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 2 : 3;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 1;
            continue;
          case 3:
            if (!CustomBatcher.zhjcKUWNbSfH3Ue9QoZx(CustomBatcher.t29KUIWNERunP3XbGctj()))
            {
              num1 = 6;
              continue;
            }
            goto case 4;
          case 4:
            queryInfo = DiagnosticsManager.StartCall<SqlQueryInfo>((Func<SqlQueryInfo>) (() =>
            {
              int num2 = 2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    if (CustomBatcher.\u003C\u003Ec__DisplayClass24_0.jMqV9FQy7K9ixljpDBkS((object) cmd1.CommandText))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_7;
                  case 2:
                    if (cmd1 != null)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 1;
                      continue;
                    }
                    goto label_6;
                  default:
                    goto label_6;
                }
              }
label_6:
              return (SqlQueryInfo) null;
label_7:
              return new SqlQueryInfo((IDbCommand) cmd1);
            }));
            num1 = 7;
            continue;
          case 5:
            DbCommand dbCommand = cmd1;
            object obj1 = CustomBatcher.uAX3wOW15YsylCp716uU((object) cmd1);
            object obj2 = CustomBatcher.t29KUIWNERunP3XbGctj();
            // ISSUE: reference to a compiler-generated field
            MatchEvaluator matchEvaluator1 = CustomBatcher.\u003C\u003Ec.\u003C\u003E9__24_0;
            MatchEvaluator matchEvaluator2;
            if (matchEvaluator1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              CustomBatcher.\u003C\u003Ec.\u003C\u003E9__24_0 = matchEvaluator2 = (MatchEvaluator) (match => ((Capture) CustomBatcher.\u003C\u003Ec.bfuZQYQmPlq4jet48jRI(CustomBatcher.\u003C\u003Ec.Hboyk0Qm2lgRpkTSl9bX((object) match), CustomBatcher.\u003C\u003Ec.zb7ZT3Qmel3VOSmChtyY(-1998538950 ^ -1998242584))).Value + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1505778440 - 1981636111 ^ -475564249));
            }
            else
              goto label_26;
label_25:
            object obj3 = CustomBatcher.qw2C0yWNf6kXvx9avGIu(obj1, obj2, (object) matchEvaluator2, RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture);
            CustomBatcher.D4YxZ0WNQR4rarh3ZMbo((object) dbCommand, obj3);
            num1 = 4;
            continue;
label_26:
            matchEvaluator2 = matchEvaluator1;
            goto label_25;
          case 6:
            if (CustomBatcher.QCRO9WW1LpKDrc8dA52J(CustomBatcher.uAX3wOW15YsylCp716uU((object) cmd1), CustomBatcher.EFZE9UW1YprMiZQoJKub(1051276242 - 990076387 ^ 61192231), StringComparison.InvariantCultureIgnoreCase))
            {
              num1 = 5;
              continue;
            }
            goto case 4;
          case 7:
            goto label_2;
          default:
            goto label_17;
        }
      }
label_2:
      DbDataReader dbDataReader;
      try
      {
        dbDataReader = (DbDataReader) new DataReaderProxy((DbDataReader) CustomBatcher.TlqeCFWNCKo5a5wbFqbK((object) this.batcher, (object) cmd1), cmd1, queryInfo);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
          num3 = 0;
        switch (num3)
        {
        }
      }
      catch (Exception ex)
      {
        int num4 = 4;
        while (true)
        {
          switch (num4)
          {
            case 1:
              CustomBatcher.lXmSvkWNFvPuHY8knMGQ((object) queryInfo, (object) ex);
              num4 = 7;
              continue;
            case 2:
              if (queryInfo == null)
              {
                num4 = 3;
                continue;
              }
              goto case 5;
            case 4:
              if (queryInfo == null)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 6 : 5;
                continue;
              }
              goto case 1;
            case 5:
              // ISSUE: explicit non-virtual call
              __nonvirtual (queryInfo.Dispose());
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
              continue;
            case 6:
            case 7:
              CustomBatcher.RQJKdtWNWEk6GnKUFlFj((object) ex, cmd1 == null ? (object) null : CustomBatcher.LZfVOvWNvIWY8YgTagCG((object) cmd1));
              num4 = 2;
              continue;
            default:
              goto label_14;
          }
        }
label_14:
        throw;
      }
label_17:
      return dbDataReader;
    }

    public bool HasOpenResources => CustomBatcher.zn2gtwWN8LXLAvIu2SGE((object) this.batcher);

    /// <summary>
    /// Установить максимальное время выполнения запросов для текущего контекста
    /// </summary>
    /// <param name="timeout">Время в секундах</param>
    /// <returns>Предыдущее значение времени</returns>
    public static int? SetCurrentContextTimeout(int? timeout) => (Locator.Initialized ? Locator.GetService<IRuntimeApplication>() : (IRuntimeApplication) null)?.SetCurrentContextTimeout(timeout);

    public DbCommand PrepareBatchCommand(
      CommandType commandType,
      SqlString sql,
      SqlType[] parameterTypes)
    {
      int num1 = 1;
      SqlQueryInfo sqlQueryInfo1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            string sqlString = sql.ToString();
            sqlQueryInfo1 = DiagnosticsManager.StartCall<SqlQueryInfo>((Func<SqlQueryInfo>) (() =>
            {
              int num2 = 2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_5;
                  case 2:
                    if (!string.IsNullOrEmpty(sqlString))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 1 : 0;
                      continue;
                    }
                    goto label_4;
                  default:
                    goto label_4;
                }
              }
label_4:
              return (SqlQueryInfo) null;
label_5:
              SqlQueryInfo sqlQueryInfo2 = new SqlQueryInfo();
              sqlQueryInfo2.Sql = sqlString;
              // ISSUE: reference to a compiler-generated method
              CustomBatcher.\u003C\u003Ec__DisplayClass28_0.MHvdB4QyMxp47neZYBiP((object) sqlQueryInfo2, true);
              return sqlQueryInfo2;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_24;
          default:
            goto label_3;
        }
      }
label_3:
      DbCommand batchCommand;
      try
      {
        this.batchCommand = (DbCommand) CustomBatcher.FGr1S5WNu6TyFmTApfr5(CustomBatcher.hM0c3HWNZPhGctwvfPeE((object) this.batcher, commandType, (object) sql, (object) parameterTypes));
        int num3 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
          num3 = 4;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_24;
            case 2:
              sqlQueryInfo1.SetDbCommand((IDbCommand) this.batchCommand);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 3 : 2;
              continue;
            case 4:
              if (sqlQueryInfo1 == null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
                continue;
              }
              goto case 2;
            default:
              batchCommand = this.batchCommand;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 1 : 1;
              continue;
          }
        }
      }
      catch (Exception ex)
      {
        int num4 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
          num4 = 1;
        while (true)
        {
          switch (num4)
          {
            case 1:
              if (sqlQueryInfo1 != null)
              {
                num4 = 2;
                continue;
              }
              goto label_17;
            case 2:
              CustomBatcher.lXmSvkWNFvPuHY8knMGQ((object) sqlQueryInfo1, (object) ex);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
              continue;
            default:
              goto label_17;
          }
        }
label_17:
        throw;
      }
      finally
      {
        if (sqlQueryInfo1 != null)
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
            num5 = 0;
          while (true)
          {
            switch (num5)
            {
              case 1:
                goto label_23;
              default:
                CustomBatcher.y182loWNoTJHc01K5jT8((object) sqlQueryInfo1);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 1;
                continue;
            }
          }
        }
label_23:;
      }
label_24:
      return batchCommand;
    }

    public DbCommand PrepareCommand(
      CommandType commandType,
      SqlString sql,
      SqlType[] parameterTypes)
    {
      int num1 = 2;
      SqlQueryInfo sqlQueryInfo1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_4;
          case 2:
            string sqlString = sql.ToString();
            sqlQueryInfo1 = DiagnosticsManager.StartCall<SqlQueryInfo>((Func<SqlQueryInfo>) (() =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    if (!string.IsNullOrEmpty(sqlString))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
                      continue;
                    }
                    goto label_4;
                  case 2:
                    goto label_4;
                  default:
                    goto label_5;
                }
              }
label_4:
              return (SqlQueryInfo) null;
label_5:
              SqlQueryInfo sqlQueryInfo2 = new SqlQueryInfo();
              // ISSUE: reference to a compiler-generated method
              CustomBatcher.\u003C\u003Ec__DisplayClass29_0.TyhcVHQyrKhniAmWy2x7((object) sqlQueryInfo2, (object) sqlString);
              // ISSUE: reference to a compiler-generated method
              CustomBatcher.\u003C\u003Ec__DisplayClass29_0.sF3WNPQygRXefyexcj0M((object) sqlQueryInfo2, true);
              return sqlQueryInfo2;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      DbCommand dbCommand;
      return dbCommand;
label_4:
      try
      {
        DbCommand command = (DbCommand) CustomBatcher.FGr1S5WNu6TyFmTApfr5(CustomBatcher.iIK4XHWNI1aWnRF8j2rx((object) this.batcher, commandType, (object) sql, (object) parameterTypes));
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              sqlQueryInfo1.SetDbCommand((IDbCommand) command);
              num3 = 3;
              continue;
            case 2:
              goto label_3;
            case 3:
              dbCommand = command;
              num3 = 2;
              continue;
            default:
              if (sqlQueryInfo1 != null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 1 : 1;
                continue;
              }
              goto case 3;
          }
        }
      }
      catch (Exception ex)
      {
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
          num4 = 0;
        while (true)
        {
          switch (num4)
          {
            case 1:
              sqlQueryInfo1.Exception = ex;
              num4 = 2;
              continue;
            case 2:
              goto label_17;
            default:
              if (sqlQueryInfo1 != null)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 1;
                continue;
              }
              goto label_17;
          }
        }
label_17:
        throw;
      }
      finally
      {
        int num5;
        if (sqlQueryInfo1 == null)
          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 1 : 1;
        else
          goto label_21;
label_20:
        switch (num5)
        {
          case 1:
          case 2:
        }
label_21:
        CustomBatcher.y182loWNoTJHc01K5jT8((object) sqlQueryInfo1);
        num5 = 2;
        goto label_20;
      }
    }

    public DbCommand PrepareQueryCommand(
      CommandType commandType,
      SqlString sql,
      SqlType[] parameterTypes)
    {
      int num1 = 1;
      SqlQueryInfo sqlQueryInfo1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            string sqlString = sql.ToString();
            sqlQueryInfo1 = DiagnosticsManager.StartCall<SqlQueryInfo>((Func<SqlQueryInfo>) (() =>
            {
              int num2 = 2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_5;
                  case 2:
                    // ISSUE: reference to a compiler-generated method
                    if (!CustomBatcher.\u003C\u003Ec__DisplayClass30_0.fHngVeQyUa4etR9ZEsEq((object) sqlString))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 1 : 0;
                      continue;
                    }
                    goto label_4;
                  default:
                    goto label_4;
                }
              }
label_4:
              return (SqlQueryInfo) null;
label_5:
              SqlQueryInfo sqlQueryInfo2 = new SqlQueryInfo();
              sqlQueryInfo2.Sql = sqlString;
              // ISSUE: reference to a compiler-generated method
              CustomBatcher.\u003C\u003Ec__DisplayClass30_0.gLFdwOQysglBlY4Pk9VD((object) sqlQueryInfo2, true);
              return sqlQueryInfo2;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_25;
          default:
            goto label_2;
        }
      }
label_2:
      DbCommand dbCommand;
      try
      {
        DbCommand command = (DbCommand) CustomBatcher.FGr1S5WNu6TyFmTApfr5(CustomBatcher.PNw5ytWNVD1Afvaupbs3((object) this.batcher, commandType, (object) sql, (object) parameterTypes));
        int num3 = 3;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
          num3 = 2;
        while (true)
        {
          switch (num3)
          {
            case 1:
              sqlQueryInfo1.SetDbCommand((IDbCommand) command);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
              continue;
            case 2:
              if (sqlQueryInfo1 != null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 1 : 1;
                continue;
              }
              break;
            case 3:
              if (command != null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 2 : 1;
                continue;
              }
              break;
            case 4:
              goto label_25;
          }
          dbCommand = command;
          num3 = 4;
        }
      }
      catch (Exception ex)
      {
        int num4 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
          num4 = 2;
        while (true)
        {
          switch (num4)
          {
            case 1:
              goto label_18;
            case 2:
              if (sqlQueryInfo1 != null)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
                continue;
              }
              goto label_18;
            default:
              CustomBatcher.lXmSvkWNFvPuHY8knMGQ((object) sqlQueryInfo1, (object) ex);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 1 : 0;
              continue;
          }
        }
label_18:
        throw;
      }
      finally
      {
        int num5;
        if (sqlQueryInfo1 == null)
          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 1 : 1;
        else
          goto label_22;
label_21:
        switch (num5)
        {
          case 2:
            break;
          default:
        }
label_22:
        CustomBatcher.y182loWNoTJHc01K5jT8((object) sqlQueryInfo1);
        num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
        {
          num5 = 0;
          goto label_21;
        }
        else
          goto label_21;
      }
label_25:
      return dbCommand;
    }

    public void Dispose()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            CustomBatcher.y182loWNoTJHc01K5jT8((object) this.batcher);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private static DbCommand SetCommandTimeout(object command)
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        int? commandTimeout;
        while (true)
        {
          IRuntimeApplication runtimeApplication1;
          switch (num2)
          {
            case 1:
              runtimeApplication1 = (IRuntimeApplication) null;
              break;
            case 3:
              if (!commandTimeout.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            case 4:
              goto label_3;
            case 5:
              goto label_7;
            case 6:
              if (CustomBatcher.runtimeApplication == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 5 : 5;
                continue;
              }
              commandTimeout = CustomBatcher.runtimeApplication.GetCommandTimeout();
              num2 = 3;
              continue;
            case 7:
              if (!Locator.Initialized)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 1;
                continue;
              }
              runtimeApplication1 = CustomBatcher.runtimeApplication = Locator.GetService<IRuntimeApplication>();
              break;
            case 8:
              IRuntimeApplication runtimeApplication2 = CustomBatcher.runtimeApplication;
              if (runtimeApplication2 == null)
              {
                num2 = 7;
                continue;
              }
              runtimeApplication1 = runtimeApplication2;
              break;
            default:
              goto label_4;
          }
          CustomBatcher.runtimeApplication = runtimeApplication1;
          num2 = 6;
        }
label_3:
        ((DbCommand) command).CommandTimeout = commandTimeout.Value;
        num1 = 2;
      }
label_4:
      return (DbCommand) command;
label_7:
      return (DbCommand) command;
    }

    private static void ProcessException(object ex)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            CustomBatcher.RQJKdtWNWEk6GnKUFlFj(ex, (object) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private static void ProcessException(object ex, object dbConnection)
    {
      int num = 11;
      while (true)
      {
        ITransformationProvider transformationProvider;
        IRuntimeApplication runtimeApplication1;
        IUnitOfWorkManager unitOfWorkManager1;
        switch (num)
        {
          case 1:
            CustomBatcher.runtimeApplication = runtimeApplication1 = Locator.GetService<IRuntimeApplication>();
            break;
          case 2:
            unitOfWorkManager1 = (IUnitOfWorkManager) null;
            goto label_29;
          case 3:
            if (CustomBatcher.YTlIxWWNSJ2NqjV41rVr())
            {
              num = 5;
              continue;
            }
            goto case 2;
          case 4:
            if (CustomBatcher.runtimeApplication != null)
            {
              transformationProvider = (ITransformationProvider) CustomBatcher.zB4GdXWNiJmJQlwIpRWM((object) CustomBatcher.runtimeApplication);
              num = 14;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 9 : 0;
            continue;
          case 5:
            unitOfWorkManager1 = CustomBatcher.unitOfWorkManager = Locator.GetService<IUnitOfWorkManager>();
            goto label_29;
          case 6:
            IUnitOfWorkManager unitOfWorkManager2 = CustomBatcher.unitOfWorkManager;
            if (unitOfWorkManager2 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 3 : 2;
              continue;
            }
            unitOfWorkManager1 = unitOfWorkManager2;
            goto label_29;
          case 7:
            CustomBatcher.unitOfWorkManager.ThrowExceptionOnCommit((Exception) ex);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 16 : 8;
            continue;
          case 8:
            goto label_21;
          case 9:
            goto label_3;
          case 10:
            if (CustomBatcher.YTlIxWWNSJ2NqjV41rVr())
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 1;
              continue;
            }
            goto case 13;
          case 11:
            IRuntimeApplication runtimeApplication2 = CustomBatcher.runtimeApplication;
            if (runtimeApplication2 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 10 : 2;
              continue;
            }
            runtimeApplication1 = runtimeApplication2;
            break;
          case 12:
            goto label_19;
          case 13:
            runtimeApplication1 = (IRuntimeApplication) null;
            break;
          case 14:
            if (transformationProvider.IsUnrecoverableException((Exception) ex))
            {
              num = 6;
              continue;
            }
            goto case 16;
          case 15:
            if (CustomBatcher.unitOfWorkManager != null)
            {
              num = 7;
              continue;
            }
            goto case 16;
          case 16:
            if (transformationProvider == null)
            {
              num = 8;
              continue;
            }
            goto default;
          default:
            CustomBatcher.lK8VUhWNRFs9VhqloFCY((object) transformationProvider, ex, dbConnection);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 12 : 5;
            continue;
        }
        CustomBatcher.runtimeApplication = runtimeApplication1;
        num = 4;
        continue;
label_29:
        CustomBatcher.unitOfWorkManager = unitOfWorkManager1;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 15 : 1;
      }
label_21:
      return;
label_3:
      return;
label_19:;
    }

    static CustomBatcher()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            CustomBatcher.yH2K3rWNqICN5B653NPH();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            CustomBatcher.OrgItemLog = (ILogger) CustomBatcher.NVaHjwWNKMtWrKqbjlsF(CustomBatcher.EFZE9UW1YprMiZQoJKub(-1867198571 ^ -1867063857));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool JdVDhiW14n1hXBCALUhW() => CustomBatcher.gF0AaUW1wCdtw4HLRhkP == null;

    internal static CustomBatcher zdYLX8W16U76YL7YOmaf() => CustomBatcher.gF0AaUW1wCdtw4HLRhkP;

    internal static AsyncTaskMethodBuilder yuRPJTW1HNO7IJMFenE3() => AsyncTaskMethodBuilder.Create();

    internal static bool ne4CSkW1AGC36NPpOMFo([In] object obj0, [In] object obj1) => SavePointHelper.SavePoint((string) obj0, (IDbCommand) obj1);

    internal static void wX9onmW17SOVlyJyKJM2([In] object obj0, [In] object obj1) => SavePointHelper.ReleaseSavePoint((string) obj0, (IDbCommand) obj1);

    internal static void ef5agyW1xqGEbMT7DIsF([In] object obj0, [In] object obj1) => SavePointHelper.RollBackSavePoint((string) obj0, (IDbCommand) obj1);

    internal static void OgO6sSW10vZglgu08kpH([In] object obj0, [In] object obj1) => ((IBatcher) obj0).AbortBatch((Exception) obj1);

    internal static int r3Rm7gW1mXyo37JPrcso([In] object obj0) => ((IExpectation) obj0).ExpectedRowCount;

    internal static void k0FyL0W1yNSbpn3FjfkQ([In] object obj0, [In] object obj1) => ((IBatcher) obj0).AddToBatch((IExpectation) obj1);

    internal static int QHTnZHW1MnaS9dlLAJGG([In] object obj0) => ((IBatcher) obj0).BatchSize;

    internal static void Cro4GgW1JqTQiYOBAh2t([In] object obj0, [In] int obj1) => ((IBatcher) obj0).BatchSize = obj1;

    internal static void DuXHPgW19pQxv22rGMnl([In] object obj0) => ((IBatcher) obj0).CancelLastQuery();

    internal static void btKj1FW1d8NyW0RiBXDj([In] object obj0, [In] object obj1, [In] object obj2) => ((IBatcher) obj0).CloseCommand((DbCommand) obj1, (DbDataReader) obj2);

    internal static void mY0Sn2W1lHZFUvQCb3Zt([In] object obj0) => ((IBatcher) obj0).CloseCommands();

    internal static void xCnfUNW1rU53fBExuPfC([In] object obj0, [In] object obj1) => ((IBatcher) obj0).CloseReader((DbDataReader) obj1);

    internal static bool mL01r7W1gSXb36nBslmN([In] object obj0, EleWise.ELMA.Logging.LogLevel level) => ((ILogger) obj0).IsEnabled(level);

    internal static object uAX3wOW15YsylCp716uU([In] object obj0) => (object) ((DbCommand) obj0).CommandText;

    internal static bool VPCk0fW1jRw6rUG7QDoY([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object EFZE9UW1YprMiZQoJKub(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool QCRO9WW1LpKDrc8dA52J([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).StartsWith((string) obj1, obj2);

    internal static object yR6AqkW1U71LhmrXZpGm([In] object obj0) => (object) ((DbCommand) obj0).Parameters;

    internal static object GZlvLFW1sguHo2bkygEF(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) string.Format((string) obj0, obj1, obj2, obj3);
    }

    internal static void jLpyPnW1cTnn1bQkyhar([In] object obj0, [In] object obj1) => ((ILogger) obj0).Debug(obj1);

    internal static void I1OAVbW1zNaGBGksfgFP([In] object obj0) => ((IBatcher) obj0).ExecuteBatch();

    internal static void lXmSvkWNFvPuHY8knMGQ([In] object obj0, [In] object obj1) => ((AbstractCallInfo) obj0).Exception = (Exception) obj1;

    internal static int HHWCSsWNBq4Z41XejoYc([In] object obj0, [In] object obj1) => ((IBatcher) obj0).ExecuteNonQuery((DbCommand) obj1);

    internal static void RQJKdtWNWEk6GnKUFlFj([In] object obj0, [In] object obj1) => CustomBatcher.ProcessException(obj0, obj1);

    internal static void y182loWNoTJHc01K5jT8([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool zhjcKUWNbSfH3Ue9QoZx([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static bool v3lDhIWNhfXPg6tjWOnX([In] object obj0, [In] object obj1) => Regex.IsMatch((string) obj0, (string) obj1);

    internal static object WUoMJAWNGRud8UrvvGGM([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object t29KUIWNERunP3XbGctj() => (object) CustomBatcher.Pattern;

    internal static object qw2C0yWNf6kXvx9avGIu(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] RegexOptions obj3)
    {
      return (object) Regex.Replace((string) obj0, (string) obj1, (MatchEvaluator) obj2, obj3);
    }

    internal static void D4YxZ0WNQR4rarh3ZMbo([In] object obj0, [In] object obj1) => ((DbCommand) obj0).CommandText = (string) obj1;

    internal static object TlqeCFWNCKo5a5wbFqbK([In] object obj0, [In] object obj1) => (object) ((IBatcher) obj0).ExecuteReader((DbCommand) obj1);

    internal static object LZfVOvWNvIWY8YgTagCG([In] object obj0) => (object) ((DbCommand) obj0).Connection;

    internal static bool zn2gtwWN8LXLAvIu2SGE([In] object obj0) => ((IBatcher) obj0).HasOpenResources;

    internal static object hM0c3HWNZPhGctwvfPeE(
      [In] object obj0,
      [In] CommandType obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((IBatcher) obj0).PrepareBatchCommand(obj1, (SqlString) obj2, (SqlType[]) obj3);
    }

    internal static object FGr1S5WNu6TyFmTApfr5([In] object obj0) => (object) CustomBatcher.SetCommandTimeout(obj0);

    internal static object iIK4XHWNI1aWnRF8j2rx(
      [In] object obj0,
      [In] CommandType obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((IBatcher) obj0).PrepareCommand(obj1, (SqlString) obj2, (SqlType[]) obj3);
    }

    internal static object PNw5ytWNVD1Afvaupbs3(
      [In] object obj0,
      [In] CommandType obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((IBatcher) obj0).PrepareQueryCommand(obj1, (SqlString) obj2, (SqlType[]) obj3);
    }

    internal static bool YTlIxWWNSJ2NqjV41rVr() => Locator.Initialized;

    internal static object zB4GdXWNiJmJQlwIpRWM([In] object obj0) => (object) ((IRuntimeApplication) obj0).TransformationProvider;

    internal static void lK8VUhWNRFs9VhqloFCY([In] object obj0, [In] object obj1, [In] object obj2) => ((ITransformationProvider) obj0).ProcessException((Exception) obj1, (IDbConnection) obj2);

    internal static void yH2K3rWNqICN5B653NPH() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object NVaHjwWNKMtWrKqbjlsF([In] object obj0) => (object) Logger.GetLogger((string) obj0);
  }
}
