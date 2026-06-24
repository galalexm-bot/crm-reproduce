// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.Id.IdentityHiLoFromTableGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using NHibernate.AdoNet.Util;
using NHibernate.Connection;
using NHibernate.Driver;
using NHibernate.Engine;
using NHibernate.Id;
using NHibernate.Mapping.ByCode;
using NHibernate.SqlCommand;
using NHibernate.SqlTypes;
using NHibernate.Type;
using NHibernate.Util;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime.NH.Id
{
  /// <summary>
  /// An <see cref="T:NHibernate.Id.IIdentifierGenerator" /> that uses a database table to store the last
  /// generated value.
  /// </summary>
  /// <remarks>
  /// <p>
  /// It is not intended that applications use this strategy directly. However,
  /// it may be used to build other (efficient) strategies. The return type is
  /// <c>System.Int32</c>
  /// </p>
  /// <p>
  /// The hi value MUST be fetched in a seperate transaction to the <c>ISession</c>
  /// transaction so the generator must be able to obtain a new connection and commit it.
  /// Hence this implementation may not be used when the user is supplying connections.
  /// </p>
  /// <p>
  /// The mapping parameters <c>table</c> and <c>column</c> are required.
  /// </p>
  /// </remarks>
  public class IdentityHiLoFromTableGenerator : 
    TransactionHelper,
    IPersistentIdentifierGenerator,
    IIdentifierGenerator,
    IConfigurable
  {
    private static readonly ILogger Log;
    /// <summary>
    /// An additional where clause that is added to
    /// the queries against the table.
    /// </summary>
    public const string WhereParamName = "where";
    /// <summary>The name of the column parameter.</summary>
    public const string ColumnParamName = "column";
    /// <summary>The name of the column from where parameter.</summary>
    public const string WhereColumnParamName = "whereColumn";
    /// <summary>The value from where parameter.</summary>
    public const string WhereValueParamName = "whereValue";
    /// <summary>The name of the table parameter.</summary>
    public const string TableParamName = "table";
    /// <summary>The name of the maximum low value parameter.</summary>
    public const string MaxLoParamName = "max_lo";
    /// <summary>Default column name </summary>
    public const string DefaultColumnName = "NextValue";
    /// <summary>Default table name </summary>
    public const string DefaultTableName = "Sys_TableGenerators";
    private long hi;
    private long lo;
    private long maxLo;
    private System.Type returnClass;
    private string tableName;
    private string columnName;
    private string whereColumnName;
    private string whereValue;
    private string whereClause;
    private string query;
    protected SqlType ColumnSqlType;
    protected PrimitiveType ColumnType;
    private SqlString updateSql;
    private SqlType[] parameterTypes;
    private static IGeneratorDef generatorDef;
    internal static IdentityHiLoFromTableGenerator hoF7nNWytsJdVxM74BsT;

    /// <inheritdoc />
    public async Task<object> GenerateAsync(
      ISessionImplementor session,
      object obj,
      CancellationToken cancellationToken)
    {
      int num1 = 1;
      object result;
      int num2;
      IdentityHiLoFromTableGenerator fromTableGenerator1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
            continue;
          case 2:
label_3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = 5;
            continue;
          case 3:
            goto label_59;
          case 4:
            try
            {
              TaskAwaiter<object> taskAwaiter;
              TaskAwaiter<object> awaiter;
              int num3;
              switch (num2)
              {
                case 0:
label_36:
                  awaiter = taskAwaiter;
                  num3 = 14;
                  break;
                case 1:
label_22:
                  awaiter = taskAwaiter;
                  num3 = 29;
                  break;
                case 2:
label_27:
                  awaiter = taskAwaiter;
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 15 : 0;
                  break;
                default:
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 27 : 37;
                  break;
              }
              while (true)
              {
                int num4;
                long num5;
                long num6;
                switch (num3)
                {
                  case 1:
                    goto label_56;
                  case 2:
                    // ISSUE: reference to a compiler-generated method
                    result = IdentityHiLoFromTableGenerator.\u003CGenerateAsync\u003Ed__0.tjvLJjQLvjpA93PAUdvq(num6, fromTableGenerator1.returnClass);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 6 : 20;
                    continue;
                  case 3:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, IdentityHiLoFromTableGenerator.\u003CGenerateAsync\u003Ed__0>(ref awaiter, this);
                    num3 = 13;
                    continue;
                  case 4:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 2;
                    num3 = 43;
                    continue;
                  case 5:
                    awaiter = fromTableGenerator1.DoWorkInNewTransactionAsync(session, cancellationToken).GetAwaiter();
                    num3 = 39;
                    continue;
                  case 6:
                    goto label_22;
                  case 7:
                  case 25:
                    if (fromTableGenerator1.lo <= fromTableGenerator1.maxLo)
                    {
                      num3 = 17;
                      continue;
                    }
                    goto case 40;
                  case 8:
                  case 10:
                    num6 = Convert.ToInt64(awaiter.GetResult());
                    num3 = 2;
                    continue;
                  case 9:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    IdentityHiLoFromTableGenerator.Log.Debug(IdentityHiLoFromTableGenerator.\u003CGenerateAsync\u003Ed__0.O9cLl6QLZ4J2XOpxhPSm(IdentityHiLoFromTableGenerator.\u003CGenerateAsync\u003Ed__0.WDYVsdQL8vKANOe3oBZE(272623989 ^ 272483555), (object) num5));
                    num3 = 12;
                    continue;
                  case 11:
                    taskAwaiter = awaiter;
                    num3 = 33;
                    continue;
                  case 12:
                  case 17:
                    long hi = fromTableGenerator1.hi;
                    IdentityHiLoFromTableGenerator fromTableGenerator2 = fromTableGenerator1;
                    long lo = fromTableGenerator1.lo;
                    long num7 = lo + 1L;
                    fromTableGenerator2.lo = num7;
                    long num8 = lo;
                    result = IdentifierGeneratorFactory.CreateNumber(hi + num8, fromTableGenerator1.returnClass);
                    num4 = 38;
                    break;
                  case 13:
                    goto label_52;
                  case 14:
                    taskAwaiter = new TaskAwaiter<object>();
                    num3 = 27;
                    continue;
                  case 15:
                    taskAwaiter = new TaskAwaiter<object>();
                    num3 = 42;
                    continue;
                  case 16:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 1;
                    num3 = 11;
                    continue;
                  case 18:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = 8;
                    continue;
                  case 19:
                    goto label_36;
                  case 20:
                  case 38:
                    goto label_3;
                  case 21:
                    if (num6 == 0L)
                    {
                      num3 = 5;
                      continue;
                    }
                    goto case 2;
                  case 22:
                    fromTableGenerator1.lo = num5 == 0L ? 1L : 0L;
                    num3 = 28;
                    continue;
                  case 23:
                    if (awaiter.IsCompleted)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 13 : 26;
                      continue;
                    }
                    goto case 4;
                  case 24:
                    taskAwaiter = awaiter;
                    num4 = 41;
                    break;
                  case 26:
                  case 34:
                    // ISSUE: reference to a compiler-generated method
                    num5 = IdentityHiLoFromTableGenerator.\u003CGenerateAsync\u003Ed__0.p8T3jNQLCwh64SX6eGsw(awaiter.GetResult());
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 3 : 22;
                    continue;
                  case 27:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = 35;
                    continue;
                  case 28:
                    fromTableGenerator1.hi = num5;
                    num3 = 9;
                    continue;
                  case 29:
                    taskAwaiter = new TaskAwaiter<object>();
                    num3 = 18;
                    continue;
                  case 30:
                    awaiter = fromTableGenerator1.DoWorkInNewTransactionAsync(session, cancellationToken).GetAwaiter();
                    num4 = 36;
                    break;
                  case 31:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 2 : 24;
                    continue;
                  case 32:
                    goto label_46;
                  case 33:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, IdentityHiLoFromTableGenerator.\u003CGenerateAsync\u003Ed__0>(ref awaiter, this);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 1;
                    continue;
                  case 35:
                    // ISSUE: reference to a compiler-generated method
                    num6 = IdentityHiLoFromTableGenerator.\u003CGenerateAsync\u003Ed__0.p8T3jNQLCwh64SX6eGsw(awaiter.GetResult());
                    num3 = 21;
                    continue;
                  case 36:
                    if (!awaiter.IsCompleted)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 31 : 4;
                      continue;
                    }
                    goto case 35;
                  case 37:
                    if (fromTableGenerator1.maxLo >= 1L)
                    {
                      num3 = 7;
                      continue;
                    }
                    goto case 30;
                  case 39:
                    if (awaiter.IsCompleted)
                    {
                      num3 = 10;
                      continue;
                    }
                    goto case 16;
                  case 40:
                    awaiter = fromTableGenerator1.DoWorkInNewTransactionAsync(session, cancellationToken).GetAwaiter();
                    num4 = 23;
                    break;
                  case 41:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, IdentityHiLoFromTableGenerator.\u003CGenerateAsync\u003Ed__0>(ref awaiter, this);
                    num3 = 32;
                    continue;
                  case 42:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = 34;
                    continue;
                  case 43:
                    taskAwaiter = awaiter;
                    num3 = 3;
                    continue;
                  default:
                    goto label_27;
                }
                num3 = num4;
              }
label_56:
              return;
label_52:
              return;
label_46:
              return;
            }
            catch (Exception ex)
            {
              int num9 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
                num9 = 1;
              while (true)
              {
                switch (num9)
                {
                  case 0:
                    goto label_45;
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num9 = 2;
                    continue;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_41;
                }
              }
label_45:
              return;
label_41:
              return;
            }
          case 5:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result);
            num1 = 3;
            continue;
          default:
            fromTableGenerator1 = this;
            num1 = 4;
            continue;
        }
      }
