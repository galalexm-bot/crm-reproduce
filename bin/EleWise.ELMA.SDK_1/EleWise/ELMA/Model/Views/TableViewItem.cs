// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.TableViewItem
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
  /// <summary>Представление для таблицы</summary>
  [Serializable]
  public class TableViewItem : 
    RootViewItem,
    ISelectionItemViewItem,
    IDynamicViewItem,
    IViewItemWithPropertyParents
  {
    internal static TableViewItem zZR6WVoRTwQDj9VacQ1x;

    /// <summary>Ctor</summary>
    public TableViewItem()
    {
      TableViewItem.tojgGKoROYqBhrT0lMcb();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.PropertyParents = new List<Guid>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
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
      return TableViewItem.LcYpfJoR2x4PIkgVxWBH((object) parentViewItem, (object) this);
label_3:
      return true;
    }

    /// <inheritdoc />
    public override bool IsChildValid(ViewItem childViewItem) => childViewItem is IGridColumnViewItem;

    /// <inheritdoc />
    public override bool IsHideEmpty(RootViewItem parent = null)
    {
      int num = 1;
      RootViewItem rootViewItem1;
      while (true)
      {
        RootViewItem rootViewItem2;
        switch (num)
        {
          case 1:
            if (this.HideEmptySettings == HideEmptyEnum.Inherit)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          case 3:
            rootViewItem1 = parent;
            if (rootViewItem1 == null)
            {
              num = 5;
              continue;
            }
            goto label_13;
          case 4:
            rootViewItem2 = this.Parent;
            break;
          case 5:
            goto label_12;
          default:
            rootViewItem2 = parent;
            if (rootViewItem2 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 1 : 4;
              continue;
            }
            break;
        }
        if (rootViewItem2 != null)
          num = 3;
        else
          goto label_14;
      }
label_4:
      return this.HideEmptySettings == HideEmptyEnum.HideEmpty;
label_12:
      rootViewItem1 = this.Parent;
label_13:
      return rootViewItem1.IsHideEmpty((RootViewItem) null);
label_14:
      return false;
    }

    /// <summary>Настройки отображения таблицы</summary>
    [DefaultValue(null)]
    public TableView TableView
    {
      get => this.\u003CTableView\u003Ek__BackingField;
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
              this.\u003CTableView\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
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

    /// <summary>Свойство, по которому производится связь</summary>
    [DefaultValue(null)]
    public Guid PropertyUid
    {
      get => this.\u003CPropertyUid\u003Ek__BackingField;
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
              this.\u003CPropertyUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
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
    public bool EnableSelection
    {
      get => this.\u003CEnableSelection\u003Ek__BackingField;
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
              this.\u003CEnableSelection\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
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
    public Guid SelectablePropertyUid
    {
      get => this.\u003CSelectablePropertyUid\u003Ek__BackingField;
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
              this.\u003CSelectablePropertyUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
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
    public List<Guid> SelectablePropertyParents { get; set; }

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.Model.Views.TableViewItem.PropertyParents" />
    /// </summary>
    /// <returns><c>true</c>, если нужно сериализовать</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializePropertyParents()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.PropertyParents != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return TableViewItem.P3BgoMoResOjmlvh0w02((object) this.PropertyParents) > 0;
label_3:
      return false;
    }

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.Model.Views.TableViewItem.SelectablePropertyParents" />
    /// </summary>
    /// <returns><c>true</c>, если нужно сериализовать</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeSelectablePropertyParents()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.SelectablePropertyParents == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      return TableViewItem.P3BgoMoResOjmlvh0w02((object) this.SelectablePropertyParents) > 0;
label_5:
      return false;
    }

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.Model.Views.TableViewItem.SelectablePropertyUid" />
    /// </summary>
    /// <returns><c>true</c>, если нужно сериализовать</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeSelectablePropertyUid() => TableViewItem.RSSHpNoRPB9seFEu7dEK(this.SelectablePropertyUid, Guid.Empty);

    internal static void tojgGKoROYqBhrT0lMcb() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool wHidkboRkmmvOQNeFwcS() => TableViewItem.zZR6WVoRTwQDj9VacQ1x == null;

    internal static TableViewItem rap6pKoRnE7TnXWP4SIy() => TableViewItem.zZR6WVoRTwQDj9VacQ1x;

    internal static bool LcYpfJoR2x4PIkgVxWBH([In] object obj0, [In] object obj1) => ((ViewItem) obj0).IsChildValid((ViewItem) obj1);

    internal static int P3BgoMoResOjmlvh0w02([In] object obj0) => ((List<Guid>) obj0).Count;

    internal static bool RSSHpNoRPB9seFEu7dEK([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;
  }
}
