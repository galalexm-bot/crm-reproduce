// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.Migrator.Providers.TransformationProviderBase
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Proxies;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime.Db.Migrator.Providers
{
  /// <summary>
  /// Базовый провайдер преобразования БД (Базовые методы, общие между синхронной и асинхронной частями)
  /// </summary>
  /// <summary>Базовый провайдер преобразования БД</summary>
  public abstract class TransformationProviderBase : ITransformationProviderBase, IDisposable
  {
    /// <summary>Интерфейс для работы со средой исполнения приложения</summary>
    protected static IRuntimeApplication runtimeApplication;
    /// <summary>Соединение с БД</summary>
    protected IDbConnection connection;
    /// <summary>Транзакция</summary>
    protected IDbTransaction transaction;
    /// <summary>Функция создания соединения с БД</summary>
    protected Func<IDbConnection> connectionCreateFunc;
    private static readonly AsyncLocal<int?> contextTimeout;
    private bool disposed;
    private static TransformationProviderBase cHPScIWTYiW9tIIJCVed;

    /// <summary>Выполнить запрос</summary>
    /// <param name="sql">Текст запроса</param>
    /// <param name="paramValues">Значения параметров</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <param name="isAsync"><c>true</c> если выполнять асинхронно</param>
    /// <returns>Объект для чтения результатов запроса</returns>
    internal async ValueTask<IDataReader> ExecuteQueryBaseAsync(
      string sql,
      Dictionary<string, object> paramValues,
      bool isAsync,
      CancellationToken cancellationToken = default (CancellationToken))
    {
      int num1 = 1;
      IDataReader result;
      int num2;
      TransformationProviderBase transformationProviderBase;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
            continue;
          case 2:
label_3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = 3;
            continue;
          case 3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result);
            num1 = 5;
            continue;
          case 4:
            try
            {
              int num3;
              if (num2 == 0)
                num3 = 6;
              else
                goto label_10;
label_7:
              IDbCommand cmd;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    goto label_13;
                  case 2:
                    goto label_10;
                  case 3:
                    cmd = transformationProviderBase.BuildCommand(sql);
                    num3 = 4;
                    continue;
                  case 4:
                  case 6:
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 1 : 0;
                    continue;
                  case 5:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    TransformationProviderBase.\u003CExecuteQueryBaseAsync\u003Ed__0.A7yZYLQHP6QQsogTpgdY((object) sql, TransformationProviderBase.\u003CExecuteQueryBaseAsync\u003Ed__0.BXmETQQHeEjTHVihgGsH(1253244298 - 1829393894 ^ -576103852));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
                    continue;
                  default:
                    Dictionary<string, object> dictionary = paramValues;
                    paramValues = dictionary == null ? new Dictionary<string, object>() : dictionary;
                    num3 = 3;
                    continue;
                }
              }
label_13:
              try
              {
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
                  num4 = 0;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_17;
                    default:
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 1;
                      continue;
                  }
                }
