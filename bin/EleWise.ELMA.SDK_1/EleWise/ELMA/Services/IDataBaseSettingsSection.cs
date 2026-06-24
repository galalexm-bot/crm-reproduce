// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.IDataBaseSettingsSection
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Services
{
  public interface IDataBaseSettingsSection
  {
    /// <summary>Имя строки подключения</summary>
    string ConnectionStringName { get; set; }

    /// <summary>Строка подключения</summary>
    string ConnectionString { get; }

    /// <summary>
    /// Удалять ли старую базу при запуске. По умолчанию - false
    /// </summary>
    bool DropDatabaseOnStart { get; set; }

    /// <summary>Количество попыток подключения</summary>
    int ConnectionAttemptCount { get; }

    /// <summary>Интервал между попытками подключения (в секундах)</summary>
    int ConnectionAttemptInverval { get; }

    /// <summary>
    /// Нужно ли делать резервные копии перед изменением структуры БД
    /// </summary>
    bool BackupEnabled { get; set; }

    /// <summary>Получить путь до папки с резервными копиями</summary>
    string BackupPath { get; }

    /// <summary>Получить значение Timeout для команд sql запросов</summary>
    int? CommandTimeout { get; }

    /// <summary>Задать строку подключения</summary>
    /// <param name="name"></param>
    /// <param name="connectionString"></param>
    void SetConnectionString(string name, string connectionString);

    /// <summary>Задать путь до папки с резервными копиями</summary>
    /// <param name="path"></param>
    void SetBackupPath(string path);

    /// <summary>Задать таймаут для команд sql запросов</summary>
    /// <param name="commandTimeOut"></param>
    void SetCommandTimeOut(int commandTimeOut);

    /// <summary>Уникальный идентификатор провайдера БД</summary>
    Type ProviderType { get; set; }

    /// <summary>Автоматическая инитиализация провайдера при загрузке</summary>
    bool AutoInitialize { get; set; }
  }
}
