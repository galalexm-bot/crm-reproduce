using System;
using System.Globalization;
using System.Reflection;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Properties;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator;

internal class EntitySetPropertyMethodInfo : EntityMethodInfo
{
	private readonly ParameterInfo[] getParameters;

	private readonly ISetter setter;

	private readonly object defaultValue;

	private static EntitySetPropertyMethodInfo qJ0hqrhi88cJ22OIt6MZ;

	public override Type ReturnType => AIv1dBhiiLhCcKk7oBac(typeof(void).TypeHandle);

	public override ParameterInfo ReturnParameter { get; }

	public EntitySetPropertyMethodInfo(Type declaringType, Type reflectedType, string name, Type type, ISetter setter)
	{
		//Discarded unreachable code: IL_0042, IL_0047
		ntsf9ghiImywPuD7XPed();
		base._002Ector(declaringType, reflectedType, (string)Wl79K4hiV2Cs0cJD6gGn(-1978478350 ^ -1978475394) + name);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 4:
				this.setter = setter;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num = 0;
				}
				break;
			case 3:
				ReturnParameter = new EntityMethodParameterInfo(this, typeof(void));
				num = 4;
				break;
			case 2:
				return;
			case 1:
			{
				ParameterInfo[] array = (getParameters = new EntityMethodParameterInfo[1]
				{
					new EntityMethodParameterInfo(this, type, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4EDCF344), 0)
				});
				num = 3;
				break;
			}
			default:
				defaultValue = lafJG4hiSl4L8xJy6Dq4(type);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num = 2;
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
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 1:
				DJSBZQhiRA6IhN9nDUYo(setter, obj, parameters[0] ?? defaultValue);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void ntsf9ghiImywPuD7XPed()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object Wl79K4hiV2Cs0cJD6gGn(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object lafJG4hiSl4L8xJy6Dq4(Type type)
	{
		return type.DefaultValue();
	}

	internal static bool Akjn0shiZZPSJ7NpLMZU()
	{
		return (object)qJ0hqrhi88cJ22OIt6MZ == null;
	}

	internal static EntitySetPropertyMethodInfo nGf0OMhiusXciUUJAw5V()
	{
		return qJ0hqrhi88cJ22OIt6MZ;
	}

	internal static Type AIv1dBhiiLhCcKk7oBac(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void DJSBZQhiRA6IhN9nDUYo(object P_0, object P_1, object P_2)
	{
		((ISetter)P_0).Set(P_1, P_2);
	}
}
