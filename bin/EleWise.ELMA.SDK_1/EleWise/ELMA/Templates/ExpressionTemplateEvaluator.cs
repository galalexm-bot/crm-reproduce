// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Templates.ExpressionTemplateEvaluator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Templates.TemplateGenerator;
using EleWise.TemplateGenerator;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Templates
{
  /// <summary>Вычислитель значений выражений на основе языка ADL</summary>
  public class ExpressionTemplateEvaluator : ExpressionEvaluator
  {
    private static ExpressionTemplateEvaluator V76xAfBNQKOlBBAd05yX;

    /// <summary>Ctor</summary>
    /// <param name="template">Шаблон</param>
    /// <param name="provider">Провайдер генерации</param>
    public ExpressionTemplateEvaluator(string template, IGeneratorProvider provider = null)
    {
      ExpressionTemplateEvaluator.SrRptNBN8Apb7bbUFrxL();
      string expressionText = template;
      IGeneratorProvider generatorProvider = provider;
      IGeneratorProvider provider1 = generatorProvider == null ? (IGeneratorProvider) new ElmaGeneratorProvider() : generatorProvider;
      // ISSUE: explicit constructor call
      base.\u002Ector(expressionText, provider1);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void SrRptNBN8Apb7bbUFrxL() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool AJE2AlBNC68Qqm438lmZ() => ExpressionTemplateEvaluator.V76xAfBNQKOlBBAd05yX == null;

    internal static ExpressionTemplateEvaluator pnUBl0BNvx5h48Vl5xHN() => ExpressionTemplateEvaluator.V76xAfBNQKOlBBAd05yX;
  }
}
