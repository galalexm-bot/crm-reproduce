// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.ITextContentExtractor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using System.IO;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>Извлечение текстового содержимого из контента.</summary>
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  [ExtensionPoint(ServiceScope.Application, ComponentType.All)]
  public interface ITextContentExtractor : IFileContentLoader
  {
    /// <summary>
    /// Получение текстового содержимого из потока. При завершении извлечения текста поток будет закрыт и уничтожен.
    /// </summary>
    /// <param name="stream">Поток с неким контентом.</param>
    /// <returns>Текстовое содержимое контента.</returns>
    string GetText(Stream stream);
  }
}
