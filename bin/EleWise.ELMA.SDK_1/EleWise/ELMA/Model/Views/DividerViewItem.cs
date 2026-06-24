// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.DividerViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Enums;
using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Разделитель</summary>
  [Serializable]
  public class DividerViewItem : ViewItem
  {
    private static DividerViewItem X7mZW3oVasgtLSC6x07I;

    /// <summary>Ctor</summary>
    public DividerViewItem()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.DirectionType = DirectionType.Horizontal;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Направление</summary>
    [DefaultValue(DirectionType.Horizontal)]
    public DirectionType DirectionType
    {
      get => this.\u003CDirectionType\u003Ek__BackingField;
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
              this.\u003CDirectionType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
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

    internal static bool O3TPg5oVDbV0Lj5QPg3u() => DividerViewItem.X7mZW3oVasgtLSC6x07I == null;

    internal static DividerViewItem WpOmHaoVton9heAtqrw7() => DividerViewItem.X7mZW3oVasgtLSC6x07I;
  }
}
