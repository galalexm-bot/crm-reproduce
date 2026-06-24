// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.TypeSettingsSerializer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>
  /// Предназначен для сериализации настроек свойств сущностей
  /// </summary>
  public static class TypeSettingsSerializer
  {
    private static ConcurrentDictionary<Type, TypeSettingsSerializer.DictionarySerializer> _dictSerializers;
    private static ConcurrentDictionary<string, Type> _typesByName;
    internal static TypeSettingsSerializer hyL2eMocNGh6vJvGqy7m;

    /// <summary>Сериализовать настройки в словарь</summary>
    /// <param name="settings"></param>
    /// <returns></returns>
    public static Dictionary<string, object> SerializeToDictionary(TypeSettings settings) => settings != null ? TypeSettingsSerializer.GetSerializer(settings.GetType()).Serialize(settings) : throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1380439818 << 3 ^ 1841409342));

    /// <summary>
    /// Сериализовать настройки в объект, пригодный для сериализации в Json
    /// </summary>
    /// <param name="settings"></param>
    /// <returns></returns>
    public static SerializableDictionary<string, object> SerializeToJsonObject(TypeSettings settings)
    {
      Type type = settings != null ? settings.GetType() : throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70046333));
      string name = type.Name;
      if (!TypeSettingsSerializer._typesByName.ContainsKey(name))
        TypeSettingsSerializer._typesByName[name] = type;
      SerializableDictionary<string, object> jsonObject = new SerializableDictionary<string, object>();
      jsonObject[z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333632616)] = (object) name;
      settings.SerializeToJsonObject(jsonObject);
      return jsonObject;
    }

    /// <summary>
    /// Десериализовать из объекта, пригодного для сериализации в Json
    /// </summary>
    /// <param name="jsonObject"></param>
    public static TypeSettings DeserializeFromJsonObject(IDictionary<string, object> jsonObject)
    {
      string typeName = jsonObject != null ? (string) jsonObject[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1304605005 ^ 1304436023)] : throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088198838));
      Type type;
      if (!TypeSettingsSerializer._typesByName.TryGetValue(typeName, out type))
      {
        type = ((IEnumerable<Type>) ComponentManager.Current.GetXsiTypes()).FirstOrDefault<Type>((Func<Type, bool>) (t =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                if (typeof (TypeSettings).IsAssignableFrom(t))
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
                  continue;
                }
                goto label_5;
              default:
                goto label_4;
            }
          }
