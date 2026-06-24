// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Services.IExportImportFileService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Files;
using System;

namespace EleWise.ELMA.Deploy.Services
{
  /// <summary>Интерфейс сервиса передачи файлов экспорта-импорта</summary>
  public interface IExportImportFileService
  {
    /// <summary>Получить имя папки временных файлов экспорта-импорта</summary>
    string GetFilesFolderName();

    /// <summary>
    /// Получить полное имя папки временных файлов экспорта-импорта
    /// </summary>
    string GetFilesFolderPath();

    /// <summary>
    /// Размер буфера для передачи данных между сервером и дизайнером
    /// </summary>
    /// <returns></returns>
    long GetBufferLength();

    /// <summary>Создание имени файла</summary>
    string CreateFileName(string id, string name, string ext);

    /// <summary>Создание имени файла</summary>
    string CreateFileName(string id, string folder, string name, string ext);

    /// <summary>Создание имени файла-архива</summary>
    string CreateZipFileName(string id);

    /// <summary>Создание имени файла-архива</summary>
    string CreateZipFileName(string id, string ext);

    /// <summary>Создание имени временной папки</summary>
    string CreateFolderName(string id);

    /// <summary>Создание имени экспорта-импорта во временной папке</summary>
    string CreateDeployFolderName(string id);

    /// <summary>Создание имени экспорта-импорта во временной папке</summary>
    string CreateDeployFolderName(string id, string folder);

    /// <summary>Добавление файла из BinaryFile</summary>
    /// <param name="id">Имя временного файла</param>
    /// <param name="file">Файл</param>
    void AddToFile(string id, BinaryFile file);

    /// <summary>Добавление части файла в файл на сервере</summary>
    /// <param name="id"></param>
    /// <param name="buf"></param>
    void AddToFile(string id, byte[] buf);

    /// <summary>Добавление части вложеного файла в файл на сервере</summary>
    void AddToNestedFile(string id, string nestedId, string path, byte[] buf);

    /// <summary>Добавление части вложеного файла в файл на сервере</summary>
    /// <param name="id">Идентификатор</param>
    /// <param name="nestedId">Следующий идентификатор</param>
    /// <param name="fileExtension">Расширение файла</param>
    /// <param name="path">Путь</param>
    /// <param name="buf">Сохраняемый массив байтов</param>
    void AddToNestedFile(
      string id,
      string nestedId,
      string fileExtension,
      string path,
      byte[] buf);

    /// <summary>Загрузка части файла с сервера</summary>
    /// <param name="id"></param>
    /// <returns></returns>
    byte[] LoadFile(string id, long i);

    /// <summary>Загрузка части файла с сервера</summary>
    /// <param name="id"></param>
    /// <returns></returns>
    byte[] LoadFile(string id, long i, string ext);

    /// <summary>Удаление файлов</summary>
    /// <param name="id"></param>
    void DeleteFiles(string id);

    /// <summary>Удаление файлов</summary>
    /// <param name="id"></param>
    void DeleteFiles(string id, string ext);

    /// <summary>Загрузка файла в CacheFilesService</summary>
    /// <param name="fileName"></param>
    /// <param name="fullFileName"></param>
    /// <param name="uid"></param>
    void LoadFileToCache(string fileName, string fullFileName, Guid uid);

    /// <summary>Проверить существования файла</summary>
    bool Exists(string id, string ext);

    /// <summary>Проверить существования файла</summary>
    bool Exists(string id);
  }
}
