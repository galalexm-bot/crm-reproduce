using System;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Extensions.QueryFunctionResults;

[Component]
public class EnumTypeConvertion : IQueryTypeConvertion
{
	internal static EnumTypeConvertion SY1p6uGJFiQfI7hvBeHu;

	public bool AvailableConvert(EntityMetadata metadata, string propName, Type valueType)
	{
		//Discarded unreachable code: IL_004c, IL_00ae, IL_012c
		int num = 7;
		int num2 = num;
		PropertyInfo propertyInfo = default(PropertyInfo);
		Type type = default(Type);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 4:
				obj = OCaP0PGJEXgohYldv6A9(propertyInfo);
				break;
			case 2:
				if (!CkDir2GJhBg9koiiZ8MR(propertyInfo, null))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				obj = null;
				break;
			case 1:
				if (!kcG7uYGJG9lC9iBl6yVl(propertyInfo.PropertyType))
				{
					num2 = 4;
					continue;
				}
				obj = HDydoCGJfsVGCgDIIqyc(OCaP0PGJEXgohYldv6A9(propertyInfo));
				break;
			default:
				return typeof(EnumBase).IsAssignableFrom(type);
			case 7:
				if (rKN5bZGJougHDWwDIa9A(typeof(string).TypeHandle).IsAssignableFrom(valueType))
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 6;
					}
					continue;
				}
				goto case 3;
			case 5:
				if (rKN5bZGJougHDWwDIa9A(typeof(Enum).TypeHandle).IsAssignableFrom(type))
				{
					return true;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 0;
				}
				continue;
			case 8:
				if (!KIklu8GJQTvpNVKHfV81(type, null))
				{
					return false;
				}
				num2 = 5;
				continue;
			case 3:
				return false;
			case 6:
				propertyInfo = (PropertyInfo)DrCg9KGJbikmB16M6emy(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(metadata.Uid), propName);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 2;
				}
				continue;
			}
			type = (Type)obj;
			num2 = 8;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
			{
				num2 = 0;
			}
		}
	}

	public object ConvertValue(EntityMetadata metadata, string propName, object value)
	{
		return Locator.GetServiceNotNull<EnumQueryResult>().GetValue(metadata, propName, new object[1] { value });
	}

	public EnumTypeConvertion()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Ff8gCcGJCbDGeXWihKW2();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type rKN5bZGJougHDWwDIa9A(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object DrCg9KGJbikmB16M6emy(Type type, object P_1)
	{
		return type.GetReflectionProperty((string)P_1);
	}

	internal static bool CkDir2GJhBg9koiiZ8MR(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static bool kcG7uYGJG9lC9iBl6yVl(Type type)
	{
		return type.IsNullableType();
	}

	internal static Type OCaP0PGJEXgohYldv6A9(object P_0)
	{
		return ((PropertyInfo)P_0).PropertyType;
	}

	internal static Type HDydoCGJfsVGCgDIIqyc(Type type)
	{
		return type.GetNonNullableType();
	}

	internal static bool KIklu8GJQTvpNVKHfV81(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static bool re8d7aGJB9lWddDesN8m()
	{
		return SY1p6uGJFiQfI7hvBeHu == null;
	}

	internal static EnumTypeConvertion I7PYAlGJWSpLocv9HSTh()
	{
		return SY1p6uGJFiQfI7hvBeHu;
	}

	internal static void Ff8gCcGJCbDGeXWihKW2()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
