using System;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Events;

public class BackgroundTaskErrorEvent : DiagnosticsEvent
{
	private static BackgroundTaskErrorEvent YAnuBIETVHmDg1ilhJ6g;

	public BackgroundTaskErrorEvent(CallContextInfo callContextInfo)
	{
		//Discarded unreachable code: IL_002b
		n5iVyWETRHQWxfMJXwZ1();
		base._002Ector(callContextInfo);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			default:
				base.Level = LogLevel.Error;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num = 1;
				}
				break;
			case 1:
			{
				base.Message = SR.T(true, (string)E9UisnETq8v69xfq4l3h(-2112703338 ^ -2112429182), (int)djrCEyETKih7V1l3ow1F(callContextInfo).TotalMilliseconds, callContextInfo.Name);
				int num2 = 2;
				num = num2;
				break;
			}
			}
		}
	}

	internal static void n5iVyWETRHQWxfMJXwZ1()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object E9UisnETq8v69xfq4l3h(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static TimeSpan djrCEyETKih7V1l3ow1F(object P_0)
	{
		return ((CallContextInfo)P_0).TotalTime;
	}

	internal static bool g5nfoMETSBZqDgZLqOQH()
	{
		return YAnuBIETVHmDg1ilhJ6g == null;
	}

	internal static BackgroundTaskErrorEvent V4FrKtETiUT1RwhyBv4W()
	{
		return YAnuBIETVHmDg1ilhJ6g;
	}
}
