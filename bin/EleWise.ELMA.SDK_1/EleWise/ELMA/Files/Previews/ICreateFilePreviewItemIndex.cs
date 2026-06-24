// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.ICreateFilePreviewItemIndex
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System;

namespace EleWise.ELMA.Files.Previews
{
  /// <summary>Точка расширения для индексации предпросмотра файла</summary>
  [ExtensionPoint(ComponentType.All)]
  public interface ICreateFilePreviewItemIndex
  {
    /// <summary>Uid точки расширения</summary>
    Guid Uid { get; }

    /// <summary>
    /// Добавить предпросмотр для файла в очередь на индексацию
    /// </summary>
    /// <param name="file">Файл, предпросмотр которого необходимо проиндексировать</param>
    void AddPreviewToIndexQueue(BinaryFile file);
  }
}
