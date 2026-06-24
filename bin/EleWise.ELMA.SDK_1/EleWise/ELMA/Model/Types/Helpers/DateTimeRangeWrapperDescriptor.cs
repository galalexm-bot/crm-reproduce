// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.DateTimeRangeWrapperDescriptor
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
  public class DateTimeRangeWrapperDescriptor : ITypeWrapperDescriptor
  {
    internal static DateTimeRangeWrapperDescriptor yHSaxybfyT3ob0YMIDlu;

    public Type OriginalType => typeof (DateTimeRange);

    public Type WrapperType => DateTimeRangeWrapperDescriptor.IQ9Qcvbf96GahicXFqrE(__typeref (DateTimeRangeWrapper));

    public object CreateWrapper(object obj)
    {
      int num = 3;
      DateTimeRange source;
      DateTime? nullable;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (nullable.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 4 : 5;
              continue;
            }
            goto case 7;
          case 2:
            source = (DateTimeRange) obj;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 8 : 8;
            continue;
          case 3:
            if (obj is DateTimeRange)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 2 : 0;
              continue;
            }
            goto label_5;
          case 4:
          case 5:
            goto label_4;
          case 6:
            goto label_5;
          case 7:
            nullable = source.To;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
            continue;
          case 8:
            nullable = source.From;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 1;
            continue;
          default:
            if (!nullable.HasValue)
            {
              num = 6;
              continue;
            }
            goto label_4;
        }
      }
label_4:
      return (object) new DateTimeRangeWrapper(source);
label_5:
      return (object) null;
    }

    public object GetObject(object wrapper)
    {
      int num = 2;
      DateTimeRangeWrapper timeRangeWrapper;
      DateTimeRange dateTimeRange;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (timeRangeWrapper == null)
            {
              num = 7;
              continue;
            }
            goto case 4;
          case 2:
            timeRangeWrapper = wrapper as DateTimeRangeWrapper;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 0;
            continue;
          case 3:
            dateTimeRange.To = timeRangeWrapper.To.Value;
            num = 6;
            continue;
          case 4:
            dateTimeRange = new DateTimeRange();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 5 : 3;
            continue;
          case 5:
            dateTimeRange.From = timeRangeWrapper.From.Value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 2 : 3;
            continue;
          case 6:
            goto label_9;
          case 7:
            dateTimeRange = new DateTimeRange();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return (object) dateTimeRange;
label_9:
      return (object) dateTimeRange;
    }

    public Type[] GenericArgumentsTypes => (Type[]) null;

    public bool TestType(Type type) => false;

    public DateTimeRangeWrapperDescriptor()
    {
      DateTimeRangeWrapperDescriptor.FP2G9QbfdWdIrR8TP2wQ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type IQ9Qcvbf96GahicXFqrE([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool LlG8rMbfMBABJGVVAC3H() => DateTimeRangeWrapperDescriptor.yHSaxybfyT3ob0YMIDlu == null;

    internal static DateTimeRangeWrapperDescriptor rLiLLSbfJygS9Okqw2Md() => DateTimeRangeWrapperDescriptor.yHSaxybfyT3ob0YMIDlu;

    internal static void FP2G9QbfdWdIrR8TP2wQ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
