// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.StaticTextViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views.Toolbox;
using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Статичный текст</summary>
  [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_StaticTextViewItem), "DisplayName")]
  [DebuggerTypeProxy(typeof (StaticTextViewItem.DebugView))]
  [Serializable]
  public class StaticTextViewItem : ViewItem, IHideEmptyViewItem, ITooltipViewItem
  {
    private static StaticTextViewItem O5kraWoeiTPqnVng21so;

    [EleWise.ELMA.Globalization.Localizable]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public string Text
    {
      get => this.\u003CText\u003Ek__BackingField;
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
              this.\u003CText\u003Ek__BackingField = value;
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

    /// <summary>Тип текста</summary>
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    [DefaultValue(TextType.Default)]
    public TextType TextType
    {
      get => this.\u003CTextType\u003Ek__BackingField;
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
              this.\u003CTextType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
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

    /// <summary>Цвет текста</summary>
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    [DefaultValue(TextColor.Default)]
    public TextColor TextColor
    {
      get => this.\u003CTextColor\u003Ek__BackingField;
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
              this.\u003CTextColor\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
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
    [EleWise.ELMA.Globalization.Localizable]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    [DefaultValue(null)]
    public string Tooltip
    {
      get => this.\u003CTooltip\u003Ek__BackingField;
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
              this.\u003CTooltip\u003Ek__BackingField = value;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return StaticTextViewItem.hyWY0NoeKgPZ2hsJ8bKc((object) parentViewItem, (object) this);
label_3:
      return true;
    }

    public override bool IsChildValid(ViewItem childViewItem) => false;

    /// <summary>Не показываеть элемент, если в текст не заполнен</summary>
    [XmlElement("HideEmpty")]
    [DefaultValue(HideEmptyEnum.Inherit)]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public HideEmptyEnum HideEmptySettings
    {
      get => this.\u003CHideEmptySettings\u003Ek__BackingField;
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
              this.\u003CHideEmptySettings\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
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

    public bool IsHideEmpty(RootViewItem parent = null)
    {
      int num1 = 1;
      RootViewItem rootViewItem1;
      while (true)
      {
        int num2 = num1;
        RootViewItem rootViewItem2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (this.HideEmptySettings == HideEmptyEnum.Inherit)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            case 2:
              goto label_10;
            case 3:
              rootViewItem1 = parent;
              if (rootViewItem1 == null)
              {
                num2 = 4;
                continue;
              }
              goto label_14;
            case 4:
              goto label_13;
            case 5:
              goto label_3;
            default:
              rootViewItem2 = parent;
              if (rootViewItem2 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 2 : 2;
                continue;
              }
              goto label_11;
          }
        }
label_10:
        rootViewItem2 = this.Parent;
label_11:
        if (rootViewItem2 != null)
          num1 = 3;
        else
          goto label_15;
      }
label_3:
      return this.HideEmptySettings == HideEmptyEnum.HideEmpty;
label_13:
      rootViewItem1 = this.Parent;
label_14:
      return rootViewItem1.IsHideEmpty((RootViewItem) null);
label_15:
      return false;
    }

    public StaticTextViewItem()
    {
      StaticTextViewItem.D35H0BoeX4MSotsW7mCe();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool mM77PboeRcGLUKo27o3i() => StaticTextViewItem.O5kraWoeiTPqnVng21so == null;

    internal static StaticTextViewItem tPKxgRoeqQdGIn7XGuTm() => StaticTextViewItem.O5kraWoeiTPqnVng21so;

    internal static bool hyWY0NoeKgPZ2hsJ8bKc([In] object obj0, [In] object obj1) => ((ViewItem) obj0).IsChildValid((ViewItem) obj1);

    internal static void D35H0BoeX4MSotsW7mCe() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    public new sealed class DebugView
    {
      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      private readonly StaticTextViewItem viewItem;
      [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
      private readonly ViewItem.DebugView _viewItemDebugView;
      private static StaticTextViewItem.DebugView Gfc7oPCQNGxgcgu0ESfJ;

      public DebugView(StaticTextViewItem viewItem)
      {
        StaticTextViewItem.DebugView.tM2lRgCQaHWXRsYbC7MV();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            case 2:
              this.viewItem = viewItem;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 1 : 1;
              continue;
            default:
              this._viewItemDebugView = new ViewItem.DebugView((ViewItem) viewItem);
              num = 2;
              continue;
          }
        }
label_3:;
      }

      public string Text
      {
        get => (string) StaticTextViewItem.DebugView.jUuCQGCQDBSuxYavb4G7((object) this.viewItem);
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
                StaticTextViewItem.DebugView.k4O1uyCQthV3lZPg4ISg((object) this.viewItem, (object) value);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
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

      internal static void tM2lRgCQaHWXRsYbC7MV() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool LBUy7eCQ36NpVgCoKcZc() => StaticTextViewItem.DebugView.Gfc7oPCQNGxgcgu0ESfJ == null;

      internal static StaticTextViewItem.DebugView vos9aBCQpoCskFOKlXDX() => StaticTextViewItem.DebugView.Gfc7oPCQNGxgcgu0ESfJ;

      internal static object jUuCQGCQDBSuxYavb4G7([In] object obj0) => (object) ((StaticTextViewItem) obj0).Text;

      internal static void k4O1uyCQthV3lZPg4ISg([In] object obj0, [In] object obj1) => ((StaticTextViewItem) obj0).Text = (string) obj1;
    }

    [Component(Order = 400)]
    private class ToolboxItem : CommonViewItemToolboxItem<StaticTextViewItem>
    {
      internal static object WnBSh1CQwU22qVdcZ9l4;

      public ToolboxItem()
      {
        StaticTextViewItem.ToolboxItem.TnxZdgCQHJTIyPnYnoRe();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static void TnxZdgCQHJTIyPnYnoRe() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool r13ZkdCQ41LQ0IWl1DpP() => StaticTextViewItem.ToolboxItem.WnBSh1CQwU22qVdcZ9l4 == null;

      internal static StaticTextViewItem.ToolboxItem sThQBSCQ6ZSWIZuqZ6bD() => (StaticTextViewItem.ToolboxItem) StaticTextViewItem.ToolboxItem.WnBSh1CQwU22qVdcZ9l4;
    }
  }
}
