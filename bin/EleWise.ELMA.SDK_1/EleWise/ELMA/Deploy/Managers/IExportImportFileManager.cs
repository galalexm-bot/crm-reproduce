// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Managers.IExportImportFileManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using System;

namespace EleWise.ELMA.Deploy.Managers
{
  /// <summary>
  /// Интерфейс менеджера для работы с ExportImportFileService через дизайнер
  /// </summary>
  public interface IExportImportFileManager : IConfigurationService
  {
    /// <summary>
    /// Размер буфера для передачи данных между сервером и дизайнером
    /// </summary>
    /// <returns></returns>
    long GetBufferLength();

    /// <summary>Создание имени временной папки</summary>
    string CreateFolderName(string id);

    /// <summary>Создание имени экспорта-импорта во временной папке</summary>
    string CreateDeployFolderName(string id);

    /// <summary>Создание имени файла-архива</summary>
    string CreateZipFileName(string id);

    /// <summary>Создание имени файла</summary>
    string CreateFileName(string id);

    /// <summary>Создание имени файла</summary>
    string CreateFileName(string id, string name, string ext);

    /// <summary>Загрузка части файла с сервера</summary>
    /// <param name="id"></param>
    /// <returns></returns>
    byte[] LoadFile(string id, long i);

    /// <summary>Удаление файлов</summary>
    /// <param name="id"></param>
    void DeleteFiles(string id);

    /// <summary>Добавление части файла в файл на сервере</summary>
    /// <param name="id"></param>
    /// <param name="buf"></param>
    void AddToFile(string id, byte[] buf);

    /// <summary>Добавление части файла во вложенный файл на сервере</summary>
    void AddToNestedFile(string id, string nestedId, string path, byte[] buf);

    /// <summary>Загрузка файла в CacheFilesService</summary>
    /// <param name="fileName"></param>
    /// <param name="fullFileName"></param>
    /// <param name="uid"></param>
    void LoadFileToCache(string fileName, string fullFileName, Guid uid);
  }
}
