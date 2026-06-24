// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.Migrator.Providers.TransformationProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Connection;
using NHibernate.Engine;
using NHibernate.Id;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime.Db.Migrator.Providers
{
  /// <summary>Провайдер преобразования БД (Асинхронная часть)</summary>
  /// <summary>
  /// Провайдер преобразования БД (Базовые методы, общие между синхронной и асинхронной частями)
  /// </summary>
  /// <summary>Провайдер преобразования БД</summary>
  public abstract class TransformationProvider : 
    TransformationProviderBase,
    ITransformationProviderAsync,
    ITransformationProvider,
    ITransformationProviderBase,
    IDisposable
  {
    /// <summary>Префикс для параметров в sql-запросах</summary>
    protected static readonly string ParamPrefix;
    /// <summary>
    /// Специальный таймаут для длительных и безопасных операций
    /// </summary>
    public const int DefaultLongCommandTimeout = 0;
    /// <summary>Max Lo для последовательности по умолчанию</summary>
    public const int DefaultSequenceMaxLo = 100;
    public const int DefaultRetryOnDeadlockCount = 20;
    public const int DefaultRetryOnDeadlockInterval = 300;
    protected readonly ForeignKeyConstraintMapper constraintMapper;
    private Dictionary<string, List<Pair<string, string>>> temporaryColumnNames;
    private Dictionary<KeyValuePair<string, string>, string> deletingColumnNames;
    private Regex createIndexPattern;
    private ConcurrentDictionary<string, IIdentifierGenerator> generatorMap;
    internal static TransformationProvider wcFITEWXPCkPiH2YAHD9;

    /// <inheritdoc />
    public virtual Task<IDataReader> ExecuteQueryAsync(
      string sql,
      Dictionary<string, object> paramValues = null,
      CancellationToken cancellationToken = default (CancellationToken))
    {
      return this.ExecuteQueryBaseAsync(sql, paramValues, true, cancellationToken).AsTask();
    }

    /// <inheritdoc />
    public virtual Task<int> ExecuteNonQueryAsync(
      string sql,
      Dictionary<string, object> paramValues = null,
      CancellationToken cancellationToken = default (CancellationToken))
    {
      paramValues = paramValues ?? new Dictionary<string, object>();
      return this.ExecuteNonQueryBaseAsync(sql, (IReadOnlyList<string>) paramValues.Keys.ToReadOnlyCollection<string>(), (IReadOnlyList<object>) paramValues.Values.ToReadOnlyCollection<object>(), true, cancellationToken).AsTask();
    }

    /// <inheritdoc />
    public virtual Task<object> ExecuteScalarAsync(
      string sql,
      Dictionary<string, object> paramValues = null,
      CancellationToken cancellationToken = default (CancellationToken))
    {
      return this.ExecuteScalarBaseAsync(sql, paramValues, true, cancellationToken).AsTask();
    }

    /// <inheritdoc />
    public virtual Task<int> InsertAsync(
      string table,
      string[] columns,
      object[] values,
      CancellationToken cancellationToken = default (CancellationToken))
    {
      return this.InsertAsync(table, columns, values, false, cancellationToken);
    }

    /// <inheritdoc />
    public virtual Task<int> InsertAsync(
      string table,
      string[] columns,
      object[] values,
      bool isNeedInsertId,
      CancellationToken cancellationToken = default (CancellationToken))
    {
      return this.InsertBaseAsync(table, (IReadOnlyList<string>) columns, (IReadOnlyList<object>) values, isNeedInsertId, true, cancellationToken).AsTask();
    }

    /// <inheritdoc />
    public virtual Task<int> InsertAsync(
      string table,
      string[] columns,
      string selectColName,
      string selectFrom,
      bool isNeedInsertId,
      Dictionary<string, object> paramValues = null,
      CancellationToken cancellationToken = default (CancellationToken))
    {
      return this.ExecuteNonQueryAsync(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536806696) + table + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1925118608 << 2 ^ -889483926) + string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~541731958 ^ -541728885), ((IEnumerable<string>) columns).Select<string, string>((System.Func<string, string>) (i => ((EleWise.ELMA.Runtime.Db.Migrator.Providers.Dialect) TransformationProvider.c8afbIWTVMx7l6O9RAYA((object) this)).QuoteIfNeeded(i)))) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099664375) + selectColName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824262423) + selectFrom, paramValues, cancellationToken);
    }

    /// <inheritdoc />
    public virtual Task<int> UpdateAsync(
      string table,
      string[] columns,
      object[] values,
      string where,
      Dictionary<string, object> paramValues = null,
      CancellationToken cancellationToken = default (CancellationToken))
    {
      return this.UpdateBaseAsync(table, (IReadOnlyList<string>) columns, (IReadOnlyList<object>) values, where, paramValues, true, cancellationToken).AsTask();
    }

    /// <inheritdoc />
    public async Task ExecuteWithTimeoutAsync(int timeout, Func<Task> action)
    {
      int num1 = 4;
      TransformationProvider transformationProvider;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 5 : 0;
            continue;
          case 2:
label_5:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 1 : 0;
            continue;
          case 3:
            transformationProvider = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
            continue;
          case 4:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = 3;
            continue;
          case 5:
            goto label_47;
          default:
            try
            {
              int num3;
              if (num2 == 0)
                num3 = 4;
              else
                goto label_11;
label_9:
              int num4 = num3;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    goto label_13;
                  case 2:
                  case 4:
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 1;
                    continue;
                  case 3:
                    goto label_11;
                  default:
                    goto label_5;
                }
              }
label_13:
              int? previousTimeout;
              try
              {
                int num5;
                if (num2 != 0)
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 3 : 3;
                else
                  goto label_18;
label_15:
                TaskAwaiter taskAwaiter;
                TaskAwaiter awaiter;
                while (true)
                {
                  object obj;
                  switch (num5)
                  {
                    case 1:
                      taskAwaiter = new TaskAwaiter();
                      num5 = 5;
                      continue;
                    case 2:
                      goto label_5;
                    case 3:
                      Func<Task> func = action;
                      if (func == null)
                      {
                        num5 = 10;
                        continue;
                      }
                      obj = (object) func();
                      break;
                    case 4:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, TransformationProvider.\u003CExecuteWithTimeoutAsync\u003Ed__7>(ref awaiter, this);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 2 : 8;
                      continue;
                    case 5:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = -1;
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 3 : 7;
                      continue;
                    case 6:
                      goto label_18;
                    case 7:
                    case 11:
                      awaiter.GetResult();
                      num5 = 2;
                      continue;
                    case 8:
                      goto label_44;
                    case 9:
                      // ISSUE: reference to a compiler-generated method
                      obj = TransformationProvider.\u003CExecuteWithTimeoutAsync\u003Ed__7.xLSXcIQ4EPcBQZYunndC();
                      goto label_33;
                    case 10:
                      obj = (object) null;
                      break;
                    case 12:
                      if (awaiter.IsCompleted)
                      {
                        num5 = 11;
                        continue;
                      }
                      goto default;
                    case 13:
                      taskAwaiter = awaiter;
                      num5 = 4;
                      continue;
                    default:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = 0;
                      num5 = 13;
                      continue;
                  }
                  if (obj == null)
                  {
                    num5 = 9;
                    continue;
                  }
label_33:
                  // ISSUE: reference to a compiler-generated method
                  awaiter = TransformationProvider.\u003CExecuteWithTimeoutAsync\u003Ed__7.jFnwAMQ4fnF4xA937RgE(obj);
                  num5 = 12;
                }
label_44:
                return;
label_18:
                awaiter = taskAwaiter;
                num5 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
                {
                  num5 = 0;
                  goto label_15;
                }
                else
                  goto label_15;
              }
              finally
              {
                if (num2 < 0)
                {
                  int num6 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
                    num6 = 1;
                  while (true)
                  {
                    switch (num6)
                    {
                      case 1:
                        // ISSUE: explicit non-virtual call
                        __nonvirtual (transformationProvider.SetCurrentContextTimeout(previousTimeout));
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_39;
                    }
                  }
                }
label_39:;
              }
label_11:
              // ISSUE: explicit non-virtual call
              previousTimeout = __nonvirtual (transformationProvider.SetCurrentContextTimeout(new int?(timeout)));
              num3 = 2;
              goto label_9;
            }
            catch (Exception ex)
            {
              int num7 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
                num7 = 0;
              while (true)
              {
                switch (num7)
                {
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num7 = 2;
                    continue;
                  case 2:
                    goto label_40;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 1;
                    continue;
                }
              }
label_40:
              return;
            }
        }
      }
label_47:;
    }

    /// <inheritdoc />
    public abstract Task BulkInsertAsync(
      string tableName,
      DataTable data,
      CancellationToken cancellationToken = default (CancellationToken));

    /// <inheritdoc />
    public abstract Task BulkInsertAsync(
      string tableName,
      DataTable data,
      bool shouldGenerateId,
      CancellationToken cancellationToken = default (CancellationToken));

    /// <inheritdoc />
    public abstract Task BulkUpdateAsync(
      string tableName,
      DataTable data,
      CancellationToken cancellationToken = default (CancellationToken));

    /// <inheritdoc />
    public abstract Task BulkUpdateAsync(
      string tableName,
      DataTable data,
      string keyColumn,
      CancellationToken cancellationToken = default (CancellationToken));

    /// <inheritdoc />
    public abstract Task BulkUpdateAsync(
      string tableName,
      DataTable data,
      List<ColumnLink> keyColumns,
      CancellationToken cancellationToken = default (CancellationToken));

    /// <inheritdoc />
    public virtual Task<int> BulkDeleteAsync(
      string table,
      string where,
      Dictionary<string, object> paramValues = null,
      CancellationToken cancellationToken = default (CancellationToken))
    {
      return this.BulkDeleteBaseAsync(table, where, paramValues, true, cancellationToken).AsTask();
    }

    /// <inheritdoc />
    public abstract Task<int> BulkDeleteAsync(
      BulkDeleteArg arg,
      CancellationToken cancellationToken = default (CancellationToken));

    /// <summary>Выполнить SQL-скрипт</summary>
    /// <param name="sql">SQL-скрипт</param>
    /// <param name="paramNames">Названия параметров</param>
    /// <param name="paramValues">Значения параметров</param>
    /// <param name="isAsync"><c>true</c> если выполнять асинхронно</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Результат выполнения</returns>
    private async ValueTask<int> ExecuteNonQueryBaseAsync(
      string sql,
      IReadOnlyList<string> paramNames,
      IReadOnlyList<object> paramValues,
      bool isAsync,
      CancellationToken cancellationToken)
    {
      int num1 = 1;
      int num2;
      int result;
      TransformationProvider transformationProvider1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
            continue;
          case 2:
label_3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = 5;
            continue;
          case 3:
            try
            {
              int num3;
              if (num2 == 0)
                num3 = 5;
              else
                goto label_9;
label_7:
              IDbCommand cmd;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    cmd = (IDbCommand) TransformationProvider.\u003CExecuteNonQueryBaseAsync\u003Ed__15.VKfYJXQ4unDAOK2xn3qD((object) transformationProvider1, (object) sql);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 4 : 4;
                    continue;
                  case 2:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    TransformationProvider.\u003CExecuteNonQueryBaseAsync\u003Ed__15.IYioe4Q4ZJxNCjKeBsgC((object) sql, TransformationProvider.\u003CExecuteNonQueryBaseAsync\u003Ed__15.oUYqJKQ489eSTREeIpyr(1574260816 ^ 1574219168));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 1 : 0;
                    continue;
                  case 3:
                    goto label_9;
                  case 4:
                  case 5:
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_12;
                }
              }
label_12:
              try
              {
                int num4;
                if (num2 == 0)
                {
                  num4 = 20;
                  goto label_16;
                }
                else
                  goto label_32;
label_15:
                int num5;
                num4 = num5;
label_16:
                string key;
                bool hasPoint;
                int index;
                string paramName;
                object paramValue;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_38;
                    case 2:
                      hasPoint = false;
                      num4 = 14;
                      continue;
                    case 3:
                      paramName = paramNames[index];
                      num4 = 13;
                      continue;
                    case 4:
                      // ISSUE: reference to a compiler-generated method
                      TransformationProvider.\u003CExecuteNonQueryBaseAsync\u003Ed__15.PGhaZVQ4Il4QE6SZdqiP((object) transformationProvider1, (object) cmd, (object) paramName, paramValue);
                      num4 = 9;
                      continue;
                    case 5:
                      if (paramValue is Generator generator)
                      {
                        num4 = 8;
                        continue;
                      }
                      goto case 4;
                    case 6:
                    case 8:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      cmd.CommandText = (string) TransformationProvider.\u003CExecuteNonQueryBaseAsync\u003Ed__15.L27hYgQ4qqemhh7hBdHA(TransformationProvider.\u003CExecuteNonQueryBaseAsync\u003Ed__15.pWFHvgQ4VLCcyPsPoZp9((object) cmd), TransformationProvider.\u003CExecuteNonQueryBaseAsync\u003Ed__15.sKlLfaQ4iBMVD9NulkVV(TransformationProvider.\u003CExecuteNonQueryBaseAsync\u003Ed__15.Ax7lcmQ4SH3tQ4VftvBT((object) transformationProvider1), (object) paramName), TransformationProvider.\u003CExecuteNonQueryBaseAsync\u003Ed__15.DJLZpxQ4REL3NGr96Di0((object) generator));
                      num4 = 16;
                      continue;
                    case 7:
                    case 11:
                    case 17:
                      key = SavePointHelper.GetSavePointKey();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 2 : 2;
                      continue;
                    case 9:
                    case 16:
                      ++index;
                      num4 = 21;
                      continue;
                    case 10:
                      goto label_25;
                    case 12:
                      goto label_27;
                    case 13:
                      paramValue = paramValues[index];
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
                      continue;
                    case 14:
                    case 20:
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 0;
                      continue;
                    case 15:
                    case 21:
                      // ISSUE: reference to a compiler-generated method
                      if (index >= TransformationProvider.\u003CExecuteNonQueryBaseAsync\u003Ed__15.IryELBQ4Krb90C4GxVkq((object) paramNames))
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 7 : 5;
                        continue;
                      }
                      goto case 18;
                    case 18:
                      if (paramValues.Count <= index)
                        goto case 9;
                      else
                        goto label_30;
                    case 19:
                      goto label_32;
                    default:
                      if (paramValues[index] != null)
                      {
                        num4 = 5;
                        continue;
                      }
                      goto case 4;
                  }
                }
label_30:
                num5 = 3;
                goto label_15;
label_38:
                try
                {
                  int num6;
                  if (num2 != 0)
                    num6 = 9;
                  else
                    goto label_48;
label_40:
                  TaskAwaiter<int> taskAwaiter;
                  TaskAwaiter<int> awaiter;
                  int num7;
                  while (true)
                  {
                    switch (num6)
                    {
                      case 1:
                        taskAwaiter = awaiter;
                        num6 = 4;
                        continue;
                      case 2:
                      case 17:
                        int num8 = num7;
                        if (hasPoint)
                        {
                          transformationProvider1.ReleaseSavePoint(key, cmd);
                          hasPoint = false;
                        }
                        result = num8;
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 14;
                        continue;
                      case 3:
                        if (cmd is DbCommand dbCommand)
                        {
                          num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 6 : 8;
                          continue;
                        }
                        goto case 5;
                      case 4:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, TransformationProvider.\u003CExecuteNonQueryBaseAsync\u003Ed__15>(ref awaiter, this);
                        num6 = 15;
                        continue;
                      case 5:
                      case 7:
                        // ISSUE: reference to a compiler-generated method
                        num7 = TransformationProvider.\u003CExecuteNonQueryBaseAsync\u003Ed__15.SgiikIQ4XEQ3YrG48wRl((object) cmd);
                        num6 = 2;
                        continue;
                      case 6:
                        if (awaiter.IsCompleted)
                        {
                          num6 = 13;
                          continue;
                        }
                        goto case 11;
                      case 8:
                        awaiter = dbCommand.ExecuteNonQueryAsync(cancellationToken).GetAwaiter();
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 6;
                        continue;
                      case 9:
                        hasPoint = transformationProvider1.SavePoint(key, cmd);
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
                        continue;
                      case 10:
                        goto label_48;
                      case 11:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003E1__state = num2 = 0;
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 1 : 0;
                        continue;
                      case 12:
                      case 13:
                        num7 = awaiter.GetResult();
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 7 : 17;
                        continue;
                      case 14:
                        goto label_3;
                      case 15:
                        goto label_81;
                      case 16:
                        taskAwaiter = new TaskAwaiter<int>();
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 13 : 18;
                        continue;
                      case 18:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003E1__state = num2 = -1;
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 12 : 2;
                        continue;
                      default:
                        if (!isAsync)
                        {
                          num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 5 : 5;
                          continue;
                        }
                        goto case 3;
                    }
                  }
label_81:
                  return;
label_48:
                  awaiter = taskAwaiter;
                  num6 = 16;
                  goto label_40;
                }
                catch (Exception ex1)
                {
                  int num9 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
                    num9 = 0;
                  while (true)
                  {
                    switch (num9)
                    {
                      case 1:
                        TransformationProvider transformationProvider2 = transformationProvider1;
                        Exception ex2 = ex1;
                        IDbCommand dbCommand = cmd;
                        IDbConnection connection = dbCommand == null ? (IDbConnection) null : dbCommand.Connection;
                        transformationProvider2.ProcessException(ex2, connection);
                        num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 3 : 1;
                        continue;
                      case 2:
                        transformationProvider1.RollBackSavePoint(key, cmd);
                        num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 1 : 1;
                        continue;
                      case 3:
                        goto label_68;
                      default:
                        if (hasPoint)
                        {
                          num9 = 2;
                          continue;
                        }
                        goto case 1;
                    }
                  }
label_68:
                  // ISSUE: reference to a compiler-generated method
                  throw new DataException(EleWise.ELMA.SR.T((string) TransformationProvider.\u003CExecuteNonQueryBaseAsync\u003Ed__15.oUYqJKQ489eSTREeIpyr(-1839087379 - 334718690 ^ 2120951631), (object) sql), ex1);
                }
label_25:
                index = 0;
                num4 = 15;
                goto label_16;
label_27:
                if (paramValues == null)
                {
                  num4 = 11;
                  goto label_16;
                }
                else
                  goto label_25;
label_32:
                if (paramNames == null)
                {
                  num5 = 17;
                  goto label_15;
                }
                else
                  goto label_27;
              }
              finally
              {
                if (num2 < 0)
                {
                  int num10 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
                    num10 = 0;
                  while (true)
                  {
                    switch (num10)
                    {
                      case 1:
                        goto label_77;
                      case 2:
                        // ISSUE: reference to a compiler-generated method
                        TransformationProvider.\u003CExecuteNonQueryBaseAsync\u003Ed__15.UBjVGJQ4TrJiQoEgeWj8((object) cmd);
                        num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 1 : 0;
                        continue;
                      default:
                        if (cmd != null)
                        {
                          num10 = 2;
                          continue;
                        }
                        goto label_77;
                    }
                  }
                }
label_77:;
              }
label_9:
              cancellationToken.ThrowIfCancellationRequested();
              num3 = 2;
              goto label_7;
            }
            catch (Exception ex)
            {
              int num11 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
                num11 = 1;
              while (true)
              {
                switch (num11)
                {
                  case 0:
                    goto label_73;
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 2;
                    continue;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_67;
                }
              }
label_73:
              return;
label_67:
              return;
            }
          case 4:
            goto label_84;
          case 5:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 3 : 4;
            continue;
          default:
            transformationProvider1 = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 3 : 1;
            continue;
        }
      }
