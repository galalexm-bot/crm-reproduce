// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Audit.Impl.BaseEntityUpdateEventAggregator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Events.Audit.Impl
{
  /// <summary>
  /// Базовый класс для агрегаторов событий с объектами.
  /// Позволяет упростить обработку дополнительного события "Изменение"
  /// </summary>
  /// <remarks>
  /// <see href="http://www.elma-bpm.ru/kb/article-104.html">Пример реализации в базе знаний</see>
  /// </remarks>
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  public abstract class BaseEntityUpdateEventAggregator : IEntityActionEventAggregator
  {
    internal static BaseEntityUpdateEventAggregator rFGkr5GcvolBOt70NxA0;

    /// <summary>
    /// Initializes a new instance of the <see cref="T:System.Object" /> class.
    /// </summary>
    protected BaseEntityUpdateEventAggregator()
    {
      BaseEntityUpdateEventAggregator.dCcpRqGcuYTeqQbxeVoa();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Logger = (ILogger) BaseEntityUpdateEventAggregator.oR4w5gGcIU3DcPWiI72L();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Текущий логгер</summary>
    public ILogger Logger
    {
      get => this.\u003CLogger\u003Ek__BackingField;
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
              this.\u003CLogger\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
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

    /// <summary>
    /// Список идентификаторов действий, которые должны быть обработаны данным аггрегатором
    /// </summary>
    protected abstract IEnumerable<Guid> ProcessedActions { get; }

    protected virtual IEnumerable<Guid> MergeOldEntityActions => (IEnumerable<Guid>) new BaseEntityUpdateEventAggregator.\u003Cget_MergeOldEntityActions\u003Ed__8(-2);

    /// <summary>
    /// Проверяет, подходит ли событие для обработки аггрегатором
    /// </summary>
    /// <param name="event">Событие</param>
    /// <returns><c>true</c>, если событие удовлетворяет условиям</returns>
    protected virtual bool IsProcessedAction(EntityActionEventArgs @event)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (@event == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
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
      return this.ProcessedActions.Contains<Guid>(BaseEntityUpdateEventAggregator.wylGS0GcSvFcW2XcvdWh(BaseEntityUpdateEventAggregator.EokPAQGcV6J2NKGRSG9q((object) @event)));
label_5:
      return false;
    }

    /// <summary>
    /// Проверяет, является ли событие объединяемым для текущего обрабатываемого события
    /// </summary>
    /// <param name="event">Проверяемое событие</param>
    /// <param name="processEvent">Текущее событие</param>
    /// <returns><c>true</c>, если события можно объединять</returns>
    protected virtual bool IsMergeAction(
      EntityActionEventArgs @event,
      EntityActionEventArgs processEvent)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!this.MergeOldEntityActions.Contains<Guid>(BaseEntityUpdateEventAggregator.wylGS0GcSvFcW2XcvdWh(BaseEntityUpdateEventAggregator.EokPAQGcV6J2NKGRSG9q((object) @event))))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
                continue;
              }
              goto case 6;
            case 2:
              if (@event != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 1;
                continue;
              }
              goto label_4;
            case 5:
              if (processEvent != null)
                goto case 2;
              else
                goto label_12;
            case 6:
              if (!BaseEntityUpdateEventAggregator.OGyAnhGcqgVYNE7b5fkW(BaseEntityUpdateEventAggregator.EaQ1QpGcR93En8wxdX4O(BaseEntityUpdateEventAggregator.j9DhrgGcijSY9Eeg3hc4((object) @event)), BaseEntityUpdateEventAggregator.EaQ1QpGcR93En8wxdX4O((object) processEvent.Object)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 3;
                continue;
              }
              goto label_3;
            case 7:
              goto label_3;
            default:
              goto label_4;
          }
        }
label_12:
        num1 = 4;
      }
label_3:
      return BaseEntityUpdateEventAggregator.h2NOPdGcXosbdYTHLggg(BaseEntityUpdateEventAggregator.dLW5YeGcKVWcd8SCM7lS((object) @event)).Equals(BaseEntityUpdateEventAggregator.h2NOPdGcXosbdYTHLggg(BaseEntityUpdateEventAggregator.dLW5YeGcKVWcd8SCM7lS((object) processEvent)));
label_4:
      return false;
    }

    /// <summary>Объединить события и записать результат выполнения</summary>
    /// <param name="eventResult">Результат с текущим событием</param>
    /// <param name="mergeEvent">Объединяемое событие</param>
    protected virtual void MergeEventResult(
      ActionEventAggregatorResult eventResult,
      EntityActionEventArgs mergeEvent)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (eventResult != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
              continue;
            }
            goto label_11;
          case 2:
            this.MergeEventData((EntityActionEventArgs) BaseEntityUpdateEventAggregator.dvmVotGcTNly3mqEKZm0((object) eventResult), mergeEvent);
            num = 3;
            continue;
          case 3:
            goto label_10;
          case 4:
            goto label_12;
          case 5:
            if (mergeEvent == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 4 : 4;
              continue;
            }
            goto case 2;
          default:
            if (BaseEntityUpdateEventAggregator.dvmVotGcTNly3mqEKZm0((object) eventResult) != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 4 : 5;
              continue;
            }
            goto label_2;
        }
      }
