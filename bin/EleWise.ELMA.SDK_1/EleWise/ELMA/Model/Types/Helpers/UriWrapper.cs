// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.UriWrapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types.Helpers
{
  [Component]
  [XmlRoot("UriValue")]
  public class UriWrapper : IXsiType
  {
    private static UriWrapper bqi9D8bbBn4JpPNC1jrZ;

    public UriWrapper()
    {
      UriWrapper.M6h3eLbbbr4L2FTxHxXA();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public UriWrapper(Uri uri)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Value = uri;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    [XmlElement("Value")]
    public string UriValue
    {
      get => this.\u003CUriValue\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CUriValue\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    [XmlIgnore]
    public Uri Value
    {
      get
      {
        int num1 = 2;
        while (true)
        {
          switch (num1)
          {
            case 1:
              goto label_6;
            case 2:
              if (!string.IsNullOrEmpty(this.UriValue))
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 1 : 1;
                continue;
              }
              goto label_4;
            default:
              goto label_4;
          }
        }
label_4:
        return (Uri) null;
label_6:
        Uri uri;
        try
        {
          uri = new Uri(this.UriValue, UriKind.RelativeOrAbsolute);
          int num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
            num2 = 0;
          switch (num2)
          {
          }
        }
        catch (Exception ex)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                uri = (Uri) null;
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
                continue;
              default:
                goto label_5;
            }
          }
        }
label_5:
        return uri;
      }
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_6;
            case 1:
              if (!UriWrapper.pTmxKhbbhgRRbow5T6Dq((object) value, (object) null))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
                continue;
              }
              goto case 3;
            case 2:
              goto label_2;
            case 3:
              this.UriValue = (string) UriWrapper.qamb2mbbGkMwIQSxqM1x((object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 2;
              continue;
            default:
              goto label_7;
          }
        }
label_6:
        return;
label_2:
        return;
label_7:;
      }
    }

    internal static void M6h3eLbbbr4L2FTxHxXA() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool E5eSJObbWGXWs5VVkR8r() => UriWrapper.bqi9D8bbBn4JpPNC1jrZ == null;

    internal static UriWrapper V3BUWwbboHjh8AWpBnWY() => UriWrapper.bqi9D8bbBn4JpPNC1jrZ;

    internal static bool pTmxKhbbhgRRbow5T6Dq([In] object obj0, [In] object obj1) => (Uri) obj0 != (Uri) obj1;

    internal static object qamb2mbbGkMwIQSxqM1x([In] object obj0) => (object) ((Uri) obj0).OriginalString;
  }
}
