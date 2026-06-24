// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Services.IAdditionalFilesService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Packaging.ElmaStoreManifest;

namespace EleWise.ELMA.Deploy.Services
{
  /// <summary>Сервис работы с дополнительными файлами</summary>
  public interface IAdditionalFilesService
  {
    /// <summary>
    /// Получить путь до файла инструкции во временной папке экспорта-импорта
    /// </summary>
    /// <param name="fileName">Имя временного файла</param>
    /// <param name="helpFileName">Имя файла инструкции</param>
    string GetHelpFilePath(string fileName, string helpFileName);

    /// <summary>
    /// Получить путь до папки постоянного хранения дополнительных файлов конфигурации
    /// </summary>
    /// <param name="manifest">Манифест</param>
    string GetStoreAdditionalFilesPath(ElmaStoreComponentManifest manifest);

    /// <summary>
    /// Получить сообщение о пути до папки постоянного хранения дополнительных файлов конфигурации
    /// </summary>
    /// <param name="manifest">Манифест</param>
    string GetStoreAdditionalFilesPathMessage(ElmaStoreComponentManifest manifest);
  }
}
