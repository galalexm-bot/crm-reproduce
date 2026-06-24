// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.TypeSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>Базовый класс настроек типа данных</summary>
  [KnownType("GetKnownType")]
  [Component]
  [Serializable]
  public class TypeSettings : Attribute, IXsiType, IXsiRoot, ISerializable
  {
    private static ConcurrentDictionary<Type, PropertiesHelper> initializersCache;
    private static ConcurrentDictionary<Type, PropertiesContainer> defaultValuesCache;
    [NonSerialized]
    private IEntity _boundEntity;
    [NonSerialized]
    private Guid _boundEntityPropertyUid;
    internal static TypeSettings aZVIyqbBypqJFOyJK8W7;

    /// <summary>Ctor</summary>
    public TypeSettings()
    {
      TypeSettings.gLYDm0bB9qp406LWIdC8();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            TypeSettings.tvwgXIbBdqBaGvrmBNDc((object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Записать атрибуты валидации свойства</summary>
    public virtual IEnumerable<ISyntaxNode> WriteValidatePropertyAttributes() => (IEnumerable<ISyntaxNode>) new TypeSettings.\u003CWriteValidatePropertyAttributes\u003Ed__1(-2);

    /// <summary>
    /// Получить список пар (имя настройки-&gt;значение настройки)
    /// </summary>
    /// <returns></returns>
    public Dictionary<string, object> GetSettingsValuePairs() => TypeSettingsSerializer.SerializeToDictionary(this);

    /// <summary>
    /// Сериализовать в объект, пригодный для сериализации в Json
    /// </summary>
    /// <param name="jsonObject"></param>
    public virtual void SerializeToJsonObject(SerializableDictionary<string, object> jsonObject) => TypeSettingsSerializer.SerializeBasicToJsonObject(this, jsonObject);

    /// <summary>
    /// Десериализовать из объекта, пригодного для сериализации в Json
    /// </summary>
    /// <param name="jsonObject"></param>
    public virtual void DeserializeFromJsonObject(IDictionary<string, object> jsonObject) => TypeSettingsSerializer.DeserializeBasicFromJsonObject(this, jsonObject);

    /// <summary>Получить описание структуры настроек</summary>
    public TypeSerializationDescriptor GetSerializationDescriptor()
    {
      int num = 1;
      TypeSerializationDescriptor descriptor;
      while (true)
      {
        switch (num)
        {
          case 1:
            descriptor = new TypeSerializationDescriptor();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.GetSerializationDescriptor(descriptor);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 2 : 2;
            continue;
        }
      }
label_2:
      return descriptor;
    }

    /// <summary>Скопировать значения из другого объекта настроек</summary>
    /// <param name="other">Другой объект настроек</param>
    public void CopyFrom(TypeSettings other)
    {
      int num1 = 4;
      Dictionary<string, object>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_29;
          case 1:
            goto label_2;
          case 2:
            goto label_6;
          case 3:
            enumerator = other.GetSettingsValuePairs().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 2 : 2;
            continue;
          case 4:
            if (other != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 3 : 2;
              continue;
            }
            goto label_25;
          default:
            goto label_20;
        }
      }
label_29:
      return;
label_2:
      return;
label_20:
      return;
label_25:
      return;
label_6:
      try
      {
label_14:
        if (enumerator.MoveNext())
          goto label_9;
        else
          goto label_15;
label_8:
        KeyValuePair<string, object> current;
        int num2;
        while (true)
        {
          int num3;
          PropertyInfo property1;
          PropertyInfo property2;
          switch (num2)
          {
            case 1:
              goto label_10;
            case 2:
              property1.SetValue((object) this, current.Value, (object[]) null);
              num2 = 11;
              continue;
            case 3:
              if (!TypeSettings.lmNfZobBr6wOMNBE1wn8((object) property1, (object) null))
              {
                num3 = 8;
                break;
              }
              goto case 9;
            case 4:
              if (TypeSettings.lmNfZobBr6wOMNBE1wn8((object) property2, (object) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 3 : 1;
                continue;
              }
              goto label_14;
            case 5:
            case 8:
            case 11:
              goto label_14;
            case 6:
              if (TypeSettings.U4mxV6bBjejC0VQoJ0Vp(TypeSettings.PyxLi2bB5N1ATnc7RZLC((object) property1), property2.PropertyType))
              {
                num2 = 2;
                continue;
              }
              goto label_14;
            case 7:
              property2 = other.GetType().GetProperty(current.Key);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 9 : 10;
              continue;
            case 9:
              if (!TypeSettings.XWYMLLbBgiVAdFu0J8x8((object) property1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 5 : 0;
                continue;
              }
              goto case 6;
            case 10:
              property1 = TypeSettings.nXbZRNbBlCxjh56cBTNj((object) this).GetProperty(current.Key);
              num3 = 4;
              break;
            default:
              goto label_9;
          }
          num2 = num3;
        }
label_10:
        return;
label_9:
        current = enumerator.Current;
        num2 = 7;
        goto label_8;
label_15:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 0;
        goto label_8;
      }
      finally
      {
        enumerator.Dispose();
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
          num4 = 0;
        switch (num4)
        {
          default:
        }
      }
    }

    /// <summary>Клонировать объект</summary>
    /// <returns>Клонированный объект настроек</returns>
    public virtual TypeSettings Clone()
    {
      TypeSettings typeSettings = (TypeSettings) TypeSettings.SEGV6tbBYqv8OCpio064(TypeSettings.nXbZRNbBlCxjh56cBTNj((object) this));
      TypeSettings.GuI58ybBL3xcsBcBapCS((object) typeSettings, (object) this);
      return typeSettings;
    }

    /// <summary>Привести к указанному типу настроек</summary>
    /// <typeparam name="TSettings">Тип настроек</typeparam>
    /// <returns>Настройки</returns>
    public TSettings As<TSettings>() where TSettings : TypeSettings => (TSettings) this;

    /// <summary>Привязать настройки к экземпляру сущности</summary>
    /// <param name="entity">Экземпляр сущности</param>
    /// <param name="propertyUid">Уникальный идентфикатор свойства</param>
    public void BindToEntity(IEntity entity, Guid propertyUid)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this._boundEntity = entity;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this._boundEntityPropertyUid = propertyUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <summary>
    /// Сохранить настройки, если они привязаны к сущности. Иначе вызывается исключение
    /// </summary>
    public void Save()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this._boundEntity != null)
            {
              TypeSettings.XbyslpbBs63S17Xvnh4L((object) this._boundEntity, this._boundEntityPropertyUid, (object) this);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 2;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return;
label_3:
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) TypeSettings.RuOImAbBUQp8GWFdvp97(-1290212282 ^ -644262414 ^ 1786975938), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021393315)));
    }

    public virtual void SetTypeSettings(PropertiesContainer dict)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            TypeSettings.KAn1FnbBzGxTHi31iMge(TypeSettings.NZdH3tbBcGKChXSNjy1G(TypeSettings.nXbZRNbBlCxjh56cBTNj((object) this)), (object) dict, (object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <inheritdoc />
    [XmlIgnore]
    [ScriptIgnore]
    public override object TypeId => TypeSettings.rD6UldbWFQh0A8bHfx6F((object) this);

    /// <summary>Deserialization ctor</summary>
    /// <param name="info">Serialization info</param>
    /// <param name="context">Context</param>
    protected TypeSettings(SerializationInfo info, StreamingContext context)
    {
      TypeSettings.gLYDm0bB9qp406LWIdC8();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      SerializationInfoEnumerator serializationInfoEnumerator;
      object obj;
      PropertyInfo property;
      string name;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
          case 5:
          case 7:
            if (!TypeSettings.k8kE1WbWhe11qRKgRL82((object) serializationInfoEnumerator))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 1;
              continue;
            }
            goto case 10;
          case 3:
            TypeSettings.tvwgXIbBdqBaGvrmBNDc((object) this);
            num = 11;
            continue;
          case 4:
            obj = TypeSettings.OCEga9bWoZ5UBa7FKvSi((object) info, (object) serializationInfoEnumerator.Name, serializationInfoEnumerator.ObjectType);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
            continue;
          case 6:
            serializationInfoEnumerator.Reset();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 5;
            continue;
          case 8:
            if (!(property != (PropertyInfo) null))
            {
              num = 2;
              continue;
            }
            goto case 4;
          case 9:
            property = TypeSettings.nXbZRNbBlCxjh56cBTNj((object) this).GetProperty(name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 8 : 7;
            continue;
          case 10:
            name = (string) TypeSettings.NrLQwubWWGIWNfl26pi5((object) serializationInfoEnumerator);
            num = 9;
            continue;
          case 11:
            serializationInfoEnumerator = (SerializationInfoEnumerator) TypeSettings.lbQXgAbWBlxol0N9RJIH((object) info);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 6 : 6;
            continue;
          default:
            TypeSettings.R2vTTFbWbkDoL1JRfebA((object) property, (object) this, obj, (object) null);
            num = 7;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Serialize this object</summary>
    /// <param name="info">Serialization info</param>
    /// <param name="context">Context</param>
    void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
    {
      int num1 = 1;
      Dictionary<string, object>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator = this.GetSettingsValuePairs().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_14;
          default:
            goto label_2;
        }
      }
label_14:
      return;
label_2:
      try
      {
label_6:
        if (enumerator.MoveNext())
          goto label_8;
        else
          goto label_7;
label_4:
        KeyValuePair<string, object> current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_6;
            case 2:
              goto label_10;
            case 3:
              goto label_8;
            default:
              TypeSettings.WPZ7BubWGZoMudIM22N2((object) info, (object) current.Key, current.Value);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 1;
              continue;
          }
        }
label_10:
        return;
label_7:
        num2 = 2;
        goto label_4;
label_8:
        current = enumerator.Current;
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
        {
          num2 = 0;
          goto label_4;
        }
        else
          goto label_4;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    /// <summary>Инициализировать свойства значениями по умолчанию</summary>
    protected virtual void InitDefaultPropertyValues()
    {
      int num1 = 3;
      PropertiesContainer orAdd;
      Type type;
      PropertiesHelper cache;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_2;
          case 1:
            TypeSettings.KAn1FnbBzGxTHi31iMge((object) cache, (object) orAdd, (object) this);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
            continue;
          case 2:
            type = TypeSettings.nXbZRNbBlCxjh56cBTNj((object) this);
            num1 = 5;
            continue;
          case 3:
            num1 = 2;
            continue;
          case 4:
            orAdd = TypeSettings.defaultValuesCache.GetOrAdd(type, (Func<Type, PropertiesContainer>) (a =>
            {
              int num2 = 3;
              PropertiesContainer propertiesContainer;
              while (true)
              {
                int num3 = num2;
                while (true)
                {
                  PropertyInfo[] propertyInfoArray;
                  int index;
                  PropertyInfo propertyInfo;
                  DefaultValueAttribute defaultValueAttribute;
                  switch (num3)
                  {
                    case 1:
                      index = 0;
                      num3 = 12;
                      continue;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      propertyInfoArray = (PropertyInfo[]) TypeSettings.\u003C\u003Ec__DisplayClass16_0.xoJ47jCXHwRlxRi7lrwF((object) cache);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 1 : 1;
                      continue;
                    case 3:
                      propertiesContainer = new PropertiesContainer();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 2;
                      continue;
                    case 4:
                      goto label_14;
                    case 5:
                      propertyInfo = propertyInfoArray[index];
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 5 : 6;
                      continue;
                    case 6:
                      defaultValueAttribute = AttributeHelper<DefaultValueAttribute>.GetAttributes((MemberInfo) propertyInfo, true).FirstOrDefault<DefaultValueAttribute>();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 7 : 4;
                      continue;
                    case 7:
                      if (defaultValueAttribute == null)
                        break;
                      goto label_6;
                    case 8:
                    case 12:
                      if (index >= propertyInfoArray.Length)
                      {
                        num3 = 4;
                        continue;
                      }
                      goto case 5;
                    case 9:
                      // ISSUE: reference to a compiler-generated method
                      if (TypeSettings.\u003C\u003Ec__DisplayClass16_0.paIsJ9CXA3ZC1MMeWR54((object) defaultValueAttribute) != null)
                      {
                        num3 = 10;
                        continue;
                      }
                      break;
                    case 10:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      if (TypeSettings.\u003C\u003Ec__DisplayClass16_0.B54vgcCX7FWFjkZq4OG9((object) propertyInfo).IsAssignableFrom(TypeSettings.\u003C\u003Ec__DisplayClass16_0.paIsJ9CXA3ZC1MMeWR54((object) defaultValueAttribute).GetType()))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 7 : 11;
                        continue;
                      }
                      break;
                    case 11:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      TypeSettings.\u003C\u003Ec__DisplayClass16_0.d8SAlfCX0VlIgJVT8Iol((object) propertiesContainer, TypeSettings.\u003C\u003Ec__DisplayClass16_0.yElX2UCXxV6U0NmxtUtR((object) propertyInfo), defaultValueAttribute.Value);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
                      continue;
                  }
                  ++index;
                  num3 = 8;
                }
label_6:
                num2 = 9;
              }
label_14:
              return propertiesContainer;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 1 : 0;
            continue;
          case 5:
            cache = TypeSettings.GetInitializerCache(type);
            num1 = 4;
            continue;
          default:
            goto label_8;
        }
      }
label_2:
      return;
label_8:;
    }

    /// <summary>Получить описание структуры настроек</summary>
    /// <param name="descriptor"></param>
    protected virtual void GetSerializationDescriptor(TypeSerializationDescriptor descriptor)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            TypeSettings.imqfXabWEJtuqvNm8RMh(TypeSettings.nXbZRNbBlCxjh56cBTNj((object) this), (object) descriptor);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private static PropertiesHelper GetInitializerCache(Type type)
    {
      int num = 1;
      Type type1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            type1 = type;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 2 : 1;
            continue;
        }
      }
