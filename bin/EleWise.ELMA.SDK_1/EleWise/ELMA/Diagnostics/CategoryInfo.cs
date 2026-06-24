// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.CategoryInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Diagnostics
{
  /// <summary>Данные о категориях</summary>
  internal sealed class CategoryInfo
  {
    private static CategoryInfo JH38EwGzFrrBs65iA7Rn;

    /// <summary>Имя категории</summary>
    public string CategoryName
    {
      get => this.\u003CCategoryName\u003Ek__BackingField;
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
              this.\u003CCategoryName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
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

    /// <summary>Описание категории</summary>
    public string CategoryHelp
    {
      get => this.\u003CCategoryHelp\u003Ek__BackingField;
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
              this.\u003CCategoryHelp\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
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

    /// <summary>Данные счетчиков</summary>
    public List<CounterInfo> CountersData { get; set; }

    public CategoryInfo()
    {
      CategoryInfo.dw6xJ1Gzo1hJQwjUfww0();
      // ISSUE: reference to a compiler-generated field
      this.\u003CCountersData\u003Ek__BackingField = new List<CounterInfo>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool ojbp4lGzB9mS7AseF6ov() => CategoryInfo.JH38EwGzFrrBs65iA7Rn == null;

    internal static CategoryInfo rmVov9GzWMoEbFJMA5b9() => CategoryInfo.JH38EwGzFrrBs65iA7Rn;

    internal static void dw6xJ1Gzo1hJQwjUfww0() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
