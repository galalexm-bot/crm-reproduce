// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.NHQueryCacheWrapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Cache;
using NHibernate.Cache.Entry;
using NHibernate.Cfg;
using NHibernate.Engine;
using NHibernate.Event;
using NHibernate.Impl;
using NHibernate.Persister.Entity;
using NHibernate.Proxy;
using NHibernate.Type;
using NHibernate.Util;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime.NH
{
  public class NHQueryCacheWrapper : IQueryCache
  {
    private static readonly ILogger Log;
    private readonly UpdateTimestampsCache updateTimestampsCache;
    private readonly ICache queryCache;
    private readonly string regionName;
    internal static NHQueryCacheWrapper FKZKokWNrM8GV7NG5Mx8;

    /// <inheritdoc />
    public Task ClearAsync(CancellationToken cancellationToken) => (Task) NHQueryCacheWrapper.Hc4O0iWNj4o9dJGPidcg((object) this.Cache, cancellationToken);

    /// <inheritdoc />
    public async Task<bool> PutAsync(
      QueryKey key,
      ICacheAssembler[] returnTypes,
      IList result,
      bool isNaturalKeyLookup,
      ISessionImplementor session,
      CancellationToken cancellationToken)
    {
      int num1 = 2;
      while (true)
      {
        int num2;
        bool result1;
        switch (num1)
        {
          case 1:
            num1 = 5;
            continue;
          case 2:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 1 : 0;
            continue;
          case 3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 1 : 4;
            continue;
          case 4:
            goto label_116;
          case 5:
            try
            {
              TaskAwaiter<object> taskAwaiter1;
              TaskAwaiter<CacheEntry> taskAwaiter2;
              TaskAwaiter<object[]> taskAwaiter3;
              int num3;
              TaskAwaiter<object> awaiter1;
              TaskAwaiter<object[]> awaiter2;
              TaskAwaiter<CacheEntry> awaiter3;
              int num4;
              switch (num2)
              {
                case 0:
label_74:
                  awaiter1 = taskAwaiter1;
                  num4 = 12;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
                  {
                    num4 = 5;
                    goto label_5;
                  }
                  else
                    goto label_5;
                case 1:
label_73:
                  awaiter1 = taskAwaiter1;
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 15 : 17;
                  goto label_5;
                case 2:
label_32:
                  awaiter3 = taskAwaiter2;
                  num4 = 71;
                  goto label_5;
                case 3:
label_72:
                  awaiter1 = taskAwaiter1;
                  num3 = 73;
                  break;
                case 4:
label_80:
                  awaiter2 = taskAwaiter3;
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 66 : 80;
                  goto label_5;
                default:
                  num4 = 46;
                  goto label_5;
              }
label_4:
              num4 = num3;
label_5:
              IList cacheable;
              int i;
              object row;
              IEntityPersister persister;
              object id;
              IList list;
              object result2;
              object[] result3;
              CacheEntry result4;
              object state1;
              ICacheAssembler returnType;
              long num5;
              EntityEntry entityEntry;
              int num6;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    goto label_32;
                  case 2:
                    goto label_113;
                  case 3:
                  case 47:
                    result2 = awaiter1.GetResult();
                    num4 = 99;
                    continue;
                  case 4:
                    result1 = false;
                    num4 = 91;
                    continue;
                  case 5:
                    i = num6 + 1;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 92 : 11;
                    continue;
                  case 6:
                    list = (IList) null;
                    num4 = 34;
                    continue;
                  case 7:
                    goto label_73;
                  case 8:
                    row = result2;
                    num4 = 14;
                    continue;
                  case 9:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num4 = 40;
                    continue;
                  case 10:
                  case 54:
                  case 91:
                    goto label_119;
                  case 11:
                    // ISSUE: reference to a compiler-generated method
                    if (!NHQueryCacheWrapper.\u003CPutAsync\u003Ed__1.gRdvCWQMbFmxB8HTOoU0((object) nhibernateProxy.HibernateLazyInitializer))
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 74 : 97;
                      continue;
                    }
                    goto case 83;
                  case 12:
                    taskAwaiter1 = new TaskAwaiter<object>();
                    num4 = 66;
                    continue;
                  case 13:
                  case 101:
                    // ISSUE: reference to a compiler-generated method
                    row = NHQueryCacheWrapper.\u003CPutAsync\u003Ed__1.XJnefnQMoG56JKe798vA((object) result, i);
                    num4 = 78;
                    continue;
                  case 14:
                    goto label_77;
                  case 15:
                    persister = (IEntityPersister) null;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 10 : 27;
                    continue;
                  case 16:
                    // ISSUE: reference to a compiler-generated method
                    NHQueryCacheWrapper.\u003CPutAsync\u003Ed__1.Fbg5PXQMha4i91Y2tCi9((object) cacheable, (object) new NHEntityCacheEntry(id, state1, row.GetType().FullName));
                    num4 = 15;
                    continue;
                  case 17:
                    taskAwaiter1 = new TaskAwaiter<object>();
                    num4 = 59;
                    continue;
                  case 18:
                    goto label_108;
                  case 19:
                  case 55:
                  case 93:
                    row = (object) null;
                    num4 = 79;
                    continue;
                  case 20:
                    if (awaiter1.IsCompleted)
                      goto case 40;
                    else
                      goto label_107;
                  case 21:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, NHQueryCacheWrapper.\u003CPutAsync\u003Ed__1>(ref awaiter1, this);
                    num4 = 2;
                    continue;
                  case 22:
                    goto label_72;
                  case 23:
                    // ISSUE: reference to a compiler-generated method
                    NHQueryCacheWrapper.\u003CPutAsync\u003Ed__1.Fbg5PXQMha4i91Y2tCi9((object) list, result2);
                    num4 = 86;
                    continue;
                  case 24:
                    goto label_74;
                  case 25:
                    if (entityEntry != null)
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 11 : 30;
                      continue;
                    }
                    goto case 102;
                  case 26:
                    taskAwaiter3 = awaiter2;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 62 : 46;
                    continue;
                  case 27:
                    goto label_34;
                  case 28:
                    goto label_109;
                  case 29:
                    if (!awaiter3.IsCompleted)
                    {
                      num4 = 85;
                      continue;
                    }
                    goto case 98;
                  case 31:
                    goto label_71;
                  case 32:
                  case 87:
                    // ISSUE: reference to a compiler-generated method
                    num5 = NHQueryCacheWrapper.\u003CPutAsync\u003Ed__1.UZftSiQMBFTriuqUh44f((object) session);
                    num4 = 37;
                    continue;
                  case 33:
                    taskAwaiter1 = awaiter1;
                    num4 = 21;
                    continue;
                  case 34:
                  case 79:
                    num6 = i;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 5 : 4;
                    continue;
                  case 35:
                  case 72:
                    result2 = awaiter1.GetResult();
                    num4 = 8;
                    continue;
                  case 36:
                    returnType = returnTypes[0];
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 7 : 60;
                    continue;
                  case 37:
                    if (!NHQueryCacheWrapper.Log.IsDebugEnabled())
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 44 : 4;
                      continue;
                    }
                    goto label_71;
                  case 38:
                    goto label_21;
                  case 39:
                    goto label_103;
                  case 40:
                    result2 = awaiter1.GetResult();
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 20 : 23;
                    continue;
                  case 41:
                    // ISSUE: reference to a compiler-generated method
                    state1 = NHQueryCacheWrapper.\u003CPutAsync\u003Ed__1.akWDARQMZ0aITaUykkFD((object) persister.CacheEntryStructure, (object) result4);
                    num4 = 16;
                    continue;
                  case 42:
                    goto label_23;
                  case 43:
                    taskAwaiter2 = awaiter3;
                    num4 = 89;
                    continue;
                  case 44:
                  case 48:
                    cacheable = (IList) new List<object>(result.Count + 1)
                    {
                      (object) num5
                    };
                    num4 = 88;
                    continue;
                  case 45:
                    awaiter2 = TypeHelper.DisassembleAsync((object[]) row, returnTypes, (bool[]) null, session, (object) null, cancellationToken).GetAwaiter();
                    num4 = 56;
                    continue;
                  case 46:
                    if (isNaturalKeyLookup)
                    {
                      num4 = 51;
                      continue;
                    }
                    goto case 32;
                  case 49:
                    list.Add((object) result3);
                    num4 = 38;
                    continue;
                  case 50:
                    if (awaiter1.IsCompleted)
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 35 : 0;
                      continue;
                    }
                    goto case 74;
                  case 51:
                    if (result.Count != 0)
                    {
                      num4 = 87;
                      continue;
                    }
                    goto case 4;
                  case 52:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 3;
                    num4 = 68;
                    continue;
                  case 53:
                    if (awaiter1.IsCompleted)
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 47 : 30;
                      continue;
                    }
                    goto label_108;
                  case 56:
                    if (!awaiter2.IsCompleted)
                    {
                      num4 = 65;
                      continue;
                    }
                    goto label_10;
                  case 57:
                    // ISSUE: reference to a compiler-generated method
                    NHQueryCacheWrapper.\u003CPutAsync\u003Ed__1.YAcl5aQMumC8C5angpmg((object) this.queryCache, (object) key, (object) cacheable);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 39 : 75;
                    continue;
                  case 58:
                    goto label_53;
                  case 59:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num4 = 72;
                    continue;
                  case 60:
                    if (row is IEntity)
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 58 : 3;
                      continue;
                    }
                    goto case 67;
                  case 61:
                    awaiter1 = returnType.DisassembleAsync(row, session, (object) null, cancellationToken).GetAwaiter();
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 53 : 5;
                    continue;
                  case 62:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<object[]>, NHQueryCacheWrapper.\u003CPutAsync\u003Ed__1>(ref awaiter2, this);
                    num4 = 39;
                    continue;
                  case 63:
                    // ISSUE: reference to a compiler-generated method
                    object state2 = NHQueryCacheWrapper.\u003CPutAsync\u003Ed__1.C5oADcQMCwNHRaxyCxNV((object) entityEntry);
                    // ISSUE: reference to a compiler-generated method
                    object version = NHQueryCacheWrapper.\u003CPutAsync\u003Ed__1.doxtHQQMvrdSfJEwFq7D(state2, (object) persister);
                    // ISSUE: reference to a compiler-generated method
                    awaiter3 = CacheEntry.CreateAsync((object[]) state2, persister, NHQueryCacheWrapper.\u003CPutAsync\u003Ed__1.dIJTXmQM8iOoIpmUhLtP((object) entityEntry), version, session, row, cancellationToken).GetAwaiter();
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 29;
                    continue;
                  case 64:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num4 = 90;
                    continue;
                  case 65:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 4;
                    num4 = 26;
                    continue;
                  case 66:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num4 = 3;
                    continue;
                  case 67:
                    list = cacheable;
                    num4 = 70;
                    continue;
                  case 68:
                    taskAwaiter1 = awaiter1;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 96 : 20;
                    continue;
                  case 69:
                    list = cacheable;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 21 : 45;
                    continue;
                  case 70:
                    awaiter1 = returnType.DisassembleAsync(row, session, (object) null, cancellationToken).GetAwaiter();
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 4 : 20;
                    continue;
                  case 71:
                    taskAwaiter2 = new TaskAwaiter<CacheEntry>();
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 16 : 77;
                    continue;
                  case 73:
                    taskAwaiter1 = new TaskAwaiter<object>();
                    num4 = 9;
                    continue;
                  case 74:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 1;
                    num4 = 94;
                    continue;
                  case 75:
                    result1 = true;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 54 : 32;
                    continue;
                  case 76:
                    goto label_100;
                  case 77:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num4 = 98;
                    continue;
                  case 78:
                    if (returnTypes.Length == 1)
                    {
                      num4 = 36;
                      continue;
                    }
                    goto case 69;
                  case 80:
                    taskAwaiter3 = new TaskAwaiter<object[]>();
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 51 : 64;
                    continue;
                  case 81:
                    goto label_95;
                  case 82:
                  case 97:
                    // ISSUE: reference to a compiler-generated method
                    awaiter1 = ((ILazyInitializer) NHQueryCacheWrapper.\u003CPutAsync\u003Ed__1.kNHXc1QMGKHDA9HaZw7P((object) nhibernateProxy)).GetImplementationAsync(cancellationToken).GetAwaiter();
                    num4 = 50;
                    continue;
                  case 83:
                    list = cacheable;
                    num4 = 61;
                    continue;
                  case 84:
                  case 92:
                    if (i < result.Count)
                    {
                      num4 = 13;
                      continue;
                    }
                    goto case 57;
                  case 85:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 2;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 27 : 43;
                    continue;
                  case 86:
                    list = (IList) null;
                    num4 = 19;
                    continue;
                  case 88:
                    i = 0;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 84 : 22;
                    continue;
                  case 89:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<CacheEntry>, NHQueryCacheWrapper.\u003CPutAsync\u003Ed__1>(ref awaiter3, this);
                    num4 = 81;
                    continue;
                  case 90:
                    goto label_10;
                  case 94:
                    taskAwaiter1 = awaiter1;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 27 : 95;
                    continue;
                  case 95:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, NHQueryCacheWrapper.\u003CPutAsync\u003Ed__1>(ref awaiter1, this);
                    num4 = 28;
                    continue;
                  case 96:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, NHQueryCacheWrapper.\u003CPutAsync\u003Ed__1>(ref awaiter1, this);
                    num4 = 76;
                    continue;
                  case 98:
                    result4 = awaiter3.GetResult();
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 11 : 41;
                    continue;
                  case 99:
                    // ISSUE: reference to a compiler-generated method
                    NHQueryCacheWrapper.\u003CPutAsync\u003Ed__1.Fbg5PXQMha4i91Y2tCi9((object) list, result2);
                    num4 = 6;
                    continue;
                  case 100:
                    goto label_80;
                  case 102:
                    result1 = false;
                    num4 = 10;
                    continue;
                  default:
                    goto label_50;
                }
              }
