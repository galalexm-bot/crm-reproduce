// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.StringSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Types.Validation;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Web.Mvc;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>Настройки типа "Строка"</summary>
  [Serializable]
  public class StringSettings : 
    SimpleTypeSettings,
    IHasDefaultValue<string>,
    IMvcValidatableTypeSettings
  {
    /// <summary>Строка, обозначающая максимальную длину строки</summary>
    public const string MAX_LENGTH = "2147483647";
    private static StringSettings bHIunrbWddYcrpvGYn5x;

    /// <summary>Ctor</summary>
    public StringSettings()
    {
      StringSettings.U4G8a3bWgcMgyXLvfdEH();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Deserialization ctor</summary>
    /// <param name="info">Serialization info</param>
    /// <param name="context">Context</param>
    protected StringSettings(SerializationInfo info, StreamingContext context)
    {
      StringSettings.U4G8a3bWgcMgyXLvfdEH();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Минимальная длина строки</summary>
    [System.ComponentModel.DefaultValue(0)]
    [PublicationBehaviour(PublicationType.Restart)]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (StringSettings.__Resources), "MinValue")]
    [XmlElement("MinValue")]
    public int MinValue
    {
      get => this.\u003CMinValue\u003Ek__BackingField;
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
              this.\u003CMinValue\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
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

    /// <summary>Максимальная длина строки</summary>
    [PublicationBehaviour(PublicationType.Restart)]
    [XmlIgnore]
    public int? MaxValue { get; set; }

    /// <summary>Максимальная длина строки (для сериализации)</summary>
    [XmlElement("MaxValue")]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (StringSettings.__Resources), "MaxValue")]
    [PublicationBehaviour(PublicationType.Restart)]
    [System.ComponentModel.DefaultValue(null)]
    public string MaxValueString
    {
      get
      {
        int num1 = 1;
        int? maxValue;
        int num2;
        while (true)
        {
          switch (num1)
          {
            case 1:
              maxValue = this.MaxValue;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            case 3:
              maxValue = this.MaxValue;
              num1 = 4;
              continue;
            case 4:
              num2 = maxValue.Value;
              num1 = 5;
              continue;
            case 5:
              goto label_8;
            default:
              if (maxValue.HasValue)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 3 : 1;
                continue;
              }
              goto label_2;
          }
        }
label_2:
        return (string) null;
label_8:
        return num2.ToString();
      }
      set
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_5;
            case 1:
              this.MaxValue = new int?(int.Parse(value));
              num = 4;
              continue;
            case 2:
              this.MaxValue = new int?();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
              continue;
            case 3:
              if (StringSettings.jFcMsAbW5YwNlpewN4AV((object) value))
              {
                num = 2;
                continue;
              }
              goto case 1;
            case 4:
              goto label_3;
            default:
              goto label_2;
          }
        }
label_5:
        return;
label_3:
        return;
