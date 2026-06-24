// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.Int16RangeShortConvertTypeWrapper
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
  public class Int16RangeShortConvertTypeWrapper : IConvertTypeWrapper
  {
    internal static Int16RangeShortConvertTypeWrapper gcjiwmbEICsXjSoGCkUB;

    public Type OriginalType => Int16RangeShortConvertTypeWrapper.OwO1UxbEigXD8v1ie5DD(__typeref (Int16Range));

    public Type ConvertType => Int16RangeShortConvertTypeWrapper.OwO1UxbEigXD8v1ie5DD(__typeref (short));

    public bool RelativeConvertNeeded(Type type) => true;

    public object ConvertWrapper(object obj)
    {
      int num = 1;
      Int16Range int16Range;
      short? from;
      while (true)
      {
        switch (num)
        {
          case 1:
            int16Range = (Int16Range) obj;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          case 3:
            if (!from.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 2 : 2;
              continue;
            }
            goto label_7;
          default:
            from = int16Range.From;
            num = 3;
            continue;
        }
      }
label_3:
      short? nullable = new short?((short) 0);
      goto label_8;
label_7:
      nullable = int16Range.From;
label_8:
      return (object) nullable;
    }

    public Int16RangeShortConvertTypeWrapper()
    {
      Int16RangeShortConvertTypeWrapper.jQnYxWbERA4HmykQYvj5();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type OwO1UxbEigXD8v1ie5DD([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool xnCrFGbEVf4QYel1gFcX() => Int16RangeShortConvertTypeWrapper.gcjiwmbEICsXjSoGCkUB == null;

    internal static Int16RangeShortConvertTypeWrapper P3Tv6RbESoH0TGB9WijA() => Int16RangeShortConvertTypeWrapper.gcjiwmbEICsXjSoGCkUB;

    internal static void jQnYxWbERA4HmykQYvj5() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
