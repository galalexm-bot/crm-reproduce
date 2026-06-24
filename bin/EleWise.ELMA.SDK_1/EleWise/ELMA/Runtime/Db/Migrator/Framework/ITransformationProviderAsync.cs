// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.Migrator.Framework.ITransformationProviderAsync
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime.Db.Migrator.Framework
{
  /// <summary>
  /// Интерфейс провайдера преобразования БД (Асинхронная часть)
  /// </summary>
  public interface ITransformationProviderAsync : 
    ITransformationProvider,
    ITransformationProviderBase,
    IDisposable
  {
    /// <summary>Выполнить запрос</summary>
    /// <param name="sql">Текст запроса</param>
    /// <param name="paramValues">Значения параметров</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Объект для чтения результатов запроса</returns>
    Task<IDataReader> ExecuteQueryAsync(
      string sql,
      Dictionary<string, object> paramValues = null,
      CancellationToken cancellationToken = default (CancellationToken));

    /// <summary>Выполнить SQL-скрипт</summary>
    /// <param name="sql">Текст скрипта</param>
    /// <param name="paramValues">Значения параметров</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Результат</returns>
    Task<int> ExecuteNonQueryAsync(
      string sql,
      Dictionary<string, object> paramValues = null,
      CancellationToken cancellationToken = default (CancellationToken));

    /// <summary>Выполнить запрос, возвращающий один результат</summary>
    /// <param name="sql">Текст запроса</param>
    /// <param name="paramValues">Значения параметров</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Возвращенное значение</returns>
    Task<object> ExecuteScalarAsync(
      string sql,
      Dictionary<string, object> paramValues = null,
      CancellationToken cancellationToken = default (CancellationToken));

    /// <summary>Вставить данные в таблицу</summary>
    /// <param name="table">Имя таблицы</param>
    /// <param name="columns">Имена колонок</param>
    /// <param name="values">Значения колонок в том же порядке, что и имена</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Результат</returns>
    Task<int> InsertAsync(
      string table,
      string[] columns,
      object[] values,
      CancellationToken cancellationToken = default (CancellationToken));

    /// <summary>Вставить данные в таблицу</summary>
    /// <param name="table">Имя таблицы</param>
    /// <param name="columns">Имена колонок</param>
    /// <param name="values">Значения колонок в том же порядке, что и имена</param>
    /// <param name="isNeedInsertId"><c>true</c> если необходимо ли генерировать и добавлять Id к вставляемым значениям (для MS SQL не используется)</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Результат</returns>
    Task<int> InsertAsync(
      string table,
      string[] columns,
      object[] values,
      bool isNeedInsertId,
      CancellationToken cancellationToken = default (CancellationToken));

    /// <summary>
    /// Вставить данные в таблицу, в качестве values ипользуем select
    /// </summary>
    /// <param name="table">Имя таблицы</param>
    /// <param name="columns">Имена колонок</param>
    /// <param name="selectColName">Имена колонок в select (Обязатально каждой колонке давать алиас)</param>
    /// <param name="selectFrom">from часть селекта</param>
    /// <param name="isNeedInsertId"><c>true</c> если необходимо ли генерировать и добавлять Id к вставляемым значениям (для MS SQL не используется)</param>
    /// <param name="paramValues">Значения параметров</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Результат</returns>
    Task<int> InsertAsync(
      string table,
      string[] columns,
      string selectColName,
      string selectFrom,
      bool isNeedInsertId,
      Dictionary<string, object> paramValues = null,
      CancellationToken cancellationToken = default (CancellationToken));

    /// <summary>Обновить данные в таблице</summary>
    /// <param name="table">Имя таблицы</param>
    /// <param name="columns">Имена колонок</param>
    /// <param name="values">Значения колонок в том же порядке, что и имена</param>
    /// <param name="where">Условие обновления</param>
    /// <param name="paramValues">Значения параметров</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Результат</returns>
    Task<int> UpdateAsync(
      string table,
      string[] columns,
      object[] values,
      string where,
      Dictionary<string, object> paramValues = null,
      CancellationToken cancellationToken = default (CancellationToken));

    /// <summary>
    /// Выполнить какое-либо действие с указанным ограничением по времени
    /// </summary>
    /// <param name="timeout">Таймаут</param>
    /// <param name="action">Действие</param>
    Task ExecuteWithTimeoutAsync(int timeout, Func<Task> action);

    /// <summary>
    /// Массовая вставка DataTable в таблицу tableName<para />
    /// Работает только для таблиц сущностей!<para />
    /// Выполняется в отдельном соединении и транзакции!
    /// </summary>
    /// <param name="tableName">Таблица в БД для вставки</param>
    /// <param name="data">Таблица данных. Первая колонка должна быть Id типа long</param>
    /// <param name="cancellationToken">Токен отмены</param>
    Task BulkInsertAsync(string tableName, DataTable data, CancellationToken cancellationToken = default (CancellationToken));

    /// <summary>
    /// Массовая вставка DataTable в таблицу tableName с указанием необходимости генерировать id<para />
    /// Работает только для таблиц сущностей!<para />
    /// Выполняется в отдельном соединении и транзакции!
    /// </summary>
    /// <param name="tableName">Таблица в БД для вставки</param>
    /// <param name="data">Таблица данных</param>
    /// <param name="shouldGenerateId">Флаг для необходимости генерировать id</param>
    /// <param name="cancellationToken">Токен отмены</param>
    Task BulkInsertAsync(
      string tableName,
      DataTable data,
      bool shouldGenerateId,
      CancellationToken cancellationToken = default (CancellationToken));

    /// <summary>
    /// Массовое обновление всех строк с Uid равным Uid из DataTable<para />
    /// Выполняется в отдельном соединении и транзакции!
    /// </summary>
    /// <param name="tableName">Таблица в БД для обновления</param>
    /// <param name="data">Таблица данных. Первая колонка - Id, вторая - Uid</param>
    /// <param name="cancellationToken">Токен отмены</param>
    Task BulkUpdateAsync(string tableName, DataTable data, CancellationToken cancellationToken = default (CancellationToken));

    /// <summary>
    /// Массовое обновление всех строк с Uid равным Uid из DataTable<para />
    /// Выполняется в отдельном соединении и транзакции!
    /// </summary>
    /// <param name="tableName">Таблица в БД для обновления</param>
    /// <param name="data">Таблица данных. Первая колонка - Id</param>
    /// <param name="keyColumn">Ключевая колонка для построения условия обновления</param>
    /// <param name="cancellationToken">Токен отмены</param>
    Task BulkUpdateAsync(
      string tableName,
      DataTable data,
      string keyColumn,
      CancellationToken cancellationToken = default (CancellationToken));

    /// <summary>
    /// Массовое обновление всех строк по набору ключевых колонок
    /// Выполняется в отдельном соединении и транзакции!
    /// </summary>
    /// <param name="tableName">Таблица в БД для обновления</param>
    /// <param name="data">Таблица данных. Первая колонка - Id</param>
    /// <param name="keyColumns">Список ключевых колонок</param>
    /// <param name="cancellationToken">Токен отмены</param>
    Task BulkUpdateAsync(
      string tableName,
      DataTable data,
      List<ColumnLink> keyColumns,
      CancellationToken cancellationToken = default (CancellationToken));

    /// <summary>
    /// Удалить данные из таблицы, используется для удаления больших объемов данных
    /// </summary>
    /// <param name="table">Имя таблицы</param>
    /// <param name="where">Условие удаления</param>
    /// <param name="paramValues">Параметры</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Результат</returns>
    Task<int> BulkDeleteAsync(
      string table,
      string where,
      Dictionary<string, object> paramValues = null,
      CancellationToken cancellationToken = default (CancellationToken));

    /// <summary>
    /// Удалить данные из таблицы, используется для удаления больших объемов данных
    /// </summary>
    /// <param name="arg">Аргументы массового удаления</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Результат</returns>
    Task<int> BulkDeleteAsync(BulkDeleteArg arg, CancellationToken cancellationToken = default (CancellationToken));
  }
}
