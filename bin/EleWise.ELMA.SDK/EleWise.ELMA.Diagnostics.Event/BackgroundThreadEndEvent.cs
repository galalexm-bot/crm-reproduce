using System;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Events;

public class BackgroundThreadEndEvent : DiagnosticsEvent
{
	internal static BackgroundThreadEndEvent VLoaL1EKnGu7grEmUBxh;

	public BackgroundThreadEndEvent(CallContextInfo callContextInfo)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		g9fOPNEKedKhubFvelbg();
		base._002Ector(callContextInfo);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				base.Message = SR.T(true, (string)uWXV2PEKPa9GrnompOBc(0x68BBB53E ^ 0x68BFE078), (int)hVcMtaEK1rKbWqWslDae(callContextInfo).TotalMilliseconds, callContextInfo.Name);
				num = 2;
				continue;
			case 2:
				return;
			}
			base.Level = LogLevel.Information;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
			{
				num = 1;
			}
		}
	}

	internal static void g9fOPNEKedKhubFvelbg()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object uWXV2PEKPa9GrnompOBc(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static TimeSpan hVcMtaEK1rKbWqWslDae(object P_0)
	{
		return ((CallContextInfo)P_0).TotalTime;
	}

	internal static bool W0vWkIEKOrrHY05aos95()
	{
		return VLoaL1EKnGu7grEmUBxh == null;
	}

	internal static BackgroundThreadEndEvent KPSbHsEK2w7uebRJa3HR()
	{
		return VLoaL1EKnGu7grEmUBxh;
	}
}
