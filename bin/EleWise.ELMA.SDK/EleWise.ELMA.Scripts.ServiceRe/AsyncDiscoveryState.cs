using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Scripts.ServiceReference;

public class AsyncDiscoveryState
{
	private WebServiceDiscoveryClientProtocol protocol;

	private Uri uri;

	private DiscoveryNetworkCredential credential;

	private static AsyncDiscoveryState fnXNqUBce0EEJdQEyJwb;

	public WebServiceDiscoveryClientProtocol Protocol => protocol;

	public Uri Uri => uri;

	public DiscoveryNetworkCredential Credential => credential;

	public AsyncDiscoveryState(WebServiceDiscoveryClientProtocol protocol, Uri uri, DiscoveryNetworkCredential credential)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		RwcBTiBcNePSUU32cOQf();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			default:
				this.protocol = protocol;
				num = 3;
				break;
			case 2:
				this.credential = credential;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num = 0;
				}
				break;
			case 3:
				this.uri = uri;
				num = 2;
				break;
			}
		}
	}

	internal static void RwcBTiBcNePSUU32cOQf()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool NX6vpsBcPgHcv7Ef6dkf()
	{
		return fnXNqUBce0EEJdQEyJwb == null;
	}

	internal static AsyncDiscoveryState EpmUeOBc1PB4PLmDUIuW()
	{
		return fnXNqUBce0EEJdQEyJwb;
	}
}
