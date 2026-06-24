// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.Mvc.ExpressionUtil.LambdaExpressionFingerprint
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq.Expressions;

namespace Microsoft.Web.Mvc.ExpressionUtil
{
  internal sealed class LambdaExpressionFingerprint : ExpressionFingerprint
  {
    internal static LambdaExpressionFingerprint KLt4AwoKv9daQCXSgbB;

    public LambdaExpressionFingerprint(ExpressionType nodeType, Type type)
    {
      LambdaExpressionFingerprint.JYxnQ8okulYgXqtqahg();
      // ISSUE: explicit constructor call
      base.\u002Ector(nodeType, type);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public override bool Equals(object obj)
    {
      int num = 3;
      LambdaExpressionFingerprint other;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            if (other == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 1;
              continue;
            }
            goto label_5;
          case 3:
            other = obj as LambdaExpressionFingerprint;
            num = 2;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return this.Equals((ExpressionFingerprint) other);
label_6:
      return false;
    }

    internal static void JYxnQ8okulYgXqtqahg() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool MZi7SXoXMBbpDgQjkvr() => LambdaExpressionFingerprint.KLt4AwoKv9daQCXSgbB == null;

    internal static LambdaExpressionFingerprint xsysrEoTniku8FfHa6R() => LambdaExpressionFingerprint.KLt4AwoKv9daQCXSgbB;
  }
}
