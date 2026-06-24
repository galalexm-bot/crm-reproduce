// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.CalculateScriptAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>Атрибут со сценарием вычисления значения свойства</summary>
  public class CalculateScriptAttribute : Attribute
  {
    private string script;
    internal static CalculateScriptAttribute pnQyPCouW2U94R298GgY;

    /// <summary>Конструктор</summary>
    /// <param name="script">Сценарий</param>
    public CalculateScriptAttribute(string script)
    {
      CalculateScriptAttribute.fqMAwbouhJGYJcvMAtIK();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.script = script;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Сценарий</summary>
    public string Script
    {
      get => this.script;
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
              this.script = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
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

    internal static void fqMAwbouhJGYJcvMAtIK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool xWf92rouo8bjgQPTMYSu() => CalculateScriptAttribute.pnQyPCouW2U94R298GgY == null;

    internal static CalculateScriptAttribute nbi2tToubxBSPjGOOSMh() => CalculateScriptAttribute.pnQyPCouW2U94R298GgY;
  }
}
