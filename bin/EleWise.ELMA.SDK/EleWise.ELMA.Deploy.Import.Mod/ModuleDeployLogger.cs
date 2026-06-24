using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Import.Modules;

public sealed class ModuleDeployLogger : ILogger, IDisposable
{
	private readonly ILogger logger;

	private TextWriter writer;

	private readonly LogLevel logLevel;

	private static ModuleDeployLogger W40AtSEMKRDiqVTYK2ta;

	public event EventHandler ConfigurationChanged
	{
		[CompilerGenerated]
		add
		{
			int num = 1;
			int num2 = num;
			EventHandler eventHandler = default(EventHandler);
			EventHandler eventHandler2 = default(EventHandler);
			EventHandler value2 = default(EventHandler);
			while (true)
			{
				switch (num2)
				{
				case 4:
					return;
				default:
					eventHandler = eventHandler2;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					eventHandler2 = this.ConfigurationChanged;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					if ((object)eventHandler2 == eventHandler)
					{
						num2 = 4;
						break;
					}
					goto default;
				case 5:
					eventHandler2 = Interlocked.CompareExchange(ref this.ConfigurationChanged, value2, eventHandler);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 3;
					}
					break;
				case 2:
					value2 = (EventHandler)Delegate.Combine(eventHandler, value);
					num2 = 5;
					break;
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			int num = 3;
			int num2 = num;
			EventHandler eventHandler = default(EventHandler);
			EventHandler value2 = default(EventHandler);
			EventHandler eventHandler2 = default(EventHandler);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 4:
					eventHandler = Interlocked.CompareExchange(ref this.ConfigurationChanged, value2, eventHandler2);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num2 = 5;
					}
					break;
				case 1:
					value2 = (EventHandler)rMLTSfEMnK65CYf8mlyA(eventHandler2, value);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 4;
					}
					break;
				case 2:
					eventHandler2 = eventHandler;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num2 = 0;
					}
					break;
				case 5:
					if ((object)eventHandler == eventHandler2)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 3:
					eventHandler = this.ConfigurationChanged;
					num2 = 2;
					break;
				}
			}
		}
	}

	public ModuleDeployLogger(ILogger logger, TextWriter writer, LogLevel logLevel = LogLevel.Information)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		ONyEH7EMklspvU35NVnn();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 2:
				this.logger = logger;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
				{
					num = 0;
				}
				break;
			default:
				this.writer = writer;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num = 3;
				}
				break;
			case 1:
				return;
			case 3:
				this.logLevel = logLevel;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public void Log(LogLevel level, Exception exception, string format, params object[] args)
	{
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				AGY6bBEM1dQoasZr9xKv(writer, m08EdBEMPOWAkXxcjvpM(new string[6]
				{
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309612194),
					(string)dmS8QKEM2MNBkBggFq0d(level),
					(string)QiHTCGEMe16NQLSAR3wp(0x63ABA4E8 ^ 0x63AF8C78),
					DateTime.Now.ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488647003)),
					(string)QiHTCGEMe16NQLSAR3wp(0x53CB464B ^ 0x53CB85ED),
					text
				}));
				num2 = 4;
				continue;
			case 1:
				logger.Log(level, exception, format, args);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				return;
			case 3:
				return;
			}
			if (level < logLevel)
			{
				num2 = 3;
				continue;
			}
			text = (string)HpcXLhEMOitL1DVOPjBn(format, args ?? Array.Empty<object>());
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
			{
				num2 = 2;
			}
		}
	}

	private static string StringifyLogLevel(LogLevel level)
	{
		//Discarded unreachable code: IL_00c2, IL_00d1
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return (string)QiHTCGEMe16NQLSAR3wp(-951514650 ^ -951208032);
			case 1:
				throw new InvalidOperationException((string)QiHTCGEMe16NQLSAR3wp(-787452571 ^ -787164211));
			case 2:
				{
					switch (level)
					{
					case LogLevel.Verbose:
						break;
					case LogLevel.Trace:
						return (string)QiHTCGEMe16NQLSAR3wp(-541731959 ^ -542020131);
					case LogLevel.Debug:
						return (string)QiHTCGEMe16NQLSAR3wp(-289714582 ^ -289411064);
					case LogLevel.Information:
						return (string)QiHTCGEMe16NQLSAR3wp(0x3CE17B75 ^ 0x3CE5C505);
					case LogLevel.Warning:
						return (string)QiHTCGEMe16NQLSAR3wp(0x48A7E34A ^ 0x48A35D34);
					case LogLevel.Error:
						return (string)QiHTCGEMe16NQLSAR3wp(-1426094279 ^ -1426376267);
					case LogLevel.Fatal:
						return (string)QiHTCGEMe16NQLSAR3wp(0x5F3078B6 ^ 0x5F34C62C);
					default:
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
						{
							num2 = 1;
						}
						goto end_IL_0012;
					}
					goto default;
				}
				end_IL_0012:
				break;
			}
		}
	}

	void IDisposable.Dispose()
	{
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					break;
				case 2:
					mhAqUTEMpCev6LGWJHmq(this);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					xFTSZmEM3YfE0GEX3Ihr(writer);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					writer = null;
					num2 = 2;
					continue;
				case 1:
					return;
				case 4:
					if (writer == null)
					{
						return;
					}
					num2 = 3;
					continue;
				case 3:
					Jn4rqKEMNvevkahesyIt(writer);
					num2 = 6;
					continue;
				}
				break;
			}
			writer.Close();
			num = 5;
		}
	}

	~ModuleDeployLogger()
	{
		//Discarded unreachable code: IL_0045, IL_007c, IL_008f, IL_009e
		switch (1)
		{
		case 1:
			try
			{
				lISf94EMan1NQmvQKQDE(this);
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
				break;
			}
			finally
			{
				wVSZAUEMDXG4YuPaFOaU(this);
				int num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
		case 0:
			break;
		}
	}

	bool ILogger.IsEnabled(LogLevel level)
	{
		return true;
	}

	internal static void ONyEH7EMklspvU35NVnn()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool nWWsEZEMXHdCtgo7Eb62()
	{
		return W40AtSEMKRDiqVTYK2ta == null;
	}

	internal static ModuleDeployLogger PlBVZVEMToDW5eJaNCA6()
	{
		return W40AtSEMKRDiqVTYK2ta;
	}

	internal static object rMLTSfEMnK65CYf8mlyA(object P_0, object P_1)
	{
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	internal static object HpcXLhEMOitL1DVOPjBn(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static object dmS8QKEM2MNBkBggFq0d(LogLevel level)
	{
		return StringifyLogLevel(level);
	}

	internal static object QiHTCGEMe16NQLSAR3wp(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object m08EdBEMPOWAkXxcjvpM(object P_0)
	{
		return string.Concat((string[])P_0);
	}

	internal static void AGY6bBEM1dQoasZr9xKv(object P_0, object P_1)
	{
		((TextWriter)P_0).WriteLine((string)P_1);
	}

	internal static void Jn4rqKEMNvevkahesyIt(object P_0)
	{
		((TextWriter)P_0).Flush();
	}

	internal static void xFTSZmEM3YfE0GEX3Ihr(object P_0)
	{
		((TextWriter)P_0).Dispose();
	}

	internal static void mhAqUTEMpCev6LGWJHmq(object P_0)
	{
		GC.SuppressFinalize(P_0);
	}

	internal static void lISf94EMan1NQmvQKQDE(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void wVSZAUEMDXG4YuPaFOaU(object P_0)
	{
		P_0.Finalize();
	}
}
