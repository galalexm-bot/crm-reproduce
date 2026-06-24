// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ActorModel.Abstractions.IActorModelRuntime
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Threading.Tasks;

namespace EleWise.ELMA.ActorModel.Abstractions
{
  /// <summary>Интерфейс Модели Акторов.</summary>
  public interface IActorModelRuntime
  {
    /// <summary>Возвращает Актор по заданному ключу.</summary>
    /// <typeparam name="TActorInterface">Интерфейс Актора.</typeparam>
    /// <param name="primaryKey">Ключ Актора.</param>
    /// <returns>Ссылка на Актор.</returns>
    TActorInterface GetActor<TActorInterface>(long primaryKey) where TActorInterface : IActorWithIntegerKey;

    /// <summary>Возвращает Актор по заданному ключу.</summary>
    /// <typeparam name="TActorInterface">Интерфейс Актора.</typeparam>
    /// <param name="primaryKey">Ключ Актора.</param>
    /// <returns>Ссылка на Актор.</returns>
    TActorInterface GetActor<TActorInterface>(string primaryKey) where TActorInterface : IActorWithStringKey;

    /// <summary>Возвращает Актор по заданному ключу.</summary>
    /// <typeparam name="TActorInterface">Интерфейс Актора.</typeparam>
    /// <param name="primaryKey">Ключ Актора.</param>
    /// <returns>Ссылка на Актор.</returns>
    TActorInterface GetActor<TActorInterface>(Guid primaryKey) where TActorInterface : IActorWithGuidKey;

    /// <summary>Возвращает Актор по заданному ключу.</summary>
    /// <typeparam name="TActorInterface">Интерфейс Актора.</typeparam>
    /// <param name="primaryKey">Guid-часть ключа Актора.</param>
    /// <param name="keyExtension">Строковая часть ключа Актора.</param>
    /// <returns>Ссылка на Актор.</returns>
    TActorInterface GetActor<TActorInterface>(Guid primaryKey, string keyExtension) where TActorInterface : IActorWithGuidCompoundKey;

    /// <summary>Подписывается на Cобытие.</summary>
    /// <typeparam name="T">Тип данных, передаваемых в событии.</typeparam>
    /// <param name="eventId">Идентификатор события.</param>
    /// <param name="eventNamespace">Пространство имен события.</param>
    /// <param name="onPublish">Обработчик события.</param>
    /// <returns>Подписка.</returns>
    Task<ISubscription> Subscribe<T>(Guid eventId, string eventNamespace, Func<T, Task> onPublish);

    /// <summary>Публикует событие.</summary>
    /// <typeparam name="T">Тип данных, передаваемых в событии.</typeparam>
    /// <param name="eventId">Идентификатор события.</param>
    /// <param name="eventNamespace">Пространство имен события.</param>
    /// <param name="data">Данные события.</param>
    /// <returns>Задача.</returns>
    Task Publish<T>(Guid eventId, string eventNamespace, T data);
  }
}
