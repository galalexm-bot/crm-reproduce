// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.Int64Settings
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
  /// <summary>Настройки типа "Целое число"</summary>
  [Serializable]
  public class Int64Settings : 
    SimpleTypeSettings,
    IHasDefaultValue<long?>,
    IMvcValidatableTypeSettings
  {
    /// <summary>Значение по умолчанию для максимального значения</summary>
    public const long DefaultMinValue = -9223372036854775808;
    /// <summary>Значение по умолчанию для максимального значения</summary>
    public const long DefaultMaxValue = 9223372036854775807;
    private static Int64Settings lMybjVbWPUsN4WhRcQlR;

    /// <summary>Ctor</summary>
    public Int64Settings()
    {
      Int64Settings.uNd2w1bW3i7IoelfjpQD();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Deserialization ctor</summary>
    /// <param name="info">Serialization info</param>
    /// <param name="context">Context</param>
    protected Int64Settings(SerializationInfo info, StreamingContext context)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Минимальное значение</summary>
    [System.ComponentModel.DefaultValue(-9223372036854775808)]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (Int64Settings.__Resources), "MinValue")]
    [PublicationBehaviour(PublicationType.Restart)]
    public long MinValue
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
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
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (Int64Settings.__Resources), "MaxValue")]
    [System.ComponentModel.DefaultValue(9223372036854775807)]
    [PublicationBehaviour(PublicationType.Restart)]
    public long MaxValue
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
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
    public long? DefaultValue { get; set; }

    /// <summary>Значение по умолчанию (для сериализации)</summary>
    [JsonSerializationIgnore]
    [System.ComponentModel.DefaultValue(null)]
    [XmlElement("DefaultValue")]
    [PublicationBehaviour(PublicationType.Delta)]
    public string DefaultValueStr
    {
      get
      {
        int num1 = 4;
        long num2;
        long? defaultValue;
        while (true)
        {
          switch (num1)
          {
            case 1:
              num2 = defaultValue.Value;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_3;
            case 3:
              if (defaultValue.HasValue)
              {
                defaultValue = this.DefaultValue;
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 1;
                continue;
              }
              num1 = 2;
              continue;
            case 4:
              defaultValue = this.DefaultValue;
              num1 = 3;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return num2.ToString();
label_3:
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
                goto label_5;
              case 1:
                goto label_3;
              case 2:
                this.DefaultValue = new long?(Int64Settings.WviLSibWwLpLliRT7Wrg((object) value, Int64Settings.ShaJBRbWtNCIRqMLoJ3i(Int64Settings.zYQrYsbWDyhaY7fAfedE(Int64Settings.aOte0kbWaFEw5g2HQgD8()))));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
                continue;
              case 3:
                if (Int64Settings.t6WFE5bWp2nUXWpeWWZO((object) value))
                {
                  this.DefaultValue = new long?();
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 1 : 1;
                  continue;
                }
                goto label_8;
              default:
                goto label_9;
            }
          }
label_8:
          num1 = 2;
        }
label_5:
        return;
label_3:
        return;
label_9:;
      }
    }

    /// <summary>Генерировать в фильтре диапазон значений</summary>
    [JsonSerializationIgnore]
    [XmlElement("RangeInFilter")]
    [System.ComponentModel.DefaultValue(true)]
    [PublicationBehaviour(PublicationType.Restart)]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
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
      int num = 2;
      Int64Settings int64Settings;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_8;
          case 2:
            if (!(obj is Int64Settings))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 1 : 1;
              continue;
            }
            int64Settings = (Int64Settings) obj;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
            continue;
          case 3:
            goto label_10;
          case 4:
            if (this.MinValue == Int64Settings.a9BhNTbW4X5oB4tRl0I8((object) int64Settings))
            {
              num = 3;
              continue;
            }
            goto label_11;
          default:
            if (base.Equals(obj))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 4 : 2;
              continue;
            }
            goto label_11;
        }
      }
