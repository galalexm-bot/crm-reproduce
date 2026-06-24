// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Managers.ITemplateFileManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Files;

namespace EleWise.ELMA.Runtime.Managers
{
  /// <summary>Менеджер файлов шаблонов</summary>
  public interface ITemplateFileManager
  {
    /// <summary>Сохранить файл шаблона</summary>
    /// <param name="binaryFile">Файл</param>
    /// <returns>Идентификатор в строковом представлении</returns>
    string SaveTemplate(BinaryFile binaryFile);

    /// <summary>Загрузить файл шаблона</summary>
    /// <param name="id">Идентификатор файла</param>
    /// <returns>Загруженный файл</returns>
    BinaryFile LoadTemplate(string id);

    /// <summary>Создать файл из шаблона (скопировать шаблон как файл)</summary>
    /// <param name="id">Идентификатор файла шаблона</param>
    /// <returns></returns>
    BinaryFile CreateFromTemplate(string id);

    /// <summary>Получить серверный путь до файла шаблона</summary>
    /// <param name="id">Идентификатор файла</param>
    /// <returns>Серверный путь до файла шаблона</returns>
    string GetTemplateFileServerPath(string id);
  }
}
