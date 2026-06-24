// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.RelativeDateTimeDateTimeRangeConverter
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
  public class RelativeDateTimeDateTimeRangeConverter : IConvertTypeWrapper
  {
    internal static RelativeDateTimeDateTimeRangeConverter X5IwPbbhNh0OnEATqgNC;

    public Type OriginalType => RelativeDateTimeDateTimeRangeConverter.bt0O7wbhaKZEia2ytLcC(__typeref (RelativeDateTime));

    public Type ConvertType => RelativeDateTimeDateTimeRangeConverter.bt0O7wbhaKZEia2ytLcC(__typeref (DateTimeRange));

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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return (object) RelativeDateTimeDateTimeRangeConverter.kiMOwNbhDvKLlfAIrRos((object) (RelativeDateTime) obj);
label_3:
      return obj;
    }

    public RelativeDateTimeDateTimeRangeConverter()
    {
      RelativeDateTimeDateTimeRangeConverter.uZm0CUbhtLhbXjZ506Bj();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type bt0O7wbhaKZEia2ytLcC([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static DateTimeRange kiMOwNbhDvKLlfAIrRos([In] object obj0) => ((RelativeDateTime) obj0).DateTimeRange;

    internal static bool iLQ6Dhbh38kYsKKdowT3() => RelativeDateTimeDateTimeRangeConverter.X5IwPbbhNh0OnEATqgNC == null;

    internal static RelativeDateTimeDateTimeRangeConverter jCsSEebhpudrfd2bPSX9() => RelativeDateTimeDateTimeRangeConverter.X5IwPbbhNh0OnEATqgNC;

    internal static void uZm0CUbhtLhbXjZ506Bj() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
