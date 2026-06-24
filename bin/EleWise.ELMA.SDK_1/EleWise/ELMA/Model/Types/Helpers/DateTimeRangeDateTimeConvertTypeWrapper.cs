// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.DateTimeRangeDateTimeConvertTypeWrapper
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
  public class DateTimeRangeDateTimeConvertTypeWrapper : IConvertTypeWrapper
  {
    internal static DateTimeRangeDateTimeConvertTypeWrapper bbbbsabfldnYj14bHAvN;

    public Type OriginalType => DateTimeRangeDateTimeConvertTypeWrapper.CRl9qMbf5lh0XNb4KnDy(__typeref (DateTimeRange));

    public Type ConvertType => DateTimeRangeDateTimeConvertTypeWrapper.CRl9qMbf5lh0XNb4KnDy(__typeref (DateTime));

    public bool RelativeConvertNeeded(Type type) => true;

    public object ConvertWrapper(object obj)
    {
      int num = 1;
      DateTimeRange dateTimeRange;
      DateTime? from;
      while (true)
      {
        switch (num)
        {
          case 1:
            dateTimeRange = (DateTimeRange) obj;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
            continue;
          case 2:
            if (!from.HasValue)
            {
              num = 3;
              continue;
            }
            goto label_7;
          case 3:
            goto label_2;
          default:
            from = dateTimeRange.From;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 2 : 2;
            continue;
        }
      }
label_2:
      DateTime? nullable = new DateTime?(DateTime.MinValue);
      goto label_8;
label_7:
      nullable = dateTimeRange.From;
label_8:
      return (object) nullable;
    }

    public DateTimeRangeDateTimeConvertTypeWrapper()
    {
      DateTimeRangeDateTimeConvertTypeWrapper.BCDTEvbfjHbNIvsY4rhr();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type CRl9qMbf5lh0XNb4KnDy([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool iKNxSlbfr5jlwIRhJkCH() => DateTimeRangeDateTimeConvertTypeWrapper.bbbbsabfldnYj14bHAvN == null;

    internal static DateTimeRangeDateTimeConvertTypeWrapper RYtEq0bfgDLxH8ZqmUc9() => DateTimeRangeDateTimeConvertTypeWrapper.bbbbsabfldnYj14bHAvN;

    internal static void BCDTEvbfjHbNIvsY4rhr() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
