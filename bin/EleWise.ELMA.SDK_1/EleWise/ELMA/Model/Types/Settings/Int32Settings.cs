// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.Int32Settings
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
  /// <summary>Настройки типа "Целое число (32 бита)"</summary>
  [Serializable]
  public class Int32Settings : 
    SimpleTypeSettings,
    IHasDefaultValue<int?>,
    IMvcValidatableTypeSettings
  {
    /// <summary>Значение по умолчанию для максимального значения</summary>
    public const int DefaultMinValue = -2147483648;
    /// <summary>Значение по умолчанию для максимального значения</summary>
    public const int DefaultMaxValue = 2147483647;
    private static Int32Settings ETZlwDbWHEOdoASKuch3;

    /// <summary>Ctor</summary>
    public Int32Settings()
    {
      Int32Settings.Haeeq0bWxfHE5yYbUORk();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Deserialization ctor</summary>
    /// <param name="info">Serialization info</param>
    /// <param name="context">Context</param>
    protected Int32Settings(SerializationInfo info, StreamingContext context)
    {
      Int32Settings.Haeeq0bWxfHE5yYbUORk();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Минимальное значение</summary>
    [PublicationBehaviour(PublicationType.Restart)]
    [System.ComponentModel.DefaultValue(-2147483648)]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (Int32Settings.__Resources), "MinValue")]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
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
    [System.ComponentModel.DefaultValue(2147483647)]
    [PublicationBehaviour(PublicationType.Restart)]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (Int32Settings.__Resources), "MaxValue")]
    public int MaxValue
    {
      get => this.\u003CMaxValue\u003Ek__BackingField;
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
              this.\u003CMaxValue\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
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
    public int? DefaultValue { get; set; }

    /// <summary>Значение по умолчанию (для сериализации)</summary>
    [PublicationBehaviour(PublicationType.Delta)]
    [JsonSerializationIgnore]
    [XmlElement("DefaultValue")]
    [System.ComponentModel.DefaultValue(null)]
    public string DefaultValueStr
    {
      get
      {
        int num1 = 4;
        int? defaultValue;
        int num2;
        while (true)
        {
          switch (num1)
          {
            case 1:
              goto label_5;
            case 2:
              num2 = defaultValue.Value;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 1 : 1;
              continue;
            case 3:
              if (defaultValue.HasValue)
              {
                defaultValue = this.DefaultValue;
                num1 = 2;
                continue;
              }
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
              continue;
            case 4:
              defaultValue = this.DefaultValue;
              num1 = 3;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        return (string) null;
label_5:
        return num2.ToString();
      }
      set
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_7;
            case 2:
              this.DefaultValue = new int?();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 4;
              continue;
            case 3:
              if (Int32Settings.opGiTKbW0vdgNejh9kns((object) value))
              {
                num = 2;
                continue;
              }
              break;
            case 4:
              goto label_3;
          }
          this.DefaultValue = new int?(int.Parse(value, (IFormatProvider) Int32Settings.bDmMaFbWM6i7yJE4Z9Mw(Int32Settings.WsmpPQbWyCy7RUoAe9Pc(Int32Settings.bx3W2obWmnMt6loTtsJs()))));
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 1 : 0;
        }
label_7:
        return;
label_3:;
      }
    }

    /// <summary>Генерировать в фильтре диапазон значений</summary>
    [XmlElement("RangeInFilter")]
    [PublicationBehaviour(PublicationType.Restart)]
    [System.ComponentModel.DefaultValue(true)]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 0 : 0;
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
      int num1 = 4;
      Int32Settings int32Settings;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              if (!base.Equals(obj))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
                continue;
              }
              goto case 5;
            case 3:
              goto label_5;
            case 4:
              if (obj is Int32Settings)
              {
                int32Settings = (Int32Settings) obj;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 2;
                continue;
              }
              goto label_12;
            case 5:
              if (this.MinValue == Int32Settings.eJAFSibWJ1vm45XW8C2l((object) int32Settings))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 1 : 1;
                continue;
              }
              goto label_4;
            default:
              goto label_4;
          }
        }
