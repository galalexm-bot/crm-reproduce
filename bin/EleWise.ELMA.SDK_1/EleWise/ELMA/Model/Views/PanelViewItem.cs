// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.PanelViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views.Toolbox;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Панель</summary>
  [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_PanelViewItem), "DisplayName")]
  [DebuggerTypeProxy(typeof (PanelViewItem.DebugView))]
  [Serializable]
  public class PanelViewItem : 
    RootViewItem,
    ICustomViewItem,
    ICustomViewNameViewItem,
    IViewItemLoading,
    IBadgeViewItem
  {
    internal static PanelViewItem GwkuG8oPOdZINpgkPj1u;

    public PanelViewItem()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            PanelViewItem.IByySXoPPYlGOWxiMBOh((object) this, PanelViewItemStyle.GrayHeaderNoBorder);
            num = 3;
            continue;
          case 2:
            this.CssClass = "";
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 4 : 2;
            continue;
          case 3:
            PanelViewItem.v1ojpdoP1qfULY7GFikK((object) this, (object) "");
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 2 : 2;
            continue;
          case 4:
            this.AsyncLoading = PanelAsyncLoading.None;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
            continue;
          default:
            goto label_8;
        }
      }
label_3:
      return;
label_8:;
    }

    /// <summary>Название панели</summary>
    [EleWise.ELMA.Globalization.Localizable]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 0;
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

    /// <summary>Панель является сворачиваемой</summary>
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    [DefaultValue(false)]
    public virtual bool Collapsible
    {
      get => this.\u003CCollapsible\u003Ek__BackingField;
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
              this.\u003CCollapsible\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
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

    /// <summary>Состояние свернутости панели по умолчанию</summary>
    [DefaultValue(PanelViewItemCollapseType.DefaultExpanded)]
    [XmlElement("Collapsed")]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public virtual PanelViewItemCollapseType DefaultCollapseState
    {
      get => this.\u003CDefaultCollapseState\u003Ek__BackingField;
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
              this.\u003CDefaultCollapseState\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
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

    /// <summary>Сохранять состояние свернутости</summary>
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    [DefaultValue(false)]
    public virtual bool SaveState
    {
      get => this.\u003CSaveState\u003Ek__BackingField;
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
              this.\u003CSaveState\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
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
    /// Панель раскрыта
    /// Используется для рефлексии при генерации вычисляемого значения
    /// </summary>
    private bool IsExpanded
    {
      get => this.\u003CIsExpanded\u003Ek__BackingField;
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
              this.\u003CIsExpanded\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
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

    /// <summary>Стиль панели</summary>
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    [DefaultValue(PanelViewItemStyle.GrayHeaderNoBorder)]
    public virtual PanelViewItemStyle Style
    {
      get => this.\u003CStyle\u003Ek__BackingField;
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
              this.\u003CStyle\u003Ek__BackingField = value;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
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

    /// <summary>CSS-класс панели</summary>
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    [DefaultValue("")]
    public virtual string CssClass
    {
      get => this.\u003CCssClass\u003Ek__BackingField;
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
              this.\u003CCssClass\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
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

    /// <summary>Загружать содержимое сворачиваемой панели асинхронно</summary>
    [DefaultValue(PanelAsyncLoading.None)]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public PanelAsyncLoading AsyncLoading
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
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

    /// <summary>Представление, для содержимого панели</summary>
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    [DefaultValue("")]
    public virtual string CustomViewName
    {
      get => this.\u003CCustomViewName\u003Ek__BackingField;
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
              this.\u003CCustomViewName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
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
    [DefaultValue(false)]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public virtual bool UseOriginalModel
    {
      get => this.\u003CUseOriginalModel\u003Ek__BackingField;
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
              this.\u003CUseOriginalModel\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
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
    ViewItemLoadingType IViewItemLoading.LoadingType
    {
      get
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_6;
            case 2:
              goto label_8;
            case 3:
              if (this.AsyncLoading == PanelAsyncLoading.None)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 2 : 1;
                continue;
              }
              break;
          }
          if (this.AsyncLoading != PanelAsyncLoading.ExpandAsyncLoading)
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 1 : 0;
          else
            goto label_7;
        }
label_6:
        return ViewItemLoadingType.AsyncLoading;
label_7:
        return ViewItemLoadingType.LazyLoading;
label_8:
        return ViewItemLoadingType.SyncLoading;
      }
      set
      {
        int num1 = 1;
        while (true)
        {
          switch (num1)
          {
            case 0:
              goto label_2;
            case 1:
              int num2;
              switch (value)
              {
                case ViewItemLoadingType.SyncLoading:
                  num2 = 0;
                  break;
                case ViewItemLoadingType.LazyLoading:
                  num2 = 1;
                  break;
                default:
                  num2 = 2;
                  break;
              }
              this.AsyncLoading = (PanelAsyncLoading) num2;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
              continue;
            default:
              goto label_8;
          }
        }
label_2:
        return;
label_8:;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
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

    public override void InitNew(ViewItem parent)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Style = PanelViewItemStyle.Separator;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
            continue;
          case 2:
            base.InitNew(parent);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (parentViewItem == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return PanelViewItem.NPFGEPoPNwNxn11rFY6a((object) parentViewItem, (object) this);
label_3:
      return true;
    }

    public override bool IsChildValid(ViewItem childViewItem) => true;

    internal static void IByySXoPPYlGOWxiMBOh([In] object obj0, PanelViewItemStyle value) => ((PanelViewItem) obj0).Style = value;

    internal static void v1ojpdoP1qfULY7GFikK([In] object obj0, [In] object obj1) => ((PanelViewItem) obj0).CustomViewName = (string) obj1;

    internal static bool SVkbIooP2MQBJiIsOv34() => PanelViewItem.GwkuG8oPOdZINpgkPj1u == null;

    internal static PanelViewItem IZdUEboPeCP6tttvF5NF() => PanelViewItem.GwkuG8oPOdZINpgkPj1u;

    internal static bool NPFGEPoPNwNxn11rFY6a([In] object obj0, [In] object obj1) => ((ViewItem) obj0).IsChildValid((ViewItem) obj1);

    public new sealed class DebugView
    {
      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      private readonly PanelViewItem viewItem;
      [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
      private readonly RootViewItem.DebugView _rootViewItemDebugView;
      private static PanelViewItem.DebugView SkkPndCQlvCYZmpAK7n4;

      public DebugView(PanelViewItem viewItem)
      {
        PanelViewItem.DebugView.AuCZdvCQ5MjqINYONuM4();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              this._rootViewItemDebugView = new RootViewItem.DebugView((RootViewItem) viewItem);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_3;
            default:
              this.viewItem = viewItem;
              num = 2;
              continue;
          }
        }
label_3:;
      }

      public string Caption
      {
        get => (string) PanelViewItem.DebugView.FBNWKPCQjlyTBDlbl6Ow((object) this.viewItem);
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
                PanelViewItem.DebugView.ToogEPCQYgecQ4pfokZ4((object) this.viewItem, (object) value);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
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

      public bool Collapsible
      {
        get => this.viewItem.Collapsible;
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
                PanelViewItem.DebugView.i2R0XvCQL1D5qYTLmksT((object) this.viewItem, value);
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

      /// <summary>Состояние свернутости по умолчанию</summary>
      public PanelViewItemCollapseType DefaultCollapseState
      {
        get => PanelViewItem.DebugView.f3QGuqCQUpvWfPo9DajQ((object) this.viewItem);
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
                PanelViewItem.DebugView.Y2XuScCQs4AEmBN8f2mq((object) this.viewItem, value);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
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

      public PanelAsyncLoading AsyncLoading
      {
        get => this.viewItem.AsyncLoading;
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
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
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

      public string CustomViewName
      {
        get => (string) PanelViewItem.DebugView.tcUto5CQcLmEy0mmU3p5((object) this.viewItem);
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
                PanelViewItem.DebugView.GngtWLCQz9ni5oPPEeig((object) this.viewItem, (object) value);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
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

      public bool UseOriginalModel
      {
        get => this.viewItem.UseOriginalModel;
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
                PanelViewItem.DebugView.dsY6ErCCFHiBKFKWsCc1((object) this.viewItem, value);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
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

      internal static void AuCZdvCQ5MjqINYONuM4() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool CTTHguCQrjilOqH6ASDw() => PanelViewItem.DebugView.SkkPndCQlvCYZmpAK7n4 == null;

      internal static PanelViewItem.DebugView lFv8PECQgbNwXu1ubsKo() => PanelViewItem.DebugView.SkkPndCQlvCYZmpAK7n4;

      internal static object FBNWKPCQjlyTBDlbl6Ow([In] object obj0) => (object) ((PanelViewItem) obj0).Caption;

      internal static void ToogEPCQYgecQ4pfokZ4([In] object obj0, [In] object obj1) => ((PanelViewItem) obj0).Caption = (string) obj1;

      internal static void i2R0XvCQL1D5qYTLmksT([In] object obj0, bool value) => ((PanelViewItem) obj0).Collapsible = value;

      internal static PanelViewItemCollapseType f3QGuqCQUpvWfPo9DajQ([In] object obj0) => ((PanelViewItem) obj0).DefaultCollapseState;

      internal static void Y2XuScCQs4AEmBN8f2mq([In] object obj0, PanelViewItemCollapseType value) => ((PanelViewItem) obj0).DefaultCollapseState = value;

      internal static object tcUto5CQcLmEy0mmU3p5([In] object obj0) => (object) ((PanelViewItem) obj0).CustomViewName;

      internal static void GngtWLCQz9ni5oPPEeig([In] object obj0, [In] object obj1) => ((PanelViewItem) obj0).CustomViewName = (string) obj1;

      internal static void dsY6ErCCFHiBKFKWsCc1([In] object obj0, bool value) => ((PanelViewItem) obj0).UseOriginalModel = value;
    }

    [Component(Order = 200)]
    private class ToolboxItem : CommonViewItemToolboxItem<PanelViewItem>
    {
      internal static object FenC0RCCBiAn0c2epL48;

      public override string Name => (string) PanelViewItem.ToolboxItem.WVA3J4CChk5jeOUry2bn(PanelViewItem.ToolboxItem.d5FjmrCCbfW7yu14IDZj(~210725948 ^ -210571263));

      public ToolboxItem()
      {
        PanelViewItem.ToolboxItem.oMn2xFCCGhtt6FnDOU1x();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static object d5FjmrCCbfW7yu14IDZj(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object WVA3J4CChk5jeOUry2bn([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static bool OUx5JyCCWOQxGdik5GDt() => PanelViewItem.ToolboxItem.FenC0RCCBiAn0c2epL48 == null;

      internal static PanelViewItem.ToolboxItem rrGVTMCCocVDSh10se8j() => (PanelViewItem.ToolboxItem) PanelViewItem.ToolboxItem.FenC0RCCBiAn0c2epL48;

      internal static void oMn2xFCCGhtt6FnDOU1x() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
