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
public class MoneyTypeConvertion : IQueryTypeConvertion
{
	internal static MoneyTypeConvertion lvW7auGyPrErxtR8AJRK;

	public bool AvailableConvert(EntityMetadata metadata, string propName, Type valueType)
	{
		//Discarded unreachable code: IL_00bb, IL_0147, IL_0151, IL_0164
		int num = 5;
		int num2 = num;
		PropertyInfo propertyInfo = default(PropertyInfo);
		Type type = default(Type);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 3:
				if (!Y5tN28GyDZgaBbfeQd5S(propertyInfo, null))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				obj = null;
				break;
			case 8:
				return EhwAqxGy3TAjcksAvIMs(typeof(Money).TypeHandle).IsAssignableFrom(type);
			case 6:
				return false;
			default:
				if (!BnnOG4GywS2iy6cOdvi0(x1e2PwGytntcNuiOJn33(propertyInfo)))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 1;
					}
					continue;
				}
				obj = x1e2PwGytntcNuiOJn33(propertyInfo).GetNonNullableType();
				break;
			case 7:
				if (!(type != null))
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				goto case 8;
			case 9:
				return false;
			case 2:
				propertyInfo = (PropertyInfo)YXkuGuGyaEJPokiEGFmx(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(pvbVwbGypSB9iuPtUiWf(metadata)), propName);
				num2 = 3;
				continue;
			case 5:
				if (!EhwAqxGy3TAjcksAvIMs(typeof(long).TypeHandle).IsAssignableFrom(valueType))
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 4;
					}
					continue;
				}
				goto case 2;
			case 1:
				obj = x1e2PwGytntcNuiOJn33(propertyInfo);
				break;
			case 4:
				if (EhwAqxGy3TAjcksAvIMs(typeof(double).TypeHandle).IsAssignableFrom(valueType))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 9;
			}
			type = (Type)obj;
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
			{
				num2 = 7;
			}
		}
	}

	public object ConvertValue(EntityMetadata metadata, string propName, object value)
	{
		return ONucF8Gy6fsAhpg0s5lh(VLKofeGy4br23RZoNxj8(value));
	}

	public MoneyTypeConvertion()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		e7GumaGyHFWdutdm7qZS();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type EhwAqxGy3TAjcksAvIMs(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static Guid pvbVwbGypSB9iuPtUiWf(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object YXkuGuGyaEJPokiEGFmx(Type type, object P_1)
	{
		return type.GetReflectionProperty((string)P_1);
	}

	internal static bool Y5tN28GyDZgaBbfeQd5S(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static Type x1e2PwGytntcNuiOJn33(object P_0)
	{
		return ((PropertyInfo)P_0).PropertyType;
	}

	internal static bool BnnOG4GywS2iy6cOdvi0(Type type)
	{
		return type.IsNullableType();
	}

	internal static bool L0Bn1rGy1NVwF0sniAho()
	{
		return lvW7auGyPrErxtR8AJRK == null;
	}

	internal static MoneyTypeConvertion JVHnsWGyNcMBoOTHIoij()
	{
		return lvW7auGyPrErxtR8AJRK;
	}

	internal static double VLKofeGy4br23RZoNxj8(object P_0)
	{
		return Convert.ToDouble(P_0);
	}

	internal static Money ONucF8Gy6fsAhpg0s5lh(double d)
	{
		return d;
	}

	internal static void e7GumaGyHFWdutdm7qZS()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
