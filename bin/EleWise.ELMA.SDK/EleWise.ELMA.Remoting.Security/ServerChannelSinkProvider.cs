using System.Collections;
using System.Runtime.Remoting.Channels;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Remoting.Security;

internal class ServerChannelSinkProvider : IServerChannelSinkProvider
{
	private IServerChannelSinkProvider _next;

	internal static ServerChannelSinkProvider uRE7lcn9ysqWyTfhIDO;

	public IServerChannelSinkProvider Next
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
				case 0:
					return;
				case 1:
					_next = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ServerChannelSinkProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		lsZYRdnrn1RArqjxUMF();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ServerChannelSinkProvider(IDictionary properties, ICollection providerData)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public void GetChannelData(IChannelDataStore channelData)
	{
	}

	public IServerChannelSink CreateSink(IChannelReceiver channel)
	{
		//Discarded unreachable code: IL_0035, IL_0044
		int num = 4;
		int num2 = num;
		IServerChannelSink nextSink = default(IServerChannelSink);
		while (true)
		{
			switch (num2)
			{
			case 1:
				nextSink = (IServerChannelSink)pq6lJingBfxrQc6xxH7(_next, channel);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				nextSink = null;
				num2 = 3;
				break;
			default:
				return new ServerChannelSink(nextSink);
			case 3:
				if (_next == null)
				{
					num2 = 2;
					break;
				}
				goto case 1;
			}
		}
	}

	internal static void lsZYRdnrn1RArqjxUMF()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool ybXpNindwHQJNAbuvQG()
	{
		return uRE7lcn9ysqWyTfhIDO == null;
	}

	internal static ServerChannelSinkProvider QpJZrLnl9pfsFIqZA3a()
	{
		return uRE7lcn9ysqWyTfhIDO;
	}

	internal static object pq6lJingBfxrQc6xxH7(object P_0, object P_1)
	{
		return ((IServerChannelSinkProvider)P_0).CreateSink((IChannelReceiver)P_1);
	}
}
