// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Templates.TemplateGenerator.ITemplateGeneratorFormatter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.TemplateGenerator;

namespace EleWise.ELMA.Templates.TemplateGenerator
{
  /// <summary>
  /// Провайдер форматирования значения для определенного режима генерации
  /// </summary>
  [ExtensionPoint(ComponentType.All)]
  public interface ITemplateGeneratorFormatter
  {
    /// <summary>Форматировать значение в строку</summary>
    /// <param name="context">Контекст процесса генерации</param>
    /// <param name="value">Значение</param>
    /// <param name="renderMode">Режим генерации</param>
    /// <returns>Форматированное значение. Если возвращается null, то используется следующий провайдер (или стандартный)</returns>
    string FormatValue(
      GenerationContext context,
      FormatedValue value,
      TemplateRenderMode renderMode);
  }
}
