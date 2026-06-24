using System;
using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Hubs;

internal static class HubClientProxyHelper
{
	private static readonly IDictionary<Type, (Type proxyType, Func<object, IClient> wrapperFactory)> ClientToClientProxyMap;

	internal static HubClientProxyHelper Wgq8qBhgtfNUb1CkKXgX;

	public static void AddProxy(Type clientType, Type clientProxyType, Func<object, IClient> wrapperFactory)
	{
		ClientToClientProxyMap[clientType] = (clientProxyType, wrapperFactory);
	}

	public static Type GetProxyType(Type clientType)
	{
		return ClientToClientProxyMap[clientType].proxyType;
	}

	public static Func<object, IClient> GetProxyWrapperFactory(Type clientType)
	{
		return ClientToClientProxyMap[clientType].wrapperFactory;
	}

	static HubClientProxyHelper()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				MDsr2mhg6lmldkOYnTow();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				ClientToClientProxyMap = new Dictionary<Type, (Type, Func<object, IClient>)>();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static bool Qu8Y36hgwn5WE5fpHbok()
	{
		return Wgq8qBhgtfNUb1CkKXgX == null;
	}

	internal static HubClientProxyHelper YA7KHbhg4KqQIUY8fXEA()
	{
		return Wgq8qBhgtfNUb1CkKXgX;
	}

	internal static void MDsr2mhg6lmldkOYnTow()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