label_59:;
    }

    /// <inheritdoc />
    public override async Task<object> DoWorkInCurrentTransactionAsync(
      ISessionImplementor session,
      DbConnection conn,
      DbTransaction transaction,
      CancellationToken cancellationToken)
    {
      int num1 = 1;
      object result1;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_114;
          case 3:
label_3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 5 : 3;
            continue;
          case 4:
            try
            {
              int num3;
              if ((uint) num2 <= 1U)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 19 : 20;
              else
                goto label_13;
label_7:
              while (true)
              {
                long result;
                DbCommand qps;
                DbDataReader rs;
                DbCommand ups;
                int result2;
                switch (num3)
                {
                  case 1:
                  case 20:
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 14 : 5;
                    continue;
                  case 2:
                    rs = (DbDataReader) null;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 13 : 3;
                    continue;
                  case 3:
                    rs = (DbDataReader) null;
                    num3 = 16;
                    continue;
                  case 4:
                    // ISSUE: reference to a compiler-generated method
                    IdentityHiLoFromTableGenerator.\u003CDoWorkInCurrentTransactionAsync\u003Ed__1.UTaFpMQLRw2PBcGwRUCS((object) qps, (object) transaction);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 8 : 18;
                    continue;
                  case 5:
label_19:
                    qps = (DbCommand) null;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 2 : 0;
                    continue;
                  case 6:
                    if (result2 == 0)
                    {
                      num3 = 7;
                      continue;
                    }
                    break;
                  case 7:
                  case 8:
                    // ISSUE: reference to a compiler-generated method
                    qps = (DbCommand) IdentityHiLoFromTableGenerator.\u003CDoWorkInCurrentTransactionAsync\u003Ed__1.xDJOMJQLS9n3SefTw9Wt((object) conn);
                    num3 = 3;
                    continue;
                  case 9:
                    // ISSUE: reference to a compiler-generated method
                    IdentityHiLoFromTableGenerator.\u003CDoWorkInCurrentTransactionAsync\u003Ed__1.UTaFpMQLRw2PBcGwRUCS((object) ups, (object) transaction);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 1 : 12;
                    continue;
                  case 10:
label_50:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    ups = (DbCommand) IdentityHiLoFromTableGenerator.\u003CDoWorkInCurrentTransactionAsync\u003Ed__1.GEaXJgQL1bClb7vgHxQA(IdentityHiLoFromTableGenerator.\u003CDoWorkInCurrentTransactionAsync\u003Ed__1.h4mFiHQLPlFXZDZ5vGoF((object) ((ISessionFactoryImplementor) IdentityHiLoFromTableGenerator.\u003CDoWorkInCurrentTransactionAsync\u003Ed__1.PcGvqRQLeCcBGMx7a4NL((object) session)).ConnectionProvider), CommandType.Text, (object) this.updateSql, (object) this.parameterTypes);
                    num3 = 21;
                    continue;
                  case 11:
                    try
                    {
                      int num4;
                      if (num2 != 2)
                        num4 = 5;
                      else
                        goto label_31;
label_24:
                      TaskAwaiter<int> taskAwaiter;
                      TaskAwaiter<int> awaiter;
                      while (true)
                      {
                        switch (num4)
                        {
                          case 1:
                            if (awaiter.IsCompleted)
                            {
                              num4 = 8;
                              continue;
                            }
                            break;
                          case 2:
                            awaiter = ups.ExecuteNonQueryAsync(cancellationToken).GetAwaiter();
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 1;
                            continue;
                          case 3:
                            goto label_19;
                          case 4:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003E1__state = num2 = -1;
                            num4 = 12;
                            continue;
                          case 5:
                            // ISSUE: reference to a compiler-generated method
                            IdentityHiLoFromTableGenerator.\u003CDoWorkInCurrentTransactionAsync\u003Ed__1.MybN2WQL3yRMhvcGPY9j((object) this.ColumnType, (object) ups, (object) (result + (this.maxLo > 0L ? this.maxLo + 1L : 1L)), 0, (object) session);
                            num4 = 11;
                            continue;
                          case 6:
                            taskAwaiter = awaiter;
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 13 : 10;
                            continue;
                          case 7:
                            // ISSUE: reference to a compiler-generated method
                            // ISSUE: reference to a compiler-generated method
                            IdentityHiLoFromTableGenerator.\u003CDoWorkInCurrentTransactionAsync\u003Ed__1.N8NccgQLq0VI83PaU46a((object) PersistentIdGeneratorParmsNames.SqlStatementLogger, IdentityHiLoFromTableGenerator.\u003CDoWorkInCurrentTransactionAsync\u003Ed__1.HvgOH4QLTIXXHh4QLvOr(--1867379187 ^ 1867505369), (object) ups, (object) FormatStyle.Basic);
                            num4 = 2;
                            continue;
                          case 8:
                          case 12:
                            result2 = awaiter.GetResult();
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 2 : 3;
                            continue;
                          case 9:
                            goto label_31;
                          case 10:
                            goto label_111;
                          case 11:
                            // ISSUE: reference to a compiler-generated method
                            IdentityHiLoFromTableGenerator.\u003CDoWorkInCurrentTransactionAsync\u003Ed__1.MybN2WQL3yRMhvcGPY9j((object) this.ColumnType, (object) ups, (object) result, 1, (object) session);
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 7 : 2;
                            continue;
                          case 13:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, IdentityHiLoFromTableGenerator.\u003CDoWorkInCurrentTransactionAsync\u003Ed__1>(ref awaiter, this);
                            num4 = 10;
                            continue;
                          case 14:
                            taskAwaiter = new TaskAwaiter<int>();
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 3 : 4;
                            continue;
                        }
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003E1__state = num2 = 2;
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 6 : 3;
                      }
label_111:
                      return;
label_31:
                      awaiter = taskAwaiter;
                      num4 = 14;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
                      {
                        num4 = 7;
                        goto label_24;
                      }
                      else
                        goto label_24;
                    }
                    catch (Exception ex)
                    {
                      int num5 = 1;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
                        num5 = 1;
                      while (true)
                      {
                        switch (num5)
                        {
                          case 1:
                            // ISSUE: reference to a compiler-generated method
                            // ISSUE: reference to a compiler-generated method
                            // ISSUE: reference to a compiler-generated method
                            IdentityHiLoFromTableGenerator.\u003CDoWorkInCurrentTransactionAsync\u003Ed__1.UD0IJHQLpvwnOfj4xCEV((object) IdentityHiLoFromTableGenerator.Log, IdentityHiLoFromTableGenerator.\u003CDoWorkInCurrentTransactionAsync\u003Ed__1.oMfQhxQLKgBVUF45pJwe(IdentityHiLoFromTableGenerator.\u003CDoWorkInCurrentTransactionAsync\u003Ed__1.HvgOH4QLTIXXHh4QLvOr(-643786247 ^ -643647825), (object) this.tableName), (object) ex);
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
                            continue;
                          default:
                            goto label_43;
                        }
                      }
label_43:
                      throw;
                    }
                    finally
                    {
                      int num6;
                      if (num2 >= 0)
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 1 : 1;
                      else
                        goto label_47;
label_46:
                      switch (num6)
                      {
                        case 1:
                        case 2:
                      }
label_47:
                      // ISSUE: reference to a compiler-generated method
                      IdentityHiLoFromTableGenerator.\u003CDoWorkInCurrentTransactionAsync\u003Ed__1.xmYuL8QL2LUpAmHK2esY((object) ups);
                      num6 = 2;
                      goto label_46;
                    }
                  case 12:
                    goto label_15;
                  case 13:
                    ups = (DbCommand) null;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 6 : 4;
                    continue;
                  case 14:
                    try
                    {
                      int num7;
                      if (num2 != 0)
                        num7 = 25;
                      else
                        goto label_86;
label_57:
                      TaskAwaiter<DbDataReader> taskAwaiter1;
                      string message;
                      TaskAwaiter<DbDataReader> awaiter1;
                      while (true)
                      {
                        TaskAwaiter<bool> taskAwaiter2;
                        int num8;
                        TaskAwaiter<bool> awaiter2;
                        DbDataReader result3;
                        switch (num7)
                        {
                          case 1:
                            awaiter2 = rs.ReadAsync(cancellationToken).GetAwaiter();
                            num7 = 7;
                            continue;
                          case 2:
                            goto label_66;
                          case 3:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, IdentityHiLoFromTableGenerator.\u003CDoWorkInCurrentTransactionAsync\u003Ed__1>(ref awaiter2, this);
                            num7 = 9;
                            continue;
                          case 4:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003E1__state = num2 = -1;
                            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 16 : 20;
                            continue;
                          case 5:
                            taskAwaiter1 = new TaskAwaiter<DbDataReader>();
                            num8 = 22;
                            break;
                          case 6:
                            awaiter1 = qps.ExecuteReaderAsync(cancellationToken).GetAwaiter();
                            num7 = 19;
                            continue;
                          case 7:
                            if (awaiter2.IsCompleted)
                            {
                              num7 = 26;
                              continue;
                            }
                            goto case 13;
                          case 8:
                            rs = result3;
                            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 1;
                            continue;
                          case 9:
                            goto label_107;
                          case 10:
                          case 11:
                            result3 = awaiter1.GetResult();
                            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 8 : 0;
                            continue;
                          case 12:
                            taskAwaiter1 = awaiter1;
                            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 23 : 15;
                            continue;
                          case 13:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003E1__state = num2 = 1;
                            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 29 : 29;
                            continue;
                          case 14:
                            // ISSUE: reference to a compiler-generated method
                            if (IdentityHiLoFromTableGenerator.\u003CDoWorkInCurrentTransactionAsync\u003Ed__1.Tt4rcnQLXbvvXLQoQuyH((object) this.whereClause))
                            {
                              num7 = 15;
                              continue;
                            }
                            goto default;
                          case 15:
                          case 27:
                            IdentityHiLoFromTableGenerator.Log.Error((object) message);
                            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 2 : 2;
                            continue;
                          case 16:
                            goto label_101;
                          case 17:
                            goto label_86;
                          case 18:
                            // ISSUE: reference to a compiler-generated method
                            message = (string) IdentityHiLoFromTableGenerator.\u003CDoWorkInCurrentTransactionAsync\u003Ed__1.oMfQhxQLKgBVUF45pJwe((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-710283084 ^ -537863435 ^ 173736975), (object) this.tableName);
                            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 6 : 14;
                            continue;
                          case 19:
                            if (awaiter1.IsCompleted)
                            {
                              num7 = 10;
                              continue;
                            }
                            goto case 21;
                          case 20:
                          case 26:
                            if (awaiter2.GetResult())
                            {
                              // ISSUE: reference to a compiler-generated method
                              result = Convert.ToInt64(IdentityHiLoFromTableGenerator.\u003CDoWorkInCurrentTransactionAsync\u003Ed__1.nTwTSdQLnLgF0MQ2SVa5((object) this.ColumnType, (object) rs, 0, (object) session));
                              num8 = 30;
                              break;
                            }
                            num8 = 18;
                            break;
                          case 21:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003E1__state = num2 = 0;
                            num7 = 12;
                            continue;
                          case 22:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003E1__state = num2 = -1;
                            num7 = 11;
                            continue;
                          case 23:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<DbDataReader>, IdentityHiLoFromTableGenerator.\u003CDoWorkInCurrentTransactionAsync\u003Ed__1>(ref awaiter1, this);
                            num7 = 16;
                            continue;
                          case 24:
                            taskAwaiter2 = new TaskAwaiter<bool>();
                            num7 = 4;
                            continue;
                          case 25:
                            if (num2 != 1)
                            {
                              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 6 : 4;
                              continue;
                            }
                            goto case 28;
                          case 28:
                            awaiter2 = taskAwaiter2;
                            num7 = 24;
                            continue;
                          case 29:
                            taskAwaiter2 = awaiter2;
                            num7 = 3;
                            continue;
                          case 30:
                            goto label_50;
                          default:
                            // ISSUE: reference to a compiler-generated method
                            // ISSUE: reference to a compiler-generated method
                            message = (string) IdentityHiLoFromTableGenerator.\u003CDoWorkInCurrentTransactionAsync\u003Ed__1.QKFvcuQLk5Lspbv1uF2q((object) message, IdentityHiLoFromTableGenerator.\u003CDoWorkInCurrentTransactionAsync\u003Ed__1.HvgOH4QLTIXXHh4QLvOr(2008901894 << 3 ^ -1108777222), (object) this.whereClause);
                            num7 = 27;
                            continue;
                        }
                        num7 = num8;
                      }
label_107:
                      return;
label_101:
                      return;
label_66:
                      throw new IdentifierGenerationException(message);
label_86:
                      awaiter1 = taskAwaiter1;
                      num7 = 5;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0)
                      {
                        num7 = 0;
                        goto label_57;
                      }
                      else
                        goto label_57;
                    }
                    catch (Exception ex)
                    {
                      int num9 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
                        num9 = 0;
                      while (true)
                      {
                        switch (num9)
                        {
                          case 1:
                            goto label_94;
                          default:
                            // ISSUE: reference to a compiler-generated method
                            IdentityHiLoFromTableGenerator.Log.Error(IdentityHiLoFromTableGenerator.\u003CDoWorkInCurrentTransactionAsync\u003Ed__1.HvgOH4QLTIXXHh4QLvOr(-1290212282 ^ -644262414 ^ 1787008832), ex);
                            num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 0;
                            continue;
                        }
                      }
label_94:
                      throw;
                    }
                    finally
                    {
                      int num10;
                      if (num2 >= 0)
                      {
                        num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 2 : 2;
                        goto label_99;
                      }
                      else
                        goto label_102;
label_98:
                      int num11;
                      num10 = num11;
label_99:
                      switch (num10)
                      {
                        case 1:
                          // ISSUE: reference to a compiler-generated method
                          IdentityHiLoFromTableGenerator.\u003CDoWorkInCurrentTransactionAsync\u003Ed__1.x13JiQQLOcA2ceCYW4Zd((object) rs);
                          num11 = 4;
                          goto label_98;
                        case 2:
                        case 3:
                        case 4:
                          goto label_104;
                      }
label_102:
                      if (rs != null)
                      {
                        num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 1 : 1;
                        goto label_99;
                      }
label_104:
                      // ISSUE: reference to a compiler-generated method
                      IdentityHiLoFromTableGenerator.\u003CDoWorkInCurrentTransactionAsync\u003Ed__1.xmYuL8QL2LUpAmHK2esY((object) qps);
                      num11 = 3;
                      goto label_98;
                    }
                  case 15:
                    // ISSUE: reference to a compiler-generated method
                    IdentityHiLoFromTableGenerator.\u003CDoWorkInCurrentTransactionAsync\u003Ed__1.aPa6xQQLiq4qEAndwld3((object) qps, CommandType.Text);
                    num3 = 4;
                    continue;
                  case 16:
                    qps.CommandText = this.query;
                    num3 = 15;
                    continue;
                  case 17:
                    goto label_3;
                  case 18:
                    // ISSUE: reference to a compiler-generated method
                    IdentityHiLoFromTableGenerator.\u003CDoWorkInCurrentTransactionAsync\u003Ed__1.N8NccgQLq0VI83PaU46a((object) PersistentIdGeneratorParmsNames.SqlStatementLogger, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210584089), (object) qps, (object) FormatStyle.Basic);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 0;
                    continue;
                  case 19:
                    goto label_13;
                  case 21:
                    // ISSUE: reference to a compiler-generated method
                    IdentityHiLoFromTableGenerator.\u003CDoWorkInCurrentTransactionAsync\u003Ed__1.qgAqh8QLNEP7mNBS4MFv((object) ups, (object) conn);
                    num3 = 9;
                    continue;
                }
                result1 = (object) result;
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 17 : 9;
              }
