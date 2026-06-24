// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.IUnitOfWorkManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Data;

namespace EleWise.ELMA.Runtime.NH
{
  /// <summary>Фабрика единиц работ</summary>
  public interface IUnitOfWorkManager
  {
    /// <summary>Создать единицу работы</summary>
    /// <param name="dbName">Имя БД</param>
    /// <param name="transactional">True, если нужно открыть транзацию</param>
    /// <param name="isolationLevel">Уровень изоляции</param>
    /// <returns></returns>
    IUnitOfWork Create(string dbName, bool transactional, IsolationLevel isolationLevel = IsolationLevel.Unspecified);

    /// <summary>Есть ли активная транзакция для указанной БД</summary>
    /// <param name="dbName">Имя БД</param>
    /// <returns>true, если транзакция существует</returns>
    bool HasActiveTransaction(string dbName);

    /// <summary>
    /// Пометить текущую единицу работы для отката.
    /// В этом случае при подтверждении самой первой единицы работы произойдет ее фактический откат, т.е. данные не будут сохранены
    /// </summary>
    /// <param name="dbName">Имя БД</param>
    void RollbackCurrent(string dbName);

    /// <summary>
    /// Отменить изменения в сущности перед сохранением данных
    /// </summary>
    /// <param name="dbName">Имя БД</param>
    /// <param name="entity">Сущность</param>
    void RevertEntityChangesOnCommit(string dbName, object entity);

    /// <summary>
    /// В момент попытки подтвердить транзакцию, выбрасывать указанное исключение
    /// </summary>
    /// <param name="ex">Исключение</param>
    void ThrowExceptionOnCommit(Exception ex);

    /// <summary>
    /// Зарегистрировать действие, которое нужно выполнить до подтверждения транзакции
    /// </summary>
    /// <param name="action"></param>
    void RegisterPreCommitAction(Action action);

    /// <summary>
    /// Зарегистрировать действие, которое нужно выполнить после подтверждения транзакции
    /// </summary>
    /// <param name="action"></param>
    void RegisterPostCommitAction(Action action);
  }
}
