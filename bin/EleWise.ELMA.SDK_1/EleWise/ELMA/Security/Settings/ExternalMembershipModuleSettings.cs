// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Settings.ExternalMembershipModuleSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Security.Settings
{
  /// <summary>
  /// Настройки модуля авторизации IExternalMembershipModule
  /// </summary>
  public abstract class ExternalMembershipModuleSettings : 
    IExternalMembershipModuleSettings,
    IStoreValuesObject
  {
    private bool deletable;
    internal static ExternalMembershipModuleSettings XeKeg3BY6sSqEdrccF87;

    /// <summary>
    /// Идентификатор модуля авторизации IExternalMembershipModule
    /// </summary>
    public abstract Guid ModuleUid { get; }

    /// <summary>Идентификатор экземпляра настроек</summary>
    public Guid InstanceUid
    {
      get => this.\u003CInstanceUid\u003Ek__BackingField;
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
              this.\u003CInstanceUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
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

    /// <summary>Отображаемое имя</summary>
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (ExternalMembershipSettings_SR), "Name")]
    public abstract string Name { get; }

    /// <summary>Возможность удалять</summary>
    public virtual bool Deletable
    {
      get => this.deletable;
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
              this.deletable = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
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

    /// <summary>Получить данные по свойству</summary>
    public virtual IDictionary<string, string> GetStorageValue(PropertyInfo property)
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

    /// <summary>Установить значение свойства по словарю с данными</summary>
    /// <param name="property">Свойство</param>
    /// <param name="values">Словарь с данными</param>
    public virtual void SetStorageValue(PropertyInfo property, IDictionary<string, string> values)
    {
      if (!values.ContainsKey(property.Name))
        return;
      object obj = (object) null;
      string str = values[property.Name];
      try
      {
        TypeConverter converter = TypeDescriptor.GetConverter(property.PropertyType);
        obj = converter == null || !converter.CanConvertFrom(typeof (string)) ? ClassSerializationHelper.DeserializeObjectByJson(property.PropertyType, str) : converter.ConvertFromInvariantString(str);
      }
      catch (Exception ex)
      {
        Logger.Log.Error((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021313705), (object) property.Name, (object) property.DeclaringType.FullName), ex);
      }
      if (obj == null)
        return;
      property.SetValue((object) this, obj, (object[]) null);
    }

    /// <summary>
    /// Пропускать ли свойство при автоматическом формировании данных
    /// </summary>
    /// <param name="property">Свойство</param>
    /// <returns><c>true</c>, если пропускать</returns>
    protected virtual bool SkipProperty(PropertyInfo property)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (ExternalMembershipModuleSettings.KIpIHqBY76AeytdK8heo((object) property))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return !ExternalMembershipModuleSettings.qVNEHXBYx1mmgjKeQgkr((object) property);
label_5:
      return true;
    }

    private static bool SkipPropertyByAttribute(object property) => AttributeHelper<XmlIgnoreAttribute>.GetAttribute((MemberInfo) property, true) != null;

    IDictionary<string, string> IStoreValuesObject.GetStorageValues() => (IDictionary<string, string>) ((IEnumerable<PropertyInfo>) this.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)).Where<PropertyInfo>((Func<PropertyInfo, bool>) (property => !ExternalMembershipModuleSettings.\u003C\u003Ec.Y5lsg3QPZc3JaDlyZoXu((object) property))).Where<PropertyInfo>((Func<PropertyInfo, bool>) (property => !ExternalMembershipModuleSettings.hxP3ooBY0o4CiwEVoeMI((object) this, (object) property))).Where<PropertyInfo>((Func<PropertyInfo, bool>) (property => ExternalMembershipModuleSettings.\u003C\u003Ec.IejenZQPuCrRbjHys3TX((object) property).Length == 0)).SelectMany<PropertyInfo, KeyValuePair<string, string>>(new Func<PropertyInfo, IEnumerable<KeyValuePair<string, string>>>(this.GetStorageValue)).ToDictionary<KeyValuePair<string, string>, string, string>((Func<KeyValuePair<string, string>, string>) (k => k.Key), (Func<KeyValuePair<string, string>, string>) (v => v.Value));

    void IStoreValuesObject.SetStorageValues(IDictionary<string, string> values)
    {
      if (values == null)
        return;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      ((IEnumerable<PropertyInfo>) this.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)).Where<PropertyInfo>((Func<PropertyInfo, bool>) (property => values.Keys.Contains((string) ExternalMembershipModuleSettings.\u003C\u003Ec__DisplayClass17_0.SmhStEQPRQeWCvSCNXgZ((object) property)))).Where<PropertyInfo>((Func<PropertyInfo, bool>) (property => !ExternalMembershipModuleSettings.\u003C\u003Ec.Y5lsg3QPZc3JaDlyZoXu((object) property))).Where<PropertyInfo>((Func<PropertyInfo, bool>) (property => !ExternalMembershipModuleSettings.\u003C\u003Ec__DisplayClass17_0.wg4CS5QPqygFujiv0fj0((object) this, (object) property))).Where<PropertyInfo>((Func<PropertyInfo, bool>) (property => ExternalMembershipModuleSettings.\u003C\u003Ec.IejenZQPuCrRbjHys3TX((object) property).Length == 0)).ForEach<PropertyInfo>((Action<PropertyInfo>) (property =>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
    }

    protected ExternalMembershipModuleSettings()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.deletable = true;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool uREA4EBYHx9SQGhNk6WL() => ExternalMembershipModuleSettings.XeKeg3BY6sSqEdrccF87 == null;

    internal static ExternalMembershipModuleSettings vfW6fnBYAW5j1RuhB6QH() => ExternalMembershipModuleSettings.XeKeg3BY6sSqEdrccF87;

    internal static bool KIpIHqBY76AeytdK8heo([In] object obj0) => ((PropertyInfo) obj0).CanRead;

    internal static bool qVNEHXBYx1mmgjKeQgkr([In] object obj0) => ((PropertyInfo) obj0).CanWrite;

    internal static bool hxP3ooBY0o4CiwEVoeMI([In] object obj0, [In] object obj1) => ((ExternalMembershipModuleSettings) obj0).SkipProperty((PropertyInfo) obj1);
  }
}
