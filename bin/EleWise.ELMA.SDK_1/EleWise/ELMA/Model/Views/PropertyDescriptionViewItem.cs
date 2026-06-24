// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.PropertyDescriptionViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Элемент отображения описания свойства</summary>
  [DisplayName(typeof (__Resources_PropertyDescriptionViewItem), "DisplayName")]
  [Serializable]
  public class PropertyDescriptionViewItem : PropertyViewItem
  {
    internal static PropertyDescriptionViewItem QaVmuooOygDNyB5o4STR;

    public override bool IsMainPropertyViewItem() => false;

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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return parentViewItem.IsChildValid((ViewItem) this);
label_5:
      return true;
    }

    public override bool IsChildValid(ViewItem childViewItem) => false;

    public PropertyDescriptionViewItem()
    {
      PropertyDescriptionViewItem.tSIU4roO9LkamwBElrTh();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool PfkAGOoOMAKrD1g5bXwE() => PropertyDescriptionViewItem.QaVmuooOygDNyB5o4STR == null;

    internal static PropertyDescriptionViewItem Gr65BnoOJ0s10LdlFmeJ() => PropertyDescriptionViewItem.QaVmuooOygDNyB5o4STR;

    internal static void tSIU4roO9LkamwBElrTh() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
