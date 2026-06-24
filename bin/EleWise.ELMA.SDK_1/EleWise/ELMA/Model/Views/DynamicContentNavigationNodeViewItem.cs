// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.DynamicContentNavigationNodeViewItem
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
  /// <summary>Динамическая вкладка меню с формой</summary>
  [Serializable]
  public class DynamicContentNavigationNodeViewItem : 
    ContentNavigationNodeViewItem,
    IDynamicViewItem,
    IViewItemWithPropertyParents
  {
    private static DynamicContentNavigationNodeViewItem gwXTSsoSXkovkg3i1U6T;

    /// <summary>Ctor</summary>
    public DynamicContentNavigationNodeViewItem()
    {
      DynamicContentNavigationNodeViewItem.et5fiaoSnibUDWMFavM6();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
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
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
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
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.Model.Views.DynamicContentNavigationNodeViewItem.PropertyParents" />
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return DynamicContentNavigationNodeViewItem.z7twhYoSOuJ2ML5G7oJA((object) this.PropertyParents) > 0;
label_5:
      return false;
    }

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.Model.Views.DynamicContentNavigationNodeViewItem.PropertyUid" />
    /// </summary>
    /// <returns><c>true</c>, если нужно сериализовать</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializePropertyUid() => DynamicContentNavigationNodeViewItem.GuwlmOoS2w5LbKhHehmX(this.PropertyUid, Guid.Empty);

    internal static void et5fiaoSnibUDWMFavM6() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool CbuYK8oSTZPFebhdtmDA() => DynamicContentNavigationNodeViewItem.gwXTSsoSXkovkg3i1U6T == null;

    internal static DynamicContentNavigationNodeViewItem uGTIxVoSkiS3Wh6QXGBL() => DynamicContentNavigationNodeViewItem.gwXTSsoSXkovkg3i1U6T;

    internal static int z7twhYoSOuJ2ML5G7oJA([In] object obj0) => ((List<Guid>) obj0).Count;

    internal static bool GuwlmOoS2w5LbKhHehmX([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;
  }
}
