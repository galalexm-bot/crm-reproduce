// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.Mvc.ExpressionUtil.ConditionalExpressionFingerprint
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq.Expressions;

namespace Microsoft.Web.Mvc.ExpressionUtil
{
  internal sealed class ConditionalExpressionFingerprint : ExpressionFingerprint
  {
    internal static ConditionalExpressionFingerprint kNQySeWiuUcmCoQB9mu;

    public ConditionalExpressionFingerprint(ExpressionType nodeType, Type type)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(nodeType, type);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public override bool Equals(object obj)
    {
      int num = 2;
      ConditionalExpressionFingerprint other;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (other != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            other = obj as ConditionalExpressionFingerprint;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 1 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return this.Equals((ExpressionFingerprint) other);
label_4:
      return false;
    }

    internal static bool zHZ3EpWRBGA5lXlabIS() => ConditionalExpressionFingerprint.kNQySeWiuUcmCoQB9mu == null;

    internal static ConditionalExpressionFingerprint kRE6IaWqC4SUg4OppUb() => ConditionalExpressionFingerprint.kNQySeWiuUcmCoQB9mu;
  }
}
