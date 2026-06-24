// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Templates.GlobalValueTemplateGenerator.IElmaParserGlobalValue
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.TemplateGenerator;

namespace EleWise.ELMA.Templates.GlobalValueTemplateGenerator
{
  /// <summary>
  /// Получение значения по текстовому представлению содержимого
  /// </summary>
  [ExtensionPoint(ComponentType.WebServer)]
  public interface IElmaParserGlobalValue
  {
    /// <summary>
    /// Получение значения по текстовому представлению содержимого
    /// </summary>
    /// <returns></returns>
    FormatedValue Parse(string[] propertyNames);
  }
}
