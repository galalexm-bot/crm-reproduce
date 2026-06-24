// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.LongInt64RangeNullConvertTypeWrapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Types.Helpers
{
  [Component]
  public class LongInt64RangeNullConvertTypeWrapper : IConvertTypeWrapper
  {
    private static LongInt64RangeNullConvertTypeWrapper qK8wwAbGjua3Jf0fX7Yp;

    public Type OriginalType => typeof (long?);

    public Type ConvertType => typeof (Int64Range);

    public bool RelativeConvertNeeded(Type type) => true;

    public object ConvertWrapper(object obj)
    {
      int num = 1;
      Int64Range int64Range;
      long? nullable;
      while (true)
      {
        switch (num)
        {
          case 1:
            nullable = (long?) obj;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
            continue;
          case 2:
            int64Range.From = nullable;
            num = 4;
            continue;
          case 3:
            goto label_4;
          case 4:
            int64Range.To = nullable;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 3;
            continue;
          default:
            int64Range = new Int64Range();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 2 : 2;
            continue;
        }
      }
label_4:
      return (object) int64Range;
    }

    public LongInt64RangeNullConvertTypeWrapper()
    {
      LongInt64RangeNullConvertTypeWrapper.GuPICJbGUcakEOywyr2o();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool pMeGyibGYVX7TZmfiij0() => LongInt64RangeNullConvertTypeWrapper.qK8wwAbGjua3Jf0fX7Yp == null;

    internal static LongInt64RangeNullConvertTypeWrapper SIh4ZqbGLqH0gjtj8yTt() => LongInt64RangeNullConvertTypeWrapper.qK8wwAbGjua3Jf0fX7Yp;

    internal static void GuPICJbGUcakEOywyr2o() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
