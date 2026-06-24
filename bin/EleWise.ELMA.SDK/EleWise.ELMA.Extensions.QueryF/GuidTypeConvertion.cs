using System;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Extensions.QueryFunctionResults;

[Component(Order = 100)]
public class GuidTypeConvertion : IQueryTypeConvertion
{
	private static GuidTypeConvertion JJBjGIGJiBnXWvdAd2jN;

	public bool AvailableConvert(EntityMetadata metadata, string propName, Type valueType)
	{
		//Discarded unreachable code: IL_00b2, IL_00c1, IL_00dd, IL_015e
		int num = 1;
		int num2 = num;
		PropertyInfo reflectionProperty = default(PropertyInfo);
		Type type = default(Type);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 6:
				if (!t1VKejGJTlQCJaGGeIle(reflectionProperty.PropertyType))
				{
					num2 = 4;
					continue;
				}
				obj = xAdFMqGJn5lxjTPS1Sie(TXUlqVGJkoDoqlcRv7ye(reflectionProperty));
				break;
			case 7:
				if (sTev6MGJOy14sWQoRvxk(type, null))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				return false;
			case 1:
				if (WVbrkQGJK5lbh3vqo0If(typeof(string).TypeHandle).IsAssignableFrom(valueType))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 5;
			case 3:
				return WVbrkQGJK5lbh3vqo0If(typeof(Guid).TypeHandle).IsAssignableFrom(type);
			case 2:
				if (!OpKUSJGJXoWilwjYGaWD(reflectionProperty, null))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 6;
					}
					continue;
				}
				obj = null;
				break;
			case 5:
				return false;
			default:
				reflectionProperty = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(metadata.Uid).GetReflectionProperty(propName);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
				{
					num2 = 2;
				}
				continue;
			case 4:
				obj = TXUlqVGJkoDoqlcRv7ye(reflectionProperty);
				break;
			}
			type = (Type)obj;
			num2 = 7;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
			{
				num2 = 5;
			}
		}
	}

	public object ConvertValue(EntityMetadata metadata, string propName, object value)
	{
		return Locator.GetServiceNotNull<GuidQueryResult>().GetValue(metadata, propName, new object[1] { value });
	}

	public GuidTypeConvertion()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		aeQlYHGJ2E4yqyIkTEU3();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type WVbrkQGJK5lbh3vqo0If(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool OpKUSJGJXoWilwjYGaWD(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static bool t1VKejGJTlQCJaGGeIle(Type type)
	{
		return type.IsNullableType();
	}

	internal static Type TXUlqVGJkoDoqlcRv7ye(object P_0)
	{
		return ((PropertyInfo)P_0).PropertyType;
	}

	internal static Type xAdFMqGJn5lxjTPS1Sie(Type type)
	{
		return type.GetNonNullableType();
	}

	internal static bool sTev6MGJOy14sWQoRvxk(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static bool zmYqtXGJRmySLGGt5jO6()
	{
		return JJBjGIGJiBnXWvdAd2jN == null;
	}

	internal static GuidTypeConvertion yHrid0GJqBRgIu1Bw0TT()
	{
		return JJBjGIGJiBnXWvdAd2jN;
	}

	internal static void aeQlYHGJ2E4yqyIkTEU3()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
