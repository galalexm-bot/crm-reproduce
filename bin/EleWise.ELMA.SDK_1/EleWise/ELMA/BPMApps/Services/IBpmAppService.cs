// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPMApps.Services.IBpmAppService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps.DTO.Models;
using EleWise.ELMA.Deploy.Export;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.BPMApps.Services
{
  /// <summary>Сервис управления BpmApp</summary>
  public interface IBpmAppService
  {
    /// <summary>Получить все приложения</summary>
    IEnumerable<BPMAppDTO> LoadAll();

    /// <summary>Сохранить</summary>
    /// <param name="bpmApp">Приложение</param>
    /// <param name="helpFileContent">Данные файла документации</param>
    /// <param name="additionalFilesContent">Данные дополнительных файлов</param>
    BPMAppDTO Save(BPMAppDTO bpmApp, byte[] helpFileContent, byte[] additionalFilesContent);

    /// <summary>Сохранить</summary>
    /// <param name="bpmApp">Приложение</param>
    BPMAppDTO Save(BPMAppDTO bpmApp);

    /// <summary>Удалить приложение</summary>
    /// <param name="id">Идентификатор приложения</param>
    void Delete(long id);

    /// <summary>Загрузить файлы приложения</summary>
    /// <param name="id">Идентификатор приложения</param>
    /// <param name="helpFileContent">Данные файла документации</param>
    /// <param name="additionalFilesContent">Данные дополнительных файлов</param>
    void LoadFiles(long id, out byte[] helpFileContent, out byte[] additionalFilesContent);

    /// <summary>Получить настройки экспорта для приложения</summary>
    /// <param name="uid">Идентификатор приложения</param>
    /// <param name="settingsFilename">Идентификатор файла настроек</param>
    ConfigExportSettings GetAppExportSettings(Guid uid, Guid settingsFilename);

    /// <summary>
    /// Загрузить файлы приложения в кэш бинарных файлов (в текущий момент это файлы с инструкциями к BpmApp)
    /// </summary>
    /// <param name="input">Идентификатор приложения</param>
    /// <returns>Guid папки в кэш-е</returns>
    FilesLoadToCacheResult PutBpmAppFilesToCache(FilesLoadToCacheInput input);
  }
}
