// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.RelativeDateTimeDateTimeConverter
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
  public class RelativeDateTimeDateTimeConverter : IConvertTypeWrapper
  {
    private static RelativeDateTimeDateTimeConverter Yute93bhw7J2V5xfbC5j;

    public Type OriginalType => RelativeDateTimeDateTimeConverter.RrxVa2bhHYk8sQpX7kgs(__typeref (RelativeDateTime));

    public Type ConvertType => typeof (DateTime);

    public bool RelativeConvertNeeded(Type type) => true;

    public object ConvertWrapper(object obj)
    {
      int num1 = 3;
      DateTime? from;
      while (true)
      {
        int num2 = num1;
        DateTimeRange dateTimeRange;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_11;
            case 2:
              goto label_13;
            case 3:
              if (!this.RelativeConvertNeeded(obj.GetType()))
              {
                num2 = 2;
                continue;
              }
              break;
            case 4:
              goto label_8;
            case 5:
              if (from.HasValue)
              {
                from = dateTimeRange.From;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 1 : 1;
                continue;
              }
              num2 = 6;
              continue;
            case 6:
              goto label_3;
          }
          dateTimeRange = RelativeDateTimeDateTimeConverter.fQL8D6bhAhQnPFnDGAFr((object) (RelativeDateTime) obj);
          num2 = 4;
        }
label_8:
        from = dateTimeRange.From;
        num1 = 5;
      }
label_3:
      DateTime minValue = DateTime.MinValue;
      goto label_12;
label_11:
      minValue = from.Value;
label_12:
      return (object) minValue;
label_13:
      return obj;
    }

    public RelativeDateTimeDateTimeConverter()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type RrxVa2bhHYk8sQpX7kgs([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static DateTimeRange fQL8D6bhAhQnPFnDGAFr([In] object obj0) => ((RelativeDateTime) obj0).DateTimeRange;

    internal static bool VH1T50bh4yRlJRnirthQ() => RelativeDateTimeDateTimeConverter.Yute93bhw7J2V5xfbC5j == null;

    internal static RelativeDateTimeDateTimeConverter hPAyombh6sLO1W2Ol20O() => RelativeDateTimeDateTimeConverter.Yute93bhw7J2V5xfbC5j;
  }
}
