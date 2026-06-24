// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Locking.DbDistributedLockService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Locking
{
  /// <summary>
  /// Реализация сервиса распределенных блокировок на БД (используется по умолчанию)
  /// </summary>
  internal class DbDistributedLockService : LockService<DbDistributedLockServiceSettings>
  {
    private static DbDistributedLockService A7klRkhraSB6M8OUqPui;

    public SessionFactoryHolder SessionFactoryHolder
    {
      get => this.\u003CSessionFactoryHolder\u003Ek__BackingField;
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
              this.\u003CSessionFactoryHolder\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
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

    public ITransformationProvider TransformationProvider
    {
      get => this.\u003CTransformationProvider\u003Ek__BackingField;
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
              this.\u003CTransformationProvider\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
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

    /// <inheritdoc />
    protected override Lock AcquireLockInternalImpl(
      string name,
      TimeSpan maxValidFor,
      TimeSpan timeout,
      TimeSpan repeatInterval)
    {
      int num1 = 3;
      Lock dLock;
      while (true)
      {
        int num2 = num1;
        DbDistributedLockService distributedLockService;
        string name1;
        TimeSpan maxValidFor1;
        Guid token;
        while (true)
        {
          switch (num2)
          {
            case 1:
              name1 = name;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 4 : 3;
              continue;
            case 2:
              distributedLockService = this;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 1;
              continue;
            case 3:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 2 : 0;
              continue;
            case 4:
              maxValidFor1 = maxValidFor;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
              continue;
            case 5:
              this.RepeatUntilTimeout(timeout, repeatInterval, (Func<bool>) (() =>
              {
                int num5 = 1;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      if (!distributedLockService.TryObtainDbLock(name1, maxValidFor1, token))
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
                        continue;
                      }
                      goto case 3;
                    case 2:
                      goto label_2;
                    case 3:
                      dLock = (Lock) new ExtendableLock(name1, maxValidFor1, (System.Action) (() =>
                      {
                        int num6 = 1;
                        while (true)
                        {
                          switch (num6)
                          {
                            case 0:
                              goto label_2;
                            case 1:
                              distributedLockService.ExtendDbLock(name1, maxValidFor1, token);
                              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
                              continue;
                            default:
                              goto label_4;
                          }
                        }
label_2:
                        return;
label_4:;
                      }), (System.Action) (() =>
                      {
                        int num7 = 1;
                        while (true)
                        {
                          switch (num7)
                          {
                            case 0:
                              goto label_2;
                            case 1:
                              distributedLockService.DeleteDbLock(name1, token);
                              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
                              continue;
                            default:
                              goto label_4;
                          }
                        }
label_2:
                        return;
label_4:;
                      }));
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 2 : 0;
                      continue;
                    default:
                      goto label_3;
                  }
                }
label_2:
                return true;
label_3:
                return false;
              }));
              num2 = 6;
              continue;
            case 6:
              goto label_4;
            case 7:
              token = DbDistributedLockService.V1pUpEhrwoYOlZCOwbAw();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 5 : 2;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        dLock = (Lock) null;
        num1 = 7;
      }
label_4:
      return dLock;
    }

    /// <inheritdoc />
    protected override async Task<Lock> AcquireLockInternalAsyncImpl(
      string name,
      CancellationToken token,
      TimeSpan maxValidFor,
      TimeSpan timeout,
      TimeSpan repeatInterval)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        Lock result;
        int num3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_33;
            case 2:
              num2 = 4;
              continue;
            case 3:
              goto label_34;
            case 4:
              try
              {
                int num4;
                if (num3 != 0)
                  num4 = 18;
                else
                  goto label_20;
label_7:
                TaskAwaiter<bool> taskAwaiter;
                TaskAwaiter<bool> awaiter;
                DbDistributedLockService distributedLockService;
                string name1;
                TimeSpan maxValidFor1;
                Guid tokenId;
                Lock dLock;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      distributedLockService = this;
                      num4 = 9;
                      continue;
                    case 2:
                    case 10:
                      awaiter.GetResult();
                      num4 = 14;
                      continue;
                    case 3:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, DbDistributedLockService.\u003CAcquireLockInternalAsyncImpl\u003Ed__10>(ref awaiter, this);
                      num4 = 12;
                      continue;
                    case 4:
                      dLock = (Lock) null;
                      num4 = 5;
                      continue;
                    case 5:
                      // ISSUE: reference to a compiler-generated method
                      tokenId = DbDistributedLockService.\u003CAcquireLockInternalAsyncImpl\u003Ed__10.tUyDE8v7HHPXH7jmPDvl();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 7 : 1;
                      continue;
                    case 6:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num3 = 0;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 8 : 8;
                      continue;
                    case 7:
                      System.Action action1;
                      System.Action action2;
                      awaiter = this.RepeatUntilTimeoutAsync(timeout, repeatInterval, token, (Func<bool>) (() =>
                      {
                        int num7 = 3;
                        while (true)
                        {
                          switch (num7)
                          {
                            case 1:
                              goto label_2;
                            case 2:
                              goto label_3;
                            case 3:
                              if (!distributedLockService.TryObtainDbLock(name1, maxValidFor1, tokenId))
                              {
                                num7 = 2;
                                continue;
                              }
                              break;
                          }
                          string name2 = name1;
                          TimeSpan ttl = maxValidFor1;
                          System.Action action3 = action1;
                          System.Action extendLockAction = action3 == null ? (action1 = (System.Action) (() =>
                          {
                            int num8 = 1;
                            while (true)
                            {
                              switch (num8)
                              {
                                case 0:
                                  goto label_2;
                                case 1:
                                  distributedLockService.ExtendDbLock(name1, maxValidFor1, tokenId);
                                  num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
                                  continue;
                                default:
                                  goto label_4;
                              }
                            }
label_2:
                            return;
label_4:;
                          })) : action3;
                          System.Action action4 = action2;
                          System.Action releaseLockAction = action4 == null ? (action2 = (System.Action) (() =>
                          {
                            int num9 = 1;
                            while (true)
                            {
                              switch (num9)
                              {
                                case 0:
                                  goto label_2;
                                case 1:
                                  distributedLockService.DeleteDbLock(name1, tokenId);
                                  num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
                                  continue;
                                default:
                                  goto label_4;
                              }
                            }
label_2:
                            return;
label_4:;
                          })) : action4;
                          dLock = (Lock) new ExtendableLock(name2, ttl, extendLockAction, releaseLockAction);
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 1 : 1;
                        }
label_2:
                        return true;
label_3:
                        return false;
                      })).GetAwaiter();
                      num4 = 11;
                      continue;
                    case 8:
                      taskAwaiter = awaiter;
                      num4 = 3;
                      continue;
                    case 9:
                      name1 = name;
                      num4 = 16;
                      continue;
                    case 11:
                      if (awaiter.IsCompleted)
                      {
                        num4 = 10;
                        continue;
                      }
                      goto case 6;
                    case 12:
                      goto label_30;
                    case 13:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num3 = -1;
                      num4 = 2;
                      continue;
                    case 14:
                      result = dLock;
                      num4 = 15;
                      continue;
                    case 15:
                      goto label_35;
                    case 16:
                      maxValidFor1 = maxValidFor;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 1 : 4;
                      continue;
                    case 17:
                      goto label_20;
                    case 18:
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 1;
                      continue;
                    default:
                      taskAwaiter = new TaskAwaiter<bool>();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 1 : 13;
                      continue;
                  }
                }
label_30:
                return;
label_20:
                awaiter = taskAwaiter;
                num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
                {
                  num4 = 0;
                  goto label_7;
                }
                else
                  goto label_7;
              }
              catch (Exception ex)
              {
                int num10 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
                  num10 = 0;
                while (true)
                {
                  switch (num10)
                  {
                    case 1:
                      goto label_26;
                    case 2:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.SetException(ex);
                      num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 1 : 1;
                      continue;
                    default:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = -2;
                      num10 = 2;
                      continue;
                  }
                }
label_26:
                return;
              }
            case 5:
label_35:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003E1__state = -2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
              continue;
            default:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003Et__builder.SetResult(result);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 1;
              continue;
          }
        }
