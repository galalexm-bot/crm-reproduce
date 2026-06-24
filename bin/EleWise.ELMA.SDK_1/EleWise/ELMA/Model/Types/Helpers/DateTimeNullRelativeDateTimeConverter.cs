// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.DateTimeNullRelativeDateTimeConverter
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
  [Component(Order = 3000)]
  public class DateTimeNullRelativeDateTimeConverter : IConvertTypeWrapper
  {
    internal static DateTimeNullRelativeDateTimeConverter PHsImmbhTg1lDCtdrIxX;

    public Type OriginalType => DateTimeNullRelativeDateTimeConverter.Gc6ZScbhOMt9OwOLIjVS(__typeref (DateTime?));

    public Type ConvertType => DateTimeNullRelativeDateTimeConverter.Gc6ZScbhOMt9OwOLIjVS(__typeref (RelativeDateTime));

    public bool RelativeConvertNeeded(Type type) => true;

    public object ConvertWrapper(object obj)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.RelativeConvertNeeded(obj.GetType()))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      RelativeDateTime relativeDateTime = new RelativeDateTime();
      relativeDateTime.DateTimeRange = new DateTimeRange()
      {
        From = new DateTime?((DateTime) obj)
      };
      DateTimeNullRelativeDateTimeConverter.vXxMPWbh2ZSmZYdjs8VV((object) relativeDateTime, false);
      DateTimeNullRelativeDateTimeConverter.tR5oZebheBtcqtNIWLhZ((object) relativeDateTime, (object) null);
      DateTimeNullRelativeDateTimeConverter.GRpacRbhPMqrF987c0Zt((object) relativeDateTime, (object) null);
      return (object) relativeDateTime;
label_3:
      return obj;
    }

    public DateTimeNullRelativeDateTimeConverter()
    {
      DateTimeNullRelativeDateTimeConverter.BOpsoSbh1g9Fiq7k3NWK();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type Gc6ZScbhOMt9OwOLIjVS([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static void vXxMPWbh2ZSmZYdjs8VV([In] object obj0, bool value) => ((RelativeDateTime) obj0).IsRelative = value;

    internal static void tR5oZebheBtcqtNIWLhZ([In] object obj0, [In] object obj1) => ((RelativeDateTime) obj0).RelativeFrom = (string) obj1;

    internal static void GRpacRbhPMqrF987c0Zt([In] object obj0, [In] object obj1) => ((RelativeDateTime) obj0).RelativeTo = (string) obj1;

    internal static bool zj1SydbhkDtL53B256c6() => DateTimeNullRelativeDateTimeConverter.PHsImmbhTg1lDCtdrIxX == null;

    internal static DateTimeNullRelativeDateTimeConverter hnMFvGbhnZUX7td5R3tk() => DateTimeNullRelativeDateTimeConverter.PHsImmbhTg1lDCtdrIxX;

    internal static void BOpsoSbh1g9Fiq7k3NWK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