label_84:;
    }

    /// <summary>Вставить данные в таблицу</summary>
    /// <param name="table">Имя таблицы</param>
    /// <param name="columns">Имена колонок</param>
    /// <param name="values">Значения колонок в том же порядке, что и имена</param>
    /// <param name="isNeedInsertId"><c>true</c> если необходимо ли генерировать и добавлять Id к вставляемым значениям (для MS SQL не используется)</param>
    /// <param name="isAsync"><c>true</c> если выполнять асинхронно</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Результат</returns>
    private async ValueTask<int> InsertBaseAsync(
      string table,
      IReadOnlyList<string> columns,
      IReadOnlyList<object> values,
      bool isNeedInsertId,
      bool isAsync,
      CancellationToken cancellationToken = default (CancellationToken))
    {
      int num1 = 3;
      TransformationProvider transformationProvider1;
      int num2;
      int result1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_66;
          case 2:
            transformationProvider1 = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
            continue;
          case 3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = 2;
            continue;
          case 4:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 1;
            continue;
          case 5:
label_4:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 4;
            continue;
          default:
            try
            {
              int num3;
              if (num2 == 0)
                num3 = 19;
              else
                goto label_40;
label_9:
              while (true)
              {
                TaskAwaiter taskAwaiter;
                List<string> stringList;
                string column;
                string key;
                List<object> objectList;
                long num4;
                int index;
                object obj;
                Dictionary<string, string> dictionary;
                TaskAwaiter awaiter;
                int result;
                TransformationProvider transformationProvider;
                string sql;
                Dictionary<string, object> @params;
                CancellationToken cancellationToken1;
                switch (num3)
                {
                  case 1:
                  case 15:
                    dictionary = new Dictionary<string, string>();
                    num3 = 32;
                    continue;
                  case 2:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    TransformationProvider.\u003CInsertBaseAsync\u003Ed__16.wrfbtbQ4aZ1lyuU56gdt((object) values, TransformationProvider.\u003CInsertBaseAsync\u003Ed__16.KPwc6tQ43leWKu2bn52X(-1978478350 ^ -1978423542));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 4 : 13;
                    continue;
                  case 3:
                    taskAwaiter = new TaskAwaiter();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 11 : 23;
                    continue;
                  case 4:
                    transformationProvider = this;
                    num3 = 47;
                    continue;
                  case 5:
                    obj = values[index];
                    num3 = 25;
                    continue;
                  case 6:
                    taskAwaiter = awaiter;
                    num3 = 50;
                    continue;
                  case 7:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    sql = (string) TransformationProvider.\u003CInsertBaseAsync\u003Ed__16.PGeVhLQ4yItEULRdArAw((object) new string[7]
                    {
                      (string) TransformationProvider.\u003CInsertBaseAsync\u003Ed__16.KPwc6tQ43leWKu2bn52X(-882126494 ^ -882234336),
                      (string) TransformationProvider.\u003CInsertBaseAsync\u003Ed__16.KgRD7HQ405dnmaMiPWgR((object) transformationProvider1, (object) table),
                      (string) TransformationProvider.\u003CInsertBaseAsync\u003Ed__16.KPwc6tQ43leWKu2bn52X(-1822890472 ^ -1822916302),
                      string.Join((string) TransformationProvider.\u003CInsertBaseAsync\u003Ed__16.KPwc6tQ43leWKu2bn52X(277947046 - -1479185048 ^ 1757133116), (IEnumerable<string>) dictionary.Keys),
                      (string) TransformationProvider.\u003CInsertBaseAsync\u003Ed__16.KPwc6tQ43leWKu2bn52X(1669212571 ^ 1669026877),
                      string.Join((string) TransformationProvider.\u003CInsertBaseAsync\u003Ed__16.KPwc6tQ43leWKu2bn52X(-710283084 ^ -537863435 ^ 173614659), (IEnumerable<string>) dictionary.Values),
                      (string) TransformationProvider.\u003CInsertBaseAsync\u003Ed__16.KPwc6tQ43leWKu2bn52X(-1876063057 ^ -1876061421)
                    });
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 44 : 35;
                    continue;
                  case 8:
                    // ISSUE: reference to a compiler-generated method
                    Contract.ArgumentNotNull((object) columns, (string) TransformationProvider.\u003CInsertBaseAsync\u003Ed__16.KPwc6tQ43leWKu2bn52X(-675505729 ^ -675458913));
                    num3 = 2;
                    continue;
                  case 9:
                    goto label_63;
                  case 10:
                    @params[key] = obj;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 26 : 5;
                    continue;
                  case 11:
                  case 37:
                    column = columns[index];
                    num3 = 5;
                    continue;
                  case 12:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    dictionary[(string) TransformationProvider.\u003CInsertBaseAsync\u003Ed__16.KgRD7HQ405dnmaMiPWgR((object) transformationProvider1, (object) column)] = (string) TransformationProvider.\u003CInsertBaseAsync\u003Ed__16.xgYkbdQ4xHfhqHxfbMLy(TransformationProvider.\u003CInsertBaseAsync\u003Ed__16.OEipRvQ4mJ0ZVgPiENXY((object) transformationProvider1), (object) key);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 10 : 6;
                    continue;
                  case 13:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    TransformationProvider.\u003CInsertBaseAsync\u003Ed__16.JuMVb0Q4wAZT5xfLE683(TransformationProvider.\u003CInsertBaseAsync\u003Ed__16.j9w4SxQ4DDVLb8MXYILc((object) columns) == TransformationProvider.\u003CInsertBaseAsync\u003Ed__16.rsIdQ1Q4tlSTJSaP6psB((object) values), TransformationProvider.\u003CInsertBaseAsync\u003Ed__16.KPwc6tQ43leWKu2bn52X(-1998538950 ^ -1998206276));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 46 : 43;
                    continue;
                  case 14:
                    stringList = new List<string>((IEnumerable<string>) columns);
                    num3 = 45;
                    continue;
                  case 16:
                    values = (IReadOnlyList<object>) objectList.ToArray();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 1;
                    continue;
                  case 17:
                    if (!awaiter.IsCompleted)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 15 : 33;
                      continue;
                    }
                    goto case 20;
                  case 18:
                  case 36:
                    // ISSUE: reference to a compiler-generated method
                    if (index < TransformationProvider.\u003CInsertBaseAsync\u003Ed__16.j9w4SxQ4DDVLb8MXYILc((object) columns))
                    {
                      num3 = 11;
                      continue;
                    }
                    goto case 21;
                  case 19:
                  case 35:
                    awaiter = taskAwaiter;
                    num3 = 3;
                    continue;
                  case 20:
                    awaiter.GetResult();
                    num3 = 43;
                    continue;
                  case 21:
                    result = 0;
                    num3 = 7;
                    continue;
                  case 22:
                    // ISSUE: reference to a compiler-generated method
                    num4 = (long) TransformationProvider.\u003CInsertBaseAsync\u003Ed__16.EIc5plQ44JgtGb4bj5Ya((object) transformationProvider1, 1, (object) table)[0];
                    num3 = 39;
                    continue;
                  case 23:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = 20;
                    continue;
                  case 24:
                    // ISSUE: reference to a compiler-generated method
                    dictionary[transformationProvider1.QuoteIfNeeded(column)] = (string) TransformationProvider.\u003CInsertBaseAsync\u003Ed__16.zVgapLQ4AJ9VJBB1wg2P((object) expressionParameter);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 16 : 31;
                    continue;
                  case 25:
                    if (obj is SqlExpressionParameter expressionParameter)
                    {
                      num3 = 24;
                      continue;
                    }
                    break;
                  case 26:
                  case 31:
                    ++index;
                    num3 = 18;
                    continue;
                  case 27:
                    // ISSUE: reference to a compiler-generated method
                    if (!columns.Contains<string>((string) TransformationProvider.\u003CInsertBaseAsync\u003Ed__16.KPwc6tQ43leWKu2bn52X(~-397266137 ^ 397233542)))
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 1 : 14;
                      continue;
                    }
                    goto case 1;
                  case 28:
                    cancellationToken1.ThrowIfCancellationRequested();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 27 : 38;
                    continue;
                  case 29:
                  case 43:
                    result1 = result;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 41 : 48;
                    continue;
                  case 30:
                    // ISSUE: explicit non-virtual call
                    // ISSUE: reference to a compiler-generated method
                    awaiter = TransformationProvider.\u003CInsertBaseAsync\u003Ed__16.lpkHg6Q4MPR4PWP5W004((object) __nonvirtual (transformationProvider1.ExecuteWithTimeoutAsync(0, (Func<Task>) (() =>
                    {
                      int num5 = 5;
                      AsyncTaskMethodBuilder tBuilder;
                      // ISSUE: variable of a compiler-generated type
                      TransformationProvider.\u003C\u003Ec__DisplayClass16_0.\u003C\u003CInsertBaseAsync\u003Eb__0\u003Ed stateMachine;
                      while (true)
                      {
                        switch (num5)
                        {
                          case 1:
                            // ISSUE: reference to a compiler-generated field
                            stateMachine.\u003C\u003E1__state = -1;
                            num5 = 2;
                            continue;
                          case 2:
                            // ISSUE: reference to a compiler-generated field
                            tBuilder = stateMachine.\u003C\u003Et__builder;
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
                            continue;
                          case 3:
                            goto label_5;
                          case 4:
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated method
                            stateMachine.\u003C\u003Et__builder = TransformationProvider.\u003C\u003Ec__DisplayClass16_0.Ctn1mkQ4e3aqBe1fC9BT();
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 1;
                            continue;
                          case 5:
                            // ISSUE: reference to a compiler-generated field
                            stateMachine.\u003C\u003E4__this = (object) this;
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 4 : 2;
                            continue;
                          default:
                            tBuilder.Start<TransformationProvider.\u003C\u003Ec__DisplayClass16_0.\u003C\u003CInsertBaseAsync\u003Eb__0\u003Ed>(ref stateMachine);
                            num5 = 3;
                            continue;
                        }
                      }
label_5:
                      // ISSUE: reference to a compiler-generated field
                      return stateMachine.\u003C\u003Et__builder.Task;
                    }))));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 17 : 14;
                    continue;
                  case 32:
                    @params = new Dictionary<string, object>();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 34 : 7;
                    continue;
                  case 33:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 6 : 5;
                    continue;
                  case 34:
                    index = 0;
                    num3 = 36;
                    continue;
                  case 38:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    TransformationProvider.\u003CInsertBaseAsync\u003Ed__16.u4EUilQ4pJ46Uy2jJKgE((object) table, TransformationProvider.\u003CInsertBaseAsync\u003Ed__16.KPwc6tQ43leWKu2bn52X(--1360331293 ^ 1360329983));
                    num3 = 8;
                    continue;
                  case 39:
                    objectList.Add((object) num4);
                    num3 = 49;
                    continue;
                  case 40:
                    goto label_40;
                  case 41:
                    // ISSUE: explicit non-virtual call
                    __nonvirtual (transformationProvider1.ExecuteWithTimeout(0, (System.Action) (() =>
                    {
                      int num6 = 1;
                      while (true)
                      {
                        switch (num6)
                        {
                          case 0:
                            goto label_2;
                          case 1:
                            result = transformationProvider.ExecuteNonQuery(sql, @params);
                            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
                            continue;
                          default:
                            goto label_4;
                        }
                      }
label_2:
                      return;
label_4:;
                    })));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 29 : 11;
                    continue;
                  case 42:
                    // ISSUE: reference to a compiler-generated method
                    columns = (IReadOnlyList<string>) TransformationProvider.\u003CInsertBaseAsync\u003Ed__16.Kpr7kOQ4Hi6ef0bWwZmo((object) stringList);
                    num3 = 16;
                    continue;
                  case 44:
                    if (isAsync)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 30 : 20;
                      continue;
                    }
                    goto case 41;
                  case 45:
                    objectList = new List<object>((IEnumerable<object>) values);
                    num3 = 22;
                    continue;
                  case 46:
                    if (!isNeedInsertId)
                    {
                      num3 = 15;
                      continue;
                    }
                    goto case 27;
                  case 47:
                    cancellationToken1 = cancellationToken;
                    num3 = 28;
                    continue;
                  case 48:
                    goto label_4;
                  case 49:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    stringList.Add((string) TransformationProvider.\u003CInsertBaseAsync\u003Ed__16.aqYY1lQ46Cntxu2ExYpn((object) transformationProvider1.Dialect, TransformationProvider.\u003CInsertBaseAsync\u003Ed__16.KPwc6tQ43leWKu2bn52X(825385222 ^ 825417816)));
                    num3 = 42;
                    continue;
                  case 50:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, TransformationProvider.\u003CInsertBaseAsync\u003Ed__16>(ref awaiter, this);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 4 : 9;
                    continue;
                }
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                key = (string) TransformationProvider.\u003CInsertBaseAsync\u003Ed__16.xgYkbdQ4xHfhqHxfbMLy((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -672071709), (object) ((string) TransformationProvider.\u003CInsertBaseAsync\u003Ed__16.hyxAckQ47Ce7lBQjnbHO((object) column, TransformationProvider.\u003CInsertBaseAsync\u003Ed__16.KPwc6tQ43leWKu2bn52X(-87337865 ^ -87340753), (object) "")).Replace((string) TransformationProvider.\u003CInsertBaseAsync\u003Ed__16.KPwc6tQ43leWKu2bn52X(-138018305 ^ -137955555), "").Replace((string) TransformationProvider.\u003CInsertBaseAsync\u003Ed__16.KPwc6tQ43leWKu2bn52X(813604817 ^ 813590841), ""));
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 12 : 12;
              }
label_63:
              return;
label_40:
              num3 = 4;
              goto label_9;
            }
            catch (Exception ex)
            {
              int num7 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
                num7 = 0;
              while (true)
              {
                switch (num7)
                {
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 2;
                    continue;
                  case 2:
                    goto label_59;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 1 : 1;
                    continue;
                }
              }
label_59:
              return;
            }
        }
      }
label_66:;
    }

    /// <summary>Обновить данные в таблице</summary>
    /// <param name="table">Имя таблицы</param>
    /// <param name="columns">Имена колонок</param>
    /// <param name="values">Значения колонок в том же порядке, что и имена</param>
    /// <param name="where">Условие обновления</param>
    /// <param name="paramValues">Значения параметров</param>
    /// <param name="isAsync"><c>true</c> если выполнять асинхронно</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Результат</returns>
    private async ValueTask<int> UpdateBaseAsync(
      string table,
      IReadOnlyList<string> columns,
      IReadOnlyList<object> values,
      string where,
      Dictionary<string, object> paramValues,
      bool isAsync,
      CancellationToken cancellationToken = default (CancellationToken))
    {
      int num1 = 2;
      int num2;
      int result1;
      TransformationProvider transformationProvider1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_76;
          case 1:
            transformationProvider1 = this;
            num1 = 4;
            continue;
          case 2:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 1;
            continue;
          case 3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
            continue;
          case 4:
            try
            {
              int num3;
              if (num2 != 0)
                num3 = 39;
              else
                goto label_17;
label_5:
              int num4 = num3;
label_6:
              TaskAwaiter taskAwaiter;
              int index;
              object obj1;
              string column;
              string key;
              TaskAwaiter awaiter;
              Dictionary<string, string> dictionary1;
              Dictionary<string, object>.Enumerator enumerator;
              int result;
              TransformationProvider transformationProvider;
              string query;
              Dictionary<string, object> @params;
              CancellationToken cancellationToken1;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    obj1 = values[index];
                    num4 = 29;
                    continue;
                  case 2:
                    cancellationToken1 = cancellationToken;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 5 : 31;
                    continue;
                  case 3:
                    index = 0;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 15 : 13;
                    continue;
                  case 4:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    TransformationProvider.\u003CUpdateBaseAsync\u003Ed__17.nubC6jQ6bXbYixeWext7((object) table, TransformationProvider.\u003CUpdateBaseAsync\u003Ed__17.cc1OTDQ6oST1kgjiCuF6(-680446928 - -370807692 ^ -309675682));
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 38 : 16;
                    continue;
                  case 5:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 23 : 3;
                    continue;
                  case 6:
                  case 15:
                    if (index < columns.Count)
                    {
                      num4 = 28;
                      continue;
                    }
                    goto case 30;
                  case 7:
                    @params = new Dictionary<string, object>();
                    num4 = 3;
                    continue;
                  case 8:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    dictionary1[((EleWise.ELMA.Runtime.Db.Migrator.Providers.Dialect) TransformationProvider.\u003CUpdateBaseAsync\u003Ed__17.XhudasQ6vTvZGic5SACy((object) transformationProvider1)).QuoteIfNeeded(column)] = (string) TransformationProvider.\u003CUpdateBaseAsync\u003Ed__17.mb4pi7Q6CgBm2KsxRwOA((object) transformationProvider1.ParameterSeparator, (object) key);
                    num4 = 25;
                    continue;
                  case 9:
                    // ISSUE: reference to a compiler-generated method
                    if (!TransformationProvider.\u003CUpdateBaseAsync\u003Ed__17.PyoOOFQ6ZyH2OkkuDLqI((object) where))
                    {
                      num4 = 26;
                      continue;
                    }
                    goto case 22;
                  case 11:
                    transformationProvider = this;
                    num4 = 2;
                    continue;
                  case 12:
                  case 46:
                    awaiter.GetResult();
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 33 : 37;
                    continue;
                  case 13:
                  case 40:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    key = (string) TransformationProvider.\u003CUpdateBaseAsync\u003Ed__17.mb4pi7Q6CgBm2KsxRwOA(TransformationProvider.\u003CUpdateBaseAsync\u003Ed__17.cc1OTDQ6oST1kgjiCuF6(-1978478350 ^ -1978525142), (object) column);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 8 : 8;
                    continue;
                  case 14:
                    if (!isAsync)
                    {
                      num4 = 47;
                      continue;
                    }
                    goto case 19;
                  case 16:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, TransformationProvider.\u003CUpdateBaseAsync\u003Ed__17>(ref awaiter, this);
                    num4 = 41;
                    continue;
                  case 17:
                    // ISSUE: reference to a compiler-generated method
                    TransformationProvider.\u003CUpdateBaseAsync\u003Ed__17.vkxtnSQ6hhIvXBXKtklX((object) values, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289785454));
                    num4 = 43;
                    continue;
                  case 18:
                    dictionary1 = new Dictionary<string, string>();
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 7 : 0;
                    continue;
                  case 19:
                    // ISSUE: explicit non-virtual call
                    // ISSUE: reference to a compiler-generated method
                    awaiter = TransformationProvider.\u003CUpdateBaseAsync\u003Ed__17.Gg2oTlQ6uwgpcfqPLtV6((object) __nonvirtual (transformationProvider1.ExecuteWithTimeoutAsync(0, (Func<Task>) (() =>
                    {
                      int num5 = 3;
                      AsyncTaskMethodBuilder tBuilder;
                      // ISSUE: variable of a compiler-generated type
                      TransformationProvider.\u003C\u003Ec__DisplayClass17_0.\u003C\u003CUpdateBaseAsync\u003Eb__1\u003Ed stateMachine;
                      while (true)
                      {
                        switch (num5)
                        {
                          case 1:
                            tBuilder.Start<TransformationProvider.\u003C\u003Ec__DisplayClass17_0.\u003C\u003CUpdateBaseAsync\u003Eb__1\u003Ed>(ref stateMachine);
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
                            continue;
                          case 2:
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated method
                            stateMachine.\u003C\u003Et__builder = TransformationProvider.\u003C\u003Ec__DisplayClass17_0.yxXMThQ4ldwmYLLCY8yh();
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 4 : 3;
                            continue;
                          case 3:
                            // ISSUE: reference to a compiler-generated field
                            stateMachine.\u003C\u003E4__this = (object) this;
                            num5 = 2;
                            continue;
                          case 4:
                            // ISSUE: reference to a compiler-generated field
                            stateMachine.\u003C\u003E1__state = -1;
                            num5 = 5;
                            continue;
                          case 5:
                            // ISSUE: reference to a compiler-generated field
                            tBuilder = stateMachine.\u003C\u003Et__builder;
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 1;
                            continue;
                          default:
                            goto label_6;
                        }
                      }
label_6:
                      // ISSUE: reference to a compiler-generated field
                      return stateMachine.\u003C\u003Et__builder.Task;
                    }))));
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 1 : 35;
                    continue;
                  case 20:
                  case 37:
                    result1 = result;
                    num4 = 24;
                    continue;
                  case 21:
                  case 28:
                    column = columns[index];
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 1 : 0;
                    continue;
                  case 22:
                    result = 0;
                    num4 = 14;
                    continue;
                  case 23:
                    taskAwaiter = awaiter;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 16 : 9;
                    continue;
                  case 24:
                    goto label_2;
                  case 25:
                    @params[key] = obj1;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
                    continue;
                  case 26:
                    goto label_62;
                  case 27:
label_65:
                    // ISSUE: reference to a compiler-generated method
                    object obj2 = TransformationProvider.\u003CUpdateBaseAsync\u003Ed__17.cc1OTDQ6oST1kgjiCuF6(~-397266137 ^ 396931430);
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    object obj3 = TransformationProvider.\u003CUpdateBaseAsync\u003Ed__17.WiNvjoQ6f8qoSF3FgOZJ(TransformationProvider.\u003CUpdateBaseAsync\u003Ed__17.XhudasQ6vTvZGic5SACy((object) transformationProvider1), (object) table);
                    // ISSUE: reference to a compiler-generated method
                    object obj4 = TransformationProvider.\u003CUpdateBaseAsync\u003Ed__17.cc1OTDQ6oST1kgjiCuF6(1470440286 ^ 1470127758);
                    // ISSUE: reference to a compiler-generated method
                    object separator = TransformationProvider.\u003CUpdateBaseAsync\u003Ed__17.cc1OTDQ6oST1kgjiCuF6(2045296739 + 1688595713 ^ -561077914);
                    Dictionary<string, string> source = dictionary1;
                    // ISSUE: reference to a compiler-generated field
                    System.Func<KeyValuePair<string, string>, string> func = TransformationProvider.\u003C\u003Ec.\u003C\u003E9__17_0;
                    System.Func<KeyValuePair<string, string>, string> selector;
                    if (func == null)
                    {
                      // ISSUE: reference to a compiler-generated field
                      TransformationProvider.\u003C\u003Ec.\u003C\u003E9__17_0 = selector = (System.Func<KeyValuePair<string, string>, string>) (p => p.Key + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669371371 ^ 1669372385) + p.Value);
                    }
                    else
                      goto label_80;
