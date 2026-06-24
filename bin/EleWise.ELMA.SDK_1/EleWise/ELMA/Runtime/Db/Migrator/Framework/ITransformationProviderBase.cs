// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.Migrator.Framework.ITransformationProviderBase
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using System;
using System.Collections.Generic;
using System.Data;

namespace EleWise.ELMA.Runtime.Db.Migrator.Framework
{
  /// <summary>Базовый интерфейс провайдера преобразования БД</summary>
  public interface ITransformationProviderBase : IDisposable
  {
    /// <summary>Начать транзакцию</summary>
    void BeginTransaction();

    /// <summary>Откатить транзакцию</summary>
    void RollbackTransaction();

    /// <summary>Подтвердить транзакцию</summary>
    void CommitTransaction();

    /// <summary>Подключение к БД</summary>
    IDbConnection Connection { get; }

    /// <summary>Добавить в запрос пейджинг</summary>
    /// <param name="query">Запрос</param>
    /// <param name="fetchOptions"></param>
    /// <returns></returns>
    string SetupFetchOptions(string query, FetchOptions fetchOptions);

    /// <summary>Добавить в запрос пейджинг</summary>
    /// <param name="query">Запрос</param>
    /// <param name="fetchOptions"></param>
    /// <param name="quoteIfNeededSortExpression">нужно ли оборачивать строку сортировки кавычками (при необходимости)</param>
    /// <returns></returns>
    string SetupFetchOptions(
      string query,
      FetchOptions fetchOptions,
      bool quoteIfNeededSortExpression);

    /// <summary>Разделитель параметров</summary>
    string ParameterSeparator { get; }

    /// <summary>Синтаксис использования Guid</summary>
    /// <param name="guid">Уникальный идентификатор</param>
    string GuidQuerySintaxis(Guid guid);

    /// <summary>Диалект</summary>
    Dialect Dialect { get; }

    /// <summary>Выполнить запрос</summary>
    /// <param name="sql">Текст запроса</param>
    /// <param name="paramValues">Значения параметров</param>
    /// <returns>Объект для чтения результатов запроса</returns>
    IDataReader ExecuteQuery(string sql, Dictionary<string, object> paramValues = null);

    /// <summary>
    /// Выполнить какое-либо действие с указанным ограничением по времени
    /// </summary>
    /// <param name="timeout"></param>
    /// <param name="action"></param>
    void ExecuteWithTimeout(int timeout, Action action);

    /// <summary>Выполнить запрос, возвращающий один результат</summary>
    /// <param name="sql">Текст запроса</param>
    /// <param name="paramValues">Значения параметров</param>
    /// <returns>Возвращенное значение</returns>
    object ExecuteScalar(string sql, Dictionary<string, object> paramValues = null);

    /// <summary>Создать запрос на получение числа строк.</summary>
    /// <param name="query">Запрос</param>
    /// <returns></returns>
    string Count(string query);

    /// <summary>Является ли колонка сортируемой в БД</summary>
    /// <param name="column"></param>
    /// <returns></returns>
    bool IsSortableDataColumn(DataColumn column);
  }
}
