// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.Listeners.IEntityEventsListener
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using NHibernate.Event;

namespace EleWise.ELMA.Runtime.NH.Listeners
{
  /// <summary>Точка расширения для прослушивания событий NHibernate</summary>
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  [ExtensionPoint(ServiceScope.Shell, ComponentType.Server | ComponentType.Test)]
  public interface IEntityEventsListener
  {
    /// <summary>Перед вставкой</summary>
    /// <param name="event">Параметры события</param>
    /// <returns><c>true</c>, если нужно первать операцию</returns>
    bool OnPreInsert(PreInsertEvent @event);

    /// <summary>После вставки</summary>
    /// <param name="event">Параметры события</param>
    void OnPostInsert(PostInsertEvent @event);

    /// <summary>Перед обновлением</summary>
    /// <param name="event">Параметры события</param>
    /// <returns><c>true</c>, если нужно первать операцию</returns>
    bool OnPreUpdate(PreUpdateEvent @event);

    /// <summary>После обновления</summary>
    /// <param name="event">Параметры события</param>
    void OnPostUpdate(PostUpdateEvent @event);

    /// <summary>После удаления</summary>
    /// <param name="event">Параметры события</param>
    void OnPostDelete(PostDeleteEvent @event);

    /// <summary>Перед удалением</summary>
    /// <param name="event">Параметры события</param>
    /// <returns><c>true</c>, если нужно первать операцию</returns>
    bool OnPreDelete(PreDeleteEvent @event);

    /// <summary>При сбросе данных сессии в базу</summary>
    /// <param name="event">Параметры события</param>
    void OnFlush(FlushEvent @event);

    /// <summary>После удаления элемента в коллекции</summary>
    /// <param name="event">Параметры события</param>
    void OnPostRemoveCollection(PostCollectionRemoveEvent @event);

    /// <summary>После пересоздания элемента в коллекции</summary>
    /// <param name="event">Параметры события</param>
    void OnPostRecreateCollection(PostCollectionRecreateEvent @event);

    /// <summary>После обновления элемента в коллекции</summary>
    /// <param name="event">Параметры события</param>
    void OnPostUpdateCollection(PostCollectionUpdateEvent @event);

    /// <summary>Перед удаления элемента в коллекции</summary>
    /// <param name="event">Параметры события</param>
    void OnPreRemoveCollection(PreCollectionRemoveEvent @event);

    /// <summary>Перед пересозданием элемента в коллекции</summary>
    /// <param name="event">Параметры события</param>
    void OnPreRecreateCollection(PreCollectionRecreateEvent @event);

    /// <summary>Перед обновлением элемента в коллекции</summary>
    /// <param name="event">Параметры события</param>
    void OnPreUpdateCollection(PreCollectionUpdateEvent @event);

    /// <summary>Перед загрузкой</summary>
    /// <param name="event">Параметры события</param>
    void OnPreLoad(PreLoadEvent @event);
  }
}