label_34:
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        num3 = (^this).\u003C\u003E1__state;
        num1 = 2;
      }
label_33:;
    }

    /// <inheritdoc />
    protected override string GetInternalLockName(string name) => (string) DbDistributedLockService.GviZlLhr4AXrj6X62o6D((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978578622), (object) name);

    private bool TryObtainDbLock(string name, TimeSpan maxValidFor, Guid token)
    {
      int num1 = 2;
      string name1;
      TimeSpan maxValidFor1;
      DbDistributedLockService distributedLockService;
      string environmentIdentifier;
      Guid token1;
      bool hasLockRecord;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              name1 = name;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
              continue;
            case 2:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 1;
              continue;
            case 3:
              distributedLockService = this;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 6 : 2;
              continue;
            case 4:
              goto label_3;
            case 5:
              goto label_8;
            case 6:
              goto label_7;
            case 7:
              goto label_6;
            case 8:
              goto label_4;
            default:
              maxValidFor1 = maxValidFor;
              num2 = 3;
              continue;
          }
        }
label_3:
        hasLockRecord = false;
        num1 = 5;
        continue;
label_4:
        environmentIdentifier = (string) DbDistributedLockService.eerVA3hr6DqOrmKBk0Fi((object) this.ApplicationEnvironment);
        num1 = 4;
        continue;
