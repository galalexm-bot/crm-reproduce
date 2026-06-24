// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Managers.IContinuedImportService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Files;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Deploy.Managers
{
  /// <summary>Интерфейс сервиса непрерывного импорта</summary>
  /// <remarks>Обеспечивает функционал непрерывного одноинстансного импорта</remarks>
  public interface IContinuedImportService
  {
    /// <summary>Вызов полного цикла импорта конфигурации</summary>
    /// <param name="testUids">Список идентификаторов сессий тестирования</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Идентификатор экземпляра импорта</returns>
    Task<Guid> Import(IEnumerable<Guid> testUids, CancellationToken cancellationToken);

    /// <summary>Получить список манифестов текущего импорта</summary>
    /// <param name="uid">Идентификатор импорта</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Манифесты</returns>
    Task<IEnumerable<BPMAppFakeManifest>> GetImportManifests(
      Guid uid,
      CancellationToken cancellationToken);

    /// <summary>Проверка файла импорта</summary>
    /// <param name="configFile">Файл конфигурации</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Идентификаторы тестирования</returns>
    Task<IEnumerable<Guid>> Test(BinaryFile configFile, CancellationToken cancellationToken);

    /// <summary>Проверка файла импорта</summary>
    /// <param name="configFile">Файл конфигурации</param>
    /// <param name="activationKey">Ключ активации</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Идентификаторы тестирования</returns>
    Task<IEnumerable<Guid>> Test(
      BinaryFile configFile,
      string activationKey,
      CancellationToken cancellationToken);

    /// <summary>
    /// Получить список последних сообщений о ходе проверки импорта
    /// </summary>
    /// <param name="testUid">Идентификатор экземпляра проверки</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Список сообщений</returns>
    Task<List<TestImportMessages>> GetTestLog(Guid testUid, CancellationToken cancellationToken);

    /// <summary>Получить настройки импорта для экземпляра проверки</summary>
    /// <param name="testUid">Идентификатор экземпляра проверки</param>
    Task<IEnumerable<IImportSettings>> GetImportSettings(Guid testUid);
  }
}
