using System;
using System.Runtime.CompilerServices;
using Castle.DynamicProxy;
using EleWise.ELMA.Remoting;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Services;

public class RemoteServiceInfo : EternalRefObject
{
	internal static RemoteServiceInfo D6ptGjBxs8UDrl0XKdh6;

	public EternalRefObject Reference
	{
		[CompilerGenerated]
		get
		{
			return _003CReference_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CReference_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public string AssemblyQualifiedTypeName
	{
		[CompilerGenerated]
		get
		{
			return _003CAssemblyQualifiedTypeName_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CAssemblyQualifiedTypeName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public RemoteServiceInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		iVk8wsB0FW5aiIdaU0J8();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public RemoteServiceInfo(EternalRefObject reference)
	{
		//Discarded unreachable code: IL_002a, IL_002f, IL_005e, IL_006d, IL_009b
		iVk8wsB0FW5aiIdaU0J8();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
		{
			num = 4;
		}
		Type type2 = default(Type);
		while (true)
		{
			Type type;
			switch (num)
			{
			case 5:
				return;
			case 2:
				AssemblyQualifiedTypeName = type2.AssemblyQualifiedName;
				num = 5;
				continue;
			case 3:
				type = reference.GetType();
				break;
			case 1:
				if (reference.GetType().IsSecurityTransparent)
				{
					num = 6;
					continue;
				}
				goto default;
			default:
				if (!(reference.GetType().GetInterface(mG3bWaB0BZT5tTxyC7Z3(typeof(IProxyTargetAccessor).TypeHandle).FullName) != null))
				{
					num = 3;
					continue;
				}
				goto case 6;
			case 4:
				Reference = reference;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num = 0;
				}
				continue;
			case 6:
				type = reference.GetType().BaseType;
				break;
			}
			type2 = type;
			num = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
			{
				num = 1;
			}
		}
	}

	internal static void iVk8wsB0FW5aiIdaU0J8()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool X8bIw6Bxc2DaZuZ4xZ6C()
	{
		return D6ptGjBxs8UDrl0XKdh6 == null;
	}

	internal static RemoteServiceInfo SY2NBEBxz0NfwHYdeOhT()
	{
		return D6ptGjBxs8UDrl0XKdh6;
	}

	internal static Type mG3bWaB0BZT5tTxyC7Z3(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
