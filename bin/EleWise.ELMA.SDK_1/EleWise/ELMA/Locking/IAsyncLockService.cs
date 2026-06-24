// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Locking.IAsyncLockService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Locking
{
  /// <summary>Интерфейс сервиса асинхронных блокировок</summary>
  public interface IAsyncLockService : ILockService
  {
    /// <summary>Попытка захватить блокировку</summary>
    /// <param name="name">Имя блокировки</param>
    /// <param name="maxValidFor">Длительность жизни блокировки. если null - значение берется из настроек провайдера (по умолчанию - 30 мин)</param>
    /// <param name="timeout">Время таймаута в течение которого выполняется попытка захватить блокировку. если null - значение берется из настроек провайдера (по умолчанию - 30 с)</param>
    /// <param name="token">Токен отмены</param>
    /// <returns>Блокировка  - в случае успеха, null - если получить не удалось</returns>
    Task<ILock> TryAcquireLockAsync(
      string name,
      TimeSpan? maxValidFor,
      TimeSpan? timeout,
      CancellationToken token = default (CancellationToken));

    /// <summary>Захватить блокировку</summary>
    /// <param name="name">Имя блокировки</param>
    /// <param name="maxValidFor">Длительность жизни блокировки. если null - значение берется из настроек провайдера (по умолчанию - 30 мин)</param>
    /// <param name="timeout">Время таймаута в течение которого выполняется попытка захватить блокировку. если null - значение берется из настроек провайдера (по умолчанию - 30 с)</param>
    /// <param name="token">Токен отмены</param>
    /// <returns>Блокировка</returns>
    Task<ILock> AcquireLockAsync(
      string name,
      TimeSpan? maxValidFor,
      TimeSpan? timeout,
      CancellationToken token = default (CancellationToken));
  }
}
