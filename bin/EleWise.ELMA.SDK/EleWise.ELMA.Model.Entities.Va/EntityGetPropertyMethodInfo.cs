using System;
using System.Globalization;
using System.Reflection;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Properties;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator;

internal class EntityGetPropertyMethodInfo : EntityMethodInfo
{
	private static readonly ParameterInfo[] getParameters;

	private readonly IGetter getter;

	internal static EntityGetPropertyMethodInfo l4QiEwhiGebbhmqL79wm;

	public override Type ReturnType { get; }

	public override ParameterInfo ReturnParameter { get; }

	public EntityGetPropertyMethodInfo(Type declaringType, Type reflectedType, string name, Type type, IGetter getter)
	{
		//Discarded unreachable code: IL_0042, IL_0047
		ylWbFKhiQmvgq6JxX27i();
		base._002Ector(declaringType, reflectedType, (string)I0vZE8hiCeRnUvqxY5Vj(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921201341), name));
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				this.getter = getter;
				num = 3;
				break;
			default:
				ReturnType = type;
				num = 2;
				break;
			case 3:
				return;
			case 2:
				ReturnParameter = new EntityMethodParameterInfo(this, type);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public override ParameterInfo[] GetParameters()
	{
		return getParameters;
	}

	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
	{
		return t1t5GShivy8LDQ2e5VB4(getter, obj);
	}

	static EntityGetPropertyMethodInfo()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				ylWbFKhiQmvgq6JxX27i();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 0;
				}
				break;
			default:
				getParameters = new ParameterInfo[0];
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static void ylWbFKhiQmvgq6JxX27i()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object I0vZE8hiCeRnUvqxY5Vj(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool pL5jwlhiEtlR8wnUafnU()
	{
		return (object)l4QiEwhiGebbhmqL79wm == null;
	}

	internal static EntityGetPropertyMethodInfo SnMMldhifbR0e0A2e2aW()
	{
		return l4QiEwhiGebbhmqL79wm;
	}

	internal static object t1t5GShivy8LDQ2e5VB4(object P_0, object P_1)
	{
		return ((IGetter)P_0).Get(P_1);
	}
}