label_17:
                try
                {
                  int num5;
                  if (num2 != 0)
                    num5 = 7;
                  else
                    goto label_62;
label_20:
                  TaskAwaiter<DbDataReader> taskAwaiter;
                  TaskAwaiter<DbDataReader> awaiter;
                  while (true)
                  {
                    int num6;
                    DataTable data;
                    IEnumerator enumerator1;
                    IDataReader dataReader;
                    IDataReader reader;
                    Dictionary<string, object>.Enumerator enumerator2;
                    switch (num5)
                    {
                      case 1:
                      case 17:
                        reader = dataReader;
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 11 : 15;
                        continue;
                      case 2:
                        // ISSUE: reference to a compiler-generated method
                        dataReader = (IDataReader) TransformationProviderBase.\u003CExecuteQueryBaseAsync\u003Ed__0.icdttaQHDUytbPKfpdHL((object) cmd);
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 1 : 1;
                        continue;
                      case 3:
                        try
                        {
label_30:
                          // ISSUE: reference to a compiler-generated method
                          if (TransformationProviderBase.\u003CExecuteQueryBaseAsync\u003Ed__0.JIx2MfQHH08Md9vdRqMq((object) enumerator1))
                            goto label_28;
                          else
                            goto label_31;
label_27:
                          int num7;
                          switch (num7)
                          {
                            case 1:
                              break;
                            case 2:
                              goto label_67;
                            default:
                              goto label_30;
                          }
label_28:
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          TransformationProviderBase.\u003CExecuteQueryBaseAsync\u003Ed__0.MsIajGQH6TtxG5BPFHnC((object) (DataColumn) TransformationProviderBase.\u003CExecuteQueryBaseAsync\u003Ed__0.cMKcPhQH4rqPQunNfByV((object) enumerator1), false);
                          num7 = 0;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
                          {
                            num7 = 0;
                            goto label_27;
                          }
                          else
                            goto label_27;
label_31:
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 2 : 2;
                          goto label_27;
                        }
                        finally
                        {
                          int num8;
                          if (num2 >= 0)
                            num8 = 2;
                          else
                            goto label_35;
label_34:
                          IDisposable disposable;
                          while (true)
                          {
                            switch (num8)
                            {
                              case 1:
                                if (disposable != null)
                                {
                                  num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
                                  continue;
                                }
                                goto label_40;
                              case 2:
                              case 4:
                                goto label_40;
                              case 3:
                                goto label_35;
                              default:
                                // ISSUE: reference to a compiler-generated method
                                TransformationProviderBase.\u003CExecuteQueryBaseAsync\u003Ed__0.Q19cS6QHAs2Pgbu2kFsF((object) disposable);
                                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 4 : 3;
                                continue;
                            }
                          }
label_40:
label_35:
                          disposable = enumerator1 as IDisposable;
                          num8 = 0;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
                          {
                            num8 = 1;
                            goto label_34;
                          }
                          else
                            goto label_34;
                        }
                      case 4:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        enumerator1 = (IEnumerator) TransformationProviderBase.\u003CExecuteQueryBaseAsync\u003Ed__0.AoRV4tQHwC3HvLoDW1aV(TransformationProviderBase.\u003CExecuteQueryBaseAsync\u003Ed__0.x5Bo1cQHtwg66Uox1Yo0((object) data));
                        num5 = 3;
                        continue;
                      case 5:
                        goto label_62;
                      case 6:
                        enumerator2 = paramValues.GetEnumerator();
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 3 : 16;
                        continue;
                      case 7:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        TransformationProviderBase.\u003CExecuteQueryBaseAsync\u003Ed__0.o27bTVQHNpnUpxDO07ya(TransformationProviderBase.\u003CExecuteQueryBaseAsync\u003Ed__0.HQKf6cQH1OlYNroD0lH7((object) cmd));
                        num5 = 6;
                        continue;
                      case 8:
label_24:
                        if (isAsync)
                        {
                          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 22 : 13;
                          continue;
                        }
                        goto case 2;
                      case 9:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003E1__state = num2 = -1;
                        num5 = 21;
                        continue;
                      case 10:
label_67:
                        transformationProviderBase.TransformIntoRuntimeDateTime(data);
                        num5 = 19;
                        continue;
                      case 11:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003E1__state = num2 = 0;
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
                        continue;
                      case 12:
                        goto label_3;
                      case 13:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<DbDataReader>, TransformationProviderBase.\u003CExecuteQueryBaseAsync\u003Ed__0>(ref awaiter, this);
                        num6 = 20;
                        break;
                      case 14:
                        awaiter = dbCommand.ExecuteReaderAsync(cancellationToken).GetAwaiter();
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 23 : 21;
                        continue;
                      case 15:
                        data = new DataTable();
                        num5 = 18;
                        continue;
                      case 16:
                        try
                        {
label_54:
                          if (enumerator2.MoveNext())
                            goto label_51;
                          else
                            goto label_55;
label_50:
                          KeyValuePair<string, object> current;
                          int num9;
                          while (true)
                          {
                            switch (num9)
                            {
                              case 1:
                                // ISSUE: reference to a compiler-generated method
                                // ISSUE: reference to a compiler-generated method
                                // ISSUE: reference to a compiler-generated method
                                TransformationProviderBase.\u003CExecuteQueryBaseAsync\u003Ed__0.MsqcbmQHafb2PZXj7wDs((object) transformationProviderBase, (object) cmd, TransformationProviderBase.\u003CExecuteQueryBaseAsync\u003Ed__0.TYOLClQHp2nc8PnrAVa8(TransformationProviderBase.\u003CExecuteQueryBaseAsync\u003Ed__0.NSN2pwQH3pfs8jjWaZXK((object) transformationProviderBase), (object) current.Key), current.Value);
                                num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 2 : 0;
                                continue;
                              case 2:
                                goto label_54;
                              case 3:
                                goto label_51;
                              default:
                                goto label_24;
                            }
                          }
label_51:
                          current = enumerator2.Current;
                          num9 = 1;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
                          {
                            num9 = 1;
                            goto label_50;
                          }
                          else
                            goto label_50;
label_55:
                          num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
                          goto label_50;
                        }
                        finally
                        {
                          if (num2 < 0)
                          {
                            int num10 = 0;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
                              num10 = 0;
                            while (true)
                            {
                              switch (num10)
                              {
                                case 1:
                                  goto label_61;
                                default:
                                  enumerator2.Dispose();
                                  num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 1 : 1;
                                  continue;
                              }
                            }
                          }
label_61:;
                        }
                      case 18:
                        data.Load(reader);
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 4;
                        continue;
                      case 19:
                        // ISSUE: reference to a compiler-generated method
                        result = (IDataReader) new SafeDataReader((DbDataReader) TransformationProviderBase.\u003CExecuteQueryBaseAsync\u003Ed__0.ddjK6WQH7vI7gvxp50iC((object) data), (DbCommand) cmd);
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 12 : 9;
                        continue;
                      case 20:
                        goto label_91;
                      case 21:
                        dataReader = (IDataReader) awaiter.GetResult();
                        num6 = 17;
                        break;
                      case 22:
                        if (cmd is DbCommand dbCommand)
                        {
                          num6 = 14;
                          break;
                        }
                        goto case 2;
                      case 23:
                        if (!awaiter.IsCompleted)
                        {
                          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 3 : 11;
                          continue;
                        }
                        goto case 21;
                      case 24:
                        taskAwaiter = new TaskAwaiter<DbDataReader>();
                        num5 = 9;
                        continue;
                      default:
                        taskAwaiter = awaiter;
                        num5 = 13;
                        continue;
                    }
                    num5 = num6;
                  }
label_91:
                  return;
label_62:
                  awaiter = taskAwaiter;
                  num5 = 24;
                  goto label_20;
                }
                catch (Exception ex)
                {
                  int num11 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0)
                    num11 = 0;
                  while (true)
                  {
                    switch (num11)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        TransformationProviderBase.\u003CExecuteQueryBaseAsync\u003Ed__0.SEhmj4QHmFpUfu2u6wNc(TransformationProviderBase.\u003CExecuteQueryBaseAsync\u003Ed__0.AiG6X2QHx0nKKUQTAree(), (object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583942172) + (string) TransformationProviderBase.\u003CExecuteQueryBaseAsync\u003Ed__0.L1Jxu9QH0d8jB7VBk4YJ((object) cmd) + (string) TransformationProviderBase.\u003CExecuteQueryBaseAsync\u003Ed__0.BXmETQQHeEjTHVihgGsH(333888594 ^ 1075625116 ^ 1408918512)), (object) ex);
                        num11 = 3;
                        continue;
                      case 2:
                      case 3:
                        goto label_78;
                      default:
                        // ISSUE: explicit non-virtual call
                        if (!__nonvirtual (transformationProviderBase.LogsEnabled))
                        {
                          num11 = 2;
                          continue;
                        }
                        goto case 1;
                    }
                  }
label_78:
                  throw;
                }
              }
              finally
              {
                if (num2 < 0)
                {
                  int num12 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0)
                    num12 = 0;
                  while (true)
                  {
                    switch (num12)
                    {
                      case 1:
                      case 2:
                        goto label_87;
                      case 3:
                        // ISSUE: reference to a compiler-generated method
                        TransformationProviderBase.\u003CExecuteQueryBaseAsync\u003Ed__0.Q19cS6QHAs2Pgbu2kFsF((object) cmd);
                        num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 2;
                        continue;
                      default:
                        if (cmd == null)
                        {
                          num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 1;
                          continue;
                        }
                        goto case 3;
                    }
                  }
                }
label_87:;
              }
label_10:
              cancellationToken.ThrowIfCancellationRequested();
              num3 = 5;
              goto label_7;
            }
            catch (Exception ex)
            {
              int num13 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
                num13 = 0;
              while (true)
              {
                switch (num13)
                {
                  case 1:
                    goto label_83;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 1;
                    continue;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num13 = 2;
                    continue;
                }
              }
label_83:
              return;
            }
          case 5:
            goto label_94;
          default:
            transformationProviderBase = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 4 : 2;
            continue;
        }
      }
label_94:;
    }

    /// <summary>Выполнить запрос, возвращающий один результат</summary>
    /// <param name="sql">Текст запроса</param>
    /// <param name="paramValues">Значения параметров</param>
    /// <param name="isAsync"><c>true</c> если выполнять асинхронно</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Возвращенное значение</returns>
    internal async ValueTask<object> ExecuteScalarBaseAsync(
      string sql,
      Dictionary<string, object> paramValues,
      bool isAsync,
      CancellationToken cancellationToken = default (CancellationToken))
    {
      int num1 = 4;
      object result;
      int num2;
      TransformationProviderBase transformationProviderBase;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_78;
          case 1:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
            continue;
          case 2:
            try
            {
              int num3;
              if (num2 != 0)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 2 : 1;
              else
                goto label_6;
label_5:
              IDbCommand cmd;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    goto label_12;
                  case 2:
                    cancellationToken.ThrowIfCancellationRequested();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
                    continue;
                  case 3:
                    cmd = transformationProviderBase.BuildCommand(sql);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 2 : 4;
                    continue;
                  case 4:
                    goto label_6;
                  case 5:
                    paramValues = paramValues ?? new Dictionary<string, object>();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 1 : 3;
                    continue;
                  default:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    TransformationProviderBase.\u003CExecuteScalarBaseAsync\u003Ed__1.Qa6SqeQHdrcd2knxYYNq((object) sql, TransformationProviderBase.\u003CExecuteScalarBaseAsync\u003Ed__1.oHYkJZQH9wWOlB3tNGb8(1514961705 ^ 1515030233));
                    num3 = 5;
                    continue;
                }
              }
