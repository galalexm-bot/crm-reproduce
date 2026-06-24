using System;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Extensions.QueryFunctionResults;

[Component]
public class UriTypeConvertion : IQueryTypeConvertion
{
	internal static UriTypeConvertion pBvXuPGMFMILBUgHSt7y;

	public bool AvailableConvert(EntityMetadata metadata, string propName, Type valueType)
	{
		//Discarded unreachable code: IL_0045, IL_0054, IL_008f, IL_009e, IL_011c, IL_0151
		int num = 4;
		int num2 = num;
		Type type = default(Type);
		PropertyInfo propertyInfo = default(PropertyInfo);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 1:
				return typeof(Uri).IsAssignableFrom(type);
			case 5:
				return false;
			default:
				if (!Hcw6DBGMGaUSDvSiL4oJ(propertyInfo, null))
				{
					num2 = 2;
					continue;
				}
				obj = null;
				break;
			case 8:
				if (!H3H7DkGMCNYHyl1Y126Q(type, null))
				{
					num2 = 5;
					continue;
				}
				goto case 1;
			case 3:
				return false;
			case 2:
				if (ysNrZWGMEgxD42RQO6VS(propertyInfo.PropertyType))
				{
					num2 = 7;
					continue;
				}
				goto case 6;
			case 6:
				obj = aPG4mUGMfQirPWGht0qH(propertyInfo);
				break;
			case 4:
				if (aoqTOhGMoPOf7Ck3H547(typeof(string).TypeHandle).IsAssignableFrom(valueType))
				{
					propertyInfo = (PropertyInfo)kuJoVCGMhc2Kb9RfRBpq(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(GaxWBMGMbXI4Ttuvw9PE(metadata)), propName);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 3;
				}
				continue;
			case 7:
				obj = pIIqwcGMQQV61PlwEJaX(aPG4mUGMfQirPWGht0qH(propertyInfo));
				break;
			}
			type = (Type)obj;
			num2 = 8;
		}
	}

	public object ConvertValue(EntityMetadata metadata, string propName, object value)
	{
		return new Uri((string)value);
	}

	public UriTypeConvertion()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type aoqTOhGMoPOf7Ck3H547(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static Guid GaxWBMGMbXI4Ttuvw9PE(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object kuJoVCGMhc2Kb9RfRBpq(Type type, object P_1)
	{
		return type.GetReflectionProperty((string)P_1);
	}

	internal static bool Hcw6DBGMGaUSDvSiL4oJ(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static bool ysNrZWGMEgxD42RQO6VS(Type type)
	{
		return type.IsNullableType();
	}

	internal static Type aPG4mUGMfQirPWGht0qH(object P_0)
	{
		return ((PropertyInfo)P_0).PropertyType;
	}

	internal static Type pIIqwcGMQQV61PlwEJaX(Type type)
	{
		return type.GetNonNullableType();
	}

	internal static bool H3H7DkGMCNYHyl1Y126Q(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static bool c8giwWGMB7VlsrsL96mt()
	{
		return pBvXuPGMFMILBUgHSt7y == null;
	}

	internal static UriTypeConvertion tq5ZmmGMWYZ2PVWO9fvs()
	{
		return pBvXuPGMFMILBUgHSt7y;
	}
}
