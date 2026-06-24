// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Validation.ScriptValidationAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types.Validation
{
  public class ScriptValidationAttribute : ValidationAttribute
  {
    internal static ScriptValidationAttribute zZMsVcordmCQEZjFA50x;

    public ScriptValidationAttribute(string message)
    {
      ScriptValidationAttribute.rho0btorgynGyUxINtfr();
      // ISSUE: explicit constructor call
      base.\u002Ector(message);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            ScriptValidationAttribute.vGJfIUor55O21vyc0f75((object) this, (object) message);
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

    internal static void rho0btorgynGyUxINtfr() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void vGJfIUor55O21vyc0f75([In] object obj0, [In] object obj1) => ((ValidationAttribute) obj0).ErrorMessage = (string) obj1;

    internal static bool G79y7sorlPxosf6YYioB() => ScriptValidationAttribute.zZMsVcordmCQEZjFA50x == null;

    internal static ScriptValidationAttribute mNUrlforrPjCYqy8bGFF() => ScriptValidationAttribute.zZMsVcordmCQEZjFA50x;
  }
}