label_12:
              try
              {
                int num4;
                if (num2 == 0)
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 2 : 4;
                else
                  goto label_28;
label_14:
                Dictionary<string, object>.Enumerator enumerator;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                    case 4:
label_15:
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_28;
                    case 3:
                      try
                      {
label_18:
                        if (enumerator.MoveNext())
                          goto label_21;
                        else
                          goto label_19;
label_17:
                        KeyValuePair<string, object> current;
                        int num5;
                        while (true)
                        {
                          switch (num5)
                          {
                            case 1:
                              goto label_21;
                            case 2:
                              goto label_15;
                            case 3:
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              TransformationProviderBase.\u003CExecuteScalarBaseAsync\u003Ed__1.zSf7yNQH5hDGXCuMaYDU((object) transformationProviderBase, (object) cmd, TransformationProviderBase.\u003CExecuteScalarBaseAsync\u003Ed__1.xesomAQHgnvt7yE6Rhot(TransformationProviderBase.\u003CExecuteScalarBaseAsync\u003Ed__1.ffCVpnQHrZfXFrtV71Xm((object) transformationProviderBase), (object) current.Key), current.Value);
                              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
                              continue;
                            default:
                              goto label_18;
                          }
                        }
label_19:
                        num5 = 2;
                        goto label_17;
label_21:
                        current = enumerator.Current;
                        num5 = 3;
                        goto label_17;
                      }
                      finally
                      {
                        int num6;
                        if (num2 >= 0)
                          num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 1;
                        else
                          goto label_25;
label_24:
                        switch (num6)
                        {
                          case 2:
                            break;
                          default:
                        }
label_25:
                        enumerator.Dispose();
                        num6 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0)
                        {
                          num6 = 0;
                          goto label_24;
                        }
                        else
                          goto label_24;
                      }
                    case 5:
                      enumerator = paramValues.GetEnumerator();
                      num4 = 3;
                      continue;
                    default:
                      goto label_30;
                  }
                }
label_30:
                try
                {
                  int num7;
                  if (num2 == 0)
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 22 : 12;
                  else
                    goto label_53;
label_33:
                  DateTime dt;
                  TaskAwaiter<object> taskAwaiter;
                  object obj1;
                  TaskAwaiter<object> awaiter;
                  object obj2;
                  while (true)
                  {
                    switch (num7)
                    {
                      case 1:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003E1__state = num2 = 0;
                        num7 = 16;
                        continue;
                      case 2:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003E1__state = num2 = -1;
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 5 : 1;
                        continue;
                      case 3:
                      case 10:
                        goto label_80;
                      case 4:
                      case 14:
                        obj2 = obj1;
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 11 : 19;
                        continue;
                      case 5:
                        obj1 = awaiter.GetResult();
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 14 : 14;
                        continue;
                      case 6:
                      case 7:
                        result = obj2;
                        num7 = 10;
                        continue;
                      case 8:
                        goto label_34;
                      case 9:
                        goto label_68;
                      case 11:
                        taskAwaiter = new TaskAwaiter<object>();
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 2 : 2;
                        continue;
                      case 12:
                        dt = (DateTime) obj1;
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 14 : 20;
                        continue;
                      case 13:
                        goto label_53;
                      case 15:
                        if (!awaiter.IsCompleted)
                        {
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 1;
                          continue;
                        }
                        goto case 5;
                      case 16:
                        taskAwaiter = awaiter;
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
                        continue;
                      case 17:
                      case 22:
                        awaiter = taskAwaiter;
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 5 : 11;
                        continue;
                      case 18:
                        if (cmd is DbCommand dbCommand)
                        {
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 21 : 17;
                          continue;
                        }
                        goto label_34;
                      case 19:
                        if (!((obj1 = obj2) is DateTime))
                        {
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 6;
                          continue;
                        }
                        goto case 12;
                      case 20:
                        // ISSUE: reference to a compiler-generated method
                        result = (object) TransformationProviderBase.\u003CExecuteScalarBaseAsync\u003Ed__1.LRuTH4QHYc2Lhi2jUBDj(dt);
                        num7 = 3;
                        continue;
                      case 21:
                        awaiter = dbCommand.ExecuteScalarAsync(cancellationToken).GetAwaiter();
                        num7 = 15;
                        continue;
                      default:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, TransformationProviderBase.\u003CExecuteScalarBaseAsync\u003Ed__1>(ref awaiter, this);
                        num7 = 9;
                        continue;
                    }
                  }
label_68:
                  return;
label_34:
                  // ISSUE: reference to a compiler-generated method
                  obj1 = TransformationProviderBase.\u003CExecuteScalarBaseAsync\u003Ed__1.lyAmGCQHjdRCmW2ooVBZ((object) cmd);
                  num7 = 2;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
                  {
                    num7 = 4;
                    goto label_33;
                  }
                  else
                    goto label_33;
label_53:
                  if (isAsync)
                  {
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 18 : 5;
                    goto label_33;
                  }
                  else
                    goto label_34;
                }
                catch (Exception ex)
                {
                  int num8 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
                    num8 = 1;
                  while (true)
                  {
                    switch (num8)
                    {
                      case 1:
                        // ISSUE: explicit non-virtual call
                        if (__nonvirtual (transformationProviderBase.LogsEnabled))
                        {
                          num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 2;
                          continue;
                        }
                        goto label_62;
                      case 2:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        TransformationProviderBase.\u003CExecuteScalarBaseAsync\u003Ed__1.BmaHbVQHUtHwSSR7FGw4((object) Logger.Log, (object) ((string) TransformationProviderBase.\u003CExecuteScalarBaseAsync\u003Ed__1.oHYkJZQH9wWOlB3tNGb8(--1360331293 ^ 1360035155) + (string) TransformationProviderBase.\u003CExecuteScalarBaseAsync\u003Ed__1.RvnvKgQHL8IWFk9eRJd0((object) cmd)), (object) ex);
                        num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_62;
                    }
                  }
label_62:
                  throw;
                }
label_28:
                // ISSUE: reference to a compiler-generated method
                TransformationProviderBase.\u003CExecuteScalarBaseAsync\u003Ed__1.rl5HExQHl1m8QUIvPQce((object) cmd.Parameters);
                num4 = 5;
                goto label_14;
              }
              finally
              {
                int num9;
                if (num2 >= 0)
                  num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
                else
                  goto label_69;
label_65:
                while (true)
                {
                  switch (num9)
                  {
                    case 2:
                      goto label_69;
                    case 3:
                      cmd.Dispose();
                      num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 1 : 0;
                      continue;
                    default:
                      goto label_71;
                  }
                }
label_69:
                if (cmd != null)
                {
                  num9 = 3;
                  goto label_65;
                }
label_71:;
              }
label_6:
              num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
              {
                num3 = 0;
                goto label_5;
              }
              else
                goto label_5;
            }
            catch (Exception ex)
            {
              int num10 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
                num10 = 0;
              while (true)
              {
                switch (num10)
                {
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 2 : 2;
                    continue;
                  case 2:
                    goto label_66;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 0;
                    continue;
                }
              }
label_66:
              return;
            }
          case 3:
            transformationProviderBase = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 2;
            continue;
          case 4:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 3 : 0;
            continue;
          case 5:
label_80:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 1 : 1;
            continue;
          default:
            goto label_75;
        }
      }
label_78:
      return;
