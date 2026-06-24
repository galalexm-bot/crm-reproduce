// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.MoneySettings
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
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Web.Mvc;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>Настройки типа "Деньги"</summary>
  [Serializable]
  public class MoneySettings : 
    SimpleTypeSettings,
    IHasDefaultValue<double?>,
    IMvcValidatableTypeSettings
  {
    private double _minValue;
    private double _maxValue;
    internal static MoneySettings cC82UNoz2PvnhSmI18Oe;

    /// <summary>Ctor</summary>
    public MoneySettings()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Deserialization ctor</summary>
    /// <param name="info">Serialization info</param>
    /// <param name="context">Context</param>
    protected MoneySettings(SerializationInfo info, StreamingContext context)
    {
      MoneySettings.D0DZ34oz13mWrPI5rD2B();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Минимальное значение</summary>
    [System.ComponentModel.DefaultValue(-1E+300)]
    [PublicationBehaviour(PublicationType.Restart)]
    [XmlElement("MinValue")]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (MoneySettings.__Resources), "MinValue")]
    public double MinValue
    {
      get => this._minValue;
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
              this._minValue = value < this._minValue ? -1E+300 : value;
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

    /// <summary>Максимальное значение</summary>
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (MoneySettings.__Resources), "MaxValue")]
    [System.ComponentModel.DefaultValue(1E+300)]
    [PublicationBehaviour(PublicationType.Restart)]
    [XmlElement("MaxValue")]
    public double MaxValue
    {
      get => this._maxValue;
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
              this._maxValue = value > this._maxValue ? 1E+300 : value;
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

    /// <summary>Значение по умолчанию</summary>
    [XmlIgnore]
    [PublicationBehaviour(PublicationType.Delta)]
    public double? DefaultValue { get; set; }

    /// <summary>Значение по умолчанию (для сериализации)</summary>
    [System.ComponentModel.DefaultValue(null)]
    [PublicationBehaviour(PublicationType.Delta)]
    [JsonSerializationIgnore]
    [XmlElement("DefaultValue")]
    public string DefaultValueStr
    {
      get
      {
        int num1 = 4;
        double num2;
        double? defaultValue;
        while (true)
        {
          switch (num1)
          {
            case 1:
              goto label_7;
            case 2:
              goto label_2;
            case 3:
              if (!defaultValue.HasValue)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 1;
                continue;
              }
              defaultValue = this.DefaultValue;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
              continue;
            case 4:
              defaultValue = this.DefaultValue;
              num1 = 3;
              continue;
            default:
              num2 = defaultValue.Value;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 2 : 0;
              continue;
          }
        }
label_2:
        return num2.ToString();
label_7:
        return (string) null;
      }
      set
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.DefaultValue = new double?();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 3 : 3;
              continue;
            case 2:
              if (MoneySettings.koSjD4ozNAMBBDjAW6Vr((object) value))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 1;
                continue;
              }
              break;
            case 3:
              goto label_3;
            case 4:
              goto label_4;
          }
          this.DefaultValue = new double?(MoneySettings.vcelmooza0o1XrT2oO1g((object) value, (object) ((CultureInfo) MoneySettings.DhARtTozpXJqrjAge2oB(MoneySettings.vw6VAdoz3v3WVyxjZWmn())).NumberFormat));
          num = 4;
        }
label_3:
        return;
label_4:;
      }
    }

    /// <summary>Генерировать в фильтре диапазон значений</summary>
    [PublicationBehaviour(PublicationType.Restart)]
    [System.ComponentModel.DefaultValue(true)]
    [XmlElement("RangeInFilter")]
    [JsonSerializationIgnore]
    public bool RangeInFilter
    {
      get => this.\u003CRangeInFilter\u003Ek__BackingField;
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
              this.\u003CRangeInFilter\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
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

    /// <summary>Одинаковы ли настройки</summary>
    /// <param name="obj">Объект настроек</param>
    /// <returns>True, если настройки одинаковы</returns>
    public override bool Equals(object obj)
    {
      int num1 = 3;
      MoneySettings moneySettings;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (this.MinValue == MoneySettings.lDoXv8ozDGJAgqQ8F6X6((object) moneySettings))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 5 : 4;
                continue;
              }
              goto label_8;
            case 2:
              goto label_9;
            case 3:
              if (obj is MoneySettings)
              {
                moneySettings = (MoneySettings) obj;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 2 : 2;
              continue;
            case 4:
              goto label_8;
            case 5:
              goto label_7;
            default:
              if (base.Equals(obj))
                goto case 1;
              else
                goto label_4;
          }
        }
