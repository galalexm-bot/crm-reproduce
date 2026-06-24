// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scripts.Models.ParseMethodsRequest
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Scripts.Models
{
  /// <summary>Запрос на парс методов модуля сценариев</summary>
  public sealed class ParseMethodsRequest
  {
    private static ParseMethodsRequest GQP3uIWB6IDMGYy1WrZx;

    /// <summary>Исходный код</summary>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
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

    public ParseMethodsRequest()
    {
      ParseMethodsRequest.mkkSeKWB7dQPLf9IrKZw();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool bO2L0pWBHXtVlF9VxaSZ() => ParseMethodsRequest.GQP3uIWB6IDMGYy1WrZx == null;

    internal static ParseMethodsRequest Bj4AAcWBARy39Wskpa92() => ParseMethodsRequest.GQP3uIWB6IDMGYy1WrZx;

    internal static void mkkSeKWB7dQPLf9IrKZw() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
