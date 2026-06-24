// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.DoubleSettings
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
  /// <summary>Настройки типа "Дробное число"</summary>
  [Serializable]
  public class DoubleSettings : 
    SimpleTypeSettings,
    IHasDefaultValue<double?>,
    IMvcValidatableTypeSettings
  {
    /// <summary>Значение по умолчанию для минимального значения</summary>
    public const double DefaultMinValue = -1E+300;
    /// <summary>Значение по умолчанию для максимального значения</summary>
    public const double DefaultMaxValue = 1E+300;
    private double _minValue;
    private double _maxValue;
    internal static DoubleSettings BVegl3bFUSW4IUf2AZ9S;

    /// <summary>Ctor</summary>
    public DoubleSettings()
    {
      DoubleSettings.gEg9c9bFzm9jL2AYVB0X();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Deserialization ctor</summary>
    /// <param name="info">Serialization info</param>
    /// <param name="context">Context</param>
    protected DoubleSettings(SerializationInfo info, StreamingContext context)
    {
      DoubleSettings.gEg9c9bFzm9jL2AYVB0X();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Минимальное значение</summary>
    [PublicationBehaviour(PublicationType.Restart)]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (DoubleSettings.__Resources), "MinValue")]
    [XmlElement("MinValue")]
    [System.ComponentModel.DefaultValue(-1E+300)]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
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
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (DoubleSettings.__Resources), "MaxValue")]
    [System.ComponentModel.DefaultValue(1E+300)]
    [XmlElement("MaxValue")]
    [PublicationBehaviour(PublicationType.Restart)]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
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

    /// <summary>Точность (число десятичных разрядов)</summary>
    [XmlIgnore]
    public int? Precision { get; set; }

    /// <summary>
    /// Точность (число десятичных разрядов, для сериализации)
    /// </summary>
    [XmlElement("Precision")]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (DoubleSettings.__Resources), "Precision")]
    public string PrecisionString
    {
      get
      {
        int num1 = 2;
        int? precision;
        int num2;
        while (true)
        {
          switch (num1)
          {
            case 1:
              if (precision.HasValue)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 2:
              precision = this.Precision;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 1 : 1;
              continue;
            case 3:
              goto label_4;
            case 4:
              goto label_3;
            case 5:
              num2 = precision.Value;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 4 : 0;
              continue;
            default:
              precision = this.Precision;
              num1 = 5;
              continue;
          }
        }
label_3:
        return num2.ToString();
label_4:
        return (string) null;
      }
      set
      {
        int num1 = 3;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 0:
                goto label_7;
              case 1:
                goto label_6;
              case 2:
                this.Precision = new int?();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
                continue;
              case 3:
                if (string.IsNullOrEmpty(value))
                {
                  num2 = 2;
                  continue;
                }
                goto label_6;
              case 4:
                goto label_9;
              default:
                goto label_3;
            }
          }
label_6:
          this.Precision = new int?(DoubleSettings.RuBbmxbBFLBvT3POdATO((object) value));
          num1 = 4;
        }
label_7:
        return;
label_9:
        return;
label_3:;
      }
    }

    /// <summary>Значение по умолчанию</summary>
    [PublicationBehaviour(PublicationType.Delta)]
    [XmlIgnore]
    public double? DefaultValue { get; set; }

    /// <summary>Значение по умолчанию (для сериализации)</summary>
    [XmlElement("DefaultValue")]
    [PublicationBehaviour(PublicationType.Delta)]
    [System.ComponentModel.DefaultValue(null)]
    [JsonSerializationIgnore]
    public string DefaultValueStr
    {
      get
      {
        int num1 = 5;
        double? defaultValue;
        double num2;
        while (true)
        {
          switch (num1)
          {
            case 1:
              goto label_7;
            case 2:
              num2 = defaultValue.Value;
              num1 = 3;
              continue;
            case 3:
              goto label_3;
            case 4:
              if (defaultValue.HasValue)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
                continue;
              }
              goto label_7;
            case 5:
              defaultValue = this.DefaultValue;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 4 : 3;
              continue;
            default:
              defaultValue = this.DefaultValue;
              num1 = 2;
              continue;
          }
        }
label_3:
        return num2.ToString();
label_7:
        return (string) null;
      }
      set
      {
        int num = 3;
        double result;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              goto label_10;
            case 2:
              if (!double.TryParse(value, out result))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 2 : 4;
                continue;
              }
              goto case 5;
            case 3:
              if (DoubleSettings.nCATAbbBBMA5WfB9JdAc((object) value))
              {
                this.DefaultValue = new double?();
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 1;
                continue;
              }
              num = 2;
              continue;
            case 4:
              goto label_2;
            case 5:
              this.DefaultValue = new double?(result);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
              continue;
            default:
              goto label_11;
          }
        }
label_3:
        return;
label_10:
        return;
label_2:
        return;
