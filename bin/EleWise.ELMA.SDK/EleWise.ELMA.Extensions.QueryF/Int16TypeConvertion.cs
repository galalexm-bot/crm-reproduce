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
public class Int16TypeConvertion : IQueryTypeConvertion
{
	internal static Int16TypeConvertion J4BYb6GyQuT9KSdJEdck;

	public bool AvailableConvert(EntityMetadata metadata, string propName, Type valueType)
	{
		//Discarded unreachable code: IL_0084, IL_0120
		int num = 1;
		int num2 = num;
		Type type = default(Type);
		PropertyInfo propertyInfo = default(PropertyInfo);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 6:
				if (type != null)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 1;
					}
					continue;
				}
				return false;
			case 5:
				return typeof(short).IsAssignableFrom(type);
			case 4:
				if (!Gfa6oWGyZM03vTJjXRxX(propertyInfo, null))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 2;
					}
					continue;
				}
				obj = null;
				break;
			case 1:
				if (!typeof(long).IsAssignableFrom(valueType))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 0;
					}
					continue;
				}
				propertyInfo = (PropertyInfo)p32s3PGy8wI4ryMXr9Ek(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(metadata.Uid), propName);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 2;
				}
				continue;
			default:
				return false;
			case 3:
				obj = xwIv2UGyutLufUcFJZFK(propertyInfo);
				break;
			case 2:
				if (cBRRJXGyI4OoV9wh32qe(xwIv2UGyutLufUcFJZFK(propertyInfo)))
				{
					obj = mgkhJCGyVyfv6EVkiCFp(xwIv2UGyutLufUcFJZFK(propertyInfo));
					break;
				}
				num2 = 3;
				continue;
			}
			type = (Type)obj;
			num2 = 6;
		}
	}

	public object ConvertValue(EntityMetadata metadata, string propName, object value)
	{
		return auc5ruGySGoeZwSgrIOy(value);
	}

	public Int16TypeConvertion()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		dr765VGyiOdhDLydVSTd();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object p32s3PGy8wI4ryMXr9Ek(Type type, object P_1)
	{
		return type.GetReflectionProperty((string)P_1);
	}

	internal static bool Gfa6oWGyZM03vTJjXRxX(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static Type xwIv2UGyutLufUcFJZFK(object P_0)
	{
		return ((PropertyInfo)P_0).PropertyType;
	}

	internal static bool cBRRJXGyI4OoV9wh32qe(Type type)
	{
		return type.IsNullableType();
	}

	internal static Type mgkhJCGyVyfv6EVkiCFp(Type type)
	{
		return type.GetNonNullableType();
	}

	internal static bool kXfdaYGyCkSQWuPqAeS1()
	{
		return J4BYb6GyQuT9KSdJEdck == null;
	}

	internal static Int16TypeConvertion ylvT3hGyvmKYRJK8sJkG()
	{
		return J4BYb6GyQuT9KSdJEdck;
	}

	internal static short auc5ruGySGoeZwSgrIOy(object P_0)
	{
		return Convert.ToInt16(P_0);
	}

	internal static void dr765VGyiOdhDLydVSTd()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
