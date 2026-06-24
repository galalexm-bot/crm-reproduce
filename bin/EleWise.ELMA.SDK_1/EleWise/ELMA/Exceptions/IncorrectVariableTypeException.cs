// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Exceptions.IncorrectVariableTypeException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Exceptions
{
  /// <summary>
  /// Исключение, когда переменная в хранилище имеет не правильный тип
  /// </summary>
  [Serializable]
  public class IncorrectVariableTypeException : EQLException
  {
    private string variableName;
    internal static IncorrectVariableTypeException oaWTE8GgbT5TfQK15nsB;

    /// <summary>Конструктор</summary>
    public IncorrectVariableTypeException()
    {
      IncorrectVariableTypeException.BwlrCEGgEcdFgmmrIPnk();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Конструктор</summary>
    /// <param name="variableName">Имя переменной</param>
    public IncorrectVariableTypeException(string variableName)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector((string) null, EleWise.ELMA.SR.T((string) IncorrectVariableTypeException.XyTrhDGgfgXAAyGJoDgF(236071375 ^ 236338535), (object) variableName));
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.variableName = variableName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Имя переменной</summary>
    public string VariableName => this.variableName;

    internal static void BwlrCEGgEcdFgmmrIPnk() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool RpuSrLGghHrdOcHOjs7v() => IncorrectVariableTypeException.oaWTE8GgbT5TfQK15nsB == null;

    internal static IncorrectVariableTypeException yJAXkEGgGdKhqCP5nLis() => IncorrectVariableTypeException.oaWTE8GgbT5TfQK15nsB;

    internal static object XyTrhDGgfgXAAyGJoDgF(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