label_4:
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          return TypeSettingsSerializer.\u003C\u003Ec__DisplayClass2_0.hJZycbCqcqMUBjmTReVY(TypeSettingsSerializer.\u003C\u003Ec__DisplayClass2_0.gQUtC3CqsBu1yYNEBtvH((object) t), (object) typeName);
label_5:
          return false;
        }));
        TypeSettingsSerializer._typesByName[typeName] = !(type == (Type) null) ? type : throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289807680), (object) typeName));
      }
      TypeSettings instance = (TypeSettings) Activator.CreateInstance(type);
      instance.DeserializeFromJsonObject(jsonObject);
      return instance;
    }

    /// <summary>
    /// Сериализовать базовые настройки в объект, пригодный для сериализации в Json
    /// </summary>
    internal static void SerializeBasicToJsonObject(
      TypeSettings settings,
      SerializableDictionary<string, object> jsonObject)
    {
      if (settings == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461602583));
      if (jsonObject == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(323422137 << 2 ^ 1293857398));
      foreach (KeyValuePair<TypeSettingsSerializer.DictionarySerializer.PropertyDescriptor, object> keyValuePair in TypeSettingsSerializer.GetSerializer(settings.GetType()).SerializeWithType(settings).Where<KeyValuePair<TypeSettingsSerializer.DictionarySerializer.PropertyDescriptor, object>>((Func<KeyValuePair<TypeSettingsSerializer.DictionarySerializer.PropertyDescriptor, object>, bool>) (p => !p.Key.JsonIgnore)))
      {
        TypeConverter converter = System.ComponentModel.TypeDescriptor.GetConverter(keyValuePair.Key.Type);
        if (converter != null)
        {
          string invariantString = converter.ConvertToInvariantString(keyValuePair.Value);
          jsonObject[keyValuePair.Key.Name] = (object) invariantString;
        }
      }
    }

    /// <summary>
    /// Десериализовать базовые настройки из объекта, пригодного для сериализации в Json
    /// </summary>
    /// <param name="jsonObject"></param>
    internal static void DeserializeBasicFromJsonObject(
      TypeSettings settings,
      IDictionary<string, object> jsonObject)
    {
      if (settings == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -36033699));
      if (jsonObject == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909271027));
      // ISSUE: reference to a compiler-generated method
      foreach (TypeSettingsSerializer.DictionarySerializer.PropertyDescriptor propertyDescriptor in TypeSettingsSerializer.GetSerializer(settings.GetType()).GetSerializedPropertyInfos().Where<TypeSettingsSerializer.DictionarySerializer.PropertyDescriptor>((Func<TypeSettingsSerializer.DictionarySerializer.PropertyDescriptor, bool>) (p => !TypeSettingsSerializer.\u003C\u003Ec.ygclgyCKoTMu3Em9iIPV((object) p))))
      {
        PropertyInfo property = propertyDescriptor.Property;
        object obj1;
        if (jsonObject.TryGetValue(propertyDescriptor.Name, out obj1))
        {
          string text = (string) obj1;
          if (property.CanWrite)
          {
            TypeConverter converter = System.ComponentModel.TypeDescriptor.GetConverter(property.PropertyType);
            if (converter != null)
            {
              object obj2 = converter.ConvertFromInvariantString(text);
              property.SetValue((object) settings, obj2, (object[]) null);
            }
          }
        }
      }
    }

    internal static void GetSerializationDescriptor(
      Type typeSettingsType,
      TypeSerializationDescriptor descriptor)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            TypeSettingsSerializer.ESvaZwocD9qBZybCpr1b(TypeSettingsSerializer.IisEM0ocaQuitkNJVDbk(typeSettingsType), (object) descriptor);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private static TypeSettingsSerializer.DictionarySerializer GetSerializer(Type typeSettingsType)
    {
      int num = 4;
      TypeSettingsSerializer.DictionarySerializer serializer;
      while (true)
      {
        switch (num)
        {
          case 1:
            serializer = new TypeSettingsSerializer.DictionarySerializer(typeSettingsType);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 2 : 2;
            continue;
          case 2:
            TypeSettingsSerializer._dictSerializers[typeSettingsType] = serializer;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
            continue;
          case 4:
            if (TypeSettingsSerializer._dictSerializers.TryGetValue(typeSettingsType, out serializer))
            {
              num = 3;
              continue;
            }
            goto case 1;
          default:
            goto label_3;
        }
      }
label_3:
      return serializer;
    }

    static TypeSettingsSerializer()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TypeSettingsSerializer.Rh10PFoct3KI38iLT622();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            TypeSettingsSerializer._typesByName = new ConcurrentDictionary<string, Type>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 2;
            continue;
          default:
            TypeSettingsSerializer._dictSerializers = new ConcurrentDictionary<Type, TypeSettingsSerializer.DictionarySerializer>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 1 : 3;
            continue;
        }
      }