label_13:
              if (num2 != 2)
              {
                num3 = 8;
                goto label_7;
              }
label_15:
              num3 = 11;
              goto label_7;
            }
            catch (Exception ex)
            {
              int num12 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
                num12 = 1;
              while (true)
              {
                switch (num12)
                {
                  case 0:
                    goto label_100;
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num12 = 2;
                    continue;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_95;
                }
              }
label_100:
              return;
label_95:
              return;
            }
          case 5:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 2 : 2;
            continue;
          default:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 3 : 4;
            continue;
        }
      }
label_114:;
    }

    /// <summary>
    /// Configures the TableGenerator by reading the value of <c>table</c>,
    /// <c>column</c>, and <c>schema</c> from the <c>parms</c> parameter.
    /// </summary>
    /// <param name="type">The <see cref="T:NHibernate.Type.IType" /> the identifier should be.</param>
    /// <param name="parms">An <see cref="T:System.Collections.IDictionary" /> of Param values that are keyed by parameter name.</param>
    /// <param name="dialect">The <see cref="T:NHibernate.Dialect.Dialect" /> to help with Configuration.</param>
    public virtual void Configure(IType type, IDictionary<string, string> parms, NHibernate.Dialect.Dialect dialect)
    {
      this.tableName = PropertiesHelper.GetString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108691246), parms, z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272483617));
      this.columnName = PropertiesHelper.GetString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234282982), parms, z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647787444));
      this.whereClause = PropertiesHelper.GetString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1597012150 ^ 1597133858), parms, "");
      this.whereColumnName = PropertiesHelper.GetString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1598106783 - -968262081 ^ -629704320), parms, "");
      this.whereValue = PropertiesHelper.GetString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-710283084 ^ -537863435 ^ 173737725), parms, "");
      string schema = PropertiesHelper.GetString(PersistentIdGeneratorParmsNames.Schema, parms, (string) null);
      string catalog = PropertiesHelper.GetString(PersistentIdGeneratorParmsNames.Catalog, parms, (string) null);
      this.maxLo = PropertiesHelper.GetInt64(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822766500), parms, (long) short.MaxValue);
      this.lo = this.maxLo + 1L;
      this.returnClass = type.ReturnedClass;
      if (this.tableName.IndexOf('.') < 0)
        this.tableName = dialect.Qualify(catalog, schema, this.tableName);
      SqlStringBuilder sqlStringBuilder1 = new SqlStringBuilder(100);
      sqlStringBuilder1.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(993438473 ^ 993432329) + this.columnName).Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1242972401 >> 4 ^ 77683741) + this.tableName);
      if (!string.IsNullOrEmpty(this.whereClause))
        sqlStringBuilder1.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 87916789)).Add(this.whereClause);
      this.query = sqlStringBuilder1.ToString();
      this.ColumnType = type as PrimitiveType;
      if (this.ColumnType == null)
      {
        IdentityHiLoFromTableGenerator.Log.Error((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825249234));
        throw new ArgumentException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477282074), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112702284));
      }
      switch (type)
      {
        case Int16Type _:
          this.ColumnSqlType = SqlTypeFactory.Int16;
          break;
        case Int64Type _:
          this.ColumnSqlType = SqlTypeFactory.Int64;
          break;
        default:
          this.ColumnSqlType = SqlTypeFactory.Int32;
          break;
      }
      this.parameterTypes = new SqlType[2]
      {
        this.ColumnSqlType,
        this.ColumnSqlType
      };
      SqlStringBuilder sqlStringBuilder2 = new SqlStringBuilder(100);
      sqlStringBuilder2.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(813604817 ^ 813478567) + this.tableName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1574260816 ^ 1574403544)).Add(this.columnName).Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107938686)).Add(Parameter.Placeholder).Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35918459)).Add(this.columnName).Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461651205)).Add(Parameter.Placeholder);
      if (!string.IsNullOrEmpty(this.whereClause))
        sqlStringBuilder2.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333696180)).Add(this.whereClause);
      this.updateSql = sqlStringBuilder2.ToSqlString();
    }

    /// <summary>
    /// Generate a <see cref="T:System.Int64" /> for the identifier by selecting and updating a value in a table.
    /// </summary>
    /// <param name="session">The <see cref="T:NHibernate.Engine.ISessionImplementor" /> this id is being generated in.</param>
    /// <param name="obj">The entity for which the id is being generated.</param>
    /// <returns>The new identifier as a <see cref="T:System.Int64" />.</returns>
    [MethodImpl(MethodImplOptions.Synchronized)]
    public object Generate(ISessionImplementor session, object obj)
    {
      int num1 = 2;
      long num2;
      long num3;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num2 = Convert.ToInt64(this.GenerateInternal(session, obj));
            num1 = 3;
            continue;
          case 2:
            if (this.maxLo < 1L)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 1 : 1;
              continue;
            }
            if (this.lo > this.maxLo)
            {
              num1 = 6;
              continue;
            }
            goto label_14;
          case 3:
            if (num2 != 0L)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 10 : 3;
              continue;
            }
            goto case 9;
          case 4:
            IdentityHiLoFromTableGenerator.Log.Debug(IdentityHiLoFromTableGenerator.nJfmujWyAkNVFJCcANFW((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979572776), (object) num3));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 7 : 4;
            continue;
          case 5:
            this.lo = num3 != 0L ? 0L : 1L;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 7 : 8;
            continue;
          case 6:
            num3 = IdentityHiLoFromTableGenerator.dBiDNZWy6vvBMGyeMD0i(this.GenerateInternal(session, obj));
            num1 = 5;
            continue;
          case 7:
            goto label_14;
          case 8:
            this.hi = num3;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 4 : 1;
            continue;
          case 9:
            num2 = IdentityHiLoFromTableGenerator.dBiDNZWy6vvBMGyeMD0i(this.GenerateInternal(session, obj));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return IdentityHiLoFromTableGenerator.qem7EkWyHYo1MJojh5QF(num2, this.returnClass);
