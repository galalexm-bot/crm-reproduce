// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.Migrator.Framework.ITransformationProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using System;
using System.Collections.Generic;
using System.Data;

namespace EleWise.ELMA.Runtime.Db.Migrator.Framework
{
  /// <summary>Интерфейс провайдера преобразования БД</summary>
  public interface ITransformationProvider : ITransformationProviderBase, IDisposable
  {
    /// <summary>Уникальный идентификатор провайдера.</summary>
    Guid Uid { get; }

    /// <summary>Начать транзакцию</summary>
    new void BeginTransaction();

    /// <summary>Начать транзакцию</summary>
    /// <param name="level">Уровень изоляции</param>
    void BeginTransaction(IsolationLevel level);

    /// <summary>Откатить транзакцию</summary>
    new void RollbackTransaction();

    /// <summary>Подключение к БД</summary>
    new IDbConnection Connection { get; }

    /// <summary>Диалект</summary>
    new Dialect Dialect { get; }

    /// <summary>Провайдер метаданных БД</summary>
    AbstractDbMetadataProvider DbMetadataProvider { get; }

    /// <summary>Создать копию провайдера с новым подключением к БД</summary>
    /// <returns></returns>
    ITransformationProvider CreateWithNewConnection();

    /// <summary>Разделитель параметров</summary>
    new string ParameterSeparator { get; }

    /// <summary>
    /// Проверять соответствие параметров поданых в запрос и параметров в строке запроса
    /// </summary>
    bool CheckParameterBinding { get; }

    /// <summary>Получить большую строку из ридера</summary>
    /// <param name="rs"></param>
    /// <param name="name"></param>
    /// <returns></returns>
    object GetLobString(IDataReader rs, string name);

    /// <summary>Включены ли логи</summary>
    bool LogsEnabled { get; set; }

    /// <summary>Синтаксис использования Guid</summary>
    /// <param name="guid"></param>
    /// <returns></returns>
    new string GuidQuerySintaxis(Guid guid);

    /// <summary>Имя схемы</summary>
    /// <returns></returns>
    string GetCurrentSchemaName();

    /// <summary>
    /// Выполнить какое-либо действие с указанным ограничением по времени
    /// </summary>
    /// <param name="timeout"></param>
    /// <param name="action"></param>
    new void ExecuteWithTimeout(int timeout, Action action);

    /// <summary>
    /// Установить максимальное время выполнения запросов для текущего контекста
    /// </summary>
    /// <param name="timeout">Время в секундах</param>
    /// <returns>Предыдущее значение времени</returns>
    int? SetCurrentContextTimeout(int? timeout);

    /// <summary>Выполнить запрос</summary>
    /// <param name="sql">Текст запроса</param>
    /// <param name="paramValues">Значения параметров</param>
    /// <returns>Объект для чтения результатов запроса</returns>
    new IDataReader ExecuteQuery(string sql, Dictionary<string, object> paramValues = null);

    /// <summary>Выполнить SQL-скрипт</summary>
    /// <param name="sql">Текст скрипта</param>
    /// <param name="paramValues">Значения параметров</param>
    /// <returns>Результат</returns>
    int ExecuteNonQuery(string sql, Dictionary<string, object> paramValues = null);

    /// <summary>Выполнить запрос, возвращающий один результат</summary>
    /// <param name="sql">Текст запроса</param>
    /// <param name="paramValues">Значения параметров</param>
    /// <returns>Возвращенное значение</returns>
    new object ExecuteScalar(string sql, Dictionary<string, object> paramValues = null);

    /// <summary>Вставить данные в таблицу</summary>
    /// <param name="table">Имя таблицы</param>
    /// <param name="columns">Имена колонок</param>
    /// <param name="values">Значения колонок в том же порядке, что и имена</param>
    /// <returns>Результат</returns>
    int Insert(string table, string[] columns, object[] values);

    /// <summary>Вставить данные в таблицу</summary>
    /// <param name="table">Имя таблицы</param>
    /// <param name="columns">Имена колонок</param>
    /// <param name="values">Значения колонок в том же порядке, что и имена</param>
    /// <param name="isNeedInsertId">Необходимо ли генерировать и добавлять Id к вставляемым значениям (для MS SQL не используется)</param>
    /// <returns>Результат</returns>
    int Insert(string table, string[] columns, object[] values, bool isNeedInsertId);

