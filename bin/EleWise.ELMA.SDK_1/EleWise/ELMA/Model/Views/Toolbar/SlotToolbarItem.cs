// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Toolbar.SlotToolbarItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Views.Toolbar
{
  /// <summary>Контейнер, содержащий элементы для Placeholder-а</summary>
  [Serializable]
  public class SlotToolbarItem : RootToolbarItem
  {
    private static SlotToolbarItem Yx4ar3otRvF4MEovc3ip;

    /// <summary>
    /// Уникальный идентификатор placeholder-а, к которому привязан контент
    /// </summary>
    public Guid PlaceholderUid
    {
      get => this.\u003CPlaceholderUid\u003Ek__BackingField;
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
              this.\u003CPlaceholderUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
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

    public SlotToolbarItem()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool arkJwGotqaCthGD9deL3() => SlotToolbarItem.Yx4ar3otRvF4MEovc3ip == null;

    internal static SlotToolbarItem KyGfOGotK3VjjCS8Lxf6() => SlotToolbarItem.Yx4ar3otRvF4MEovc3ip;
  }
}
