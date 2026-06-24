using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Types;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.DevServer.TypeDescriptors;

internal sealed class CLRTypeDescriptorProvider : ITypeDescriptorProvider
{
	private static Type clrTypeDescriptorType;

	internal static CLRTypeDescriptorProvider AjWFuwEnsHsSETcjO1Cy;

	public IEnumerable<Type> GetTypeDescriptors()
	{
		return typeof(CLRTypeDescriptorProvider).Assembly.GetTypes().Where(delegate(Type t)
		{
			//Discarded unreachable code: IL_005b, IL_006a
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return _003C_003Ec.ktg73u8XrA0JeR1h7elj(t);
				default:
					return false;
				case 1:
					if (t.IsAbstract)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				}
			}
		});
	}

	private static bool IsCLRTypeDescriptor(Type toCheck)
	{
		//Discarded unreachable code: IL_00a2, IL_00b1, IL_011c, IL_0126, IL_0135, IL_0145, IL_0154, IL_0163, IL_0172
		int num = 10;
		int num2 = num;
		Type type2 = default(Type);
		while (true)
		{
			Type type;
			switch (num2)
			{
			case 9:
			case 11:
				if (toCheck.IsGenericType)
				{
					num2 = 2;
					continue;
				}
				goto case 5;
			case 7:
			case 10:
				if (!I8h44AEOBb2f1BlHbPB4(toCheck, null))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 6;
			default:
				return true;
			case 4:
				toCheck = toCheck.BaseType;
				num2 = 7;
				continue;
			case 3:
			case 8:
				return false;
			case 6:
				if (toCheck != QOnltfEOW3NPUilEfQe6(typeof(object).TypeHandle))
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 11;
					}
					continue;
				}
				goto case 3;
			case 1:
				if (!PQDG0TEOFMaM4lrCqv3G(clrTypeDescriptorType, type2))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 4;
					}
					continue;
				}
				goto default;
			case 5:
				type = toCheck;
				break;
			case 2:
				type = toCheck.GetGenericTypeDefinition();
				break;
			}
			type2 = type;
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
			{
				num2 = 1;
			}
		}
	}

	public CLRTypeDescriptorProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		hxlth1EOooJE3hwJ4hPG();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static CLRTypeDescriptorProvider()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				clrTypeDescriptorType = typeof(CLRTypeDescriptor<>);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				hxlth1EOooJE3hwJ4hPG();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static bool PQDG0TEOFMaM4lrCqv3G(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static bool I8h44AEOBb2f1BlHbPB4(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static Type QOnltfEOW3NPUilEfQe6(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool b6L0AlEnci8XKA2g36iL()
	{
		return AjWFuwEnsHsSETcjO1Cy == null;
	}

	internal static CLRTypeDescriptorProvider MYnZbCEnzgbAp0vFHZC6()
	{
		return AjWFuwEnsHsSETcjO1Cy;
	}

	internal static void hxlth1EOooJE3hwJ4hPG()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
