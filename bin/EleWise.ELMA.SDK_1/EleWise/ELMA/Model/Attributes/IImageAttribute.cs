// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.IImageAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Drawing;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Интерфейс атрибута, определяющего изображение для какого-либо элемента
  /// </summary>
  public interface IImageAttribute
  {
    /// <summary>Размер изображения</summary>
    int Size { get; }

    /// <summary>Является ли изображением по умолчанию</summary>
    bool IsDefault { get; }

    /// <summary>
    /// Создать изображение. После использования необходимо уничтожить.
    /// </summary>
    Image CreateImage();
  }
}
