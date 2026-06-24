// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Locking.ILockService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Locking
{
  /// <summary>Интерфейс сервиса блокировок</summary>
  public interface ILockService
  {
    /// <summary>Попытка захватить блокировку</summary>
    /// <param name="name">Имя блокировки</param>
    /// <param name="maxValidFor">Длительность жизни блокировки. если null - значение берется из настроек провайдера (по умолчанию - 30 мин)</param>
    /// <param name="timeout">Время таймаута в течение которого выполняется попытка захватить блокировку. если null - значение берется из настроек провайдера (по умолчанию - 30 с)</param>
    /// <param name="lock">Блокировка, null - если получить не удалось</param>
    /// <returns>True  - в случае успеха</returns>
    bool TryAcquireLock(string name, TimeSpan? maxValidFor, TimeSpan? timeout, out ILock @lock);

    /// <summary>Захватить блокировку</summary>
    /// <param name="name">Имя блокировки</param>
    /// <param name="maxValidFor">Длительность жизни блокировки. если null - значение берется из настроек провайдера (по умолчанию - 30 мин)</param>
    /// <param name="timeout">Время таймаута в течение которого выполняется попытка захватить блокировку. если null - значение берется из настроек провайдера (по умолчанию - 30 с)</param>
    /// <returns>Блокировка</returns>
    ILock AcquireLock(string name, TimeSpan? maxValidFor, TimeSpan? timeout);
  }
}
