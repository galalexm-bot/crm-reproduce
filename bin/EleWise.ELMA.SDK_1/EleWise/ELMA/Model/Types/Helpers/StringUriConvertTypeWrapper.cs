// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.StringUriConvertTypeWrapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Types.Helpers
{
  [Component]
  public class StringUriConvertTypeWrapper : IConvertTypeWrapper
  {
    internal static StringUriConvertTypeWrapper YBDFCbbb8cF7SI8K98Ci;

    public Type OriginalType => typeof (string);

    public Type ConvertType => typeof (Uri);

    public bool RelativeConvertNeeded(Type type) => true;

    public object ConvertWrapper(object obj)
    {
      int num1 = 1;
      string uriString;
      while (true)
      {
        switch (num1)
        {
          case 1:
            uriString = (string) obj;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            goto label_4;
        }
      }
label_2:
      object obj1;
      return obj1;
label_4:
      try
      {
        obj1 = (object) new Uri(uriString, UriKind.RelativeOrAbsolute);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
          num2 = 0;
        switch (num2)
        {
          default:
            goto label_2;
        }
      }
      catch (Exception ex)
      {
        int num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
          num3 = 1;
        while (true)
        {
          switch (num3)
          {
            case 1:
              obj1 = (object) null;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
      }
    }

    public StringUriConvertTypeWrapper()
    {
      StringUriConvertTypeWrapper.nM1fbqbbIwybObfSri1K();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool TYnsDZbbZ4j51SLjS8yM() => StringUriConvertTypeWrapper.YBDFCbbb8cF7SI8K98Ci == null;

    internal static StringUriConvertTypeWrapper EOcpAsbbubLtbCRJqUbh() => StringUriConvertTypeWrapper.YBDFCbbb8cF7SI8K98Ci;

    internal static void nM1fbqbbIwybObfSri1K() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
