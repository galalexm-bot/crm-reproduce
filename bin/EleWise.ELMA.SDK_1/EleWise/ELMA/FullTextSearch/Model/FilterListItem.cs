// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Model.FilterListItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.FullTextSearch.Enum;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.FullTextSearch.Model
{
  /// <summary>Описание поля фильтрации в полнотекстовом поиске</summary>
  public class FilterListItem
  {
    private List<object> values;
    internal static FilterListItem I7ALiPGRBB7Hyc4H46Vr;

    public FilterListItem(
      string field,
      List<object> values,
      FilterListItemType itemType,
      FullTextFieldType type)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.values = new List<object>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Field = field;
      this.values = values;
      this.ItemType = itemType;
      this.Type = type;
    }

    public string Field
    {
      get => this.\u003CField\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CField\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
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

    public List<string> Values => this.values.Where<object>((Func<object, bool>) (s => s != null)).Select<object, string>((Func<object, string>) (s => s.ToString())).Distinct<string>().ToList<string>();

    public object[] Array => this.values.ToArray();

    public FilterListItemType ItemType
    {
      get => this.\u003CItemType\u003Ek__BackingField;
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
              this.\u003CItemType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
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

    public FullTextFieldType Type
    {
      get => this.\u003CType\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
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

    internal static bool aWI98FGRW324GrSU5q6L() => FilterListItem.I7ALiPGRBB7Hyc4H46Vr == null;

    internal static FilterListItem KROqIJGRoNgbE6VdD2vs() => FilterListItem.I7ALiPGRBB7Hyc4H46Vr;
  }
}