label_7:
        token1 = token;
        num1 = 8;
      }
label_6:
      return hasLockRecord;
label_8:
      try
      {
        new StatelessSessionHelper(this.SessionFactoryHolder).ExecuteOnSeparateTransaction((Action<IStatelessSession>) (session =>
        {
          int num3 = 14;
          while (true)
          {
            int num4 = num3;
            DbLock dblock1;
            while (true)
            {
              DateTime? nullable1;
              DateTime dateTime;
              DateTime utcNow;
              DateTime? nullable2;
              DateTime? nullable3;
              switch (num4)
              {
                case 1:
                  DbDistributedLockService distributedLockService1 = distributedLockService;
                  IStatelessSession session1 = session;
                  DbLock dblock2 = new DbLock();
                  dblock2.Id = name1;
                  // ISSUE: reference to a compiler-generated method
                  DbDistributedLockService.\u003C\u003Ec__DisplayClass12_0.iU5u2vv7MQI54CsSqgYq((object) dblock2, (object) environmentIdentifier);
                  dblock2.CreationDate = new DateTime?(utcNow);
                  dblock2.ValidUntilDate = nullable2;
                  // ISSUE: reference to a compiler-generated method
                  DbDistributedLockService.\u003C\u003Ec__DisplayClass12_0.zCvpODv7JWo9gmBcXn1s((object) dblock2, token1);
                  distributedLockService1.InsertDbLockByQuery(session1, dblock2);
                  num4 = 16;
                  continue;
                case 2:
                  nullable3 = new DateTime?(utcNow + maxValidFor1);
                  break;
                case 3:
                  hasLockRecord = true;
                  num4 = 4;
                  continue;
                case 4:
                  goto label_20;
                case 5:
                  goto label_18;
                case 6:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  distributedLockService.Logger.Debug(DbDistributedLockService.\u003C\u003Ec__DisplayClass12_0.xigfcDv7gGkLT8FRg12l(DbDistributedLockService.\u003C\u003Ec__DisplayClass12_0.oE7alAv7rM37WG5XZsQd(1142330761 ^ 1541959139 ^ 536554476), (object) name1, (object) environmentIdentifier));
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 3;
                  continue;
                case 7:
                  if (!(maxValidFor1 == LockService.InfiniteTimeSpan))
                  {
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 2;
                    continue;
                  }
                  nullable1 = new DateTime?();
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 15 : 19;
                  continue;
                case 8:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  if (DbDistributedLockService.\u003C\u003Ec__DisplayClass12_0.pOacluv7lJwi02c2lmOy(DbDistributedLockService.\u003C\u003Ec__DisplayClass12_0.pyRNLBv7dCOWtP5XqtIP((object) dblock1), (object) environmentIdentifier))
                  {
                    num4 = 6;
                    continue;
                  }
                  goto label_15;
                case 9:
                  nullable1 = dblock1.ValidUntilDate;
                  num4 = 12;
                  continue;
                case 10:
                  goto label_23;
                case 11:
                  goto label_5;
                case 12:
                  if (nullable1.HasValue)
                  {
                    num4 = 18;
                    continue;
                  }
                  goto case 8;
                case 13:
                  utcNow = DateTime.UtcNow;
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 7 : 1;
                  continue;
                case 14:
                  dblock1 = session.Get<DbLock>((object) name1);
                  num4 = 13;
                  continue;
                case 15:
                  if (dblock1 != null)
                  {
                    num4 = 9;
                    continue;
                  }
                  goto case 21;
                case 16:
                  hasLockRecord = true;
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 3 : 5;
                  continue;
                case 17:
                  goto label_28;
                case 18:
                  nullable1 = dblock1.ValidUntilDate;
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
                  continue;
                case 19:
                  nullable3 = nullable1;
                  break;
                case 20:
                  // ISSUE: reference to a compiler-generated method
                  if (!DbDistributedLockService.\u003C\u003Ec__DisplayClass12_0.ARH5SZv795awxthgSaCF(dateTime.Add(distributedLockService.ValidUntilDateOverTime), utcNow))
                  {
                    num4 = 8;
                    continue;
                  }
                  goto label_23;
                case 21:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  DbDistributedLockService.\u003C\u003Ec__DisplayClass12_0.jJHVmJv7yHHEFc4jOnn5((object) distributedLockService.Logger, DbDistributedLockService.\u003C\u003Ec__DisplayClass12_0.KgFACHv7m3SK6uag3RvJ((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289497752), (object) name1));
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 1 : 0;
                  continue;
                default:
                  dateTime = nullable1.Value;
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 9 : 20;
                  continue;
              }
              nullable2 = nullable3;
              num4 = 15;
            }
label_23:
            distributedLockService.DeleteDbLockByQuery(session, dblock1);
            num3 = 17;
            continue;
label_28:
            hasLockRecord = false;
            num3 = 11;
          }
label_20:
          return;
label_18:
          return;
label_5:
          return;
label_15:;
        }));
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
          num5 = 0;
        switch (num5)
        {
          default:
            goto label_6;
        }
      }
      catch (Exception ex)
      {
        int num6 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
          num6 = 0;
        while (true)
        {
          switch (num6)
          {
            case 1:
              goto label_6;
            case 2:
              this.Logger.Debug(ex, (string) DbDistributedLockService.GviZlLhr4AXrj6X62o6D((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921032675), (object) name1));
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 1;
              continue;
            default:
              hasLockRecord = false;
              num6 = 2;
              continue;
          }
        }
      }
    }

    private void ExtendDbLock(string name, TimeSpan maxValidFor, Guid token)
    {
      int num1 = 3;
      // ISSUE: variable of a compiler-generated type
      DbDistributedLockService.\u003C\u003Ec__DisplayClass13_0 cDisplayClass130;
      CallContextSessionOwner contextSessionOwner;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_3;
          case 2:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass130.name = name;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
            continue;
          case 3:
            // ISSUE: object of a compiler-generated type is created
            cDisplayClass130 = new DbDistributedLockService.\u003C\u003Ec__DisplayClass13_0();
            num1 = 2;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass130.\u003C\u003E4__this = this;
            num1 = 6;
            continue;
          case 5:
            contextSessionOwner = (CallContextSessionOwner) DbDistributedLockService.rRyWJyhrAUViEFUJhtKs();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 1;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            this.Logger.Debug(DbDistributedLockService.GviZlLhr4AXrj6X62o6D(DbDistributedLockService.heC2OkhrH8m29hPNfOJs(-1921202237 ^ -1921032815), (object) cDisplayClass130.name));
            num1 = 5;
            continue;
          case 7:
            goto label_14;
          case 8:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass130.token = token;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 4 : 4;
            continue;
          default:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass130.maxValidFor = maxValidFor;
            num1 = 8;
            continue;
        }
      }
