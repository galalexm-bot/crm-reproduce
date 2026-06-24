// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.NHUnitOfWorkManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Exceptions;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Collection;
using NHibernate.Engine;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime.NH
{
  /// <summary>Фабрика единицы работы с БД (асинхронная часть)</summary>
  /// <summary>Фабрика единицы работы с БД</summary>
  internal class NHUnitOfWorkManager : 
    IUnitOfWorkManagerAsync,
    IUnitOfWorkManager,
    IUnitOfWorkManagerRollback
  {
    private readonly ISessionProvider sessionProvider;
    private readonly ITransformationProvider transformProvider;
    private readonly NestedScopeComponents<IUnitOfWorkEventListener> listeners;
    internal static NHUnitOfWorkManager mrVxG3W1GMgp29mlTopo;

    /// <summary>
    /// Создать асинхронный <see cref="T:EleWise.ELMA.Runtime.NH.IUnitOfWorkAsync" />
    /// </summary>
    /// <param name="dbName">Название БД</param>
    /// <param name="transactional"><c>true</c> если требуется поддержка транзакции</param>
    /// <param name="isolationLevel">Уровень изоляции</param>
    /// <returns>Единица работы</returns>
    public IUnitOfWorkAsync CreateAsync(
      string dbName,
      bool transactional,
      IsolationLevel isolationLevel = IsolationLevel.Unspecified)
    {
      return (IUnitOfWorkAsync) new NHUnitOfWorkManager.UnitOfWork(dbName, transactional, this.sessionProvider, this.transformProvider, this.listeners.Value, isolationLevel);
    }

    /// <inheritdoc />
    public void RegisterAsyncPreCommitAction(System.Func<CancellationToken, Task> action)
    {
      if (action == null)
        return;
      NHUnitOfWorkManager.PreCommitAsyncActions.LockEnqueue<System.Func<CancellationToken, Task>>(action);
    }

    /// <inheritdoc />
    public void RegisterAsyncPostCommitAction(System.Func<CancellationToken, Task> action)
    {
      if (action == null)
        return;
      NHUnitOfWorkManager.PostCommitAsyncActions.Add(action);
    }

    /// <inheritdoc />
    public void RegisterAsyncRollbackAction(System.Func<CancellationToken, Task> action)
    {
      if (action == null)
        return;
      NHUnitOfWorkManager.RollbackAsyncActions.Add(action);
    }

    /// <inheritdoc />
    public Task ThrowExceptionOnCommitAsync(
      Exception exception,
      CancellationToken cancellationToken = default (CancellationToken))
    {
      int num = 6;
      // ISSUE: variable of a compiler-generated type
      NHUnitOfWorkManager.\u003CThrowExceptionOnCommitAsync\u003Ed__5 stateMachine;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 7 : 7;
            continue;
          case 2:
            goto label_6;
          case 3:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = AsyncTaskMethodBuilder.Create();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 1;
            continue;
          case 4:
            tBuilder.Start<NHUnitOfWorkManager.\u003CThrowExceptionOnCommitAsync\u003Ed__5>(ref stateMachine);
            num = 2;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            stateMachine.exception = exception;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = 5;
            continue;
          case 7:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = 4;
            continue;
          default:
            // ISSUE: reference to a compiler-generated field
            stateMachine.cancellationToken = cancellationToken;
            num = 3;
            continue;
        }
      }
label_6:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    private static Queue<System.Func<CancellationToken, Task>> PreCommitAsyncActions => NHUnitOfWorkManager.PreCommitActionsHolder.GetFromContext().AsyncActions;

    private static List<System.Func<CancellationToken, Task>> PostCommitAsyncActions => NHUnitOfWorkManager.PostCommitActionsHolder.GetFromContext().AsyncActions;

    private static List<System.Func<CancellationToken, Task>> RollbackAsyncActions => NHUnitOfWorkManager.UnitOfWorkContextRollbackHolder.GetFromContext().AsyncActions;

    /// <summary>Ctor</summary>
    /// <param name="sessionProvider">Провайдер сессий NHibernate</param>
    /// <param name="transformProvider">Провайдер преобразования БД</param>
    public NHUnitOfWorkManager(
      ISessionProvider sessionProvider,
      ITransformationProvider transformProvider)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.listeners = new NestedScopeComponents<IUnitOfWorkEventListener>(ServiceScope.Shell);
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.transformProvider = transformProvider;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 0;
            continue;
          default:
            this.sessionProvider = sessionProvider;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 2 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>
    /// Создать синхронный <see cref="T:EleWise.ELMA.Runtime.NH.IUnitOfWork" />
    /// </summary>
    /// <param name="dbName">Название БД</param>
    /// <param name="transactional"><c>true</c> если требуется поддержка транзакции</param>
    /// <param name="isolationLevel">Уровень изоляции</param>
    /// <returns>Единица работы</returns>
    public IUnitOfWork Create(string dbName, bool transactional, IsolationLevel isolationLevel = IsolationLevel.Unspecified) => (IUnitOfWork) new NHUnitOfWorkManager.UnitOfWork(dbName, transactional, this.sessionProvider, this.transformProvider, this.listeners.Value, isolationLevel);

    /// <summary>Проверить есть ли активные транзакции</summary>
    /// <param name="dbName">Название БД</param>
    /// <returns><c>true</c> если есть активные транзакции</returns>
    public bool HasActiveTransaction(string dbName) => NHUnitOfWorkManager.UnitOfWork.HasTransaction((object) dbName, this.sessionProvider);

    /// <summary>
    /// Пометить текущую единицу работы для отката.
    /// В этом случае при подтверждении самой первой единицы работы произойдет ее фактический откат, т.е. данные не будут сохранены
    /// </summary>
    /// <param name="dbName">Имя БД</param>
    public void RollbackCurrent(string dbName)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            NHUnitOfWorkManager.yk6pqcW1CUrIYnxEqwLP(NHUnitOfWorkManager.f2LBdxW1QdwGhK5yD4eF(), (object) dbName, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <inheritdoc />
    public void RegisterPreCommitAction(System.Action action)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_5;
          case 1:
            NHUnitOfWorkManager.PreCommitActions.LockEnqueue<System.Action>(action);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            if (action == null)
            {
              num = 2;
              continue;
            }
            goto case 1;
          default:
            goto label_7;
        }
      }
label_5:
      return;
label_2:
      return;
label_7:;
    }

    /// <inheritdoc />
    public void RegisterPostCommitAction(System.Action action)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (action != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            goto label_2;
          default:
            NHUnitOfWorkManager.PostCommitActions.Add(action);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 2 : 2;
            continue;
        }
      }
label_2:
      return;
label_6:;
    }

    /// <inheritdoc />
    public void RegisterRollbackAction(System.Action action)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (action != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            goto label_2;
          default:
            NHUnitOfWorkManager.RollbackActions.Add(action);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 2 : 1;
            continue;
        }
      }
label_2:
      return;
label_6:;
    }

    /// <inheritdoc />
    public void RevertEntityChangesOnCommit(string dbName, object entity)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_4;
          case 1:
            object name = NHUnitOfWorkManager.jN2KtHW1vaSy6PhGqXyM((object) dbName);
            // ISSUE: reference to a compiler-generated field
            Func<List<object>> func = NHUnitOfWorkManager.\u003C\u003Ec.\u003C\u003E9__22_0;
            Func<List<object>> val;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              NHUnitOfWorkManager.\u003C\u003Ec.\u003C\u003E9__22_0 = val = (Func<List<object>>) (() => new List<object>());
            }
            else
              goto label_7;
label_6:
            List<object> orAdd = ContextVars.GetOrAdd<List<object>>((string) name, val);
            orAdd.Add(entity);
            ContextVars.Set<List<object>>((string) name, orAdd);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
            continue;
label_7:
            val = func;
            goto label_6;
          default:
            goto label_2;
        }
      }
label_4:
      return;
label_2:;
    }

    /// <inheritdoc />
    public void ThrowExceptionOnCommit(Exception exception)
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        ISession session;
        while (true)
        {
          object obj;
          switch (num2)
          {
            case 1:
              goto label_23;
            case 2:
              obj = (object) null;
              break;
            case 3:
label_5:
              if (!NHUnitOfWorkManager.V7Q3y2W1u6sAR4vbe06k(NHUnitOfWorkManager.csRTLfW1ZV8Nl0aHleH8((object) session)))
                goto default;
              else
                goto label_6;
            case 4:
              goto label_24;
            case 6:
              goto label_8;
            case 7:
              if (session == null)
              {
                num2 = 2;
                continue;
              }
              obj = NHUnitOfWorkManager.csRTLfW1ZV8Nl0aHleH8((object) session);
              break;
            case 8:
              session = (ISession) NHUnitOfWorkManager.PiutqdW181hTStx8cWhp((object) this.sessionProvider, (object) "");
              num2 = 7;
              continue;
            case 9:
              try
              {
                ((DbConnection) NHUnitOfWorkManager.QJgZ6WW1Ryoxet53ASv3((object) session)).Close();
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
                  num3 = 0;
                switch (num3)
                {
                  default:
                    goto label_25;
                }
              }
              catch (Exception ex)
              {
                int num4 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0)
                  num4 = 1;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      NHUnitOfWorkManager.WXhB9cW1iNyWT9AsST8H(NHUnitOfWorkManager.gZHi36W1VlOQyH23eXpY(), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978605756), (object) ex);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_25;
                  }
                }
              }
            default:
label_25:
              ContextVars.Set<Exception>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583610596), exception);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 4 : 1;
              continue;
          }
          if (obj == null)
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
          else
            goto label_5;
        }
label_6:
        num1 = 6;
        continue;
label_8:
        try
        {
          NHUnitOfWorkManager.gwMBfoW1IdaKSA7M35rn(NHUnitOfWorkManager.csRTLfW1ZV8Nl0aHleH8((object) session));
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
            num5 = 0;
          switch (num5)
          {
          }
        }
        catch (Exception ex)
        {
          int num6 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
            num6 = 0;
          while (true)
          {
            switch (num6)
            {
              case 1:
                goto label_23;
              default:
                NHUnitOfWorkManager.WXhB9cW1iNyWT9AsST8H(NHUnitOfWorkManager.gZHi36W1VlOQyH23eXpY(), NHUnitOfWorkManager.HULNmsW1S3yjvtweGIBa(-488881205 ^ -488751025), (object) ex);
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 1;
                continue;
            }
          }
        }
label_23:
        num1 = 9;
      }