    /// <summary>
    /// Вставить данные в таблицу, в качестве values ипользуем select
    /// </summary>
    /// <param name="table">Имя таблицы</param>
    /// <param name="columns">Имена колонок</param>
    /// <param name="selectColName">Имена колонок в select (Обязатально каждой колонке давать алиас)</param>
    /// <param name="selectFrom">from часть селекта</param>
    /// <param name="isNeedInsertId">Необходимо ли генерировать и добавлять Id к вставляемым значениям</param>
    /// <param name="paramValues"></param>
    /// <returns>Результат</returns>
    int Insert(
      string table,
      string[] columns,
      string selectColName,
      string selectFrom,
      bool isNeedInsertId,
      Dictionary<string, object> paramValues = null);

    /// <summary>Обновить данные в таблице</summary>
    /// <param name="table">Имя таблицы</param>
    /// <param name="columns">Имена колонок</param>
    /// <param name="values">Значения колонок в том же порядке, что и имена</param>
    /// <param name="where">Условие обновления</param>
    /// <param name="paramValues">Значения параметров</param>
    /// <returns>Результат</returns>
    int Update(
      string table,
      string[] columns,
      object[] values,
      string where,
      Dictionary<string, object> paramValues = null);

    /// <summary>Добавить в запрос пейджинг</summary>
    /// <param name="query">Запрос</param>
    /// <param name="fetchOptions"></param>
    /// <returns></returns>
    new string SetupFetchOptions(string query, FetchOptions fetchOptions);

    /// <summary>Добавить в запрос пейджинг</summary>
    /// <param name="query">Запрос</param>
    /// <param name="fetchOptions"></param>
    /// <param name="quoteIfNeededSortExpression">нужно ли оборачивать строку сортировки кавычками (при необходимости)</param>
    /// <returns></returns>
    new string SetupFetchOptions(
      string query,
      FetchOptions fetchOptions,
      bool quoteIfNeededSortExpression);

    /// <summary>Создать запрос на получение числа строк.</summary>
    /// <param name="query">Запрос</param>
    /// <returns></returns>
    new string Count(string query);

    /// <summary>Выражение OrderBy для колонки</summary>
    /// <param name="propertyMetadata"></param>
    /// <param name="columnName"></param>
    /// <returns></returns>
    string GetSqlOrderBy(PropertyMetadata propertyMetadata, string columnName);

    /// <summary>
    /// Запрос для получения вложеностей иерархического справочника
    /// </summary>
    string GetSqlHierarchicalChilds(
      string tableName,
      string parentColumnName,
      string nameColumnName,
      long? parentId,
      int indent,
      int deep);

    /// <summary>Битовое сложение</summary>
    /// <param name="idcolumn"></param>
    /// <param name="mask"></param>
    /// <returns></returns>
    string BitAndExpression(string idcolumn, long mask);

    /// <summary>Битовое сложение</summary>
    /// <param name="idcolumn"></param>
    /// <param name="mask"></param>
    /// <returns></returns>
    string BitAndExpression(string idcolumn, string mask);

    /// <summary>Выражение NOLOCK для выборки из таблицы</summary>
    /// <param name="tableName"></param>
    /// <param name="alias"></param>
    /// <returns></returns>
    string NoLockTableExpression(string tableName, string alias);

    /// <summary>Получить имя процедуры из текста ее создания</summary>
    /// <param name="procedureText"></param>
    /// <returns></returns>
    string GetProcedureNameFromText(string procedureText);

    /// <summary>
    /// Получить имя индекса и имя таблицы из текста его создания
    /// </summary>
    /// <param name="sqlText">SQL выражение</param>
    /// <returns>Объект <see cref="T:EleWise.ELMA.Runtime.Db.Migrator.Framework.Index" /> с именами индекса и таблицы, если в тексте удалось распознать выражение создания индекса, иначе - null</returns>
    Index GetIndexInfoFromStatement(string sqlText);

    /// <summary>
    /// Выполнить действие, и повторить попытку в случае возникновения DeadLock-а
    /// </summary>
    /// <param name="action">Действие</param>
    /// <param name="retryCount">Кол-во повторов, если отрицательное, то берется значение по умолчанию</param>
    void RetryOnDeadlock(Action action, int retryCount);

    /// <summary>
    /// Возвращает True, если произошла ошибка, при которой надо обязательно откатывать транзакцию
    /// </summary>
    /// <param name="ex">Исключение</param>
    /// <returns></returns>
    bool IsUnrecoverableException(Exception ex);

    /// <summary>Дополнительная обработка ошибки и соединения</summary>
    /// <param name="ex">Исключение</param>
    /// <param name="dbConnection">Соединение</param>
    void ProcessException(Exception ex, IDbConnection dbConnection);

