// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.Comparer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Helpers
{
  internal class Comparer : IEqualityComparer<object>
  {
    protected Func<object, object, bool> Expression;
    internal static Comparer XYPdishczP9UDLqJNmoY;

    public Comparer()
    {
      Comparer.laA5w5hzWNsSNbCvkRgx();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public Comparer(Func<object, object, bool> expression)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Expression = expression;
    }

    bool IEqualityComparer<object>.Equals(object x, object y)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.Expression == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return this.Expression(x, y);
label_3:
      return false;
    }

    public int GetHashCode(object x) => x.GetHashCode();

    internal static void laA5w5hzWNsSNbCvkRgx() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool c8NMrshzFkRUQlDqTWHJ() => Comparer.XYPdishczP9UDLqJNmoY == null;

    internal static Comparer QF1dRmhzBTFvDTwHXZQq() => Comparer.XYPdishczP9UDLqJNmoY;
  }
}
