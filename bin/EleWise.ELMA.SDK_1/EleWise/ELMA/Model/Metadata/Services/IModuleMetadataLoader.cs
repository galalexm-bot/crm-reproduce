// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Services.IModuleMetadataLoader
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Metadata.Services
{
  /// <summary>Загрузчик метаданных модулей</summary>
  internal interface IModuleMetadataLoader
  {
    /// <summary>
    /// Загрузить версию модуля по умолчанию (самая свежая опубликованную)
    /// </summary>
    /// <param name="moduleUid">Идентификатор модуля</param>
    /// <param name="published">Только активированные/опубликованные модули</param>
    /// <returns>Модуль</returns>
    ModuleVersion GetDefaultModuleVersion(Guid moduleUid, bool published = true);

    /// <summary>Загрузить конкретную версию модуля</summary>
    /// <param name="moduleUid">Идентификатор модуля</param>
    /// <param name="versionUid">Идентификатор версии модуля</param>
    /// <returns>Модуль</returns>
    ModuleVersion GetSpecificModuleVersion(Guid moduleUid, Guid versionUid);

    /// <summary>Получить сигнатуры всех версий модуля</summary>
    /// <param name="moduleUid">Идентификатор метаданных модуля</param>
    /// <param name="published">Только активированные/опубликованные модули</param>
    /// <returns>Версии модуля</returns>
    IReadOnlyCollection<ModuleVersionHeader> GetModuleVersionHeaders(Guid moduleUid, bool published = true);

    /// <summary>
    /// Загрузить все версии по умолчанию для всех модулей (только опубликованные)
    /// </summary>
    /// <param name="excluded">Модули не включаемые в выборку</param>
    /// <param name="published">Только активированные/опубликованные модули</param>
    /// <returns>Версии модулей</returns>
    [Obsolete("TODO: ELMA4-6475 Убрать после оптимизации загрузки модулей для поиска точек расширения и реализаций", false)]
    IReadOnlyCollection<ModuleVersion> GetAllDefaultVersions(
      IEnumerable<Guid> excluded,
      bool published = true);

    /// <summary>
    /// Получить заголовки всех последних опубликованных версии модулей
    /// </summary>
    /// <param name="notLoaded">Список идентификаторов заголовков модулей, которые не нужно загружать</param>
    /// <returns>Список заголовков последних версий</returns>
    IEnumerable<ModuleMetadataItemWrapper> GetLastPublishedHeaders(IEnumerable<Guid> notLoaded);

    /// <summary>Проверить является ли модуль системным</summary>
    /// <param name="moduleUid">Идентификатор метаданных модуля</param>
    /// <returns><c>True</c> если системный</returns>
    bool IsSystemModule(Guid moduleUid);
  }
}
