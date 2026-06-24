// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.PropertyValueViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Элемент отображения значения свойства</summary>
  [DisplayName(typeof (__Resources_PropertyValueViewItem), "DisplayName")]
  [Serializable]
  public class PropertyValueViewItem : PropertyViewItem
  {
    private static PropertyValueViewItem Ag5YK1oefq2oxra6V9Ld;

    public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (parentViewItem != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return PropertyValueViewItem.kpIaPUoevsvIdew3ZdRR((object) parentViewItem, (object) this);
label_5:
      return true;
    }

    public PropertyValueViewItem()
    {
      PropertyValueViewItem.Soub9Zoe8mcv4VEua1u8();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool kpIaPUoevsvIdew3ZdRR([In] object obj0, [In] object obj1) => ((ViewItem) obj0).IsChildValid((ViewItem) obj1);

    internal static bool HgI1ILoeQ4m27Rtikq7G() => PropertyValueViewItem.Ag5YK1oefq2oxra6V9Ld == null;

    internal static PropertyValueViewItem UDaMAVoeC19WgFjLlBda() => PropertyValueViewItem.Ag5YK1oefq2oxra6V9Ld;

    internal static void Soub9Zoe8mcv4VEua1u8() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