label_10:
      return;
label_12:
      return;
label_2:
      return;
label_11:;
    }

    /// <summary>Объединить данные в событиях</summary>
    /// <param name="event">Текущее событие</param>
    /// <param name="mergeEvent">Объединяемое событие</param>
    protected virtual void MergeEventData(
      [NotNull] EntityActionEventArgs @event,
      [NotNull] EntityActionEventArgs mergeEvent)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            BaseEntityUpdateEventAggregator.o4QCY9Gcka4e2KPtOHvV((object) @event, (object) mergeEvent.Old);
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

    /// <summary>
    /// Аггрегировать события в списке (убрать дублирующие, объединить общие события)
    /// </summary>
    /// <param name="eventList">Текущий список событий в рамках транзакции</param>
    /// <param name="previousResults">Список результатов выполнения предыдущих аггрегаторов</param>
    /// <returns>Результаты выполнения</returns>
    public IEnumerable<ActionEventAggregatorResult> Aggregate(
      IList<EntityActionEventArgs> eventList,
      IEnumerable<ActionEventAggregatorResult> previousResults)
    {
      try
      {
        foreach (ActionEventAggregatorResult aggregatorResult in previousResults.Where<ActionEventAggregatorResult>((Func<ActionEventAggregatorResult, bool>) (r => BaseEntityUpdateEventAggregator.id8ChuGcnYBNBoN8pQ10((object) this, (object) r.EventArgs))).ToList<ActionEventAggregatorResult>())
        {
          ActionEventAggregatorResult eventResult = aggregatorResult;
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          foreach (EntityActionEventArgs mergeEvent in eventList.Where<EntityActionEventArgs>((Func<EntityActionEventArgs, bool>) (e => BaseEntityUpdateEventAggregator.\u003C\u003Ec__DisplayClass13_0.d6Iklw8VGIBT5aVlY6hv((object) this, (object) e, BaseEntityUpdateEventAggregator.\u003C\u003Ec__DisplayClass13_0.WhJCtR8Vhj9IV3Sb2mmt((object) eventResult)))).ToList<EntityActionEventArgs>())
            this.MergeEventResult(eventResult, mergeEvent);
        }
      }
      catch (Exception ex)
      {
        this.Logger.Error((object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137718656)), ex);
      }
      return Enumerable.Empty<ActionEventAggregatorResult>();
    }

    internal static void dCcpRqGcuYTeqQbxeVoa() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object oR4w5gGcIU3DcPWiI72L() => (object) NullLogger.Instance;

    internal static bool V6UHM7Gc8jlVX7YSLaeR() => BaseEntityUpdateEventAggregator.rFGkr5GcvolBOt70NxA0 == null;

    internal static BaseEntityUpdateEventAggregator JX6eCWGcZ8oVkLmcGtqs() => BaseEntityUpdateEventAggregator.rFGkr5GcvolBOt70NxA0;

    internal static object EokPAQGcV6J2NKGRSG9q([In] object obj0) => (object) ((AuditEventArgs) obj0).Action;

    internal static Guid wylGS0GcSvFcW2XcvdWh([In] object obj0) => ((IAuditAction) obj0).Uid;

    internal static object j9DhrgGcijSY9Eeg3hc4([In] object obj0) => (object) ((AuditEventArgs) obj0).Object;

    internal static Guid EaQ1QpGcR93En8wxdX4O([In] object obj0) => ((IAuditObject) obj0).Uid;

    internal static bool OGyAnhGcqgVYNE7b5fkW([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object dLW5YeGcKVWcd8SCM7lS([In] object obj0) => (object) ((EntityActionEventArgs) obj0).New;

    internal static object h2NOPdGcXosbdYTHLggg([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static object dvmVotGcTNly3mqEKZm0([In] object obj0) => (object) ((ActionEventAggregatorResult) obj0).EventArgs;

    internal static void o4QCY9Gcka4e2KPtOHvV([In] object obj0, [In] object obj1) => ((EntityActionEventArgs) obj0).Old = (IEntity) obj1;

    internal static bool id8ChuGcnYBNBoN8pQ10([In] object obj0, [In] object obj1) => ((BaseEntityUpdateEventAggregator) obj0).IsProcessedAction((EntityActionEventArgs) obj1);
  }
}
