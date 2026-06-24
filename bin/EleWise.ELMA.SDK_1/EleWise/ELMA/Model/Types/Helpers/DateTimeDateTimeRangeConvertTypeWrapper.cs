// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.DateTimeDateTimeRangeConvertTypeWrapper
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
  public class DateTimeDateTimeRangeConvertTypeWrapper : IConvertTypeWrapper
  {
    internal static DateTimeDateTimeRangeConvertTypeWrapper y5FibjbfcyQ9r41Qg6fI;

    public Type OriginalType => DateTimeDateTimeRangeConvertTypeWrapper.rZjZN7bQBFN4FJ5at3m9(__typeref (DateTime));

    public Type ConvertType => DateTimeDateTimeRangeConvertTypeWrapper.rZjZN7bQBFN4FJ5at3m9(__typeref (DateTimeRange));

    public bool RelativeConvertNeeded(Type type) => true;

    public object ConvertWrapper(object obj)
    {
      int num1 = 3;
      DateTimeRange dateTimeRange;
      while (true)
      {
        int num2 = num1;
        DateTime dateTime;
        while (true)
        {
          switch (num2)
          {
            case 1:
              dateTimeRange.From = new DateTime?(dateTime);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
              continue;
            case 2:
              dateTimeRange = new DateTimeRange();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 0;
              continue;
            case 3:
              dateTime = (DateTime) obj;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 2 : 0;
              continue;
            case 4:
              goto label_7;
            default:
              goto label_5;
          }
        }
label_5:
        dateTimeRange.To = new DateTime?(dateTime);
        num1 = 4;
      }
label_7:
      return (object) dateTimeRange;
    }

    public DateTimeDateTimeRangeConvertTypeWrapper()
    {
      DateTimeDateTimeRangeConvertTypeWrapper.jNB0h2bQWRchoRG8eqp1();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type rZjZN7bQBFN4FJ5at3m9([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool Ddxrp5bfzIwsnsPVV1Sv() => DateTimeDateTimeRangeConvertTypeWrapper.y5FibjbfcyQ9r41Qg6fI == null;

    internal static DateTimeDateTimeRangeConvertTypeWrapper GPIbJJbQFUo6k4mOUilp() => DateTimeDateTimeRangeConvertTypeWrapper.y5FibjbfcyQ9r41Qg6fI;

    internal static void jNB0h2bQWRchoRG8eqp1() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
