// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Templates.TemplateGenerator.ElmaGeneratorProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.DataSources;
using EleWise.TemplateGenerator.Formats;
using EleWise.TemplateGenerator.Functions;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Templates.TemplateGenerator
{
  /// <summary>Провайдер генерации с поддержкой специфики ELMA SDK</summary>
  public class ElmaGeneratorProvider : DefaultGeneratorProvider
  {
    internal static ElmaGeneratorProvider WTJxtvBavA6L7a9lqhXj;

    /// <summary>Преобразовать объект в источник данных</summary>
    /// <param name="dataSourceObject">ОБъект источника данных</param>
    public override IGeneratorDataSource ConvertObjectToDataSource(object dataSourceObject) => (IGeneratorDataSource) new ElmaObjectGeneratorDataSource(dataSourceObject);

    /// <summary>Преобразовать объект в источник данных</summary>
    /// <param name="dataSourceObject">ОБъект источника данных</param>
    public override IGeneratorGlobalDataSource ConvertObjectToGlobalDataSource(
      object dataSourceObject)
    {
      return (IGeneratorGlobalDataSource) new ElmaObjectGeneratorGlobalDataSource(dataSourceObject);
    }

    /// <summary>Создать провайдер форматирования значений</summary>
    /// <param name="context">Контекст процесса генерации</param>
    public override IGeneratorFormatProvider CreateFormatProvider(GenerationContext context) => (IGeneratorFormatProvider) new ElmaGeneratorFormatProvider(context);

    /// <summary>Создать вычислитель функций</summary>
    /// <param name="context">Контекст процесса генерации</param>
    public override IGeneratorFunctionEvaluator CreateFunctionEvaluator(GenerationContext context) => (IGeneratorFunctionEvaluator) new ElmaGeneratorFunctionEvaluator(context);

    public ElmaGeneratorProvider()
    {
      ElmaGeneratorProvider.QvSZikBau2MgHCFQ56oI();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void QvSZikBau2MgHCFQ56oI() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool asXZUrBa8qB6uHjh3Vk5() => ElmaGeneratorProvider.WTJxtvBavA6L7a9lqhXj == null;

    internal static ElmaGeneratorProvider xSSywRBaZxgf1CuIPwPg() => ElmaGeneratorProvider.WTJxtvBavA6L7a9lqhXj;
  }
}