label_14:
      return IdentifierGeneratorFactory.CreateNumber(this.hi + this.lo++, this.returnClass);
    }

    /// <summary>
    /// Generate a <see cref="T:System.Int16" />, <see cref="T:System.Int32" />, or <see cref="T:System.Int64" />
    /// for the identifier by selecting and updating a value in a table.
    /// </summary>
    /// <param name="session">The <see cref="T:NHibernate.Engine.ISessionImplementor" /> this id is being generated in.</param>
    /// <param name="obj">The entity for which the id is being generated.</param>
    /// <returns>The new identifier as a <see cref="T:System.Int16" />, <see cref="T:System.Int32" />, or <see cref="T:System.Int64" />.</returns>
    [MethodImpl(MethodImplOptions.Synchronized)]
    protected object GenerateInternal(ISessionImplementor session, object obj) => this.DoWorkInNewTransaction(session);

    /// <summary>
    /// The SQL required to create the database objects for a TableGenerator.
    /// </summary>
    /// <param name="dialect">The <see cref="T:NHibernate.Dialect.Dialect" /> to help with creating the sql.</param>
    /// <returns>
    /// An array of <see cref="T:System.String" /> objects that contain the Dialect specific sql to
    /// create the necessary database objects and to create the first value as <c>1</c>
    /// for the TableGenerator.
    /// </returns>
    public virtual string[] SqlCreateStrings(NHibernate.Dialect.Dialect dialect) => new string[2]
    {
      (string) IdentityHiLoFromTableGenerator.VFKjtTWyx7wLH9wpRBQJ((object) new string[7]
      {
        (string) IdentityHiLoFromTableGenerator.waFpDcWy7EVaLiFe1qYD(1251470110 >> 2 ^ 312989565),
        this.tableName,
        (string) IdentityHiLoFromTableGenerator.waFpDcWy7EVaLiFe1qYD(--1333735954 ^ 1333600202),
        this.columnName,
        (string) IdentityHiLoFromTableGenerator.waFpDcWy7EVaLiFe1qYD(-1146510045 ^ -1146491903),
        dialect.GetTypeName(this.ColumnSqlType),
        (string) IdentityHiLoFromTableGenerator.waFpDcWy7EVaLiFe1qYD(1051276242 - 990076387 ^ 61339661)
      }),
      (string) IdentityHiLoFromTableGenerator.SWtxGYWy08MDROkD7PQ1(IdentityHiLoFromTableGenerator.waFpDcWy7EVaLiFe1qYD(1514961705 ^ 1515083459), (object) this.tableName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488739379))
    };

    /// <summary>
    /// The SQL required to remove the underlying database objects for a TableGenerator.
    /// </summary>
    /// <param name="dialect">The <see cref="T:NHibernate.Dialect.Dialect" /> to help with creating the sql.</param>
    /// <returns>
    /// A <see cref="T:System.String" /> that will drop the database objects for the TableGenerator.
    /// </returns>
    public virtual string[] SqlDropString(NHibernate.Dialect.Dialect dialect) => new string[1]
    {
      (string) IdentityHiLoFromTableGenerator.OD1lH9WymxixhW6xV74X((object) dialect, (object) this.tableName)
    };

    /// <summary>
    /// Return a key unique to the underlying database objects for a TableGenerator.
    /// </summary>
    /// <returns>The configured table name.</returns>
    public string GeneratorKey() => this.tableName;

    /// <inheritdoc />
    public override object DoWorkInCurrentTransaction(
      ISessionImplementor session,
      DbConnection conn,
      DbTransaction transaction)
    {
      int num1 = 5;
      long int64;
      DbCommand dbCommand;
      DbDataReader dbDataReader;
      DbCommand cmd;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            try
            {
              dbDataReader = (DbDataReader) IdentityHiLoFromTableGenerator.gASccUWydVQWEr4U37D7((object) dbCommand);
              int num3 = 4;
              string message;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    message = (string) IdentityHiLoFromTableGenerator.a3t1s9Wyr5wOIsHZUcIs(IdentityHiLoFromTableGenerator.waFpDcWy7EVaLiFe1qYD(--1418440330 ^ 1418297540), (object) this.tableName);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 2 : 6;
                    continue;
                  case 2:
                    goto label_11;
                  case 3:
                    goto label_28;
                  case 4:
                    if (IdentityHiLoFromTableGenerator.UHBqmcWylZBFLiRISi9x((object) dbDataReader))
                    {
                      int64 = Convert.ToInt64(IdentityHiLoFromTableGenerator.rXRwZkWy5lGq2WDWKJn0((object) this.ColumnType, (object) dbDataReader, 0, (object) session));
                      num3 = 3;
                      continue;
                    }
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 1;
                    continue;
                  case 6:
                    if (IdentityHiLoFromTableGenerator.JcKi5nWygyBayZLwFkIj((object) this.whereClause))
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
                      continue;
                    }
                    goto case 7;
                  case 7:
                    message = message + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-630932142 - 1120244082 ^ -1751317206) + this.whereClause;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 5 : 5;
                    continue;
                  default:
                    IdentityHiLoFromTableGenerator.Log.Error((object) message);
                    num3 = 2;
                    continue;
                }
              }
