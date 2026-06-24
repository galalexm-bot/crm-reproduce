using System;
using System.Reflection;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Extensions.QueryFunctionResults;

[Component]
public class WorkTimeTypeConvertion : IQueryTypeConvertion
{
	private static WorkTimeTypeConvertion Toxn75GMVfK6WbaICCdA;

	public bool AvailableConvert(EntityMetadata metadata, string propName, Type valueType)
	{
		//Discarded unreachable code: IL_004c, IL_0056, IL_0065, IL_0074, IL_0155
		int num = 6;
		PropertyInfo propertyInfo = default(PropertyInfo);
		Type type = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 4:
					obj = IV3hBiGMToWCLN0IeDnZ(propertyInfo);
					break;
				case 7:
					return false;
				case 5:
					propertyInfo = (PropertyInfo)YThkXUGMKHOmNhmihLx1(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(NCAfN5GMqXSjq2cIHd3x(metadata)), propName);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 3;
					}
					continue;
				case 6:
					if (Rddb8PGMRjSEKCLdyhUD(typeof(long).TypeHandle).IsAssignableFrom(valueType))
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 7;
				case 1:
					if (wvk5p9GMkO2pR38t7yU6(IV3hBiGMToWCLN0IeDnZ(propertyInfo)))
					{
						obj = SeyiqDGMnwq8x2nWum1M(IV3hBiGMToWCLN0IeDnZ(propertyInfo));
						break;
					}
					goto end_IL_0012;
				case 2:
					return Rddb8PGMRjSEKCLdyhUD(typeof(WorkTime).TypeHandle).IsAssignableFrom(type);
				case 3:
					if (xmetEXGMXABceL3eMMSF(propertyInfo, null))
					{
						num2 = 8;
						continue;
					}
					goto case 1;
				default:
					if (!LL0vXYGMOJmnPRT6Mvrm(type, null))
					{
						return false;
					}
					num2 = 2;
					continue;
				case 8:
					obj = null;
					break;
				}
				type = (Type)obj;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	public object ConvertValue(EntityMetadata metadata, string propName, object value)
	{
		return new WorkTime((long)value);
	}

	public WorkTimeTypeConvertion()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		PoBV8AGM22HKtVPVs3ZU();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type Rddb8PGMRjSEKCLdyhUD(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static Guid NCAfN5GMqXSjq2cIHd3x(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object YThkXUGMKHOmNhmihLx1(Type type, object P_1)
	{
		return type.GetReflectionProperty((string)P_1);
	}

	internal static bool xmetEXGMXABceL3eMMSF(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static Type IV3hBiGMToWCLN0IeDnZ(object P_0)
	{
		return ((PropertyInfo)P_0).PropertyType;
	}

	internal static bool wvk5p9GMkO2pR38t7yU6(Type type)
	{
		return type.IsNullableType();
	}

	internal static Type SeyiqDGMnwq8x2nWum1M(Type type)
	{
		return type.GetNonNullableType();
	}

	internal static bool LL0vXYGMOJmnPRT6Mvrm(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static bool vuFUmrGMSlhNBX0ShHGH()
	{
		return Toxn75GMVfK6WbaICCdA == null;
	}

	internal static WorkTimeTypeConvertion BMduTLGMiiiTpbE8v5Dr()
	{
		return Toxn75GMVfK6WbaICCdA;
	}

	internal static void PoBV8AGM22HKtVPVs3ZU()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
