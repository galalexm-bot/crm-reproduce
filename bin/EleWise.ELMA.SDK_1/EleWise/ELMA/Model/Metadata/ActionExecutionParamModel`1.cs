// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.ActionExecutionParamModel`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata
{
  /// <inheritdoc />
  public class ActionExecutionParamModel<T> : IActionExecutionParamModel
  {
    internal static object g9uGM3bpvIvL7n0PhQvR;

    /// <inheritdoc />
    object IActionExecutionParamModel.Parameter
    {
      get => (object) this.Parameter;
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
              this.Parameter = (T) value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
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

    /// <summary>Входной параметр</summary>
    public T Parameter { get; set; }

    public ActionExecutionParamModel()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool Bj7XSkbp8S9Q7YESUFNy() => ActionExecutionParamModel<T>.g9uGM3bpvIvL7n0PhQvR == null;

    internal static object ewe5yebpZAXHbsi8lHlm() => ActionExecutionParamModel<T>.g9uGM3bpvIvL7n0PhQvR;
  }
}