label_75:;
    }

    /// <summary>Ctor</summary>
    [Obsolete("Не использовать", true)]
    public TransformationProviderBase()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="connectionCreateFunc">Функция создания соединения с БД</param>
    public TransformationProviderBase(Func<IDbConnection> connectionCreateFunc)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      Contract.ArgumentNotNull((object) connectionCreateFunc, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106387300));
      this.connectionCreateFunc = connectionCreateFunc;
      IDbConnection dbConnection = connectionCreateFunc();
      this.connection = !(dbConnection is DbConnectionProxy) ? (IDbConnection) new DbConnectionProxy((DbConnection) dbConnection) : dbConnection;
      if (this.connection.State == ConnectionState.Open)
        return;
      this.BeforeOpenConnection(dbConnection);
      this.connection.Open();
    }

    /// <summary>Dispose</summary>
    public void Dispose()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_6;
          case 1:
            if (this.connection == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
              continue;
            }
            goto case 4;
          case 2:
            goto label_10;
          case 3:
            this.disposed = true;
            num = 5;
            continue;
          case 4:
            if (TransformationProviderBase.P2P9XmWTsnBcWgmWvxXn((object) this.connection) == ConnectionState.Open)
            {
              num = 3;
              continue;
            }
            goto label_2;
          case 5:
            this.connection.Close();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 2 : 2;
            continue;
          default:
            goto label_11;
        }
      }
label_6:
      return;
label_10:
      return;
label_11:
      return;
label_2:;
    }

    /// <summary>Начать транзакцию</summary>
    public void BeginTransaction()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.BeginTransaction(IsolationLevel.Unspecified);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Начать транзакцию</summary>
    /// <param name="level">Уровень изоляции</param>
    public void BeginTransaction(IsolationLevel level)
    {
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_8;
          case 2:
            goto label_4;
          case 3:
            goto label_5;
          case 4:
            if (this.transaction == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 5:
            if (this.connection != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 4 : 1;
              continue;
            }
            goto label_3;
          default:
            this.transaction = level == IsolationLevel.Unspecified ? (IDbTransaction) TransformationProviderBase.yR4ue1WTzIqEJjlEpgoA((object) this.connection) : (IDbTransaction) TransformationProviderBase.iGIOPRWTc6WrtdreVfQF((object) this.connection, level);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 1 : 1;
            continue;
        }
      }
label_8:
      return;
label_4:
      return;
label_5:
      return;
label_2:
      return;
label_3:;
    }

    /// <summary>Откатить транзакцию</summary>
    public void RollbackTransaction()
    {
      int num1 = 6;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_16;
          case 2:
            try
            {
              TransformationProviderBase.bQYYGSWkFZoOm4tx7dIr((object) this.transaction);
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
                num2 = 0;
              switch (num2)
              {
              }
            }
            catch (Exception ex)
            {
              int num3 = 2;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    goto label_19;
                  case 2:
                    if (this.LogsEnabled)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_19;
                  default:
                    ((ILogger) TransformationProviderBase.naC2DvWkBEDh8suK3AEU()).Error(TransformationProviderBase.MIPAnEWkWRtMxO3d4sSF(-281842504 ^ -281972932), ex);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 1 : 1;
                    continue;
                }
              }
            }
            break;
          case 3:
            goto label_2;
          case 4:
            goto label_3;
          case 5:
            if (this.transaction != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 2;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 3;
            continue;
          case 6:
            if (this.connection != null)
            {
              num1 = 5;
              continue;
            }
            goto label_12;
        }
label_19:
        this.transaction = (IDbTransaction) null;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 0;
      }
label_16:
      return;
label_2:
      return;
label_3:
      return;
label_12:;
    }

    /// <summary>Подтвердить транзакцию</summary>
    public void CommitTransaction()
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
label_19:
              this.transaction = (IDbTransaction) null;
              num2 = 2;
              continue;
            case 2:
              goto label_14;
            case 3:
              goto label_13;
            case 4:
              if (this.connection != null)
              {
                if (this.transaction == null)
                {
                  num2 = 5;
                  continue;
                }
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
                continue;
              }
              goto label_21;
            case 5:
              goto label_17;
            default:
              try
              {
                TransformationProviderBase.NpmyoWWkbsD7Nd7ZxMN1((object) this.transaction);
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0)
                  num3 = 0;
                switch (num3)
                {
                  default:
                    goto label_19;
                }
              }
              catch (Exception ex)
              {
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
                  num4 = 0;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_19;
                    case 2:
                      ((ILogger) TransformationProviderBase.naC2DvWkBEDh8suK3AEU()).Error(TransformationProviderBase.MIPAnEWkWRtMxO3d4sSF(-1426456882 ^ 2009939514 ^ -583613672), ex);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 1 : 1;
                      continue;
                    default:
                      if (this.LogsEnabled)
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 2;
                        continue;
                      }
                      goto label_19;
                  }
                }
              }
          }
        }
label_21:
        num1 = 3;
      }
label_14:
      return;
label_13:
      return;
label_17:
      throw new InvalidOperationException((string) TransformationProviderBase.oCOtPFWko6gMsYhxQLNw(TransformationProviderBase.MIPAnEWkWRtMxO3d4sSF(--1418440330 ^ 1418308916)));
    }

    /// <summary>Подключение к БД</summary>
    public virtual IDbConnection Connection
    {
      get
      {
        int num1 = 6;
        IDbConnection connection1;
        while (true)
        {
          int num2 = num1;
          IDbConnection connection2;
          while (true)
          {
            switch (num2)
            {
              case 1:
                TransformationProviderBase.gyHoV6WkG7FAcuOp6eeZ((object) connection1);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
                continue;
              case 2:
                if (connection1 == null)
                {
                  num2 = 7;
                  continue;
                }
                goto case 11;
              case 3:
              case 7:
              case 9:
                goto label_11;
              case 5:
                goto label_15;
              case 6:
                connection2 = this.connection;
                if (connection2 == null)
                {
                  num2 = 5;
                  continue;
                }
                goto label_17;
              case 8:
                goto label_8;
              case 10:
                TransformationProviderBase.aLCNv3WkEvsEintP5S03((object) this, (object) connection1);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 8 : 8;
                continue;
              case 11:
                if (!TransformationProviderBase.P2P9XmWTsnBcWgmWvxXn((object) connection1).HasFlag((Enum) ConnectionState.Broken))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 4;
                  continue;
                }
                goto case 1;
              default:
                if (connection1.State.HasFlag((Enum) ConnectionState.Open))
                {
                  num2 = 9;
                  continue;
                }
                goto case 10;
            }
          }
label_8:
          connection1.Open();
          num1 = 3;
          continue;
label_15:
          IDbConnection dbConnection = (IDbConnection) new DbConnectionProxy((DbConnection) TransformationProviderBase.wdtSC0Wkhna9PCCLPCiL((object) this.Session), false);
label_16:
          connection1 = dbConnection;
          num1 = 2;
          continue;
label_17:
          dbConnection = connection2;
          goto label_16;
        }
label_11:
        return connection1;
      }
    }

    /// <summary>Провайдер сессий</summary>
    public ISessionProvider SessionProvider
    {
      protected get => this.\u003CSessionProvider\u003Ek__BackingField;
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
              this.\u003CSessionProvider\u003Ek__BackingField = value;
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
    }

    /// <summary>Разделитель параметров</summary>
    public virtual string ParameterSeparator => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2092274397 << 4 ^ 883351340);

    /// <summary>
    /// Таймаут выполнения SQL-команды по умолчанию в секундах. По умолчанию - 600.
    /// Может быть задан в AppSettings["DbTransformCommandTimeout"]
    /// </summary>
    public static int DefaultCommandTimeout
    {
      get
      {
        int num1 = 10;
        int? nullable1;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            int num3;
            int? nullable2;
            IRuntimeApplication runtimeApplication1;
            switch (num2)
            {
              case 1:
                if (Locator.Initialized)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 12 : 1;
                  continue;
                }
                goto case 7;
              case 2:
                if (nullable2.GetValueOrDefault() <= num3 & nullable2.HasValue)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
                  continue;
                }
                goto label_5;
              case 3:
                if (TransformationProviderBase.runtimeApplication != null)
                {
                  num2 = 8;
                  continue;
                }
                goto case 6;
              case 4:
                goto label_5;
              case 5:
                num3 = 0;
                num2 = 2;
                continue;
              case 6:
                if (!nullable1.HasValue)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 13;
                  continue;
                }
                goto case 11;
              case 7:
                runtimeApplication1 = (IRuntimeApplication) null;
                break;
              case 8:
                nullable1 = TransformationProviderBase.runtimeApplication.GetCommandTimeout();
                num2 = 6;
                continue;
              case 9:
                IRuntimeApplication runtimeApplication2 = TransformationProviderBase.runtimeApplication;
                if (runtimeApplication2 == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 1;
                  continue;
                }
                runtimeApplication1 = runtimeApplication2;
                break;
              case 10:
                goto label_15;
              case 11:
                nullable2 = nullable1;
                num2 = 5;
                continue;
              case 12:
                runtimeApplication1 = TransformationProviderBase.runtimeApplication = Locator.GetService<IRuntimeApplication>();
                break;
              default:
                nullable1 = new int?(600);
                num2 = 4;
                continue;
            }
            TransformationProviderBase.runtimeApplication = runtimeApplication1;
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 3;
          }