label_68:
                    IEnumerable<string> values1 = source.Select<KeyValuePair<string, string>, string>(selector);
                    string str = string.Join((string) separator, values1);
                    // ISSUE: reference to a compiler-generated method
                    query = (string) TransformationProvider.\u003CUpdateBaseAsync\u003Ed__17.rdXlMPQ68KZTI1OQXP8Y(obj2, obj3, obj4, (object) str);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 9 : 6;
                    continue;
label_80:
                    selector = func;
                    goto label_68;
                  case 29:
                    if (obj1 is SqlExpressionParameter expressionParameter)
                      goto case 36;
                    else
                      goto label_29;
                  case 30:
                    Dictionary<string, object> dictionary2 = paramValues;
                    paramValues = dictionary2 == null ? new Dictionary<string, object>() : dictionary2;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 28 : 32;
                    continue;
                  case 31:
                    cancellationToken1.ThrowIfCancellationRequested();
                    num4 = 4;
                    continue;
                  case 32:
                    enumerator = paramValues.GetEnumerator();
                    num4 = 45;
                    continue;
                  case 33:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num4 = 46;
                    continue;
                  case 34:
                    goto label_17;
                  case 35:
                    if (awaiter.IsCompleted)
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 12 : 12;
                      continue;
                    }
                    goto case 5;
                  case 36:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    dictionary1[(string) TransformationProvider.\u003CUpdateBaseAsync\u003Ed__17.WiNvjoQ6f8qoSF3FgOZJ((object) transformationProvider1.Dialect, (object) column)] = (string) TransformationProvider.\u003CUpdateBaseAsync\u003Ed__17.AlLcKFQ6QikfcwrwSjLA((object) expressionParameter);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 10 : 10;
                    continue;
                  case 38:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    TransformationProvider.\u003CUpdateBaseAsync\u003Ed__17.vkxtnSQ6hhIvXBXKtklX((object) columns, TransformationProvider.\u003CUpdateBaseAsync\u003Ed__17.cc1OTDQ6oST1kgjiCuF6(-1487388570 ^ -1487304378));
                    num4 = 17;
                    continue;
                  case 39:
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 1 : 11;
                    continue;
                  case 41:
                    goto label_69;
                  case 42:
                  case 47:
                    // ISSUE: explicit non-virtual call
                    __nonvirtual (transformationProvider1.ExecuteWithTimeout(0, (System.Action) (() =>
                    {
                      int num6 = 1;
                      while (true)
                      {
                        switch (num6)
                        {
                          case 0:
                            goto label_2;
                          case 1:
                            result = transformationProvider.ExecuteNonQuery(query, @params);
                            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
                            continue;
                          default:
                            goto label_4;
                        }
                      }
label_2:
                      return;
label_4:;
                    })));
                    num4 = 20;
                    continue;
                  case 43:
                    goto label_52;
                  case 44:
                    taskAwaiter = new TaskAwaiter();
                    num4 = 33;
                    continue;
                  case 45:
                    try
                    {
label_38:
                      if (enumerator.MoveNext())
                        goto label_34;
                      else
                        goto label_39;
label_33:
                      int num7;
                      KeyValuePair<string, object> paramValue;
                      while (true)
                      {
                        switch (num7)
                        {
                          case 1:
                            @params[paramValue.Key] = paramValue.Value;
                            num7 = 3;
                            continue;
                          case 2:
                            goto label_65;
                          case 3:
                            goto label_38;
                          case 4:
                            paramValue = enumerator.Current;
                            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 5;
                            continue;
                          case 5:
                            // ISSUE: reference to a compiler-generated method
                            if (!@params.Keys.Any<string>((System.Func<string, bool>) (n => TransformationProvider.\u003C\u003Ec__DisplayClass17_1.ehTOscQ4YJvyeIcQmw22((object) n, (object) paramValue.Key, StringComparison.CurrentCultureIgnoreCase))))
                            {
                              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 0;
                              continue;
                            }
                            goto label_38;
                          default:
                            goto label_34;
                        }
                      }
label_34:
                      num7 = 4;
                      goto label_33;
label_39:
                      num7 = 2;
                      goto label_33;
                    }
                    finally
                    {
                      int num8;
                      if (num2 >= 0)
                        num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
                      else
                        goto label_44;
label_43:
                      switch (num8)
                      {
                        case 2:
                          break;
                        default:
                      }
label_44:
                      enumerator.Dispose();
                      num8 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0)
                      {
                        num8 = 1;
                        goto label_43;
                      }
                      else
                        goto label_43;
                    }
                  default:
                    ++index;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 3 : 6;
                    continue;
                }
              }
label_69:
              return;
label_29:
              num3 = 40;
              goto label_5;
label_52:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              Contract.CheckArgument(TransformationProvider.\u003CUpdateBaseAsync\u003Ed__17.PvH4HoQ6G83mBXYydY5w((object) columns) == TransformationProvider.\u003CUpdateBaseAsync\u003Ed__17.qn3IMeQ6EGJHmwmk1Xyi((object) values), (string) TransformationProvider.\u003CUpdateBaseAsync\u003Ed__17.cc1OTDQ6oST1kgjiCuF6(-2092274397 << 4 ^ 883142582));
              num3 = 18;
              goto label_5;
label_62:
              // ISSUE: reference to a compiler-generated method
              query = query + (string) TransformationProvider.\u003CUpdateBaseAsync\u003Ed__17.cc1OTDQ6oST1kgjiCuF6(381945751 ^ 1158627804 ^ 1406024597) + where;
              num3 = 22;
              goto label_5;
label_17:
              awaiter = taskAwaiter;
              num4 = 44;
              goto label_6;
            }
            catch (Exception ex)
            {
              int num9 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
                num9 = 0;
              while (true)
              {
                switch (num9)
                {
                  case 0:
                    goto label_66;
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 1 : 2;
                    continue;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_64;
                }
              }
label_66:
              return;
label_64:
              return;
            }
          case 5:
label_2:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 3 : 3;
            continue;
          default:
            goto label_73;
        }
      }
label_76:
      return;
label_73:;
    }

    /// <summary>
    /// Удалить данные из таблицы, используется для удаления больших объемов данных
    /// </summary>
    /// <param name="table">Имя таблицы</param>
    /// <param name="where">Условие удаления</param>
    /// <param name="paramValues">Параметры</param>
    /// <param name="isAsync"><c>true</c> если выполнять асинхронно</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Результат</returns>
    private async ValueTask<int> BulkDeleteBaseAsync(
      string table,
      string where,
      Dictionary<string, object> paramValues,
      bool isAsync,
      CancellationToken cancellationToken = default (CancellationToken))
    {
      int num1 = 2;
      while (true)
      {
        int result;
        TransformationProvider transformationProvider1;
        int num2;
        switch (num1)
        {
          case 1:
            transformationProvider1 = this;
            num1 = 5;
            continue;
          case 2:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 1;
            continue;
          case 3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 4 : 4;
            continue;
          case 4:
            goto label_36;
          case 5:
            try
            {
              int num3;
              if (num2 != 0)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 11 : 18;
              else
                goto label_10;
label_6:
              TaskAwaiter taskAwaiter;
              TaskAwaiter awaiter;
              TransformationProvider transformationProvider;
              string query;
              Dictionary<string, object> paramValues1;
              CancellationToken cancellationToken1;
              int rowsDeleted;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, TransformationProvider.\u003CBulkDeleteBaseAsync\u003Ed__18>(ref awaiter, this);
                    num3 = 19;
                    continue;
                  case 2:
                    cancellationToken1.ThrowIfCancellationRequested();
                    num3 = 10;
                    continue;
                  case 3:
                    transformationProvider = this;
                    num3 = 20;
                    continue;
                  case 4:
                    if (isAsync)
                    {
                      num3 = 15;
                      continue;
                    }
                    goto case 9;
                  case 5:
                  case 11:
                    result = rowsDeleted;
                    num3 = 8;
                    continue;
                  case 6:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    query = (string) TransformationProvider.\u003CBulkDeleteBaseAsync\u003Ed__18.q41wpiQ6XZDKfgie7gfJ(1218962250 ^ 1218617018) + (string) TransformationProvider.\u003CBulkDeleteBaseAsync\u003Ed__18.sq0QawQ6TdlFMgtg4txd((object) transformationProvider1, (object) table) + (string) TransformationProvider.\u003CBulkDeleteBaseAsync\u003Ed__18.q41wpiQ6XZDKfgie7gfJ(1178210108 ^ 1178280810) + where + (string) TransformationProvider.\u003CBulkDeleteBaseAsync\u003Ed__18.q41wpiQ6XZDKfgie7gfJ(-105199646 ^ -105214272);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 4 : 3;
                    continue;
                  case 7:
                    goto label_10;
                  case 8:
                    goto label_38;
                  case 9:
                    // ISSUE: explicit non-virtual call
                    __nonvirtual (transformationProvider1.ExecuteWithTimeout(0, (System.Action) (() =>
                    {
                      int num4 = 1;
                      while (true)
                      {
                        switch (num4)
                        {
                          case 0:
                            goto label_2;
                          case 1:
                            rowsDeleted = transformationProvider.ExecuteNonQuery(query, paramValues1);
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
                            continue;
                          default:
                            goto label_4;
                        }
                      }
label_2:
                      return;
label_4:;
                    })));
                    num3 = 5;
                    continue;
                  case 10:
                    rowsDeleted = 0;
                    num3 = 6;
                    continue;
                  case 12:
                    if (!awaiter.IsCompleted)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
                      continue;
                    }
                    goto case 21;
                  case 13:
                    taskAwaiter = new TaskAwaiter();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 16 : 7;
                    continue;
                  case 14:
                    cancellationToken1 = cancellationToken;
                    num3 = 2;
                    continue;
                  case 15:
                    // ISSUE: explicit non-virtual call
                    // ISSUE: reference to a compiler-generated method
                    awaiter = TransformationProvider.\u003CBulkDeleteBaseAsync\u003Ed__18.mKkx8lQ6k9CpquHiIi31((object) __nonvirtual (transformationProvider1.ExecuteWithTimeoutAsync(0, (Func<Task>) (() =>
                    {
                      int num5 = 5;
                      AsyncTaskMethodBuilder tBuilder;
                      // ISSUE: variable of a compiler-generated type
                      TransformationProvider.\u003C\u003Ec__DisplayClass18_0.\u003C\u003CBulkDeleteBaseAsync\u003Eb__0\u003Ed stateMachine;
                      while (true)
                      {
                        switch (num5)
                        {
                          case 1:
                            // ISSUE: reference to a compiler-generated field
                            stateMachine.\u003C\u003E1__state = -1;
                            num5 = 3;
                            continue;
                          case 2:
                            tBuilder.Start<TransformationProvider.\u003C\u003Ec__DisplayClass18_0.\u003C\u003CBulkDeleteBaseAsync\u003Eb__0\u003Ed>(ref stateMachine);
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
                            continue;
                          case 3:
                            // ISSUE: reference to a compiler-generated field
                            tBuilder = stateMachine.\u003C\u003Et__builder;
                            num5 = 2;
                            continue;
                          case 4:
                            // ISSUE: reference to a compiler-generated field
                            stateMachine.\u003C\u003Et__builder = AsyncTaskMethodBuilder.Create();
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 1 : 0;
                            continue;
                          case 5:
                            // ISSUE: reference to a compiler-generated field
                            stateMachine.\u003C\u003E4__this = (object) this;
                            num5 = 4;
                            continue;
                          default:
                            goto label_6;
                        }
                      }
label_6:
                      // ISSUE: reference to a compiler-generated field
                      return stateMachine.\u003C\u003Et__builder.Task;
                    }))));
                    num3 = 12;
                    continue;
                  case 16:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = 21;
                    continue;
                  case 17:
                    taskAwaiter = awaiter;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 1 : 1;
                    continue;
                  case 18:
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 1 : 3;
                    continue;
                  case 19:
                    goto label_33;
                  case 20:
                    paramValues1 = paramValues;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 7 : 14;
                    continue;
                  case 21:
                    awaiter.GetResult();
                    num3 = 11;
                    continue;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 13 : 17;
                    continue;
                }
              }
label_33:
              return;
label_10:
              awaiter = taskAwaiter;
              num3 = 13;
              goto label_6;
            }
            catch (Exception ex)
            {
              int num6 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
                num6 = 0;
              while (true)
              {
                switch (num6)
                {
                  case 0:
                    goto label_29;
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num6 = 2;
                    continue;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_25;
                }
              }
label_29:
              return;
label_25:
              return;
            }
        }
label_38:
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        (^this).\u003C\u003E1__state = -2;
        num1 = 3;
      }
label_36:;
    }

    /// <summary>Уникальный идентификатор провайдера.</summary>
    public abstract Guid Uid { get; }

    /// <summary>Ctor</summary>
    [Obsolete("Не использовать", true)]
    public TransformationProvider()
    {
      TransformationProvider.FinqLEWX3lSUqg2BApY8();
      this.constraintMapper = new ForeignKeyConstraintMapper();
      this.temporaryColumnNames = new Dictionary<string, List<Pair<string, string>>>();
      this.deletingColumnNames = new Dictionary<KeyValuePair<string, string>, string>();
      this.generatorMap = new ConcurrentDictionary<string, IIdentifierGenerator>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="connectionCreateFunc">Функция создания соединения с БД</param>
    public TransformationProvider(Func<IDbConnection> connectionCreateFunc)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.constraintMapper = new ForeignKeyConstraintMapper();
      this.temporaryColumnNames = new Dictionary<string, List<Pair<string, string>>>();
      this.deletingColumnNames = new Dictionary<KeyValuePair<string, string>, string>();
      this.generatorMap = new ConcurrentDictionary<string, IIdentifierGenerator>();
      // ISSUE: explicit constructor call
      base.\u002Ector(connectionCreateFunc);
    }

    /// <summary>Создать копию провайдера с новым подключением к БД</summary>
    /// <returns></returns>
    public abstract ITransformationProvider CreateWithNewConnection();

    private bool SavePoint(string key, IDbCommand dBCommand)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 2:
            goto label_6;
          case 3:
            if (dBCommand == null)
            {
              num = 2;
              continue;
            }
            break;
        }
        if (TransformationProvider.YJmYaUWXpkCxM7UlB5Wm((object) dBCommand) == null)
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 1 : 1;
        else
          goto label_7;
      }
label_6:
      return false;
label_7:
      return this.SavePoint(key, (IDbTransaction) TransformationProvider.YJmYaUWXpkCxM7UlB5Wm((object) dBCommand));
    }

    private void ReleaseSavePoint(string key, IDbCommand dBCommand)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (dBCommand != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
              continue;
            }
            goto label_9;
          case 2:
            goto label_2;
          case 3:
            goto label_5;
          default:
            if (TransformationProvider.YJmYaUWXpkCxM7UlB5Wm((object) dBCommand) == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 2 : 3;
              continue;
            }
            TransformationProvider.OliiwoWXaQgkaARVX1Wd((object) this, (object) key, TransformationProvider.YJmYaUWXpkCxM7UlB5Wm((object) dBCommand));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:
      return;
label_5:
      return;
label_9:;
    }

    private void RollBackSavePoint(string key, IDbCommand dBCommand)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            if (TransformationProvider.YJmYaUWXpkCxM7UlB5Wm((object) dBCommand) == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 3 : 1;
              continue;
            }
            TransformationProvider.dLqK9pWXDmMSlZJ2GXds((object) this, (object) key, TransformationProvider.YJmYaUWXpkCxM7UlB5Wm((object) dBCommand));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
            continue;
          case 2:
            if (dBCommand != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 1 : 1;
              continue;
            }
            goto label_10;
          case 3:
            goto label_5;
          default:
            goto label_9;
        }
      }
label_2:
      return;
label_5:
      return;
label_9:
      return;
