// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Toolbar.DynamicListToolbarItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Views.Toolbar
{
  /// <summary>Динамический список</summary>
  [Serializable]
  public class DynamicListToolbarItem : 
    RootToolbarItem,
    IDynamicViewItem,
    IViewItemWithPropertyParents
  {
    internal static DynamicListToolbarItem tfOBjIotZAl1YKwGjAcO;

    /// <summary>Ctor</summary>
    public DynamicListToolbarItem()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
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
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
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

    internal static bool osPcouotuecwqaTOppYy() => DynamicListToolbarItem.tfOBjIotZAl1YKwGjAcO == null;

    internal static DynamicListToolbarItem DAP500otI7WjaoIXRli5() => DynamicListToolbarItem.tfOBjIotZAl1YKwGjAcO;
  }
}