label_2:;
    }

    internal static object IisEM0ocaQuitkNJVDbk(Type typeSettingsType) => (object) TypeSettingsSerializer.GetSerializer(typeSettingsType);

    internal static void ESvaZwocD9qBZybCpr1b([In] object obj0, [In] object obj1) => ((TypeSettingsSerializer.DictionarySerializer) obj0).GetSerializationDescriptor((TypeSerializationDescriptor) obj1);

    internal static bool B7NfERoc3JjBXCoS7wGN() => TypeSettingsSerializer.hyL2eMocNGh6vJvGqy7m == null;

    internal static TypeSettingsSerializer OyxFQRocpAPaQmr2I31F() => TypeSettingsSerializer.hyL2eMocNGh6vJvGqy7m;

    internal static void Rh10PFoct3KI38iLT622() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    private class DictionarySerializer
    {
      private Type _type;
      private List<TypeSettingsSerializer.DictionarySerializer.PropertyDescriptor> _propertyInfos;
      private static object ppMZ6JCqwLYHWFQds81s;

      public DictionarySerializer(Type type)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        this._propertyInfos = new List<TypeSettingsSerializer.DictionarySerializer.PropertyDescriptor>();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num1 = 43;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
          num1 = 17;
        while (true)
        {
          int num2;
          XmlAttributeAttribute attribute1;
          TypeSettingsSerializer.DictionarySerializer.PropertyDescriptor propertyDescriptor1;
          PropertyInfo[] propertyInfoArray;
          int index;
          PropertyInfo propertyInfo;
          string str;
          DefaultValueAttribute defaultValueAttribute;
          XmlElementAttribute attribute2;
          System.ComponentModel.DescriptionAttribute sysDescriptionAttr;
          System.ComponentModel.DisplayNameAttribute sysDisplayNameAttr;
          EleWise.ELMA.Model.Attributes.DisplayNameAttribute displayNameAttr;
          EleWise.ELMA.Model.Attributes.DescriptionAttribute descriptionAttr;
          switch (num1)
          {
            case 1:
            case 22:
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 38 : 0;
              continue;
            case 2:
              ++index;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 20 : 11;
              continue;
            case 3:
            case 20:
              if (index < propertyInfoArray.Length)
              {
                num1 = 39;
                continue;
              }
              goto label_44;
            case 4:
              // ISSUE: reference to a compiler-generated method
              propertyDescriptor1.DisplayNameAccessor = (Func<string>) (() => (string) TypeSettingsSerializer.DictionarySerializer.\u003C\u003Ec__DisplayClass0_0.qZpfR4ZVShITpvZVfnCk((object) descriptionAttr));
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 32 : 5;
              continue;
            case 5:
              if (sysDisplayNameAttr != null)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 4 : 44;
                continue;
              }
              goto case 14;
            case 6:
              sysDisplayNameAttr = AttributeHelper<System.ComponentModel.DisplayNameAttribute>.GetAttribute((MemberInfo) propertyInfo, true);
              num1 = 5;
              continue;
            case 7:
              propertyDescriptor1.DisplayNameAccessor = (Func<string>) (() => sysDescriptionAttr.Description);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 5 : 10;
              continue;
            case 8:
              goto label_49;
            case 9:
              num1 = 6;
              continue;
            case 10:
            case 32:
            case 33:
              this._propertyInfos.Add(propertyDescriptor1);
              num1 = 2;
              continue;
            case 11:
              propertyInfoArray = (PropertyInfo[]) TypeSettingsSerializer.DictionarySerializer.kowmiaCqHLclv23h9VUY(type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy);
              num1 = 25;
              continue;
            case 12:
              str = attribute2.ElementName;
              num1 = 17;
              continue;
            case 13:
              if (attribute2 == null)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 21 : 3;
                continue;
              }
              goto case 41;
            case 14:
            case 16:
              descriptionAttr = AttributeHelper<EleWise.ELMA.Model.Attributes.DescriptionAttribute>.GetAttribute((MemberInfo) propertyInfo, true);
              num1 = 26;
              continue;
            case 15:
            case 39:
              propertyInfo = propertyInfoArray[index];
              num2 = 45;
              break;
            case 17:
            case 24:
            case 31:
            case 36:
              // ISSUE: type reference
              defaultValueAttribute = ((IEnumerable) TypeSettingsSerializer.DictionarySerializer.SD6XwACqJc75v0Ev379I((object) propertyInfo, TypeSettingsSerializer.DictionarySerializer.fZWLo5CqxcGTEIKNNY06(__typeref (DefaultValueAttribute)), true)).Cast<DefaultValueAttribute>().FirstOrDefault<DefaultValueAttribute>();
              num2 = 29;
              break;
            case 18:
              attribute2 = AttributeHelper<XmlElementAttribute>.GetAttribute((MemberInfo) propertyInfo, true);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 13 : 11;
              continue;
            case 19:
              if (!TypeSettingsSerializer.DictionarySerializer.gg2EEcCqApfcsyAQHJxw((object) propertyInfo, typeof (XmlIgnoreAttribute), false))
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 25 : 28;
                continue;
              }
              goto case 2;
            case 21:
            case 23:
            case 46:
              attribute1 = AttributeHelper<XmlAttributeAttribute>.GetAttribute((MemberInfo) propertyInfo, true);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 6 : 34;
              continue;
            case 25:
              index = 0;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 2 : 3;
              continue;
            case 26:
              if (descriptionAttr == null)
              {
                num1 = 22;
                continue;
              }
              goto case 4;
            case 27:
              str = (string) TypeSettingsSerializer.DictionarySerializer.uhsuDLCqmwaBR8A34KUK((object) propertyInfo);
              num1 = 18;
              continue;
            case 28:
              // ISSUE: type reference
              if (!TypeSettingsSerializer.DictionarySerializer.gl9HIUCq0KGfC3gKoJIU(TypeSettingsSerializer.DictionarySerializer.j1qraKCq7jotKW4KKEsx((object) propertyInfo), TypeSettingsSerializer.DictionarySerializer.fZWLo5CqxcGTEIKNNY06(__typeref (Attribute))))
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 27 : 0;
                continue;
              }
              goto case 2;
            case 29:
              TypeSettingsSerializer.DictionarySerializer.PropertyDescriptor propertyDescriptor2 = new TypeSettingsSerializer.DictionarySerializer.PropertyDescriptor();
              TypeSettingsSerializer.DictionarySerializer.d67lSOCq9hrp17pabFgx((object) propertyDescriptor2, (object) propertyInfo);
              TypeSettingsSerializer.DictionarySerializer.NYxFlkCqd0y3W80osm1R((object) propertyDescriptor2, (object) str);
              TypeSettingsSerializer.DictionarySerializer.fXkZIgCql1lubCuFxaK8((object) propertyDescriptor2, propertyInfo.PropertyType);
              propertyDescriptor2.DefaultValueAttribute = defaultValueAttribute;
              // ISSUE: type reference
              TypeSettingsSerializer.DictionarySerializer.O4qeAbCqrZhNUn1Fw2sr((object) propertyDescriptor2, TypeSettingsSerializer.DictionarySerializer.gg2EEcCqApfcsyAQHJxw((object) propertyInfo, TypeSettingsSerializer.DictionarySerializer.fZWLo5CqxcGTEIKNNY06(__typeref (JsonSerializationIgnoreAttribute)), true));
              propertyDescriptor1 = propertyDescriptor2;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 30;
              continue;
            case 30:
              displayNameAttr = AttributeHelper<EleWise.ELMA.Model.Attributes.DisplayNameAttribute>.GetAttribute((MemberInfo) propertyInfo, true);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 11 : 40;
              continue;
            case 34:
              if (attribute1 == null)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 31 : 22;
                continue;
              }
              goto default;
            case 35:
              if (sysDescriptionAttr == null)
              {
                num1 = 33;
                continue;
              }
              goto case 7;
            case 37:
              str = (string) TypeSettingsSerializer.DictionarySerializer.B2agQaCqMuchhti6GlqX((object) attribute1);
              num1 = 36;
              continue;
            case 38:
              sysDescriptionAttr = AttributeHelper<System.ComponentModel.DescriptionAttribute>.GetAttribute((MemberInfo) propertyInfo, true);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 33 : 35;
              continue;
            case 40:
              if (displayNameAttr != null)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 11 : 42;
                continue;
              }
              goto case 9;
            case 41:
              if (TypeSettingsSerializer.DictionarySerializer.pyHu61CqyCiXjHGGuW9n((object) attribute2.ElementName))
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 18 : 46;
                continue;
              }
              goto case 12;
            case 42:
              propertyDescriptor1.DisplayNameAccessor = (Func<string>) (() => displayNameAttr.Value);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 10 : 14;
              continue;
            case 43:
              this._type = type;
              num1 = 11;
              continue;
            case 44:
              propertyDescriptor1.DisplayNameAccessor = (Func<string>) (() => sysDisplayNameAttr.DisplayName);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 16 : 3;
              continue;
            case 45:
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 19;
              continue;
            default:
              if (TypeSettingsSerializer.DictionarySerializer.pyHu61CqyCiXjHGGuW9n(TypeSettingsSerializer.DictionarySerializer.B2agQaCqMuchhti6GlqX((object) attribute1)))
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 5 : 24;
                continue;
              }
              goto case 37;
          }
          num1 = num2;
        }