label_10:;
    }

    /// <summary>Провайдер метаданных БД</summary>
    public abstract AbstractDbMetadataProvider DbMetadataProvider { get; }

    /// <summary>Функция создания соединения с БД</summary>
    protected Func<IDbConnection> ConnectionCreateFunc => this.connectionCreateFunc ?? this.FromCurrentSession();

    protected virtual Func<IDbConnection> FromCurrentSession()
    {
      if (!(this.Session is ISessionImplementor session))
        return (Func<IDbConnection>) null;
      IConnectionProvider sifc = session.Factory.ConnectionProvider;
      // ISSUE: reference to a compiler-generated method
      return (Func<IDbConnection>) (() => (IDbConnection) TransformationProvider.\u003C\u003Ec__DisplayClass32_0.SMDgkkQ6PHyWJNbiTyLm((object) sifc));
    }

    /// <summary>
    /// Специальный таймаут для SQL операций, требующих ограничения и время выполнения которых выходит за рамки таймаута, установленного по умолчанию.
    /// По умолчанию - 300 секунд
    /// </summary>
    public static int DefaultExtendedCommandTimeout
    {
      get
      {
        int num = 3;
        int extendedCommandTimeout;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_5;
            case 2:
              if (extendedCommandTimeout <= 0)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            case 3:
              extendedCommandTimeout = EleWise.ELMA.SR.GetSetting<int>((string) TransformationProvider.HUgsdnWXtd4YQwhnFhJx(874012245 ^ 874095569), 300);
              num = 2;
              continue;
            default:
              extendedCommandTimeout = 300;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 0;
              continue;
          }
        }
label_5:
        return extendedCommandTimeout;
      }
    }

    /// <summary>
    /// Проверять соответствие параметров поданых в запрос и параметров в строке запроса
    /// </summary>
    public virtual bool CheckParameterBinding => false;

    public virtual void CheckPrerequisites()
    {
    }

    public virtual string GetDatabaseServerVersion() => (string) null;

    public virtual Version GetEngineVersion() => (Version) null;

    public virtual string GetCurrentSchemaName() => string.Empty;

    /// <summary>RuntimeDateTime --&gt; ServerDateTime</summary>
    /// <param name="data">Данные для записи</param>
    protected void TransformIntoServerDateTime(DataTable data)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        int num3;
        int index;
        DateTime? nullable;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 16:
              ++index;
              num2 = 8;
              continue;
            case 2:
            case 15:
              // ISSUE: type reference
              if (!TransformationProvider.QeAKL1WXHUwqREmbDkwE(((DataColumn) TransformationProvider.UVI86HWX4EmckK8ScyJW(TransformationProvider.CJeeJhWXweptRXYaopFG((object) data), num3)).DataType, TransformationProvider.kcFGHvWX66UvSiChBiyq(__typeref (DateTime))))
                goto case 14;
              else
                goto label_5;
            case 3:
              goto label_10;
            case 4:
            case 9:
              if (num3 < ((InternalDataCollectionBase) TransformationProvider.CJeeJhWXweptRXYaopFG((object) data)).Count)
              {
                num2 = 2;
                continue;
              }
              goto label_6;
            case 5:
              num3 = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 3 : 4;
              continue;
            case 6:
              if (!nullable.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 1 : 0;
                continue;
              }
              goto case 17;
            case 7:
            case 8:
              if (index >= TransformationProvider.JMy7CMWXymvbGnvfVYGe(TransformationProvider.BIWfC6WX0hRBpYo8n0PL((object) data)))
              {
                num2 = 12;
                continue;
              }
              goto case 13;
            case 10:
            case 11:
              index = 0;
              num2 = 7;
              continue;
            case 13:
              nullable = TransformationProvider.hsbE9AWXxjXfEwYGMQdG(TransformationProvider.E7t1xUWX7tjRWJMbbWlJ((object) data.Rows, index), num3) as DateTime?;
              num2 = 6;
              continue;
            case 14:
              // ISSUE: type reference
              if (!TransformationProvider.QeAKL1WXHUwqREmbDkwE(TransformationProvider.Mlg9vNWXAs0Ma7K68RZC(TransformationProvider.UVI86HWX4EmckK8ScyJW((object) data.Columns, num3)), TransformationProvider.kcFGHvWX66UvSiChBiyq(__typeref (DateTime?))))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
                continue;
              }
              goto case 10;
            case 17:
              TransformationProvider.eleATJWXmN1S24iKZntv((object) ((DataRowCollection) TransformationProvider.BIWfC6WX0hRBpYo8n0PL((object) data))[index], num3, (object) nullable.Value.ToServerDateTime());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 10 : 16;
              continue;
            default:
              ++num3;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 3 : 9;
              continue;
          }
        }
label_5:
        num1 = 11;
      }
label_10:
      return;
label_6:;
    }

    /// <summary>Выполнить SQL-скрипт</summary>
    /// <param name="sql">Текст скрипта</param>
    /// <param name="paramValues">Значения параметров</param>
    /// <returns>Результат</returns>
    public override int ExecuteNonQuery(string sql, Dictionary<string, object> paramValues = null)
    {
      Contract.ArgumentNotNull((object) sql, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107952658));
      Contract.ArgumentNotNullOrEmpty(sql, z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272503941));
      paramValues = paramValues ?? new Dictionary<string, object>();
      return this.ExecuteNonQuery(sql, paramValues.Keys.ToArray<string>(), paramValues.Values.ToArray<object>());
    }

    /// <summary>Вставить данные в таблицу</summary>
    /// <param name="table">Имя таблицы</param>
    /// <param name="columns">Имена колонок</param>
    /// <param name="values">Значения колонок в том же порядке, что и имена</param>
    /// <returns>Результат</returns>
    public virtual int Insert(string table, string[] columns, object[] values) => TransformationProvider.Qe1UqsWXMuEGJHxTGPQa((object) this, (object) table, (object) columns, (object) values, false);

    /// <summary>Вставить данные в таблицу</summary>
    /// <param name="table">Имя таблицы</param>
    /// <param name="columns">Имена колонок</param>
    /// <param name="values">Значения колонок в том же порядке, что и имена</param>
    /// <param name="isNeedInsertId">Необходимо ли генерировать и добавлять Id к вставляемым значениям (для MS SQL не используется)</param>
    /// <returns>Результат</returns>
    public virtual int Insert(
      string table,
      string[] columns,
      object[] values,
      bool isNeedInsertId)
    {
      int num = 2;
      ValueTask<int> valueTask;
      ValueTaskAwaiter<int> awaiter;
      while (true)
      {
        switch (num)
        {
          case 1:
            awaiter = valueTask.GetAwaiter();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
            continue;
          case 2:
            valueTask = this.InsertBaseAsync(table, (IReadOnlyList<string>) columns, (IReadOnlyList<object>) values, isNeedInsertId, false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return awaiter.GetResult();
    }

    /// <summary>
    /// Вставить данные в таблицу, в качестве values используем select
    /// </summary>
    /// <param name="table">Имя таблицы</param>
    /// <param name="columns">Имена колонок</param>
    /// <param name="selectColName">Имена колонок в select (Обязатально каждой колонке давать алиас)</param>
    /// <param name="selectFrom">from часть селекта</param>
    /// <param name="isNeedInsertId">Необходимо ли генерировать и добавлять Id к вставляемым значениям</param>
    /// <param name="paramValues"></param>
    /// <returns>Результат</returns>
    public virtual int Insert(
      string table,
      string[] columns,
      string selectColName,
      string selectFrom,
      bool isNeedInsertId,
      Dictionary<string, object> paramValues = null)
    {
      return this.ExecuteNonQuery(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426163005), (object) table, (object) string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583742218), ((IEnumerable<string>) columns).Select<string, string>((System.Func<string, string>) (i => (string) TransformationProvider.mNbVhyWXJlS2ZRZuSPDn(TransformationProvider.c8afbIWTVMx7l6O9RAYA((object) this), (object) i)))), (object) selectColName, (object) selectFrom), paramValues);
    }

    /// <summary>Обновить данные в таблице</summary>
    /// <param name="table">Имя таблицы</param>
    /// <param name="columns">Имена колонок</param>
    /// <param name="values">Значения колонок в том же порядке, что и имена. Желательно передавать данные в виде объекта ParameterValue, с указанием типа. При передаче значения напрямую без указания типа, возможны ситуации, когда тип определzется не верно, особенно для значения null.</param>
    /// <param name="where">Условие обновления</param>
    /// <param name="paramValues">Значения параметров</param>
    /// <returns>Результат</returns>
    public virtual int Update(
      string table,
      string[] columns,
      object[] values,
      string where,
      Dictionary<string, object> paramValues = null)
    {
      return this.UpdateBaseAsync(table, (IReadOnlyList<string>) columns, (IReadOnlyList<object>) values, where, paramValues, false).GetAwaiter().GetResult();
    }

    /// <summary>Выражение OrderBy для колонки</summary>
    /// <param name="propertyMetadata"></param>
    /// <param name="columnName"></param>
    /// <returns></returns>
    public abstract string GetSqlOrderBy(PropertyMetadata propertyMetadata, string columnName);

    /// <summary>
    /// Запрос для получения вложеностей иерархического справочника
    /// </summary>
    public virtual string GetSqlHierarchicalChilds(
      string tableName,
      string parentColumnName,
      string nameColumnName,
      long? parentId,
      int indent,
      int deep)
    {
      throw new NotImplementedException();
    }

    /// <summary>Битовое сложение</summary>
    /// <param name="idcolumn"></param>
    /// <param name="mask"></param>
    /// <returns></returns>
    public abstract string BitAndExpression(string idcolumn, long mask);

    /// <summary>Битовое сложение</summary>
    /// <param name="idcolumn"></param>
    /// <param name="mask"></param>
    /// <returns></returns>
    public abstract string BitAndExpression(string idcolumn, string mask);

    /// <summary>Выражение NOLOCK для выборки из таблицы</summary>
    /// <param name="tableName"></param>
    /// <param name="alias"></param>
    /// <returns></returns>
    public virtual string NoLockTableExpression(string tableName, string alias) => (string) TransformationProvider.MIVZl1WX97yyHeoixXXl(TransformationProvider.HUgsdnWXtd4YQwhnFhJx(1581325282 << 3 ^ -234282688), TransformationProvider.mNbVhyWXJlS2ZRZuSPDn((object) this.Dialect, (object) tableName), (object) alias);

    /// <summary>Получить имя процедуры из текста ее создания</summary>
    /// <param name="procedureText"></param>
    /// <returns></returns>
    public virtual string GetProcedureNameFromText(string procedureText) => (string) TransformationProvider.gQrq12WXdI1DBTA9QAnw((object) procedureText);

    /// <summary>
    /// Получить имя индекса и имя таблицы из текста его создания
    /// </summary>
    /// <param name="sqlText">SQL выражение</param>
    /// <returns>Объект <see cref="T:EleWise.ELMA.Runtime.Db.Migrator.Framework.Index" /> с именами индекса и таблицы, если в тексте удалось распознать выражение создания индекса, иначе - null</returns>
    public virtual EleWise.ELMA.Runtime.Db.Migrator.Framework.Index GetIndexInfoFromStatement(
      string sqlText)
    {
      int num = 2;
      Match match;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            str = ((IEnumerable<string>) TransformationProvider.fdSUInWXlyd5IiP4m0Hg((object) match.Groups[(string) TransformationProvider.HUgsdnWXtd4YQwhnFhJx(-1921202237 ^ -1921183903)].Value, (object) new char[1]
            {
              '.'
            })).Last<string>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
            continue;
          case 2:
            match = this.CreateIndexPattern.Match(sqlText);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      EleWise.ELMA.Runtime.Db.Migrator.Framework.Index infoFromStatement = new EleWise.ELMA.Runtime.Db.Migrator.Framework.Index();
      infoFromStatement.Name = (string) TransformationProvider.Dfm11pWX5Y3xSpKfLslA((object) this.Dialect, (object) ((Capture) TransformationProvider.kmh2MvWXgGLA0274iWAh(TransformationProvider.S8rGWYWXrF4VAcFTKwda((object) match), TransformationProvider.HUgsdnWXtd4YQwhnFhJx(1574260816 ^ 1574219314))).Value);
      TransformationProvider.TflSjaWXjlASCOfTFeHd((object) infoFromStatement, TransformationProvider.Dfm11pWX5Y3xSpKfLslA((object) this.Dialect, (object) str));
      return infoFromStatement;
    }

    /// <summary>
    /// Выполнить действие, и повторить попытку в случае возникновения DeadLock-а
    /// </summary>
    /// <param name="action"></param>
    /// <param name="retryCount"></param>
    public virtual void RetryOnDeadlock(System.Action action, int retryCount)
    {
      int num1 = 9;
      while (true)
      {
        int num2 = num1;
        Random random;
        int num3;
        int intervalDeviation;
        int deadlockRetryInterval;
        int num4;
        while (true)
        {
          switch (num2)
          {
            case 1:
              try
              {
                TransformationProvider.V0xc5GWXL3eROm9gowxL((object) action);
                int num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
                  num5 = 0;
                switch (num5)
                {
                  case 0:
                    return;
                  default:
                    return;
                }
              }
              catch (Exception ex)
              {
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
                  num6 = 0;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                      goto label_28;
                    case 2:
                      if (num3 == retryCount + 1)
                      {
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 1;
                        continue;
                      }
                      goto label_12;
                    case 3:
                      goto label_25;
                    default:
                      if (TransformationProvider.ygDWIqWXUspv6MwfURB8((object) this, (object) ex))
                      {
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 2 : 2;
                        continue;
                      }
                      goto label_25;
                  }
                }
label_25:
                throw;
label_28:
                throw;
              }
            case 2:
              num3 = 1;
              num2 = 12;
              continue;
            case 3:
            case 12:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 1 : 1;
              continue;
            case 4:
              goto label_6;
            case 5:
label_12:
              num4 = random.Next(-intervalDeviation, intervalDeviation);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 1 : 10;
              continue;
            case 6:
              intervalDeviation = this.GetDeadlockRetryIntervalDeviation();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
              continue;
            case 7:
              goto label_29;
            case 8:
              random = new Random();
              num2 = 13;
              continue;
            case 9:
              TransformationProvider.DxbkD1WXYwkIbPOn3hGI((object) action, TransformationProvider.HUgsdnWXtd4YQwhnFhJx(1514961705 ^ 1515021021));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 8 : 8;
              continue;
            case 10:
              Thread.Sleep((deadlockRetryInterval + num4 * deadlockRetryInterval / 100 + 1) * num3);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 4 : 3;
              continue;
            case 11:
              retryCount = this.GetDeadlockRetryAttempt();
              num2 = 2;
              continue;
            case 13:
              deadlockRetryInterval = this.GetDeadlockRetryInterval();
              num2 = 6;
              continue;
            default:
              if (retryCount < 0)
              {
                num2 = 11;
                continue;
              }
              goto case 2;
          }
        }
label_6:
        ++num3;
        num1 = 3;
      }
label_29:;
    }

    /// <summary>
    /// Возвращает True, если произошла ошибка, при которой надо обязательно откатывать транзакцию
    /// </summary>
    /// <param name="ex">Исключение</param>
    /// <returns></returns>
    public abstract bool IsUnrecoverableException(Exception ex);

    /// <summary>Дополнительная обработка ошибки и соединения</summary>
    /// <param name="ex"></param>
    /// <param name="dbConnection"></param>
    public virtual void ProcessException(Exception ex, IDbConnection dbConnection)
    {
      int num = 6;
      while (true)
      {
        IUnitOfWorkManager unitOfWorkManager1;
        IUnitOfWorkManager unitOfWorkManager2;
        switch (num)
        {
          case 1:
            TransformationProvider.mfA4npWXz4xYBkcEKRuB((object) unitOfWorkManager1, (object) ex);
            num = 7;
            continue;
          case 2:
            if (TransformationProvider.JHu6bWWXcTR0O9eAN2o1())
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
              continue;
            }
            goto case 4;
          case 3:
            if (unitOfWorkManager1 != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 1;
              continue;
            }
            goto label_11;
          case 4:
            unitOfWorkManager2 = (IUnitOfWorkManager) null;
            break;
          case 5:
            goto label_12;
          case 6:
            if (!TransformationProvider.Qjkgh0WXsTl21FPTg7cY((object) this, (object) ex))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 5 : 5;
              continue;
            }
            goto case 2;
          case 7:
            goto label_2;
          default:
            unitOfWorkManager2 = Locator.GetService<IUnitOfWorkManager>();
            break;
        }
        unitOfWorkManager1 = unitOfWorkManager2;
        num = 3;
      }
label_12:
      return;
label_2:
      return;
label_11:;
    }

    /// <summary>Установка точки сохранения</summary>
    public virtual bool SavePoint(string key, IDbTransaction dbTransaction) => false;

    /// <summary>Удаление точки сохранения</summary>
    public virtual void ReleaseSavePoint(string key, IDbTransaction dbTransaction)
    {
    }

    /// <summary>Откат к точке сохранения</summary>
    public virtual void RollBackSavePoint(string key, IDbTransaction dbTransaction)
    {
    }

    /// <summary>Можно ли повторить выполнение команды после ошибки</summary>
    /// <param name="ex"></param>
    /// <returns></returns>
    protected virtual bool CanRetryAfterException(Exception ex) => false;

    /// <summary>
    /// Парсить все возможные синтаксисы на поиск названия функци и процедур
    /// </summary>
    /// <param name="procedureText"></param>
    /// <returns></returns>
    public static string UniversalProcedureNameFromText(string procedureText)
    {
      int num1 = 8;
      string str1;
      string str2;
      while (true)
      {
        int num2 = num1;
        Match match;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 6:
              if (TransformationProvider.NtxsCmWTb5ujoVSPXxYO((object) str2))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
                continue;
              }
              goto case 4;
            case 2:
              str1 = (string) TransformationProvider.iIQIHnWTWgpyKXtg5Ewd((object) match.Value);
              num2 = 15;
              continue;
            case 3:
              if (!TransformationProvider.yycXYfWToQIxQ7weEJlH((object) str2, TransformationProvider.HUgsdnWXtd4YQwhnFhJx(1669212571 ^ 1669215071)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 1 : 0;
                continue;
              }
              goto case 17;
            case 4:
              str2 = (string) TransformationProvider.gui2SsWThpT7B06k87Ym(TransformationProvider.gui2SsWThpT7B06k87Ym(TransformationProvider.gui2SsWThpT7B06k87Ym((object) str2, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1505778440 - 1981636111 ^ -475919845), (object) ""), TransformationProvider.HUgsdnWXtd4YQwhnFhJx(1461625753 ^ 1461605745), (object) ""), TransformationProvider.HUgsdnWXtd4YQwhnFhJx(-138018305 ^ -138011481), (object) "");
              num2 = 10;
              continue;
            case 5:
            case 11:
              if (!TransformationProvider.NtxsCmWTb5ujoVSPXxYO((object) str1))
              {
                num2 = 14;
                continue;
              }
              goto label_19;
            case 7:
              goto label_27;
            case 8:
              if (string.IsNullOrEmpty(procedureText))
              {
                num2 = 7;
                continue;
              }
              match = (Match) TransformationProvider.fdCCJlWTBrZR2RsSvHeg(TransformationProvider.u1wMVyWTFhpnnJljCOx5((object) procedureText), TransformationProvider.HUgsdnWXtd4YQwhnFhJx(132912447 ^ 133032775));
              num2 = 16;
              continue;
            case 9:
              str1 = ((IEnumerable<string>) str1.Split(new string[1]
              {
                (string) TransformationProvider.HUgsdnWXtd4YQwhnFhJx(--1418440330 ^ 1418441806)
              }, StringSplitOptions.RemoveEmptyEntries)).LastOrDefault<string>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 11 : 6;
              continue;
            case 12:
              goto label_19;
            case 13:
              str2 = match.Value.Trim();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 3;
              continue;
            case 14:
              str1 = (string) TransformationProvider.gui2SsWThpT7B06k87Ym((object) str1.Replace((string) TransformationProvider.HUgsdnWXtd4YQwhnFhJx(-1824388195 ^ -1824326273), "").Replace((string) TransformationProvider.HUgsdnWXtd4YQwhnFhJx(-105199646 ^ -105238262), ""), TransformationProvider.HUgsdnWXtd4YQwhnFhJx(~289714581 ^ -289713358), (object) "");
              num2 = 12;
              continue;
            case 15:
              if (TransformationProvider.yycXYfWToQIxQ7weEJlH((object) str1, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(993438473 ^ 993440205)))
                goto case 9;
              else
                goto label_25;
            case 16:
              if (match.Success)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 2;
                continue;
              }
              match = Regex.Match((string) TransformationProvider.u1wMVyWTFhpnnJljCOx5((object) procedureText), (string) TransformationProvider.HUgsdnWXtd4YQwhnFhJx(372753449 ^ 372652679));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 18 : 5;
              continue;
            case 17:
              str2 = ((IEnumerable<string>) TransformationProvider.F7xFSPWTE3q2t6KOtGdb((object) str2, (object) new string[1]
              {
                (string) TransformationProvider.HUgsdnWXtd4YQwhnFhJx(-1876063057 ^ -1876060565)
              }, StringSplitOptions.RemoveEmptyEntries)).LastOrDefault<string>();
              num2 = 6;
              continue;
            case 18:
              if (TransformationProvider.lkeTLeWTGwaIL6RTDXUu((object) match))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 13 : 1;
                continue;
              }
              goto label_8;
            default:
              goto label_7;
          }
        }
