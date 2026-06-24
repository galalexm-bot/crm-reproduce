// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.Int64RangeLongNullConvertTypeWrapper
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
  public class Int64RangeLongNullConvertTypeWrapper : IConvertTypeWrapper
  {
    internal static Int64RangeLongNullConvertTypeWrapper aDGG7qbG09qVr8cca8kx;

    public Type OriginalType => typeof (Int64Range);

    public Type ConvertType => Int64RangeLongNullConvertTypeWrapper.FhDqPpbGMdZYFdS3Ar9L(__typeref (long?));

    public bool RelativeConvertNeeded(Type type) => true;

    public object ConvertWrapper(object obj)
    {
      int num = 1;
      Int64Range int64Range;
      while (true)
      {
        switch (num)
        {
          case 1:
            int64Range = (Int64Range) obj;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (object) int64Range.From;
    }

    public Int64RangeLongNullConvertTypeWrapper()
    {
      Int64RangeLongNullConvertTypeWrapper.VCoiYObGJJ1cxEihZshb();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type FhDqPpbGMdZYFdS3Ar9L([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool VeEWxWbGmUOm05FLNN0U() => Int64RangeLongNullConvertTypeWrapper.aDGG7qbG09qVr8cca8kx == null;

    internal static Int64RangeLongNullConvertTypeWrapper OaZNGObGyV5bjpmXtv5S() => Int64RangeLongNullConvertTypeWrapper.aDGG7qbG09qVr8cca8kx;

    internal static void VCoiYObGJJ1cxEihZshb() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
