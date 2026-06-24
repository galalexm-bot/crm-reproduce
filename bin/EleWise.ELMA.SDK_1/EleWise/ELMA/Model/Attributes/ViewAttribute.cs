// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.ViewAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>Параметры отображения свойства в представлении</summary>
  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
  [Serializable]
  public class ViewAttribute : Attribute
  {
    private bool readOnly;
    internal static ViewAttribute YAXgHNoZcZOc20XSZ4X5;

    /// <summary>Ctor</summary>
    public ViewAttribute()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.Visibility = Visibility.Visible;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 1 : 0;
            continue;
          default:
            this.ViewType = ViewType.All;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 2 : 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Ctor</summary>
    /// <param name="visibility">Видимость</param>
    public ViewAttribute(Visibility visibility)
    {
      ViewAttribute.iNK3nxouBaw8baKXA8fw();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
        num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.ViewType = ViewType.All;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
            continue;
          default:
            this.Visibility = visibility;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Тип представления</summary>
    [DefaultValue(ViewType.All)]
    public ViewType ViewType
    {
      get => this.\u003CViewType\u003Ek__BackingField;
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
              this.\u003CViewType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
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

    /// <summary>Тип элемента</summary>
    [DefaultValue(ItemType.Default)]
    public ItemType ItemType
    {
      get => this.\u003CItemType\u003Ek__BackingField;
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
              this.\u003CItemType\u003Ek__BackingField = value;
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

    /// <summary>Видимость</summary>
    [DefaultValue(Visibility.Visible)]
    public Visibility Visibility
    {
      get => this.\u003CVisibility\u003Ek__BackingField;
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
              this.\u003CVisibility\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
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

    /// <summary>Получить видимость</summary>
    public bool Visible => this.Visibility == Visibility.Visible;

    /// <summary>
    /// Признак, что свойство отображается в режиме "Только для чтения"
    /// </summary>
    [DefaultValue(false)]
    public bool ReadOnly
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!this.readOnly)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        return (this.ViewType & ViewType.Display) == ViewType.Display;
label_5:
        return true;
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
              this.readOnly = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
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

    internal static bool cljqTDoZzmmaBbjUOt2r() => ViewAttribute.YAXgHNoZcZOc20XSZ4X5 == null;

    internal static ViewAttribute Cmhr1pouFi8Vm69XHuDo() => ViewAttribute.YAXgHNoZcZOc20XSZ4X5;

    internal static void iNK3nxouBaw8baKXA8fw() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
