// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Audit.Impl.BaseEntityActionUnitOfWorkListener
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Events.Audit.Impl
{
  public abstract class BaseEntityActionUnitOfWorkListener : IUnitOfWorkEventListener
  {
    private readonly IContextBoundVariableService contextBoundVariableService;
    private readonly ISessionProvider sessionProvider;
    private readonly ILogger logger;
    internal static BaseEntityActionUnitOfWorkListener nDS3v9GsmNlwIMjHFslX;

    /// <summary>Интерфейс провайдера преобразования БД</summary>
    public ITransformationProvider Transform
    {
      get => this.\u003CTransform\u003Ek__BackingField;
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
              this.\u003CTransform\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
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

    /// <summary>Ctor</summary>
    /// <param name="contextBoundVariableService"></param>
    /// <param name="sessionProvider"></param>
    /// <param name="logger"></param>
    public BaseEntityActionUnitOfWorkListener(
      [NotNull] IContextBoundVariableService contextBoundVariableService,
      [NotNull] ISessionProvider sessionProvider,
      [NotNull] ILogger logger)
    {
      BaseEntityActionUnitOfWorkListener.OQ3AGhGsJV4XR0RaYAya();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (contextBoundVariableService == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 4 : 5;
              continue;
            }
            if (sessionProvider == null)
            {
              num = 3;
              continue;
            }
            if (logger == null)
            {
              num = 4;
              continue;
            }
            this.contextBoundVariableService = contextBoundVariableService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
            continue;
          case 2:
            this.logger = logger;
            num = 6;
            continue;
          case 3:
            goto label_10;
          case 4:
            goto label_14;
          case 5:
            goto label_7;
          case 6:
            goto label_3;
          default:
            this.sessionProvider = sessionProvider;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 2;
            continue;
        }
      }
label_3:
      return;
label_7:
      throw new ArgumentNullException((string) BaseEntityActionUnitOfWorkListener.gLa6UEGs90bmTcrADK0D(1642859704 ^ 1642598904));
label_10:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-649342099 - -1150814748 ^ 501728155));
label_14:
      throw new ArgumentNullException((string) BaseEntityActionUnitOfWorkListener.gLa6UEGs90bmTcrADK0D(-1426456882 ^ 2009939514 ^ -583600770));
    }

    public void OnStartUnitofWork(IUnitOfWork unitOfWork)
    {
    }

    public void OnPreFlushUnitofWork(IUnitOfWork unitOfWork, IEnumerable<object> entities)
    {
    }

    public void OnPostFlushUnitofWork(IUnitOfWork unitOfWork)
    {
    }

    public void OnPreCommitUnitofWork(IUnitOfWork unitOfWork)
    {
      switch (1)
      {
        case 1:
          try
          {
            ISession session = (ISession) BaseEntityActionUnitOfWorkListener.y2nkieGsddM7mGryI5RK((object) this.SessionProvider, (object) "");
            int num1 = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
              num1 = 0;
            while (true)
            {
              IList<EntityActionEventArgs> list;
              IEnumerator<EntityActionEventArgs> enumerator;
              Guid guid1;
              Guid guid2;
              switch (num1)
              {
                case 0:
                  goto label_34;
                case 1:
                  list = this.GetContextEventList();
                  num1 = 10;
                  continue;
                case 2:
                  goto label_25;
                case 3:
label_7:
                  if (!BaseEntityActionUnitOfWorkListener.MNTk1MGsLOA3Lr8PpCYH((object) session))
                  {
                    num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 1 : 2;
                    continue;
                  }
                  goto case 8;
                case 4:
                  guid2 = BaseEntityActionUnitOfWorkListener.zIJpKLGsrOsUbr1DnK9L((object) unitOfWork);
                  break;
                case 5:
                  if (unitOfWork != null)
                  {
                    num1 = 4;
                    continue;
                  }
                  goto case 7;
                case 6:
                  try
                  {
label_11:
                    if (BaseEntityActionUnitOfWorkListener.IAqitPGsjJkYQUZr8loG((object) enumerator))
                      goto label_13;
                    else
                      goto label_12;
label_10:
                    EntityActionEventArgs current;
                    int num2;
                    while (true)
                    {
                      switch (num2)
                      {
                        case 1:
                          BaseEntityActionUnitOfWorkListener.lXB6htGs5ugvyffxBHpN((object) this, (object) current);
                          num2 = 5;
                          continue;
                        case 2:
                          if (current == null)
                          {
                            num2 = 3;
                            continue;
                          }
                          break;
                        case 3:
                        case 5:
                          goto label_11;
                        case 4:
                          goto label_7;
                        case 6:
                          goto label_13;
                      }
                      BaseEntityActionUnitOfWorkListener.pZmqo8GsgwbFyLHrfr6a((object) current, guid1);
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 1 : 0;
                    }
label_12:
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 4 : 3;
                    goto label_10;
label_13:
                    current = enumerator.Current;
                    num2 = 2;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
                    {
                      num2 = 2;
                      goto label_10;
                    }
                    else
                      goto label_10;
                  }
                  finally
                  {
                    if (enumerator != null)
                    {
                      int num3 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
                        num3 = 0;
                      while (true)
                      {
                        switch (num3)
                        {
                          case 1:
                            goto label_27;
                          default:
                            BaseEntityActionUnitOfWorkListener.koc7YjGsYRp1eu6r2LvC((object) enumerator);
                            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 1;
                            continue;
                        }
                      }
                    }
label_27:;
                  }
                case 7:
                  guid2 = BaseEntityActionUnitOfWorkListener.iVoklnGslioFQymwJLtu();
                  break;
                case 8:
                  BaseEntityActionUnitOfWorkListener.NqKNEyGsUoSlc9VNrr3r((object) session);
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 0;
                  continue;
                case 9:
                  enumerator = list.GetEnumerator();
                  num1 = 6;
                  continue;
                case 10:
                  list = this.PrepareEventsList(list);
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 5 : 2;
                  continue;
                default:
                  goto label_20;
              }
              guid1 = guid2;
              num1 = 9;
            }
label_34:
            break;
label_25:
            break;
label_20:
            break;
          }
          catch (Exception ex)
          {
            int num = 2;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_41;
                case 2:
                  this.Logger.Error((object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289451938)), ex);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
                  continue;
                default:
                  if (BaseEntityActionUnitOfWorkListener.sUbMrHGss9rwnA2M8rNo((object) this.Transform, (object) ex))
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 0;
                    continue;
                  }
                  goto label_19;
              }
            }