label_12:
        num1 = 3;
      }
label_3:
      return this.MaxValue == Int32Settings.wGeWVlbW9CphjJigej6i((object) int32Settings);
label_4:
      return false;
label_5:
      return false;
    }

    /// <summary>Записать атрибуты валидации свойства</summary>
    public override IEnumerable<ISyntaxNode> WriteValidatePropertyAttributes() => (IEnumerable<ISyntaxNode>) new Int32Settings.\u003CWriteValidatePropertyAttributes\u003Ed__24(-2)
    {
      \u003C\u003E4__this = this
    };

    void IMvcValidatableTypeSettings.ApplyValidationRules(
      ICollection<ModelClientValidationRule> rules,
      ModelMetadata metadata,
      ControllerContext context,
      TypeSettings originalPropertySettings)
    {
      Contract.ArgumentNotNull((object) rules, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1445902765 ^ -1980277732 ^ 539277247));
      if (originalPropertySettings is Int32Settings int32Settings && this.MinValue == int32Settings.MinValue && this.MaxValue == int32Settings.MaxValue)
        return;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      rules.RemoveAll<ModelClientValidationRule>((Func<ModelClientValidationRule, bool>) (r => (string) Int32Settings.\u003C\u003Ec.flP3KnCTsJjEktaBgE3X((object) r) == (string) Int32Settings.\u003C\u003Ec.C2ijlfCTcQKjWUwh0yZ8(864270449 << 6 ^ -521355504)));
      if (this.MinValue == int.MinValue && this.MaxValue == int.MaxValue)
        return;
      rules.AddRange<ModelClientValidationRule>(new RangeValueValidator(metadata, context, new RangeValueAttribute(this.MinValue, this.MaxValue)).GetClientValidationRules());
    }

    internal static void Haeeq0bWxfHE5yYbUORk() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool YUKAK0bWAHCEJMLnmeE5() => Int32Settings.ETZlwDbWHEOdoASKuch3 == null;

    internal static Int32Settings a2drbgbW7sY4AT8k9OUX() => Int32Settings.ETZlwDbWHEOdoASKuch3;

    internal static bool opGiTKbW0vdgNejh9kns([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object bx3W2obWmnMt6loTtsJs() => (object) Thread.CurrentThread;

    internal static object WsmpPQbWyCy7RUoAe9Pc([In] object obj0) => (object) ((Thread) obj0).CurrentCulture;

    internal static object bDmMaFbWM6i7yJE4Z9Mw([In] object obj0) => (object) ((CultureInfo) obj0).NumberFormat;

    internal static int eJAFSibWJ1vm45XW8C2l([In] object obj0) => ((Int32Settings) obj0).MinValue;

    internal static int wGeWVlbW9CphjJigej6i([In] object obj0) => ((Int32Settings) obj0).MaxValue;

    private static class __Resources
    {
      private static object CCLjffCTya6x0ixtvT0p;

      public static string MinValue => (string) Int32Settings.__Resources.Ca8CP5CTdNer59Pu0TCE(Int32Settings.__Resources.Uu943FCT9kf2s8gsUXvK(-218496594 ^ -218486752));

      public static string MaxValue => (string) Int32Settings.__Resources.Ca8CP5CTdNer59Pu0TCE(Int32Settings.__Resources.Uu943FCT9kf2s8gsUXvK(-1886646897 ^ -1886641099));

      internal static object Uu943FCT9kf2s8gsUXvK(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object Ca8CP5CTdNer59Pu0TCE([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static bool K7JWiKCTMIjZ3gfp85ZP() => Int32Settings.__Resources.CCLjffCTya6x0ixtvT0p == null;

      internal static Int32Settings.__Resources B7vmgDCTJEyr1LEfWXAS() => (Int32Settings.__Resources) Int32Settings.__Resources.CCLjffCTya6x0ixtvT0p;
    }
  }
}
