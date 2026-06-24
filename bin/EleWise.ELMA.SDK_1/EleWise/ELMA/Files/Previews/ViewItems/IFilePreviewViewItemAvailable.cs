// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.ViewItems.IFilePreviewViewItemAvailable
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Files.Previews.ViewItems
{
  /// <summary>Доступен ли элемент предпросмотра в конструкторе форм</summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IFilePreviewViewItemAvailable
  {
    /// <summary>Доступен ли элемент предпросмотра в конструкторе форм</summary>
    /// <param name="metadata">Метаданные объекта</param>
    bool IsAvailable(IMetadata metadata);

    /// <summary>Получить файл превью из модели</summary>
    /// <param name="model">Модель представления</param>
    /// <returns>Файл превью</returns>
    BinaryFile GetFile(object model);
  }
}
