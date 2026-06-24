// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Common.Models.WebDataItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;

namespace EleWise.ELMA.Common.Models
{
  /// <summary>Элемент данных</summary>
  [DataContract]
  [KnownType(typeof (WebData))]
  [KnownType(typeof (WebData[]))]
  [Serializable]
  public class WebDataItem
  {
    protected string name;
    protected string value;
    protected WebData data;
    protected WebData[] dataArray;
    internal static WebDataItem pYd1Onfitr37UJ0eSXm4;

    public WebDataItem()
    {
      WebDataItem.jdp3bVfi6iJow1PlLPys();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.dataArray = new WebData[0];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Имя параметра</summary>
    [DataMember]
    public virtual string Name
    {
      get => this.name;
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
              this.name = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
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

    /// <summary>Значение</summary>
    [DataMember]
    public virtual string Value
    {
      get => this.value;
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
              this.value = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
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

    /// <summary>Значение со словарем данных</summary>
    [DataMember]
    public virtual WebData Data
    {
      get => this.data;
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
              this.data = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
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

    /// <summary>Значение с массивом словарей данных</summary>
    [DataMember]
    public virtual WebData[] DataArray
    {
      get => this.dataArray;
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
              this.dataArray = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
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

    public override string ToString()
    {
      int num1 = 2;
      StringBuilder stringBuilder1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              WebDataItem.cLdHSffiAgJMsKe14wRO((object) stringBuilder1, (object) (this.name + (string) WebDataItem.lKUvHFfiHgZOtEttueh1(1012087039 ^ 1012093099)));
              num2 = 4;
              continue;
            case 2:
              stringBuilder1 = new StringBuilder();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 1 : 1;
              continue;
            case 3:
              WebDataItem.c2l5Hrfi7RU5ZH7Y1nxu((object) stringBuilder1, WebDataItem.lKUvHFfiHgZOtEttueh1(-1255365154 ^ 596875508 ^ -1765815358));
              num2 = 13;
              continue;
            case 4:
              if (this.value != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 3 : 9;
                continue;
              }
              goto case 10;
            case 5:
              WebDataItem.cLdHSffiAgJMsKe14wRO((object) stringBuilder1, WebDataItem.lKUvHFfiHgZOtEttueh1(694673736 ^ -23604109 ^ -672127523));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 12 : 3;
              continue;
            case 6:
            case 7:
            case 12:
            case 13:
              goto label_10;
            case 8:
            case 15:
              if (this.dataArray != null)
              {
                num2 = 11;
                continue;
              }
              goto case 5;
            case 9:
              WebDataItem.cLdHSffiAgJMsKe14wRO((object) stringBuilder1, (object) ((string) WebDataItem.lKUvHFfiHgZOtEttueh1(-1638402543 ^ -1638405303) + this.value + (string) WebDataItem.lKUvHFfiHgZOtEttueh1(1669212571 ^ 1669215427)));
              num2 = 6;
              continue;
            case 10:
              if (this.data == null)
              {
                num2 = 15;
                continue;
              }
              goto case 14;
            case 11:
              WebDataItem.c2l5Hrfi7RU5ZH7Y1nxu((object) stringBuilder1, WebDataItem.lKUvHFfiHgZOtEttueh1(323422137 << 2 ^ 1293740038));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
              continue;
            case 14:
              stringBuilder1.Append((object) this.data);
              num2 = 7;
              continue;
            default:
              goto label_18;
          }
        }
label_18:
        StringBuilder stringBuilder2 = stringBuilder1;
        object separator = WebDataItem.xZC2Uefi0qGfFFBh8PBi(WebDataItem.lKUvHFfiHgZOtEttueh1(-1886646897 ^ -1886625921), WebDataItem.G0Mh6nfixQ0ARMdhclPU());
        WebData[] dataArray = this.dataArray;
        // ISSUE: reference to a compiler-generated field
        Func<WebData, string> func = WebDataItem.\u003C\u003Ec.\u003C\u003E9__17_0;
        Func<WebData, string> selector;
        if (func == null)
        {
          // ISSUE: reference to a compiler-generated field
          WebDataItem.\u003C\u003Ec.\u003C\u003E9__17_0 = selector = (Func<WebData, string>) (d => d.ToString());
        }
        else
          goto label_6;
label_20:
        IEnumerable<string> values = ((IEnumerable<WebData>) dataArray).Select<WebData, string>(selector);
        string str = string.Join((string) separator, values);
        WebDataItem.cLdHSffiAgJMsKe14wRO((object) stringBuilder2, (object) str);
        num1 = 3;
        continue;
label_6:
        selector = func;
        goto label_20;
      }
label_10:
      return stringBuilder1.ToString();
    }

    internal static void jdp3bVfi6iJow1PlLPys() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool IfVA4YfiwOZmdBNHvNbq() => WebDataItem.pYd1Onfitr37UJ0eSXm4 == null;

    internal static WebDataItem MFFWCQfi447epb3Y2DMg() => WebDataItem.pYd1Onfitr37UJ0eSXm4;

    internal static object lKUvHFfiHgZOtEttueh1(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object cLdHSffiAgJMsKe14wRO([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).Append((string) obj1);

    internal static object c2l5Hrfi7RU5ZH7Y1nxu([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).AppendLine((string) obj1);

    internal static object G0Mh6nfixQ0ARMdhclPU() => (object) Environment.NewLine;

    internal static object xZC2Uefi0qGfFFBh8PBi([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);
  }
}
