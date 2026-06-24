using System.Collections;
using System.Runtime.Remoting.Channels;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Remoting.NH;

public class NHServerChannelSinkProvider : IServerChannelSinkProvider
{
	private IServerChannelSinkProvider _next;

	private static NHServerChannelSinkProvider axMxY2OWPHMHnRoUWSX;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public NHServerChannelSinkProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public NHServerChannelSinkProvider(IDictionary properties, ICollection providerData)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		IeQp85OhgamJlXG4hXw();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
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
		//Discarded unreachable code: IL_0052
		int num = 1;
		int num2 = num;
		IServerChannelSink nextSink = default(IServerChannelSink);
		while (true)
		{
			switch (num2)
			{
			case 1:
				nextSink = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (_next == null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 4;
			case 4:
				nextSink = (IServerChannelSink)OVxlTOOGfK8HZPkZewO(_next, channel);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
			case 3:
				return new NHServerChannelSink(nextSink);
			}
		}
	}

	internal static bool cFhVrAOo9gKX6MdkNFn()
	{
		return axMxY2OWPHMHnRoUWSX == null;
	}

	internal static NHServerChannelSinkProvider hC4Jb1ObNm3wBhlNdbk()
	{
		return axMxY2OWPHMHnRoUWSX;
	}

	internal static void IeQp85OhgamJlXG4hXw()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object OVxlTOOGfK8HZPkZewO(object P_0, object P_1)
	{
		return ((IServerChannelSinkProvider)P_0).CreateSink((IChannelReceiver)P_1);
	}
}