label_113:
              return;
label_109:
              return;
label_103:
              return;
label_100:
              return;
label_95:
              return;
label_10:
              result3 = awaiter2.GetResult();
              num3 = 49;
              goto label_4;
label_21:
              list = (IList) null;
              num3 = 55;
              goto label_4;
label_23:
              // ISSUE: reference to a compiler-generated method
              id = NHQueryCacheWrapper.\u003CPutAsync\u003Ed__1.pn5VtNQMQZMKlFjFqCNH((object) entityEntry);
              num3 = 63;
              goto label_4;
label_34:
              id = (object) null;
              num3 = 93;
              goto label_4;
label_50:
              // ISSUE: reference to a compiler-generated method
              persister = (IEntityPersister) NHQueryCacheWrapper.\u003CPutAsync\u003Ed__1.d82oySQMfl3nvnJRRLOQ((object) entityEntry);
              num3 = 42;
              goto label_4;
label_53:
              if (row is INHibernateProxy nhibernateProxy)
              {
                num3 = 11;
                goto label_4;
              }
              else
                goto label_77;
label_71:
              // ISSUE: reference to a compiler-generated method
              NHQueryCacheWrapper.Log.DebugFormat((string) NHQueryCacheWrapper.\u003CPutAsync\u003Ed__1.Nv3mVvQMWX16jmH5jjTk(-53329496 >> 4 ^ -3197282), (object) this.regionName, (object) key);
              num3 = 48;
              goto label_4;
label_77:
              // ISSUE: reference to a compiler-generated method
              entityEntry = (EntityEntry) NHQueryCacheWrapper.\u003CPutAsync\u003Ed__1.nJGksPQMEJ0HZXRbinyK((object) session.PersistenceContext, row);
              num3 = 25;
              goto label_4;
label_107:
              num3 = 52;
              goto label_4;
label_108:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003E1__state = num2 = 0;
              num3 = 33;
              goto label_4;
            }
            catch (Exception ex)
            {
              int num7 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0)
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
                    goto label_91;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 1;
                    continue;
                }
              }
label_91:
              return;
            }
        }
label_119:
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        (^this).\u003C\u003E1__state = -2;
        num1 = 3;
      }
