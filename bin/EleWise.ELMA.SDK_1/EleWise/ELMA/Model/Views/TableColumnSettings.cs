// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.TableColumnSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;
using System.Web.UI.WebControls;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Views
{
  [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_TableColumnSettings), "DisplayName")]
  [Serializable]
  public class TableColumnSettings
  {
    internal static TableColumnSettings X1cYV9oe4ADWrNw98vV5;

    [XmlIgnore]
    public Unit Width
    {
      get => this.\u003CWidth\u003Ek__BackingField;
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
              this.\u003CWidth\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
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

    [XmlElement("Width")]
    [DefaultValue("")]
    public string WidthString
    {
      get
      {
        int num = 1;
        Unit width;
        while (true)
        {
          switch (num)
          {
            case 1:
              width = this.Width;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        return width.ToString();
      }
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
              this.Width = new Unit(value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
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

    public TableColumnSettings()
    {
      TableColumnSettings.UKQ1DCoeAK6qXHQh7JfB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool jefnacoe6tWwyvRZGehj() => TableColumnSettings.X1cYV9oe4ADWrNw98vV5 == null;

    internal static TableColumnSettings r420dUoeHjnQQp5YD3I5() => TableColumnSettings.X1cYV9oe4ADWrNw98vV5;

    internal static void UKQ1DCoeAK6qXHQh7JfB() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
