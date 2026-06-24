// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.ICacheFilesService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using System;
using System.IO;

namespace EleWise.ELMA.Services
{
  /// <summary>Сервис для работы с временными файлами</summary>
  [DeveloperApi(DeveloperApiType.Service)]
  public interface ICacheFilesService
  {
    /// <summary>Удалить временный файл</summary>
    /// <param name="uid">Идентификатор временного файла</param>
    /// <returns></returns>
    bool DeleteByUid(Guid uid);

    /// <summary>Создание записи о новом временном файле</summary>
    /// <param name="fileName">Имя файла</param>
    /// <returns>Идентификатор временного файла</returns>
    Guid CreateCacheFile(string fileName);

    /// <summary>
    /// Создание записи о новом временном файле с предустановленым uid'ом
    /// </summary>
    /// <param name="uid">Идентификатор временного файла</param>
    /// <param name="fileName">Имя файла</param>
    /// <returns></returns>
    bool CreateCacheFileByUid(Guid uid, string fileName);

    /// <summary>Добавление информации в файл из потока</summary>
    /// <param name="uid">Идентификатор временного файла</param>
    /// <param name="inputStream">Входной поток. Должен быть подготовлен для чтения данных (установлен на нужную позицию)</param>
    /// <param name="startPos">Позиция в теле временного файла, с которой надо начинать запись</param>
    /// <param name="endPos">Позиция в теле временного файла, до которой надо вести запись. Должна быть больше <paramref name="startPos" /></param>
    /// <returns><c>true</c>, если запись завершилась удачно</returns>
    /// <exception cref="T:System.ArgumentException">Невозможно начать чтение из потока</exception>
    /// <exception cref="T:System.ArgumentNullException"><paramref name="inputStream" /> равен <c>null</c></exception>
    bool IncrementCacheFile(Guid uid, Stream inputStream, long startPos = 0, long endPos = 9223372036854775807);

    /// <summary>Добавление информации в файл</summary>
    /// <param name="uid">Идентификатор временного файла</param>
    /// <param name="buf">Буффер с данными</param>
    /// <param name="startPos">Позиция в теле временного файла, с которой надо начинать запись</param>
    /// <param name="endPos">Позиция в теле временного файла, до которой надо вести запись. Должна быть больше <paramref name="startPos" /></param>
    /// <returns><c>true</c>, если запись завершилась удачно</returns>
    /// <exception cref="T:System.ArgumentNullException"><paramref name="buf" /> равен <c>null</c></exception>
    bool IncrementCacheFile(Guid uid, byte[] buf, long startPos = 0, long endPos = 9223372036854775807);

    /// <summary>Добавление информации в конец файла</summary>
    /// <param name="uid">Идентификатор временного файла</param>
    /// <param name="buf">Буффер с данными</param>
    /// <param name="cnt">Количество данных для чтения из буфера</param>
    /// <returns><c>true</c>, если запись завершилась удачно</returns>
    /// <exception cref="T:System.ArgumentNullException"><paramref name="buf" /> равен <c>null</c></exception>
    bool AppendCacheFile(Guid uid, byte[] buf, int cnt);

    /// <summary>Добавление информации в конец файла из потока</summary>
    /// <param name="uid">Идентификатор временного файла</param>
    /// <param name="inputStream">Входной поток. Должен быть подготовлен для чтения данных (установлен на нужную позицию)</param>
    /// <returns><c>true</c>, если запись завершилась удачно</returns>
    /// <exception cref="T:System.ArgumentException">Невозможно начать чтение из потока</exception>
    /// <exception cref="T:System.ArgumentNullException"><paramref name="inputStream" /> равен <c>null</c></exception>
    bool AppendCacheFile(Guid uid, Stream inputStream);

    /// <summary>Получить имя файла</summary>
    /// <param name="uid">Идентификатор временного файла</param>
    /// <returns>Имя файла</returns>
    string GetFileName(Guid uid);

    /// <summary>Получить локальный путь до временного файла</summary>
    /// <param name="uid">Идентификатор временного файла</param>
    /// <returns>Локальный путь</returns>
    string GetFilePath(Guid uid);

    /// <summary>Получить размер временного файла</summary>
    /// <param name="uid">Идентификатор временного файла</param>
    /// <returns>Размер файла</returns>
    long GetFileLength(Guid uid);
  }
}