label_15:
          nullable1 = new int?();
          num1 = 9;
        }
label_5:
        return nullable1.Value;
      }
    }

    /// <summary>Включены ли логи</summary>
    public bool LogsEnabled
    {
      get
      {
        int num = 1;
        bool logsEnabled;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (TransformationProviderBase.PU5hsuWkfwKQxAXQQxYJ())
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_2;
            case 3:
              goto label_5;
            default:
              if (!ContextVars.TryGetValue<bool>((string) TransformationProviderBase.MIPAnEWkWRtMxO3d4sSF(-1867198571 ^ -1867068489), out logsEnabled))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 3 : 1;
                continue;
              }
              goto label_6;
          }
        }
label_2:
        return true;
label_5:
        return true;
label_6:
        return logsEnabled;
      }
      set
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_6;
            case 2:
              if (!TransformationProviderBase.PU5hsuWkfwKQxAXQQxYJ())
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 1;
                continue;
              }
              break;
            case 3:
              goto label_2;
          }
          ContextVars.Set<bool>((string) TransformationProviderBase.MIPAnEWkWRtMxO3d4sSF(1253244298 - 1829393894 ^ -576019578), value);
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 3 : 0;
        }
label_6:
        return;
label_2:;
      }
    }

    /// <inheritdoc />
    public abstract string GuidQuerySintaxis(Guid guid);

    /// <summary>Получить схему таблицы</summary>
    /// <param name="tableName">Имя таблицы</param>
    /// <returns>Объект со схемой таблицы</returns>
    public DataTable GetSchemaTable(string tableName)
    {
      int num1 = 3;
      string query;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_4;
          case 2:
            query = (string) TransformationProviderBase.IuEbNXWkv48lWfRbX0Z9(TransformationProviderBase.MIPAnEWkWRtMxO3d4sSF(1597012150 ^ 1597144284), TransformationProviderBase.MRVus9WkCWvqPVHvccW4((object) this, (object) tableName));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
            continue;
          case 3:
            TransformationProviderBase.YPSG1PWkQELJAKYRBPQe((object) tableName, TransformationProviderBase.MIPAnEWkWRtMxO3d4sSF(277947046 - -1479185048 ^ 1757052316));
            num1 = 2;
            continue;
          case 4:
            goto label_32;
          default:
            query = this.SetupFetchOptions(query, new FetchOptions(0, 1));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 0;
            continue;
        }
      }
label_4:
      DataTable schemaTable;
      try
      {
        IDbCommand dbCommand = (IDbCommand) TransformationProviderBase.LoLoFmWk80ZjhXRl6Uqx((object) this, (object) query);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
              IDataReader dataReader = (IDataReader) TransformationProviderBase.AV3P0rWkZIhaltebkXWj((object) dbCommand, CommandBehavior.KeyInfo);
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
                num3 = 0;
              switch (num3)
              {
                default:
                  try
                  {
                    schemaTable = (DataTable) TransformationProviderBase.jBmHWCWku6i2CCw0gHw1((object) dataReader);
                    int num4 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
                      num4 = 0;
                    switch (num4)
                    {
                    }
                  }
                  finally
                  {
                    if (dataReader != null)
                    {
                      int num5 = 1;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
                        num5 = 1;
                      while (true)
                      {
                        switch (num5)
                        {
                          case 1:
                            TransformationProviderBase.WmZMXtWkIGCdtYKEX32M((object) dataReader);
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
                            continue;
                          default:
                            goto label_20;
                        }
                      }
                    }
label_20:;
                  }
                  break;
              }
            }
            finally
            {
              int num6;
              if (dbCommand == null)
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
              else
                goto label_24;
label_23:
              switch (num6)
              {
                case 1:
                  break;
                default:
              }
label_24:
              dbCommand.Dispose();
              num6 = 2;
              goto label_23;
            }
        }
      }
      catch (Exception ex)
      {
        int num7 = 2;
        while (true)
        {
          switch (num7)
          {
            case 1:
              ((ILogger) TransformationProviderBase.naC2DvWkBEDh8suK3AEU()).Warn(TransformationProviderBase.df5UmEWkVKRvkpWQAtqP(TransformationProviderBase.MIPAnEWkWRtMxO3d4sSF(-1858887263 ^ -1859017249), (object) query, TransformationProviderBase.MIPAnEWkWRtMxO3d4sSF(-812025778 ^ -812049552)), ex);
              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
              continue;
            case 2:
              if (this.LogsEnabled)
              {
                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 1 : 1;
                continue;
              }
              goto label_31;
            default:
              goto label_31;
          }
        }
label_31:
        throw;
      }
label_32:
      return schemaTable;
    }

    /// <summary>Получить список имен таблиц</summary>
    /// <returns>Список имен таблиц</returns>
    public abstract List<string> GetTables();

    /// <inheritdoc />
    public abstract Dialect Dialect { get; }

    /// <summary>Выполнить запрос</summary>
    /// <param name="sql">Текст запроса</param>
    /// <param name="paramValues">Значения параметров</param>
    /// <returns>Объект для чтения результатов запроса</returns>
    public virtual IDataReader ExecuteQuery(string sql, Dictionary<string, object> paramValues = null) => this.ExecuteQueryBaseAsync(sql, paramValues, false, CancellationToken.None).GetAwaiter().GetResult();

    /// <summary>
    /// Выполнить какое-либо действие с указанным ограничением по времени
    /// </summary>
    /// <param name="timeout">Таймаут</param>
    /// <param name="action">Действие</param>
    public void ExecuteWithTimeout(int timeout, System.Action action)
    {
      int num1 = 1;
      int? timeout1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            timeout1 = this.SetCurrentContextTimeout(new int?(timeout));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_13;
          default:
            goto label_3;
        }
      }
