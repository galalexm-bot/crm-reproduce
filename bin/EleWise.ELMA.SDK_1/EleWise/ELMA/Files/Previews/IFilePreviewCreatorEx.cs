// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.IFilePreviewCreatorEx
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using System.Diagnostics;

namespace EleWise.ELMA.Files.Previews
{
  /// <summary>
  /// Расширение IFilePreviewCreator (добавлена поддержка запуска внешних генераторов файлов предпросмотра)
  /// </summary>
  [ExtensionPoint(ServiceScope.Application, ComponentType.All)]
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  public interface IFilePreviewCreatorEx : IFilePreviewCreator
  {
    /// <summary>
    /// Полное наименование исполняемого файла внешнего генератора предпросмотра
    /// </summary>
    string ExternalCreatorFileName { get; }

    /// <summary>
    /// Полное наименование исполняемого файла внешнего генератора предпросмотра
    /// </summary>
    /// <param name="file"></param>
    /// <returns></returns>
    string GetExternalCreatorFileName(BinaryFile file);

    /// <summary>Требуется внешний генератор файла предпросмотра</summary>
    /// <returns><с>true</с>, если требуется внешний генератор файла предпросмотра</returns>
    bool RequiredExternalCreator { get; }

    /// <summary>
    /// Создать файл предпросмотра используя внешний генератор
    /// </summary>
    /// <param name="filePreviewDir">Путь до директории предпросмотра</param>
    /// <param name="file">Файл</param>
    /// <returns>Процесс внешнего генератора</returns>
    Process CreateWithExternalCreator(string filePreviewDir, BinaryFile file);
  }
}
