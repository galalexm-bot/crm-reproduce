using System.Runtime.CompilerServices;
using System.Web;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Events;

public class WebRequestEndEvent : DiagnosticsEvent
{
	internal static WebRequestEndEvent kxDInFETL7JinKlWkZP5;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public WebRequestEndEvent(CallContextInfo callContextInfo, HttpContext context)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		daCm54ETcaUT1fDLmKRA();
		base._002Ector(callContextInfo);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				Context = context;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num = 1;
				}
				break;
			case 2:
				base.Message = SR.T(true, (string)yrGmU1ETzS1sQqFDT6Qf(-35995181 ^ -35743471), (int)callContextInfo.TotalTime.TotalMilliseconds, QmGppAEkFAnELaHCUg2U(callContextInfo), callContextInfo.Name);
				num = 3;
				break;
			case 1:
				base.Level = LogLevel.Information;
				num = 2;
				break;
			case 3:
				return;
			}
		}
	}

	internal static void daCm54ETcaUT1fDLmKRA()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object yrGmU1ETzS1sQqFDT6Qf(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object QmGppAEkFAnELaHCUg2U(object P_0)
	{
		return ((CallContextInfo)P_0).HttpMethod;
	}

	internal static bool LpETmLETU36LrI0XY6Ns()
	{
		return kxDInFETL7JinKlWkZP5 == null;
	}

	internal static WebRequestEndEvent BXTNpHETshSVcwK6WJI5()
	{
		return kxDInFETL7JinKlWkZP5;
	}
}
