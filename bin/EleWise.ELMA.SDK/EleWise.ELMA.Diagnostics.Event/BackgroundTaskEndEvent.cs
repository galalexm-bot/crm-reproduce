using System;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Events;

public class BackgroundTaskEndEvent : DiagnosticsEvent
{
	internal static BackgroundTaskEndEvent kOd07CETQic2Q9JtoFOP;

	public BackgroundTaskEndEvent(CallContextInfo callContextInfo)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		V3KbnOET8g7ifnq0f3iy();
		base._002Ector(callContextInfo);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
				base.Level = LogLevel.Information;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num = 0;
				}
				continue;
			}
			base.Message = SR.T(true, (string)GKSthEETZnkMZWqhYq0c(0x12A5FAC7 ^ 0x12A1AC69), (int)khChigETu2RSxxaQv5Ye(callContextInfo).TotalMilliseconds, x5g0OrETIcHxbfDUkSAP(callContextInfo));
			num = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
			{
				num = 0;
			}
		}
	}

	internal static void V3KbnOET8g7ifnq0f3iy()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object GKSthEETZnkMZWqhYq0c(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static TimeSpan khChigETu2RSxxaQv5Ye(object P_0)
	{
		return ((CallContextInfo)P_0).TotalTime;
	}

	internal static object x5g0OrETIcHxbfDUkSAP(object P_0)
	{
		return ((CallContextInfo)P_0).Name;
	}

	internal static bool V2FXQFETCOlBOadUhvO0()
	{
		return kOd07CETQic2Q9JtoFOP == null;
	}

	internal static BackgroundTaskEndEvent BHEuRJETvfT3BZdp2fdJ()
	{
		return kOd07CETQic2Q9JtoFOP;
	}
}
