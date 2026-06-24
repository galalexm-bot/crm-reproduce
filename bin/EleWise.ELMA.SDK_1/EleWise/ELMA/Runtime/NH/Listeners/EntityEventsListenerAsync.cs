// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.Listeners.EntityEventsListenerAsync
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime.NH.Listeners
{
  /// <summary>
  /// Базовый асинхронный класс для прослушивания событий NHibernate
  /// </summary>
  /// <remarks>
  /// Для корректной работы в асинхронном окружение необходимо реализовывать как синхронную, так и асинхронную части.
  /// Например, если Вы реализуете метод OnPreUpdate, то так же должны реализовать и метод OnPreUpdateAsync, в котором
  /// описать асинхронную логику и/или явным образом переиспользовать синхронную
  /// </remarks>
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  public abstract class EntityEventsListenerAsync : 
    EntityEventsListener,
    IEntityEventsListenerAsync,
    IEntityEventsListener
  {
    internal static EntityEventsListenerAsync beS0FvWA2BNnj7GR6kII;

    /// <inheritdoc />
    public virtual Task<bool> OnPreInsertAsync(
      PreInsertEvent @event,
      CancellationToken cancellationToken)
    {
      return Task.FromResult<bool>(false);
    }

    /// <inheritdoc />
    public virtual Task OnPostInsertAsync(
      PostInsertEvent @event,
      CancellationToken cancellationToken)
    {
      return Task.CompletedTask;
    }

    /// <inheritdoc />
    public virtual Task<bool> OnPreUpdateAsync(
      PreUpdateEvent @event,
      CancellationToken cancellationToken)
    {
      return Task.FromResult<bool>(false);
    }

    /// <inheritdoc />
    public virtual Task OnPostUpdateAsync(
      PostUpdateEvent @event,
      CancellationToken cancellationToken)
    {
      return (Task) EntityEventsListenerAsync.ow4vV2WA1lEmlvZpYl6X();
    }

    /// <inheritdoc />
    public virtual Task OnPostDeleteAsync(
      PostDeleteEvent @event,
      CancellationToken cancellationToken)
    {
      return Task.CompletedTask;
    }

    /// <inheritdoc />
    public virtual Task<bool> OnPreDeleteAsync(
      PreDeleteEvent @event,
      CancellationToken cancellationToken)
    {
      return Task.FromResult<bool>(false);
    }

    /// <inheritdoc />
    public virtual Task OnFlushAsync(FlushEvent @event, CancellationToken cancellationToken) => (Task) EntityEventsListenerAsync.ow4vV2WA1lEmlvZpYl6X();

    /// <inheritdoc />
    public virtual Task OnPostRemoveCollectionAsync(
      PostCollectionRemoveEvent @event,
      CancellationToken cancellationToken)
    {
      return (Task) EntityEventsListenerAsync.ow4vV2WA1lEmlvZpYl6X();
    }

    /// <inheritdoc />
    public virtual Task OnPostRecreateCollectionAsync(
      PostCollectionRecreateEvent @event,
      CancellationToken cancellationToken)
    {
      return (Task) EntityEventsListenerAsync.ow4vV2WA1lEmlvZpYl6X();
    }

    /// <inheritdoc />
    public virtual Task OnPostUpdateCollectionAsync(
      PostCollectionUpdateEvent @event,
      CancellationToken cancellationToken)
    {
      return Task.CompletedTask;
    }

    /// <inheritdoc />
    public virtual Task OnPreRemoveCollectionAsync(
      PreCollectionRemoveEvent @event,
      CancellationToken cancellationToken)
    {
      return (Task) EntityEventsListenerAsync.ow4vV2WA1lEmlvZpYl6X();
    }

    /// <inheritdoc />
    public virtual Task OnPreRecreateCollectionAsync(
      PreCollectionRecreateEvent @event,
      CancellationToken cancellationToken)
    {
      return Task.CompletedTask;
    }

    /// <inheritdoc />
    public virtual Task OnPreUpdateCollectionAsync(
      PreCollectionUpdateEvent @event,
      CancellationToken cancellationToken)
    {
      return (Task) EntityEventsListenerAsync.ow4vV2WA1lEmlvZpYl6X();
    }

    /// <inheritdoc />
    public virtual Task OnPreLoadAsync(PreLoadEvent @event, CancellationToken cancellationToken) => (Task) EntityEventsListenerAsync.ow4vV2WA1lEmlvZpYl6X();

    protected EntityEventsListenerAsync()
    {
      EntityEventsListenerAsync.bjRhfWWAN5r4DvJLw0IB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object ow4vV2WA1lEmlvZpYl6X() => (object) Task.CompletedTask;

    internal static void bjRhfWWAN5r4DvJLw0IB() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Pwt65UWAeSlk28JwwTMG() => EntityEventsListenerAsync.beS0FvWA2BNnj7GR6kII == null;

    internal static EntityEventsListenerAsync lo5wvOWAPY9jPi79xdBm() => EntityEventsListenerAsync.beS0FvWA2BNnj7GR6kII;
  }
}