label_25:
        num1 = 5;
      }
label_7:
      return str2;
label_8:
      return string.Empty;
label_19:
      return str1;
label_27:
      return string.Empty;
    }

    /// <summary>Сделать бэкап таблиц</summary>
    /// <param name="tableNames"></param>
    /// <param name="newTableNames"></param>
    public abstract void BackupTables(string[] tableNames, string[] newTableNames);

    /// <summary>Проверить существование таблицы</summary>
    /// <param name="table">Имя таблицы</param>
    /// <returns>True, если таблица существует</returns>
    public abstract bool TableExists(string table);

    /// <summary>Добавить таблицу</summary>
    /// <param name="table">Таблица</param>
    public virtual void AddTable(Table table)
    {
      int num1 = 1;
      List<ForeignKey>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            Contract.ArgumentNotNull((object) table, (string) TransformationProvider.HUgsdnWXtd4YQwhnFhJx(1505778440 - 1981636111 ^ -475856357));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_6;
          case 3:
            enumerator = table.ForeignKeys.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 6 : 3;
            continue;
          case 4:
            if (table.ForeignKeys != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 3 : 3;
              continue;
            }
            goto label_15;
          case 5:
            goto label_19;
          case 6:
            goto label_8;
          default:
            this.AddTable(table.Name, TransformationProvider.zZGY93WTfSD03hNLBG9s((object) table), TransformationProvider.vB2EWyWTQwj49jAPyyvy((object) table), table.Columns.ToArray());
            num1 = 4;
            continue;
        }
      }
label_6:
      return;
label_19:
      return;
label_15:
      return;
label_8:
      try
      {
label_12:
        if (enumerator.MoveNext())
          goto label_14;
        else
          goto label_13;
label_9:
        ForeignKey current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_10;
            case 2:
              goto label_12;
            case 3:
              this.AddForeignKey(current);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 2 : 0;
              continue;
            default:
              goto label_14;
          }
        }
label_10:
        return;
label_13:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 1 : 1;
        goto label_9;
label_14:
        current = enumerator.Current;
        num2 = 3;
        goto label_9;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    /// <summary>Переименовать таблицу</summary>
    /// <param name="oldTableName">Старое имя таблицы</param>
    /// <param name="newTableName">Новое имя таблицы</param>
    public abstract void RenameTable(string oldTableName, string newTableName);

    /// <summary>
    /// Переименовать последовательность, связанную с таблицей
    /// </summary>
    /// <param name="oldTableName">Старое имя таблицы</param>
    /// <param name="newTableName">Новое имя таблицы</param>
    public abstract void RenameSequence(string oldTableName, string newTableName);

    /// <summary>Получить суммарную длину всех полей таблицы</summary>
    /// <param name="table">Имя таблицы</param>
    /// <returns>Суммарная длина полей таблицы</returns>
    public abstract int GetTableColumnsSize(string table);

    /// <summary>Максимальный размер записи в таблице</summary>
    public abstract int TableRecordMaxSize { get; }

    /// <summary>Удалить таблицу</summary>
    /// <param name="tableName">Имя таблицы</param>
    public virtual void RemoveTable(string tableName, bool removeSequence)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.ExecuteNonQuery((string) TransformationProvider.eUWIxXWTvUXwcluM0RN1((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461673321), TransformationProvider.th4WuLWTCoficlLkMVib((object) this, (object) tableName)), (Dictionary<string, object>) null);
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

    /// <summary>Создать счётчик для таблицы.</summary>
    /// <param name="tableName">Имя таблицы.</param>
    public abstract void AddTableSequence(string tableName);

    /// <summary>Удалить счётчик для таблицы.</summary>
    /// <param name="tableName">Имя таблицы.</param>
    public abstract void RemoveTableSequence(string tableName);

    /// <summary>
    /// Инициализировать таблицу с генераторами для Сущностей.
    /// Переопределять в БД где нет встроенной поддержки генераторов
    /// </summary>
    public virtual void InitTableGenerators()
    {
    }

    /// <summary>Проверить существование колонки в таблице</summary>
    /// <param name="table">Имя таблицы</param>
    /// <param name="column">Имя колонки</param>
    /// <returns>True, если колонка существует</returns>
    public abstract bool ColumnExists(string table, string column);

    /// <summary>Добавить колонку в существующую таблицу</summary>
    /// <param name="table">Имя таблицы</param>
    /// <param name="column">Колонка</param>
    public virtual void AddColumn(string table, Column column)
    {
      int num = 5;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!TransformationProvider.BcOadbWTu2aBFD9YVqO9((object) this, (object) table, TransformationProvider.tiI7oaWTZKB0MmbbtxwA((object) column)))
            {
              str = (string) TransformationProvider.QIcOScWTSGccOlYsB2tk(TransformationProvider.c8afbIWTVMx7l6O9RAYA((object) this), (object) column, false);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 2 : 1;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_2;
          case 4:
            TransformationProvider.fVlMmMWT8LuO0H3irfrY((object) table, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-397266137 ^ 397161018));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 6 : 6;
            continue;
          case 5:
            TransformationProvider.DxbkD1WXYwkIbPOn3hGI((object) table, TransformationProvider.HUgsdnWXtd4YQwhnFhJx(1819636893 << 3 ^ 1672108554));
            num = 4;
            continue;
          case 6:
            TransformationProvider.DxbkD1WXYwkIbPOn3hGI((object) column, TransformationProvider.HUgsdnWXtd4YQwhnFhJx(1470998129 - 231418599 ^ 1239647360));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 1 : 0;
            continue;
          default:
            TransformationProvider.fEeL7JWTipjVFsiraghx((object) this, (object) table, (object) str, TransformationProvider.tiI7oaWTZKB0MmbbtxwA((object) column));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 2 : 3;
            continue;
        }
      }
label_2:
      return;
label_3:
      throw new DataException((string) TransformationProvider.MIVZl1WX97yyHeoixXXl(TransformationProvider.Q25YMBWTI0IQHBaFpJSM(TransformationProvider.HUgsdnWXtd4YQwhnFhJx(694673736 ^ -23604109 ^ -672020525)), (object) column.Name, (object) table));
    }

    /// <summary>Переименовать колонку</summary>
    /// <param name="table">Имя таблицы</param>
    /// <param name="oldColumnName">Старое имя колонки</param>
    /// <param name="newColumnName">Новое имя колонки</param>
    public abstract void RenameColumn(string table, string oldColumnName, string newColumnName);

    /// <summary>Удалить колонку из БД</summary>
    /// <param name="table">Имя таблицы</param>
    /// <param name="column">Имя колонки</param>
    public virtual void RemoveColumn(string table, string column)
    {
      int num = 3;
      string columnName;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.DeleteDeletingColumnTemporaryName(table, columnName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
            continue;
          case 2:
            if (columnName != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 1 : 0;
              continue;
            }
            goto label_7;
          case 3:
            columnName = (string) TransformationProvider.SW5TQbWTRQiALaZTJyow((object) this, (object) table, (object) column);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 2;
            continue;
          default:
            goto label_8;
        }
      }
label_2:
      return;
label_8:
      return;
label_7:;
    }

    /// <summary>Удалить ограничения, навешенные на колонку</summary>
    /// <param name="table">Имя таблицы</param>
    /// <param name="column">Имя колонки</param>
    public abstract void RemoveColumnConstraints(string table, string column);

    /// <summary>Получить длину колонки в БД</summary>
    /// <param name="column">Колонка</param>
    /// <returns>Размер колонки</returns>
    public virtual int GetColumnSize(Column column)
    {
      int num1 = 5;
      int num2;
      while (true)
      {
        DbType dataType;
        int? length;
        int maxValue;
        switch (num1)
        {
          case 1:
            if (length.HasValue)
            {
              length = ((ColumnType) TransformationProvider.aOiKVJWTqa8YmGEkqbMP((object) column)).Length;
              num1 = 10;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 2 : 2;
            continue;
          case 2:
            maxValue = (int) byte.MaxValue;
            break;
          case 3:
            dataType = ((ColumnType) TransformationProvider.aOiKVJWTqa8YmGEkqbMP((object) column)).DataType;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 9;
            continue;
          case 4:
            TransformationProvider.DxbkD1WXYwkIbPOn3hGI((object) column.ColumnType, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837727391));
            num1 = 8;
            continue;
          case 5:
            TransformationProvider.DxbkD1WXYwkIbPOn3hGI((object) column, TransformationProvider.HUgsdnWXtd4YQwhnFhJx(1199946765 ^ 1199850247));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 4 : 4;
            continue;
          case 6:
            goto label_3;
          case 7:
            goto label_4;
          case 8:
            length = ((ColumnType) TransformationProvider.aOiKVJWTqa8YmGEkqbMP((object) column)).Length;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 1 : 1;
            continue;
          case 9:
            switch (dataType)
            {
              case DbType.AnsiString:
              case DbType.AnsiStringFixedLength:
                goto label_23;
              case DbType.Binary:
                goto label_5;
              case DbType.Byte:
                goto label_7;
              case DbType.Boolean:
                goto label_6;
              case DbType.Currency:
                goto label_8;
              case DbType.Date:
              case DbType.DateTime:
              case DbType.DateTime2:
              case DbType.DateTimeOffset:
                goto label_9;
              case DbType.Decimal:
                goto label_10;
              case DbType.Double:
                goto label_11;
              case DbType.Guid:
                goto label_12;
              case DbType.Int16:
                goto label_13;
              case DbType.Int32:
                goto label_14;
              case DbType.Int64:
                goto label_15;
              case DbType.Object:
                goto label_16;
              case DbType.SByte:
                goto label_17;
              case DbType.Single:
                goto label_18;
              case DbType.String:
              case DbType.StringFixedLength:
                if (num2 > 512)
                {
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
                  continue;
                }
                goto label_32;
              case DbType.Time:
                goto label_33;
              case DbType.UInt16:
                goto label_34;
              case DbType.UInt32:
                goto label_35;
              case DbType.UInt64:
                goto label_36;
              case DbType.VarNumeric:
                goto label_37;
              case DbType.Double | DbType.String:
                goto label_39;
              case DbType.Xml:
                goto label_38;
              default:
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 4 : 11;
                continue;
            }
          case 10:
            maxValue = length.Value;
            break;
          case 11:
            goto label_39;
          case 12:
label_23:
            if (num2 <= 1024)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 7 : 5;
              continue;
            }
            goto label_3;
          default:
            goto label_31;
        }
        num2 = maxValue;
        num1 = 3;
      }
label_3:
      return 4;
label_4:
      return 1024;
label_5:
      return 0;
label_6:
      return 2;
label_7:
      return 2;
label_8:
      return 6;
label_9:
      return 8;
label_10:
      return 8;
label_11:
      return 8;
label_12:
      return 16;
label_13:
      return 2;
label_14:
      return 4;
label_15:
      return 8;
label_16:
      return 0;
label_17:
      return 2;
label_18:
      return 6;
label_31:
      return 4;
label_32:
      return num2 * 2;
label_33:
      return 4;
label_34:
      return 2;
label_35:
      return 4;
label_36:
      return 8;
label_37:
      return 8;
label_38:
      return 4;
label_39:
      return 0;
    }

    /// <summary>Колонка типа String нуждается ли в преобразовании?</summary>
    /// <returns></returns>
    public virtual bool NeedStringColumnTransform(string tableName, string columnName) => false;

    /// <summary>
    /// Сконвертировать колонку в строковый тип ограниченной длины
    /// </summary>
    /// <param name="tableName">Наименование таблицы</param>
    /// <param name="columnName">Наименование колонки</param>
    public virtual void ConvertColumnString(string tableName, string columnName, int columnSize)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            TransformationProvider.M34GdGWTK2w7GnJdjXXq((object) this, (object) tableName, (object) columnName, columnSize, false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>
    /// Сконвертировать колонку в строковый тип ограниченной длины
    /// </summary>
    /// <param name="tableName"></param>
    /// <param name="columnName"></param>
    /// <param name="columnSize"></param>
    /// <param name="substringStrings"></param>
    public virtual void ConvertColumnString(
      string tableName,
      string columnName,
      int columnSize,
      bool substringStrings)
    {
      int num = 2;
      while (true)
      {
        string columnTemporaryName;
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            if (!TransformationProvider.QKTOkiWTXpqniq8J75xn((object) this, (object) tableName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 1;
              continue;
            }
            break;
          case 3:
            TransformationProvider.wHjXj9WTTxTFIWxY5oBI((object) this, (object) tableName, (object) columnName, (object) columnTemporaryName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 3 : 5;
            continue;
          case 4:
            this.RemoveColumn(tableName, columnTemporaryName);
            num = 8;
            continue;
          case 5:
            TransformationProvider.qw135nWTkujsqlYvoCK8((object) this, (object) tableName, (object) new Column(columnName, new ColumnType(DbType.String, columnSize)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 6 : 4;
            continue;
          case 6:
            this.ExecuteNonQuery((string) TransformationProvider.lsc52dWTnSNR5IjpkEjk(TransformationProvider.HUgsdnWXtd4YQwhnFhJx(-688192331 - 435440695 ^ -1123596482), TransformationProvider.mNbVhyWXJlS2ZRZuSPDn((object) this.Dialect, (object) tableName), (object) ((EleWise.ELMA.Runtime.Db.Migrator.Providers.Dialect) TransformationProvider.c8afbIWTVMx7l6O9RAYA((object) this)).QuoteIfNeeded(columnName), !substringStrings ? (object) ((EleWise.ELMA.Runtime.Db.Migrator.Providers.Dialect) TransformationProvider.c8afbIWTVMx7l6O9RAYA((object) this)).QuoteIfNeeded(columnTemporaryName) : (object) ((EleWise.ELMA.Runtime.Db.Migrator.Providers.Dialect) TransformationProvider.c8afbIWTVMx7l6O9RAYA((object) this)).Substring((string) TransformationProvider.mNbVhyWXJlS2ZRZuSPDn((object) this.Dialect, (object) columnTemporaryName), 1, new int?(columnSize))), (Dictionary<string, object>) null);
            num = 4;
            continue;
          case 7:
            goto label_10;
          case 8:
            goto label_13;
        }
        if (!this.ColumnExists(tableName, columnName))
        {
          num = 7;
        }
        else
        {
          columnTemporaryName = this.GenerateColumnTemporaryName(tableName, columnName);
          num = 3;
        }
      }
label_4:
      return;
label_10:
      return;
label_13:;
    }

    public virtual void ConvertColumnStringIfNeed(
      string tableName,
      string columnName,
      int columnSize)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (!TransformationProvider.apQ6i5WTOht9x51VqZ1q((object) this, (object) tableName, (object) columnName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 1;
              continue;
            }
            break;
          case 3:
            goto label_2;
        }
        TransformationProvider.AgHKpJWT2cf4s4Vkp062((object) this, (object) tableName, (object) columnName, columnSize);
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 3 : 2;
      }
label_5:
      return;
label_2:;
    }

    public virtual string GenerateDeletingColumnTemporaryName(string tableName, string columnName)
    {
      int num = 2;
      KeyValuePair<string, string> key;
      string columnTemporaryName;
      while (true)
      {
        switch (num)
        {
          case 1:
            TransformationProvider.DxbkD1WXYwkIbPOn3hGI((object) columnName, TransformationProvider.HUgsdnWXtd4YQwhnFhJx(272623989 ^ 272504325));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
            continue;
          case 2:
            TransformationProvider.DxbkD1WXYwkIbPOn3hGI((object) tableName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1870808427));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 1 : 1;
            continue;
          case 3:
            this.deletingColumnNames[key] = columnTemporaryName;
            num = 4;
            continue;
          case 4:
            goto label_7;
          case 5:
            columnTemporaryName = (string) TransformationProvider.RPFKGhWTPJVyHgXFQuik((object) this, (object) tableName, (object) columnName);
            num = 3;
            continue;
          default:
            key = new KeyValuePair<string, string>((string) TransformationProvider.Jn4UQMWTek4uxF6h5VkE((object) tableName), (string) TransformationProvider.Jn4UQMWTek4uxF6h5VkE((object) columnName));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 5 : 5;
            continue;
        }
      }
label_7:
      return columnTemporaryName;
    }

    public virtual string GenerateColumnTemporaryName(string tableName, string columnName)
    {
      int num1 = 16;
      string temporaryName;
      while (true)
      {
        int num2 = num1;
        List<Pair<string, string>> pairList;
        string str;
        int num3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              temporaryName = (string) TransformationProvider.G6qBvPWT33TL3lyoqYIU((object) str, (object) num3);
              num2 = 6;
              continue;
            case 2:
              goto label_9;
            case 3:
              pairList = new List<Pair<string, string>>();
              num2 = 13;
              continue;
            case 4:
              goto label_17;
            case 5:
              ++num3;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 1 : 1;
              continue;
            case 6:
            case 7:
              if (!TransformationProvider.BcOadbWTu2aBFD9YVqO9((object) this, (object) tableName, (object) temporaryName))
              {
                num2 = 12;
                continue;
              }
              goto case 5;
            case 8:
              columnName = columnName.Substring(0, 20);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 2 : 11;
              continue;
            case 9:
            case 11:
              temporaryName = (string) TransformationProvider.APrideWTNw058Md1SOJi((object) temporaryName, (object) columnName, TransformationProvider.HUgsdnWXtd4YQwhnFhJx(-2099751081 ^ -2099750099));
              num2 = 18;
              continue;
            case 10:
              num3 = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 7 : 7;
              continue;
            case 12:
              if (!pairList.Exists((Predicate<Pair<string, string>>) (p => p.First == temporaryName.ToUpper())))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 2 : 2;
                continue;
              }
              goto case 5;
            case 13:
              this.temporaryColumnNames.Add((string) TransformationProvider.Jn4UQMWTek4uxF6h5VkE((object) tableName), pairList);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 14;
              continue;
            case 14:
              str = temporaryName;
              num2 = 10;
              continue;
            case 15:
              Contract.ArgumentNotNull((object) tableName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583727018));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
              continue;
            case 16:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 10 : 15;
              continue;
            case 17:
              if (TransformationProvider.M02wnCWT1cvi6iMqZWuF((object) columnName) <= 25)
              {
                num2 = 9;
                continue;
              }
              goto case 8;
            case 18:
              if (!this.temporaryColumnNames.TryGetValue((string) TransformationProvider.Jn4UQMWTek4uxF6h5VkE((object) tableName), out pairList))
              {
                num2 = 3;
                continue;
              }
              goto case 14;
            case 19:
              temporaryName = (string) TransformationProvider.HUgsdnWXtd4YQwhnFhJx(-138018305 ^ -137888137);
              num2 = 17;
              continue;
            default:
              TransformationProvider.DxbkD1WXYwkIbPOn3hGI((object) columnName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1411176739));
              num2 = 19;
              continue;
          }
        }
