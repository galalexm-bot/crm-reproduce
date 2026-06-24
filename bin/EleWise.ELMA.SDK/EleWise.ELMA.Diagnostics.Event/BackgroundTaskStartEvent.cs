using System;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Events;

public class BackgroundTaskStartEvent : DiagnosticsEvent
{
	private static BackgroundTaskStartEvent OJKyeDETX8Um8VyDfS7x;

	public BackgroundTaskStartEvent(CallContextInfo callContextInfo)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		zBU6rvETnWZu1jqLsGbD();
		base._002Ector(callContextInfo);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
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
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
				{
					num = 0;
				}
				continue;
			}
			base.Message = SR.T(true, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A4C7B29 ^ 0x5A482C55), hA8je9ETOSEseC94pMGS(callContextInfo).ConvertUtcToLocal().ToString((string)RkrWJpET2HFNjm526rsB(-606654180 ^ -606914398)), u76aw5ETehCjrqdG7TeM(callContextInfo), R7D9yqETP0NuUsBU7wNZ(callContextInfo));
			num = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
			{
				num = 0;
			}
		}
	}

	internal static void zBU6rvETnWZu1jqLsGbD()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static DateTime hA8je9ETOSEseC94pMGS(object P_0)
	{
		return ((CallContextInfo)P_0).StartTime;
	}

	internal static object RkrWJpET2HFNjm526rsB(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static long u76aw5ETehCjrqdG7TeM(object P_0)
	{
		return ((CallContextInfo)P_0).ManagedThreadId;
	}

	internal static object R7D9yqETP0NuUsBU7wNZ(object P_0)
	{
		return ((CallContextInfo)P_0).Name;
	}

	internal static bool t2X98XETTq197f9K9Ibw()
	{
		return OJKyeDETX8Um8VyDfS7x == null;
	}

	internal static BackgroundTaskStartEvent b24M0xETkZ6SpTC2NuFn()
	{
		return OJKyeDETX8Um8VyDfS7x;
	}
}
