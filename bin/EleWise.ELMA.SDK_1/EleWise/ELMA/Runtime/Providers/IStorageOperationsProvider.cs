// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Providers.IStorageOperationsProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Files;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime.Providers
{
  /// <summary>Интерфейс провайдера операций с хранилищем файлов.</summary>
  public interface IStorageOperationsProvider
  {
    /// <summary>
    /// Получить ссылку на местоположение первоисточника контента.
    /// </summary>
    /// <param name="systemFile"></param>
    /// <returns></returns>
    Uri GetSourceContentLocation(SystemFile systemFile);

    /// <summary>Получить размер контента.</summary>
    /// <param name="systemFile">Метаданные постоянно храняимого контента.</param>
    /// <returns>Размер контента, либо null, если контент не существует.</returns>
    long? GetContentSize(SystemFile systemFile);

    /// <summary>
    /// Сохранить контент (переместить в папку постоянного хранения).
    /// </summary>
    /// <param name="srcLocation">Исходное местоположение контента.</param>
    /// <param name="systemFile">Метаданные сохраняемого контента.</param>
    /// <param name="deleteSourceAfterSave">Удалять ли исходный контент после его сохранения в папке постоянного хранения?</param>
    /// <returns>Местоположение сохранённого контента.</returns>
    Uri SaveContent(Uri srcLocation, SystemFile systemFile, bool deleteSourceAfterSave = false);

    /// <summary>
    /// Разместить указанный файл на ближайшей точке хранения (скопирует с источника контента).
    /// </summary>
    /// <param name="systemFile">Метаданные постоянно хранимого файла.</param>
    void FetchContent(SystemFile systemFile);

    /// <summary>
    /// Разместить указанный файл на ближайшей точке хранения асинхронно (скопирует с источника контента).
    /// </summary>
    /// <param name="systemFile">Метаданные постоянно хранимого файла.</param>
    /// <param name="token">Токен отмены.</param>
    /// <returns>Задачу, которая представляет собой работу по размещению файла (копирование из источника на ближайшую точку).</returns>
    Task FetchContentAsync(SystemFile systemFile, CancellationToken token);

    /// <summary>Зашифровать контент.</summary>
    /// <param name="systemFile">Метаданные постоянно хранимого контента.</param>
    /// <param name="password">Пароль.</param>
    /// <returns>Сведения о зашифрованном контенте.</returns>
    BinaryFileContentInfo EncryptContent(SystemFile systemFile, string password);

    /// <summary>Расшифровать контент.</summary>
    /// <param name="systemFile">Метаданные постоянно хранимого контента.</param>
    /// <param name="password">Пароль.</param>
    /// <returns>Сведения о расшифрованном контенте.</returns>
    BinaryFileContentInfo DecryptContent(SystemFile systemFile, string password);

    /// <summary>Открыть поток записи с требуемыми характеристиками.</summary>
    /// <param name="contentInfoHandler">Действие, обрабатывающее сведения о записываемом контенте.</param>
    /// <param name="options">Требуемые характеристики потока.</param>
    /// <returns>Поток.</returns>
    /// <remarks>
    /// При открытии потока на запись внутренний код или удалённая сторона решает, каким будет имя временного файла.
    /// Это имя может быть известно не сразу при открытии потока.
    /// Отсюда и использование делегата contentInfoHandler, роль которого - передать сведения о временном файле вызывающему коду.
    /// </remarks>
    Stream OpenTempContentWriteStream(Action<Uri> contentInfoHandler, PutContentOptions options);

    /// <summary>
    /// Открыть поток чтения для постоянно хранимого файла с требуемыми характеристиками.
    /// </summary>
    /// <param name="systemFile">Метаданные постоянно хранимого файла.</param>
    /// <param name="options">Требуемые характеристики потока.</param>
    /// <returns>Поток.</returns>
    Stream OpenPersistentContentReadStream(SystemFile systemFile, GetContentOptions options);

    /// <summary>
    /// Открыть поток чтения для временного файла с требуемыми характеристиками.
    /// </summary>
    /// <param name="contentLocation">Местоположение временного файла.</param>
    /// <param name="options">Требуемые характеристики потока.</param>
    /// <returns>Поток.</returns>
    Stream OpenTempContentReadStream(Uri contentLocation, GetContentOptions options);

    /// <summary>
    /// Вычислить хеш по указанному алгоритму у постоянно хранимого файла.
    /// </summary>
    /// <param name="systemFile">Метаданные постоянно хранимого файла.</param>
    /// <param name="hashAlgorithm">Алгоритм хеширования.</param>
    /// <returns>Хеш.</returns>
    string GetContentHash(SystemFile systemFile, HashAlogrithmEnum hashAlgorithm);

    /// <summary>
    /// Вычислить хеш по указанному алгоритму у постоянно хранимого файла.
    /// </summary>
    /// <param name="systemFile">Метаданные постоянно хранимого файла.</param>
    /// <param name="hashAlgorithm">Алгоритм хеширования.</param>
    /// <param name="token">Токен отмены.</param>
    /// <returns>Задачу, представляющую собой работу по вычислению хеша.</returns>
    Task<string> GetContentHashAsync(
      SystemFile systemFile,
      HashAlogrithmEnum hashAlgorithm,
      CancellationToken token);
  }
}
