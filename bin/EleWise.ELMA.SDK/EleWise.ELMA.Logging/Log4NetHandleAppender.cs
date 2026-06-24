using System;
using System.Runtime.CompilerServices;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using log4net.Appender;
using log4net.Core;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Logging;

[Component(EnableInterceptiors = false, InjectProerties = false)]
internal class Log4NetHandleAppender : AppenderSkeleton, ILoggerEventHandler
{
	internal static Log4NetHandleAppender h6HSVbhlUT9U56jh7Adh;

	public event LogEventHandler Logged
	{
		[CompilerGenerated]
		add
		{
			int num = 4;
			LogEventHandler logEventHandler2 = default(LogEventHandler);
			LogEventHandler logEventHandler = default(LogEventHandler);
			LogEventHandler value2 = default(LogEventHandler);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 3:
						break;
					case 1:
						if ((object)logEventHandler2 == logEventHandler)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
							{
								num2 = 0;
							}
							continue;
						}
						break;
					case 0:
						return;
					case 4:
						logEventHandler2 = this.Logged;
						num2 = 3;
						continue;
					case 2:
						value2 = (LogEventHandler)fkaGO3hrFRB5JRvrrTSA(logEventHandler, value);
						num2 = 5;
						continue;
					case 5:
						logEventHandler2 = Interlocked.CompareExchange(ref this.Logged, value2, logEventHandler);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				}
				logEventHandler = logEventHandler2;
				num = 2;
			}
		}
		[CompilerGenerated]
		remove
		{
			int num = 2;
			int num2 = num;
			LogEventHandler logEventHandler = default(LogEventHandler);
			LogEventHandler logEventHandler2 = default(LogEventHandler);
			LogEventHandler value2 = default(LogEventHandler);
			while (true)
			{
				switch (num2)
				{
				case 1:
					logEventHandler = logEventHandler2;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 5;
					}
					break;
				case 2:
					logEventHandler2 = this.Logged;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
					{
						num2 = 1;
					}
					break;
				default:
					if ((object)logEventHandler2 == logEventHandler)
					{
						num2 = 4;
						break;
					}
					goto case 1;
				case 3:
					logEventHandler2 = Interlocked.CompareExchange(ref this.Logged, value2, logEventHandler);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 0;
					}
					break;
				case 5:
					value2 = (LogEventHandler)mfD8bchrBU074IlXdY4R(logEventHandler, value);
					num2 = 3;
					break;
				case 4:
					return;
				}
			}
		}
	}

	internal Log4NetHandleAppender()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		v7uPywhlzsugO97qZL0y();
		((AppenderSkeleton)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal void Append(LoggingEventArgs loggingEventArgs)
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
				this.Logged.RaiseSafe(loggingEventArgs);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override void Append([NotNull] LoggingEvent loggingEvent)
	{
		//Discarded unreachable code: IL_00c6, IL_0169, IL_0178, IL_01f7, IL_0206, IL_0216, IL_0269, IL_0278, IL_035c
		int num = 7;
		LoggingEventArgs loggingEventArgs = default(LoggingEventArgs);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					Vd6NGMhrfMTIovhYj9ey(loggingEventArgs, LogLevel.Information);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 0;
					}
					break;
				case 20:
					Vd6NGMhrfMTIovhYj9ey(loggingEventArgs, LogLevel.Debug);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 4;
					}
					break;
				case 19:
					return;
				case 7:
					if (loggingEvent != null)
					{
						goto end_IL_0012;
					}
					goto case 18;
				case 2:
				case 13:
					if (xliEiChrQdtkF9kxtpj7(loggingEvent.get_Level(), Level.Info))
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
						{
							num2 = 8;
						}
						break;
					}
					goto default;
				case 3:
				case 12:
					if (!xliEiChrQdtkF9kxtpj7(q4ZGVAhrCS4nvihY29Z5(loggingEvent), Level.Verbose))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 8;
				case 1:
					Vd6NGMhrfMTIovhYj9ey(loggingEventArgs, LogLevel.Fatal);
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 8;
					}
					break;
				default:
					if (!xliEiChrQdtkF9kxtpj7(q4ZGVAhrCS4nvihY29Z5(loggingEvent), Level.Debug))
					{
						num2 = 23;
						break;
					}
					goto case 20;
				case 5:
					loggingEventArgs.Level = LogLevel.Warning;
					num2 = 14;
					break;
				case 14:
					if (!xliEiChrQdtkF9kxtpj7(q4ZGVAhrCS4nvihY29Z5(loggingEvent), Level.Error))
					{
						num2 = 22;
						break;
					}
					goto case 10;
				case 17:
					if (!xliEiChrQdtkF9kxtpj7(loggingEvent.get_Level(), Level.Trace))
					{
						num2 = 3;
						break;
					}
					goto case 21;
				case 15:
				case 16:
					Append(loggingEventArgs);
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
					{
						num2 = 16;
					}
					break;
				case 21:
					Vd6NGMhrfMTIovhYj9ey(loggingEventArgs, LogLevel.Trace);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num2 = 12;
					}
					break;
				case 8:
					Vd6NGMhrfMTIovhYj9ey(loggingEventArgs, LogLevel.Verbose);
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 13;
					}
					break;
				case 10:
					Vd6NGMhrfMTIovhYj9ey(loggingEventArgs, LogLevel.Error);
					num2 = 11;
					break;
				case 18:
					throw new ArgumentNullException((string)Pm5mQihrWkT7VnNNkVIf(-787452571 ^ -787219551));
				case 6:
				{
					LoggingEventArgs loggingEventArgs2 = new LoggingEventArgs();
					nIHR08hrbROnWLQTML3t(loggingEventArgs2, qkDTQ1hroetR6O0sclOP(loggingEvent));
					reREPLhrhot0CTkPuEmO(loggingEventArgs2, loggingEvent.get_ExceptionObject());
					JOAQ8YhrEsxEL8JeNhJi(loggingEventArgs2, rF9AeVhrG2KhQ1YRgDoQ(loggingEvent));
					Vd6NGMhrfMTIovhYj9ey(loggingEventArgs2, LogLevel.Verbose);
					loggingEventArgs = loggingEventArgs2;
					num2 = 17;
					break;
				}
				case 4:
				case 23:
					if (xliEiChrQdtkF9kxtpj7(q4ZGVAhrCS4nvihY29Z5(loggingEvent), Level.Warn))
					{
						num2 = 5;
						break;
					}
					goto case 14;
				case 11:
				case 22:
					if (!xliEiChrQdtkF9kxtpj7(q4ZGVAhrCS4nvihY29Z5(loggingEvent), Level.Fatal))
					{
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 1;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 6;
		}
	}

	internal static void v7uPywhlzsugO97qZL0y()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool PR75F6hlsst5vqPb95Gl()
	{
		return h6HSVbhlUT9U56jh7Adh == null;
	}

	internal static Log4NetHandleAppender EiLsKphlc8UM182HO7lD()
	{
		return h6HSVbhlUT9U56jh7Adh;
	}

	internal static object fkaGO3hrFRB5JRvrrTSA(object P_0, object P_1)
	{
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	internal static object mfD8bchrBU074IlXdY4R(object P_0, object P_1)
	{
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	internal static object Pm5mQihrWkT7VnNNkVIf(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static DateTime qkDTQ1hroetR6O0sclOP(object P_0)
	{
		return ((LoggingEvent)P_0).get_TimeStamp();
	}

	internal static void nIHR08hrbROnWLQTML3t(object P_0, DateTime value)
	{
		((LoggingEventArgs)P_0).TimeStamp = value;
	}

	internal static void reREPLhrhot0CTkPuEmO(object P_0, object P_1)
	{
		((LoggingEventArgs)P_0).Exception = (Exception)P_1;
	}

	internal static object rF9AeVhrG2KhQ1YRgDoQ(object P_0)
	{
		return ((LoggingEvent)P_0).get_RenderedMessage();
	}

	internal static void JOAQ8YhrEsxEL8JeNhJi(object P_0, object P_1)
	{
		((LoggingEventArgs)P_0).Message = (string)P_1;
	}

	internal static void Vd6NGMhrfMTIovhYj9ey(object P_0, LogLevel value)
	{
		((LoggingEventArgs)P_0).Level = value;
	}

	internal static bool xliEiChrQdtkF9kxtpj7(object P_0, object P_1)
	{
		return (Level)P_0 == (Level)P_1;
	}

	internal static object q4ZGVAhrCS4nvihY29Z5(object P_0)
	{
		return ((LoggingEvent)P_0).get_Level();
	}
}
