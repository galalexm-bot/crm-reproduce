// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Services.IModuleMetadataExtractorService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Model.Metadata;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Services
{
  /// <summary>Сервис извлечения данных о модулях из nuget пакетов</summary>
  internal interface IModuleMetadataExtractorService
  {
    /// <summary>Получить данные о модулях</summary>
    /// <param name="importSettings">Настройки импорта</param>
    IEnumerable<ModuleVersion> ExtractModules(IConfigImportSettings importSettings);

    /// <summary>Получить данные о модулях</summary>
    /// <param name="filePath">Файл импорта .elma4</param>
    IEnumerable<ModuleVersion> ExtractModules(string filePath);
  }
}