label_11:
              throw new IdentifierGenerationException(message);
            }
            catch (Exception ex)
            {
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
                num4 = 0;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    goto label_20;
                  default:
                    IdentityHiLoFromTableGenerator.zrF06OWyjVRXASGVMi4G((object) IdentityHiLoFromTableGenerator.Log, IdentityHiLoFromTableGenerator.waFpDcWy7EVaLiFe1qYD(-643786247 ^ -643647731), (object) ex);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 1 : 1;
                    continue;
                }
              }
label_20:
              throw;
            }
            finally
            {
              int num5;
              if (dbDataReader == null)
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 1;
              else
                goto label_25;
label_23:
              while (true)
              {
                switch (num5)
                {
                  case 2:
                    goto label_27;
                  case 3:
                    goto label_25;
                  default:
                    IdentityHiLoFromTableGenerator.d0KDR8WyLKBD7a8rHsaD((object) dbCommand);
                    num5 = 2;
                    continue;
                }
              }
label_27:
label_25:
              IdentityHiLoFromTableGenerator.uPICRHWyYBcgw06dVceP((object) dbDataReader);
              num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
              {
                num5 = 0;
                goto label_23;
              }
              else
                goto label_23;
            }
          case 3:
            try
            {
              this.ColumnType.Set(cmd, (object) (int64 + (this.maxLo > 0L ? this.maxLo + 1L : 1L)), 0, session);
              int num6 = 2;
              while (true)
              {
                switch (num6)
                {
                  case 1:
                    num2 = cmd.ExecuteNonQuery();
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 3;
                    continue;
                  case 2:
                    this.ColumnType.Set(cmd, (object) int64, 1, session);
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
                    continue;
                  case 3:
                    goto label_29;
                  default:
                    IdentityHiLoFromTableGenerator.eCWqKMWy9q8el7oSmFvI((object) PersistentIdGeneratorParmsNames.SqlStatementLogger, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882246072), (object) cmd, (object) FormatStyle.Basic);
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 1 : 1;
                    continue;
                }
              }
            }
            catch (Exception ex)
            {
              int num7 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
                num7 = 0;
              while (true)
              {
                switch (num7)
                {
                  case 1:
                    IdentityHiLoFromTableGenerator.zrF06OWyjVRXASGVMi4G((object) IdentityHiLoFromTableGenerator.Log, (object) ((string) IdentityHiLoFromTableGenerator.waFpDcWy7EVaLiFe1qYD(1819636893 << 3 ^ 1672055742) + this.tableName), (object) ex);
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_43;
                }
              }
label_43:
              throw;
            }
            finally
            {
              IdentityHiLoFromTableGenerator.d0KDR8WyLKBD7a8rHsaD((object) cmd);
              int num8 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
                num8 = 0;
              switch (num8)
              {
                default:
              }
            }
          case 4:
            dbDataReader = (DbDataReader) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 11 : 6;
            continue;
          case 5:
            dbCommand = (DbCommand) IdentityHiLoFromTableGenerator.UWL0S1WyyY3j6vF2baUn((object) conn);
            num1 = 4;
            continue;
          case 6:
