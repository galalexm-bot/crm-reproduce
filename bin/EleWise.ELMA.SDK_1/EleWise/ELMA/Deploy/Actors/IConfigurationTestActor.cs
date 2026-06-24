// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Actors.IConfigurationTestActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy.Import;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EleWise.ELMA.Deploy.Actors
{
  /// <summary>Интерфейс актора проверки конфигурации для импорта</summary>
  internal interface IConfigurationTestActor : IActorWithGuidKey, IActor
  {
    /// <summary>Запустить проверку конфигурации</summary>
    /// <param name="settings">Настройки импорта</param>
    /// <param name="activateKey">Ключ активации</param>
    /// <param name="storeSettings">Сохранить настройки импорта после теста</param>
    /// <remarks>
    /// При вызове метода с параметром storeSettings = true нужно обеспечить очистку данных.
    /// Для этого надо после завершения работы с актором вызвать метод <see cref="M:EleWise.ELMA.Deploy.Actors.IConfigurationTestActor.Clear" />
    /// Либо, для получения сохраненных настроек и продолжения импорта лучше использовать <see cref="M:EleWise.ELMA.Deploy.Services.IExportImportService.ContinuedImport(System.Collections.Generic.IEnumerable{System.Guid})" />.
    /// Он выполняет очистку данных автоматически.
    /// </remarks>
    Task Test(IConfigImportSettings settings, string activateKey, bool storeSettings);

    /// <summary>Запустить проверку конфигураций модулей</summary>
    /// <param name="settings">Настройки импорта</param>
    /// <param name="activateKey">Ключ активации</param>
    /// <param name="storeSettings">Сохранить настройки импорта после теста</param>
    /// <remarks>
    /// При вызове метода с параметром storeSettings = true нужно обеспечить очистку данных.
    /// Для этого надо после завершения работы с актором вызвать метод <see cref="M:EleWise.ELMA.Deploy.Actors.IConfigurationTestActor.Clear" />
    /// Либо, для получения сохраненных настроек и продолжения импорта лучше использовать <see cref="M:EleWise.ELMA.Deploy.Services.IExportImportService.ContinuedImport(System.Collections.Generic.IEnumerable{System.Guid})" />.
    /// Он выполняет очистку данных автоматически.
    /// </remarks>
    Task TestModules(
      IEnumerable<IConfigImportSettings> settings,
      string activateKey,
      bool storeSettings);

    /// <summary>Получить новые системные сообщения</summary>
    /// <param name="offset">Количество сообщений, которые уже есть на клиенте</param>
    /// <param name="count">Максимальное количество сообщений, которые надо получить. 0 - чтобы получить все</param>
    Task<IEnumerable<DeploySystemMessage>> GetSystemMessages(int offset, int count);

    /// <summary>Получить новые сообщения лога</summary>
    /// <param name="offset">Количество сообщений, которые уже есть на клиенте</param>
    /// <param name="count">Максимальное количество сообщений, которые надо получить. 0 - чтобы получить все</param>
    Task<IEnumerable<TestImportMessages>> GetLog(int offset, int count);

    /// <summary>Получить настройки для которых выполнено тестирование</summary>
    Task<IConfigImportSettings[]> GetTestedSettings();

    /// <summary>
    /// Получить настройки, для которых выполнено тестирование, проверенные на актуальность.
    /// <br />
    /// <b>Важно:</b> Если после получения настроек, их не нужно больше хранить в акторе, то нужно вызвать метод <see cref="M:EleWise.ELMA.Deploy.Actors.IConfigurationTestActor.Clear" />.
    /// <br />
    /// Для получения сохраненных настроек и продолжения импорта лучше использовать <see cref="M:EleWise.ELMA.Deploy.Services.IExportImportService.ContinuedImport(System.Collections.Generic.IEnumerable{System.Guid})" />.
    /// <br />
    /// Он выполняет очистку данных автоматически.
    /// </summary>
    /// <returns>Настройки тестирования</returns>
    Task<IConfigImportSettings[]> GetTestedSettingsWithCheck();

    /// <summary>
    /// Получить <see cref="T:EleWise.ELMA.BPMApps.BPMAppFakeManifest" /> для протестированных настроек
    /// </summary>
    Task<BPMAppFakeManifest[]> GetFakeManifest();

    /// <summary>Очистить данные связанные с тестированием</summary>
    /// <returns></returns>
    Task Clear();

    /// <summary>Получить идентификатор протестированного приложения</summary>
    /// <returns>Идентификатор протестированного приложения, либо <c>null</c>, если протестировано не приложение</returns>
    Task<string> GetAppId();
  }
}
