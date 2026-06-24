// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Managers.IDeployManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Managers
{
  /// <summary>
  /// Интерфейс менеджера экспорта-импорта конфигурации для работы через Remoting
  /// </summary>
  public interface IDeployManager : IConfigurationService
  {
    /// <summary>Экспортировать конфигурацию</summary>
    /// <param name="settings">Настройки экспорта</param>
    /// <returns>гуид экземпляра экспорта</returns>
    Guid ExportConfiguration(ConfigExportSettings settings);

    /// <summary>Проверить конфигурацию</summary>
    /// <param name="settings">Настройки импорта</param>
    /// <param name="activateKey">Ключ активации</param>
    /// <returns>гуид экземпляра проверки</returns>
    Guid TestConfiguration(IConfigImportSettings settings, string activateKey = null);

    /// <summary>Добавить ключ активации</summary>
    /// <param name="activateKey"></param>
    bool AddActivationKey(
      string activateKey,
      List<ElmaStoreComponentManifest> componentsToInstall,
      out List<ElmaStoreComponentManifest> notActivatedComponents);

    /// <summary>Импортировать конфигурацию</summary>
    /// <param name="settings">Настройки импорта</param>
    /// <returns>гуид экземпляра импорта</returns>
    Guid ImportConfiguration(IConfigImportSettings settings);

    /// <summary>Получить список последних сообщений о ходе импорта</summary>
    /// <param name="importUid">Гуид экземпляра импорта</param>
    /// <returns>Список сообщений</returns>
    List<DeployLogMessage> GetImportLog(Guid importUid);

    /// <summary>Получить список последних сообщений о ходе экспорта</summary>
    /// <param name="exportUid">Гуид экземпляра экспорта</param>
    /// <returns>Список сообщений</returns>
    List<DeployLogMessage> GetExportLog(Guid exportUid);

    /// <summary>
    /// Получить список последних сообщений о ходе проверки импорта
    /// </summary>
    /// <param name="testUid">гуид экземпляра проверки</param>
    /// <returns>список сообщений</returns>
    List<TestImportMessages> GetTestLog(Guid testUid);

    /// <summary>
    /// Получить список последних системных сообщений в ходе импорта
    /// </summary>
    /// <param name="importUid">Гуид экземпляра импорта</param>
    /// <returns>Список сообщений</returns>
    List<DeploySystemMessage> GetImportSystemMessages(Guid importUid);

    /// <summary>
    /// Получить список последних системных сообщений в ходе проверки импорта
    /// </summary>
    /// <param name="testUid">Гуид экземпляра проверки импорта</param>
    /// <returns>Список сообщений</returns>
    List<DeploySystemMessage> GetTestSystemMessages(Guid testUid);

    /// <summary>Получить зависимости пакета</summary>
    /// <param name="description"></param>
    /// <returns></returns>
    List<PackageDescription> FindPackageDependencies(PackageDescription description);

    /// <summary>Все пакеты сервера</summary>
    /// <returns></returns>
    List<PackageDescription> FindAllPackages();

    /// <summary>Поиск пакета на сервере</summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    List<PackageDescription> FindPackages(PackageFilter filter);

    /// <summary>Установить новые пакеты</summary>
    /// <param name="installInfo"></param>
    void ExecutePackagesOperations(PackageInstallInfo installInfo);

    /// <summary>Получить статус операции обновления</summary>
    /// <param name="uid"></param>
    /// <returns></returns>
    PackageOperationStatus GetUpdatePackagesOperationsStatus(Guid uid);

    /// <summary>Получить информацию по лицензированию сервера</summary>
    /// <returns></returns>
    ImportLicenseInfo GetServerLicenseInfo();

    /// <summary>
    /// Получить содержимое файла из папки дополнительных файлов компонента
    /// </summary>
    /// <param name="componentId">Идентификатор компонента</param>
    /// <param name="version">Версия компонента</param>
    /// <param name="relativeFileName">Путь до файла относительно папки с дополнительными файлами данного компонента</param>
    /// <returns></returns>
    byte[] GetComponentFileContent(string componentId, string version, string relativeFileName);

    /// <summary>Проверяем запущен ли импорт в текущий момент</summary>
    /// <returns>true - если импорт запущен</returns>
    bool IsImportAlreadyRun();

    /// <summary>Получить настройки импорта для экземпляра проверки</summary>
    /// <param name="testUid">Идентификатор экземпляра проверки</param>
    IImportSettings GetImportSettings(Guid testUid);
  }
}