    /// <summary>Установка точки сохранения</summary>
    bool SavePoint(string key, IDbTransaction dbTransaction);

    /// <summary>Удаление точки сохранения</summary>
    void ReleaseSavePoint(string key, IDbTransaction dbTransaction);

    /// <summary>Откат к точке сохранения</summary>
    void RollBackSavePoint(string key, IDbTransaction dbTransaction);

    /// <summary>Проверить существование таблицы</summary>
    /// <param name="table">Имя таблицы</param>
    /// <returns>True, если таблица существует</returns>
    bool TableExists(string table);

    /// <summary>Добавить таблицу</summary>
    /// <param name="table">Таблица</param>
    void AddTable(Table table);

    /// <summary>Переименовать таблицу</summary>
    /// <param name="oldTableName">Старое имя таблицы</param>
    /// <param name="newTableName">Новое имя таблицы</param>
    void RenameTable(string oldTableName, string newTableName);

    /// <summary>
    /// Переименовать последовательность, связанную с таблицей
    /// </summary>
    /// <param name="oldTableName">Старое имя таблицы</param>
    /// <param name="newTableName">Новое имя таблицы</param>
    void RenameSequence(string oldTableName, string newTableName);

    /// <summary>Получить суммарную длину всех полей таблицы</summary>
    /// <param name="table">Имя таблицы</param>
    /// <returns>Суммарная длина полей таблицы</returns>
    int GetTableColumnsSize(string table);

    /// <summary>Максимальный размер записи в таблице</summary>
    int TableRecordMaxSize { get; }

    /// <summary>Удалить таблицу</summary>
    /// <param name="tableName">Имя таблицы</param>
    /// <param name="removeSequence">Удалить счётчик.</param>
    void RemoveTable(string tableName, bool removeSequence = true);

    /// <summary>Создать счётчик для таблицы.</summary>
    /// <param name="tableName">Имя таблицы.</param>
    void AddTableSequence(string tableName);

    /// <summary>Удалить счётчик для таблицы.</summary>
    /// <param name="tableName">Имя таблицы.</param>
    void RemoveTableSequence(string tableName);

    /// <summary>Инициализировать таблицу с генераторами для Сущностей</summary>
    void InitTableGenerators();

    /// <summary>Сделать бэкап таблиц</summary>
    /// <param name="tableNames"></param>
    /// <param name="newTableNames"></param>
    void BackupTables(string[] tableNames, string[] newTableNames);

    /// <summary>Проверить существование колонки в таблице</summary>
    /// <param name="table">Имя таблицы</param>
    /// <param name="column">Имя колонки</param>
    /// <returns>True, если колонка существует</returns>
    bool ColumnExists(string table, string column);

    /// <summary>Добавить колонку в существующую таблицу</summary>
    /// <param name="table">Имя таблицы</param>
    /// <param name="column">Колонка</param>
    void AddColumn(string table, Column column);

    /// <summary>Переименовать колонку</summary>
    /// <param name="table">Имя таблицы</param>
    /// <param name="oldColumnName">Старое имя колонки</param>
    /// <param name="newColumnName">Новое имя колонки</param>
    void RenameColumn(string table, string oldColumnName, string newColumnName);

    /// <summary>Удалить колонку из БД</summary>
    /// <param name="table">Имя таблицы</param>
    /// <param name="column">Имя колонки</param>
    void RemoveColumn(string table, string column);

    /// <summary>Удалить ограничения, навешенные на колонку</summary>
    /// <param name="table">Имя таблицы</param>
    /// <param name="column">Имя колонки</param>
    void RemoveColumnConstraints(string table, string column);

    /// <summary>Получить длину колонки в БД</summary>
    /// <param name="column">Колонка</param>
    /// <returns>Размер колонки</returns>
    int GetColumnSize(Column column);

    /// <summary>Колонка типа String нуждается ли в преобразовании?</summary>
    /// <returns></returns>
    bool NeedStringColumnTransform(string tableName, string columnName);

    /// <summary>
    /// Сконвертировать колонку в строковый тип ограниченной длины
    /// </summary>
    /// <param name="tableName">Наименование таблицы</param>
    /// <param name="columnName">Наименование колонки</param>
    /// <param name="columnSize">Конечный размер колонки</param>
    void ConvertColumnString(string tableName, string columnName, int columnSize);

