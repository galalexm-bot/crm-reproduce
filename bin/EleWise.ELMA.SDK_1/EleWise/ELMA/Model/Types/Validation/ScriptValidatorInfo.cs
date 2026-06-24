// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Validation.ScriptValidatorInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types.Validation
{
  [Component]
  public class ScriptValidatorInfo : IValidatorInfo
  {
    private static ScriptValidatorInfo p9jLtWorstQaEDkhP8UJ;

    public Type AttributeType => ScriptValidatorInfo.pdumjNogFRlX6MDxTNnK(__typeref (ScriptValidationAttribute));

    public Type ValidatorType => ScriptValidatorInfo.pdumjNogFRlX6MDxTNnK(__typeref (ScriptValidator));

    public ScriptValidatorInfo()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type pdumjNogFRlX6MDxTNnK([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool RwOi2XorcD3awNtDm5Pi() => ScriptValidatorInfo.p9jLtWorstQaEDkhP8UJ == null;

    internal static ScriptValidatorInfo xk2fUborzhEgnWUEmdMP() => ScriptValidatorInfo.p9jLtWorstQaEDkhP8UJ;
  }
}
