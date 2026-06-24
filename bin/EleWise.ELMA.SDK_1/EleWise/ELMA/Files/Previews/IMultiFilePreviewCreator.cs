// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.IMultiFilePreviewCreator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Collections.Generic;

namespace EleWise.ELMA.Files.Previews
{
  /// <summary>
  ///  Создание превью из нескольких файлов для файла определенного типа
  /// </summary>
  internal interface IMultiFilePreviewCreator
  {
    /// <summary>Список файлов в превью</summary>
    /// <param name="file">Файл</param>
    IEnumerable<string> GetPreviewFilesList(BinaryFile file);

    /// <summary>
    /// Размер файлов учавствующих в формировании текста превью
    /// </summary>
    /// <param name="file">Файл</param>
    long GetTextPreviewFilesSize(BinaryFile file);
  }
}