    /// <summary>
    /// Сконвертировать колонку в строковый тип ограниченной длины
    /// </summary>
    /// <param name="tableName">Наименование таблицы</param>
    /// <param name="columnName">Наименование колонки</param>
    /// <param name="columnSize">Конечный размер колонки</param>
    /// <param name="substringStrings">Нужно ли в запросах использовать безопасное урезание строки</param>
    void ConvertColumnString(
      string tableName,
      string columnName,
      int columnSize,
      bool substringStrings);

    /// <summary>
    /// Сконвертировать колонку в строковый тип ограниченной длины если нужно
    /// </summary>
    /// <param name="tableName"></param>
    /// <param name="columnName"></param>
    /// <param name="columnSize"></param>
    void ConvertColumnStringIfNeed(string tableName, string columnName, int columnSize);

    /// <summary>Получить список полей таблицы</summary>
    /// <param name="tableName">Имя таблицы</param>
    /// <returns>Список полей</returns>
    string[] GetTableColumnsNames(string tableName);

    /// <summary>Сгенерировать временное имя для колонки</summary>
    /// <param name="tableName">Имя таблицы</param>
    /// <param name="columnName">Оригинальное имя колонки</param>
    /// <returns>Имя временной колонки</returns>
    string GenerateColumnTemporaryName(string tableName, string columnName);

    /// <summary>Сгенерировать временное имя для удаляемой колонки</summary>
    /// <param name="tableName">Имя таблицы</param>
    /// <param name="columnName">Оригинальное имя колонки</param>
    /// <returns>Имя временной колонки</returns>
    string GenerateDeletingColumnTemporaryName(string tableName, string columnName);

    /// <summary>Получить временное имя удаляемой колонки</summary>
    /// <remarks>
    /// Перед удалением колонки она переименовывается, чтобы можно было перенести данные из старой колонки в новую.
    /// </remarks>
    /// <param name="tableName">Имя таблицы</param>
    /// <param name="columnName">Оригинальное имя колонки</param>
    /// <returns>Временное имя удаляемой колонки</returns>
    string GetDeletingColumnTemporaryName(string tableName, string columnName);

    /// <summary>
    /// Проверить, существует ли ограничение с указанным именем
    /// </summary>
    /// <param name="table">Имя таблицы</param>
    /// <param name="name">Имя органичения</param>
    /// <returns>True, если существует</returns>
    bool ConstraintExists(string table, string name);

    /// <summary>Возвращает список внешних ключей для таблицы.</summary>
    /// <param name="tableName">Имя таблицы</param>
    /// <returns></returns>
    List<ForeignKey> GetForeignKeys(string tableName);

    /// <summary>Добавить внешний ключ</summary>
    /// <param name="foreignKey">Внешний ключ</param>
    void AddForeignKey(ForeignKey foreignKey);

    /// <summary>Удалить внешний ключ</summary>
    /// <param name="tableName">Имя таблицы</param>
    /// <param name="fkName">Имя внешнего ключа</param>
    void RemoveForeignKey(string tableName, string fkName);

    /// <summary>Удалить внешние ключи</summary>
    /// <param name="skipNames">Имена ключей, которые удалять не нужно</param>
    /// <param name="useNames">Имена ключей, которые нужно удалить (будут удалены только они)</param>
    void RemoveForeignKeys(IList<string> skipNames = null, IList<string> useNames = null);

    /// <summary>Добавить внешний ключ</summary>
    /// <param name="primaryKey">Внешний ключ</param>
    void AddPrimaryKey(PrimaryKey primaryKey);

    /// <summary>Получить все первичные ключи</summary>
    /// <returns></returns>
    List<KeyValuePair<string, string>> GetPrimaryKeys();

    /// <summary>Получить превичный ключ по таблице</summary>
    /// <returns></returns>
    PrimaryKey GetPrimaryKeyByTable(string table);

    /// <summary>Удалить первичнй ключ</summary>
    /// <param name="tableName">Имя таблицы</param>
    /// <param name="pkName">Имя внешнего ключа</param>
    void RemovePrimaryKey(string tableName, string pkName);

    /// <summary>Удалить первичные ключи</summary>
    /// <param name="skipNames"></param>
    /// <param name="useNames"></param>
    void RemovePrimaryKeys(IList<string> skipNames = null, IList<string> useNames = null);

    /// <summary>Удалить триггер</summary>
    /// <param name="tableName">Имя таблицы</param>
    /// <param name="triggerName">Имя триггера</param>
    void RemoveTrigger(string tableName, string triggerName);

