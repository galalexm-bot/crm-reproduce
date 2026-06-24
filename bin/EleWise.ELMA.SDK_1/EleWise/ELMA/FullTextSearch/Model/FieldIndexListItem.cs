// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Model.FieldIndexListItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.FullTextSearch.Enum;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.FullTextSearch.Model
{
  /// <summary>
  /// Описание поля для отправки на индексацию в полнотекстовом поиске
  /// </summary>
  [Serializable]
  public class FieldIndexListItem
  {
    private static FieldIndexListItem wh5LlYGilHYh2Wj1x5H4;

    /// <summary>Ctor</summary>
    public FieldIndexListItem()
    {
      FieldIndexListItem.kKyexdGi5rNbWbDPgF2j();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Tag = FullTextFieldTag.Value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Ctor</summary>
    /// <param name="field">Название поля</param>
    /// <param name="value">Значение</param>
    /// <param name="type">Тип</param>
    public FieldIndexListItem(string field, object value, FullTextFieldType type)
    {
      FieldIndexListItem.kKyexdGi5rNbWbDPgF2j();
      // ISSUE: explicit constructor call
      this.\u002Ector();
      int num = 3;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.Type = type;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 1 : 1;
            continue;
          case 3:
            this.Field = field;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
            continue;
          default:
            this.Value = value;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Ctor</summary>
    /// <param name="field">Название поля</param>
    /// <param name="value">Значение</param>
    /// <param name="type">Тип</param>
    /// <param name="tag">Тип</param>
    public FieldIndexListItem(
      string field,
      object value,
      FullTextFieldType type,
      FullTextFieldTag tag)
    {
      FieldIndexListItem.kKyexdGi5rNbWbDPgF2j();
      // ISSUE: explicit constructor call
      this.\u002Ector(field, value, type);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Tag = tag;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
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
    public object Value
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
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

    /// <summary>Тип поля</summary>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
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

    /// <summary>Метка поля</summary>
    public FullTextFieldTag Tag
    {
      get => this.\u003CTag\u003Ek__BackingField;
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
              this.\u003CTag\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
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

    internal static void kKyexdGi5rNbWbDPgF2j() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool DhHt4IGirJ0QRGNTAxO0() => FieldIndexListItem.wh5LlYGilHYh2Wj1x5H4 == null;

    internal static FieldIndexListItem OjO1dCGig382TkCCPV4a() => FieldIndexListItem.wh5LlYGilHYh2Wj1x5H4;
  }
}
