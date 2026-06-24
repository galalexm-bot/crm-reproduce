// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.DateTimeRelativeDateTimeConverter
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
  public class DateTimeRelativeDateTimeConverter : IConvertTypeWrapper
  {
    private static DateTimeRelativeDateTimeConverter VJxyHWbhuyUUhDVxlWd4;

    public Type OriginalType => typeof (DateTime);

    public Type ConvertType => DateTimeRelativeDateTimeConverter.hW60HVbhSpU8sw3tvVc9(__typeref (RelativeDateTime));

    public bool RelativeConvertNeeded(Type type) => true;

    public object ConvertWrapper(object obj)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!this.RelativeConvertNeeded(obj.GetType()))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      RelativeDateTime relativeDateTime = new RelativeDateTime();
      DateTimeRelativeDateTimeConverter.kgbDaGbhiW4xdsX1t7EO((object) relativeDateTime, new DateTimeRange()
      {
        From = new DateTime?((DateTime) obj)
      });
      DateTimeRelativeDateTimeConverter.mX42fmbhR2Aj7v8Vdlw0((object) relativeDateTime, false);
      DateTimeRelativeDateTimeConverter.yvJQ54bhqxtfb1sBoBy7((object) relativeDateTime, (object) null);
      DateTimeRelativeDateTimeConverter.hmQkEbbhKh5cdg6v7f7w((object) relativeDateTime, (object) null);
      return (object) relativeDateTime;
label_5:
      return obj;
    }

    public DateTimeRelativeDateTimeConverter()
    {
      DateTimeRelativeDateTimeConverter.Qhg6CVbhXJDamscMZjWU();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type hW60HVbhSpU8sw3tvVc9([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static void kgbDaGbhiW4xdsX1t7EO([In] object obj0, DateTimeRange value) => ((RelativeDateTime) obj0).DateTimeRange = value;

    internal static void mX42fmbhR2Aj7v8Vdlw0([In] object obj0, bool value) => ((RelativeDateTime) obj0).IsRelative = value;

    internal static void yvJQ54bhqxtfb1sBoBy7([In] object obj0, [In] object obj1) => ((RelativeDateTime) obj0).RelativeFrom = (string) obj1;

    internal static void hmQkEbbhKh5cdg6v7f7w([In] object obj0, [In] object obj1) => ((RelativeDateTime) obj0).RelativeTo = (string) obj1;

    internal static bool SVsGYwbhIVq5XdFhNqge() => DateTimeRelativeDateTimeConverter.VJxyHWbhuyUUhDVxlWd4 == null;

    internal static DateTimeRelativeDateTimeConverter jldYlRbhVvTJEqpOf8lb() => DateTimeRelativeDateTimeConverter.VJxyHWbhuyUUhDVxlWd4;

    internal static void Qhg6CVbhXJDamscMZjWU() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
