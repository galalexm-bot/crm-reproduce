// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.CustomSettingValue
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>Класс сохраниения дополнительных настроек</summary>
  [XmlRoot("CustomSetting")]
  [Serializable]
  public class CustomSettingValue
  {
    internal static CustomSettingValue CZLP8Voswus8Gf2PCKxk;

    /// <summary>Ключ</summary>
    [XmlElement("Key")]
    public string Key
    {
      get => this.\u003CKey\u003Ek__BackingField;
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
              this.\u003CKey\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
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

    /// <summary>Значение. Должно быть сериализуемым</summary>
    [XmlElement("Value")]
    public object Value
    {
      get => this.\u003CValue\u003Ek__BackingField;
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

    public CustomSettingValue()
    {
      CustomSettingValue.fCmZKAosHjqh9Hmopuky();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool ox8vQqos4JgJWXae0ewt() => CustomSettingValue.CZLP8Voswus8Gf2PCKxk == null;

    internal static CustomSettingValue ScHt5Vos6Cf7WaiGRc3C() => CustomSettingValue.CZLP8Voswus8Gf2PCKxk;

    internal static void fCmZKAosHjqh9Hmopuky() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
