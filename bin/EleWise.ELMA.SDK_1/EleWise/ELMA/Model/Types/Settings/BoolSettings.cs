// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.BoolSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>Настройки типа "Да / нет"</summary>
  [Serializable]
  public class BoolSettings : SimpleTypeSettings, IHasDefaultValue<bool>, IHasDefaultValue<bool?>
  {
    internal static BoolSettings iFVum4bFgdeTpAWfnib9;

    /// <summary>Ctor</summary>
    public BoolSettings()
    {
      BoolSettings.TEE548bFYtlRrLC7L8pM();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Deserialization ctor</summary>
    /// <param name="info">Serialization info</param>
    /// <param name="context">Context</param>
    protected BoolSettings(SerializationInfo info, StreamingContext context)
    {
      BoolSettings.TEE548bFYtlRrLC7L8pM();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Текст для значения Да.</summary>
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (BoolSettings.__Resources), "YesText")]
    [System.ComponentModel.DefaultValue("")]
    [XmlElement("YesText")]
    public string YesText
    {
      get => this.\u003CYesText\u003Ek__BackingField;
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
              this.\u003CYesText\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
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

    /// <summary>Текст для значения Нет.</summary>
    [System.ComponentModel.DefaultValue("")]
    [XmlElement("NoText")]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (BoolSettings.__Resources), "NoText")]
    public string NoText
    {
      get => this.\u003CNoText\u003Ek__BackingField;
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
              this.\u003CNoText\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
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

    /// <summary>Значение по умолчанию</summary>
    [XmlIgnore]
    [JsonSerializationIgnore]
    [PublicationBehaviour(PublicationType.Delta)]
    public bool? BoolDefaultValue { get; set; }

    /// <summary>Значение по умолчанию (для сериализации)</summary>
    [PublicationBehaviour(PublicationType.Delta)]
    [System.ComponentModel.DefaultValue(null)]
    [JsonSerializationIgnore]
    [XmlElement("DefaultValue")]
    public string DefaultValueStr
    {
      get
      {
        int num = 1;
        bool valueOrDefault;
        bool? boolDefaultValue;
        while (true)
        {
          switch (num)
          {
            case 1:
              boolDefaultValue = this.BoolDefaultValue;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_6;
            case 3:
              goto label_2;
            default:
              ref bool? local = ref boolDefaultValue;
              if (!local.HasValue)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 1 : 2;
                continue;
              }
              valueOrDefault = local.GetValueOrDefault();
              num = 3;
              continue;
          }
        }
label_2:
        return valueOrDefault.ToString();
label_6:
        return (string) null;
      }
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
              this.BoolDefaultValue = BoolSettings.kBiaP6bFL2wLWMuGwugc((object) value) ? new bool?() : new bool?(bool.Parse(value));
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

    /// <inheritdoc />
    [XmlIgnore]
    [Obsolete("Use BoolDefaultValue property instead", true)]
    [JsonSerializationIgnore]
    public bool DefaultValue
    {
      get
      {
        int num = 1;
        bool? boolDefaultValue;
        while (true)
        {
          switch (num)
          {
            case 1:
              boolDefaultValue = this.BoolDefaultValue;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_5;
            case 3:
              goto label_6;
            default:
              if (boolDefaultValue.HasValue)
              {
                num = 3;
                continue;
              }
              goto label_5;
          }
        }
label_5:
        return false;
label_6:
        return boolDefaultValue.GetValueOrDefault();
      }
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
              this.BoolDefaultValue = value ? new bool?(true) : new bool?();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
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

    [XmlIgnore]
    [JsonSerializationIgnore]
    bool? IHasDefaultValue<bool?>.DefaultValue
    {
      get => this.BoolDefaultValue;
      set => this.BoolDefaultValue = value;
    }

    /// <summary>Тип отображения (радиогруппа, флажок, переключатель)</summary>
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (BoolSettings.__Resources), "DisplayType")]
    [System.ComponentModel.DefaultValue(BoolDisplayType.RadioButtons)]
    [XmlElement("DisplayType")]
    public BoolDisplayType DisplayType
    {
      get => this.\u003CDisplayType\u003Ek__BackingField;
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
              this.\u003CDisplayType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
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

    internal static void TEE548bFYtlRrLC7L8pM() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool frvyljbF5M2oohbYpuvR() => BoolSettings.iFVum4bFgdeTpAWfnib9 == null;

    internal static BoolSettings clxLgkbFjYcKYLBjI2Eg() => BoolSettings.iFVum4bFgdeTpAWfnib9;

    internal static bool kBiaP6bFL2wLWMuGwugc([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    private static class __Resources
    {
      internal static object TJ1bJ9CKUPf1bpYVWoyg;

      public static string DisplayType => EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(95909607 + 343705423 ^ 439771554), (object) BoolDisplayType.RadioButtons, (object) BoolDisplayType.Checkbox, (object) BoolDisplayType.Switch);

      public static string YesText => (string) BoolSettings.__Resources.lEduTbCXFnul8FXeVviw(BoolSettings.__Resources.p57eoWCKzYTZ3YLVJI54(-882126494 ^ -881954496));

      public static string NoText => EleWise.ELMA.SR.T((string) BoolSettings.__Resources.p57eoWCKzYTZ3YLVJI54(-70007027 ^ -69834913));

      internal static bool LTo8XtCKsM5WqTdW4wxW() => BoolSettings.__Resources.TJ1bJ9CKUPf1bpYVWoyg == null;

      internal static BoolSettings.__Resources EgT0NtCKcl1dSMpQVEDp() => (BoolSettings.__Resources) BoolSettings.__Resources.TJ1bJ9CKUPf1bpYVWoyg;

      internal static object p57eoWCKzYTZ3YLVJI54(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object lEduTbCXFnul8FXeVviw([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);
    }
  }
}