label_13:
      return;
label_3:
      try
      {
        int num2;
        if (action == null)
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 1;
        else
          goto label_7;
label_6:
        switch (num2)
        {
          case 1:
            return;
          case 2:
            return;
        }
label_7:
        TransformationProviderBase.WqUlsAWkSNiHJh6ObqZL((object) action);
        num2 = 2;
        goto label_6;
      }
      finally
      {
        this.SetCurrentContextTimeout(timeout1);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    /// <summary>Выполнить запрос, возвращающий один результат</summary>
    /// <param name="sql">Текст запроса</param>
    /// <param name="paramValues">Значения параметров</param>
    /// <returns>Возвращенное значение</returns>
    public virtual object ExecuteScalar(string sql, Dictionary<string, object> paramValues = null) => this.ExecuteScalarBaseAsync(sql, paramValues, false, CancellationToken.None).GetAwaiter().GetResult();

    /// <summary>
    /// Установить максимальное время выполнения запросов для текущего контекста
    /// </summary>
    /// <param name="timeout">Время в секундах</param>
    /// <returns>Предыдущее значение времени</returns>
    public int? SetCurrentContextTimeout(int? timeout)
    {
      int? nullable = TransformationProviderBase.contextTimeout.Value;
      TransformationProviderBase.contextTimeout.Value = timeout;
      return nullable;
    }

    /// <summary>Добавить в запрос пейджинг</summary>
    /// <param name="query">Запрос</param>
    /// <param name="fetchOptions"></param>
    /// <returns>Запрос</returns>
    public virtual string SetupFetchOptions(string query, FetchOptions fetchOptions) => (string) TransformationProviderBase.Bsgr8EWkiRAF8KTAaTy1((object) this, (object) query, (object) fetchOptions, true);

    /// <summary>Добавить в запрос пейджинг</summary>
    /// <param name="query">Запрос</param>
    /// <param name="fetchOptions">Параметры</param>
    /// <param name="quoteIfNeededSortExpression">нужно ли оборачивать строку сортировки кавычками (при необходимости)</param>
    /// <returns>Запрос</returns>
    public abstract string SetupFetchOptions(
      string query,
      FetchOptions fetchOptions,
      bool quoteIfNeededSortExpression);

    /// <summary>Создать запрос на получение числа строк.</summary>
    /// <param name="query">Запрос</param>
    public abstract string Count(string query);

    public virtual bool IsSortableDataColumn(DataColumn column) => true;

    /// <summary>
    /// Получить список внешних ключей. Pair.Key - имя таблицы. Pair.Value - Имя внешнего ключа.
    /// </summary>
    /// <returns>Список внешних ключей</returns>
    public abstract IList<ForeignKey> GetForeignKeys();

    /// <summary>
    /// Получить все первичные ключи. Pair.Key - имя таблицы. Pair.Value - Первичный ключ.
    /// </summary>
    /// <returns>Внешние ключи</returns>
    public abstract IDictionary<string, PrimaryKey> GetAllPrimaryKeys();

    /// <summary>Получить список имен представлений</summary>
    /// <returns>Список имен представлений</returns>
    public abstract List<string> GetViews();

    /// <summary>Сессия NHibernate</summary>
    protected ISession Session
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              TransformationProviderBase.qaRiPbWkRbv0uPUG9H7i((object) this.SessionProvider, TransformationProviderBase.MIPAnEWkWRtMxO3d4sSF(--1333735954 ^ 1333707486));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return (ISession) TransformationProviderBase.adrtxUWkqIth09awhnVy((object) this.SessionProvider, (object) "");
      }
    }

    /// <summary>
    /// Действие выполняемое перед вызовом <see cref="M:System.Data.IDbConnection.Open" />
    /// </summary>
    /// <param name="dbConnection">Подключение к БД</param>
    protected virtual void BeforeOpenConnection(IDbConnection dbConnection)
    {
    }

    /// <summary>Построить команду</summary>
    /// <param name="sql">Текст команды</param>
    /// <returns>Команда</returns>
    protected virtual IDbCommand BuildCommand(string sql)
    {
      int num = 5;
      IDbCommand command;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 3:
          case 8:
            goto label_12;
          case 2:
            if (this.connection == null)
            {
              num = 10;
              continue;
            }
            goto case 7;
          case 4:
            TransformationProviderBase.MJVlT4WkX57aHO5ZTXvd((object) command, (object) sql);
            num = 11;
            continue;
          case 5:
            command = (IDbCommand) TransformationProviderBase.SOO2xCWkKeMySd6OvdFB((object) this.Connection);
            num = 4;
            continue;
          case 6:
            if (TransformationProviderBase.DCDYmIWkkMvwVrrjo7Gj((object) this.Session) != null)
            {
              num = 9;
              continue;
            }
            goto label_12;
          case 7:
            command.Transaction = this.transaction;
            num = 8;
            continue;
          case 9:
            TransformationProviderBase.nP73RlWkn8pXXNaqTocH(TransformationProviderBase.DCDYmIWkkMvwVrrjo7Gj((object) this.Session), (object) (DbCommand) command);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 1 : 1;
            continue;
          case 10:
            if (this.Session == null)
            {
              num = 3;
              continue;
            }
            goto case 6;
          case 11:
            TransformationProviderBase.AhRWAtWkTZFAK5DaviDd((object) command, CommandType.Text);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
            continue;
          default:
            this.SetCommanTimeout(command);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 1 : 2;
            continue;
        }
      }
label_12:
      return command;
    }

    /// <summary>ServerDateTime --&gt; RuntimeDateTime</summary>
    /// <param name="data">Данные чтения</param>
    protected void TransformIntoRuntimeDateTime(DataTable data)
    {
      int num = 7;
      int columnIndex;
      int index;
      DateTime? nullable;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (nullable.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 5 : 10;
              continue;
            }
            goto case 14;
          case 2:
          case 13:
            if (index >= TransformationProviderBase.h4OtFDWkakirc506su4S((object) data.Rows))
            {
              num = 5;
              continue;
            }
            goto case 9;
          case 3:
            goto label_19;
          case 4:
          case 5:
            ++columnIndex;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 11 : 15;
            continue;
          case 6:
          case 15:
            if (columnIndex < TransformationProviderBase.h4OtFDWkakirc506su4S((object) data.Columns))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
              continue;
            }
            goto label_13;
          case 7:
            columnIndex = 0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 6 : 4;
            continue;
          case 8:
            // ISSUE: type reference
            if (!TransformationProviderBase.P5CK9jWk11mXwUGGsXKQ(TransformationProviderBase.aUiyAMWkeXJbQfbm8wTR(TransformationProviderBase.JfU09EWk23PoHtZPpqNJ((object) data.Columns, columnIndex)), TransformationProviderBase.YuHVNFWkPBS0BSYvffX6(__typeref (DateTime?))))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 4 : 0;
              continue;
            }
            goto case 12;
          case 9:
            nullable = data.Rows[index][columnIndex] as DateTime?;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 1 : 1;
            continue;
          case 10:
            TransformationProviderBase.RaflpWWkpULR8K01TwxR(TransformationProviderBase.jTrri8WkNZyXwRaLN4DS((object) data.Rows, index), columnIndex, (object) TransformationProviderBase.pFkxenWk32S2IuXWXev5(nullable.Value));
            num = 14;
            continue;
          case 12:
            index = 0;
            num = 2;
            continue;
          case 14:
            ++index;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 4 : 13;
            continue;
          default:
            // ISSUE: type reference
            if (!TransformationProviderBase.P5CK9jWk11mXwUGGsXKQ(TransformationProviderBase.aUiyAMWkeXJbQfbm8wTR(TransformationProviderBase.JfU09EWk23PoHtZPpqNJ(TransformationProviderBase.Rj8FVAWkO8FtT6hH4yJr((object) data), columnIndex)), TransformationProviderBase.YuHVNFWkPBS0BSYvffX6(__typeref (DateTime))))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 3 : 8;
              continue;
            }
            goto case 12;
        }
      }
