// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.Int32RangeIntConvertTypeWrapper
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
  public class Int32RangeIntConvertTypeWrapper : IConvertTypeWrapper
  {
    internal static Int32RangeIntConvertTypeWrapper rO71RbbEMCk5iOknVGhK;

    public Type OriginalType => typeof (Int32Range);

    public Type ConvertType => Int32RangeIntConvertTypeWrapper.NAIJyAbEdLpgdgjGWQsb(__typeref (int));

    public bool RelativeConvertNeeded(Type type) => true;

    public object ConvertWrapper(object obj)
    {
      int num1 = 1;
      int? from;
      while (true)
      {
        int num2 = num1;
        Int32Range int32Range;
        while (true)
        {
          switch (num2)
          {
            case 1:
              int32Range = (Int32Range) obj;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_3;
            case 3:
              if (!from.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 2 : 2;
                continue;
              }
              goto label_5;
            case 4:
              goto label_9;
            default:
              from = int32Range.From;
              num2 = 3;
              continue;
          }
        }
label_5:
        from = int32Range.From;
        num1 = 4;
      }
label_3:
      int num3 = 0;
      goto label_10;
label_9:
      num3 = from.Value;
label_10:
      return (object) num3;
    }

    public Int32RangeIntConvertTypeWrapper()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type NAIJyAbEdLpgdgjGWQsb([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool wsi1bBbEJOYunh5IxgAL() => Int32RangeIntConvertTypeWrapper.rO71RbbEMCk5iOknVGhK == null;

    internal static Int32RangeIntConvertTypeWrapper p2weNybE9YDnPuNIPPVZ() => Int32RangeIntConvertTypeWrapper.rO71RbbEMCk5iOknVGhK;
  }
}