label_3:
      return TypeSettings.initializersCache.GetOrAdd(type1, (Func<Type, PropertiesHelper>) (a =>
      {
        Type type2 = type1;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        ParameterExpression parameterExpression = (ParameterExpression) TypeSettings.\u003C\u003Ec__DisplayClass22_0.oLDBBHCX9t0i983sVCZe(typeof (PropertyInfo), TypeSettings.\u003C\u003Ec__DisplayClass22_0.JC0YrFCXJrDBeqpp5VQg(589593376 ^ -1977315327 ^ -1459609095));
        // ISSUE: method reference
        // ISSUE: reference to a compiler-generated method
        // ISSUE: method reference
        // ISSUE: reference to a compiler-generated method
        // ISSUE: type reference
        // ISSUE: reference to a compiler-generated method
        // ISSUE: type reference
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: type reference
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        Expression<Func<PropertyInfo, bool>> propertiesSelectCondition = Expression.Lambda<Func<PropertyInfo, bool>>((Expression) TypeSettings.\u003C\u003Ec__DisplayClass22_0.S5f6gsCX5NHVKDMA6Qq4(TypeSettings.\u003C\u003Ec__DisplayClass22_0.djQyTMCXgjPpkygJkDpo((object) null, (object) (MethodInfo) TypeSettings.\u003C\u003Ec__DisplayClass22_0.N5SCuXCXdgcdRFjim2fo(__methodref (Enumerable.Any)), (object) new Expression[1]
        {
          (Expression) TypeSettings.\u003C\u003Ec__DisplayClass22_0.djQyTMCXgjPpkygJkDpo((object) parameterExpression, (object) (MethodInfo) TypeSettings.\u003C\u003Ec__DisplayClass22_0.N5SCuXCXdgcdRFjim2fo(__methodref (MemberInfo.GetCustomAttributes)), (object) new Expression[2]
          {
            (Expression) TypeSettings.\u003C\u003Ec__DisplayClass22_0.OO99BvCXrgRY4UyGx8yj((object) TypeSettings.\u003C\u003Ec__DisplayClass22_0.zduCJqCXlwNXFaQrCDEO(__typeref (XmlIgnoreAttribute)), TypeSettings.\u003C\u003Ec__DisplayClass22_0.zduCJqCXlwNXFaQrCDEO(__typeref (Type))),
            (Expression) TypeSettings.\u003C\u003Ec__DisplayClass22_0.OO99BvCXrgRY4UyGx8yj((object) true, TypeSettings.\u003C\u003Ec__DisplayClass22_0.zduCJqCXlwNXFaQrCDEO(__typeref (bool)))
          })
        })), parameterExpression);
        return new PropertiesHelper(type2, propertiesSelectCondition);
      }));
    }

    [UsedImplicitly]
    private static IEnumerable<Type> GetKnownType() => ComponentManager.Current.GetExtensionPointTypes<IXsiType>().Where<Type>((Func<Type, bool>) (t => TypeSettings.\u003C\u003Ec.dEnHgwCXUIiWC5Kw9QHq(__typeref (TypeSettings)).IsAssignableFrom(t)));

    static TypeSettings()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
            continue;
          case 2:
            TypeSettings.defaultValuesCache = new ConcurrentDictionary<Type, PropertiesContainer>();
            num = 3;
            continue;
          case 3:
            goto label_2;
          default:
            TypeSettings.initializersCache = new ConcurrentDictionary<Type, PropertiesHelper>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static void gLYDm0bB9qp406LWIdC8() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void tvwgXIbBdqBaGvrmBNDc([In] object obj0) => ((TypeSettings) obj0).InitDefaultPropertyValues();

    internal static bool AOMKAdbBMpc157VNSmdO() => TypeSettings.aZVIyqbBypqJFOyJK8W7 == null;

    internal static TypeSettings onOLVvbBJQ4RVlNgS9xx() => TypeSettings.aZVIyqbBypqJFOyJK8W7;

    internal static Type nXbZRNbBlCxjh56cBTNj([In] object obj0) => obj0.GetType();

    internal static bool lmNfZobBr6wOMNBE1wn8([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 != (PropertyInfo) obj1;

    internal static bool XWYMLLbBgiVAdFu0J8x8([In] object obj0) => ((PropertyInfo) obj0).CanWrite;

    internal static Type PyxLi2bB5N1ATnc7RZLC([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

    internal static bool U4mxV6bBjejC0VQoJ0Vp([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object SEGV6tbBYqv8OCpio064([In] Type obj0) => Activator.CreateInstance(obj0);

    internal static void GuI58ybBL3xcsBcBapCS([In] object obj0, [In] object obj1) => ((TypeSettings) obj0).CopyFrom((TypeSettings) obj1);

    internal static object RuOImAbBUQp8GWFdvp97(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void XbyslpbBs63S17Xvnh4L([In] object obj0, Guid propertyUid, [In] object obj2) => ((IEntity) obj0).SavePropertyInstanceSettings(propertyUid, (TypeSettings) obj2);

    internal static object NZdH3tbBcGKChXSNjy1G(Type type) => (object) TypeSettings.GetInitializerCache(type);

    internal static void KAn1FnbBzGxTHi31iMge([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertiesHelper) obj0).SetValues((PropertiesContainer) obj1, obj2);

    internal static object rD6UldbWFQh0A8bHfx6F([In] object obj0) => __nonvirtual (((Attribute) obj0).TypeId);

    internal static object lbQXgAbWBlxol0N9RJIH([In] object obj0) => (object) ((SerializationInfo) obj0).GetEnumerator();

    internal static object NrLQwubWWGIWNfl26pi5([In] object obj0) => (object) ((SerializationInfoEnumerator) obj0).Name;

    internal static object OCEga9bWoZ5UBa7FKvSi([In] object obj0, [In] object obj1, [In] Type obj2) => ((SerializationInfo) obj0).GetValue((string) obj1, obj2);

    internal static void R2vTTFbWbkDoL1JRfebA([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);

    internal static bool k8kE1WbWhe11qRKgRL82([In] object obj0) => ((SerializationInfoEnumerator) obj0).MoveNext();

    internal static void WPZ7BubWGZoMudIM22N2([In] object obj0, [In] object obj1, [In] object obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);

    internal static void imqfXabWEJtuqvNm8RMh(Type typeSettingsType, [In] object obj1) => TypeSettingsSerializer.GetSerializationDescriptor(typeSettingsType, (TypeSerializationDescriptor) obj1);
  }
}
