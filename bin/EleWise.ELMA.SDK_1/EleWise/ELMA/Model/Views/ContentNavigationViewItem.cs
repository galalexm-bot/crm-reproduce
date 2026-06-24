// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ContentNavigationViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Меню с формой</summary>
  [Serializable]
  public class ContentNavigationViewItem : 
    RootViewItem,
    IViewItemWithActiveKey,
    IViewItemWithPropertyParents
  {
    private static ContentNavigationViewItem tQhD48oXSvE2CSBEVvTs;

    /// <summary>Ctor</summary>
    public ContentNavigationViewItem()
    {
      ContentNavigationViewItem.IQLg6koXqfrrbuh4UfL8();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.PropertyParents = new List<Guid>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Заголовок</summary>
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

    /// <summary>Уничтожать вкладку при закрытии</summary>
    [DefaultValue(false)]
    public bool DestroyOnClose
    {
      get => this.\u003CDestroyOnClose\u003Ek__BackingField;
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
              this.\u003CDestroyOnClose\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
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
    public Guid ActiveKeyProperty
    {
      get => this.\u003CActiveKeyProperty\u003Ek__BackingField;
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
              this.\u003CActiveKeyProperty\u003Ek__BackingField = value;
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

    /// <inheritdoc />
    public List<Guid> PropertyParents { get; set; }

    /// <inheritdoc />
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
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
      return ContentNavigationViewItem.kT3AlpoXKUhC9ZPJdlmi((object) parentViewItem, (object) this);
label_3:
      return true;
    }

    /// <inheritdoc />
    public override bool IsChildValid(ViewItem childViewItem) => childViewItem is ContentNavigationNodeViewItem;

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.Model.Views.ContentNavigationViewItem.PropertyParents" />
    /// </summary>
    /// <returns><c>true</c>, если нужно сериализовать</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializePropertyParents()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.PropertyParents != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return ContentNavigationViewItem.vptypEoXXsFDClwvf7N9((object) this.PropertyParents) > 0;
label_3:
      return false;
    }

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.Model.Views.ContentNavigationViewItem.ActiveKeyProperty" />
    /// </summary>
    /// <returns><c>true</c>, если нужно сериализовать</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeActiveKeyProperty() => ContentNavigationViewItem.KL7RZFoXTHRvvFw3iNUD(this.ActiveKeyProperty, Guid.Empty);

    internal static void IQLg6koXqfrrbuh4UfL8() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool OV3qtJoXisJ4rTW2nMyd() => ContentNavigationViewItem.tQhD48oXSvE2CSBEVvTs == null;

    internal static ContentNavigationViewItem o2YWK7oXROJZScnvb34v() => ContentNavigationViewItem.tQhD48oXSvE2CSBEVvTs;

    internal static bool kT3AlpoXKUhC9ZPJdlmi([In] object obj0, [In] object obj1) => ((ViewItem) obj0).IsChildValid((ViewItem) obj1);

    internal static int vptypEoXXsFDClwvf7N9([In] object obj0) => ((List<Guid>) obj0).Count;

    internal static bool KL7RZFoXTHRvvFw3iNUD([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;
  }
}