label_29:
            if (num2 != 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 1 : 1;
              continue;
            }
            goto case 5;
          case 7:
label_28:
            cmd = (DbCommand) IdentityHiLoFromTableGenerator.gIXH4ZWyzWyO8WsKCYXU(IdentityHiLoFromTableGenerator.Nr1DpKWycdSYkvce0ee5(IdentityHiLoFromTableGenerator.G93c3EWysOoGNkA7lsqe(IdentityHiLoFromTableGenerator.bIv5bHWyUAsoBaRF09lN((object) session))), CommandType.Text, (object) this.updateSql, (object) this.parameterTypes);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 0 : 0;
            continue;
          case 8:
            IdentityHiLoFromTableGenerator.qfJ2uLWyJSGNylCubNEX((object) dbCommand, (object) transaction);
            num1 = 12;
            continue;
          case 9:
            IdentityHiLoFromTableGenerator.qfJ2uLWyJSGNylCubNEX((object) cmd, (object) transaction);
            num1 = 3;
            continue;
          case 10:
            dbCommand.CommandType = CommandType.Text;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 8 : 3;
            continue;
          case 11:
            IdentityHiLoFromTableGenerator.UHdtpdWyMUUfIwAdk5QY((object) dbCommand, (object) this.query);
            num1 = 10;
            continue;
          case 12:
            IdentityHiLoFromTableGenerator.eCWqKMWy9q8el7oSmFvI((object) PersistentIdGeneratorParmsNames.SqlStatementLogger, IdentityHiLoFromTableGenerator.waFpDcWy7EVaLiFe1qYD(1142330761 ^ 1541959139 ^ 536663630), (object) dbCommand, (object) FormatStyle.Basic);
            num1 = 2;
            continue;
          default:
            IdentityHiLoFromTableGenerator.pmRcyjWMFwAOtBdxtLr3((object) cmd, (object) conn);
            num1 = 9;
            continue;
        }
      }
