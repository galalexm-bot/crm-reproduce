// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ActorModel.Abstractions.IServerPlacementPublishService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EleWise.ELMA.ActorModel.Abstractions
{
  /// <summary>
  /// Сервис публикации действия на всех серверах кластера ELMA
  /// </summary>
  public interface IServerPlacementPublishService
  {
    /// <summary>Публикация действия на всех серверах кластера ELMA</summary>
    /// <typeparam name="T">Тип актора</typeparam>
    /// <param name="action">Действие</param>
    /// <param name="ignoreError">Игнорировать ошибки</param>
    /// <param name="errorAction">Действие при ошибке (может быть <see langword="null" />)</param>
    Task Publish<T>(Func<T, Task> action, bool ignoreError, Action<Guid, Exception> errorAction) where T : IServerPlacementActor;

    /// <summary>Публикация действия на всех серверах кластера ELMA</summary>
    /// <typeparam name="T">Тип актора</typeparam>
    /// <typeparam name="TRes">Тип результата</typeparam>
    /// <param name="action">Действие</param>
    /// <param name="ignoreError">Игнорировать ошибки</param>
    /// <param name="errorAction">Действие при ошибке (может быть <see langword="null" />)</param>
    /// <returns>Ответы от серверов</returns>
    Task<IReadOnlyDictionary<Guid, TRes>> Publish<T, TRes>(
      Func<T, Task<TRes>> action,
      bool ignoreError,
      Action<Guid, Exception> errorAction)
      where T : IServerPlacementActor;
  }
}
