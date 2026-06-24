using System;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using log4net;
using log4net.Core;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Logs;

[Service(Type = ComponentType.Server, EnableInterceptors = false)]
public class DiagnosticsLogManager
{
	private readonly ILog completeSessionLogger;

	private readonly ILog activeSessionLogger;

	private readonly Type callerType;

	private static DiagnosticsLogManager Xdr3L2EVgwsIOdv6LBOk;

	public void Log(DiagnosticsEvent e)
	{
		//Discarded unreachable code: IL_00a3, IL_00b2
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				((ILogger)TcsOX3EVYL7qkVxWTUwR(activeSessionLogger)).Log(callerType, (Level)KSCHAmEVLOZBRYRp3Vyt(e.Level), (object)e, (Exception)null);
				num2 = 4;
				break;
			case 1:
				BXlTn6EVUa32C1ulmPCb(TcsOX3EVYL7qkVxWTUwR(completeSessionLogger), callerType, KSCHAmEVLOZBRYRp3Vyt(e.Level), e, null);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				return;
			case 3:
				if (activeSessionLogger == null)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto default;
			case 4:
				return;
			case 2:
				if (completeSessionLogger != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public DiagnosticsLogManager()
	{
		//Discarded unreachable code: IL_0080, IL_0085
		qZICBBEVsAMsxyU7qANp();
		completeSessionLogger = LogManager.GetLogger((string)GFRjMKEVcXcvRldMD40u(0x18A6761F ^ 0x18A226F7));
		activeSessionLogger = (ILog)y594RKEVzVH0NcgbobFC(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35745549));
		callerType = TypeOf<DiagnosticsLogManager>.Raw;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object TcsOX3EVYL7qkVxWTUwR(object P_0)
	{
		return ((ILoggerWrapper)P_0).get_Logger();
	}

	internal static object KSCHAmEVLOZBRYRp3Vyt(LogLevel level)
	{
		return Log4NetLogger.GetLevel(level);
	}

	internal static void BXlTn6EVUa32C1ulmPCb(object P_0, Type P_1, object P_2, object P_3, object P_4)
	{
		((ILogger)P_0).Log(P_1, (Level)P_2, P_3, (Exception)P_4);
	}

	internal static bool ym2SYNEV5539ti28OE02()
	{
		return Xdr3L2EVgwsIOdv6LBOk == null;
	}

	internal static DiagnosticsLogManager iQoyhkEVjZ7JI30qJMG2()
	{
		return Xdr3L2EVgwsIOdv6LBOk;
	}

	internal static void qZICBBEVsAMsxyU7qANp()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object GFRjMKEVcXcvRldMD40u(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object y594RKEVzVH0NcgbobFC(object P_0)
	{
		return LogManager.GetLogger((string)P_0);
	}
}
