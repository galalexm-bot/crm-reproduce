// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.Listeners.EntityEventsListener
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Event;
using System;

namespace EleWise.ELMA.Runtime.NH.Listeners
{
  /// <summary>
  /// Базовый синхронный класс для прослушивания событий NHibernate
  /// </summary>
  /// <remarks>
  /// <see href="http://www.elma-bpm.ru/kb/article-779.html">Пример реализации в базе знаний</see>
  /// </remarks>
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  public class EntityEventsListener : IEntityEventsListener
  {
    private static EntityEventsListener djPf4YWAMRFJII1xYRuS;

    /// <summary>Провайдер сессии NHibernate</summary>
    public ISessionProvider SessionProvider
    {
      get => this.\u003CSessionProvider\u003Ek__BackingField;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
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

    /// <summary>Перед вставкой</summary>
    /// <param name="event">Параметры события</param>
    /// <returns><c>true</c>, если нужно первать операцию</returns>
    public virtual bool OnPreInsert(PreInsertEvent @event) => false;

    /// <summary>После вставки</summary>
    /// <param name="event">Параметры события</param>
    public virtual void OnPostInsert(PostInsertEvent @event)
    {
    }

    /// <summary>Перед обновлением</summary>
    /// <param name="event">Параметры события</param>
    /// <returns><c>true</c>, если нужно первать операцию</returns>
    public virtual bool OnPreUpdate(PreUpdateEvent @event) => false;

    /// <summary>После обновления</summary>
    /// <param name="event">Параметры события</param>
    public virtual void OnPostUpdate(PostUpdateEvent @event)
    {
    }

    /// <summary>Перед удалением</summary>
    /// <param name="event">Параметры события</param>
    /// <returns><c>true</c>, если нужно первать операцию</returns>
    public virtual bool OnPreDelete(PreDeleteEvent @event) => false;

    /// <summary>После удаления</summary>
    /// <param name="event">Параметры события</param>
    public virtual void OnPostDelete(PostDeleteEvent @event)
    {
    }

    /// <summary>После удаления элемента в коллекции</summary>
    /// <param name="event">Параметры события</param>
    public virtual void OnPostRemoveCollection(PostCollectionRemoveEvent @event)
    {
    }

    /// <summary>После пересоздания элемента в коллекции</summary>
    /// <param name="event">Параметры события</param>
    public virtual void OnPostRecreateCollection(PostCollectionRecreateEvent @event)
    {
    }

    /// <summary>После обновления элемента в коллекции</summary>
    /// <param name="event">Параметры события</param>
    public virtual void OnPostUpdateCollection(PostCollectionUpdateEvent @event)
    {
    }

    /// <summary>Перед удаления элемента в коллекции</summary>
    /// <param name="event">Параметры события</param>
    public virtual void OnPreRemoveCollection(PreCollectionRemoveEvent @event)
    {
    }

    /// <summary>Перед пересозданием элемента в коллекции</summary>
    /// <param name="event">Параметры события</param>
    public virtual void OnPreRecreateCollection(PreCollectionRecreateEvent @event)
    {
    }

    /// <summary>Перед обновлением элемента в коллекции</summary>
    /// <param name="event">Параметры события</param>
    public virtual void OnPreUpdateCollection(PreCollectionUpdateEvent @event)
    {
    }

    /// <summary>Перед загрузкой</summary>
    /// <param name="event">Параметры события</param>
    public virtual void OnPreLoad(PreLoadEvent @event)
    {
    }

    /// <summary>
    /// Функция запуска кода в дочерней сесии в обрабочике событий NHibernate,
    /// нужна для исправления ошибок описанных здесь // FIX http://groups.google.com/group/nhibernate-development/browse_thread/thread/c455d8d1a8911c62
    /// </summary>
    /// <param name="event">Параметры события</param>
    /// <param name="action"></param>
    protected void RunInChildSession(AbstractEvent @event, Action<ISession> action)
    {
      IEventSource session1 = @event.Session;
      try
      {
        ISession session2 = session1.GetSession(EntityMode.Poco);
        this.SessionProvider.SetCurrentSession(session2, string.Empty);
        action(session2);
      }
      finally
      {
        this.SessionProvider.SetCurrentSession((ISession) session1, string.Empty);
      }
    }

    /// <summary>При сбросе данных сессии в базу</summary>
    /// <param name="event">Событие</param>
    public virtual void OnFlush(FlushEvent @event)
    {
    }

    public EntityEventsListener()
    {
      EntityEventsListener.XGmEV0WAdO0M89mKyc5P();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool YNkPR1WAJ3qP2nw5bKFx() => EntityEventsListener.djPf4YWAMRFJII1xYRuS == null;

    internal static EntityEventsListener Wv6a0XWA9wWYflssWXo5() => EntityEventsListener.djPf4YWAMRFJII1xYRuS;

    internal static void XGmEV0WAdO0M89mKyc5P() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
