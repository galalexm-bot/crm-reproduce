// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Locking.LockServiceExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Locking
{
  /// <summary>Расширение интерфейса сервиса блокировок</summary>
  public static class LockServiceExtensions
  {
    private static LockServiceExtensions C0xerthrYuoY4yYOyrOq;

    /// <summary>Попытка мгновенного захвата блокировки без таймаута</summary>
    /// <param name="name">Имя блокировки</param>
    /// <param name="maxValidFor">Длительность жизни блокировки. если null - значение берется из настроек провайдера (по умолчанию - 30 мин)</param>
    /// <param name="lock">Блокировка</param>
    /// <returns>True  - в случае успеха</returns>
    public static bool TryAcquireLock(
      this ILockService service,
      string name,
      TimeSpan? maxValidFor,
      out ILock @lock)
    {
      return service.TryAcquireLock(name, maxValidFor, new TimeSpan?(TimeSpan.Zero), out @lock);
    }

    /// <summary>
    /// Попытка захватить блокировку по имени (времена читаются из настроек)
    /// </summary>
    /// <param name="name">Имя блокировки</param>
    /// <param name="lock">Блокировка</param>
    /// <returns>True  - в случае успеха</returns>
    public static bool TryAcquireLock(this ILockService service, string name, out ILock @lock) => service.TryAcquireLock(name, new TimeSpan?(), new TimeSpan?(TimeSpan.Zero), out @lock);

    /// <summary>Захват блокировки (таймаут чиатется из настроек)</summary>
    /// <param name="name">Имя блокировки</param>
    /// <param name="maxValidFor">Длительность жизни блокировки. если null - значение берется из настроек провайдера (по умолчанию - 30 мин)</param>
    /// <returns>Блокировка</returns>
    public static ILock AcquireLock(this ILockService service, string name, TimeSpan? maxValidFor) => service.AcquireLock(name, maxValidFor, new TimeSpan?());

    /// <summary>
    /// Захватить блокировку по имени (времена читаются из настроек)
    /// </summary>
    /// <param name="name">Имя блокировки</param>
    /// <returns>Блокировка</returns>
    public static ILock AcquireLock(this ILockService service, string name) => service.AcquireLock(name, new TimeSpan?(), new TimeSpan?());

    /// <summary>Попытка мгновенного захвата блокировки без таймаута</summary>
    /// <param name="service">Сервис блокировки</param>
    /// <param name="name">Имя блокировки</param>
    /// <param name="maxValidFor">Длительность жизни блокировки. если null - значение берется из настроек провайдера (по умолчанию - 30 мин)</param>
    /// <param name="token">Токен отмены</param>
    /// <returns>Блокировка - в случае успеха</returns>
    public static Task<ILock> TryAcquireLockAsync(
      this IAsyncLockService service,
      string name,
      TimeSpan? maxValidFor,
      CancellationToken token = default (CancellationToken))
    {
      return service.TryAcquireLockAsync(name, maxValidFor, new TimeSpan?(TimeSpan.Zero), token);
    }

    /// <summary>
    /// Попытка захватить блокировку по имени (времена читаются из настроек)
    /// </summary>
    /// <param name="service">Сервис блокировки</param>
    /// <param name="name">Имя блокировки</param>
    /// <param name="token">Токен отмены</param>
    /// <returns>Блокировка - в случае успеха</returns>
    public static Task<ILock> TryAcquireLockAsync(
      this IAsyncLockService service,
      string name,
      CancellationToken token = default (CancellationToken))
    {
      return service.TryAcquireLockAsync(name, new TimeSpan?(), new TimeSpan?(TimeSpan.Zero), token);
    }

    /// <summary>Захват блокировки (таймаут чиатется из настроек)</summary>
    /// <param name="service">Сервис блокировки</param>
    /// <param name="name">Имя блокировки</param>
    /// <param name="maxValidFor">Длительность жизни блокировки. если null - значение берется из настроек провайдера (по умолчанию - 30 мин)</param>
    /// <param name="token">Токен отмены</param>
    /// <returns>Блокировка</returns>
    public static Task<ILock> AcquireLockAsync(
      this IAsyncLockService service,
      string name,
      TimeSpan? maxValidFor,
      CancellationToken token = default (CancellationToken))
    {
      return service.AcquireLockAsync(name, maxValidFor, new TimeSpan?(), token);
    }

    /// <summary>
    /// Захватить блокировку по имени (времена читаются из настроек)
    /// </summary>
    /// <param name="service">Сервис блокировки</param>
    /// <param name="name">Имя блокировки</param>
    /// <param name="token">Токен отмены</param>
    /// <returns>Блокировка</returns>
    public static Task<ILock> AcquireLockAsync(
      this IAsyncLockService service,
      string name,
      CancellationToken token = default (CancellationToken))
    {
      return service.AcquireLockAsync(name, new TimeSpan?(), new TimeSpan?(), token);
    }

    internal static bool UTagE9hrLtB7pouRBvRM() => LockServiceExtensions.C0xerthrYuoY4yYOyrOq == null;

    internal static LockServiceExtensions rrwNxmhrU0G3SOSY12X6() => LockServiceExtensions.C0xerthrYuoY4yYOyrOq;
  }
}