label_24:;
    }

    private static NHUnitOfWorkManager.UnitOfWorkContextRollbackHolder RollbackHolder => (NHUnitOfWorkManager.UnitOfWorkContextRollbackHolder) NHUnitOfWorkManager.hwMyufW1qlrGP9ptvB6H();

    private static Queue<System.Action> PreCommitActions => NHUnitOfWorkManager.PreCommitActionsHolder.GetFromContext().Actions;

    private static List<System.Action> PostCommitActions => NHUnitOfWorkManager.PostCommitActionsHolder.GetFromContext().Actions;

    private static List<System.Action> RollbackActions => NHUnitOfWorkManager.UnitOfWorkContextRollbackHolder.GetFromContext().Actions;

    private static string GetRevertEntityChangesKey(object dbName) => (string) NHUnitOfWorkManager.Wj6LCLW1KNVCjS17j3v2(NHUnitOfWorkManager.HULNmsW1S3yjvtweGIBa(-441065788 ^ -2092910478 ^ 1727493830), dbName);

    public static List<object> GetRevertEntities(string dbName)
    {
      List<object> revertEntities = ContextVars.GetOrAdd<List<object>>(NHUnitOfWorkManager.GetRevertEntityChangesKey((object) dbName), (Func<List<object>>) (() => new List<object>()));
      if (revertEntities.Count == 0)
        return revertEntities;
      System.Action action1 = (System.Action) (() =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_6;
            case 1:
              List<object> first = revertEntities;
              List<object> source1 = revertEntities;
              // ISSUE: reference to a compiler-generated field
              System.Func<object, IEnumerable<object>> func1 = NHUnitOfWorkManager.\u003C\u003Ec.\u003C\u003E9__38_3;
              System.Func<object, IEnumerable<object>> selector;
              if (func1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                NHUnitOfWorkManager.\u003C\u003Ec.\u003C\u003E9__38_3 = selector = (System.Func<object, IEnumerable<object>>) (e => !(e is ICompositeEntity) ? (IEnumerable<object>) new object[0] : ((ICompositeEntity) e).GetCompositeEntities().Cast<object>());
              }
              else
                goto label_10;
label_5:
              IEnumerable<object> source2 = source1.SelectMany<object, object>(selector);
              // ISSUE: reference to a compiler-generated field
              System.Func<object, bool> func2 = NHUnitOfWorkManager.\u003C\u003Ec.\u003C\u003E9__38_4;
              System.Func<object, bool> predicate;
              if (func2 == null)
              {
                // ISSUE: reference to a compiler-generated field
                NHUnitOfWorkManager.\u003C\u003Ec.\u003C\u003E9__38_4 = predicate = (System.Func<object, bool>) (e => e != null);
              }
              else
                goto label_9;
label_8:
              // ISSUE: reference to a compiler-generated method
              IEnumerable<object> second = source2.Where<object>(predicate).Select<object, object>((System.Func<object, object>) (e => NHUnitOfWorkManager.\u003C\u003Ec.Bh0D1gQ0WuJLmRIQ2FBp(e)));
              revertEntities = first.Union<object>(second).ToList<object>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 0;
              continue;
label_9:
              predicate = func2;
              goto label_8;
label_10:
              selector = func1;
              goto label_5;
            default:
              goto label_3;
          }
        }
label_6:
        return;
label_3:;
      });
      System.Action action2 = (System.Action) (() =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_9;
            case 1:
              List<object> first = revertEntities;
              IEnumerable<IEntity> source3 = revertEntities.OfType<IEntity>();
              // ISSUE: reference to a compiler-generated field
              System.Func<IEntity, IEnumerable<IEntity>> func3 = NHUnitOfWorkManager.\u003C\u003Ec.\u003C\u003E9__38_6;
              System.Func<IEntity, IEnumerable<IEntity>> selector1;
              if (func3 == null)
              {
                // ISSUE: reference to a compiler-generated field
                NHUnitOfWorkManager.\u003C\u003Ec.\u003C\u003E9__38_6 = selector1 = (System.Func<IEntity, IEnumerable<IEntity>>) (e => e.GetContainedEntities());
              }
              else
                goto label_13;
label_5:
              IEnumerable<IEntity> source4 = source3.SelectMany<IEntity, IEntity>(selector1);
              // ISSUE: reference to a compiler-generated field
              System.Func<IEntity, bool> func4 = NHUnitOfWorkManager.\u003C\u003Ec.\u003C\u003E9__38_7;
              System.Func<IEntity, bool> predicate;
              if (func4 == null)
              {
                // ISSUE: reference to a compiler-generated field
                NHUnitOfWorkManager.\u003C\u003Ec.\u003C\u003E9__38_7 = predicate = (System.Func<IEntity, bool>) (e => e != null);
              }
              else
                goto label_12;
label_8:
              IEnumerable<IEntity> source5 = source4.Where<IEntity>(predicate);
              // ISSUE: reference to a compiler-generated field
              System.Func<IEntity, IEntity> func5 = NHUnitOfWorkManager.\u003C\u003Ec.\u003C\u003E9__38_8;
              System.Func<IEntity, IEntity> selector2;
              if (func5 == null)
              {
                // ISSUE: reference to a compiler-generated field
                NHUnitOfWorkManager.\u003C\u003Ec.\u003C\u003E9__38_8 = selector2 = (System.Func<IEntity, IEntity>) (e => e.CastAsRealType<IEntity>());
              }
              else
                goto label_2;
label_11:
              IEnumerable<IEntity> second = source5.Select<IEntity, IEntity>(selector2);
              revertEntities = first.Union<object>((IEnumerable<object>) second).ToList<object>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
              continue;
label_2:
              selector2 = func5;
              goto label_11;
label_12:
              predicate = func4;
              goto label_8;
label_13:
              selector1 = func3;
              goto label_5;
            default:
              goto label_6;
          }
        }
label_9:
        return;
label_6:;
      });
      action1();
      action2();
      action1();
      return revertEntities;
    }

    internal static bool PuURP4W1Ea7GuZllFI74() => NHUnitOfWorkManager.mrVxG3W1GMgp29mlTopo == null;

    internal static NHUnitOfWorkManager UFCibBW1fHYuvwcboruH() => NHUnitOfWorkManager.mrVxG3W1GMgp29mlTopo;

    internal static object f2LBdxW1QdwGhK5yD4eF() => (object) NHUnitOfWorkManager.RollbackHolder;

    internal static void yk6pqcW1CUrIYnxEqwLP([In] object obj0, [In] object obj1, bool flag) => ((NHUnitOfWorkManager.UnitOfWorkContextRollbackHolder) obj0).SetRollBackFlag((string) obj1, flag);

    internal static object jN2KtHW1vaSy6PhGqXyM([In] object obj0) => (object) NHUnitOfWorkManager.GetRevertEntityChangesKey(obj0);

    internal static object PiutqdW181hTStx8cWhp([In] object obj0, [In] object obj1) => (object) ((ISessionProvider) obj0).GetSession((string) obj1);

    internal static object csRTLfW1ZV8Nl0aHleH8([In] object obj0) => (object) ((ISession) obj0).Transaction;

    internal static bool V7Q3y2W1u6sAR4vbe06k([In] object obj0) => ((ITransaction) obj0).IsActive;

    internal static void gwMBfoW1IdaKSA7M35rn([In] object obj0) => ((ITransaction) obj0).Rollback();

    internal static object gZHi36W1VlOQyH23eXpY() => (object) Logger.Log;

    internal static object HULNmsW1S3yjvtweGIBa(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void WXhB9cW1iNyWT9AsST8H([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Debug(obj1, (Exception) obj2);

    internal static object QJgZ6WW1Ryoxet53ASv3([In] object obj0) => (object) ((ISession) obj0).Connection;

    internal static object hwMyufW1qlrGP9ptvB6H() => (object) NHUnitOfWorkManager.UnitOfWorkContextRollbackHolder.GetFromContext();

    internal static object Wj6LCLW1KNVCjS17j3v2([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    private class UnitOfWork : EleWise.ELMA.Runtime.NH.UnitOfWork
    {
      private readonly object sessionProvider;
      private readonly object transformProvider;
      private readonly IEnumerable<IUnitOfWorkEventListener> listeners;
      private readonly bool nested;
      private readonly object dbName;
      private readonly Guid uid;
      private static object uHKsZsQ7gewG0ZdCGbs4;

      /// <inheritdoc />
      public override Task<bool> IsDirtyAsync => this.Session.IsDirtyAsync(CancellationToken.None);

      /// <inheritdoc />
      public override Task CommitAsync(CancellationToken cancellationToken = default (CancellationToken))
      {
        int num = 6;
        // ISSUE: variable of a compiler-generated type
        NHUnitOfWorkManager.UnitOfWork.\u003CCommitAsync\u003Ed__2 stateMachine;
        AsyncTaskMethodBuilder tBuilder;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: reference to a compiler-generated field
              tBuilder = stateMachine.\u003C\u003Et__builder;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 2;
              continue;
            case 2:
              tBuilder.Start<NHUnitOfWorkManager.UnitOfWork.\u003CCommitAsync\u003Ed__2>(ref stateMachine);
              num = 3;
              continue;
            case 3:
              goto label_4;
            case 4:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E1__state = -1;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 1 : 1;
              continue;
            case 5:
              // ISSUE: reference to a compiler-generated field
              stateMachine.cancellationToken = cancellationToken;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
              continue;
            case 6:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E4__this = this;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 5 : 3;
              continue;
            default:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003Et__builder = NHUnitOfWorkManager.UnitOfWork.zr4d5FQ7YoiywvCnUZtw();
              num = 4;
              continue;
          }
        }
label_4:
        // ISSUE: reference to a compiler-generated field
        return stateMachine.\u003C\u003Et__builder.Task;
      }

      /// <inheritdoc />
      public override Task RollbackAsync(CancellationToken cancellationToken = default (CancellationToken))
      {
        int num = 4;
        // ISSUE: variable of a compiler-generated type
        NHUnitOfWorkManager.UnitOfWork.\u003CRollbackAsync\u003Ed__3 stateMachine;
        AsyncTaskMethodBuilder tBuilder;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E1__state = -1;
              num = 6;
              continue;
            case 2:
              tBuilder.Start<NHUnitOfWorkManager.UnitOfWork.\u003CRollbackAsync\u003Ed__3>(ref stateMachine);
              num = 5;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated field
              stateMachine.cancellationToken = cancellationToken;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
              continue;
            case 4:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E4__this = this;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 2 : 3;
              continue;
            case 5:
              goto label_6;
            case 6:
              // ISSUE: reference to a compiler-generated field
              tBuilder = stateMachine.\u003C\u003Et__builder;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 2 : 2;
              continue;
            default:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003Et__builder = NHUnitOfWorkManager.UnitOfWork.zr4d5FQ7YoiywvCnUZtw();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 0;
              continue;
          }
        }
label_6:
        // ISSUE: reference to a compiler-generated field
        return stateMachine.\u003C\u003Et__builder.Task;
      }

      /// <summary>Выполнить асинхронные действия по откату транзакции</summary>
      /// <param name="cancellationToken">Токен отмены</param>
      private Task ExecuteRollbackActionsAsync(CancellationToken cancellationToken)
      {
        int num = 5;
        // ISSUE: variable of a compiler-generated type
        NHUnitOfWorkManager.UnitOfWork.\u003CExecuteRollbackActionsAsync\u003Ed__4 stateMachine;
        AsyncTaskMethodBuilder tBuilder;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_4;
            case 2:
              tBuilder.Start<NHUnitOfWorkManager.UnitOfWork.\u003CExecuteRollbackActionsAsync\u003Ed__4>(ref stateMachine);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 1;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated field
              tBuilder = stateMachine.\u003C\u003Et__builder;
              num = 2;
              continue;
            case 4:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003Et__builder = AsyncTaskMethodBuilder.Create();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
              continue;
            case 5:
              // ISSUE: reference to a compiler-generated field
              stateMachine.cancellationToken = cancellationToken;
              num = 4;
              continue;
            default:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E1__state = -1;
              num = 3;
              continue;
          }
        }
label_4:
        // ISSUE: reference to a compiler-generated field
        return stateMachine.\u003C\u003Et__builder.Task;
      }

      /// <summary>Безопасно выполнить действие асинхронно</summary>
      /// <param name="action">Действие</param>
      /// <param name="errorMessage">Сообщение об ошибке</param>
      /// <param name="logger">Логгер</param>
      /// <param name="cancellationToken">Токен отмены</param>
      private async Task SafeExecuteActionAsync(
        System.Func<CancellationToken, Task> action,
        string errorMessage,
        ILogger logger,
        CancellationToken cancellationToken)
      {
        int num1 = 3;
        while (true)
        {
          int num2 = num1;
          int num3;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_41;
              case 2:
                try
                {
                  int num4 = 2;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        goto label_5;
                      case 2:
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 1;
                        continue;
                      default:
                        goto label_43;
                    }
                  }
label_5:
                  try
                  {
                    int num5;
                    if (num3 != 0)
                      num5 = 2;
                    else
                      goto label_17;
label_7:
                    TaskAwaiter taskAwaiter;
                    TaskAwaiter awaiter;
                    while (true)
                    {
                      switch (num5)
                      {
                        case 0:
                          goto label_38;
                        case 1:
                          if (!awaiter.IsCompleted)
                          {
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 2 : 8;
                            continue;
                          }
                          goto case 5;
                        case 2:
                          // ISSUE: reference to a compiler-generated method
                          awaiter = NHUnitOfWorkManager.UnitOfWork.\u003CSafeExecuteActionAsync\u003Ed__5.LUibO6ZZ79TuJXu3x08Z((object) action(cancellationToken));
                          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 1 : 1;
                          continue;
                        case 3:
                          goto label_43;
                        case 4:
                          taskAwaiter = new TaskAwaiter();
                          num5 = 9;
                          continue;
                        case 5:
                          awaiter.GetResult();
                          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 1 : 3;
                          continue;
                        case 6:
                          // ISSUE: explicit reference operation
                          // ISSUE: reference to a compiler-generated field
                          (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, NHUnitOfWorkManager.UnitOfWork.\u003CSafeExecuteActionAsync\u003Ed__5>(ref awaiter, this);
                          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
                          continue;
                        case 7:
                          goto label_17;
                        case 8:
                          // ISSUE: explicit reference operation
                          // ISSUE: reference to a compiler-generated field
                          (^this).\u003C\u003E1__state = num3 = 0;
                          num5 = 10;
                          continue;
                        case 9:
                          // ISSUE: explicit reference operation
                          // ISSUE: reference to a compiler-generated field
                          (^this).\u003C\u003E1__state = num3 = -1;
                          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 5 : 4;
                          continue;
                        case 10:
                          taskAwaiter = awaiter;
                          num5 = 6;
                          continue;
                        default:
                          goto label_34;
                      }
                    }
label_38:
                    return;
label_34:
                    return;
label_17:
                    awaiter = taskAwaiter;
                    num5 = 4;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
                    {
                      num5 = 2;
                      goto label_7;
                    }
                    else
                      goto label_7;
                  }
                  catch (TransactionRollbackException ex)
                  {
                    int num6 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
                      num6 = 0;
                    switch (num6)
                    {
                      default:
                        throw;
                    }
                  }
                  catch (Exception ex)
                  {
                    int num7 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
                      num7 = 3;
                    Exception innerException;
                    while (true)
                    {
                      switch (num7)
                      {
                        case 1:
                          goto label_31;
                        case 2:
                          ContextVars.TryGetValue<Exception>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710702814), out innerException);
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
                          continue;
                        case 3:
                          // ISSUE: reference to a compiler-generated method
                          NHUnitOfWorkManager.UnitOfWork.\u003CSafeExecuteActionAsync\u003Ed__5.sOI0wQZZxxxdP1MJd0RS((object) logger, (object) errorMessage, (object) ex);
                          num7 = 2;
                          continue;
                        case 4:
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          NHUnitOfWorkManager.UnitOfWork.\u003CSafeExecuteActionAsync\u003Ed__5.F2J5FNZZmsRKVmlhEm5P(NHUnitOfWorkManager.UnitOfWork.\u003CSafeExecuteActionAsync\u003Ed__5.vCC6IAZZ0skMo9Cw6HUq(-1598106783 - -968262081 ^ -629712182));
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 1 : 1;
                          continue;
                        default:
                          if (innerException != null)
                          {
                            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 4 : 4;
                            continue;
                          }
                          goto label_43;
                      }
                    }
label_31:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    throw new InvalidOperationException((string) NHUnitOfWorkManager.UnitOfWork.\u003CSafeExecuteActionAsync\u003Ed__5.ngndvLZZyo3Y16AR4Gd3(NHUnitOfWorkManager.UnitOfWork.\u003CSafeExecuteActionAsync\u003Ed__5.vCC6IAZZ0skMo9Cw6HUq(1597012150 ^ 1597370384)), innerException);
                  }
                }
                catch (Exception ex)
                {
                  int num8 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
                    num8 = 0;
                  while (true)
                  {
                    switch (num8)
                    {
                      case 1:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003Et__builder.SetException(ex);
                        num8 = 2;
                        continue;
                      case 2:
                        goto label_32;
                      default:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003E1__state = -2;
                        num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 0;
                        continue;
                    }
                  }
label_32:
                  return;
                }
              case 3:
                goto label_42;
              case 4:
                // ISSUE: explicit reference operation
                // ISSUE: reference to a compiler-generated field
                (^this).\u003C\u003Et__builder.SetResult();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 1;
                continue;
            }
