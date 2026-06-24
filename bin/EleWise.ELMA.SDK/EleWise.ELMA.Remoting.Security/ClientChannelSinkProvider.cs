using System.Collections;
using System.Runtime.Remoting.Channels;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Remoting.Security;

internal class ClientChannelSinkProvider : IClientChannelSinkProvider
{
	private IClientChannelSinkProvider _next;

	private static ClientChannelSinkProvider S2AmsCnov0etfyrGJsw;

	public IClientChannelSinkProvider Next
	{
		get
		{
			return _next;
		}
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
					_next = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
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

	public ClientChannelSinkProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		BkBHf1nGaEDWkEMRFnn();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ClientChannelSinkProvider(IDictionary properties, ICollection providerData)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		BkBHf1nGaEDWkEMRFnn();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public IClientChannelSink CreateSink(IChannelSender channel, string url, object remoteChannelData)
	{
		//Discarded unreachable code: IL_004a, IL_0059
		int num = 4;
		int num2 = num;
		IClientChannelSink clientChannelSink = default(IClientChannelSink);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (clientChannelSink != null)
				{
					num2 = 5;
					break;
				}
				goto default;
			default:
				return null;
			case 5:
				return new ClientChannelSink(url, clientChannelSink);
			case 3:
				if (_next != null)
				{
					num2 = 2;
					break;
				}
				goto case 5;
			case 2:
				clientChannelSink = (IClientChannelSink)NfspIwnEWSn2fe6MSfW(_next, channel, url, remoteChannelData);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				clientChannelSink = null;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static void BkBHf1nGaEDWkEMRFnn()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool lmbNj1nbuMr7gwFIW8d()
	{
		return S2AmsCnov0etfyrGJsw == null;
	}

	internal static ClientChannelSinkProvider VEDY3vnhHl1LxSGVedd()
	{
		return S2AmsCnov0etfyrGJsw;
	}

	internal static object NfspIwnEWSn2fe6MSfW(object P_0, object P_1, object P_2, object P_3)
	{
		return ((IClientChannelSinkProvider)P_0).CreateSink((IChannelSender)P_1, (string)P_2, P_3);
	}
}
