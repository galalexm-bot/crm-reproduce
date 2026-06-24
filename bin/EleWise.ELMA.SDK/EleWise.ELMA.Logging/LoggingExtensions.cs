using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Services;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Logging;

public static class LoggingExtensions
{
	public const string CONTEXT_LOG_CALL_TYPE_KEY = "EleWise.ELMA.Logging.LoggingExtensions.ContextCallType";

	internal static LoggingExtensions tkG30Mhl8R3J75S1mhjP;

	public static bool IsVerboseEnabled(this ILogger log)
	{
		return log.IsEnabled(LogLevel.Verbose);
	}

	public static bool IsTraceEnabled(this ILogger log)
	{
		return log.IsEnabled(LogLevel.Trace);
	}

	public static bool IsDebugEnabled(this ILogger log)
	{
		return buKaZQhlIBuDdLWyTtfb(log, LogLevel.Debug);
	}

	public static bool IsInfoEnabled(this ILogger log)
	{
		return buKaZQhlIBuDdLWyTtfb(log, LogLevel.Information);
	}

	public static bool IsWarnEnabled(this ILogger log)
	{
		return buKaZQhlIBuDdLWyTtfb(log, LogLevel.Warning);
	}

	public static bool IsErrorEnabled(this ILogger log)
	{
		return log.IsEnabled(LogLevel.Error);
	}

	public static bool IsFatalEnabled(this ILogger log)
	{
		return buKaZQhlIBuDdLWyTtfb(log, LogLevel.Fatal);
	}