label_43:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num2 = 4;
          }
label_42:
          // ISSUE: explicit reference operation
          // ISSUE: reference to a compiler-generated field
          num3 = (^this).\u003C\u003E1__state;
          num1 = 2;
        }
label_41:;
      }

      /// <summary>
      /// Безопасно выполнить указанное действие над <see cref="T:EleWise.ELMA.Runtime.NH.IUnitOfWorkEventListener" /> асинхронно
      /// </summary>
      /// <param name="action">Действие</param>
      /// <param name="errorMessage">Сообщение об ошибке</param>
      /// <param name="logger">Логгер</param>
      /// <param name="cancellationToken">Токен отмены</param>
      private async Task SafeExecuteListenersAsync(
        Func<IUnitOfWorkEventListener, CancellationToken, Task> action,
        string errorMessage,
        ILogger logger,
        CancellationToken cancellationToken)
      {
        int num1 = 2;
        while (true)
        {
          int num2;
          switch (num1)
          {
            case 1:
              num1 = 5;
              continue;
            case 2:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              num2 = (^this).\u003C\u003E1__state;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_47;
            case 4:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003Et__builder.SetResult();
              num1 = 3;
              continue;
            case 5:
              try
              {
                int num3;
                if (num2 == 0)
                  num3 = 2;
                else
                  goto label_37;
label_4:
                // ISSUE: variable of a compiler-generated type
                NHUnitOfWorkManager.UnitOfWork.\u003C\u003Ec__DisplayClass6_0 cDisplayClass60;
                IEnumerator<IUnitOfWorkEventListener> enumerator;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated field
                      cDisplayClass60.action = action;
                      num3 = 7;
                      continue;
                    case 2:
                    case 6:
                      num3 = 5;
                      continue;
                    case 3:
label_35:
                      enumerator = (IEnumerator<IUnitOfWorkEventListener>) null;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
                      continue;
                    case 4:
                      goto label_37;
                    case 5:
                      try
                      {
                        int num4;
                        if (num2 != 0)
                        {
                          num4 = 12;
                          goto label_10;
                        }
                        else
                          goto label_23;
label_9:
                        int num5;
                        num4 = num5;
label_10:
                        TaskAwaiter taskAwaiter;
                        TaskAwaiter awaiter;
                        IUnitOfWorkEventListener current;
                        // ISSUE: variable of a compiler-generated type
                        NHUnitOfWorkManager.UnitOfWork.\u003C\u003Ec__DisplayClass6_1 cDisplayClass61;
                        while (true)
                        {
                          switch (num4)
                          {
                            case 1:
                              cancellationToken.ThrowIfCancellationRequested();
                              num4 = 3;
                              continue;
                            case 2:
                              goto label_19;
                            case 3:
                              // ISSUE: reference to a compiler-generated field
                              cDisplayClass61.currentListener = current;
                              num4 = 16;
                              continue;
                            case 4:
                              goto label_16;
                            case 5:
                              goto label_44;
                            case 6:
                              taskAwaiter = awaiter;
                              num4 = 8;
                              continue;
                            case 7:
                              goto label_27;
                            case 8:
                              // ISSUE: explicit reference operation
                              // ISSUE: reference to a compiler-generated field
                              (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, NHUnitOfWorkManager.UnitOfWork.\u003CSafeExecuteListenersAsync\u003Ed__6>(ref awaiter, this);
                              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 5 : 2;
                              continue;
                            case 9:
                              current = enumerator.Current;
                              num4 = 15;
                              continue;
                            case 10:
                              if (!awaiter.IsCompleted)
                              {
                                num4 = 7;
                                continue;
                              }
                              goto label_19;
                            case 11:
                              // ISSUE: reference to a compiler-generated field
                              cDisplayClass61.CS\u0024\u003C\u003E8__locals1 = cDisplayClass60;
                              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 1 : 0;
                              continue;
                            case 12:
                            case 17:
                              // ISSUE: reference to a compiler-generated method
                              if (!NHUnitOfWorkManager.UnitOfWork.\u003CSafeExecuteListenersAsync\u003Ed__6.lblVGrZZsVrmqpaBknio((object) enumerator))
                              {
                                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
                                continue;
                              }
                              goto case 9;
                            case 13:
                              taskAwaiter = new TaskAwaiter();
                              num4 = 4;
                              continue;
                            case 14:
                              goto label_23;
                            case 15:
                              // ISSUE: object of a compiler-generated type is created
                              cDisplayClass61 = new NHUnitOfWorkManager.UnitOfWork.\u003C\u003Ec__DisplayClass6_1();
                              num4 = 11;
                              continue;
                            case 16:
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              awaiter = NHUnitOfWorkManager.UnitOfWork.\u003CSafeExecuteListenersAsync\u003Ed__6.PfoimgZZUeAQEGtuEjMC((object) this.SafeExecuteActionAsync(new System.Func<CancellationToken, Task>(cDisplayClass61.\u003CSafeExecuteListenersAsync\u003Eb__0), errorMessage, logger, cancellationToken));
                              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 10;
                              continue;
                            default:
                              goto label_35;
                          }
                        }
label_44:
                        return;
label_16:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003E1__state = num2 = -1;
                        num5 = 2;
                        goto label_9;
label_19:
                        awaiter.GetResult();
                        num5 = 17;
                        goto label_9;
label_27:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003E1__state = num2 = 0;
                        num5 = 6;
                        goto label_9;
label_23:
                        awaiter = taskAwaiter;
                        num5 = 13;
                        goto label_9;
                      }
                      finally
                      {
                        int num6;
                        if (num2 >= 0)
                          num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
                        else
                          goto label_32;
label_30:
                        switch (num6)
                        {
                          case 1:
                            break;
                          case 4:
                            goto label_32;
                          default:
                        }
label_31:
                        // ISSUE: reference to a compiler-generated method
                        NHUnitOfWorkManager.UnitOfWork.\u003CSafeExecuteListenersAsync\u003Ed__6.WdBhEBZZcIL9FWCYUyG3((object) enumerator);
                        num6 = 3;
                        goto label_30;
label_32:
                        if (enumerator == null)
                        {
                          num6 = 2;
                          goto label_30;
                        }
                        else
                          goto label_31;
                      }
                    case 7:
                      enumerator = this.listeners.GetEnumerator();
                      num3 = 6;
                      continue;
                    default:
                      goto label_48;
                  }
                }
label_37:
                // ISSUE: object of a compiler-generated type is created
                cDisplayClass60 = new NHUnitOfWorkManager.UnitOfWork.\u003C\u003Ec__DisplayClass6_0();
                num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
                {
                  num3 = 1;
                  goto label_4;
                }
                else
                  goto label_4;
              }
              catch (Exception ex)
              {
                int num7 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0)
                  num7 = 1;
                while (true)
                {
                  switch (num7)
                  {
                    case 0:
                      goto label_40;
                    case 1:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = -2;
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 2;
                      continue;
                    case 2:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.SetException(ex);
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_36;
                  }
                }
label_40:
                return;
label_36:
                return;
              }
          }
