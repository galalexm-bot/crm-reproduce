// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.DateTimeNullDateTimeRangeConvertTypeWrapper
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
  public class DateTimeNullDateTimeRangeConvertTypeWrapper : IConvertTypeWrapper
  {
    private static DateTimeNullDateTimeRangeConvertTypeWrapper Pvt10CbQoiivTNioeppo;

    public Type OriginalType => DateTimeNullDateTimeRangeConvertTypeWrapper.AeUncebQGCJTBy4GhvvH(__typeref (DateTime?));

    public Type ConvertType => DateTimeNullDateTimeRangeConvertTypeWrapper.AeUncebQGCJTBy4GhvvH(__typeref (DateTimeRange));

    public bool RelativeConvertNeeded(Type type) => true;

    public object ConvertWrapper(object obj)
    {
      int num = 4;
      DateTimeRange dateTimeRange;
      DateTime? nullable;
      while (true)
      {
        switch (num)
        {
          case 1:
            dateTimeRange.To = nullable;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 2 : 2;
            continue;
          case 2:
            goto label_3;
          case 3:
            dateTimeRange = new DateTimeRange();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
            continue;
          case 4:
            nullable = (DateTime?) obj;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 3;
            continue;
          default:
            dateTimeRange.From = nullable;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 1 : 1;
            continue;
        }
      }
label_3:
      return (object) dateTimeRange;
    }

    public DateTimeNullDateTimeRangeConvertTypeWrapper()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type AeUncebQGCJTBy4GhvvH([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool MTUqfEbQbDKwVCT53Pgu() => DateTimeNullDateTimeRangeConvertTypeWrapper.Pvt10CbQoiivTNioeppo == null;

    internal static DateTimeNullDateTimeRangeConvertTypeWrapper JgOyAFbQhflimYRreDBw() => DateTimeNullDateTimeRangeConvertTypeWrapper.Pvt10CbQoiivTNioeppo;
  }
}
