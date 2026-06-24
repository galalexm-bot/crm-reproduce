// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Templates.TextTemplateGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Templates.TemplateGenerator;
using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.DataSources;
using j3AmrhgkCleVTGdEwA;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Templates
{
  /// <summary>Генератор текста по шаблону на языке ADL</summary>
  public class TextTemplateGenerator : TextGenerator
  {
    private TemplateRenderMode renderMode;
    internal static TextTemplateGenerator HTHFIvBNVhZsf6Nvgs5J;

    /// <summary>Ctor</summary>
    /// <param name="template">Шаблон</param>
    /// <param name="provider">Провайдер генерации</param>
    /// <param name="renderMode">Режим генерации</param>
    public TextTemplateGenerator(
      string template,
      IGeneratorProvider provider = null,
      TemplateRenderMode renderMode = TemplateRenderMode.Default)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      string template1 = template;
      IGeneratorProvider generatorProvider = provider;
      IGeneratorProvider provider1 = generatorProvider == null ? (IGeneratorProvider) new ElmaGeneratorProvider() : generatorProvider;
      // ISSUE: explicit constructor call
      base.\u002Ector(template1, provider1);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.renderMode = renderMode;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Создать контекст генерации</summary>
    /// <param name="dataSource">Источник данных</param>
    /// <returns>Контекст генерации</returns>
    protected override GenerationContext CreateGenerationContext(IGeneratorDataSource dataSource)
    {
      object context = TextTemplateGenerator.J8MfWKBNRIXG2iCgGF6l((object) this, (object) dataSource);
      ((GenerationContext) context).SetRenderMode(this.renderMode);
      return (GenerationContext) context;
    }

    /// <summary>Режим генерации</summary>
    protected TemplateRenderMode RenderMode => this.renderMode;

    internal static bool bH58YPBNSFTmrXXwuUFi() => TextTemplateGenerator.HTHFIvBNVhZsf6Nvgs5J == null;

    internal static TextTemplateGenerator bKJ98lBNiaq2F1glEbUo() => TextTemplateGenerator.HTHFIvBNVhZsf6Nvgs5J;

    internal static object J8MfWKBNRIXG2iCgGF6l([In] object obj0, [In] object obj1) => (object) __nonvirtual (((GeneratorBase) obj0).CreateGenerationContext((IGeneratorDataSource) obj1));
  }
}
