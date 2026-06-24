// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.DoubleRangeDoubleConvertTypeWrapper
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
  public class DoubleRangeDoubleConvertTypeWrapper : IConvertTypeWrapper
  {
    internal static DoubleRangeDoubleConvertTypeWrapper c3BJdXbGQkCEffLgLhtt;

    public Type OriginalType => DoubleRangeDoubleConvertTypeWrapper.gMmiIMbG8qUJGOKvdc90(__typeref (DoubleRange));

    public Type ConvertType => DoubleRangeDoubleConvertTypeWrapper.gMmiIMbG8qUJGOKvdc90(__typeref (double));

    public bool RelativeConvertNeeded(Type type) => true;

    public object ConvertWrapper(object obj)
    {
      int num = 2;
      DoubleRange doubleRange;
      double? from;
      while (true)
      {
        switch (num)
        {
          case 1:
            from = doubleRange.From;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
            continue;
          case 2:
            doubleRange = (DoubleRange) obj;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 1;
            continue;
          case 3:
            goto label_2;
          default:
            if (!from.HasValue)
            {
              num = 3;
              continue;
            }
            goto label_7;
        }
      }
label_2:
      double? nullable = new double?(0.0);
      goto label_8;
label_7:
      nullable = doubleRange.From;
label_8:
      return (object) nullable;
    }

    public DoubleRangeDoubleConvertTypeWrapper()
    {
      DoubleRangeDoubleConvertTypeWrapper.RD0fKNbGZbCxSerFuh4q();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type gMmiIMbG8qUJGOKvdc90([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool jfck3BbGC1eWDx63L6W3() => DoubleRangeDoubleConvertTypeWrapper.c3BJdXbGQkCEffLgLhtt == null;

    internal static DoubleRangeDoubleConvertTypeWrapper hP1ZFUbGvUq7QQoFcyyg() => DoubleRangeDoubleConvertTypeWrapper.c3BJdXbGQkCEffLgLhtt;

    internal static void RD0fKNbGZbCxSerFuh4q() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