label_11:;
      }
    }

    /// <summary>Генерировать в фильтре диапазон значений</summary>
    [System.ComponentModel.DefaultValue(true)]
    [PublicationBehaviour(PublicationType.Restart)]
    [JsonSerializationIgnore]
    [XmlElement("RangeInFilter")]
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

    /// <summary>Одинаковы ли настройки</summary>
    /// <param name="obj">Объект настроек</param>
    /// <returns>True, если настройки одинаковы</returns>
    public override bool Equals(object obj)
    {
      int num = 3;
      DoubleSettings doubleSettings;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.MinValue == DoubleSettings.BFJXgVbBWli6MVc7nZvY((object) doubleSettings))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          case 2:
            goto label_8;
          case 3:
            if (obj is DoubleSettings)
            {
              doubleSettings = (DoubleSettings) obj;
              num = 5;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 2 : 1;
            continue;
          case 4:
            goto label_7;
          case 5:
            if (!base.Equals(obj))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 4 : 4;
              continue;
            }
            goto case 1;
          case 6:
            goto label_6;
          default:
            if (this.MaxValue == DoubleSettings.mMOObqbBoCPGNp6ASCgH((object) doubleSettings))
            {
              num = 6;
              continue;
            }
            goto label_7;
        }
      }
label_6:
      return DoubleSettings.k8BHu6bBhP6Q3N3fYmH2((object) this.PrecisionString, DoubleSettings.umSMx5bBbZGIAHYRa9k8((object) doubleSettings));
label_7:
      return false;
label_8:
      return false;
    }

    /// <summary>Записать атрибуты валидации свойства</summary>
    public override IEnumerable<ISyntaxNode> WriteValidatePropertyAttributes() => (IEnumerable<ISyntaxNode>) new DoubleSettings.\u003CWriteValidatePropertyAttributes\u003Ed__29(-2)
    {
      \u003C\u003E4__this = this
    };

    void IMvcValidatableTypeSettings.ApplyValidationRules(
      ICollection<ModelClientValidationRule> rules,
      ModelMetadata metadata,
      ControllerContext context,
      TypeSettings originalPropertySettings)
    {
      Contract.ArgumentNotNull((object) rules, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675400625));
      if (originalPropertySettings is DoubleSettings doubleSettings && this.MinValue == doubleSettings.MinValue && this.MaxValue == doubleSettings.MaxValue)
        return;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      rules.RemoveAll<ModelClientValidationRule>((Func<ModelClientValidationRule, bool>) (r => DoubleSettings.\u003C\u003Ec.R9WGO9CXVLSnygpvSNKf((object) r.ValidationType, DoubleSettings.\u003C\u003Ec.zSrna7CXI2Y9XW2d8L81(993438473 ^ 993265753))));
      if (this.MinValue <= -1E+300 && this.MaxValue >= 1E+300)
        return;
      rules.AddRange<ModelClientValidationRule>(new RangeValueValidator(metadata, context, new RangeValueAttribute(this.MinValue, this.MaxValue)).GetClientValidationRules());
    }

    internal static void gEg9c9bFzm9jL2AYVB0X() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool wwYbWKbFsZDGmrsIT0Nx() => DoubleSettings.BVegl3bFUSW4IUf2AZ9S == null;

    internal static DoubleSettings WilS0cbFcT6xIJRsvZ1m() => DoubleSettings.BVegl3bFUSW4IUf2AZ9S;

    internal static int RuBbmxbBFLBvT3POdATO([In] object obj0) => int.Parse((string) obj0);

    internal static bool nCATAbbBBMA5WfB9JdAc([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static double BFJXgVbBWli6MVc7nZvY([In] object obj0) => ((DoubleSettings) obj0).MinValue;

    internal static double mMOObqbBoCPGNp6ASCgH([In] object obj0) => ((DoubleSettings) obj0).MaxValue;

    internal static object umSMx5bBbZGIAHYRa9k8([In] object obj0) => (object) ((DoubleSettings) obj0).PrecisionString;

    internal static bool k8BHu6bBhP6Q3N3fYmH2([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    private static class __Resources
    {
      internal static object q6Lf08CXBUQjcxC8Ma5k;

      public static string MinValue => (string) DoubleSettings.__Resources.w2d8etCXbmDO9iNuBfSJ((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1872275253 >> 6 ^ -29248275));

      public static string MaxValue => (string) DoubleSettings.__Resources.w2d8etCXbmDO9iNuBfSJ(DoubleSettings.__Resources.ncydfiCXhhJc3DYDYQrg(-1858887263 ^ -1858893797));

      public static string Precision => (string) DoubleSettings.__Resources.w2d8etCXbmDO9iNuBfSJ(DoubleSettings.__Resources.ncydfiCXhhJc3DYDYQrg(-1939377524 ^ -1939680760));

      internal static object w2d8etCXbmDO9iNuBfSJ([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static bool IDhR3wCXWQQOQmQ0vKed() => DoubleSettings.__Resources.q6Lf08CXBUQjcxC8Ma5k == null;

      internal static DoubleSettings.__Resources X9L5m8CXoolAtUXpRreM() => (DoubleSettings.__Resources) DoubleSettings.__Resources.q6Lf08CXBUQjcxC8Ma5k;

      internal static object ncydfiCXhhJc3DYDYQrg(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
    }
  }
}
