// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.BadgeViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Transformations;
using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Счетчик</summary>
  [Serializable]
  public class BadgeViewItem : RootViewItem, IBadgeViewItem
  {
    private static BadgeViewItem jOo8pyoiknpVs8yoJYa7;

    /// <summary>Текст</summary>
    [EleWise.ELMA.Globalization.Localizable]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    [DefaultValue("")]
    public string BadgeText
    {
      get => this.\u003CBadgeText\u003Ek__BackingField;
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
              this.\u003CBadgeText\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
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

    /// <summary>Отображать счетчик в виде точки</summary>
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    [DefaultValue(false)]
    public bool Dot
    {
      get => this.\u003CDot\u003Ek__BackingField;
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
              this.\u003CDot\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
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

    /// <summary>Цвет</summary>
    [DefaultValue(ButtonStyle.Default)]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public ButtonStyle BadgeStyle
    {
      get => this.\u003CBadgeStyle\u003Ek__BackingField;
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
              this.\u003CBadgeStyle\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
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
    public override bool IsValid(ViewType viewType, ViewItem parentViewItem) => true;

    /// <inheritdoc />
    public override bool IsChildValid(ViewItem childViewItem)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_8;
            case 2:
              goto label_7;
            case 3:
              if (BadgeViewItem.M8lt0koi25x5VVB9gqye((object) this.Items) >= 1)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
                continue;
              }
              goto case 5;
            case 4:
              if (this.Items == null)
                goto case 5;
              else
                goto label_6;
            case 5:
              if (childViewItem is ContentNavigationViewItem)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 1;
                continue;
              }
              goto case 6;
            case 6:
              if (!(childViewItem is PanelViewItem))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 2 : 1;
                continue;
              }
              goto label_8;
            default:
              goto label_9;
          }
        }
label_6:
        num1 = 3;
      }
label_7:
      return !(childViewItem is TabLayoutViewItem);
label_8:
      return false;
label_9:
      return false;
    }

    public BadgeViewItem()
    {
      BadgeViewItem.a9WFg7oiedyrg5EBMuM7();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool yy5L25oinevLSfLMBeik() => BadgeViewItem.jOo8pyoiknpVs8yoJYa7 == null;

    internal static BadgeViewItem TMI5IjoiOXnadMRt8xQk() => BadgeViewItem.jOo8pyoiknpVs8yoJYa7;

    internal static int M8lt0koi25x5VVB9gqye([In] object obj0) => ((EventedList<ViewItem>) obj0).Count;

    internal static void a9WFg7oiedyrg5EBMuM7() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
