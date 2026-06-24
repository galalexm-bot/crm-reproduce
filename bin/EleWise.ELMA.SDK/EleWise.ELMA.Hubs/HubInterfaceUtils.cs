using System;
using System.Reflection;

namespace EleWise.ELMA.Hubs;

internal static class HubInterfaceUtils
{
	internal static HubInterfaceUtils VNCcNghgHvet8vWl34sx;

	public static bool IsHubInterface(Type type)
	{
		//Discarded unreachable code: IL_007e, IL_008d, IL_009c
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (type.IsGenericType)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			case 1:
				if (KL7Qethg01SsjXYnq3xa(type.GetInterface((string)DlJLbdhgxr42rKrNRXCj()), null))
				{
					num2 = 4;
					break;
				}
				goto default;
			case 5:
				return KL7Qethg01SsjXYnq3xa(type, TypeOf<IHub>.Raw);
			default:
				return false;
			case 3:
				if (!type.IsInterface)
				{
					num2 = 2;
					break;
				}
				goto case 1;
			}
		}
	}

	internal static object DlJLbdhgxr42rKrNRXCj()
	{
		return TypeOf<IHub>.FullName;
	}

	internal static bool KL7Qethg01SsjXYnq3xa(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static bool tblbqUhgAYlnPqpaWhVS()
	{
		return VNCcNghgHvet8vWl34sx == null;
	}

	internal static HubInterfaceUtils EhTERGhg7xGf43LjTSmv()
	{
		return VNCcNghgHvet8vWl34sx;
	}
}
