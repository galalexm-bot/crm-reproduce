// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.IFilePreviewCreator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Files.Previews
{
  /// <summary>Создание превью для файла определенного типа</summary>
  /// <remarks>
  /// <see href="http://www.elma-bpm.ru/kb/article-783.html">Пример реализации в базе знаний</see>
  /// </remarks>
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  [ExtensionPoint(ServiceScope.Application, ComponentType.All)]
  public interface IFilePreviewCreator
  {
    /// <summary>Уникальный идентификатор GUID</summary>
    Guid Uid { get; }

    /// <summary>Отображаемое имя</summary>
    string DisplayName { get; }

    /// <summary>Расширения файлов</summary>
    List<string> Extensions { get; }

    /// <summary>Имя главного файла</summary>
    /// <param name="file">Файл</param>
    /// <returns>Имя главного файла</returns>
    string GetMainFileName(BinaryFile file);

    /// <summary>Имя текстового файла</summary>
    /// <param name="file">Файл</param>
    /// <returns>Имя текстового файла</returns>
    string GetTextFileName(BinaryFile file);

    /// <summary>Относительный путь до главного файла</summary>
    /// <param name="file">Файл</param>
    /// <returns>Относительный путь до главного файла</returns>
    string GetRelativeMainFileName(BinaryFile file);

    /// <summary>Создать превью</summary>
    /// <param name="path">Путь до файла</param>
    /// <param name="file">Файл</param>
    void Create(string path, BinaryFile file);

    /// <summary>Доступен ли для использования</summary>
    /// <param name="file">Файл</param>
    /// <returns><c>true</c>, если доступен для использования</returns>
    bool IsAvaliable(BinaryFile file);

    /// <summary>Имеется ли сгенерированая превью</summary>
    /// <param name="file">Файл</param>
    /// <returns><c>true</c>, если имеется сгенерированная превью</returns>
    bool HasPreview(BinaryFile file);

    /// <summary>Имеется ли сгенерированая превью</summary>
    /// <param name="file">Файл</param>
    /// <param name="priority">Приоритет</param>
    /// <returns><c>true</c>, если имеется сгенерированная превью</returns>
    bool HasPreview(BinaryFile file, long priority);

    /// <summary>
    /// Получение текстового представления превью для индексации
    /// </summary>
    /// <param name="file">Файл</param>
    /// <returns>Текстовое представление превью</returns>
    string GetPreviewText(BinaryFile file);

    /// <summary>Генерируется превью в формате HTML</summary>
    /// <returns><c>true</c>, если генерируется превью в формате html</returns>
    bool EnableGenerateHtml();
  }
}
