// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.TreeSelectViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Common;
using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Расширенный поиск</summary>
  [Serializable]
  public class TreeSelectViewItem : ViewItem, IFocusable
  {
    private static TreeSelectViewItem ydFZVBoXkcxxXgnlYPUZ;

    /// <summary>Подсказка в строке поиска</summary>
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    [EleWise.ELMA.Globalization.Localizable]
    public string Placeholder
    {
      get => this.\u003CPlaceholder\u003Ek__BackingField;
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
              this.\u003CPlaceholder\u003Ek__BackingField = value;
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

    /// <summary>Можно ли выбирать узел дерева</summary>
    public bool SelectableParentNode
    {
      get => this.\u003CSelectableParentNode\u003Ek__BackingField;
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
              this.\u003CSelectableParentNode\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
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

    /// <summary>
    /// Выбранное значение
    /// Используется для рефлексии при генерации вычисляемого значения
    /// </summary>
    private DropDownItem Value
    {
      get => this.\u003CValue\u003Ek__BackingField;
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
              this.\u003CValue\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
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

    /// <inheritdoc />
    [DefaultValue(FocusableType.None)]
    public FocusableType FocusableType
    {
      get => this.\u003CFocusableType\u003Ek__BackingField;
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
              this.\u003CFocusableType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
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

    /// <inheritdoc />
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return TreeSelectViewItem.PosSoSoX2UHXYycOtFrb((object) parentViewItem, (object) this);
label_3:
      return true;
    }

    /// <inheritdoc />
    public override bool IsChildValid(ViewItem childViewItem) => false;

    public TreeSelectViewItem()
    {
      TreeSelectViewItem.iOyBG9oXeXTaLrNfSSo1();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool QQELaXoXniGaIuCvioC2() => TreeSelectViewItem.ydFZVBoXkcxxXgnlYPUZ == null;

    internal static TreeSelectViewItem v6ajtCoXOwKVsFLbK7GW() => TreeSelectViewItem.ydFZVBoXkcxxXgnlYPUZ;

    internal static bool PosSoSoX2UHXYycOtFrb([In] object obj0, [In] object obj1) => ((ViewItem) obj0).IsChildValid((ViewItem) obj1);

    internal static void iOyBG9oXeXTaLrNfSSo1() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
