// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.DoubleDoubleRangeConvertTypeWrapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types.Helpers
{
  [Component]
  public class DoubleDoubleRangeConvertTypeWrapper : IConvertTypeWrapper
  {
    internal static DoubleDoubleRangeConvertTypeWrapper yFKYSZbGiueqLbBVFdiS;

    public Type OriginalType => DoubleDoubleRangeConvertTypeWrapper.pD5MgJbGKLtymUhU2Sqn(__typeref (double));

    public Type ConvertType => DoubleDoubleRangeConvertTypeWrapper.pD5MgJbGKLtymUhU2Sqn(__typeref (DoubleRange));

    public bool RelativeConvertNeeded(Type type) => true;

    public object ConvertWrapper(object obj)
    {
      int num1 = 3;
      DoubleRange doubleRange;
      double num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_3;
          case 2:
            doubleRange = new DoubleRange();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
            continue;
          case 3:
            num2 = DoubleDoubleRangeConvertTypeWrapper.M3PrHxbGX70bcBcdnoIM(obj);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 2 : 1;
            continue;
          case 4:
            doubleRange.To = new double?(num2);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 1 : 1;
            continue;
          default:
            doubleRange.From = new double?(num2);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 4 : 3;
            continue;
        }
      }
label_3:
      return (object) doubleRange;
    }

    public DoubleDoubleRangeConvertTypeWrapper()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type pD5MgJbGKLtymUhU2Sqn([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static double M3PrHxbGX70bcBcdnoIM([In] object obj0) => Convert.ToDouble(obj0);

    internal static bool Mhk3RHbGRZZLvdtS4RK3() => DoubleDoubleRangeConvertTypeWrapper.yFKYSZbGiueqLbBVFdiS == null;

    internal static DoubleDoubleRangeConvertTypeWrapper Q5clMobGqrwk9YsvJ5X8() => DoubleDoubleRangeConvertTypeWrapper.yFKYSZbGiueqLbBVFdiS;
  }
}
