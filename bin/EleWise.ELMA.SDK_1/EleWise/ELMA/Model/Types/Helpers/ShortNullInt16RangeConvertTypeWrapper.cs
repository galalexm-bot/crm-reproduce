// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.ShortNullInt16RangeConvertTypeWrapper
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
  public class ShortNullInt16RangeConvertTypeWrapper : IConvertTypeWrapper
  {
    internal static ShortNullInt16RangeConvertTypeWrapper UBgTaUbENRAgSsl0kLG3;

    public Type OriginalType => ShortNullInt16RangeConvertTypeWrapper.BS6AVIbEaNHmsXfYwpYB(__typeref (short?));

    public Type ConvertType => ShortNullInt16RangeConvertTypeWrapper.BS6AVIbEaNHmsXfYwpYB(__typeref (Int16Range));

    public bool RelativeConvertNeeded(Type type) => true;

    public object ConvertWrapper(object obj)
    {
      int num = 2;
      Int16Range int16Range;
      short? nullable;
      while (true)
      {
        switch (num)
        {
          case 1:
            int16Range = new Int16Range();
            num = 3;
            continue;
          case 2:
            nullable = (short?) obj;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 1 : 1;
            continue;
          case 3:
            int16Range.From = nullable;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
            continue;
          case 4:
            goto label_4;
          default:
            int16Range.To = nullable;
            num = 4;
            continue;
        }
      }
label_4:
      return (object) int16Range;
    }

    public ShortNullInt16RangeConvertTypeWrapper()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type BS6AVIbEaNHmsXfYwpYB([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool rAIkSTbE3aR7LnMb8UU4() => ShortNullInt16RangeConvertTypeWrapper.UBgTaUbENRAgSsl0kLG3 == null;

    internal static ShortNullInt16RangeConvertTypeWrapper Khuu5gbEptFOPMSkQZpS() => ShortNullInt16RangeConvertTypeWrapper.UBgTaUbENRAgSsl0kLG3;
  }
}
