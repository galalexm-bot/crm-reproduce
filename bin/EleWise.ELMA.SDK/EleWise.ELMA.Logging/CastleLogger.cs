using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Castle.Core.Logging;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Logging;

internal class CastleLogger : ILogger
{
	private readonly ILogger castleLogger;

	internal static CastleLogger pZSJxshdBAnMXM7qsaZh;

	public event EventHandler ConfigurationChanged
	{
		[CompilerGenerated]
		add
		{
			int num = 3;
			int num2 = num;
			EventHandler eventHandler2 = default(EventHandler);
			EventHandler value2 = default(EventHandler);
			EventHandler eventHandler = default(EventHandler);
			while (true)
			{
				switch (num2)
				{
				case 3:
					eventHandler2 = this.ConfigurationChanged;
					num2 = 2;
					break;
				case 1:
					value2 = (EventHandler)LuxCDkhdRNcDmY1YaXKw(eventHandler, value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					return;
				case 5:
					if ((object)eventHandler2 == eventHandler)
					{
						num2 = 4;
						break;
					}
					goto case 2;
				case 2:
					eventHandler = eventHandler2;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 1;
					}
					break;
				default:
					eventHandler2 = Interlocked.CompareExchange(ref this.ConfigurationChanged, value2, eventHandler);
					num2 = 5;
					break;
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			int num = 3;
			EventHandler eventHandler2 = default(EventHandler);
			EventHandler eventHandler = default(EventHandler);
			EventHandler value2 = default(EventHandler);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						if ((object)eventHandler2 == eventHandler)
						{
							num = 4;
							break;
						}
						goto case 2;
					case 3:
						eventHandler2 = this.ConfigurationChanged;
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
						{
							num2 = 1;
						}
						continue;
					default:
						eventHandler2 = Interlocked.CompareExchange(ref this.ConfigurationChanged, value2, eventHandler);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
						{
							num2 = 0;
						}
						continue;
					case 4:
						return;
					case 5:
						value2 = (EventHandler)K7GboOhdqRKQY3WJ0UgH(eventHandler, value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
						{
							num2 = 0;
						}
						continue;
					case 2:
						eventHandler = eventHandler2;
						num = 5;
						break;
					}
					break;
				}
			}
		}
	}