label_116:;
    }

    /// <inheritdoc />
    public async Task<IList> GetAsync(
      QueryKey key,
      ICacheAssembler[] returnTypes,
      bool isNaturalKeyLookup,
      ISet<string> spaces,
      ISessionImplementor session,
      CancellationToken cancellationToken)
    {
      int num1 = 4;
      int num2;
      IList result1;
      while (true)
      {
        switch (num1)
        {
          case 1:
label_2:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 2 : 2;
            continue;
          case 2:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 3 : 5;
            continue;
          case 3:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
            continue;
          case 4:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = 3;
            continue;
          case 5:
            goto label_200;
          default:
            try
            {
              TaskAwaiter<object> taskAwaiter1;
              TaskAwaiter taskAwaiter2;
              TaskAwaiter awaiter1;
              TaskAwaiter<object> awaiter2;
              int num3;
              switch (num2)
              {
                case 0:
label_161:
                  awaiter2 = taskAwaiter1;
                  num3 = 65;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
                  {
                    num3 = 83;
                    break;
                  }
                  break;
                case 1:
label_182:
                  awaiter1 = taskAwaiter2;
                  num3 = 22;
                  break;
                case 2:
label_134:
                  awaiter1 = taskAwaiter2;
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 25 : 8;
                  break;
                case 3:
                case 4:
                case 5:
                case 6:
label_137:
                  num3 = 42;
                  break;
                case 7:
label_133:
                  awaiter1 = taskAwaiter2;
                  num3 = 8;
                  break;
                default:
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 45 : 16;
                  break;
              }
              object obj;
              while (true)
              {
                IList cacheable;
                IList result;
                int i;
                int num;
                int num4;
                object cached;
                ICacheAssembler returnType1;
                object result2;
                long timestamp;
                int num5;
                switch (num3)
                {
                  case 1:
                    goto label_133;
                  case 2:
                    taskAwaiter2 = awaiter1;
                    num3 = 32;
                    continue;
                  case 3:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    awaiter1 = NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2.o7o0yEQMXPWu0hqh9cN8(NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2.RsTDpFQMpvmIO7FXTObf((object) this.queryCache, (object) key, cancellationToken));
                    num3 = 11;
                    continue;
                  case 4:
                    awaiter2 = this.queryCache.GetAsync((object) key, cancellationToken).GetAwaiter();
                    num3 = 50;
                    continue;
                  case 5:
                    goto label_182;
                  case 6:
                  case 79:
                    // ISSUE: reference to a compiler-generated method
                    if (i >= NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2.jG2aKCQMkvjhvBy63cow((object) cacheable))
                    {
                      num4 = 43;
                      break;
                    }
                    goto case 48;
                  case 7:
                    goto label_134;
                  case 8:
                    taskAwaiter2 = new TaskAwaiter();
                    num3 = 21;
                    continue;
                  case 9:
                  case 37:
                    // ISSUE: reference to a compiler-generated method
                    if (i < NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2.jG2aKCQMkvjhvBy63cow((object) cacheable))
                    {
                      num3 = 62;
                      continue;
                    }
                    goto case 84;
                  case 10:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2.MdPlykQM39JLEtWWcw1O((object) NHQueryCacheWrapper.Log, NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2.isyL48QMRR4GPP6oeIY7(1218962250 ^ 1218836466));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 3 : 2;
                    continue;
                  case 11:
                    if (!awaiter1.IsCompleted)
                    {
                      num3 = 49;
                      continue;
                    }
                    goto case 40;
                  case 12:
                    i = num5 + 1;
                    num3 = 79;
                    continue;
                  case 13:
                    if (cacheable != null)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 58 : 47;
                      continue;
                    }
                    goto case 16;
                  case 14:
                    if (returnType1 is ManyToOneType)
                    {
                      num3 = 35;
                      continue;
                    }
                    goto case 38;
                  case 15:
                  case 72:
                    result1 = (IList) null;
                    num3 = 60;
                    continue;
                  case 16:
                    // ISSUE: reference to a compiler-generated method
                    NHQueryCacheWrapper.Log.DebugFormat((string) NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2.isyL48QMRR4GPP6oeIY7(-1822890472 ^ -1822755504), (object) key);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 52 : 68;
                    continue;
                  case 17:
                    if (returnTypes.Length == 1)
                    {
                      num4 = 52;
                      break;
                    }
                    goto case 46;
                  case 18:
                  case 65:
                  case 78:
                    if (NHQueryCacheWrapper.Log.IsDebugEnabled())
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 5 : 24;
                      continue;
                    }
                    goto case 61;
                  case 19:
                    taskAwaiter2 = awaiter1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 34 : 32;
                    continue;
                  case 20:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = 39;
                    continue;
                  case 21:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 35 : 40;
                    continue;
                  case 22:
                    taskAwaiter2 = new TaskAwaiter();
                    num3 = 20;
                    continue;
                  case 23:
                    if (awaiter1.IsCompleted)
                    {
                      num3 = 91;
                      continue;
                    }
                    goto case 36;
                  case 24:
                    NHQueryCacheWrapper.Log.DebugFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1033719030 - 2012070891 ^ -978477715), (object) key);
                    num3 = 61;
                    continue;
                  case 25:
                    taskAwaiter2 = new TaskAwaiter();
                    num3 = 93;
                    continue;
                  case 26:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 53 : 28;
                    continue;
                  case 27:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num3 = 66;
                    continue;
                  case 28:
                    if (isNaturalKeyLookup)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 18 : 10;
                      continue;
                    }
                    goto case 90;
                  case 29:
                  case 55:
                  case 60:
                  case 81:
                    goto label_2;
                  case 30:
                    // ISSUE: reference to a compiler-generated method
                    NHQueryCacheWrapper.Log.DebugFormat((string) NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2.isyL48QMRR4GPP6oeIY7(1597012150 ^ 1597140150), (object) key);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 68 : 72;
                    continue;
                  case 31:
                  case 62:
                    num = 0;
                    num3 = 94;
                    continue;
                  case 32:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2>(ref awaiter1, this);
                    num3 = 51;
                    continue;
                  case 33:
                    // ISSUE: reference to a compiler-generated method
                    NHQueryCacheWrapper.Log.DebugFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -671996261), NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2.bZS7AYQMKnODe5qBPJxn((object) (ICollection) spaces));
                    num3 = 28;
                    continue;
                  case 34:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2>(ref awaiter1, this);
                    num3 = 69;
                    continue;
                  case 35:
                    if (cached is NHEntityCacheEntry)
                    {
                      num3 = 64;
                      continue;
                    }
                    goto case 38;
                  case 36:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 2;
                    num3 = 19;
                    continue;
                  case 38:
                    // ISSUE: reference to a compiler-generated method
                    awaiter1 = NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2.o7o0yEQMXPWu0hqh9cN8((object) returnType1.BeforeAssembleAsync(cached, session, cancellationToken));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 3 : 71;
                    continue;
                  case 39:
                    awaiter1.GetResult();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 73 : 82;
                    continue;
                  case 40:
                    awaiter1.GetResult();
                    num4 = 85;
                    break;
                  case 41:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2>(ref awaiter2, this);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 57 : 9;
                    continue;
                  case 42:
                    try
                    {
                      TaskAwaiter<object[]> taskAwaiter3;
                      TaskAwaiter<object[]> awaiter3;
                      int num6;
                      switch (num2)
                      {
                        case 3:
label_86:
                          awaiter2 = taskAwaiter1;
                          num6 = 36;
                          break;
                        case 4:
label_85:
                          awaiter2 = taskAwaiter1;
                          num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 62 : 40;
                          break;
                        case 5:
label_42:
                          awaiter2 = taskAwaiter1;
                          num6 = 65;
                          break;
                        case 6:
label_71:
                          awaiter3 = taskAwaiter3;
                          num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 15 : 0;
                          break;
                        default:
                          num6 = 48;
                          break;
                      }
                      while (true)
                      {
                        IList list;
                        int num7;
                        ISessionFactoryImplementor factoryImplementor;
                        IEntityPersister entityPersister;
                        CacheEntry entry;
                        EntityKey entityKey;
                        object[] result3;
                        ICacheAssembler returnType2;
                        object obj1;
                        LoadEvent @event;
                        object obj2;
                        switch (num6)
                        {
                          case 1:
                          case 59:
                            // ISSUE: reference to a compiler-generated method
                            // ISSUE: reference to a compiler-generated method
                            entry = (CacheEntry) NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2.OiHhSOQMP9FOfrfHDSrW((object) entityPersister.CacheEntryStructure, NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2.Yp9ogoQMevtaJuVIyFof((object) entityCacheEntry), (object) factoryImplementor);
                            num6 = 57;
                            continue;
                          case 2:
                            list = (IList) null;
                            num6 = 17;
                            continue;
                          case 3:
                            if (!awaiter2.IsCompleted)
                            {
                              num6 = 9;
                              continue;
                            }
                            goto case 69;
                          case 4:
                            list.Add((object) result3);
                            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
                            continue;
                          case 5:
                          case 17:
                          case 44:
                          case 52:
                          case 58:
                            goto label_163;
                          case 6:
                            list = (IList) null;
                            num6 = 5;
                            continue;
                          case 7:
                            list = result;
                            num6 = 16;
                            continue;
                          case 8:
                            goto label_85;
                          case 9:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003E1__state = num2 = 5;
                            num6 = 21;
                            continue;
                          case 10:
                            result2 = awaiter2.GetResult();
                            num6 = 68;
                            continue;
                          case 11:
                            goto label_160;
                          case 12:
                            if (awaiter2.IsCompleted)
                            {
                              num6 = 34;
                              continue;
                            }
                            goto case 27;
                          case 13:
                            if (returnTypes.Length == 1)
                            {
                              num6 = 60;
                              continue;
                            }
                            goto case 7;
                          case 14:
                            if (!(returnType2 is ManyToOneType))
                            {
                              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 11 : 50;
                              continue;
                            }
                            goto case 72;
                          case 15:
                            taskAwaiter3 = new TaskAwaiter<object[]>();
                            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 12 : 19;
                            continue;
                          case 16:
                            awaiter3 = TypeHelper.AssembleAsync((object[]) obj1, returnTypes, session, (object) null, cancellationToken).GetAwaiter();
                            num6 = 23;
                            continue;
                          case 18:
                          case 34:
                            result2 = awaiter2.GetResult();
                            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 47 : 61;
                            continue;
                          case 19:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003E1__state = num2 = -1;
                            num6 = 55;
                            continue;
                          case 20:
                            taskAwaiter3 = awaiter3;
                            num6 = 31;
                            continue;
                          case 21:
                            taskAwaiter1 = awaiter2;
                            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 45 : 23;
                            continue;
                          case 22:
                            entityPersister = factoryImplementor.GetEntityPersister(entityCacheEntry.ClassName);
                            num6 = 47;
                            continue;
                          case 23:
                            if (!awaiter3.IsCompleted)
                            {
                              num7 = 71;
                              break;
                            }
                            goto case 55;
                          case 24:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003E1__state = num2 = -1;
                            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 24 : 69;
                            continue;
                          case 25:
                            if (!awaiter2.IsCompleted)
                            {
                              num6 = 67;
                              continue;
                            }
                            goto case 10;
                          case 26:
                            goto label_86;
                          case 27:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003E1__state = num2 = 4;
                            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 19 : 29;
                            continue;
                          case 28:
                            goto label_193;
                          case 29:
                            taskAwaiter1 = awaiter2;
                            num6 = 63;
                            continue;
                          case 30:
                            // ISSUE: reference to a compiler-generated method
                            NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2.tmBtwvQMNdTStGf4O4BP((object) result, obj2);
                            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 36 : 58;
                            continue;
                          case 31:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<object[]>, NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2>(ref awaiter3, this);
                            num6 = 54;
                            continue;
                          case 32:
                            taskAwaiter1 = awaiter2;
                            num6 = 37;
                            continue;
                          case 33:
                            obj2 = this.AssembleCacheEntry(entry, entityCacheEntry.Id, entityPersister, @event);
                            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 30 : 28;
                            continue;
                          case 35:
                            goto label_190;
                          case 36:
                            taskAwaiter1 = new TaskAwaiter<object>();
                            num6 = 46;
                            continue;
                          case 37:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2>(ref awaiter2, this);
                            num6 = 39;
                            continue;
                          case 38:
                            // ISSUE: reference to a compiler-generated method
                            NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2.tmBtwvQMNdTStGf4O4BP((object) list, result2);
                            num6 = 2;
                            continue;
                          case 39:
                            goto label_179;
                          case 40:
                            awaiter2 = returnType2.AssembleAsync(entityCacheEntry.Id, session, (object) null, cancellationToken).GetAwaiter();
                            num6 = 25;
                            continue;
                          case 41:
                            awaiter2 = returnType2.AssembleAsync(obj1, session, (object) null, cancellationToken).GetAwaiter();
                            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 12 : 2;
                            continue;
                          case 42:
                            goto label_42;
                          case 43:
                            list = result;
                            num6 = 40;
                            continue;
                          case 45:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2>(ref awaiter2, this);
                            num7 = 35;
                            break;
                          case 46:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003E1__state = num2 = -1;
                            num6 = 10;
                            continue;
                          case 47:
                            // ISSUE: reference to a compiler-generated method
                            entityKey = new EntityKey(NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2.tig1KJQMO1K3hOrvY4ZJ((object) entityCacheEntry), entityPersister);
                            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 17 : 66;
                            continue;
                          case 48:
                            // ISSUE: reference to a compiler-generated method
                            obj1 = NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2.Ppg1uwQMqwPvOSOWIjTw((object) cacheable, i);
                            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 13 : 11;
                            continue;
                          case 49:
                            list = (IList) null;
                            num6 = 11;
                            continue;
                          case 50:
                          case 51:
                            list = result;
                            num6 = 64;
                            continue;
                          case 53:
                            // ISSUE: reference to a compiler-generated method
                            @event = new LoadEvent(NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2.tig1KJQMO1K3hOrvY4ZJ((object) entityCacheEntry), entityCacheEntry.ClassName, false, (IEventSource) session);
                            num6 = 33;
                            continue;
                          case 54:
                            goto label_174;
                          case 55:
                            result3 = awaiter3.GetResult();
                            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 3 : 4;
                            continue;
                          case 56:
                            // ISSUE: reference to a compiler-generated method
                            factoryImplementor = (ISessionFactoryImplementor) NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2.trGEl7QMnSsqGQ1egmNN((object) session);
                            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 17 : 22;
                            continue;
                          case 57:
                            // ISSUE: reference to a compiler-generated method
                            if (!entityPersister.EntityMetamodel.SubclassEntityNames.Contains((string) NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2.kdUF3EQM1NIWxLYe2dlO((object) entry)))
                            {
                              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 31 : 44;
                              continue;
                            }
                            goto case 53;
                          case 60:
                            returnType2 = returnTypes[0];
                            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 14 : 5;
                            continue;
                          case 61:
                            // ISSUE: reference to a compiler-generated method
                            NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2.tmBtwvQMNdTStGf4O4BP((object) list, result2);
                            num6 = 6;
                            continue;
                          case 62:
                            taskAwaiter1 = new TaskAwaiter<object>();
                            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 19 : 74;
                            continue;
                          case 63:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2>(ref awaiter2, this);
                            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 11 : 28;
                            continue;
                          case 64:
                            awaiter2 = returnType2.AssembleAsync(obj1, session, (object) null, cancellationToken).GetAwaiter();
                            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 1 : 3;
                            continue;
                          case 65:
                            taskAwaiter1 = new TaskAwaiter<object>();
                            num6 = 24;
                            continue;
                          case 66:
                            // ISSUE: reference to a compiler-generated method
                            if (!NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2.s706BoQM25JUSMXrDPvC((object) session.PersistenceContext, (object) entityKey))
                            {
                              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 1;
                              continue;
                            }
                            goto case 43;
                          case 67:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003E1__state = num2 = 3;
                            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 32 : 13;
                            continue;
                          case 68:
                            list.Add(result2);
                            num6 = 49;
                            continue;
                          case 69:
                            result2 = awaiter2.GetResult();
                            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 38 : 1;
                            continue;
                          case 70:
                            list = result;
                            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 13 : 41;
                            continue;
                          case 71:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003E1__state = num2 = 6;
                            num7 = 20;
                            break;
                          case 72:
                            if (obj1 is NHEntityCacheEntry entityCacheEntry)
                            {
                              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 5 : 56;
                              continue;
                            }
                            goto case 70;
                          case 73:
                            goto label_71;
                          case 74:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003E1__state = num2 = -1;
                            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 15 : 18;
                            continue;
                          default:
                            list = (IList) null;
                            num6 = 52;
                            continue;
                        }
                        num6 = num7;
                      }
label_193:
                      return;
label_190:
                      return;
label_179:
                      return;
label_174:
                      return;
                    }
                    catch (UnresolvableObjectException ex)
                    {
                      int num8 = 1;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
                        num8 = 1;
                      while (true)
                      {
                        switch (num8)
                        {
                          case 1:
                            obj = (object) ex;
                            num8 = 2;
                            continue;
                          case 2:
                            num = 1;
                            num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
                            continue;
                          default:
                            goto label_163;
                        }
                      }
                    }
                  case 43:
                    result = (IList) new List<object>(cacheable.Count - 1);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 89 : 72;
                    continue;
                  case 44:
                    cacheable = result2 as IList;
                    num3 = 13;
                    continue;
                  case 45:
                    // ISSUE: reference to a compiler-generated method
                    if (NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2.aIfpG7QMiVnDSXMyWVjS((object) NHQueryCacheWrapper.Log))
                    {
                      num3 = 63;
                      continue;
                    }
                    goto case 4;
                  case 46:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    awaiter1 = NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2.o7o0yEQMXPWu0hqh9cN8(NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2.RvjqrfQMTStieQgB63yE((object) (object[]) cached, (object) returnTypes, (object) session, cancellationToken));
                    num3 = 23;
                    continue;
                  case 47:
                    if (obj is Exception exception)
                    {
                      // ISSUE: reference to a compiler-generated method
                      ((ExceptionDispatchInfo) NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2.uRYm3EQMamAMkIFUC3PX((object) exception)).Throw();
                      num3 = 80;
                      continue;
                    }
                    goto label_191;
                  case 48:
                    // ISSUE: reference to a compiler-generated method
                    cached = NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2.Ppg1uwQMqwPvOSOWIjTw((object) cacheable, i);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 1 : 17;
                    continue;
                  case 49:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 7;
                    num4 = 2;
                    break;
                  case 50:
                    if (!awaiter2.IsCompleted)
                    {
                      num3 = 27;
                      continue;
                    }
                    goto case 77;
                  case 51:
                    goto label_197;
                  case 52:
                    returnType1 = returnTypes[0];
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 1 : 14;
                    continue;
                  case 53:
                    taskAwaiter2 = awaiter1;
                    num4 = 70;
                    break;
                  case 54:
                    // ISSUE: reference to a compiler-generated method
                    if (!NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2.aIfpG7QMiVnDSXMyWVjS((object) NHQueryCacheWrapper.Log))
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 1 : 15;
                      continue;
                    }
                    goto case 30;
                  case 56:
                  case 64:
                  case 82:
                    num5 = i;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 12 : 4;
                    continue;
                  case 57:
                    goto label_171;
                  case 58:
                  case 86:
                    // ISSUE: reference to a compiler-generated method
                    timestamp = (long) NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2.Ppg1uwQMqwPvOSOWIjTw((object) cacheable, 0);
                    num4 = 92;
                    break;
                  case 59:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = 77;
                    continue;
                  case 61:
                    i = 1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 1 : 6;
                    continue;
                  case 63:
                    // ISSUE: reference to a compiler-generated method
                    NHQueryCacheWrapper.Log.DebugFormat((string) NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2.isyL48QMRR4GPP6oeIY7(-87337865 ^ -87472471), (object) this.regionName, (object) key);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 4 : 0;
                    continue;
                  case 66:
                    taskAwaiter1 = awaiter2;
                    num3 = 41;
                    continue;
                  case 67:
                    goto label_169;
                  case 68:
                    result1 = (IList) null;
                    num3 = 81;
                    continue;
                  case 69:
                    goto label_168;
                  case 70:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2>(ref awaiter1, this);
                    num3 = 67;
                    continue;
                  case 71:
                    if (!awaiter1.IsCompleted)
                    {
                      num3 = 26;
                      continue;
                    }
                    goto case 39;
                  case 73:
                    if (isNaturalKeyLookup)
                    {
                      num3 = 10;
                      continue;
                    }
                    goto case 47;
                  case 74:
                  case 91:
                    awaiter1.GetResult();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 56 : 3;
                    continue;
                  case 75:
                    goto label_161;
                  case 76:
                    if (num5 == 1)
                    {
                      num3 = 73;
                      continue;
                    }
                    goto case 80;
                  case 77:
                    result2 = awaiter2.GetResult();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 41 : 44;
                    continue;
                  case 80:
                    obj = (object) null;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
                    continue;
                  case 83:
                    taskAwaiter1 = new TaskAwaiter<object>();
                    num4 = 59;
                    break;
                  case 84:
                    result1 = result;
                    num3 = 55;
                    continue;
                  case 85:
                    result1 = (IList) null;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 29 : 27;
                    continue;
                  case 87:
label_163:
                    num5 = num;
                    num3 = 76;
                    continue;
                  case 88:
                    i = num5 + 1;
                    num4 = 9;
                    break;
                  case 89:
                    i = 1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 37 : 30;
                    continue;
                  case 90:
                    if (this.IsUpToDate(spaces, timestamp))
                    {
                      num3 = 78;
                      continue;
                    }
                    goto case 54;
                  case 92:
                    // ISSUE: reference to a compiler-generated method
                    if (NHQueryCacheWrapper.\u003CGetAsync\u003Ed__2.aIfpG7QMiVnDSXMyWVjS((object) NHQueryCacheWrapper.Log))
                    {
                      num3 = 33;
                      continue;
                    }
                    goto case 28;
                  case 93:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 74 : 22;
                    continue;
                  case 94:
                    goto label_137;
                  default:
label_160:
                    num5 = i;
                    num3 = 88;
                    continue;
                }
                num3 = num4;
              }
label_197:
              return;
label_171:
              return;
label_169:
              return;
label_168:
              return;
label_191:
              throw obj;
            }
            catch (Exception ex)
            {
              int num9 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
                num9 = 1;
              while (true)
              {
                switch (num9)
                {
                  case 0:
                    goto label_167;
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
                    num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_166;
                }
              }
label_167:
              return;
label_166:
              return;
            }
        }
      }