label_19:
      return;
label_13:;
    }

    /// <summary>Добавить параметр</summary>
    /// <param name="cmd">Команда</param>
    /// <param name="name">Имя параметра</param>
    /// <param name="val">Значение параметра</param>
    protected virtual void AddParameter(IDbCommand cmd, string name, object val)
    {
      int num = 2;
      IDbDataParameter parameter;
      while (true)
      {
        switch (num)
        {
          case 1:
            parameter.ParameterName = name;
            num = 4;
            continue;
          case 2:
            parameter = cmd.CreateParameter();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          case 4:
            TransformationProviderBase.dTRsd7WkDrlg2bVOqQvp((object) this, (object) parameter, val);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
            continue;
          default:
            TransformationProviderBase.bjJtGtWkw7lwdYSRJ6UB(TransformationProviderBase.vOreSgWktg4dFUE3PC3B((object) cmd), (object) parameter);
            num = 3;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Установить значение параметра</summary>
    /// <param name="param">Параметр</param>
    /// <param name="val">Значение</param>
    protected virtual void SetParameterValue(IDbDataParameter param, object val)
    {
      int num1 = 23;
      while (true)
      {
        ParameterValue parameterValue;
        bool? nullable1;
        DateTime? nullable2;
        object obj1;
        int num2;
        int num3;
        object obj2;
        switch (num1)
        {
          case 1:
            num2 = 0;
            goto label_37;
          case 2:
            if (nullable1.Value)
            {
              num1 = 24;
              continue;
            }
            goto case 1;
          case 3:
            nullable2 = obj1 as DateTime?;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 4 : 20;
            continue;
          case 4:
            num3 = TransformationProviderBase.NOJUr0Wk4yRAgtTIJcKm((object) parameterValue) ? 1 : 0;
            goto label_34;
          case 5:
          case 9:
            TransformationProviderBase.faqmhCWkAQN7J5ou10Hy((object) param, obj1 ?? (object) DBNull.Value);
            num1 = 19;
            continue;
          case 6:
            TransformationProviderBase.yTSW84WkHO0WaqJ9RlU7((object) memoryStream, 0L, SeekOrigin.Begin);
            num1 = 15;
            continue;
          case 7:
            goto label_30;
          case 8:
            obj2 = val;
            break;
          case 10:
          case 17:
            if (obj1 is MemoryStream memoryStream)
            {
              num1 = 6;
              continue;
            }
            goto case 15;
          case 11:
            if (parameterValue != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 4 : 4;
              continue;
            }
            goto case 14;
          case 12:
            param.DbType = parameterValue.Type;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 3 : 13;
            continue;
          case 13:
            if (TransformationProviderBase.Fv8RMrWk7luZE01NIvBN((object) parameterValue) > 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
              continue;
            }
            goto label_24;
          case 14:
            num3 = 1;
            goto label_34;
          case 15:
            nullable1 = obj1 as bool?;
            num1 = 18;
            continue;
          case 16:
            obj2 = parameterValue.Value;
            break;
          case 18:
            if (!nullable1.HasValue)
            {
              num1 = 5;
              continue;
            }
            goto case 2;
          case 19:
            if (parameterValue != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 7 : 12;
              continue;
            }
            goto label_20;
          case 20:
            if (nullable2.HasValue)
            {
              num1 = 11;
              continue;
            }
            goto case 10;
          case 21:
label_15:
            obj1 = (object) TransformationProviderBase.BxitTtWk67XSbeXN0eHw(nullable2.Value);
            num1 = 10;
            continue;
          case 22:
            if (parameterValue != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 16 : 13;
              continue;
            }
            goto case 8;
          case 23:
            parameterValue = val as ParameterValue;
            num1 = 22;
            continue;
          case 24:
            num2 = 1;
            goto label_37;
          default:
            TransformationProviderBase.o1n0feWkxm2Or6iDOtSg((object) param, TransformationProviderBase.Fv8RMrWk7luZE01NIvBN((object) parameterValue));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 5 : 7;
            continue;
        }
        obj1 = obj2;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 3 : 3;
        continue;
label_34:
        if (num3 == 0)
        {
          num1 = 17;
          continue;
        }
        goto label_15;
label_37:
        obj1 = (object) num2;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 7 : 9;
      }
label_30:
      return;
label_24:
      return;
label_20:;
    }

    /// <summary>Получить список резервных слов</summary>
    /// <returns>Список резервных слов</returns>
    protected virtual List<string> GetReservedWords()
    {
      List<string> reservedWords = new List<string>();
      foreach (DataRow row in (InternalDataCollectionBase) (this.Connection is DbConnectionProxy connection ? connection.RealConnection : (DbConnection) this.Connection).GetSchema(DbMetaDataCollectionNames.ReservedWords).Rows)
        reservedWords.Add(row[z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108783874)].ToString());
      return reservedWords;
    }

    /// <summary>
    /// Заключить имя в кавычки, если это резервное слово или содержит недопустимые символы
    /// </summary>
    /// <param name="name">Имя</param>
    /// <returns>Обработанное имя</returns>
    protected abstract string QuoteIfNeeded(string name);

    private IDbCommand SetCommanTimeout(IDbCommand command)
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        int? nullable;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_8;
            case 2:
              TransformationProviderBase.q44cvLWk0Mm16n5R0uro((object) command, 30);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 1 : 1;
              continue;
            case 3:
            case 4:
              TransformationProviderBase.q44cvLWk0Mm16n5R0uro((object) command, nullable.Value);
              num2 = 8;
              continue;
            case 5:
              nullable = TransformationProviderBase.contextTimeout.Value;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
              continue;
            case 6:
              if (this.disposed)
                goto case 2;
              else
                goto label_4;
            case 7:
              goto label_5;
            case 8:
              goto label_12;
            default:
              if (nullable.HasValue)
              {
                num2 = 4;
                continue;
              }
              goto label_5;
          }
        }
label_4:
        num1 = 5;
        continue;
label_5:
        nullable = new int?(TransformationProviderBase.fIj2ULWkm3lXlJWek0Fe());
        num1 = 3;
      }
label_8:
      return command;