label_48:
          // ISSUE: explicit reference operation
          // ISSUE: reference to a compiler-generated field
          (^this).\u003C\u003E1__state = -2;
          num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 4 : 1;
        }
label_47:;
      }

      /// <summary>Единица работы</summary>
      /// <param name="dbName">Название БД</param>
      /// <param name="transactional">Транзакционность</param>
      /// <param name="sessionProvider">Провайдер сессии</param>
      /// <param name="transformProvider">Провайден преобразования</param>
      /// <param name="listeners">Слушатели</param>
      /// <param name="isolationLevel">Уровень изоляции</param>
      public UnitOfWork(
        string dbName,
        bool transactional,
        ISessionProvider sessionProvider,
        ITransformationProvider transformProvider,
        IEnumerable<IUnitOfWorkEventListener> listeners,
        IsolationLevel isolationLevel = IsolationLevel.Unspecified)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        Contract.ArgumentNotNull((object) sessionProvider, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099492539));
        Contract.ArgumentNotNull((object) transformProvider, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1642695902));
        Contract.ArgumentNotNull((object) listeners, z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289485082));
        if (!transactional)
          throw new NotImplementedException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -104904896));
        this.dbName = (object) dbName;
        this.sessionProvider = (object) sessionProvider;
        this.transformProvider = (object) transformProvider;
        this.listeners = listeners;
        this.uid = Guid.NewGuid();
        this.nested = NHUnitOfWorkManager.UnitOfWork.HasTransaction((object) dbName, sessionProvider);
        if (this.nested)
          return;
        ISession session = sessionProvider.GetSession(dbName);
        if (isolationLevel != IsolationLevel.Unspecified && transformProvider.Dialect.IsIsolationLevelSupported(isolationLevel))
          session.BeginTransaction(isolationLevel);
        else
          session.BeginTransaction();
        foreach (IUnitOfWorkEventListener listener in this.listeners)
          listener.OnStartUnitofWork((IUnitOfWork) this);
        NHUnitOfWorkManager.RollbackHolder.SetRollBackFlag(dbName, false);
        NHUnitOfWorkManager.PreCommitActions.LockClear<System.Action>();
        NHUnitOfWorkManager.PreCommitAsyncActions.LockClear<System.Func<CancellationToken, Task>>();
        NHUnitOfWorkManager.PostCommitActions.Clear();
        NHUnitOfWorkManager.PostCommitAsyncActions.Clear();
        NHUnitOfWorkManager.RollbackActions.Clear();
        NHUnitOfWorkManager.RollbackAsyncActions.Clear();
      }

      public static bool HasTransaction(object dbName, [NotNull] ISessionProvider sessionProvider)
      {
        int num = 2;
        ISession session;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (NHUnitOfWorkManager.UnitOfWork.NArOBLQ7U2VhHHfu4cwm((object) session) == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            case 2:
              session = (ISession) NHUnitOfWorkManager.UnitOfWork.S3hVyeQ7LJ0xbbpYTDdH((object) sessionProvider, dbName);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 1 : 0;
              continue;
            case 3:
              goto label_3;
            default:
              goto label_4;
          }
        }
label_3:
        return NHUnitOfWorkManager.UnitOfWork.e3ypf1Q7s6vf4fCC4GRG(NHUnitOfWorkManager.UnitOfWork.NArOBLQ7U2VhHHfu4cwm((object) session));
label_4:
        return false;
      }

      /// <inheritdoc />
      public override void Dispose()
      {
        int num1 = 1;
        IEnumerator<IUnitOfWorkEventListener> enumerator;
        while (true)
        {
          switch (num1)
          {
            case 0:
              goto label_3;
            case 1:
              if (this.nested)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
                continue;
              }
              enumerator = this.listeners.GetEnumerator();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 2 : 0;
              continue;
            case 2:
              try
              {
label_10:
                if (NHUnitOfWorkManager.UnitOfWork.plk1QyQ7zFdelifhJRbA((object) enumerator))
                  goto label_8;
                else
                  goto label_11;
label_7:
                int num2;
                switch (num2)
                {
                  case 1:
                    goto label_2;
                  case 2:
                    break;
                  default:
                    goto label_10;
                }
label_8:
                NHUnitOfWorkManager.UnitOfWork.bmtlv1Q7cw3moBTH01eg((object) enumerator.Current, (object) this);
                num2 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
                {
                  num2 = 0;
                  goto label_7;
                }
                else
                  goto label_7;
label_11:
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 1 : 1;
                goto label_7;
              }
              finally
              {
                int num3;
                if (enumerator == null)
                  num3 = 2;
                else
                  goto label_16;
label_14:
                switch (num3)
                {
                  case 1:
                  case 2:
                }
label_16:
                NHUnitOfWorkManager.UnitOfWork.LM72atQxFiRWk4wlOeSC((object) enumerator);
                num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
                {
                  num3 = 1;
                  goto label_14;
                }
                else
                  goto label_14;
              }
            case 3:
              goto label_18;
            case 4:
label_2:
              ContextVars.Remove(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1012087039 ^ 1011955479));
              num1 = 3;
              continue;
            default:
              goto label_15;
          }
        }
label_3:
        return;
label_18:
        return;
