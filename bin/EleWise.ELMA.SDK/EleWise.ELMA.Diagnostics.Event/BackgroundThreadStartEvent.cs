using System;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Events;

public class BackgroundThreadStartEvent : DiagnosticsEvent
{
	private static BackgroundThreadStartEvent JBwFysEKN8YAqtonAcag;

	public BackgroundThreadStartEvent(CallContextInfo callContextInfo)
	{
		//Discarded unreachable code: IL_001f
		GMA4CTEKaZ1bIADNe2Un();
		base._002Ector(callContextInfo);
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				base.Level = LogLevel.Information;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				return;
			}
			base.Message = SR.T(true, (string)TTBIDoEKDBfw9VQyw8fC(0x63ABA4E8 ^ 0x63AFF146), yVAiWwEKtmsF8CgJhjr1(callContextInfo.StartTime).ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837926459)), SPGHT9EKwLwcsYmeiQ2o(callContextInfo), juLe1FEK4m1kpVyRUINu(callContextInfo));
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
			{
				num2 = 0;
			}
		}
	}

	internal static void GMA4CTEKaZ1bIADNe2Un()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object TTBIDoEKDBfw9VQyw8fC(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static DateTime yVAiWwEKtmsF8CgJhjr1(DateTime dateTime)
	{
		return dateTime.ConvertUtcToLocal();
	}

	internal static long SPGHT9EKwLwcsYmeiQ2o(object P_0)
	{
		return ((CallContextInfo)P_0).ManagedThreadId;
	}

	internal static object juLe1FEK4m1kpVyRUINu(object P_0)
	{
		return ((CallContextInfo)P_0).Name;
	}

	internal static bool uZr9oTEK3QMiy2uuMB52()
	{
		return JBwFysEKN8YAqtonAcag == null;
	}

	internal static BackgroundThreadStartEvent T8tQ1IEKpXnu4UVDNawu()
	{
		return JBwFysEKN8YAqtonAcag;
	}
}
