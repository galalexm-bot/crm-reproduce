// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.LongInt64RangeConvertTypeWrapper
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
  public class LongInt64RangeConvertTypeWrapper : IConvertTypeWrapper
  {
    private static LongInt64RangeConvertTypeWrapper ITDRMlbG9mr7dT9TiPWT;

    public Type OriginalType => LongInt64RangeConvertTypeWrapper.cVWwRJbGrnqUkb7TQQkK(__typeref (long));

    public Type ConvertType => LongInt64RangeConvertTypeWrapper.cVWwRJbGrnqUkb7TQQkK(__typeref (Int64Range));

    public bool RelativeConvertNeeded(Type type) => true;

    public object ConvertWrapper(object obj)
    {
      int num1 = 3;
      Int64Range int64Range;
      while (true)
      {
        int num2 = num1;
        long num3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              int64Range.To = new long?(num3);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_4;
            case 3:
              num3 = LongInt64RangeConvertTypeWrapper.OwbDaMbGgnLguHk2J54h(obj);
              num2 = 2;
              continue;
            case 4:
              int64Range.From = new long?(num3);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 1 : 1;
              continue;
            default:
              goto label_3;
          }
        }
label_4:
        int64Range = new Int64Range();
        num1 = 4;
      }
label_3:
      return (object) int64Range;
    }

    public LongInt64RangeConvertTypeWrapper()
    {
      LongInt64RangeConvertTypeWrapper.y8KmZLbG5jtTLEnJHRse();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type cVWwRJbGrnqUkb7TQQkK([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static long OwbDaMbGgnLguHk2J54h([In] object obj0) => Convert.ToInt64(obj0);

    internal static bool LSXsdDbGdZNMgQVKiObv() => LongInt64RangeConvertTypeWrapper.ITDRMlbG9mr7dT9TiPWT == null;

    internal static LongInt64RangeConvertTypeWrapper fex6uKbGlGtVWVtbWnjF() => LongInt64RangeConvertTypeWrapper.ITDRMlbG9mr7dT9TiPWT;

    internal static void y8KmZLbG5jtTLEnJHRse() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
