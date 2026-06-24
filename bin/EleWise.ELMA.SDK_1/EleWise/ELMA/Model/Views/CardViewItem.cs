// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.CardViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Карточка</summary>
  [Serializable]
  public class CardViewItem : RootViewItem, IContainerViewItem
  {
    private ViewItemComponentSize size;
    internal static CardViewItem O3trYBoqk5nmq9bMyspj;

    /// <summary>Отображать ли карточку на всю ширину контейнера</summary>
    [DefaultValue(false)]
    [Obsolete("Use Size instead", false)]
    [XmlForceElement]
    public bool IsFullWidth
    {
      get => this.\u003CIsFullWidth\u003Ek__BackingField;
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
              this.\u003CIsFullWidth\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
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

    /// <summary>Размер карточки</summary>
    [DefaultValue(ViewItemComponentSize.Small)]
    public ViewItemComponentSize Size
    {
      get
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            case 2:
              if (!this.IsFullWidth)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 1;
                continue;
              }
              goto label_2;
            default:
              goto label_2;
          }
        }
label_2:
        return ViewItemComponentSize.Full;
label_3:
        return this.size;
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
              this.size = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
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

    /// <summary>Отступ</summary>
    [DefaultValue(CardPaddingType.Small)]
    public CardPaddingType Padding
    {
      get => this.\u003CPadding\u003Ek__BackingField;
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
              this.\u003CPadding\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
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

    /// <summary>Тип тени</summary>
    [DefaultValue(CardShadow.Volume)]
    public CardShadow ShadowType
    {
      get => this.\u003CShadowType\u003Ek__BackingField;
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
              this.\u003CShadowType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
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

    /// <summary>Текст ярлыка</summary>
    [DefaultValue("")]
    [EleWise.ELMA.Globalization.Localizable]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public string LabelText
    {
      get => this.\u003CLabelText\u003Ek__BackingField;
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
              this.\u003CLabelText\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
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

    /// <summary>Цвет ярлыка</summary>
    [DefaultValue(CardLabelColor.Gray)]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public CardLabelColor LabelColor
    {
      get => this.\u003CLabelColor\u003Ek__BackingField;
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
              this.\u003CLabelColor\u003Ek__BackingField = value;
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

    /// <inheritdoc />
    public override bool IsValid(ViewType viewType, ViewItem parentViewItem) => CardViewItem.kOeFJKoq28HW2XQoaeYm((object) parentViewItem, (object) this);

    /// <inheritdoc />
    public override bool IsChildValid(ViewItem childViewItem) => true;

    public CardViewItem()
    {
      CardViewItem.Ie6SuLoqeSCSXhrCho0w();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool dS2cG6oqnqk9Dw2o03kv() => CardViewItem.O3trYBoqk5nmq9bMyspj == null;

    internal static CardViewItem oU2xl0oqOsSAq2Dj0auG() => CardViewItem.O3trYBoqk5nmq9bMyspj;

    internal static bool kOeFJKoq28HW2XQoaeYm([In] object obj0, [In] object obj1) => ((ViewItem) obj0).IsChildValid((ViewItem) obj1);

    internal static void Ie6SuLoqeSCSXhrCho0w() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
