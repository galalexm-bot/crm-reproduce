// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Services.IExportImportService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Import;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EleWise.ELMA.Deploy.Services
{
  /// <summary>Интерфейс сервиса импорта/экспорта</summary>
  public interface IExportImportService
  {
    /// <summary>Запустить проверку конфигурации</summary>
    /// <param name="settings">Настройки импорта</param>
    /// <param name="activateKey">Ключ активации</param>
    /// <param name="storeSettings">Сохранить настройки импорта после теста</param>
    /// <returns>Идентификатор сессии проверки</returns>
    Task<Guid> Test(IConfigImportSettings settings, string activateKey = null, bool storeSettings = false);

    /// <summary>Запустить проверку списка конфигураций модулей</summary>
    /// <param name="testUid">Идентификатор сессии теста</param>
    /// <param name="settings">Список конфигураций</param>
    /// <param name="activateKey">Ключ активации</param>
    /// <param name="storeSettings">Сохранить настройки импорта после теста</param>
    /// <returns>Идентификатор сессии проверки</returns>
    Task<Guid> TestModules(
      Guid testUid,
      IEnumerable<IConfigImportSettings> settings,
      string activateKey = null,
      bool storeSettings = false);

    /// <summary>Запустить импорт</summary>
    /// <param name="settings">Настройки импорта</param>
    /// <returns>Идентификатор сессии импорта</returns>
    Task<Guid> Import(IImportSettings settings);

    /// <summary>Запустить экспорт</summary>
    /// <param name="settings">Настройки экспорта</param>
    /// <returns>Идентификатор сессии экспорта</returns>
    Task<Guid> Export(ConfigExportSettings settings);

    /// <summary>Запустить экспорт с подписью файла конфигурации</summary>
    /// <param name="settings">Настройки экспорта</param>
    /// <param name="certificate">Сертификат</param>
    /// <param name="password">Пароль сертификата</param>
    /// <returns>Идентификатор сессии экспорта</returns>
    Task<Guid> Export(ConfigExportSettings settings, byte[] certificate, string password);

    /// <summary>Получить новые системные сообщения импорта</summary>
    /// <param name="importUid">Идентификатор сессии импорта</param>
    /// <param name="offset">Количество сообщений, которые уже есть на клиенте</param>
    /// <param name="count">Максимальное количество сообщений, которые надо получить. 0 - чтобы получить все</param>
    Task<IEnumerable<DeploySystemMessage>> GetImportSystemMessages(
      Guid importUid,
      int offset,
      int count = 0);

    /// <summary>
    /// Получить новые системные сообщения проверки конфигурации
    /// </summary>
    /// <param name="testUid">Идентификатор сессии проверки</param>
    /// <param name="offset">Количество сообщений, которые уже есть на клиенте</param>
    /// <param name="count">Максимальное количество сообщений, которые надо получить. 0 - чтобы получить все</param>
    Task<IEnumerable<DeploySystemMessage>> GetTestSystemMessages(
      Guid testUid,
      int offset,
      int count = 0);

    /// <summary>Получить новые сообщения лога проверки конфигурации</summary>
    /// <param name="testUid">Идентификатор сессии проверки</param>
    /// <param name="offset">Количество сообщений, которые уже есть на клиенте</param>
    /// <param name="count">Максимальное количество сообщений, которые надо получить. 0 - чтобы получить все</param>
    Task<IEnumerable<TestImportMessages>> GetTestLog(Guid testUid, int offset, int count = 0);

    /// <summary>Получить новые сообщения лога импорта</summary>
    /// <param name="importUid">Идентификатор сессии импорта</param>
    /// <param name="offset">Количество сообщений, которые уже есть на клиенте</param>
    /// <param name="count">Максимальное количество сообщений, которые надо получить. 0 - чтобы получить все</param>
    Task<IEnumerable<DeployLogMessage>> GetImportLog(Guid importUid, int offset, int count = 0);

    /// <summary>Получить новые сообщения лога</summary>
    /// <param name="exportUid">Идентификатор сессии экспорта</param>
    /// <param name="offset">Количество сообщений, которые уже есть на клиенте</param>
    /// <param name="count">Максимальное количество сообщений, которые надо получить. 0 - чтобы получить все</param>
    Task<IEnumerable<DeployLogMessage>> GetExportLog(Guid exportUid, int offset, int count = 0);

    /// <summary>Получить идентификатор текущего импорта</summary>
    /// <returns>Идентификатор импорта, либо пустой <see cref="T:System.Guid" />, если в данный момент не запущен импорт</returns>
    Task<Guid> GetCurrentImportId();

    /// <summary>Запустить продолжаемый импорт</summary>
    /// <param name="settings">Список настроек импорта</param>
    /// <returns>Идентификатор сессии импорта</returns>
    Task<Guid> ContinuedImport(IEnumerable<IConfigImportSettings> settings);

    /// <summary>
    /// Запустить продолжаемый импорт по списку идентификаторов сессий тестирования
    /// </summary>
    /// <param name="testUids">Список идентификаторов сессий тестирования</param>
    Task<Guid> ContinuedImport(IEnumerable<Guid> testUids);

    /// <summary>
    /// Получить список <see cref="T:EleWise.ELMA.BPMApps.BPMAppFakeManifest" /> для сессии импорта
    /// </summary>
    /// <param name="importUid">Идентификатор сессии импорта</param>
    Task<IEnumerable<BPMAppFakeManifest>> GetImportManifests(Guid importUid);

    /// <summary>
    /// Получить список <see cref="T:EleWise.ELMA.BPMApps.BPMAppFakeManifest" /> для сессий теста
    /// </summary>
    /// <param name="testUids">Список идентификаторов сессий теста</param>
    Task<IEnumerable<BPMAppFakeManifest>> GetTestManifests(IEnumerable<Guid> testUids);

    /// <summary>Импорт требует перезагрузки</summary>
    /// <param name="importUid">Идентификатор сессии импорта</param>
    Task<bool> ImportNeedRestart(Guid importUid);

    /// <summary>Очистить тестовые данные</summary>
    /// <param name="testUid">Идентификатор сессии тестирования</param>
    void ClearTestData(Guid testUid);

    /// <summary>Получить настройки импорта для экземпляра проверки</summary>
    /// <param name="testUid">Идентификатор экземпляра проверки</param>
    Task<IEnumerable<IImportSettings>> GetImportSettings(Guid testUid);

    /// <summary>Получить идентификатор протестированного приложения</summary>
    /// <param name="testUid">Идентификатор сессии теста</param>
    /// <returns>Идентификатор протестированного приложения, либо <see cref="F:System.Guid.Empty" />, если протестировано не приложение</returns>
    Task<string> GetTestedAppId(Guid testUid);

    /// <summary>Получить состояние импорта</summary>
    /// <param name="importUid">Идентификатор сессии импорта</param>
    Task<IContinuedImportState> GetImportState(Guid importUid);

    /// <summary>Получить список тестируемых модулей</summary>
    Task<IReadOnlyCollection<Guid>> GetTestedModules();

    /// <summary>Продолжить выполнение импорта</summary>
    Task ContinueImport();
  }
}
