using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Serialization;

internal sealed class XmlContractResolver : DefaultContractResolver
{
	private static readonly ConcurrentDictionary<Type, JsonContract> contracts;

	internal static XmlContractResolver HSy4QRB9JPBrjpsUMA2a;

	protected override JsonContract CreateContract(Type objectType)
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return contracts.GetOrAdd(_003C_003Ec__DisplayClass1_.objectType, (Func<Type, JsonContract>)_003C_003Ec__DisplayClass1_._003CCreateContract_003Eb__0);
			case 2:
				_003C_003Ec__DisplayClass1_.objectType = objectType;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass1_._003C_003E4__this = this;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((DefaultContractResolver)this).CreateProperties(type, RemoveDataContractAttributeMemberSerialization(type, memberSerialization));
	}

	protected override JsonObjectContract CreateObjectContract(Type objectType)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num2 = num;
		JsonObjectContract val = default(JsonObjectContract);
		while (true)
		{
			switch (num2)
			{
			default:
				YTXB7LB9gTX1DA6GMavv(val, RemoveDataContractAttributeMemberSerialization(objectType, LMTngRB9rEbO41Wyr4Mb(val)));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return val;
			case 1:
				val = (JsonObjectContract)ObAH1SB9lI4yyWpKVjIo(this, objectType);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num2 = num;
		JsonProperty val = default(JsonProperty);
		while (true)
		{
			switch (num2)
			{
			default:
				ConfigureProperty(member, val);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return val;
			case 1:
				val = (JsonProperty)CptCHQB95dcoDiFyQWKM(this, member, memberSerialization);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void ConfigureProperty(MemberInfo member, JsonProperty property)
	{
		//Discarded unreachable code: IL_01ef, IL_01fe, IL_02c8, IL_02d7, IL_0347, IL_0378, IL_0387, IL_0396, IL_0414, IL_0423
		int num = 29;
		_003C_003Ec__DisplayClass5_2 _003C_003Ec__DisplayClass5_3 = default(_003C_003Ec__DisplayClass5_2);
		XmlElementAttribute attribute = default(XmlElementAttribute);
		_003C_003Ec__DisplayClass5_1 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_1);
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_2 = default(_003C_003Ec__DisplayClass5_0);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 18:
					if (AttributeHelper<XmlForceElementAttribute>.GetAttribute(member, inherited: true) != null)
					{
						num2 = 31;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
						{
							num2 = 37;
						}
						continue;
					}
					goto case 4;
				case 13:
					VB38cQB9YdMnXkXBD4y6(property, true);
					num2 = 36;
					continue;
				case 30:
					if (!(_003C_003Ec__DisplayClass5_3.specifiedProperty != null))
					{
						num2 = 25;
						continue;
					}
					goto case 24;
				case 2:
					if (attribute != null)
					{
						num = 31;
						break;
					}
					goto case 22;
				case 17:
					throw new InvalidOperationException(SR.T((string)D53Hn6BdbYMfRUtGkTdQ(0x12A5FAC7 ^ 0x12A48BAD), FAqFH5BdFyO6VHdZ0TKq(_003C_003Ec__DisplayClass5_.specifiedField), typeof(bool).FullName));
				case 34:
					if (N5u6rUBdQGRR9xlRWFPV(_003C_003Ec__DisplayClass5_.specifiedField))
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num2 = 6;
						}
						continue;
					}
					return;
				case 1:
					if (NX33GDBdo6QjrQiIx8d1(g7dqHUBdWyqHOGDtnCkC(_003C_003Ec__DisplayClass5_2.shouldSerializeMethodInfo), typeof(bool)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						property.set_ShouldSerialize((Predicate<object>)_003C_003Ec__DisplayClass5_2._003CConfigureProperty_003Eb__0);
						num2 = 21;
					}
					continue;
				case 15:
					VB38cQB9YdMnXkXBD4y6(property, true);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num2 = 7;
					}
					continue;
				case 19:
					throw new InvalidOperationException(SR.T((string)D53Hn6BdbYMfRUtGkTdQ(-475857671 ^ -475820753), FAqFH5BdFyO6VHdZ0TKq(_003C_003Ec__DisplayClass5_3.specifiedProperty), IuHIenBdhjj2A0hpxHOD(typeof(bool).TypeHandle).FullName));
				case 22:
				case 26:
					_003C_003Ec__DisplayClass5_2.shouldSerializeMethodInfo = (MethodInfo)d5bcpyBdB3vU40J44Doo(UTG0gGB9zBXr0ZR1DWm9(member), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63ABA4E8 ^ 0x63AAD42C) + (string)FAqFH5BdFyO6VHdZ0TKq(member), new Type[0]);
					num2 = 5;
					continue;
				case 3:
					return;
				case 12:
				case 37:
					attribute = AttributeHelper<XmlElementAttribute>.GetAttribute(member, inherited: true);
					num2 = 2;
					continue;
				default:
					throw new InvalidOperationException(SR.T((string)D53Hn6BdbYMfRUtGkTdQ(-289714582 ^ -289784180), FAqFH5BdFyO6VHdZ0TKq(_003C_003Ec__DisplayClass5_2.shouldSerializeMethodInfo), IuHIenBdhjj2A0hpxHOD(typeof(bool).TypeHandle).FullName));
				case 25:
					return;
				case 10:
					return;
				case 6:
					property.set_ShouldSerialize((Predicate<object>)_003C_003Ec__DisplayClass5_._003CConfigureProperty_003Eb__1);
					num2 = 33;
					continue;
				case 28:
					if (!ePaQMRB9jRM4dCcSqtb6(property))
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
						{
							num2 = 15;
						}
						continue;
					}
					if (AttributeHelper<XmlIgnoreAttribute>.GetAttribute(member, inherited: true) == null)
					{
						if (AttributeHelper<ObsoleteAttribute>.GetAttribute(member, inherited: true) == null)
						{
							num2 = 12;
							continue;
						}
						goto case 18;
					}
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 13;
					}
					continue;
				case 33:
					return;
				case 20:
					_003C_003Ec__DisplayClass5_3 = new _003C_003Ec__DisplayClass5_2();
					num2 = 23;
					continue;
				case 32:
					_003C_003Ec__DisplayClass5_.specifiedField = UTG0gGB9zBXr0ZR1DWm9(member).GetField((string)q4S1FRBdGfN5mILLNDeI(member.Name, D53Hn6BdbYMfRUtGkTdQ(-1822890472 ^ -1822845108)));
					num2 = 35;
					continue;
				case 16:
					text = (string)cB8Y89B9LOQIt3GoVUH4(attribute);
					num = 14;
					break;
				case 4:
					VB38cQB9YdMnXkXBD4y6(property, true);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 1;
					}
					continue;
				case 35:
					if (!oldIV5BdETRIdNwrolLt(_003C_003Ec__DisplayClass5_.specifiedField, null))
					{
						num2 = 20;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 9;
				case 29:
					_003C_003Ec__DisplayClass5_2 = new _003C_003Ec__DisplayClass5_0();
					num = 28;
					break;
				case 14:
					if (zP7BWiB9sXJloSXCDP3U(text))
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
						{
							num2 = 22;
						}
						continue;
					}
					goto case 27;
				case 36:
					return;
				case 31:
					if ((string)cB8Y89B9LOQIt3GoVUH4(attribute) != (string)yFqhcfB9Ur4ixdZv5sXc(property))
					{
						num2 = 16;
						continue;
					}
					goto case 22;
				case 27:
					aH5q4DB9cjiBolqWmWvW(property, text);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 26;
					}
					continue;
				case 24:
					if (!NX33GDBdo6QjrQiIx8d1(YyCjIUBdvpFc8UtM0saU(_003C_003Ec__DisplayClass5_3.specifiedProperty), IuHIenBdhjj2A0hpxHOD(typeof(bool).TypeHandle)))
					{
						if (!jmN09RBd8PVEDf1GDXvY(_003C_003Ec__DisplayClass5_3.specifiedProperty))
						{
							return;
						}
						num2 = 11;
					}
					else
					{
						num2 = 19;
					}
					continue;
				case 9:
					if (!NX33GDBdo6QjrQiIx8d1(VGfUDsBdfhTULVhRJ2X3(_003C_003Ec__DisplayClass5_.specifiedField), IuHIenBdhjj2A0hpxHOD(typeof(bool).TypeHandle)))
					{
						num2 = 34;
						continue;
					}
					goto case 17;
				case 11:
					property.set_ShouldSerialize((Predicate<object>)_003C_003Ec__DisplayClass5_3._003CConfigureProperty_003Eb__2);
					num2 = 10;
					continue;
				case 23:
					_003C_003Ec__DisplayClass5_3.specifiedProperty = (PropertyInfo)CpFd1mBdCDN6sJXrZLyA(member.DeclaringType, q4S1FRBdGfN5mILLNDeI(FAqFH5BdFyO6VHdZ0TKq(member), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C9495B4 ^ 0x1C95E4E0)));
					num2 = 30;
					continue;
				case 7:
					return;
				case 5:
					if (!(_003C_003Ec__DisplayClass5_2.shouldSerializeMethodInfo != null))
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 1;
				case 21:
					return;
				case 8:
					_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_1();
					num = 32;
					break;
				}
				break;
			}
		}
	}

	private static MemberSerialization RemoveDataContractAttributeMemberSerialization(Type type, MemberSerialization memberSerialization)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Invalid comparison between Unknown and I4
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		int num = 3;
		int num2 = num;
		while (true)
		{
			Type type2;
			switch (num2)
			{
			case 3:
				if ((int)memberSerialization != 1)
				{
					num2 = 2;
					break;
				}
				type2 = XCUMgOBdZ97RKTnoXJOg(type);
				if ((object)type2 != null)
				{
					goto IL_00a1;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 5;
				}
				break;
			default:
				return memberSerialization;
			case 6:
				return memberSerialization;
			case 4:
				return memberSerialization;
			case 2:
				return memberSerialization;
			case 5:
				type2 = type;
				goto IL_00a1;
			case 1:
				{
					if (type.SelfAndBaseTypes().Any((Type t) => AttributeHelper<DataContractAttribute>.GetAttribute(t, inherited: true) != null))
					{
						if (AttributeHelper<JsonObjectAttribute>.GetAttribute(type, inherited: true) != null)
						{
							num2 = 4;
							break;
						}
						memberSerialization = (MemberSerialization)0;
						num2 = 6;
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
						{
							num2 = 0;
						}
					}
					break;
				}
				IL_00a1:
				type = type2;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public XmlContractResolver()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		S4mvKNBduJIN4JxDMaG2();
		((DefaultContractResolver)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static XmlContractResolver()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				S4mvKNBduJIN4JxDMaG2();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				contracts = new ConcurrentDictionary<Type, JsonContract>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool ptG9FNB99fxb6JDaoU55()
	{
		return HSy4QRB9JPBrjpsUMA2a == null;
	}

	internal static XmlContractResolver RD3TjgB9dh5IjTCyN0Cn()
	{
		return HSy4QRB9JPBrjpsUMA2a;
	}

	internal static object ObAH1SB9lI4yyWpKVjIo(object P_0, Type P_1)
	{
		return ((DefaultContractResolver)P_0).CreateObjectContract(P_1);
	}

	internal static MemberSerialization LMTngRB9rEbO41Wyr4Mb(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((JsonObjectContract)P_0).get_MemberSerialization();
	}

	internal static void YTXB7LB9gTX1DA6GMavv(object P_0, MemberSerialization P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((JsonObjectContract)P_0).set_MemberSerialization(P_1);
	}

	internal static object CptCHQB95dcoDiFyQWKM(object P_0, object P_1, MemberSerialization P_2)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return ((DefaultContractResolver)P_0).CreateProperty((MemberInfo)P_1, P_2);
	}

	internal static bool ePaQMRB9jRM4dCcSqtb6(object P_0)
	{
		return ((JsonProperty)P_0).get_Readable();
	}

	internal static void VB38cQB9YdMnXkXBD4y6(object P_0, bool P_1)
	{
		((JsonProperty)P_0).set_Ignored(P_1);
	}

	internal static object cB8Y89B9LOQIt3GoVUH4(object P_0)
	{
		return ((XmlElementAttribute)P_0).ElementName;
	}

	internal static object yFqhcfB9Ur4ixdZv5sXc(object P_0)
	{
		return ((JsonProperty)P_0).get_PropertyName();
	}

	internal static bool zP7BWiB9sXJloSXCDP3U(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static void aH5q4DB9cjiBolqWmWvW(object P_0, object P_1)
	{
		((JsonProperty)P_0).set_PropertyName((string)P_1);
	}

	internal static Type UTG0gGB9zBXr0ZR1DWm9(object P_0)
	{
		return ((MemberInfo)P_0).DeclaringType;
	}

	internal static object FAqFH5BdFyO6VHdZ0TKq(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static object d5bcpyBdB3vU40J44Doo(Type type, object P_1, object P_2)
	{
		return type.GetReflectionMethod((string)P_1, (Type[])P_2);
	}

	internal static Type g7dqHUBdWyqHOGDtnCkC(object P_0)
	{
		return ((MethodInfo)P_0).ReturnType;
	}

	internal static bool NX33GDBdo6QjrQiIx8d1(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object D53Hn6BdbYMfRUtGkTdQ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type IuHIenBdhjj2A0hpxHOD(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object q4S1FRBdGfN5mILLNDeI(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool oldIV5BdETRIdNwrolLt(object P_0, object P_1)
	{
		return (FieldInfo)P_0 != (FieldInfo)P_1;
	}

	internal static Type VGfUDsBdfhTULVhRJ2X3(object P_0)
	{
		return ((FieldInfo)P_0).FieldType;
	}

	internal static bool N5u6rUBdQGRR9xlRWFPV(object P_0)
	{
		return ((FieldInfo)P_0).IsInitOnly;
	}

	internal static object CpFd1mBdCDN6sJXrZLyA(Type type, object P_1)
	{
		return type.GetReflectionProperty((string)P_1);
	}

	internal static Type YyCjIUBdvpFc8UtM0saU(object P_0)
	{
		return ((PropertyInfo)P_0).PropertyType;
	}

	internal static bool jmN09RBd8PVEDf1GDXvY(object P_0)
	{
		return ((PropertyInfo)P_0).CanWrite;
	}

	internal static Type XCUMgOBdZ97RKTnoXJOg(Type P_0)
	{
		return Nullable.GetUnderlyingType(P_0);
	}

	internal static void S4mvKNBduJIN4JxDMaG2()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object wcrEjZBdIX180wTFuUcV(object P_0, Type P_1)
	{
		return ((DefaultContractResolver)P_0).CreateContract(P_1);
	}
}
