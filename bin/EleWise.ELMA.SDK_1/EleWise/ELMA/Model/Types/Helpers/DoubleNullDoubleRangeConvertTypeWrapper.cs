// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.DoubleNullDoubleRangeConvertTypeWrapper
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
  public class DoubleNullDoubleRangeConvertTypeWrapper : IConvertTypeWrapper
  {
    private static DoubleNullDoubleRangeConvertTypeWrapper IGqwICbGTZCbnSsLB2iN;

    public Type OriginalType => typeof (double?);

    public Type ConvertType => DoubleNullDoubleRangeConvertTypeWrapper.gGrSqabGOh06oyV89Wg7(__typeref (DoubleRange));

    public bool RelativeConvertNeeded(Type type) => true;

    public object ConvertWrapper(object obj)
    {
      int num1 = 1;
      DoubleRange doubleRange;
      while (true)
      {
        int num2 = num1;
        double? nullable;
        while (true)
        {
          switch (num2)
          {
            case 1:
              nullable = (double?) obj;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_6;
            case 3:
              goto label_5;
            case 4:
              doubleRange.To = nullable;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 2 : 2;
              continue;
            default:
              doubleRange = new DoubleRange();
              num2 = 3;
              continue;
          }
        }
label_5:
        doubleRange.From = nullable;
        num1 = 4;
      }
label_6:
      return (object) doubleRange;
    }

    public DoubleNullDoubleRangeConvertTypeWrapper()
    {
      DoubleNullDoubleRangeConvertTypeWrapper.xXQlgwbG2EZhRJNkg3Wa();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type gGrSqabGOh06oyV89Wg7([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool BncYX9bGkdERS7TeGlFc() => DoubleNullDoubleRangeConvertTypeWrapper.IGqwICbGTZCbnSsLB2iN == null;

    internal static DoubleNullDoubleRangeConvertTypeWrapper k5coRcbGnIVI4nCgev7a() => DoubleNullDoubleRangeConvertTypeWrapper.IGqwICbGTZCbnSsLB2iN;

    internal static void xXQlgwbG2EZhRJNkg3Wa() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
