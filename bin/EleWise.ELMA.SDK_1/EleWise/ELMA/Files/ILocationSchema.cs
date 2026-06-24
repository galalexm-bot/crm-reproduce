// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.ILocationSchema
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Files
{
  /// <summary>
  /// Схема сопоставления метаданных контента в ссылки на его местоположение.
  /// </summary>
  public interface ILocationSchema
  {
    /// <summary>
    /// Превратить метаданные о постоянно хранимом контенте в ссылку на его местоположение.
    /// </summary>
    /// <param name="systemFile">Метаданные о постоянно хранимом контенте.</param>
    /// <returns>Ссылку на местоположение постоянно хранимого контента.</returns>
    Uri MapPersistentLocation(SystemFile systemFile);

    /// <summary>
    /// По уникальному идентификатору временного контента и расширению файла получить ссылку на местоположение временного контента.
    /// </summary>
    /// <param name="uid">Уникальный идентификатор временного контента. Если указать null, то метод сам сгенерирует идентификатор.</param>
    /// <param name="extension">Расширение временного файла контента.</param>
    /// <returns>Ссылка на местоположение временного контента.</returns>
    Uri MapTempLocation(string uid, string extension);

    /// <summary>
    /// Явно сгенерировать случайную ссылку на местоположение временного контента.
    /// </summary>
    /// <param name="extension">Расширение временного файла контента.</param>
    /// <returns>Ссылка на местоположение временного контента.</returns>
    Uri CreateNewTempLocation(string extension = null);

    /// <summary>
    /// Перебазировать (сменить точку хранения) исходную ссылку на местоположение исходя из текущей схемы сопоставления.
    /// </summary>
    /// <param name="location">Исходная ссылка на местоположение контента.</param>
    /// <returns>Модифицированная ссылка на местоположение контента.</returns>
    Uri RemapTempLocationFor(Uri location);

    /// <summary>
    /// Превратить уникальный идентификатор контента и путь контента в ссылку на местоположение ресурса предпросмотра.
    /// </summary>
    /// <param name="uid">Уникальный идентификатор контента.</param>
    /// <param name="contentPath">Относительный путь к контенту предпросмотра.</param>
    /// <returns>Ссылка на местоположение контента предпросмотра.</returns>
    Uri MapPreviewLocation(string uid, string contentPath);
  }
}
