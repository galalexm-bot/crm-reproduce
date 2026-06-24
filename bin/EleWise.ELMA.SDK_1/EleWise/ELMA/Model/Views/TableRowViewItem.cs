// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.TableRowViewItem
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
  /// <summary>Строка таблицы</summary>
  [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_TableRowViewItem), "DisplayName")]
  [Serializable]
  public class TableRowViewItem : RootViewItem, ILayoutItemViewItem
  {
    internal static TableRowViewItem uVKC51oesnNcGlw1ZNg5;

    [XmlIgnore]
    public Unit Height
    {
      get => this.\u003CHeight\u003Ek__BackingField;
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
              this.\u003CHeight\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
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

    [DefaultValue("")]
    [XmlElement("Height")]
    public string HeightString
    {
      get
      {
        int num = 1;
        Unit height;
        while (true)
        {
          switch (num)
          {
            case 1:
              height = this.Height;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return height.ToString();
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
              this.Height = new Unit(value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
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

    public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (parentViewItem == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return parentViewItem is TableLayoutViewItem;
label_5:
      return true;
    }

    public override bool IsChildValid(ViewItem childViewItem) => childViewItem is TableCellViewItem;

    public TableRowViewItem()
    {
      TableRowViewItem.XyxNjmoPFdU1PeLn0M1d();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool H1hqBpoec0KYiW1kOyUC() => TableRowViewItem.uVKC51oesnNcGlw1ZNg5 == null;

    internal static TableRowViewItem FmIBrroezvClWR7y6Rpn() => TableRowViewItem.uVKC51oesnNcGlw1ZNg5;

    internal static void XyxNjmoPFdU1PeLn0M1d() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
