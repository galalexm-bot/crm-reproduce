// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Serialization.XmlContractResolver
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Serialization
{
  /// <summary>Резолвер для объектов с атрибутами Xml</summary>
  internal sealed class XmlContractResolver : DefaultContractResolver
  {
    private static readonly ConcurrentDictionary<Type, JsonContract> contracts;
    internal static XmlContractResolver HSy4QRB9JPBrjpsUMA2a;

    protected override JsonContract CreateContract(Type objectType)
    {
      int num1 = 3;
      Type objectType1;
      XmlContractResolver contractResolver;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            objectType1 = objectType;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
            continue;
          case 3:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 2 : 0;
            continue;
          default:
            contractResolver = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 1 : 0;
            continue;
        }
      }
label_2:
      return XmlContractResolver.contracts.GetOrAdd(objectType1, (Func<Type, JsonContract>) (objType =>
      {
        int num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!TypeOf<IXsiType>.Raw.IsAssignableFrom(objectType1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
                continue;
              }
              if (!TypeOf<IEnumerable>.Raw.IsAssignableFrom(objType))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 2 : 2;
                continue;
              }
              goto label_4;
            case 2:
              goto label_5;
            case 3:
              goto label_4;
            default:
              goto label_6;
          }
        }
label_4:
        // ISSUE: reference to a compiler-generated method
        return (JsonContract) XmlContractResolver.\u003C\u003Ec__DisplayClass1_0.LTmOS6Q2EIQcujutllmZ((object) contractResolver, objType);
label_5:
        // ISSUE: reference to a compiler-generated method
        return (JsonContract) XmlContractResolver.\u003C\u003Ec__DisplayClass1_0.PKpfJCQ2fZ6V8G507b3h((object) contractResolver, objType);
label_6:
        // ISSUE: reference to a compiler-generated method
        return contractResolver.\u003C\u003En__0(objectType1);
      }));
    }

    protected override IList<JsonProperty> CreateProperties(
      Type type,
      MemberSerialization memberSerialization)
    {
      return base.CreateProperties(type, XmlContractResolver.RemoveDataContractAttributeMemberSerialization(type, memberSerialization));
    }

    protected override JsonObjectContract CreateObjectContract(Type objectType)
    {
      int num = 1;
      JsonObjectContract objectContract;
      while (true)
      {
        switch (num)
        {
          case 1:
            objectContract = (JsonObjectContract) XmlContractResolver.ObAH1SB9lI4yyWpKVjIo((object) this, objectType);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            XmlContractResolver.YTXB7LB9gTX1DA6GMavv((object) objectContract, XmlContractResolver.RemoveDataContractAttributeMemberSerialization(objectType, XmlContractResolver.LMTngRB9rEbO41Wyr4Mb((object) objectContract)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 2;
            continue;
        }
      }
label_3:
      return objectContract;
    }

    protected override JsonProperty CreateProperty(
      MemberInfo member,
      MemberSerialization memberSerialization)
    {
      int num = 1;
      JsonProperty property;
      while (true)
      {
        switch (num)
        {
          case 1:
            property = (JsonProperty) XmlContractResolver.CptCHQB95dcoDiFyQWKM((object) this, (object) member, memberSerialization);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.ConfigureProperty(member, property);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 2 : 1;
            continue;
        }
      }
label_3:
      return property;
    }

    /// <summary>Подготовить свойство для сериализации</summary>
    /// <param name="member">Метаданные свойства/поля/метода</param>
    /// <param name="property">Свойство Json, которое необходимо подготовить</param>
    private void ConfigureProperty(MemberInfo member, JsonProperty property)
    {
      int num1 = 29;
      PropertyInfo specifiedProperty;
      MethodInfo shouldSerializeMethodInfo;
      FieldInfo specifiedField;
      while (true)
      {
        int num2 = num1;
        XmlElementAttribute attribute;
        string str;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (XmlContractResolver.NX33GDBdo6QjrQiIx8d1(XmlContractResolver.g7dqHUBdWyqHOGDtnCkC((object) shouldSerializeMethodInfo), typeof (bool)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
                continue;
              }
              // ISSUE: reference to a compiler-generated method
              property.ShouldSerialize = (Predicate<object>) (e => (bool) XmlContractResolver.\u003C\u003Ec__DisplayClass5_0.WsnuBWQ2ZKabW1PA3GYr((object) shouldSerializeMethodInfo, e, (object) new object[0]));
              num2 = 21;
              continue;
            case 2:
              if (attribute == null)
                goto case 22;
              else
                goto label_9;
            case 3:
              goto label_34;
            case 4:
              XmlContractResolver.VB38cQB9YdMnXkXBD4y6((object) property, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 3 : 1;
              continue;
            case 5:
              if (!(shouldSerializeMethodInfo != (MethodInfo) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 8 : 8;
                continue;
              }
              goto case 1;
            case 6:
              // ISSUE: reference to a compiler-generated method
              property.ShouldSerialize = (Predicate<object>) (e => (bool) XmlContractResolver.\u003C\u003Ec__DisplayClass5_1.dEDnGxQ2iUbVK7cr7IBM((object) specifiedField, e));
              num2 = 33;
              continue;
            case 7:
              goto label_42;
            case 8:
              goto label_59;
            case 9:
              // ISSUE: type reference
              if (!XmlContractResolver.NX33GDBdo6QjrQiIx8d1(XmlContractResolver.VGfUDsBdfhTULVhRJ2X3((object) specifiedField), XmlContractResolver.IuHIenBdhjj2A0hpxHOD(__typeref (bool))))
              {
                num2 = 34;
                continue;
              }
              goto label_10;
            case 10:
              goto label_20;
            case 11:
              // ISSUE: reference to a compiler-generated method
              property.ShouldSerialize = (Predicate<object>) (e => (bool) XmlContractResolver.\u003C\u003Ec__DisplayClass5_2.TlGEWOQ2T9GtbaLlS8rL((object) specifiedProperty, e));
              num2 = 10;
              continue;
            case 12:
            case 37:
              attribute = AttributeHelper<XmlElementAttribute>.GetAttribute(member, true);
              num2 = 2;
              continue;
            case 13:
              XmlContractResolver.VB38cQB9YdMnXkXBD4y6((object) property, true);
              num2 = 36;
              continue;
            case 14:
              if (XmlContractResolver.zP7BWiB9sXJloSXCDP3U((object) str))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 6 : 22;
                continue;
              }
              goto case 27;
            case 15:
              XmlContractResolver.VB38cQB9YdMnXkXBD4y6((object) property, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 7 : 7;
              continue;
            case 16:
              goto label_35;
            case 17:
              goto label_10;
            case 18:
              if (AttributeHelper<XmlForceElementAttribute>.GetAttribute(member, true) != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 31 : 37;
                continue;
              }
              goto case 4;
            case 19:
              goto label_16;
            case 20:
              num2 = 23;
              continue;
            case 21:
              goto label_54;
            case 22:
            case 26:
              shouldSerializeMethodInfo = (MethodInfo) XmlContractResolver.d5bcpyBdB3vU40J44Doo(XmlContractResolver.UTG0gGB9zBXr0ZR1DWm9((object) member), (object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(1819636893 << 3 ^ 1672139820) + (string) XmlContractResolver.FAqFH5BdFyO6VHdZ0TKq((object) member)), (object) new Type[0]);
              num2 = 5;
              continue;
            case 23:
              specifiedProperty = (PropertyInfo) XmlContractResolver.CpFd1mBdCDN6sJXrZLyA(member.DeclaringType, XmlContractResolver.q4S1FRBdGfN5mILLNDeI(XmlContractResolver.FAqFH5BdFyO6VHdZ0TKq((object) member), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917998801 >> 2 ^ 479585504)));
              num2 = 30;
              continue;
            case 24:
              // ISSUE: type reference
              if (!XmlContractResolver.NX33GDBdo6QjrQiIx8d1(XmlContractResolver.YyCjIUBdvpFc8UtM0saU((object) specifiedProperty), XmlContractResolver.IuHIenBdhjj2A0hpxHOD(__typeref (bool))))
              {
                if (XmlContractResolver.jmN09RBd8PVEDf1GDXvY((object) specifiedProperty))
                {
                  num2 = 11;
                  continue;
                }
                goto label_27;
              }
              else
              {
                num2 = 19;
                continue;
              }
            case 25:
              goto label_26;
            case 27:
              XmlContractResolver.aH5q4DB9cjiBolqWmWvW((object) property, (object) str);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 4 : 26;
              continue;
            case 28:
              if (!XmlContractResolver.ePaQMRB9jRM4dCcSqtb6((object) property))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 5 : 15;
                continue;
              }
              if (AttributeHelper<XmlIgnoreAttribute>.GetAttribute(member, true) == null)
              {
                if (AttributeHelper<ObsoleteAttribute>.GetAttribute(member, true) == null)
                {
                  num2 = 12;
                  continue;
                }
                goto case 18;
              }
              else
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 2 : 13;
                continue;
              }
            case 29:
              goto label_39;
            case 30:
              if (!(specifiedProperty != (PropertyInfo) null))
              {
                num2 = 25;
                continue;
              }
              goto case 24;
            case 31:
              if ((string) XmlContractResolver.cB8Y89B9LOQIt3GoVUH4((object) attribute) != (string) XmlContractResolver.yFqhcfB9Ur4ixdZv5sXc((object) property))
              {
                num2 = 16;
                continue;
              }
              goto case 22;
            case 32:
              specifiedField = XmlContractResolver.UTG0gGB9zBXr0ZR1DWm9((object) member).GetField((string) XmlContractResolver.q4S1FRBdGfN5mILLNDeI((object) member.Name, XmlContractResolver.D53Hn6BdbYMfRUtGkTdQ(-1822890472 ^ -1822845108)));
              num2 = 35;
              continue;
            case 33:
              goto label_24;
            case 34:
              if (XmlContractResolver.N5u6rUBdQGRR9xlRWFPV((object) specifiedField))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 6 : 6;
                continue;
              }
              goto label_33;
            case 35:
              if (!XmlContractResolver.oldIV5BdETRIdNwrolLt((object) specifiedField, (object) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 20 : 1;
                continue;
              }
              goto case 9;
            case 36:
              goto label_30;
            default:
              goto label_22;
          }
        }
label_9:
        num1 = 31;
        continue;
label_35:
        str = (string) XmlContractResolver.cB8Y89B9LOQIt3GoVUH4((object) attribute);
        num1 = 14;
        continue;
label_39:
        num1 = 28;
        continue;
label_59:
        num1 = 32;
      }
label_34:
      return;
label_42:
      return;
label_20:
      return;
label_54:
      return;
label_26:
      return;
label_24:
      return;
label_30:
      return;
label_10:
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) XmlContractResolver.D53Hn6BdbYMfRUtGkTdQ(1251470110 >> 2 ^ 312773549), XmlContractResolver.FAqFH5BdFyO6VHdZ0TKq((object) specifiedField), (object) typeof (bool).FullName));
label_33:
      return;
