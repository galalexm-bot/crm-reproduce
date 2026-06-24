// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.IUnitOfWorkManagerAsync
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime.NH
{
  /// <summary>Фабрика асинхронных единиц работ</summary>
  public interface IUnitOfWorkManagerAsync : IUnitOfWorkManager
  {
    /// <summary>Создать асинхронную единицу работы</summary>
    /// <param name="dbName">Имя БД</param>
    /// <param name="transactional">True, если нужно открыть транзацию</param>
    /// <param name="isolationLevel">Уровень изоляции</param>
    /// <returns>Асинхронная единица работы</returns>
    IUnitOfWorkAsync CreateAsync(string dbName, bool transactional, IsolationLevel isolationLevel = IsolationLevel.Unspecified);

    /// <summary>
    /// Зарегистрировать асинхронное действие, которое нужно выполнить до подтверждения транзакции
    /// </summary>
    /// <param name="action">Асинхронное действие</param>
    void RegisterAsyncPreCommitAction(System.Func<CancellationToken, Task> action);

    /// <summary>
    /// Зарегистрировать действие, которое нужно выполнить после подтверждения транзакции
    /// </summary>
    /// <param name="action">Асинхронное действие</param>
    void RegisterAsyncPostCommitAction(System.Func<CancellationToken, Task> action);

    /// <summary>
    /// Зарегистрировать асинхронное действие, которое нужно выполнить после отката транзакции
    /// </summary>
    /// <param name="action">Асинхронное действие</param>
    void RegisterAsyncRollbackAction(System.Func<CancellationToken, Task> action);

    /// <summary>
    /// В момент попытки подтвердить транзакцию, выбрасывать указанное исключение
    /// </summary>
    /// <param name="ex">Исключение</param>
    /// <param name="cancellationToken">Токен отмены</param>
    Task ThrowExceptionOnCommitAsync(Exception ex, CancellationToken cancellationToken = default (CancellationToken));
  }
}
