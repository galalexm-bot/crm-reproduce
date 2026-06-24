// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.IntNullInt32RangeConvertTypeWrapper
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
  public class IntNullInt32RangeConvertTypeWrapper : IConvertTypeWrapper
  {
    internal static IntNullInt32RangeConvertTypeWrapper BGEuf8bfFIq0dyUATdHf;

    public Type OriginalType => typeof (int?);

    public Type ConvertType => IntNullInt32RangeConvertTypeWrapper.lTT2Ebbform1FaIydhSD(__typeref (Int32Range));

    public bool RelativeConvertNeeded(Type type) => true;

    public object ConvertWrapper(object obj)
    {
      int num = 2;
      Int32Range int32Range;
      int? nullable;
      while (true)
      {
        switch (num)
        {
          case 1:
            int32Range = new Int32Range();
            num = 3;
            continue;
          case 2:
            nullable = (int?) obj;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 1;
            continue;
          case 3:
            int32Range.From = nullable;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 3 : 4;
            continue;
          case 4:
            int32Range.To = nullable;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return (object) int32Range;
    }

    public IntNullInt32RangeConvertTypeWrapper()
    {
      IntNullInt32RangeConvertTypeWrapper.cClNtKbfbY8e9sldboMP();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type lTT2Ebbform1FaIydhSD([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool K10yWIbfBPQYYyeN4Mw3() => IntNullInt32RangeConvertTypeWrapper.BGEuf8bfFIq0dyUATdHf == null;

    internal static IntNullInt32RangeConvertTypeWrapper uHgAxPbfW4JwE0YB0hlf() => IntNullInt32RangeConvertTypeWrapper.BGEuf8bfFIq0dyUATdHf;

    internal static void cClNtKbfbY8e9sldboMP() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
