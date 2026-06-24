// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.Int16RangeShortNullConvertTypeWrapper
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
  public class Int16RangeShortNullConvertTypeWrapper : IConvertTypeWrapper
  {
    internal static Int16RangeShortNullConvertTypeWrapper hJPDbRbEq31JbPIpb2s9;

    public Type OriginalType => Int16RangeShortNullConvertTypeWrapper.SrfLGhbETUE5MI0gC7ij(__typeref (Int16Range));

    public Type ConvertType => Int16RangeShortNullConvertTypeWrapper.SrfLGhbETUE5MI0gC7ij(__typeref (short?));

    public bool RelativeConvertNeeded(Type type) => true;

    public object ConvertWrapper(object obj)
    {
      int num = 1;
      Int16Range int16Range;
      while (true)
      {
        switch (num)
        {
          case 1:
            int16Range = (Int16Range) obj;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (object) int16Range.From;
    }

    public Int16RangeShortNullConvertTypeWrapper()
    {
      Int16RangeShortNullConvertTypeWrapper.WCmfgBbEkya9YwuFq3yP();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type SrfLGhbETUE5MI0gC7ij([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool zocjTHbEKSbbaSXnJ5jk() => Int16RangeShortNullConvertTypeWrapper.hJPDbRbEq31JbPIpb2s9 == null;

    internal static Int16RangeShortNullConvertTypeWrapper ew41lAbEX6Yj0b9sH81R() => Int16RangeShortNullConvertTypeWrapper.hJPDbRbEq31JbPIpb2s9;

    internal static void WCmfgBbEkya9YwuFq3yP() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
