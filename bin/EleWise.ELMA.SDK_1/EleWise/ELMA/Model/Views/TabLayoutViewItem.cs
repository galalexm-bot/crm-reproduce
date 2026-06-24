// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.TabLayoutViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views.Toolbox;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Шаблон для формы со вкладками</summary>
  [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_TabLayoutViewItem), "DisplayName")]
  [Serializable]
  public class TabLayoutViewItem : 
    RootViewItem,
    ILayoutViewItem,
    IViewItemWithActiveKey,
    IViewItemWithPropertyParents
  {
    internal static TabLayoutViewItem WWJjCpopIoNEeg5XR8Pg;

    /// <summary>Ctor</summary>
    public TabLayoutViewItem()
    {
      TabLayoutViewItem.x3kMXYopiqVSeMrgdsvR();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.TabProviderUseOriginalModel = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
            continue;
          default:
            this.PropertyParents = new List<Guid>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
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
            if (parentViewItem == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
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
      return parentViewItem.IsChildValid((ViewItem) this);
label_3:
      return true;
    }

    /// <inheritdoc />
    public override bool IsChildValid(ViewItem childViewItem) => childViewItem is TabViewItem;

    /// <summary>
    /// Использовать точку расширения ITabProviderExtension для добавления вкладок
    /// </summary>
    [DefaultValue(false)]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public bool UseTabProvider
    {
      get => this.\u003CUseTabProvider\u003Ek__BackingField;
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
              this.\u003CUseTabProvider\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
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

    /// <summary>Передавать оригинальную модель в точку расширения</summary>
    [DefaultValue(true)]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public bool TabProviderUseOriginalModel
    {
      get => this.\u003CTabProviderUseOriginalModel\u003Ek__BackingField;
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
              this.\u003CTabProviderUseOriginalModel\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
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

    /// <summary>Ключ активной вкладки</summary>
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
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

    /// <inheritdoc />
    public List<Guid> PropertyParents { get; set; }

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.Model.Views.TabLayoutViewItem.ActiveKeyProperty" />
    /// </summary>
    /// <returns><c>true</c>, если нужно сериализовать</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeActiveKeyProperty() => TabLayoutViewItem.Tmd2LMopRqDWTRgr1hXr(this.ActiveKeyProperty, Guid.Empty);

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.Model.Views.TabLayoutViewItem.PropertyParents" />
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return TabLayoutViewItem.eoM1IMopqBpoWbr6ZuF4((object) this.PropertyParents) > 0;
label_3:
      return false;
    }

    internal static void x3kMXYopiqVSeMrgdsvR() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool zMIMUmopVvikR0rTpNac() => TabLayoutViewItem.WWJjCpopIoNEeg5XR8Pg == null;

    internal static TabLayoutViewItem jWj1PoopS3axiuTnAqHy() => TabLayoutViewItem.WWJjCpopIoNEeg5XR8Pg;

    internal static bool Tmd2LMopRqDWTRgr1hXr([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static int eoM1IMopqBpoWbr6ZuF4([In] object obj0) => ((List<Guid>) obj0).Count;

    [Component(Order = 300)]
    private class ToolboxItem : CommonViewItemToolboxItem<TabLayoutViewItem>
    {
      internal static object BtQlQiCZbF8pBVREOQ4S;

      public ToolboxItem()
      {
        TabLayoutViewItem.ToolboxItem.sDc8yfCZETWPUH8hp04u();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static void sDc8yfCZETWPUH8hp04u() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool fFH2xBCZh45JebhwWuax() => TabLayoutViewItem.ToolboxItem.BtQlQiCZbF8pBVREOQ4S == null;

      internal static TabLayoutViewItem.ToolboxItem nMsFidCZGtVH1mt8ylMw() => (TabLayoutViewItem.ToolboxItem) TabLayoutViewItem.ToolboxItem.BtQlQiCZbF8pBVREOQ4S;
    }
  }
}
