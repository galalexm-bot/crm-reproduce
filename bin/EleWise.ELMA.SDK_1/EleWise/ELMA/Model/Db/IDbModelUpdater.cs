// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Db.IDbModelUpdater
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Actions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;

namespace EleWise.ELMA.Model.Db
{
  /// <summary>Интерфейс обработчика изменений БД моделей</summary>
  public interface IDbModelUpdater : IActionsHolder
  {
    /// <summary>Провайдер преобразования БД</summary>
    ITransformationProvider Transform { get; }

    /// <summary>
    /// Сервис, позволяющий получать или ставить метки при обновлении структуры БД
    /// </summary>
    DbUpdateMarkerService MarkerService { get; }

    /// <summary>
    /// Пересоздаются ли ограничения (внешние ключи, индексы, триггеры и т.д.) полностью
    /// </summary>
    bool RecreateConstraints { get; }

    /// <summary>Сгенерировать имя внешнего ключа</summary>
    /// <param name="tableName">Имя таблицы</param>
    /// <param name="columnName">Имя колонки</param>
    /// <returns>Имя внешнего ключа</returns>
    string GenerateForeignKeyName(string tableName, string columnName);

    /// <summary>Сгенерировать имя первичного ключа</summary>
    /// <param name="tableName">Имя таблицы</param>
    /// <param name="columnName">Имя колонки</param>
    /// <returns>Имя первичного ключа</returns>
    string GeneratePrimaryKeyName(string tableName, string columnName);

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
  }
}
