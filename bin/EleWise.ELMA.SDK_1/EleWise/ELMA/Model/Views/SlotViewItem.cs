// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.SlotViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Контейнер, содержащий элементы для Placeholder-а</summary>
  [Serializable]
  public class SlotViewItem : RootViewItem
  {
    /// <summary>Uid типа слота</summary>
    public static Guid TypeUid;
    private static SlotViewItem ex9heboKJtt2WDuhhoNk;

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

    /// <inheritdoc />
    public override bool IsChildValid(ViewItem childViewItem) => true;

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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return SlotViewItem.d1qu5roKlC9VAU8XihRE((object) parentViewItem, (object) this);
label_3:
      return true;
    }

    public SlotViewItem()
    {
      SlotViewItem.guiGyZoKr6PcxZq0rcMY();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static SlotViewItem()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            SlotViewItem.guiGyZoKr6PcxZq0rcMY();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            SlotViewItem.TypeUid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1199946765 ^ 1200088777));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool abv8v4oK9LMLh02Kb8Gp() => SlotViewItem.ex9heboKJtt2WDuhhoNk == null;

    internal static SlotViewItem VRfCFGoKdtJvUE6irlbC() => SlotViewItem.ex9heboKJtt2WDuhhoNk;

    internal static bool d1qu5roKlC9VAU8XihRE([In] object obj0, [In] object obj1) => ((ViewItem) obj0).IsChildValid((ViewItem) obj1);

    internal static void guiGyZoKr6PcxZq0rcMY() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
