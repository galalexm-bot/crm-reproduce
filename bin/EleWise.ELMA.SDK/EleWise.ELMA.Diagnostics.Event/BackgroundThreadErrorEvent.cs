using System;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Events;

public class BackgroundThreadErrorEvent : DiagnosticsEvent
{
	internal static BackgroundThreadErrorEvent YIZqTHEKiE71YPLNUn3Z;

	public BackgroundThreadErrorEvent(CallContextInfo callContextInfo)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		QnwALrEKK7KgfHeAMAvv();
		base._002Ector(callContextInfo);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				base.Message = SR.T(true, (string)NZPLXGEKXFAOw3MPn0ml(-542721635 ^ -542970497), (int)FGdxPZEKTSeWDgvPCpTG(callContextInfo).TotalMilliseconds, GMEpDuEKkcMecHKkMJij(callContextInfo));
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			default:
				base.Level = LogLevel.Error;
				num = 2;
				break;
			}
		}
	}

	internal static void QnwALrEKK7KgfHeAMAvv()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object NZPLXGEKXFAOw3MPn0ml(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static TimeSpan FGdxPZEKTSeWDgvPCpTG(object P_0)
	{
		return ((CallContextInfo)P_0).TotalTime;
	}

	internal static object GMEpDuEKkcMecHKkMJij(object P_0)
	{
		return ((CallContextInfo)P_0).Name;
	}

	internal static bool EAHSQUEKR1iDe9EcQBxg()
	{
		return YIZqTHEKiE71YPLNUn3Z == null;
	}

	internal static BackgroundThreadErrorEvent jQVuruEKqcc4yuHg9AJn()
	{
		return YIZqTHEKiE71YPLNUn3Z;
	}
}
