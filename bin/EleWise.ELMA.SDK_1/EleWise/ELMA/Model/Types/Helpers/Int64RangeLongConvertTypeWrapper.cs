// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.Int64RangeLongConvertTypeWrapper
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
  public class Int64RangeLongConvertTypeWrapper : IConvertTypeWrapper
  {
    private static Int64RangeLongConvertTypeWrapper hbABRsbG6pHJFtNrHLwS;

    public Type OriginalType => typeof (Int64Range);

    public Type ConvertType => Int64RangeLongConvertTypeWrapper.Tp0Rj6bG7YU30UD7vQBB(__typeref (long));

    public bool RelativeConvertNeeded(Type type) => true;

    public object ConvertWrapper(object obj)
    {
      int num1 = 2;
      Int64Range int64Range;
      long? from;
      while (true)
      {
        switch (num1)
        {
          case 1:
            from = int64Range.From;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
            continue;
          case 2:
            int64Range = (Int64Range) obj;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_8;
          case 4:
            goto label_4;
          case 5:
            from = int64Range.From;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 3;
            continue;
          default:
            if (from.HasValue)
            {
              num1 = 5;
              continue;
            }
            goto label_4;
        }
      }
label_4:
      long num2 = 0;
      goto label_9;
label_8:
      num2 = from.Value;
label_9:
      return (object) num2;
    }

    public Int64RangeLongConvertTypeWrapper()
    {
      Int64RangeLongConvertTypeWrapper.SQlGggbGxVpbCeIOdgQ8();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type Tp0Rj6bG7YU30UD7vQBB([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool A9fdjXbGHNxtxxmhnX3p() => Int64RangeLongConvertTypeWrapper.hbABRsbG6pHJFtNrHLwS == null;

    internal static Int64RangeLongConvertTypeWrapper XQtD86bGAgplWTSs2QSy() => Int64RangeLongConvertTypeWrapper.hbABRsbG6pHJFtNrHLwS;

    internal static void SQlGggbGxVpbCeIOdgQ8() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
