// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.HtmlStringWrapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using System.Web;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types.Helpers
{
  [XmlRoot("HtmlString")]
  [Component]
  public class HtmlStringWrapper : IXsiType
  {
    private static HtmlStringWrapper od8Lpmbb1U7X8RCwGF4d;

    public HtmlStringWrapper()
    {
      HtmlStringWrapper.VFUy1ObbpiH1leblcI86();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public HtmlStringWrapper(HtmlString html)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Value = html;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
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
    public string HtmlValue
    {
      get => this.\u003CHtmlValue\u003Ek__BackingField;
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
              this.\u003CHtmlValue\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
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
    public HtmlString Value
    {
      get
      {
        int num = 1;
        string htmlValue;
        while (true)
        {
          switch (num)
          {
            case 1:
              htmlValue = this.HtmlValue;
              if (htmlValue == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_5:
        string str = string.Empty;
label_6:
        return new HtmlString(str);
label_2:
        str = htmlValue;
        goto label_6;
      }
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (value != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
                continue;
              }
              goto label_6;
            case 2:
              goto label_2;
            default:
              this.HtmlValue = value.ToString();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 2 : 1;
              continue;
          }
        }
label_2:
        return;
label_6:;
      }
    }

    internal static void VFUy1ObbpiH1leblcI86() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool eDX8dJbbNfFoctcLEHkt() => HtmlStringWrapper.od8Lpmbb1U7X8RCwGF4d == null;

    internal static HtmlStringWrapper sYrDNRbb3K9B4HHGFM8d() => HtmlStringWrapper.od8Lpmbb1U7X8RCwGF4d;
  }
}
