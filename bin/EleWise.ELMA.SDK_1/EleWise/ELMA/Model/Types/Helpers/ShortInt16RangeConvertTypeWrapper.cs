// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.ShortInt16RangeConvertTypeWrapper
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
  public class ShortInt16RangeConvertTypeWrapper : IConvertTypeWrapper
  {
    internal static ShortInt16RangeConvertTypeWrapper ol4rGebEnb848U8tj9H5;

    public Type OriginalType => ShortInt16RangeConvertTypeWrapper.mRovxHbEeMUR5wvyS8b0(__typeref (short));

    public Type ConvertType => ShortInt16RangeConvertTypeWrapper.mRovxHbEeMUR5wvyS8b0(__typeref (Int16Range));

    public bool RelativeConvertNeeded(Type type) => true;

    public object ConvertWrapper(object obj)
    {
      int num1 = 4;
      Int16Range int16Range;
      short num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            int16Range.From = new short?(num2);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          case 3:
            int16Range = new Int16Range();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 1;
            continue;
          case 4:
            num2 = ShortInt16RangeConvertTypeWrapper.URW689bEPkG8y7x2m6np(obj);
            num1 = 3;
            continue;
          default:
            int16Range.To = new short?(num2);
            num1 = 2;
            continue;
        }
      }
label_5:
      return (object) int16Range;
    }

    public ShortInt16RangeConvertTypeWrapper()
    {
      ShortInt16RangeConvertTypeWrapper.DFXAuFbE1S7B4sgQZ6RR();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type mRovxHbEeMUR5wvyS8b0([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static short URW689bEPkG8y7x2m6np([In] object obj0) => Convert.ToInt16(obj0);

    internal static bool NnbcDXbEOriPojJ5aE4N() => ShortInt16RangeConvertTypeWrapper.ol4rGebEnb848U8tj9H5 == null;

    internal static ShortInt16RangeConvertTypeWrapper OhyfoebE2Jvm1AWbAhAJ() => ShortInt16RangeConvertTypeWrapper.ol4rGebEnb848U8tj9H5;

    internal static void DFXAuFbE1S7B4sgQZ6RR() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