label_2:
      return (object) int64;
    }

    public static IGeneratorDef GeneratorDef
    {
      get
      {
        int num = 1;
        IGeneratorDef generatorDef;
        while (true)
        {
          switch (num)
          {
            case 1:
              generatorDef = IdentityHiLoFromTableGenerator.generatorDef;
              if (generatorDef == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return generatorDef;
label_5:
        return IdentityHiLoFromTableGenerator.generatorDef = (IGeneratorDef) new IdentityHiLoFromTableGenerator.GeneratorDefInternal();
      }
    }

    public IdentityHiLoFromTableGenerator()
    {
      IdentityHiLoFromTableGenerator.XEwKeXWMBmZvroHt5dZr();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static IdentityHiLoFromTableGenerator()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            IdentityHiLoFromTableGenerator.Log = Logger.GetLogger(typeof (IdentityHiLoFromTableGenerator));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static long dBiDNZWy6vvBMGyeMD0i([In] object obj0) => Convert.ToInt64(obj0);

    internal static object qem7EkWyHYo1MJojh5QF([In] long obj0, [In] System.Type obj1) => IdentifierGeneratorFactory.CreateNumber(obj0, obj1);

    internal static object nJfmujWyAkNVFJCcANFW([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static bool umlGpIWywnJQAX1v85c0() => IdentityHiLoFromTableGenerator.hoF7nNWytsJdVxM74BsT == null;

    internal static IdentityHiLoFromTableGenerator edpM3UWy4Npct8E83Bnh() => IdentityHiLoFromTableGenerator.hoF7nNWytsJdVxM74BsT;

    internal static object waFpDcWy7EVaLiFe1qYD(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object VFKjtTWyx7wLH9wpRBQJ([In] object obj0) => (object) string.Concat((string[]) obj0);

    internal static object SWtxGYWy08MDROkD7PQ1([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object OD1lH9WymxixhW6xV74X([In] object obj0, [In] object obj1) => (object) ((NHibernate.Dialect.Dialect) obj0).GetDropTableString((string) obj1);

    internal static object UWL0S1WyyY3j6vF2baUn([In] object obj0) => (object) ((DbConnection) obj0).CreateCommand();

    internal static void UHdtpdWyMUUfIwAdk5QY([In] object obj0, [In] object obj1) => ((DbCommand) obj0).CommandText = (string) obj1;

    internal static void qfJ2uLWyJSGNylCubNEX([In] object obj0, [In] object obj1) => ((DbCommand) obj0).Transaction = (DbTransaction) obj1;

    internal static void eCWqKMWy9q8el7oSmFvI([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((SqlStatementLogger) obj0).LogCommand((string) obj1, (DbCommand) obj2, (FormatStyle) obj3);

    internal static object gASccUWydVQWEr4U37D7([In] object obj0) => (object) ((DbCommand) obj0).ExecuteReader();

    internal static bool UHBqmcWylZBFLiRISi9x([In] object obj0) => ((DbDataReader) obj0).Read();

    internal static object a3t1s9Wyr5wOIsHZUcIs([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static bool JcKi5nWygyBayZLwFkIj([In] object obj0) => ((string) obj0).IsNullOrWhiteSpace();

    internal static object rXRwZkWy5lGq2WDWKJn0([In] object obj0, [In] object obj1, [In] int obj2, [In] object obj3) => ((NullableType) obj0).Get((DbDataReader) obj1, obj2, (ISessionImplementor) obj3);

    internal static void zrF06OWyjVRXASGVMi4G([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static void uPICRHWyYBcgw06dVceP([In] object obj0) => ((DbDataReader) obj0).Close();

    internal static void d0KDR8WyLKBD7a8rHsaD([In] object obj0) => ((Component) obj0).Dispose();

    internal static object bIv5bHWyUAsoBaRF09lN([In] object obj0) => (object) ((ISessionImplementor) obj0).Factory;

    internal static object G93c3EWysOoGNkA7lsqe([In] object obj0) => (object) ((ISessionFactoryImplementor) obj0).ConnectionProvider;

    internal static object Nr1DpKWycdSYkvce0ee5([In] object obj0) => (object) ((IConnectionProvider) obj0).Driver;

    internal static object gIXH4ZWyzWyO8WsKCYXU(
      [In] object obj0,
      [In] CommandType obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((IDriver) obj0).GenerateCommand(obj1, (SqlString) obj2, (SqlType[]) obj3);
    }

    internal static void pmRcyjWMFwAOtBdxtLr3([In] object obj0, [In] object obj1) => ((DbCommand) obj0).Connection = (DbConnection) obj1;

    internal static void XEwKeXWMBmZvroHt5dZr() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    private class GeneratorDefInternal : IGeneratorDef
    {
      internal static object xnipxOQLoniQ8o92iKoo;

      public string Class => typeof (IdentityHiLoFromTableGenerator).AssemblyQualifiedName;

      public object Params => (object) null;

      public System.Type DefaultReturnType => TypeOf<long>.Raw;

      public bool SupportedAsCollectionElementId => false;

      public GeneratorDefInternal()
      {
        IdentityHiLoFromTableGenerator.GeneratorDefInternal.RbwcxHQLGLaEcVpqPNvs();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool NnP7wqQLbIOOHfwOmU9j() => IdentityHiLoFromTableGenerator.GeneratorDefInternal.xnipxOQLoniQ8o92iKoo == null;

      internal static IdentityHiLoFromTableGenerator.GeneratorDefInternal XcqUJrQLhRHVBsfTgfJK() => (IdentityHiLoFromTableGenerator.GeneratorDefInternal) IdentityHiLoFromTableGenerator.GeneratorDefInternal.xnipxOQLoniQ8o92iKoo;

      internal static void RbwcxHQLGLaEcVpqPNvs() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
