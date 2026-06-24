// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.TableLayoutViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Шаблон для формы с таблицей</summary>
  [DisplayName(typeof (__Resources_TableLayoutViewItem), "DisplayName")]
  [Serializable]
  public class TableLayoutViewItem : RootViewItem, ILayoutViewItem
  {
    private readonly List<TableColumnSettings> columnsSettings;
    private static TableLayoutViewItem jFeAVWoeJVcO3L0mXZp1;

    public TableLayoutViewItem()
    {
      TableLayoutViewItem.xiMcxroelVFELhFMB9wV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.columnsSettings = new List<TableColumnSettings>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    public List<TableColumnSettings> ColumnsSettings => this.columnsSettings;

    public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (parentViewItem != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return TableLayoutViewItem.ODk8R1oerqfQdnR6B1fR((object) parentViewItem, (object) this);
label_5:
      return true;
    }

    public override bool IsChildValid(ViewItem childViewItem) => childViewItem is TableRowViewItem;

    internal static void xiMcxroelVFELhFMB9wV() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool w8PQYToe9XkJ4pUq4Egr() => TableLayoutViewItem.jFeAVWoeJVcO3L0mXZp1 == null;

    internal static TableLayoutViewItem XAbxfWoedVJflCGFVq9E() => TableLayoutViewItem.jFeAVWoeJVcO3L0mXZp1;

    internal static bool ODk8R1oerqfQdnR6B1fR([In] object obj0, [In] object obj1) => ((ViewItem) obj0).IsChildValid((ViewItem) obj1);
  }
}
