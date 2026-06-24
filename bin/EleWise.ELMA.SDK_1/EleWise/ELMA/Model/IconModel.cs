// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.IconModel
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model
{
  /// <summary>
  /// Модель IconPack-иконки используется в <see cref="T:EleWise.ELMA.Services.IIconPackService" />
  /// </summary>
  [Serializable]
  public class IconModel
  {
    private static IconModel xES0AdWgOZrpDwKQISrX;

    /// <summary>Наименование иконки</summary>
    public string Name
    {
      get => this.\u003CName\u003Ek__BackingField;
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
              this.\u003CName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
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

    /// <summary>SVG-разметка</summary>
    public string Data
    {
      get => this.\u003CData\u003Ek__BackingField;
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
              this.\u003CData\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
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

    public IconModel()
    {
      IconModel.SpMnBNWgPRYpRvkMEC7n();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool DVMGYnWg2CkcRQt3EHFE() => IconModel.xES0AdWgOZrpDwKQISrX == null;

    internal static IconModel GTDutGWgeofCaZh9eN8A() => IconModel.xES0AdWgOZrpDwKQISrX;

    internal static void SpMnBNWgPRYpRvkMEC7n() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
