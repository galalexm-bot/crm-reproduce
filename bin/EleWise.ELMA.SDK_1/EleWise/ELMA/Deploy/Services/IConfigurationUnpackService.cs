// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Services.IConfigurationUnpackService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Files;
using EleWise.ELMA.Logging;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Services
{
  /// <summary>Сервис получения настроек импорта из файла импорта</summary>
  public interface IConfigurationUnpackService
  {
    /// <summary>Получить настройки импорта</summary>
    /// <param name="file">Файл импорта</param>
    /// <param name="logger">Логер</param>
    /// <param name="checkManifests">Проверить манифесты компонетов на совместимость с текущей конфигурацией</param>
    /// <param name="tagFilter">Отфильтровать несовместимые компоненты по тегам манифеста</param>
    IEnumerable<IConfigImportSettings> Unpack(
      BinaryFile file,
      ILogger logger = null,
      bool checkManifests = true,
      bool tagFilter = true);

    /// <summary>Отфильтровать настройки импорта по тегам манифеста</summary>
    /// <param name="importSettings">Настройки импорта</param>
    /// <returns>Отфильтрованные настройки импорта</returns>
    IEnumerable<IConfigImportSettings> FilterByTags(
      IEnumerable<IConfigImportSettings> importSettings);

    /// <summary>
    /// Валидировать настройки по наличию зависимостей в системе
    /// </summary>
    /// <param name="importSettings">Настройки импорта</param>
    /// <exception cref="T:EleWise.ELMA.Exceptions.ConfigurationUnpackException">При несовместимости</exception>
    void ValidateComponents(IEnumerable<IConfigImportSettings> importSettings);
  }
}
