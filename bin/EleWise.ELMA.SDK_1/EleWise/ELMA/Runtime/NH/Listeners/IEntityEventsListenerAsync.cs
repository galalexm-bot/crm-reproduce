// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.Listeners.IEntityEventsListenerAsync
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using NHibernate.Event;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime.NH.Listeners
{
  /// <summary>Точка расширения для прослушивания событий NHibernate</summary>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.Server | ComponentType.Test)]
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  public interface IEntityEventsListenerAsync : IEntityEventsListener
  {
    /// <summary>Перед вставкой</summary>
    /// <param name="event">Параметры события</param>
    /// <returns><c>true</c>, если нужно первать операцию</returns>
    /// <param name="cancellationToken">Токен отмены</param>
    Task<bool> OnPreInsertAsync(PreInsertEvent @event, CancellationToken cancellationToken);

    /// <summary>После вставки</summary>
    /// <param name="event">Параметры события</param>
    /// <param name="cancellationToken">Токен отмены</param>
    Task OnPostInsertAsync(PostInsertEvent @event, CancellationToken cancellationToken);

    /// <summary>Перед обновлением</summary>
    /// <param name="event">Параметры события</param>
    /// <returns><c>true</c>, если нужно первать операцию</returns>
    /// <param name="cancellationToken">Токен отмены</param>
    Task<bool> OnPreUpdateAsync(PreUpdateEvent @event, CancellationToken cancellationToken);

    /// <summary>После обновления</summary>
    /// <param name="event">Параметры события</param>
    /// <param name="cancellationToken">Токен отмены</param>
    Task OnPostUpdateAsync(PostUpdateEvent @event, CancellationToken cancellationToken);

    /// <summary>После удаления</summary>
    /// <param name="event">Параметры события</param>
    /// <param name="cancellationToken">Токен отмены</param>
    Task OnPostDeleteAsync(PostDeleteEvent @event, CancellationToken cancellationToken);

    /// <summary>Перед удалением</summary>
    /// <param name="event">Параметры события</param>
    /// <returns><c>true</c>, если нужно первать операцию</returns>
    /// <param name="cancellationToken">Токен отмены</param>
    Task<bool> OnPreDeleteAsync(PreDeleteEvent @event, CancellationToken cancellationToken);

    /// <summary>При сбросе данных сессии в базу</summary>
    /// <param name="event">Параметры события</param>
    /// <param name="cancellationToken">Токен отмены</param>
    Task OnFlushAsync(FlushEvent @event, CancellationToken cancellationToken);

    /// <summary>После удаления элемента в коллекции</summary>
    /// <param name="event">Параметры события</param>
    /// <param name="cancellationToken">Токен отмены</param>
    Task OnPostRemoveCollectionAsync(
      PostCollectionRemoveEvent @event,
      CancellationToken cancellationToken);

    /// <summary>После пересоздания элемента в коллекции</summary>
    /// <param name="event">Параметры события</param>
    /// <param name="cancellationToken">Токен отмены</param>
    Task OnPostRecreateCollectionAsync(
      PostCollectionRecreateEvent @event,
      CancellationToken cancellationToken);

    /// <summary>После обновления элемента в коллекции</summary>
    /// <param name="event">Параметры события</param>
    /// <param name="cancellationToken">Токен отмены</param>
    Task OnPostUpdateCollectionAsync(
      PostCollectionUpdateEvent @event,
      CancellationToken cancellationToken);

    /// <summary>Перед удаления элемента в коллекции</summary>
    /// <param name="event">Параметры события</param>
    /// <param name="cancellationToken">Токен отмены</param>
    Task OnPreRemoveCollectionAsync(
      PreCollectionRemoveEvent @event,
      CancellationToken cancellationToken);

    /// <summary>Перед пересозданием элемента в коллекции</summary>
    /// <param name="event">Параметры события</param>
    /// <param name="cancellationToken">Токен отмены</param>
    Task OnPreRecreateCollectionAsync(
      PreCollectionRecreateEvent @event,
      CancellationToken cancellationToken);

    /// <summary>Перед обновлением элемента в коллекции</summary>
    /// <param name="event">Параметры события</param>
    /// <param name="cancellationToken">Токен отмены</param>
    Task OnPreUpdateCollectionAsync(
      PreCollectionUpdateEvent @event,
      CancellationToken cancellationToken);

    /// <summary>Перед загрузкой</summary>
    /// <param name="event">Параметры события</param>
    /// <param name="cancellationToken">Токен отмены</param>
    Task OnPreLoadAsync(PreLoadEvent @event, CancellationToken cancellationToken);
  }
}