label_4:
        num1 = 4;
      }
label_7:
      return this.MaxValue == MoneySettings.PZijRIoztoG70V2yYNNx((object) moneySettings);
label_8:
      return false;
label_9:
      return false;
    }

    /// <summary>Записать атрибуты валидации свойства</summary>
    public override IEnumerable<ISyntaxNode> WriteValidatePropertyAttributes() => (IEnumerable<ISyntaxNode>) new MoneySettings.\u003CWriteValidatePropertyAttributes\u003Ed__20(-2)
    {
      \u003C\u003E4__this = this
    };

    void IMvcValidatableTypeSettings.ApplyValidationRules(
      ICollection<ModelClientValidationRule> rules,
      ModelMetadata metadata,
      ControllerContext context,
      TypeSettings originalPropertySettings)
    {
      Contract.ArgumentNotNull((object) rules, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 1360506861));
      if (originalPropertySettings is MoneySettings moneySettings && this.MinValue == moneySettings.MinValue && this.MaxValue == moneySettings.MaxValue)
        return;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      rules.RemoveAll<ModelClientValidationRule>((Func<ModelClientValidationRule, bool>) (r => MoneySettings.\u003C\u003Ec.AsCnx1CKMBdeERB8xTel(MoneySettings.\u003C\u003Ec.CjiRXdCKmoH3oXjlUFGS((object) r), MoneySettings.\u003C\u003Ec.paFBt9CKyAk9V0svAbeh(-1445902765 ^ -1980277732 ^ 539277599))));
      if (this.MinValue <= -1E+300 && this.MaxValue >= 1E+300)
        return;
      rules.AddRange<ModelClientValidationRule>(new RangeValueValidator(metadata, context, new RangeValueAttribute(this.MinValue, this.MaxValue)).GetClientValidationRules());
    }

    internal static bool RuY7beoze42Kar6wAJg8() => MoneySettings.cC82UNoz2PvnhSmI18Oe == null;

    internal static MoneySettings vooqclozPVMbwy2Zgn4T() => MoneySettings.cC82UNoz2PvnhSmI18Oe;

    internal static void D0DZ34oz13mWrPI5rD2B() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool koSjD4ozNAMBBDjAW6Vr([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object vw6VAdoz3v3WVyxjZWmn() => (object) Thread.CurrentThread;

    internal static object DhARtTozpXJqrjAge2oB([In] object obj0) => (object) ((Thread) obj0).CurrentCulture;

    internal static double vcelmooza0o1XrT2oO1g([In] object obj0, [In] object obj1) => double.Parse((string) obj0, (IFormatProvider) obj1);

    internal static double lDoXv8ozDGJAgqQ8F6X6([In] object obj0) => ((MoneySettings) obj0).MinValue;

    internal static double PZijRIoztoG70V2yYNNx([In] object obj0) => ((MoneySettings) obj0).MaxValue;

    private static class __Resources
    {
      private static object mk26QhCKNvKFXIpu9yg7;

      public static string MinValue => EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712490553));

      public static string MaxValue => (string) MoneySettings.__Resources.BN0kHbCKD5OoXW4c6AoZ(MoneySettings.__Resources.f7ilkpCKameXkakjEJCt(-1217523399 ^ -1217513341));

      internal static bool iDa4ALCK3w2AtlPX2mMF() => MoneySettings.__Resources.mk26QhCKNvKFXIpu9yg7 == null;

      internal static MoneySettings.__Resources DpKL55CKp8CMTTiwQs0p() => (MoneySettings.__Resources) MoneySettings.__Resources.mk26QhCKNvKFXIpu9yg7;

      internal static object f7ilkpCKameXkakjEJCt(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object BN0kHbCKD5OoXW4c6AoZ([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);
    }
  }
}
