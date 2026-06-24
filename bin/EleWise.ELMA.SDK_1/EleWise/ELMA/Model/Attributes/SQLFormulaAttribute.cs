// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.SQLFormulaAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>Атрибут с SQL выражением</summary>
  public class SQLFormulaAttribute : Attribute
  {
    private string formula;
    internal static SQLFormulaAttribute WdYVcRoumUKTF5KCgSOP;

    /// <summary>Конструктор</summary>
    /// <param name="formula">Выражение</param>
    public SQLFormulaAttribute(string formula)
    {
      SQLFormulaAttribute.gDPyRGouJgMxtdLKhJwG();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.formula = formula;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Выражение</summary>
    public string Formula
    {
      get => this.formula;
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
              this.formula = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
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

    internal static void gDPyRGouJgMxtdLKhJwG() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool ABueh9ouyxoT29YPKIXY() => SQLFormulaAttribute.WdYVcRoumUKTF5KCgSOP == null;

    internal static SQLFormulaAttribute IaTHxEouM1CogZAovYZJ() => SQLFormulaAttribute.WdYVcRoumUKTF5KCgSOP;
  }
}
