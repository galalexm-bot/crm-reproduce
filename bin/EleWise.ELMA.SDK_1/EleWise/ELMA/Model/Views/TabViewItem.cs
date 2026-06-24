// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.TabViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Вкладка</summary>
  [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_TabViewItem), "DisplayName")]
  [DebuggerTypeProxy(typeof (TabViewItem.DebugView))]
  [Serializable]
  public class TabViewItem : 
    RootViewItem,
    ILayoutItemViewItem,
    IContainerViewItem,
    IViewItemLoading,
    IBadgeViewItem
  {
    private static TabViewItem cGthGFop2ShPXAedLoVP;

    public TabViewItem()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            TabViewItem.Icd4qoop1FNYKAO0Tstd((object) this, (object) "");
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 3 : 1;
            continue;
          case 2:
            this.LoadingType = ViewItemLoadingType.AsyncLoading;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
            continue;
          case 3:
            this.AsyncLoading = true;
            num = 2;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_7:;
    }

    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    [EleWise.ELMA.Globalization.Localizable]
    public virtual string Caption
    {
      get => this.\u003CCaption\u003Ek__BackingField;
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
              this.\u003CCaption\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
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

    /// <summary>Представление для содержимого заголовка вкладки</summary>
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    [DefaultValue("")]
    public virtual string CaptionViewName
    {
      get => this.\u003CCaptionViewName\u003Ek__BackingField;
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
              this.\u003CCaptionViewName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
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
    /// Использовать в качестве модели оригинальную начальную модель
    /// </summary>
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    [DefaultValue(false)]
    public virtual bool CaptionUseOriginalModel
    {
      get => this.\u003CCaptionUseOriginalModel\u003Ek__BackingField;
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
              this.\u003CCaptionUseOriginalModel\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
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
    /// Загружать содержимое вкладки асинхронно при переходе на нее
    /// </summary>
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    [DefaultValue(true)]
    public bool AsyncLoading
    {
      get => this.\u003CAsyncLoading\u003Ek__BackingField;
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
              this.\u003CAsyncLoading\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
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

    /// <summary>Фиксировать размер контейнера</summary>
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    [DefaultValue(false)]
    public bool FixedHeight
    {
      get => this.\u003CFixedHeight\u003Ek__BackingField;
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
              this.\u003CFixedHeight\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
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

    /// <summary>Тип загрузки</summary>
    [DefaultValue(ViewItemLoadingType.AsyncLoading)]
    public ViewItemLoadingType LoadingType
    {
      get => this.\u003CLoadingType\u003Ek__BackingField;
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
              this.\u003CLoadingType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
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

    /// <summary>Текст</summary>
    [DefaultValue("")]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
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
            goto label_3;
          case 2:
            if (parentViewItem == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return parentViewItem is TabLayoutViewItem;
label_3:
      return true;
    }

    public override bool IsChildValid(ViewItem childViewItem) => true;

    internal static void Icd4qoop1FNYKAO0Tstd([In] object obj0, [In] object obj1) => ((TabViewItem) obj0).CaptionViewName = (string) obj1;

    internal static bool uKduKFope4V0HEZiMqFZ() => TabViewItem.cGthGFop2ShPXAedLoVP == null;

    internal static TabViewItem oQgM7LopP5T5X17G9kIG() => TabViewItem.cGthGFop2ShPXAedLoVP;

    public new sealed class DebugView
    {
      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      private readonly TabViewItem viewItem;
      [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
      private readonly RootViewItem.DebugView _rootViewItemDebugView;
      private static TabViewItem.DebugView EUMhTWCZfM77BET9bdcm;

      public DebugView(TabViewItem viewItem)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.viewItem = viewItem;
              num = 2;
              continue;
            case 2:
              goto label_3;
            default:
              this._rootViewItemDebugView = new RootViewItem.DebugView((RootViewItem) viewItem);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 1 : 1;
              continue;
          }
        }
label_3:;
      }

      public string Caption
      {
        get => (string) TabViewItem.DebugView.J0jAPoCZvWvnsjSNh5le((object) this.viewItem);
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
                TabViewItem.DebugView.PDYU51CZ8yMZGPbBRUCs((object) this.viewItem, (object) value);
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

      public string CaptionViewName
      {
        get => (string) TabViewItem.DebugView.PjijlACZZjuIja5WPhHB((object) this.viewItem);
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
                TabViewItem.DebugView.GLr4L2CZuwNT1B0Wv9ea((object) this.viewItem, (object) value);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
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

      public bool CaptionUseOriginalModel
      {
        get => this.viewItem.CaptionUseOriginalModel;
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
                TabViewItem.DebugView.eooca9CZIPLqSXgXc6vq((object) this.viewItem, value);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 0 : 0;
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

      public bool AsyncLoading
      {
        get => TabViewItem.DebugView.gfSQ1xCZVe6EQdCUwiVg((object) this.viewItem);
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
                this.viewItem.AsyncLoading = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
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

      internal static bool WIgSyjCZQG4i2e20IuYy() => TabViewItem.DebugView.EUMhTWCZfM77BET9bdcm == null;

      internal static TabViewItem.DebugView nmocOnCZCAILm1n19mFx() => TabViewItem.DebugView.EUMhTWCZfM77BET9bdcm;

      internal static object J0jAPoCZvWvnsjSNh5le([In] object obj0) => (object) ((TabViewItem) obj0).Caption;

      internal static void PDYU51CZ8yMZGPbBRUCs([In] object obj0, [In] object obj1) => ((TabViewItem) obj0).Caption = (string) obj1;

      internal static object PjijlACZZjuIja5WPhHB([In] object obj0) => (object) ((TabViewItem) obj0).CaptionViewName;

      internal static void GLr4L2CZuwNT1B0Wv9ea([In] object obj0, [In] object obj1) => ((TabViewItem) obj0).CaptionViewName = (string) obj1;

      internal static void eooca9CZIPLqSXgXc6vq([In] object obj0, bool value) => ((TabViewItem) obj0).CaptionUseOriginalModel = value;

      internal static bool gfSQ1xCZVe6EQdCUwiVg([In] object obj0) => ((TabViewItem) obj0).AsyncLoading;
    }
  }
}