label_9:
        pairList.Add(new Pair<string, string>((string) TransformationProvider.Jn4UQMWTek4uxF6h5VkE((object) temporaryName), columnName.ToUpper()));
        num1 = 4;
      }
label_17:
      return temporaryName;
    }

    public virtual string GetDeletingColumnTemporaryName(string tableName, string columnName)
    {
      int num1 = 3;
      string columnTemporaryName;
      while (true)
      {
        int num2 = num1;
        KeyValuePair<string, string> key;
        while (true)
        {
          switch (num2)
          {
            case 1:
              key = new KeyValuePair<string, string>((string) TransformationProvider.Jn4UQMWTek4uxF6h5VkE((object) tableName), (string) TransformationProvider.Jn4UQMWTek4uxF6h5VkE((object) columnName));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
              continue;
            case 2:
              Contract.ArgumentNotNull((object) columnName, (string) TransformationProvider.HUgsdnWXtd4YQwhnFhJx(712480695 ^ 712403143));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 0;
              continue;
            case 3:
              goto label_6;
            case 4:
              goto label_7;
            default:
              if (!this.deletingColumnNames.TryGetValue(key, out columnTemporaryName))
              {
                num2 = 4;
                continue;
              }
              goto label_8;
          }
        }
label_6:
        TransformationProvider.DxbkD1WXYwkIbPOn3hGI((object) tableName, TransformationProvider.HUgsdnWXtd4YQwhnFhJx(-643786247 ^ -643739301));
        num1 = 2;
      }
label_7:
      return columnName;
label_8:
      return columnTemporaryName;
    }

    /// <summary>
    /// Проверить, существует ли ограничение с указанным именем
    /// </summary>
    /// <param name="table">Имя таблицы</param>
    /// <param name="name">Имя органичения</param>
    /// <returns>True, если существует</returns>
    public abstract bool ConstraintExists(string table, string name);

    /// <summary>Возвращает список внешних ключей для таблицы.</summary>
    /// <param name="tableName">Имя таблицы</param>
    /// <returns></returns>
    public abstract List<ForeignKey> GetForeignKeys(string tableName);

    /// <summary>Добавить внешний ключ</summary>
    /// <param name="foreignKey">Внешний ключ</param>
    public virtual void AddForeignKey(ForeignKey foreignKey)
    {
      int num1 = 5;
      TransformationProvider transformationProvider;
      ForeignKey foreignKey1;
      string[] columnNames;
      string[] refColumnNames;
      string onUpdateConstraintResolved;
      string onDeleteConstraintResolved;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_15;
          case 2:
            onDeleteConstraintResolved = (string) TransformationProvider.iipkVfWTanfGoKphhPBI((object) this.constraintMapper, foreignKey1.DeleteAction);
            num1 = 6;
            continue;
          case 3:
            refColumnNames = foreignKey1.RefColumns.Select<string, string>(new System.Func<string, string>(((TransformationProviderBase) this).QuoteIfNeeded)).ToArray<string>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 1 : 11;
            continue;
          case 4:
            transformationProvider = this;
            num1 = 9;
            continue;
          case 5:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 4 : 4;
            continue;
          case 6:
            onUpdateConstraintResolved = (string) TransformationProvider.iipkVfWTanfGoKphhPBI((object) this.constraintMapper, foreignKey1.UpdateAction);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
            continue;
          case 7:
            TransformationProvider.DxbkD1WXYwkIbPOn3hGI((object) foreignKey1, TransformationProvider.HUgsdnWXtd4YQwhnFhJx(-1120607109 - 305487170 ^ -1426163539));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 1 : 8;
            continue;
          case 8:
            if (!this.ConstraintExists((string) TransformationProvider.a7D8cxWTpTmTRWQiPyOT((object) foreignKey1), foreignKey1.Name))
            {
              num1 = 2;
              continue;
            }
            goto label_2;
          case 9:
            foreignKey1 = foreignKey;
            num1 = 7;
            continue;
          case 10:
            goto label_6;
          case 11:
            this.ExecuteWithTimeout(0, (System.Action) (() =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    transformationProvider.ExecuteNonQuery((string) TransformationProvider.\u003C\u003Ec__DisplayClass93_0.l7I2JKQ6xPkO371f2yU2((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426392779), (object) new object[7]
                    {
                      TransformationProvider.\u003C\u003Ec__DisplayClass93_0.JJZ66DQ665aY4f3mQdXj((object) transformationProvider, TransformationProvider.\u003C\u003Ec__DisplayClass93_0.SpiDImQ64RmbcHebKxEx((object) foreignKey1)),
                      TransformationProvider.\u003C\u003Ec__DisplayClass93_0.JJZ66DQ665aY4f3mQdXj((object) transformationProvider, (object) foreignKey1.Name),
                      TransformationProvider.\u003C\u003Ec__DisplayClass93_0.yXjweUQ6HO6E2b22yQ16((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306466388), (object) columnNames),
                      TransformationProvider.\u003C\u003Ec__DisplayClass93_0.JJZ66DQ665aY4f3mQdXj((object) transformationProvider, TransformationProvider.\u003C\u003Ec__DisplayClass93_0.zaACfFQ6AeZ8ySTEtaY1((object) foreignKey1)),
                      TransformationProvider.\u003C\u003Ec__DisplayClass93_0.yXjweUQ6HO6E2b22yQ16(TransformationProvider.\u003C\u003Ec__DisplayClass93_0.HVIlGUQ67EXB3bZwf9Ax(1232639661 >> 3 ^ 154091557), (object) refColumnNames),
                      (object) onUpdateConstraintResolved,
                      (object) onDeleteConstraintResolved
                    }), (Dictionary<string, object>) null);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 10 : 10;
            continue;
          default:
            columnNames = foreignKey1.Columns.Select<string, string>(new System.Func<string, string>(((TransformationProviderBase) this).QuoteIfNeeded)).ToArray<string>();
            num1 = 3;
            continue;
        }
      }
label_15:
      return;
label_6:
      return;
label_2:;
    }

    /// <summary>Удалить внешний ключ</summary>
    /// <param name="tableName">Имя таблицы</param>
    /// <param name="fkName">Имя внешнего ключа</param>
    public virtual void RemoveForeignKey(string tableName, string fkName)
    {
      int num1 = 2;
      TransformationProvider transformationProvider;
      string tableName1;
      string fkName1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_2;
          case 1:
            transformationProvider = this;
            num1 = 3;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 1;
            continue;
          case 3:
            tableName1 = tableName;
            num1 = 5;
            continue;
          case 4:
            this.ExecuteWithTimeout(0, (System.Action) (() =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    transformationProvider.ExecuteNonQuery(string.Format((string) TransformationProvider.\u003C\u003Ec__DisplayClass94_0.BkAkrmQ6JKnY6xIstrJn(--1333735954 ^ 1333710270), TransformationProvider.\u003C\u003Ec__DisplayClass94_0.Aw66BdQ69LGVV9ljIMfl((object) transformationProvider, (object) tableName1), (object) transformationProvider.QuoteIfNeeded(fkName1)), (Dictionary<string, object>) null);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
            continue;
          case 5:
            fkName1 = fkName;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 4 : 4;
            continue;
          default:
            goto label_8;
        }
      }
label_2:
      return;
label_8:;
    }

    /// <summary>Удалить внешние ключи</summary>
    /// <param name="skipNames">Имена ключей, которые удалять не нужно</param>
    /// <param name="useNames">Имена ключей, которые нужно удалить (будут удалены только они)</param>
    public virtual void RemoveForeignKeys(IList<string> skipNames, IList<string> useNames)
    {
      IEnumerable<KeyValuePair<string, string>> items = this.GetForeignKeys().Select<ForeignKey, KeyValuePair<string, string>>((System.Func<ForeignKey, KeyValuePair<string, string>>) (fk => new KeyValuePair<string, string>(fk.TableName, fk.Name)));
      this.ExecuteMethod(skipNames, useNames, items, (Action<KeyValuePair<string, string>>) (p => this.RemoveForeignKey(p.Key, p.Value)));
    }

    /// <summary>Добавить внешний ключ</summary>
    /// <param name="primaryKey">Внешний ключ</param>
    public virtual void AddPrimaryKey(PrimaryKey primaryKey)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.AddPrimaryKey(primaryKey.Name, (string) TransformationProvider.JfvglTWTDhek8QggO44p((object) primaryKey), (string[]) TransformationProvider.FGAdBZWTtYkIGidQptRN((object) primaryKey.Columns));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Удалить первичнй ключ</summary>
    /// <param name="tableName">Имя таблицы</param>
    /// <param name="pkName">Имя внешнего ключа</param>
    public virtual void RemovePrimaryKey(string tableName, string pkName)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (TransformationProvider.AUe37iWTwCK8BTafFv9v((object) this, (object) tableName, (object) pkName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_6;
          case 3:
            goto label_3;
          default:
            this.ExecuteNonQuery((string) TransformationProvider.MIVZl1WX97yyHeoixXXl((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 154070393), (object) this.QuoteIfNeeded(tableName), TransformationProvider.th4WuLWTCoficlLkMVib((object) this, (object) pkName)), (Dictionary<string, object>) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 1 : 2;
            continue;
        }
      }
label_6:
      return;
label_3:
      return;
label_2:;
    }

    /// <summary>Удалить первичные ключи</summary>
    /// <param name="skipNames">Имена ключей, которые удалять не нужно</param>
    /// <param name="useNames">Имена ключей, которые нужно удалить (будут удалены только они)</param>
    public virtual void RemovePrimaryKeys(IList<string> skipNames = null, IList<string> useNames = null) => this.ExecuteMethod(skipNames, useNames, (IEnumerable<KeyValuePair<string, string>>) this.GetPrimaryKeys(), (Action<KeyValuePair<string, string>>) (p => this.RemovePrimaryKey(p.Key, p.Value)));

    /// <summary>
    /// Получить список первичных ключей. Pair.Key - имя таблицы. Pair.Value - Имя первичного ключа.
    /// </summary>
    /// <returns>Список первичных ключей</returns>
    public virtual List<KeyValuePair<string, string>> GetPrimaryKeys() => new List<KeyValuePair<string, string>>();

    /// <summary>Получить превичный ключ по таблице</summary>
    /// <returns></returns>
    public virtual PrimaryKey GetPrimaryKeyByTable(string table) => (PrimaryKey) null;

    /// <summary>Получить имя индекса по имени внешнего ключа</summary>
    /// <param name="fkName">Имя внешнего ключа</param>
    /// <returns>Имя индекса</returns>
    protected virtual string GetIndexNameByForeignKey(string fkName)
    {
      int num = 2;
      string nameByForeignKey;
      while (true)
      {
        switch (num)
        {
          case 1:
            nameByForeignKey = (string) TransformationProvider.eUWIxXWTvUXwcluM0RN1(TransformationProvider.HUgsdnWXtd4YQwhnFhJx(-105199646 ^ -105170916), TransformationProvider.NlYql1WT6YapEQiOCZcE((object) fkName, 2));
            num = 3;
            continue;
          case 2:
            if (TransformationProvider.Dy6BhLWT4Ibx0VoZBox6((object) fkName, TransformationProvider.HUgsdnWXtd4YQwhnFhJx(1581325282 << 3 ^ -234282778), StringComparison.CurrentCultureIgnoreCase))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 0;
              continue;
            }
            goto case 4;
          case 4:
            nameByForeignKey = (string) TransformationProvider.eUWIxXWTvUXwcluM0RN1(TransformationProvider.HUgsdnWXtd4YQwhnFhJx(272623989 ^ 272492915), (object) fkName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return nameByForeignKey;
    }

    /// <summary>Получаем список названий полей для таблицы</summary>
    /// <param name="tableName">Имя таблицы</param>
    /// <returns>Список полей</returns>
    public abstract string[] GetTableColumnsNames(string tableName);

    /// <summary>Удалить триггер</summary>
    /// <param name="tableName">Имя таблицы</param>
    /// <param name="triggerName">Имя триггера</param>
    public virtual void RemoveTrigger(string tableName, string triggerName)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.ExecuteNonQuery((string) TransformationProvider.eUWIxXWTvUXwcluM0RN1((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740469308), (object) this.QuoteIfNeeded(triggerName)), (Dictionary<string, object>) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Удалить триггеры</summary>
    /// <param name="skipNames">Имена триггеров, которые удалять не нужно</param>
    /// <param name="useNames">Имена триггеров, которые нужно удалить (будут удалены только они)</param>
    public virtual void RemoveTriggers(IList<string> skipNames, IList<string> useNames) => this.ExecuteMethod(skipNames, useNames, (IEnumerable<KeyValuePair<string, string>>) this.GetTriggers(), (Action<KeyValuePair<string, string>>) (p => this.RemoveTrigger(p.Key, p.Value)));

    /// <summary>
    /// Получить список триггеров. Pair.Key - имя таблицы. Pair.Value - Имя внешнего ключа.
    /// </summary>
    /// <returns>Список триггеров</returns>
    protected abstract List<KeyValuePair<string, string>> GetTriggers();

    /// <summary>Удалить процедуру или функцию</summary>
    /// <param name="procedureName">Имя процедуры или функции</param>
    public virtual void RemoveProcedure(string procedureName)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.ExecuteNonQuery((string) TransformationProvider.eUWIxXWTvUXwcluM0RN1(TransformationProvider.HUgsdnWXtd4YQwhnFhJx(-1350312861 << 3 ^ 2082267958), TransformationProvider.th4WuLWTCoficlLkMVib((object) this, (object) procedureName)), (Dictionary<string, object>) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Удалить процедуры и функции</summary>
    /// <param name="skipNames">Имена процедур и функций, которые удалять не нужно</param>
    /// <param name="useNames">Имена процедур и функций, которые нужно удалить (будут удалены только они)</param>
    public virtual void RemoveProcedures(IList<string> skipNames, IList<string> useNames) => this.ExecuteMethod(skipNames, useNames, this.GetProcedures(), (Action<string>) (p =>
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            TransformationProvider.yIoVZ6WT5JCAZw4B0qj7((object) this, (object) p);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }));

    /// <summary>Получить список имен процедур и функций</summary>
    /// <returns>Список внешних ключей</returns>
    protected abstract List<string> GetProcedures();

    /// <summary>Обращение к табличной функции</summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public virtual string TableFunction(string name, string @params) => (string) TransformationProvider.MIVZl1WX97yyHeoixXXl(TransformationProvider.HUgsdnWXtd4YQwhnFhJx(2045296739 + 1688595713 ^ -561088726), (object) name, (object) @params);

    /// <summary>Удалить представление</summary>
    /// <param name="viewName">Имя представления</param>
    public virtual void RemoveView(string viewName)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.ExecuteNonQuery((string) TransformationProvider.HUgsdnWXtd4YQwhnFhJx(1052221104 - 768835541 ^ 283516555) + (string) TransformationProvider.th4WuLWTCoficlLkMVib((object) this, (object) viewName), (Dictionary<string, object>) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Удалить представления</summary>
    /// <param name="skipNames">Имена представлений, которые удалять не нужно</param>
    /// <param name="useNames">Имена представлений, которые нужно удалить (будут удалены только они)</param>
    public virtual void RemoveViews(IList<string> skipNames, IList<string> useNames) => this.ExecuteMethod(skipNames, useNames, this.GetViews(), (Action<string>) (p =>
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            TransformationProvider.v0MtnoWTjH1ul91eqxUZ((object) this, (object) p);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }));

    /// <summary>Возвращает все имена индексов для указанной таблицы.</summary>
    /// <param name="tableName"></param>
    /// <returns></returns>
    public abstract List<string> GetIndexes(string tableName);

    /// <summary>Добавить уникальный индекс</summary>
    /// <param name="index">Индекс</param>
    public abstract void AddUniqueIndex(EleWise.ELMA.Runtime.Db.Migrator.Framework.Index index);

    /// <summary>Добавить индекс</summary>
    /// <param name="index">Индекс</param>
    public abstract void AddIndex(EleWise.ELMA.Runtime.Db.Migrator.Framework.Index index);

    /// <summary>
    /// Добавить индекс с учетом того что значение в поле может не быть
    /// </summary>
    /// <param name="index"></param>
    public virtual void AddNvlIndex(EleWise.ELMA.Runtime.Db.Migrator.Framework.Index index)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            TransformationProvider.okCqYYWTHxKYAoP4Ftv6((object) this, (object) index);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Существует ли индекс</summary>
    /// <param name="tableName"></param>
    /// <param name="indexName"></param>
    /// <returns></returns>
    public abstract bool IndexExists(string tableName, string indexName);

    /// <summary>Удалить индекс</summary>
    /// <param name="tableName">Имя таблицы</param>
    /// <param name="indexName">Имя индекса</param>
    public virtual void RemoveIndex(string tableName, string indexName)
    {
      int num1 = 3;
      TransformationProvider transformationProvider;
      string indexName1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_2;
          case 1:
            indexName1 = indexName;
            num1 = 4;
            continue;
          case 2:
            transformationProvider = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 0;
            continue;
          case 3:
            num1 = 2;
            continue;
          case 4:
            this.ExecuteWithTimeout(0, (System.Action) (() =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    transformationProvider.ExecuteNonQuery((string) TransformationProvider.\u003C\u003Ec__DisplayClass117_0.Y28qvbQ6jouoiD4sBawF(TransformationProvider.\u003C\u003Ec__DisplayClass117_0.NH78EUQ6goviY6pWOBGk(979449278 ^ 979651428), TransformationProvider.\u003C\u003Ec__DisplayClass117_0.Vs1NpVQ65ggALZpvi3jM((object) transformationProvider, (object) indexName1)), (Dictionary<string, object>) null);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
            continue;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_7:;
    }

    /// <summary>Удалить все индексы</summary>
    /// <param name="skipNames">Имена индексов, которые удалять не нужно</param>
    /// <param name="useNames">Имена индексов, которые нужно удалить (будут удалены только они)</param>
    public virtual void RemoveIndexes(IList<string> skipNames, IList<string> useNames) => this.ExecuteMethod(skipNames, useNames, (IEnumerable<KeyValuePair<string, string>>) this.GetIndexes(), (Action<KeyValuePair<string, string>>) (p => this.RemoveIndex(p.Key, p.Value)));

    /// <summary>Сенерить уникально имя индекса</summary>
    /// <returns></returns>
    public virtual string GenerateIndexName()
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 901924371));
      TransformationProvider.paEffGWTxpKWVy7C0KGW((object) stringBuilder, TransformationProvider.RpOH9hWT7HNgRPEDtRjg((object) TransformationProvider.LjGZCcWTAT4yFW5bpbvU().ToString((string) TransformationProvider.HUgsdnWXtd4YQwhnFhJx(694673736 ^ -23604109 ^ -672084109)), 0, 24));
      return stringBuilder.ToString();
    }

    /// <summary>
    /// Получить список индексов. Pair.Key - имя таблицы. Pair.Value - Имя индекса.
    /// </summary>
    /// <returns>Список индексов</returns>
    protected abstract List<KeyValuePair<string, string>> GetIndexes();

    /// <summary>
    /// Отключить индексы для таблицы, не отключает индексы для Primary Key
    /// </summary>
    /// <param name="tableName">Имя таблицы в БД</param>
    public virtual void DisableIndexOnTable(string tableName)
    {
      int num1 = 4;
      TransformationProvider transformationProvider;
      string tableName1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            this.ExecuteWithTimeout(0, (System.Action) (() =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    transformationProvider.ExecuteQuery((string) TransformationProvider.\u003C\u003Ec__DisplayClass121_0.x4FugIQ6sjay1j8qL3l7((object) transformationProvider, (object) tableName1), (Dictionary<string, object>) null);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 1 : 1;
            continue;
          case 3:
            transformationProvider = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
            continue;
          case 4:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 3;
            continue;
          default:
            tableName1 = tableName;
            num1 = 2;
            continue;
        }
      }
label_2:;
    }

    /// <summary>
    /// включает и пересобирает индексы относящиеся к таблице.
    /// </summary>
    /// <param name="tableName">Имя таблицы в БД</param>
    public virtual void RebuildIndexOnTable(string tableName)
    {
      int num1 = 2;
      TransformationProvider transformationProvider;
      string tableName1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            transformationProvider = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 1;
            continue;
          case 3:
            this.ExecuteWithTimeout(0, (System.Action) (() =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    transformationProvider.ExecuteQuery((string) TransformationProvider.\u003C\u003Ec__DisplayClass122_0.uOPK1OQHW0K4omVoPgPB((object) transformationProvider, (object) tableName1), (Dictionary<string, object>) null);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 4;
            continue;
          case 4:
            goto label_2;
          default:
            tableName1 = tableName;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 3 : 3;
            continue;
        }
      }
label_2:;
    }

    /// <summary>
    /// Возвращает текст скрипта для отключения индекса для таблицы, не отключает индексы для Primary Key
    /// </summary>
    /// <param name="tableName">Имя таблицы в БД</param>
    public abstract string GetDisableIndexOnTable(string tableName);

    /// <summary>
    /// Возвращает текст скрипта для включения и пересбборки индексов относящиеся к таблице.
    /// </summary>
    /// <param name="tableName">Имя таблицы в БД</param>
    public abstract string GetRebuildIndexOnTable(string tableName);

    /// <summary>Выполнить резервное копирование БД</summary>
    /// <param name="connectionString">Строка подключения</param>
    /// <param name="outputPath">Полный путь до папки, в которую нужно сохранить резервную копию БД</param>
    /// <returns>Полное имя файла резервной копии</returns>
    public abstract string BackupDatabase(string connectionString, string outputPath);

    /// <summary>
    /// Является ли поддержка автоматического бекапа полной? (Во всех случаях можно сделать автоматический бекап?)
    /// </summary>
    public abstract bool HasFullAutoBackupSupport { get; }

    /// <summary>
    /// Получить значение текущего времени из БД.
    /// Применять для синхронизации операций на фермах или для получения точного серверного времени
    /// </summary>
    /// <returns>Текущее время сервера БД</returns>
    public abstract DateTime GetDateTimeNow();

    /// <summary>
    /// Получить значение текущего времени UTC из БД.
    /// Применять для синхронизации операций на фермах или для получения точного серверного времени
    /// </summary>
    /// <returns>Текущее время UTC на сервере БД</returns>
    public abstract DateTime GetUtcDateTimeNow();

    /// <summary>
    /// Проверить, есть ли соединение с БД. Если нет - открыть
    /// </summary>
    protected void EnsureHasConnection()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (((IDbConnection) TransformationProvider.I2RZT7WT0DaunAb21A5A((object) this)).State != ConnectionState.Open)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            goto label_2;
          default:
            TransformationProvider.NErxTEWTmb9CKE36MhPL(TransformationProvider.I2RZT7WT0DaunAb21A5A((object) this));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 2 : 2;
            continue;
        }
      }
