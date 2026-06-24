// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.DatabaseConversionStage
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Runtime
{
  /// <summary>Стадии преобразования базы данных</summary>
  internal enum DatabaseConversionStage
  {
    /// <summary>Начало преобразования базы данных</summary>
    [DisplayName("SR.M('Начало преобразования базы данных')")] StartDatabaseConversion = 1,
    /// <summary>Создание резервной копии</summary>
    [DisplayName("SR.M('Создание резервной копии')")] Backup = 2,
    /// <summary>Преобразование базы данных: удаление триггеров</summary>
    [DisplayName("SR.M('Преобразование базы данных: удаление триггеров')")] DeleteTriggers = 3,
    /// <summary>Преобразование базы данных: удаление процедур</summary>
    [DisplayName("SR.M('Преобразование базы данных: удаление процедур')")] DeletingOfProcedures = 4,
    /// <summary>Преобразование базы данных: удаление представлений</summary>
    [DisplayName("SR.M('Преобразование базы данных: удаление представлений')")] DeletingViews = 5,
    /// <summary>
    /// Преобразование базы данных: умное удаление ключей и индексов
    /// </summary>
    [DisplayName("SR.M('Преобразование базы данных: умное удаление ключей и индексов')")] SmartDeleteKeysAndIndexes = 6,
    /// <summary>Преобразование базы данных: удаление внешних ключей</summary>
    [DisplayName("SR.M('Преобразование базы данных: удаление внешних ключей')")] DeletingForeignKeys = 7,
    /// <summary>Преобразование базы данных: удаление индексов</summary>
    [DisplayName("SR.M('Преобразование базы данных: удаление индексов')")] IndexRemoval = 8,
    /// <summary>Преобразование базы данных: создание таблиц</summary>
    [DisplayName("SR.M('Преобразование базы данных: создание таблиц')")] TableCreation = 9,
    /// <summary>Преобразование базы данных: удаление таблиц</summary>
    [DisplayName("SR.M('Преобразование базы данных: удаление таблиц')")] DeleteTables = 10, // 0x0000000A
    /// <summary>Преобразование базы данных: создание внешних ключей</summary>
    [DisplayName("SR.M('Преобразование базы данных: создание внешних ключей')")] CreatingForeignKeys = 11, // 0x0000000B
    /// <summary>Преобразование базы данных: создание индексов</summary>
    [DisplayName("SR.M('Преобразование базы данных: создание индексов')")] IndexCreation = 12, // 0x0000000C
    /// <summary>Преобразование базы данных: создание представлений</summary>
    [DisplayName("SR.M('Преобразование базы данных: создание представлений')")] CreatingViews = 13, // 0x0000000D
    /// <summary>Преобразование базы данных: создание процедур</summary>
    [DisplayName("SR.M('Преобразование базы данных: создание процедур')")] CreationOfProcedures = 14, // 0x0000000E
    /// <summary>Преобразование базы данных: создание триггеров</summary>
    [DisplayName("SR.M('Преобразование базы данных: создание триггеров')")] CreateTriggers = 15, // 0x0000000F
    /// <summary>Завершение преобразования базы данных</summary>
    [DisplayName("SR.M('Завершение преобразования базы данных')")] CompleteDatabaseConversion = 16, // 0x00000010
  }
}