label_15:;
      }

      /// <inheritdoc />
      public override bool IsDirty => NHUnitOfWorkManager.UnitOfWork.GFPl0yQxBaovBA51wt9S((object) this.Session);

      /// <inheritdoc />
      public override void Commit()
      {
        int num1 = 30;
        while (true)
        {
          int num2 = num1;
          ISession session;
          Exception exception;
          List<System.Action> list;
          List<System.Action>.Enumerator enumerator1;
          DateTime dateTime1;
          ILogger log;
          bool flag;
          DateTime dateTime2;
          TimeSpan timeSpan;
          IEnumerator<IUnitOfWorkEventListener> enumerator2;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_129;
              case 2:
                goto label_131;
              case 3:
              case 26:
                NHUnitOfWorkManager.UnitOfWork.weZP9pQxhIXoTxiIdgjA((object) this);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 12 : 12;
                continue;
              case 4:
                goto label_159;
              case 5:
                NHUnitOfWorkManager.PostCommitActions.Clear();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 16 : 7;
                continue;
              case 6:
                try
                {
                  int num3 = 15;
                  while (true)
                  {
                    int num4;
                    System.Action result;
                    IPersistenceContext persistenceContext;
                    IEnumerator<KeyValuePair<CollectionKey, IPersistentCollection>> enumerator3;
                    IEnumerator<object> enumerator4;
                    List<object> revertEntities;
                    List<object> changedEntities;
                    NHUnitOfWorkManager.UnitOfWork unitOfWork;
                    switch (num3)
                    {
                      case 1:
                        if (flag)
                        {
                          num3 = 28;
                          continue;
                        }
                        goto default;
                      case 2:
                        if (flag)
                        {
                          num4 = 23;
                          break;
                        }
                        goto case 18;
                      case 3:
                        int num5 = session.IsDirty() ? 1 : 0;
                        if (flag)
                        {
                          ILogger logger = log;
                          object obj1 = NHUnitOfWorkManager.UnitOfWork.lVYGWnQxWFWdWWsa2drl(-649342099 - -1150814748 ^ 501636199);
                          timeSpan = NHUnitOfWorkManager.UnitOfWork.VPpcM4QxVEF014kvURka(NHUnitOfWorkManager.UnitOfWork.tytbEIQxGYtdIsuNbEpj(), dateTime2);
                          // ISSUE: variable of a boxed type
                          __Boxed<int> totalMilliseconds = (System.ValueType) (int) timeSpan.TotalMilliseconds;
                          object obj2 = NHUnitOfWorkManager.UnitOfWork.lVYGWnQxWFWdWWsa2drl(1470998129 - 231418599 ^ 1239939612);
                          object message = NHUnitOfWorkManager.UnitOfWork.fPQEkTQxIyFdrIwCntiT(obj1, (object) totalMilliseconds, obj2);
                          logger.Debug(message);
                        }
                        if (num5 == 0)
                        {
                          num3 = 25;
                          continue;
                        }
                        goto case 22;
                      case 4:
                        if (result == null)
                        {
                          num3 = 31;
                          continue;
                        }
                        goto case 12;
                      case 5:
                        changedEntities = persistenceContext.EntitiesByKey.Values.ToList<object>();
                        num3 = 20;
                        continue;
                      case 6:
                      case 36:
                        NHUnitOfWorkManager.PreCommitActions.LockClear<System.Action>();
                        num3 = 14;
                        continue;
                      case 7:
                        revertEntities = NHUnitOfWorkManager.GetRevertEntities((string) this.dbName);
                        num3 = 34;
                        continue;
                      case 8:
label_35:
                        this.SafeExecuteListeners((Action<IUnitOfWorkEventListener>) (l =>
                        {
                          int num6 = 1;
                          while (true)
                          {
                            switch (num6)
                            {
                              case 0:
                                goto label_2;
                              case 1:
                                l.OnPreFlushUnitofWork((IUnitOfWork) unitOfWork, (IEnumerable<object>) changedEntities);
                                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
                                continue;
                              default:
                                goto label_4;
                            }
                          }
label_2:
                          return;
label_4:;
                        }), (string) NHUnitOfWorkManager.UnitOfWork.lVYGWnQxWFWdWWsa2drl(589593376 ^ -1977315327 ^ -1459262501), log);
                        num3 = 24;
                        continue;
                      case 9:
                        try
                        {
label_68:
                          if (NHUnitOfWorkManager.UnitOfWork.plk1QyQ7zFdelifhJRbA((object) enumerator3))
                            goto label_75;
                          else
                            goto label_69;
label_65:
                          IPersistentCollection persistentCollection;
                          KeyValuePair<CollectionKey, IPersistentCollection> current;
                          int num7;
                          while (true)
                          {
                            switch (num7)
                            {
                              case 1:
                                NHUnitOfWorkManager.UnitOfWork.pdG6FgQxZlDyjfyYri39((object) persistentCollection);
                                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
                                continue;
                              case 2:
                                goto label_35;
                              case 3:
                                if (NHUnitOfWorkManager.UnitOfWork.vYnbupQx84SNAyOpMLw9((object) persistentCollection) != null)
                                {
                                  num7 = 6;
                                  continue;
                                }
                                goto label_68;
                              case 4:
                                if ((persistentCollection = current.Value) != null)
                                {
                                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 3 : 1;
                                  continue;
                                }
                                goto label_68;
                              case 5:
                                goto label_75;
                              case 6:
                                if (revertEntities.Contains(NHUnitOfWorkManager.UnitOfWork.vYnbupQx84SNAyOpMLw9((object) persistentCollection)))
                                {
                                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 1 : 0;
                                  continue;
                                }
                                goto label_68;
                              default:
                                goto label_68;
                            }
                          }
label_69:
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 2 : 2;
                          goto label_65;
label_75:
                          current = enumerator3.Current;
                          num7 = 4;
                          goto label_65;
                        }
                        finally
                        {
                          if (enumerator3 != null)
                          {
                            int num8 = 0;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
                              num8 = 0;
                            while (true)
                            {
                              switch (num8)
                              {
                                case 1:
                                  goto label_81;
                                default:
                                  NHUnitOfWorkManager.UnitOfWork.LM72atQxFiRWk4wlOeSC((object) enumerator3);
                                  num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 0;
                                  continue;
                              }
                            }
                          }
label_81:;
                        }
                      case 10:
                      case 21:
                        goto label_154;
                      case 11:
                        ILogger logger1 = log;
                        object obj3 = NHUnitOfWorkManager.UnitOfWork.lVYGWnQxWFWdWWsa2drl(87862435 ^ 87633635);
                        timeSpan = NHUnitOfWorkManager.UnitOfWork.VPpcM4QxVEF014kvURka(NHUnitOfWorkManager.UnitOfWork.tytbEIQxGYtdIsuNbEpj(), dateTime2);
                        // ISSUE: variable of a boxed type
                        __Boxed<int> totalMilliseconds1 = (System.ValueType) (int) timeSpan.TotalMilliseconds;
                        string str1 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606949238);
                        object obj4 = NHUnitOfWorkManager.UnitOfWork.fPQEkTQxIyFdrIwCntiT(obj3, (object) totalMilliseconds1, (object) str1);
                        NHUnitOfWorkManager.UnitOfWork.bEusJaQxSEJSFiMsvlMZ((object) logger1, obj4);
                        num3 = 19;
                        continue;
                      case 12:
                        this.SafeExecuteAction(result, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -575855380), (object) result), log);
                        num3 = 30;
                        continue;
                      case 13:
                        NHUnitOfWorkManager.UnitOfWork.TbMfKXQxuSvxpZpnpA7s((object) session);
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 16 : 7;
                        continue;
                      case 14:
                        if (!flag)
                        {
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 7 : 21;
                          continue;
                        }
                        goto case 32;
                      case 15:
                        unitOfWork = this;
                        num4 = 7;
                        break;
                      case 16:
                        if (flag)
                        {
                          num3 = 11;
                          continue;
                        }
                        goto case 19;
                      case 17:
                        try
                        {
label_48:
                          if (enumerator4.MoveNext())
                            goto label_50;
                          else
                            goto label_49;
label_44:
                          IEntity current;
                          EntityEntry entityEntry;
                          int num9;
                          while (true)
                          {
                            switch (num9)
                            {
                              case 1:
                                goto label_96;
                              case 2:
                                entityEntry = (EntityEntry) NHUnitOfWorkManager.UnitOfWork.kBcs7rQxQGuFrMXqRu9Y((object) persistenceContext, (object) current);
                                num9 = 3;
                                continue;
                              case 3:
                                if (entityEntry != null)
                                {
                                  num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
                                  continue;
                                }
                                goto label_48;
                              case 4:
                                goto label_48;
                              case 5:
                                goto label_50;
                              default:
                                NHUnitOfWorkManager.UnitOfWork.uFYyQwQxCeYgGuhAlXtP((object) entityEntry, Status.ReadOnly);
                                num9 = 4;
                                continue;
                            }
                          }
label_49:
                          num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 1 : 1;
                          goto label_44;
label_50:
                          current = (IEntity) enumerator4.Current;
                          num9 = 2;
                          goto label_44;
                        }
                        finally
                        {
                          int num10;
                          if (enumerator4 == null)
                            num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 1;
                          else
                            goto label_55;
label_54:
                          switch (num10)
                          {
                            case 2:
                              break;
                            default:
                          }
label_55:
                          NHUnitOfWorkManager.UnitOfWork.LM72atQxFiRWk4wlOeSC((object) enumerator4);
                          num10 = 0;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0)
                          {
                            num10 = 0;
                            goto label_54;
                          }
                          else
                            goto label_54;
                        }
                      case 18:
                        this.SafeExecuteListeners((Action<IUnitOfWorkEventListener>) (l =>
                        {
                          int num11 = 1;
                          while (true)
                          {
                            switch (num11)
                            {
                              case 0:
                                goto label_2;
                              case 1:
                                NHUnitOfWorkManager.UnitOfWork.UhKvYGQxpJVTtappYxQW((object) l, (object) this);
                                num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
                                continue;
                              default:
                                goto label_4;
                            }
                          }
label_2:
                          return;
label_4:;
                        }), (string) NHUnitOfWorkManager.UnitOfWork.lVYGWnQxWFWdWWsa2drl(1470998129 - 231418599 ^ 1239939626), log);
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 26 : 9;
                        continue;
                      case 19:
                      case 25:
                        this.SafeExecuteListeners((Action<IUnitOfWorkEventListener>) (l =>
                        {
                          int num12 = 1;
                          while (true)
                          {
                            switch (num12)
                            {
                              case 0:
                                goto label_2;
                              case 1:
                                l.OnPostFlushUnitofWork((IUnitOfWork) this);
                                num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
                                continue;
                              default:
                                goto label_4;
                            }
                          }
label_2:
                          return;
label_4:;
                        }), (string) NHUnitOfWorkManager.UnitOfWork.lVYGWnQxWFWdWWsa2drl(1319452732 ^ 1319158444), log);
                        num3 = 27;
                        continue;
                      case 20:
                        List<object> source = changedEntities;
                        System.Func<object, bool> func;
                        System.Func<object, bool> func1 = func;
                        System.Func<object, bool> predicate = func1 == null ? (func = (System.Func<object, bool>) (e => revertEntities.Contains(e))) : func1;
                        enumerator4 = source.Where<object>(predicate).GetEnumerator();
                        num3 = 17;
                        continue;
                      case 22:
                        dateTime2 = DateTime.Now;
                        num3 = 13;
                        continue;
                      case 23:
                        ILogger logger2 = log;
                        string str2 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 44655163);
                        timeSpan = NHUnitOfWorkManager.UnitOfWork.tytbEIQxGYtdIsuNbEpj() - dateTime2;
                        // ISSUE: variable of a boxed type
                        __Boxed<int> totalMilliseconds2 = (System.ValueType) (int) timeSpan.TotalMilliseconds;
                        object obj5 = NHUnitOfWorkManager.UnitOfWork.lVYGWnQxWFWdWWsa2drl(-1290212282 ^ -644262414 ^ 1787050018);
                        object message1 = NHUnitOfWorkManager.UnitOfWork.fPQEkTQxIyFdrIwCntiT((object) str2, (object) totalMilliseconds2, obj5);
                        logger2.Debug(message1);
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 18 : 1;
                        continue;
                      case 24:
                        dateTime2 = NHUnitOfWorkManager.UnitOfWork.tytbEIQxGYtdIsuNbEpj();
                        num3 = 29;
                        continue;
                      case 26:
                        dateTime2 = NHUnitOfWorkManager.UnitOfWork.tytbEIQxGYtdIsuNbEpj();
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 3;
                        continue;
                      case 27:
                        if (NHUnitOfWorkManager.UnitOfWork.d7tLxfQxiyPfvdVgXtLw((object) NHUnitOfWorkManager.PreCommitActions) > 0)
                        {
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 1 : 0;
                          continue;
                        }
                        goto label_154;
                      case 28:
                        NHUnitOfWorkManager.UnitOfWork.bEusJaQxSEJSFiMsvlMZ((object) log, NHUnitOfWorkManager.UnitOfWork.lVYGWnQxWFWdWWsa2drl(-1839087379 - 334718690 ^ 2120997077));
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
                        continue;
                      case 29:
                        NHUnitOfWorkManager.UnitOfWork.TbMfKXQxuSvxpZpnpA7s((object) session);
                        num3 = 2;
                        continue;
                      case 32:
                        NHUnitOfWorkManager.UnitOfWork.bEusJaQxSEJSFiMsvlMZ((object) log, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675734997));
                        num3 = 10;
                        continue;
                      case 33:
label_96:
                        if (NHUnitOfWorkManager.UnitOfWork.t1aUZ8Qxv1JG93iRAuKT((object) revertEntities) > 0)
                        {
                          num4 = 35;
                          break;
                        }
                        goto case 8;
                      case 34:
                        persistenceContext = (IPersistenceContext) NHUnitOfWorkManager.UnitOfWork.TRt7n7QxfYqVTuH3e7Bt(NHUnitOfWorkManager.UnitOfWork.tkiEt2QxExZnkKZyfTPs((object) session));
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 5 : 5;
                        continue;
                      case 35:
                        enumerator3 = persistenceContext.CollectionsByKey.GetEnumerator();
                        num3 = 9;
                        continue;
                      default:
                        if (!NHUnitOfWorkManager.PreCommitActions.LockTryDequeue<System.Action>(out result))
                        {
                          num3 = 36;
                          continue;
                        }
                        goto case 4;
                    }
                    num3 = num4;
                  }
                }
                catch
                {
                  int num13 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
                    num13 = 0;
                  while (true)
                  {
                    switch (num13)
                    {
                      case 1:
                        try
                        {
                          try
                          {
                            NHUnitOfWorkManager.UnitOfWork.nSwMWiQxRTtZEmZNqPNU((object) session.Transaction);
                            int num14 = 0;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0)
                              num14 = 0;
                            switch (num14)
                            {
                            }
                          }
                          catch
                          {
                            int num15 = 0;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
                              num15 = 0;
                            while (true)
                            {
                              switch (num15)
                              {
                                case 1:
                                  goto label_109;
                                default:
                                  ((IDisposable) NHUnitOfWorkManager.UnitOfWork.NArOBLQ7U2VhHHfu4cwm((object) session)).Dispose();
                                  num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 0;
                                  continue;
                              }
                            }
                          }
                        }
                        catch (Exception ex)
                        {
                          int num16 = 0;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
                            num16 = 1;
                          while (true)
                          {
                            switch (num16)
                            {
                              case 1:
                                NHUnitOfWorkManager.UnitOfWork.RiwEiGQxqBgmtsuNeI3k((object) log, NHUnitOfWorkManager.UnitOfWork.lVYGWnQxWFWdWWsa2drl(~289714581 ^ -289845778), (object) ex);
                                num16 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
                                continue;
                              default:
                                goto label_109;
                            }
                          }
                        }
                        break;
                      case 2:
                        goto label_128;
                      case 3:
                        goto label_121;
                    }
label_109:
                    num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 1 : 3;
                  }
label_121:
                  try
                  {
                    this.ExecuteRollbackActions();
                    int num17 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
                      num17 = 0;
                    switch (num17)
                    {
                    }
                  }
                  catch (Exception ex)
                  {
                    int num18 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
                      num18 = 0;
                    while (true)
                    {
                      switch (num18)
                      {
                        case 1:
                          goto label_128;
                        default:
                          log.Error(NHUnitOfWorkManager.UnitOfWork.lVYGWnQxWFWdWWsa2drl(1319452732 ^ 1319158724), ex);
                          num18 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 1;
                          continue;
                      }
                    }
                  }
label_128:
                  throw;
                }
              case 7:
                NHUnitOfWorkManager.UnitOfWork.PmXx0OQxKFw6yi2wMnhq(NHUnitOfWorkManager.UnitOfWork.NArOBLQ7U2VhHHfu4cwm((object) session));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 3 : 8;
                continue;
              case 8:
                if (!flag)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 15 : 14;
                  continue;
                }
                goto case 24;
              case 9:
                goto label_167;
              case 10:
                goto label_164;
              case 11:
                if (exception == null)
                {
                  num2 = 38;
                  continue;
                }
                goto case 3;
              case 12:
                goto label_179;
              case 13:
              case 22:
                if (!flag)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 1 : 1;
                  continue;
                }
                goto label_167;
              case 14:
                ContextVars.TryGetValue<Exception>((string) NHUnitOfWorkManager.UnitOfWork.lVYGWnQxWFWdWWsa2drl(1597012150 ^ 1597142878), out exception);
                num2 = 35;
                continue;
              case 16:
                if (flag)
                {
                  num2 = 32;
                  continue;
                }
                goto case 21;
              case 17:
label_154:
                dateTime2 = NHUnitOfWorkManager.UnitOfWork.tytbEIQxGYtdIsuNbEpj();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 6 : 33;
                continue;
              case 18:
                if (NHUnitOfWorkManager.UnitOfWork.NArOBLQ7U2VhHHfu4cwm((object) session) != null)
                {
                  num2 = 25;
                  continue;
                }
                goto label_160;
              case 19:
                try
                {
label_20:
                  if (enumerator1.MoveNext())
                    goto label_22;
                  else
                    goto label_21;
label_11:
                  System.Action current;
                  int num19;
                  switch (num19)
                  {
                    case 1:
                      goto label_171;
                    case 2:
                      goto label_22;
                    case 3:
                      goto label_20;
                    default:
                      try
                      {
                        current();
                        int num20 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
                          num20 = 0;
                        switch (num20)
                        {
                          default:
                            goto label_20;
                        }
                      }
                      catch (Exception ex)
                      {
                        int num21 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
                          num21 = 0;
                        while (true)
                        {
                          switch (num21)
                          {
                            case 1:
                              goto label_20;
                            default:
                              NHUnitOfWorkManager.UnitOfWork.RiwEiGQxqBgmtsuNeI3k((object) log, NHUnitOfWorkManager.UnitOfWork.in5MJ2QxTL2IBff9TMll(NHUnitOfWorkManager.UnitOfWork.lVYGWnQxWFWdWWsa2drl(-951514650 ^ -951284552), (object) current), (object) ex);
                              num21 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 1;
                              continue;
                          }
                        }
                      }
                  }
label_21:
                  num19 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 1 : 1;
                  goto label_11;
label_22:
                  current = enumerator1.Current;
                  num19 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0)
                  {
                    num19 = 0;
                    goto label_11;
                  }
                  else
                    goto label_11;
                }
                finally
                {
                  enumerator1.Dispose();
                  int num22 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
                    num22 = 0;
                  switch (num22)
                  {
                    default:
                  }
                }
              case 20:
label_171:
                if (!flag)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 8 : 13;
                  continue;
                }
                goto case 27;
              case 21:
                enumerator1 = list.GetEnumerator();
                num2 = 19;
                continue;
              case 23:
                goto label_153;
              case 24:
                ILogger logger3 = log;
                object obj6 = NHUnitOfWorkManager.UnitOfWork.lVYGWnQxWFWdWWsa2drl(1819636893 << 3 ^ 1672356050);
                timeSpan = NHUnitOfWorkManager.UnitOfWork.VPpcM4QxVEF014kvURka(NHUnitOfWorkManager.UnitOfWork.tytbEIQxGYtdIsuNbEpj(), dateTime2);
                // ISSUE: variable of a boxed type
                __Boxed<int> totalMilliseconds3 = (System.ValueType) (int) timeSpan.TotalMilliseconds;
                string str = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1642695982);
                object obj7 = NHUnitOfWorkManager.UnitOfWork.fPQEkTQxIyFdrIwCntiT(obj6, (object) totalMilliseconds3, (object) str);
                NHUnitOfWorkManager.UnitOfWork.bEusJaQxSEJSFiMsvlMZ((object) logger3, obj7);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
                continue;
              case 25:
                if (!((ITransaction) NHUnitOfWorkManager.UnitOfWork.NArOBLQ7U2VhHHfu4cwm((object) session)).IsActive)
                {
                  num2 = 4;
                  continue;
                }
                goto case 14;
              case 27:
                NHUnitOfWorkManager.UnitOfWork.bEusJaQxSEJSFiMsvlMZ((object) log, NHUnitOfWorkManager.UnitOfWork.lVYGWnQxWFWdWWsa2drl(1461625753 ^ 1461397045));
                num2 = 22;
                continue;
              case 28:
                dateTime1 = NHUnitOfWorkManager.UnitOfWork.tytbEIQxGYtdIsuNbEpj();
                num2 = 6;
                continue;
              case 29:
                if (!this.nested)
                {
                  num2 = 18;
                  continue;
                }
                goto label_166;
              case 30:
                session = (ISession) NHUnitOfWorkManager.UnitOfWork.S3hVyeQ7LJ0xbbpYTDdH(this.sessionProvider, this.dbName);
                num2 = 29;
                continue;
              case 31:
                if (list.Count > 0)
                {
                  num2 = 5;
                  continue;
                }
                goto case 13;
              case 32:
                NHUnitOfWorkManager.UnitOfWork.bEusJaQxSEJSFiMsvlMZ((object) log, NHUnitOfWorkManager.UnitOfWork.lVYGWnQxWFWdWWsa2drl(813604817 ^ 813374243));
                num2 = 21;
                continue;
              case 33:
                if (NHUnitOfWorkManager.UnitOfWork.NArOBLQ7U2VhHHfu4cwm((object) session) == null)
                {
                  num2 = 10;
                  continue;
                }
                goto case 34;
              case 34:
                if (NHUnitOfWorkManager.UnitOfWork.e3ypf1Q7s6vf4fCC4GRG((object) session.Transaction))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 2 : 7;
                  continue;
                }
                goto label_149;
              case 35:
                if (!NHUnitOfWorkManager.UnitOfWork.RPRqaLQxb9VjsvES0nsa(NHUnitOfWorkManager.UnitOfWork.KeYCnBQxoxqJfEhhmHjh(), this.dbName))
                  goto case 11;
                else
                  goto label_29;
              case 36:
                goto label_144;
              case 37:
                goto label_155;
              case 38:
                log = Logger.Log;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 39 : 30;
                continue;
              case 39:
                flag = log.IsDebugEnabled();
                num2 = 28;
                continue;
              default:
                enumerator2 = this.listeners.GetEnumerator();
                num2 = 2;
                continue;
            }
          }
label_29:
          num1 = 26;
          continue;
label_131:
          try
          {
label_135:
            if (enumerator2.MoveNext())
              goto label_133;
            else
              goto label_136;
label_132:
            IUnitOfWorkEventListener current;
            int num23;
            switch (num23)
            {
              case 1:
                try
                {
                  NHUnitOfWorkManager.UnitOfWork.g582XlQxX86Bfggk2GAj((object) current, (object) this);
                  int num24 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0)
                    num24 = 0;
                  switch (num24)
                  {
                    default:
                      goto label_135;
                  }
                }
                catch (Exception ex)
                {
                  int num25 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
                    num25 = 1;
                  while (true)
                  {
                    switch (num25)
                    {
                      case 1:
                        NHUnitOfWorkManager.UnitOfWork.RiwEiGQxqBgmtsuNeI3k((object) log, NHUnitOfWorkManager.UnitOfWork.lVYGWnQxWFWdWWsa2drl(712480695 ^ 712119061), (object) ex);
                        num25 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_135;
                    }
                  }
                }
              case 2:
                break;
              case 3:
                goto label_155;
              default:
                goto label_135;
            }
label_133:
            current = enumerator2.Current;
            num23 = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
            {
              num23 = 1;
              goto label_132;
            }
            else
              goto label_132;
label_136:
            num23 = 3;
            goto label_132;
          }
          finally
          {
            if (enumerator2 != null)
            {
              int num26 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
                num26 = 0;
              while (true)
              {
                switch (num26)
                {
                  case 1:
                    NHUnitOfWorkManager.UnitOfWork.LM72atQxFiRWk4wlOeSC((object) enumerator2);
                    num26 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_151;
                }
              }
            }
label_151:;
          }
label_155:
          list = NHUnitOfWorkManager.PostCommitActions.ToList<System.Action>();
          num1 = 31;
          continue;
label_167:
          ILogger logger4 = log;
          object obj8 = NHUnitOfWorkManager.UnitOfWork.lVYGWnQxWFWdWWsa2drl(901793403 ^ 902152297);
          timeSpan = NHUnitOfWorkManager.UnitOfWork.VPpcM4QxVEF014kvURka(DateTime.Now, dateTime1);
          // ISSUE: variable of a boxed type
          __Boxed<int> totalMilliseconds4 = (System.ValueType) (int) timeSpan.TotalMilliseconds;
          object obj9 = NHUnitOfWorkManager.UnitOfWork.lVYGWnQxWFWdWWsa2drl(1052221104 - 768835541 ^ 283221837);
          object obj10 = NHUnitOfWorkManager.UnitOfWork.fPQEkTQxIyFdrIwCntiT(obj8, (object) totalMilliseconds4, obj9);
          NHUnitOfWorkManager.UnitOfWork.bEusJaQxSEJSFiMsvlMZ((object) logger4, obj10);
          num1 = 23;
        }
label_129:
        return;
label_159:
        return;
label_164:
        return;
label_179:
        return;
label_153:
        return;
label_144:
        return;
label_166:
        return;
label_149:
        return;
label_160:;
      }

      /// <summary>Откатить транзакцию</summary>
      public override void Rollback()
      {
        int num1 = 12;
        Exception exception;
        while (true)
        {
          int num2 = num1;
          ISession session;
          IEnumerator<IUnitOfWorkEventListener> enumerator;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_36;
              case 2:
label_35:
                enumerator = this.listeners.GetEnumerator();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
                continue;
              case 3:
                goto label_60;
              case 4:
                try
                {
                  ((ILogger) NHUnitOfWorkManager.UnitOfWork.IgZLptQxkqm8NcH9aSc4()).Debug(NHUnitOfWorkManager.UnitOfWork.lVYGWnQxWFWdWWsa2drl(1470998129 - 231418599 ^ 1239940568));
                  int num3 = 4;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 1:
                        goto label_37;
                      case 2:
                        NHUnitOfWorkManager.PreCommitActions.LockClear<System.Action>();
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 1;
                        continue;
                      case 3:
                        NHUnitOfWorkManager.UnitOfWork.y1XPPvQxnsKc7QExKJfa((object) NHUnitOfWorkManager.RollbackHolder, this.dbName, false);
                        num3 = 2;
                        continue;
                      case 4:
                        try
                        {
                          NHUnitOfWorkManager.UnitOfWork.nSwMWiQxRTtZEmZNqPNU(NHUnitOfWorkManager.UnitOfWork.NArOBLQ7U2VhHHfu4cwm((object) session));
                          int num4 = 0;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
                            num4 = 0;
                          switch (num4)
                          {
                          }
                        }
                        catch
                        {
                          int num5 = 1;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
                            num5 = 0;
                          while (true)
                          {
                            switch (num5)
                            {
                              case 1:
                                NHUnitOfWorkManager.UnitOfWork.LM72atQxFiRWk4wlOeSC(NHUnitOfWorkManager.UnitOfWork.NArOBLQ7U2VhHHfu4cwm((object) session));
                                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
                                continue;
                              default:
                                goto label_21;
                            }
                          }
                        }
                        break;
                    }
label_21:
                    NHUnitOfWorkManager.UnitOfWork.bEusJaQxSEJSFiMsvlMZ(NHUnitOfWorkManager.UnitOfWork.IgZLptQxkqm8NcH9aSc4(), NHUnitOfWorkManager.UnitOfWork.lVYGWnQxWFWdWWsa2drl(--1360331293 ^ 1360037073));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 3 : 2;
                  }
                }
                catch (Exception ex)
                {
                  int num6 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
                    num6 = 1;
                  while (true)
                  {
                    switch (num6)
                    {
                      case 1:
                        Logger.Log.Warn(NHUnitOfWorkManager.UnitOfWork.lVYGWnQxWFWdWWsa2drl(1113862659 ^ 1113993607), ex);
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_37;
                    }
                  }
                }
              case 5:
                goto label_55;
              case 6:
                if (exception == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 5 : 3;
                  continue;
                }
                goto label_36;
              case 7:
                goto label_38;
              case 8:
                ContextVars.TryGetValue<Exception>((string) NHUnitOfWorkManager.UnitOfWork.lVYGWnQxWFWdWWsa2drl(-87337865 ^ -87467105), out exception);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 6 : 2;
                continue;
              case 9:
              case 13:
label_31:
                if (this.nested)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 3 : 2;
                  continue;
                }
                goto case 8;
              case 10:
                if (session.Transaction == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 9 : 1;
                  continue;
                }
                goto case 15;
              case 11:
                if (!this.nested)
                {
                  num2 = 10;
                  continue;
                }
                goto case 9;
              case 12:
                session = (ISession) NHUnitOfWorkManager.UnitOfWork.S3hVyeQ7LJ0xbbpYTDdH(this.sessionProvider, this.dbName);
                num2 = 11;
                continue;
              case 14:
                try
                {
                  this.ExecuteRollbackActions();
                  int num7 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
                    num7 = 0;
                  switch (num7)
                  {
                    default:
                      goto label_35;
                  }
                }
                catch (Exception ex)
                {
                  int num8 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
                    num8 = 1;
                  while (true)
                  {
                    switch (num8)
                    {
                      case 1:
                        ((ILogger) NHUnitOfWorkManager.UnitOfWork.IgZLptQxkqm8NcH9aSc4()).Error(NHUnitOfWorkManager.UnitOfWork.lVYGWnQxWFWdWWsa2drl(~-306453669 ^ 306290524), ex);
                        num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_35;
                    }
                  }
                }
              case 15:
                if (NHUnitOfWorkManager.UnitOfWork.e3ypf1Q7s6vf4fCC4GRG((object) session.Transaction))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 4 : 0;
                  continue;
                }
                goto case 9;
              case 16:
label_37:
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 2 : 14;
                continue;
              default:
                try
                {
label_43:
                  if (enumerator.MoveNext())
                    goto label_53;
                  else
                    goto label_44;
label_42:
                  IUnitOfWorkEventListener current;
                  int num9;
                  switch (num9)
                  {
                    case 1:
                      goto label_43;
                    case 2:
                      goto label_53;
                    case 3:
                      goto label_31;
                    default:
                      try
                      {
                        NHUnitOfWorkManager.UnitOfWork.lUpySHQxOTV8sSOuHkVy((object) current, (object) this);
                        int num10 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
                          num10 = 0;
                        switch (num10)
                        {
                          default:
                            goto label_43;
                        }
                      }
                      catch (Exception ex)
                      {
                        int num11 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
                          num11 = 1;
                        while (true)
                        {
                          switch (num11)
                          {
                            case 1:
                              NHUnitOfWorkManager.UnitOfWork.RiwEiGQxqBgmtsuNeI3k(NHUnitOfWorkManager.UnitOfWork.IgZLptQxkqm8NcH9aSc4(), NHUnitOfWorkManager.UnitOfWork.lVYGWnQxWFWdWWsa2drl(~1767720452 ^ -1767424321), (object) ex);
                              num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
                              continue;
                            default:
                              goto label_43;
                          }
                        }
                      }
                  }
label_44:
                  num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 3 : 1;
                  goto label_42;
label_53:
                  current = enumerator.Current;
                  num9 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
                  {
                    num9 = 0;
                    goto label_42;
                  }
                  else
                    goto label_42;
                }
                finally
                {
                  if (enumerator != null)
                  {
                    int num12 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
                      num12 = 1;
                    while (true)
                    {
                      switch (num12)
                      {
                        case 1:
                          NHUnitOfWorkManager.UnitOfWork.LM72atQxFiRWk4wlOeSC((object) enumerator);
                          num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
                          continue;
                        default:
                          goto label_62;
                      }
                    }
                  }
label_62:;
                }
            }
          }
label_36:
          NHUnitOfWorkManager.UnitOfWork.A0hNHvQx26oB5XOtQ5EC((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345292244));
          num1 = 7;
        }
label_60:
        return;
label_55:
        return;
label_38:
        throw exception;
      }

      /// <inheritdoc />
      public override ISession Session => ((ISessionProvider) this.sessionProvider).GetSession((string) this.dbName);

      /// <inheritdoc />
      public override Guid Uid => this.uid;

      /// <summary>Выполнить синхронные действия по откату транзакции</summary>
      private void ExecuteRollbackActions()
      {
        int num1 = 12;
        while (true)
        {
          List<System.Action> list;
          List<System.Action>.Enumerator enumerator;
          ILogger log;
          bool flag;
          switch (num1)
          {
            case 1:
              log = (ILogger) NHUnitOfWorkManager.UnitOfWork.IgZLptQxkqm8NcH9aSc4();
              num1 = 6;
              continue;
            case 2:
              NHUnitOfWorkManager.RollbackActions.Clear();
              num1 = 7;
              continue;
            case 3:
              goto label_31;
            case 4:
              NHUnitOfWorkManager.UnitOfWork.bEusJaQxSEJSFiMsvlMZ((object) log, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824027643));
              num1 = 10;
              continue;
            case 5:
              goto label_17;
            case 6:
              flag = log.IsDebugEnabled();
              num1 = 2;
              continue;
            case 7:
              if (flag)
              {
                num1 = 4;
                continue;
              }
              goto case 10;
            case 8:
              try
              {
label_15:
                if (enumerator.MoveNext())
                  goto label_7;
                else
                  goto label_16;
label_6:
                System.Action current;
                int num2;
                switch (num2)
                {
                  case 1:
                    goto label_32;
                  case 2:
                    break;
                  case 3:
                    try
                    {
                      current();
                      int num3 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0)
                        num3 = 0;
                      switch (num3)
                      {
                        default:
                          goto label_15;
                      }
                    }
                    catch (Exception ex)
                    {
                      int num4 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
                        num4 = 0;
                      while (true)
                      {
                        switch (num4)
                        {
                          case 1:
                            goto label_15;
                          default:
                            NHUnitOfWorkManager.UnitOfWork.RiwEiGQxqBgmtsuNeI3k((object) log, NHUnitOfWorkManager.UnitOfWork.in5MJ2QxTL2IBff9TMll((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-710283084 ^ -537863435 ^ 173845951), (object) current), (object) ex);
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 1;
                            continue;
                        }
                      }
                    }
                  default:
                    goto label_15;
                }
label_7:
                current = enumerator.Current;
                num2 = 3;
                goto label_6;
label_16:
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 1;
                goto label_6;
              }
              finally
              {
                enumerator.Dispose();
                int num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
                  num5 = 0;
                switch (num5)
                {
                  default:
                }
              }
            case 9:
label_32:
              if (!flag)
              {
                num1 = 3;
                continue;
              }
              break;
            case 10:
              enumerator = list.GetEnumerator();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 8 : 7;
              continue;
            case 11:
              if (NHUnitOfWorkManager.UnitOfWork.dmmtPMQxe2x9G5JRH2EM((object) list) > 0)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 1;
                continue;
              }
              goto label_21;
            case 12:
              list = NHUnitOfWorkManager.RollbackActions.ToList<System.Action>();
              num1 = 11;
              continue;
          }
          NHUnitOfWorkManager.UnitOfWork.bEusJaQxSEJSFiMsvlMZ((object) log, NHUnitOfWorkManager.UnitOfWork.lVYGWnQxWFWdWWsa2drl(-398663332 ^ -398890726));
          num1 = 5;
        }
label_31:
        return;
label_17:
        return;