label_14:
      return;
label_3:
      try
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        DbDistributedLockService.\u003C\u003Ec__DisplayClass13_1 cDisplayClass131 = new DbDistributedLockService.\u003C\u003Ec__DisplayClass13_1();
        int num2 = 3;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass131.environmentIdentifier = (string) DbDistributedLockService.eerVA3hr6DqOrmKBk0Fi((object) this.ApplicationEnvironment);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_9;
            case 3:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass131.CS\u0024\u003C\u003E8__locals1 = cDisplayClass130;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 1;
              continue;
            default:
              // ISSUE: reference to a compiler-generated method
              new StatelessSessionHelper(this.SessionFactoryHolder).ExecuteOnSeparateTransaction(new Action<IStatelessSession>(cDisplayClass131.\u003CExtendDbLock\u003Eb__0));
              num2 = 2;
              continue;
          }
        }
label_9:;
      }
      finally
      {
        if (contextSessionOwner != null)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                DbDistributedLockService.WVJor8hr7O1uEdjqePUI((object) contextSessionOwner);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
                continue;
              default:
                goto label_16;
            }
          }
        }
label_16:;
      }
    }

    private void DeleteDbLock(string name, Guid token)
    {
      int num1 = 4;
      string name1;
      DbDistributedLockService distributedLockService;
      Guid token1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            distributedLockService = this;
            num1 = 2;
            continue;
          case 2:
            token1 = token;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
            continue;
          case 3:
            name1 = name;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 1;
            continue;
          case 4:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 3 : 0;
            continue;
          case 5:
            goto label_18;
          default:
            goto label_7;
        }
      }
