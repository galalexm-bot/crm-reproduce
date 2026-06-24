// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.GenerateFunctionCodeResponse
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model
{
  /// <summary>Ответ при генерации кода для функции</summary>
  public sealed class GenerateFunctionCodeResponse
  {
    internal static GenerateFunctionCodeResponse GcyoCWW5K0YkC1CTLNeB;

    /// <summary>Сгенерированный исходный код</summary>
    public string SourceCode
    {
      get => this.\u003CSourceCode\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CSourceCode\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public GenerateFunctionCodeResponse()
    {
      GenerateFunctionCodeResponse.AKawFXW5kt3xqJIYDmEU();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool tdI8lvW5XClKoEhg02Vw() => GenerateFunctionCodeResponse.GcyoCWW5K0YkC1CTLNeB == null;

    internal static GenerateFunctionCodeResponse Wq70JJW5T88pVYCWm8tp() => GenerateFunctionCodeResponse.GcyoCWW5K0YkC1CTLNeB;

    internal static void AKawFXW5kt3xqJIYDmEU() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