label_21:;
      }

      /// <summary>Безопасно выполнить действие синхронно</summary>
      /// <param name="action">Действие</param>
      /// <param name="errorMessage">Сообщение об ошибке</param>
      /// <param name="logger">Логгер</param>
      private void SafeExecuteAction(System.Action action, string errorMessage, ILogger logger)
      {
        switch (1)
        {
          case 1:
            try
            {
              NHUnitOfWorkManager.UnitOfWork.jOVdFPQxPtcF17HYOxfN((object) action);
              int num = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
                num = 0;
              switch (num)
              {
                case 0:
                  return;
                default:
                  return;
              }
            }
            catch (TransactionRollbackException ex)
            {
              int num = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
                num = 0;
              switch (num)
              {
                default:
                  throw;
              }
            }
            catch (Exception ex)
            {
              int num = 2;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
                num = 2;
              Exception innerException;
              while (true)
              {
                switch (num)
                {
                  case 1:
                    goto label_20;
                  case 2:
                    NHUnitOfWorkManager.UnitOfWork.RiwEiGQxqBgmtsuNeI3k((object) logger, (object) errorMessage, (object) ex);
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
                    continue;
                  case 3:
                    NHUnitOfWorkManager.UnitOfWork.A0hNHvQx26oB5XOtQ5EC(NHUnitOfWorkManager.UnitOfWork.lVYGWnQxWFWdWWsa2drl(-138018305 ^ -138146281));
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 1;
                    continue;
                  case 4:
                    if (innerException != null)
                    {
                      num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 3 : 2;
                      continue;
                    }
                    goto label_4;
                  default:
                    ContextVars.TryGetValue<Exception>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2092274397 << 4 ^ 883219928), out innerException);
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 3 : 4;
                    continue;
                }
              }
label_4:
              break;
label_20:
              throw new InvalidOperationException((string) NHUnitOfWorkManager.UnitOfWork.jLcAXoQx1CaIUbqaZ4CG((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138596514)), innerException);
            }
        }
      }

      /// <summary>
      /// Безопасно выполнить указанное действие над <see cref="T:EleWise.ELMA.Runtime.NH.IUnitOfWorkEventListener" /> синхронно
      /// </summary>
      /// <param name="action">Действие</param>
      /// <param name="errorMessage">Сообщение об ошибке</param>
      /// <param name="logger">Логгер</param>
      private void SafeExecuteListeners(
        Action<IUnitOfWorkEventListener> action,
        string errorMessage,
        ILogger logger)
      {
        foreach (IUnitOfWorkEventListener listener in this.listeners)
        {
          IUnitOfWorkEventListener currentListener = listener;
          this.SafeExecuteAction((System.Action) (() =>
          {
            int num = 1;
            while (true)
            {
              switch (num)
              {
                case 0:
                  goto label_2;
                case 1:
                  action(currentListener);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_4;
              }
            }
label_2:
            return;
label_4:;
          }), errorMessage, logger);
        }
      }

      internal static AsyncTaskMethodBuilder zr4d5FQ7YoiywvCnUZtw() => AsyncTaskMethodBuilder.Create();

      internal static bool KBOH3XQ75JJQL8LCjlZS() => NHUnitOfWorkManager.UnitOfWork.uHKsZsQ7gewG0ZdCGbs4 == null;

      internal static NHUnitOfWorkManager.UnitOfWork PoaeK8Q7jvt1QFr1AqBf() => (NHUnitOfWorkManager.UnitOfWork) NHUnitOfWorkManager.UnitOfWork.uHKsZsQ7gewG0ZdCGbs4;

      internal static object S3hVyeQ7LJ0xbbpYTDdH([In] object obj0, [In] object obj1) => (object) ((ISessionProvider) obj0).GetSession((string) obj1);

      internal static object NArOBLQ7U2VhHHfu4cwm([In] object obj0) => (object) ((ISession) obj0).Transaction;

      internal static bool e3ypf1Q7s6vf4fCC4GRG([In] object obj0) => ((ITransaction) obj0).IsActive;

      internal static void bmtlv1Q7cw3moBTH01eg([In] object obj0, [In] object obj1) => ((IUnitOfWorkEventListener) obj0).OnDisposeUnitofWork((IUnitOfWork) obj1);

      internal static bool plk1QyQ7zFdelifhJRbA([In] object obj0) => ((IEnumerator) obj0).MoveNext();

      internal static void LM72atQxFiRWk4wlOeSC([In] object obj0) => ((IDisposable) obj0).Dispose();

      internal static bool GFPl0yQxBaovBA51wt9S([In] object obj0) => ((ISession) obj0).IsDirty();

      internal static object lVYGWnQxWFWdWWsa2drl(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object KeYCnBQxoxqJfEhhmHjh() => (object) NHUnitOfWorkManager.RollbackHolder;

      internal static bool RPRqaLQxb9VjsvES0nsa([In] object obj0, [In] object obj1) => ((NHUnitOfWorkManager.UnitOfWorkContextRollbackHolder) obj0).GetRollBackFlag((string) obj1);

      internal static void weZP9pQxhIXoTxiIdgjA([In] object obj0) => ((EleWise.ELMA.Runtime.NH.UnitOfWork) obj0).Rollback();

      internal static DateTime tytbEIQxGYtdIsuNbEpj() => DateTime.Now;

      internal static object tkiEt2QxExZnkKZyfTPs([In] object obj0) => (object) ((ISession) obj0).GetSessionImplementation();

      internal static object TRt7n7QxfYqVTuH3e7Bt([In] object obj0) => (object) ((ISessionImplementor) obj0).PersistenceContext;

      internal static object kBcs7rQxQGuFrMXqRu9Y([In] object obj0, [In] object obj1) => (object) ((IPersistenceContext) obj0).GetEntry(obj1);

      internal static void uFYyQwQxCeYgGuhAlXtP([In] object obj0, [In] Status obj1) => ((EntityEntry) obj0).Status = obj1;

      internal static int t1aUZ8Qxv1JG93iRAuKT([In] object obj0) => ((List<object>) obj0).Count;

      internal static object vYnbupQx84SNAyOpMLw9([In] object obj0) => ((IPersistentCollection) obj0).Owner;

      internal static void pdG6FgQxZlDyjfyYri39([In] object obj0) => ((IPersistentCollection) obj0).ClearDirty();

      internal static void TbMfKXQxuSvxpZpnpA7s([In] object obj0) => ((ISession) obj0).Flush();

      internal static object fPQEkTQxIyFdrIwCntiT([In] object obj0, [In] object obj1, [In] object obj2) => (object) (obj0.ToString() + obj1 + obj2);

      internal static TimeSpan VPpcM4QxVEF014kvURka([In] DateTime obj0, [In] DateTime obj1) => obj0 - obj1;

      internal static void bEusJaQxSEJSFiMsvlMZ([In] object obj0, [In] object obj1) => ((ILogger) obj0).Debug(obj1);

      internal static int d7tLxfQxiyPfvdVgXtLw([In] object obj0) => ((Queue<System.Action>) obj0).Count;

      internal static void nSwMWiQxRTtZEmZNqPNU([In] object obj0) => ((ITransaction) obj0).Rollback();

      internal static void RiwEiGQxqBgmtsuNeI3k([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

      internal static void PmXx0OQxKFw6yi2wMnhq([In] object obj0) => ((ITransaction) obj0).Commit();

      internal static void g582XlQxX86Bfggk2GAj([In] object obj0, [In] object obj1) => ((IUnitOfWorkEventListener) obj0).OnPostCommitUnitofWork((IUnitOfWork) obj1);

      internal static object in5MJ2QxTL2IBff9TMll([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

      internal static object IgZLptQxkqm8NcH9aSc4() => (object) Logger.Log;

      internal static void y1XPPvQxnsKc7QExKJfa([In] object obj0, [In] object obj1, bool flag) => ((NHUnitOfWorkManager.UnitOfWorkContextRollbackHolder) obj0).SetRollBackFlag((string) obj1, flag);

      internal static void lUpySHQxOTV8sSOuHkVy([In] object obj0, [In] object obj1) => ((IUnitOfWorkEventListener) obj0).OnPostRollbackUnitofWork((IUnitOfWork) obj1);

      internal static void A0hNHvQx26oB5XOtQ5EC([In] object obj0) => ContextVars.Remove((string) obj0);

      internal static int dmmtPMQxe2x9G5JRH2EM([In] object obj0) => ((List<System.Action>) obj0).Count;

      internal static void jOVdFPQxPtcF17HYOxfN([In] object obj0) => ((System.Action) obj0)();

      internal static object jLcAXoQx1CaIUbqaZ4CG([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static object FySL82QxNDLehktR2TOt() => (object) Task.CompletedTask;

      internal static void WZEfrBQx33oM8b2ljov4([In] object obj0, [In] object obj1) => ((IUnitOfWorkEventListener) obj0).OnPostFlushUnitofWork((IUnitOfWork) obj1);

      internal static void UhKvYGQxpJVTtappYxQW([In] object obj0, [In] object obj1) => ((IUnitOfWorkEventListener) obj0).OnPreCommitUnitofWork((IUnitOfWork) obj1);
    }

    private class UnitOfWorkContextRollbackHolder
    {
      internal static object jhW8ZGQxau4mWS8Lnve8;

      public static NHUnitOfWorkManager.UnitOfWorkContextRollbackHolder GetFromContext() => ContextVars.GetOrAdd<NHUnitOfWorkManager.UnitOfWorkContextRollbackHolder>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(95909607 + 343705423 ^ 439777046), (Func<NHUnitOfWorkManager.UnitOfWorkContextRollbackHolder>) (() => new NHUnitOfWorkManager.UnitOfWorkContextRollbackHolder()));

      /// <summary>Конструктор</summary>
      private UnitOfWorkContextRollbackHolder()
      {
        NHUnitOfWorkManager.UnitOfWorkContextRollbackHolder.jqjTTXQxwUHQ0PLfvWJm();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.Actions = new List<System.Action>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 2;
              continue;
            case 2:
              this.AsyncActions = new List<System.Func<CancellationToken, Task>>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
              continue;
            default:
              goto label_6;
          }
        }
label_3:
        return;
label_6:;
      }

      /// <summary>
      /// Синхронные действия после выполнения отката транзакции
      /// </summary>
      public List<System.Action> Actions { get; set; }

      /// <summary>
      /// Асинхронные действия после выполнения отката транзакции
      /// </summary>
      public List<System.Func<CancellationToken, Task>> AsyncActions { get; set; }

      public void SetRollBackFlag(string dbName, bool flag)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              ContextVars.Set<bool>(NHUnitOfWorkManager.UnitOfWorkContextRollbackHolder.GetKey((object) dbName), flag);
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

      private static string GetKey(object dbName) => (string) NHUnitOfWorkManager.UnitOfWorkContextRollbackHolder.WAPCZ6Qx6Vs287tC7hnS(NHUnitOfWorkManager.UnitOfWorkContextRollbackHolder.g87IfAQx4NMUfqGpWM4D(1051802738 - -1831968059 ^ -1410903967), dbName);

      public bool GetRollBackFlag(string dbName) => ContextVars.GetOrAdd<bool>(NHUnitOfWorkManager.UnitOfWorkContextRollbackHolder.GetKey((object) dbName), (Func<bool>) (() => false));

      internal static bool taGNUUQxDldvs1Ttog0D() => NHUnitOfWorkManager.UnitOfWorkContextRollbackHolder.jhW8ZGQxau4mWS8Lnve8 == null;

      internal static NHUnitOfWorkManager.UnitOfWorkContextRollbackHolder KGnedvQxtmKYbgUHNRRP() => (NHUnitOfWorkManager.UnitOfWorkContextRollbackHolder) NHUnitOfWorkManager.UnitOfWorkContextRollbackHolder.jhW8ZGQxau4mWS8Lnve8;

      internal static void jqjTTXQxwUHQ0PLfvWJm() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static object g87IfAQx4NMUfqGpWM4D(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object WAPCZ6Qx6Vs287tC7hnS([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);
    }

    private class PreCommitActionsHolder
    {
      internal static object V4YlosQxHYg1loHKKsgW;

      public static NHUnitOfWorkManager.PreCommitActionsHolder GetFromContext() => ContextVars.GetOrAdd<NHUnitOfWorkManager.PreCommitActionsHolder>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333442704), (Func<NHUnitOfWorkManager.PreCommitActionsHolder>) (() => new NHUnitOfWorkManager.PreCommitActionsHolder()));

      /// <summary>Ctor</summary>
      private PreCommitActionsHolder()
      {
        NHUnitOfWorkManager.PreCommitActionsHolder.CnthjqQxxil6vUYMPnZc();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            case 2:
              this.AsyncActions = new Queue<System.Func<CancellationToken, Task>>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 1 : 0;
              continue;
            default:
              this.Actions = new Queue<System.Action>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 2 : 0;
              continue;
          }
        }
label_3:;
      }

      /// <summary>Синхронные действия, выполняемые перед коммитом</summary>
      public Queue<System.Action> Actions { get; private set; }

      /// <summary>Асинхронные действия, выполняемые перед коммитом</summary>
      public Queue<System.Func<CancellationToken, Task>> AsyncActions { get; private set; }

      internal static bool MdygMNQxAJuj2kJj9Nt0() => NHUnitOfWorkManager.PreCommitActionsHolder.V4YlosQxHYg1loHKKsgW == null;

      internal static NHUnitOfWorkManager.PreCommitActionsHolder CT0Up9Qx7gDTHCd8x8le() => (NHUnitOfWorkManager.PreCommitActionsHolder) NHUnitOfWorkManager.PreCommitActionsHolder.V4YlosQxHYg1loHKKsgW;

      internal static void CnthjqQxxil6vUYMPnZc() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }

    private class PostCommitActionsHolder
    {
      internal static object Prly3ZQx0a3UHDsjWFY0;

      public static NHUnitOfWorkManager.PostCommitActionsHolder GetFromContext() => ContextVars.GetOrAdd<NHUnitOfWorkManager.PostCommitActionsHolder>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 153786825), (Func<NHUnitOfWorkManager.PostCommitActionsHolder>) (() => new NHUnitOfWorkManager.PostCommitActionsHolder()));

      private PostCommitActionsHolder()
      {
        NHUnitOfWorkManager.PostCommitActionsHolder.ykdngdQxM20OuI7cs004();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.AsyncActions = new List<System.Func<CancellationToken, Task>>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
              continue;
            case 2:
              this.Actions = new List<System.Action>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 1 : 1;
              continue;
            default:
              goto label_6;
          }
        }
label_3:
        return;
label_6:;
      }

      /// <summary>Синхронные действия, выполняемые после коммитом</summary>
      public List<System.Action> Actions { get; set; }

      /// <summary>Асинхронные действия, выполняемые после коммита</summary>
      public List<System.Func<CancellationToken, Task>> AsyncActions { get; private set; }

      internal static bool YXiLVaQxmmPXrbYZ39P7() => NHUnitOfWorkManager.PostCommitActionsHolder.Prly3ZQx0a3UHDsjWFY0 == null;

      internal static NHUnitOfWorkManager.PostCommitActionsHolder GCodcvQxyjOeqnojsmH7() => (NHUnitOfWorkManager.PostCommitActionsHolder) NHUnitOfWorkManager.PostCommitActionsHolder.Prly3ZQx0a3UHDsjWFY0;

      internal static void ykdngdQxM20OuI7cs004() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
