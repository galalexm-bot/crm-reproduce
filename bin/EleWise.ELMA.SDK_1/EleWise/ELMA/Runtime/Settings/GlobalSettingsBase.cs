// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Settings.GlobalSettingsBase
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Settings.Events;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Web.Mvc;

namespace EleWise.ELMA.Runtime.Settings
{
  /// <summary>
  /// Базовый класс для глобальных настроек.
  /// Хранит настройки в полях объекта
  /// </summary>
  /// <remarks>
  /// <see href="http://www.elma-bpm.ru/kb/article-780.html">Пример реализации в базе знаний</see> <br />
  /// <see href="http://www.elma-bpm.ru/kb/article-781.html">Простой пример реализации в базе знаний</see>
  /// </remarks>
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  public class GlobalSettingsBase : IStoreValuesObject
  {
    private IGlobalSettingsEventHandler _globalSettingsEventHandler;
    private readonly IDictionary<string, string> _settingsData;
    private static GlobalSettingsBase tbSZr2Wh0FSqb5NohpfF;

    [HiddenInput(DisplayValue = false)]
    public IGlobalSettingsEventHandler GlobalSettingsEventHandler
    {
      get
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              this._globalSettingsEventHandler = Locator.GetService<IGlobalSettingsEventHandler>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
              continue;
            case 2:
              if (this._globalSettingsEventHandler == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_5;
          }
        }
label_5:
        return this._globalSettingsEventHandler;
      }
    }

    /// <summary>Получить данные по свойству</summary>
    /// <param name="property">Свойство</param>
    /// <returns>Словарь с данными</returns>
    protected virtual IDictionary<string, string> GetStorageValue(PropertyInfo property)
    {
      object obj = property.GetValue((object) this, (object[]) null);
      TypeConverter converter = TypeDescriptor.GetConverter(property.PropertyType);
      string str = converter == null || !converter.CanConvertTo(typeof (string)) ? ClassSerializationHelper.SerializeObjectByJson(obj) : converter.ConvertToInvariantString(obj);
      return (IDictionary<string, string>) new Dictionary<string, string>()
      {
        {
          property.Name,
          str
        }
      };
    }

    /// <summary>
    /// Пропускать ли свойство при автоматическом формировании данных
    /// </summary>
    /// <param name="property">Свойство</param>
    /// <returns><c>true</c>, если пропускать</returns>
    protected virtual bool SkipProperty(PropertyInfo property)
    {
      int num = 7;
      HiddenInputAttribute attribute1;
      IgnoreDataMemberAttribute attribute2;
      while (true)
      {
        switch (num)
        {
          case 1:
            attribute2 = AttributeHelper<IgnoreDataMemberAttribute>.GetAttribute((MemberInfo) property, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 4 : 4;
            continue;
          case 2:
          case 3:
            goto label_11;
          case 4:
            if (attribute1 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 3;
              continue;
            }
            goto case 5;
          case 5:
            if (GlobalSettingsBase.TfPm9fWh9gxrLS8oxEV9((object) attribute1))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 2;
              continue;
            }
            goto label_12;
          case 6:
            if (GlobalSettingsBase.ASsLgVWhJbeVqbQ8wZFh((object) property))
            {
              attribute1 = AttributeHelper<HiddenInputAttribute>.GetAttribute((MemberInfo) property, true);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 0;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 0 : 0;
            continue;
          case 7:
            if (GlobalSettingsBase.zRwBZEWhMAFeXpXQsm3w((object) property))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 6 : 6;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return true;
label_11:
      return attribute2 != null;
label_12:
      return true;
    }

    /// <summary>Установить значение свойства по словарю с данными</summary>
    /// <param name="property">Свойство</param>
    /// <param name="values">Словарь с данными</param>
    protected virtual void SetStorageValue(
      PropertyInfo property,
      IDictionary<string, string> values)
    {
      if (!values.ContainsKey(property.Name))
        return;
      object obj = (object) null;
      string str = values[property.Name];
      try
      {
        TypeConverter converter = TypeDescriptor.GetConverter(property.PropertyType);
        obj = converter == null || !converter.CanConvertFrom(typeof (string)) ? ClassSerializationHelper.DeserializeObjectByJson(property.PropertyType, str) : converter.ConvertFromInvariantString(str);
        this.GlobalSettingsEventHandler.ChangeSetting(new EditGlobalSettingsEventArgs(property, (IStoreValuesObject) this, str));
      }
      catch (Exception ex)
      {
        Logger.Log.Error((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1872275253 >> 6 ^ -29301569), (object) property.Name, (object) property.DeclaringType.FullName), ex);
      }
      if (obj == null)
        return;
      property.SetValue((object) this, obj, (object[]) null);
    }

    /// <summary>Получить настройки из объекта</summary>
    /// <returns>Словарь с настройками</returns>
    public virtual IDictionary<string, string> GetStorageValues()
    {
      // ISSUE: reference to a compiler-generated method
      Dictionary<string, string> dictionary = ((IEnumerable<PropertyInfo>) this.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)).Where<PropertyInfo>((Func<PropertyInfo, bool>) (property => !GlobalSettingsBase.uSQkpgWhlle7gTAoMGAE((object) this, (object) property))).Where<PropertyInfo>((Func<PropertyInfo, bool>) (property => GlobalSettingsBase.\u003C\u003Ec.tVOrfgQNGptvjo25vB48((object) property).Length == 0)).SelectMany<PropertyInfo, KeyValuePair<string, string>>(new Func<PropertyInfo, IEnumerable<KeyValuePair<string, string>>>(this.GetStorageValue)).ToDictionary<KeyValuePair<string, string>, string, string>((Func<KeyValuePair<string, string>, string>) (k => k.Key), (Func<KeyValuePair<string, string>, string>) (v => v.Value));
      foreach (KeyValuePair<string, string> keyValuePair in dictionary)
        this.SettingsData[keyValuePair.Key] = keyValuePair.Value;
      return (IDictionary<string, string>) dictionary;
    }

    /// <summary>Установить настройки в объект</summary>
    /// <param name="values">Словарь с настройками</param>
    public virtual void SetStorageValues(IDictionary<string, string> values)
    {
      if (values == null)
        return;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      ((IEnumerable<PropertyInfo>) this.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)).Where<PropertyInfo>((Func<PropertyInfo, bool>) (property => values.Keys.Contains((string) GlobalSettingsBase.\u003C\u003Ec__DisplayClass7_0.ywSmSSQNCiWbIho3vsOa((object) property)))).Where<PropertyInfo>((Func<PropertyInfo, bool>) (property => !this.SkipProperty(property))).Where<PropertyInfo>((Func<PropertyInfo, bool>) (property => GlobalSettingsBase.\u003C\u003Ec.tVOrfgQNGptvjo25vB48((object) property).Length == 0)).ForEach<PropertyInfo>((Action<PropertyInfo>) (property =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.SetStorageValue(property, values);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
      this.SettingsData.Clear();
      foreach (KeyValuePair<string, string> keyValuePair in (IEnumerable<KeyValuePair<string, string>>) values)
        this.SettingsData[keyValuePair.Key] = keyValuePair.Value;
    }

    /// <summary>Полные данные настроек</summary>
    [HiddenInput(DisplayValue = false)]
    public virtual IDictionary<string, string> SettingsData => this._settingsData;

    public GlobalSettingsBase()
    {
      GlobalSettingsBase.i5Dg9CWhd6UCSXnEKNOl();
      this._settingsData = (IDictionary<string, string>) new Dictionary<string, string>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool TDdjujWhmqqkXm57QfNa() => GlobalSettingsBase.tbSZr2Wh0FSqb5NohpfF == null;

    internal static GlobalSettingsBase WrmuZeWhyPSc9potfXId() => GlobalSettingsBase.tbSZr2Wh0FSqb5NohpfF;

    internal static bool zRwBZEWhMAFeXpXQsm3w([In] object obj0) => ((PropertyInfo) obj0).CanRead;

    internal static bool ASsLgVWhJbeVqbQ8wZFh([In] object obj0) => ((PropertyInfo) obj0).CanWrite;

    internal static bool TfPm9fWh9gxrLS8oxEV9([In] object obj0) => ((HiddenInputAttribute) obj0).DisplayValue;

    internal static void i5Dg9CWhd6UCSXnEKNOl() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool uSQkpgWhlle7gTAoMGAE([In] object obj0, [In] object obj1) => ((GlobalSettingsBase) obj0).SkipProperty((PropertyInfo) obj1);
  }
}