label_12:
      return command;
    }

    /// <summary>Выполнить SQL-скрипт</summary>
    /// <param name="sql">Текст скрипта</param>
    /// <param name="paramValues">Значения параметров</param>
    /// <returns>Результат</returns>
    public abstract int ExecuteNonQuery(string sql, Dictionary<string, object> paramValues = null);

    static TransformationProviderBase()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TransformationProviderBase.tgvGqqWkyo6TPjqmpyLW();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            TransformationProviderBase.contextTimeout = new AsyncLocal<int?>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool CCfsUDWTLbrDlCcL6m26() => TransformationProviderBase.cHPScIWTYiW9tIIJCVed == null;

    internal static TransformationProviderBase YRsw3TWTU85DIQkjtbXt() => TransformationProviderBase.cHPScIWTYiW9tIIJCVed;

    internal static ConnectionState P2P9XmWTsnBcWgmWvxXn([In] object obj0) => ((IDbConnection) obj0).State;

    internal static object iGIOPRWTc6WrtdreVfQF([In] object obj0, [In] IsolationLevel obj1) => (object) ((IDbConnection) obj0).BeginTransaction(obj1);

    internal static object yR4ue1WTzIqEJjlEpgoA([In] object obj0) => (object) ((IDbConnection) obj0).BeginTransaction();

    internal static void bQYYGSWkFZoOm4tx7dIr([In] object obj0) => ((IDbTransaction) obj0).Rollback();

    internal static object naC2DvWkBEDh8suK3AEU() => (object) Logger.Log;

    internal static object MIPAnEWkWRtMxO3d4sSF(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object oCOtPFWko6gMsYhxQLNw([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void NpmyoWWkbsD7Nd7ZxMN1([In] object obj0) => ((IDbTransaction) obj0).Commit();

    internal static object wdtSC0Wkhna9PCCLPCiL([In] object obj0) => (object) ((ISession) obj0).Connection;

    internal static void gyHoV6WkG7FAcuOp6eeZ([In] object obj0) => ((IDbConnection) obj0).Close();

    internal static void aLCNv3WkEvsEintP5S03([In] object obj0, [In] object obj1) => ((TransformationProviderBase) obj0).BeforeOpenConnection((IDbConnection) obj1);

    internal static bool PU5hsuWkfwKQxAXQQxYJ() => ContextVars.HasImpl;

    internal static void YPSG1PWkQELJAKYRBPQe([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object MRVus9WkCWvqPVHvccW4([In] object obj0, [In] object obj1) => (object) ((TransformationProviderBase) obj0).QuoteIfNeeded((string) obj1);

    internal static object IuEbNXWkv48lWfRbX0Z9([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object LoLoFmWk80ZjhXRl6Uqx([In] object obj0, [In] object obj1) => (object) ((TransformationProviderBase) obj0).BuildCommand((string) obj1);

    internal static object AV3P0rWkZIhaltebkXWj([In] object obj0, [In] CommandBehavior obj1) => (object) ((IDbCommand) obj0).ExecuteReader(obj1);

    internal static object jBmHWCWku6i2CCw0gHw1([In] object obj0) => (object) ((IDataReader) obj0).GetSchemaTable();

    internal static void WmZMXtWkIGCdtYKEX32M([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object df5UmEWkVKRvkpWQAtqP([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static void WqUlsAWkSNiHJh6ObqZL([In] object obj0) => ((System.Action) obj0)();

    internal static object Bsgr8EWkiRAF8KTAaTy1(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      bool quoteIfNeededSortExpression)
    {
      return (object) ((TransformationProviderBase) obj0).SetupFetchOptions((string) obj1, (FetchOptions) obj2, quoteIfNeededSortExpression);
    }

    internal static void qaRiPbWkRbv0uPUG9H7i([In] object obj0, [In] object obj1) => Contract.NotNull(obj0, (string) obj1);

    internal static object adrtxUWkqIth09awhnVy([In] object obj0, [In] object obj1) => (object) ((ISessionProvider) obj0).GetSession((string) obj1);

    internal static object SOO2xCWkKeMySd6OvdFB([In] object obj0) => (object) ((IDbConnection) obj0).CreateCommand();

    internal static void MJVlT4WkX57aHO5ZTXvd([In] object obj0, [In] object obj1) => ((IDbCommand) obj0).CommandText = (string) obj1;

    internal static void AhRWAtWkTZFAK5DaviDd([In] object obj0, [In] CommandType obj1) => ((IDbCommand) obj0).CommandType = obj1;

    internal static object DCDYmIWkkMvwVrrjo7Gj([In] object obj0) => (object) ((ISession) obj0).Transaction;

    internal static void nP73RlWkn8pXXNaqTocH([In] object obj0, [In] object obj1) => ((ITransaction) obj0).Enlist((DbCommand) obj1);

    internal static object Rj8FVAWkO8FtT6hH4yJr([In] object obj0) => (object) ((DataTable) obj0).Columns;

    internal static object JfU09EWk23PoHtZPpqNJ([In] object obj0, [In] int obj1) => (object) ((DataColumnCollection) obj0)[obj1];

    internal static Type aUiyAMWkeXJbQfbm8wTR([In] object obj0) => ((DataColumn) obj0).DataType;

    internal static Type YuHVNFWkPBS0BSYvffX6([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool P5CK9jWk11mXwUGGsXKQ([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object jTrri8WkNZyXwRaLN4DS([In] object obj0, [In] int obj1) => (object) ((DataRowCollection) obj0)[obj1];

    internal static DateTime pFkxenWk32S2IuXWXev5(DateTime serverDateTime) => serverDateTime.ToRuntimeDateTimeFromServer();

    internal static void RaflpWWkpULR8K01TwxR([In] object obj0, [In] int obj1, [In] object obj2) => ((DataRow) obj0)[obj1] = obj2;

    internal static int h4OtFDWkakirc506su4S([In] object obj0) => ((InternalDataCollectionBase) obj0).Count;

    internal static void dTRsd7WkDrlg2bVOqQvp([In] object obj0, [In] object obj1, [In] object obj2) => ((TransformationProviderBase) obj0).SetParameterValue((IDbDataParameter) obj1, obj2);

    internal static object vOreSgWktg4dFUE3PC3B([In] object obj0) => (object) ((IDbCommand) obj0).Parameters;

    internal static int bjJtGtWkw7lwdYSRJ6UB([In] object obj0, [In] object obj1) => ((IList) obj0).Add(obj1);

    internal static bool NOJUr0Wk4yRAgtTIJcKm([In] object obj0) => ((ParameterValue) obj0).ConvertToDbTime;

    internal static DateTime BxitTtWk67XSbeXN0eHw(DateTime runtimeDateTime) => runtimeDateTime.ToServerDateTime();

    internal static long yTSW84WkHO0WaqJ9RlU7([In] object obj0, [In] long obj1, [In] SeekOrigin obj2) => ((Stream) obj0).Seek(obj1, obj2);

    internal static void faqmhCWkAQN7J5ou10Hy([In] object obj0, [In] object obj1) => ((IDataParameter) obj0).Value = obj1;

    internal static int Fv8RMrWk7luZE01NIvBN([In] object obj0) => ((ParameterValue) obj0).Size;

    internal static void o1n0feWkxm2Or6iDOtSg([In] object obj0, [In] int obj1) => ((IDbDataParameter) obj0).Size = obj1;

    internal static void q44cvLWk0Mm16n5R0uro([In] object obj0, [In] int obj1) => ((IDbCommand) obj0).CommandTimeout = obj1;

    internal static int fIj2ULWkm3lXlJWek0Fe() => TransformationProviderBase.DefaultCommandTimeout;

    internal static void tgvGqqWkyo6TPjqmpyLW() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
