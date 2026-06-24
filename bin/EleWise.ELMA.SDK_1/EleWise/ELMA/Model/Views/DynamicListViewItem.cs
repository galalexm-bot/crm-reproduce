// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.DynamicListViewItem
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
  /// <summary>Динамический список</summary>
  [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_DynamicListViewItem), "DisplayName")]
  [Serializable]
  public class DynamicListViewItem : RootViewItem, IDynamicViewItem, IViewItemWithPropertyParents
  {
    private static DynamicListViewItem PaJLKooq09oDmtxrdJdH;

    /// <summary>Ctor</summary>
    public DynamicListViewItem()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.PropertyParents = new List<Guid>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
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

    /// <summary>Высота контейнера в процентах</summary>
    [DefaultValue(null)]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public int? HeightPercentage { get; set; }

    /// <inheritdoc />
    public override bool IsChildValid(ViewItem childViewItem) => childViewItem is DynamicSlotViewItem;

    /// <inheritdoc />
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return DynamicListViewItem.hHvy5qoqM3rHq2V19yg2((object) parentViewItem, (object) this);
label_3:
      return true;
    }

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.Model.Views.DynamicListViewItem.PropertyParents" />
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return DynamicListViewItem.r48nVOoqJa6VNU6kHgOR((object) this.PropertyParents) > 0;
label_5:
      return false;
    }

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.Model.Views.DynamicListViewItem.PropertyUid" />
    /// </summary>
    /// <returns><c>true</c>, если нужно сериализовать</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializePropertyUid() => DynamicListViewItem.yDTGvVoq9xGXb1eHsTiy(this.PropertyUid, Guid.Empty);

    internal static bool QClrePoqm1rGe0RUHkyo() => DynamicListViewItem.PaJLKooq09oDmtxrdJdH == null;

    internal static DynamicListViewItem p3gEGJoqyiVF8yAQZCmI() => DynamicListViewItem.PaJLKooq09oDmtxrdJdH;

    internal static bool hHvy5qoqM3rHq2V19yg2([In] object obj0, [In] object obj1) => ((ViewItem) obj0).IsChildValid((ViewItem) obj1);

    internal static int r48nVOoqJa6VNU6kHgOR([In] object obj0) => ((List<Guid>) obj0).Count;

    internal static bool yDTGvVoq9xGXb1eHsTiy([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;
  }
}
