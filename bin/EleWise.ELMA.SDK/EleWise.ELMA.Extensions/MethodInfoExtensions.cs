using System;
using System.CodeDom.Compiler;
using System.Reflection;

namespace EleWise.ELMA.Extensions;

public static class MethodInfoExtensions
{
	internal static MethodInfoExtensions Pl0V0yGpd7kyfujTZS7W;

	public static bool IsAnonymous(this MethodInfo method)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return !VhavMbGpjEbtWb8KoVy0(e4QxesGp59xQDry3LXNa(method));
			case 1:
				if (jmi3eXGpg7bp1uIsqpmy(method) == null)
				{
					return true;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static Type jmi3eXGpg7bp1uIsqpmy(object P_0)
	{
		return ((MemberInfo)P_0).DeclaringType;
	}

	internal static object e4QxesGp59xQDry3LXNa(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static bool VhavMbGpjEbtWb8KoVy0(object P_0)
	{
		return CodeGenerator.IsValidLanguageIndependentIdentifier((string)P_0);
	}

	internal static bool fQL5ehGplkdwq4Hi2fhJ()
	{
		return Pl0V0yGpd7kyfujTZS7W == null;
	}

	internal static MethodInfoExtensions ANGKfgGpr6YCJ3IfwysG()
	{
		return Pl0V0yGpd7kyfujTZS7W;
	}
}