label_2:
      return;
label_6:;
    }

    /// <summary>Получить из IDataReader длинную строку</summary>
    /// <param name="rs"></param>
    /// <param name="name"></param>
    /// <returns></returns>
    public virtual object GetLobString(IDataReader rs, string name) => TransformationProvider.YqTfu3WTMBZx7he1c7gT((object) NHibernateUtil.StringClob, (object) (DbDataReader) rs, (object) name, TransformationProvider.Q0cHoIWTyo0TxkhqDJGe((object) this.Session));

    /// <summary>Выполнить SQL-скрипт</summary>
    /// <param name="sql">Текст скрипта</param>
    /// <param name="paramnames">Имена параметров</param>
    /// <param name="paramvalues">Значения параметров</param>
    /// <returns>Результат</returns>
    protected virtual int ExecuteNonQuery(string sql, string[] paramnames, object[] paramvalues)
    {
      int num = 1;
      ValueTask<int> valueTask;
      ValueTaskAwaiter<int> awaiter;
      while (true)
      {
        switch (num)
        {
          case 1:
            valueTask = this.ExecuteNonQueryBaseAsync(sql, (IReadOnlyList<string>) paramnames, (IReadOnlyList<object>) paramvalues, false, TransformationProvider.tSBP0BWTJdFa0uRBw4ey());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            awaiter = valueTask.GetAwaiter();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 2 : 2;
            continue;
        }
      }
label_4:
      return awaiter.GetResult();
    }

    /// <inheritdoc />
    protected override string QuoteIfNeeded(string name) => (string) TransformationProvider.mNbVhyWXJlS2ZRZuSPDn(TransformationProvider.c8afbIWTVMx7l6O9RAYA((object) this), (object) name);

    /// <summary>
    /// Получить список имен колонок с признаком первичного ключа
    /// </summary>
    /// <param name="columns">Список колонок</param>
    /// <returns>Список имен колонок с признаком первичного ключа</returns>
    protected List<string> GetPrimaryKeys(IEnumerable<Column> columns) => columns.Where<Column>((System.Func<Column, bool>) (column => TransformationProvider.\u003C\u003Ec.EjMrohQ4cWbpulqZmZsC((object) column))).Select<Column, string>((System.Func<Column, string>) (column => (string) TransformationProvider.\u003C\u003Ec.gBlLIZQ4zt4Zem7nLbZk((object) column))).ToList<string>();

    /// <summary>Добавить таблицу</summary>
    /// <param name="name"></param>
    /// <param name="sequence"></param>
    /// <param name="isTemporary"></param>
    /// <param name="columns"></param>
    protected virtual void AddTable(
      string name,
      bool sequence,
      bool isTemporary,
      params Column[] columns)
    {
      int num = 16;
      Column column1;
      List<string> collection;
      string commaSeparatedString;
      Column[] columnArray;
      string str;
      List<string> primaryKeys;
      bool compoundPrimaryKey;
      int index;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 19:
            if (index < columnArray.Length)
            {
              num = 18;
              continue;
            }
            goto case 8;
          case 2:
            goto label_20;
          case 3:
            this.AddPrimaryKey((string) TransformationProvider.rjY3ySWT9JKkoqHPyZ5g((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333604964), (object) name), name, primaryKeys.ToArray());
            num = 2;
            continue;
          case 4:
            collection.Add(str);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 17 : 22;
            continue;
          case 5:
          case 18:
            column1 = columnArray[index];
            num = 9;
            continue;
          case 6:
            if (TransformationProvider.APvbZZWTd1XyT16Xdxra((object) column1))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 12 : 11;
              continue;
            }
            goto case 14;
          case 7:
            if (!compoundPrimaryKey)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 2 : 10;
              continue;
            }
            goto case 3;
          case 8:
            commaSeparatedString = collection.ToCommaSeparatedString<string>();
            num = 17;
            continue;
          case 9:
            if (compoundPrimaryKey)
            {
              num = 6;
              continue;
            }
            goto case 14;
          case 10:
            goto label_19;
          case 11:
            index = 0;
            num = 19;
            continue;
          case 12:
            Column column2 = column1;
            TransformationProvider.h37VAiWTrqwitMpDOOBo((object) column2, TransformationProvider.MYscFcWTlmJrEfaXpdvM((object) column2) | ColumnProperty.NotNull);
            num = 14;
            continue;
          case 13:
            goto label_12;
          case 14:
            str = (string) TransformationProvider.QIcOScWTSGccOlYsB2tk(TransformationProvider.c8afbIWTVMx7l6O9RAYA((object) this), (object) column1, compoundPrimaryKey);
            num = 4;
            continue;
          case 15:
            primaryKeys = this.GetPrimaryKeys((IEnumerable<Column>) columns);
            num = 20;
            continue;
          case 16:
            if (!this.TableExists(name))
            {
              num = 15;
              continue;
            }
            goto label_12;
          case 17:
            TransformationProvider.rMhHKUWTgnJkN1Fyki2f((object) this, (object) name, (object) commaSeparatedString, sequence, isTemporary);
            num = 7;
            continue;
          case 20:
            compoundPrimaryKey = primaryKeys.Count > 1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
            continue;
          case 21:
            columnArray = columns;
            num = 11;
            continue;
          case 22:
            ++index;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 1 : 0;
            continue;
          default:
            collection = new List<string>(columns.Length);
            num = 21;
            continue;
        }
      }
label_20:
      return;
label_19:
      return;
label_12:
      throw new DataException((string) TransformationProvider.rjY3ySWT9JKkoqHPyZ5g(TransformationProvider.Q25YMBWTI0IQHBaFpJSM(TransformationProvider.HUgsdnWXtd4YQwhnFhJx(1218962250 ^ 1218844524)), (object) name));
    }

    /// <summary>Добавить таблицу</summary>
    /// <param name="name">Имя таблицы</param>
    /// <param name="columns">Колонки</param>
    /// <param name="sequence">Создавать счётчик.</param>
    protected virtual void AddTable(string name, bool sequence, params Column[] columns)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.AddTable(name, sequence, false, columns);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Добавить таблицу</summary>
    /// <param name="table">Имя таблицы</param>
    /// <param name="columns">SQL-определения колонок</param>
    /// <param name="sequence">Добавить счётчик.</param>
    protected virtual void AddTable(string table, string columns, bool sequence)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            TransformationProvider.rMhHKUWTgnJkN1Fyki2f((object) this, (object) table, (object) columns, sequence, false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Добавить таблицу</summary>
    /// <param name="table"></param>
    /// <param name="columns"></param>
    /// <param name="sequence"></param>
    /// <param name="isTemporary"></param>
    protected virtual void AddTable(string table, string columns, bool sequence, bool isTemporary)
    {
      int num = 1;
      string sql;
      while (true)
      {
        switch (num)
        {
          case 1:
            sql = (string) TransformationProvider.MIVZl1WX97yyHeoixXXl(TransformationProvider.HUgsdnWXtd4YQwhnFhJx(-477139494 ^ -477270692), TransformationProvider.th4WuLWTCoficlLkMVib((object) this, (object) table), (object) columns);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.ExecuteNonQuery(sql, (Dictionary<string, object>) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Добавить первичный ключ к таблице</summary>
    /// <param name="name">Имя первичного ключа</param>
    /// <param name="table">Имя таблицы</param>
    /// <param name="columns">Имена колонок для первичного ключа</param>
    protected virtual void AddPrimaryKey(string name, string table, params string[] columns)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        TransformationProvider transformationProvider;
        string sql;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_3;
            case 1:
              if (TransformationProvider.AUe37iWTwCK8BTafFv9v((object) this, (object) table, (object) name))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
                continue;
              }
              sql = (string) TransformationProvider.lsc52dWTnSNR5IjpkEjk(TransformationProvider.HUgsdnWXtd4YQwhnFhJx(-2138160520 ^ -2138291506), TransformationProvider.th4WuLWTCoficlLkMVib((object) this, (object) table), TransformationProvider.th4WuLWTCoficlLkMVib((object) this, (object) name), (object) ((IEnumerable<string>) columns).Select<string, string>(new System.Func<string, string>(((TransformationProviderBase) this).QuoteIfNeeded)).ToCommaSeparatedString<string>());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 2 : 2;
              continue;
            case 2:
              goto label_8;
            case 3:
              goto label_6;
            case 4:
              transformationProvider = this;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 1 : 1;
              continue;
            case 5:
              num2 = 4;
              continue;
            default:
              goto label_11;
          }
        }
label_8:
        this.ExecuteWithTimeout(0, (System.Action) (() =>
        {
          int num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 0:
                goto label_2;
              case 1:
                transformationProvider.ExecuteNonQuery(sql, (Dictionary<string, object>) null);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
        num1 = 3;
      }
label_3:
      return;
label_6:
      return;
label_11:;
    }

    /// <summary>
    /// Проверить, что ограничение не существует. Если сущесвует - вызывается DataException
    /// </summary>
    /// <param name="table">Имя таблицы</param>
    /// <param name="name">Имя ограничения</param>
    protected void CheckConstraintNotExists(string table, string name)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (!TransformationProvider.AUe37iWTwCK8BTafFv9v((object) this, (object) table, (object) name))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_5:
      return;
label_4:
      throw new DataException((string) TransformationProvider.rjY3ySWT9JKkoqHPyZ5g(TransformationProvider.Q25YMBWTI0IQHBaFpJSM(TransformationProvider.HUgsdnWXtd4YQwhnFhJx(1149433385 + 173655049 ^ 1323219734)), (object) name));
    }

    /// <summary>Добавить колонку</summary>
    /// <param name="table">Имя таблицы</param>
    /// <param name="sqlColumn">SQL-определение колонки</param>
    /// <param name="columnName">Имя колонки</param>
    protected abstract void AddColumn(string table, string sqlColumn, string columnName);

    protected Dictionary<string, List<string>> ConvertItemNames(IList<string> itemNames)
    {
      Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
      if (itemNames == null)
        return dictionary;
      foreach (string itemName in (IEnumerable<string>) itemNames)
      {
        if (!string.IsNullOrEmpty(itemName))
        {
          string key = string.Empty;
          string upper = itemName.ToUpper();
          int length = itemName.IndexOf('.');
          if (length >= 0)
          {
            key = itemName.Substring(0, length).ToUpper();
            upper = itemName.Substring(length + 1).ToUpper();
          }
          List<string> stringList;
          if (!dictionary.TryGetValue(key, out stringList))
          {
            stringList = new List<string>();
            dictionary.Add(key, stringList);
          }
          if (upper != string.Empty && !stringList.Contains(upper))
            stringList.Add(upper);
        }
      }
      return dictionary;
    }

    protected bool ItemNameContains(Dictionary<string, List<string>> dict, string itemName)
    {
      itemName = itemName.ToUpper();
      if (dict != null)
      {
        foreach (List<string> stringList in dict.Values)
        {
          if (stringList.Contains(itemName))
            return true;
        }
      }
      return false;
    }

    protected bool ItemNameContains(
      Dictionary<string, List<string>> dict,
      string tableName,
      string itemName)
    {
      itemName = itemName.ToUpper();
      tableName = tableName != null ? tableName.ToUpper() : string.Empty;
      List<string> list;
      return dict.TryGetValue(tableName, out list) && this.ItemNameContains(list, itemName) || tableName != string.Empty && dict.TryGetValue(string.Empty, out list) && this.ItemNameContains(list, itemName);
    }

    /// <summary>
    /// Удалить имя временной колонки из списка временных колонок
    /// </summary>
    /// <param name="tableName">Название таблицы</param>
    /// <param name="temporaryName">Временная колонка</param>
    /// <returns>Оригинальная колонка, для которой создавалсь временная</returns>
    protected virtual string DeleteColumnTemporaryName(string tableName, string temporaryName)
    {
      int num = 6;
      List<Pair<string, string>> pairList;
      Pair<string, string> pair;
      string temporaryName1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_10;
          case 2:
            if (!pairList.Remove(pair))
            {
              num = 3;
              continue;
            }
            goto label_10;
          case 3:
            goto label_11;
          case 4:
            TransformationProvider.DxbkD1WXYwkIbPOn3hGI((object) tableName, TransformationProvider.HUgsdnWXtd4YQwhnFhJx(-787452571 ^ -787372601));
            num = 8;
            continue;
          case 5:
            temporaryName1 = temporaryName;
            num = 4;
            continue;
          case 6:
            num = 5;
            continue;
          case 7:
            if (this.temporaryColumnNames.TryGetValue((string) TransformationProvider.Jn4UQMWTek4uxF6h5VkE((object) tableName), out pairList))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
              continue;
            }
            goto label_11;
          case 8:
            Contract.ArgumentNotNull((object) temporaryName1, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -36126551));
            num = 7;
            continue;
          default:
            pair = pairList.Find((Predicate<Pair<string, string>>) (p => p.First == temporaryName1.ToUpper()));
            num = 2;
            continue;
        }
      }
label_10:
      return pair.Second;
label_11:
      return (string) null;
    }

    /// <summary>
    /// Удалить из списка удаляемых колонок инфомрацию о временной колонке
    /// </summary>
    /// <param name="tableName">Название таблицы</param>
    /// <param name="columnName">Удаляемая колонка</param>
    protected virtual void DeleteDeletingColumnTemporaryName(string tableName, string columnName)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        KeyValuePair<string, string> key;
        while (true)
        {
          switch (num2)
          {
            case 1:
              TransformationProvider.DxbkD1WXYwkIbPOn3hGI((object) tableName, TransformationProvider.HUgsdnWXtd4YQwhnFhJx(-1638402543 ^ -1638515021));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_3;
            case 3:
              key = new KeyValuePair<string, string>((string) TransformationProvider.Jn4UQMWTek4uxF6h5VkE((object) tableName), (string) TransformationProvider.Jn4UQMWTek4uxF6h5VkE((object) columnName));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 4 : 4;
              continue;
            case 4:
              this.deletingColumnNames.Remove(key);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 2 : 2;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        TransformationProvider.DxbkD1WXYwkIbPOn3hGI((object) columnName, TransformationProvider.HUgsdnWXtd4YQwhnFhJx(1304605005 ^ 1304645181));
        num1 = 3;
      }
label_3:;
    }

    protected virtual Regex CreateIndexPattern
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.createIndexPattern == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            case 2:
              goto label_5;
            default:
              this.createIndexPattern = new Regex((string) TransformationProvider.HUgsdnWXtd4YQwhnFhJx(1021410165 ^ 1021541101), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 2 : 2;
              continue;
          }
        }
label_5:
        return this.createIndexPattern;
      }
    }

    /// <summary>Формирование имени sql-параметра</summary>
    /// <param name="args">Список строки чисел</param>
    /// <returns>Наименование параметра</returns>
    protected string CreateParamName(params object[] args) => TransformationProvider.ParamPrefix + string.Concat(args);

    private bool ItemNameContains(List<string> list, string name)
    {
      foreach (string str1 in list)
      {
        if (str1.EndsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(323422137 << 2 ^ 1293700276)))
        {
          string str2 = str1.Substring(0, str1.Length - 1);
          if (name.StartsWith(str2, StringComparison.CurrentCultureIgnoreCase))
            return true;
        }
        else if (name.Equals(str1, StringComparison.CurrentCultureIgnoreCase))
          return true;
      }
      return false;
    }

    protected void ExecuteMethod(
      IList<string> skipNames,
      IList<string> useNames,
      IEnumerable<KeyValuePair<string, string>> items,
      Action<KeyValuePair<string, string>> itemAction)
    {
      Dictionary<string, List<string>> dict1 = this.ConvertItemNames(skipNames);
      Dictionary<string, List<string>> dict2 = useNames != null ? this.ConvertItemNames(useNames) : (Dictionary<string, List<string>>) null;
      foreach (KeyValuePair<string, string> keyValuePair in items)
      {
        if (!this.ItemNameContains(dict1, keyValuePair.Key, keyValuePair.Value) && (dict2 == null || this.ItemNameContains(dict2, keyValuePair.Key, keyValuePair.Value)))
          itemAction(keyValuePair);
      }
    }

    protected void ExecuteMethod(
      IList<string> skipNames,
      IList<string> useNames,
      List<string> items,
      Action<string> itemAction)
    {
      Dictionary<string, List<string>> dict1 = this.ConvertItemNames(skipNames);
      Dictionary<string, List<string>> dict2 = useNames != null ? this.ConvertItemNames(useNames) : (Dictionary<string, List<string>>) null;
      foreach (string str in items)
      {
        if (!str.IsNullOrWhiteSpace() && (!this.ItemNameContains(dict1, str) && dict2 == null || this.ItemNameContains(dict2, str)))
          itemAction(str);
      }
    }

    private int GetDeadlockRetryInterval()
    {
      int num = 3;
      int setting;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (setting > 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 3:
            setting = EleWise.ELMA.SR.GetSetting<int>((string) TransformationProvider.HUgsdnWXtd4YQwhnFhJx(-1978478350 ^ -1978608954), 300);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 2;
            continue;
          default:
            goto label_6;
        }
      }
