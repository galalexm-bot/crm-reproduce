// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.DateTimeRangeDateTimeNullConvertTypeWrapper
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
  public class DateTimeRangeDateTimeNullConvertTypeWrapper : IConvertTypeWrapper
  {
    internal static DateTimeRangeDateTimeNullConvertTypeWrapper WZvLynbfYDa81O6YhSMX;

    public Type OriginalType => DateTimeRangeDateTimeNullConvertTypeWrapper.QcfaECbfs3mgCUpu0txN(__typeref (DateTimeRange));

    public Type ConvertType => typeof (DateTime?);

    public bool RelativeConvertNeeded(Type type) => true;

    public object ConvertWrapper(object obj)
    {
      int num = 1;
      DateTimeRange dateTimeRange;
      while (true)
      {
        switch (num)
        {
          case 1:
            dateTimeRange = (DateTimeRange) obj;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (object) dateTimeRange.From;
    }

    public DateTimeRangeDateTimeNullConvertTypeWrapper()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type QcfaECbfs3mgCUpu0txN([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool GHj9lLbfLII7sG8pYcwd() => DateTimeRangeDateTimeNullConvertTypeWrapper.WZvLynbfYDa81O6YhSMX == null;

    internal static DateTimeRangeDateTimeNullConvertTypeWrapper uqnP0AbfUxPQEhGLZaip() => DateTimeRangeDateTimeNullConvertTypeWrapper.WZvLynbfYDa81O6YhSMX;
  }
}
