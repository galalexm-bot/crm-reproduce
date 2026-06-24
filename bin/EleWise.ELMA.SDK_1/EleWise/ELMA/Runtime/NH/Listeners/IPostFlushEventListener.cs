// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.Listeners.IPostFlushEventListener
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using NHibernate.Event;

namespace EleWise.ELMA.Runtime.NH.Listeners
{
  /// <summary>
  /// Точка расширения для прослушивания событий NHibernate после их выполнения
  /// </summary>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  public interface IPostFlushEventListener
  {
    /// <summary>После вставки</summary>
    /// <param name="event">Параметры события</param>
    void OnPostInsert(PostInsertEvent @event);

    /// <summary>После обновления</summary>
    /// <param name="event">Параметры события</param>
    void OnPostUpdate(PostUpdateEvent @event);

    /// <summary>После удаления</summary>
    /// <param name="event">Параметры события</param>
    void OnPostDelete(PostDeleteEvent @event);

    /// <summary>После обновления элемента в коллекции</summary>
    /// <param name="event">Параметры события</param>
    void OnPostUpdateCollection(PostCollectionUpdateEvent @event);
  }
}