	public static void Verbose(this ILogger logger, object message)
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
				CFc3UlhlVhaoLL6ktxNV(logger, LogLevel.Verbose, message);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void Trace(this ILogger logger, object message)
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
				logger.Log(LogLevel.Trace, message);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void Debug(this ILogger logger, object message)
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
				logger.Log(LogLevel.Debug, message);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void Info(this ILogger logger, object message)
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
				CFc3UlhlVhaoLL6ktxNV(logger, LogLevel.Information, message);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void Warn(this ILogger logger, object message)
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
				CFc3UlhlVhaoLL6ktxNV(logger, LogLevel.Warning, message);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public static void Error(this ILogger logger, object message)
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
				CFc3UlhlVhaoLL6ktxNV(logger, LogLevel.Error, message);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public static void Fatal(this ILogger logger, object message)
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
				CFc3UlhlVhaoLL6ktxNV(logger, LogLevel.Fatal, message);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public static void Log(this ILogger logger, LogLevel level, object message)
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
				UlxBLPhlSIMjgwpjPXGw(logger, level, null, message, null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void Verbose(this ILogger logger, object message, Exception exception)
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
				logger.Log(LogLevel.Verbose, message, exception);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void Trace(this ILogger logger, object message, Exception exception)
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
				GJ90ONhlisSfgjgFfgsl(logger, LogLevel.Trace, message, exception);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public static void Debug(this ILogger logger, object message, Exception exception)
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
				GJ90ONhlisSfgjgFfgsl(logger, LogLevel.Debug, message, exception);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void Info(this ILogger logger, object message, Exception exception)
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
				GJ90ONhlisSfgjgFfgsl(logger, LogLevel.Information, message, exception);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void Warn(this ILogger logger, object message, Exception exception)
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
				GJ90ONhlisSfgjgFfgsl(logger, LogLevel.Warning, message, exception);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public static void Error(this ILogger logger, object message, Exception exception)
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
				GJ90ONhlisSfgjgFfgsl(logger, LogLevel.Error, message, exception);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public static void Fatal(this ILogger logger, object message, Exception exception)
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
				GJ90ONhlisSfgjgFfgsl(logger, LogLevel.Fatal, message, exception);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void Log(this ILogger logger, LogLevel level, object message, Exception exception)
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
				UlxBLPhlSIMjgwpjPXGw(logger, level, exception, message, null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void VerboseFormat(this ILogger logger, string format, params object[] args)
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
				logger.LogFormat(LogLevel.Verbose, format, args);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void TraceFormat(this ILogger logger, string format, params object[] args)
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
				logger.LogFormat(LogLevel.Trace, format, args);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public static void DebugFormat(this ILogger logger, string format, params object[] args)
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
				logger.LogFormat(LogLevel.Debug, format, args);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void InfoFormat(this ILogger logger, string format, params object[] args)
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
				logger.LogFormat(LogLevel.Information, format, args);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void WarnFormat(this ILogger logger, string format, params object[] args)
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
				logger.LogFormat(LogLevel.Warning, format, args);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public static void ErrorFormat(this ILogger logger, string format, params object[] args)
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
				logger.LogFormat(LogLevel.Error, format, args);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void FatalFormat(this ILogger logger, string format, params object[] args)
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
				logger.LogFormat(LogLevel.Fatal, format, args);
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

	public static void LogFormat(this ILogger logger, LogLevel level, string format, params object[] args)
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
				FilteredLog(logger, level, null, format, args);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void Verbose(this ILogger logger, Exception exception, string format, params object[] args)
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
				Log(logger, LogLevel.Verbose, exception, format, args);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void Trace(this ILogger logger, Exception exception, string format, params object[] args)
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
				Log(logger, LogLevel.Trace, exception, format, args);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void Debug(this ILogger logger, Exception exception, string format, params object[] args)
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
				Log(logger, LogLevel.Debug, exception, format, args);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public static void Info(this ILogger logger, Exception exception, string format, params object[] args)
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
				Log(logger, LogLevel.Information, exception, format, args);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void Warn(this ILogger logger, Exception exception, string format, params object[] args)
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
				Log(logger, LogLevel.Warning, exception, format, args);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void Error(this ILogger logger, Exception exception, string format, params object[] args)
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
				Log(logger, LogLevel.Error, exception, format, args);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void Fatal(this ILogger logger, Exception exception, string format, params object[] args)
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
				Log(logger, LogLevel.Fatal, exception, format, args);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public static void Log(this ILogger logger, LogLevel level, Exception exception, string format, params object[] args)
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
				UlxBLPhlSIMjgwpjPXGw(logger, level, exception, format, args);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private static void FilteredLog(object logger, LogLevel level, object exception, object format, object objects)
	{
		//Discarded unreachable code: IL_00a9, IL_00b8, IL_0117, IL_0126, IL_0143, IL_01eb, IL_020a, IL_0219, IL_0236, IL_0245, IL_0255, IL_0264, IL_0275
		int num = 5;
		IDisposable disposable = default(IDisposable);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					disposable = (IDisposable)Wb3fS2hlRq6h7cKNrtdJ();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					return;
				case 6:
					return;
				case 5:
					if (logger == null)
					{
						return;
					}
					goto end_IL_0012;
				case 1:
					return;
				case 4:
					if (!((ILogger)logger).IsEnabled(level))
					{
						num2 = 3;
						continue;
					}
					goto case 2;
				}
				try
				{
					int num3;
					if (!z8ohvWhlqAFnwfPhWd5j())
					{
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num3 = 1;
						}
						goto IL_0082;
					}
					goto IL_00c3;
					IL_007e:
					int num4;
					num3 = num4;
					goto IL_0082;
					IL_0082:
					switch (num3)
					{
					case 4:
						goto IL_00ed;
					case 2:
						return;
					case 5:
						goto IL_0131;
					case 1:
						goto IL_0148;
					case 3:
						return;
					}
					goto IL_00c3;
					IL_00c3:
					if (SjbQ3ChlKyS73KRtRKeF(ComponentManager.Current) != ComponentManager.LifetimeStage.Disposed)
					{
						num3 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
						{
							num3 = 2;
						}
						goto IL_0082;
					}
					goto IL_0148;
					IL_00ed:
					ContextVars.Set<Type>((string)CHQfMphlTFs9675WNTMs(--1418440330 ^ 0x5488386A), null);
					num4 = 3;
					goto IL_007e;
					IL_0131:
					int num5 = ((SjbQ3ChlKyS73KRtRKeF(SUlnIkhlXTNEmGpUteIT()) != ComponentManager.LifetimeStage.BeforeInit) ? 1 : 0);
					if (num5 != 0 && !jY7ktchlkM3RMbroWyqV(CHQfMphlTFs9675WNTMs(-289714582 ^ -289875830)))
					{
						ContextVars.Set(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x53F3A43), ByavuKhlnoU1muoD8XQT(typeof(LoggingExtensions).TypeHandle));
					}
					goto IL_0189;
					IL_0148:
					num5 = 0;
					goto IL_0189;
					IL_0189:
					string format2 = ((format != null) ? format.ToString() : "");
					((ILogger)logger).Log(level, (Exception)exception, format2, (object[])objects);
					if (num5 == 0)
					{
						num4 = 2;
						goto IL_007e;
					}
					goto IL_00ed;
				}
				finally
				{
					int num6;
					if (disposable == null)
					{
						num6 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
						{
							num6 = 0;
						}
						goto IL_01ef;
					}
					goto IL_0224;
					IL_0224:
					s3JNJfhlOK2tfnnMbZob(disposable);
					num6 = 2;
					goto IL_01ef;
					IL_01ef:
					switch (num6)
					{
					case 1:
						goto end_IL_01ca;
					case 2:
						goto end_IL_01ca;
					}
					goto IL_0224;
					end_IL_01ca:;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	internal static bool ViiBFIhlZPxO7P7nhW8i()
	{
		return tkG30Mhl8R3J75S1mhjP == null;
	}

	internal static LoggingExtensions l8FQHqhlumex8LCaaJYH()
	{
		return tkG30Mhl8R3J75S1mhjP;
	}

	internal static bool buKaZQhlIBuDdLWyTtfb(object P_0, LogLevel level)
	{
		return ((ILogger)P_0).IsEnabled(level);
	}

	internal static void CFc3UlhlVhaoLL6ktxNV(object P_0, LogLevel level, object P_2)
	{
		((ILogger)P_0).Log(level, P_2);
	}

	internal static void UlxBLPhlSIMjgwpjPXGw(object P_0, LogLevel level, object P_2, object P_3, object P_4)
	{
		FilteredLog(P_0, level, P_2, P_3, P_4);
	}

	internal static void GJ90ONhlisSfgjgFfgsl(object P_0, LogLevel level, object P_2, object P_3)
	{
		((ILogger)P_0).Log(level, P_2, (Exception)P_3);
	}

	internal static object Wb3fS2hlRq6h7cKNrtdJ()
	{
		return ELMAContext.Create();
	}

	internal static bool z8ohvWhlqAFnwfPhWd5j()
	{
		return ComponentManager.Initialized;
	}

	internal static ComponentManager.LifetimeStage SjbQ3ChlKyS73KRtRKeF(object P_0)
	{
		return ((ComponentManager)P_0).Stage;
	}

	internal static object SUlnIkhlXTNEmGpUteIT()
	{
		return ComponentManager.Current;
	}

	internal static object CHQfMphlTFs9675WNTMs(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool jY7ktchlkM3RMbroWyqV(object P_0)
	{
		return ContextVars.Contains((string)P_0);
	}

	internal static Type ByavuKhlnoU1muoD8XQT(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void s3JNJfhlOK2tfnnMbZob(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}
