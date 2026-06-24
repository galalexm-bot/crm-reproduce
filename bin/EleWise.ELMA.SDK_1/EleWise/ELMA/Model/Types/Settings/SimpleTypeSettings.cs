// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.SimpleTypeSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>Настройки простых типов (содержащих одно поле в БД)</summary>
  [Serializable]
  public class SimpleTypeSettings : TypeSettings
  {
    internal static SimpleTypeSettings PAeYBZbFNYOWXd8xyiHJ;

    /// <summary>Ctor</summary>
    public SimpleTypeSettings()
    {
      SimpleTypeSettings.bMYsTVbFap3lcO5CDx2l();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.CustomSettings = new List<CustomSettingValue>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Ctor for serialization</summary>
    /// <param name="info">SerializationInfo</param>
    /// <param name="context">StreamingContext</param>
    protected SimpleTypeSettings(SerializationInfo info, StreamingContext context)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Имя поля в БД</summary>
    [PublicationBehaviour(PublicationType.Restart)]
    [DataMember]
    [JsonSerializationIgnore]
    [XmlElement("FieldName")]
    [DefaultValue("")]
    public string FieldName
    {
      get => this.\u003CFieldName\u003Ek__BackingField;
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
              this.\u003CFieldName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
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

    [DefaultValue(null)]
    [JsonSerializationIgnore]
    [XmlElement("CustomSettings")]
    public string CustomSettingsSerialized
    {
      get
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (SimpleTypeSettings.JIqibebFDgn2PpetuZuF((object) this.CustomSettings) != 0)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            case 2:
              goto label_3;
            case 3:
              if (this.CustomSettings == null)
              {
                num = 2;
                continue;
              }
              goto case 1;
            default:
              goto label_2;
          }
        }
label_2:
        return ClassSerializationHelper.SerializeObjectByXml((object) new CustomSettingsValueContainer(this.CustomSettings));
label_3:
        return (string) null;
      }
      set
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.CustomSettings = new List<CustomSettingValue>();
              num = 3;
              continue;
            case 2:
              if (!SimpleTypeSettings.EJRnJtbFtfM4idaByF2y((object) value))
              {
                this.CustomSettings = ClassSerializationHelper.DeserializeObjectByXml<CustomSettingsValueContainer>(value).Settings;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
                continue;
              }
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 1 : 0;
              continue;
            case 3:
              goto label_3;
            default:
              goto label_8;
          }
        }
label_2:
        return;
label_3:
        return;
label_8:;
      }
    }

    [XmlIgnore]
    public List<CustomSettingValue> CustomSettings { get; set; }

    /// <summary>Получить кастомную настройку по ключу</summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public T GetCustomSetting<T>(string key) => (T) this.GetCustomSetting(key);

    /// <summary>Получить кастомную настройку по ключу</summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public object GetCustomSetting(string key)
    {
      int num1 = 1;
      CustomSettingValue customSettingValue;
      string key1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_8;
          case 3:
            goto label_10;
          case 4:
            if (customSettingValue == null)
            {
              num1 = 3;
              continue;
            }
            goto label_11;
          case 5:
            customSettingValue = this.CustomSettings.FirstOrDefault<CustomSettingValue>((Func<CustomSettingValue, bool>) (s =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    if (SimpleTypeSettings.\u003C\u003Ec__DisplayClass14_0.uhHSo3CKr9ofMpWgX8IS((object) s) != null)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_5;
                  default:
                    goto label_4;
                }
              }
label_4:
              // ISSUE: reference to a compiler-generated method
              return SimpleTypeSettings.\u003C\u003Ec__DisplayClass14_0.PFpPRNCKg1DI5YAg4Z7a((object) s.Key, (object) key1, StringComparison.Ordinal);
label_5:
              return false;
            }));
            num1 = 4;
            continue;
          case 6:
            if (this.CustomSettings != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 5;
              continue;
            }
            goto label_8;
          default:
            key1 = key;
            num1 = 6;
            continue;
        }
      }
label_8:
      return (object) null;
label_10:
      return (object) null;
