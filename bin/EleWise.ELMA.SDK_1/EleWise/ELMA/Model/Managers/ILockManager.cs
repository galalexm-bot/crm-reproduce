// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Managers.ILockManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Model.Managers
{
  /// <summary>Интерфейс менеджера блокировок</summary>
  [DeveloperApi(DeveloperApiType.Service)]
  public interface ILockManager
  {
    /// <summary>Получить блокировку</summary>
    /// <param name="lockName">Имя блокировки</param>
    /// <returns>Блокировка</returns>
    IDisposable Lock(string lockName);

    /// <summary>Получить блокировку</summary>
    /// <param name="lockName">Имя блокировки</param>
    /// <param name="timeout">Таймаут в секундах</param>
    /// <returns>Блокировка</returns>
    IDisposable Lock(string lockName, int timeout);

    /// <summary>Попытаться получить блокировку</summary>
    /// <param name="lockName">Имя блокивроки</param>
    /// <param name="lock">Блокировка</param>
    /// <returns>true - в случае успеха</returns>
    bool TryLock(string lockName, out IDisposable @lock);

    /// <summary>Попытаться получить блокировку</summary>
    /// <param name="lockName">Имя блокировки</param>
    /// <param name="timeout">Таймаут в секундах</param>
    /// <param name="lock">Блокировка</param>
    /// <returns>true - в случае успеха</returns>
    bool TryLock(string lockName, int timeout, out IDisposable @lock);

    /// <summary>Получить блокировку</summary>
    /// <param name="lockName">Имя блокировки</param>
    /// <param name="token">Токен отмены</param>
    /// <returns>Блокировка</returns>
    Task<IDisposable> LockAsync(string lockName, CancellationToken token = default (CancellationToken));

    /// <summary>Получить блокировку</summary>
    /// <param name="lockName">Имя блокировки</param>
    /// <param name="timeout">Таймаут в секундах</param>
    /// <param name="token">Токен отмены</param>
    /// <returns>Блокировка</returns>
    Task<IDisposable> LockAsync(string lockName, int timeout, CancellationToken token = default (CancellationToken));

    /// <summary>Попытаться получить блокировку</summary>
    /// <param name="lockName">Имя блокивроки</param>
    /// <param name="token">Токен отмены</param>
    /// <returns>Блокировка - в случае успеха, иначе null</returns>
    Task<IDisposable> TryLockAsync(string lockName, CancellationToken token = default (CancellationToken));

    /// <summary>Попытаться получить блокировку</summary>
    /// <param name="lockName">Имя блокировки</param>
    /// <param name="timeout">Таймаут в секундах</param>
    /// <param name="token">Токен отмены</param>
    /// <returns>Блокировка - в случае успеха, иначе null</returns>
    Task<IDisposable> TryLockAsync(string lockName, int timeout, CancellationToken token = default (CancellationToken));
  }
}