label_49:
        return;
label_44:;
      }

      public Dictionary<string, object> Serialize(TypeSettings settings) => this.SerializeWithType(settings).ToDictionary<KeyValuePair<TypeSettingsSerializer.DictionarySerializer.PropertyDescriptor, object>, string, object>((Func<KeyValuePair<TypeSettingsSerializer.DictionarySerializer.PropertyDescriptor, object>, string>) (k => k.Key.Property.Name), (Func<KeyValuePair<TypeSettingsSerializer.DictionarySerializer.PropertyDescriptor, object>, object>) (v => v.Value));

      public Dictionary<TypeSettingsSerializer.DictionarySerializer.PropertyDescriptor, object> SerializeWithType(
        TypeSettings settings)
      {
        if (settings == null)
          throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97912104));
        Dictionary<TypeSettingsSerializer.DictionarySerializer.PropertyDescriptor, object> dictionary = new Dictionary<TypeSettingsSerializer.DictionarySerializer.PropertyDescriptor, object>();
        foreach (TypeSettingsSerializer.DictionarySerializer.PropertyDescriptor propertyInfo in this._propertyInfos)
        {
          PropertyInfo property = propertyInfo.Property;
          DefaultValueAttribute defaultValueAttribute = propertyInfo.DefaultValueAttribute;
          TypeSettings typeSettings = settings;
          object obj = property.GetValue((object) typeSettings, (object[]) null);
          if (defaultValueAttribute == null || (obj != null && (!(obj is string) || !((string) obj == string.Empty)) || defaultValueAttribute.Value != null && (!(defaultValueAttribute.Value is string) || !((string) defaultValueAttribute.Value == string.Empty))) && (obj == null || defaultValueAttribute.Value == null || !obj.Equals(defaultValueAttribute.Value)))
            dictionary[propertyInfo] = obj;
        }
        return dictionary;
      }

      public IEnumerable<TypeSettingsSerializer.DictionarySerializer.PropertyDescriptor> GetSerializedPropertyInfos() => (IEnumerable<TypeSettingsSerializer.DictionarySerializer.PropertyDescriptor>) this._propertyInfos;

      public void GetSerializationDescriptor(TypeSerializationDescriptor descriptor)
      {
        int num1 = 2;
        IEnumerator<TypeSettingsSerializer.DictionarySerializer.PropertyDescriptor> enumerator;
        TypeSerializationDescriptorBuilder descriptorBuilder;
        while (true)
        {
          switch (num1)
          {
            case 0:
              goto label_22;
            case 1:
              List<TypeSettingsSerializer.DictionarySerializer.PropertyDescriptor> propertyInfos = this._propertyInfos;
              // ISSUE: reference to a compiler-generated field
              Func<TypeSettingsSerializer.DictionarySerializer.PropertyDescriptor, bool> func = TypeSettingsSerializer.DictionarySerializer.\u003C\u003Ec.\u003C\u003E9__4_0;
              Func<TypeSettingsSerializer.DictionarySerializer.PropertyDescriptor, bool> predicate;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                TypeSettingsSerializer.DictionarySerializer.\u003C\u003Ec.\u003C\u003E9__4_0 = predicate = (Func<TypeSettingsSerializer.DictionarySerializer.PropertyDescriptor, bool>) (p1 => !TypeSettingsSerializer.DictionarySerializer.\u003C\u003Ec.TXIpSCZVeIVTEQqWtY0L((object) p1));
              }
              else
                goto label_4;
label_24:
              enumerator = propertyInfos.Where<TypeSettingsSerializer.DictionarySerializer.PropertyDescriptor>(predicate).GetEnumerator();
              num1 = 3;
              continue;
label_4:
              predicate = func;
              goto label_24;
            case 2:
              descriptorBuilder = new TypeSerializationDescriptorBuilder(descriptor);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 1 : 1;
              continue;
            case 3:
              goto label_2;
            default:
              goto label_17;
          }
        }
