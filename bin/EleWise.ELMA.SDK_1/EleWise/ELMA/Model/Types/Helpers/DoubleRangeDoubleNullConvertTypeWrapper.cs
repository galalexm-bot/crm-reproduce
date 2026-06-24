// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.DoubleRangeDoubleNullConvertTypeWrapper
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
  public class DoubleRangeDoubleNullConvertTypeWrapper : IConvertTypeWrapper
  {
    internal static DoubleRangeDoubleNullConvertTypeWrapper LkWUJibGusCReCMiGWLB;

    public Type OriginalType => DoubleRangeDoubleNullConvertTypeWrapper.zeJb7pbGSRHJSvAWfu2D(__typeref (DoubleRange));

    public Type ConvertType => DoubleRangeDoubleNullConvertTypeWrapper.zeJb7pbGSRHJSvAWfu2D(__typeref (double?));

    public bool RelativeConvertNeeded(Type type) => true;

    public object ConvertWrapper(object obj)
    {
      int num = 1;
      DoubleRange doubleRange;
      while (true)
      {
        switch (num)
        {
          case 1:
            doubleRange = (DoubleRange) obj;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (object) doubleRange.From;
    }

    public DoubleRangeDoubleNullConvertTypeWrapper()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type zeJb7pbGSRHJSvAWfu2D([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool ciYS09bGIsjRej5nCG3o() => DoubleRangeDoubleNullConvertTypeWrapper.LkWUJibGusCReCMiGWLB == null;

    internal static DoubleRangeDoubleNullConvertTypeWrapper zyrZpYbGVZLQxIJFimn9() => DoubleRangeDoubleNullConvertTypeWrapper.LkWUJibGusCReCMiGWLB;
  }
}
