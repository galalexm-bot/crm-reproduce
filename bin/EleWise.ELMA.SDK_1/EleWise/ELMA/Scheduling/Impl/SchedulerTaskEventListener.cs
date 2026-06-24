// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.Impl.SchedulerTaskEventListener
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Scheduling;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Scheduling.Models;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Scheduling.Impl
{
  /// <summary>
  /// Класс для прослушивания событий NHibernate после их выполнения, относящихся к сущностям ISchedulerTask
  /// </summary>
  [Component]
  internal sealed class SchedulerTaskEventListener : PostFlushEventListener
  {
    private readonly IActorModelRuntime actorModelRuntime;
    private readonly IUnitOfWorkManager unitOfWorkManager;
    private readonly ContextVars.Local<bool> needRefresh;
    internal static SchedulerTaskEventListener gJUcw1BkKw6Ltp4N8mU3;

    /// <summary>Ctor</summary>
    /// <param name="actorModelRuntime">Среда исполнения акторов</param>
    /// <param name="unitOfWorkManager">Менеджер единиц работы</param>
    public SchedulerTaskEventListener(
      IActorModelRuntime actorModelRuntime,
      IUnitOfWorkManager unitOfWorkManager)
    {
      SchedulerTaskEventListener.tjtEyoBkkYq8eBNIXurM();
      this.needRefresh = new ContextVars.Local<bool>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.actorModelRuntime = actorModelRuntime;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
            continue;
          default:
            this.unitOfWorkManager = unitOfWorkManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 0;
            continue;
        }
      }
label_2:;
    }

    /// <inheritdoc />
    public override void OnPostInsert(PostInsertEvent @event)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Refresh(@event.Entity as ISchedulerTask);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
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
    public override void OnPostUpdate(PostUpdateEvent @event)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Refresh(SchedulerTaskEventListener.NIpIASBkn1HwjUODQJfX((object) @event) as ISchedulerTask);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
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
    public override void OnPostDelete(PostDeleteEvent @event)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Refresh(@event.Entity as ISchedulerTask);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
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
    /// Обновить данные в <see cref="T:EleWise.ELMA.ActorModel.Scheduling.ISchedulerJobDbRepositoryActor" />
    /// </summary>
    /// <param name="schedulerTask">Задача планировщика</param>
    private void Refresh(ISchedulerTask schedulerTask)
    {
      int num1 = 3;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_2;
          case 1:
            SchedulerTaskEventListener.gwbEwTBkOvMZS86kAm7Q((object) this.unitOfWorkManager, (object) (System.Action) (() =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    this.actorModelRuntime.GetActor<ISchedulerJobDbRepositoryActor>(Guid.Empty).Refresh();
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
            continue;
          case 2:
            if (!this.needRefresh.Value)
            {
              this.needRefresh.Value = true;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 1 : 1;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 4 : 1;
            continue;
          case 3:
            if (schedulerTask != null)
            {
              num1 = 2;
              continue;
            }
            goto label_11;
          case 4:
            goto label_3;
          default:
            goto label_10;
        }
      }
label_2:
      return;
label_3:
      return;
label_10:
      return;
label_11:;
    }

    internal static void tjtEyoBkkYq8eBNIXurM() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool MyTU9NBkXRYWt5h6eyUA() => SchedulerTaskEventListener.gJUcw1BkKw6Ltp4N8mU3 == null;

    internal static SchedulerTaskEventListener uMD2xXBkT8O11kkuD23N() => SchedulerTaskEventListener.gJUcw1BkKw6Ltp4N8mU3;

    internal static object NIpIASBkn1HwjUODQJfX([In] object obj0) => ((AbstractPostDatabaseOperationEvent) obj0).Entity;

    internal static void gwbEwTBkOvMZS86kAm7Q([In] object obj0, [In] object obj1) => ((IUnitOfWorkManager) obj0).RegisterPostCommitAction((System.Action) obj1);
  }
}
