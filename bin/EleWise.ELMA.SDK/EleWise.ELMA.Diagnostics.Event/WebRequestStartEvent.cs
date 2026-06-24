using System.Runtime.CompilerServices;
using System.Web;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Events;

public class WebRequestStartEvent : DiagnosticsEvent
{
	private static WebRequestStartEvent IE5RXwEkfkO1yinZUuEl;

	public HttpContext Context
	{
		[CompilerGenerated]
		get
		{
			return _003CContext_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CContext_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public WebRequestStartEvent(CallContextInfo callContextInfo, HttpContext context)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		wgl7Y5EkvKoeROh44U6L();
		base._002Ector(callContextInfo);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				Context = context;
				num = 2;
				break;
			case 3:
				base.Message = SR.T(true, (string)moiuRWEk8CboruTYXIiF(0x463A0F3C ^ 0x463E564E), callContextInfo.StartTime.ConvertUtcToLocal().ToString((string)moiuRWEk8CboruTYXIiF(-309639236 ^ -309375486)), callContextInfo.ManagedThreadId, rLr4r4EkZrciQ2GbC6aT(callContextInfo), Kj8QrkEkuVpoQltuqwwD(callContextInfo), f1MwgrEkIyRjwxpeSdDe(callContextInfo));
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
				{
					num = 0;
				}
				break;
			case 2:
				base.Level = LogLevel.Information;
				num = 3;
				break;
			case 1:
				return;
			}
		}
	}

	internal static void wgl7Y5EkvKoeROh44U6L()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object moiuRWEk8CboruTYXIiF(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object rLr4r4EkZrciQ2GbC6aT(object P_0)
	{
		return ((CallContextInfo)P_0).HttpMethod;
	}

	internal static object Kj8QrkEkuVpoQltuqwwD(object P_0)
	{
		return ((CallContextInfo)P_0).Name;
	}

	internal static object f1MwgrEkIyRjwxpeSdDe(object P_0)
	{
		return ((CallContextInfo)P_0).UserHostAddress;
	}

	internal static bool jQQi9yEkQikklVAp4DnX()
	{
		return IE5RXwEkfkO1yinZUuEl == null;
	}

	internal static WebRequestStartEvent HVYC5mEkCW6pnh3DfrCM()
	{
		return IE5RXwEkfkO1yinZUuEl;
	}
}
