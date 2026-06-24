// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.Int64RangeWrapperDescriptor
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
  [Component(Order = 1000)]
  public class Int64RangeWrapperDescriptor : ITypeWrapperDescriptor
  {
    private static Int64RangeWrapperDescriptor c4wZ61bG3vQdgYL8emft;

    public Type OriginalType => typeof (Int64Range);

    public Type WrapperType => typeof (Int64RangeWrapper);

    public object CreateWrapper(object obj) => (object) new Int64RangeWrapper((Int64Range) obj);

    public object GetObject(object wrapper)
    {
      int num1 = 2;
      Int64Range int64Range;
      while (true)
      {
        int num2 = num1;
        Int64RangeWrapper int64RangeWrapper;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (int64RangeWrapper == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
                continue;
              }
              goto case 4;
            case 2:
              int64RangeWrapper = wrapper as Int64RangeWrapper;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 1;
              continue;
            case 3:
              int64Range.From = Int64RangeWrapperDescriptor.yPY5vGbGDU7kn5udrlMQ((object) int64RangeWrapper) ? new long?(Int64RangeWrapperDescriptor.TKU95WbGt1FykBNiLVdg((object) int64RangeWrapper)) : new long?();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 7;
              continue;
            case 4:
              int64Range = new Int64Range();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 3 : 0;
              continue;
            case 5:
              goto label_9;
            case 6:
              goto label_3;
            case 7:
              int64Range.To = !Int64RangeWrapperDescriptor.KIsFVZbGwWmYAf6asVpY((object) int64RangeWrapper) ? new long?() : new long?(int64RangeWrapper.To);
              num2 = 6;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        int64Range = new Int64Range();
        num1 = 5;
      }
label_3:
      return (object) int64Range;
label_9:
      return (object) int64Range;
    }

    public Type[] GenericArgumentsTypes => (Type[]) null;

    public bool TestType(Type type) => false;

    public Int64RangeWrapperDescriptor()
    {
      Int64RangeWrapperDescriptor.g2qTTfbG4PfsarEfsVg3();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool zccrJMbGplE3raXVm6C1() => Int64RangeWrapperDescriptor.c4wZ61bG3vQdgYL8emft == null;

    internal static Int64RangeWrapperDescriptor qAkm6KbGaULn2GJ37l9k() => Int64RangeWrapperDescriptor.c4wZ61bG3vQdgYL8emft;

    internal static bool yPY5vGbGDU7kn5udrlMQ([In] object obj0) => ((Int64RangeWrapper) obj0).HasFromValue;

    internal static long TKU95WbGt1FykBNiLVdg([In] object obj0) => ((Int64RangeWrapper) obj0).From;

    internal static bool KIsFVZbGwWmYAf6asVpY([In] object obj0) => ((Int64RangeWrapper) obj0).HasToValue;

    internal static void g2qTTfbG4PfsarEfsVg3() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
