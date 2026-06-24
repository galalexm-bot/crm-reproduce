// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Templates.GenerationContextExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.TemplateGenerator;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Templates
{
  /// <summary>Методы-расширения для контекста генерации по шаблону</summary>
  public static class GenerationContextExtensions
  {
    internal static GenerationContextExtensions NRwtOAB1BOQvMYjhs7Kx;

    /// <summary>Получить режим генерации</summary>
    /// <param name="context">Контекст генерации</param>
    /// <returns>Режим генерации</returns>
    public static TemplateRenderMode GetRenderMode(this GenerationContext context)
    {
      int num = 1;
      object renderMode;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!context.ExtendedProperties.TryGetValue((string) GenerationContextExtensions.Dn3Y5JB1bUyYM0cEFuWL(1149433385 + 173655049 ^ 1323170370), out renderMode))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return TemplateRenderMode.Default;
label_3:
      return (TemplateRenderMode) renderMode;
    }

    /// <summary>Установить режим генерации</summary>
    /// <param name="context">Контекст генерации</param>
    /// <param name="mode">Режим генерации</param>
    public static void SetRenderMode(this GenerationContext context, TemplateRenderMode mode)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            context.ExtendedProperties[(string) GenerationContextExtensions.Dn3Y5JB1bUyYM0cEFuWL(-477139494 ^ -477221462)] = (object) mode;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static object Dn3Y5JB1bUyYM0cEFuWL(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool Xe4T46B1W6kUjMZA1vun() => GenerationContextExtensions.NRwtOAB1BOQvMYjhs7Kx == null;

    internal static GenerationContextExtensions vbZmi4B1oyIgLnEsEEP6() => GenerationContextExtensions.NRwtOAB1BOQvMYjhs7Kx;
  }
}