label_16:
      // ISSUE: type reference
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) XmlContractResolver.D53Hn6BdbYMfRUtGkTdQ(1505778440 - 1981636111 ^ -475820753), XmlContractResolver.FAqFH5BdFyO6VHdZ0TKq((object) specifiedProperty), (object) XmlContractResolver.IuHIenBdhjj2A0hpxHOD(__typeref (bool)).FullName));
label_27:
      return;
label_22:
      // ISSUE: type reference
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) XmlContractResolver.D53Hn6BdbYMfRUtGkTdQ(~289714581 ^ -289784180), XmlContractResolver.FAqFH5BdFyO6VHdZ0TKq((object) shouldSerializeMethodInfo), (object) XmlContractResolver.IuHIenBdhjj2A0hpxHOD(__typeref (bool)).FullName));
    }

    /// <summary>
    /// Метод переписывает <see cref="F:Newtonsoft.Json.MemberSerialization.OptIn" /> на <see cref="F:Newtonsoft.Json.MemberSerialization.OptOut" />, если класс был отмечен <see cref="T:System.Runtime.Serialization.DataContractAttribute" />
    /// </summary>
    /// <remarks>
    /// По умолчанию, если сериализатор встречает в классе атрибуты <see cref="T:System.Runtime.Serialization.DataContractAttribute" /> он будет сериализовать исключительно такие свойства.
    /// Метод переопределяет <see cref="T:Newtonsoft.Json.MemberSerialization" /> для сериализатора.
    /// </remarks>
    /// <param name="type">Тип</param>
    /// <param name="memberSerialization">Текущий <see cref="T:Newtonsoft.Json.MemberSerialization" /> для <see cref="T:Newtonsoft.Json.Serialization.JsonObjectContract" /></param>
    /// <returns>Новый <see cref="T:Newtonsoft.Json.MemberSerialization" />, если он был <see cref="F:Newtonsoft.Json.MemberSerialization.OptIn" /> и тип был отмечен атрибутом  <see cref="T:System.Runtime.Serialization.DataContractAttribute" /> </returns>
    private static MemberSerialization RemoveDataContractAttributeMemberSerialization(
      Type type,
      MemberSerialization memberSerialization)
    {
      int num = 3;
      while (true)
      {
        Type type1;
        switch (num)
        {
          case 1:
            if (type.SelfAndBaseTypes().Any<Type>((Func<Type, bool>) (t => AttributeHelper<DataContractAttribute>.GetAttribute(t, true) != null)))
            {
              if (AttributeHelper<JsonObjectAttribute>.GetAttribute(type, true) != null)
              {
                num = 4;
                continue;
              }
              memberSerialization = MemberSerialization.OptOut;
              num = 6;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_10;
          case 3:
            if (memberSerialization != MemberSerialization.OptIn)
            {
              num = 2;
              continue;
            }
            type1 = XmlContractResolver.XCUMgOBdZ97RKTnoXJOg(type);
            if ((object) type1 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 1 : 5;
              continue;
            }
            break;
          case 4:
            goto label_8;
          case 5:
            type1 = type;
            break;
          case 6:
            goto label_7;
          default:
            goto label_4;
        }
        type = type1;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 1 : 1;
      }
label_4:
      return memberSerialization;
label_7:
      return memberSerialization;
label_8:
      return memberSerialization;
label_10:
      return memberSerialization;
    }

    public XmlContractResolver()
    {
      XmlContractResolver.S4mvKNBduJIN4JxDMaG2();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static XmlContractResolver()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            XmlContractResolver.contracts = new ConcurrentDictionary<Type, JsonContract>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
            continue;
          case 2:
            XmlContractResolver.S4mvKNBduJIN4JxDMaG2();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool ptG9FNB99fxb6JDaoU55() => XmlContractResolver.HSy4QRB9JPBrjpsUMA2a == null;

    internal static XmlContractResolver RD3TjgB9dh5IjTCyN0Cn() => XmlContractResolver.HSy4QRB9JPBrjpsUMA2a;

    internal static object ObAH1SB9lI4yyWpKVjIo([In] object obj0, [In] Type obj1) => (object) __nonvirtual (((DefaultContractResolver) obj0).CreateObjectContract(obj1));

    internal static MemberSerialization LMTngRB9rEbO41Wyr4Mb([In] object obj0) => ((JsonObjectContract) obj0).MemberSerialization;

    internal static void YTXB7LB9gTX1DA6GMavv([In] object obj0, [In] MemberSerialization obj1) => ((JsonObjectContract) obj0).MemberSerialization = obj1;

    internal static object CptCHQB95dcoDiFyQWKM([In] object obj0, [In] object obj1, [In] MemberSerialization obj2) => (object) __nonvirtual (((DefaultContractResolver) obj0).CreateProperty((MemberInfo) obj1, obj2));

    internal static bool ePaQMRB9jRM4dCcSqtb6([In] object obj0) => ((JsonProperty) obj0).Readable;

    internal static void VB38cQB9YdMnXkXBD4y6([In] object obj0, [In] bool obj1) => ((JsonProperty) obj0).Ignored = obj1;

    internal static object cB8Y89B9LOQIt3GoVUH4([In] object obj0) => (object) ((XmlElementAttribute) obj0).ElementName;

    internal static object yFqhcfB9Ur4ixdZv5sXc([In] object obj0) => (object) ((JsonProperty) obj0).PropertyName;

    internal static bool zP7BWiB9sXJloSXCDP3U([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static void aH5q4DB9cjiBolqWmWvW([In] object obj0, [In] object obj1) => ((JsonProperty) obj0).PropertyName = (string) obj1;

    internal static Type UTG0gGB9zBXr0ZR1DWm9([In] object obj0) => ((MemberInfo) obj0).DeclaringType;

    internal static object FAqFH5BdFyO6VHdZ0TKq([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static object d5bcpyBdB3vU40J44Doo(Type type, [In] object obj1, [In] object obj2) => (object) type.GetReflectionMethod((string) obj1, (Type[]) obj2);

    internal static Type g7dqHUBdWyqHOGDtnCkC([In] object obj0) => ((MethodInfo) obj0).ReturnType;

    internal static bool NX33GDBdo6QjrQiIx8d1([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static object D53Hn6BdbYMfRUtGkTdQ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Type IuHIenBdhjj2A0hpxHOD([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object q4S1FRBdGfN5mILLNDeI([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static bool oldIV5BdETRIdNwrolLt([In] object obj0, [In] object obj1) => (FieldInfo) obj0 != (FieldInfo) obj1;

    internal static Type VGfUDsBdfhTULVhRJ2X3([In] object obj0) => ((FieldInfo) obj0).FieldType;

    internal static bool N5u6rUBdQGRR9xlRWFPV([In] object obj0) => ((FieldInfo) obj0).IsInitOnly;

    internal static object CpFd1mBdCDN6sJXrZLyA(Type type, [In] object obj1) => (object) type.GetReflectionProperty((string) obj1);

    internal static Type YyCjIUBdvpFc8UtM0saU([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

    internal static bool jmN09RBd8PVEDf1GDXvY([In] object obj0) => ((PropertyInfo) obj0).CanWrite;

    internal static Type XCUMgOBdZ97RKTnoXJOg([In] Type obj0) => Nullable.GetUnderlyingType(obj0);

    internal static void S4mvKNBduJIN4JxDMaG2() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object wcrEjZBdIX180wTFuUcV([In] object obj0, [In] Type obj1) => (object) __nonvirtual (((DefaultContractResolver) obj0).CreateContract(obj1));
  }
}
