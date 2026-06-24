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
public class Int32TypeConvertion : IQueryTypeConvertion
{
	internal static Int32TypeConvertion TwoD7FGyRo766Ty7Z0PH;

	public bool AvailableConvert(EntityMetadata metadata, string propName, Type valueType)
	{
		//Discarded unreachable code: IL_0045, IL_0054, IL_0090, IL_00a6, IL_010e, IL_011d
		int num = 4;
		int num2 = num;
		PropertyInfo reflectionProperty = default(PropertyInfo);
		Type type = default(Type);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 2:
				return false;
			case 3:
				reflectionProperty = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(JU0mlmGyTNSap8iiXmpM(metadata)).GetReflectionProperty(propName);
				num2 = 7;
				continue;
			default:
				obj = S6j6PXGynouQpACoJ453(reflectionProperty);
				break;
			case 1:
				obj = dU1pMlGyOgEV0hAPkZg2(S6j6PXGynouQpACoJ453(reflectionProperty));
				break;
			case 4:
				if (DdVorKGyXHB06FPilO53(typeof(long).TypeHandle).IsAssignableFrom(valueType))
				{
					num2 = 3;
					continue;
				}
				goto case 2;
			case 5:
				return DdVorKGyXHB06FPilO53(typeof(int).TypeHandle).IsAssignableFrom(type);
			case 8:
				if (reflectionProperty.PropertyType.IsNullableType())
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto default;
			case 7:
				if (!R5aP82GykAwG7WgXxLIa(reflectionProperty, null))
				{
					num2 = 8;
					continue;
				}
				obj = null;
				break;
			case 6:
				if (!sys01OGy2QqnHf8dovGA(type, null))
				{
					return false;
				}
				num2 = 5;
				continue;
			}
			type = (Type)obj;
			num2 = 6;
		}
	}

	public object ConvertValue(EntityMetadata metadata, string propName, object value)
	{
		return Convert.ToInt32(value);
	}

	public Int32TypeConvertion()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		lAmnhjGyeqDsHyufdCvd();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type DdVorKGyXHB06FPilO53(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static Guid JU0mlmGyTNSap8iiXmpM(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static bool R5aP82GykAwG7WgXxLIa(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static Type S6j6PXGynouQpACoJ453(object P_0)
	{
		return ((PropertyInfo)P_0).PropertyType;
	}

	internal static Type dU1pMlGyOgEV0hAPkZg2(Type type)
	{
		return type.GetNonNullableType();
	}

	internal static bool sys01OGy2QqnHf8dovGA(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static bool WwRfkDGyqPUOYluBEEbK()
	{
		return TwoD7FGyRo766Ty7Z0PH == null;
	}

	internal static Int32TypeConvertion uJ2PLXGyKpdJfAFAbpXe()
	{
		return TwoD7FGyRo766Ty7Z0PH;
	}

	internal static void lAmnhjGyeqDsHyufdCvd()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