label_2:;
      }
    }

    /// <summary>Многострочное поле</summary>
    [System.ComponentModel.DefaultValue(false)]
    [XmlElement("MultiLine")]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (StringSettings.__Resources), "MultiLine")]
    public virtual bool MultiLine
    {
      get => this.\u003CMultiLine\u003Ek__BackingField;
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
              this.\u003CMultiLine\u003Ek__BackingField = value;
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

    /// <summary>Регулярное выражение</summary>
    [PublicationBehaviour(PublicationType.Restart)]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (StringSettings.__Resources), "RegularExpression")]
    [System.ComponentModel.DefaultValue("")]
    [XmlElement("RegularExpression")]
    public string RegularExpression
    {
      get => this.\u003CRegularExpression\u003Ek__BackingField;
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
              this.\u003CRegularExpression\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
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

    /// <summary>
    /// Сообщение при ошибке при несоответствии значения регулярному выражению
    /// </summary>
    [PublicationBehaviour(PublicationType.Restart)]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (StringSettings.__Resources), "RegularExpressionMessage")]
    [XmlElement("RegularExpressionMessage")]
    [System.ComponentModel.DefaultValue("")]
    public string RegularExpressionMessage
    {
      get => this.\u003CRegularExpressionMessage\u003Ek__BackingField;
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
              this.\u003CRegularExpressionMessage\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
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
    [System.ComponentModel.DefaultValue("")]
    [PublicationBehaviour(PublicationType.Delta)]
    [XmlElement("DefaultValue")]
    [JsonSerializationIgnore]
    public string DefaultValue
    {
      get => this.\u003CDefaultValue\u003Ek__BackingField;
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
              this.\u003CDefaultValue\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
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

    /// <summary>Записать атрибуты валидации свойства</summary>
    public override IEnumerable<ISyntaxNode> WriteValidatePropertyAttributes() => (IEnumerable<ISyntaxNode>) new StringSettings.\u003CWriteValidatePropertyAttributes\u003Ed__30(-2)
    {
      \u003C\u003E4__this = this
    };

    void IMvcValidatableTypeSettings.ApplyValidationRules(
      ICollection<ModelClientValidationRule> rules,
      ModelMetadata metadata,
      ControllerContext context,
      TypeSettings originalPropertySettings)
    {
      Contract.ArgumentNotNull((object) rules, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886478209));
      if (!(originalPropertySettings is StringSettings stringSettings) || !string.Equals(this.RegularExpression, stringSettings.RegularExpression) || !string.Equals(this.RegularExpressionMessage, stringSettings.RegularExpressionMessage))
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        rules.RemoveAll<ModelClientValidationRule>((Func<ModelClientValidationRule, bool>) (r => StringSettings.\u003C\u003Ec.rqcRg6CkSXUd3diex1ig(StringSettings.\u003C\u003Ec.pBMohYCkIoZi8P8CRlg8((object) r), StringSettings.\u003C\u003Ec.TdXV3RCkVZA3QSrPkqc0(236071375 ^ 235965119))));
        if (!string.IsNullOrEmpty(this.RegularExpression))
          rules.AddRange<ModelClientValidationRule>(new RegularExpressionValidator(metadata, context, new RegularExpressionAttribute(this.RegularExpression, this.RegularExpressionMessage)).GetClientValidationRules());
      }
      int? maxValue1;
      if (stringSettings != null && stringSettings.MinValue == this.MinValue)
      {
        int? maxValue2 = stringSettings.MaxValue;
        maxValue1 = this.MaxValue;
        if (maxValue2.GetValueOrDefault() == maxValue1.GetValueOrDefault() & maxValue2.HasValue == maxValue1.HasValue)
          return;
      }
      // ISSUE: reference to a compiler-generated method
      rules.RemoveAll<ModelClientValidationRule>((Func<ModelClientValidationRule, bool>) (r => StringSettings.\u003C\u003Ec.rqcRg6CkSXUd3diex1ig((object) r.ValidationType, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -671968841))));
      if (this.MinValue <= 0)
      {
        maxValue1 = this.MaxValue;
        if (!maxValue1.HasValue)
          return;
        maxValue1 = this.MaxValue;
        if (maxValue1.Value <= 0)
          return;
      }
      rules.AddRange<ModelClientValidationRule>(new StringRangeLengthValidator(metadata, context, new StringRangeLengthAttribute(this.MinValue, this.MaxValueString)).GetClientValidationRules());
    }

    internal static void U4G8a3bWgcMgyXLvfdEH() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool kmm58ybWll3nD1KRZpry() => StringSettings.bHIunrbWddYcrpvGYn5x == null;

    internal static StringSettings KrOfN7bWrwyEE6y8IpNq() => StringSettings.bHIunrbWddYcrpvGYn5x;

    internal static bool jFcMsAbW5YwNlpewN4AV([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    private static class __Resources
    {
      internal static object uWU2qUCTzXCHoJryMUZC;

      public static string MinValue => (string) StringSettings.__Resources.mSh6bDCkoabonsdNr1Oj(StringSettings.__Resources.iH5G2ICkWsCxJpaR1AXA(-688192331 - 435440695 ^ -1123869032));

      public static string MaxValue => (string) StringSettings.__Resources.mSh6bDCkoabonsdNr1Oj(StringSettings.__Resources.iH5G2ICkWsCxJpaR1AXA(-630932142 - 1120244082 ^ -1751479046));

      public static string MultiLine => (string) StringSettings.__Resources.mSh6bDCkoabonsdNr1Oj(StringSettings.__Resources.iH5G2ICkWsCxJpaR1AXA(1178210108 ^ 1178577032));

      public static string RegularExpression => (string) StringSettings.__Resources.mSh6bDCkoabonsdNr1Oj(StringSettings.__Resources.iH5G2ICkWsCxJpaR1AXA(1319452732 ^ 1319168086));

      public static string RegularExpressionMessage => (string) StringSettings.__Resources.mSh6bDCkoabonsdNr1Oj(StringSettings.__Resources.iH5G2ICkWsCxJpaR1AXA(-441065788 ^ -2092910478 ^ 1727057504));

      internal static object iH5G2ICkWsCxJpaR1AXA(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object mSh6bDCkoabonsdNr1Oj([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static bool pL9q1ZCkFQvGLjjOiKYM() => StringSettings.__Resources.uWU2qUCTzXCHoJryMUZC == null;

      internal static StringSettings.__Resources sBbkR3CkBgE9d75GmxyQ() => (StringSettings.__Resources) StringSettings.__Resources.uWU2qUCTzXCHoJryMUZC;
    }
  }
}
