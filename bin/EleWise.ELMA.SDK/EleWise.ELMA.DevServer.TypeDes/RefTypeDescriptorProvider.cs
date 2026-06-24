using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Types;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.DevServer.TypeDescriptors;

internal sealed class RefTypeDescriptorProvider : ITypeDescriptorProvider
{
	private static Type refTypeDescriptorType;

	internal static RefTypeDescriptorProvider bq4y1REObB3wmNgS8Ped;

	public IEnumerable<Type> GetTypeDescriptors()
	{
		return typeof(RefTypeDescriptorProvider).Assembly.GetTypes().Where(delegate(Type t)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (t.IsAbstract)
					{
						return false;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return _003C_003Ec.InG8LE8XLOsGC1rZcWc3(t);
				}
			}
		});
	}

	private static bool IsRefTypeDescriptor(Type toCheck)
	{
		//Discarded unreachable code: IL_0071, IL_0080, IL_00a6, IL_00cf, IL_00de, IL_00ed, IL_00fd
		int num = 1;
		int num2 = num;
		Type type2 = default(Type);
		while (true)
		{
			Type type;
			switch (num2)
			{
			case 9:
				return true;
			case 3:
				toCheck = toCheck.BaseType;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
				{
					num2 = 4;
				}
				continue;
			default:
				if (toCheck.IsGenericType)
				{
					num2 = 7;
					continue;
				}
				goto case 6;
			case 6:
				type = toCheck;
				break;
			case 2:
				if (!(toCheck != mrkYmkEOff8P1MX7ICRl(typeof(object).TypeHandle)))
				{
					num2 = 10;
					continue;
				}
				goto default;
			case 1:
			case 4:
				if (!(toCheck != null))
				{
					num2 = 5;
					continue;
				}
				goto case 2;
			case 5:
			case 10:
				return false;
			case 8:
				if (!MIuTmFEOEJpL19FAissZ(refTypeDescriptorType, type2))
				{
					num2 = 3;
					continue;
				}
				goto case 9;
			case 7:
				type = toCheck.GetGenericTypeDefinition();
				break;
			}
			type2 = type;
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
			{
				num2 = 8;
			}
		}
	}

	public RefTypeDescriptorProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		wv6xFjEOQ9hrquilh45i();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static RefTypeDescriptorProvider()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				refTypeDescriptorType = mrkYmkEOff8P1MX7ICRl(typeof(RefTypeDescriptor<, >).TypeHandle);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool MIuTmFEOEJpL19FAissZ(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static Type mrkYmkEOff8P1MX7ICRl(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool cFDrbeEOhDP4a36DHb7x()
	{
		return bq4y1REObB3wmNgS8Ped == null;
	}

	internal static RefTypeDescriptorProvider wEEf4vEOGfFAjCCSeYXU()
	{
		return bq4y1REObB3wmNgS8Ped;
	}

	internal static void wv6xFjEOQ9hrquilh45i()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
