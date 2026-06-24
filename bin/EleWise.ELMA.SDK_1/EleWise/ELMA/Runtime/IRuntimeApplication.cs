// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.IRuntimeApplication
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Runtime.Cache;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Runtime
{
  /// <summary>Интерфейс для работы со средой исполнения приложения</summary>
  [ExtensionPoint(ComponentType.Server)]
  public interface IRuntimeApplication
  {
    /// <summary>Текущая конфигурация приложения</summary>
    RuntimeConfiguration Configuration { get; }

    /// <summary>Уникальный идентификатор конфигурации (хранится в БД)</summary>
    Guid ConfigurationUid { get; }

    /// <summary>Информация о конфигурации</summary>
    ConfigurationInfo ConfigurationInfo { get; }

    /// <summary>Основной провайдер</summary>
    IMainDatabaseProvider MainProvider { get; }

    /// <summary>Список провайдеров</summary>
    IEnumerable<IProvider> Providers { get; }

    /// <summary>
    /// Провайдер предварительного преобразования БД (до инициализации приложения)
    /// </summary>
    /// <returns></returns>
    DbPreUpdater DbPreUpdater { get; }

    /// <summary>Провайдер преобразования БД</summary>
    /// <returns></returns>
    ITransformationProvider TransformationProvider { get; }

    /// <summary>Кэш запуска приложения</summary>
    ApplicationStartCache ApplicationStartCache { get; }

    /// <summary>Уникальный идентификатор текущего подключения к БД</summary>
    Guid ConnectionUid { get; }

    /// <summary>
    /// Уникальный идентификатор установленного экземпляра ELMA
    /// </summary>
    Guid InstanceUid { get; }

    /// <summary>Активно ли данное подключение к БД</summary>
    /// <param name="connectionUid">Уникальный идентификатор подключения</param>
    /// <returns>True, если активно</returns>
    bool IsConnectionAlive(Guid connectionUid);

    /// <summary>
    /// Получить список идентификаторов активных подключений (включая текущее)
    /// </summary>
    /// <returns></returns>
    IEnumerable<Guid> GetActiveConnectionUids();

    /// <summary>Вызывается сразу после загрузки модулей</summary>
    void OnApplicationStarting();

    /// <summary>Вызывается при завершении запуска приложения</summary>
    void OnApplicationStarted();

    /// <summary>Признак, что приложение запущено</summary>
    bool IsStarted { get; }

    /// <summary>
    /// Признак, является ли сервер первым запущенным в кластере
    /// </summary>
    bool IsFirstServerInCluster { get; }

    /// <summary>Получить ограничение по времени выполнения команды</summary>
    /// <returns></returns>
    int? GetCommandTimeout();

    /// <summary>
    /// Установить максимальное время выполнения запросов для текущего контекста
    /// </summary>
    /// <param name="timeout">Время в секундах</param>
    /// <returns>Предыдущее значение времени</returns>
    int? SetCurrentContextTimeout(int? timeout);
  }
}