label_5:
      return 300;
label_6:
      return setting;
    }

    private int GetDeadlockRetryIntervalDeviation()
    {
      int num1 = 2;
      int setting;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_6;
            case 2:
              setting = EleWise.ELMA.SR.GetSetting<int>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1319452732 ^ 1319584428), 20);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_4;
            default:
              goto label_3;
          }
        }
label_6:
        if (setting > 0)
          num1 = 3;
        else
          break;
      }
label_3:
      return 20;
label_4:
      return setting;
    }

    private int GetDeadlockRetryAttempt()
    {
      int num = 1;
      int setting;
      while (true)
      {
        switch (num)
        {
          case 1:
            setting = EleWise.ELMA.SR.GetSetting<int>((string) TransformationProvider.HUgsdnWXtd4YQwhnFhJx(1199946765 ^ 1200078579), 20);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          case 3:
            goto label_6;
          default:
            if (setting > 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 1 : 3;
              continue;
            }
            goto label_5;
        }
      }
label_5:
      return 20;
label_6:
      return setting;
    }

    /// <inheritdoc />
    public abstract void BulkInsert(string tableName, DataTable data);

    /// <inheritdoc />
    public abstract void BulkInsert(string tableName, DataTable data, bool shouldGenerateId);

    /// <inheritdoc />
    public abstract void BulkUpdate(string tableName, DataTable data);

    /// <inheritdoc />
    public abstract void BulkUpdate(string tableName, DataTable data, string keyColumn);

    /// <inheritdoc />
    public abstract void BulkUpdate(string tableName, DataTable data, List<ColumnLink> keyColumns);

    /// <inheritdoc />
    public virtual long ReserveId(int count, string tableName) => this.ReserveIds(count, tableName)[0];

    /// <inheritdoc />
    public virtual long[] ReserveIds(int count, string tableName) => new long[0];

    /// <summary>
    /// Сгенерировать идентификатор для таблицы, созданной с Sequence = true
    /// </summary>
    /// <param name="count">Количество идентификаторов</param>
    /// <param name="table">Имя таблицы</param>
    /// <param name="createGenerator">Создание генератора</param>
    /// <param name="reserveIdRange">Функция формирования диапазона идентификаторов</param>
    /// <returns>Идентификаторы</returns>
    protected internal virtual long[] ReserveIds(
      int count,
      string table,
      System.Func<Dictionary<string, string>, IIdentifierGenerator> createGenerator,
      Func<long[]> reserveIdRange)
    {
      if (count < 1)
        return new long[1];
      if (createGenerator == null || count > 100 || this.SessionProvider == null)
        return reserveIdRange();
      IIdentifierGenerator gen = this.generatorMap.GetOrAdd(table, (System.Func<string, IIdentifierGenerator>) (_ =>
      {
        int num = 5;
        IIdentifierGenerator identifierGenerator;
        Int64Type int64;
        Dictionary<string, string> parms;
        NHibernate.Dialect.Dialect dialect;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!(identifierGenerator is IConfigurable))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
                continue;
              }
              goto case 6;
            case 3:
              identifierGenerator = createGenerator(parms);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 1 : 1;
              continue;
            case 4:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              dialect = (NHibernate.Dialect.Dialect) TransformationProvider.\u003C\u003Ec__DisplayClass169_0.zIDQ8wQHSkVXEPXFZEkW(TransformationProvider.\u003C\u003Ec__DisplayClass169_0.TRMXPYQHVhA1FTEvtsvn(TransformationProvider.\u003C\u003Ec__DisplayClass169_0.yhaRkYQHILxDJj7BR35C((object) this.Session)));
              num = 7;
              continue;
            case 5:
              int64 = NHibernateUtil.Int64;
              num = 4;
              continue;
            case 6:
              ((IConfigurable) identifierGenerator).Configure((IType) int64, (IDictionary<string, string>) parms, dialect);
              num = 2;
              continue;
            case 7:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              parms = new Dictionary<string, string>()
              {
                {
                  (string) TransformationProvider.\u003C\u003Ec__DisplayClass169_0.sMynCFQHifvDQKratt8J(-1334993905 ^ -1334857653),
                  100.ToString()
                },
                {
                  (string) TransformationProvider.\u003C\u003Ec__DisplayClass169_0.sMynCFQHifvDQKratt8J(~289714581 ^ -289525602),
                  (string) TransformationProvider.\u003C\u003Ec__DisplayClass169_0.eA1EgXQHR7pb5KTYjZAE(TransformationProvider.\u003C\u003Ec__DisplayClass169_0.sMynCFQHifvDQKratt8J(-1638402543 ^ -1638758119), (object) table)
                }
              };
              num = 3;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        return identifierGenerator;
      }));
      // ISSUE: reference to a compiler-generated method
      return Enumerable.Range(0, count).Select<int, long>((System.Func<int, long>) (_ => Convert.ToInt64(TransformationProvider.\u003C\u003Ec__DisplayClass169_1.qoRde0QHk6CaPJjjVfAG((object) gen, (object) this.Session.GetSessionImplementation(), (object) null)))).ToArray<long>();
    }

    /// <inheritdoc />
    public virtual int BulkDelete(
      string table,
      string where,
      Dictionary<string, object> paramValues = null)
    {
      return this.BulkDeleteBaseAsync(table, where, paramValues, false).GetAwaiter().GetResult();
    }

    /// <inheritdoc />
    public abstract int BulkDelete(BulkDeleteArg arg);

    static TransformationProvider()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            TransformationProvider.ParamPrefix = (string) TransformationProvider.HUgsdnWXtd4YQwhnFhJx(~541731958 ^ -541779631);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void FinqLEWX3lSUqg2BApY8() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool DBxeZKWX1j5N7PFfroFt() => TransformationProvider.wcFITEWXPCkPiH2YAHD9 == null;

    internal static TransformationProvider m79CTIWXNlRuF5JEXc4L() => TransformationProvider.wcFITEWXPCkPiH2YAHD9;

    internal static object YJmYaUWXpkCxM7UlB5Wm([In] object obj0) => (object) ((IDbCommand) obj0).Transaction;

    internal static void OliiwoWXaQgkaARVX1Wd([In] object obj0, [In] object obj1, [In] object obj2) => ((TransformationProvider) obj0).ReleaseSavePoint((string) obj1, (IDbTransaction) obj2);

    internal static void dLqK9pWXDmMSlZJ2GXds([In] object obj0, [In] object obj1, [In] object obj2) => ((TransformationProvider) obj0).RollBackSavePoint((string) obj1, (IDbTransaction) obj2);

    internal static object HUgsdnWXtd4YQwhnFhJx(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object CJeeJhWXweptRXYaopFG([In] object obj0) => (object) ((DataTable) obj0).Columns;

    internal static object UVI86HWX4EmckK8ScyJW([In] object obj0, [In] int obj1) => (object) ((DataColumnCollection) obj0)[obj1];

    internal static System.Type kcFGHvWX66UvSiChBiyq([In] RuntimeTypeHandle obj0) => System.Type.GetTypeFromHandle(obj0);

    internal static bool QeAKL1WXHUwqREmbDkwE([In] System.Type obj0, [In] System.Type obj1) => obj0 == obj1;

    internal static System.Type Mlg9vNWXAs0Ma7K68RZC([In] object obj0) => ((DataColumn) obj0).DataType;

    internal static object E7t1xUWX7tjRWJMbbWlJ([In] object obj0, [In] int obj1) => (object) ((DataRowCollection) obj0)[obj1];

    internal static object hsbE9AWXxjXfEwYGMQdG([In] object obj0, [In] int obj1) => ((DataRow) obj0)[obj1];

    internal static object BIWfC6WX0hRBpYo8n0PL([In] object obj0) => (object) ((DataTable) obj0).Rows;

    internal static void eleATJWXmN1S24iKZntv([In] object obj0, [In] int obj1, [In] object obj2) => ((DataRow) obj0)[obj1] = obj2;

    internal static int JMy7CMWXymvbGnvfVYGe([In] object obj0) => ((InternalDataCollectionBase) obj0).Count;

    internal static int Qe1UqsWXMuEGJHxTGPQa(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3,
      bool isNeedInsertId)
    {
      return ((TransformationProvider) obj0).Insert((string) obj1, (string[]) obj2, (object[]) obj3, isNeedInsertId);
    }

    internal static object mNbVhyWXJlS2ZRZuSPDn([In] object obj0, [In] object obj1) => (object) ((EleWise.ELMA.Runtime.Db.Migrator.Providers.Dialect) obj0).QuoteIfNeeded((string) obj1);

    internal static object MIVZl1WX97yyHeoixXXl([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object gQrq12WXdI1DBTA9QAnw([In] object obj0) => (object) TransformationProvider.UniversalProcedureNameFromText((string) obj0);

    internal static object fdSUInWXlyd5IiP4m0Hg([In] object obj0, [In] object obj1) => (object) ((string) obj0).Split((char[]) obj1);

    internal static object S8rGWYWXrF4VAcFTKwda([In] object obj0) => (object) ((Match) obj0).Groups;

    internal static object kmh2MvWXgGLA0274iWAh([In] object obj0, [In] object obj1) => (object) ((GroupCollection) obj0)[(string) obj1];

    internal static object Dfm11pWX5Y3xSpKfLslA([In] object obj0, [In] object obj1) => (object) ((EleWise.ELMA.Runtime.Db.Migrator.Providers.Dialect) obj0).UnquoteIfNeeded((string) obj1);

    internal static void TflSjaWXjlASCOfTFeHd([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Runtime.Db.Migrator.Framework.Index) obj0).TableName = (string) obj1;

    internal static void DxbkD1WXYwkIbPOn3hGI([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void V0xc5GWXL3eROm9gowxL([In] object obj0) => ((System.Action) obj0)();

    internal static bool ygDWIqWXUspv6MwfURB8([In] object obj0, [In] object obj1) => ((TransformationProvider) obj0).CanRetryAfterException((Exception) obj1);

    internal static bool Qjkgh0WXsTl21FPTg7cY([In] object obj0, [In] object obj1) => ((TransformationProvider) obj0).IsUnrecoverableException((Exception) obj1);

    internal static bool JHu6bWWXcTR0O9eAN2o1() => Locator.Initialized;

    internal static void mfA4npWXz4xYBkcEKRuB([In] object obj0, [In] object obj1) => ((IUnitOfWorkManager) obj0).ThrowExceptionOnCommit((Exception) obj1);

    internal static object u1wMVyWTFhpnnJljCOx5([In] object obj0) => (object) ((string) obj0).ToLower();

    internal static object fdCCJlWTBrZR2RsSvHeg([In] object obj0, [In] object obj1) => (object) Regex.Match((string) obj0, (string) obj1);

    internal static object iIQIHnWTWgpyKXtg5Ewd([In] object obj0) => (object) ((string) obj0).Trim();

    internal static bool yycXYfWToQIxQ7weEJlH([In] object obj0, [In] object obj1) => ((string) obj0).Contains((string) obj1);

    internal static bool NtxsCmWTb5ujoVSPXxYO([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object gui2SsWThpT7B06k87Ym([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static bool lkeTLeWTGwaIL6RTDXUu([In] object obj0) => ((Group) obj0).Success;

    internal static object F7xFSPWTE3q2t6KOtGdb([In] object obj0, [In] object obj1, [In] StringSplitOptions obj2) => (object) ((string) obj0).Split((string[]) obj1, obj2);

    internal static bool zZGY93WTfSD03hNLBG9s([In] object obj0) => ((Table) obj0).Sequence;

    internal static bool vB2EWyWTQwj49jAPyyvy([In] object obj0) => ((Table) obj0).IsTemporary;

    internal static object th4WuLWTCoficlLkMVib([In] object obj0, [In] object obj1) => (object) ((TransformationProviderBase) obj0).QuoteIfNeeded((string) obj1);

    internal static object eUWIxXWTvUXwcluM0RN1([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static void fVlMmMWT8LuO0H3irfrY([In] object obj0, [In] object obj1) => Contract.ArgumentNotNullOrEmpty((string) obj0, (string) obj1);

    internal static object tiI7oaWTZKB0MmbbtxwA([In] object obj0) => (object) ((Column) obj0).Name;

    internal static bool BcOadbWTu2aBFD9YVqO9([In] object obj0, [In] object obj1, [In] object obj2) => ((TransformationProvider) obj0).ColumnExists((string) obj1, (string) obj2);

    internal static object Q25YMBWTI0IQHBaFpJSM([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object c8afbIWTVMx7l6O9RAYA([In] object obj0) => (object) ((TransformationProviderBase) obj0).Dialect;

    internal static object QIcOScWTSGccOlYsB2tk([In] object obj0, [In] object obj1, bool compoundPrimaryKey) => (object) ((EleWise.ELMA.Runtime.Db.Migrator.Providers.Dialect) obj0).GetColumnSql((Column) obj1, compoundPrimaryKey);

    internal static void fEeL7JWTipjVFsiraghx([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((TransformationProvider) obj0).AddColumn((string) obj1, (string) obj2, (string) obj3);

    internal static object SW5TQbWTRQiALaZTJyow([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((TransformationProvider) obj0).DeleteColumnTemporaryName((string) obj1, (string) obj2);

    internal static object aOiKVJWTqa8YmGEkqbMP([In] object obj0) => (object) ((Column) obj0).ColumnType;

    internal static void M34GdGWTK2w7GnJdjXXq(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      int columnSize,
      bool substringStrings)
    {
      ((TransformationProvider) obj0).ConvertColumnString((string) obj1, (string) obj2, columnSize, substringStrings);
    }

    internal static bool QKTOkiWTXpqniq8J75xn([In] object obj0, [In] object obj1) => ((TransformationProvider) obj0).TableExists((string) obj1);

    internal static void wHjXj9WTTxTFIWxY5oBI([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((TransformationProvider) obj0).RenameColumn((string) obj1, (string) obj2, (string) obj3);

    internal static void qw135nWTkujsqlYvoCK8([In] object obj0, [In] object obj1, [In] object obj2) => ((TransformationProvider) obj0).AddColumn((string) obj1, (Column) obj2);

    internal static object lsc52dWTnSNR5IjpkEjk(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) string.Format((string) obj0, obj1, obj2, obj3);
    }

    internal static bool apQ6i5WTOht9x51VqZ1q([In] object obj0, [In] object obj1, [In] object obj2) => ((TransformationProvider) obj0).NeedStringColumnTransform((string) obj1, (string) obj2);

    internal static void AgHKpJWT2cf4s4Vkp062(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      int columnSize)
    {
      ((TransformationProvider) obj0).ConvertColumnString((string) obj1, (string) obj2, columnSize);
    }

    internal static object Jn4UQMWTek4uxF6h5VkE([In] object obj0) => (object) ((string) obj0).ToUpper();

    internal static object RPFKGhWTPJVyHgXFQuik([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((TransformationProvider) obj0).GenerateColumnTemporaryName((string) obj1, (string) obj2);

    internal static int M02wnCWT1cvi6iMqZWuF([In] object obj0) => ((string) obj0).Length;

    internal static object APrideWTNw058Md1SOJi([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object G6qBvPWT33TL3lyoqYIU([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static object a7D8cxWTpTmTRWQiPyOT([In] object obj0) => (object) ((ForeignKey) obj0).TableName;

    internal static object iipkVfWTanfGoKphhPBI([In] object obj0, EleWise.ELMA.Runtime.Db.Migrator.Framework.ForeignKeyConstraint constraint) => (object) ((ForeignKeyConstraintMapper) obj0).SqlForConstraint(constraint);

    internal static object JfvglTWTDhek8QggO44p([In] object obj0) => (object) ((PrimaryKey) obj0).TableName;

    internal static object FGAdBZWTtYkIGidQptRN([In] object obj0) => (object) ((List<string>) obj0).ToArray();

    internal static bool AUe37iWTwCK8BTafFv9v([In] object obj0, [In] object obj1, [In] object obj2) => ((TransformationProvider) obj0).ConstraintExists((string) obj1, (string) obj2);

    internal static bool Dy6BhLWT4Ibx0VoZBox6([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).StartsWith((string) obj1, obj2);

    internal static object NlYql1WT6YapEQiOCZcE([In] object obj0, [In] int obj1) => (object) ((string) obj0).Substring(obj1);

    internal static void okCqYYWTHxKYAoP4Ftv6([In] object obj0, [In] object obj1) => ((TransformationProvider) obj0).AddIndex((EleWise.ELMA.Runtime.Db.Migrator.Framework.Index) obj1);

    internal static Guid LjGZCcWTAT4yFW5bpbvU() => Guid.NewGuid();

    internal static object RpOH9hWT7HNgRPEDtRjg([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static object paEffGWTxpKWVy7C0KGW([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).Append((string) obj1);

    internal static object I2RZT7WT0DaunAb21A5A([In] object obj0) => (object) ((TransformationProviderBase) obj0).Connection;

    internal static void NErxTEWTmb9CKE36MhPL([In] object obj0) => ((IDbConnection) obj0).Open();

    internal static object Q0cHoIWTyo0TxkhqDJGe([In] object obj0) => (object) ((ISession) obj0).GetSessionImplementation();

    internal static object YqTfu3WTMBZx7he1c7gT(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return ((NullableType) obj0).NullSafeGet((DbDataReader) obj1, (string) obj2, (ISessionImplementor) obj3);
    }

    internal static CancellationToken tSBP0BWTJdFa0uRBw4ey() => CancellationToken.None;

    internal static object rjY3ySWT9JKkoqHPyZ5g([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static bool APvbZZWTd1XyT16Xdxra([In] object obj0) => ((Column) obj0).IsPrimaryKey;

    internal static ColumnProperty MYscFcWTlmJrEfaXpdvM([In] object obj0) => ((Column) obj0).ColumnProperty;

    internal static void h37VAiWTrqwitMpDOOBo([In] object obj0, ColumnProperty value) => ((Column) obj0).ColumnProperty = value;

    internal static void rMhHKUWTgnJkN1Fyki2f(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      bool sequence,
      bool isTemporary)
    {
      ((TransformationProvider) obj0).AddTable((string) obj1, (string) obj2, sequence, isTemporary);
    }

    internal static void yIoVZ6WT5JCAZw4B0qj7([In] object obj0, [In] object obj1) => ((TransformationProvider) obj0).RemoveProcedure((string) obj1);

    internal static void v0MtnoWTjH1ul91eqxUZ([In] object obj0, [In] object obj1) => ((TransformationProvider) obj0).RemoveView((string) obj1);
  }
}