label_18:
      return;
label_7:
      try
      {
        new StatelessSessionHelper(this.SessionFactoryHolder).ExecuteOnSeparateTransaction((Action<IStatelessSession>) (session =>
        {
          int num2 = 6;
          string message1;
          DbLock dblock;
          string message2;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_13;
              case 2:
                goto label_8;
              case 3:
                // ISSUE: reference to a compiler-generated method
                DbDistributedLockService.\u003C\u003Ec__DisplayClass14_0.qvlB8FvxvoH6T4Xwc3Hw((object) distributedLockService.Logger, (object) message2);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 1 : 2;
                continue;
              case 4:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                message1 = (string) DbDistributedLockService.\u003C\u003Ec__DisplayClass14_0.hb2wSLvxZAPJy4i5qIId(DbDistributedLockService.\u003C\u003Ec__DisplayClass14_0.e7NH52vxCdcMunaorJI1(1597012150 ^ 1597353034), (object) name1, (object) token1);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 7 : 0;
                continue;
              case 5:
                if (dblock != null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 10 : 9;
                  continue;
                }
                goto case 9;
              case 6:
                dblock = session.Get<DbLock>((object) name1);
                num2 = 5;
                continue;
              case 7:
                distributedLockService.Logger.Error((object) message1);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
                continue;
              case 8:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                DbDistributedLockService.\u003C\u003Ec__DisplayClass14_0.T0yEAPvxIiqHXNtLTolA((object) distributedLockService.Logger, DbDistributedLockService.\u003C\u003Ec__DisplayClass14_0.iceLsavxup2DoI4yXq5M(DbDistributedLockService.\u003C\u003Ec__DisplayClass14_0.e7NH52vxCdcMunaorJI1(-1204263869 ^ -1341583247 ^ 137666996), (object) name1));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 1 : 1;
                continue;
              case 9:
                // ISSUE: reference to a compiler-generated method
                message2 = string.Format((string) DbDistributedLockService.\u003C\u003Ec__DisplayClass14_0.e7NH52vxCdcMunaorJI1(-1872275253 >> 6 ^ -29079061), (object) name1);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 3 : 3;
                continue;
              case 10:
                // ISSUE: reference to a compiler-generated method
                if (!(DbDistributedLockService.\u003C\u003Ec__DisplayClass14_0.VIFcwwvx8LZL26JAtjtm((object) dblock) != token1))
                {
                  distributedLockService.DeleteDbLockByQuery(session, dblock);
                  num2 = 8;
                  continue;
                }
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 2 : 4;
                continue;
              default:
                goto label_3;
            }
          }
label_13:
          return;
label_3:
          throw new Exception(message1);
label_8:
          throw new Exception(message2);
        }));
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
          num3 = 0;
        switch (num3)
        {
        }
      }
      catch (Exception ex)
      {
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
          num4 = 1;
        while (true)
        {
          switch (num4)
          {
            case 0:
              goto label_11;
            case 1:
              this.Logger.Error(ex, (string) DbDistributedLockService.GviZlLhr4AXrj6X62o6D(DbDistributedLockService.heC2OkhrH8m29hPNfOJs(-1710575414 ^ -1710675386), (object) name1));
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_11:
        return;
label_2:;
      }
    }

    private void ExecuteOnSeparateTransaction(Action<IStatelessSession> action)
    {
      IStatelessSession statelessSession = (IStatelessSession) null;
      try
      {
        statelessSession = this.SessionFactoryHolder.SessionFactory.OpenStatelessSession();
        statelessSession.BeginTransaction(IsolationLevel.ReadCommitted);
        action(statelessSession);
      }
      catch (Exception ex)
      {
        if (statelessSession != null && statelessSession.Transaction != null && statelessSession.Transaction.IsActive)
        {
          this.Logger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837833083));
          statelessSession.Transaction.Rollback();
        }
        this.Logger.Debug(ex, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218522912));
      }
      finally
      {
        if (statelessSession != null)
        {
          try
          {
            if (statelessSession.Transaction != null)
            {
              if (statelessSession.Transaction.IsActive)
                statelessSession.Transaction.Commit();
            }
          }
          finally
          {
            statelessSession.Close();
            statelessSession.Dispose();
          }
        }
      }
    }

    private bool RepeatUntilTimeout(TimeSpan timeout, TimeSpan repeatInterval, Func<bool> action)
    {
      TimeSpan zero = TimeSpan.Zero;
      bool flag;
      while (!(flag = action()) && zero < timeout)
      {
        Thread.Sleep(repeatInterval);
        zero += repeatInterval;
      }
      return flag;
    }

    private async Task<bool> RepeatUntilTimeoutAsync(
      TimeSpan timeout,
      TimeSpan repeatInterval,
      CancellationToken token,
      Func<bool> action)
    {
      int num1 = 2;
      int num2;
      bool result;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_36;
          case 1:
            try
            {
              int num3;
              if (num2 != 0)
              {
                num3 = 12;
                goto label_8;
              }
              else
                goto label_21;
label_7:
              int num4;
              num3 = num4;
label_8:
              TimeSpan waitedTime;
              TaskAwaiter taskAwaiter;
              TaskAwaiter awaiter;
              bool flag;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    goto label_21;
                  case 2:
                    taskAwaiter = new TaskAwaiter();
                    num3 = 11;
                    continue;
                  case 3:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, DbDistributedLockService.\u003CRepeatUntilTimeoutAsync\u003Ed__17>(ref awaiter, this);
                    num3 = 4;
                    continue;
                  case 4:
                    goto label_29;
                  case 6:
                    // ISSUE: reference to a compiler-generated method
                    if (!DbDistributedLockService.\u003CRepeatUntilTimeoutAsync\u003Ed__17.kjMDHCvxK31gG97grFaF(waitedTime, timeout))
                    {
                      num3 = 7;
                      continue;
                    }
                    goto case 18;
                  case 7:
                  case 16:
                    result = flag;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 14 : 7;
                    continue;
                  case 8:
                    if (!awaiter.IsCompleted)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 9 : 7;
                      continue;
                    }
                    goto case 17;
                  case 9:
                    goto label_23;
                  case 10:
                    taskAwaiter = awaiter;
                    num3 = 3;
                    continue;
                  case 11:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 17 : 17;
                    continue;
                  case 12:
                    waitedTime = TimeSpan.Zero;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
                    continue;
                  case 13:
                    // ISSUE: reference to a compiler-generated method
                    waitedTime = DbDistributedLockService.\u003CRepeatUntilTimeoutAsync\u003Ed__17.dnpXg9vxqZ8JwNGAJwpr(waitedTime, repeatInterval);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 5 : 4;
                    continue;
                  case 14:
                    goto label_4;
                  case 15:
                    // ISSUE: reference to a compiler-generated method
                    awaiter = DbDistributedLockService.\u003CRepeatUntilTimeoutAsync\u003Ed__17.GQKinMvxRrb1UNhB8yQ1((object) Task.Delay(repeatInterval));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 4 : 8;
                    continue;
                  case 17:
                    awaiter.GetResult();
                    num3 = 13;
                    continue;
                  case 18:
                    if (token.IsCancellationRequested)
                    {
                      num3 = 16;
                      continue;
                    }
                    goto case 15;
                  default:
                    if (flag = action())
                      goto case 7;
                    else
                      goto label_25;
                }
              }
