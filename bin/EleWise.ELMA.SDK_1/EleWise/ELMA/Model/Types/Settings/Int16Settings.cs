// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.Int16Settings
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
  /// <summary>Настройки типа "Целое число (16 бит)"</summary>
  [Serializable]
  public class Int16Settings : 
    SimpleTypeSettings,
    IHasDefaultValue<short?>,
    IMvcValidatableTypeSettings
  {
    /// <summary>Значение по умолчанию для максимального значения</summary>
    public const short DefaultMinValue = -32768;
    /// <summary>Значение по умолчанию для максимального значения</summary>
    public const short DefaultMaxValue = 32767;
    internal static Int16Settings Sno92rbWqQYtXUGEGpFJ;

    /// <summary>Ctor</summary>
    public Int16Settings()
    {
      Int16Settings.qETWNObWTFp55WmSGltH();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Deserialization ctor</summary>
    /// <param name="info">Serialization info</param>
    /// <param name="context">Context</param>
    protected Int16Settings(SerializationInfo info, StreamingContext context)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Минимальное значение</summary>
    [PublicationBehaviour(PublicationType.Restart)]
    [System.ComponentModel.DefaultValue(-32768)]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (Int16Settings.__Resources), "MinValue")]
    public short MinValue
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
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
    [System.ComponentModel.DefaultValue(32767)]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (Int16Settings.__Resources), "MaxValue")]
    [PublicationBehaviour(PublicationType.Restart)]
    public short MaxValue
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
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
    [PublicationBehaviour(PublicationType.Delta)]
    [XmlIgnore]
    public short? DefaultValue { get; set; }

    /// <summary>Значение по умолчанию (для сериализации)</summary>
    [System.ComponentModel.DefaultValue(null)]
    [XmlElement("DefaultValue")]
    [JsonSerializationIgnore]
    [PublicationBehaviour(PublicationType.Delta)]
    public string DefaultValueStr
    {
      get
      {
        int num1 = 2;
        short? defaultValue;
        short num2;
        while (true)
        {
          switch (num1)
          {
            case 1:
              if (!defaultValue.HasValue)
              {
                num1 = 3;
                continue;
              }
              defaultValue = this.DefaultValue;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 4 : 4;
              continue;
            case 2:
              defaultValue = this.DefaultValue;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_6;
            case 4:
              num2 = defaultValue.Value;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return num2.ToString();
label_6:
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
              case 1:
                goto label_6;
              case 2:
                this.DefaultValue = new short?();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 1;
                continue;
              case 3:
                if (Int16Settings.qNKyq0bWkfJNFOZHAZUQ((object) value))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 1 : 2;
                  continue;
                }
                goto label_3;
              case 4:
                goto label_8;
              default:
                goto label_3;
            }
          }
label_3:
          this.DefaultValue = new short?(Int16Settings.Pp2xuybW24sJMW0URdFs((object) value, Int16Settings.CF8gfTbWOUBUcs7PJ4cw(Int16Settings.tnyOIIbWnrlGeTOeqWmf((object) Thread.CurrentThread))));
          num1 = 4;
        }
label_6:
        return;
label_8:;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
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
      int num = 4;
      Int16Settings int16Settings;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            goto label_10;
          case 3:
            int16Settings = (Int16Settings) obj;
            num = 5;
            continue;
          case 4:
            if (obj is Int16Settings)
            {
              num = 3;
              continue;
            }
            goto label_10;
          case 5:
            if (base.Equals(obj))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          default:
            if ((int) this.MinValue == (int) Int16Settings.H2xZbYbWeMwce5SfC0rG((object) int16Settings))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 1;
              continue;
            }
            goto label_7;
        }
      }
label_6:
      return (int) this.MaxValue == (int) int16Settings.MaxValue;
label_7:
      return false;
label_10:
      return false;
    }

    /// <summary>Записать атрибуты валидации свойства</summary>
    public override IEnumerable<ISyntaxNode> WriteValidatePropertyAttributes() => (IEnumerable<ISyntaxNode>) new Int16Settings.\u003CWriteValidatePropertyAttributes\u003Ed__24(-2)
    {
      \u003C\u003E4__this = this
    };

    void IMvcValidatableTypeSettings.ApplyValidationRules(
      ICollection<ModelClientValidationRule> rules,
      ModelMetadata metadata,
      ControllerContext context,
      TypeSettings originalPropertySettings)
    {
      Contract.ArgumentNotNull((object) rules, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426249015));
      if (originalPropertySettings is Int16Settings int16Settings && (int) this.MinValue == (int) int16Settings.MinValue && (int) this.MaxValue == (int) int16Settings.MaxValue)
        return;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      rules.RemoveAll<ModelClientValidationRule>((Func<ModelClientValidationRule, bool>) (r => Int16Settings.\u003C\u003Ec.sWiOWHCTPpkt2js3JqWq(Int16Settings.\u003C\u003Ec.jUpv9YCTegN4tbuVulj0((object) r), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(874012245 ^ 874183941))));
      if (this.MinValue == short.MinValue && this.MaxValue == short.MaxValue)
        return;
      rules.AddRange<ModelClientValidationRule>(new RangeValueValidator(metadata, context, new RangeValueAttribute(this.MinValue, this.MaxValue)).GetClientValidationRules());
    }

    internal static void qETWNObWTFp55WmSGltH() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool rhbUgPbWK2RErNIKggid() => Int16Settings.Sno92rbWqQYtXUGEGpFJ == null;

    internal static Int16Settings XGhOEibWXun0cCOdjUM1() => Int16Settings.Sno92rbWqQYtXUGEGpFJ;

    internal static bool qNKyq0bWkfJNFOZHAZUQ([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object tnyOIIbWnrlGeTOeqWmf([In] object obj0) => (object) ((Thread) obj0).CurrentCulture;

    internal static object CF8gfTbWOUBUcs7PJ4cw([In] object obj0) => (object) ((CultureInfo) obj0).NumberFormat;

    internal static short Pp2xuybW24sJMW0URdFs([In] object obj0, [In] object obj1) => short.Parse((string) obj0, (IFormatProvider) obj1);

    internal static short H2xZbYbWeMwce5SfC0rG([In] object obj0) => ((Int16Settings) obj0).MinValue;

    private static class __Resources
    {
      private static object bSZ4pRCTZcnAbVBNu9iq;

      public static string MinValue => (string) Int16Settings.__Resources.wWSqahCTS5kdT78F9Ead(Int16Settings.__Resources.s9t3wwCTVFeZC5ZdmUUT(1917998801 >> 2 ^ 479509562));

      public static string MaxValue => (string) Int16Settings.__Resources.wWSqahCTS5kdT78F9Ead(Int16Settings.__Resources.s9t3wwCTVFeZC5ZdmUUT(712480695 ^ 712490509));

      internal static object s9t3wwCTVFeZC5ZdmUUT(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object wWSqahCTS5kdT78F9Ead([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static bool J9NED5CTuxD2Y6MW2Wv8() => Int16Settings.__Resources.bSZ4pRCTZcnAbVBNu9iq == null;

      internal static Int16Settings.__Resources t1O9bQCTI3IZ7X7gsfJB() => (Int16Settings.__Resources) Int16Settings.__Resources.bSZ4pRCTZcnAbVBNu9iq;
    }
  }
}
