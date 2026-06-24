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
public class BooleanTypeConvertion : IQueryTypeConvertion
{
	internal static BooleanTypeConvertion WCuGLVGm2jiAIbiF2H4v;

	public bool AvailableConvert(EntityMetadata metadata, string propName, Type valueType)
	{
		//Discarded unreachable code: IL_0045, IL_0054, IL_006b, IL_013b, IL_0145
		int num = 7;
		int num2 = num;
		PropertyInfo reflectionProperty = default(PropertyInfo);
		Type type = default(Type);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 4:
				obj = OC14CIGmpMk7FZJOTbPP(reflectionProperty);
				break;
			case 7:
				if (CAJ9NbGm1AC8o0VsGt4j(typeof(long).TypeHandle).IsAssignableFrom(valueType))
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 8;
			case 2:
				if (!YCFkKvGm3XeFcYJXioRF(reflectionProperty, null))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				obj = null;
				break;
			default:
				return typeof(bool).IsAssignableFrom(type);
			case 3:
				return false;
			case 8:
				return false;
			case 6:
				reflectionProperty = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(Jxy30WGmN5ZsbgjAxyiy(metadata)).GetReflectionProperty(propName);
				num2 = 2;
				continue;
			case 1:
				if (!vmP1UwGma0xrE5VQy0lE(OC14CIGmpMk7FZJOTbPP(reflectionProperty)))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 4;
					}
					continue;
				}
				obj = UBglkHGmDb4v6gk9yVqQ(OC14CIGmpMk7FZJOTbPP(reflectionProperty));
				break;
			case 5:
				if (!(type != null))
				{
					num2 = 3;
					continue;
				}
				goto default;
			}
			type = (Type)obj;
			num2 = 5;
		}
	}

	public object ConvertValue(EntityMetadata metadata, string propName, object value)
	{
		return (long)value != 0;
	}

	public BooleanTypeConvertion()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		R0s64fGmtXs71Ap2diVZ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type CAJ9NbGm1AC8o0VsGt4j(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static Guid Jxy30WGmN5ZsbgjAxyiy(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static bool YCFkKvGm3XeFcYJXioRF(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static Type OC14CIGmpMk7FZJOTbPP(object P_0)
	{
		return ((PropertyInfo)P_0).PropertyType;
	}

	internal static bool vmP1UwGma0xrE5VQy0lE(Type type)
	{
		return type.IsNullableType();
	}

	internal static Type UBglkHGmDb4v6gk9yVqQ(Type type)
	{
		return type.GetNonNullableType();
	}

	internal static bool joUHxmGmexRRwxMp3abt()
	{
		return WCuGLVGm2jiAIbiF2H4v == null;
	}

	internal static BooleanTypeConvertion WaSJe2GmPrtGyrpt3xtK()
	{
		return WCuGLVGm2jiAIbiF2H4v;
	}

	internal static void R0s64fGmtXs71Ap2diVZ()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