label_22:
        return;
label_17:
        return;
label_2:
        try
        {
label_7:
          if (enumerator.MoveNext())
            goto label_5;
          else
            goto label_8;
label_3:
          TypeSettingsSerializer.DictionarySerializer.PropertyDescriptor current;
          int num2;
          TypeSettingsSerializer.DictionarySerializer.PropertyDescriptor p1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                p1 = current;
                num2 = 2;
                continue;
              case 2:
                descriptorBuilder.ItemWithDescriptor((string) TypeSettingsSerializer.DictionarySerializer.nvNFJNCqgEgrBUrReZm2((object) current), (Action<TypeSerializationDescriptorBuilder>) (i =>
                {
                  int num3 = 2;
                  while (true)
                  {
                    int num4 = num3;
                    string str1;
                    string description;
                    string str2;
                    while (true)
                    {
                      switch (num4)
                      {
                        case 1:
                          if (p1.DefaultValueAttribute != null)
                          {
                            num4 = 12;
                            continue;
                          }
                          goto case 3;
                        case 2:
                          // ISSUE: reference to a compiler-generated method
                          i.Type(TypeSettingsSerializer.DictionarySerializer.\u003C\u003Ec__DisplayClass4_0.ncL4XlZV3d3fI1lUr86f((object) p1.Property));
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 1;
                          continue;
                        case 3:
                          str1 = (string) null;
                          num4 = 16;
                          continue;
                        case 4:
                        case 8:
                          // ISSUE: reference to a compiler-generated method
                          description = (string) TypeSettingsSerializer.DictionarySerializer.\u003C\u003Ec__DisplayClass4_0.HXKhUZZVa7QWESsrxpmD((object) p1.Property);
                          num4 = 6;
                          continue;
                        case 5:
                        case 10:
                        case 20:
                          // ISSUE: reference to a compiler-generated method
                          if (TypeSettingsSerializer.DictionarySerializer.\u003C\u003Ec__DisplayClass4_0.DmLf92ZVDQI4A0hsdvNO((object) str2))
                          {
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 13 : 2;
                            continue;
                          }
                          goto label_25;
                        case 6:
                          // ISSUE: reference to a compiler-generated method
                          if (TypeSettingsSerializer.DictionarySerializer.\u003C\u003Ec__DisplayClass4_0.DmLf92ZVDQI4A0hsdvNO((object) str1))
                          {
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
                            continue;
                          }
                          goto case 23;
                        case 7:
                          if (p1.DisplayNameAccessor != null)
                          {
                            num4 = 14;
                            continue;
                          }
                          goto case 18;
                        case 9:
                          goto label_30;
                        case 11:
                          description = str1;
                          num4 = 22;
                          continue;
                        case 12:
                          goto label_29;
                        case 13:
                        case 15:
                          i.Description(description);
                          num4 = 9;
                          continue;
                        case 14:
                          str1 = p1.DisplayNameAccessor();
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 17 : 18;
                          continue;
                        case 16:
                          str2 = (string) null;
                          num4 = 7;
                          continue;
                        case 17:
                          goto label_25;
                        case 18:
                          if (p1.DescriptionAccessor == null)
                          {
                            num4 = 4;
                            continue;
                          }
                          goto label_26;
                        case 19:
                          goto label_26;
                        case 21:
                          // ISSUE: reference to a compiler-generated method
                          description = (string) TypeSettingsSerializer.DictionarySerializer.\u003C\u003Ec__DisplayClass4_0.uwsrpxZVtTWqjtTXd53L((object) description, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1255365154 ^ 596875508 ^ -1766165982));
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 2 : 5;
                          continue;
                        case 22:
                          // ISSUE: reference to a compiler-generated method
                          if (TypeSettingsSerializer.DictionarySerializer.\u003C\u003Ec__DisplayClass4_0.DmLf92ZVDQI4A0hsdvNO((object) str2))
                          {
                            num4 = 20;
                            continue;
                          }
                          goto case 21;
                        case 23:
                          if (!string.IsNullOrEmpty(str1))
                            goto case 11;
                          else
                            goto label_4;
                        default:
                          if (!string.IsNullOrEmpty(str2))
                          {
                            num4 = 23;
                            continue;
                          }
                          goto case 13;
                      }
                    }
label_4:
                    num3 = 10;
                    continue;
label_25:
                    description += str2;
                    num3 = 15;
                    continue;
label_26:
                    str2 = p1.DescriptionAccessor();
                    num3 = 8;
                    continue;
label_29:
                    // ISSUE: reference to a compiler-generated method
                    i.Optional(TypeSettingsSerializer.DictionarySerializer.\u003C\u003Ec__DisplayClass4_0.L2ScUrZVp9D04Y3ehlVe((object) p1.DefaultValueAttribute));
                    num3 = 3;
                  }
label_30:;
                }));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
                continue;
              case 3:
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 1 : 1;
                continue;
              case 4:
                goto label_5;
              case 5:
                goto label_12;
              default:
                goto label_7;
            }
          }