	public CastleLogger(ILogger castleLogger)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		I2WwJ7hdb8l3wVY54dOs();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				this.castleLogger = castleLogger;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public bool IsEnabled(LogLevel level)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return EWEdt9hdhvKFXeMjHqYl(castleLogger);
			default:
				return false;
			case 1:
				{
					switch (level)
					{
					case LogLevel.Verbose:
					case LogLevel.Trace:
					case LogLevel.Debug:
						break;
					case LogLevel.Information:
						return yHEi4XhdGaqGkFtO0ntU(castleLogger);
					case LogLevel.Warning:
						return RE1Q6RhdEfO4eOoZ9Gcy(castleLogger);
					case LogLevel.Error:
						return castleLogger.get_IsErrorEnabled();
					case LogLevel.Fatal:
						return hBcQdmhdfs0ay7Nu25JI(castleLogger);
					default:
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
						{
							num2 = 0;
						}
						goto end_IL_0012;
					}
					goto case 2;
				}
				end_IL_0012:
				break;
			}
		}
	}

	public void Log(LogLevel level, Exception exception, string format, params object[] args)
	{
		//Discarded unreachable code: IL_01e8
		int num = 14;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				return;
			case 6:
				return;
			case 0:
				return;
			case 12:
				return;
			case 11:
				return;
			case 7:
				return;
			case 5:
				return;
			case 14:
				if (args != null)
				{
					num2 = 13;
					continue;
				}
				break;
			case 3:
				return;
			case 9:
				return;
			case 13:
				switch (level)
				{
				case LogLevel.Fatal:
					Alh9QphdiX8BG0mFIRfS(castleLogger, exception, format, args);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num2 = 12;
					}
					break;
				case LogLevel.Information:
					fTOpLxhdI9l2VmiySeyp(castleLogger, exception, format, args);
					num2 = 4;
					break;
				case LogLevel.Verbose:
				case LogLevel.Trace:
				case LogLevel.Debug:
					Md7tPUhdug9Bskb6Q2qn(castleLogger, exception, format, args);
					num2 = 7;
					break;
				default:
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num2 = 5;
					}
					break;
				case LogLevel.Error:
					bjovochdSGqvZJyYuNhF(castleLogger, exception, format, args);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 0;
					}
					break;
				case LogLevel.Warning:
					MnWkJZhdVBe3H7Aw1PMa(castleLogger, exception, format, args);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 1;
					}
					break;
				}
				continue;
			case 10:
				return;
			case 1:
				return;
			case 8:
				break;
			case 4:
				return;
			}
			switch (level)
			{
			case LogLevel.Fatal:
				AdgvTIhdZx68tdP6VHvI(castleLogger, format, exception);
				num2 = 9;
				break;
			case LogLevel.Verbose:
			case LogLevel.Trace:
			case LogLevel.Debug:
				TMapFHhdQNSDaytJpiBE(castleLogger, format, exception);
				num2 = 11;
				break;
			case LogLevel.Information:
				sj3m3phdCPPiNhymZaY6(castleLogger, format, exception);
				num2 = 3;
				break;
			case LogLevel.Warning:
				h3lZSKhdvIacGrne6JL4(castleLogger, format, exception);
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
				{
					num2 = 2;
				}
				break;
			case LogLevel.Error:
				xBaKryhd8THpyJbnkHnw(castleLogger, format, exception);
				num2 = 2;
				break;
			default:
				num2 = 6;
				break;
			}
		}
	}

	internal static void I2WwJ7hdb8l3wVY54dOs()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool xxErg4hdWeHnA7pms5M7()
	{
		return pZSJxshdBAnMXM7qsaZh == null;
	}

	internal static CastleLogger Co8Bs4hdo0AXDYOR0d0w()
	{
		return pZSJxshdBAnMXM7qsaZh;
	}

	internal static bool EWEdt9hdhvKFXeMjHqYl(object P_0)
	{
		return ((ILogger)P_0).get_IsDebugEnabled();
	}

	internal static bool yHEi4XhdGaqGkFtO0ntU(object P_0)
	{
		return ((ILogger)P_0).get_IsInfoEnabled();
	}

	internal static bool RE1Q6RhdEfO4eOoZ9Gcy(object P_0)
	{
		return ((ILogger)P_0).get_IsWarnEnabled();
	}

	internal static bool hBcQdmhdfs0ay7Nu25JI(object P_0)
	{
		return ((ILogger)P_0).get_IsFatalEnabled();
	}

	internal static void TMapFHhdQNSDaytJpiBE(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Debug((string)P_1, (Exception)P_2);
	}

	internal static void sj3m3phdCPPiNhymZaY6(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Info((string)P_1, (Exception)P_2);
	}

	internal static void h3lZSKhdvIacGrne6JL4(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Warn((string)P_1, (Exception)P_2);
	}

	internal static void xBaKryhd8THpyJbnkHnw(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error((string)P_1, (Exception)P_2);
	}

	internal static void AdgvTIhdZx68tdP6VHvI(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Fatal((string)P_1, (Exception)P_2);
	}

	internal static void Md7tPUhdug9Bskb6Q2qn(object P_0, object P_1, object P_2, object P_3)
	{
		((ILogger)P_0).DebugFormat((Exception)P_1, (string)P_2, (object[])P_3);
	}

	internal static void fTOpLxhdI9l2VmiySeyp(object P_0, object P_1, object P_2, object P_3)
	{
		((ILogger)P_0).InfoFormat((Exception)P_1, (string)P_2, (object[])P_3);
	}

	internal static void MnWkJZhdVBe3H7Aw1PMa(object P_0, object P_1, object P_2, object P_3)
	{
		((ILogger)P_0).WarnFormat((Exception)P_1, (string)P_2, (object[])P_3);
	}

	internal static void bjovochdSGqvZJyYuNhF(object P_0, object P_1, object P_2, object P_3)
	{
		((ILogger)P_0).ErrorFormat((Exception)P_1, (string)P_2, (object[])P_3);
	}

	internal static void Alh9QphdiX8BG0mFIRfS(object P_0, object P_1, object P_2, object P_3)
	{
		((ILogger)P_0).FatalFormat((Exception)P_1, (string)P_2, (object[])P_3);
	}

	internal static object LuxCDkhdRNcDmY1YaXKw(object P_0, object P_1)
	{
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	internal static object K7GboOhdqRKQY3WJ0UgH(object P_0, object P_1)
	{
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}
}
