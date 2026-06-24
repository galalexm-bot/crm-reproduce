// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.Int32RangeIntNullConvertTypeWrapper
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
  public class Int32RangeIntNullConvertTypeWrapper : IConvertTypeWrapper
  {
    internal static Int32RangeIntNullConvertTypeWrapper NlRRSjbElfQRvXMA4lRT;

    public Type OriginalType => Int32RangeIntNullConvertTypeWrapper.SHdVnybE56By1js2CBWV(__typeref (Int32Range));

    public Type ConvertType => typeof (int?);

    public bool RelativeConvertNeeded(Type type) => true;

    public object ConvertWrapper(object obj)
    {
      int num = 1;
      Int32Range int32Range;
      while (true)
      {
        switch (num)
        {
          case 1:
            int32Range = (Int32Range) obj;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (object) int32Range.From;
    }

    public Int32RangeIntNullConvertTypeWrapper()
    {
      Int32RangeIntNullConvertTypeWrapper.nCJhZFbEj7cMyCAsgXh2();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type SHdVnybE56By1js2CBWV([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool gbfvEpbErV6tjxfDFG2g() => Int32RangeIntNullConvertTypeWrapper.NlRRSjbElfQRvXMA4lRT == null;

    internal static Int32RangeIntNullConvertTypeWrapper m9xwa3bEgUcInOsCSxXB() => Int32RangeIntNullConvertTypeWrapper.NlRRSjbElfQRvXMA4lRT;

    internal static void nCJhZFbEj7cMyCAsgXh2() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