    /// <summary>Удалить триггеры</summary>
    /// <param name="skipNames">Имена триггеров, которые удалять не нужно</param>
    /// <param name="useNames">Имена триггеров, которые нужно удалить (будут удалены только они)</param>
    void RemoveTriggers(IList<string> skipNames = null, IList<string> useNames = null);

    /// <summary>Удалить процедуру или функцию</summary>
    /// <param name="procedureName">Имя процедуры или функции</param>
    void RemoveProcedure(string procedureName);

    /// <summary>Удалить процедуры и функции</summary>
    /// <param name="skipNames">Имена процедур и функций, которые удалять не нужно</param>
    /// <param name="useNames">Имена процедур и функций, которые нужно удалить (будут удалены только они)</param>
    void RemoveProcedures(IList<string> skipNames = null, IList<string> useNames = null);

    /// <summary>Обращение к табличной функции</summary>
    /// <param name="name">Название функции</param>
    /// <param name="params">Параметры</param>
    /// <returns></returns>
    string TableFunction(string name, string @params);

    /// <summary>Удалить представление</summary>
    /// <param name="viewName">Имя представления</param>
    void RemoveView(string viewName);

    /// <summary>Удалить представления</summary>
    /// <param name="skipNames">Имена представлений, которые удалять не нужно</param>
    /// <param name="useNames">Имена представлений, которые нужно удалить (будут удалены только они)</param>
    void RemoveViews(IList<string> skipNames = null, IList<string> useNames = null);

    /// <summary>Возвращает список индексов для таблицы.</summary>
    /// <param name="tableName"></param>
    /// <returns></returns>
    List<string> GetIndexes(string tableName);

    /// <summary>Добавить уникальный индекс</summary>
    /// <param name="index">Индекс</param>
    void AddUniqueIndex(Index index);

    /// <summary>Добавить индекс</summary>
    /// <param name="index">Индекс</param>
    void AddIndex(Index index);

    /// <summary>
    /// Добавить индекс с учетом того что значение в поле может не быть (актувльно для Оракла)
    /// </summary>
    /// <param name="index">Индекс</param>
    void AddNvlIndex(Index index);

    /// <summary>Удалить индекс</summary>
    /// <param name="tableName">Имя таблицы</param>
    /// <param name="indexName">Имя индекса</param>
    void RemoveIndex(string tableName, string indexName);

    /// <summary>Удалить индексы</summary>
    /// <param name="skipNames">Имена индексов, которые удалять не нужно</param>
    /// <param name="useNames">Имена индексов, которые нужно удалить (будут удалены только они)</param>
    void RemoveIndexes(IList<string> skipNames = null, IList<string> useNames = null);

    /// <summary>Сенерить уникально имя индекса</summary>
    /// <returns></returns>
    string GenerateIndexName();

    /// <summary>Существует ли индекс</summary>
    /// <param name="tableName"></param>
    /// <param name="indexName"></param>
    /// <returns></returns>
    bool IndexExists(string tableName, string indexName);

    /// <summary>
    /// Отключить индексы для таблицы, не отключает индексы для Primary Key
    /// </summary>
    /// <param name="tableName">Имя таблицы в БД</param>
    void DisableIndexOnTable(string tableName);

    /// <summary>
    /// Включает и пересобирает индексы относящиеся к таблице.
    /// </summary>
    /// <param name="tableName">Имя таблицы в БД</param>
    void RebuildIndexOnTable(string tableName);

    /// <summary>Выполнить резервное копирование БД</summary>
    /// <param name="connectionString">Строка подключения</param>
    /// <param name="outputPath">Полный путь до папки, в которую нужно сохранить резервную копию БД</param>
    /// <returns>Полное имя файла резервной копии</returns>
    string BackupDatabase(string connectionString, string outputPath);

    /// <summary>
    /// Является ли поддержка автоматического бекапа полной? (Во всех случаях можно сделать автоматический бекап?)
    /// </summary>
    bool HasFullAutoBackupSupport { get; }

    /// <summary>
    /// Получить значение текущего времени из БД.
    /// Применять для синхронизации операций на фермах или для получения точного серверного времени
    /// </summary>
    /// <returns>Текущее время сервера БД</returns>
    DateTime GetDateTimeNow();

    /// <summary>
    /// Получить значение текущего времени UTC из БД.
    /// Применять для синхронизации операций на фермах или для получения точного серверного времени
    /// </summary>
    /// <returns>Текущее время UTC на сервере БД</returns>
    DateTime GetUtcDateTimeNow();