label_19:
            break;
label_41:
            throw;
          }
      }
    }

    public void OnPostCommitUnitofWork(IUnitOfWork unitOfWork)
    {
    }

    public void OnPostRollbackUnitofWork(IUnitOfWork unitOfWork)
    {
    }

    public void OnDisposeUnitofWork(IUnitOfWork unitOfWork) => this.ClearContextEventList();

    /// <summary>Агрегаторы событий</summary>
    protected IEnumerable<IEntityActionEventAggregator> Aggregators => this.contextBoundVariableService.GetOrAdd<IEnumerable<IEntityActionEventAggregator>>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 153816129), (Func<IEnumerable<IEntityActionEventAggregator>>) (() => ComponentManager.Current.GetExtensionPoints<IEntityActionEventAggregator>()));

    /// <summary>Провайдер сессий NHibernate</summary>
    protected ISessionProvider SessionProvider => this.sessionProvider;

    /// <summary>Логгер</summary>
    protected ILogger Logger => this.logger;

    /// <summary>
    /// Ключ значения в IContextBoundVariableService, содержащий список событий с сущностью, который нужно обработать
    /// </summary>
    protected abstract string EventListContextKey { get; }

    /// <summary>Сохранить событие</summary>
    /// <param name="e"></param>
    protected abstract void PersistEvent(EntityActionEventArgs e);

    protected virtual IList<EntityActionEventArgs> PrepareEventsList(
      IList<EntityActionEventArgs> list)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return (IList<EntityActionEventArgs>) ((IEnumerable<ActionEventAggregatorResult>) this.Aggregators.Aggregate<IEntityActionEventAggregator, ActionEventAggregatorResult[]>(new ActionEventAggregatorResult[0], (Func<ActionEventAggregatorResult[], IEntityActionEventAggregator, ActionEventAggregatorResult[]>) ((current, aggregator) => ((IEnumerable<ActionEventAggregatorResult>) current).Union<ActionEventAggregatorResult>(aggregator.Aggregate(list, (IEnumerable<ActionEventAggregatorResult>) current)).ToArray<ActionEventAggregatorResult>()))).Where<ActionEventAggregatorResult>((Func<ActionEventAggregatorResult, bool>) (r => BaseEntityActionUnitOfWorkListener.\u003C\u003Ec.ke5S8d8IDur4i38tYK8E((object) r))).Select<ActionEventAggregatorResult, EntityActionEventArgs>((Func<ActionEventAggregatorResult, EntityActionEventArgs>) (r => (EntityActionEventArgs) BaseEntityActionUnitOfWorkListener.\u003C\u003Ec.RfnAYS8ItbnZi14fOsVB((object) r))).Distinct<EntityActionEventArgs>().OrderBy<EntityActionEventArgs, DateTime>((Func<EntityActionEventArgs, DateTime>) (e => e.ActionDate)).ToList<EntityActionEventArgs>();
    }

    private IList<EntityActionEventArgs> GetContextEventList() => (IList<EntityActionEventArgs>) this.contextBoundVariableService.GetOrAdd<List<EntityActionEventArgs>>(this.EventListContextKey, (Func<List<EntityActionEventArgs>>) (() => new List<EntityActionEventArgs>()));

    private void ClearContextEventList()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            BaseEntityActionUnitOfWorkListener.vXSdIOGszlq5yJ0psggD((object) this.contextBoundVariableService, BaseEntityActionUnitOfWorkListener.RUa8ghGsck2FqnastY5g((object) this), (object) new List<EntityActionEventArgs>());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static bool eEubSNGsyYWkLLa9HOMx() => BaseEntityActionUnitOfWorkListener.nDS3v9GsmNlwIMjHFslX == null;

    internal static BaseEntityActionUnitOfWorkListener nWfX3oGsMUFOyFbF1aUm() => BaseEntityActionUnitOfWorkListener.nDS3v9GsmNlwIMjHFslX;

    internal static void OQ3AGhGsJV4XR0RaYAya() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object gLa6UEGs90bmTcrADK0D(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object y2nkieGsddM7mGryI5RK([In] object obj0, [In] object obj1) => (object) ((ISessionProvider) obj0).GetSession((string) obj1);

    internal static Guid iVoklnGslioFQymwJLtu() => Guid.NewGuid();

    internal static Guid zIJpKLGsrOsUbr1DnK9L([In] object obj0) => ((IUnitOfWork) obj0).Uid;

    internal static void pZmqo8GsgwbFyLHrfr6a([In] object obj0, Guid value) => ((EntityActionEventArgs) obj0).UnitOfWorkUid = value;

    internal static void lXB6htGs5ugvyffxBHpN([In] object obj0, [In] object obj1) => ((BaseEntityActionUnitOfWorkListener) obj0).PersistEvent((EntityActionEventArgs) obj1);

    internal static bool IAqitPGsjJkYQUZr8loG([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void koc7YjGsYRp1eu6r2LvC([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool MNTk1MGsLOA3Lr8PpCYH([In] object obj0) => ((ISession) obj0).IsDirty();

    internal static void NqKNEyGsUoSlc9VNrr3r([In] object obj0) => ((ISession) obj0).Flush();

    internal static bool sUbMrHGss9rwnA2M8rNo([In] object obj0, [In] object obj1) => ((ITransformationProvider) obj0).IsUnrecoverableException((Exception) obj1);

    internal static object RUa8ghGsck2FqnastY5g([In] object obj0) => (object) ((BaseEntityActionUnitOfWorkListener) obj0).EventListContextKey;

    internal static void vXSdIOGszlq5yJ0psggD([In] object obj0, [In] object obj1, [In] object obj2) => ((IAbstractBoundVariableService) obj0).Set((string) obj1, obj2);
  }
}
