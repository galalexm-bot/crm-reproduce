using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ActorModel.Attributes;

[AttributeUsage(AttributeTargets.Interface)]
public sealed class ActorProxyToAttribute : Attribute
{
	private static ActorProxyToAttribute hAaW9lfDW3GnHDqTnGIS;

	public Type ActorInterfaceType { get; }

	public Type ActorToProxyWrapper { get; }

	public Type ProxyToActorWrapper { get; }

	public ActorProxyToAttribute(Type actorInterfaceType, Type actorToProxyWrapper, Type proxyToActorWrapper)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ItfrnkfDhYDldV1CS0s2();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			default:
				ProxyToActorWrapper = proxyToActorWrapper;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num = 1;
				}
				break;
			case 1:
				ActorInterfaceType = actorInterfaceType;
				num = 3;
				break;
			case 3:
				ActorToProxyWrapper = actorToProxyWrapper;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void ItfrnkfDhYDldV1CS0s2()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool Fnucl9fDo1Mbj6897bxC()
	{
		return hAaW9lfDW3GnHDqTnGIS == null;
	}

	internal static ActorProxyToAttribute ef3klOfDbWZfP1ATW2rK()
	{
		return hAaW9lfDW3GnHDqTnGIS;
	}
}
