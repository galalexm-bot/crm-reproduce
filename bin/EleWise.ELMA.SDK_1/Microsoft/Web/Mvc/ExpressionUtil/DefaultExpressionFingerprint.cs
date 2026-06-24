// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.Mvc.ExpressionUtil.DefaultExpressionFingerprint
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq.Expressions;

namespace Microsoft.Web.Mvc.ExpressionUtil
{
  internal sealed class DefaultExpressionFingerprint : ExpressionFingerprint
  {
    internal static DefaultExpressionFingerprint J18S4oWkKkioEU7rf7N;

    public DefaultExpressionFingerprint(ExpressionType nodeType, Type type)
    {
      DefaultExpressionFingerprint.C84Xw3W25LDJanN1Hel();
      // ISSUE: explicit constructor call
      base.\u002Ector(nodeType, type);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public override bool Equals(object obj)
    {
      int num = 1;
      DefaultExpressionFingerprint other;
      while (true)
      {
        switch (num)
        {
          case 1:
            other = obj as DefaultExpressionFingerprint;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_2;
          default:
            if (other == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 2 : 2;
              continue;
            }
            goto label_2;
        }
      }
label_2:
      return this.Equals((ExpressionFingerprint) other);
label_3:
      return false;
    }

    internal static void C84Xw3W25LDJanN1Hel() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool brj8dYWnT9xKEq93arT() => DefaultExpressionFingerprint.J18S4oWkKkioEU7rf7N == null;

    internal static DefaultExpressionFingerprint x8ZPgNWO0pSHXeUF8Mw() => DefaultExpressionFingerprint.J18S4oWkKkioEU7rf7N;
  }
}
