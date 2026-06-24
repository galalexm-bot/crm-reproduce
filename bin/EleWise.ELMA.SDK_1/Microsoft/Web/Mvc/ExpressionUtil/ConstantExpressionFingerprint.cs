// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.Mvc.ExpressionUtil.ConstantExpressionFingerprint
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq.Expressions;

namespace Microsoft.Web.Mvc.ExpressionUtil
{
  internal sealed class ConstantExpressionFingerprint : ExpressionFingerprint
  {
    internal static ConstantExpressionFingerprint G7iTRsWKZlytWWXtuR7;

    public ConstantExpressionFingerprint(ExpressionType nodeType, Type type)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(nodeType, type);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public override bool Equals(object obj)
    {
      int num = 3;
      ConstantExpressionFingerprint other;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (other == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 3:
            other = obj as ConstantExpressionFingerprint;
            num = 2;
            continue;
          default:
            goto label_6;
        }
      }
label_5:
      return this.Equals((ExpressionFingerprint) other);
label_6:
      return false;
    }

    internal static bool wIPxlAWXkvhmyA7f4Kj() => ConstantExpressionFingerprint.G7iTRsWKZlytWWXtuR7 == null;

    internal static ConstantExpressionFingerprint aFy877WTrqZG5pVLhWy() => ConstantExpressionFingerprint.G7iTRsWKZlytWWXtuR7;
  }
}
