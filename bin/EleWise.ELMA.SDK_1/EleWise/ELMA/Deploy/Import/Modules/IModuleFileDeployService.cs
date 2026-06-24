// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.Modules.IModuleFileDeployService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Files;
using EleWise.ELMA.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EleWise.ELMA.Deploy.Import.Modules
{
  /// <summary>Сервис развертывания модуля из файлового контейнера</summary>
  public interface IModuleFileDeployService
  {
    /// <summary>Установить модуль в систему</summary>
    /// <param name="container">Контейнер экспорта/импорта, обычно BpmApp</param>
    /// <param name="logger">Лог развертывания</param>
    /// <remarks>
    /// В качестве файлового контейнера для модуля используется BPMApp, для приложения - комплексный BPMApp.
    /// </remarks>
    /// <exception cref="T:EleWise.ELMA.Deploy.Import.FilesImportExtension">Файл-контейнер не найден</exception>
    /// <exception cref="T:EleWise.ELMA.Deploy.Import.Modules.ModuleValidationException">Файл-контейнер не содержит валидный модуль/приложение</exception>
    /// <exception cref="T:EleWise.ELMA.Deploy.Import.Modules.ModuleDeployException">При развертывании произошли ошибки</exception>
    Task Deploy(BinaryFile container, ILogger logger = null);

    /// <summary>
    /// Проверка, является ли импортируемая конфигурация модулем
    /// </summary>
    /// <param name="importSettings">Настройки импорта</param>
    bool IsModule(
      IReadOnlyCollection<IConfigImportSettings> importSettings);

    /// <summary>Тестирование импорта модулей</summary>
    /// <param name="importSettings">Настройки импорта</param>
    /// <remarks>
    /// Если импортируется приложение - ожидается неизмененный неотфильтрованный список всех модулей.
    /// Все необходимые проверки совместимости будут произведены внутри
    /// </remarks>
    /// <remarks>Результат будет возвращен без ожидания окончания импорта</remarks>
    /// <returns>Список идентификаторов сессий теста</returns>
    Task<IEnumerable<Guid>> Test(
      IReadOnlyCollection<IConfigImportSettings> importSettings);

    /// <summary>Импорт модулей</summary>
    /// <param name="importSettings">Настройки импорта</param>
    Task Import(
      IReadOnlyCollection<IConfigImportSettings> importSettings);
  }
}
