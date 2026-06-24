// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.DoubleRangeWrapperDescriptor
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
  public class DoubleRangeWrapperDescriptor : ITypeWrapperDescriptor
  {
    private static DoubleRangeWrapperDescriptor aOnKZXbGoUxquWMnUJNU;

    public Type OriginalType => typeof (DoubleRange);

    public Type WrapperType => typeof (DoubleRangeWrapper);

    public object CreateWrapper(object obj) => (object) new DoubleRangeWrapper((DoubleRange) obj);

    public object GetObject(object wrapper)
    {
      int num = 3;
      DoubleRangeWrapper doubleRangeWrapper;
      DoubleRange doubleRange;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (doubleRangeWrapper == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
              continue;
            }
            goto case 6;
          case 3:
            doubleRangeWrapper = wrapper as DoubleRangeWrapper;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 2;
            continue;
          case 4:
            doubleRange.From = !DoubleRangeWrapperDescriptor.mGFU3AbGGJ8lUDIEEwdR((object) doubleRangeWrapper) ? new double?() : new double?(DoubleRangeWrapperDescriptor.wI5WnRbGERrSFG6AxeDL((object) doubleRangeWrapper));
            num = 5;
            continue;
          case 5:
            doubleRange.To = !doubleRangeWrapper.HasToValue ? new double?() : new double?(DoubleRangeWrapperDescriptor.dkwlFEbGfX6c3bk9ssIS((object) doubleRangeWrapper));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 0;
            continue;
          case 6:
            doubleRange = new DoubleRange();
            num = 4;
            continue;
          case 7:
            goto label_3;
          default:
            doubleRange = new DoubleRange();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 7 : 7;
            continue;
        }
      }
label_3:
      return (object) doubleRange;
label_5:
      return (object) doubleRange;
    }

    public Type[] GenericArgumentsTypes => (Type[]) null;

    public bool TestType(Type type) => false;

    public DoubleRangeWrapperDescriptor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool RH0iltbGbmTLUu7q7l4H() => DoubleRangeWrapperDescriptor.aOnKZXbGoUxquWMnUJNU == null;

    internal static DoubleRangeWrapperDescriptor EVUJ17bGhbEaTuYHnxEF() => DoubleRangeWrapperDescriptor.aOnKZXbGoUxquWMnUJNU;

    internal static bool mGFU3AbGGJ8lUDIEEwdR([In] object obj0) => ((DoubleRangeWrapper) obj0).HasFromValue;

    internal static double wI5WnRbGERrSFG6AxeDL([In] object obj0) => ((DoubleRangeWrapper) obj0).From;

    internal static double dkwlFEbGfX6c3bk9ssIS([In] object obj0) => ((DoubleRangeWrapper) obj0).To;
  }
}
