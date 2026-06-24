using System;
using System.Collections.Generic;
using EleWise.ELMA.Collections;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Extensions;

public static class UntypedCollectionExtensions
{
	private static UntypedCollectionExtensions MuuxHkG6ewuf6tUd8scC;

	public static UntypedISetProxy AsUntypedISet(this object iSetValue)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!(iSetValue.GetType().GetInterface(U9mmovG6NMXJn0mbkjGS(typeof(ISet<>).TypeHandle).FullName) != null))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return new UntypedISetProxy(iSetValue);
			default:
				return null;
			case 2:
				if (iSetValue != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public static UntypedICollectionProxy AsUntypedICollection(this object iCollectionValue)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 1:
				if (CGOeJcG63Zp5ylamhNfa(iCollectionValue.GetType().GetInterface(U9mmovG6NMXJn0mbkjGS(typeof(ICollection<>).TypeHandle).FullName), null))
				{
					return new UntypedICollectionProxy(iCollectionValue);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (iCollectionValue == null)
				{
					num2 = 2;
					break;
				}
				goto case 1;
			}
		}
	}

	public static UntypedIDictionaryProxy AsUntypedIDictionary(this object iDictionaryValue)
	{
		//Discarded unreachable code: IL_0090, IL_009f
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (iDictionaryValue == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				if (!(iDictionaryValue.GetType().GetInterface(typeof(IDictionary<, >).FullName) != null))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 1;
					}
					break;
				}
				return new UntypedIDictionaryProxy(iDictionaryValue);
			case 1:
			case 2:
				return null;
			}
		}
	}

	internal static Type U9mmovG6NMXJn0mbkjGS(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool RFs7OmG6P52Uv6uSvohR()
	{
		return MuuxHkG6ewuf6tUd8scC == null;
	}

	internal static UntypedCollectionExtensions zBqvwuG618LewubBRebR()
	{
		return MuuxHkG6ewuf6tUd8scC;
	}

	internal static bool CGOeJcG63Zp5ylamhNfa(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}
}