label_11:
      return SimpleTypeSettings.hhN8KtbFwKN573kwEEP9((object) customSettingValue);
    }

    /// <summary>Записать кастомную настройку</summary>
    /// <param name="key"></param>
    /// <param name="value"></param>
    public void SetCustomSetting(string key, object value)
    {
      int num1 = 9;
      CustomSettingValue customSettingValue;
      string key1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            customSettingValue = new CustomSettingValue()
            {
              Key = key1
            };
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
            continue;
          case 2:
          case 7:
            SimpleTypeSettings.gCCHxjbF4vGpGj4CAlBE((object) customSettingValue, value);
            num1 = 10;
            continue;
          case 3:
            customSettingValue = this.CustomSettings.FirstOrDefault<CustomSettingValue>((Func<CustomSettingValue, bool>) (s =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    if (s.Key != null)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_3;
                  default:
                    goto label_2;
                }
              }
label_2:
              return s.Key.Equals(key1, StringComparison.Ordinal);
label_3:
              return false;
            }));
            num1 = 5;
            continue;
          case 4:
            if (this.CustomSettings == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 5 : 6;
              continue;
            }
            goto case 3;
          case 5:
            if (customSettingValue != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 1 : 2;
              continue;
            }
            goto case 1;
          case 6:
            this.CustomSettings = new List<CustomSettingValue>();
            num1 = 3;
            continue;
          case 8:
            key1 = key;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 1 : 4;
            continue;
          case 9:
            num1 = 8;
            continue;
          case 10:
            goto label_5;
          default:
            this.CustomSettings.Add(customSettingValue);
            num1 = 7;
            continue;
        }
      }
label_5:;
    }

    /// <summary>
    /// Получить имена полей БД, которые создаются для данного свойства в таблице сущности
    /// </summary>
    /// <returns></returns>
    public virtual string[] GetFieldNames() => new string[1]
    {
      this.FieldName
    };

    public virtual bool Equals(SimpleTypeSettings other)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (this != other)
            {
              if (SimpleTypeSettings.rboSn8bFH6w8Gu0WMdQh(SimpleTypeSettings.Pk9MXdbF6f9m5sa4cyVZ((object) other), (object) this.FieldName))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
                continue;
              }
              goto label_6;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 1 : 0;
              continue;
            }
          case 3:
            if (other != null)
            {
              num = 2;
              continue;
            }
            goto label_7;
          case 4:
            goto label_7;
          default:
            goto label_5;
        }
      }
label_2:
      return true;
label_5:
      return SimpleTypeSettings.rboSn8bFH6w8Gu0WMdQh(SimpleTypeSettings.frbfe0bFAguI8ZA2KCZb((object) other), (object) this.CustomSettingsSerialized);
label_6:
      return false;
label_7:
      return false;
    }

    public override bool Equals(object obj)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_10;
            case 2:
              if (obj == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 0;
                continue;
              }
              if (this != obj)
              {
                if (SimpleTypeSettings.vRmh72bF7i18PuxDMmTp(obj.GetType(), typeof (SimpleTypeSettings)))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
                  continue;
                }
                goto label_4;
              }
              else
                goto label_12;
            case 3:
              goto label_5;
            default:
              goto label_3;
          }
        }
label_12:
        num1 = 3;
      }
label_3:
      return false;
label_4:
      return SimpleTypeSettings.YDVVr9bFxCUPvqsLIFIF((object) this, (object) (SimpleTypeSettings) obj);
label_5:
      return true;
label_10:
      return false;
    }

    public override int GetHashCode()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.FieldName == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_2;
        }
      }
label_2:
      // ISSUE: type reference
      int hashCode = SimpleTypeSettings.yKouswbF0O2eO8alPxZb(__typeref (string)).GetHashCode();
      goto label_6;
label_5:
      hashCode = this.FieldName.GetHashCode();
label_6:
      return hashCode * 397 ^ (this.CustomSettingsSerialized != null ? this.CustomSettingsSerialized.GetHashCode() : typeof (string).GetHashCode()) * 13;
    }

    internal static void bMYsTVbFap3lcO5CDx2l() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Wr2rCZbF3nssxguw9g1l() => SimpleTypeSettings.PAeYBZbFNYOWXd8xyiHJ == null;

    internal static SimpleTypeSettings J6fuxTbFpaCdCdcX5dyh() => SimpleTypeSettings.PAeYBZbFNYOWXd8xyiHJ;

    internal static int JIqibebFDgn2PpetuZuF([In] object obj0) => ((List<CustomSettingValue>) obj0).Count;

    internal static bool EJRnJtbFtfM4idaByF2y([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object hhN8KtbFwKN573kwEEP9([In] object obj0) => ((CustomSettingValue) obj0).Value;

    internal static void gCCHxjbF4vGpGj4CAlBE([In] object obj0, [In] object obj1) => ((CustomSettingValue) obj0).Value = obj1;

    internal static object Pk9MXdbF6f9m5sa4cyVZ([In] object obj0) => (object) ((SimpleTypeSettings) obj0).FieldName;

    internal static bool rboSn8bFH6w8Gu0WMdQh([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object frbfe0bFAguI8ZA2KCZb([In] object obj0) => (object) ((SimpleTypeSettings) obj0).CustomSettingsSerialized;

    internal static bool vRmh72bF7i18PuxDMmTp([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static bool YDVVr9bFxCUPvqsLIFIF([In] object obj0, [In] object obj1) => ((SimpleTypeSettings) obj0).Equals((SimpleTypeSettings) obj1);

    internal static Type yKouswbF0O2eO8alPxZb([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);
  }
}
