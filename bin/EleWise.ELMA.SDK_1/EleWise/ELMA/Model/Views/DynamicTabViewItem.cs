// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.DynamicTabViewItem
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
  /// <summary>Динамическая вкладка</summary>
  [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_DynamicTabViewItem), "DisplayName")]
  [Serializable]
  public class DynamicTabViewItem : TabViewItem, IDynamicViewItem, IViewItemWithPropertyParents
  {
    private static DynamicTabViewItem SrLgpqoXp1x4HsT7j8lu;

    /// <summary>Ctor</summary>
    public DynamicTabViewItem()
    {
      DynamicTabViewItem.KA69VwoXtBVKx7ipO5Dw();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.PropertyParents = new List<Guid>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 1;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
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
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.Model.Views.DynamicTabViewItem.PropertyParents" />
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return DynamicTabViewItem.OesVoLoXwlWKn7S7IS6w((object) this.PropertyParents) > 0;
label_5:
      return false;
    }

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.Model.Views.DynamicTabViewItem.PropertyUid" />
    /// </summary>
    /// <returns><c>true</c>, если нужно сериализовать</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializePropertyUid() => DynamicTabViewItem.X6e4cmoX4sman3WwB43D(this.PropertyUid, Guid.Empty);

    internal static void KA69VwoXtBVKx7ipO5Dw() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool aRXj1noXaDEfwen0ZxBA() => DynamicTabViewItem.SrLgpqoXp1x4HsT7j8lu == null;

    internal static DynamicTabViewItem u7pTZsoXDU0Er9rU5qUQ() => DynamicTabViewItem.SrLgpqoXp1x4HsT7j8lu;

    internal static int OesVoLoXwlWKn7S7IS6w([In] object obj0) => ((List<Guid>) obj0).Count;

    internal static bool X6e4cmoX4sman3WwB43D([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;
  }
}