label_29:
              return;
label_23:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003E1__state = num2 = 0;
              num4 = 10;
              goto label_7;
label_25:
              num4 = 6;
              goto label_7;
label_21:
              awaiter = taskAwaiter;
              num4 = 2;
              goto label_7;
            }
            catch (Exception ex)
            {
              int num5 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
                num5 = 1;
              while (true)
              {
                switch (num5)
                {
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
                    continue;
                  case 2:
                    goto label_14;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num5 = 2;
                    continue;
                }
              }
label_14:
              return;
            }
          case 2:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 1;
            continue;
          case 3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
            continue;
          case 4:
label_4:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = 3;
            continue;
          default:
            goto label_33;
        }
      }
label_36:
      return;
label_33:;
    }

    private void InsertDbLockByQuery(IStatelessSession session, DbLock dblock)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            DbDistributedLockService.CsiNUjhrx3qRY0QunsZy((object) session, (object) dblock);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private void ExtendDbLockByQuery(
      IStatelessSession session,
      DbLock dbLock,
      DateTime? validUntilDate)
    {
      dbLock.ValidUntilDate = validUntilDate;
      session.Update((object) dbLock);
    }

    private void DeleteDbLockByQuery(IStatelessSession session, DbLock dblock)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            DbDistributedLockService.jBKeUmhr0rt347gUCeaD((object) session, (object) dblock);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
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
    /// Получить время, в течение которого истекшая блокировка будет считаться еще активной.
    /// Используется при удалении блокировки и может компенсировать расхождение времен на нодах.
    /// </summary>
    /// <returns>Время</returns>
    private TimeSpan ValidUntilDateOverTime => DbDistributedLockService.JRj4pyhrmOpttAZEghdI((double) EleWise.ELMA.SR.GetSetting<long>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1323246060), 2L));

    public DbDistributedLockService()
    {
      DbDistributedLockService.nrCtAkhry3qUpT6a99eY();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool cTnZePhrDChU6HDP5ZA2() => DbDistributedLockService.A7klRkhraSB6M8OUqPui == null;

    internal static DbDistributedLockService vqeWWohrtTkjJv3nNiVE() => DbDistributedLockService.A7klRkhraSB6M8OUqPui;

    internal static Guid V1pUpEhrwoYOlZCOwbAw() => Guid.NewGuid();

    internal static object GviZlLhr4AXrj6X62o6D([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object eerVA3hr6DqOrmKBk0Fi([In] object obj0) => (object) ((IApplicationEnvironmentService) obj0).GetEnvironmentId();

    internal static object heC2OkhrH8m29hPNfOJs(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object rRyWJyhrAUViEFUJhtKs() => (object) CallContextSessionOwner.Create();

    internal static void WVJor8hr7O1uEdjqePUI([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object CsiNUjhrx3qRY0QunsZy([In] object obj0, [In] object obj1) => ((IStatelessSession) obj0).Insert(obj1);

    internal static void jBKeUmhr0rt347gUCeaD([In] object obj0, [In] object obj1) => ((IStatelessSession) obj0).Delete(obj1);

    internal static TimeSpan JRj4pyhrmOpttAZEghdI([In] double obj0) => TimeSpan.FromMinutes(obj0);

    internal static void nrCtAkhry3qUpT6a99eY() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
