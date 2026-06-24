// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.IPasswordFilePreviewCreatorEx
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Diagnostics;

namespace EleWise.ELMA.Files.Previews
{
  /// <summary>
  /// Расширение IPasswordFilePreviewCreator (добавлена поддержка запуска внешних генераторов файлов предпросмотра)
  /// </summary>
  public interface IPasswordFilePreviewCreatorEx : 
    IFilePreviewCreatorEx,
    IFilePreviewCreator,
    IPasswordFilePreviewCreator
  {
    /// <summary>
    /// Создать файл предпросмотра используя внешний генератор
    /// </summary>
    /// <param name="filePreviewDir">Путь до директории предпросмотра</param>
    /// <param name="file">Файл</param>
    /// <param name="password">Пароль для расшифровки файла</param>
    /// <returns>Процесс внешнего генератора</returns>
    Process CreateWithExternalCreator(string filePreviewDir, BinaryFile file, string password);
  }
}