    /// <summary>
    /// Массовая вставка DataTable в таблицу tableName<para />
    /// Работает только для таблиц сущностей!<para />
    /// Выполняется в отдельном соединении и транзакции!
    /// </summary>
    /// <param name="tableName">Таблица в БД для вставки</param>
    /// <param name="data">Таблица данных. Первая колонка должна быть Id типа long</param>
    void BulkInsert(string tableName, DataTable data);

    /// <summary>
    /// Массовая вставка DataTable в таблицу tableName с указанием необходимости генерировать id<para />
    /// Работает только для таблиц сущностей!<para />
    /// Выполняется в отдельном соединении и транзакции!
    /// </summary>
    /// <param name="tableName">Таблица в БД для вставки</param>
    /// <param name="data">Таблица данных</param>
    /// <param name="shouldGenerateId">Флаг для необходимости генерировать id</param>
    void BulkInsert(string tableName, DataTable data, bool shouldGenerateId);

    /// <summary>
    /// Массовое обновление всех строк с Uid равным Uid из DataTable<para />
    /// Выполняется в отдельном соединении и транзакции!
    /// </summary>
    /// <param name="tableName">Таблица в БД для обновления</param>
    /// <param name="data">Таблица данных. Первая колонка - Id, вторая - Uid</param>
    void BulkUpdate(string tableName, DataTable data);

    /// <summary>
    /// Массовое обновление всех строк с Uid равным Uid из DataTable<para />
    /// Выполняется в отдельном соединении и транзакции!
    /// </summary>
    /// <param name="tableName">Таблица в БД для обновления</param>
    /// <param name="data">Таблица данных. Первая колонка - Id</param>
    /// <param name="keyColumn">Ключевая колонка для построения условия обновления</param>
    void BulkUpdate(string tableName, DataTable data, string keyColumn);

    /// <summary>
    /// Массовое обновление всех строк по набору ключевых колонок
    /// Выполняется в отдельном соединении и транзакции!
    /// </summary>
    /// <param name="tableName">Таблица в БД для обновления</param>
    /// <param name="data">Таблица данных. Первая колонка - Id</param>
    /// <param name="keyColumns">Список ключевых колонок</param>
    void BulkUpdate(string tableName, DataTable data, List<ColumnLink> keyColumns);

    /// <summary>
    /// Удалить данные из таблицы, используется для удаления больших объемов данных
    /// </summary>
    /// <param name="table">Имя таблицы</param>
    /// <param name="where">Условие удаления</param>
    /// <param name="paramValues">Параметры</param>
    /// <returns>Результат</returns>
    int BulkDelete(string table, string where, Dictionary<string, object> paramValues = null);

    /// <summary>
    /// Удалить данные из таблицы, используется для удаления больших объемов данных
    /// </summary>
    /// <param name="arg">Аргументы массового удаления</param>
    /// <returns>Результат</returns>
    int BulkDelete(BulkDeleteArg arg);

    /// <summary>
    /// Зарезервировать указанное количество идентификаторов для таблицы
    /// </summary>
    /// <param name="count">Количество</param>
    /// <param name="tableName">Название таблицы</param>
    /// <returns>Первый Id зарезервированного массива идентификаторов</returns>
    [Obsolete("Не атомарен, могут возникать промежутки в отрезке выделения идентификаторов. Используйте ReserveIds")]
    long ReserveId(int count, string tableName);

    /// <summary>
    /// Зарезервировать указанное количество идентификаторов для таблицы
    /// </summary>
    /// <param name="count">Количество</param>
    /// <param name="tableName">Название таблицы</param>
    /// <returns>Массив выделенных идентификаторов</returns>
    long[] ReserveIds(int count, string tableName);

    /// <summary>
    /// Проверить предварительные условия возможности запуска системы <pre />
    /// В случае ошибки - необходимо сгенерировать исключение <see cref="T:EleWise.ELMA.Runtime.Exceptions.CheckPrerequisitesException" />
    /// </summary>
    void CheckPrerequisites();

    /// <summary>
    /// Вернуть версию сервера базы данных в строковом представлении
    /// </summary>
    /// <returns></returns>
    string GetDatabaseServerVersion();

    /// <summary>Вернуть номер версии сервера базы данных</summary>
    /// <returns></returns>
    Version GetEngineVersion();

    /// <summary>Является ли колонка сортируемой в БД</summary>
    /// <param name="column"></param>
    /// <returns></returns>
    new bool IsSortableDataColumn(DataColumn column);
  }
}
