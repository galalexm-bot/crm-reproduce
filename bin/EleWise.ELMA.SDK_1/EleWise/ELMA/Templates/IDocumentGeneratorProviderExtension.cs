// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Templates.IDocumentGeneratorProviderExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.TemplateGenerator;
using System.IO;

namespace EleWise.ELMA.Templates
{
  /// <summary>Провайдер генерации документов по шаблону</summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IDocumentGeneratorProviderExtension : IDocumentGeneratorProvider
  {
    /// <summary>Создать генератор</summary>
    /// <param name="templateFileStream">Шаблон файла (поток)</param>
    /// <param name="provider">Провайдер генерации (по умолчанию используется GlobalGeneratorSettings.DefaultProvider)</param>
    DocumentGeneratorBase Create(Stream templateFileStream, IGeneratorProvider provider = null);
  }
}
