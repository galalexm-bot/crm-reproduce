using System;
using System.Collections.Concurrent;
using System.Reflection;
using System.Reflection.Emit;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Helpers;

public class FastMemberAccessHelper<TObjectType>
{
	public delegate MemberType MemberGetDelegate<out MemberType>(TObjectType obj);

	private static readonly ConcurrentDictionary<string, Delegate> _memberGetDelegates;

	internal static object iIflUThsYuLY4uXaKKXk;

	public static MemberGetDelegate<TMemberType> GetMemberGetDelegate<TMemberType>(string memberName)
	{
		Type typeFromHandle = typeof(TObjectType);
		PropertyInfo reflectionProperty = typeFromHandle.GetReflectionProperty(memberName);
		FieldInfo reflectionField = typeFromHandle.GetReflectionField(memberName);
		if (reflectionProperty != null)
		{
			MethodInfo getMethod = reflectionProperty.GetGetMethod();
			if (getMethod != null)
			{
				return (MemberGetDelegate<TMemberType>)Delegate.CreateDelegate(typeof(MemberGetDelegate<TMemberType>), getMethod);
			}
			throw new Exception(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x53F1C9D), memberName, typeFromHandle.Name));
		}
		if (reflectionField != null)
		{
			DynamicMethod dynamicMethod = new DynamicMethod(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A81B9B4 ^ 0x6A82E56C) + memberName, typeof(TMemberType), new Type[1] { typeFromHandle }, typeFromHandle);
			ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Ldfld, reflectionField);
			iLGenerator.Emit(OpCodes.Ret);
			return (MemberGetDelegate<TMemberType>)dynamicMethod.CreateDelegate(typeof(MemberGetDelegate<TMemberType>));
		}
		throw new Exception(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-521266112 ^ -521294714), memberName, typeFromHandle.Name));
	}

	public static MemberGetDelegate<MemberType> GetCachedMemberGetDelegate<MemberType>(string memberName)
	{
		if (_memberGetDelegates.ContainsKey(memberName))
		{
			return (MemberGetDelegate<MemberType>)_memberGetDelegates[memberName];
		}
		MemberGetDelegate<MemberType> memberGetDelegate = GetMemberGetDelegate<MemberType>(memberName);
		lock (_memberGetDelegates)
		{
			_memberGetDelegates[memberName] = memberGetDelegate;
			return memberGetDelegate;
		}
	}

	public FastMemberAccessHelper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static FastMemberAccessHelper()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_memberGetDelegates = new ConcurrentDictionary<string, Delegate>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool cCUQtohsLJWA5UDaC5tM()
	{
		return iIflUThsYuLY4uXaKKXk == null;
	}

	internal static object KB6cn8hsUvqFyqvrlLH9()
	{
		return iIflUThsYuLY4uXaKKXk;
	}
}
