using System.Runtime.CompilerServices;
using System.Web;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Events;

public class WebRequestErrorEvent : DiagnosticsEvent
{
	private static WebRequestErrorEvent NakBsTEkBo73EM337Cdw;

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
				case 1:
					_003CContext_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
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

	public WebRequestErrorEvent(CallContextInfo callContextInfo, HttpContext context)
	{
		//Discarded unreachable code: IL_001b, IL_0020
		wrkGvdEkbGuwXaRWWuxs();
		base._002Ector(callContextInfo);
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				base.Level = LogLevel.Error;
				num = 3;
				break;
			case 2:
				Context = context;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			case 3:
				base.Message = SR.T(true, (string)afaR29Ekh1gG0TaYuoNH(0x57A5235E ^ 0x57A17A4E), (int)callContextInfo.TotalTime.TotalMilliseconds, fqD3ENEkG5e0HdVWDY1r(callContextInfo), dsTFG1EkEaPUn6QTK5R5(callContextInfo));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	internal static void wrkGvdEkbGuwXaRWWuxs()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object afaR29Ekh1gG0TaYuoNH(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object fqD3ENEkG5e0HdVWDY1r(object P_0)
	{
		return ((CallContextInfo)P_0).HttpMethod;
	}

	internal static object dsTFG1EkEaPUn6QTK5R5(object P_0)
	{
		return ((CallContextInfo)P_0).Name;
	}

	internal static bool bTW25BEkWhMwjIUWZyZ5()
	{
		return NakBsTEkBo73EM337Cdw == null;
	}

	internal static WebRequestErrorEvent SkcpdREkoGRulRguiG0j()
	{
		return NakBsTEkBo73EM337Cdw;
	}
}