label_200:;
    }

    public NHQueryCacheWrapper(
      string regionName,
      UpdateTimestampsCache updateTimestampsCache,
      Settings settings,
      IDictionary<string, string> props)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.updateTimestampsCache = updateTimestampsCache;
      if (string.IsNullOrWhiteSpace(regionName))
        regionName = typeof (NHQueryCacheWrapper).FullName;
      string cacheRegionPrefix = settings.CacheRegionPrefix;
      if (!string.IsNullOrEmpty(cacheRegionPrefix))
        regionName = cacheRegionPrefix + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105194202) + regionName;
      this.regionName = regionName;
      this.queryCache = settings.CacheProvider.BuildCache(this.regionName, props);
    }

    public void Clear()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            NHQueryCacheWrapper.jIlRdSWNYv4Drv2n0Fhe((object) this.Cache);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public bool Put(
      QueryKey key,
      ICacheAssembler[] returnTypes,
      IList result,
      bool isNaturalKeyLookup,
      ISessionImplementor session)
    {
      int num1 = 17;
      while (true)
      {
        int num2 = num1;
        INHibernateProxy nhibernateProxy;
        object entity;
        IList list;
        ICacheAssembler returnType;
        int num3;
        IEntityPersister entityPersister;
        CacheEntry cacheEntry;
        object state;
        EntityEntry entry;
        object id;
        long num4;
        while (true)
        {
          switch (num2)
          {
            case 1:
              num3 = 0;
              num2 = 8;
              continue;
            case 2:
            case 7:
              entry = ((IPersistenceContext) NHQueryCacheWrapper.K3hs71W3hqJ2Hb4SBW6N((object) session)).GetEntry(entity);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 24 : 27;
              continue;
            case 3:
            case 8:
              if (num3 < NHQueryCacheWrapper.YtcfaZWNLlYO6xAZTMEV((object) result))
                goto case 28;
              else
                goto label_7;
            case 4:
            case 19:
              entity = NHQueryCacheWrapper.PPNwx7W3bmZ4eHbTwxyx(NHQueryCacheWrapper.O3grlwW3B9h9207aF0IV((object) nhibernateProxy), (object) session);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 2 : 7;
              continue;
            case 5:
              this.queryCache.Put((object) key, (object) list);
              num2 = 13;
              continue;
            case 6:
              list = (IList) new List<object>(NHQueryCacheWrapper.YtcfaZWNLlYO6xAZTMEV((object) result) + 1)
              {
                (object) num4
              };
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 1;
              continue;
            case 9:
              state = NHQueryCacheWrapper.r5vMG9W3vYWIOtU1hVr4((object) entityPersister.CacheEntryStructure, (object) cacheEntry);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 17 : 33;
              continue;
            case 10:
              NHQueryCacheWrapper.Log.DebugFormat((string) NHQueryCacheWrapper.fyaIIDWNceGKuI2TCOlK(-2138160520 ^ -2138287876), (object) this.regionName, (object) key);
              num2 = 6;
              continue;
            case 11:
              id = NHQueryCacheWrapper.JmuDEeW3EwECkYfvTYGt((object) entry);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 12 : 8;
              continue;
            case 12:
              object[] loadedState = entry.LoadedState;
              object obj = NHQueryCacheWrapper.sSXioFW3fZA5flwxPD1N((object) loadedState, (object) entityPersister);
              cacheEntry = (CacheEntry) NHQueryCacheWrapper.cuI3PpW3CQeRXpQ1UBhD((object) loadedState, (object) entityPersister, NHQueryCacheWrapper.LW8ZI8W3Qk5qBnFPwqiD((object) entry), obj, (object) session, entity);
              num2 = 9;
              continue;
            case 13:
              goto label_4;
            case 14:
              if (entity is IEntity)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 19 : 29;
                continue;
              }
              goto case 20;
            case 15:
              NHQueryCacheWrapper.AxQOqnW3osALQhXB9NbV((object) list, NHQueryCacheWrapper.VkmsihW3ZxTyE2nVJlvv((object) (object[]) entity, (object) returnTypes, (object) null, (object) session, (object) null));
              num2 = 26;
              continue;
            case 16:
              if (NHQueryCacheWrapper.YtcfaZWNLlYO6xAZTMEV((object) result) != 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 34 : 12;
                continue;
              }
              goto label_22;
            case 17:
              if (isNaturalKeyLookup)
              {
                num2 = 16;
                continue;
              }
              goto case 34;
            case 18:
              if (returnTypes.Length == 1)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
                continue;
              }
              goto case 15;
            case 20:
              NHQueryCacheWrapper.AxQOqnW3osALQhXB9NbV((object) list, NHQueryCacheWrapper.AVyBVyW38rBSS5x3kRMj((object) returnType, entity, (object) session, (object) null));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 28 : 32;
              continue;
            case 21:
              if (!NHQueryCacheWrapper.yBD3E9W3W79QWCyZjaKM(NHQueryCacheWrapper.O3grlwW3B9h9207aF0IV((object) nhibernateProxy)))
              {
                num2 = 19;
                continue;
              }
              goto case 23;
            case 22:
              goto label_25;
            case 23:
              NHQueryCacheWrapper.AxQOqnW3osALQhXB9NbV((object) list, returnType.Disassemble(entity, session, (object) null));
              num2 = 30;
              continue;
            case 24:
              goto label_22;
            case 25:
              nhibernateProxy = (INHibernateProxy) entity;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 7 : 21;
              continue;
            case 26:
            case 30:
            case 32:
            case 35:
              ++num3;
              num2 = 3;
              continue;
            case 27:
              if (entry == null)
              {
                num2 = 22;
                continue;
              }
              entityPersister = (IEntityPersister) NHQueryCacheWrapper.uR9xlAW3GyDsW3mJp5Am((object) entry);
              num2 = 11;
              continue;
            case 28:
              entity = NHQueryCacheWrapper.lEBFLuWNz0CyR3rhFtiQ((object) result, num3);
              num2 = 18;
              continue;
            case 29:
              if (!NHQueryCacheWrapper.iUfpAbW3FwyivbhvvEvv(entity))
              {
                num2 = 2;
                continue;
              }
              goto case 25;
            case 31:
              if (NHQueryCacheWrapper.USiLLQWNs4vV7Q6spGgu((object) NHQueryCacheWrapper.Log))
              {
                num2 = 10;
                continue;
              }
              goto case 6;
            case 33:
              NHQueryCacheWrapper.AxQOqnW3osALQhXB9NbV((object) list, (object) new NHEntityCacheEntry(id, state, entity.GetType().FullName));
              num2 = 35;
              continue;
            case 34:
              num4 = NHQueryCacheWrapper.eeOXoWWNUxBs6Ydtg59X((object) session);
              num2 = 31;
              continue;
            default:
              returnType = returnTypes[0];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 14 : 13;
              continue;
          }
        }
