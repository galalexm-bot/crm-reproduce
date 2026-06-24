// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Model.FieldListItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.FullTextSearch.Enum;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.FullTextSearch.Model
{
  /// <summary>Описание поля для поиска в полнотекстовом поиске</summary>
  public class FieldListItem
  {
    private static FieldListItem gb058tGRYCuLlJ9cKRO7;

    /// <summary>Ctor</summary>
    /// <param name="field">Имя поля</param>
    /// <param name="value">Значение</param>
    public FieldListItem(string field, string value)
    {
      FieldListItem.lGBX47GRsKg0OCG8IXrE();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Field = field;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.Value = value;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Ctor</summary>
    /// <param name="field">Имя поля</param>
    /// <param name="value">Значение</param>
    /// <param name="itemType">Тип услвоия поиска</param>
    public FieldListItem(string field, string value, FilterListItemType itemType)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(field, value);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.ItemType = itemType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Название поля</summary>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
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

    /// <summary>Значение</summary>
    public string Value
    {
      get => this.\u003CValue\u003Ek__BackingField;
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
              this.\u003CValue\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
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

    /// <summary>Тип условия для поля поиска</summary>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
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

    internal static void lGBX47GRsKg0OCG8IXrE() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool rUavdCGRLlo0DMUZYaQu() => FieldListItem.gb058tGRYCuLlJ9cKRO7 == null;

    internal static FieldListItem wVLg7jGRUQEErdUUXmQT() => FieldListItem.gb058tGRYCuLlJ9cKRO7;
  }
}
