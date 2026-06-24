using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Logging;

public static class ScriptLogger
{
	private static ILogger log;

	internal static ScriptLogger VGdROoh996ndudqeXqRu;

	public static ILogger Log
	{
		get
		{
			//Discarded unreachable code: IL_0089, IL_0129, IL_015e, IL_016d, IL_01a9, IL_01e5, IL_01f4
			int num = 3;
			int num2 = num;
			ILogger result = default(ILogger);
			Log4NetFactory log4NetFactory = default(Log4NetFactory);
			while (true)
			{
				switch (num2)
				{
				case 2:
					return (ILogger)UJ7mVgh9gcZ705pscFNT();
				case 3:
					if (OTJssDh9r8D6Nf4LbKbq())
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
						{
							num2 = 1;
						}
					}
					else
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
						{
							num2 = 2;
						}
					}
					break;
				default:
					return result;
				case 1:
					try
					{
						int num3;
						if (log != null)
						{
							num3 = 3;
							goto IL_008d;
						}
						goto IL_00ed;
						IL_008d:
						while (true)
						{
							ILogger instance;
							switch (num3)
							{
							case 6:
								return result;
							case 7:
								log = (ILogger)kK1lG2h9j493nQYxAp45(log4NetFactory, IVDgJxh95GU5vLfcw56e(0x3C5338FF ^ 0x3C526BE1));
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
								{
									num3 = 0;
								}
								continue;
							case 1:
								break;
							case 5:
								if (log4NetFactory == null)
								{
									num3 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
									{
										num3 = 4;
									}
									continue;
								}
								goto case 7;
							default:
								instance = log;
								if (instance == null)
								{
									num3 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
									{
										num3 = 2;
									}
									continue;
								}
								goto IL_017d;
							case 2:
								{
									instance = NullLogger.Instance;
									goto IL_017d;
								}
								IL_017d:
								result = instance;
								num3 = 6;
								continue;
							}
							break;
						}
						goto IL_00ed;
						IL_00ed:
						log4NetFactory = Locator.GetService<ILoggerFactory>() as Log4NetFactory;
						num3 = 5;
						goto IL_008d;
					}
					catch
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								return result;
							}
							result = NullLogger.Instance;
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
							{
								num4 = 0;
							}
						}
					}
				}
			}
		}
	}

	static ScriptLogger()
	{
		TtMMa5h9YAREWwSf7Qj3();
	}

	internal static bool OTJssDh9r8D6Nf4LbKbq()
	{
		return Locator.Initialized;
	}

	internal static object UJ7mVgh9gcZ705pscFNT()
	{
		return NullLogger.Instance;
	}

	internal static object IVDgJxh95GU5vLfcw56e(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object kK1lG2h9j493nQYxAp45(object P_0, object P_1)
	{
		return ((Log4NetFactory)P_0).Create((string)P_1);
	}

	internal static bool vwc9Dhh9d2Uvu4VOvawC()
	{
		return VGdROoh996ndudqeXqRu == null;
	}

	internal static ScriptLogger wbuOuVh9lCm4wvhgiXxH()
	{
		return VGdROoh996ndudqeXqRu;
	}

	internal static void TtMMa5h9YAREWwSf7Qj3()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