label_8:
      return false;
label_10:
      return this.MaxValue == Int64Settings.P3k0XQbW6ST6KjgtQSsX((object) int64Settings);
label_11:
      return false;
    }

    /// <summary>Записать атрибуты валидации свойства</summary>
    public override IEnumerable<ISyntaxNode> WriteValidatePropertyAttributes() => (IEnumerable<ISyntaxNode>) new Int64Settings.\u003CWriteValidatePropertyAttributes\u003Ed__24(-2)
    {
      \u003C\u003E4__this = this
    };

    void IMvcValidatableTypeSettings.ApplyValidationRules(
      ICollection<ModelClientValidationRule> rules,
      ModelMetadata metadata,
      ControllerContext context,
      TypeSettings originalPropertySettings)
    {
      Contract.ArgumentNotNull((object) rules, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-649342099 - -1150814748 ^ 501313657));
      if (originalPropertySettings is Int64Settings int64Settings && this.MinValue == int64Settings.MinValue && this.MaxValue == int64Settings.MaxValue)
        return;
      // ISSUE: reference to a compiler-generated method
      rules.RemoveAll<ModelClientValidationRule>((Func<ModelClientValidationRule, bool>) (r => Int64Settings.\u003C\u003Ec.mkYK7uCTmcFwtO1q6N78((object) r.ValidationType, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1859058959))));
      if (this.MinValue == long.MinValue && this.MaxValue == long.MaxValue)
        return;
      rules.AddRange<ModelClientValidationRule>(new RangeValueValidator(metadata, context, new RangeValueAttribute(this.MinValue, this.MaxValue)).GetClientValidationRules());
    }

    internal static void uNd2w1bW3i7IoelfjpQD() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool DhIFhybW13A1uqXQQ6IK() => Int64Settings.lMybjVbWPUsN4WhRcQlR == null;

    internal static Int64Settings KMIFrkbWNJJrIgbxW1ZU() => Int64Settings.lMybjVbWPUsN4WhRcQlR;

    internal static bool t6WFE5bWp2nUXWpeWWZO([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object aOte0kbWaFEw5g2HQgD8() => (object) Thread.CurrentThread;

    internal static object zYQrYsbWDyhaY7fAfedE([In] object obj0) => (object) ((Thread) obj0).CurrentCulture;

    internal static object ShaJBRbWtNCIRqMLoJ3i([In] object obj0) => (object) ((CultureInfo) obj0).NumberFormat;

    internal static long WviLSibWwLpLliRT7Wrg([In] object obj0, [In] object obj1) => long.Parse((string) obj0, (IFormatProvider) obj1);

    internal static long a9BhNTbW4X5oB4tRl0I8([In] object obj0) => ((Int64Settings) obj0).MinValue;

    internal static long P3k0XQbW6ST6KjgtQSsX([In] object obj0) => ((Int64Settings) obj0).MaxValue;

    private static class __Resources
    {
      private static object MRNIssCT1RFe5p8EGqe8;

      public static string MinValue => (string) Int64Settings.__Resources.pbdxDiCTaF8Miaf59my0(Int64Settings.__Resources.deG0PpCTpOkhH7SMlO0d(-2112703338 ^ -2112709352));

      public static string MaxValue => (string) Int64Settings.__Resources.pbdxDiCTaF8Miaf59my0(Int64Settings.__Resources.deG0PpCTpOkhH7SMlO0d(-342626196 - 1290888215 ^ -1633507857));

      internal static object deG0PpCTpOkhH7SMlO0d(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object pbdxDiCTaF8Miaf59my0([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static bool hnpsjBCTNxX1WxAWJNu0() => Int64Settings.__Resources.MRNIssCT1RFe5p8EGqe8 == null;

      internal static Int64Settings.__Resources t1Jls3CT38vMQjgcUVnS() => (Int64Settings.__Resources) Int64Settings.__Resources.MRNIssCT1RFe5p8EGqe8;
    }
  }
}
