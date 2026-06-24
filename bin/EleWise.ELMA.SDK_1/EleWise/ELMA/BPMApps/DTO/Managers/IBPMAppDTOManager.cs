// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPMApps.DTO.Managers.IBPMAppDTOManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps.DTO.Models;
using EleWise.ELMA.ExtensionPoints;
using System.Collections.Generic;

namespace EleWise.ELMA.BPMApps.DTO.Managers
{
  /// <summary>Менеджер BPMAppDTO</summary>
  public interface IBPMAppDTOManager : IConfigurationService
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
  }
}