label_12:
          return;
label_5:
          current = enumerator.Current;
          num2 = 3;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
          {
            num2 = 3;
            goto label_3;
          }
          else
            goto label_3;
label_8:
          num2 = 5;
          goto label_3;
        }
        finally
        {
          if (enumerator != null)
          {
            int num5 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
              num5 = 0;
            while (true)
            {
              switch (num5)
              {
                case 1:
                  goto label_19;
                default:
                  TypeSettingsSerializer.DictionarySerializer.PlIxyHCq50kHQGkEceOA((object) enumerator);
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 1 : 0;
                  continue;
              }
            }
          }
label_19:;
        }
      }

      internal static object kowmiaCqHLclv23h9VUY(Type type, BindingFlags bindingAttr) => (object) type.GetReflectionProperties(bindingAttr);

      internal static bool gg2EEcCqApfcsyAQHJxw([In] object obj0, [In] Type obj1, [In] bool obj2) => ((MemberInfo) obj0).IsDefined(obj1, obj2);

      internal static Type j1qraKCq7jotKW4KKEsx([In] object obj0) => ((MemberInfo) obj0).DeclaringType;

      internal static Type fZWLo5CqxcGTEIKNNY06([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

      internal static bool gl9HIUCq0KGfC3gKoJIU([In] Type obj0, [In] Type obj1) => obj0 == obj1;

      internal static object uhsuDLCqmwaBR8A34KUK([In] object obj0) => (object) ((MemberInfo) obj0).Name;

      internal static bool pyHu61CqyCiXjHGGuW9n([In] object obj0) => string.IsNullOrEmpty((string) obj0);

      internal static object B2agQaCqMuchhti6GlqX([In] object obj0) => (object) ((XmlAttributeAttribute) obj0).AttributeName;

      internal static object SD6XwACqJc75v0Ev379I([In] object obj0, [In] Type obj1, [In] bool obj2) => (object) ((MemberInfo) obj0).GetCustomAttributes(obj1, obj2);

      internal static void d67lSOCq9hrp17pabFgx([In] object obj0, [In] object obj1) => ((TypeSettingsSerializer.DictionarySerializer.PropertyDescriptor) obj0).Property = (PropertyInfo) obj1;

      internal static void NYxFlkCqd0y3W80osm1R([In] object obj0, [In] object obj1) => ((TypeSettingsSerializer.DictionarySerializer.PropertyDescriptor) obj0).Name = (string) obj1;

      internal static void fXkZIgCql1lubCuFxaK8([In] object obj0, Type value) => ((TypeSettingsSerializer.DictionarySerializer.PropertyDescriptor) obj0).Type = value;

      internal static void O4qeAbCqrZhNUn1Fw2sr([In] object obj0, bool value) => ((TypeSettingsSerializer.DictionarySerializer.PropertyDescriptor) obj0).JsonIgnore = value;

      internal static bool IM00W3Cq4GDMWVtrwIOR() => TypeSettingsSerializer.DictionarySerializer.ppMZ6JCqwLYHWFQds81s == null;

      internal static TypeSettingsSerializer.DictionarySerializer CBMyhhCq63AUHZ1vImHG() => (TypeSettingsSerializer.DictionarySerializer) TypeSettingsSerializer.DictionarySerializer.ppMZ6JCqwLYHWFQds81s;

      internal static object nvNFJNCqgEgrBUrReZm2([In] object obj0) => (object) ((TypeSettingsSerializer.DictionarySerializer.PropertyDescriptor) obj0).Name;

      internal static void PlIxyHCq50kHQGkEceOA([In] object obj0) => ((IDisposable) obj0).Dispose();

      public class PropertyDescriptor
      {
        internal static TypeSettingsSerializer.DictionarySerializer.PropertyDescriptor pllRRbZVCR6yFaCbsSf1;

        public PropertyInfo Property
        {
          get => this.\u003CProperty\u003Ek__BackingField;
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
                  this.\u003CProperty\u003Ek__BackingField = value;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
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

        public string Name
        {
          get => this.\u003CName\u003Ek__BackingField;
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
                  this.\u003CName\u003Ek__BackingField = value;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
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

        public Type Type
        {
          get => this.\u003CType\u003Ek__BackingField;
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
                  this.\u003CType\u003Ek__BackingField = value;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
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

        public DefaultValueAttribute DefaultValueAttribute
        {
          get => this.\u003CDefaultValueAttribute\u003Ek__BackingField;
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
                  this.\u003CDefaultValueAttribute\u003Ek__BackingField = value;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
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

        public bool JsonIgnore
        {
          get => this.\u003CJsonIgnore\u003Ek__BackingField;
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
                  this.\u003CJsonIgnore\u003Ek__BackingField = value;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
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

        public Func<string> DisplayNameAccessor { get; set; }

        public Func<string> DescriptionAccessor { get; set; }

        public PropertyDescriptor()
        {
          TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0)
            num = 0;
          switch (num)
          {
          }
        }

        internal static bool i7B9VBZVvW5NepoVhT5D() => TypeSettingsSerializer.DictionarySerializer.PropertyDescriptor.pllRRbZVCR6yFaCbsSf1 == null;

        internal static TypeSettingsSerializer.DictionarySerializer.PropertyDescriptor TVIi49ZV8Rj7CgmxiK6i() => TypeSettingsSerializer.DictionarySerializer.PropertyDescriptor.pllRRbZVCR6yFaCbsSf1;
      }
    }
  }
}