label_7:
        num1 = 5;
      }
label_4:
      return true;
label_22:
      return false;
label_25:
      return false;
    }

    public IList Get(
      QueryKey key,
      ICacheAssembler[] returnTypes,
      bool isNaturalKeyLookup,
      ISet<string> spaces,
      ISessionImplementor session)
    {
      if (NHQueryCacheWrapper.Log.IsDebugEnabled())
        NHQueryCacheWrapper.Log.DebugFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477266172), (object) this.regionName, (object) key);
      IList list1 = (IList) this.queryCache.Get((object) key);
      if (list1 == null)
      {
        NHQueryCacheWrapper.Log.DebugFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1925118608 << 2 ^ -889587448), (object) key);
        return (IList) null;
      }
      long timestamp = (long) list1[0];
      if (NHQueryCacheWrapper.Log.IsDebugEnabled())
        NHQueryCacheWrapper.Log.DebugFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1255365154 ^ 596875508 ^ -1765986678), (object) StringHelper.CollectionToString((IEnumerable) spaces));
      if (!isNaturalKeyLookup && !this.IsUpToDate(spaces, timestamp))
      {
        if (NHQueryCacheWrapper.Log.IsDebugEnabled())
          NHQueryCacheWrapper.Log.DebugFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-441065788 ^ -2092910478 ^ 1727492790), (object) key);
        return (IList) null;
      }
      if (NHQueryCacheWrapper.Log.IsDebugEnabled())
        NHQueryCacheWrapper.Log.DebugFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 654171967), (object) key);
      for (int index = 1; index < list1.Count; ++index)
      {
        object obj = list1[index];
        if (returnTypes.Length == 1)
        {
          ICacheAssembler returnType = returnTypes[0];
          if (!(returnType is ManyToOneType) || !(obj is NHEntityCacheEntry))
            returnType.BeforeAssemble(obj, session);
        }
        else
          TypeHelper.BeforeAssemble((object[]) obj, returnTypes, session);
      }
      IList list2 = (IList) new List<object>(list1.Count - 1);
      for (int index = 1; index < list1.Count; ++index)
      {
        try
        {
          object obj1 = list1[index];
          if (returnTypes.Length == 1)
          {
            ICacheAssembler returnType = returnTypes[0];
            if (returnType is ManyToOneType)
            {
              if (obj1 is NHEntityCacheEntry entityCacheEntry)
              {
                ISessionFactoryImplementor factory = session.Factory;
                IEntityPersister entityPersister = factory.GetEntityPersister(entityCacheEntry.ClassName);
                EntityKey key1 = new EntityKey(entityCacheEntry.Id, entityPersister);
                if (session.PersistenceContext.ContainsEntity(key1))
                {
                  list2.Add(returnType.Assemble(entityCacheEntry.Id, session, (object) null));
                }
                else
                {
                  CacheEntry entry = (CacheEntry) entityPersister.CacheEntryStructure.Destructure(entityCacheEntry.State, factory);
                  if (entityPersister.EntityMetamodel.SubclassEntityNames.Contains(entry.Subclass))
                  {
                    LoadEvent @event = new LoadEvent(entityCacheEntry.Id, entityCacheEntry.ClassName, false, (IEventSource) session);
                    object obj2 = this.AssembleCacheEntry(entry, entityCacheEntry.Id, entityPersister, @event);
                    list2.Add(obj2);
                  }
                }
              }
              else
                list2.Add(returnType.Assemble(obj1, session, (object) null));
            }
            else
              list2.Add(returnType.Assemble(obj1, session, (object) null));
          }
          else
            list2.Add((object) TypeHelper.Assemble((object[]) obj1, returnTypes, session, (object) null));
        }
        catch (UnresolvableObjectException ex)
        {
          if (isNaturalKeyLookup)
          {
            NHQueryCacheWrapper.Log.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272498125));
            this.queryCache.Remove((object) key);
            return (IList) null;
          }
          throw;
        }
      }
      return list2;
    }

    public void Destroy()
    {
      switch (1)
      {
        case 1:
          try
          {
            NHQueryCacheWrapper.QiiI3JW3ugIDfuTUMWiJ((object) this.queryCache);
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
              num = 0;
            switch (num)
            {
              case 0:
                return;
              default:
                return;
            }
          }
          catch (Exception ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_1;
                default:
                  NHQueryCacheWrapper.cLoOx2W3VNxwUs2LvD2X((object) NHQueryCacheWrapper.Log, NHQueryCacheWrapper.cr2kfZW3IVoMh3Pji9M7(NHQueryCacheWrapper.fyaIIDWNceGKuI2TCOlK(-1921202237 ^ -1921068341), (object) this.regionName), (object) ex);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 1 : 0;
                  continue;
              }
            }
label_1:
            break;
          }
      }
    }

    public ICache Cache => this.queryCache;

    public string RegionName => this.regionName;

    private object AssembleCacheEntry(
      CacheEntry entry,
      object id,
      IEntityPersister persister,
      LoadEvent @event)
    {
      int num1 = 9;
      object entity;
      while (true)
      {
        int num2 = num1;
        IEventSource source;
        IPostLoadEventListener[] loadEventListeners;
        while (true)
        {
          object[] loadedState;
          IType[] typeArray;
          IEntityPersister persister1;
          PostLoadEvent postLoadEvent;
          object version;
          int index;
          object obj1;
          switch (num2)
          {
            case 1:
            case 3:
              NHQueryCacheWrapper.s6H8uwW3wceraGrpipBX((object) loadEventListeners[index], (object) postLoadEvent);
              num2 = 20;
              continue;
            case 2:
              NHQueryCacheWrapper.afZYYxW31D8tISSw42EA((object) NHQueryCacheWrapper.Log, NHQueryCacheWrapper.sLqqx0W3Pj9OrWjdIVA9(NHQueryCacheWrapper.fyaIIDWNceGKuI2TCOlK(-138018305 ^ -138144677), version));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 14 : 18;
              continue;
            case 4:
              postLoadEvent = new PostLoadEvent(source);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
              continue;
            case 5:
              goto label_15;
            case 6:
              goto label_9;
            case 7:
            case 21:
              if (index < loadEventListeners.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 1 : 0;
                continue;
              }
              goto label_9;
            case 8:
              obj1 = NHQueryCacheWrapper.nSs51eW3XwxeJlWYdRwX((object) source, (object) persister1, id);
              break;
            case 9:
              object obj2 = NHQueryCacheWrapper.LV9XRhW3SHrk9pHO6lST((object) @event);
              source = (IEventSource) NHQueryCacheWrapper.PlIrg7W3i2tYF8igTdIj((object) @event);
              ISessionFactoryImplementor factoryImplementor = (ISessionFactoryImplementor) NHQueryCacheWrapper.Rpi4HVW3RZx9qsgDVTSv((object) source);
              if (NHQueryCacheWrapper.USiLLQWNs4vV7Q6spGgu((object) NHQueryCacheWrapper.Log))
                NHQueryCacheWrapper.Log.Debug(NHQueryCacheWrapper.cr2kfZW3IVoMh3Pji9M7((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740474722), NHQueryCacheWrapper.MFUrOFW3qU6NfVACvGKw((object) persister, id, (object) factoryImplementor)));
              persister1 = (IEntityPersister) NHQueryCacheWrapper.qQTPFcW3KoMGsVWdVmX6((object) factoryImplementor, (object) entry.Subclass);
              if (obj2 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 8 : 4;
                continue;
              }
              obj1 = obj2;
              break;
            case 10:
              NHQueryCacheWrapper.BxKiKPW3nd6AgKZHIoHH((object) new EntityKey(id, persister1), entity, (object) persister1, (object) LockMode.None, NHQueryCacheWrapper.ElpPfTW3Tx3e5bHLNypt((object) entry), NHQueryCacheWrapper.sf0nUTW3kjGLUBf0roRY((object) entry), (object) source);
              num2 = 12;
              continue;
            case 11:
              NHQueryCacheWrapper.WUiCZcW3DOdkLmnISrPk((object) postLoadEvent, (object) persister);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 5 : 2;
              continue;
            case 12:
              typeArray = (IType[]) NHQueryCacheWrapper.r04ipjW3OT20HQBymRX9((object) persister1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 14 : 12;
              continue;
            case 13:
              version = NHQueryCacheWrapper.sSXioFW3fZA5flwxPD1N((object) loadedState, (object) persister1);
              num2 = 16;
              continue;
            case 14:
              loadedState = (object[]) NHQueryCacheWrapper.HP9wgaW32brgTXE9BdRE((object) entry, entity, id, (object) persister1, (object) source.Interceptor, (object) source);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 19 : 18;
              continue;
            case 15:
              NHQueryCacheWrapper.r72nEMW3aOLn9MhE1AB0((object) postLoadEvent, id);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 4 : 11;
              continue;
            case 16:
              if (!NHQueryCacheWrapper.USiLLQWNs4vV7Q6spGgu((object) NHQueryCacheWrapper.Log))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 10 : 17;
                continue;
              }
              goto case 2;
            case 17:
            case 18:
              IPersistenceContext persistenceContext = source.PersistenceContext;
              persistenceContext.AddEntry(entity, Status.Loaded, loadedState, (object) null, id, version, LockMode.None, true, persister1, false, NHQueryCacheWrapper.ElpPfTW3Tx3e5bHLNypt((object) entry));
              NHQueryCacheWrapper.krbABYW3NajU6UB2Otdm((object) persister1, entity, entry.AreLazyPropertiesUnfetched, (object) source);
              NHQueryCacheWrapper.ocY9BYW336Il4YaJxcel((object) persistenceContext);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 3 : 4;
              continue;
            case 19:
              NHQueryCacheWrapper.G2PLF1W3efATdLyTtp84((object) loadedState, (object) typeArray, (object) persister1.PropertyUpdateability, (object) loadedState, (object) source);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 13 : 10;
              continue;
            case 20:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 7 : 5;
              continue;
            case 22:
              index = 0;
              num2 = 21;
              continue;
            default:
              NHQueryCacheWrapper.JUAsjaW3pt20cyF27kZU((object) postLoadEvent, entity);
              num2 = 15;
              continue;
          }
          entity = obj1;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 10 : 1;
        }
label_15:
        loadEventListeners = ((EventListeners) NHQueryCacheWrapper.ktGbcGW3tNciswSF6FST((object) source)).PostLoadEventListeners;
        num1 = 22;
      }
label_9:
      return entity;
    }

    protected virtual bool IsUpToDate(ISet<string> spaces, long timestamp) => this.updateTimestampsCache.IsUpToDate(spaces, timestamp);

    static NHQueryCacheWrapper()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            // ISSUE: type reference
            NHQueryCacheWrapper.Log = (ILogger) NHQueryCacheWrapper.nUwFDGW3HKmKnmn8meta(NHQueryCacheWrapper.VWKb3mW36AGyDS0Yd0gh(__typeref (NHQueryCacheWrapper)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
            continue;
          case 2:
            NHQueryCacheWrapper.oruf2HW34intjM4L4lbX();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object Hc4O0iWNj4o9dJGPidcg([In] object obj0, [In] CancellationToken obj1) => (object) ((ICache) obj0).ClearAsync(obj1);

    internal static bool cx9SNOWNgYi7Hi8EfQUS() => NHQueryCacheWrapper.FKZKokWNrM8GV7NG5Mx8 == null;

    internal static NHQueryCacheWrapper rrerspWN5bM6mCmx138O() => NHQueryCacheWrapper.FKZKokWNrM8GV7NG5Mx8;

    internal static void jIlRdSWNYv4Drv2n0Fhe([In] object obj0) => ((ICache) obj0).Clear();

    internal static int YtcfaZWNLlYO6xAZTMEV([In] object obj0) => ((ICollection) obj0).Count;

    internal static long eeOXoWWNUxBs6Ydtg59X([In] object obj0) => ((ISessionImplementor) obj0).Timestamp;

    internal static bool USiLLQWNs4vV7Q6spGgu([In] object obj0) => ((ILogger) obj0).IsDebugEnabled();

    internal static object fyaIIDWNceGKuI2TCOlK(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object lEBFLuWNz0CyR3rhFtiQ([In] object obj0, [In] int obj1) => ((IList) obj0)[obj1];

    internal static bool iUfpAbW3FwyivbhvvEvv([In] object obj0) => obj0.IsProxy();

    internal static object O3grlwW3B9h9207aF0IV([In] object obj0) => (object) ((INHibernateProxy) obj0).HibernateLazyInitializer;

    internal static bool yBD3E9W3W79QWCyZjaKM([In] object obj0) => ((ILazyInitializer) obj0).IsUninitialized;

    internal static int AxQOqnW3osALQhXB9NbV([In] object obj0, [In] object obj1) => ((IList) obj0).Add(obj1);

    internal static object PPNwx7W3bmZ4eHbTwxyx([In] object obj0, [In] object obj1) => ((ILazyInitializer) obj0).GetImplementation((ISessionImplementor) obj1);

    internal static object K3hs71W3hqJ2Hb4SBW6N([In] object obj0) => (object) ((ISessionImplementor) obj0).PersistenceContext;

    internal static object uR9xlAW3GyDsW3mJp5Am([In] object obj0) => (object) ((EntityEntry) obj0).Persister;

    internal static object JmuDEeW3EwECkYfvTYGt([In] object obj0) => ((EntityEntry) obj0).Id;

    internal static object sSXioFW3fZA5flwxPD1N([In] object obj0, [In] object obj1) => Versioning.GetVersion((object[]) obj0, (IEntityPersister) obj1);

    internal static bool LW8ZI8W3Qk5qBnFPwqiD([In] object obj0) => ((EntityEntry) obj0).LoadedWithLazyPropertiesUnfetched;

    internal static object cuI3PpW3CQeRXpQ1UBhD(
      [In] object obj0,
      [In] object obj1,
      [In] bool obj2,
      [In] object obj3,
      [In] object obj4,
      [In] object obj5)
    {
      return (object) CacheEntry.Create((object[]) obj0, (IEntityPersister) obj1, obj2, obj3, (ISessionImplementor) obj4, obj5);
    }

    internal static object r5vMG9W3vYWIOtU1hVr4([In] object obj0, [In] object obj1) => ((ICacheEntryStructure) obj0).Structure(obj1);

    internal static object AVyBVyW38rBSS5x3kRMj(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return ((ICacheAssembler) obj0).Disassemble(obj1, (ISessionImplementor) obj2, obj3);
    }

    internal static object VkmsihW3ZxTyE2nVJlvv(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3,
      [In] object obj4)
    {
      return (object) TypeHelper.Disassemble((object[]) obj0, (ICacheAssembler[]) obj1, (bool[]) obj2, (ISessionImplementor) obj3, obj4);
    }

    internal static void QiiI3JW3ugIDfuTUMWiJ([In] object obj0) => ((ICache) obj0).Destroy();

    internal static object cr2kfZW3IVoMh3Pji9M7([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static void cLoOx2W3VNxwUs2LvD2X([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Warn(obj1, (Exception) obj2);

    internal static object LV9XRhW3SHrk9pHO6lST([In] object obj0) => ((LoadEvent) obj0).InstanceToLoad;

    internal static object PlIrg7W3i2tYF8igTdIj([In] object obj0) => (object) ((AbstractEvent) obj0).Session;

    internal static object Rpi4HVW3RZx9qsgDVTSv([In] object obj0) => (object) ((ISessionImplementor) obj0).Factory;

    internal static object MFUrOFW3qU6NfVACvGKw([In] object obj0, [In] object obj1, [In] object obj2) => (object) MessageHelper.InfoString((IEntityPersister) obj0, obj1, (ISessionFactoryImplementor) obj2);

    internal static object qQTPFcW3KoMGsVWdVmX6([In] object obj0, [In] object obj1) => (object) ((ISessionFactoryImplementor) obj0).GetEntityPersister((string) obj1);

    internal static object nSs51eW3XwxeJlWYdRwX([In] object obj0, [In] object obj1, [In] object obj2) => ((IEventSource) obj0).Instantiate((IEntityPersister) obj1, obj2);

    internal static bool ElpPfTW3Tx3e5bHLNypt([In] object obj0) => ((CacheEntry) obj0).AreLazyPropertiesUnfetched;

    internal static object sf0nUTW3kjGLUBf0roRY([In] object obj0) => ((CacheEntry) obj0).Version;

    internal static void BxKiKPW3nd6AgKZHIoHH(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3,
      [In] bool obj4,
      [In] object obj5,
      [In] object obj6)
    {
      TwoPhaseLoad.AddUninitializedCachedEntity((EntityKey) obj0, obj1, (IEntityPersister) obj2, (LockMode) obj3, obj4, obj5, (ISessionImplementor) obj6);
    }

    internal static object r04ipjW3OT20HQBymRX9([In] object obj0) => (object) ((IEntityPersister) obj0).PropertyTypes;

    internal static object HP9wgaW32brgTXE9BdRE(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3,
      [In] object obj4,
      [In] object obj5)
    {
      return (object) ((CacheEntry) obj0).Assemble(obj1, obj2, (IEntityPersister) obj3, (IInterceptor) obj4, (ISessionImplementor) obj5);
    }

    internal static void G2PLF1W3efATdLyTtp84(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3,
      [In] object obj4)
    {
      TypeHelper.DeepCopy((object[]) obj0, (IType[]) obj1, (bool[]) obj2, (object[]) obj3, (ISessionImplementor) obj4);
    }

    internal static object sLqqx0W3Pj9OrWjdIVA9([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static void afZYYxW31D8tISSw42EA([In] object obj0, [In] object obj1) => ((ILogger) obj0).Debug(obj1);

    internal static void krbABYW3NajU6UB2Otdm([In] object obj0, [In] object obj1, [In] bool obj2, [In] object obj3) => ((IEntityPersister) obj0).AfterInitialize(obj1, obj2, (ISessionImplementor) obj3);

    internal static void ocY9BYW336Il4YaJxcel([In] object obj0) => ((IPersistenceContext) obj0).InitializeNonLazyCollections();

    internal static void JUAsjaW3pt20cyF27kZU([In] object obj0, [In] object obj1) => ((PostLoadEvent) obj0).Entity = obj1;

    internal static void r72nEMW3aOLn9MhE1AB0([In] object obj0, [In] object obj1) => ((PostLoadEvent) obj0).Id = obj1;

    internal static void WUiCZcW3DOdkLmnISrPk([In] object obj0, [In] object obj1) => ((PostLoadEvent) obj0).Persister = (IEntityPersister) obj1;

    internal static object ktGbcGW3tNciswSF6FST([In] object obj0) => (object) ((ISessionImplementor) obj0).Listeners;

    internal static void s6H8uwW3wceraGrpipBX([In] object obj0, [In] object obj1) => ((IPostLoadEventListener) obj0).OnPostLoad((PostLoadEvent) obj1);

    internal static void oruf2HW34intjM4L4lbX() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static System.Type VWKb3mW36AGyDS0Yd0gh([In] RuntimeTypeHandle obj0) => System.Type.GetTypeFromHandle(obj0);

    internal static object nUwFDGW3HKmKnmn8meta(System.Type componentType) => (object) Logger.GetLogger(componentType);
  }
}
